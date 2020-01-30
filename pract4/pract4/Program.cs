using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[20];//Массив чисел
            int[] nums2 = new int[20];//Умноженные на 2
            string arrayInConsol = "Массив: ";//Для вывода массива

            //Случайное заполнение массива
            Random rand = new Random();
            for (int y = 0; y < 20; y++)
            {
                nums[y] = rand.Next(1, 21);

                arrayInConsol += Convert.ToString(nums[y]) + "; ";
                
            }
            //Вывод первого массива
            Console.WriteLine(arrayInConsol);

            arrayInConsol = "Массив 2: ";//Второй массив

            //Заполнение второго массива
            for (int y = 0; y < 20; y++)
            {
                
                nums2[y] = nums[y] * 2;
            }

            //Минимальное число
            int min = nums2[0];
            for (int y = 0; y < 20; y++)
            {
                
                if (nums2[y] < min)
                {
                    min = nums2[y];
                }
            }


            //Замена первого и последнего элемента
            nums2[0] = min;
            nums2[nums2.Length-1] = min;

            for (int y = 0; y < 20; y++)
            {
                //Заполнение переменной вывода
                arrayInConsol += Convert.ToString(nums2[y]) + "; ";
            }
            //Вывод
            Console.WriteLine(arrayInConsol);
            Console.ReadLine();
        }
    }
}


/*
 * 10.	На основе одномерного массива создать второй одномерный массив путем умножения элементов на 2.
 * Заменить первый и последний элемент полученного массива на  минимальное его значение.
 * */
