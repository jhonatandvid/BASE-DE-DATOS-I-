using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace PROYECTO_PROGRAMACION_II
{
    public partial class Frm_INICIO2 : Form
    {
        public Frm_INICIO2()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int iparam);

        string var;
        private void btn_gerente_Click(object sender, EventArgs e)
        {
            btn_gerente.Text = var;
                var="GERENTE";
            this.Hide();
            frm_login_empleado login_emp = new frm_login_empleado(var);
            login_emp.ShowDialog();
            //frm_login_administrador login_ger = new frm_login_administrador();
            //login_ger.ShowDialog();
        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            btn_empleado.Text = var;
            var="EMPLEADO";
            this.Hide();
            frm_login_empleado login_emp = new frm_login_empleado(var);
            login_emp.ShowDialog();
        }
        class custombtnov : Button
        {
            protected override void OnPaint(PaintEventArgs pevent)
            {
                GraphicsPath path= new GraphicsPath();
                path.AddEllipse(0,0,ClientSize.Width,ClientSize.Height);
                this.Region = new System.Drawing.Region(path);
                base.OnPaint(pevent);
            }
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            //minimizar xd error mio
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
          
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            //maximizar xd
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_INICIO2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
