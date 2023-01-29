using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк в массиве (размерность массива)");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] mas = new string[n];
            int n_3 = 0;
            int index = 0;
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Введите "+(i+1)+" слово: ");
                mas[i] = Console.ReadLine();
                if (mas[i].Length<=3){n_3++;}
            }

            Console.Write("Введеный массив строк: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i]+" ");
            }
            Console.WriteLine();

            
            string[] mas_3 = new string[n_3];
            Console.Write("Сформированный массив из строк, длина которых не больше трех символов: ");
            for (int i = 0; i < n; i++)
            {
                if (mas[i].Length <= 3)
                {
                    mas_3[index] = mas[i];
                    Console.Write(mas_3[index] + " ");
                    index++;
                }
                
            }

        }
    }
}
