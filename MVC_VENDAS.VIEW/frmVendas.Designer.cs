namespace MVC_VENDAS.VIEW
{
    partial class frmVendas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRetireItemCarrinho = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnItemParaCarrinho = new System.Windows.Forms.Button();
            this.lstCarrinho = new System.Windows.Forms.ListBox();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstVendedor = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.btnRetireItemCarrinho);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnItemParaCarrinho);
            this.groupBox1.Controls.Add(this.lstCarrinho);
            this.groupBox1.Controls.Add(this.lstProdutos);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens e Carrinho de Compras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produtos no Carrinho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produtos a Venda:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(129, 211);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(121, 20);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total a Pagar:";
            // 
            // btnRetireItemCarrinho
            // 
            this.btnRetireItemCarrinho.Location = new System.Drawing.Point(205, 171);
            this.btnRetireItemCarrinho.Name = "btnRetireItemCarrinho";
            this.btnRetireItemCarrinho.Size = new System.Drawing.Size(53, 23);
            this.btnRetireItemCarrinho.TabIndex = 3;
            this.btnRetireItemCarrinho.Text = "<<<";
            this.btnRetireItemCarrinho.UseVisualStyleBackColor = true;
            this.btnRetireItemCarrinho.Click += new System.EventHandler(this.btnRetireItemCarrinho_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total a Pagar:";
            // 
            // btnItemParaCarrinho
            // 
            this.btnItemParaCarrinho.Location = new System.Drawing.Point(205, 48);
            this.btnItemParaCarrinho.Name = "btnItemParaCarrinho";
            this.btnItemParaCarrinho.Size = new System.Drawing.Size(53, 23);
            this.btnItemParaCarrinho.TabIndex = 2;
            this.btnItemParaCarrinho.Text = ">>>";
            this.btnItemParaCarrinho.UseVisualStyleBackColor = true;
            this.btnItemParaCarrinho.Click += new System.EventHandler(this.btnItemParaCarrinho_Click);
            // 
            // lstCarrinho
            // 
            this.lstCarrinho.FormattingEnabled = true;
            this.lstCarrinho.Location = new System.Drawing.Point(264, 35);
            this.lstCarrinho.Name = "lstCarrinho";
            this.lstCarrinho.Size = new System.Drawing.Size(193, 173);
            this.lstCarrinho.TabIndex = 1;
            // 
            // lstProdutos
            // 
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.Location = new System.Drawing.Point(6, 35);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(193, 173);
            this.lstProdutos.TabIndex = 0;
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(500, 48);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(193, 69);
            this.lstClientes.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente:";
            // 
            // lstVendedor
            // 
            this.lstVendedor.FormattingEnabled = true;
            this.lstVendedor.Location = new System.Drawing.Point(500, 152);
            this.lstVendedor.Name = "lstVendedor";
            this.lstVendedor.Size = new System.Drawing.Size(193, 69);
            this.lstVendedor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vendedor:";
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.Location = new System.Drawing.Point(13, 275);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(150, 37);
            this.btnConfirmarCompra.TabIndex = 9;
            this.btnConfirmarCompra.Text = "Confirmar Venda";
            this.btnConfirmarCompra.UseVisualStyleBackColor = true;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(540, 245);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 56);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Location = new System.Drawing.Point(389, 275);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(90, 37);
            this.btnRelatorios.TabIndex = 11;
            this.btnRelatorios.Text = "Ver Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 324);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConfirmarCompra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstVendedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Efetuar Vendas SHow";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRetireItemCarrinho;
        private System.Windows.Forms.Button btnItemParaCarrinho;
        private System.Windows.Forms.ListBox lstCarrinho;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstVendedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRelatorios;
    }
}