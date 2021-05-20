using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Bank
    {
        public string BankName { get; set; }
        public Client[] Clients { get; set; }
        public int Client_Count { get; set; } = 0;
        public void AddClient(ref Client client)
        {
            Client[] temp = new Client[++Client_Count];
            if (Clients != null)
            {
                Clients.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = client;
            Clients = temp;
        }
        public void showCard()
        {
            Console.WriteLine("Input Pan");
            StringBuilder pan = new StringBuilder();
            string value = Console.ReadLine();
            pan.Append(value);
            Console.WriteLine("Input Pin");
            string pin = Console.ReadLine();
            for (int i = 0; i < Client_Count; i++)
            {
                for (int k = 0; k < Clients[i].Bankcard_Count; k++)
                {
                    Console.WriteLine($"Pan:{Clients[i].Bankcards[k].Pan}");
                    Console.WriteLine("Pan" + pan);
                    if (pan.ToString() == Clients[i].Bankcards[k].Pan.ToString() &&
                        pin == Clients[i].Bankcards[k].Pin)
                    {
                        if (BankName == Clients[i].Bankcards[k].Bankname)
                        {
                            Clients[i].Bankcards[k].ShowBankCard();
                        }
                        else
                        {
                            Console.WriteLine("There is no card here");
                        }
                    }
                }
            }
        }
    }
}
