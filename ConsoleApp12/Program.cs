using System;
using System.Drawing;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите цвет геометрической фигуры: \n1. Зеленый\n2. Синий\n3. Красный\n");
            string color;
            color = Console.ReadLine();
            switch (color)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "3":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }

            Console.WriteLine("Выберите геометрическую фигуру: \n1. Треугольник\n2. Прямоугольник\n3. Ромб" +
                "\n4. Трапеция\n5. Многоугольник\n");
            string Figuri;
            Figuri = Console.ReadLine();
            switch (Figuri)
            {
                case "1":
                    Treugolnik Figura1 = new Treugolnik();
                    Figura1.PrintTreugolnik();

                    break;
                case "2":
                    Preamougolnik Figura2 = new Preamougolnik();
                    Figura2.PrintPreamougolnik();
                    break;
                case "3":
                    Romb Figura3 = new Romb();
                    Figura3.PrintRomb();
                    break;
                case "4":
                    Trapetia Figura4 = new Trapetia();
                    Figura4.PrintTrapetia();
                    break;
                case "5":
                    Mnogougolnik Figura5 = new Mnogougolnik();
                    Figura5.PrintMnogougolnik();
                    break;
            }

        }

        public class Treugolnik
        {
            public void PrintTreugolnik()
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }

        public class Preamougolnik
        {
            public void PrintPreamougolnik()
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
        public class Romb
        {
            public void PrintRomb()
            {
                int a = 0;
                Console.Write("\n");
                for (int i = 4; i > 0; i--)
                {
                    Console.Write("\t");
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(' ');
                    }
                    for (int k = 0; k <= a * 2; k++)
                    {
                        Console.Write('*');
                    }
                    Console.Write("\n");
                    a++;
                }
                for (int i = 0; i <= 4; i++)
                {
                    Console.Write("\t");
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(' ');
                    }
                    for (int k = 0; k <= a * 2; k++)
                    {
                        Console.Write('*');
                    }
                    Console.Write("\n");
                    a--;
                }

            }
        }
        public class Trapetia 
        {
            public void PrintTrapetia() 
            {
                int a = 3;
                Console.Write("\n");
                for (int i = 7; i > 3; i--)
                {
                    Console.Write("\t");
                    for (int j = 3; j < i; j++)
                    {
                        Console.Write(' ');
                    }
                    for (int k = 3; k <= a * 2; k++)
                    {
                        Console.Write('*');
                    }
                    Console.Write("\n");
                    a++;
                }
            }

        }
        public class Mnogougolnik 
        {
            public void PrintMnogougolnik()
            {
                int a = 5;
                Console.Write("\n");
                for (int i = 4; i > 0; i--)
                {
                    Console.Write("\t");
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(' ');
                    }
                    for (int k = 0; k <= a * 2; k++)
                    {
                        Console.Write('*');
                    }
                    Console.Write("\n");
                    a++;
                }
                for (int i = 0; i <= 4; i++)
                {
                    Console.Write("\t");
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(' ');
                    }
                    for (int k = 0; k <= a * 2; k++)
                    {
                        Console.Write('*');
                    }
                    Console.Write("\n");
                    a--;
                }
            }
        }

    }
}
