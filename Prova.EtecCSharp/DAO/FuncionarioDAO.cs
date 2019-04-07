using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Prova.EtecCSharp.DTO;
using System.Data;

namespace Prova.EtecCSharp.DAO
{
    class FuncionarioDAO
    {
        string _conexaoMySQL;
        MySqlConnection conexao = null;
        public FuncionarioDAO()
        {
            _conexaoMySQL = "server=localhost;user id=root;password='';database=db_lojaRoupa";
        }

        public DataTable SelectFuncionario(string campo)
        { 
            try
            {
                conexao = new MySqlConnection();
                string cs = "server=localhost;User id=root;password='';database=db_lojaRoupa";
                conexao.ConnectionString = cs;
                conexao.Open();

                string query = "select * from tb_funcionario where cpfFunc ='" + campo + "'";


                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexao);
                DataSet ds = new DataSet();

                adapter.Fill(ds);

                conexao.Clone();

                return ds.Tables[0];
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public void insertFuncionario(Funcionario func)
        {
            try
            {
                conexao = new MySqlConnection();
                string cs = "server=localhost;User id=root;password='';database=db_lojaRoupa";
                conexao.ConnectionString = cs;
                string sql = "INSERT INTO tb_funcionario (id,cpfFunc,nomeFunc,dsEndereco, salario) VALUES (null,@cpfFunc, @nmFunc,@endereco,@salario)";
                conexao = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                
                cmd.Parameters.AddWithValue("@cpfFunc", func.CPF);
                cmd.Parameters.AddWithValue("@nmFunc", func.Nome);
                cmd.Parameters.AddWithValue("@Endereco", func.Endereco);
                cmd.Parameters.AddWithValue("@salario", func.Salario);
       
                conexao.Open();
                cmd.ExecuteNonQuery();

        
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }


    }
}
