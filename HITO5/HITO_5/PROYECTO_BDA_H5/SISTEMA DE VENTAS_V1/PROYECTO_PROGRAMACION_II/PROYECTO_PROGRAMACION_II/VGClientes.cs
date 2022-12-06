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
    public partial class VGClientes : Form
    {
        ClientesDB client = new ClientesDB();

        public VGClientes()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            gbxClientes.Visible = true;

            DataTable dt2; int nr2 = 0;
            client.listarClientes(out dt2, out nr2);
            dvgClientes.DataSource = dt2;
            if (nr2 > 0)
                dvgClientes.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        private void cmbBuscarClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2; int nr2 = 0;
            switch (cmbBuscarClient.SelectedIndex)
            {
                case 0:
                    client.buscaridCliente(txtBuscarClient.Text, out dt2, out nr2);
                    dvgClientes.DataSource = dt2;
                    break;
                case 1:
                    client.buscarci(Convert.ToInt32(txtBuscarClient.Text), out dt2, out nr2);
                    dvgClientes.DataSource = dt2;
                    break;
                case 2:
                    client.buscarNombre_Clientes(txtBuscarClient.Text, out dt2, out nr2);
                    dvgClientes.DataSource = dt2;
                    break;
                case 3:
                    client.buscarApellido_Clientes(txtBuscarClient.Text, out dt2, out nr2);
                    dvgClientes.DataSource = dt2;
                    break;
            }
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt2; int nr2 = 0;

            client.adicionarCliente(Convert.ToString(dvgClientes.Rows[dvgClientes.CurrentRow.Index].Cells[0].Value),

                Convert.ToInt32(dvgClientes.Rows[dvgClientes.CurrentRow.Index].Cells[1].Value),

                Convert.ToString(dvgClientes.Rows[dvgClientes.CurrentRow.Index].Cells[2].Value),

                Convert.ToString(dvgClientes.Rows[dvgClientes.CurrentRow.Index].Cells[3].Value));

            client.listarClientes(out dt2, out nr2);
            dvgClientes.DataSource = dt2;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataTable dt2; int nr2 = 0;

            client.modificarCliente(Convert.ToString(dvgClientes.Rows[dvgClientes.CurrentRow.Index].Cells[0].Value),

                 Convert.ToInt32(dvgClientes.Rows[dvgClientes.CurrentRow.Index].Cells[1].Value),

                 Convert.ToString(dvgClientes.Rows[dvgClientes.CurrentRow.Index].Cells[2].Value),

                 Convert.ToString(dvgClientes.Rows[dvgClientes.CurrentRow.Index].Cells[3].Value));

            client.listarClientes(out dt2, out nr2);
            dvgClientes.DataSource = dt2;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            client.eliminarCliente(Convert.ToString(dvgClientes.Rows[dvgClientes.CurrentRow.Index].Cells[0].Value));
            dvgClientes.Rows.RemoveAt(dvgClientes.CurrentRow.Index);
        }


        private void dvgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (!dvgClientes.Rows[e.RowIndex].IsNewRow)
            //{
            //    dvgClientes.Rows.RemoveAt(e.RowIndex);
            //}
        }


        private void btnDesplegarLista_Click(object sender, EventArgs e)
        {
            gbxClientes.Visible = true;

            DataTable dt2; int nr2 = 0;
            client.listarClientes(out dt2, out nr2);
            dvgClientes.DataSource = dt2;
            if (nr2 > 0)
                dvgClientes.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        class ClientesDB
        {
            public SqlConnection conexion;
            public SqlDataAdapter adaptador;
            public DataTable dt2;

            public ClientesDB()
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

            public void listarClientes(out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PA_MostrarCliente", conexion); // Modificar el PA  
                    adaptador = new SqlDataAdapter(cmd);
                    dt2 = new DataTable();

                    adaptador.Fill(dt2);
                    dataTable = dt2;
                    numreg = dt2.Rows.Count;
                }
                catch (Exception ex)
                {
                    dataTable = dt2;
                    numreg = dt2.Rows.Count;

                    MessageBox.Show(ex.Message.ToString());
                }
            }

            public void eliminarCliente(string id) // CAMBIAR EL INT Y VARIABLE Si Fuera NECESARIO
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Pa_EliminarCliente"; // Modificar el PA
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = id;  // MODIFICAR EL @id y VARIABLE 

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

            public void adicionarCliente(string id, int nom, string apell, string ci) // CAMBIAR EL TIPOS DE DATOS "INT,etc" Y VARIABLE segun a lo de la base de datos
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_AdicionarCliente"; // Modificar el PA
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = id + ' '; 
                cmd.Parameters.Add("@ci", SqlDbType.Int).Value = nom; 
                cmd.Parameters.Add("@Nombre_Clientes", SqlDbType.VarChar).Value = apell; 
                cmd.Parameters.Add("@Apellido_Clientes", SqlDbType.VarChar).Value = ci; 

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

            public void modificarCliente(string id, int nom, string apell, string ci)    // CAMBIAR EL TIPOS DE DATOS "INT,etc" Y VARIABLE segun a lo de la base de datos
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_ModificarCliente"; // MODIFICAR EL PA 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@ci", SqlDbType.Int).Value = nom;
                cmd.Parameters.Add("@Nombre_Clientes", SqlDbType.VarChar).Value = apell;
                cmd.Parameters.Add("@Apellido_Clientes", SqlDbType.VarChar).Value = ci;

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

            public void buscaridCliente(string nombre, out DataTable dataTable2, out int numreg2) // MODIFICAR EL TIPO DE DATO
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_buscarIdCliente"; // MODIFICAR EL PA
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = nombre; // MODIFICAR EL @ Y VARIABLE

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                    adaptador = new SqlDataAdapter(cmd);
                    dt2 = new DataTable();

                    adaptador.Fill(dt2);
                    dataTable2 = dt2;
                    numreg2 = dt2.Rows.Count;

                }
                catch (Exception ex)
                {
                    dataTable2 = dt2;
                    numreg2 = dt2.Rows.Count;

                    MessageBox.Show(ex.Message.ToString());
                }
                conexion.Close();
            }

            public void buscarci(int apClient, out DataTable dataTable, out int numreg) // MODIFICAR EL TIPO DE DATO Y VARIABLES
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_Buscarci"; // MODIFICAR EL PA
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@ci", SqlDbType.Int).Value = apClient; // MODIFICAR EL @ Y VARIABLES

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                    adaptador = new SqlDataAdapter(cmd);
                    dt2 = new DataTable();

                    adaptador.Fill(dt2);
                    dataTable = dt2;
                    numreg = dt2.Rows.Count;
                }
                catch (Exception ex)
                {
                    dataTable = dt2;
                    numreg = dt2.Rows.Count;

                    MessageBox.Show(ex.Message.ToString());
                }
                conexion.Close();
            }

            public void buscarNombre_Clientes(string ci, out DataTable dataTable, out int numreg)  // MODIFICAR EL TIPO DE DATO Y VAR
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_buscarNombre_Clientes"; // MODIFICAR EL PA
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Nombre_Clientes", SqlDbType.VarChar).Value = ci; // MODIFICAR EL @

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                    adaptador = new SqlDataAdapter(cmd);
                    dt2 = new DataTable();

                    adaptador.Fill(dt2);
                    dataTable = dt2;
                    numreg = dt2.Rows.Count;
                }
                catch (Exception ex)
                {
                    dataTable = dt2;
                    numreg = dt2.Rows.Count;

                    MessageBox.Show(ex.Message.ToString());
                }
                conexion.Close();
            }


            public void buscarApellido_Clientes(string ci, out DataTable dataTable, out int numreg)  // MODIFICAR EL TIPO DE DATO Y VAR
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_buscarApellido_Clientes"; // MODIFICAR EL PA
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Apellido_Clientes", SqlDbType.VarChar).Value = ci; // MODIFICAR EL @

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                    adaptador = new SqlDataAdapter(cmd);
                    dt2 = new DataTable();

                    adaptador.Fill(dt2);
                    dataTable = dt2;
                    numreg = dt2.Rows.Count;
                }
                catch (Exception ex)
                {
                    dataTable = dt2;
                    numreg = dt2.Rows.Count;

                    MessageBox.Show(ex.Message.ToString());
                }
                conexion.Close();
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_INICIO2  VGPersonal = new Frm_INICIO2();
            VGPersonal.Show();
        }
    }
}
