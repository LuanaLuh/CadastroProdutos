namespace Trabalho1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void painel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void txtPrecoCusto_TextChanged(object sender, EventArgs e)
        {

            CalcularMargem();
        }

        private void txtPrecoVenda_TextChanged(object sender, EventArgs e)
        {

            CalcularMargem();
        }



        private void CalcularMargem()
        {

            decimal.TryParse(txtPrecoCusto.Text, out decimal precoCusto);
            decimal.TryParse(txtPrecoVenda.Text, out decimal precoVenda);

            if (precoCusto > 0)
            {
                decimal margem = ((precoVenda - precoCusto) / precoCusto) * 100;
                txtMargem.Text = margem.ToString("N2");
            }
            else
            {
                txtMargem.Text = "0,00";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
