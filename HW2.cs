using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            string modetp;
            double inputx, inputy, time, price;
            modetp = Console.ReadLine();
            inputx = double.Parse(Console.ReadLine());
            inputy = double.Parse(Console.ReadLine());
   
            if (modetp == "time" || modetp == "price")
            {
                if (inputx >= 0)
                {
                    if (modetp == "time")
                    {
                        
                        price = Math.Pow((inputx - 1), 2);
                        Console.WriteLine("{0}, {1}", inputx, price);
                    }
                    else if (modetp == "price")
                    {
                        time = Math.Sqrt(inputy) + 1;
                        Console.WriteLine("{0}, {1}", time, inputy);
                    }
                    else
                    {
                        Console.WriteLine("Invalid mouse position");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid mouse position");
                }
            }
            else
            {
                Console.WriteLine("Invalid mode");
            }
            Console.ReadLine();
        }
    }
}
