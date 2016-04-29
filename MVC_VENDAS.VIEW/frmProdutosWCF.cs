using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MVC_VENDAS.VIEW
{
    public partial class frmProdutosWCF : Form
    {
        public frmProdutosWCF()
        {
            InitializeComponent();
        }

        private void HandShake(Action<CProdutoWCF.CProdutoClient> lambda)
        {
            CProdutoWCF.CProdutoClient oProxy = new CProdutoWCF.CProdutoClient();
            oProxy.Open();
            lambda(oProxy);
            oProxy.Close();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            grdProdutos.AutoGenerateColumns = false;
            HandShake(proxy => { grdProdutos.DataSource = proxy.ListaProdutos(); });
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
            txtPercLucro.Text = "";
            txtPrecoCompra.Text = "";
            txtQtdEstoque.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                //Produto oProduto = new Produto();
                CProdutoWCF.Produto oProduto = new CProdutoWCF.Produto();

                oProduto.Codigo = txtCodigo.Text;
                oProduto.Nome = txtNome.Text;
                oProduto.PrecoCompra = decimal.Parse(txtPrecoCompra.Text);
                oProduto.QtdEstoque = decimal.Parse(txtQtdEstoque.Text);
                oProduto.PercLucro = decimal.Parse(txtPercLucro.Text);

                HandShake(proxy => {
                    if(proxy.SelecionarProduto(oProduto.Codigo) != null)
                    {
                        proxy.AlterarProduto(oProduto);
                    }
                    else
                    {
                        proxy.IncluirProduto(oProduto);
                    }
                    grdProdutos.DataSource = proxy.ListaProdutos();
                });
                LimpaControles();
            } 
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdProdutos.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (e.ColumnIndex == 3)
                {
                    txtCodigo.Enabled = false;
                    CProdutoWCF.Produto oProd = (CProdutoWCF.Produto)grdProdutos.Rows[e.RowIndex].DataBoundItem;
                    CProdutoWCF.Produto oprodAtulaizado;
                    HandShake(proxy => {
                        oprodAtulaizado = proxy.SelecionarProduto(oProd.Codigo);
                        txtCodigo.Text = oprodAtulaizado.Codigo;
                        txtNome.Text = oprodAtulaizado.Nome;
                        txtPercLucro.Text = oprodAtulaizado.PercLucro.ToString("###0.00");
                        txtPrecoCompra.Text = oprodAtulaizado.PrecoCompra.ToString("###0.00");
                        txtQtdEstoque.Text = oprodAtulaizado.QtdEstoque.ToString();
                        txtCodigo.Enabled = false;
                    });
                }
                if (e.ColumnIndex == 4)
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Cadastro de Produtos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        CProdutoWCF.Produto oProd = (CProdutoWCF.Produto)grdProdutos.Rows[e.RowIndex].DataBoundItem;
                        HandShake(proxy => {
                            proxy.ExcluirProduto(oProd.Codigo);
                            grdProdutos.DataSource = proxy.ListaProdutos();
                        });
                    }

                }
            }
        }

        private void grdProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
