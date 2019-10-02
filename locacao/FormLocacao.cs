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
    public partial class FormLocacao : Form
    {
        public FormLocacao()
        {
            InitializeComponent();
        }

        private void LabelNome_Click(object sender, EventArgs e)
        {

        }

        private void LabelEndereco_Click(object sender, EventArgs e)
        {

        }

        private void LabelCpf_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAdcPagamento_Click(object sender, EventArgs e)
        {
            FormPagamento formpag = new FormPagamento();
            formpag.ShowDialog();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
