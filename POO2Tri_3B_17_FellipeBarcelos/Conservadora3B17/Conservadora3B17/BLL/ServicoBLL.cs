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
    class ServicoBLL
    {
        DALProjeto dao;
        public ServicoBLL()
        {
            dao = new DALProjeto("localhost", "conservadora", "root", "");
        }
        
        public void InserirServico(ServicoDTO dto)
        {
            dao.Insert("tbl_servicos", dto);
        }
        public void AlterarServico(ServicoDTO dto)
        {
            dao.Update("tbl_servicos", dto, 0);
        }

        public void ExcluirServico(ServicoDTO dto)
        {
            dao.Delete("tbl_servicos", dto, 0);
        }

        public DataTable ListarTodosServicos()
        {
            return dao.SelectAll("tbl_servicos");
        }

        public DataTable ListarTodasCategorias()
        {
            return dao.SelectAll("tbl_categoria");
        }
    }
}
