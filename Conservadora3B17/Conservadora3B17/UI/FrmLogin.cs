using System;
using System.Windows.Forms;
using BLL;
using DTO;

namespace Conservadora
{
    public partial class FrmLogin : Form
    {
        public int tipoUsuario;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioDTO dto = new UsuarioDTO();
             dto.EmailUsuario = txtEmail.Text;
             dto.SenhaUsuario = txtSenha.Text;

            tipoUsuario = new UsuarioBLL().ValidarUsuario(dto);
            if (tipoUsuario != -1)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Você está negado meu caro, quando se está negado é simples, basta se desrenegar.");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
