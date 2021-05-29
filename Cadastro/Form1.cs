using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        List<Cliente> listaCliente;
        public Form1()
        {
            InitializeComponent();

            listaCliente = new List<Cliente>();

            comboEstadoCivil.Items.Add("Casado");
            comboEstadoCivil.Items.Add("Solteiro");
            comboEstadoCivil.Items.Add("Viuvo");
            comboEstadoCivil.Items.Add("Divorciado");

            comboEstadoCivil.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        #region btnCadastrarAlterar_Click
        private void btnCadastrarAlterar_Click(object sender, EventArgs e)
        {
            int index = -1;

            foreach (var c in listaCliente)
            {
                if (c.Cpf == txtcpf.Text)
                {
                    index = listaCliente.IndexOf(c);
                }

            }

            if (txtNome.Text == "")
            {
                MessageBox.Show("O campo Nome é obrigatório");
                txtNome.Focus();
                return;
            }

            if (txtTelefone.Text == "(  )      -")
            {
                MessageBox.Show("O campo Telefone é obrigatório");
                txtTelefone.Focus();
                return;
            }

            if (txtcpf.Text == "")
            {
                MessageBox.Show("O campo CPF é obrigatório");
                txtcpf.Focus();
                return;
            }

            char sexo;
            if (radioMasculino.Checked)
            {
                sexo = 'M';
            }
            else if (radioFeminino.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = '0';
            }
            //inserindo um novo cadastro
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.DataNascimento = txtDataNascimento.Text;
           
            
            cliente.EstadoCivil = comboEstadoCivil.SelectedItem.ToString();
            cliente.Telefone = txtTelefone.Text;
            cliente.PossuiInvestimento = checkInvestimento.Checked;
            cliente.Sexo = sexo;

            if (index < 0)
            {
                listaCliente.Add(cliente);
            }
            //alterando para um novo valor
            else
            {
                listaCliente[index] = cliente;
            }

            btnLimpar_Click(btnLimpar, EventArgs.Empty);

            Listar();

        }
        #endregion

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int indice = Lista.SelectedIndex;
            listaCliente.RemoveAt(indice);
            Listar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtDataNascimento.Text = "";
            comboEstadoCivil.SelectedIndex = 0;
            txtTelefone.Text = "";
            txtcpf.Text = "";
            checkInvestimento.Checked = false;
            radioMasculino.Checked = true;
            radioFeminino.Checked = false;
            radioOutro.Checked = false;
            txtNome.Focus();

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Listar()
        {
            Lista.Items.Clear();

            foreach (var cliente in listaCliente)
            {
                Lista.Items.Add(cliente.Nome);
            }
        }

        private void Lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = Lista.SelectedIndex;
            Cliente cliente = listaCliente[indice];

            txtNome.Text = cliente.Nome;
            txtcpf.Text = cliente.Cpf;
            txtDataNascimento.Text = cliente.DataNascimento;
            comboEstadoCivil.SelectedItem = cliente.EstadoCivil;
            txtTelefone.Text = cliente.Telefone;
            checkInvestimento.Checked = cliente.PossuiInvestimento;

            switch (cliente.Sexo)
            {
                case 'M':
                    radioMasculino.Checked = true;
                    break;
                case 'F':
                    radioFeminino.Checked = true;
                    break;
                default:
                case 'O':
                    radioOutro.Checked = true;
                    break;
            }
        }
    }
}
