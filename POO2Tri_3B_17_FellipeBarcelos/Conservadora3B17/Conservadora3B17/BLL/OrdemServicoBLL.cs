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
    class OrdemServicoBLL
    {
        DALProjeto dao;
        public OrdemServicoBLL()
        {
            dao = new DALProjeto("localhost", "conservadora", "root", "");
        }
        

        public void InserirOrdemServico(OrdemServicoDTO dto)
        {
            dao.Insert("tbl_os", dto);
        }

        public void AlterarOrdemServico(OrdemServicoDTO dto)
        {
            dao.Update("tbl_os", dto, 0);
        }

        public void ExcluirOrdemServico(OrdemServicoDTO dto)
        {
            dao.Delete("tbl_os", dto, 0);
        }

        public DataTable ListarTodasOrdensServicos()
        {
            return dao.SelectAll("tbl_os");
        }

        public DataTable ListarOSAbertasEemAndamento()
        {
            try
            {
                return dao.SelectWhere("tbl_os", "status_os < 2");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void FecharChamadoManualmente(OrdemServicoDTO os)
        {
            try
            {
                os.Status_os = 2;
                dao.ExecutarConsulta($@"UPDATE tbl_os SET status_os = '{os.Status_os}' where id_os = '{os.Id_os}'");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ConsultarOrdemServico(OrdemServicoDTO os)
        {
            try
            {
                return dao.SelectWhere("tbl_os", $"id_os = {os.Id_os}");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable ListarOSCanceladas()
        {
            try
            {
                return dao.SelectWhere("tbl_os", "status_os = 3");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListarOSFinalizadas()
        {
            try
            {
                return dao.SelectWhere("tbl_os", "status_os = 2");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable ListarOSAbertas()
        {
            try
            {
                return dao.ExecutarConsulta(@"SELECT os.dataabertura_os as 'Data Abertura',
                                                     os.endereco_os     as  Endereço,
                                                     os.numendereco_os  as  Número,                           
                                                     os.descricao_os    as Descrição,
                                                     cli.nome_cliente as Cliente,
                                                     pre.nome_prestador as Prestador
                                             FROM    tbl_Os os, tbl_cliente cli, tbl_prestador pre
                                             WHERE   os.status_os = 0 AND
                                                     (os.dataabertura_os < CURRENT_DATE() - 30) AND
                                                     os.id_cliente = cli.id_cliente AND
                                                     os.id_prestador = pre.id_prestador;");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable ListarOsPorPeriodo(DateTime dtInicio, DateTime dtFim)
        {
            try
            {
                return dao.ExecutarConsulta($@"SELECT os.dataabertura_os as 'Data Abertura',
                                                     os.endereco_os     as  Endereço,
                                                     os.numendereco_os  as  Número,                           
                                                     os.descricao_os    as Descrição,
                                                     cli.nome_cliente as Cliente,
                                                     pre.nome_prestador as Prestador
                                             FROM    tbl_Os os, tbl_cliente cli, tbl_prestador pre
                                             WHERE   os.dataabertura_os BETWEEN '{dtInicio.ToString("yyyy/MM/dd")}' AND '{dtFim.ToString("yyyy/MM/dd")}' 
                                                     AND os.id_cliente = cli.id_cliente AND
                                                     os.id_prestador = pre.id_prestador
                                          ORDER BY   os.status_os");
            }
            catch (Exception)
            {
                throw;
            }
        }
        
     public DataTable ListarOSQuantPorStatus()
        {
            try
            {
                return dao.ExecutarConsulta(@"select status_os as status, count(*) as quantidade from tbl_os group by status;");
            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}
