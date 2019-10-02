using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace locacao
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void TesteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do programa?", "Exit", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            FormFuncionario formfunc = new FormFuncionario();
            formfunc.ShowDialog();
        }

        private void VeiculoBtn_Click(object sender, EventArgs e)
        {
            FormVeiculo formveic = new FormVeiculo();
            formveic.ShowDialog();
        }

        private void PagamentoBtn_Click(object sender, EventArgs e)
        {
            FormPagamento formpag = new FormPagamento();
            formpag.ShowDialog();
        }

        private void ClienteBtn_Click(object sender, EventArgs e)
        {
            FormCliente formcli = new FormCliente();
            formcli.ShowDialog();
        }

        private void LocacaoBtn_Click(object sender, EventArgs e)
        {
            FormLocacao formloc = new FormLocacao();
            formloc.ShowDialog();
        }

        private void StatusStripPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSobre formsobre = new FormSobre();
            formsobre.ShowDialog();
        }
    }
}
