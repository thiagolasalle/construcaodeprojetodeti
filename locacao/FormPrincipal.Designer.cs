namespace locacao
{
    partial class FormPrincipal
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.testeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FuncionarioBtn = new System.Windows.Forms.Button();
            this.LocacaoBtn = new System.Windows.Forms.Button();
            this.ClienteBtn = new System.Windows.Forms.Button();
            this.VeiculoBtn = new System.Windows.Forms.Button();
            this.StatusStripPrincipal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.StatusStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(259, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // testeToolStripMenuItem1
            // 
            this.testeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.testeToolStripMenuItem1.Name = "testeToolStripMenuItem1";
            this.testeToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.testeToolStripMenuItem1.Text = "Arquivo";
            this.testeToolStripMenuItem1.Click += new System.EventHandler(this.TesteToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // FuncionarioBtn
            // 
            this.FuncionarioBtn.Location = new System.Drawing.Point(43, 39);
            this.FuncionarioBtn.Name = "FuncionarioBtn";
            this.FuncionarioBtn.Size = new System.Drawing.Size(175, 74);
            this.FuncionarioBtn.TabIndex = 5;
            this.FuncionarioBtn.Text = "Funcionário";
            this.FuncionarioBtn.UseVisualStyleBackColor = true;
            this.FuncionarioBtn.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // LocacaoBtn
            // 
            this.LocacaoBtn.Location = new System.Drawing.Point(43, 333);
            this.LocacaoBtn.Name = "LocacaoBtn";
            this.LocacaoBtn.Size = new System.Drawing.Size(175, 74);
            this.LocacaoBtn.TabIndex = 6;
            this.LocacaoBtn.Text = "Locação";
            this.LocacaoBtn.UseVisualStyleBackColor = true;
            this.LocacaoBtn.Click += new System.EventHandler(this.LocacaoBtn_Click);
            // 
            // ClienteBtn
            // 
            this.ClienteBtn.Location = new System.Drawing.Point(43, 233);
            this.ClienteBtn.Name = "ClienteBtn";
            this.ClienteBtn.Size = new System.Drawing.Size(175, 74);
            this.ClienteBtn.TabIndex = 7;
            this.ClienteBtn.Text = "Cliente";
            this.ClienteBtn.UseVisualStyleBackColor = true;
            this.ClienteBtn.Click += new System.EventHandler(this.ClienteBtn_Click);
            // 
            // VeiculoBtn
            // 
            this.VeiculoBtn.Location = new System.Drawing.Point(43, 140);
            this.VeiculoBtn.Name = "VeiculoBtn";
            this.VeiculoBtn.Size = new System.Drawing.Size(175, 74);
            this.VeiculoBtn.TabIndex = 9;
            this.VeiculoBtn.Text = "Veículo";
            this.VeiculoBtn.UseVisualStyleBackColor = true;
            this.VeiculoBtn.Click += new System.EventHandler(this.VeiculoBtn_Click);
            // 
            // StatusStripPrincipal
            // 
            this.StatusStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.StatusStripPrincipal.Location = new System.Drawing.Point(0, 438);
            this.StatusStripPrincipal.Name = "StatusStripPrincipal";
            this.StatusStripPrincipal.Size = new System.Drawing.Size(259, 22);
            this.StatusStripPrincipal.TabIndex = 10;
            this.StatusStripPrincipal.Text = "statusStrip1";
            this.StatusStripPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusStripPrincipal_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 460);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.StatusStripPrincipal);
            this.Controls.Add(this.VeiculoBtn);
            this.Controls.Add(this.ClienteBtn);
            this.Controls.Add(this.LocacaoBtn);
            this.Controls.Add(this.FuncionarioBtn);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locação System";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.StatusStripPrincipal.ResumeLayout(false);
            this.StatusStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button FuncionarioBtn;
        private System.Windows.Forms.Button LocacaoBtn;
        private System.Windows.Forms.Button ClienteBtn;
        private System.Windows.Forms.Button VeiculoBtn;
        private System.Windows.Forms.StatusStrip StatusStripPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}