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
            label1 = new Label();
            label2 = new Label();
            textBoxPreçoUnitario = new TextBox();
            textBoxValorTotal = new TextBox();
            comboBoxProduto = new ComboBox();
            comboBoxFornecedor = new ComboBox();
            textBoxTotalComDesconto = new TextBox();
            label3 = new Label();
            numericUpDownQuantidade = new NumericUpDown();
            numericUpDownDesconto = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).BeginInit();
            SuspendLayout();
            // 
            // Ok
            // 
            Ok.Location = new Point(78, 215);
            Ok.Name = "Ok";
            Ok.Size = new Size(75, 23);
            Ok.TabIndex = 0;
            Ok.Text = "Ok";
            Ok.UseVisualStyleBackColor = true;
            Ok.Click += Ok_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(160, 215);
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
            labelidCompra.Location = new Point(45, 20);
            labelidCompra.Name = "labelidCompra";
            labelidCompra.Size = new Size(0, 15);
            labelidCompra.TabIndex = 2;
            // 
            // labelidProduto
            // 
            labelidProduto.AutoSize = true;
            labelidProduto.Location = new Point(71, 9);
            labelidProduto.Name = "labelidProduto";
            labelidProduto.Size = new Size(53, 15);
            labelidProduto.TabIndex = 3;
            labelidProduto.Text = "Produto:";
            // 
            // labelidFornecedor
            // 
            labelidFornecedor.AutoSize = true;
            labelidFornecedor.Location = new Point(54, 47);
            labelidFornecedor.Name = "labelidFornecedor";
            labelidFornecedor.Size = new Size(70, 15);
            labelidFornecedor.TabIndex = 4;
            labelidFornecedor.Text = "Fornecedor:";
            // 
            // labelQtComprada
            // 
            labelQtComprada.AutoSize = true;
            labelQtComprada.Location = new Point(-4, 72);
            labelQtComprada.Name = "labelQtComprada";
            labelQtComprada.Size = new Size(131, 15);
            labelQtComprada.TabIndex = 5;
            labelQtComprada.Text = "Quantidade Comprada:";
            // 
            // labelDesconto
            // 
            labelDesconto.AutoSize = true;
            labelDesconto.Location = new Point(54, 104);
            labelDesconto.Name = "labelDesconto";
            labelDesconto.Size = new Size(73, 15);
            labelDesconto.TabIndex = 6;
            labelDesconto.Text = "% Desconto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 133);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 13;
            label1.Text = "Preço Unitario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 162);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 14;
            label2.Text = "Preço Total:";
            // 
            // textBoxPreçoUnitario
            // 
            textBoxPreçoUnitario.Location = new Point(136, 130);
            textBoxPreçoUnitario.Name = "textBoxPreçoUnitario";
            textBoxPreçoUnitario.Size = new Size(118, 23);
            textBoxPreçoUnitario.TabIndex = 15;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.Location = new Point(135, 159);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.Size = new Size(119, 23);
            textBoxValorTotal.TabIndex = 16;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(136, 9);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(121, 23);
            comboBoxProduto.TabIndex = 17;
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(135, 39);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(121, 23);
            comboBoxFornecedor.TabIndex = 18;
            // 
            // textBoxTotalComDesconto
            // 
            textBoxTotalComDesconto.Location = new Point(135, 188);
            textBoxTotalComDesconto.Name = "textBoxTotalComDesconto";
            textBoxTotalComDesconto.Size = new Size(119, 23);
            textBoxTotalComDesconto.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 191);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 20;
            label3.Text = "Valor com Desconto:";
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(137, 72);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(120, 23);
            numericUpDownQuantidade.TabIndex = 21;
            // 
            // numericUpDownDesconto
            // 
            numericUpDownDesconto.Location = new Point(137, 101);
            numericUpDownDesconto.Name = "numericUpDownDesconto";
            numericUpDownDesconto.Size = new Size(120, 23);
            numericUpDownDesconto.TabIndex = 22;
            // 
            // FormNovaCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 254);
            Controls.Add(numericUpDownDesconto);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(label3);
            Controls.Add(textBoxTotalComDesconto);
            Controls.Add(comboBoxFornecedor);
            Controls.Add(comboBoxProduto);
            Controls.Add(textBoxValorTotal);
            Controls.Add(textBoxPreçoUnitario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelDesconto);
            Controls.Add(labelQtComprada);
            Controls.Add(labelidFornecedor);
            Controls.Add(labelidProduto);
            Controls.Add(labelidCompra);
            Controls.Add(buttonCancel);
            Controls.Add(Ok);
            Name = "FormNovaCompra";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).EndInit();
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
        private Label label1;
        private Label label2;
        private TextBox textBoxPreçoUnitario;
        private TextBox textBoxValorTotal;
        private ComboBox comboBoxProduto;
        private ComboBox comboBoxFornecedor;
        private TextBox textBoxTotalComDesconto;
        private Label label3;
        private NumericUpDown numericUpDownQuantidade;
        private NumericUpDown numericUpDownDesconto;
    }
}