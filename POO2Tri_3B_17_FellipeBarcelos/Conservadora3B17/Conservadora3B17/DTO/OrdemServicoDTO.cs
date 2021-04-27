using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class OrdemServicoDTO
    {
        private int id_os;
        private DateTime dataabertura_os;
        private DateTime dataservico_os;
        private string endereco_os;
        private int numendereco_os;
        private string cep_os;
        private string complemento_os;
        private int vip_os;
        private int horacontratadas_os;
        private string descricao_os;
        private string comentarios_os;
        private int status_os;
        private int id_servico;
        private int id_cliente;
        private int id_prestador;

        public int Id_os { get => id_os; set => id_os = value; }
        public DateTime Dataabertura_os { get => dataabertura_os; set => dataabertura_os = value; }
        public DateTime Dataservico_os { get => dataservico_os; set => dataservico_os = value; }
        public string Endereco_os { get => endereco_os; set => endereco_os = value; }
        public int Numendereco_os { get => numendereco_os; set => numendereco_os = value; }
        public string Cep_os { get => cep_os; set => cep_os = value; }
        public string Complemento_os { get => complemento_os; set => complemento_os = value; }
        public int Vip_os { get => vip_os; set => vip_os = value; }
        public int Horacontratadas_os { get => horacontratadas_os; set => horacontratadas_os = value; }
        public string Descricao_os { get => descricao_os; set => descricao_os = value; }
        public string Comentarios_os { get => comentarios_os; set => comentarios_os = value; }
        public int Status_os { get => status_os; set => status_os = value; }
        public int Id_servico { get => id_servico; set => id_servico = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_prestador { get => id_prestador; set => id_prestador = value; }
    }
}
