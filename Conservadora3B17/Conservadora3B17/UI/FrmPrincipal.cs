using System;
using System.Windows.Forms;

namespace Conservadora
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCliente().Show();
        }

        private void ordemServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAbrirChamado().Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCategoria().Show();
        }

        private void prestadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPrestador().Show();
        }

        private void servicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmServicos().Show();
        }

        private void fecharChamadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmFecharChamado().Show();
        }

        private void listarChamadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmListarChamados().Show();
        }

        private void relatorioOsAbertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Relatorio_OS_abertas().Show();
        }

        private void relatorioOsPorDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Relatorio_Todas_Os_Por_Data().Show();
        }

        private void relatorioOsPorStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Relatorio_Quant_OS_PorStatus().Show();
        }
    }
}
