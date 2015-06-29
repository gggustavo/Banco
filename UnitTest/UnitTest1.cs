using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    using Banco;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CrearTituluar()
        {
            Banco banco = new Banco();
            banco.CrearTitular(new Titular() { Nombre = "Gustavo", Documento = "34245678" });
        }

        [TestMethod]
        public void EliminarTituluar()
        {
            Banco banco = new Banco();
            banco.EliminarTitular(new Titular() { Nombre = "Gustavo", Documento = "34245678" });
        }

        [TestMethod]
        public void BuscarTituluar()
        {
            Banco banco = new Banco();
            banco.CrearTitular(new Titular() { Nombre = "Gustavo", Documento = "34245678" });
            var titular = banco.BuscarTitular("34245678");
            Assert.IsNotNull(titular);
        }

        [TestMethod]
        public void CrearCuentaCorriente()
        {
            Banco banco = new Banco();
            Cuenta cuenta = new CuentaCorriente() { Titular = new Titular() { Nombre = "Gustavo", Documento = "34245678" } };
            banco.CrearCuenta(cuenta);
            Assert.IsInstanceOfType(cuenta, typeof(CuentaCorriente));
            var cuentas = banco.ObtenerCuentas();
            Assert.IsTrue(cuentas[0] != null, "Error al agregar la cuenta");
        }

        [TestMethod]
        public void CrearCajaAhorro()
        {
            Banco banco = new Banco();
            Cuenta cuenta = new CajaAhorro() { Titular = new Titular() { Nombre = "Gustavo", Documento = "34245678" } };
            banco.CrearCuenta(cuenta);
            Assert.IsInstanceOfType(cuenta, typeof(CajaAhorro));
            var cuentas = banco.ObtenerCuentas();
            Assert.IsTrue(cuentas[0] != null, "Error al agregar la cuenta");
        }

        [TestMethod]
        public void BuscarCuentaPorDni()
        {
            Banco banco = new Banco();
            Cuenta cuenta = new CajaAhorro() { Titular = new Titular() { Nombre = "Gustavo", Documento = "34245678" } };
            banco.CrearCuenta(cuenta);
            Assert.IsInstanceOfType(cuenta, typeof(CajaAhorro));
            var cuentadni = banco.BuscarCuentaPorDni("34245678", typeof(CajaAhorro).Name);
            Assert.IsTrue(cuentadni != null, "Error al buscar la cuenta");
        }

        [TestMethod]
        public void CrearMovimiento()
        {
            Banco banco = new Banco();
            Cuenta cuenta = new CajaAhorro() { Titular = new Titular() { Nombre = "Gustavo", Documento = "34245678" } };
            banco.CrearCuenta(cuenta);
            Assert.IsInstanceOfType(cuenta, typeof(CajaAhorro));
            cuenta.Depositar(20);
            banco.CrearMovimiento(new Movimiento() { Cuenta = cuenta, Fecha = DateTime.Now, Importe = 20, TipoMovimiento = "Deposito" });
            var movimiento = banco.ObtenerMovimientos();
            Assert.IsTrue(movimiento[0] != null);
        }

    }
}
