using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;


namespace pract2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинну большей полуоси: ");
            
            int a=0;//Большая полуось
            try
            {
                //Попытка ввода данных
                a = Convert.ToInt32(Console.ReadLine());           

            }
            catch
            {
                //Если возникла ошибка
                Console.WriteLine("Введённые символы не являются числом!");
                Console.ReadLine();
                //Перезапустить приложение
                Process.Start(Assembly.GetExecutingAssembly().Location);
                Environment.Exit(0);
            }
            Console.Write("Введите длинну меньшей полуоси: ");
            int b = 0;//Большая полуось
            try
            {
                //Попытка ввода данных
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                //Если возникла ошибка
                Console.WriteLine("Введённые символы не являются числом!");
                Console.ReadLine();
                //Перезапустить приложение
                Process.Start(Assembly.GetExecutingAssembly().Location);
                Environment.Exit(0);
            }
            //Вывод
            Console.WriteLine("Площадь элипса = "+ Math.PI * a* b );
            Console.ReadLine();
        }
    }
}
