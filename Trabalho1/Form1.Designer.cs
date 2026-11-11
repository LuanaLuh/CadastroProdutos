namespace Trabalho1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnExcluir = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            txtDescricao = new RichTextBox();
            txtFornecedor = new ComboBox();
            txtCategoria = new ComboBox();
            txtCodigo = new TextBox();
            txtNomeProduto = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            gbPrecificacao = new GroupBox();
            nudPrecoVenda = new NumericUpDown();
            nudStockMinimo = new NumericUpDown();
            nudStockInicial = new NumericUpDown();
            txtMargem = new TextBox();
            nudPrecoCusto = new NumericUpDown();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            gbSituacao = new GroupBox();
            dtpDataCadastro = new DateTimePicker();
            chkProdutoAtivo = new CheckBox();
            label13 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label18 = new Label();
            label17 = new Label();
            gbDadosPrincipais = new GroupBox();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            richDescricao = new RichTextBox();
            cmbCategoria = new ComboBox();
            cmbFornecedor = new ComboBox();
            txtNome = new TextBox();
            textCodigo = new TextBox();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gbPrecificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecoVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecoCusto).BeginInit();
            gbSituacao.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            gbDadosPrincipais.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(94, 12);
            label1.Name = "label1";
            label1.Size = new Size(244, 31);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produtos";
            // 
            // btnNovo
            // 
            btnNovo.Image = (Image)resources.GetObject("btnNovo.Image");
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.Location = new Point(121, 436);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(118, 49);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(245, 436);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(119, 49);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = (Image)resources.GetObject("btnLimpar.Image");
            btnLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpar.Location = new Point(370, 436);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(119, 49);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(497, 436);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(118, 49);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(1, 43);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.FromArgb(192, 64, 0);
            label16.Location = new Point(608, 37);
            label16.Name = "label16";
            label16.Size = new Size(14, 17);
            label16.TabIndex = 12;
            label16.Text = "*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.FromArgb(192, 64, 0);
            label15.Location = new Point(82, 97);
            label15.Name = "label15";
            label15.Size = new Size(14, 17);
            label15.TabIndex = 11;
            label15.Text = "*";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.FromArgb(192, 64, 0);
            label14.Location = new Point(312, 37);
            label14.Name = "label14";
            label14.Size = new Size(14, 17);
            label14.TabIndex = 10;
            label14.Text = "*";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(233, 117);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            txtDescricao.Size = new Size(304, 62);
            txtDescricao.TabIndex = 9;
            txtDescricao.Text = "";
            // 
            // txtFornecedor
            // 
            txtFornecedor.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFornecedor.FormattingEnabled = true;
            txtFornecedor.Location = new Point(6, 117);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(151, 25);
            txtFornecedor.TabIndex = 8;
            txtFornecedor.Text = "Selecione...";
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoria.FormattingEnabled = true;
            txtCategoria.Location = new Point(543, 57);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(151, 25);
            txtCategoria.TabIndex = 7;
            txtCategoria.Text = "Selecione...";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(11, 57);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(161, 25);
            txtCodigo.TabIndex = 6;
            txtCodigo.Text = "000000";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(192, 57);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(298, 27);
            txtNomeProduto.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(543, 37);
            label7.Name = "label7";
            label7.Size = new Size(69, 17);
            label7.TabIndex = 4;
            label7.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(233, 97);
            label6.Name = "label6";
            label6.Size = new Size(68, 17);
            label6.TabIndex = 3;
            label6.Text = "Descrição:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(192, 37);
            label5.Name = "label5";
            label5.Size = new Size(122, 17);
            label5.TabIndex = 2;
            label5.Text = "Nome do Produto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 97);
            label4.Name = "label4";
            label4.Size = new Size(81, 17);
            label4.TabIndex = 1;
            label4.Text = "Fornecedor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 37);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 0;
            label3.Text = "Código:";
            // 
            // gbPrecificacao
            // 
            gbPrecificacao.Controls.Add(nudPrecoVenda);
            gbPrecificacao.Controls.Add(nudStockMinimo);
            gbPrecificacao.Controls.Add(nudStockInicial);
            gbPrecificacao.Controls.Add(txtMargem);
            gbPrecificacao.Controls.Add(nudPrecoCusto);
            gbPrecificacao.Controls.Add(label12);
            gbPrecificacao.Controls.Add(label11);
            gbPrecificacao.Controls.Add(label10);
            gbPrecificacao.Controls.Add(label9);
            gbPrecificacao.Controls.Add(label8);
            gbPrecificacao.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbPrecificacao.Location = new Point(11, 271);
            gbPrecificacao.Name = "gbPrecificacao";
            gbPrecificacao.Size = new Size(462, 149);
            gbPrecificacao.TabIndex = 7;
            gbPrecificacao.TabStop = false;
            gbPrecificacao.Text = "Precificação e Estoque";
            // 
            // nudPrecoVenda
            // 
            nudPrecoVenda.DecimalPlaces = 2;
            nudPrecoVenda.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudPrecoVenda.Location = new Point(386, 29);
            nudPrecoVenda.Name = "nudPrecoVenda";
            nudPrecoVenda.Size = new Size(70, 25);
            nudPrecoVenda.TabIndex = 15;
            // 
            // nudStockMinimo
            // 
            nudStockMinimo.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudStockMinimo.Location = new Point(371, 109);
            nudStockMinimo.Name = "nudStockMinimo";
            nudStockMinimo.Size = new Size(85, 22);
            nudStockMinimo.TabIndex = 14;
            // 
            // nudStockInicial
            // 
            nudStockInicial.DecimalPlaces = 2;
            nudStockInicial.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudStockInicial.Location = new Point(102, 107);
            nudStockInicial.Name = "nudStockInicial";
            nudStockInicial.Size = new Size(78, 25);
            nudStockInicial.TabIndex = 13;
            // 
            // txtMargem
            // 
            txtMargem.BackColor = SystemColors.ScrollBar;
            txtMargem.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMargem.Location = new Point(102, 64);
            txtMargem.Name = "txtMargem";
            txtMargem.Size = new Size(84, 25);
            txtMargem.TabIndex = 12;
            txtMargem.Text = "0,00";
            // 
            // nudPrecoCusto
            // 
            nudPrecoCusto.DecimalPlaces = 2;
            nudPrecoCusto.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            nudPrecoCusto.Location = new Point(142, 29);
            nudPrecoCusto.Name = "nudPrecoCusto";
            nudPrecoCusto.Size = new Size(85, 25);
            nudPrecoCusto.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(261, 113);
            label12.Name = "label12";
            label12.Size = new Size(94, 17);
            label12.TabIndex = 9;
            label12.Text = "Stock Mínimo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(248, 36);
            label11.Name = "label11";
            label11.Size = new Size(132, 17);
            label11.TabIndex = 8;
            label11.Text = "Preço de Venda (R$):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(5, 108);
            label10.Name = "label10";
            label10.Size = new Size(82, 17);
            label10.TabIndex = 7;
            label10.Text = "Stock Inicial:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 67);
            label9.Name = "label9";
            label9.Size = new Size(89, 17);
            label9.TabIndex = 6;
            label9.Text = "Margem (R$):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 33);
            label8.Name = "label8";
            label8.Size = new Size(130, 17);
            label8.TabIndex = 5;
            label8.Text = "Preço de Custo (R$):";
            // 
            // gbSituacao
            // 
            gbSituacao.Controls.Add(dtpDataCadastro);
            gbSituacao.Controls.Add(chkProdutoAtivo);
            gbSituacao.Controls.Add(label13);
            gbSituacao.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbSituacao.Location = new Point(480, 271);
            gbSituacao.Name = "gbSituacao";
            gbSituacao.Size = new Size(250, 149);
            gbSituacao.TabIndex = 8;
            gbSituacao.TabStop = false;
            gbSituacao.Text = "Situação / Detalhes";
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataCadastro.Format = DateTimePickerFormat.Short;
            dtpDataCadastro.Location = new Point(15, 87);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.Size = new Size(172, 25);
            dtpDataCadastro.TabIndex = 12;
            // 
            // chkProdutoAtivo
            // 
            chkProdutoAtivo.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            chkProdutoAtivo.Location = new Point(17, 29);
            chkProdutoAtivo.Name = "chkProdutoAtivo";
            chkProdutoAtivo.Size = new Size(150, 27);
            chkProdutoAtivo.TabIndex = 11;
            chkProdutoAtivo.Text = "Produto Ativo";
            chkProdutoAtivo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(15, 67);
            label13.Name = "label13";
            label13.Size = new Size(116, 17);
            label13.TabIndex = 0;
            label13.Text = "Data de Cadastro:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 101, 143);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label17);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 72);
            panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 67);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Image = (Image)resources.GetObject("label18.Image");
            label18.Location = new Point(55, 35);
            label18.Name = "label18";
            label18.Size = new Size(0, 20);
            label18.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold);
            label17.ForeColor = Color.White;
            label17.Location = new Point(82, 21);
            label17.Name = "label17";
            label17.Size = new Size(262, 32);
            label17.TabIndex = 0;
            label17.Text = "Cadastro de Produtos";
            // 
            // gbDadosPrincipais
            // 
            gbDadosPrincipais.Controls.Add(label26);
            gbDadosPrincipais.Controls.Add(label25);
            gbDadosPrincipais.Controls.Add(label24);
            gbDadosPrincipais.Controls.Add(richDescricao);
            gbDadosPrincipais.Controls.Add(cmbCategoria);
            gbDadosPrincipais.Controls.Add(cmbFornecedor);
            gbDadosPrincipais.Controls.Add(txtNome);
            gbDadosPrincipais.Controls.Add(textCodigo);
            gbDadosPrincipais.Controls.Add(label23);
            gbDadosPrincipais.Controls.Add(label22);
            gbDadosPrincipais.Controls.Add(label21);
            gbDadosPrincipais.Controls.Add(label20);
            gbDadosPrincipais.Controls.Add(label19);
            gbDadosPrincipais.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDadosPrincipais.Location = new Point(11, 77);
            gbDadosPrincipais.Name = "gbDadosPrincipais";
            gbDadosPrincipais.Size = new Size(718, 188);
            gbDadosPrincipais.TabIndex = 9;
            gbDadosPrincipais.TabStop = false;
            gbDadosPrincipais.Text = "Dados Principais";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.White;
            label26.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.FromArgb(192, 64, 0);
            label26.Location = new Point(583, 25);
            label26.Name = "label26";
            label26.Size = new Size(13, 17);
            label26.TabIndex = 12;
            label26.Text = "*";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.White;
            label25.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.FromArgb(192, 64, 0);
            label25.Location = new Point(320, 27);
            label25.Name = "label25";
            label25.Size = new Size(13, 17);
            label25.TabIndex = 11;
            label25.Text = "*";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.White;
            label24.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.FromArgb(192, 64, 0);
            label24.Location = new Point(80, 105);
            label24.Name = "label24";
            label24.Size = new Size(13, 17);
            label24.TabIndex = 10;
            label24.Text = "*";
            // 
            // richDescricao
            // 
            richDescricao.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richDescricao.Location = new Point(248, 105);
            richDescricao.Name = "richDescricao";
            richDescricao.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richDescricao.Size = new Size(441, 75);
            richDescricao.TabIndex = 9;
            richDescricao.Text = "";
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(517, 45);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(181, 25);
            cmbCategoria.TabIndex = 8;
            // 
            // cmbFornecedor
            // 
            cmbFornecedor.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFornecedor.FormattingEnabled = true;
            cmbFornecedor.Location = new Point(9, 125);
            cmbFornecedor.Name = "cmbFornecedor";
            cmbFornecedor.Size = new Size(218, 25);
            cmbFornecedor.TabIndex = 7;
            cmbFornecedor.Text = "Selecione...";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(205, 47);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(303, 25);
            txtNome.TabIndex = 6;
            // 
            // textCodigo
            // 
            textCodigo.BackColor = SystemColors.ScrollBar;
            textCodigo.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textCodigo.Location = new Point(7, 47);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(169, 25);
            textCodigo.TabIndex = 5;
            textCodigo.Text = "000000";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(205, 27);
            label23.Name = "label23";
            label23.Size = new Size(118, 17);
            label23.TabIndex = 4;
            label23.Text = "Nome do Produto:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(248, 85);
            label22.Name = "label22";
            label22.Size = new Size(68, 17);
            label22.TabIndex = 3;
            label22.Text = "Descrição:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(5, 105);
            label21.Name = "label21";
            label21.Size = new Size(78, 17);
            label21.TabIndex = 2;
            label21.Text = "Fornecedor:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(517, 27);
            label20.Name = "label20";
            label20.Size = new Size(68, 17);
            label20.TabIndex = 1;
            label20.Text = "Categoria:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(7, 27);
            label19.Name = "label19";
            label19.Size = new Size(54, 17);
            label19.TabIndex = 0;
            label19.Text = "Código:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(742, 516);
            Controls.Add(panel1);
            Controls.Add(gbDadosPrincipais);
            Controls.Add(gbSituacao);
            Controls.Add(gbPrecificacao);
            Controls.Add(btnExcluir);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gbPrecificacao.ResumeLayout(false);
            gbPrecificacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecoVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockInicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecoCusto).EndInit();
            gbSituacao.ResumeLayout(false);
            gbSituacao.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            gbDadosPrincipais.ResumeLayout(false);
            gbDadosPrincipais.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnExcluir;
      
        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox gbPrecificacao;
        private GroupBox gbSituacao;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtCodigo;
        private TextBox txtNomeProduto;
        private Label label12;
        private Label label13;
        private ComboBox txtFornecedor;
        private ComboBox txtCategoria;
        private NumericUpDown nudPrecoCusto;
        private TextBox txtMargem;
        private NumericUpDown nudStockInicial;
        private NumericUpDown nudPrecoVenda;
        private NumericUpDown nudStockMinimo;
        private CheckBox chkProdutoAtivo;
        private DateTimePicker dtpDataCadastro;
        private RichTextBox txtDescricao;
        private Label label16;
        private Label label15;
        private Label label14;
        private Panel panel1;
        private Label label18;
        private Label label17;
        private GroupBox gbDadosPrincipais;
        private PictureBox pictureBox2;
        private Label label19;
        private TextBox txtNome;
        private TextBox textCodigo;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private RichTextBox richDescricao;
        private ComboBox cmbCategoria;
        private ComboBox cmbFornecedor;
        private Label label26;
        private Label label25;
        private Label label24;
    }
}
