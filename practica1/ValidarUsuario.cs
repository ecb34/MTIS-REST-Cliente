using Newtonsoft.Json;
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
    public partial class ValidarUsuario : Form
    {
        private string restKey = "";
        public ValidarUsuario(string restKey)
        {
            InitializeComponent();
            this.restKey = restKey;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home(restKey);
            form.ShowDialog();
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var endpoint = new Seguridad.SeguridadClient("https://localhost:44308/api/");
            string dni = textBox1.Text;
            string sala = textBox2.Text;
            var res = await endpoint.Seguridad.Get(new Seguridad.Models.GetSeguridadQuery
            {
                NIF = dni,
                Sala = sala,
                RestKey = restKey
            });

            try
            {
                using (var contentStream = await res.RawContent.ReadAsStreamAsync())
                {
                    contentStream.Seek(0, SeekOrigin.Begin);
                    using (var sr = new StreamReader(contentStream))
                    {
                        var result = JsonConvert.DeserializeObject<Seguridad.Models.MultipleSeguridadGet>(sr.ReadToEnd());
                        if (result.Ipbool.HasValue)
                        {
                            label3.Text = result.Ipbool.Value ? "Usuario Validado" : "Usuario sin permiso";
                        }
                        else
                        {
                            label3.Text = "Error:  " + result.Error.Codigo + " " + result.Error.Mensaje;
                        }
                    }
                }
            }
            catch (Exception)
            {
                label3.Text = "Error al validar usuario";
            }
        }

        private void ValidarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
