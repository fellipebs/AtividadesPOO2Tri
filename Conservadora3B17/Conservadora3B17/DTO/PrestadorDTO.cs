using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class PrestadorDTO
    {
        private int id_prestador;
        private string nome_prestador;
        private string sobrenome_prestador;
        private string email_prestador;
        private string senha_prestador;
        private string cpf_prestador;
        private int vip_prestador;
        private int id_categoria;

        public int Id_prestador { get => id_prestador; set => id_prestador = value; }
        public string Nome_prestador { get => nome_prestador; set => nome_prestador = value; }
        public string Sobrenome_prestador { get => sobrenome_prestador; set => sobrenome_prestador = value; }
        public string Email_prestador { get => email_prestador; set => email_prestador = value; }
        public string Senha_prestador { get => senha_prestador; set => senha_prestador = value; }
        public string Cpf_prestador { get => cpf_prestador; set => cpf_prestador = value; }
        public int Vip_prestador { get => vip_prestador; set => vip_prestador = value; }
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
    }
}
