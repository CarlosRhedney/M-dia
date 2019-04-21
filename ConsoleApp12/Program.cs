using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, NM, Nm, nmenor;
            string s;
            Console.Write("Digite o 1° número: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 2° número: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 3° número: ");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a > b) && (a > c) && (b > c))
            {
                NM = a;
                Nm = b;
                nmenor = c;
                Console.Write("\nMaior: {0}\tMédio: {1}\tMenor: {2}", NM, Nm, nmenor);
            }
            else if ((a > b) && (a > c) && (c > b))
            {
                NM = a;
                Nm = c;
                nmenor = b;
                Console.Write("\nMaior: {0}\tMédio: {1}\tMenor: {2}", NM, Nm, nmenor);

            }
            else if ((b > a) && (b > c) && (a > c))
            {
                NM = b;
                Nm = a;
                nmenor = c;
                Console.Write("\nMaior: {0}\tMédio: {1}\tMenor: {2}", NM, Nm, nmenor);

            }
            else if ((b > a) && (b > c) && (c > a))
            {
                NM = b;
                Nm = c;
                nmenor = a;
                Console.Write("\nMaior: {0}\tMédio: {1}\tMenor: {2}", NM, Nm, nmenor);

            }
            else if ((c > a) && (c > b) && (a > b))
            {
                NM = c;
                Nm = a;
                nmenor = b;
                Console.Write("\nMaior: {0}\tMédio: {1}\tMenor: {2}", NM, Nm, nmenor);
            }
            else if ((c > a) && (c > b) && (b > a))
            {
                NM = c;
                Nm = b;
                nmenor = a;
                Console.Write("\nMaior: {0}\tMédio: {1}\tMenor: {2}", NM, Nm, nmenor);
            }
            Console.Write("\n********************************************************************************");
            Console.Write("\n\nDeseja continuar com mais números?\nDigite \"s\" para sim e \"n\" para não: ");
            s = Console.ReadLine();
            while (s == "s")
            {
                Console.Write("\nDigite o 1° número: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o 2° número: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o 3° número: ");
                c = Convert.ToInt32(Console.ReadLine());

                if ((a > b) && (a > c) && (b > c))
                {
                    NM = a;
                    Nm = b;
                    nmenor = c;
                    Console.Write("\nMaior: {0}\tMédio: {1}\tMenor: {2}", NM, Nm, nmenor);
                }
                else if ((a > b) && (a > c) && (c > b))
                {
                    NM = a;
                    Nm = c;
                    nmenor = b;
                    Console.Write("\nMaior: {0}\tMédio: {1}\tMenor: {2}", NM, Nm, nmenor);

                }
                else if ((b > a) && (b > c) && (a > c))
                {
                    NM = b;
                    Nm = a;
                    nmenor = c;
                    Console.Write("\nMaior: {0}\tMédio: {1}\tMenor: {2}", NM, Nm, nmenor);

                }
                else if ((b > a) && (b > c) && (c > a))
                {
                    NM = b;
                    Nm = c;
                    nmenor = a;
                    Console.Write("\nMaior: {0}\tMédio: {1}\tMenor: {2}", NM, Nm, nmenor);

                }
                else if ((c > a) && (c > b) && (a > b))
                {
                    NM = c;
                    Nm = a;
                    nmenor = b;
                    Console.Write("\nMaior: {0}\tMédio: {1}\tMenor: {2}", NM, Nm, nmenor);
                }
                else if ((c > a) && (c > b) && (b > a))
                {
                    NM = c;
                    Nm = b;
                    nmenor = a;
                    Console.Write("\nMaior: {0}\tMédio: {1}\tMenor: {2}", NM, Nm, nmenor);
                }
                Console.Write("\n********************************************************************************");
                Console.Write("\n\nDeseja continuar com mais números?\nDigite \"s\" para sim e \"n\" para não: ");
                s = Console.ReadLine();
            }
        }
    }
}
