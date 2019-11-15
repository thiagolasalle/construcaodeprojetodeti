using Modelo;
using Controle;
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
        private Funcionario p = new Funcionario();


        public FormFuncionario()
        {
            InitializeComponent();
           
        }

        private void CarregarMapaFuncionarios()
        {
            dataGridView1.Rows.Clear();

            FuncionarioController control = new FuncionarioController();

            List<Funcionario> funcionarios = (List<Funcionario>)control.ExecutarOpBD('t', p);

            foreach (Funcionario o in funcionarios)
            {
                dataGridView1.Rows.Add(o.Id, o.Nome, o.Matricula, o.Senha, o.Sexo);
            }
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            CarregarMapaFuncionarios();
        }

        private void MaskedTextBoxCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = CarregarFuncionarioDoForm();

                //Enviar objeto para camada de controle para Salvar no arquivo
                FuncionarioController control = new FuncionarioController();

                Boolean teste = (Boolean)control.ExecutarOpBD('i', funcionario);

                if (teste)
                {
                    MessageBox.Show("Funcionario cadastrado com sucesso!");
                    CarregarMapaFuncionarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR Funcionario: " + ex.Message);
            }
        }

        public Funcionario CarregarFuncionarioDoForm()
        {
            try
            {

                p.Nome = textBoxNome.Text;
                p.Matricula = textBoxMatricula.Text;
                p.Senha = textBox1.Text;

                if (radioButtonMasculino.Checked)
                {
                    p.Sexo = "masculino";
                }
                if (radioButtonFeminino.Checked)
                {
                    p.Sexo = "feminino";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao carregar Funcionario: " + ex.Message);
            }

            return p;
        }

        private void RadioButtonMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAlterarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = CarregarFuncionarioDoForm();

                //Enviar objeto para camada de controle para Salvar no arquivo
                FuncionarioController control = new FuncionarioController();

                Boolean teste = (Boolean)control.ExecutarOpBD('a', funcionario);

                if (teste)
                {
                    MessageBox.Show("Funcionario alterado com sucesso!");
                    CarregarMapaFuncionarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO alterar o Funcionario: " + ex.Message);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Int64 idFuncionario = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value);

                p.Id = idFuncionario;

                FuncionarioController control = new FuncionarioController();

                Funcionario funcionario = (Funcionario)control.ExecutarOpBD('o', p);

                CarregarFormDeFuncionario(funcionario);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO SELECIONAR LINHA: " + ex.Message);
            }
        }

        private void CarregarFormDeFuncionario(Funcionario p)
        {
            try
            {
                textBoxNome.Text = p.Nome;
                textBoxMatricula.Text = p.Matricula;
                textBox1.Text = p.Senha;

                if (p.Sexo == "masculino")
                {
                    radioButtonMasculino.Checked = true;
                }
                if (p.Sexo == "feminino")
                {
                    radioButtonFeminino.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao carregar o FORM: " + ex.Message);
            }
        }

        private void DeletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int64 idFuncionario = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value);

            p.Id = idFuncionario;

            FuncionarioController control = new FuncionarioController();

            Boolean funcionario = (Boolean)control.ExecutarOpBD('d', p);

            CarregarMapaFuncionarios();
        }
    }
}
