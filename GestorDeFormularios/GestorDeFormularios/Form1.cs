namespace GestorDeFormularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void registroDePersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistropersonas frm = new FrmRegistropersonas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void conversorDeDivisasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conversordivisas frm = new Conversordivisas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void c�lculoDeImpuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C�lculo_de_Impuestos frm = new C�lculo_de_Impuestos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void generadorDeLaSerieFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fibonacci frm = new Fibonacci();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
