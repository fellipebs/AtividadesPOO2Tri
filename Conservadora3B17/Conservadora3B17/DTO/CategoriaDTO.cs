using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class CategoriaDTO
    {
        private int id_categoria;
        private string descricao_categoria;

        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Descricao_categoria { get => descricao_categoria; set => descricao_categoria = value; }
    }
}
