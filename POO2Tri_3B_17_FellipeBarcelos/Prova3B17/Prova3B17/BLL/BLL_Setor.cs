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
    class BLL_Setor
    {

        DALProjeto dao;
        public BLL_Setor()
        {
            dao = new DALProjeto("localhost", "bd_empresa", "root", "");
        }

        public DataTable ListarSetores()
        {
            return dao.SelectAll("tbl_setor");
        }


        public void InserirSetor(SetorDTO dto)
        {
            dao.Insert("tbl_setor", dto);
        }
        public void AlterarSetor(SetorDTO dto)
        {
            dao.Update("tbl_setor", dto, 0);
        }

        public void ExcluirSetor(SetorDTO dto)
        {
            dao.Delete("tbl_setor", dto, 0);
        }
    }
}
