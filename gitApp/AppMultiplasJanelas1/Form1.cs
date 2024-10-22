namespace AppMultiplasJanelas1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDeletarProduto_Click(object sender, EventArgs e)
        {
            if(listBoxProdutos.Items.Count > 0) 
            {
                if(listBoxProdutos.SelectedIndex >= 0) 
                {
                    listBoxProdutos.Items.RemoveAt(listBoxProdutos.SelectedIndex);  
                }
            }
        }

        private void buttonAdicionarProduto_Click(object sender, EventArgs e)
        {
            FormNovoProduto fnp = new FormNovoProduto();    
            DialogResult resultado = fnp.ShowDialog();  
            if (resultado == DialogResult.OK) 
            {
                string textoProduto = $"{fnp.Nome}-{fnp.Fabricante}(R${fnp.PreçoCompra})(R${fnp.PreçoVenda})";
                listBoxProdutos.Items.Add(textoProduto);
            }   
        }
    }
}
