using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Prova.EtecCSharp.DTO;
using Prova.EtecCSharp.BLL;

namespace Prova.EtecCSharp.UI
{
    public partial class ClienteUI : UserControl
    {
        public ClienteUI()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente novoCliente = new Cliente(); //instancia um nnovo objeto da classe produto do pacote DTO.

            novoCliente.CPF = (String)txtCPF.Text; // joga na propriedade o txt correspondente. Não é preciso fazer o mesmo com ID pois é auto_increment

            //p.Preco = Convert.ToDecimal(txtPreco.Text);
            novoCliente.Nome = txtNomeCliente.Text;
            novoCliente.Endereco = txtEnd.Text;
            novoCliente.Rg = txtRG.Text;


            try
            {

                BLL.ClienteBLL bll = new ClienteBLL();

                bll.NovoCliente(novoCliente); // instancia um objeto BLL e em seguida chama o metodo correspondente jogando o atributo anterior(p) como parametro.
                MessageBox.Show("Cadastro Efetuado com sucesso", "Loja");

            }

            catch (Exception ex)
            {

                MessageBox.Show(" Erro : " + ex.Message.ToString());

            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            BLL.ClienteBLL cli = new ClienteBLL();
            dgvCliente.DataSource = cli.selecionaClientes(txtConsulta.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text = String.Empty;
            txtCPF.Text = String.Empty;
            txtEnd.Text = String.Empty; 
            txtRG.Text = String.Empty; 
        }
    }
}
