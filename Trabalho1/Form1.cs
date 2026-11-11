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
            if (btnSalvar.Text == "Salvar")
            {


            }
            else
            {



            }





        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtPrecoCusto.Clear();
            txtPrecoVenda.Clear();
            txtMargem.Clear();
            txtStockInicial.Clear();
            txtStockMinimo.Clear();

            cmbCategoria.SelectedIndex = -1;
            cmbFornecedor.SelectedIndex = -1;

            chkProdutoAtivo.Checked = true;
            dtpDataCadastro.Value = DateTime.Now;

            txtNome.Focus();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
