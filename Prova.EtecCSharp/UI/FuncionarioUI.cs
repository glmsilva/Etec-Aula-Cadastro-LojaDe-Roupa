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
using Prova.EtecCSharp.DAO;

namespace Prova.EtecCSharp.UI
{
    public partial class FuncionarioUI : UserControl
    {
        public FuncionarioUI()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ValidaFloat validar = new ValidaFloat();
            Funcionario func = new Funcionario();
            FuncionarioBLL novo = new FuncionarioBLL();
            func.Nome = txtNomeFunc.Text;
            func.CPF = txtCPF.Text;
            func.Endereco = txtEnd.Text;
            if (validar.Validar(txtSalario.Text, txtSalario.Name))
            {
                
                func.Salario= float.Parse(txtSalario.Text);
            }

            novo.NovoFuncionario(func);


            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeFunc.Text = String.Empty;
            txtCPF.Text = String.Empty;
            txtEnd.Text = String.Empty;
            
            
            txtSalario.Text = String.Empty;
            
        }

        private void btnBuscaFunc_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string id = txtConsulta.Text;
                BLL.FuncionarioBLL func = new FuncionarioBLL();

                    dgvFunc.DataSource = func.selecionaFuncionario(id);


                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro);
                }

            }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtNomeFunc.Text = String.Empty;
            txtCPF.Text = String.Empty;
            txtEnd.Text = String.Empty;
            
            txtSalario.Text = String.Empty;
        }
    }
}
