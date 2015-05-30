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
    public partial class frmMovimientos : Form
    {
        Banco objbanco;

        public frmMovimientos(Banco banco)
        {
            InitializeComponent();
            objbanco = banco;  
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnrocuenta.Text))
            {
                MessageBox.Show("Ingrese el numero de cuenta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnrocuenta.Focus();
                return;
            }

            if (this.tipocuenta.Text == null)
            {
                MessageBox.Show("Seleccionar un tipo de cuenta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cuenta cuenta;
            cuenta = objbanco.BuscarCuentaPorDni(txtnrocuenta.Text, this.tipocuenta.Text);

            if (cuenta != null)
            {
                lblsaldo.Text = cuenta.Saldo.ToString();
            }
            else
            {
                MessageBox.Show("El numero de cuenta ingresado no es valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnrocuenta.Focus();
                return;
            } 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnrocuenta.Text))
            {
                MessageBox.Show("Ingrese el numero de cuenta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnrocuenta.Focus();
                return;
            }
            if (this.tipocuenta.Text == null)
            {
                MessageBox.Show("Seleccionar un tipo de cuenta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cuenta cuenta;
            cuenta = objbanco.BuscarCuentaPorDni(txtnrocuenta.Text, this.tipocuenta.Text);
            if (cuenta != null)
            {
                lblsaldo.Text = cuenta.Saldo.ToString();

                if (rbDepositar.Checked)
                {
                    if (string.IsNullOrEmpty(txtsaldo.Text))
                    {
                        MessageBox.Show("Ingres un saldo a depositar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtsaldo.Focus();
                        return;
                    }
                    cuenta.Depositar(Convert.ToInt32(txtsaldo.Text));
                    MessageBox.Show("Se realizo el deposito correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (rbExtraer.Checked)
                {
                    if (string.IsNullOrEmpty(txtsaldo.Text))
                    {
                        MessageBox.Show("Ingres un saldo a extraer", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtsaldo.Focus();
                        return;
                    }
                    cuenta.Extraer(Convert.ToInt32(txtsaldo.Text));
                    MessageBox.Show("Se realizo la extraccion correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                lblsaldo.Text = cuenta.Saldo.ToString();
            }
            else
            {
                MessageBox.Show("El numero de cuenta ingresado no es valido", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnrocuenta.Focus();
                return;
            }
            this.Close();
        }

    }
}
