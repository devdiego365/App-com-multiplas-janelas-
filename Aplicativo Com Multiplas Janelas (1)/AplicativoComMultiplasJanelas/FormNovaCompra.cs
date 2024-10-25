using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoComMultiplasJanelas
{
    public partial class FormNovaCompra : Form
    {
        public string Id { get { return textBoxIdCompra.Text; } }
        public int IdFornecedor { get { return textBoxIdFornecedor.Text; } }
        public string IdProduto { get { return textBoxIdProduto.Text; } }
        public string QuantidadeComprada { get { return textBoxQuantidadeComprada.Text; } }
        public string Desconto { get { return textBoxDesconto.Text; } }

        public FormNovaCompra()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
