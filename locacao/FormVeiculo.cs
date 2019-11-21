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
    public partial class FormVeiculo : Form
    {
        private Veiculo p = new Veiculo();

        public FormVeiculo()
        {
            InitializeComponent();
        }

        private void CarregarMapaVeiculos()
        {
            dataGridView1.Rows.Clear();

            VeiculoController control = new VeiculoController();

            List<Veiculo> veiculos = (List<Veiculo>)control.ExecutarOpBD('t', p);

            foreach (Veiculo o in veiculos)
            {
                dataGridView1.Rows.Add(o.Id, o.Marca, o.Cor, o.Placa, o.status);
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo veiculo = CarregarVeiculoDoForm();

                //Enviar objeto para camada de controle para Salvar no arquivo
                VeiculoController control = new VeiculoController();

                Boolean teste = (Boolean)control.ExecutarOpBD('i', veiculo);

                if (teste)
                {
                    MessageBox.Show("Veiculo cadastrado com sucesso!");
                    CarregarMapaVeiculos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR Veiculo: " + ex.Message);
            }
        }

        public Veiculo CarregarVeiculoDoForm()
        {
            try
            {
                p.Marca = textBoxMarca.Text;
                p.Cor = textBoxCor.Text;
                p.Placa = textBoxPlaca.Text;
                p.status = comboBoxStatus.Text;
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao carregar veiculo: " + ex.Message);
            }

            return p;
        }

        private void ComboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAlterarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo veiculo = CarregarVeiculoDoForm();

                //Enviar objeto para camada de controle para Salvar no arquivo
                VeiculoController control = new VeiculoController();

                Boolean teste = (Boolean)control.ExecutarOpBD('a', veiculo);

                if (teste)
                {
                    MessageBox.Show("Veiculo alterado com sucesso!");
                    CarregarMapaVeiculos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO alterar o Veiculo: " + ex.Message);
            }
        }

        private void FormVeiculo_Load(object sender, EventArgs e)
        {
            CarregarMapaVeiculos();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Int64 idVeiculo = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value);
                p.Id = idVeiculo;

                VeiculoController control = new VeiculoController();

                Veiculo veiculo = (Veiculo)control.ExecutarOpBD('o', p);

                CarregarFormDeVeiculo(veiculo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO SELECIONAR LINHA: " + ex.Message);
            }
        }

        private void CarregarFormDeVeiculo(Veiculo p)
        {
            try
            {
                textBoxMarca.Text = p.Marca;
                textBoxCor.Text = p.Cor;
                textBoxPlaca.Text = p.Placa;
                comboBoxStatus.Text = p.status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao carregar o FORM: " + ex.Message);
            }
        }

        private void ExcluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int64 idVeiculo = Convert.ToInt64(dataGridView1.SelectedRows[0].Cells[0].Value);

            p.Id = idVeiculo;

            VeiculoController control = new VeiculoController();

            Boolean veiculo = (Boolean)control.ExecutarOpBD('d', p);

            CarregarMapaVeiculos();
        }

        private void TextBoxPlaca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
