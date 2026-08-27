namespace swBiblioteca
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            pnlMenu = new Panel();
            pnlLogo = new Panel();
            imgLogo = new PictureBox();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlSuperior = new Panel();
            pnlEstado = new Panel();
            pnlCcontenido = new Panel();
            btnInicio = new Button();
            btnLibros = new Button();
            btnUsuarios = new Button();
            btnAutores = new Button();
            btnEditoriales = new Button();
            btnPrestamos = new Button();
            btnReportes = new Button();
            btnSalida = new Button();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.White;
            pnlMenu.Controls.Add(btnSalida);
            pnlMenu.Controls.Add(btnReportes);
            pnlMenu.Controls.Add(btnPrestamos);
            pnlMenu.Controls.Add(btnEditoriales);
            pnlMenu.Controls.Add(btnAutores);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnLibros);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(244, 538);
            pnlMenu.TabIndex = 0;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.LightSeaGreen;
            pnlLogo.Controls.Add(imgLogo);
            pnlLogo.Controls.Add(lblSubtitulo);
            pnlLogo.Controls.Add(lblTitulo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(244, 130);
            pnlLogo.TabIndex = 0;
            // 
            // imgLogo
            // 
            imgLogo.BackColor = Color.Transparent;
            imgLogo.Image = (Image)resources.GetObject("imgLogo.Image");
            imgLogo.Location = new Point(3, 3);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(90, 124);
            imgLogo.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogo.TabIndex = 2;
            imgLogo.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(99, 70);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(142, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Sistema De Gestion ";
            lblSubtitulo.Click += lblSubtitulo_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(90, 41);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(154, 29);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BIBLIOTECA";
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.LightBlue;
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(244, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(650, 90);
            pnlSuperior.TabIndex = 1;
            // 
            // pnlEstado
            // 
            pnlEstado.BackColor = Color.CadetBlue;
            pnlEstado.Dock = DockStyle.Bottom;
            pnlEstado.Location = new Point(244, 488);
            pnlEstado.Name = "pnlEstado";
            pnlEstado.Size = new Size(650, 50);
            pnlEstado.TabIndex = 2;
            // 
            // pnlCcontenido
            // 
            pnlCcontenido.BackColor = SystemColors.ControlLight;
            pnlCcontenido.Dock = DockStyle.Fill;
            pnlCcontenido.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlCcontenido.Location = new Point(244, 90);
            pnlCcontenido.Name = "pnlCcontenido";
            pnlCcontenido.Size = new Size(650, 398);
            pnlCcontenido.TabIndex = 3;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.Location = new Point(0, 130);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(244, 45);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // btnLibros
            // 
            btnLibros.Dock = DockStyle.Top;
            btnLibros.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLibros.Location = new Point(0, 175);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(244, 45);
            btnLibros.TabIndex = 2;
            btnLibros.Text = "Libros";
            btnLibros.UseVisualStyleBackColor = true;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.Location = new Point(0, 220);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(244, 45);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnAutores
            // 
            btnAutores.Dock = DockStyle.Top;
            btnAutores.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutores.Location = new Point(0, 265);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(244, 45);
            btnAutores.TabIndex = 4;
            btnAutores.Text = "Autores";
            btnAutores.UseVisualStyleBackColor = true;
            // 
            // btnEditoriales
            // 
            btnEditoriales.Dock = DockStyle.Top;
            btnEditoriales.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditoriales.Location = new Point(0, 310);
            btnEditoriales.Name = "btnEditoriales";
            btnEditoriales.Size = new Size(244, 45);
            btnEditoriales.TabIndex = 5;
            btnEditoriales.Text = "Editoriales";
            btnEditoriales.UseVisualStyleBackColor = true;
            // 
            // btnPrestamos
            // 
            btnPrestamos.Dock = DockStyle.Top;
            btnPrestamos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrestamos.Location = new Point(0, 355);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(244, 45);
            btnPrestamos.TabIndex = 6;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.Location = new Point(0, 400);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(244, 45);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnSalida
            // 
            btnSalida.Dock = DockStyle.Top;
            btnSalida.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalida.Location = new Point(0, 445);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(244, 45);
            btnSalida.TabIndex = 8;
            btnSalida.Text = "Salida";
            btnSalida.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 538);
            Controls.Add(pnlCcontenido);
            Controls.Add(pnlEstado);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlMenu);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de gestion biblioteca";
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlSuperior;
        private Panel pnlEstado;
        private Panel pnlCcontenido;
        private Panel pnlLogo;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private PictureBox imgLogo;
        private Button btnInicio;
        private Button btnSalida;
        private Button btnReportes;
        private Button btnPrestamos;
        private Button btnEditoriales;
        private Button btnAutores;
        private Button btnUsuarios;
        private Button btnLibros;
    }
}
