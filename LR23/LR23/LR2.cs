using System;
using System.Collections.Generic;
using System.Text;

namespace LR23
{
    class LR2
    {
        public int r1 = 0;
        public int r2 = 0;
        public int r3 = 0;
        public void function()
        {
            Console.WriteLine("Введите R1, R2, R3");
            int r1 = Convert.ToInt32(Console.ReadLine());
            int r2 = Convert.ToInt32(Console.ReadLine());
            int r3 = Convert.ToInt32(Console.ReadLine());

            double rez = Math.Sin(r2) / Math.PI * r1 + r3;
            if (rez > 100)
                Console.WriteLine("Потеря разряда, переполнение");

            int Rr = r2 - r3;
            if (Rr == 0)
                Console.WriteLine("Потеря разряда, деление на 0");

            if (rez < 0.0001)
                Console.WriteLine("Исчезновение порядка");

            Console.WriteLine(rez);
        }
    }
}
