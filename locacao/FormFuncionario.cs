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
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
           
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void MaskedTextBoxCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
