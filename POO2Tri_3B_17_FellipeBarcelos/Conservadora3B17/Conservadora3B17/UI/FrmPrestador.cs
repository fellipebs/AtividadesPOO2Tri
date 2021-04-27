using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Conservadora
{
    public partial class FrmPrestador : Form
    {
        public FrmPrestador()
        {
            InitializeComponent();
        }

        private void CarregarGridPrestadores()
        {
            dtgClientes.DataSource = new PrestadorBLL().ListarTodosPrestadores();
        }

        public void CarregaCategoria()
        {

            cmbCategoria.DataSource = new CategoriaBLL().ListarTodasCategorias();
            cmbCategoria.DisplayMember = "descricao_categoria";
            cmbCategoria.ValueMember = "id_categoria";

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            new LimpaForm(this);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrestador_Load(object sender, EventArgs e)
        {
            CarregarGridPrestadores();
            CarregaCategoria();
        }

        private void dtgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dtgClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSobrenome.Text = dtgClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dtgClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSenha.Text = dtgClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCPF.Text = dtgClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbCategoria.Text = dtgClientes.Rows[e.RowIndex].Cells[6].Value.ToString();
            chkVip.Checked = dtgClientes.Rows[e.RowIndex].Cells[7].Value.ToString() == "0" ? false : true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (txtId.Text.Trim().Length == 0)
            {

                MessageBox.Show("Você deve escolher um cliente para poder excluir!");
            }

            else
            {
                if (MessageBox.Show("Deseja realmente excluir este cara??", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    PrestadorDTO prestador = new PrestadorDTO();
                    prestador.Id_prestador = Convert.ToInt32(txtId.Text);

                    new PrestadorBLL().ExcluirPrestador(prestador);
                    dtgClientes.DataSource = new PrestadorBLL().ListarTodosPrestadores();
                    new LimpaForm(this);
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                PrestadorDTO prestadorDTO = new PrestadorDTO();
                prestadorDTO.Nome_prestador = txtNome.Text;
                prestadorDTO.Sobrenome_prestador = txtSobrenome.Text;
                prestadorDTO.Email_prestador = txtEmail.Text;
                prestadorDTO.Senha_prestador = txtSenha.Text;
                prestadorDTO.Cpf_prestador = txtCPF.Text;

                if(chkVip.Checked == true)
                {
                    prestadorDTO.Vip_prestador = 1;
                }
                else
                {
                    prestadorDTO.Vip_prestador = 0;
                }

                prestadorDTO.Id_categoria = Convert.ToInt32(cmbCategoria.SelectedValue);

                if (txtId.Text == string.Empty)
                {
                    new PrestadorBLL().InserirPrestador(prestadorDTO);
                }
                else
                {
                    prestadorDTO.Id_prestador = Convert.ToInt32(txtId.Text);
                    new PrestadorBLL().AlterarPrestador(prestadorDTO);
                }
                CarregarGridPrestadores();
                new LimpaForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
