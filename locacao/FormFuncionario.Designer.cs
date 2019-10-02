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
            this.groupBoxFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxDadosComplementares.SuspendLayout();
            this.groupBoxSexo.SuspendLayout();
            this.groupBoxDadosPrincipais.SuspendLayout();
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(497, 337);
            this.dataGridView1.TabIndex = 0;
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
            // 
            // buttonCadastrarFuncionario
            // 
            this.buttonCadastrarFuncionario.Location = new System.Drawing.Point(540, 351);
            this.buttonCadastrarFuncionario.Name = "buttonCadastrarFuncionario";
            this.buttonCadastrarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrarFuncionario.TabIndex = 14;
            this.buttonCadastrarFuncionario.Text = "Cadastrar";
            this.buttonCadastrarFuncionario.UseVisualStyleBackColor = true;
            // 
            // groupBoxDadosComplementares
            // 
            this.groupBoxDadosComplementares.Controls.Add(this.groupBoxSexo);
            this.groupBoxDadosComplementares.Location = new System.Drawing.Point(540, 128);
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
            // 
            // groupBoxDadosPrincipais
            // 
            this.groupBoxDadosPrincipais.Controls.Add(this.textBoxMatricula);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelCpf);
            this.groupBoxDadosPrincipais.Controls.Add(this.labelNome);
            this.groupBoxDadosPrincipais.Controls.Add(this.textBoxNome);
            this.groupBoxDadosPrincipais.Location = new System.Drawing.Point(540, 12);
            this.groupBoxDadosPrincipais.Name = "groupBoxDadosPrincipais";
            this.groupBoxDadosPrincipais.Size = new System.Drawing.Size(390, 100);
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
    }
}