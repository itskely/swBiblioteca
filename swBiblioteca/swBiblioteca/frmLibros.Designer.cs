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
            txtBuscar = new TextBox();
            lblISBN = new Label();
            pnlDatos = new Panel();
            bxcEditorial = new ComboBox();
            bxcAutor = new ComboBox();
            bxexistencias = new TextBox();
            bxano = new TextBox();
            bxcategoria = new TextBox();
            bxtitulo = new TextBox();
            bxisbn = new TextBox();
            txtexistencias = new Label();
            panel1 = new Panel();
            txtcategoria = new Label();
            txtano = new Label();
            txteditorial = new Label();
            txtisbn = new Label();
            txttitulo = new Label();
            txtautor = new Label();
            pnlbotones = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
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
            pnlTitulo.Size = new Size(1348, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(223, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(313, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE LIBROS ";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.WhiteSmoke;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(lblISBN);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1348, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(546, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(223, 22);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(303, 27);
            txtBuscar.TabIndex = 1;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(158, 25);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(41, 20);
            lblISBN.TabIndex = 0;
            lblISBN.Text = "ISBN";
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(bxcEditorial);
            pnlDatos.Controls.Add(bxcAutor);
            pnlDatos.Controls.Add(bxexistencias);
            pnlDatos.Controls.Add(bxano);
            pnlDatos.Controls.Add(bxcategoria);
            pnlDatos.Controls.Add(bxtitulo);
            pnlDatos.Controls.Add(bxisbn);
            pnlDatos.Controls.Add(txtexistencias);
            pnlDatos.Controls.Add(panel1);
            pnlDatos.Controls.Add(txtcategoria);
            pnlDatos.Controls.Add(txtano);
            pnlDatos.Controls.Add(txteditorial);
            pnlDatos.Controls.Add(txtisbn);
            pnlDatos.Controls.Add(txttitulo);
            pnlDatos.Controls.Add(txtautor);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 115);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1348, 256);
            pnlDatos.TabIndex = 2;
            // 
            // bxcEditorial
            // 
            bxcEditorial.FormattingEnabled = true;
            bxcEditorial.Location = new Point(344, 118);
            bxcEditorial.Name = "bxcEditorial";
            bxcEditorial.Size = new Size(296, 28);
            bxcEditorial.TabIndex = 17;
            // 
            // bxcAutor
            // 
            bxcAutor.FormattingEnabled = true;
            bxcAutor.Location = new Point(344, 84);
            bxcAutor.Name = "bxcAutor";
            bxcAutor.Size = new Size(296, 28);
            bxcAutor.TabIndex = 16;
            // 
            // bxexistencias
            // 
            bxexistencias.Location = new Point(344, 210);
            bxexistencias.Name = "bxexistencias";
            bxexistencias.Size = new Size(296, 27);
            bxexistencias.TabIndex = 15;
            // 
            // bxano
            // 
            bxano.Location = new Point(344, 180);
            bxano.Name = "bxano";
            bxano.Size = new Size(296, 27);
            bxano.TabIndex = 14;
            // 
            // bxcategoria
            // 
            bxcategoria.Location = new Point(344, 149);
            bxcategoria.Name = "bxcategoria";
            bxcategoria.Size = new Size(296, 27);
            bxcategoria.TabIndex = 13;
            // 
            // bxtitulo
            // 
            bxtitulo.Location = new Point(344, 52);
            bxtitulo.Name = "bxtitulo";
            bxtitulo.Size = new Size(296, 27);
            bxtitulo.TabIndex = 10;
            // 
            // bxisbn
            // 
            bxisbn.Location = new Point(344, 21);
            bxisbn.Name = "bxisbn";
            bxisbn.Size = new Size(296, 27);
            bxisbn.TabIndex = 9;
            // 
            // txtexistencias
            // 
            txtexistencias.AutoSize = true;
            txtexistencias.Location = new Point(223, 217);
            txtexistencias.Name = "txtexistencias";
            txtexistencias.Size = new Size(80, 20);
            txtexistencias.TabIndex = 8;
            txtexistencias.Text = "Existencias";
            // 
            // panel1
            // 
            panel1.Location = new Point(154, 262);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 7;
            // 
            // txtcategoria
            // 
            txtcategoria.AutoSize = true;
            txtcategoria.Location = new Point(223, 156);
            txtcategoria.Name = "txtcategoria";
            txtcategoria.Size = new Size(74, 20);
            txtcategoria.TabIndex = 6;
            txtcategoria.Text = "Categoria";
            // 
            // txtano
            // 
            txtano.AutoSize = true;
            txtano.Location = new Point(223, 187);
            txtano.Name = "txtano";
            txtano.Size = new Size(36, 20);
            txtano.TabIndex = 5;
            txtano.Text = "Año";
            // 
            // txteditorial
            // 
            txteditorial.AutoSize = true;
            txteditorial.Location = new Point(223, 127);
            txteditorial.Name = "txteditorial";
            txteditorial.Size = new Size(65, 20);
            txteditorial.TabIndex = 4;
            txteditorial.Text = "Editorial";
            txteditorial.Click += label4_Click;
            // 
            // txtisbn
            // 
            txtisbn.AutoSize = true;
            txtisbn.Location = new Point(223, 28);
            txtisbn.Name = "txtisbn";
            txtisbn.Size = new Size(41, 20);
            txtisbn.TabIndex = 3;
            txtisbn.Text = "ISBN";
            // 
            // txttitulo
            // 
            txttitulo.AutoSize = true;
            txttitulo.Location = new Point(223, 59);
            txttitulo.Name = "txttitulo";
            txttitulo.Size = new Size(47, 20);
            txttitulo.TabIndex = 2;
            txttitulo.Text = "Titulo";
            // 
            // txtautor
            // 
            txtautor.AutoSize = true;
            txtautor.Location = new Point(223, 94);
            txtautor.Name = "txtautor";
            txtautor.Size = new Size(46, 20);
            txtautor.TabIndex = 1;
            txtautor.Text = "Autor";
            // 
            // pnlbotones
            // 
            pnlbotones.Controls.Add(btnCancelar);
            pnlbotones.Controls.Add(btnEliminar);
            pnlbotones.Controls.Add(btnEditar);
            pnlbotones.Controls.Add(btnGuardar);
            pnlbotones.Controls.Add(btnNuevo);
            pnlbotones.Location = new Point(158, 380);
            pnlbotones.Name = "pnlbotones";
            pnlbotones.Size = new Size(519, 65);
            pnlbotones.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(408, 17);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(308, 17);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(208, 17);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(108, 17);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.Location = new Point(8, 17);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvlibros
            // 
            dgvlibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlibros.Location = new Point(12, 451);
            dgvlibros.Name = "dgvlibros";
            dgvlibros.RowHeadersWidth = 51;
            dgvlibros.Size = new Size(852, 169);
            dgvlibros.TabIndex = 9;
            // 
            // frmLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(dgvlibros);
            Controls.Add(pnlbotones);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
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
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Panel pnlDatos;
        private Label txteditorial;
        private Label txtisbn;
        private Label txttitulo;
        private Label txtautor;
        private Label txtcategoria;
        private Label txtano;
        private Panel panel1;
        private Panel pnlbotones;
        private Label txtexistencias;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private DataGridView dgvlibros;
        private TextBox bxtitulo;
        private TextBox bxisbn;
        private ComboBox bxcEditorial;
        private ComboBox bxcAutor;
        private TextBox bxexistencias;
        private TextBox bxano;
        private TextBox bxcategoria;
    }
}