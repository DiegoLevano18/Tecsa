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
    public partial class FormVista_ModuloSistema : Form
    {
        Negocio_ModuloSistema negocio_ModuloSistema = new Negocio_ModuloSistema();
        public FormVista_ModuloSistema()
        {
            InitializeComponent();
        }

        private void FormVista_ModuloSistema_Load(object sender, EventArgs e)
        {
            dgvModuloSistema.DataSource = negocio_ModuloSistema.Vista_ModuloSistema();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar.Text, out int id))
            {
                dgvModuloSistema.DataSource = negocio_ModuloSistema.Buscar_ModuloSistema(id);
            }
            else if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {

                dgvModuloSistema.DataSource = negocio_ModuloSistema.Vista_ModuloSistema();

            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("Por favor, ingrese un valor numérico válido.", "Error");

                // Borrar el contenido del TextBox
                txtBuscar.Text = string.Empty;
            }
        }

        private void dgvModuloSistema_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormNuevo_ModuloSistema FormEditar_ModuloSistema = new FormNuevo_ModuloSistema();
            FormEditar_ModuloSistema.Controls["btnGuardar"].Text = "Actualizar";
            /*FormEditar_ModuloSistema.Controls["txtId"].Text =
           dgvModuloSistema.Rows[e.RowIndex].Cells[0].Value.ToString();*/
            FormEditar_ModuloSistema.Controls["txtNombre"].Text =
           dgvModuloSistema.Rows[e.RowIndex].Cells[1].Value.ToString();
            FormEditar_ModuloSistema.ShowDialog();
        }

        private void FormVista_ModuloSistema_Activated(object sender, EventArgs e)
        {
            dgvModuloSistema.DataSource = negocio_ModuloSistema.Vista_ModuloSistema();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormNuevo_ModuloSistema FormNuevo = new FormNuevo_ModuloSistema();
            FormNuevo.ShowDialog();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            FormNuevo_ModuloSistema FormNuevo = new FormNuevo_ModuloSistema();
            FormNuevo.ShowDialog();
        }
    }
}