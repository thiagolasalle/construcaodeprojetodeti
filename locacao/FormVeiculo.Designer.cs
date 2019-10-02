namespace locacao
{
    partial class FormVeiculo
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
            this.groupBoxVeículos = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAlterarCliente = new System.Windows.Forms.Button();
            this.buttonCadastrarCliente = new System.Windows.Forms.Button();
            this.groupBoxDadosPrincipais = new System.Windows.Forms.GroupBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxCor = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.groupBoxVeículos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxDadosPrincipais.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVeículos
            // 
            this.groupBoxVeículos.Controls.Add(this.dataGridView1);
            this.groupBoxVeículos.Location = new System.Drawing.Point(6, 12);
            this.groupBoxVeículos.Name = "groupBoxVeículos";
            this.groupBoxVeículos.Size = new System.Drawing.Size(513, 257);
            this.groupBoxVeículos.TabIndex = 12;
            this.groupBoxVeículos.TabStop = false;
            this.groupBoxVeículos.Text = "Veículos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(727, 246);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 16;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // buttonAlterarCliente
            // 
            this.buttonAlterarCliente.Location = new System.Drawing.Point(634, 246);
            this.buttonAlterarCliente.Name = "buttonAlterarCliente";
            this.buttonAlterarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarCliente.TabIndex = 15;
            this.buttonAlterarCliente.Text = "Alterar";
            this.buttonAlterarCliente.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrarCliente
            // 
            this.buttonCadastrarCliente.Location = new System.Drawing.Point(540, 246);
            this.buttonCadastrarCliente.Name = "buttonCadastrarCliente";
            this.buttonCadastrarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrarCliente.TabIndex = 14;
            this.buttonCadastrarCliente.Text = "Cadastrar";
            this.buttonCadastrarCliente.UseVisualStyleBackColor = true;
            // 
            // groupBoxDadosPrincipais
            // 
            this.groupBoxDadosPrincipais.Controls.Add(this.comboBoxStatus);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelStatus);
            this.groupBoxDadosPrincipais.Controls.Add(this.textBoxCor);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelEndereco);
            this.groupBoxDadosPrincipais.Controls.Add(this.textBoxPlaca);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelCpf);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelNome);
            this.groupBoxDadosPrincipais.Controls.Add(this.textBoxMarca);
            this.groupBoxDadosPrincipais.Location = new System.Drawing.Point(540, 12);
            this.groupBoxDadosPrincipais.Name = "groupBoxDadosPrincipais";
            this.groupBoxDadosPrincipais.Size = new System.Drawing.Size(262, 207);
            this.groupBoxDadosPrincipais.TabIndex = 11;
            this.groupBoxDadosPrincipais.TabStop = false;
            this.groupBoxDadosPrincipais.Text = "Dados Principais";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "disponivel",
            "indisponivel"});
            this.comboBoxStatus.Location = new System.Drawing.Point(68, 155);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(132, 21);
            this.comboBoxStatus.TabIndex = 10;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(7, 155);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Status:";
            // 
            // textBoxCor
            // 
            this.textBoxCor.Location = new System.Drawing.Point(68, 70);
            this.textBoxCor.Name = "textBoxCor";
            this.textBoxCor.Size = new System.Drawing.Size(132, 20);
            this.textBoxCor.TabIndex = 7;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(7, 115);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(37, 13);
            this.labelEndereco.TabIndex = 6;
            this.labelEndereco.Text = "Placa:";
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(68, 112);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(132, 20);
            this.textBoxPlaca.TabIndex = 5;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(7, 73);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(26, 13);
            this.labelCpf.TabIndex = 3;
            this.labelCpf.Text = "Cor:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(7, 33);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Marca:";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(68, 30);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(188, 20);
            this.textBoxMarca.TabIndex = 0;
            // 
            // FormVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 287);
            this.Controls.Add(this.groupBoxVeículos);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAlterarCliente);
            this.Controls.Add(this.buttonCadastrarCliente);
            this.Controls.Add(this.groupBoxDadosPrincipais);
            this.Name = "FormVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veículo";
            this.groupBoxVeículos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxDadosPrincipais.ResumeLayout(false);
            this.groupBoxDadosPrincipais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVeículos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAlterarCliente;
        private System.Windows.Forms.Button buttonCadastrarCliente;
        private System.Windows.Forms.GroupBox groupBoxDadosPrincipais;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxCor;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelStatus;
    }
}