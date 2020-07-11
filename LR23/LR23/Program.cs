using System;

namespace LR23
{
    class Program
    {
        static void Main(string[] args)
        {
            LR1 lr1 = new LR1();
            Interface face = new Interface();
            LR2 lr2 = new LR2();

        menu:
            Console.Clear();
            face.menu();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Exit")
                    break;

                switch (command)
                {
                    case "1":
                        {
                            Console.Clear();
                            lr1.AgeCalc();
                            Console.ReadKey();
                            goto menu;
                        }
                    case "2":
                        {
                            Console.Clear();
                            lr2.function();
                            Console.ReadKey();
                            goto menu;
                        }
                }
            }
        }
    }
}
