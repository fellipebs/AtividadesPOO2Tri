using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    class EditoraBLL
    {
        private Conexao dao = new Conexao();
        private string tabela = "tbl_editora";
        public DataTable ListarEditora()
        {
            try
            {
                return dao.ExecutarConsulta($@"SELECT * FROM {tabela} ORDER BY nome;");
            }
            catch (Exception e)
            {
                throw new Exception("Error no select");
            }
        }
    }
}
