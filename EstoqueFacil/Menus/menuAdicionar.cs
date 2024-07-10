using EstoqueFacil.Objetos;
using EstoqueFacil.Banco;
using EstoqueFacil.Funcionalidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EstoqueFacil.Menus
{
    public class menuAdicionar:Menu
    {
        public override void Executar()
        {
            ProgramMain programMain = new();
            var produtoDAL = new ProdutoDAL();
            Produto produto = new();
            base.Executar();

            Console.WriteLine("Qual a identificação do item ?");
            produto.Id = int.Parse(Console.ReadLine());
            int id = produto.Id;

            Console.WriteLine("Quantos itens você está registrando ?");
            produto.quantidade = int.Parse(Console.ReadLine());

            if (produtoDAL.validaID(id).Equals(1))
            {
                produtoDAL.adcionarProdExistente(produto);

                Console.WriteLine($"Produto cadastrado com sucesso");
                Console.ReadKey();

                programMain.MenuApresentacao();

            }

            Console.WriteLine("Qual a descrição do item ?");
            produto.descricao = Console.ReadLine();

            Console.WriteLine("Qual o Valor do item ?");
            produto.valor = Double.Parse(Console.ReadLine());

            produtoDAL.adicionarProduto(produto);

            Console.WriteLine($"Produto cadastrado com sucesso");
            Console.ReadKey();

            programMain.MenuApresentacao();
        }
    }
}
