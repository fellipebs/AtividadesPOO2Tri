using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    class Conexao
    {
        MySqlConnection conexao;
        private string string_conexao = "Persist security info = false; server = localhost; database = bd_livros; user = root; pwd =;";

        //"Primeiro" método que servira para conectar ao DB e irá abri-lo.

        private void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            } catch(MySqlException ex)
            {
                throw new Exception("Fail to connect to the DB xD");
            }
        }

        public void ExecutarComando(string sql)  // O mesmo método para executar INSERT, UPDATE E DELETE.
        {
            try
            {
                Conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Falha para executar o comando");
            }
            finally
            {
                conexao.Close();
            }
            
        }
        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                Conectar();
                DataTable dados = new DataTable(); // Cria-se uma tabela temporaria na memoria apenas para retornar o select;
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
                da.Fill(dados);
                return dados;
            }
            catch(MySqlException ex)
            {
                throw new Exception("Erro ao executar a consulta");
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}

