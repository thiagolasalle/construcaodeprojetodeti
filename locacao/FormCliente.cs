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
    public partial class FormCliente : Form
    {
        private Cliente p = new Cliente();

        public FormCliente()
        {
            InitializeComponent();
        }


        private void CarregarMapaClientes()
        {
            dataGridView1.Rows.Clear();

            ClienteController control = new ClienteController();

            List<Cliente> clientes = (List<Cliente>)control.ExecutarOpBD('t', p); 

            foreach (Cliente o in clientes)
            {
                dataGridView1.Rows.Add(o.Id, o.Nome, o.Cpf, o.Endereco, o.Sexo, o.Deficiencia, o.IdadeDeRisco);
            }
        }

        //salvar info ao apertar o botão
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = CarregarClienteDoForm();

                //Enviar objeto para camada de controle para Salvar no arquivo
                ClienteController control = new ClienteController();

                Boolean teste = (Boolean)control.ExecutarOpBD('i', cliente);

                if (teste)
                {
                    MessageBox.Show("Cliente cadastrada com sucesso!");
                    CarregarMapaClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR Cliente: " + ex.Message);
            }
        }

        //Carregar dados do formulário em um Novo Objeto do Tipo Cliente
        public Cliente CarregarClienteDoForm()
        {
            try
            {
                
                p.Nome = textBoxNome.Text;
                p.Cpf = textBoxCpf.Text;
                p.Endereco = textBoxEndereco.Text;

                if (radioButtonMasculino.Checked)
                {
                    p.Sexo = "masculino";
                }
                if (radioButtonFeminino.Checked)
                {
                    p.Sexo = "feminino";
                }
                
                p.Deficiencia = checkBoxDeficiencia.Checked;

                p.IdadeDeRisco = checkBoxIdadeDeRisco.Checked;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao carregar cliente: " + ex.Message);
            }

            return p;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = CarregarClienteDoForm();

                //Enviar objeto para camada de controle para Salvar no arquivo
                ClienteController control = new ClienteController();

                Boolean teste = (Boolean)control.ExecutarOpBD('a', cliente);

                if (teste)
                {
                    MessageBox.Show("Cliente alterado com sucesso!");
                    CarregarMapaClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO alterar o Cliente: " + ex.Message);
            }


        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void radioButtonMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDeficiencia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxIdadeDeRisco_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            CarregarMapaClientes();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Int64 idPessoa = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value);

                p.Id = idPessoa;

                ClienteController control = new ClienteController();

                Cliente cliente = (Cliente)control.ExecutarOpBD('o', p);

                CarregarFormDeCliente(cliente);

                /*
                Pessoa p = mapaPessoas[idPessoa];

                frmCadPessoa form = new frmCadPessoa();

                form.Tag = p;

                form.ShowDialog();
                 * */
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO SELECIONAR LINHA: " + ex.Message);
            }
        }

        private void CarregarFormDeCliente(Cliente p)
        {
            try
            {


                textBoxNome.Text = p.Nome;
                textBoxCpf.Text = p.Cpf;
                textBoxEndereco.Text = p.Endereco;

                if (p.Sexo == "masculino" )
                {
                    radioButtonMasculino.Checked = true;
                }
                if (p.Sexo == "feminino" )
                {
                    radioButtonFeminino.Checked = true;
                }
                if (p.Deficiencia == true)
                {
                    checkBoxDeficiencia.Checked = true;
                }
                if (p.Deficiencia == false)
                {
                    checkBoxDeficiencia.Checked = false;
                }
                if (p.IdadeDeRisco == true)
                {
                    checkBoxIdadeDeRisco.Checked = true;
                }
                if (p.IdadeDeRisco == false)
                {
                    checkBoxIdadeDeRisco.Checked = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao carregar o FORM: " + ex.Message);
            }
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            Cliente cliente = CarregarClienteDoForm();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int64 idPessoa = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value);

            p.Id = idPessoa;

            ClienteController control = new ClienteController();

            Boolean cliente = (Boolean)control.ExecutarOpBD('d', p);

            CarregarMapaClientes();
        }

    }
}
