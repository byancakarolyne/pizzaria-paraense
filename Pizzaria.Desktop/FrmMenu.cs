using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.Desktop
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        // PRODUTO
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmProduto FrmProduto = new FrmProduto();
           FrmProduto.ShowDialog();
        }

        // CATEGORIA DE PRODUTO
        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoriaProduto FrmCategoriaProduto = new FrmCategoriaProduto();
            FrmCategoriaProduto.ShowDialog();
        }

        // CLIENTE
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente FrmCliente = new FrmCliente();
            FrmCliente.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void toolStripOpcoes_Click(object sender, EventArgs e)
        {

        }
    }
}
