using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_CSharp
{
    public class Account
    {
        private decimal saldo;
        public Account(decimal saldo)
        {
            Saldo = saldo;
        }
        #region metodo 1
        //public decimal Saldo { get; set; }// automatic property
        #endregion
        #region metodo 2
        public decimal Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }
        
        #endregion
        #region metodo 3
        public decimal GetSaldo()
        {
            return saldo;
        }
        public void SetSaldo(decimal newSaldo)
        {
            saldo = newSaldo;
        }
        #endregion
    }
    #region test overwriting
    //class Account()
    //    {
    //        saldo = newSaldo;
    //    }
    //    // overloading dei costruttori
    //    public Account()
    //    {
    //        saldo = 0;
    //    }

    //    public void F1(int x, double z) { } // nome func + lista par = firma metodo
    //    // overloading delle funzioni
    //    public void F1(double z, int x) { }
    //}
    #endregion
}
