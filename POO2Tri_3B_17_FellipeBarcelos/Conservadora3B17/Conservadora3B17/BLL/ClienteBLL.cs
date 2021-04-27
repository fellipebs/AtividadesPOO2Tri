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
    class ClienteBLL
    {
        DALProjeto dao;

        public ClienteBLL()
        {
            dao = new DALProjeto("localhost", "conservadora", "root", "");
        }

        public void InserirCliente(ClienteDTO dto)
        {
            dao.Insert("tbl_cliente", dto);
        }

        public void AlterarCliente(ClienteDTO dto)
        {
            dao.Update("tbl_cliente", dto, 0);
        }

        public void ExcluirCliente(ClienteDTO dto)
        {
            dao.Delete("tbl_cliente", dto, 0);
        }

        public DataTable ListarTodosClientes()
        {
            return dao.SelectAll("tbl_cliente");
        }

    }
}
