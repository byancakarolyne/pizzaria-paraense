using System;
using System.Windows.Forms;
using Class;
using Controller;



namespace Pizzaria.Desktop
{
    public partial class FrmCliente : Form
    {
        public ClienteController ClienteController = new ClienteController();

        public FrmCliente()
        {
            InitializeComponent();
            AtualizarGridCliente();            
        }

        // ATUALIZAÇÃO DA GRADE DOS CLIENTES
        private void AtualizarGridCliente()
        {
            var clientes = ClienteController.ListarCliente();
            dataGridCliente.Rows.Clear();
            foreach (var cliente in clientes)
            {
                dataGridCliente.Rows.Add(cliente.ID, cliente.NOME, cliente.FONE, cliente.END);
            }
            dataGridCliente.DataSource = null;
        }

        // BOTÃO SALVAR CADASTRO DO CLIENTE
        private void btnIncluirCliente_Click(object sender, EventArgs e)
        {
            ClasseCliente cliente = new ClasseCliente();
            cliente.NOME = txtNomeCliente.Text;
            cliente.FONE = txtTelefoneCliente.Text;
            cliente.END = txtEnderecoCliente.Text;
            ClienteController.SalvarCliente(cliente);
            AtualizarGridCliente();
        }
        
        
        // BOTÃO EXCLUIR CLIENTE
        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            var rows = dataGridCliente.SelectedRows;
            if (rows.Count == 1)
            {
                ClienteController.ExcluirCliente(Convert.ToInt32(dataGridCliente.CurrentRow.Cells[0].Value));
                dataGridCliente.Rows.RemoveAt(dataGridCliente.CurrentRow.Index);               
            }
        }
       
        // CÓDIGO(ID) CLIENTE
        private void txtCodigoCliente_TextChanged(object sender, EventArgs e)
        {

        }
        // NOME CLIENTE
        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }
        // TELEFONE CLIENTE
        private void txtTelefoneCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        // ENDEREÇO CLIENTE
        private void txtEnderecoCliente_TextChanged(object sender, EventArgs e)
        {

        }
        // GRID DO CLIENTE
        private void dataGridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
