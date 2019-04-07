using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prova.EtecCSharp.DTO;
using Prova.EtecCSharp.DAO;

namespace Prova.EtecCSharp.BLL
{
    class ClienteBLL
    {

        DAO.ClienteDAO clienteDao = null;

        public ClienteBLL()
        {

        }

        public DataTable selecionaClientes( string campo)
        {
            DataTable dt = new DataTable();
            try
            {
                clienteDao = new DAO.ClienteDAO();
                dt = clienteDao.SelectCliente(campo);

            }
            catch (Exception erro)
            {
                erro.Message.ToString();
            }
            return dt;
        }

        public void NovoCliente(Cliente cli)
        {

            try
            {
                clienteDao = new DAO.ClienteDAO();
                clienteDao.insertCliente(cli);

            }
            catch (Exception erro)
            {

            }
        }

        public DataTable retornaTabela()
        {

            DataTable dt = new DataTable();
            try
            {
                DAO.ClienteDAO cliDao;
                cliDao = new DAO.ClienteDAO();
                dt = cliDao.returnTable();
            }
            catch (Exception erro)
            {
                throw erro;
            }

            return dt;


        }

    }
}
