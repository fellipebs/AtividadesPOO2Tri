//Turma: 3B2	
//Nome Completo: Fellipe Barcelos Saraiva

using System;
using System.Windows.Forms;
using BLL;

namespace ProjetoFinanceiro
{
    public partial class frmTransacao : Form
    {
        public frmTransacao()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Limpar();
            txtDescricao.Focus();
        }

        private void Limpar()
        {
            txtId.Text = "";
            txtDescricao.Text = "";
            txtDataLancamento.Text = "";
            cmbConta.Text = "";
            cmbPlanoConta.Text = "";
            txtValor.Text = "";
            rdbReceita.Checked = false;
            rdbDespesa.Checked = false;
        }

        BLL_Transacoes objTransacao = new BLL_Transacoes();
        BLL_Contas objContas = new BLL_Contas();
        BLL_PlanoContas objPlano = new BLL_PlanoContas();

        private void CarregarContas()
        {
            cmbConta.DataSource = objContas.ListarTodasAsContas();
            cmbConta.DisplayMember = "descricao";
            cmbConta.ValueMember = "id";
        }

        private void CarregarPlanoContas()
        {
            cmbPlanoConta.DataSource = objPlano.ListarTodosPlanos();
            cmbPlanoConta.DisplayMember = "descricao";
            cmbPlanoConta.ValueMember = "id";
        }

        private void CarregarGridTransacao()
        {
            gridTransacoes.DataSource = objTransacao.ListarTodasTransacaoes();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                objTransacao.Descricao = txtDescricao.Text;
                objTransacao.DataLancamento = Convert.ToDateTime(txtDataLancamento.Text);
                objTransacao.Conta = int.Parse(cmbConta.SelectedValue.ToString());
                objTransacao.PlanoConta = int.Parse(cmbPlanoConta.SelectedValue.ToString());
                objTransacao.Tipo = rdbReceita.Checked ? "R" : rdbDespesa.Checked ? "D" : "";
                objTransacao.Valor = double.Parse(txtValor.Text);

                if (txtId.Text == "")
                {
                    objTransacao.InserirTransacao();
                    MessageBox.Show("Dados inseridos com sucesso.");
                }
                else
                {
                    objTransacao.IdTransacao = int.Parse(txtId.Text);
                    objTransacao.AlterarTransacao();
                    MessageBox.Show("Dados alterados com sucesso.");
                }
                Limpar();
                CarregarGridTransacao();
            }
       
             catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }  
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirma = MessageBox.Show("Excluir Registro", "Deseja EXCLUIR realmente?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirma == DialogResult.Yes)
            {
                objTransacao.IdTransacao = int.Parse(txtId.Text);
                objTransacao.ExcluirTransacao();
                CarregarGridTransacao();
                Limpar();
            }
        }

        private void ConfigurarGridTransacoes()
        {
            gridTransacoes.Columns["id"].HeaderText 			= "Id";
            gridTransacoes.Columns["descricao"].HeaderText 		= "Descrição";
            gridTransacoes.Columns["tipo"].HeaderText 			= "Tipo";
            gridTransacoes.Columns["data_hora"].HeaderText 		= "Data Lanç.";
            gridTransacoes.Columns["valor"].HeaderText 			= "Valor (R$)";
            gridTransacoes.Columns["tbl_conta_id"].HeaderText 		= "Conta";
            gridTransacoes.Columns["tbl_planoConta_id"].HeaderText 	= "Plano Conta";
        }

        private void GridContas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = gridTransacoes.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDescricao.Text = gridTransacoes.Rows[e.RowIndex].Cells[1].Value.ToString();

                if (gridTransacoes.Rows[e.RowIndex].Cells[2].Value.ToString() == "R")
                    rdbReceita.Checked = true;
                else
                    if (gridTransacoes.Rows[e.RowIndex].Cells[2].Value.ToString() == "D")
                    rdbDespesa.Checked = true;

                txtDataLancamento.Text = gridTransacoes.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtValor.Text = gridTransacoes.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbConta.SelectedValue = gridTransacoes.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbPlanoConta.SelectedValue = gridTransacoes.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void FrmTransacao_Load(object sender, EventArgs e)
        {
            CarregarContas();
            CarregarPlanoContas();
            CarregarGridTransacao();
            ConfigurarGridTransacoes();
        }
    }
}
