namespace swBiblioteca
{
    partial class FrmUsuarios
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
            lblCorreo = new Label();
            txtTelefono = new TextBox();
            txtDocumento = new TextBox();
            pnlbotones = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            txtCorreo = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDocumento = new Label();
            pnlLista = new Panel();
            dgvUsuarios = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlbotones.SuspendLayout();
            pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.LightSeaGreen;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1348, 70);
            pnlTitulo.TabIndex = 2;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(245, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(352, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "GESTIÓN DE USUARIOS";
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(lblCorreo);
            pnlDatos.Controls.Add(txtTelefono);
            pnlDatos.Controls.Add(txtDocumento);
            pnlDatos.Controls.Add(pnlbotones);
            pnlDatos.Controls.Add(txtCorreo);
            pnlDatos.Controls.Add(txtApellido);
            pnlDatos.Controls.Add(txtNombre);
            pnlDatos.Controls.Add(lblTelefono);
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Controls.Add(lblApellido);
            pnlDatos.Controls.Add(lblDocumento);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 70);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1348, 351);
            pnlDatos.TabIndex = 3;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10.2F);
            lblCorreo.Location = new Point(94, 174);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(66, 23);
            lblCorreo.TabIndex = 20;
            lblCorreo.Text = "Correo:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(245, 135);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(368, 27);
            txtTelefono.TabIndex = 19;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(245, 102);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(368, 27);
            txtDocumento.TabIndex = 18;
            // 
            // pnlbotones
            // 
            pnlbotones.Controls.Add(btnCancelar);
            pnlbotones.Controls.Add(btnEliminar);
            pnlbotones.Controls.Add(btnEditar);
            pnlbotones.Controls.Add(btnGuardar);
            pnlbotones.Controls.Add(btnNuevo);
            pnlbotones.Location = new Point(94, 249);
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
            // txtCorreo
            // 
            txtCorreo.Location = new Point(245, 170);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(368, 27);
            txtCorreo.TabIndex = 13;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(245, 59);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(368, 27);
            txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(245, 23);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(368, 27);
            txtNombre.TabIndex = 9;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 10.2F);
            lblTelefono.Location = new Point(94, 145);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(78, 23);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Telefono:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.2F);
            lblNombre.Location = new Point(94, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 23);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10.2F);
            lblApellido.Location = new Point(94, 67);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(76, 23);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI", 10.2F);
            lblDocumento.Location = new Point(94, 107);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(104, 23);
            lblDocumento.TabIndex = 1;
            lblDocumento.Text = "Documento:";
            // 
            // pnlLista
            // 
            pnlLista.BackColor = Color.White;
            pnlLista.Controls.Add(dgvUsuarios);
            pnlLista.Dock = DockStyle.Fill;
            pnlLista.Location = new Point(0, 421);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(1348, 454);
            pnlLista.TabIndex = 4;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(0, 0);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(1348, 454);
            dgvUsuarios.TabIndex = 1;
            dgvUsuarios.CellDoubleClick += dgvUsuarios_CellDoubleClick;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 875);
            Controls.Add(pnlLista);
            Controls.Add(pnlDatos);
            Controls.Add(pnlTitulo);
            Name = "FrmUsuarios";
            Text = "FmrUsuarios";
            WindowState = FormWindowState.Maximized;
            Load += FrmUsuarios_Load;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlbotones.ResumeLayout(false);
            pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlDatos;
        private ComboBox cmbEditorial;
        private Panel pnlbotones;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private ComboBox cmb;
        private TextBox txtExistencias;
        private TextBox txtAno;
        private TextBox txtCorreo;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblExistencias;
        private Label lblCategoria;
        private Label lblano;
        private Label lblTelefono;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDocumento;
        private TextBox txtDocumento;
        private TextBox txtTelefono;
        private Label lblCorreo;
        private Panel pnlLista;
        private DataGridView dgvUsuarios;
    }
}