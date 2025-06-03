using System;
using System.Collections.Generic;
using Class;
using Model;

namespace Controller
{
    public class CategoriaProdutoController
    {
        public void SalvarCategoriaProduto(ClasseCategoriaProduto categoria)
        {
            if (string.IsNullOrEmpty(categoria.NOME))
                throw new Exception("O Nome da Categoria é obrigatório!");

            CategoriaProdutoModel.SalvarCategoria(categoria);
        }

        public void ExcluirCategoriaProduto(int Codigo)
        {
            if (Codigo == 0)
                throw new Exception("Nenhuma Categoria selecionada!");

            CategoriaProdutoModel.ExcluirCategoria(Codigo);
        }

        public List<ClasseCategoriaProduto> ListarCategoria()
        {
            return CategoriaProdutoModel.ListarCategoriaProduto();
        }


       
    }
}
