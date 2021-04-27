using System;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Conservadora
{
    public partial class Relatorio_OS_abertas : Form
    {
        public Relatorio_OS_abertas()
        {
            InitializeComponent();
        }

        private void Relatorio_OS_abertas_Load(object sender, EventArgs e)
        {
            dtgRelatorio.DataSource = new OrdemServicoBLL().ListarOSAbertas();
        }
    }
}
