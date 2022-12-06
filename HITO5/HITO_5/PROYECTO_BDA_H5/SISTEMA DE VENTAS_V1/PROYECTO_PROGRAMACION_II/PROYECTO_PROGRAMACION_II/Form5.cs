using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PROGRAMACION_II
{
    public partial class fmr_bienvenida : Form
    {
        string nombre_usuario,menuini;
        public fmr_bienvenida(string user,string menu)
        {
           nombre_usuario = user;
            menuini = menu;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            lblname.Text = nombre_usuario;
            this.Opacity = 0.0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timeOpen.Start();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            circularProgressBar1.Value += 1;
            circularProgressBar1.Text=circularProgressBar1.Value.ToString();    
            if(circularProgressBar1.Value == 100)
            {
                timeOpen.Stop(); 
                timeClose.Start();  
            }
        }

        private void timeClose_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity ==0)
            {
                timeClose.Stop();
                this.Hide();
                fmMenus menu = new fmMenus(menuini);
                menu.ShowDialog();
            }
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }
    }
}
