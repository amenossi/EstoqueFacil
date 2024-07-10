using System;
using EstoqueFacil.Banco;
using EstoqueFacil.Funcionalidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueFacil.Menus
{
    public class menuExcluir:Menu
    {
        public override void Executar()
        {
            base.Executar();

            ProgramMain main = new();
            Console.Clear();
            ProdutoDAL produtoDal = new();

            Console.WriteLine("Informe o identificador do item que deseja excluir");
            int Id = int.Parse(Console.ReadLine());

            if(produtoDal.validaID(Id).Equals(1))
            {
                produtoDal.deleteProduto(Id);
            }
            else
            {
                Console.WriteLine("Este identificador não existe no sistema. Tente novamente");
                Console.ReadKey();
                menuExcluir excluir = new();
                excluir.Executar();
            }

            main.MenuApresentacao();
        }
    }
}
