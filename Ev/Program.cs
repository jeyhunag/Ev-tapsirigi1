using System;

namespace sual_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            int sum;
            Console.Write("Birinci ededinizi daxil edin: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ikinci  ededinizi daxil edin: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            sum = number1 + number2;
            Console.WriteLine("Toplam:" + sum);
        }
    }
}
