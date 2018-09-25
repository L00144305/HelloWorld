using System;

namespace LapPractical1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num;
            int numval;
            Console.Write("Enter a number : ");
            num = Console.ReadLine();
            numval = Convert.ToInt32(num);
            Console.WriteLine("*************************************");
            Console.WriteLine("|  The number you entered was : " + num + "  |");
            Console.WriteLine("*************************************");
            Console.ReadKey();
        }
    }
}
