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
    public partial class customTextBox : UserControl
    {
        public customTextBox()
        {
            InitializeComponent();
        }

        private void customTextBox_Load(object sender, EventArgs e)
        {
            if (password == true)
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }
        bool isFocused = false;
        private string text = "label";
        private bool pass = false;
        private bool multiline = false;
       

    
        
        public string customText
        {
            get { return text; }
            set { text = value;
                this.Invalidate();
            }

        }
        public bool password
        {
            get { return pass; }
            set { pass = value;
            this.Invalidate();}
        }
        public bool customMultiline
        {
            get { return multiline; }
            set { multiline = value;
            this.Invalidate();}
        }
        private void labelTimer_Tick(object sender, EventArgs e)
        {
            int y = label1.Location.Y;
            if (isFocused == false)
            {
                y -= 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y <= 3)
                {
                    isFocused = true;
                    labelTimer.Stop();
                    label1.Font = new Font("Segoi UI", 8);
                    y = 0;
                    label1.ForeColor = Color.Silver;
                }
            }
            else
            {
                y += 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y >= 32)
                {
                    isFocused = false;
                    labelTimer.Stop();
                    label1.Font = new Font("Segoi UI", 10);
                    y = 32;
                    label1.ForeColor = Color.Black;

                }
            }
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                labelTimer.Start();
            }
        }
        public string Textbox;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Textbox = textBox1.Text;
        } 

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                labelTimer.Start();
            }
        }

        private void customTextBox_Paint(object sender, PaintEventArgs e)
        {
           

            label1.Text = customText;
            if (customMultiline==true)
            {
                textBox1.Multiline = true;
                textBox1.Anchor= AnchorStyles.Top |AnchorStyles.Bottom|AnchorStyles.Left|AnchorStyles.Right;
                textBox1.Height=this.Height;
            }
        
        }
    }
}
