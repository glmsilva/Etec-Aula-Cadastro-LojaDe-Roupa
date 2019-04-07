using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova.EtecCSharp.UI
{
    public partial class PainelControle : Form
    {
        public PainelControle()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*if (Directory.Exists(@"C:\Users\Aluno\Desktop\ProvaEtec") == false)
            {
                Directory.CreateDirectory(@"C:\Users\Aluno\Desktop\ProvaEtec");
            }

            using (StreamWriter arquivoTexto = new StreamWriter(@"C:\Users\Aluno\Desktop\ProvaEtec\log.txt"))
            {

                arquivoTexto.WriteLine("- Acessou a página do Cliente ");

            }*/
            clienteUI1.BringToFront();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            /*if (Directory.Exists(@"C:\Users\Aluno\Desktop\ProvaEtec") == false)
            {
                Directory.CreateDirectory(@"C:\Users\Aluno\Desktop\ProvaEtec");
            }

            using (StreamWriter arquivoTexto = new StreamWriter(@"C:\Users\Aluno\Desktop\ProvaEtec\log.txt"))
            {

                arquivoTexto.WriteLine("- Acessou a página do Funcionário ");

            }*/

            funcionarioUI1.BringToFront();
            
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            /*
            if (Directory.Exists(@"C:\Users\Aluno\Desktop\ProvaEtec") == false)
            {
                Directory.CreateDirectory(@"C:\Users\Aluno\Desktop\ProvaEtec");
            }

            using (StreamWriter arquivoTexto = new StreamWriter(@"C:\Users\Aluno\Desktop\ProvaEtec\log.txt"))
            {
                
                arquivoTexto.WriteLine("- Acessou a página da Empresa ");
                
            }*/
            empresaUI1.BringToFront();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login login = new Login();
            login.Show();
        }
    }
}
