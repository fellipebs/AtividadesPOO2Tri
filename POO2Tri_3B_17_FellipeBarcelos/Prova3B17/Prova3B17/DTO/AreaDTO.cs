using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class AreaDTO
    {
        private int idArea;
        private string descricao;

        public int IdArea { get => idArea; set => idArea = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
