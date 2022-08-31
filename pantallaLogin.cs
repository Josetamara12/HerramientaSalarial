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
    public partial class pantallaLogin : Form
    {
        // Instancio el formulario nuevo y le doy un nombre
        pantallaPrincipal Ingreso;
        public pantallaLogin()
        {
            InitializeComponent();
        }
        // desplazamiento de la pagina por toda la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {// Foco Enter si el txt tiene el sigueinte mensaje 
            if (txtUsuario.Text == "Ingresa Usuario")
            {
                // entonces queda vacio.
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {// Foco Leave si el txt esta vacio entonces muestre el siguiente mensaje
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingresa Usuario";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {// Foco Enter si el txt tiene el sigueinte mensaje
            if (txtContraseña.Text == "Constraseña")
            {
                // entonces queda vacio.
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {// Foco Leave si el txt esta vacio entonces muestre el siguiente mensaje
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void picboxCerrar_Click(object sender, EventArgs e)
        {
            // Le Asigno al PictureBox la opcion de cerrar aplicacion
            Application.Exit();
        }

        private void picboxMinimizar_Click(object sender, EventArgs e)
        {
            // igualmente al PictureBox de Minimizar la opcion de minimizar 
            this.WindowState = FormWindowState.Minimized;
        }

        private void pantallaLogin_MouseDown(object sender, MouseEventArgs e)
        {
            // Opcion MouseDown muevo la pantalla desde el form
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            // muevo la pantalla desde el Panel 
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // al dar click en el boton ingresar ingresa al form PantallaPrincipal 
            int Contraseña = 12345;
            // Usuario debe ser admin, de lo contrario muestra mensaje
            if (txtUsuario.Text != "Admin")
            {
                MessageBox.Show("USUARIO INVALIDO", "ERROR");
            }
            //Valido que la contraseña seA una valor numerico 
            if (!int.TryParse(txtContraseña.Text, out Contraseña))
            {
                MessageBox.Show("Debes ingresar un valor numerico", "ERROR");
            }
            //Valido que sea la contraseña correcta 
            if (txtContraseña.Text != "12345")
            {
                MessageBox.Show("Contraseña incorrecta, por favor valida tu contraseña", "ERROR");

            }
            // Si el usuario y la contraseña es correcta entonces Ingresa a pantalla Principal
            if ((txtUsuario.Text == "Admin") && (txtContraseña.Text == "12345"))
            {
                Ingreso = new pantallaPrincipal();
                Ingreso.Show();
                this.Hide();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // boton salir le asigno la funcion de salir del programa. 
            Application.Exit();
        }
    }
}
