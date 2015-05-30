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
    public partial class frmListadoCuentas : Form
    {
        Banco objbanco;
        public frmListadoCuentas(Banco banco)
        {
            InitializeComponent();
            objbanco = banco;
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            this.CargaListado();
        }

        private void CargaListado()
        {
            dgCajaAhorro.DataSource = objbanco.ObtenerCuentas().ToList().Select(x => new { Documento = x.Titular.Documento, Nombre = x.Titular.Nombre, TipoCuenta = x.GetType().Name}).ToList();
        }
               
    }
}
