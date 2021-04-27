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
    class AvaliacaoBLL
    {
        DALProjeto dao;

        public AvaliacaoBLL()
        {
            dao = new DALProjeto("localhost", "conservadora", "root", "");
        }

        public void InserirAvaliacao(AvaliacaoDTO dto)
        {
            dao.Insert("tbl_avaliacao", dto);
        }

        public void AlterarAvaliacao(AvaliacaoDTO dto)
        {
            dao.Update("tbl_avaliacao", dto, 0);
        }

        public void ExcluirAvaliacao(AvaliacaoDTO dto)
        {
            dao.Delete("tbl_avaliacao", dto, 0);
        }

        public DataTable ListarTodasAvaliacoes()
        {
            return dao.SelectAll("tbl_avaliacao");
        }
    }
}
