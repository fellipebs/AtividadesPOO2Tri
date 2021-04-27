using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    class LivroBLL
    {
        private Conexao dao = new Conexao();
        private string tabela = "tbl_livro";
        public void InserirLivro(LivroDTO dto) // o objeto dto vem como parametro do formulario
        {
            try
            {
                dao.ExecutarComando($@"INSERT INTO {tabela} VALUES (NULL, '{dto.Titulo}', '{dto.Autor}', '{dto.Isbn}',
                                                                          '{dto.NumPaginas}', '{dto.IdEditora}', '{dto.IdGenero}')");
            }
            catch (Exception e)
            {
                throw new Exception("ERROR INSERT");
            }
        }
        public void AlterarLivro(LivroDTO dto)
        {
            try
            {
                dao.ExecutarComando($@"UPDATE {tabela} SET titulo = '{dto.Titulo}',
                                                           autor = '{dto.Autor}',
                                                           isbn = '{dto.Isbn}',
                                                           numPaginas = '{dto.NumPaginas}',
                                                           idEditora = '{dto.IdEditora}',
                                                           idGenero = '{dto.IdGenero}'
                                                   WHERE   idLivro = '{dto.IdLivro}'");
            }
            catch (Exception e)
            {
                throw new Exception("ERROR Update");
            }
        }

        public void ExcluirLivro(LivroDTO dto)
        {
            try
            {
                dao.ExecutarComando($@"DELETE FROM {tabela} WHERE idLivro = '{dto.IdLivro}';");
            }

            catch (Exception e)
            {
                throw new Exception("ERROR Delete");
            }
        }
        public DataTable ListarLivros()
        {
            return dao.ExecutarConsulta($@"SELECT * FROM {tabela} ORDER BY titulo;");
        }
    }
}
