using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class LivroDTO
    {
        private int idLivro;
        private string titulo;
        private string autor;
        private int isbn;
        private int numPaginas;
        private int idEditora;
        private int idGenero;

        public int IdLivro { get => idLivro; set => idLivro = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Isbn { get => isbn; set => isbn = value; }
        public int NumPaginas { get => numPaginas; set => numPaginas = value; }
        public int IdEditora { get => idEditora; set => idEditora = value; }
        public int IdGenero { get => idGenero; set => idGenero = value; }
    }
}
