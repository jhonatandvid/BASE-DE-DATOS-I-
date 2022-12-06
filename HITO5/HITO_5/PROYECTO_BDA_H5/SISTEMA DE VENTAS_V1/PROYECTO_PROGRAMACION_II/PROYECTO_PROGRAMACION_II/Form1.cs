using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PROYECTO_PROGRAMACION_II
{
    public partial class frm_inicio : Form
    {
  
        public frm_inicio()
        {
            InitializeComponent();
        }

        private void btn_gerente_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
           
        }
    
        private void timeOpen_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
          progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timeOpen.Stop();
                timeClose.Start();
            }
        }

        private void timeClose_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timeClose.Stop();
                //this.Close();
                this.Hide();
                Frm_INICIO2 inicio1 = new Frm_INICIO2();
                inicio1.ShowDialog();
            }
       
           
        }

        private void frm_inicio_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "D:/c#/SISTEMA DE VENTAS_V1/PROYECTO_PROGRAMACION_II/PROYECTO_PROGRAMACION_II/sound/intro.wav";
            player.Play();
            this.Opacity = 0.0;
            timeOpen.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
