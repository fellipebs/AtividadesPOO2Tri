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
    class BLL_Area
    {
        DALProjeto dao;
        public BLL_Area()
        {
            dao = new DALProjeto("localhost", "bd_empresa", "root", "");
        }

        public DataTable ListarAreas()
        {
            return dao.SelectAll("tbl_area");
        }


        public void InserirArea(AreaDTO dto)
        {
            dao.Insert("tbl_area", dto);
        }
        public void AlterarFuncionarios(AreaDTO dto)
        {
            dao.Update("tbl_area", dto, 0);
        }

        public void ExcluirFuncionarios(AreaDTO dto)
        {
            dao.Delete("tbl_area", dto, 0);
        }


    }
}
