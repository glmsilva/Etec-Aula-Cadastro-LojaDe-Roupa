using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova.EtecCSharp.BLL
{
    class ValidaNumeroBLL
    {
        public bool ValidarNumeros(string campoValidar, string nomeCampo)
        {
            try
            {
                int numero;
                numero = int.Parse(campoValidar);
                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("O campo " + nomeCampo + " está inválido", "Etec");
                return false;

            }
        }
    }
}

