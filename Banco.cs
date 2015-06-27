using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banco
{
    public class Banco
    {
        List<Titular> ltitular;
        private List<Cuenta> lcuentas;
        private List<Movimiento> lmovimientos;

        public Banco()
        {
            //Constructor de la clase Banco
            //Inicializacion de los catalogos titular / cuenta y movimientos
            ltitular = new List<Titular>();
            lcuentas = new List<Cuenta>();
            lmovimientos = new List<Movimiento>();
        }

        //Metodos necesarios para crear, eliminar y buscar un titular///
        public void CrearTitular(Titular titular)
        {
            ltitular.Add(titular);
        }

        public void EliminarTitular(Titular titular)
        {
            ltitular.Remove(titular);
        }

        public Titular BuscarTitular(string documento)
        {
            return ltitular.Find(t => t.Documento == documento);
        }

        public List<Titular> ObtenerTitulares()
        {
            return ltitular;
        }

        //Metodos necesarios para crear, eliminar una cuenta///
        public void CrearCuenta(Cuenta cuenta)
        {
            lcuentas.Add(cuenta);
        }

        public void EliminarCuenta(Cuenta cuenta)
        {
            lcuentas.Remove(cuenta);
        }

        public List<Cuenta> ObtenerCuentas()
        {
            return lcuentas;
        }

        public Cuenta BuscarCuentaPorDni(string dni, string tipocuenta)
        {
            return lcuentas.Where(c => c.Titular.Documento == dni && c.GetType().Name == tipocuenta).FirstOrDefault();
        }

        //Metodos necesarios para crear un movimientos y listarlos
        public void CrearMovimiento(Movimiento movimiento)
        {
            lmovimientos.Add(movimiento);
        }

        public List<Movimiento> ObtenerMovimientos()
        {
            return lmovimientos.ToList();
        }
    
    }
}
