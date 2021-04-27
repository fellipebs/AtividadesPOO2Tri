using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    class GeneroBLL
    {
        private Conexao dao = new Conexao();
        private string tabela = "tbl_genero";

        public DataTable ListarGenero()
        {
            try
            {
                return dao.ExecutarConsulta($@"SELECT * FROM {tabela} ORDER BY descricao;");
            }

            catch (Exception e)
            {
                throw new Exception("Error no select");
            }
        }
    }
}
