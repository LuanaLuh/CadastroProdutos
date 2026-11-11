namespace Trabalho1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularMargem()
        {

            if (decimal.TryParse(nudPrecoCusto.Text, out decimal precoCusto) &&
                decimal.TryParse(nudPrecoVenda.Text, out decimal precoVenda))
            {
                if (precoCusto > 0)
                {

                    decimal margem = ((precoVenda - precoCusto) / precoCusto) * 100;
                    txtMargem.Text = margem.ToString("N2");
                }
                else
                {
                    txtMargem.Text = "0.00";
                }
            }
        }

        private void txtPrecoCusto_Leave(object sender, EventArgs e)
        {
            CalcularMargem();
        }

        private void txtPrecoVenda_Leave(object sender, EventArgs e)
        {
            CalcularMargem();
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo 'Nome do Produto' é obrigatório!", "Atenção", MessageBoxButtons.OK);
                txtNome.Focus();
                return;
            }
            else if (nudPrecoCusto.Value <= 0)
            {
                MessageBox.Show("Informe um preço de custo válido!", "Atenção", MessageBoxButtons.OK);
                nudPrecoCusto.Focus();
                return;
            }
            else if (nudPrecoVenda.Value <= 0)
            {
                MessageBox.Show("Informe um preço de venda válido!", "Atenção", MessageBoxButtons.OK);
                nudPrecoVenda.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            textCodigo.Clear();
            txtNome.Clear();
            richDescricao.Clear();
            txtMargem.Clear();


            nudPrecoCusto.Value = 0;
            nudPrecoVenda.Value = 0;
            nudStockInicial.Value = 0;
            nudStockMinimo.Value = 0;


            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.Text = string.Empty;

            cmbFornecedor.SelectedIndex = -1;
            cmbFornecedor.Text = string.Empty;


            chkProdutoAtivo.Checked = true;
            dtpDataCadastro.Value = DateTime.Now;


            txtNome.Focus();
        }
    }
}
        
    

