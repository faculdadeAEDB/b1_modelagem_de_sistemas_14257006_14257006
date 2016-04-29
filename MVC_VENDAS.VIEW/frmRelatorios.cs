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

namespace MVC_VENDAS.VIEW
{
    public partial class frmRelatorios : Form
    {
        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
            foreach (var item in CVenda.ListaVendas())
            {
                dgvVendas.Rows.Add(item.Item1, item.Item2, item.Item3, item.Item4, item.Item5, item.Item6);
            }

            foreach (var item in CVenda.VendedoresQueMaisVendem())
            {
                dgvVendedores.Rows.Add(item.Item1, item.Item2);
            }

            foreach (var item in CVenda.ProdutosMaisVendidos())
            {
                dgvProdutos.Rows.Add(item.Item1, item.Item2);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

    }
}
