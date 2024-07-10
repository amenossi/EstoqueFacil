using EstoqueFacil.Banco;
using EstoqueFacil.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueFacil.Menus
{
    public class menuListar : Menu
    {
        public override void Executar()
        {
            base.Executar();
            ProdutoDAL getProduto = new();
            List<Produto> products = new();
            getProduto.getProdutos(out products);



            foreach (Produto prod in products)
            {
                Console.WriteLine($"ID: {prod.Id} Produto: {prod.descricao} Valor: R${prod.valor} Quantidade: {prod.quantidade}");
            }
            Console.ReadKey();

            ProgramMain programMain = new();
            programMain.MenuApresentacao();
        }
    }
}
