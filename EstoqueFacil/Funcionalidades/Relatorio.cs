using System;
using EstoqueFacil.Banco;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstoqueFacil.Objetos;

namespace EstoqueFacil.Funcionalidades
{
    internal class Relatorio
    {
        public void GeraRelatorio()
        {

            ProdutoDAL produtoDAL = new();
            List<Produto> produto = new();
            produtoDAL.getProdutos(out produto);

            using StreamWriter writer = new StreamWriter("relatório.csv", true);

            foreach (Produto produtos in produto)
            {
                writer.WriteLine($"{produtos.Id},{produtos.descricao},{produtos.quantidade},{produtos.valor}");
            }
            
        }
    }
}
