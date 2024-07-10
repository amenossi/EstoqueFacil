using EstoqueFacil.Objetos;
using EstoqueFacil.Banco;
using EstoqueFacil.Funcionalidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueFacil.Menus
{
    public class menuVender : Menu
    {
        public override void Executar()
        {

            //Allan, a executar este método, está dando erro, favor tratar amanhã
            base.Executar();
            ProgramMain main = new();
            ProdutoDAL produtoDAL = new();
            Produto produto = new();

            Console.WriteLine("Qual o ID do item você está vendendo ?");
            produto.Id = int.Parse(Console.ReadLine());
            int id = produto.Id;
            if (produtoDAL.validaID(id).Equals(1))
            {
                Console.WriteLine("Quantos itens você está vendendo ?");
                produto.quantidade = int.Parse(Console.ReadLine());
                produtoDAL.subtraiItem(produto);
                Console.WriteLine("Produto vendido com sucesso");
                Console.ReadKey();
                main.MenuApresentacao();
            }
            else
            {
                Console.WriteLine("Id invalido");
                Console.ReadKey();
                menuVender menu = new();
                menu.Executar();
            }

        }
    }
}
