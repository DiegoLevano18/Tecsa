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

        /* CARGA DEL COMPONENTE */
        private void FormVista_ModuloSistema_Load(object sender, EventArgs e)
        {
            dgvModuloSistema.DataSource = negocio_ModuloSistema.Vista_ModuloSistema();

            dgvModuloSistema.Columns[0].Width = 100; // Por ejemplo, la primera columna tiene un ancho de 100
            dgvModuloSistema.Columns[1].Width = 180; // La segunda columna tiene un ancho de 150
        }



        /* BUSCAR */
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


        /* VISUALIZAR */
        private void FormVista_ModuloSistema_Activated(object sender, EventArgs e)
        {
            dgvModuloSistema.DataSource = negocio_ModuloSistema.Vista_ModuloSistema();
        }
        
        /* CREAR */
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormNuevo_ModuloSistema FormNuevo = new FormNuevo_ModuloSistema();
            FormNuevo.ShowDialog();
            // Actualiza el DataGridView después de crear el registro
            dgvModuloSistema.DataSource = negocio_ModuloSistema.Vista_ModuloSistema();
        }

        /* EDITAR */
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvModuloSistema.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = dgvModuloSistema.SelectedRows[0].Index;

                FormNuevo_ModuloSistema FormEditar_ModuloSistema = new FormNuevo_ModuloSistema();
                FormEditar_ModuloSistema.Controls["btnGuardar"].Text = "Actualizar";

                FormEditar_ModuloSistema.Controls["txtId"].Text =
                   dgvModuloSistema.Rows[rowIndex].Cells["Id"].Value.ToString();
                FormEditar_ModuloSistema.Controls["txtNombre"].Text =
                   dgvModuloSistema.Rows[rowIndex].Cells["Nombre"].Value.ToString();

                FormEditar_ModuloSistema.ShowDialog();
                // Actualiza el DataGridView después de editar el registro
                dgvModuloSistema.DataSource = negocio_ModuloSistema.Vista_ModuloSistema();
            }
        
            else
            {
                MessageBox.Show("Por favor, seleccione un registro para editar.", "Error");
            }
        }

        /*ELIMINAR*/
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvModuloSistema.SelectedRows.Count > 0)
            {
                // Preguntar al usuario si está seguro de eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // Obtener el ID del registro seleccionado
                    int id = Convert.ToInt32(dgvModuloSistema.SelectedRows[0].Cells["Id"].Value);

                    // Aquí debes llamar a tu método de eliminación desde la capa de negocio
                    negocio_ModuloSistema.Eliminar_ModuloSistema(id);

                    // Actualiza el DataGridView después de eliminar el registro
                    dgvModuloSistema.DataSource = negocio_ModuloSistema.Vista_ModuloSistema();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un registro para eliminar.", "Error");
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}