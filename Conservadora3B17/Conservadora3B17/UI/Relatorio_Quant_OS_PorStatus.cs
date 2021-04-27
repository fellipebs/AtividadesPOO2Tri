using System;
using System.Windows.Forms;
using BLL;

namespace Conservadora
{
    public partial class Relatorio_Quant_OS_PorStatus : Form
    {
        public Relatorio_Quant_OS_PorStatus()
        {
            InitializeComponent();
        }

        private void Relatorio_Quant_OS_PorStatus_Load(object sender, EventArgs e)
        {
            dtgRelatorio.DataSource = new OrdemServicoBLL().ListarOSQuantPorStatus();
        }
    }
}
