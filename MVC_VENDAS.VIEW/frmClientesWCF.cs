using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_VENDAS.VIEW
{
    public partial class frmClientesWCF : Form
    {
        static int idEdicao;

        public frmClientesWCF()
        {
            InitializeComponent();
        }

        private void HandShake(Action<CClienteWCF.CClienteClient> lambda)
        {
            CClienteWCF.CClienteClient oProxy = new CClienteWCF.CClienteClient();
            oProxy.Open();
            lambda(oProxy);
            oProxy.Close();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            grdClientes.AutoGenerateColumns = false;
            HandShake(proxy => { grdClientes.DataSource = proxy.ListaClientes(); });
        }

        private bool VerificaControles()
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencher o conteudo do campo Nome.");
                txtNome.Focus();
                return false;
            }
            return true;
        }

        private void LimpaControles()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtTelefone.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                CClienteWCF.Cliente oCliente = new CClienteWCF.Cliente();
                oCliente.Nome = txtNome.Text;
                oCliente.Endereco = txtEndereco.Text;
                oCliente.Bairro = txtBairro.Text;
                oCliente.Cidade = txtCidade.Text;
                oCliente.Telefone = txtTelefone.Text;
                HandShake(proxy => {
                    if (idEdicao != default(int))
                    {
                        oCliente.Codigo = idEdicao;
                        proxy.AlterarCliente(oCliente);
                    }
                    else
                    {
                        proxy.IncluirCliente(oCliente);
                    }
                    grdClientes.DataSource = proxy.ListaClientes();
                    LimpaControles();
                    idEdicao = default(int);
                });
            }
        }

        private void grdClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdClientes.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (e.ColumnIndex == 3)
                {
                    CClienteWCF.Cliente oCli = (CClienteWCF.Cliente)grdClientes.Rows[e.RowIndex].DataBoundItem;
                    HandShake(proxy => {
                        CClienteWCF.Cliente oCliAtulaizado = proxy.SelecionarCliente(oCli.Codigo);
                        idEdicao = oCliAtulaizado.Codigo;
                        txtNome.Text = oCliAtulaizado.Nome;
                        txtEndereco.Text = oCliAtulaizado.Endereco;
                        txtBairro.Text = oCliAtulaizado.Bairro;
                        txtCidade.Text = oCliAtulaizado.Cidade;
                        txtTelefone.Text = oCliAtulaizado.Telefone;
                    });
                }
                if (e.ColumnIndex == 4)
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Cadastro de Produtos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        CClienteWCF.Cliente oCli = (CClienteWCF.Cliente)grdClientes.Rows[e.RowIndex].DataBoundItem;
                        HandShake(proxy => {
                            proxy.ExcluirCliente(oCli.Codigo);
                            grdClientes.DataSource = proxy.ListaClientes();
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
