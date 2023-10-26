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
    public partial class Inicio : Form
    {   

        public Inicio()
        {
            InitializeComponent();

            /*Se ocultan los sub menus*/
            ocultarSubMenu();
        }

        #region Ocultar Sub Menú

        private void ocultarSubMenu()
        {   
            /*Se incocan a todos los paneles que hacen de submenus y se los oculta*/
            panelPersonal.Visible = false;
            panelGestionVentas.Visible = false;
            panelGestionRoles.Visible = false;
            panelInfracciones.Visible = false;
        }

        #endregion

        #region Mostrar Sub Menú
        /*Le pasa un panel como argumento y se instancia como "submenu" dentro de la función*/
        private void mostrarSubMenu(Panel subMenu)
        {   
            /*Comprueba si el submenu esta oculto si lo esta (oculta todos los menus *confirmación*) y  abre el submenú*/
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            /*Si esta abierto lo cierra*/
            else
                subMenu.Visible = false;
        }
        #endregion

        #region Invocar Sub Menus con botones
        /*Invocamos mostrar submenú desde el boton que corresponde o querramos abrir el submenu*/

        private void btnPersonal_Click(object sender, EventArgs e)
        {   
            /*Mostramos el submenú perfil al hacer clic en el boton perfil*/
            mostrarSubMenu(panelPersonal);
        }

        private void btnGestionVentas_Click(object sender, EventArgs e)
        {
            /*Mostramos el submenú perfil al hacer clic en el boton perfil*/
            mostrarSubMenu(panelGestionVentas);
        }

        private void btnGestionRoles_Click(object sender, EventArgs e)
        {
            /*Mostramos el submenú perfil al hacer clic en el boton perfil*/
            mostrarSubMenu(panelGestionRoles);
        }

        private void btnInfracciones_Click(object sender, EventArgs e)
        {
            /*Mostramos el submenú perfil al hacer clic en el boton perfil*/
            mostrarSubMenu(panelInfracciones);
        }
        #endregion

        #region Abrir Formularios en el Panel Principal
        /*Se inicializa la instancia de Form en nulo*/
        private Form formActivo = null;

        /*La funcion recibe un dato de tipo Formulario y la renombra como hijoForm para su uso dentro de la funcion*/
        private void abrirHijosEnPanel(Form hijoForm)
        {   
            //Comprueba si hay Formularios Abiertos
            if (formActivo != null)
                //Si los hay los cierra
                formActivo.Close();

            //Cada que se use esta Funcion se guardara los datos en formActivo
            formActivo = hijoForm;

            // Configura el formulario hijo para que no tenga bordes y se ajuste al tamaño del panel
            hijoForm.TopLevel = false;
            hijoForm.FormBorderStyle = FormBorderStyle.None;
            hijoForm.Dock = DockStyle.Fill;

            // Añade el formulario hijo al panel y muéstralo
            panelHijoForm.Controls.Add(hijoForm);
            hijoForm.Show();
        }
        #endregion

        #region Invocar Formularios dentro del Panel
        private void btnModuloSistema_Click(object sender, EventArgs e)
        {
            abrirHijosEnPanel(new FormVista_ModuloSistema());

            ocultarSubMenu();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            abrirHijosEnPanel(new FormVista_Operaciones());

            ocultarSubMenu();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            abrirHijosEnPanel(new FormVista_Rol());

            ocultarSubMenu();
        }

        private void btnRolOperaciones_Click(object sender, EventArgs e)
        {
            abrirHijosEnPanel(new FormVista_RolOperaciones());

            ocultarSubMenu();
        }
        #endregion










        private void btnMinVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxVentana_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized; // Maximiza la ventana
            }
            else
            {
                this.WindowState = FormWindowState.Normal; // Restaura la ventana al tamaño normal
            }
        }

        private void bntCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void panelSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panelSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

    }
}
