using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnquantoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int cont = 0;
            /* Conta usando case
            while (cont == 0)
            {
                Console.Write("Escolha uma operação(+, -, /, *): ");
                String caso = Console.ReadLine();

                Console.Write("Escolha o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Escolha o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());


                switch (caso)
                {
                    case "+":
                        double resp = num1 + num2;
                        Console.WriteLine("Result: " + resp);
                        cont = 1;
                        break;

                    case "-":
                        resp = num1 - num2;
                        Console.WriteLine("Result: " + resp);
                        cont = 1;
                        break;

                    case "*":
                        resp = num1 * num2;
                        Console.WriteLine("Result: " + resp);
                        cont = 1;
                        break;

                    case "/":
                        if (num2 == 0)
                        {
                            Console.Write("Você tem certeza(s/n)? ");
                            string talvez = Console.ReadLine(); 

                            switch (talvez)
                            {
                                case "s":
                                   Console.WriteLine("\r\n███████████████████████████\r\n███████▀▀▀░░░░░░░▀▀▀███████\r\n████▀░░░░░░░░░░░░░░░░░▀████\r\n███│░░░░░░░░░░░░░░░░░░░│███\r\n██▌│░░░░░░░░░░░░░░░░░░░│▐██\r\n██░└┐░░░░░░░░░░░░░░░░░┌┘░██\r\n██░░└┐░░░░░░░░░░░░░░░┌┘░░██\r\n██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██\r\n██▌░│██████▌░░░▐██████│░▐██\r\n███░│▐███▀▀░░▄░░▀▀███▌│░███\r\n██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██\r\n██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██\r\n████▄─┘██▌░░░░░░░▐██└─▄████\r\n█████░░▐█─┬┬┬┬┬┬┬─█▌░░█████\r\n████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████\r\n█████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████\r\n███████▄░░░░░░░░░░░▄███████\r\n██████████▄▄▄▄▄▄▄██████████\r\n███████████████████████████");
                                   break;

                                case "n":
                                    Console.WriteLine("UFA!! faz denovo");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        else
                        {
                            double respost = num1 / num2;
                            Console.WriteLine("Result: " + respost);
                            cont = 1;

                        }
                        
                        break;

                    default:
                        Console.WriteLine("Opção indisponivel, Porfavor repita o processo");

                        Console.ReadKey();
                        break;
                }
            }

            Console.ReadKey();
            */
            while (cont == 0)
            {
                
                Console.WriteLine("Escolha uma das formas geométrica:");
                Console.WriteLine("1- Quadrado");
                Console.WriteLine("2- Triangulo");
                Console.WriteLine("3- Trapésio");
                Console.WriteLine("4- Losango");
                Console.Write("Escolha(n): ");
                int forma = int.Parse(Console.ReadLine());

                switch (forma)
                {
                    case 1:
                        Console.Write("Digite o valor do lado: ");
                        double L = double.Parse(Console.ReadLine());
                        double area = L * L;
                        Console.WriteLine("A área do quadrado é: " + area);
                        cont = 1;
                        break;

                    case 2:
                        Console.Write("Digite o valor de um dos lados: ");
                        L = double.Parse(Console.ReadLine());
                        Console.Write("Digite o valor de outro lado: ");
                        double L2 = double.Parse(Console.ReadLine());
                        area = (L * L2) / 2;
                        Console.WriteLine("A área do triangulo é: " + area);
                        cont = 1;
                        break;

                    case 3:
                        Console.Write("Digite o valor do comprimento maior: ");
                        double B = double.Parse(Console.ReadLine());
                        Console.Write("Digite o valor do comprimento menor: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Digite o valor da altura: ");
                        double H = double.Parse(Console.ReadLine());
                        area = ((B + b) * H) / 2;
                        Console.WriteLine("A área do trapézio é: " + area);
                        cont = 1;
                        break;

                    case 4:
                        Console.Write("Digite o valor do diametro vertical: ");
                        double V = double.Parse(Console.ReadLine());
                        Console.Write("Digite o valor do diametro horizontal: ");
                        H = double.Parse(Console.ReadLine());
                        area = (V * H) / 2;
                        Console.WriteLine("A área do losango é: " + area);
                        cont = 1;
                        break;

                    default:
                        Console.WriteLine("Opção invalida, tente novamente");
                        Console.ReadKey();
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
