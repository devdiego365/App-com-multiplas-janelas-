namespace AplicativoComMultiplasJanelas
{
    partial class FormNovaVenda
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
            numericUpDownDesconto = new NumericUpDown();
            numericUpDownQuantidade = new NumericUpDown();
            label3 = new Label();
            textBoxTotalComDesconto = new TextBox();
            comboBoxCliente = new ComboBox();
            comboBoxProduto = new ComboBox();
            textBoxValorTotal = new TextBox();
            textBoxPreçoUnitario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            labelDesconto = new Label();
            labelQtComprada = new Label();
            labelidFornecedor = new Label();
            labelidProduto = new Label();
            labelidCompra = new Label();
            buttonCancel = new Button();
            Ok = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownDesconto
            // 
            numericUpDownDesconto.Location = new Point(146, 104);
            numericUpDownDesconto.Name = "numericUpDownDesconto";
            numericUpDownDesconto.Size = new Size(120, 23);
            numericUpDownDesconto.TabIndex = 39;
            numericUpDownDesconto.ValueChanged += numericUpDownDesconto_ValueChanged;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(142, 75);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(120, 23);
            numericUpDownQuantidade.TabIndex = 38;
            numericUpDownQuantidade.ValueChanged += numericUpDownQuantidade_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 194);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 37;
            label3.Text = "Valor com Desconto:";
            // 
            // textBoxTotalComDesconto
            // 
            textBoxTotalComDesconto.Location = new Point(144, 191);
            textBoxTotalComDesconto.Name = "textBoxTotalComDesconto";
            textBoxTotalComDesconto.Size = new Size(119, 23);
            textBoxTotalComDesconto.TabIndex = 36;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(144, 42);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(121, 23);
            comboBoxCliente.TabIndex = 35;
            comboBoxCliente.SelectedIndexChanged += comboBoxCliente_SelectedIndexChanged;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(145, 12);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(121, 23);
            comboBoxProduto.TabIndex = 34;
            comboBoxProduto.SelectedIndexChanged += comboBoxProduto_SelectedIndexChanged;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.Location = new Point(144, 162);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.Size = new Size(119, 23);
            textBoxValorTotal.TabIndex = 33;
            // 
            // textBoxPreçoUnitario
            // 
            textBoxPreçoUnitario.Location = new Point(145, 133);
            textBoxPreçoUnitario.Name = "textBoxPreçoUnitario";
            textBoxPreçoUnitario.Size = new Size(118, 23);
            textBoxPreçoUnitario.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 165);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 31;
            label2.Text = "Preço Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 136);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 30;
            label1.Text = "Preço Unitario:";
            // 
            // labelDesconto
            // 
            labelDesconto.AutoSize = true;
            labelDesconto.Location = new Point(63, 107);
            labelDesconto.Name = "labelDesconto";
            labelDesconto.Size = new Size(73, 15);
            labelDesconto.TabIndex = 29;
            labelDesconto.Text = "% Desconto:";
            // 
            // labelQtComprada
            // 
            labelQtComprada.AutoSize = true;
            labelQtComprada.Location = new Point(5, 75);
            labelQtComprada.Name = "labelQtComprada";
            labelQtComprada.Size = new Size(131, 15);
            labelQtComprada.TabIndex = 28;
            labelQtComprada.Text = "Quantidade Comprada:";
            // 
            // labelidFornecedor
            // 
            labelidFornecedor.AutoSize = true;
            labelidFornecedor.Location = new Point(86, 50);
            labelidFornecedor.Name = "labelidFornecedor";
            labelidFornecedor.Size = new Size(47, 15);
            labelidFornecedor.TabIndex = 27;
            labelidFornecedor.Text = "Cliente:";
            // 
            // labelidProduto
            // 
            labelidProduto.AutoSize = true;
            labelidProduto.Location = new Point(80, 12);
            labelidProduto.Name = "labelidProduto";
            labelidProduto.Size = new Size(53, 15);
            labelidProduto.TabIndex = 26;
            labelidProduto.Text = "Produto:";
            // 
            // labelidCompra
            // 
            labelidCompra.AutoSize = true;
            labelidCompra.Location = new Point(54, 23);
            labelidCompra.Name = "labelidCompra";
            labelidCompra.Size = new Size(0, 15);
            labelidCompra.TabIndex = 25;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(169, 218);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 24;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // Ok
            // 
            Ok.Location = new Point(87, 218);
            Ok.Name = "Ok";
            Ok.Size = new Size(75, 23);
            Ok.TabIndex = 23;
            Ok.Text = "Ok";
            Ok.UseVisualStyleBackColor = true;
            // 
            // FormNovaVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDownDesconto);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(label3);
            Controls.Add(textBoxTotalComDesconto);
            Controls.Add(comboBoxCliente);
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
            Name = "FormNovaVenda";
            Text = "FormNovaVenda";
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownDesconto;
        private NumericUpDown numericUpDownQuantidade;
        private Label label3;
        private TextBox textBoxTotalComDesconto;
        private ComboBox comboBoxCliente;
        private ComboBox comboBoxProduto;
        private TextBox textBoxValorTotal;
        private TextBox textBoxPreçoUnitario;
        private Label label2;
        private Label label1;
        private Label labelDesconto;
        private Label labelQtComprada;
        private Label labelidFornecedor;
        private Label labelidProduto;
        private Label labelidCompra;
        private Button buttonCancel;
        private Button Ok;
    }
}