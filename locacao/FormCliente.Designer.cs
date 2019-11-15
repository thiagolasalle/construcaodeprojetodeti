namespace locacao
{
    partial class FormCliente
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxDadosPrincipais = new System.Windows.Forms.GroupBox();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.groupBoxDadosComplementares = new System.Windows.Forms.GroupBox();
            this.groupBoxExtras = new System.Windows.Forms.GroupBox();
            this.checkBoxIdadeDeRisco = new System.Windows.Forms.CheckBox();
            this.checkBoxDeficiencia = new System.Windows.Forms.CheckBox();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.buttonCadastrarCliente = new System.Windows.Forms.Button();
            this.buttonAlterarCliente = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBoxClientes = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDeficiencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdadeDeRisco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDadosPrincipais.SuspendLayout();
            this.groupBoxDadosComplementares.SuspendLayout();
            this.groupBoxExtras.SuspendLayout();
            this.groupBoxSexo.SuspendLayout();
            this.groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDadosPrincipais
            // 
            this.groupBoxDadosPrincipais.Controls.Add(this.textBoxCpf);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelEndereco);
            this.groupBoxDadosPrincipais.Controls.Add(this.textBoxEndereco);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelCpf);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelNome);
            this.groupBoxDadosPrincipais.Controls.Add(this.textBoxNome);
            this.groupBoxDadosPrincipais.Location = new System.Drawing.Point(546, 12);
            this.groupBoxDadosPrincipais.Name = "groupBoxDadosPrincipais";
            this.groupBoxDadosPrincipais.Size = new System.Drawing.Size(390, 151);
            this.groupBoxDadosPrincipais.TabIndex = 0;
            this.groupBoxDadosPrincipais.TabStop = false;
            this.groupBoxDadosPrincipais.Text = "Dados Principais";
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(68, 66);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(130, 20);
            this.textBoxCpf.TabIndex = 7;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(7, 115);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(56, 13);
            this.labelEndereco.TabIndex = 6;
            this.labelEndereco.Text = "Endereço:";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(68, 112);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(303, 20);
            this.textBoxEndereco.TabIndex = 5;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(7, 73);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(30, 13);
            this.labelCpf.TabIndex = 3;
            this.labelCpf.Text = "CPF:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(7, 33);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(38, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(68, 30);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(303, 20);
            this.textBoxNome.TabIndex = 0;
            // 
            // groupBoxDadosComplementares
            // 
            this.groupBoxDadosComplementares.Controls.Add(this.groupBoxExtras);
            this.groupBoxDadosComplementares.Controls.Add(this.groupBoxSexo);
            this.groupBoxDadosComplementares.Location = new System.Drawing.Point(546, 169);
            this.groupBoxDadosComplementares.Name = "groupBoxDadosComplementares";
            this.groupBoxDadosComplementares.Size = new System.Drawing.Size(390, 151);
            this.groupBoxDadosComplementares.TabIndex = 7;
            this.groupBoxDadosComplementares.TabStop = false;
            this.groupBoxDadosComplementares.Text = "Dados Compementares";
            // 
            // groupBoxExtras
            // 
            this.groupBoxExtras.Controls.Add(this.checkBoxIdadeDeRisco);
            this.groupBoxExtras.Controls.Add(this.checkBoxDeficiencia);
            this.groupBoxExtras.Location = new System.Drawing.Point(206, 30);
            this.groupBoxExtras.Name = "groupBoxExtras";
            this.groupBoxExtras.Size = new System.Drawing.Size(122, 106);
            this.groupBoxExtras.TabIndex = 9;
            this.groupBoxExtras.TabStop = false;
            this.groupBoxExtras.Text = "Extras";
            // 
            // checkBoxIdadeDeRisco
            // 
            this.checkBoxIdadeDeRisco.AutoSize = true;
            this.checkBoxIdadeDeRisco.Location = new System.Drawing.Point(15, 65);
            this.checkBoxIdadeDeRisco.Name = "checkBoxIdadeDeRisco";
            this.checkBoxIdadeDeRisco.Size = new System.Drawing.Size(98, 17);
            this.checkBoxIdadeDeRisco.TabIndex = 1;
            this.checkBoxIdadeDeRisco.Text = "Idade de Risco";
            this.checkBoxIdadeDeRisco.UseVisualStyleBackColor = true;
            this.checkBoxIdadeDeRisco.CheckedChanged += new System.EventHandler(this.checkBoxIdadeDeRisco_CheckedChanged);
            // 
            // checkBoxDeficiencia
            // 
            this.checkBoxDeficiencia.AutoSize = true;
            this.checkBoxDeficiencia.Location = new System.Drawing.Point(15, 28);
            this.checkBoxDeficiencia.Name = "checkBoxDeficiencia";
            this.checkBoxDeficiencia.Size = new System.Drawing.Size(79, 17);
            this.checkBoxDeficiencia.TabIndex = 0;
            this.checkBoxDeficiencia.Text = "Deficiência";
            this.checkBoxDeficiencia.UseVisualStyleBackColor = true;
            this.checkBoxDeficiencia.CheckedChanged += new System.EventHandler(this.checkBoxDeficiencia_CheckedChanged);
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.radioButtonFeminino);
            this.groupBoxSexo.Controls.Add(this.radioButtonMasculino);
            this.groupBoxSexo.Location = new System.Drawing.Point(68, 30);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(113, 106);
            this.groupBoxSexo.TabIndex = 8;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Sexo";
            // 
            // radioButtonFeminino
            // 
            this.radioButtonFeminino.AutoSize = true;
            this.radioButtonFeminino.Location = new System.Drawing.Point(17, 64);
            this.radioButtonFeminino.Name = "radioButtonFeminino";
            this.radioButtonFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioButtonFeminino.TabIndex = 1;
            this.radioButtonFeminino.TabStop = true;
            this.radioButtonFeminino.Text = "Feminino";
            this.radioButtonFeminino.UseVisualStyleBackColor = true;
            this.radioButtonFeminino.CheckedChanged += new System.EventHandler(this.radioButtonFeminino_CheckedChanged);
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(17, 28);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 0;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            this.radioButtonMasculino.CheckedChanged += new System.EventHandler(this.radioButtonMasculino_CheckedChanged);
            // 
            // buttonCadastrarCliente
            // 
            this.buttonCadastrarCliente.Location = new System.Drawing.Point(546, 351);
            this.buttonCadastrarCliente.Name = "buttonCadastrarCliente";
            this.buttonCadastrarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrarCliente.TabIndex = 8;
            this.buttonCadastrarCliente.Text = "Cadastrar";
            this.buttonCadastrarCliente.UseVisualStyleBackColor = true;
            this.buttonCadastrarCliente.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonAlterarCliente
            // 
            this.buttonAlterarCliente.Location = new System.Drawing.Point(640, 351);
            this.buttonAlterarCliente.Name = "buttonAlterarCliente";
            this.buttonAlterarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarCliente.TabIndex = 9;
            this.buttonAlterarCliente.Text = "Alterar";
            this.buttonAlterarCliente.UseVisualStyleBackColor = true;
            this.buttonAlterarCliente.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(733, 351);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // groupBoxClientes
            // 
            this.groupBoxClientes.Controls.Add(this.dataGridView1);
            this.groupBoxClientes.Location = new System.Drawing.Point(12, 12);
            this.groupBoxClientes.Name = "groupBoxClientes";
            this.groupBoxClientes.Size = new System.Drawing.Size(513, 362);
            this.groupBoxClientes.TabIndex = 7;
            this.groupBoxClientes.TabStop = false;
            this.groupBoxClientes.Text = "Clientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColNome,
            this.ColCpf,
            this.ColEndereco,
            this.ColSexo,
            this.ColDeficiencia,
            this.ColIdadeDeRisco});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(10, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(497, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            // 
            // ColNome
            // 
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            this.ColNome.ReadOnly = true;
            // 
            // ColCpf
            // 
            this.ColCpf.HeaderText = "Cpf";
            this.ColCpf.Name = "ColCpf";
            this.ColCpf.ReadOnly = true;
            // 
            // ColEndereco
            // 
            this.ColEndereco.HeaderText = "Endereço";
            this.ColEndereco.Name = "ColEndereco";
            this.ColEndereco.ReadOnly = true;
            // 
            // ColSexo
            // 
            this.ColSexo.HeaderText = "Sexo";
            this.ColSexo.Name = "ColSexo";
            this.ColSexo.ReadOnly = true;
            // 
            // ColDeficiencia
            // 
            this.ColDeficiencia.HeaderText = "Deficiencia";
            this.ColDeficiencia.Name = "ColDeficiencia";
            this.ColDeficiencia.ReadOnly = true;
            // 
            // ColIdadeDeRisco
            // 
            this.ColIdadeDeRisco.HeaderText = "Idade de Risco";
            this.ColIdadeDeRisco.Name = "ColIdadeDeRisco";
            this.ColIdadeDeRisco.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 26);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.excluirToolStripMenuItem.Text = "excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 388);
            this.Controls.Add(this.groupBoxClientes);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAlterarCliente);
            this.Controls.Add(this.buttonCadastrarCliente);
            this.Controls.Add(this.groupBoxDadosComplementares);
            this.Controls.Add(this.groupBoxDadosPrincipais);
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.groupBoxDadosPrincipais.ResumeLayout(false);
            this.groupBoxDadosPrincipais.PerformLayout();
            this.groupBoxDadosComplementares.ResumeLayout(false);
            this.groupBoxExtras.ResumeLayout(false);
            this.groupBoxExtras.PerformLayout();
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.groupBoxClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDadosPrincipais;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.GroupBox groupBoxDadosComplementares;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.GroupBox groupBoxExtras;
        private System.Windows.Forms.CheckBox checkBoxDeficiencia;
        private System.Windows.Forms.CheckBox checkBoxIdadeDeRisco;
        private System.Windows.Forms.Button buttonCadastrarCliente;
        private System.Windows.Forms.Button buttonAlterarCliente;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.GroupBox groupBoxClientes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDeficiencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdadeDeRisco;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
    }
}