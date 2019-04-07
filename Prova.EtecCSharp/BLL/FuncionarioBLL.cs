using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova.EtecCSharp.DTO;
using Prova.EtecCSharp.DAO;
using System.Data;

namespace Prova.EtecCSharp.BLL
{
    class FuncionarioBLL
    {
        DAO.FuncionarioDAO funcDao = new FuncionarioDAO();

        public FuncionarioBLL()
        {

        }

        public DataTable selecionaFuncionario(string cpf)
        {
            DataTable dt = new DataTable();
            try
            {
                funcDao = new DAO.FuncionarioDAO();
                dt = funcDao.SelectFuncionario(cpf);

            }
            catch (Exception erro)
            {
                erro.Message.ToString();
            }
            return dt;
        }

        public void NovoFuncionario(Funcionario func)
        {

            try
            {
                funcDao = new DAO.FuncionarioDAO();
                funcDao.insertFuncionario(func);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
