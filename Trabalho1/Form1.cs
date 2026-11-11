namespace Trabalho1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            else if (precoVenda > 0)
            {
                decimal margem = ((precoVenda - precoCusto) / precoVenda) * 100;
                txtMargem.Text = margem.ToString("N2");
            }
            else
            {
                txtMargem.Text = "0,00";
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string TextoCodigo = txtCodigo.Text;
            string TextoFornecedor = txtFornecedor.Text;
            string TextoCategoria = txtCategoria.Text;
            string TextoPrecoCusto = txtPrecoCusto.Text;
            string TextoPrecoVenda = txtPrecoVenda.Text;


            if (btnSalvar.Text == "Salvar")
            {


            }
            else
            {



            }





        }

       
        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
