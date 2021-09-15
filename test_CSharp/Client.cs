using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//msdn C# Reference

//gargabe collector = distugge gli oggetti in eccesso nell'heap e nello stack
namespace test_CSharp
{
    public class Client
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Ssn { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int NumberOfAccounts { get; private set; }

        public Account[] Accounts { get; set; }

        public Client(string name, string lastname, string ssn, DateTime dateOfBirth)
        {
            Name = name;
            Lastname = lastname;
            Ssn = ssn;
            DateOfBirth = dateOfBirth;
            Accounts = new Account[5];
        }
        public int BadAddAccount(Account a)
        {
            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i] == null)
                {
                    Accounts[i] = a;
                    NumberOfAccounts++;
                    return NumberOfAccounts;
                }
            }
            return -1;

        }
        public int AddAccount(Account a)
        {
            if (NumberOfAccounts >= Accounts.Length)
            {
                return -1;
            }
            Accounts[NumberOfAccounts] = a;
            NumberOfAccounts++;
            return NumberOfAccounts;
        }
        public Account BadRemoveAccount(int pos)
        {
            Account r = Accounts[pos];
            Accounts[pos] = null;
            NumberOfAccounts--;
            for (int i = pos; i < Accounts.Length - 1; i++)
            {
                if (Accounts[i + 1] != null)
                {
                    Accounts[i] = Accounts[i + 1];
                }
                else
                {
                    Accounts[i] = null;
                }
            }
            if (NumberOfAccounts == 4)
            {
                Accounts[NumberOfAccounts] = null;
            }
            return r;
        }
        public Account RemoveAccount(int pos)
        {
            if (pos < 0 || pos > Accounts.Length - 1 || NumberOfAccounts <= 0)
            {
                return null;
            }
            Account r = Accounts[pos];
            //if (pos == Accounts.Length - 1)
            //{
            //    Accounts[pos] = null;
            //    NumberOfAccounts--;
            //    return r;
            //}
            for (int i = pos; i < NumberOfAccounts - 1; i++)
            {
                Accounts[i] = Accounts[i + 1];
            }
            NumberOfAccounts--;
            Accounts[NumberOfAccounts] = null;
            return r;
        }
        public void PrintReport()
        {
            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i] != null)
                {
                    Console.WriteLine("pos: " + i + " saldo: " + Accounts[i].Saldo);
                }
                else
                {
                    Console.WriteLine("pos: " + i + " posizione disponibile");
                }
            }
        }
        public decimal TotalBalance()
        {
            var total = 0.0m;
            foreach (var acc in Accounts)
            {
                if (acc != null)
                {
                    total += acc.Saldo;
                }
            }
            return total;
        }
    }
}
