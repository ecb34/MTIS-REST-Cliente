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
                if(res.Content.Ipbool.HasValue)
                {
                    label3.Text = res.Content.Ipbool.Value ? "Usuario Validado" : "Usuario sin permiso";
                }
                else
                {
                    label3.Text = "Error:  " + res.Content.Error.Codigo + " " + res.Content.Error.Mensaje;
                }
            }
            catch (Exception)
            {
                label3.Text = "Error al validar";
            }
        }

        private void ValidarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
