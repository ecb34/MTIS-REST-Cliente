﻿using Newtonsoft.Json;
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
    public partial class ObtenerNiveles : Form
    {
        private string soapkey = "";
        public ObtenerNiveles(string soapkey)
        {
            InitializeComponent();
            this.soapkey = soapkey;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var endpoint = new Seguridad.SeguridadClient("https://localhost:44308/");

            string dni = textBox1.Text;
            var res = await endpoint.SeguridadNif.Get(dni, new Seguridad.Models.GetSeguridadNifQuery { RestKey = soapkey });

            try
            {
                using (var contentStream = await res.RawContent.ReadAsStreamAsync())
                {
                    contentStream.Seek(0, SeekOrigin.Begin);
                    using (var sr = new StreamReader(contentStream))
                    {
                        var result = JsonConvert.DeserializeObject<Seguridad.Models.MultipleSeguridadNifGet>(sr.ReadToEnd());
                        if(result.Ipstring != null)
                        {
                            var salas = "Salas: \n";
                            foreach (var sala in result.Ipstring)
                            {
                                salas += sala + "\n";
                            }

                            label2.Text = salas;
                        }
                        else
                        {
                            label2.Text = "Error: " + result.Error.Codigo + " " + result.Error.Mensaje;
                        }
                    }
                }
            }
            catch (Exception)
            {
                label2.Text = "Error al obtener niveles";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home(soapkey);
            form.ShowDialog();
            this.Close();
        }

        private void ObtenerNiveles_Load(object sender, EventArgs e)
        {

        }
    }
}
