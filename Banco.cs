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

        public Banco()
        { 
            //Constructor de la clase Banco
            //Inicializacion de los catalogos titular y cuenta.
            ltitular = new List<Titular>();
            lcuentas = new List<Cuenta>();
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
    
    }
}
