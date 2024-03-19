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



            /* Calcular a area de uma forma geométrica (while/case)
            
            
            
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
                        Console.WriteLine("A área do quadrado é: ");
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
            */

            
            
            double sala = 0;

            while (cont == 0)
            {

                Console.WriteLine("Como você ganha dinheiro: ");
                Console.WriteLine("1- Assalariado");
                Console.WriteLine("2- Comissionado ");
                Console.WriteLine("3- Horista ");
                Console.Write("Escolha: ");
                int caso = int.Parse(Console.ReadLine());

                switch (caso)
                {
                    case 1:
                        Console.Write("Digite o salário bruto: R$");
                        double bruto = double.Parse(Console.ReadLine());
                        Console.Write("digite o desconto: R$");
                        double des = double.Parse(Console.ReadLine());
                        cont = 1;
                        sala = bruto - des;

                       
                        break;

                    case 2:
                        Console.Write("Digite Quantas unidades você vendeu:");
                        int quant = int.Parse(Console.ReadLine());
                        Console.Write("digite o valor por cada unidade: R$");
                        double valor = double.Parse(Console.ReadLine());
                        cont = 1;
                        sala = quant * valor;
                        break;

                    case 3:
                        Console.Write("Digite quantas horas trabalhou: ");
                        int hora = int.Parse(Console.ReadLine());
                        Console.Write("digite o dvalor por hora: R$");
                        valor = double.Parse(Console.ReadLine());
                        cont = 1;
                        sala = hora * valor;
                        break;

                    default:
                        Console.WriteLine("Trabalho invalido, tente denovo");
                        Console.ReadKey();
                        break;
                }
            }
            if (sala <= 2000)
            {
                double ir = sala * 0.075;
                Console.WriteLine("Você pagará " + ir.ToString("C") + " de IR(7,5%)");
            }
            else if (sala <= 4000)
            {
                double ir = sala * 0.12;
                Console.WriteLine("Você pagará " + ir.ToString("C") + " de IR(12%)");
            }
            else
            {
                double ir = sala * 0.15;
                Console.WriteLine("Você pagará " + ir.ToString("C") + " de IR(15%)");
            }

            Console.ReadKey (); 
        }
    }
}
