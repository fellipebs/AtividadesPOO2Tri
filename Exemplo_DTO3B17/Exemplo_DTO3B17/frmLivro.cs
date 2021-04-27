using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Exemplo_DTO3B17
{
    public partial class frmLivros : Form
    {

        private LivroDTO objtLivroDTO = new LivroDTO();
        private LivroBLL objtLivroBLL = new LivroBLL();
        private EditoraBLL objtEditoraBLL = new EditoraBLL(); // para invocar muito sagazmente o listar editouras
        private GeneroBLL objtGeneroBll = new GeneroBLL();

        private void CarregarEditoras()
        {
            cmbEditora.DataSource = objtEditoraBLL.ListarEditora();
            cmbEditora.ValueMember = "idEditora";
            cmbEditora.DisplayMember = "nome";
        }
        private void CarregarGeneros()
        {
            cmbGenero.DataSource = objtGeneroBll.ListarGenero();
            cmbGenero.ValueMember = "idGenero";
            cmbGenero.DisplayMember = "descricao";
        }



        public frmLivros()
        {
            InitializeComponent();
        }
        private void Limpar()
        {
            txtIdLivro.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtISBN.Clear();
            txtNumPaginas.Value = 0;
            cmbEditora.SelectedIndex = -1;
            cmbGenero.SelectedIndex = -1;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdLivro.Text = dtgLivros.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTitulo.Text = dtgLivros.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAutor.Text = dtgLivros.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtISBN.Text = dtgLivros.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNumPaginas.Text = dtgLivros.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbEditora.SelectedValue = dtgLivros.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbGenero.SelectedValue = dtgLivros.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            objtLivroDTO.Titulo = txtTitulo.Text;
            objtLivroDTO.Autor = txtAutor.Text;
            objtLivroDTO.Isbn = Convert.ToInt32(txtISBN.Text);
            objtLivroDTO.NumPaginas = Convert.ToInt32(txtNumPaginas.Value);
            objtLivroDTO.IdEditora = Convert.ToInt32(cmbEditora.SelectedValue);
            objtLivroDTO.IdGenero = Convert.ToInt32(cmbGenero.SelectedValue);

            if (txtIdLivro.Text == string.Empty)
            {
                objtLivroBLL.InserirLivro(objtLivroDTO);
            }
            else
            {
                objtLivroDTO.IdLivro = Convert.ToInt32(txtIdLivro.Text);
                objtLivroBLL.AlterarLivro(objtLivroDTO);
            }
            Limpar();
            ExibirDadosNoDataGrid();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir essa bagaça?", "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objtLivroDTO.IdLivro = Convert.ToInt32(txtIdLivro.Text);
                    objtLivroBLL.ExcluirLivro(objtLivroDTO);
                    ExibirDadosNoDataGrid();
                }
                Limpar();
            }
            catch (FormatException)

            {
                MessageBox.Show("O id deve ser preenchido com um valor numérico.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void ExibirDadosNoDataGrid()
        {
            dtgLivros.DataSource = objtLivroBLL.ListarLivros();
        }


        private void frmLivros_Load(object sender, EventArgs e)
        {
            ExibirDadosNoDataGrid();
            CarregarEditoras();
            CarregarGeneros();
        }
    }
}
