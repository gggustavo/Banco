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
    public partial class frmTitulares : Form
    {
        Banco objbanco;
        public frmTitulares(Banco banco)
        {
            InitializeComponent();
            objbanco = banco;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                MessageBox.Show("Ingrese un documento");
                txtDocumento.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre");
                txtNombre.Focus();
                return;
            }

            Titular objtitular = new Titular();
            objtitular.Documento = txtDocumento.Text;
            objtitular.Nombre = txtNombre.Text;

            objbanco.CrearTitular(objtitular);

            MessageBox.Show("El titular fue creado correctamente","Creacion", MessageBoxButtons.OK, MessageBoxIcon.Information);;
            this.Close();
        }
    }
}
