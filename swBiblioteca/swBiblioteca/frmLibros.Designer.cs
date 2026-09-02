namespace swBiblioteca
{
    partial class frmLibros
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
            pnlBusqueda = new Panel();
            btnBuscar = new Button();
            txtBuscarISBN = new TextBox();
            lblISBN = new Label();
            pnlDatos = new Panel();
            cmbEditorial = new ComboBox();
            pnlbotones = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            cmbAutor = new ComboBox();
            txtExistencias = new TextBox();
            txtAno = new TextBox();
            txtCategoria = new TextBox();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            lblExistencias = new Label();
            lblCategoria = new Label();
            lblano = new Label();
            lblEditorial = new Label();
            lblSBN2 = new Label();
            txttitulo2 = new Label();
            lblAutor = new Label();
            dgvlibros = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlbotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlibros).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.LightSeaGreen;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1604, 69);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(279, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(313, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE LIBROS ";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.WhiteSmoke;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscarISBN);
            pnlBusqueda.Controls.Add(lblISBN);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 69);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1604, 63);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightSeaGreen;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(682, 23);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(118, 33);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscarISBN
            // 
            txtBuscarISBN.BackColor = Color.White;
            txtBuscarISBN.Location = new Point(279, 25);
            txtBuscarISBN.Name = "txtBuscarISBN";
            txtBuscarISBN.Size = new Size(377, 30);
            txtBuscarISBN.TabIndex = 1;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(198, 29);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(49, 23);
            lblISBN.TabIndex = 0;
            lblISBN.Text = "ISBN";
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(cmbEditorial);
            pnlDatos.Controls.Add(pnlbotones);
            pnlDatos.Controls.Add(cmbAutor);
            pnlDatos.Controls.Add(txtExistencias);
            pnlDatos.Controls.Add(txtAno);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblano);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(lblSBN2);
            pnlDatos.Controls.Add(txttitulo2);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 132);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1604, 351);
            pnlDatos.TabIndex = 2;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(430, 136);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(368, 31);
            cmbEditorial.TabIndex = 17;
            // 
            // pnlbotones
            // 
            pnlbotones.Controls.Add(btnCancelar);
            pnlbotones.Controls.Add(btnEliminar);
            pnlbotones.Controls.Add(btnEditar);
            pnlbotones.Controls.Add(btnGuardar);
            pnlbotones.Controls.Add(btnNuevo);
            pnlbotones.Location = new Point(255, 278);
            pnlbotones.Name = "pnlbotones";
            pnlbotones.Size = new Size(649, 61);
            pnlbotones.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightSeaGreen;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(510, 20);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 33);
            btnCancelar.TabIndex = 4;
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
            btnEliminar.Location = new Point(384, 20);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 33);
            btnEliminar.TabIndex = 3;
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
            btnEditar.Location = new Point(260, 20);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(118, 33);
            btnEditar.TabIndex = 2;
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
            btnGuardar.Location = new Point(136, 20);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(118, 33);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.LightSeaGreen;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.Location = new Point(10, 20);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(118, 33);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(430, 97);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(368, 31);
            cmbAutor.TabIndex = 16;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(430, 242);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(368, 30);
            txtExistencias.TabIndex = 15;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(430, 207);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(368, 30);
            txtAno.TabIndex = 14;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(430, 171);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(368, 30);
            txtCategoria.TabIndex = 13;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(430, 60);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(368, 30);
            txtTitulo.TabIndex = 10;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(430, 24);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(368, 30);
            txtISBN.TabIndex = 9;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Segoe UI", 10.2F);
            lblExistencias.Location = new Point(279, 250);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(91, 23);
            lblExistencias.TabIndex = 8;
            lblExistencias.Text = "Existencias";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 10.2F);
            lblCategoria.Location = new Point(279, 179);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(84, 23);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categoria";
            // 
            // lblano
            // 
            lblano.AutoSize = true;
            lblano.Font = new Font("Segoe UI", 10.2F);
            lblano.Location = new Point(279, 215);
            lblano.Name = "lblano";
            lblano.Size = new Size(41, 23);
            lblano.TabIndex = 5;
            lblano.Text = "Año";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI", 10.2F);
            lblEditorial.Location = new Point(279, 146);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(72, 23);
            lblEditorial.TabIndex = 4;
            lblEditorial.Text = "Editorial";
            lblEditorial.Click += label4_Click;
            // 
            // lblSBN2
            // 
            lblSBN2.AutoSize = true;
            lblSBN2.Font = new Font("Segoe UI", 10.2F);
            lblSBN2.Location = new Point(279, 32);
            lblSBN2.Name = "lblSBN2";
            lblSBN2.Size = new Size(47, 23);
            lblSBN2.TabIndex = 3;
            lblSBN2.Text = "ISBN";
            // 
            // txttitulo2
            // 
            txttitulo2.AutoSize = true;
            txttitulo2.Font = new Font("Segoe UI", 10.2F);
            txttitulo2.Location = new Point(279, 68);
            txttitulo2.Name = "txttitulo2";
            txttitulo2.Size = new Size(53, 23);
            txttitulo2.TabIndex = 2;
            txttitulo2.Text = "Titulo";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 10.2F);
            lblAutor.Location = new Point(279, 108);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(53, 23);
            lblAutor.TabIndex = 1;
            lblAutor.Text = "Autor";
            // 
            // dgvlibros
            // 
            dgvlibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlibros.Location = new Point(107, 506);
            dgvlibros.Name = "dgvlibros";
            dgvlibros.RowHeadersWidth = 51;
            dgvlibros.Size = new Size(958, 152);
            dgvlibros.TabIndex = 9;
            // 
            // frmLibros
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 829);
            Controls.Add(dgvlibros);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "frmLibros";
            Text = "FmrLibros";
            WindowState = FormWindowState.Maximized;
            Load += frmLibros_Load;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlbotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvlibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private Label lblISBN;
        private TextBox txtBuscarISBN;
        private Button btnBuscar;
        private Panel pnlDatos;
        private Label lblEditorial;
        private Label lblSBN2;
        private Label txttitulo2;
        private Label lblAutor;
        private Label lblCategoria;
        private Label lblano;
        private Panel pnlbotones;
        private Label lblExistencias;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private DataGridView dgvlibros;
        private TextBox txtTitulo;
        private TextBox txtISBN;
        private ComboBox cmbEditorial;
        private ComboBox cmbAutor;
        private TextBox txtExistencias;
        private TextBox txtAno;
        private TextBox txtCategoria;
    }
}