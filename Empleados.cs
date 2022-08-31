using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoGrafico_trabajoFinal
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

       private void btnGuardar_Click(object sender, EventArgs e)
        {
           // Inicilo la variable de tipo bool hasta que sea false
           bool strAlerta = false;
           int documento = 0;

          if (TxtNombre.Text == "" || txtCorreoElectronico.Text == "" || TxtDocumento.Text == "" || gbGenero.Text == "" || CbCargoDeEmpleado.Text == "" || txtDireccionActual.Text == "")
          {
            MessageBox.Show("Los campos marcados con (*) deben ser llenados obligatoriamente", "ERROR");
            strAlerta = true;
          }
          else
            {
                // validacion de ingreso de caracter especial para el campo obligatorio correo electronico 
                if (txtCorreoElectronico.Text.IndexOf('@') < 0)
                {
                   MessageBox.Show("El correo ingresado no es valido", "ERROR");
                   strAlerta = true;
                }
                // Valido el campo numerico de documento. 
                if (!int.TryParse(TxtDocumento.Text, out documento))
                {
                   MessageBox.Show("Solo es permitido el ingreso de valores numericos", "ERROR");
                   strAlerta = true;
                }

                // Valido el campo de cargo de empleado
                if (CbCargoDeEmpleado.Text == "")
                {
                  MessageBox.Show("Selecciona un cargo", "ERROR");
                  strAlerta = true;
                }
                // Muestro los datos a guardar 
                if (strAlerta == false)
                {
                   String StrDatos = "";

                   StrDatos =  "Nombre Empleado : " + TxtNombre.Text;
                   StrDatos += "\nDocumento empleado : " + TxtDocumento.Text;
                   StrDatos += "\nFecha de nacimiento : " + DtmFechaDeNacimiento.Text;
                   StrDatos += "\nCargo del empleado : " + CbCargoDeEmpleado.Text;
                   StrDatos += "\nCorreo electronico : " + txtCorreoElectronico.Text;
                   StrDatos += "\nNumero de contacto : " + txtTelefonoContacto.Text;
                   StrDatos += "\nDireccion actual : " + txtDireccionActual.Text;
                   StrDatos += "\nProfesion : " + txtProfesion.Text;
                   StrDatos += "\nFecha de ingreso : " + DtmFechaDeIngresoAlaEmpresa.Text;
                   StrDatos += "\nDatos generales del empelado: " + txtDatosGenerales;

               // Valido la seleccion de Genero 

                    if (RbFemenino.Checked)
                    {
                        StrDatos += "\n Genero: ------------ Femenino";
                    }
                    else
                    {
                        StrDatos += "\nGenero: ------------ Masculino";
                    }
                    MessageBox.Show(StrDatos, "LOS DATOS INGRESADOS SO ");
             }
          }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
