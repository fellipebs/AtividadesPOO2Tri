using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ClienteDTO
    {
        private int id_cliente;
        private string nome_cliente;
        private string sobrenome_cliente;
        private string email_cliente;
        private string senha_cliente;
        private string cpf_cliente;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nome_cliente { get => nome_cliente; set => nome_cliente = value; }
        public string Sobrenome_cliente { get => sobrenome_cliente; set => sobrenome_cliente = value; }
        public string Email_cliente { get => email_cliente; set => email_cliente = value; }
        public string Senha_cliente { get => senha_cliente; set => senha_cliente = value; }
        public string Cpf_cliente { get => cpf_cliente; set => cpf_cliente = value; }
    }
}