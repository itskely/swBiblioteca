namespace swBiblioteca
{
    partial class FrmReportes
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlObciones = new Panel();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnGenerar = new FontAwesome.Sharp.IconButton();
            cmbTipoReporte = new ComboBox();
            lblTipoReporte = new Label();
            pnlLista = new Panel();
            dgvReportes = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlObciones.SuspendLayout();
            pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.LightSeaGreen;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1348, 69);
            pnlTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(279, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(348, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE REPORTES";
            // 
            // pnlObciones
            // 
            pnlObciones.BackColor = Color.WhiteSmoke;
            pnlObciones.Controls.Add(btnLimpiar);
            pnlObciones.Controls.Add(btnGenerar);
            pnlObciones.Controls.Add(cmbTipoReporte);
            pnlObciones.Controls.Add(lblTipoReporte);
            pnlObciones.Dock = DockStyle.Top;
            pnlObciones.Location = new Point(0, 69);
            pnlObciones.Name = "pnlObciones";
            pnlObciones.Size = new Size(1348, 240);
            pnlObciones.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.LightSeaGreen;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.Location = new Point(499, 120);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(181, 33);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.LightSeaGreen;
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGenerar.IconColor = Color.Black;
            btnGenerar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGenerar.Location = new Point(312, 120);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(181, 33);
            btnGenerar.TabIndex = 20;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(312, 35);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(368, 28);
            cmbTipoReporte.TabIndex = 19;
            // 
            // lblTipoReporte
            // 
            lblTipoReporte.AutoSize = true;
            lblTipoReporte.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoReporte.Location = new Point(194, 40);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(112, 23);
            lblTipoReporte.TabIndex = 1;
            lblTipoReporte.Text = "Tipo Reporte:";
            // 
            // pnlLista
            // 
            pnlLista.BackColor = Color.White;
            pnlLista.Controls.Add(dgvReportes);
            pnlLista.Dock = DockStyle.Fill;
            pnlLista.Location = new Point(0, 309);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(1348, 566);
            pnlLista.TabIndex = 4;
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Dock = DockStyle.Fill;
            dgvReportes.Location = new Point(0, 0);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowHeadersWidth = 51;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(1348, 566);
            dgvReportes.TabIndex = 2;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 875);
            Controls.Add(pnlLista);
            Controls.Add(pnlObciones);
            Controls.Add(pnlTitulo);
            Name = "FrmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FmrReportes";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlObciones.ResumeLayout(false);
            pnlObciones.PerformLayout();
            pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlObciones;
        private Label lblTipoReporte;
        private ComboBox cmbTipoReporte;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGenerar;
        private Panel pnlLista;
        private DataGridView dgvReportes;
    }
}