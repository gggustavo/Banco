using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public abstract class Cuenta
    {
        private Titular titular;
        protected decimal saldo;
        

        public Titular Titular
        {
            get
            {
                return titular;
            }
            set
            {
                titular = value;
            }
        }

        public decimal Saldo
        {
            get
            {
                return saldo;
            }

        }

        public abstract void Extraer(decimal Monto);

        public void Depositar(decimal Monto)
        {
            saldo += Monto;
        }
    }
}
