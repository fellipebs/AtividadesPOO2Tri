using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Conservadora
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        public void CarregarGridCategoria()
        {
            gridCategoria.DataSource = new CategoriaBLL().ListarTodasCategorias();
        }

        private void gridCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = gridCategoria.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDescricao.Text = gridCategoria.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CarregarGridCategoria();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                CategoriaDTO categoriaDTO = new CategoriaDTO();
                categoriaDTO.Descricao_categoria = txtDescricao.Text;

                if (txtID.Text == string.Empty)
                {
                    new CategoriaBLL().InserirCategoria(categoriaDTO);
                }
                else
                {
                    categoriaDTO.Id_categoria = Convert.ToInt32(txtID.Text);
                    new CategoriaBLL().AlterarCategoria(categoriaDTO);
                }
                CarregarGridCategoria();
                new LimpaForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim().Length == 0)
                {

                    MessageBox.Show("Você deve escolher uma categoria para poder excluir!");
                }

                else
                {
                    if (MessageBox.Show("Deseja realmente excluir este cara??", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        CategoriaDTO categoriaDTO = new CategoriaDTO();
                        categoriaDTO.Id_categoria = Convert.ToInt32(txtID.Text);

                        new CategoriaBLL().ExcluirCategoria(categoriaDTO);
                        gridCategoria.DataSource = new CategoriaBLL().ListarTodasCategorias();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            new LimpaForm(this);
        }
    }
}
