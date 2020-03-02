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
    public partial class AddEmpleado : Form
    {
        private string restKey = "";

        private Utilidades.UtilidadesClient endpointUtilidades = new Utilidades.UtilidadesClient("https://localhost:44308/api/");
        public AddEmpleado(string restKey)
        {
            InitializeComponent();
            this.restKey = restKey;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var empleado = new Empleado.EmpleadoClient("https://localhost:44308/api/");
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

            var res = await empleado.Empleado.Post(body);

            try
            {
                MessageBox.Show("Error " + res.Content.Codigo + " " + res.Content.Mensaje);
            }
            catch (Exception)
            {
                MessageBox.Show("Guardado correctamente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home(restKey);
            form.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var res = await endpointUtilidades.UtilidadesValidarNIF.Get(new Utilidades.Models.GetUtilidadesValidarNIFQuery
                {
                    Nif = textBox2.Text,
                    RestKey = restKey
                });

                if (res.Content.Ipbool.HasValue)
                {
                    if (res.Content.Ipbool.Value)
                    {
                        mensajeValidacion.Text = "NIF válido";
                        mensajeValidacion.BackColor = Color.Green;
                    }
                    else
                    {
                        mensajeValidacion.Text = "NIF inválido";
                        mensajeValidacion.BackColor = Color.Red;
                    }
                }
                else
                {
                    mensajeValidacion.Text = "ERROR: " + res.Content.Error.Codigo + " " + res.Content.Error.Mensaje;
                }
            }
            catch (Exception)
            {
                mensajeValidacion.Text = "Error al validar";
            }     
        }

        private async void ValidarNSS_Click(object sender, EventArgs e)
        {
            try
            {
                var res = await endpointUtilidades.UtilidadesValidarNAFSS.Get(new Utilidades.Models.GetUtilidadesValidarNAFSSQuery
                {
                    Nif = textBox10.Text,
                    RestKey = restKey
                });

                if (res.Content.Ipbool.HasValue)
                {
                    if (res.Content.Ipbool.Value)
                    {
                        mensajeValidacion.Text = "NSS válido";
                        mensajeValidacion.BackColor = Color.Green;
                    }
                    else
                    {
                        mensajeValidacion.Text = "NSS inválido";
                        mensajeValidacion.BackColor = Color.Red;
                    }
                }
                else
                {
                    mensajeValidacion.Text = "ERROR: " + res.Content.Error.Codigo + " " + res.Content.Error.Mensaje;
                }
            }
            catch (Exception)
            {
                mensajeValidacion.Text = "Error al validar";
            }
        }

        private async void ValidarIBAN_Click(object sender, EventArgs e)
        {
            try
            {
                var res = await endpointUtilidades.UtilidadesValidarIBAN.Get(new Utilidades.Models.GetUtilidadesValidarIBANQuery
                {
                    Nif = textBox11.Text,
                    RestKey = restKey
                });

                if (res.Content.Ipbool.HasValue)
                {
                    if (res.Content.Ipbool.Value)
                    {
                        mensajeValidacion.Text = "IBAN válido";
                        mensajeValidacion.BackColor = Color.Green;
                    }
                    else
                    {
                        mensajeValidacion.Text = "IBAN inválido";
                        mensajeValidacion.BackColor = Color.Red;
                    }
                }
                else
                {
                    mensajeValidacion.Text = "ERROR: " + res.Content.Error.Codigo + " " + res.Content.Error.Mensaje;
                }
            }
            catch (Exception)
            {
                mensajeValidacion.Text = "Error al validar";
            }
        }
    }
}
