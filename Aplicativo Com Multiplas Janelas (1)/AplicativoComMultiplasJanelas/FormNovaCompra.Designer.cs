namespace AplicativoComMultiplasJanelas
{
    partial class FormNovaCompra
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
            Ok = new Button();
            buttonCancel = new Button();
            labelidCompra = new Label();
            labelidProduto = new Label();
            labelidFornecedor = new Label();
            labelQtComprada = new Label();
            labelDesconto = new Label();
            textBoxIdCompra = new TextBox();
            textBoxIdProduto = new TextBox();
            textBoxIdFornecedor = new TextBox();
            textBoxQuantidadeComprada = new TextBox();
            textBoxDesconto = new TextBox();
            SuspendLayout();
            // 
            // Ok
            // 
            Ok.Location = new Point(78, 200);
            Ok.Name = "Ok";
            Ok.Size = new Size(75, 23);
            Ok.TabIndex = 0;
            Ok.Text = "Ok";
            Ok.UseVisualStyleBackColor = true;
            Ok.Click += Ok_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(159, 200);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelidCompra
            // 
            labelidCompra.AutoSize = true;
            labelidCompra.Location = new Point(47, 20);
            labelidCompra.Name = "labelidCompra";
            labelidCompra.Size = new Size(82, 15);
            labelidCompra.TabIndex = 2;
            labelidCompra.Text = "Id da Compra:";
            // 
            // labelidProduto
            // 
            labelidProduto.AutoSize = true;
            labelidProduto.Location = new Point(46, 51);
            labelidProduto.Name = "labelidProduto";
            labelidProduto.Size = new Size(83, 15);
            labelidProduto.TabIndex = 3;
            labelidProduto.Text = "Id do Produto:";
            // 
            // labelidFornecedor
            // 
            labelidFornecedor.AutoSize = true;
            labelidFornecedor.Location = new Point(29, 81);
            labelidFornecedor.Name = "labelidFornecedor";
            labelidFornecedor.Size = new Size(100, 15);
            labelidFornecedor.TabIndex = 4;
            labelidFornecedor.Text = "Id do Fornecedor:";
            // 
            // labelQtComprada
            // 
            labelQtComprada.AutoSize = true;
            labelQtComprada.Location = new Point(-2, 105);
            labelQtComprada.Name = "labelQtComprada";
            labelQtComprada.Size = new Size(131, 15);
            labelQtComprada.TabIndex = 5;
            labelQtComprada.Text = "Quantidade Comprada:";
            // 
            // labelDesconto
            // 
            labelDesconto.AutoSize = true;
            labelDesconto.Location = new Point(56, 131);
            labelDesconto.Name = "labelDesconto";
            labelDesconto.Size = new Size(73, 15);
            labelDesconto.TabIndex = 6;
            labelDesconto.Text = "% Desconto:";
            // 
            // textBoxIdCompra
            // 
            textBoxIdCompra.Location = new Point(135, 12);
            textBoxIdCompra.Name = "textBoxIdCompra";
            textBoxIdCompra.Size = new Size(100, 23);
            textBoxIdCompra.TabIndex = 8;
            // 
            // textBoxIdProduto
            // 
            textBoxIdProduto.Location = new Point(135, 43);
            textBoxIdProduto.Name = "textBoxIdProduto";
            textBoxIdProduto.Size = new Size(100, 23);
            textBoxIdProduto.TabIndex = 9;
            // 
            // textBoxIdFornecedor
            // 
            textBoxIdFornecedor.Location = new Point(135, 73);
            textBoxIdFornecedor.Name = "textBoxIdFornecedor";
            textBoxIdFornecedor.Size = new Size(100, 23);
            textBoxIdFornecedor.TabIndex = 10;
            // 
            // textBoxQuantidadeComprada
            // 
            textBoxQuantidadeComprada.Location = new Point(135, 102);
            textBoxQuantidadeComprada.Name = "textBoxQuantidadeComprada";
            textBoxQuantidadeComprada.Size = new Size(100, 23);
            textBoxQuantidadeComprada.TabIndex = 11;
            // 
            // textBoxDesconto
            // 
            textBoxDesconto.Location = new Point(135, 128);
            textBoxDesconto.Name = "textBoxDesconto";
            textBoxDesconto.Size = new Size(100, 23);
            textBoxDesconto.TabIndex = 12;
            // 
            // FormNovaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 250);
            Controls.Add(textBoxDesconto);
            Controls.Add(textBoxQuantidadeComprada);
            Controls.Add(textBoxIdFornecedor);
            Controls.Add(textBoxIdProduto);
            Controls.Add(textBoxIdCompra);
            Controls.Add(labelDesconto);
            Controls.Add(labelQtComprada);
            Controls.Add(labelidFornecedor);
            Controls.Add(labelidProduto);
            Controls.Add(labelidCompra);
            Controls.Add(buttonCancel);
            Controls.Add(Ok);
            Name = "FormNovaCompra";
            Text = "FormNovaCompra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Ok;
        private Button buttonCancel;
        private Label labelidCompra;
        private Label labelidProduto;
        private Label labelidFornecedor;
        private Label labelQtComprada;
        private Label labelDesconto;
        private TextBox textBoxIdCompra;
        private TextBox textBoxIdProduto;
        private TextBox textBoxIdFornecedor;
        private TextBox textBoxQuantidadeComprada;
        private TextBox textBoxDesconto;
    }
}