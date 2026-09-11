namespace swBiblioteca
{
    partial class FrmEditoriales
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
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            txtNombre = new TextBox();
            lblNombre = new Label();
            pnlLista = new Panel();
            dgvEditoriales = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).BeginInit();
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
            pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(215, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(388, 41);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "GESTIÓN DE EDITORIALES";
            // 
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.WhiteSmoke;
            pnlDatos.Controls.Add(btnCancelar);
            pnlDatos.Controls.Add(btnEliminar);
            pnlDatos.Controls.Add(btnEditar);
            pnlDatos.Controls.Add(btnGuardar);
            pnlDatos.Controls.Add(btnNuevo);
            pnlDatos.Controls.Add(txtNombre);
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 70);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1348, 300);
            pnlDatos.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightSeaGreen;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(621, 213);
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
            btnEliminar.Location = new Point(485, 213);
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
            btnEditar.Location = new Point(355, 213);
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
            btnGuardar.Location = new Point(222, 213);
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
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.Location = new Point(87, 213);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(118, 33);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(232, 61);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(239, 27);
            txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(104, 65);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // pnlLista
            // 
            pnlLista.BackColor = Color.White;
            pnlLista.Controls.Add(dgvEditoriales);
            pnlLista.Dock = DockStyle.Fill;
            pnlLista.Location = new Point(0, 370);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(1348, 505);
            pnlLista.TabIndex = 3;
            // 
            // dgvEditoriales
            // 
            dgvEditoriales.AllowUserToAddRows = false;
            dgvEditoriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditoriales.Dock = DockStyle.Fill;
            dgvEditoriales.Location = new Point(0, 0);
            dgvEditoriales.Name = "dgvEditoriales";
            dgvEditoriales.ReadOnly = true;
            dgvEditoriales.RowHeadersWidth = 51;
            dgvEditoriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEditoriales.Size = new Size(1348, 505);
            dgvEditoriales.TabIndex = 1;
            dgvEditoriales.CellDoubleClick += dgvEditoriales_CellDoubleClick;
            // 
            // FrmEditoriales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 875);
            Controls.Add(pnlLista);
            Controls.Add(pnlDatos);
            Controls.Add(pnlTitulo);
            Name = "FrmEditoriales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEditoriales";
            WindowState = FormWindowState.Maximized;
            Load += FrmEditoriales_Load;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).EndInit();
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
        private TextBox txtNombre;
        private Label lblNombre;
        private Panel pnlLista;
        private DataGridView dgvEditoriales;
    }
}