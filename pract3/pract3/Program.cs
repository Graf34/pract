using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[20];//Массив чисел
            string arrayInConsol = "Массив: ";//Для вывода массива

            //Случайное заполнение массива
            Random rand = new Random();
            for (int y = 0; y < 20; y++)
            {
                nums[y] = rand.Next(1, 21);

                arrayInConsol += Convert.ToString(nums[y]) + "; ";
            }
            Console.WriteLine(arrayInConsol);
            //Сортировка массива
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            //Вывод
            arrayInConsol = "Отсортированный: ";

            for (int i = 0; i < nums.Length; i++)
            {
                arrayInConsol +=  Convert.ToString(nums[i])+"; ";
            }
            Console.WriteLine(arrayInConsol);
            Console.ReadLine();

        }
    }
}
