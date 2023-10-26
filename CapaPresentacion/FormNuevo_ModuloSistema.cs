using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormNuevo_ModuloSistema : Form
    {
        public FormNuevo_ModuloSistema()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ModuloSistema oModuloSistema = new ModuloSistema();
            Negocio_ModuloSistema nModuloSistema = new Negocio_ModuloSistema();
            string resultado;

            

            if (btnGuardar.Text == "Guardar")
            {
                oModuloSistema.Nombre = txtNombre.Text;
                resultado = nModuloSistema.Crear_ModuloSistema(oModuloSistema);
                MessageBox.Show(resultado);
                this.Close();
            }

            else if (btnGuardar.Text == "Actualizar")
            {
                oModuloSistema.Id = int.Parse(txtId.Text);
                oModuloSistema.Nombre = txtNombre.Text;
                resultado = nModuloSistema.Actualizar_ModuloSistema(oModuloSistema);
                MessageBox.Show(resultado);
                this.Close();
            }

        }

        private void FormNuevo_ModuloSistema_Load(object sender, EventArgs e)
        {
            if (btnGuardar.Text == "Actualizar")
            {
                txtId.Enabled = false;
            }
            else
            {
                txtId.Visible = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
