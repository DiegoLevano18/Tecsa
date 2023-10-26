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
    public partial class FormNuevo_RolOperaciones : Form
    {
        public FormNuevo_RolOperaciones()
        {
            InitializeComponent();
        }
        private void btnGuardar_RolOperaciones_Click(object sender, EventArgs e)
        {
            RolOperaciones oRolOperaciones = new RolOperaciones();
            Negocio_RolOperaciones nRolOperaciones = new Negocio_RolOperaciones();
            string resultado;



            if (btnGuardar_RolOperaciones.Text == "Guardar")
            {
                oRolOperaciones.IdRol = int.Parse(txt_IdRol_RolOperaciones.Text);
                oRolOperaciones.IdOperaciones = int.Parse(txt_IdOperaciones_RolOperaciones.Text);
                resultado = nRolOperaciones.Crear_RolOperaciones(oRolOperaciones);
                MessageBox.Show(resultado);
                this.Close();
            }

            else if (btnGuardar_RolOperaciones.Text == "Actualizar")
            {
                oRolOperaciones.Id = int.Parse(txtId_RolOperaciones.Text); 
                oRolOperaciones.IdRol = int.Parse(txt_IdRol_RolOperaciones.Text);
                oRolOperaciones.IdOperaciones = int.Parse(txt_IdOperaciones_RolOperaciones.Text);
                resultado = nRolOperaciones.Actualizar_RolOperaciones(oRolOperaciones);
                MessageBox.Show(resultado);
                this.Close();
            }

        }

        private void FormNuevo_RolOperaciones_Load(object sender, EventArgs e)
        {
            if (btnGuardar_RolOperaciones.Text == "Actualizar")
            {
                txtId_RolOperaciones.Enabled = false;
            }
            else
            {
                txtId_RolOperaciones.Visible = false;
            }
        }

        private void Lbl_Id_Click(object sender, EventArgs e)
        {

        }
    }
}
