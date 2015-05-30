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
    public partial class frmPrincipal : Form
    {
        Banco objbanco;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            objbanco = new Banco();
        }

        private void titularesMenuItem_Click(object sender, EventArgs e)
        {
            frmTitulares frmtitulares = new frmTitulares(objbanco);
            frmtitulares.Show(this);            
        }

        private void CuentasMenuItem_Click(object sender, EventArgs e)
        {
            frmCuentas frmcuentas = new frmCuentas(objbanco);
            frmcuentas.Show(this);
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void titulareslistadoMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoTitulares frmlistado = new frmListadoTitulares(objbanco);
            frmlistado.Show(this);
        }

        private void listadocuentasMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoCuentas frmlistado = new frmListadoCuentas(objbanco);
            frmlistado.Show(this);
        }

        private void depositarExtraerMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimientos frmmovimientos = new frmMovimientos(objbanco);
            frmmovimientos.Show(this);
        }



  

       
    }
}
