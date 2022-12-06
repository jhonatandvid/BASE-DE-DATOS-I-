
namespace PROYECTO_PROGRAMACION_II
{
    partial class VGVentas
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
            this.gbxVentas = new System.Windows.Forms.GroupBox();
            this.lblNumRegistros = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dvgVentas = new System.Windows.Forms.DataGridView();
            this.btnDesplegarLista = new System.Windows.Forms.Button();
            this.gbxVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 59);
            this.label1.TabIndex = 57;
            this.label1.Text = "VENTAS";
            // 
            // gbxVentas
            // 
            this.gbxVentas.Controls.Add(this.lblNumRegistros);
            this.gbxVentas.Controls.Add(this.label6);
            this.gbxVentas.Controls.Add(this.txtBuscar);
            this.gbxVentas.Controls.Add(this.cmbBuscar);
            this.gbxVentas.Controls.Add(this.btnAgregar);
            this.gbxVentas.Controls.Add(this.btnModificar);
            this.gbxVentas.Controls.Add(this.btnEliminar);
            this.gbxVentas.Controls.Add(this.dvgVentas);
            this.gbxVentas.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVentas.Location = new System.Drawing.Point(3, 69);
            this.gbxVentas.Margin = new System.Windows.Forms.Padding(4);
            this.gbxVentas.Name = "gbxVentas";
            this.gbxVentas.Padding = new System.Windows.Forms.Padding(4);
            this.gbxVentas.Size = new System.Drawing.Size(849, 338);
            this.gbxVentas.TabIndex = 56;
            this.gbxVentas.TabStop = false;
            this.gbxVentas.Text = "Lista de Ventas";
            // 
            // lblNumRegistros
            // 
            this.lblNumRegistros.AutoSize = true;
            this.lblNumRegistros.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRegistros.Location = new System.Drawing.Point(588, 307);
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
            this.label6.Location = new System.Drawing.Point(399, 307);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "NUMERO DEREGISTROS";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(335, 18);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(168, 25);
            this.txtBuscar.TabIndex = 52;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "Id_Ventas ",
            "Id_Cliente ",
            "Id_Producto",
            "Cuenta_a_Pagar ",
            "Cuenta_Pagada ",
            "Total_a_Pagar"});
            this.cmbBuscar.Location = new System.Drawing.Point(532, 17);
            this.cmbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(160, 25);
            this.cmbBuscar.TabIndex = 51;
            this.cmbBuscar.Text = "-- Buscar Por --";
            this.cmbBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBuscar_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(35, 52);
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
            this.btnModificar.Location = new System.Drawing.Point(35, 111);
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
            this.btnEliminar.Location = new System.Drawing.Point(35, 175);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 28);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dvgVentas
            // 
            this.dvgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVentas.Location = new System.Drawing.Point(192, 47);
            this.dvgVentas.Margin = new System.Windows.Forms.Padding(4);
            this.dvgVentas.Name = "dvgVentas";
            this.dvgVentas.RowHeadersWidth = 51;
            this.dvgVentas.Size = new System.Drawing.Size(592, 250);
            this.dvgVentas.TabIndex = 35;
            this.dvgVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgVentas_CellContentClick_1);
            // 
            // btnDesplegarLista
            // 
            this.btnDesplegarLista.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesplegarLista.Location = new System.Drawing.Point(353, 412);
            this.btnDesplegarLista.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesplegarLista.Name = "btnDesplegarLista";
            this.btnDesplegarLista.Size = new System.Drawing.Size(141, 28);
            this.btnDesplegarLista.TabIndex = 55;
            this.btnDesplegarLista.Text = "ACTUALIZAR";
            this.btnDesplegarLista.UseVisualStyleBackColor = true;
            this.btnDesplegarLista.Click += new System.EventHandler(this.btnDesplegarLista_Click);
            // 
            // VGVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxVentas);
            this.Controls.Add(this.btnDesplegarLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VGVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.VGVentas_Load);
            this.gbxVentas.ResumeLayout(false);
            this.gbxVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxVentas;
        private System.Windows.Forms.Label lblNumRegistros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dvgVentas;
        private System.Windows.Forms.Button btnDesplegarLista;
    }
}