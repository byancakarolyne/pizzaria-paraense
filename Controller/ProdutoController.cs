using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class;
using Model;

namespace Controller
{
   public class ProdutoController
    {
        public void SalvarProduto(ClasseProduto produto)
        {
            if (string.IsNullOrEmpty(produto.NOME))
                throw new Exception("O NOME É OBRIGATÓRIO!");

            ProdutoModel.SalvarProduto(produto);
        }

        public void ExcluirProduto(int ID)
        {
            if (ID == 0)
                throw new Exception("NENHUM PRODUTO SELECIONADO!");

            ProdutoModel.ExcluirProduto(ID);
        }

        public List<ClasseProduto> ListarProduto()
        {
            return ProdutoModel.ListarProduto();
        }

    }
}
