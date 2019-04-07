using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prova.EtecCSharp.DTO;
using Prova.EtecCSharp.BLL;

namespace Prova.EtecCSharp.UI
{
    public partial class EmpresaUI : UserControl
    {
        public EmpresaUI()
        {
            InitializeComponent();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtConsulta.Text);
                BLL.LojaBLL loja = new BLL.LojaBLL();

                dgvEmpresa.DataSource = loja.selecionaProdutos(id);

                
            }catch(Exception erro)
            {
                MessageBox.Show("Erro: " + erro);
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            Empresa novaLoja = new Empresa(); //instancia um nnovo objeto da classe produto do pacote DTO.

            novaLoja.cnpj = (String)txtCNPJ.Text; // joga na propriedade o txt correspondente. Não é preciso fazer o mesmo com ID pois é auto_increment

            //p.Preco = Convert.ToDecimal(txtPreco.Text);
            novaLoja.NomeLoja = txtNome.Text;
            novaLoja.Endereco = txtEnd.Text;
            novaLoja.Porte = cmbPorte.Text;

            try
            {

                BLL.LojaBLL bll = new LojaBLL();

                bll.NovaLoja(novaLoja); // instancia um objeto BLL e em seguida chama o metodo correspondente jogando o atributo anterior(p) como parametro.
                MessageBox.Show("Cadastro Efetuado com sucesso", "Loja");

            }

            catch (Exception ex)
            {

                MessageBox.Show(" Erro : " + ex.Message.ToString());

            }
        }

        private void EmpresaUI_Load(object sender, EventArgs e)
        {
            BLL.LojaBLL bll = new LojaBLL();
            dgvEmpresa.DataSource = bll.retornaTabela();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCNPJ.Text = String.Empty; ;
            txtConsulta.Text = String.Empty; ;
            txtEnd.Text = String.Empty; ;
            txtNome.Text = String.Empty;
            cmbPorte.Text = String.Empty; 
        }
    }
}
