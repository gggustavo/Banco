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
    public partial class frmListadoMovimientos : Form
    {
        Banco objbanco;
        public frmListadoMovimientos(Banco banco)
        {
            InitializeComponent();
            objbanco = banco;
        }

        protected override void OnLoad(EventArgs e)
        {
            this.CargaListado();
            base.OnLoad(e);
        }

        private void CargaListado()
        {
            dgMovimientos.DataSource = objbanco.ObtenerMovimientos().Select(m => new { Fecha = m.Fecha, Importe = m.Importe, TipoMovimiento = m.TipoMovimiento, Titular = m.Cuenta.Titular.Nombre  }).ToList();
        }
    }
}
