using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//msdn C# Reference

//gargabe collector = distugge gli oggetti in eccesso nell'heap e nello stack
namespace test_CSharp
{
    #region test chiamate di classe
    class HelloWorld
    {
        public static void Go()
        {
            Hello();
            Console.ReadKey();
        }
        static void Hello()
        {
            Console.WriteLine("Hello World");
        }
    }
    #endregion


    class Program
    {
        static void F1()
        {
            bool magro = false;
            Console.WriteLine(magro);
        }
        static void Main(string[] args)
        {
            BankManager bm1 = new BankManager(10000);

            Account a1 = new Account(bm1.InitialBalance);
            Account a2 = new Account(bm1.InitialBalance);
            Account a3 = new Account(bm1.InitialBalance);
            Account a4 = new Account(bm1.InitialBalance);
            Account a5 = new Account(bm1.InitialBalance);
            Account a6 = new Account(bm1.InitialBalance);
            Client c1 = new Client("Mario", "Rossi", "abcd123", new DateTime(1990, 1, 1));
            Client c2 = new Client("Gino", "Carlo", "dcfd123", new DateTime(1980, 2, 1));

            c1.AddAccount(a1);
            c1.AddAccount(a2);
            c1.AddAccount(a3);
            c1.AddAccount(a4);
            c1.AddAccount(a5);
            c2.AddAccount(a6);

            bm1.AddClient(c1);
            bm1.AddClient(c2);
            bm1.report();

            Console.ReadKey();



            //int x = 3;
            //// l'oggetto viene creato nella memoria heap(mucchio)
            //// mentre y (il puntatore) e' salvato all'interno di main come stack
            //F1();

            //#region for and if
            //int[] nums = { 2, 4, 6, 3, 2, 4, 5, 6, 2, 5 };
            ////for (int i = 1; i <= 100; i++)
            ////{
            ////    if (((i % 3) == 0) && ((i % 5) == 0))
            ////    {
            ////        Console.WriteLine("fizzbuzz");

            ////    }
            ////    else if ((i % 3) == 0)
            ////    {
            ////        Console.WriteLine("fizz");
            ////    }
            ////    else if ((i % 5) == 0)
            ////    {
            ////        Console.WriteLine("buzz");
            ////    }
            ////    else
            ////    {
            ////        Console.WriteLine(i);
            ////    }
            ////}
            //#endregion

            //// test chiamate oltreclasse
            //HelloWorld.Go();

            //#region test funzioni chiamata
            //int primo = 1, secondo = 11;
            //Console.WriteLine(Swap(ref primo, ref secondo, out int sum));
            //Console.WriteLine(primo + " " + secondo);
            //Console.WriteLine(sum);
            //#endregion

            //Console.ReadKey();
        }
        static bool Swap(ref int a, ref int b, out int sum)
        {
            int z;
            z = a;
            a = b;
            b = z;
            sum = a + b;
            return a + b > 10 ? true : false;
        }
    }
}
