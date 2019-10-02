namespace locacao
{
    partial class FormLocacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAlterarCliente = new System.Windows.Forms.Button();
            this.buttonCadastrarCliente = new System.Windows.Forms.Button();
            this.groupBoxDadosPrincipais = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxDataEntrega = new System.Windows.Forms.MaskedTextBox();
            this.labelDataEntrega = new System.Windows.Forms.Label();
            this.maskedTextBoxDataLocacao = new System.Windows.Forms.MaskedTextBox();
            this.labelDataLocacao = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelLocacaoPlaca = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxLocacaoCliente = new System.Windows.Forms.ComboBox();
            this.labelLocacaoStatus = new System.Windows.Forms.Label();
            this.labelLocacaoCliente = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxLocacaoFuncionario = new System.Windows.Forms.TextBox();
            this.groupBoxPagamento = new System.Windows.Forms.GroupBox();
            this.labelForma = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.textBoxForma = new System.Windows.Forms.TextBox();
            this.buttonAdcPagamento = new System.Windows.Forms.Button();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxDadosPrincipais.SuspendLayout();
            this.groupBoxPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.dataGridView1);
            this.groupBoxClientes.Location = new System.Drawing.Point(7, 12);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(513, 493);
            this.groupBoxClientes.TabIndex = 12;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Locações";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 468);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(728, 482);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 16;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // buttonAlterarCliente
            // 
            this.buttonAlterarCliente.Location = new System.Drawing.Point(635, 482);
            this.buttonAlterarCliente.Name = "buttonAlterarCliente";
            this.buttonAlterarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarCliente.TabIndex = 15;
            this.buttonAlterarCliente.Text = "Alterar";
            this.buttonAlterarCliente.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrarCliente
            // 
            this.buttonCadastrarCliente.Location = new System.Drawing.Point(541, 482);
            this.buttonCadastrarCliente.Name = "buttonCadastrarCliente";
            this.buttonCadastrarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrarCliente.TabIndex = 14;
            this.buttonCadastrarCliente.Text = "Cadastrar";
            this.buttonCadastrarCliente.UseVisualStyleBackColor = true;
            // 
            // groupBoxDadosPrincipais
            // 
            this.groupBoxDadosPrincipais.Controls.Add(this.maskedTextBoxDataEntrega);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelDataEntrega);
            this.groupBoxDadosPrincipais.Controls.Add(this.maskedTextBoxDataLocacao);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelDataLocacao);
            this.groupBoxDadosPrincipais.Controls.Add(this.comboBox2);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelLocacaoPlaca);
            this.groupBoxDadosPrincipais.Controls.Add(this.comboBox1);
            this.groupBoxDadosPrincipais.Controls.Add(this.comboBoxLocacaoCliente);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelLocacaoStatus);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelLocacaoCliente);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelNome);
            this.groupBoxDadosPrincipais.Controls.Add(this.textBoxLocacaoFuncionario);
            this.groupBoxDadosPrincipais.Location = new System.Drawing.Point(541, 12);
            this.groupBoxDadosPrincipais.Name = "groupBoxDadosPrincipais";
            this.groupBoxDadosPrincipais.Size = new System.Drawing.Size(390, 264);
            this.groupBoxDadosPrincipais.TabIndex = 11;
            this.groupBoxDadosPrincipais.TabStop = false;
            this.groupBoxDadosPrincipais.Text = "Dados Principais";
            // 
            // maskedTextBoxDataEntrega
            // 
            this.maskedTextBoxDataEntrega.Location = new System.Drawing.Point(92, 218);
            this.maskedTextBoxDataEntrega.Mask = "00/00/0000";
            this.maskedTextBoxDataEntrega.Name = "maskedTextBoxDataEntrega";
            this.maskedTextBoxDataEntrega.Size = new System.Drawing.Size(77, 20);
            this.maskedTextBoxDataEntrega.TabIndex = 17;
            this.maskedTextBoxDataEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // labelDataEntrega
            // 
            this.labelDataEntrega.AutoSize = true;
            this.labelDataEntrega.Location = new System.Drawing.Point(7, 226);
            this.labelDataEntrega.Name = "labelDataEntrega";
            this.labelDataEntrega.Size = new System.Drawing.Size(73, 13);
            this.labelDataEntrega.TabIndex = 16;
            this.labelDataEntrega.Text = "Data Entrega:";
            this.labelDataEntrega.Click += new System.EventHandler(this.Label1_Click);
            // 
            // maskedTextBoxDataLocacao
            // 
            this.maskedTextBoxDataLocacao.Location = new System.Drawing.Point(92, 180);
            this.maskedTextBoxDataLocacao.Mask = "00/00/0000";
            this.maskedTextBoxDataLocacao.Name = "maskedTextBoxDataLocacao";
            this.maskedTextBoxDataLocacao.Size = new System.Drawing.Size(77, 20);
            this.maskedTextBoxDataLocacao.TabIndex = 15;
            this.maskedTextBoxDataLocacao.ValidatingType = typeof(System.DateTime);
            // 
            // labelDataLocacao
            // 
            this.labelDataLocacao.AutoSize = true;
            this.labelDataLocacao.Location = new System.Drawing.Point(7, 188);
            this.labelDataLocacao.Name = "labelDataLocacao";
            this.labelDataLocacao.Size = new System.Drawing.Size(78, 13);
            this.labelDataLocacao.TabIndex = 11;
            this.labelDataLocacao.Text = "Data Locação:";
            this.labelDataLocacao.Click += new System.EventHandler(this.LabelCpf_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Alugado",
            "Pendente",
            "Finalizado"});
            this.comboBox2.Location = new System.Drawing.Point(78, 143);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(147, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // labelLocacaoPlaca
            // 
            this.labelLocacaoPlaca.AutoSize = true;
            this.labelLocacaoPlaca.Location = new System.Drawing.Point(7, 151);
            this.labelLocacaoPlaca.Name = "labelLocacaoPlaca";
            this.labelLocacaoPlaca.Size = new System.Drawing.Size(37, 13);
            this.labelLocacaoPlaca.TabIndex = 9;
            this.labelLocacaoPlaca.Text = "Placa:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Livre",
            "Alugado",
            "Pendente",
            "Finalizado"});
            this.comboBox1.Location = new System.Drawing.Point(78, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBoxLocacaoCliente
            // 
            this.comboBoxLocacaoCliente.FormattingEnabled = true;
            this.comboBoxLocacaoCliente.Location = new System.Drawing.Point(78, 65);
            this.comboBoxLocacaoCliente.Name = "comboBoxLocacaoCliente";
            this.comboBoxLocacaoCliente.Size = new System.Drawing.Size(303, 21);
            this.comboBoxLocacaoCliente.TabIndex = 7;
            // 
            // labelLocacaoStatus
            // 
            this.labelLocacaoStatus.AutoSize = true;
            this.labelLocacaoStatus.Location = new System.Drawing.Point(7, 111);
            this.labelLocacaoStatus.Name = "labelLocacaoStatus";
            this.labelLocacaoStatus.Size = new System.Drawing.Size(40, 13);
            this.labelLocacaoStatus.TabIndex = 6;
            this.labelLocacaoStatus.Text = "Status:";
            this.labelLocacaoStatus.Click += new System.EventHandler(this.LabelEndereco_Click);
            // 
            // labelLocacaoCliente
            // 
            this.labelLocacaoCliente.AutoSize = true;
            this.labelLocacaoCliente.Location = new System.Drawing.Point(7, 73);
            this.labelLocacaoCliente.Name = "labelLocacaoCliente";
            this.labelLocacaoCliente.Size = new System.Drawing.Size(42, 13);
            this.labelLocacaoCliente.TabIndex = 3;
            this.labelLocacaoCliente.Text = "Cliente:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(7, 33);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(65, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Funcionário:";
            this.labelNome.Click += new System.EventHandler(this.LabelNome_Click);
            // 
            // textBoxLocacaoFuncionario
            // 
            this.textBoxLocacaoFuncionario.Location = new System.Drawing.Point(78, 26);
            this.textBoxLocacaoFuncionario.Name = "textBoxLocacaoFuncionario";
            this.textBoxLocacaoFuncionario.ReadOnly = true;
            this.textBoxLocacaoFuncionario.Size = new System.Drawing.Size(303, 20);
            this.textBoxLocacaoFuncionario.TabIndex = 0;
            // 
            // groupBoxPagamento
            // 
            this.groupBoxPagamento.Controls.Add(this.labelForma);
            this.groupBoxPagamento.Controls.Add(this.labelValor);
            this.groupBoxPagamento.Controls.Add(this.textBoxValor);
            this.groupBoxPagamento.Controls.Add(this.textBoxForma);
            this.groupBoxPagamento.Controls.Add(this.buttonAdcPagamento);
            this.groupBoxPagamento.Location = new System.Drawing.Point(541, 292);
            this.groupBoxPagamento.Name = "groupBoxPagamento";
            this.groupBoxPagamento.Size = new System.Drawing.Size(390, 163);
            this.groupBoxPagamento.TabIndex = 13;
            this.groupBoxPagamento.TabStop = false;
            this.groupBoxPagamento.Text = "Pagamentos";
            // 
            // labelForma
            // 
            this.labelForma.AutoSize = true;
            this.labelForma.Location = new System.Drawing.Point(31, 82);
            this.labelForma.Name = "labelForma";
            this.labelForma.Size = new System.Drawing.Size(39, 13);
            this.labelForma.TabIndex = 22;
            this.labelForma.Text = "Forma:";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(31, 42);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(34, 13);
            this.labelValor.TabIndex = 21;
            this.labelValor.Text = "Valor:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(92, 39);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.ReadOnly = true;
            this.textBoxValor.Size = new System.Drawing.Size(170, 20);
            this.textBoxValor.TabIndex = 20;
            // 
            // textBoxForma
            // 
            this.textBoxForma.Location = new System.Drawing.Point(92, 82);
            this.textBoxForma.Name = "textBoxForma";
            this.textBoxForma.ReadOnly = true;
            this.textBoxForma.Size = new System.Drawing.Size(170, 20);
            this.textBoxForma.TabIndex = 18;
            // 
            // buttonAdcPagamento
            // 
            this.buttonAdcPagamento.Location = new System.Drawing.Point(297, 19);
            this.buttonAdcPagamento.Name = "buttonAdcPagamento";
            this.buttonAdcPagamento.Size = new System.Drawing.Size(75, 129);
            this.buttonAdcPagamento.TabIndex = 17;
            this.buttonAdcPagamento.Text = "Adicionar Pagamento";
            this.buttonAdcPagamento.UseVisualStyleBackColor = true;
            this.buttonAdcPagamento.Click += new System.EventHandler(this.ButtonAdcPagamento_Click);
            // 
            // FormLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 519);
            this.Controls.Add(this.groupBoxPagamento);
            this.Controls.Add(this.groupBoxClientes);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAlterarCliente);
            this.Controls.Add(this.buttonCadastrarCliente);
            this.Controls.Add(this.groupBoxDadosPrincipais);
            this.Name = "FormLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locação";
            this.groupBoxClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxDadosPrincipais.ResumeLayout(false);
            this.groupBoxDadosPrincipais.PerformLayout();
            this.groupBoxPagamento.ResumeLayout(false);
            this.groupBoxPagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAlterarCliente;
        private System.Windows.Forms.Button buttonCadastrarCliente;
        private System.Windows.Forms.GroupBox groupBoxDadosPrincipais;
        private System.Windows.Forms.Label labelLocacaoStatus;
        private System.Windows.Forms.Label labelLocacaoCliente;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxLocacaoFuncionario;
        private System.Windows.Forms.ComboBox comboBoxLocacaoCliente;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelLocacaoPlaca;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBoxPagamento;
        private System.Windows.Forms.Button buttonAdcPagamento;
        private System.Windows.Forms.Label labelDataLocacao;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataLocacao;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDataEntrega;
        private System.Windows.Forms.Label labelDataEntrega;
        private System.Windows.Forms.TextBox textBoxForma;
        private System.Windows.Forms.Label labelForma;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox textBoxValor;
    }
}