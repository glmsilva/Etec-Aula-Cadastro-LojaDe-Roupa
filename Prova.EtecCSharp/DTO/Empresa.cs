using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.EtecCSharp.DTO
{
    public class Empresa
    {
        string _cnpj;
        string _nomeLoja;
        string _endereco;
        string _porte;

        public string cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        public string NomeLoja
        {
            get { return _nomeLoja; }
            set { _nomeLoja = value; }
        }

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public string Porte
        {
            get { return _porte; }
            set { _porte = value; }
        }

    }
}
