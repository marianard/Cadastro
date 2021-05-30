using Cadastro.Helpers;
using Cadastro.Models;
using Cadastro.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class FrmAddClient : Form
    {
        private readonly ClientRepository repository;

        #region Initialize
        public FrmAddClient()
        {
            InitializeComponent();

            repository = new ClientRepository();

            cbMaritalStatus.Items.Add("Casado");
            cbMaritalStatus.Items.Add("Solteiro");
            cbMaritalStatus.Items.Add("Viúvo");
            cbMaritalStatus.Items.Add("Divorciado");
        }
        #endregion

        #region Events
        private void btnAddOrUpate_Click(object sender, EventArgs e)
        {

            var isValid = IsValid();
            if (!isValid)
                return;

            char gender = rdMale.Checked ? 'M' : rdFemale.Checked ? 'F' : 'O';

            var client = new Client();
            client.Id = int.Parse(string.IsNullOrEmpty(txtId.Text) ? "0" : txtId.Text);
            client.Name = txtName.Text;
            client.BirthDate = txtBirthDate.Text;
            client.Cpf = txtcpf.Text;
            client.MaritalStatus = cbMaritalStatus.SelectedItem.ToString();
            client.Telephone = txtTelephone.Text;
            client.HasInvestments = ckHasInvestiment.Checked;
            client.Gender = gender;

            if (client.Id == 0)
            {
                repository.Add(client);
            }
          
            else
            {
                repository.Update(client.Id, client);
            }

            btnClean_Click(btnClean, EventArgs.Empty);
            LoadGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = dgvClient.CurrentCell?.RowIndex;
            if (!selected.HasValue)
            {
                MessageBox.Show("Não ha registros para excluir");
                return;
            }
            var id = dgvClient.Rows[selected.Value].Cells[0];
            repository.Delete(int.Parse(id.Value.ToString()));
            LoadGrid();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtId.Text = null;
            txtName.Text = null;
            txtBirthDate.Text = null;
            cbMaritalStatus.SelectedIndex = -1;
            txtTelephone.Text = null;
            txtcpf.Text = null;
            ckHasInvestiment.Checked = false;
            rdMale.Checked = false;
            rdFemale.Checked = false;
            rdOther.Checked = false;
            txtName.Focus();
        }

        private void OnMouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = dgvClient.CurrentCell?.RowIndex;
            if (!selected.HasValue)
            {
                MessageBox.Show("Não ha registro para editar");
                return;
            }
            var id = dgvClient.Rows[selected.Value]?.Cells[0];
            if (string.IsNullOrEmpty(id?.Value?.ToString()))
            {
                MessageBox.Show("Não ha registro para editar");
                return;
            }

            var client = repository.Get(int.Parse(id.Value.ToString()));

            txtId.Text = client.Id.ToString();
            txtName.Text = client.Name;
            txtcpf.Text = client.Cpf;
            txtBirthDate.Text = client.BirthDate;
            cbMaritalStatus.SelectedItem = client.MaritalStatus;
            txtTelephone.Text = client.Telephone;
            ckHasInvestiment.Checked = client.HasInvestments;

            switch (client.Gender)
            {
                case 'M':
                    rdMale.Checked = true;
                    break;
                case 'F':
                    rdFemale.Checked = true;
                    break;
                default:
                case 'O':
                    rdOther.Checked = true;
                    break;
            }
        }
        #endregion

        #region Private Methods
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            dgvClient.DataSource = repository.List();
        }

        private bool IsValid()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("O campo Nome é obrigatório");
                txtName.Focus();
                return false;
            }

            if (txtName.TextLength < 2)
            {
                MessageBox.Show("Preencha o nome completo");
                txtName.Focus();
                return false;
            }

            if (txtName.TextLength >= 150)
            {
                MessageBox.Show("O máximo de caracteres para o campo nome é 150.");
                txtName.Focus();
                return false;
            }

            if (txtBirthDate.Value > DateTime.Today)
            {
                MessageBox.Show("A data de nascimento deve ser menor que a data atual");
                txtBirthDate.Focus();
                return false;
            }

            if (cbMaritalStatus.SelectedItem is null)
            {
                MessageBox.Show("O campo Estado Civil é obrigatório");
                cbMaritalStatus.Focus();
                return false;
            }

            if (txtTelephone.Text == "(  )      -")
            {
                MessageBox.Show("O campo Telefone é obrigatório");
                txtTelephone.Focus();
                return false;
            }

            if (!CpfHelper.IsValid(txtcpf.Text))
            {
                MessageBox.Show("O campo CPF é obrigatório");
                txtcpf.Focus();
                return false;
            }

            if (!TelephoneHelper.IsValid(txtTelephone.Text))
            {
                MessageBox.Show("O campo telefone é obrigatório");
                txtTelephone.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(txtId.Text) && repository.GetByCpf(txtcpf.Text) is not null)
            {
                MessageBox.Show("Cliente já cadastrado");
                return false;
            }

            if (!gbGender.Controls.OfType<RadioButton>().Any(x => x.Checked))
            {
                MessageBox.Show("O campo sexo é obrigatório");
                return false;
            }

            return true;
        }
        #endregion
    }
}
