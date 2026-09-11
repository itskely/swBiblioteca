namespace swBiblioteca
{
    partial class FrmPrestamos
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
            pnlDatos = new Panel();
            dtpFechaDevolucion = new DateTimePicker();
            dtpFechaPrestamo = new DateTimePicker();
            lblFechadevolucion = new Label();
            lblFechaprestamo = new Label();
            cmbLibros = new ComboBox();
            cmbUsuario = new ComboBox();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            lblLibro = new Label();
            lblUsuario = new Label();
            panel1 = new Panel();
            dgvPrestamos = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pnlTitulo.SuspendLayout();
            pnlDatos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
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
            pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(279, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(386, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTIÓN DE PRÉSTAMOS ";
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.WhiteSmoke;
            pnlDatos.Controls.Add(dtpFechaDevolucion);
            pnlDatos.Controls.Add(dtpFechaPrestamo);
            pnlDatos.Controls.Add(lblFechadevolucion);
            pnlDatos.Controls.Add(lblFechaprestamo);
            pnlDatos.Controls.Add(cmbLibros);
            pnlDatos.Controls.Add(cmbUsuario);
            pnlDatos.Controls.Add(btnCancelar);
            pnlDatos.Controls.Add(btnEliminar);
            pnlDatos.Controls.Add(btnEditar);
            pnlDatos.Controls.Add(btnGuardar);
            pnlDatos.Controls.Add(btnNuevo);
            pnlDatos.Controls.Add(lblLibro);
            pnlDatos.Controls.Add(lblUsuario);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 69);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1348, 300);
            pnlDatos.TabIndex = 2;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Checked = false;
            dtpFechaDevolucion.Location = new Point(297, 164);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.ShowCheckBox = true;
            dtpFechaDevolucion.Size = new Size(368, 27);
            dtpFechaDevolucion.TabIndex = 23;
            dtpFechaDevolucion.Visible = false;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Location = new Point(293, 118);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(368, 27);
            dtpFechaPrestamo.TabIndex = 22;
            // 
            // lblFechadevolucion
            // 
            lblFechadevolucion.AutoSize = true;
            lblFechadevolucion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechadevolucion.Location = new Point(139, 168);
            lblFechadevolucion.Name = "lblFechadevolucion";
            lblFechadevolucion.Size = new Size(148, 23);
            lblFechadevolucion.TabIndex = 20;
            lblFechadevolucion.Text = "Fecha Devolución:";
            // 
            // lblFechaprestamo
            // 
            lblFechaprestamo.AutoSize = true;
            lblFechaprestamo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaprestamo.Location = new Point(138, 122);
            lblFechaprestamo.Name = "lblFechaprestamo";
            lblFechaprestamo.Size = new Size(135, 23);
            lblFechaprestamo.TabIndex = 19;
            lblFechaprestamo.Text = "Fecha prestamo:";
            // 
            // cmbLibros
            // 
            cmbLibros.FormattingEnabled = true;
            cmbLibros.Location = new Point(293, 75);
            cmbLibros.Name = "cmbLibros";
            cmbLibros.Size = new Size(368, 28);
            cmbLibros.TabIndex = 18;
            // 
            // cmbUsuario
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(293, 23);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(368, 28);
            cmbUsuario.TabIndex = 17;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightSeaGreen;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(657, 235);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 33);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightSeaGreen;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(521, 235);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 33);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LightSeaGreen;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(391, 235);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(118, 33);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LightSeaGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(258, 235);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 33);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.LightSeaGreen;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.Location = new Point(123, 235);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(118, 33);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLibro.Location = new Point(138, 76);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(52, 23);
            lblLibro.TabIndex = 1;
            lblLibro.Text = "Libro:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(139, 28);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(72, 23);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dgvPrestamos);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 369);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 506);
            panel1.TabIndex = 3;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Dock = DockStyle.Fill;
            dgvPrestamos.Location = new Point(0, 0);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(1348, 506);
            dgvPrestamos.TabIndex = 1;
            dgvPrestamos.CellDoubleClick += dgvPrestamos_CellDoubleClick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 875);
            Controls.Add(panel1);
            Controls.Add(pnlDatos);
            Controls.Add(pnlTitulo);
            Name = "FrmPrestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FmrPrestamos";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlDatos;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private TextBox txtApellido;
        private TextBox tx;
        private Label lblLibro;
        private Label lblUsuario;
        private Panel panel1;
        private ComboBox cmbUsuario;
        private ComboBox cmbLibros;
        private Label lblFechadevolucion;
        private Label lblFechaprestamo;
        private DateTimePicker dtpFechaDevolucion;
        private DateTimePicker dtpFechaPrestamo;
        private DataGridView dgvPrestamos;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}