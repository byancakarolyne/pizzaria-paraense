using System;
using System.Windows.Forms;
using Class;
using Controller;


namespace Pizzaria.Desktop
{
    public partial class FrmProduto : Form
    {
        public ProdutoController ProdutoController = new ProdutoController();
        public CategoriaProdutoController CategoriaProdutoController = new CategoriaProdutoController();

        public FrmProduto()
        {
            InitializeComponent();
            txtCodProduto.Text = "0";
            var categorias = CategoriaProdutoController.ListarCategoria();
            cbbCategoriaProduto.Items.AddRange(categorias.ToArray()); 
            cbbCategoriaProduto.DisplayMember = nameof(ClasseCategoriaProduto.NOME);
            AtualizarGridProduto();
        }

        // ATUALIZAR GRID DE PRODUTO
        private void AtualizarGridProduto()
        {
            dataGridProduto.DataSource = null;
            dataGridProduto.DataSource = ProdutoController.ListarProduto();
        }

        // BOTÃO SALVAR PRODUTO
        private void btnInserirProduto_Click(object sender, EventArgs e)
        {            
            ClasseProduto Produto = new ClasseProduto();
            Produto.ID = Convert.ToInt32(txtCodProduto.Text);
            Produto.NOME = txtNomeProduto.Text;
            Produto.PRECO = Convert.ToInt32(txtPrecoProduto.Text);
            Produto.CATEGORIA = (ClasseCategoriaProduto) cbbCategoriaProduto.SelectedItem;
            ProdutoController.SalvarProduto(Produto);
            AtualizarGridProduto();
        }
                       
        // BOTÃO EDITAR PRODUTO
        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            var rows = dataGridProduto.SelectedRows;
            if (rows.Count == 1)
            {
                var produto = (ClasseProduto)rows[0].DataBoundItem;
                txtCodProduto.Text = produto.ID.ToString();
                txtNomeProduto.Text = produto.NOME;
                txtPrecoProduto.Text = produto.PRECO.ToString();
                var categoria = produto.CATEGORIA;
                cbbCategoriaProduto.SelectedItem = categoria;
            }
        }
        
        //BOTÃO EXCLUIR PRODUTO
        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            var rows = dataGridProduto.SelectedRows;
            if (rows.Count == 1)
            {
                var produto = (ClasseProduto)rows[0].DataBoundItem;
                dataGridProduto.ClearSelection();
                ProdutoController.ExcluirProduto(produto.ID);
                dataGridProduto.DataSource = null;
                dataGridProduto.DataSource = ProdutoController.ListarProduto();
            }
        }

        // CÓDIGO (ID) PRODUTO
        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {

        }
        // NOME PRODUTO
        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }
        // PREÇO PRODUTO
        private void txtPrecoProduto_TextChanged(object sender, EventArgs e)
        {

        }
        // GRID DO PRODUTO
        private void dataGridProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //COMBO BOX DA CATEGORIA DO PRODUTO
        private void cbbCategoriaProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}