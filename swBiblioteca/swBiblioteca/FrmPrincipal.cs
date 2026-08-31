namespace swBiblioteca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void AbrirFormulario(Form formulario)
        {
            pnlCcontenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
            pnlCcontenido.Controls.Add(formulario);
            formulario.BringToFront();
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmInicio());
        }
        private void btnLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmLibros());
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios());
        }
        private void btnAutores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAutores());
        }
        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEditoriales());
        }
        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPrestamos());
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReportes());
        }
        private void btnSalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler añadido para evitar error CS0103 cuando el diseñador asigna el evento Click
        private void lblSubtitulo_Click(object sender, EventArgs e)
        {
            // Actualmente no realiza ninguna acción. Mantener vacío o implementar comportamiento necesario.
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
