using System;
using EstoqueFacil.Funcionalidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueFacil.Menus
{
    internal class Relatorios : Menu
    {
        public override void Executar()
        {
            base.Executar();
            Relatorio GeraRelatorio = new();

            GeraRelatorio.GeraRelatorio();
            Console.WriteLine("Relatório gerado com sucesso !");
            Console.ReadKey();
        }
    }
}
