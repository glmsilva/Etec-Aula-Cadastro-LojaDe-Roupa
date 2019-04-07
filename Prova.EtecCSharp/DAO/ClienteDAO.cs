using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Prova.EtecCSharp.DTO;

namespace Prova.EtecCSharp.DAO
{
    class ClienteDAO
    {

        String _conexaoMySQL = String.Empty;
        MySqlConnection conexao = null;

        public ClienteDAO()
        {
            _conexaoMySQL = "server=localhost;user id=root;password='';database=db_lojaRoupa";
        }

        public DataTable SelectCliente(string campo)
        {

            try
            {


                conexao = new MySqlConnection();
                string cs = "server=localhost;User id=root;password='';database=db_lojaRoupa";
                conexao.ConnectionString = cs;
                conexao.Open();

                string sqlStatement = "SELECT * FROM tb_cliente where cpf = '" + campo + "'";

                MySqlDataAdapter mda = new MySqlDataAdapter(sqlStatement, conexao);

                DataSet ds = new DataSet();

                mda.Fill(ds);

                conexao.Close();

                return ds.Tables[0];
            }

            catch (Exception erro)
            {
                throw erro;
            }
            
         

        }

        public void insertCliente(Cliente cliente)
        {
            try
            {
                String sql = "INSERT INTO tb_cliente (id,nome,cpf,rg,endereco) VALUES (null,@nome,@cpf,@rg,@endereco)";
                conexao = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@cpf", cliente.CPF);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@rg", cliente.Rg);
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

        public DataTable returnTable()
        {
            MySqlConnection msc = new MySqlConnection();
            string cs = "server=localhost;User id=root;password='';database=db_lojaRoupa";
            msc.ConnectionString = cs;
            msc.Open();

            string sqlStatement = "SELECT * FROM tb_cliente";

            MySqlDataAdapter mda = new MySqlDataAdapter(sqlStatement, msc);

            DataSet ds = new DataSet();

            mda.Fill(ds);

            msc.Close();

            return ds.Tables[0];
        }
    }
}
