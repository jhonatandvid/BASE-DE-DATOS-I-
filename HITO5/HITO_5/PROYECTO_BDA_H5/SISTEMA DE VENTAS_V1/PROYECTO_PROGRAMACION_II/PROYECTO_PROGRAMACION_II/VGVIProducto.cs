using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROYECTO_PROGRAMACION_II
{
    public partial class VGVIProducto : Form
    {
        ProductoBD prod = new ProductoBD();

        public VGVIProducto()
        {
            InitializeComponent();
        }

        private void VGVIProducto_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt; int nr = 0;
            prod.listarInventario(out dt, out nr);
            dgvProducto.DataSource = dt;
            if (nr > 0)
                dgvProducto.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            prod.eliminarProducto(Convert.ToString(dgvProducto.Rows[dgvProducto.CurrentRow.Index].Cells[0].Value));
            dgvProducto.Rows.RemoveAt(dgvProducto.CurrentRow.Index);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            prod.adicionarProducto(Convert.ToString(dgvProducto.Rows[dgvProducto.CurrentRow.Index].Cells[0].Value),

                Convert.ToString(dgvProducto.Rows[dgvProducto.CurrentRow.Index].Cells[1].Value),

                Convert.ToString(dgvProducto.Rows[dgvProducto.CurrentRow.Index].Cells[2].Value),

                Convert.ToString(dgvProducto.Rows[dgvProducto.CurrentRow.Index].Cells[3].Value),

                Convert.ToInt32(dgvProducto.Rows[dgvProducto.CurrentRow.Index].Cells[4].Value));

            prod.listarInventario(out dt, out nr);
            dgvProducto.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            prod.modificarProducto(Convert.ToString(dgvProducto.Rows[dgvProducto.CurrentRow.Index].Cells[0].Value),

                Convert.ToString(dgvProducto.Rows[dgvProducto.CurrentRow.Index].Cells[1].Value),

                Convert.ToString(dgvProducto.Rows[dgvProducto.CurrentRow.Index].Cells[2].Value),

                Convert.ToString(dgvProducto.Rows[dgvProducto.CurrentRow.Index].Cells[3].Value),

                Convert.ToInt32(dgvProducto.Rows[dgvProducto.CurrentRow.Index].Cells[4].Value));

            prod.listarInventario(out dt, out nr);
            dgvProducto.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt; int nr = 0;
            prod.listarInventario(out dt, out nr);
            dgvProducto.DataSource = dt;
            if (nr > 0)
                dgvProducto.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;
            switch (cmbBuscar.SelectedIndex)
            {
                case 0:
                    prod.buscarTIdProducto(txtBuscar.Text, out dt, out nr);
                    dgvProducto.DataSource = dt;
                    break;
                case 1:
                    prod.buscarNombreProducto(txtBuscar.Text, out dt, out nr);
                    dgvProducto.DataSource = dt;
                    break;
                case 2:
                    prod.buscarPrecioProducto(txtBuscar.Text, out dt, out nr);
                    dgvProducto.DataSource = dt;
                    break;
                case 3:
                    prod.buscarMarcaProducto(txtBuscar.Text, out dt, out nr);
                    dgvProducto.DataSource = dt;
                    break;
                case 4:
                    prod.buscarStockProducto(Convert.ToInt32(txtBuscar.Text), out dt, out nr);
                    dgvProducto.DataSource = dt;
                    break;
            }
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btn_volver_Click(object sender, EventArgs e)
        {
            
            VGInventario INVENTARIO = new VGInventario();
            INVENTARIO.Show();
            this.Close();


        }


        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (!dgvProducto.Rows[e.RowIndex].IsNewRow)
            //{
            //    dgvProducto.Rows.RemoveAt(e.RowIndex);
            //}
        }


        class ProductoBD
        {
            public SqlConnection conexion;
            public SqlDataAdapter adaptador;
            public DataTable dt;

            public ProductoBD()
            {
                try
                {
                    conexion = new SqlConnection("server=localhost;Database=DB_SistemaDeVentas;integrated security=true");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

            public void listarInventario(out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PA_MostrarProducto", conexion);
                    adaptador = new SqlDataAdapter(cmd);
                    dt = new DataTable();

                    adaptador.Fill(dt);
                    dataTable = dt;
                    numreg = dt.Rows.Count;
                }
                catch (Exception ex)
                {
                    dataTable = dt;
                    numreg = dt.Rows.Count;

                    MessageBox.Show(ex.Message.ToString());
                }

            }

            public void eliminarProducto(string id)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_EliminarProducto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Producto", SqlDbType.VarChar).Value = id;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                conexion.Close();
            }

            public void adicionarProducto(string id, string nom, string pre, string mar, int Stk)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_AdicionarProducto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Producto", SqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nom;
                cmd.Parameters.Add("@Precio", SqlDbType.VarChar).Value = pre;
                cmd.Parameters.Add("@Marca", SqlDbType.VarChar).Value = mar;
                cmd.Parameters.Add("@Stock", SqlDbType.Int).Value = Stk;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                conexion.Close();
            }

            public void modificarProducto(string id, string nom, string pre, string mar, int Stk)   // cambiar por string el id
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_ModificarProducto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Producto", SqlDbType.VarChar).Value = id;  // Int y modificar bda sino quitar el +1 y ver que pasa
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nom;
                cmd.Parameters.Add("@Precio", SqlDbType.VarChar).Value = pre;
                cmd.Parameters.Add("@Marca", SqlDbType.VarChar).Value = mar;
                cmd.Parameters.Add("@Stock", SqlDbType.Int).Value = Stk;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                conexion.Close();
            }

            public void buscarTIdProducto(string nom, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarTIdProducto";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Id_Producto", SqlDbType.VarChar).Value = nom;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }



                    adaptador = new SqlDataAdapter(cmd);
                    dt = new DataTable();

                    adaptador.Fill(dt);
                    dataTable = dt;
                    numreg = dt.Rows.Count;

                }
                catch (Exception ex)
                {
                    dataTable = dt;
                    numreg = dt.Rows.Count;

                    MessageBox.Show(ex.Message.ToString());
                }
                conexion.Close();
            }

            public void buscarNombreProducto(string apPaterno, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarNombreProducto";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@NombreProducto", SqlDbType.VarChar).Value = apPaterno;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                    adaptador = new SqlDataAdapter(cmd);
                    dt = new DataTable();

                    adaptador.Fill(dt);
                    dataTable = dt;
                    numreg = dt.Rows.Count;
                }
                catch (Exception ex)
                {
                    dataTable = dt;
                    numreg = dt.Rows.Count;

                    MessageBox.Show(ex.Message.ToString());
                }
                conexion.Close();
            }

            public void buscarPrecioProducto(string apMaterno, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarPrecioProducto";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@PrecioProducto", SqlDbType.VarChar).Value = apMaterno;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                    adaptador = new SqlDataAdapter(cmd);
                    dt = new DataTable();

                    adaptador.Fill(dt);
                    dataTable = dt;
                    numreg = dt.Rows.Count;
                }
                catch (Exception ex)
                {
                    dataTable = dt;
                    numreg = dt.Rows.Count;

                    MessageBox.Show(ex.Message.ToString());
                }
                conexion.Close();
            }

            public void buscarMarcaProducto(string ed, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarMarcaProducto";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@MarcaProducto", SqlDbType.VarChar).Value = ed;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                    adaptador = new SqlDataAdapter(cmd);
                    dt = new DataTable();

                    adaptador.Fill(dt);
                    dataTable = dt;
                    numreg = dt.Rows.Count;
                }
                catch (Exception ex)
                {
                    dataTable = dt;
                    numreg = dt.Rows.Count;

                    MessageBox.Show(ex.Message.ToString());
                }
                conexion.Close();
            }


            public void buscarStockProducto(int ed, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarStockProducto";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@StockProducto", SqlDbType.Int).Value = ed;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                    adaptador = new SqlDataAdapter(cmd);
                    dt = new DataTable();

                    adaptador.Fill(dt);
                    dataTable = dt;
                    numreg = dt.Rows.Count;
                }
                catch (Exception ex)
                {
                    dataTable = dt;
                    numreg = dt.Rows.Count;

                    MessageBox.Show(ex.Message.ToString());
                }
                conexion.Close();
            }
        }


    }
}
