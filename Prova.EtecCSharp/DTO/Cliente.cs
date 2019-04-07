using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.EtecCSharp.DTO
{
    public class Cliente
    {

        string _cpf;
        string _nome;
        string _endereco;
        string _rg;

       public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }


        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public string Rg
        {
            get { return _rg; }
            set { _rg = value; }
        }

    }
}
