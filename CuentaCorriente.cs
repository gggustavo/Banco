using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public class CuentaCorriente : Cuenta
    {
        public override void Extraer(decimal Monto)
        {
            saldo -= Monto;
        }
    }
}
