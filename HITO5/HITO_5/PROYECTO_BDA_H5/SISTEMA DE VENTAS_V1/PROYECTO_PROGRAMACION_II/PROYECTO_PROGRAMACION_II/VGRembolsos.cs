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
    public partial class VGRembolsos : Form
    {
        RembolsoDB remb = new RembolsoDB();

        public VGRembolsos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void VGRembolsos_Load(object sender, EventArgs e)
        {
            gbxRembolsos.Visible = true;

            DataTable dt2; int nr2 = 0;
            remb.listarRembolsos(out dt2, out nr2);
            dvgRembolsos.DataSource = dt2;
            if (nr2 > 0)
                dvgRembolsos.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt2; int nr2 = 0;

            remb.adicionarRembolso(Convert.ToString(dvgRembolsos.Rows[dvgRembolsos.CurrentRow.Index].Cells[0].Value),

                Convert.ToString(dvgRembolsos.Rows[dvgRembolsos.CurrentRow.Index].Cells[1].Value),

                Convert.ToString(dvgRembolsos.Rows[dvgRembolsos.CurrentRow.Index].Cells[2].Value),

                Convert.ToString(dvgRembolsos.Rows[dvgRembolsos.CurrentRow.Index].Cells[3].Value),

                Convert.ToString(dvgRembolsos.Rows[dvgRembolsos.CurrentRow.Index].Cells[4].Value));


            remb.listarRembolsos(out dt2, out nr2);
            dvgRembolsos.DataSource = dt2;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            remb.eliminarRembolso(Convert.ToString(dvgRembolsos.Rows[dvgRembolsos.CurrentRow.Index].Cells[0].Value));
            dvgRembolsos.Rows.RemoveAt(dvgRembolsos.CurrentRow.Index);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataTable dt2; int nr2 = 0;

            remb.modificarRembolso(Convert.ToString(dvgRembolsos.Rows[dvgRembolsos.CurrentRow.Index].Cells[0].Value),

                Convert.ToString(dvgRembolsos.Rows[dvgRembolsos.CurrentRow.Index].Cells[1].Value),

                Convert.ToString(dvgRembolsos.Rows[dvgRembolsos.CurrentRow.Index].Cells[2].Value),

                Convert.ToString(dvgRembolsos.Rows[dvgRembolsos.CurrentRow.Index].Cells[3].Value),

                Convert.ToString(dvgRembolsos.Rows[dvgRembolsos.CurrentRow.Index].Cells[4].Value));


            remb.listarRembolsos(out dt2, out nr2);
            dvgRembolsos.DataSource = dt2;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        private void dvgRembolsos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (!dvgRembolsos.Rows[e.RowIndex].IsNewRow)
            //{
            //    dvgRembolsos.Rows.RemoveAt(e.RowIndex);
            //}
        }


        private void btnActualizarLista_Click(object sender, EventArgs e)
        {
            gbxRembolsos.Visible = true;

            DataTable dt2; int nr2 = 0;
            remb.listarRembolsos(out dt2, out nr2);
            dvgRembolsos.DataSource = dt2;
            if (nr2 > 0)
                dvgRembolsos.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        private void btn_volver_Click(object sender, EventArgs e)
        {
            //VentanaGerente VGPersonal = new VentanaGerente();
            //VGPersonal.Show();
            //this.Close();
        }


        private void cmbBuscarRem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt2; int nr2 = 0;
            switch (cmbBuscarRem.SelectedIndex)
            {
                case 0:
                    remb.buscarId_Rembolsos(txtBuscarRem.Text, out dt2, out nr2);
                    dvgRembolsos.DataSource = dt2;
                    break;
                case 1:
                    remb.buscarId_Cliente(txtBuscarRem.Text, out dt2, out nr2);
                    dvgRembolsos.DataSource = dt2;
                    break;
                case 2:
                    remb.buscarId_Productos_Rembolsados(txtBuscarRem.Text, out dt2, out nr2);
                    dvgRembolsos.DataSource = dt2;
                    break;
                case 3:
                    remb.buscarMontoRemb(txtBuscarRem.Text, out dt2, out nr2);
                    dvgRembolsos.DataSource = dt2;
                    break;
                case 4:
                    remb.buscarMotivo(txtBuscarRem.Text, out dt2, out nr2);
                    dvgRembolsos.DataSource = dt2;
                    break;
            }
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        class RembolsoDB
        {
            public SqlConnection conexion;
            public SqlDataAdapter adaptador;
            public DataTable dt2;

            public RembolsoDB()
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

            public void listarRembolsos(out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PA_MostrarRembolsos", conexion); // Modificar el PA  
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

            public void eliminarRembolso(string id) // CAMBIAR EL INT Y VARIABLE Si Fuera NECESARIO
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Pa_EliminarRembolso"; // Modificar el PA
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Rembolsos", SqlDbType.VarChar).Value = id;  // MODIFICAR EL @id y VARIABLE 

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


            public void adicionarRembolso(string id, string client, string prod, string marc, string montRem) // CAMBIAR EL TIPOS DE DATOS "INT,etc" Y VARIABLE segun a lo de la base de datos
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_AdicionarRembolso"; // Modificar el PA
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Rembolsos", SqlDbType.VarChar).Value = id; 
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = client; 
                cmd.Parameters.Add("@Id_Productos_Rembolsados", SqlDbType.VarChar).Value = prod;
                cmd.Parameters.Add("@Monto_Rembolsado", SqlDbType.VarChar).Value = marc;
                cmd.Parameters.Add("@Motivo", SqlDbType.VarChar).Value = montRem; 
 

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

            public void modificarRembolso(string id, string client, string prod, string marc, string montRem) // CAMBIAR EL TIPOS DE DATOS "INT,etc" Y VARIABLE segun a lo de la base de datos
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_ModificarRembolso"; // Modificar el PA
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Rembolsos", SqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = client;
                cmd.Parameters.Add("@Id_Productos_Rembolsados", SqlDbType.VarChar).Value = prod;
                cmd.Parameters.Add("@Monto_Rembolsado", SqlDbType.VarChar).Value = marc;
                cmd.Parameters.Add("@Motivo", SqlDbType.VarChar).Value = montRem;

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

            public void buscarId_Rembolsos(string clientRem, out DataTable dataTable2, out int numreg2) // MODIFICAR EL TIPO DE DATO
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarId_Rembolsos"; // MODIFICAR EL PA
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Id_Rembolsos", SqlDbType.VarChar).Value = clientRem; // MODIFICAR EL @ Y VARIABLE

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

            public void buscarId_Cliente(string ProdRem, out DataTable dataTable, out int numreg) // MODIFICAR EL TIPO DE DATO Y VARIABLES
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarRemId_Cliente"; // MODIFICAR EL PA
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Id_Cliente", SqlDbType.VarChar).Value = ProdRem; // MODIFICAR EL @ Y VARIABLES

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


            public void buscarId_Productos_Rembolsados(string MarcRem, out DataTable dataTable, out int numreg) // MODIFICAR EL TIPO DE DATO Y VARIABLES
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarId_Productos_Rembolsados"; // MODIFICAR EL PA
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Id_Productos_Rembolsados", SqlDbType.VarChar).Value = MarcRem; // MODIFICAR EL @ Y VARIABLES

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


            public void buscarMontoRemb(string MontRem, out DataTable dataTable, out int numreg) // MODIFICAR EL TIPO DE DATO Y VARIABLES
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarMonto_Rembolsado"; // MODIFICAR EL PA
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Monto_Rembolsado", SqlDbType.VarChar).Value = MontRem; // MODIFICAR EL @ Y VARIABLES

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

            public void buscarMotivo(string MontRem, out DataTable dataTable, out int numreg) // MODIFICAR EL TIPO DE DATO Y VARIABLES
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarMotivo"; // MODIFICAR EL PA
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Motivo", SqlDbType.VarChar).Value = MontRem; // MODIFICAR EL @ Y VARIABLES

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
