using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controle;
using Modelo;

namespace locacao
{
    public partial class FormLocacao : Form
    {
        private Locacao p = new Locacao();
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

        private void FormLocacao_Load(object sender, EventArgs e)
        {
            CarregarMapaLocacoes();
        }

        private void CarregarMapaLocacoes()
        {
            dataGridView1.Rows.Clear();

            LocacaoController control = new LocacaoController();

            List<Locacao> locacoes = (List<Locacao>)control.ExecutarOpBD('t', p);

            foreach (Locacao o in locacoes)
            {
                dataGridView1.Rows.Add(o.Id, o.DataLocacao, o.DataEntrega, o.Status);
            }
        }

        private void ButtonCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Locacao locacao = CarregarLocacaoDoForm();

                //Enviar objeto para camada de controle para Salvar no arquivo
                LocacaoController control = new LocacaoController();

                Boolean teste = (Boolean)control.ExecutarOpBD('i', locacao);

                if (teste)
                {
                    MessageBox.Show("Locacao cadastrado com sucesso!");
                    CarregarMapaLocacoes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR Locacao: " + ex.Message);
            }
        }

        public Locacao CarregarLocacaoDoForm()
        {
            try
            {
                p.DataLocacao = Convert.ToDateTime(maskedTextBoxDataLocacao.Text);
                p.DataEntrega = Convert.ToDateTime(maskedTextBoxDataEntrega.Text); 
                p.Status = comboBox1.Text;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao carregar Locacao: " + ex.Message);
            }

            return p;
        }

        private void MaskedTextBoxDataLocacao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAlterarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Locacao locacao = CarregarLocacaoDoForm();

                //Enviar objeto para camada de controle para Salvar no arquivo
                LocacaoController control = new LocacaoController();

                Boolean teste = (Boolean)control.ExecutarOpBD('a', locacao);

                if (teste)
                {
                    MessageBox.Show("Locacao alterado com sucesso!");
                    CarregarMapaLocacoes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO alterar o Locacao: " + ex.Message);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Int64 idLocacao = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value);
                p.Id = idLocacao;

                LocacaoController control = new LocacaoController();

                Locacao locacao = (Locacao)control.ExecutarOpBD('o', p);

                CarregarFormDeLocacao(locacao);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO SELECIONAR LINHA: " + ex.Message);
            }
        }

        private void CarregarFormDeLocacao(Locacao p)
        {
            try
            {
                maskedTextBoxDataLocacao.Text = Convert.ToString(p.DataLocacao);
                maskedTextBoxDataEntrega.Text = Convert.ToString(p.DataEntrega);
                comboBox1.Text = p.Status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao carregar o FORM: " + ex.Message);
            }
        }

        private void ExcluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int64 idLocacao = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value);

            p.Id = idLocacao;

            LocacaoController control = new LocacaoController();

            Boolean locacao = (Boolean)control.ExecutarOpBD('d', p);

            CarregarMapaLocacoes();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ExcluirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Int64 idLocacao = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value);

            p.Id = idLocacao;

            LocacaoController control = new LocacaoController();

            Boolean locacao = (Boolean)control.ExecutarOpBD('d', p);

            CarregarMapaLocacoes();
        }
    }
}
