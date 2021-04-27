using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class SetorDTO
    {
        private int idSetor;
        private string descricao;

        public int IdSetor { get => idSetor; set => idSetor = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
