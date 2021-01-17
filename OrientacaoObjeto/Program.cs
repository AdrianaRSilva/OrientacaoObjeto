using System;
using System.Globalization;
namespace OrientacaoObjeto
{
   
        class Program
        {
        private static double xB;

        static void Main(string[] args)
            {
                // programa para ler as medidas dos lados de dois triângulos X e Y usando fórmula de Heron
            CultureInfo CI = CultureInfo.InvariantCulture;
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A= double.Parse(Console.ReadLine(), CI);
                 x.B= double.Parse(Console.ReadLine(), CI);
                 x.C = double.Parse(Console.ReadLine(), CI);

                Console.WriteLine("Entre com as medidas do triângulo Y: ");
                 y.A= double.Parse(Console.ReadLine(), CI);
                 y.B = double.Parse(Console.ReadLine(), CI);
                 y.C= double.Parse(Console.ReadLine(), CI);

                double areaX = x.Area(); //metodo criando na class Triangulo
                double areaY = y.Area();
                                 

                Console.WriteLine("Área de X = " + areaX.ToString("F3", CI));
                Console.WriteLine("Área de Y = " + areaY.ToString("F3", CI));
                if (areaX > areaY)
                {
                    Console.WriteLine("Maior área: X");
                }
                else
                    Console.WriteLine("Maior área: Y ");

            }

        }
    }
   
