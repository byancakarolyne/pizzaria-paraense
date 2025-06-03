using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class;

namespace Model
{
    public class ClienteModel
    {
        //POPULAÇÃO DOS CLIENTES
        private static List<ClasseCliente> Lista = new List<ClasseCliente>
        {
            new ClasseCliente { ID = 1, NOME = "BYANCA", FONE = "13997558115", END ="AV CNSO NEBIAS, 459"},
            new ClasseCliente { ID = 2, NOME = "ADRIANA", FONE = "13997558115", END ="NABUCO DE ARAUJO, 56"}
        };

        // LISTA DOS CLIENTES
        public static List<ClasseCliente> ListarCliente()
        {
            return Lista;
        }


        // SALVAR CLIENTE
        public static void SalvarCliente(ClasseCliente Cliente)
        {
            if (Cliente.ID == 0)
            {
                Cliente.ID = Lista.Any() ? Lista.Max(x => x.ID + 1) : 1;
                Lista.Add(Cliente);
            }
            else
            {
                ClasseCliente c = Lista.Find(x => x.ID == Cliente.ID);
                c.NOME = Cliente.NOME;
                c.FONE = Cliente.FONE;
                c.END = Cliente.END;
            }
        }

        // EXCLUIR CLIENTE
        public static void ExcluirCliente(int Codigo)
        {
            Lista.Remove(Lista.Find(x => x.ID == Codigo));
        }
        
    }
}
