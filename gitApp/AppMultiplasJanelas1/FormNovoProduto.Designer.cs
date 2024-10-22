namespace AppMultiplasJanelas1
{
    partial class FormNovoProduto
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
            buttonOk = new Button();
            buttonCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxNome = new TextBox();
            textBoxFabricante = new TextBox();
            numericUpDownVenda = new NumericUpDown();
            numericUpDownCompra = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCompra).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(101, 167);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(65, 23);
            buttonOk.TabIndex = 4;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += Ok_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(172, 169);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(69, 21);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Fabricante:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 4;
            label3.Text = "Preço de Venda:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 89);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 5;
            label4.Text = "Preço de Compra:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(124, 16);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(117, 23);
            textBoxNome.TabIndex = 0;
            // 
            // textBoxFabricante
            // 
            textBoxFabricante.Location = new Point(124, 58);
            textBoxFabricante.Name = "textBoxFabricante";
            textBoxFabricante.Size = new Size(117, 23);
            textBoxFabricante.TabIndex = 1;
            // 
            // numericUpDownVenda
            // 
            numericUpDownVenda.DecimalPlaces = 2;
            numericUpDownVenda.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownVenda.Location = new Point(124, 126);
            numericUpDownVenda.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownVenda.Name = "numericUpDownVenda";
            numericUpDownVenda.Size = new Size(117, 23);
            numericUpDownVenda.TabIndex = 3;
            numericUpDownVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // numericUpDownCompra
            // 
            numericUpDownCompra.DecimalPlaces = 2;
            numericUpDownCompra.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownCompra.Location = new Point(124, 87);
            numericUpDownCompra.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownCompra.Name = "numericUpDownCompra";
            numericUpDownCompra.Size = new Size(117, 23);
            numericUpDownCompra.TabIndex = 2;
            numericUpDownCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // FormNovoProduto
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(255, 207);
            Controls.Add(numericUpDownCompra);
            Controls.Add(numericUpDownVenda);
            Controls.Add(textBoxFabricante);
            Controls.Add(textBoxNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOk);
            Name = "FormNovoProduto";
            Text = "FormNovoProduto";
            ((System.ComponentModel.ISupportInitialize)numericUpDownVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Button buttonCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxNome;
        private TextBox textBoxFabricante;
        private NumericUpDown numericUpDownVenda;
        private NumericUpDown numericUpDownCompra;
    }
}