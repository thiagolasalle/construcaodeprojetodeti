namespace locacao
{
    partial class FormFuncionario
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
            this.groupBoxFuncionarios = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAlterarFuncionario = new System.Windows.Forms.Button();
            this.buttonCadastrarFuncionario = new System.Windows.Forms.Button();
            this.groupBoxDadosComplementares = new System.Windows.Forms.GroupBox();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.radioButtonFeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.groupBoxDadosPrincipais = new System.Windows.Forms.GroupBox();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxDadosComplementares.SuspendLayout();
            this.groupBoxSexo.SuspendLayout();
            this.groupBoxDadosPrincipais.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFuncionarios
            // 
            this.groupBoxFuncionarios.Controls.Add(this.dataGridView1);
            this.groupBoxFuncionarios.Location = new System.Drawing.Point(6, 12);
            this.groupBoxFuncionarios.Name = "groupBoxFuncionarios";
            this.groupBoxFuncionarios.Size = new System.Drawing.Size(513, 362);
            this.groupBoxFuncionarios.TabIndex = 12;
            this.groupBoxFuncionarios.TabStop = false;
            this.groupBoxFuncionarios.Text = "Funcionários";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColNome,
            this.ColMatricula,
            this.ColSenha,
            this.ColSexo});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(10, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(497, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(727, 351);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 16;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // buttonAlterarFuncionario
            // 
            this.buttonAlterarFuncionario.Location = new System.Drawing.Point(634, 351);
            this.buttonAlterarFuncionario.Name = "buttonAlterarFuncionario";
            this.buttonAlterarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarFuncionario.TabIndex = 15;
            this.buttonAlterarFuncionario.Text = "Alterar";
            this.buttonAlterarFuncionario.UseVisualStyleBackColor = true;
            this.buttonAlterarFuncionario.Click += new System.EventHandler(this.ButtonAlterarFuncionario_Click);
            // 
            // buttonCadastrarFuncionario
            // 
            this.buttonCadastrarFuncionario.Location = new System.Drawing.Point(540, 351);
            this.buttonCadastrarFuncionario.Name = "buttonCadastrarFuncionario";
            this.buttonCadastrarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrarFuncionario.TabIndex = 14;
            this.buttonCadastrarFuncionario.Text = "Cadastrar";
            this.buttonCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.buttonCadastrarFuncionario.Click += new System.EventHandler(this.ButtonCadastrarFuncionario_Click);
            // 
            // groupBoxDadosComplementares
            // 
            this.groupBoxDadosComplementares.Controls.Add(this.groupBoxSexo);
            this.groupBoxDadosComplementares.Location = new System.Drawing.Point(541, 180);
            this.groupBoxDadosComplementares.Name = "groupBoxDadosComplementares";
            this.groupBoxDadosComplementares.Size = new System.Drawing.Size(390, 151);
            this.groupBoxDadosComplementares.TabIndex = 13;
            this.groupBoxDadosComplementares.TabStop = false;
            this.groupBoxDadosComplementares.Text = "Dados Compementares";
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.radioButtonFeminino);
            this.groupBoxSexo.Controls.Add(this.radioButtonMasculino);
            this.groupBoxSexo.Location = new System.Drawing.Point(149, 29);
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
            this.radioButtonMasculino.CheckedChanged += new System.EventHandler(this.RadioButtonMasculino_CheckedChanged);
            // 
            // groupBoxDadosPrincipais
            // 
            this.groupBoxDadosPrincipais.Controls.Add(this.textBox1);
            this.groupBoxDadosPrincipais.Controls.Add(this.label1);
            this.groupBoxDadosPrincipais.Controls.Add(this.textBoxMatricula);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelCpf);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelNome);
            this.groupBoxDadosPrincipais.Controls.Add(this.textBoxNome);
            this.groupBoxDadosPrincipais.Location = new System.Drawing.Point(540, 12);
            this.groupBoxDadosPrincipais.Name = "groupBoxDadosPrincipais";
            this.groupBoxDadosPrincipais.Size = new System.Drawing.Size(390, 162);
            this.groupBoxDadosPrincipais.TabIndex = 11;
            this.groupBoxDadosPrincipais.TabStop = false;
            this.groupBoxDadosPrincipais.Text = "Dados Principais";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(68, 66);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(194, 20);
            this.textBoxMatricula.TabIndex = 7;
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(7, 73);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(55, 13);
            this.labelCpf.TabIndex = 3;
            this.labelCpf.Text = "Matrícula:";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Senha:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletarToolStripMenuItem.Text = "Deletar";
            this.deletarToolStripMenuItem.Click += new System.EventHandler(this.DeletarToolStripMenuItem_Click);
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
            // ColMatricula
            // 
            this.ColMatricula.HeaderText = "Matricula";
            this.ColMatricula.Name = "ColMatricula";
            this.ColMatricula.ReadOnly = true;
            // 
            // ColSenha
            // 
            this.ColSenha.HeaderText = "Senha";
            this.ColSenha.Name = "ColSenha";
            this.ColSenha.ReadOnly = true;
            // 
            // ColSexo
            // 
            this.ColSexo.HeaderText = "Sexo";
            this.ColSexo.Name = "ColSexo";
            this.ColSexo.ReadOnly = true;
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 390);
            this.Controls.Add(this.groupBoxFuncionarios);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAlterarFuncionario);
            this.Controls.Add(this.buttonCadastrarFuncionario);
            this.Controls.Add(this.groupBoxDadosComplementares);
            this.Controls.Add(this.groupBoxDadosPrincipais);
            this.Name = "FormFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionário";
            this.Load += new System.EventHandler(this.FormFuncionario_Load);
            this.groupBoxFuncionarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxDadosComplementares.ResumeLayout(false);
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.groupBoxDadosPrincipais.ResumeLayout(false);
            this.groupBoxDadosPrincipais.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFuncionarios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAlterarFuncionario;
        private System.Windows.Forms.Button buttonCadastrarFuncionario;
        private System.Windows.Forms.GroupBox groupBoxDadosComplementares;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton radioButtonFeminino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.GroupBox groupBoxDadosPrincipais;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSexo;
    }
}