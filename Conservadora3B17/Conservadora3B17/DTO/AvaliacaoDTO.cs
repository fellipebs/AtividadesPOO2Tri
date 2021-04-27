using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class AvaliacaoDTO
    {
        private int id_avaliacao;
        private int nota_avaliacao;
        private string comentario_avaliacao;
        private int id_cliente;
        private int id_prestador;

        public int Id_avaliacao { get => id_avaliacao; set => id_avaliacao = value; }
        public int Nota_avaliacao { get => nota_avaliacao; set => nota_avaliacao = value; }
        public string Comentario_avaliacao { get => comentario_avaliacao; set => comentario_avaliacao = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_prestador { get => id_prestador; set => id_prestador = value; }
    }
}
