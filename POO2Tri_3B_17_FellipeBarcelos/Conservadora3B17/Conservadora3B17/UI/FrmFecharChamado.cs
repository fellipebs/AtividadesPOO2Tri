using System;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Conservadora
{
    public partial class FrmFecharChamado : Form
    {
        public FrmFecharChamado()
        {
            InitializeComponent();
        }

       

        private void btnFecharChamado_Click(object sender, EventArgs e)
        {
            OrdemServicoDTO os = new OrdemServicoDTO();
            os.Id_os = int.Parse(txtIdChamado.Text);

            new OrdemServicoBLL().FecharChamadoManualmente(os);
            CarregarGridChamados();
            new LimpaForm(this);
        }

        private void FrmFecharChamado_Load(object sender, EventArgs e)
        {
            CarregarGridChamados();
        }

        public void CarregarGridChamados()
        {
            dtgChamados.DataSource = new OrdemServicoBLL().ListarOSAbertasEemAndamento();
        }
    }
}
