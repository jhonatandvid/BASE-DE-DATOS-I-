
namespace PROYECTO_PROGRAMACION_II
{
    partial class VGClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbxClientes = new System.Windows.Forms.GroupBox();
            this.lblNumRegistros = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscarClient = new System.Windows.Forms.TextBox();
            this.cmbBuscarClient = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dvgClientes = new System.Windows.Forms.DataGridView();
            this.btnDesplegarLista = new System.Windows.Forms.Button();
            this.gbxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 50);
            this.label1.TabIndex = 69;
            this.label1.Text = "CLIENTES";
            // 
            // gbxClientes
            // 
            this.gbxClientes.Controls.Add(this.lblNumRegistros);
            this.gbxClientes.Controls.Add(this.label6);
            this.gbxClientes.Controls.Add(this.txtBuscarClient);
            this.gbxClientes.Controls.Add(this.cmbBuscarClient);
            this.gbxClientes.Controls.Add(this.btnAgregar);
            this.gbxClientes.Controls.Add(this.btnModificar);
            this.gbxClientes.Controls.Add(this.btnEliminar);
            this.gbxClientes.Controls.Add(this.dvgClientes);
            this.gbxClientes.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxClientes.Location = new System.Drawing.Point(5, 56);
            this.gbxClientes.Margin = new System.Windows.Forms.Padding(4);
            this.gbxClientes.Name = "gbxClientes";
            this.gbxClientes.Padding = new System.Windows.Forms.Padding(4);
            this.gbxClientes.Size = new System.Drawing.Size(919, 379);
            this.gbxClientes.TabIndex = 68;
            this.gbxClientes.TabStop = false;
            this.gbxClientes.Text = "LISTA DE CLIENTES";
            // 
            // lblNumRegistros
            // 
            this.lblNumRegistros.AutoSize = true;
            this.lblNumRegistros.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRegistros.Location = new System.Drawing.Point(684, 346);
            this.lblNumRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumRegistros.Name = "lblNumRegistros";
            this.lblNumRegistros.Size = new System.Drawing.Size(15, 17);
            this.lblNumRegistros.TabIndex = 54;
            this.lblNumRegistros.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(495, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "NUMERO DEREGISTROS";
            // 
            // txtBuscarClient
            // 
            this.txtBuscarClient.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarClient.Location = new System.Drawing.Point(350, 37);
            this.txtBuscarClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarClient.Name = "txtBuscarClient";
            this.txtBuscarClient.Size = new System.Drawing.Size(168, 25);
            this.txtBuscarClient.TabIndex = 52;
            // 
            // cmbBuscarClient
            // 
            this.cmbBuscarClient.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarClient.FormattingEnabled = true;
            this.cmbBuscarClient.Items.AddRange(new object[] {
            "Id Cliente",
            "C.I.",
            "Nombre del Cliente",
            "Apellido del Cliente"});
            this.cmbBuscarClient.Location = new System.Drawing.Point(548, 36);
            this.cmbBuscarClient.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBuscarClient.Name = "cmbBuscarClient";
            this.cmbBuscarClient.Size = new System.Drawing.Size(160, 25);
            this.cmbBuscarClient.TabIndex = 51;
            this.cmbBuscarClient.Text = "-- Buscar Por --";
            this.cmbBuscarClient.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarClient_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(8, 69);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 28);
            this.btnAgregar.TabIndex = 39;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(8, 128);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 28);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(8, 192);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 28);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dvgClientes
            // 
            this.dvgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgClientes.Location = new System.Drawing.Point(138, 69);
            this.dvgClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dvgClientes.Name = "dvgClientes";
            this.dvgClientes.RowHeadersWidth = 51;
            this.dvgClientes.Size = new System.Drawing.Size(754, 257);
            this.dvgClientes.TabIndex = 35;
            this.dvgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgClientes_CellContentClick);
            // 
            // btnDesplegarLista
            // 
            this.btnDesplegarLista.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesplegarLista.Location = new System.Drawing.Point(366, 445);
            this.btnDesplegarLista.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesplegarLista.Name = "btnDesplegarLista";
            this.btnDesplegarLista.Size = new System.Drawing.Size(169, 30);
            this.btnDesplegarLista.TabIndex = 67;
            this.btnDesplegarLista.Text = "ACTUALIZAR";
            this.btnDesplegarLista.UseVisualStyleBackColor = true;
            this.btnDesplegarLista.Click += new System.EventHandler(this.btnDesplegarLista_Click);
            // 
            // VGClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxClientes);
            this.Controls.Add(this.btnDesplegarLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VGClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.gbxClientes.ResumeLayout(false);
            this.gbxClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxClientes;
        private System.Windows.Forms.Label lblNumRegistros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscarClient;
        private System.Windows.Forms.ComboBox cmbBuscarClient;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dvgClientes;
        private System.Windows.Forms.Button btnDesplegarLista;
    }
}