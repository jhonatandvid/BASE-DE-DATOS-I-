using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PROGRAMACION_II
{
    public partial class VGInventario : Form
    {
        InventarioBD inv = new InventarioBD();


        public VGInventario()
        {
            InitializeComponent();
        }


        private void VGInventario_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt; int nr = 0;
            inv.listarInventario(out dt, out nr);
            dgvInventario.DataSource = dt;
            if (nr > 0)
                dgvInventario.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            inv.eliminarInvetario(Convert.ToString(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[0].Value));
            dgvInventario.Rows.RemoveAt(dgvInventario.CurrentRow.Index);
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            inv.adicionarInventaio(Convert.ToString(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[0].Value),

                Convert.ToString(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[1].Value),

                Convert.ToString(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[2].Value),

                Convert.ToString(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[3].Value));

            inv.listarInventario(out dt, out nr);
            dgvInventario.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            inv.modificarInventario(Convert.ToString(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[0].Value),

                Convert.ToString(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[1].Value),

                Convert.ToString(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[2].Value),

                Convert.ToString(dgvInventario.Rows[dgvInventario.CurrentRow.Index].Cells[3].Value));

            inv.listarInventario(out dt, out nr);
            dgvInventario.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt; int nr = 0;
            inv.listarInventario(out dt, out nr);
            dgvInventario.DataSource = dt;
            if (nr > 0)
                dgvInventario.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btn_volver_Click_1(object sender, EventArgs e)
        {
            //VentanaGerente VentanaGerente = new VentanaGerente();
            //VentanaGerente.Show();
            //this.Close();
        }


        private void cmbBuscar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;
            switch (cmbBuscar.SelectedIndex)
            {
                case 0:
                    inv.buscarIdInventario(txtBuscar.Text, out dt, out nr);
                    dgvInventario.DataSource = dt;
                    break;
                case 1:
                    inv.buscarIdProducto(txtBuscar.Text, out dt, out nr);
                    dgvInventario.DataSource = dt;
                    break;
                case 2:
                    inv.buscarProducto(txtBuscar.Text, out dt, out nr);
                    dgvInventario.DataSource = dt;
                    break;
                case 3:
                    inv.buscarMarcas(txtBuscar.Text, out dt, out nr);
                    dgvInventario.DataSource = dt;
                    break;
            }
            lblNumRegistros.Text = Convert.ToString(nr);
        }
   

        class InventarioBD
        {
            public SqlConnection conexion;
            public SqlDataAdapter adaptador;
            public DataTable dt;

            public InventarioBD()
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
                    SqlCommand cmd = new SqlCommand("PA_MostrarInventario", conexion);
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

            public void eliminarInvetario(string id)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_EliminarInventario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Inventario", SqlDbType.VarChar).Value = id;

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

            public void adicionarInventaio(string id, string idprod, string Pro, string mar)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_AdicionarInventario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Inventario", SqlDbType.VarChar).Value = id + ' ';
                cmd.Parameters.Add("@Id_Productos", SqlDbType.VarChar).Value = idprod;
                cmd.Parameters.Add("@Productos", SqlDbType.VarChar).Value = Pro;
                cmd.Parameters.Add("@Marcas", SqlDbType.VarChar).Value = mar;

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

            public void modificarInventario(string id, string idprod, string Pro, string mar)   // cambiar por string el id
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_ModificarInventario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Inventario", SqlDbType.VarChar).Value = id;  // Int y modificar bda sino quitar el +1 y ver que pasa
                cmd.Parameters.Add("@Id_Productos", SqlDbType.VarChar).Value = idprod;
                cmd.Parameters.Add("@Productos", SqlDbType.VarChar).Value = Pro;
                cmd.Parameters.Add("@Marcas", SqlDbType.VarChar).Value = mar;


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

            public void buscarIdInventario(string nom, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarIdInventario";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Id_Inventario", SqlDbType.VarChar).Value = nom;

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

            public void buscarIdProducto(string apPaterno, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarIdProducto";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Id_Productos", SqlDbType.VarChar).Value = apPaterno;

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

            public void buscarProducto(string apMaterno, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarProducto";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Productos", SqlDbType.VarChar).Value = apMaterno;

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

            public void buscarMarcas(string ed, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarMarcas";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Marcas", SqlDbType.VarChar).Value = ed;

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


        private void dgvInventario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //if (!dgvInventario.Rows[e.RowIndex].IsNewRow)
            //{
            //    dgvInventario.Rows.RemoveAt(e.RowIndex);
            //}
        }


        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            VGVIProducto PRODUCTO = new VGVIProducto();
            PRODUCTO.Show();
            this.Hide();
        }
    }
}
