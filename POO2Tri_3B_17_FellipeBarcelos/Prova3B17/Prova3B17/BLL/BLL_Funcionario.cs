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
    class BLL_Funcionario
    {
        DALProjeto dao;
        public BLL_Funcionario()
        {
            dao = new DALProjeto("localhost", "bd_empresa", "root", "");
        }

       
        public DataTable ListarFuncionarios()
        {
            return dao.SelectAll("tbl_funcionario");
        }



        public void InserirFuncionarios(FuncionarioDTO dto)
        {
            dao.Insert("tbl_funcionario", dto);
        }
        public void AlterarFuncionarios(FuncionarioDTO dto)
        {
            dao.Update("tbl_funcionario", dto, 0);
        }

        public void ExcluirFuncionarios(FuncionarioDTO dto)
        {
            dao.Delete("tbl_funcionario", dto, 0);
        }

        public DataTable ListarFuncionarioPorPeriodo(int setor, DateTime data)
        {
            try
            {
                return dao.ExecutarConsulta($@"select f.nome, date_format(f.dataAdmissao, '%d/%m/%Y') as dataAdm, f.cargo, a.descricao as Area
                                               from tbl_funcionario f
                                               inner join tbl_area a
                                               on f.idArea = a.idArea
                                               where f.idSetor = '{setor}' and dataAdmissao >= '{data.ToString("yyyy/MM/dd")}' and formaContrato = 'Carteira Assinada'");
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
