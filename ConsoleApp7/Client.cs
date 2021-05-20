using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public static int Client_Id { get; set; } = 0;
        public Bankcard[] Bankcards { get; set; }
        public int Bankcard_Count { get; set; }
        public void createBankCard(ref Bankcard bankcard)
        {
            Bankcard[] temp = new Bankcard[++Bankcard_Count];
            if (Bankcards != null)
            {
                Bankcards.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = bankcard;
            Bankcards = temp;
        }
        public Client()
        {
            Id = ++Client_Id;
        }
        public void Show()
        {
            Console.WriteLine("ID:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname:{Surname}");
            Console.WriteLine($"Age:{Age}");
            Console.WriteLine($"Salary:{Salary}");
        }

    }
}
