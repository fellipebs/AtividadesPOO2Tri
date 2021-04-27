using System;
using System.Windows.Forms;
using DTO;
using BLL;


namespace Conservadora
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void CarregarGridClientes()
        {
            dtgClientes.DataSource = new ClienteBLL().ListarTodosClientes();
        }


        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text          = dtgClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text        = dtgClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSobrenome.Text   = dtgClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text       = dtgClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSenha.Text       = dtgClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCPF.Text         = dtgClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CarregarGridClientes();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDTO clienteDTO = new ClienteDTO();
                clienteDTO.Nome_cliente = txtNome.Text;
                clienteDTO.Sobrenome_cliente = txtSobrenome.Text;
                clienteDTO.Email_cliente = txtEmail.Text;
                clienteDTO.Senha_cliente = txtSenha.Text;
                clienteDTO.Cpf_cliente = txtCPF.Text;

                if (txtId.Text == string.Empty)
                {
                    new ClienteBLL().InserirCliente(clienteDTO);
                }
                else
                {
                    clienteDTO.Id_cliente = Convert.ToInt32(txtId.Text);
                    new ClienteBLL().AlterarCliente(clienteDTO);
                }
                CarregarGridClientes();
                new LimpaForm(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.Trim().Length == 0)
                {

                    MessageBox.Show("Você deve escolher um cliente para poder excluir!");
                }

                else
                {
                    if (MessageBox.Show("Deseja realmente excluir este cara??", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        ClienteDTO clienteDTO = new ClienteDTO();
                        clienteDTO.Id_cliente = Convert.ToInt32(txtId.Text);

                        new ClienteBLL().ExcluirCliente(clienteDTO);
                        dtgClientes.DataSource = new ClienteBLL().ListarTodosClientes();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            new LimpaForm(this);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            new LimpaForm(this);
        }

    }
}
