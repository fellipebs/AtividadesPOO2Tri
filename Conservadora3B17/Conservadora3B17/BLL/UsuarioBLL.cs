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
    class UsuarioBLL
    {
        DALProjeto dao;
        public UsuarioBLL()
        {
            dao = new DALProjeto("localhost", "conservadora", "root", "");
        }

        public int ValidarUsuario(UsuarioDTO dto)
        {
            try
            {
                DataTable bolinho = new DataTable();
                bolinho = dao.SelectWhere("tbl_usuario", $@"tbl_usuario.emailUsuario = '{dto.EmailUsuario}' and tbl_usuario.senhaUsuario = '{dto.SenhaUsuario}'");
                if (bolinho.Rows.Count == 1)
                {
                    return Convert.ToInt32(bolinho.Rows[0]["tipoUsuario"]);
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                throw new Exception("Problemas, você tem problemas.");
            }
        }

        public void InserirUsuario(UsuarioDTO dto)
        {
            dao.Insert("tbl_usuario", dto);
        }

        public void AlterarUsuario(UsuarioDTO dto)
        {
            dao.Update("tbl_usuario", dto, 0);
        }

        public void ExcluirUsuario(UsuarioDTO dto)
        {
            dao.Delete("tbl_usuario", dto, 0);
        }

        public DataTable ListarUsuario()
        {
            return dao.SelectAll("tbl_usuario");
        }

    }
}
