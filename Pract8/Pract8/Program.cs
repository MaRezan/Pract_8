using System;

namespace Pract8
{
    class Program
    {
        static void Main(string[] args)
        {

          int[,] mass = new int[10, 10];
          Random rand = new Random();
          for (int i = 0; i < mass.GetLength(0); i++)
          {
              for (int j = 0; j < mass.GetLength(1); j++)
              {
                  mass[i, j] = rand.Next(-20, 20);
                  Console.Write(mass[i, j] + "\t");
              }
              Console.WriteLine("\n\n");
          }

          Console.WriteLine("\n");
          
          int b = 0;
          int b1 = 1;
          int c = -51;
          int d = 0;
          int d1 = 0;
          for (int i = 0; i < mass.GetLength(0); i++)
          {

              for (int j = b; j < b1; j++)
              {
                  if (mass[i, j] > c)
                  {
                      c = mass[i, j];
                      d = i;
                      d1 = j;
                  }
              }
              b++;
              b1++;
          }
          Console.WriteLine($"Координаты Max элемента главной диоганали [{d1 + 1}:{10 - (d + 1)}]");
          Console.WriteLine($"Max главной диоганали: {c}\n");


          b = 0;
          b1 = 1;
          c = -51;
          d = 0;
          d1 = 0;
          for (int i = mass.GetLength(0) - 1; i > 0; i--)
          {

              for (int j = b; j < b1; j++)
              {
                  if (mass[i, j] > c)
                  {
                      c = mass[i, j];
                      d = i;
                      d1 = j;
                  }
              }
              b++;
              b1++;
          }
          Console.WriteLine($"Координаты Max элемента побочной диоганали [{d1 + 1}:{10 - (d + 1)}]");
          Console.WriteLine($"Наибольшее число побочной диагонали {c}");

         
          Console.WriteLine("\nСуммы элементов столбцов");
          int sum = 0;
          for (int i = 0; i < mass.GetLength(0); i++)
          {

              for (int j = 0; j < mass.GetLength(0); j++)
              {
                  sum += mass[j, i];

              }
              Console.Write(sum + "\t");
              sum = 0;
          }
            Console.WriteLine("\n");
        }
    }
}
