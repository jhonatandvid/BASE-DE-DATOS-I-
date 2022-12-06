
namespace PROYECTO_PROGRAMACION_II
{
    partial class VGRembolsos
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
            this.gbxRembolsos = new System.Windows.Forms.GroupBox();
            this.txtBuscarRem = new System.Windows.Forms.TextBox();
            this.cmbBuscarRem = new System.Windows.Forms.ComboBox();
            this.lblNumRegistros = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dvgRembolsos = new System.Windows.Forms.DataGridView();
            this.btnActualizarLista = new System.Windows.Forms.Button();
            this.gbxRembolsos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRembolsos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, -6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 50);
            this.label1.TabIndex = 79;
            this.label1.Text = "REMBOLSOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbxRembolsos
            // 
            this.gbxRembolsos.Controls.Add(this.txtBuscarRem);
            this.gbxRembolsos.Controls.Add(this.cmbBuscarRem);
            this.gbxRembolsos.Controls.Add(this.lblNumRegistros);
            this.gbxRembolsos.Controls.Add(this.label6);
            this.gbxRembolsos.Controls.Add(this.btnAgregar);
            this.gbxRembolsos.Controls.Add(this.btnModificar);
            this.gbxRembolsos.Controls.Add(this.btnEliminar);
            this.gbxRembolsos.Controls.Add(this.dvgRembolsos);
            this.gbxRembolsos.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRembolsos.Location = new System.Drawing.Point(1, 44);
            this.gbxRembolsos.Margin = new System.Windows.Forms.Padding(4);
            this.gbxRembolsos.Name = "gbxRembolsos";
            this.gbxRembolsos.Padding = new System.Windows.Forms.Padding(4);
            this.gbxRembolsos.Size = new System.Drawing.Size(993, 388);
            this.gbxRembolsos.TabIndex = 78;
            this.gbxRembolsos.TabStop = false;
            this.gbxRembolsos.Text = "LISTA DE REEMBOLSOS";
            // 
            // txtBuscarRem
            // 
            this.txtBuscarRem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarRem.Location = new System.Drawing.Point(488, 15);
            this.txtBuscarRem.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarRem.Name = "txtBuscarRem";
            this.txtBuscarRem.Size = new System.Drawing.Size(168, 25);
            this.txtBuscarRem.TabIndex = 56;
            // 
            // cmbBuscarRem
            // 
            this.cmbBuscarRem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuscarRem.FormattingEnabled = true;
            this.cmbBuscarRem.Items.AddRange(new object[] {
            "Id_Rembolsos ",
            "Id_Cliente ",
            "Id_Productos_Rembolsados ",
            "Monto_Rembolsado",
            "Motivo Varchar"});
            this.cmbBuscarRem.Location = new System.Drawing.Point(754, 15);
            this.cmbBuscarRem.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBuscarRem.Name = "cmbBuscarRem";
            this.cmbBuscarRem.Size = new System.Drawing.Size(160, 25);
            this.cmbBuscarRem.TabIndex = 55;
            this.cmbBuscarRem.Text = "-- Buscar Por --";
            this.cmbBuscarRem.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarRem_SelectedIndexChanged_1);
            // 
            // lblNumRegistros
            // 
            this.lblNumRegistros.AutoSize = true;
            this.lblNumRegistros.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRegistros.Location = new System.Drawing.Point(851, 363);
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
            this.label6.Location = new System.Drawing.Point(661, 363);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "NUMERO DEREGISTROS";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(8, 70);
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
            this.btnModificar.Location = new System.Drawing.Point(8, 129);
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
            this.btnEliminar.Location = new System.Drawing.Point(8, 193);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 28);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dvgRembolsos
            // 
            this.dvgRembolsos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRembolsos.Location = new System.Drawing.Point(157, 69);
            this.dvgRembolsos.Margin = new System.Windows.Forms.Padding(4);
            this.dvgRembolsos.Name = "dvgRembolsos";
            this.dvgRembolsos.RowHeadersWidth = 51;
            this.dvgRembolsos.Size = new System.Drawing.Size(796, 277);
            this.dvgRembolsos.TabIndex = 35;
            this.dvgRembolsos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgRembolsos_CellContentClick);
            // 
            // btnActualizarLista
            // 
            this.btnActualizarLista.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarLista.Location = new System.Drawing.Point(436, 432);
            this.btnActualizarLista.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarLista.Name = "btnActualizarLista";
            this.btnActualizarLista.Size = new System.Drawing.Size(169, 30);
            this.btnActualizarLista.TabIndex = 77;
            this.btnActualizarLista.Text = "ACTUALIZAR";
            this.btnActualizarLista.UseVisualStyleBackColor = true;
            this.btnActualizarLista.Click += new System.EventHandler(this.btnActualizarLista_Click);
            // 
            // VGRembolsos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxRembolsos);
            this.Controls.Add(this.btnActualizarLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VGRembolsos";
            this.Text = "Rembolsos";
            this.Load += new System.EventHandler(this.VGRembolsos_Load);
            this.gbxRembolsos.ResumeLayout(false);
            this.gbxRembolsos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRembolsos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxRembolsos;
        private System.Windows.Forms.TextBox txtBuscarRem;
        private System.Windows.Forms.ComboBox cmbBuscarRem;
        private System.Windows.Forms.Label lblNumRegistros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dvgRembolsos;
        private System.Windows.Forms.Button btnActualizarLista;
    }
}