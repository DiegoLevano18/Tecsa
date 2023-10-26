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
    public partial class FormVista_RolOperaciones : Form
    {

        Negocio_RolOperaciones negocio_RolOperaciones = new Negocio_RolOperaciones();
        public FormVista_RolOperaciones()
        {
            InitializeComponent();
        }


        /* CARGA DEL COMPONENTE */
        private void FormVista_RolOperaciones_Load(object sender, EventArgs e)
        {
            dgvRolOperaciones.DataSource = negocio_RolOperaciones.Vista_RolOperaciones();

            dgvRolOperaciones.Columns[0].Width = 100; // Por ejemplo, la primera columna tiene un ancho de 100
            dgvRolOperaciones.Columns[1].Width = 180; // La segunda columna tiene un ancho de 150
        }



        /* BUSCAR */
        private void txtBuscar_RolOperaciones_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar_RolOperaciones.Text, out int id))
            {
                dgvRolOperaciones.DataSource = negocio_RolOperaciones.Buscar_RolOperaciones(id);
            }
            else if (string.IsNullOrWhiteSpace(txtBuscar_RolOperaciones.Text))
            {
                dgvRolOperaciones.DataSource = negocio_RolOperaciones.Vista_RolOperaciones();
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("Por favor, ingrese un valor numérico válido.", "Error");

                // Borrar el contenido del TextBox
                txtBuscar_RolOperaciones.Text = string.Empty;
            }
        }


        /* VISUALIZAR */
        private void FormVista_RolOperaciones_Activated(object sender, EventArgs e)
        {
            dgvRolOperaciones.DataSource = negocio_RolOperaciones.Vista_RolOperaciones();
        }

        /* CREAR */
        private void btnNuevo_RolOperaciones_Click(object sender, EventArgs e)
        {
            FormNuevo_RolOperaciones FormNuevo = new FormNuevo_RolOperaciones();
            FormNuevo.ShowDialog();
            // Actualiza el DataGridView después de crear el registro
            dgvRolOperaciones.DataSource = negocio_RolOperaciones.Vista_RolOperaciones();
        }

        /* EDITAR */
        private void btnEditar_RolOperaciones_Click(object sender, EventArgs e)
        {
            if (dgvRolOperaciones.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = dgvRolOperaciones.SelectedRows[0].Index;

                FormNuevo_RolOperaciones FormEditar_RolOperaciones = new FormNuevo_RolOperaciones();
                FormEditar_RolOperaciones.Controls["btnGuardar_RolOperaciones"].Text = "Actualizar";

                FormEditar_RolOperaciones.Controls["txtId_RolOperaciones"].Text =
                   dgvRolOperaciones.Rows[rowIndex].Cells["Id"].Value.ToString();
                FormEditar_RolOperaciones.Controls["txt_IdRol_RolOperaciones"].Text =
                   dgvRolOperaciones.Rows[rowIndex].Cells["IdRol"].Value.ToString();
                FormEditar_RolOperaciones.Controls["txt_IdOperaciones_RolOperaciones"].Text =
                   dgvRolOperaciones.Rows[rowIndex].Cells["IdOperaciones"].Value.ToString();

                FormEditar_RolOperaciones.ShowDialog();
                // Actualiza el DataGridView después de editar el registro
                dgvRolOperaciones.DataSource = negocio_RolOperaciones.Vista_RolOperaciones();
            }

            else
            {
                MessageBox.Show("Por favor, seleccione un registro para editar.", "Error");
            }
        }

        /*ELIMINAR*/
        private void btnEliminar_RolOperaciones_Click(object sender, EventArgs e)
        {
            if (dgvRolOperaciones.SelectedRows.Count > 0)
            {
                // Preguntar al usuario si está seguro de eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // Obtener el ID del registro seleccionado
                    int id = Convert.ToInt32(dgvRolOperaciones.SelectedRows[0].Cells["Id"].Value);

                    // Aquí debes llamar a tu método de eliminación desde la capa de negocio
                    negocio_RolOperaciones.Eliminar_RolOperaciones(id);

                    // Actualiza el DataGridView después de eliminar el registro
                    dgvRolOperaciones.DataSource = negocio_RolOperaciones.Vista_RolOperaciones();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un registro para eliminar.", "Error");
            }
        }

        private void Cerrar_RolOperaciones_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
