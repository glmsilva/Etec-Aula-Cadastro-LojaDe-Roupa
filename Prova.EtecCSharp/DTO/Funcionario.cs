using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.EtecCSharp.DTO
{
    public class Funcionario
    {
       
        string _cpfFunc;
        string _nome;
        string _endereco;
        float _salario;


        public string CPF
        {
            get { return _cpfFunc; }
            set { _cpfFunc = value; }
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


        public float Salario
        {
            get { return _salario; }
            set { _salario = value; }
        }

       

    }
}
