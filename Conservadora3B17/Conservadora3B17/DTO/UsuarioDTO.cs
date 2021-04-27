using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class UsuarioDTO
    {
        private int id_usuario;
        private string loginUsuario;
        private string emailUsuario;
        private string senhaUsuario;
        private int tipoUsuario;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string LoginUsuario { get => loginUsuario; set => loginUsuario = value; }
        public string EmailUsuario { get => emailUsuario; set => emailUsuario = value; }
        public string SenhaUsuario { get => senhaUsuario; set => senhaUsuario = value; }
        public int TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
    }
}
