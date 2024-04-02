using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int contd = 0;
            int conta = 0;
            int conte = 0;
            int contm = 0;
            string resp;
            string resp2;
            string resp3;

            Console.WriteLine("Deseja começar? S - sim N - não");
            resp = Console.ReadLine();

            while (resp == "S")
            {
                Console.WriteLine("Qual curso deseja participar? D - desenvolvimento de sistemas A - administração E - edificação M - mecatrônica ");
                resp2 = Console.ReadLine();

                switch (resp2)
                {
                    case "D":
                        if (contd < 5)
                        {
                            contd++;
                            cont ++;

                            Console.WriteLine("O aluno está matriculado em Desenvolvimento de sistemas.");
                        } else 
                        {
                            Console.WriteLine("Curso Indisponível.");
                        }
                        break;

                    case "A":
                        if (cont < 5)
                        {
                            conta++;
                            cont++;

                            Console.WriteLine("O aluno está matriculado em Administração.");
                        } else 
                        {
                            Console.WriteLine("Curso Indisponível.");
                        }
                        break;

                    case "E":
                        if (conte < 5)
                        {
                            conte++;
                            cont++;

                            Console.WriteLine("O aluno está matriculado em Edificações.");
                        } else 
                        {
                            Console.WriteLine("Curso Indisponível.");
                        }
                        break;

                    case "M":
                        if (contm < 5)
                        {
                            contm++;
                            cont++;

                            Console.WriteLine("O aluno está matriculado em Mecatrônica.");
                        } else 
                        {
                            Console.WriteLine("Curso Indisponível.");
                        }
                        break;

                        default:
                        {
                            Console.WriteLine("Opção Inválida.");
                        }
                        break;
                }

                Console.WriteLine("Deseja continuar? S - sim N - não");
                resp = Console.ReadLine();

            }

            Console.WriteLine("O total de matrículas é de " + cont);
            Console.WriteLine("O total de matrículas no curso de Desenvolvimento de sistemas é de " + contd);
            Console.WriteLine("O total de matrículas no curso de Administração é de " + conta);
            Console.WriteLine("O total de matrículas no curso de Edificações é de " + conte);
            Console.WriteLine("O total de matrículas no curso de Mecatrônica é de " + contm);

            Console.ReadKey();
        }
    }
}
