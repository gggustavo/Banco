using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Banco
{
    public partial class frmCuentas : Form
    {
        Banco objbanco;
        public frmCuentas(Banco banco)
        {
            InitializeComponent();
            objbanco = banco;            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (this.titularBindingSource.Current == null)
            {
                MessageBox.Show("Seleccionar un titular para crear la cuenta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (this.tipocuenta.Text == null)
            {
                MessageBox.Show("Seleccionar un tipo de cuenta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cuenta cuenta;
            if (this.tipocuenta.Text == typeof(CuentaCorriente).Name)
            {
                cuenta = new CuentaCorriente();
            }
            else
            {
                cuenta = new CajaAhorro();
            }

            cuenta.Titular = (Titular)this.titularBindingSource.Current;
            objbanco.CrearCuenta(cuenta);
            MessageBox.Show("La cuenta fue creada correctamente", "Creacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmCuentas_Load(object sender, EventArgs e)
        {
            this.titularBindingSource.DataSource = objbanco.ObtenerTitulares();
        }
    }
}
