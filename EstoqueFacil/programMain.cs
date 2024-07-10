using System;
using EstoqueFacil.Menus;
using System.Collections.Generic;

namespace EstoqueFacil
{
    public class ProgramMain
    {
        private Dictionary<int, Menu> opcoes = new Dictionary<int, Menu>();
        public ProgramMain()
        {
            opcoes.Add(1, new menuAdicionar());
            opcoes.Add(2, new menuAlterar());
            opcoes.Add(3, new menuListar());
            opcoes.Add(4, new menuExcluir());
            opcoes.Add(5, new menuVender());
            opcoes.Add(6, new Relatorios());
        }

        public void MenuApresentacao()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao Estoque Fácil");
            Console.WriteLine("1 - Para cadastrar um produto");
            Console.WriteLine("2 - Para alterar os dados de um produto");
            Console.WriteLine("3 - Para ver os produtos cadastrados");
            Console.WriteLine("4 - Para excluir um produto");
            Console.WriteLine("5 - Para vender um produto");
            Console.WriteLine("5 - Para gerar um relatório");
            var opc = Console.ReadLine();
            if (opcoes.ContainsKey(int.Parse(opc)))
            {
                Menu menuExibido = opcoes[int.Parse(opc)];
                menuExibido.Executar();
            }
        }

        public static void Main()
        {
            ProgramMain programa = new ProgramMain();
            programa.MenuApresentacao();
            
        }
    }
}