using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_CSharp
{
    public class BankManager
    {
        public decimal InitialBalance { get; set; }
        public static decimal MaxBalance { get; set; }
        public static int NumManager { get; set; }
        private Client[] clients;
        public int NumClients { get; set; }
        public BankManager(decimal initialBalance)
        {
            InitialBalance = initialBalance;
            BankManager.NumManager++;
            clients = new Client[3];
        }
        public bool AddClient(Client c)
        {
            if (NumClients >= clients.Length)
            {
                return false;
            }
            clients[NumClients] = c;
            NumClients++;
            return true;
        }
        public void report()
        {
            for (int i = 0; i < clients.Length; i++)
                if (clients[i] != null)
                {
                    Console.Write("nome: " + clients[i].Name);
                    Console.Write(" Cognome: " + clients[i].Lastname);
                    Console.Write(" totale account: " + clients[i].TotalBalance());
                    Console.WriteLine();

                }
            
            {

            }
        }
        public static void F()
        {
            //Console.WriteLine(InitialBalance);
        }
        public void HandleBank()
        {
            double x = Math.Sin(100);
            double p = Math.PI;
            Account a1 = new Account(this.InitialBalance);
            Account a2 = new Account(InitialBalance);
            Account a3 = new Account(InitialBalance);
            Account a4 = new Account(InitialBalance);
            Account a5 = new Account(InitialBalance);
            Account a6 = new Account(InitialBalance);
            Client c1 = new Client("Mario", "Rossi", "abcd123", new DateTime(1990, 1, 1));
            Client c2 = new Client("Gino", "Carlo", "dcfd123", new DateTime(1980, 2, 1));

            c1.AddAccount(a1);
            c1.AddAccount(a2);
            c1.AddAccount(a3);
            c1.AddAccount(a4);
            c1.AddAccount(a5);

            c1.PrintReport();
            Console.WriteLine("***");
            c1.RemoveAccount(3);
            c1.PrintReport();
            Console.ReadKey();
        }

    }
}
