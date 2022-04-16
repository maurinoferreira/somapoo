

namespace Soma
{
    using modelo;
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        internal Controle Controle
        {
            get => default;
            set
            {
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txbNumero1.Text, txbNumero2.Text, "Somar");
            if (controle.Mensagem.Equals(""))
            {
                lblResultado.Text = controle.Resultado;
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
                txbNumero1.Text = "";
                txbNumero2.Text = "";
                lblResultado.Text = "Resultado";
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            Controle controle = new Controle(txbNumero1.Text, txbNumero2.Text, "Dividir");
            if (controle.Mensagem.Equals(""))
            {
                lblResultado.Text = controle.Resultado;
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
                txbNumero1.Text = "";
                txbNumero2.Text = "";
                lblResultado.Text = "Resultado";
            }

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txbNumero1.Text, txbNumero2.Text, "Subtrair");
            if (controle.Mensagem.Equals(""))
            {
                lblResultado.Text = controle.Resultado;
            }
            else
            {
                MessageBox.Show(controle.Mensagem);
                txbNumero1.Text = "";
                txbNumero2.Text = "";
                lblResultado.Text = "Resultado";
            }

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txbNumero1.Text, txbNumero2.Text, "Multiplicar");
            if (controle.Mensagem.Equals(""))
            {
                lblResultado.Text = controle.Resultado;

            }
            else
            {
                MessageBox.Show(controle.Mensagem);
                txbNumero1.Text = "";
                txbNumero2.Text = "";
                lblResultado.Text = "Resultado";
            }
        }
    }
}