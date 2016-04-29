using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC_VENDAS.CONTROLLER;
using MVC_VENDAS.MODEL;

namespace MVC_VENDAS.VIEW
{
    public partial class frmFuncionariosWCF : Form
    {
        static int idEdicao;

        public frmFuncionariosWCF()
        {
            InitializeComponent();
        }

        private void HandShake(Action<CFuncionarioWCF.CFuncionarioClient> lambda)
        {
            CFuncionarioWCF.CFuncionarioClient oProxy = new CFuncionarioWCF.CFuncionarioClient();
            oProxy.Open();
            lambda(oProxy);
            oProxy.Close();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            grdFuncionarios.AutoGenerateColumns = false;
            HandShake(proxy => { grdFuncionarios.DataSource = proxy.ListaFuncionarios(); });
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(VerificaControles())
            {
                HandShake(proxy => {
                    CFuncionarioWCF.Funcionario oFuncionario = new CFuncionarioWCF.Funcionario();
                    oFuncionario.Nome = txtNome.Text;
                    oFuncionario.Cargo = txtCargo.Text;
                    oFuncionario.cpf = txtCpf.Text;
                    oFuncionario.Endereco = txtEndereco.Text;
                    oFuncionario.Salario = Convert.ToDecimal(txtSalario.Text);
                    if (idEdicao != default(int))
                    {
                        oFuncionario.Codigo = idEdicao;
                        proxy.AlterarFuncionario(oFuncionario);
                    }
                    else
                    {
                        proxy.IncluirFuncionario(oFuncionario);
                    }
                    grdFuncionarios.DataSource = proxy.ListaFuncionarios();
                    LimpaControles();
                    idEdicao = default(int);
                });
            }
            else
            {
                MessageBox.Show("Existem campos obrigatórios não preenchidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool VerificaControles()
        {
            bool camposPreenchidos = txtCargo.Text != "" &&
                txtCpf.Text != "" &&
                txtEndereco.Text != "" &&
                txtNome.Text != "" &&
                txtSalario.Text != "";

            return camposPreenchidos;
        }

        private void LimpaControles()
        {
            txtCargo.Text =
            txtCpf.Text = 
            txtEndereco.Text =
            txtNome.Text =
            txtSalario.Text = "";
        }

        private void grdFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdFuncionarios.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (e.ColumnIndex == 5)
                {
                    HandShake(proxy => {
                        CFuncionarioWCF.Funcionario oFun = (CFuncionarioWCF.Funcionario)grdFuncionarios.Rows[e.RowIndex].DataBoundItem;
                        CFuncionarioWCF.Funcionario oFunAtulaizado = proxy.SelecionarFuncionario(oFun.Codigo);
                        idEdicao = oFunAtulaizado.Codigo;
                        txtNome.Text = oFunAtulaizado.Nome;
                        txtEndereco.Text = oFunAtulaizado.Endereco;
                        txtCpf.Text = oFunAtulaizado.cpf;
                        txtSalario.Text = oFunAtulaizado.Salario.ToString();
                        txtCargo.Text = oFunAtulaizado.Cargo;
                    });
                }
                if (e.ColumnIndex == 6)
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Cadastro de Produtos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        HandShake(proxy => {
                            CFuncionarioWCF.Funcionario oFun = (CFuncionarioWCF.Funcionario)grdFuncionarios.Rows[e.RowIndex].DataBoundItem;
                            proxy.ExcluirFuncionario(oFun.Codigo);
                            grdFuncionarios.DataSource = proxy.ListaFuncionarios();
                        });
                    }

                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
