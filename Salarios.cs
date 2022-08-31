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
    public partial class FormSalarios : Form
    {
        public FormSalarios()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            bool Datos = false;
            int horasTrabajadas = 0;
            double sueldoTotal = 0, valorComisExtra = 0, horasExtras = 0, sueldoBase = 0;
            double seguridadSocial = 0, subTransporte = 0, Beneficio = 0;

            // represento un instante a travez de un date time 
            DateTime dateTime = DateTime.Parse(dtmFechaIngreso.Text);
            DateTime dateTime1 = DateTime.Now;
            dateTime1 = dateTime1.AddYears(-5);

            //Validamos los campos obligatorios 
            if (txtNombreEmpleado.Text == "" || txtDocumento.Text == "" || txtHorasSemana.Text == "")
            {
                MessageBox.Show("Debes ingresar los valores de los campos vacios", "ERROR");
                Datos = true;
            }
            // Valido que el cargo del empleado sea vendedor, de lo contrario 
            // si esta vacio muestro mensaje de error. 
            if (cbCargoEmpleado.Text == "Vendedor")
            {
                if (txtValorventas.Text == "")// Si valor ventas esta vacio, mensaje error
                {
                    MessageBox.Show("Debes ingresa el valor de las ventas", "ERROR");
                }
            }
            // Validacion de horas menores de 48 y mayores a 60
            horasTrabajadas = int.Parse(txtHorasSemana.Text);

            while (horasTrabajadas < 48 && horasTrabajadas > 60)
            {
                MessageBox.Show("Las horas trabajas en la semana no cumplen con los requerimientos establecidos por administracion", "ERROR");
            }
            //Valido los sueldos de cada area y realizo las operaciones
            if (cbCargoEmpleado.Text == "Administrativo") // si el cargo del empleado es
                                                          //Administrativo entonces entra. 
            {
                // Sueldo Administrativo equivalente a 30.000 $
                sueldoBase = horasTrabajadas * 30000;
                seguridadSocial = sueldoBase * 0.08;
                sueldoTotal = sueldoBase - seguridadSocial;
            }
            // Valido si es vendedor 
            else if (cbCargoEmpleado.Text == "Vendedor")
            {
                // sueldo de vendedor equivalente a 15.000 $
                sueldoBase = horasTrabajadas * 15000;
                // convierto los caracteres numericos a datos numericos
                valorComisExtra = int.Parse(txtValorventas.Text);
                // Multiplico el valor de las ventas por el porcentaje
                valorComisExtra = valorComisExtra * 0.04;
                seguridadSocial = sueldoBase * 0.08;
                sueldoTotal = (sueldoBase) + valorComisExtra - seguridadSocial;
            }
            // Valido si es mecanico 
            else if (cbCargoEmpleado.Text == "Mecanico")
            {
                //Si es mecanico su sueldo es de 20.000 $
                sueldoBase = horasTrabajadas * 20000;
                horasExtras = horasTrabajadas - 48;
                horasExtras = horasExtras * 30000;
                seguridadSocial = sueldoBase * 0.08;
                sueldoTotal = sueldoBase + horasExtras - seguridadSocial;
            }
            // validamos si es servicios varios
            else if (cbCargoEmpleado.Text == "Servicios varios")
            {
                // si es de servicios varios su hora laborada cuesta 5.000 $
                sueldoBase = horasTrabajadas * 5000;
                horasExtras = horasTrabajadas - 48;
                horasExtras = horasExtras * 7500;
                seguridadSocial = sueldoBase * 0.08;
                subTransporte = 45000;
                sueldoTotal = sueldoBase + horasExtras + subTransporte - seguridadSocial;
            }
            // si dateTime es menor o igual a 5 años
            if (dateTime <= dateTime1)
            {
                Beneficio = (sueldoTotal * 0.02);
                sueldoTotal = sueldoTotal + Beneficio;
            }
            // genero las operaciones realizadas y las
            // ingreso convertidas en datos con carecteres numericos
            txtSueldoBase.Text = sueldoBase.ToString();
            txtValorComisiones.Text = valorComisExtra.ToString();
            txtValorBeneficio.Text = Beneficio.ToString();
            txtSubsTransporte.Text = subTransporte.ToString();
            txtValorHorasExtras.Text = horasExtras.ToString();
            txtSeguridadSocial.Text = seguridadSocial.ToString();
            txtTotalDevengado.Text = sueldoTotal.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Limpio los campos con informacion. 
            txtNombreEmpleado.Clear();
            txtDocumento.Clear();
            txtHorasSemana.Clear();
            txtValorventas.Clear();
            txtSueldoBase.Clear();
            txtValorComisiones.Clear();
            txtValorBeneficio.Clear();
            txtSubsTransporte.Clear();
            txtValorHorasExtras.Clear();
            txtSeguridadSocial.Clear();
            txtTotalDevengado.Clear();
            this.cbCargoEmpleado.Text = "";
            this.dtmFechaIngreso.Text = ""; 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierro la pestaña
            Application.Exit();
        }
    }
 }

