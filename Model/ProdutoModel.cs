using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class;



namespace Model
{
    public static class ProdutoModel
    {
        // POPULAÇÃO DOS PRODUTOS COM AS RESPECTIVAS CATEGORIAS
        public static List<ClasseProduto> Lista = new List<ClasseProduto> {
            new ClasseProduto { ID = 1, NOME = "MUSSARELA", PRECO = 20, CATEGORIA = CategoriaProdutoModel.Lista[0] },
            new ClasseProduto { ID = 2, NOME = "REFRIGERANTE", PRECO = 7, CATEGORIA = CategoriaProdutoModel.Lista[1] },
            new ClasseProduto { ID = 3, NOME = "X-SALADA", PRECO = 16, CATEGORIA = CategoriaProdutoModel.Lista[2] },
           
        };

        // LISTA DOS PRODUTOS
        public static List<ClasseProduto> ListarProduto()
        {
                   return Lista;
        }

        // SALVAR PRODUTO
        public static void SalvarProduto(ClasseProduto produto)
        {
            if (produto.ID == 0)
            {
                produto.ID = Lista.Any() ? Lista.Max(x => x.ID + 1) : 1;
                Lista.Add(produto);
            }
            else
            {
                ClasseProduto p = Lista.Find(x => x.ID == produto.ID);
                p.NOME = produto.NOME;
                p.PRECO = produto.PRECO;
                p.CATEGORIA = produto.CATEGORIA;

            }
        }


        // EXCLUIR PRODUTO
        public static void ExcluirProduto(int Codigo)
        {
            Lista.Remove(Lista.Find(x => x.ID == Codigo));
        }

    }
}
