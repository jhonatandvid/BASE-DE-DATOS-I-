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
using System.Runtime.InteropServices;


namespace PROYECTO_PROGRAMACION_II
{
    public partial class frm_login_empleado : Form
    {

        string nombre_usuario;
        public frm_login_empleado(string nombrelogin)
        {
            nombre_usuario= nombrelogin;
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg,int wparam,int iparam);

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text += nombre_usuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_INICIO2 inicio1 = new Frm_INICIO2();
            inicio1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtuser.Textbox;
            string pass = txtpass.Textbox;
            logins(user,pass);
        }
    
        public void  logins(string user,string pass)
        {
            try
            {
                string cnn = ("server=localhost;Database=DB_SistemaDeVentas;integrated security=true");
                using (SqlConnection connexion = new SqlConnection(cnn))
                {
                    connexion.Open();
                   // CAMBIAR USUARIO Y PASS
                    using (SqlCommand cmd = new SqlCommand("SELECT Login,Password FROM USERS WHERE Login='" + user + "'and Password ='" + pass + "'", connexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            this.Hide();
                            fmr_bienvenida bienvenida = new fmr_bienvenida(txtuser.Textbox,nombre_usuario);
                            bienvenida.ShowDialog();
                            //fmMenus menu = new fmMenus();
                            //menu.Show();


                        }
                        else
                        {
                            MessageBox.Show("ERROR AL INICIAR SECION");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void txtpass_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtuser_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void frm_login_empleado_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x122, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
