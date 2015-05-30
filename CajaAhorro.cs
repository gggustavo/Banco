using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public class CajaAhorro : Cuenta
    {

        public override void Extraer(decimal Monto)
        {
            if (Monto > saldo)
            {
                throw new Exception("No dispone de saldo");
            }
            else
            {
                saldo -= Monto;
            }
        }
    }
}
