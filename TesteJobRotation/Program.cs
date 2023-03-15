using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace TesteJobRotation
{
    internal class Program
    {
        public static string reverterPalavra (string palavra)
        {
            char[] charArray = palavra.ToCharArray();

            string reverterstring = String.Empty;

            for (int i = charArray.Length - 1; i > -1; i--)
            {

                reverterstring += charArray[i];
            }

            return reverterstring;
        }
        static void Main(string[] args)
        {
            int menu = 6;

            while (menu != 9)
            {

                string palavraMain;
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        int indice = 13;
                        int soma = 0;
                        int k = 0;
                        while (k < indice)
                        {
                            k = k + 1;
                            soma = soma + k;
                        }

                        Console.WriteLine("O Valor de Soma Sera de:" + soma);
                        Console.ReadKey();
                        menu = 6;
                        break;
                    case 2:
                        Console.Clear ();
                        int num;
                        Console.Write("Informe um número inteiro positivo: ");
                        num = int.Parse(Console.ReadLine());

                        int a = 0, b = 1, c = 0;
                        while (c < num)
                        {
                            c = a + b;
                            a = b;
                            b = c;
                        }

                        if (c == num)
                        {
                            Console.WriteLine("{0} pertence à sequência de Fibonacci.", num);
                        }
                        else
                        {
                            Console.WriteLine("{0} não pertence à sequência de Fibonacci.", num);
                        }

                        Console.ReadKey();
                        menu = 6;


                        break;
                    case 3:
                        break;
                    case 4:
                        Console.Clear ();
                        decimal sp = 67836.43M;
                        decimal rj = 36678.66M;
                        decimal mg = 29229.88M;
                        decimal es = 27165.48M;
                        decimal outros = 19849.53M;
                        decimal total = sp + rj + mg + es + outros;

                        decimal percentualSP = (sp / total) * 100;
                        decimal percentualRJ = (rj / total) * 100;
                        decimal percentualMG = (mg / total) * 100;
                        decimal percentualES = (es / total) * 100;
                        decimal percentualOutros = (outros / total) * 100;

                        Console.WriteLine("Percentual de representação por estado:");
                        Console.WriteLine("SP: {0:f2}%", percentualSP);
                        Console.WriteLine("RJ: {0:f2}%", percentualRJ);
                        Console.WriteLine("MG: {0:f2}%", percentualMG);
                        Console.WriteLine("ES: {0:f2}%", percentualES);
                        Console.WriteLine("Outros: {0:f2}%", percentualOutros);

                        Console.ReadKey();
                        menu = 6;
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Digite a palavra desejada para inverter a ordem:");
                        palavraMain = Console.ReadLine();
                        Console.WriteLine(reverterPalavra(palavraMain));
                        Console.ReadKey();
                        menu = 6;
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Menu de Questões:");
                        Console.WriteLine("(1) - Valor de Soma:");
                        Console.WriteLine("(2) - Valor de Fibonacci:");
                        Console.WriteLine("(4) - Percentual Estados:");
                        Console.WriteLine("(5) - Inverter Palavra:");
                        Console.WriteLine("(9) - Sair do Programa.");
                        Console.WriteLine("Digite a Opção:");
                        menu = int.Parse(Console.ReadLine());
                        break;
                }
            }
        }
    }
}
