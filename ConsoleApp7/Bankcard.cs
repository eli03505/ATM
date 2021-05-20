using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Bankcard
    {
        public string Bankname { get; set; }
        public string Username { get; set; }
        public StringBuilder Pan { get; set; } = CreatePan();
        public string Pin { get; set; }
        public string Cvc { get; set; } = CreatePin();
        public DateTime Cantune { get; set; } = CreateExpired();
        public double Balance { get; set; } = CreateBalance();
        public static StringBuilder CreatePan()
        {
            Random random = new Random();
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                int value = random.Next(1000, 10000);
                str.Append(string.Concat(value));
            }
            return str;
        }
        private static string CreatePin()
        {
            Random random = new Random();
            int value = random.Next(100, 1000);
            string str = value.ToString();
            return str;
        }
        public static DateTime CreateExpired()
        {
            DateTime exp = DateTime.Now.AddYears(2);
            return exp;
        }
        public static double CreateBalance()
        {
            Random random = new Random();
            double value = (random.NextDouble() * (9999.99 - 0.99) + 0.99);
            double b = Math.Round(value, 2, MidpointRounding.ToEven);
            return b;
        }
        public void ShowBankCard()
        {
            Console.WriteLine($"Bank Name:{Bankname}");
            Console.WriteLine($"Username:{Username}");
            Console.WriteLine($"Pan:{ Pan}");
            Console.WriteLine($"Pin:{Pin}");
            Console.WriteLine($"CVC:{Cvc}");
            Console.WriteLine($"Cantune:{Cantune}");
            Console.WriteLine($"Balance:{Balance}");
        }
    }
}
