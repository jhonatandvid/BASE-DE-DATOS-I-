namespace PROYECTO_PROGRAMACION_II
{
    partial class Frm_INICIO2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_x = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_empleado = new System.Windows.Forms.Button();
            this.btn_gerente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(395, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 35);
            this.label2.TabIndex = 8;
            this.label2.Text = "EMPLEADO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(71, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "GERENTE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.btn_x);
            this.panel1.Controls.Add(this.btn_max);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 37);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_x
            // 
            this.btn_x.FlatAppearance.BorderSize = 0;
            this.btn_x.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.btn_x.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(3)))));
            this.btn_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_x.Image = global::PROYECTO_PROGRAMACION_II.Properties.Resources.close;
            this.btn_x.Location = new System.Drawing.Point(583, 0);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(50, 34);
            this.btn_x.TabIndex = 14;
            this.btn_x.UseVisualStyleBackColor = true;
            this.btn_x.Click += new System.EventHandler(this.btn_x_Click);
            // 
            // btn_max
            // 
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.btn_max.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_max.Image = global::PROYECTO_PROGRAMACION_II.Properties.Resources.min;
            this.btn_max.Location = new System.Drawing.Point(536, 0);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(50, 34);
            this.btn_max.TabIndex = 13;
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_empleado
            // 
            this.btn_empleado.BackColor = System.Drawing.Color.Transparent;
            this.btn_empleado.BackgroundImage = global::PROYECTO_PROGRAMACION_II.Properties.Resources.vendedor__5_;
            this.btn_empleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_empleado.FlatAppearance.BorderSize = 0;
            this.btn_empleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.btn_empleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(121)))), ((int)(((byte)(133)))));
            this.btn_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_empleado.Location = new System.Drawing.Point(364, 107);
            this.btn_empleado.Name = "btn_empleado";
            this.btn_empleado.Size = new System.Drawing.Size(239, 248);
            this.btn_empleado.TabIndex = 6;
            this.btn_empleado.UseVisualStyleBackColor = false;
            this.btn_empleado.Click += new System.EventHandler(this.btn_empleado_Click);
            // 
            // btn_gerente
            // 
            this.btn_gerente.BackColor = System.Drawing.Color.Transparent;
            this.btn_gerente.BackgroundImage = global::PROYECTO_PROGRAMACION_II.Properties.Resources.administrador;
            this.btn_gerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_gerente.FlatAppearance.BorderSize = 0;
            this.btn_gerente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.btn_gerente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(121)))), ((int)(((byte)(133)))));
            this.btn_gerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gerente.Location = new System.Drawing.Point(33, 111);
            this.btn_gerente.Name = "btn_gerente";
            this.btn_gerente.Size = new System.Drawing.Size(239, 240);
            this.btn_gerente.TabIndex = 5;
            this.btn_gerente.UseVisualStyleBackColor = false;
            this.btn_gerente.Click += new System.EventHandler(this.btn_gerente_Click);
            // 
            // Frm_INICIO2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(121)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(630, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_empleado);
            this.Controls.Add(this.btn_gerente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_INICIO2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE VENTAS";
            this.Load += new System.EventHandler(this.Frm_INICIO2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_empleado;
        private System.Windows.Forms.Button btn_gerente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_x;
    }
}