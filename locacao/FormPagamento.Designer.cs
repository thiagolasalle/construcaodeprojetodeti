namespace locacao
{
    partial class FormPagamento
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
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.groupBoxDadosDePagamento = new System.Windows.Forms.GroupBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelForma = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.groupBoxDadosDePagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(12, 143);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(213, 23);
            this.buttonAdicionar.TabIndex = 18;
            this.buttonAdicionar.Text = "Adicionar Pagamento";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            // 
            // groupBoxDadosDePagamento
            // 
            this.groupBoxDadosDePagamento.Controls.Add(this.comboBoxStatus);
            this.groupBoxDadosDePagamento.Controls.Add(this.labelForma);
            this.groupBoxDadosDePagamento.Controls.Add(this.labelValor);
            this.groupBoxDadosDePagamento.Controls.Add(this.textBoxValor);
            this.groupBoxDadosDePagamento.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDadosDePagamento.Name = "groupBoxDadosDePagamento";
            this.groupBoxDadosDePagamento.Size = new System.Drawing.Size(213, 113);
            this.groupBoxDadosDePagamento.TabIndex = 17;
            this.groupBoxDadosDePagamento.TabStop = false;
            this.groupBoxDadosDePagamento.Text = "Dados de Pagamento";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Cartão Débito",
            "Cartão Crédito",
            "Dinheiro"});
            this.comboBoxStatus.Location = new System.Drawing.Point(68, 65);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(132, 21);
            this.comboBoxStatus.TabIndex = 10;
            // 
            // labelForma
            // 
            this.labelForma.AutoSize = true;
            this.labelForma.Location = new System.Drawing.Point(7, 73);
            this.labelForma.Name = "labelForma";
            this.labelForma.Size = new System.Drawing.Size(39, 13);
            this.labelForma.TabIndex = 3;
            this.labelForma.Text = "Forma:";
            this.labelForma.Click += new System.EventHandler(this.LabelCpf_Click);
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(7, 33);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(34, 13);
            this.labelValor.TabIndex = 1;
            this.labelValor.Text = "Valor:";
            this.labelValor.Click += new System.EventHandler(this.LabelNome_Click);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(68, 30);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(132, 20);
            this.textBoxValor.TabIndex = 0;
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 180);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.groupBoxDadosDePagamento);
            this.Name = "FormPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.groupBoxDadosDePagamento.ResumeLayout(false);
            this.groupBoxDadosDePagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.GroupBox groupBoxDadosDePagamento;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelForma;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox textBoxValor;
    }
}