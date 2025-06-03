using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class;

namespace Model
{
    public static class CategoriaProdutoModel
    {
        // CATEGORIA DOS PRODUTOS   
        public static List<ClasseCategoriaProduto> Lista = new List<ClasseCategoriaProduto> {
            new ClasseCategoriaProduto { ID = 0, NOME = "PIZZAS"}, 
            new ClasseCategoriaProduto { ID = 1, NOME = "BEBIDAS" }, 
            new ClasseCategoriaProduto { ID = 2, NOME = "HAMBURGUERES" }, 
        };

        // LISTA DAS CATEGORIAS
        public static List<ClasseCategoriaProduto> ListarCategoriaProduto()
        {
            return Lista;
        }

        // SALVAR CATEGORIA
        public static void SalvarCategoria(ClasseCategoriaProduto categoria)
        {
            if (categoria.ID == 0)
            {
                categoria.ID = Lista.Any() ? Lista.Max(x => x.ID + 1) : 1;
                Lista.Add(categoria);
            }
            else
            {
                ClasseCategoriaProduto cat = Lista.Find(x => x.ID == categoria.ID);
                cat.NOME = categoria.NOME;
            }
        }

        // EXCLUIR CATEGORIA
        public static void ExcluirCategoria(int Codigo)
        {
            Lista.Remove(Lista.Find(x => x.ID == Codigo));
        }

    }
}
