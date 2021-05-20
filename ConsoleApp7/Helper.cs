using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Helper
    {
        public static string GetUsername()
        {
            Console.WriteLine("Username:");
            string user = Console.ReadLine();
            return user;
        }
        public static string GetBankName()
        {
            string[] str = new string[] { "Kapital", "Pasa Bank", "YellowBank" };
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Your choice:");
            int s = Convert.ToInt32(Console.ReadLine());
            if (s == 1)
            {
                return str[0];
            }
            else if (s == 2)
            {
                return str[1];
            }
            else
            {
                return str[2];
            }
        }
        public static string GetPin()
        {
            Random random = new Random();
            int value = random.Next(1000, 10000);
            string s = value.ToString();
            return s;
        }
        public static string GetName()
        {
            Console.WriteLine("Input name:");
            string name = Console.ReadLine();
            return name;
        }
        public static string GetSurname()
        {
            Console.WriteLine("Input surname:");
            string surname = Console.ReadLine();
            return surname;
        }
        public static int GetAge()
        {
            Console.WriteLine("Input age");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }
        public static int GetSalary()
        {
            Console.WriteLine("Input salary");
            int salary = Convert.ToInt32(Console.ReadLine());
            return salary;
        }
    }
}
