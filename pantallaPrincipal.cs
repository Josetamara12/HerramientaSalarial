using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace proyectoGrafico_trabajoFinal
{
    public partial class pantallaPrincipal : Form
    {
        public pantallaPrincipal()
        {
            InitializeComponent();
        }
        // desplazamiento de la pagina por toda la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnEmpleados_Click(object sender, EventArgs e)
        {//  dentro del boton empleados 
            // instancio el formulario de empleados para abrirlo 
            Form Formulario_Empleados = new FormEmpleados();
            // y lo muestro por pantalla
            Formulario_Empleados.Show();

        }

        private void btnSalarios_Click(object sender, EventArgs e)
        {
            //Igualmente instancio el formulario salarios 
            // dentro del boton salarios para abrirlo
            Form Formulario_Salarios = new FormSalarios();
            // y lo muestro por pantalla
            Formulario_Salarios.Show();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            // instancio 
            Form acercaDe = new Acerca_De();
            //lo muestro
            acercaDe.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pantallaPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            // Opcion MouseDown muevo la pantalla desde el form
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelPantallaprincipal_MouseDown(object sender, MouseEventArgs e)
        {
            // muevo la pantalla desde el Panel 
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picboxCerrarPantallaPrincipal_Click(object sender, EventArgs e)
        {
            // Le Asigno al PictureBox la opcion de cerrar aplicacion
            Application.Exit();
        }

        private void picboxMinimizar_Click(object sender, EventArgs e)
        {
            // igualmente al PictureBox de Minimizar la opcion de minimizar 
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
