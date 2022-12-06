namespace PROYECTO_PROGRAMACION_II
{
    partial class fmMenus
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
            this.components = new System.ComponentModel.Container();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.barra = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_x = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnRembolso = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.barra.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 5;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.barra.Controls.Add(this.label1);
            this.barra.Controls.Add(this.pictureBox1);
            this.barra.Controls.Add(this.btn_x);
            this.barra.Controls.Add(this.btn_max);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(200, 0);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(950, 63);
            this.barra.TabIndex = 5;
            this.barra.Paint += new System.Windows.Forms.PaintEventHandler(this.barra_Paint);
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_MouseDown);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(47)))), ((int)(((byte)(71)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel15);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 550);
            this.sidebar.MinimumSize = new System.Drawing.Size(63, 469);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(200, 550);
            this.sidebar.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInicio);
            this.panel2.Location = new System.Drawing.Point(1, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 50);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnInventario);
            this.panel3.Location = new System.Drawing.Point(1, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 50);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnVentas);
            this.panel4.Location = new System.Drawing.Point(1, 181);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 50);
            this.panel4.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCliente);
            this.panel6.Location = new System.Drawing.Point(1, 237);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 50);
            this.panel6.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnRembolso);
            this.panel5.Location = new System.Drawing.Point(1, 293);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 50);
            this.panel5.TabIndex = 29;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnPersonal);
            this.panel7.Location = new System.Drawing.Point(1, 349);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 50);
            this.panel7.TabIndex = 30;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.panel15.Controls.Add(this.menuButton);
            this.panel15.Controls.Add(this.label3);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(200, 63);
            this.panel15.TabIndex = 16;
            this.panel15.Paint += new System.Windows.Forms.PaintEventHandler(this.panel15_Paint);
            this.panel15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel15_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(74, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 497);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 50);
            this.panel1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "SPARTAN GAME SHOP";
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 63);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(950, 487);
            this.panelContenedor.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_PROGRAMACION_II.Properties.Resources.Spartan_Game_Shop_Logo___Original___5000x5000_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-45, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btn_x
            // 
            this.btn_x.FlatAppearance.BorderSize = 0;
            this.btn_x.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.btn_x.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(3)))));
            this.btn_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_x.Image = global::PROYECTO_PROGRAMACION_II.Properties.Resources.close;
            this.btn_x.Location = new System.Drawing.Point(897, 0);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(50, 34);
            this.btn_x.TabIndex = 16;
            this.btn_x.UseVisualStyleBackColor = true;
            this.btn_x.Click += new System.EventHandler(this.btn_x_Click_1);
            // 
            // btn_max
            // 
            this.btn_max.FlatAppearance.BorderSize = 0;
            this.btn_max.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.btn_max.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_max.Image = global::PROYECTO_PROGRAMACION_II.Properties.Resources.min;
            this.btn_max.Location = new System.Drawing.Point(850, 0);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(50, 34);
            this.btn_max.TabIndex = 15;
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click_1);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Image = global::PROYECTO_PROGRAMACION_II.Properties.Resources.globe;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-22, -13);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(232, 73);
            this.button1.TabIndex = 8;
            this.button1.Text = "        Cerrar secion";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInicio.Image = global::PROYECTO_PROGRAMACION_II.Properties.Resources.home__3_;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(-22, -12);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(232, 73);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "            Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInventario.Image = global::PROYECTO_PROGRAMACION_II.Properties.Resources.inventario;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(-22, -12);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(232, 73);
            this.btnInventario.TabIndex = 8;
            this.btnInventario.Text = "            Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVentas.Image = global::PROYECTO_PROGRAMACION_II.Properties.Resources.ventas;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(-22, -12);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(232, 73);
            this.btnVentas.TabIndex = 8;
            this.btnVentas.Text = "            Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCliente.Image = global::PROYECTO_PROGRAMACION_II.Properties.Resources.clientes;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(-22, -12);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnCliente.Size = new System.Drawing.Size(232, 73);
            this.btnCliente.TabIndex = 8;
            this.btnCliente.Text = "            Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnRembolso
            // 
            this.btnRembolso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRembolso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRembolso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRembolso.Image = global::PROYECTO_PROGRAMACION_II.Properties.Resources.reembolsos;
            this.btnRembolso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRembolso.Location = new System.Drawing.Point(-22, -12);
            this.btnRembolso.Name = "btnRembolso";
            this.btnRembolso.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnRembolso.Size = new System.Drawing.Size(232, 73);
            this.btnRembolso.TabIndex = 8;
            this.btnRembolso.Text = "            Reembolso";
            this.btnRembolso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRembolso.UseVisualStyleBackColor = true;
            this.btnRembolso.Click += new System.EventHandler(this.btnRembolso_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPersonal.Image = global::PROYECTO_PROGRAMACION_II.Properties.Resources.empleado;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Location = new System.Drawing.Point(-22, -12);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnPersonal.Size = new System.Drawing.Size(232, 73);
            this.btnPersonal.TabIndex = 8;
            this.btnPersonal.Text = "            Personal";
            this.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.BackgroundImage = global::PROYECTO_PROGRAMACION_II.Properties.Resources.menu;
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Location = new System.Drawing.Point(11, 14);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(34, 31);
            this.menuButton.TabIndex = 7;
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.button14_Click_1);
            this.menuButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button14_MouseDown);
            // 
            // fmMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 550);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmMenus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMEA DE VENTAS";
            this.Load += new System.EventHandler(this.fmMenus_Load);
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel barra;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRembolso;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContenedor;
    }
}