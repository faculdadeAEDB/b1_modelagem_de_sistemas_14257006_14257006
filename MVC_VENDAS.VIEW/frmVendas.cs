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
    public partial class frmVendas : Form
    {
        private static decimal totalAPagar;
        private static List<Produto> produtos;
        private static List<Produto> carrinho;
        private static List<Cliente> clientes;
        private static List<Funcionario> funcionarios;

        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            AtualizaTotalAPagar();
            produtos = CProduto.ListaProdutos();
            foreach (var item in produtos)
            {
                lstProdutos.Items.Add(item.Codigo + " - " + item.Nome + " - " + string.Format("{0:C}", item.PrecoVenda) );
            }

            clientes = CCliente.ListaClientes();
            foreach (var item in clientes)
            {
                lstClientes.Items.Add(item.Codigo + " - " + item.Nome);
            }

            funcionarios = CFuncionario.ListaFuncionarios();
            foreach (var item in funcionarios)
            {
                lstVendedor.Items.Add(item.Codigo + " - " + item.Nome);
            }
        }

        private void AtualizaTotalAPagar()
        {
            lblTotal.Text = string.Format("{0:C}", totalAPagar);
        }

        private string pegaIdItem(string item)
        {
            string id = item.Substring(0, item.IndexOf("-"));
            return id.Trim();
        }

        private void btnItemParaCarrinho_Click(object sender, EventArgs e)
        {
            foreach (string item in lstProdutos.SelectedItems)
            {
                string idItem = pegaIdItem(item);
                Produto oProd = produtos.Find(p => p.Codigo.ToString() == idItem);
                if(oProd.QtdEstoque > 0)
                {
                    totalAPagar += oProd.PrecoVenda;
                    if(lstCarrinho.FindString(item) == -1)
                    {
                        lstCarrinho.Items.Add(item + " (1)");
                    }
                    else
                    {
                        int index = lstCarrinho.FindString(item);
                        string prod = lstCarrinho.Items[index].ToString();
                        string qtdProd = pegaQuantidade(prod);
                        string qtdProdAtual = (Convert.ToInt32(qtdProd) + 1).ToString();
                        lstCarrinho.Items[index] = prod.Replace("(" + qtdProd + ")", "(" + qtdProdAtual + ")");
                    }
                    produtos.Find(p => p.Codigo.ToString() == idItem).QtdEstoque--;
                }
                else
                {
                    MessageBox.Show("Este produto acabou no estoque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            AtualizaTotalAPagar();
        }

        private string pegaQuantidade(string prod)
        {
            return prod.Substring(prod.IndexOf("(")).Replace("(", "").Replace(")", "").Trim();
        }

        private void btnRetireItemCarrinho_Click(object sender, EventArgs e)
        {
            foreach (int item in lstCarrinho.SelectedIndices)
            {
                string strItem = lstCarrinho.Items[item].ToString();
                string qtdProd = pegaQuantidade(strItem);
                if (Convert.ToInt32(qtdProd) > 1)
                {
                    string prod = lstCarrinho.Items[item].ToString();
                    string qtdProdAtual = (Convert.ToInt32(qtdProd) - 1).ToString();
                    lstCarrinho.Items[item] = prod.Replace("(" + qtdProd + ")", "(" + qtdProdAtual + ")");
                }
                else
                {
                    lstCarrinho.Items.RemoveAt(item);
                }
                string idItem = pegaIdItem(strItem);
                Produto oProd = produtos.Find(p => p.Codigo.ToString() == idItem);
                totalAPagar -= oProd.PrecoVenda;
                produtos.Find(p => p.Codigo.ToString() == idItem).QtdEstoque++;
            }
            AtualizaTotalAPagar();
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            if(verificaDadosObrigatorios())
            {
                if(MessageBox.Show("Deseja concluir a compra?", "Confirmação da Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Venda oVenda = new Venda();
                    int idCliente = Convert.ToInt32(pegaIdItem(lstClientes.SelectedItem.ToString()));
                    oVenda.oCliente = Cliente.SelecionarCliente(idCliente);

                    ItemVenda itemVenda;
                    foreach (string item in lstCarrinho.Items)
                    {
                        itemVenda = new ItemVenda();
                        itemVenda.oProduto = Produto.SelecionarProduto(pegaIdItem(item.ToString())); ;
                        itemVenda.Quantidade = Convert.ToInt16(pegaQuantidade(item));
                        oVenda.Itens.Add(itemVenda);
                    }

                    int idVendedor = Convert.ToInt32(pegaIdItem(lstVendedor.SelectedItem.ToString()));
                    oVenda.oFuncionario = Funcionario.SelecionarFuncionario(idVendedor);
                    CVenda.IncluirVenda(oVenda);

                    MessageBox.Show("Venda Concluída", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstCarrinho.SelectedIndex =
                        lstClientes.SelectedIndex =
                        lstProdutos.SelectedIndex =
                        lstVendedor.SelectedIndex = -1;

                    lstCarrinho.Items.Clear();
                    totalAPagar = 0;
                    AtualizaTotalAPagar();
                }
            }
            else
            {
                MessageBox.Show("Todos os dados devem ser selecionandos antes da confirmação da compra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool verificaDadosObrigatorios()
        {
            return lstCarrinho.Items.Count > 0 && lstClientes.SelectedIndex != -1 && lstVendedor.SelectedIndex != -1;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            (new frmRelatorios()).ShowDialog();
            this.Visible = true;
        }
    }
}
