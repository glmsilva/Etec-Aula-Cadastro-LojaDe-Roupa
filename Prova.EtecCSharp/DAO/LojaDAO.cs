using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Prova.EtecCSharp.DTO;

namespace Prova.EtecCSharp.DAO
{
    public class LojaDAO
    {
        String _conexaoMySQL = String.Empty;
        MySqlConnection conexao = null;

        public LojaDAO()
        {
            _conexaoMySQL = "server=localhost;user id=root;password='';database=db_lojaRoupa";
        }


        public DataTable SelectLoja(int campo)
        {
            try
            {
               
            
            conexao = new MySqlConnection();
            string cs = "server=localhost;User id=root;password='';database=db_lojaRoupa";
            conexao.ConnectionString = cs;
            conexao.Open();

            string sqlStatement = "SELECT * FROM tb_loja where id = '" + campo + "'";

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
          

        public void insertLoja(Empresa loja)
        {
            try
            {
                String sql = "INSERT INTO tb_loja (id,cnpj,nomeLoja,dsEndereco,porte) VALUES (null, @cnpj,@nmLoja,@endereco,@porte)";
                conexao = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@cnpj", loja.cnpj);
                cmd.Parameters.AddWithValue("@nmLoja", loja.NomeLoja);
                cmd.Parameters.AddWithValue("@endereco", loja.Endereco);
                cmd.Parameters.AddWithValue("@porte", loja.Porte);
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

            string sqlStatement = "SELECT * FROM tb_loja";

            MySqlDataAdapter mda = new MySqlDataAdapter(sqlStatement, msc);

            DataSet ds = new DataSet();

            mda.Fill(ds);

            msc.Close();

            return ds.Tables[0];
        }
    }
}
