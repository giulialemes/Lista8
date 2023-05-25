using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8
{
    internal class Program
    {
        public static void Exercício1() {
            Console.WriteLine("Aqui esta codificado o exercício 1 ");
        }
        public static void Exercício2() {
            Console.WriteLine("Aqui esta codificado o exercício 2 ");
        }
        public static void Exercício3() {
            Console.WriteLine("Aqui esta codificado o exercício 3 ");
        }
        public static void Exercício4() {
            Console.WriteLine("Aqui esta codificado o exercício 4 ");
        }
        public static void Exercício5() {
            Console.WriteLine("Aqui esta codificado o exercício 5 ");
        }
        static void Main(string[] args)
        {
            int opcao;


            do
            {
                Console.WriteLine(" ========== MENU ============ ");
                Console.WriteLine(" 1 - EXERCÍCIO 1 ");
                Console.WriteLine(" 2 - EXERCÍCIO 2 ");
                Console.WriteLine(" 3 - EXERCÍCIO 3 ");
                Console.WriteLine(" 4 - EXERCÍCIO 4 ");
                Console.WriteLine(" 5 - EXERCÍCIO 5 ");
                Console.WriteLine(" ========================= ");
                
                opcao = int.Parse(Console.ReadLine()); //Lê a opção escolhida

            switch (opcao){

                    case 0:
                        Console.WriteLine("Thanks for using my system!");
                        break;  

                    case 1:
                        Exercício1();
                        break;

                    case 2:
                        Exercício2();
                        break;

                    case 3:
                        Exercício3();
                        break;

                    case 4:
                        Exercício4();
                        break;

                    case 5:
                        Exercício4();
                        break;
                    default:
                        Console.WriteLine("Não é um exercício válido!");
                        break;

                }

            }while(opcao != 0); 

        }
    }
}
