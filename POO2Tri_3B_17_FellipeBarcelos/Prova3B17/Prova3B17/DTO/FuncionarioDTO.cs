using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class FuncionarioDTO
    {
        private int idFuncionario;
        private string nome;
        private DateTime dataAdmissao;
        private string cargo;
        private string formaContrato;
        private int idArea;
        private int idSetor;

        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime DataAdmissao { get => dataAdmissao; set => dataAdmissao = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string FormaContrato { get => formaContrato; set => formaContrato = value; }
        public int IdArea { get => idArea; set => idArea = value; }
        public int IdSetor { get => idSetor; set => idSetor = value; }
    }
}
