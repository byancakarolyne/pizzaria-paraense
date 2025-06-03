using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class;
using Model;

namespace Controller
{
    public class ClienteController
    {
        // SALVAR CLIENTE
        public void SalvarCliente(ClasseCliente Cliente)
        {
            if (string.IsNullOrEmpty(Cliente.NOME))
                throw new Exception("O NOME É OBRIGATÓRIO!");

            ClienteModel.SalvarCliente(Cliente);
        }

        // EXCLUIR CLIENTE
        public void ExcluirCliente(int ID)
        {
            if (ID == 0)
                throw new Exception("NENHUM CLIENTE SELECIONADO!");

            ClienteModel.ExcluirCliente(ID);
        }

        // LISTA DE CLIENTES
        public List<ClasseCliente> ListarCliente()
        {
            return ClienteModel.ListarCliente();
        }

    }
}
