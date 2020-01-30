using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1
{
    class Program
    {
        static void Main(string[] args)
        {
            int min;//Минимальный элемент
            int all = 0;//Сумма 
            int[] nums = new int[20];//Массив чисел
            string arrayInConsol = "Массив: ";//Для вывода массива

            //Случайное заполнение массива
            Random rand = new Random();           
            for (int y = 0; y < 20; y++)
            {
                nums[y] = rand.Next(1, 21);

                arrayInConsol += Convert.ToString(nums[y])+"; ";
            }
            
            Console.WriteLine(arrayInConsol);//Вывод массива в консоль
            min = nums[0];
            foreach (int nm in nums)//Перебор массива 
            {
                if (nm < min)//Если меньше, 
                {
                    min = nm;//то поменять переменную меньшего числа 
                }
                all += nm;//Общая сумма 
            }
            //Вывод
            Console.WriteLine("Сумма: "+Convert.ToString(all));
            Console.WriteLine("Минимальный элемент: " + Convert.ToString(min));
            Console.ReadKey();
        }
    }
}
