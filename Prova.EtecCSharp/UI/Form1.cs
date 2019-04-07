using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Prova.EtecCSharp.BLL;

namespace Prova.EtecCSharp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection();
            int i = 0;
            try
            {
                
                string con = "server=localhost;User id=root;password='';database=db_lojaRoupa";
                conexao.ConnectionString = con;
                conexao.Open();
                MySqlCommand cmd = conexao.CreateCommand();
                string query = "select * from tb_login where login = '" + txtLogin.Text + "' and senha ='" + txtSenha.Text + "'";
                

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    MessageBox.Show("Você digitou um Login ou Senha invalido");
                }
                else
                {
                    UI.PainelControle painel = new UI.PainelControle();
                    this.Hide();
                    painel.Show();


                }

                



            }catch(Exception erro)
            {
                
            }
            finally
            {
                conexao.Close();
            }

            BLL.LogBLL log = new LogBLL();
            log.LoginCriaLog(txtLogin.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogBLL log = new LogBLL();
            log.TerminoLog();
            this.Dispose();
        }
    }
}
