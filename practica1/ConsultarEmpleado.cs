using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class ConsultarEmpleado : Form
    {
        private string restKey = "";
        public ConsultarEmpleado(string restkey)
        {
            InitializeComponent();
            deshabilitarTextBox();
            this.restKey = restkey;
        }
        private void deshabilitarTextBox()
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            dateTimePicker1.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var endpoint = new Empleado.EmpleadoClient("https://localhost:44308/");

            var res = await endpoint.EmpleadoNif.Get(textBox1.Text);

            try
            {
                var empleado = res.Content.Empleado;
                if (empleado != null)
                {
                    textBox2.Text = empleado.NIF;
                    textBox3.Text = empleado.Nombre;
                    textBox4.Text = empleado.Apellidos;
                    textBox5.Text = empleado.Direccion;
                    textBox6.Text = empleado.Poblacion;
                    textBox7.Text = empleado.Telefono;
                    textBox8.Text = empleado.Email;
                    dateTimePicker1.Text = empleado.FechaNacimiento.ToString();
                    textBox10.Text = empleado.NSS;
                    textBox11.Text = empleado.IBAN;
                }
                else
                {
                    var error = res.Content.Error;
                    MessageBox.Show("Error " + error.Codigo + " " + error.Mensaje);
                }  
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la consulta");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home(restKey);
            form.ShowDialog();
            this.Close();
        }

        private void ConsultarEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
