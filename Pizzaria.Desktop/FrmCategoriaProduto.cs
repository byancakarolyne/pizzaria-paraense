using System;
using System.Windows.Forms;
using Controller;
using Class;


namespace Pizzaria.Desktop
{
    public partial class FrmCategoriaProduto : Form
    {
        public CategoriaProdutoController CategoriaController;

        public FrmCategoriaProduto()
        {
            InitializeComponent();
            CategoriaController = new CategoriaProdutoController();
            AtualizarGridCategoriaProduto();
        }

        // ATUALIZAR GRID CATEGORIA PRODUTO
        private void AtualizarGridCategoriaProduto()
        {
            dataGridCategoriaProduto.DataSource = null;
            dataGridCategoriaProduto.DataSource = CategoriaController.ListarCategoria();
        }

        //BOTÃO CADASTRAR (INCLUIR) NOVA CATEGORIA
        private void btnIncluirCategoriaProduto_Click(object sender, EventArgs e)
        {
            FrmCategoriaProdutoManutencao FrmManutencao = new FrmCategoriaProdutoManutencao();
            FrmManutencao.Show();
            AtualizarGridCategoriaProduto();
        }

        // BOTÃO PROCURAR CATEGORIA
        private void btnProcurarCategoriaProduto_Click(object sender, EventArgs e)
        {
            dataGridCategoriaProduto.DataSource = null;
            dataGridCategoriaProduto.DataSource = CategoriaController.ListarCategoria();
        }

        // BOTÃO EDITAR CATEGORIA
        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            var rows = dataGridCategoriaProduto.SelectedRows;
            if (rows.Count == 1)
            {
                var categoria = (ClasseCategoriaProduto)rows[0].DataBoundItem;
                var frm = new FrmCategoriaProdutoManutencao(categoria);
                frm.ShowDialog();                
            }
            AtualizarGridCategoriaProduto();
        }

        // BOTÃO EXCLUIR CATEGORIA
        private void btnExcluirCategoriaProduto_Click(object sender, EventArgs e)
        {
            var rows = dataGridCategoriaProduto.SelectedRows;
            if (rows.Count == 1)
            {
                var categoria = (ClasseCategoriaProduto)rows[0].DataBoundItem;
                dataGridCategoriaProduto.ClearSelection();
                CategoriaController.ExcluirCategoriaProduto(categoria.ID);
                dataGridCategoriaProduto.DataSource = null;
                dataGridCategoriaProduto.DataSource = CategoriaController.ListarCategoria();
            }
            AtualizarGridCategoriaProduto();
        }

        // GRID CATEGORIA
        private void dataGridCategoriaProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
