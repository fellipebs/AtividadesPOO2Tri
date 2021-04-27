using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using DAL;

namespace BLL
{
    class PrestadorBLL
    {
        DALProjeto dao;
        public PrestadorBLL()
        {
            dao = new DALProjeto("localhost", "conservadora", "root", "");
        }
        public void InserirPrestador(PrestadorDTO dto)
        {
            dao.Insert("tbl_prestador", dto);
        }
        public void AlterarPrestador(PrestadorDTO dto)
        {
            dao.Update("tbl_prestador", dto, 0);
        }

        public void ExcluirPrestador(PrestadorDTO dto)
        {
            dao.Delete("tbl_prestador", dto, 0);
        }

        public DataTable ListarTodosPrestadores()
        {
            return dao.SelectAll("tbl_prestador");
        }
    }
}
