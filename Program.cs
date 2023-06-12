using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula03Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1 = "Conrado";
            string nome2 = "Pedrita";

            int idade1 = 15;
            int idade2 = 19;

            Boolean isCliente1 = false;
            Boolean isCliente2 = true;

            int qtdCafe1 = 187;
            int qtdCafe2 = 5;

            int somaCafes = qtdCafe1 + qtdCafe2;

            int cafesFaltam1 = 200 - qtdCafe1;
            int cafesFaltam2 = 200 - qtdCafe2;

            Console.WriteLine("Aula 03 - Atividade com variáveis\n\n\n");

            Console.WriteLine("Olá!");
            Console.WriteLine("Bem-vindo ao sistema de usuários do Conradito");
            Console.WriteLine("Abaixo estão as informações dos usuários cadastrados no nosso sistema: \n\n\n");

            Console.WriteLine("----- Lista de usuários: ");
            Console.WriteLine($"1 - Nome: {nome1}, idade: {idade1}. É cliente {isCliente1}");
            Console.WriteLine($"2 - Nome: {nome2}, idade: {idade2}. É cliente {isCliente2}\n\n\n");

            Console.WriteLine("----- Quantidade de cafés");
            Console.WriteLine($"O cliente {nome1} já tomou {qtdCafe1} cafés!");
            Console.WriteLine($"O cliente {nome2} já tomou {qtdCafe2} cafés!\n\n\n");

            Console.WriteLine("----- Soma de cafés tomados");
            Console.WriteLine($"Juntos, os clientes {nome1} e {nome2} tomaram {somaCafes} cafés!\n\n\n");

            Console.WriteLine("----- Quantos cafés falta para chegar em 200?");
            Console.WriteLine($"Faltam {cafesFaltam1} para {nome1}");
            Console.WriteLine($"Faltam {cafesFaltam2} para {nome2}\n\n\n\n");

            Console.WriteLine("----- Fim do sistema de consultas");
            Console.Write("- Obrigado e volte sempre!");

            Console.ReadKey();
        }

    }
}
