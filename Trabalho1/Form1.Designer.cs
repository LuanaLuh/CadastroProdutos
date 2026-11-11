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
            groupBox2 = new GroupBox();
            txtPrecoVenda = new NumericUpDown();
            txtStockMinimo = new NumericUpDown();
            txtStockInicial = new NumericUpDown();
            txtMargem = new TextBox();
            txtPrecoCusto = new NumericUpDown();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            txtCadastro = new DateTimePicker();
            txtProdutoAtivo = new CheckBox();
            label13 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label18 = new Label();
            label17 = new Label();
            groupBox1 = new GroupBox();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            richTextBox1 = new RichTextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            btnNome = new TextBox();
            textBox1 = new TextBox();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPrecoVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStockMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStockInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecoCusto).BeginInit();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
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
            btnNovo.Location = new Point(106, 327);
            btnNovo.Margin = new Padding(3, 2, 3, 2);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(103, 37);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
         
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(214, 327);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(104, 37);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Image = (Image)resources.GetObject("btnLimpar.Image");
            btnLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpar.Location = new Point(324, 327);
            btnLimpar.Margin = new Padding(3, 2, 3, 2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(104, 37);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(435, 327);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(103, 37);
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
            txtFornecedor.Size = new Size(151, 21);
            txtFornecedor.TabIndex = 8;
            txtFornecedor.Text = "Selecione...";
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoria.FormattingEnabled = true;
            txtCategoria.Location = new Point(543, 57);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(151, 21);
            txtCategoria.TabIndex = 7;
            txtCategoria.Text = "Selecione...";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(11, 57);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(161, 21);
            txtCodigo.TabIndex = 6;
            txtCodigo.Text = "000000";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(192, 57);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(298, 23);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPrecoVenda);
            groupBox2.Controls.Add(txtStockMinimo);
            groupBox2.Controls.Add(txtStockInicial);
            groupBox2.Controls.Add(txtMargem);
            groupBox2.Controls.Add(txtPrecoCusto);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(10, 203);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(404, 112);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Precificação e Estoque";
            // 
            // txtPrecoVenda
            // 
            txtPrecoVenda.DecimalPlaces = 2;
            txtPrecoVenda.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecoVenda.Location = new Point(338, 22);
            txtPrecoVenda.Margin = new Padding(3, 2, 3, 2);
            txtPrecoVenda.Name = "txtPrecoVenda";
            txtPrecoVenda.Size = new Size(61, 21);
            txtPrecoVenda.TabIndex = 15;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStockMinimo.Location = new Point(325, 82);
            txtStockMinimo.Margin = new Padding(3, 2, 3, 2);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(74, 19);
            txtStockMinimo.TabIndex = 14;
            // 
            // txtStockInicial
            // 
            txtStockInicial.DecimalPlaces = 2;
            txtStockInicial.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStockInicial.Location = new Point(89, 80);
            txtStockInicial.Margin = new Padding(3, 2, 3, 2);
            txtStockInicial.Name = "txtStockInicial";
            txtStockInicial.Size = new Size(68, 21);
            txtStockInicial.TabIndex = 13;
            // 
            // txtMargem
            // 
            txtMargem.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMargem.Location = new Point(89, 48);
            txtMargem.Margin = new Padding(3, 2, 3, 2);
            txtMargem.Name = "txtMargem";
            txtMargem.Size = new Size(74, 21);
            txtMargem.TabIndex = 12;
            txtMargem.Text = "0,00";
            // 
            // txtPrecoCusto
            // 
            txtPrecoCusto.DecimalPlaces = 2;
            txtPrecoCusto.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            txtPrecoCusto.Location = new Point(124, 22);
            txtPrecoCusto.Margin = new Padding(3, 2, 3, 2);
            txtPrecoCusto.Name = "txtPrecoCusto";
            txtPrecoCusto.Size = new Size(74, 22);
            txtPrecoCusto.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(228, 85);
            label12.Name = "label12";
            label12.Size = new Size(80, 13);
            label12.TabIndex = 9;
            label12.Text = "Stock Mínimo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(217, 27);
            label11.Name = "label11";
            label11.Size = new Size(112, 13);
            label11.TabIndex = 8;
            label11.Text = "Preço de Venda (R$):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(4, 81);
            label10.Name = "label10";
            label10.Size = new Size(70, 13);
            label10.TabIndex = 7;
            label10.Text = "Stock Inicial:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(5, 50);
            label9.Name = "label9";
            label9.Size = new Size(77, 13);
            label9.TabIndex = 6;
            label9.Text = "Margem (R$):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(5, 25);
            label8.Name = "label8";
            label8.Size = new Size(110, 13);
            label8.TabIndex = 5;
            label8.Text = "Preço de Custo (R$):";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtCadastro);
            groupBox3.Controls.Add(txtProdutoAtivo);
            groupBox3.Controls.Add(label13);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(420, 203);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(219, 112);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Situação / Detalhes";
            // 
            // txtCadastro
            // 
            txtCadastro.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCadastro.Format = DateTimePickerFormat.Short;
            txtCadastro.Location = new Point(13, 65);
            txtCadastro.Margin = new Padding(3, 2, 3, 2);
            txtCadastro.Name = "txtCadastro";
            txtCadastro.Size = new Size(151, 21);
            txtCadastro.TabIndex = 12;
            // 
            // txtProdutoAtivo
            // 
            txtProdutoAtivo.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            txtProdutoAtivo.Location = new Point(15, 22);
            txtProdutoAtivo.Margin = new Padding(3, 2, 3, 2);
            txtProdutoAtivo.Name = "txtProdutoAtivo";
            txtProdutoAtivo.Size = new Size(131, 20);
            txtProdutoAtivo.TabIndex = 11;
            txtProdutoAtivo.Text = "Produto Ativo";
            txtProdutoAtivo.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(13, 50);
            label13.Name = "label13";
            label13.Size = new Size(99, 13);
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 54);
            panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 50);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Image = (Image)resources.GetObject("label18.Image");
            label18.Location = new Point(48, 26);
            label18.Name = "label18";
            label18.Size = new Size(0, 15);
            label18.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold);
            label17.ForeColor = Color.White;
            label17.Location = new Point(72, 16);
            label17.Name = "label17";
            label17.Size = new Size(206, 25);
            label17.TabIndex = 0;
            label17.Text = "Cadastro de Produtos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label26);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(label24);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(btnNome);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(label19);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 58);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(628, 141);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Principais";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.White;
            label26.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.FromArgb(192, 64, 0);
            label26.Location = new Point(510, 19);
            label26.Name = "label26";
            label26.Size = new Size(12, 13);
            label26.TabIndex = 12;
            label26.Text = "*";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.White;
            label25.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.ForeColor = Color.FromArgb(192, 64, 0);
            label25.Location = new Point(280, 20);
            label25.Name = "label25";
            label25.Size = new Size(12, 13);
            label25.TabIndex = 11;
            label25.Text = "*";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.White;
            label24.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.FromArgb(192, 64, 0);
            label24.Location = new Point(70, 79);
            label24.Name = "label24";
            label24.Size = new Size(12, 13);
            label24.TabIndex = 10;
            label24.Text = "*";
            label24.Click += label24_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(217, 79);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richTextBox1.Size = new Size(386, 57);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(452, 34);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(159, 27);
            comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(8, 94);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 20);
            comboBox1.TabIndex = 7;
            comboBox1.Text = "Selecione...";
            // 
            // btnNome
            // 
            btnNome.Location = new Point(179, 35);
            btnNome.Margin = new Padding(3, 2, 3, 2);
            btnNome.Name = "btnNome";
            btnNome.Size = new Size(266, 27);
            btnNome.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 35);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 27);
            textBox1.TabIndex = 5;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(179, 20);
            label23.Name = "label23";
            label23.Size = new Size(102, 13);
            label23.TabIndex = 4;
            label23.Text = "Nome do Produto:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(217, 64);
            label22.Name = "label22";
            label22.Size = new Size(59, 13);
            label22.TabIndex = 3;
            label22.Text = "Descrição:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(4, 79);
            label21.Name = "label21";
            label21.Size = new Size(69, 13);
            label21.TabIndex = 2;
            label21.Text = "Fornecedor:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(452, 20);
            label20.Name = "label20";
            label20.Size = new Size(60, 13);
            label20.TabIndex = 1;
            label20.Text = "Categoria:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(6, 20);
            label19.Name = "label19";
            label19.Size = new Size(48, 13);
            label19.TabIndex = 0;
            label19.Text = "Código:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(649, 387);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(btnExcluir);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            ForeColor = Color.Black;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPrecoVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStockMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStockInicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrecoCusto).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox2;
        private GroupBox groupBox3;
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
        private NumericUpDown txtPrecoCusto;
        private TextBox txtMargem;
        private NumericUpDown txtStockInicial;
        private NumericUpDown txtPrecoVenda;
        private NumericUpDown txtStockMinimo;
        private CheckBox txtProdutoAtivo;
        private DateTimePicker txtCadastro;
        private RichTextBox txtDescricao;
        private Label label16;
        private Label label15;
        private Label label14;
        private Panel panel1;
        private Label label18;
        private Label label17;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private Label label19;
        private TextBox btnNome;
        private TextBox textBox1;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private RichTextBox richTextBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label26;
        private Label label25;
        private Label label24;
    }
}
