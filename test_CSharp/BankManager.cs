using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_CSharp
{
    public class BankManager
    {
        public static void HandleBank()
        {
            Account a1 = new Account(100);
            Account a2 = new Account(200);
            Account a3 = new Account(300);
            Account a4 = new Account(400);
            Account a5 = new Account(500);
            Account a6 = new Account(600);
            Client c1 = new Client("Mario", "Rossi", "abcd123", new DateTime(1990, 1, 1));
            Client c2 = new Client("Gino", "Carlo", "dcfd123", new DateTime(1980, 2, 1));

            c1.AddAccount(a1);
            c1.AddAccount(a2);
            c1.AddAccount(a3);
            c1.AddAccount(a4);
            c1.AddAccount(a5);

            c1.PrintReport();
            Console.WriteLine("***");
            c1.RemoveAccount(4);
            c1.PrintReport();
            Console.ReadKey();
        }
    }
}
