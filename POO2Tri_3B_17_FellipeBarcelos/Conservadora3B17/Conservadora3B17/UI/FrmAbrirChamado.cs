using System.Windows.Forms;
using DTO;
using BLL;
using System;

namespace Conservadora
{
    public partial class FrmAbrirChamado : Form
    {
        public FrmAbrirChamado()
        {
            InitializeComponent();
        }
        private void CarregarGridOrdemServico()
        {
        }
        public void CarregaTipoServico()
        {

            cbxservico.DataSource = new OrdemServicoBLL().ListarTodasOrdensServicos();
            cbxservico.DisplayMember = "endereco_os";
            cbxservico.ValueMember = "id_servico";

        }

        public void CarregaCliente()
        {

            cbxCliente.DataSource = new ClienteBLL().ListarTodosClientes();
            cbxCliente.DisplayMember = "nome_cliente";
            cbxCliente.ValueMember = "id_cliente";

        }

        public void CarregaPrestador()
        {

            cbxPrestador.DataSource = new PrestadorBLL().ListarTodosPrestadores();
            cbxPrestador.DisplayMember = "nome_prestador";
            cbxPrestador.ValueMember = "id_prestador";

        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void FrmAbrirChamado_Load(object sender, System.EventArgs e)
        {
            CarregaTipoServico();
            CarregaCliente();
            CarregaPrestador();
        }

        private void btnRegistrar_Click(object sender, System.EventArgs e)
        {
            try
            {
                OrdemServicoDTO ordemservicoDTO = new OrdemServicoDTO();
                ordemservicoDTO.Dataabertura_os = DateTime.Now;
                ordemservicoDTO.Dataservico_os = dtpdataservico.Value;
                ordemservicoDTO.Endereco_os = txtEndereco.Text;
                ordemservicoDTO.Numendereco_os = Convert.ToInt32(txtnumero.Text);
                ordemservicoDTO.Cep_os = txtcep.Text;
                ordemservicoDTO.Complemento_os = txtcomplemento.Text;


                if(chkVip.Checked == true)
                {
                    ordemservicoDTO.Vip_os = 1;
                }
                else
                {
                    ordemservicoDTO.Vip_os = 0;
                }
                ordemservicoDTO.Horacontratadas_os = int.Parse(txtHoras.Text);
                ordemservicoDTO.Descricao_os = txtdescricao.Text;
                ordemservicoDTO.Comentarios_os = txtcomplemento.Text;
                ordemservicoDTO.Status_os = 0;
                ordemservicoDTO.Id_servico = Convert.ToInt32(cbxservico.SelectedValue);
                ordemservicoDTO.Id_cliente = Convert.ToInt32(cbxCliente.SelectedValue);
                ordemservicoDTO.Id_prestador = Convert.ToInt32(cbxPrestador.SelectedValue);

                new OrdemServicoBLL().InserirOrdemServico(ordemservicoDTO);
                new LimpaForm(this);

            }
         
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
