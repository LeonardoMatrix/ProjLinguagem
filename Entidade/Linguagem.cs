using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Linguagem
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Pontuacao { get; set; }

        public override string ToString()
        {


            return "ID: " + this.Id +
                  "\n nome" + this.Nome +
                 "\n pontuacao" + this.Pontuacao;

        }
    }
 
}
