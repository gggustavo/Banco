using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public class Movimiento
    {
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private Cuenta cuenta;

        public Cuenta Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        private decimal importe;

        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }
        private string tipoMov;

        public string TipoMovimiento
        {
            get { return tipoMov; }
            set { tipoMov = value; }
        }

    }
}