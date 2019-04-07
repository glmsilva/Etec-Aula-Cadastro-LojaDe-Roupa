using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.EtecCSharp.BLL
{
    public class LogBLL
    {
        public LogBLL()
        {

        }

        public void LoginCriaLog(string parameter)
        {
            try
            {
                if (Directory.Exists(@"C:\LogCSharp") == false)
                {
                    Directory.CreateDirectory(@"C:\LogCSharp");
                    using (StreamWriter arquivoTexto = new StreamWriter(@"C:\LogCSharp\log.txt"))
                    {
                        arquivoTexto.WriteLine("---------------------------------------------------------------------------------------------------------------");
                        arquivoTexto.WriteLine(" -- Iniciando Log --");
                        arquivoTexto.WriteLine("- Nome do Login: " + parameter + "\r\n");
                        arquivoTexto.WriteLine("-- Inicio Log --");
                        arquivoTexto.WriteLine("---------------------------------------------------------------------------------------------------------------");
                    }
                }
                else
                {
                    using (StreamWriter arquivoTexto = new StreamWriter(@"C:\LogCSharp\log.txt"))
                    {
                        arquivoTexto.WriteLine("---------------------------------------------------------------------------------------------------------------");
                        arquivoTexto.WriteLine(" -- Iniciando Log --");
                        arquivoTexto.WriteLine("- Nome do Login: " + parameter + "\r\n");
                        arquivoTexto.WriteLine("-- Inicio Log --");
                        arquivoTexto.WriteLine("---------------------------------------------------------------------------------------------------------------");
                    }
                }

              
            }
            catch (Exception)
            {

            }
        }

        public void AcessoLog(string parameter)
        {
            try
            {
                if (Directory.Exists(@"C:\LogCSharp") == false)
                {
                    Directory.CreateDirectory(@"C:\LogCSharp");
                }

                using (StreamWriter arquivoTexto = new StreamWriter(@"C:\LogCSharp\log.txt"))
                {
                    arquivoTexto.WriteLine("---------------------------------------------------------------------------------------------------------------");
                    
                    arquivoTexto.WriteLine("- Acessou a pagina: " + parameter + "\r\n");
                    
                    arquivoTexto.WriteLine("---------------------------------------------------------------------------------------------------------------");
                }
            }
            catch (Exception)
            {

            }
        }

        public void TerminoLog()
        {
            if (Directory.Exists(@"C:\LogCSharp") == false)
            {
                Directory.CreateDirectory(@"C:\LogCSharp");
                using (StreamWriter arquivoTexto = new StreamWriter(@"C:\LogCSharp\log.txt"))
                {
                    arquivoTexto.WriteLine("---------------------------------------------------------------------------------------------------------------");
                    arquivoTexto.WriteLine(" -- Encerrando Log --");
                    arquivoTexto.WriteLine("-- Termino Log --");
                    arquivoTexto.WriteLine("---------------------------------------------------------------------------------------------------------------");
                }
            }
            else
            {
                using (StreamWriter arquivoTexto = new StreamWriter(@"C:\LogCSharp\log.txt"))
                {
                    arquivoTexto.WriteLine("---------------------------------------------------------------------------------------------------------------");
                    arquivoTexto.WriteLine(" -- Encerrando Log --");
                    arquivoTexto.WriteLine("-- Termino Log --");
                    arquivoTexto.WriteLine("---------------------------------------------------------------------------------------------------------------");
                }
            }

           
            
        }
    }
}
