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
    public partial class FormNuevo_Operaciones : Form
    {
        public FormNuevo_Operaciones()
        {
            InitializeComponent();
        }

        private void btnGuardar_Operaciones_Click(object sender, EventArgs e)
        {
            Operaciones oOperaciones = new Operaciones();
            Negocio_Operaciones nOperaciones = new Negocio_Operaciones();
            string resultado;



            if (btnGuardar_Operaciones.Text == "Guardar")
            {
                oOperaciones.Nombre = txtNombre_Operaciones.Text;
                oOperaciones.IdModuloSistema = int.Parse(txtIdModuloSistema_Operaciones.Text);
                resultado = nOperaciones.Crear_Operaciones(oOperaciones);
                MessageBox.Show(resultado);
                this.Close();
            }

            else if (btnGuardar_Operaciones.Text == "Actualizar")
            {
                oOperaciones.Id = int.Parse(txtId_Operaciones.Text);
                oOperaciones.Nombre = txtNombre_Operaciones.Text;
                oOperaciones.IdModuloSistema = int.Parse(txtIdModuloSistema_Operaciones.Text);
                resultado = nOperaciones.Actualizar_Operaciones(oOperaciones);
                MessageBox.Show(resultado);
                this.Close();
            }

        }

        private void FormNuevo_Operaciones_Load(object sender, EventArgs e)
        {
            if (btnGuardar_Operaciones.Text == "Actualizar")
            {
                txtId_Operaciones.Enabled = false;
            }
            else
            {
                txtId_Operaciones.Visible = false;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
