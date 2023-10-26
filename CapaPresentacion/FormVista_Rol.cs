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
    public partial class FormVista_Rol : Form
    {
        Negocio_Rol negocio_Rol = new Negocio_Rol();

        public FormVista_Rol()
        {
            InitializeComponent();
        }



        /* CARGA DEL COMPONENTE */
        private void FormVista_Rol_Load(object sender, EventArgs e)
        {
            dgvRol.DataSource = negocio_Rol.Vista_Rol();

            dgvRol.Columns[0].Width = 100; // Por ejemplo, la primera columna tiene un ancho de 100
            dgvRol.Columns[1].Width = 180; // La segunda columna tiene un ancho de 150
        }



        /* BUSCAR */
        private void txtBuscar_Rol_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar_Rol.Text, out int id))
            {
                dgvRol.DataSource = negocio_Rol.Buscar_Rol(id);
            }
            else if (string.IsNullOrWhiteSpace(txtBuscar_Rol.Text))
            {
                dgvRol.DataSource = negocio_Rol.Vista_Rol();
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("Por favor, ingrese un valor numérico válido.", "Error");

                // Borrar el contenido del TextBox
                txtBuscar_Rol.Text = string.Empty;
            }
        }


        /* VISUALIZAR */
        private void FormVista_Rol_Activated(object sender, EventArgs e)
        {
            dgvRol.DataSource = negocio_Rol.Vista_Rol();
        }

        /* CREAR */
        private void btnNuevo_Rol_Click(object sender, EventArgs e)
        {
            FormNuevo_Rol FormNuevo = new FormNuevo_Rol();
            FormNuevo.ShowDialog();
            // Actualiza el DataGridView después de crear el registro
            dgvRol.DataSource = negocio_Rol.Vista_Rol();
        }

        /* EDITAR */
        private void btnEditar_Rol_Click(object sender, EventArgs e)
        {
            if (dgvRol.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = dgvRol.SelectedRows[0].Index;

                FormNuevo_Rol FormEditar_Rol = new FormNuevo_Rol();
                FormEditar_Rol.Controls["btnGuardar_Rol"].Text = "Actualizar";

                FormEditar_Rol.Controls["txtId_Rol"].Text =
                   dgvRol.Rows[rowIndex].Cells["Id"].Value.ToString();
                FormEditar_Rol.Controls["txtNombre_Rol"].Text =
                   dgvRol.Rows[rowIndex].Cells["Nombre"].Value.ToString();

                FormEditar_Rol.ShowDialog();
                // Actualiza el DataGridView después de editar el registro
                dgvRol.DataSource = negocio_Rol.Vista_Rol();
            }

            else
            {
                MessageBox.Show("Por favor, seleccione un registro para editar.", "Error");
            }
        }

        /*ELIMINAR*/
        private void btnEliminar_Rol_Click(object sender, EventArgs e)
        {
            if (dgvRol.SelectedRows.Count > 0)
            {
                // Preguntar al usuario si está seguro de eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // Obtener el ID del registro seleccionado
                    int id = Convert.ToInt32(dgvRol.SelectedRows[0].Cells["Id"].Value);

                    // Aquí debes llamar a tu método de eliminación desde la capa de negocio
                    negocio_Rol.Eliminar_Rol(id);

                    // Actualiza el DataGridView después de eliminar el registro
                    dgvRol.DataSource = negocio_Rol.Vista_Rol();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un registro para eliminar.", "Error");
            }
        }

        private void Cerrar_Rol_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
