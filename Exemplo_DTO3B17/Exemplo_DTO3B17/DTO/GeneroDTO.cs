using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class GeneroDTO
    {
        private int idGenero;
        private string descricao;

        public int IdGenero { get => idGenero; set => idGenero = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
