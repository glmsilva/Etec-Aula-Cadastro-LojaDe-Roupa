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
    class LojaBLL
    {
        DAO.LojaDAO lojaDao = null;

        public LojaBLL()
        {

        }

        public DataTable selecionaProdutos(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                lojaDao = new DAO.LojaDAO();
                dt = lojaDao.SelectLoja(id);

            }
            catch (Exception erro)
            {
                erro.Message.ToString();
            }
            return dt;
        }

        public DataTable retornaTabela()
        {

            DataTable dt = new DataTable();
            try
            {
                lojaDao = new DAO.LojaDAO();
                dt = lojaDao.returnTable();
            }catch(Exception erro)
            {
                throw erro;
            }

            return dt;
            

        }



        public void NovaLoja(Empresa loja)
        {

            try
            {
                lojaDao = new DAO.LojaDAO();
                lojaDao.insertLoja(loja);

            }
            catch (Exception erro)
            {

            }
        }





    }
}
