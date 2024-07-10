using EstoqueFacil.Banco;
using EstoqueFacil.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueFacil.Funcionalidades
{
    internal class checagemEstoque
    {
        public bool checaID(int id)
        {
            ProdutoDAL produtoDAL = new();
            List<Produto> produtos = new();
            if(produtoDAL.validaID(id).Equals(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
