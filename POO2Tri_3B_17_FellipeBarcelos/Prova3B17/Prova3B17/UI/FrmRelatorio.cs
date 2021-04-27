using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Prova3B17
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void PreencheComboSetores()
        {
            cmbSetor.DataSource = new BLL_Setor().ListarSetores();
            cmbSetor.DisplayMember = "descricao";
            cmbSetor.ValueMember = "idSetor";
        }

        private void btnExibir_Click(object sender, System.EventArgs e)
        {
            int setor = Convert.ToInt32(cmbSetor.SelectedValue);
            DateTime data = Convert.ToDateTime(dtpData.Value);
            gridFuncionarios.DataSource = new BLL_Funcionario().ListarFuncionarioPorPeriodo(setor, data);
        }

        private void FrmRelatorio_Load(object sender, System.EventArgs e)
        {
            PreencheComboSetores();
        }
    }
}
