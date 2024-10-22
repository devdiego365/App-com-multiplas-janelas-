using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMultiplasJanelas1
{

    public partial class FormNovoProduto : Form
    {
        public string Nome { get { return textBoxNome.Text; } }
        public string Fabricante { get { return textBoxFabricante.Text; } }
        public decimal PreçoCompra { get { return numericUpDownCompra.Value; } }
        public decimal PreçoVenda { get { return numericUpDownVenda.Value; } }
        public FormNovoProduto()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
