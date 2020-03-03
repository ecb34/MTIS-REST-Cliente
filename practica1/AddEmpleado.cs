using Newtonsoft.Json;
using practica1.Utilidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class AddEmpleado : Form
    {
        private string restKey = "";

        private Utilidades.UtilidadesClient endpointUtilidades = new Utilidades.UtilidadesClient("https://localhost:44308/");
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

        private async Task CallValidarNIF()
        {
            try
            {
                var res = await endpointUtilidades.UtilidadesValidarNIF.Get(new GetUtilidadesValidarNIFQuery
                {
                    Nif = textBox2.Text,
                    RestKey = restKey
                });
                using (var contentStream = await res.RawContent.ReadAsStreamAsync())
                {
                    contentStream.Seek(0, SeekOrigin.Begin);
                    using (var sr = new StreamReader(contentStream))
                    {
                        var result = JsonConvert.DeserializeObject<MultipleUtilidadesValidarNIFGet>(sr.ReadToEnd());
                        if (result.Ipbool.HasValue)
                        {
                            if (result.Ipbool.Value)
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
                            mensajeValidacion.Text = "ERROR: " + result.Error.Codigo + " " + result.Error.Mensaje;
                            mensajeValidacion.BackColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception)
            {
                mensajeValidacion.Text = "Error al validar";
                mensajeValidacion.BackColor = Color.Red;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await CallValidarNIF();

        }

        private async void ValidarNSS_Click(object sender, EventArgs e)
        {
            try
            {
                var res = await endpointUtilidades.UtilidadesValidarNAFSS.Get(new GetUtilidadesValidarNAFSSQuery
                {
                    Nif = textBox10.Text,
                    RestKey = restKey
                });

                using (var contentStream = await res.RawContent.ReadAsStreamAsync())
                {
                    contentStream.Seek(0, SeekOrigin.Begin);
                    using (var sr = new StreamReader(contentStream))
                    {
                        var result = JsonConvert.DeserializeObject<MultipleUtilidadesValidarNAFSSGet>(sr.ReadToEnd());
                        if (result.Ipbool.HasValue)
                        {
                            if (result.Ipbool.Value)
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
                            mensajeValidacion.Text = "ERROR: " + result.Error.Codigo + " " + result.Error.Mensaje;
                            mensajeValidacion.BackColor = Color.Red;
                        }
                    }
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

                using (var contentStream = await res.RawContent.ReadAsStreamAsync())
                {
                    contentStream.Seek(0, SeekOrigin.Begin);
                    using (var sr = new StreamReader(contentStream))
                    {
                        var result = JsonConvert.DeserializeObject<MultipleUtilidadesValidarIBANGet>(sr.ReadToEnd());
                        if (result.Ipbool.HasValue)
                        {
                            if (result.Ipbool.Value)
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
                            mensajeValidacion.Text = "ERROR: " + result.Error.Codigo + " " + result.Error.Mensaje;
                            mensajeValidacion.BackColor = Color.Red;
                        }
                    }
                }
            }
            catch (Exception)
            {
                mensajeValidacion.Text = "Error al validar";
            }
        }
    }
}
