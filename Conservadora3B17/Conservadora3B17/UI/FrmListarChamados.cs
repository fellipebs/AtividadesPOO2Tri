using System;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Conservadora
{
    public partial class FrmListarChamados : Form
    {
        public FrmListarChamados()
        {
            InitializeComponent();
        }

        public void CarregaGrid()
        {
            
        }
        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdChamado.Text != string.Empty)
                {
                    OrdemServicoDTO os = new OrdemServicoDTO();
                    os.Id_os = int.Parse(txtIdChamado.Text);

                    dtgChamado.DataSource = new OrdemServicoBLL().ConsultarOrdemServico(os);
                    new OrdemServicoBLL().ConsultarOrdemServico(os);

                    
                    dtpDtAbertura.Value = Convert.ToDateTime(dtgChamado.Rows[0].Cells["dataservico_os"].Value);
                    dtpDtServico.Value = Convert.ToDateTime(dtgChamado.Rows[0].Cells["dataabertura_os"].Value);
                    txtEndereco.Text = dtgChamado.Rows[0].Cells["endereco_os"].Value.ToString();
                    txtnumero.Text = dtgChamado.Rows[0].Cells["numendereco_os"].Value.ToString();
                    txtcomplemento.Text = dtgChamado.Rows[0].Cells["complemento_os"].Value.ToString();
                    txtcep.Text = dtgChamado.Rows[0].Cells["cep_os"].Value.ToString();
                    txtHoras.Text = dtgChamado.Rows[0].Cells["horacontratadas_os"].Value.ToString();
                    txtdescricao.Text = dtgChamado.Rows[0].Cells["descricao_os"].Value.ToString();
                    txtcomentario.Text = dtgChamado.Rows[0].Cells["comentarios_os"].Value.ToString();
                    cmbServico.Text = dtgChamado.Rows[0].Cells["id_servico"].Value.ToString();
                    cmbCliente.Text = dtgChamado.Rows[0].Cells["id_cliente"].Value.ToString();
                    cmbPrestador.Text = dtgChamado.Rows[0].Cells["id_prestador"].Value.ToString();
                    chkVip.Checked = Convert.ToBoolean(dtgChamado.Rows[0].Cells["numendereco_os"].Value);
                }



            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ExibirDados()
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListarChamados_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }
    }
}
