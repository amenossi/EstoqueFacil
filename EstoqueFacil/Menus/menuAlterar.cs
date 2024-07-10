using EstoqueFacil.Objetos;
using EstoqueFacil.Funcionalidades;
using EstoqueFacil.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueFacil.Menus
{
    public class menuAlterar:Menu
    {
        public override void Executar()
        {
            ProdutoDAL produtoDAL = new();
            Produto produto = new();
            base.Executar();
            Console.WriteLine("Informe o ID do produto que deseja alterar");
            produto.Id = int.Parse(Console.ReadLine());
            int id = produto.Id;


            Console.WriteLine("Informe a descrição do produto");
            produto.descricao = Console.ReadLine();
            Console.WriteLine("Informe o Valor do produto");
            produto.valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do produto");
            produto.quantidade = int.Parse(Console.ReadLine());

            if (produtoDAL.validaID(id).Equals(1))
            {
                produtoDAL.updateProduto(produto);
            }
            else
            {
                Console.WriteLine("O id informado é invalido");
                Console.ReadKey();

                menuAlterar alterar = new();
                alterar.Executar();
            }

            ProgramMain main = new();
            main.MenuApresentacao();
        }
    }
}
