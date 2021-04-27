using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class EditoraDTO
    {
        private int idEditora;
        private string nome;
        private string endereco;

        public int IdEditora { get => idEditora; set => idEditora = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
    }
}
