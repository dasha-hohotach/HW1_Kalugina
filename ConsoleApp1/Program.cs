using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Daria Kalugina";
            #region Task1
            // а)
            Console.Write("Введите имя: ");
            string s1 = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string s2 = Console.ReadLine();
            Console.Write("Введите возраст: ");
            string s3 = Console.ReadLine();
            Console.Write("Введите рост: ");
            string s4 = Console.ReadLine();
            Console.Write("Введите вес: ");
            string s5 = Console.ReadLine();
            Console.WriteLine(s1 + ", " + s2 + ", " + s3 + ", " + s4 + ", " + s5);
            //  б)
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", s1, s2, s3, s4, s5);
            //  в)
            Console.WriteLine($"{s1}, {s2}, {s3}, {s4}, {s5}");
            Console.ReadLine();
            Console.Clear();
            #endregion
            #region Task 2
            double m;
            double h;
            Console.Write("Введите массу тела (в кг): ");
            string mass = Console.ReadLine();
            Console.Write("Введите рост (в м): ");
            string hght = Console.ReadLine();
            m = Convert.ToDouble(mass);
            h = Convert.ToDouble(hght);
            double l = m / (h * h);
            Console.WriteLine($"ИМТ: {m} / ({h} * {h}) = {l}");
            Console.WriteLine("ИМТ: {0} / ({1} * {1} = {2:F2}", m, h, l);
            Console.ReadLine();
            Console.Clear();
            #endregion
            #region   Task 6         
            Console.WriteLine("Дарья");  //а)
            Console.WriteLine("Калугина");
            Console.WriteLine("Санкт-Петербург");
            Console.ReadLine();
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);   //б)
            Console.Write("Дарья Калугина Санкт-Петербург");
            Console.ReadLine();
            string[] str = { "Дарья", "Калугина", "Санкт-Петербург" };   //в)
            int width = Console.WindowWidth, height = Console.WindowHeight;
            Print();
            while (true)
            {
                if (width != Console.WindowWidth || height != Console.WindowHeight)
                {
                    width = Console.WindowWidth;
                    height = Console.WindowHeight;
                    Print();
                }
            }

            void Print()
            {
                int top = Console.WindowHeight / 2 - str.Length / 2;
                for (int i = 0; i < str.Length; i++, top++)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - str[i].Length / 2, top);
                    Console.Write(str[i]);
                    #endregion
                }
            }
        }
    }
}
