using System;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Prova3B17
{
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            new LimpaForm(this);
        }

        private void PreencheComboAreas()
        {
            cmbArea.DataSource = new BLL_Area().ListarAreas();
            cmbArea.DisplayMember = "descricao";
            cmbArea.ValueMember = "idArea";
        }

        private void PreencheComboSetores()
        {
            cmbSetor.DataSource = new BLL_Setor().ListarSetores();
            cmbSetor.DisplayMember = "descricao";
            cmbSetor.ValueMember = "idSetor";
        }

        private void PreencheGridFuncionarios()
        {
            gridFuncionarios.DataSource = new BLL_Funcionario().ListarFuncionarios();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            try
            {
                FuncionarioDTO funcionarioDTO = new FuncionarioDTO();
                funcionarioDTO.Nome = txtNome.Text;
                funcionarioDTO.DataAdmissao = dtpDtAdmissao.Value;
                funcionarioDTO.Cargo = txtCargo.Text;
                funcionarioDTO.FormaContrato = cmbFormaContrato.Text;
                funcionarioDTO.IdArea = Convert.ToInt32(cmbArea.SelectedValue);
                funcionarioDTO.IdSetor = Convert.ToInt32(cmbSetor.SelectedValue);

            

                if (txtIdFuncionario.Text == string.Empty)
                {
                    new BLL_Funcionario().InserirFuncionarios(funcionarioDTO);
                }
                else
                {
                    funcionarioDTO.IdFuncionario = Convert.ToInt32(txtIdFuncionario.Text);
                    new BLL_Funcionario().AlterarFuncionarios(funcionarioDTO);
                }
                PreencheGridFuncionarios();
                new LimpaForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (txtIdFuncionario.Text.Trim().Length == 0)
            {

                MessageBox.Show("Você deve escolher um funcionario para poder excluir!");
            }

            else
            {
                if (MessageBox.Show("Deseja realmente excluir este cara??", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    FuncionarioDTO funcionario = new FuncionarioDTO();
                    funcionario.IdFuncionario = Convert.ToInt32(txtIdFuncionario.Text);

                    new BLL_Funcionario().ExcluirFuncionarios(funcionario);
                    gridFuncionarios.DataSource = new BLL_Funcionario().ListarFuncionarios();
                    new LimpaForm(this);
                }
            }


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridContratos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdFuncionario.Text = gridFuncionarios.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = gridFuncionarios.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpDtAdmissao.Value = Convert.ToDateTime(gridFuncionarios.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtCargo.Text = gridFuncionarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbFormaContrato.Text = gridFuncionarios.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbArea.SelectedValue = gridFuncionarios.Rows[e.RowIndex].Cells[5].Value;
            cmbSetor.SelectedValue = gridFuncionarios.Rows[e.RowIndex].Cells[6].Value;
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            new FrmRelatorio().ShowDialog();
        }

        private void FrmContrato_Load(object sender, EventArgs e)
        {
            PreencheComboAreas();
            PreencheComboSetores();
            PreencheGridFuncionarios();
        }
    }
}
