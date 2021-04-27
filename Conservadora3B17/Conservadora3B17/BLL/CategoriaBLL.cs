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
    class CategoriaBLL
    {

        DALProjeto dao;
        public CategoriaBLL()
        {
            dao = new DALProjeto("localhost", "conservadora", "root", "");
        }

        public void InserirCategoria(CategoriaDTO dto)
        {
            dao.Insert("tbl_categoria", dto);
        }

        public void AlterarCategoria(CategoriaDTO dto)
        {
            dao.Update("tbl_categoria", dto, 0);
        }

        public void ExcluirCategoria(CategoriaDTO dto)
        {
            dao.Delete("tbl_categoria", dto, 0);
        }

        public DataTable ListarTodasCategorias()
        {
            return dao.SelectAll("tbl_categoria");
        }
    }
}
