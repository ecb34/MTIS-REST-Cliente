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
    public partial class ModificarEmpleado : Form
    {
        private int privateModificar = 0;
        private string restKey = "";
        
        Empleado.EmpleadoService empleado = new Empleado.EmpleadoService();
        public ModificarEmpleado(string restKey)
        {
            InitializeComponent();
            deshabilitarTextBox();
            button1.Enabled = false;
            this.restKey = restKey;
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

        private void habilitarTextBox()
        {
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            dateTimePicker1.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
        }

        private async Task button1_ClickAsync(object sender, EventArgs e)
        {
            if (privateModificar == 0)
            {
                // enable
                habilitarTextBox();
                privateModificar++;
            }else
            {
                var empleado = new Empleado.EmpleadoClient("https://localhost:44308/api/");

                privateModificar = 0;

                // disable
                deshabilitarTextBox();

                var body = new Empleado.Models.Empleado
                {
                    NIF = textBox2.Text,
                    Nombre = textBox3.Text,
                    Apellidos = textBox4.Text,
                    Direccion = textBox5.Text,
                    Poblacion = textBox6.Text,
                    Telefono = textBox7.Text,
                    Email = textBox8.Text,
                    FechaNacimiento = dateTimePicker1.Value.Date,
                    NSS = textBox10.Text,
                    IBAN = textBox11.Text
                };

                var res = await empleado.EmpleadoNif.Put(body, textBox2.Text);

                try
                {
                    MessageBox.Show("Error: " + res.Content.Codigo + " " + res.Content.Mensaje);
                }
                catch (Exception)
                {
                    MessageBox.Show("Modificado correctamente.");
                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var endpoint = new Empleado.EmpleadoClient("https://localhost:44308/api/");

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
                    button1.Enabled = true;
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
