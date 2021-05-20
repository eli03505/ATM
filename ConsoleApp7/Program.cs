using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creating Bank");
        Bank bank = new Bank
        {
            BankName = "Kapital"
        };
        Console.WriteLine("Creating Bank Card");
        Bankcard card1 = new Bankcard
        {
            Bankname = Helper.GetBankName(),
            Username = Helper.GetUsername(),
            Pin = Helper.GetPin()
        };
        Console.WriteLine($"Pin:{card1.Pin}");
        Console.WriteLine($"Pan:{card1.Pan}");
        Console.WriteLine("Creating another Bank Card");
        Bankcard card2 = new Bankcard
        {
            Bankname = Helper.GetBankName(),
            Username = Helper.GetUsername(),
            Pin = Helper.GetPin()
        };
        Console.WriteLine($"Pin:{card2.Pin}");
        Console.WriteLine($"Pan:{card2.Pan}");
        Console.WriteLine("Creating client");
        Client client1 = new Client
        {
            Name = Helper.GetName(),
            Surname = Helper.GetSurname(),
            Age = Helper.GetAge(),
            Salary = Helper.GetSalary()
        };
        client1.createBankCard(ref card1);
        client1.createBankCard(ref card2);
        bank.AddClient(ref client1);
        bank.showCard();
        Console.ReadLine();
    }
}

