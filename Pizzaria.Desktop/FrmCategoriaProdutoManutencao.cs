using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class;
using Controller;

namespace Pizzaria.Desktop
{
    public partial class FrmCategoriaProdutoManutencao : Form
    {
        public CategoriaProdutoController CategoriaController;
        public FrmCategoriaProdutoManutencao(ClasseCategoriaProduto categoriaProduto = null)
        {
            InitializeComponent();
            if (categoriaProduto != null)
            {
                txtCodigoCategoriaProduto.Text = categoriaProduto.ID.ToString();
                txtNomeCategoriaProduto.Text = categoriaProduto.NOME;
            }
            else {
                txtCodigoCategoriaProduto.Text = "0";
            }
            CategoriaController = new CategoriaProdutoController();
        }

        private void btnSalvarCategoriaProduto_Click(object sender, EventArgs e)
        {

            ClasseCategoriaProduto Categoria = new ClasseCategoriaProduto();
            Categoria.NOME = txtNomeCategoriaProduto.Text;
            
            Categoria.ID = Convert.ToInt32(txtCodigoCategoriaProduto.Text);

            CategoriaController.SalvarCategoriaProduto(Categoria);

            Close();
        }
    }
}
