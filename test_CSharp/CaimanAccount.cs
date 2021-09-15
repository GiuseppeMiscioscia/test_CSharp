using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_CSharp
{
    public class CaimanAccount : Account
    {
        public string SecretCode { get; private set; }
        public decimal Perc { get; private set; }

        public CaimanAccount() : base(0)
        { 
            
        }

        public CaimanAccount(decimal initialSaldo, string secretCode) : base(initialSaldo) 
        {
            SecretCode = secretCode;
            //saldo = initialSaldo;

        }

        public CaimanAccount(decimal initialSaldo, string secretCode, decimal perc) : base(initialSaldo)
        {
            SecretCode = secretCode;
            Perc = perc;
        }

        public decimal Deposit(decimal inputValue) //override virtual
        {
            saldo += inputValue + (inputValue * Perc) / 100;
            return saldo;
        }

    }
}
