using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class ClasseCategoriaProduto
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public override string ToString()
        {
            return NOME;
        }
    }
}
