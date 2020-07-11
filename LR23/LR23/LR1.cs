using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR23
{
    class LR1
    {
        int year = 0;
        int age = 0;
        int today = DateTime.Now.Year;
        public void AgeCalc()
        {
            Console.WriteLine("Введите год рождения");
            year = Convert.ToInt32(Console.ReadLine());

            if (year > DateTime.Now.Year)
            {
                Console.WriteLine("Ошибка: год рождения больше текущего");
            }
            else
            {
                Console.WriteLine("Введите ваш возрост");
                age = Convert.ToInt32(Console.ReadLine());
                if (today - year != age)
                {
                    Console.WriteLine("Ошибка: отрицательное значение возраста");
                }
                else
                {
                    Console.WriteLine("Ok");
                }

            }
        }
    }
}
