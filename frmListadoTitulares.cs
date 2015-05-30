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
    public partial class frmListadoTitulares : Form
    {
        Banco objbanco;
        public frmListadoTitulares(Banco banco)
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
            dgTitulares.DataSource = objbanco.ObtenerTitulares();            
        }

       
    }
}
