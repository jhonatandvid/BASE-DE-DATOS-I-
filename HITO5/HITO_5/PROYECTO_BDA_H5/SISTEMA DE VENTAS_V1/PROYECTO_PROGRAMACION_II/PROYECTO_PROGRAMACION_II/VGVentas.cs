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
    public partial class VGVentas : Form
    {
        VentasDB ven = new VentasDB();

        public VGVentas()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            //VentanaGerente VGPersonal = new VentanaGerente();
            //VGPersonal.Show();
            //this.Close();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            ven.adicionarVenta(Convert.ToString(dvgVentas.Rows[dvgVentas.CurrentRow.Index].Cells[0].Value),

                Convert.ToString(dvgVentas.Rows[dvgVentas.CurrentRow.Index].Cells[1].Value),

                Convert.ToString(dvgVentas.Rows[dvgVentas.CurrentRow.Index].Cells[2].Value),

                Convert.ToString(dvgVentas.Rows[dvgVentas.CurrentRow.Index].Cells[3].Value),

                Convert.ToString(dvgVentas.Rows[dvgVentas.CurrentRow.Index].Cells[4].Value),

                Convert.ToString(dvgVentas.Rows[dvgVentas.CurrentRow.Index].Cells[5].Value));

            ven.listarVentas(out dt, out nr);
            dvgVentas.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            ven.modificarVenta(Convert.ToString(dvgVentas.Rows[dvgVentas.CurrentRow.Index].Cells[0].Value),

                Convert.ToString(dvgVentas.Rows[dvgVentas.CurrentRow.Index].Cells[1].Value),

                Convert.ToString(dvgVentas.Rows[dvgVentas.CurrentRow.Index].Cells[2].Value),

                Convert.ToString(dvgVentas.Rows[dvgVentas.CurrentRow.Index].Cells[3].Value),

                Convert.ToString(dvgVentas.Rows[dvgVentas.CurrentRow.Index].Cells[4].Value),

                Convert.ToString(dvgVentas.Rows[dvgVentas.CurrentRow.Index].Cells[5].Value));

            ven.listarVentas(out dt, out nr);
            dvgVentas.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void dvgVentas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //if (!dvgVentas.Rows[e.RowIndex].IsNewRow)
            //{
            //    dvgVentas.Rows.RemoveAt(e.RowIndex);
            //}
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ven.eliminarVenta(Convert.ToString(dvgVentas.Rows[dvgVentas.CurrentRow.Index].Cells[0].Value));
            dvgVentas.Rows.RemoveAt(dvgVentas.CurrentRow.Index);
        }


        private void btnDesplegarLista_Click(object sender, EventArgs e)
        {
            gbxVentas.Visible = true;

            DataTable dt; int nr = 0;
            ven.listarVentas(out dt, out nr);
            dvgVentas.DataSource = dt;
            if (nr > 0)
                dvgVentas.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;
            switch (cmbBuscar.SelectedIndex)
            {
                case 0:
                    ven.buscarIdVentas(txtBuscar.Text, out dt, out nr);
                    dvgVentas.DataSource = dt;
                    break;
                case 1:
                    ven.buscarIdCliente(txtBuscar.Text, out dt, out nr);
                    dvgVentas.DataSource = dt;
                    break;
                case 2:
                    ven.buscarId_Producto(txtBuscar.Text, out dt, out nr);
                    dvgVentas.DataSource = dt;
                    break;
                case 3:
                    ven.buscarCuenta_a_Pagar(txtBuscar.Text, out dt, out nr);
                    dvgVentas.DataSource = dt;
                    break;
                case 4:
                    ven.buscarCuenta_Pagada(txtBuscar.Text, out dt, out nr);
                    dvgVentas.DataSource = dt;
                    break;
                case 5:
                    ven.buscarTotal_a_Pagar(txtBuscar.Text, out dt, out nr);
                    dvgVentas.DataSource = dt;
                    break;

            }
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void VGVentas_Load(object sender, EventArgs e)
        {
            gbxVentas.Visible = true;

            DataTable dt; int nr = 0;
            ven.listarVentas(out dt, out nr);
            dvgVentas.DataSource = dt;
            if (nr > 0)
                dvgVentas.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        class VentasDB
        {
            public SqlConnection conexion;
            public SqlDataAdapter adaptador;
            public DataTable dt;

            public VentasDB()
            {
                try
                {
                    conexion = new SqlConnection("server=localhost;Database=DB_SistemaDeVentas;integrated security=true"); // PONER LA BASE DE DATOS AQUI este es un EJEMPLO
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

            public void listarVentas(out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PA_MostrarVenta", conexion); // Modificar el PA  
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

            public void eliminarVenta(string id) // CAMBIAR EL INT Y VARIABLE
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Pa_EliminarVenta"; // Modificar el PA
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Ventas", SqlDbType.VarChar).Value = id;  // MODIFICAR EL @id y VARIABLE 

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

            public void adicionarVenta(string id, string idcl, string idpro, string caP, string cP, string tp) // CAMBIAR EL TIPOS DE DATOS "INT,etc" Y VARIABLE segun a lo de la base de datos
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_AdicionarVenta"; // Modificar el PA
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Ventas", SqlDbType.VarChar).Value = id; 
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = idcl; 
                cmd.Parameters.Add("@Id_Productos", SqlDbType.VarChar).Value = idpro; 
                cmd.Parameters.Add("@Cuenta_a_Pagar", SqlDbType.VarChar).Value = caP;
                cmd.Parameters.Add("@Cuenta_Pagada", SqlDbType.VarChar).Value = cP;
                cmd.Parameters.Add("@Total_a_Pagar", SqlDbType.VarChar).Value = tp;

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

            public void modificarVenta(string id, string idcl, string idpro, string caP, string cP, string tp)    // CAMBIAR EL TIPOS DE DATOS "INT,etc" Y VARIABLE segun a lo de la base de datos
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_ModificarVenta"; // MODIFICAR EL PA 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Ventas", SqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = idcl;
                cmd.Parameters.Add("@Id_Productos", SqlDbType.VarChar).Value = idpro;
                cmd.Parameters.Add("@Cuenta_a_Pagar", SqlDbType.VarChar).Value = caP;
                cmd.Parameters.Add("@Cuenta_Pagada", SqlDbType.VarChar).Value = cP;
                cmd.Parameters.Add("@Total_a_Pagar", SqlDbType.VarChar).Value = tp;

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

            public void buscarIdVentas(string nom, out DataTable dataTable, out int numreg) // MODIFICAR EL TIPO DE DATO
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarIdVentas"; // MODIFICAR EL PA
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Id_Ventas", SqlDbType.VarChar).Value = nom; // MODIFICAR EL @ Y VARIABLE

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



            public void buscarIdCliente(string apPaterno, out DataTable dataTable, out int numreg) // MODIFICAR EL TIPO DE DATO Y VARIABLES
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarId_Cliente"; // MODIFICAR EL PA
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = apPaterno; // MODIFICAR EL @ Y VARIABLES

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

            public void buscarId_Producto(string tl, out DataTable dataTable, out int numreg)  // MODIFICAR EL TIPO DE DATO Y VAR
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarId_Productos"; // MODIFICAR EL PA
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Id_Productos", SqlDbType.VarChar).Value = tl; // MODIFICAR EL @

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

            public void buscarCuenta_a_Pagar(string tl, out DataTable dataTable, out int numreg)  // MODIFICAR EL TIPO DE DATO Y VAR
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarCuenta_a_Pagar"; // MODIFICAR EL PA
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Cuenta_a_Pagar", SqlDbType.VarChar).Value = tl; // MODIFICAR EL @

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


            public void buscarCuenta_Pagada(string tl, out DataTable dataTable, out int numreg)  // MODIFICAR EL TIPO DE DATO Y VAR
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarCuenta_Pagada"; // MODIFICAR EL PA
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Cuenta_Pagada", SqlDbType.VarChar).Value = tl; // MODIFICAR EL @

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

            public void buscarTotal_a_Pagar(string tl, out DataTable dataTable, out int numreg)  // MODIFICAR EL TIPO DE DATO Y VAR
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarTotal_a_Pagar"; // MODIFICAR EL PA
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Total_a_Pagar", SqlDbType.VarChar).Value = tl; // MODIFICAR EL @

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
