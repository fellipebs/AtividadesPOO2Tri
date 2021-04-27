using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Conservadora
{
    public partial class FrmServicos : Form
    {
        public FrmServicos()
        {
            InitializeComponent();
        }

        public void CarregaGrid()
        {
            gridCategoria.DataSource = new ServicoBLL().ListarTodosServicos();
        }

        public void CarregaCategoria()
        {

            cmbCategoria.DataSource = new ServicoBLL().ListarTodasCategorias();
            cmbCategoria.DisplayMember = "descricao_categoria";
            cmbCategoria.ValueMember = "id_categoria";

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ServicoDTO servicoDTO = new ServicoDTO();
                servicoDTO.Descricao_servico = txtDescricao.Text;
                servicoDTO.Valorhora_servico = double.Parse(txtValorHora.Text);
                servicoDTO.Valorhoravip_servico = double.Parse(txtValorHoraVIP.Text);
                servicoDTO.Minimohora_servico = int.Parse(txtTempoMin.Text);
                servicoDTO.Tbl_categoria_id_categoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                if (txtID.Text == string.Empty)
                {
                    new ServicoBLL().InserirServico(servicoDTO);
                }
                else
                {
                    servicoDTO.Id_servico = Convert.ToInt32(txtID.Text);
                    new ServicoBLL().AlterarServico(servicoDTO);
                }
                CarregaGrid();
                new LimpaForm(this);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

}

        private void FrmServicos_Load(object sender, EventArgs e)
        {
            CarregaCategoria();
            CarregaGrid();
        }

        private void gridCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = gridCategoria.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescricao.Text = gridCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtValorHora.Text = gridCategoria.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtValorHoraVIP.Text = gridCategoria.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTempoMin.Text = gridCategoria.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbCategoria.SelectedValue = gridCategoria.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            new LimpaForm(this);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim().Length == 0)
                {

                    MessageBox.Show("Você deve escolher um servico para poder excluir!");
                }

                else
                {
                    if (MessageBox.Show("Deseja realmente excluir este cara??", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        ServicoDTO servicoDTO = new ServicoDTO();
                        servicoDTO.Id_servico = Convert.ToInt32(txtID.Text);

                        new ServicoBLL().ExcluirServico(servicoDTO);
                        gridCategoria.DataSource = new ServicoBLL().ListarTodosServicos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            new LimpaForm(this);
        }

        private void FrmServicos_Load_1(object sender, EventArgs e)
        {
            CarregaCategoria();
            CarregaGrid();
        }

        private void gridCategoria_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = gridCategoria.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescricao.Text = gridCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtValorHora.Text = gridCategoria.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtValorHoraVIP.Text = gridCategoria.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTempoMin.Text = gridCategoria.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbCategoria.SelectedValue = gridCategoria.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Length == 0)
            {

                MessageBox.Show("Você deve escolher um cliente para poder excluir!");
            }

            else
            {
                if (MessageBox.Show("Deseja realmente excluir este cara??", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    ServicoDTO servicoDTO = new ServicoDTO();
                    servicoDTO.Id_servico = Convert.ToInt32(txtID.Text);

                    new ServicoBLL().ExcluirServico(servicoDTO);
                    gridCategoria.DataSource = new ServicoBLL().ListarTodosServicos();
                }
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
