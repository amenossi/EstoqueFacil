using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueFacil.Objetos
{
    public class Produto
    {
        public int Id { get; set; }
        public string descricao {  get; set; }
        public double valor { get; set; }
        public int quantidade { get; set; }

    }
}
