using System.ComponentModel;
using static System.Net.WebRequestMethods;

namespace AplicativoComMultiplasJanelas
{
    public partial class Form1 : Form
    {

        private BindingList<Produto> Produtos = new BindingList<Produto>();
        private BindingList<Cliente> Clientes = new BindingList<Cliente>();
        private BindingList<Fornecedor> Fornecedores = new BindingList<Fornecedor>();
        private BindingList<Venda> Vendas = new BindingList<Venda>();
        private BindingList<Compra> Compras = new BindingList<Compra>();



        public Form1()
        {
            InitializeComponent();

            this.dataGridView1.DataSource = Produtos;
        }



        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            var produto = Produtos.Last();
            if (produto.Id == 0) produto.Id = Produtos.Max(x => x.Id) + 1;
        }

        private void buttonVerProdutos_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Produtos;
        }

        private void buttonVerFornecedores_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Fornecedores;
        }

        private void buttonVerClientes_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Clientes;
        }

        private void buttonVerCompras_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Compras;
        }

        private void buttonVerVendas_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Vendas;
        }

        private void buttonAdicionarProduto_Click(object sender, EventArgs e)
        {
            FormNovoProduto fnp = new FormNovoProduto();
            DialogResult resultado = fnp.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Produto produto = new Produto();

                if (Produtos.Count == 0) produto.Id = 1;
                else produto.Id = Produtos.Max(x => x.Id) + 1;

                produto.Nome = fnp.Nome;
                produto.Fabricante = fnp.Fabricante;
                produto.PrecoVenda = fnp.PrecoVenda;
                produto.PrecoCompra = fnp.PrecoCompra;

                Produtos.Add(produto);
            }
        }

        private void buttonDeletarProduto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Produtos)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }

        }

        private void buttonNovoFornecedor_Click(object sender, EventArgs e)
        {
            FormNovoFornecedor fnf = new FormNovoFornecedor();
            var resultado = fnf.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Fornecedor fornecedor = new Fornecedor();

                if (Fornecedores.Count == 0) fornecedor.Id = 1;
                else fornecedor.Id = Fornecedores.Max(x => x.Id) + 1;

                fornecedor.NomeEmpresa = fnf.NomeEmpresa;
                fornecedor.NomeContato = fnf.NomeContato;
                fornecedor.Endereco = fnf.Endereco;
                fornecedor.Email = fnf.Email;
                fornecedor.Telefone = fnf.Telefone;
                Fornecedores.Add(fornecedor);
            }
        }

        private void buttonDeletarFornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Fornecedores)
            {
                if (dataGridView1.SelectedRows.Count > 0 && Fornecedores.Count > 0)
                {
                    Fornecedores.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void buttonNovoCliente_Click(object sender, EventArgs e)
        {
            FormNovoCliente fncc = new FormNovoCliente();
            var resultado = fncc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Cliente cliente = new Cliente();
                if (Cliente.Count == 0) cliente.Id = 1;
                else cliente.Id = Clientes.Max(x => x.Id) + 1;

                cliente.Email = fncc.Email;
                cliente.Telefone = fncc.Telefone;
                cliente.Nome = fncc.Nome;
                cliente.Endereco = fncc.Endereco;
                Clientes.Add(cliente);
            }
        }

        private void buttonDeletarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Clientes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Clientes.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }

        }

        private void buttonAdicionarCompra_Click(object sender, EventArgs e)
        {
            if (Fornecedores.Count == 0)
            {
                MessageBox.Show("Voce precisa Cadastrar Fornecedores antes de efetuar uma compra .");
                return;
            }
            if (Produtos.Count == 0)
            {
                MessageBox.Show("Voce precisa cadastrar um produto antes de efetuar uma compra.");
                return;
            }
            FormNovaCompra fnccc = new FormNovaCompra(Fornecedores, Produtos);
            var resultado = fnccc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Compra compra = new Compra();
                if (Compra.Count == 0) compra.Id = 1;
                else compra.Id = Compras.Max(x => x.Id) + 1;

                compra.IdFornecedor = fnccc.IdFornecedor;
                compra.Quantidade = (int)fnccc.Quantidade;
                compra.DataCompra = DateTime.Now;
                compra.IdFornecedor = fnccc.IdFornecedor;
                compra.Desconto = fnccc.Desconto;

                Compras.Add(compra);
                this.dataGridView1.DataSource = Compras;
            }

        }

        private void buttonDeletarCompra_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Compras)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Compras.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonNovaVenda_Click(object sender, EventArgs e)
        {
            if (Clientes.Count == 0) MessageBox.Show("Voce precisar Cadastrar clientes antes de efetuar uma venda");
            if (Produtos.Count == 0) MessageBox.Show("Voce precisar cadastrar um produto antes de efetuar uma venda");

            FormNovaVenda fnv = new FormNovaVenda(Clientes, Produtos);
            var resultado = fnv.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Venda venda = new Venda();
                if (Vendas.Count == 0) venda.Id = 1;
                else venda.Id = Vendas.Max(x => x.Id)+1;

                venda.IdProduto = fnv.IdProduto;
                venda.DataVenda = DateTime.Now;
                venda.IdCliente = fnv.IdCliente;
                venda.Quantidade = (int)fnv.Quantidade;
                venda.Desconto = fnv.Desconto;

                Vendas.Add(venda);
                this.dataGridView1.DataSource = Vendas;


            }


                    
        }
    }
}
