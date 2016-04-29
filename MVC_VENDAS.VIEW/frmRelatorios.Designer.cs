namespace MVC_VENDAS.VIEW
{
    partial class frmRelatorios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.NomeVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRelatorio1 = new System.Windows.Forms.Label();
            this.lblRelatorio2 = new System.Windows.Forms.Label();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.lblRelatorio4 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.VenCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendedorOrderby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdItensVendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AllowUserToAddRows = false;
            this.dgvVendedores.AllowUserToDeleteRows = false;
            this.dgvVendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeVendedor,
            this.QuantidadeV});
            this.dgvVendedores.Location = new System.Drawing.Point(12, 33);
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.ReadOnly = true;
            this.dgvVendedores.Size = new System.Drawing.Size(345, 208);
            this.dgvVendedores.TabIndex = 0;
            // 
            // NomeVendedor
            // 
            this.NomeVendedor.HeaderText = "Vendedor";
            this.NomeVendedor.Name = "NomeVendedor";
            this.NomeVendedor.ReadOnly = true;
            // 
            // QuantidadeV
            // 
            this.QuantidadeV.HeaderText = "Quantidade";
            this.QuantidadeV.Name = "QuantidadeV";
            this.QuantidadeV.ReadOnly = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.QuantidadeP});
            this.dgvProdutos.Location = new System.Drawing.Point(369, 33);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(345, 208);
            this.dgvProdutos.TabIndex = 1;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // QuantidadeP
            // 
            this.QuantidadeP.HeaderText = "Quantidade";
            this.QuantidadeP.Name = "QuantidadeP";
            this.QuantidadeP.ReadOnly = true;
            // 
            // lblRelatorio1
            // 
            this.lblRelatorio1.AutoSize = true;
            this.lblRelatorio1.Location = new System.Drawing.Point(13, 13);
            this.lblRelatorio1.Name = "lblRelatorio1";
            this.lblRelatorio1.Size = new System.Drawing.Size(137, 13);
            this.lblRelatorio1.TabIndex = 2;
            this.lblRelatorio1.Text = "Vendedor que mais vendeu";
            // 
            // lblRelatorio2
            // 
            this.lblRelatorio2.AutoSize = true;
            this.lblRelatorio2.Location = new System.Drawing.Point(366, 13);
            this.lblRelatorio2.Name = "lblRelatorio2";
            this.lblRelatorio2.Size = new System.Drawing.Size(119, 13);
            this.lblRelatorio2.TabIndex = 3;
            this.lblRelatorio2.Text = "Produtos mais vendidos";
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VenCodigo,
            this.Cliente,
            this.VendedorOrderby,
            this.Total,
            this.QtdItensVendidos,
            this.DataVenda});
            this.dgvVendas.Location = new System.Drawing.Point(12, 274);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.Size = new System.Drawing.Size(702, 208);
            this.dgvVendas.TabIndex = 5;
            // 
            // lblRelatorio4
            // 
            this.lblRelatorio4.AutoSize = true;
            this.lblRelatorio4.Location = new System.Drawing.Point(9, 255);
            this.lblRelatorio4.Name = "lblRelatorio4";
            this.lblRelatorio4.Size = new System.Drawing.Size(194, 13);
            this.lblRelatorio4.TabIndex = 7;
            this.lblRelatorio4.Text = "Vendedor que mais vendeu por produto";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(573, 488);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(141, 47);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // VenCodigo
            // 
            this.VenCodigo.HeaderText = "ID da Venda";
            this.VenCodigo.Name = "VenCodigo";
            this.VenCodigo.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // VendedorOrderby
            // 
            this.VendedorOrderby.HeaderText = "Vendedor";
            this.VendedorOrderby.Name = "VendedorOrderby";
            this.VendedorOrderby.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // QtdItensVendidos
            // 
            this.QtdItensVendidos.HeaderText = "Quantidade de Itens";
            this.QtdItensVendidos.Name = "QtdItensVendidos";
            this.QtdItensVendidos.ReadOnly = true;
            // 
            // DataVenda
            // 
            this.DataVenda.HeaderText = "Data da Venda";
            this.DataVenda.Name = "DataVenda";
            this.DataVenda.ReadOnly = true;
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 547);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblRelatorio4);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.lblRelatorio2);
            this.Controls.Add(this.lblRelatorio1);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.dgvVendedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios";
            this.Load += new System.EventHandler(this.frmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendedores;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblRelatorio1;
        private System.Windows.Forms.Label lblRelatorio2;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Label lblRelatorio4;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn VenCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendedorOrderby;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdItensVendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVenda;
    }
}