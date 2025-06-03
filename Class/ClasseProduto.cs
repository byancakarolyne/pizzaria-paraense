using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class ClasseProduto
    {
        public int ID { get; set; }
        public string NOME { get; set; }
        public int PRECO { get; set; }
        public ClasseCategoriaProduto CATEGORIA { get; set; }
    }
}
