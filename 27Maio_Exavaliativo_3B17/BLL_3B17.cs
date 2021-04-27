//Turma: 3B2	
//Nome Completo: Fellipe Barcelos Saraiva

using System;
using System.Data;
using DAL;

namespace CamadaDeNegocios
{
    class BLL_Transacoes
    {

        string tabela;

        public BLL_Transacoes()
        {
            tabela = "tbl_transacao";
        }

        private int idTransacao, conta, planoConta;
        private string descricao, tipo;
        private DateTime dataLancamento;
        private double valor;

        public int IdTransacao
        {
            get { return idTransacao; }
            set { idTransacao = value; }
        }
        //descricao -> obrigatorio OK / tipo- >r ou d  / data menor que a de hoje
        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                if(value == string.Empty)
                {
                    throw new Exception("Preencha com amor e carinho a descrição pois ela é obrigatória.");
                }
                else
                {
                    descricao = value;
                }   
               
            }
        }

        public int Conta
        {
            get { return conta; }
            set { conta = value; }
        }

        public DateTime DataLancamento
        {
            get
            {
              return dataLancamento;
            }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new Exception("Preencha com uma data anterior a do dia de hoje");
                }
                else
                {
                    dataLancamento = value;
                }
              
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                if(value != "d" && value != "r")
                {
                    throw new Exception("Preencha com r ou d.");
                }
                else
                {
                    tipo = value;
                }
                
            }
        }

        public int PlanoConta
        {
            get { return planoConta; }
            set { planoConta = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        Conexao dao = new Conexao();

        public void InserirTransacao()
        {
            try
            {
                string inserir = string.Format($@"INSERT INTO {tabela} VALUES (NULL, 
                                             				   '{Descricao}', '{Tipo}', 
                                             				   '{DataLancamento.ToString("yyyy/MM/dd")}', 
                                             				   '{Valor}','{Conta}', '{PlanoConta}')");
                dao.ExecutarComando(inserir);
            }
            catch(Exception e)
            {
                throw new Exception("Erro no insert.");
            }
        }

        public void AlterarTransacao()
        {
            try
            {
                string alterar = string.Format($@"UPDATE {tabela} SET descricao = '{Descricao}', 
								tipo = '{Tipo}', 
								data_hora = '{DataLancamento.ToString("yyyy/MM/dd")}', 
								valor = '{Valor}', 
								tbl_conta_id = '{Conta}', 
							  WHERE id = '{idTransacao}'");
                dao.ExecutarComando(alterar);

            }
            catch(Exception e) {

                throw new Exception("Erro no update.");
            }


        }

        public void ExcluirTransacao()
        {
            try
            {
                string excluir = "DELETE FROM {tabela} WHERE id = " + IdTransacao;
                dao.ExecutarComando(excluir);
            }
            catch(Exception e)
            {
                throw new Exception("Erro no delete.");
            }

        }

        public DataTable ListarTodasTransacaoes()
        {
            try
            {
                string sql = "SELECT * FROM {tabela};";
                return dao.ExecutarConsulta(sql);
            }
            catch(Exception e)
            {
                throw new Exception("Erro no select.");
            }  
        }

        public DataTable Listar(string comando)
        {
            try
            {
               return dao.ExecutarConsulta(comando);
            }
            catch(Exception e)
            {
                throw new Exception("Erro no select com parametro.");
            }
            
        }
    }
}

