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
    public partial class FormVista_Operaciones : Form
    {
        Negocio_Operaciones negocio_Operaciones = new Negocio_Operaciones();

        public FormVista_Operaciones()
        {
            InitializeComponent();
        }

        

        /* CARGA DEL COMPONENTE */
        private void FormVista_Operaciones_Load(object sender, EventArgs e)
        {
            dgvOperaciones.DataSource = negocio_Operaciones.Vista_Operaciones();

            dgvOperaciones.Columns[0].Width = 100; // Por ejemplo, la primera columna tiene un ancho de 100
            dgvOperaciones.Columns[1].Width = 180; // La segunda columna tiene un ancho de 150
        }



        /* BUSCAR */
        private void txtBuscar_Operaciones_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBuscar_Operaciones.Text, out int id))
            {
                dgvOperaciones.DataSource = negocio_Operaciones.Buscar_Operaciones(id);
            }
            else if (string.IsNullOrWhiteSpace(txtBuscar_Operaciones.Text))
            {
                dgvOperaciones.DataSource = negocio_Operaciones.Vista_Operaciones();
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("Por favor, ingrese un valor numérico válido.", "Error");

                // Borrar el contenido del TextBox
                txtBuscar_Operaciones.Text = string.Empty;
            }
        }


        /* VISUALIZAR */
        private void FormVista_Operaciones_Activated(object sender, EventArgs e)
        {
            dgvOperaciones.DataSource = negocio_Operaciones.Vista_Operaciones();
        }

        /* CREAR */
        private void btnNuevo_Operaciones_Click(object sender, EventArgs e)
        {
            FormNuevo_Operaciones FormNuevo = new FormNuevo_Operaciones();
            FormNuevo.ShowDialog();
            // Actualiza el DataGridView después de crear el registro
            dgvOperaciones.DataSource = negocio_Operaciones.Vista_Operaciones();
        }

        /* EDITAR */
        private void btnEditar_Operaciones_Click(object sender, EventArgs e)
        {
            if (dgvOperaciones.SelectedRows.Count > 0)
            {
                // Obtener el índice de la fila seleccionada
                int rowIndex = dgvOperaciones.SelectedRows[0].Index;

                FormNuevo_Operaciones FormEditar_Operaciones = new FormNuevo_Operaciones();
                FormEditar_Operaciones.Controls["btnGuardar_Operaciones"].Text = "Actualizar";

                FormEditar_Operaciones.Controls["txtId_Operaciones"].Text =
                   dgvOperaciones.Rows[rowIndex].Cells["Id"].Value.ToString();
                FormEditar_Operaciones.Controls["txtNombre_Operaciones"].Text =
                   dgvOperaciones.Rows[rowIndex].Cells["Nombre"].Value.ToString();
                FormEditar_Operaciones.Controls["txtIdModuloSistema_Operaciones"].Text =
                   dgvOperaciones.Rows[rowIndex].Cells["IdModuloSistema"].Value.ToString();

                FormEditar_Operaciones.ShowDialog();
                // Actualiza el DataGridView después de editar el registro
                dgvOperaciones.DataSource = negocio_Operaciones.Vista_Operaciones();
            }

            else
            {
                MessageBox.Show("Por favor, seleccione un registro para editar.", "Error");
            }
        }

        /*ELIMINAR*/
        private void btnEliminar_Operaciones_Click(object sender, EventArgs e)
        {
            if (dgvOperaciones.SelectedRows.Count > 0)
            {
                // Preguntar al usuario si está seguro de eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // Obtener el ID del registro seleccionado
                    int id = Convert.ToInt32(dgvOperaciones.SelectedRows[0].Cells["Id"].Value);

                    // Aquí debes llamar a tu método de eliminación desde la capa de negocio
                    negocio_Operaciones.Eliminar_Operaciones(id);

                    // Actualiza el DataGridView después de eliminar el registro
                    dgvOperaciones.DataSource = negocio_Operaciones.Vista_Operaciones();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un registro para eliminar.", "Error");
            }
        }

        private void Cerrar_Operaciones_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
