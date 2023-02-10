using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAluguelFilmesCMD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione 'A' para alugar um filme ou 'S' para sair da locadora: ");
            int opcao = Console.ReadKey(true).KeyChar;

            if (opcao == 'A' || opcao == 'a') {
                Console.WriteLine("*****");
                Console.WriteLine("Bem vindo à MaykAlugueis, Escolha um filme: ");
                Console.WriteLine("********");
                Console.WriteLine("1 - Turbo");
                Console.WriteLine("2 - Carros");
                Console.WriteLine("3 - Top Gun");

                int opcaoFilme = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());
                switch (opcaoFilme)
                {
                    case 1:
                        Console.WriteLine("Turbo excelente escolha, tire seu Ticket logo abaixo");
                        break;
                    case 2:
                        Console.WriteLine("Carros excelente escolha, tire seu Ticket logo abaixo");
                        break;
                    case 3:
                        Console.WriteLine("Top Gun excelente escolha, tire seu Ticket logo abaixo");
                        break;
                    default:
                        Console.WriteLine("Não encontramos essa opção, desculpe!");
                        break;
                }
            } 
            else if (opcao == 'S' || opcao == 's') {
                Console.WriteLine("Obrigado, Volte sempre!");
            }
            else {
                Console.WriteLine("Não conheço essa opção!");
            }
            Console.WriteLine("Pressione qualquer tecla para encerrar");
            Console.ReadKey();
        }
    }
}
