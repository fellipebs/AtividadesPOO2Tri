using System;
using System.Windows.Forms;
using BLL;

namespace Conservadora
{
    public partial class Relatorio_Todas_Os_Por_Data : Form
    {
        public Relatorio_Todas_Os_Por_Data()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            DateTime dt1 = Convert.ToDateTime(txtDataInicio.Text);
            DateTime dt2 = Convert.ToDateTime(txtDataFinal.Text);
            dtgRelatorio.DataSource = new OrdemServicoBLL().ListarOsPorPeriodo(dt1, dt2);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
