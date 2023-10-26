using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormNuevo_Rol : Form
    {
        public FormNuevo_Rol()
        {
            InitializeComponent();
        }

        private void btnGuardar_Rol_Click(object sender, EventArgs e)
        {
            Rol oRol = new Rol();
            Negocio_Rol nRol = new Negocio_Rol();
            string resultado;



            if (btnGuardar_Rol.Text == "Guardar")
            {
                oRol.Nombre = txtNombre_Rol.Text;
                resultado = nRol.Crear_Rol(oRol);
                MessageBox.Show(resultado);
                this.Close();
            }

            else if (btnGuardar_Rol.Text == "Actualizar")
            {
                oRol.Id = int.Parse(txtId_Rol.Text);
                oRol.Nombre = txtNombre_Rol.Text;
                resultado = nRol.Actualizar_Rol(oRol);
                MessageBox.Show(resultado);
                this.Close();
            }

        }

        private void FormNuevo_Rol_Load(object sender, EventArgs e)
        {
            if (btnGuardar_Rol.Text == "Actualizar")
            {
                txtId_Rol.Enabled = false;
            }
            else
            {
                txtId_Rol.Visible = false;
            }
        }
    }
}
