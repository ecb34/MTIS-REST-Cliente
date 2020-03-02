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
    public partial class AsignarPermiso : Form
    {
        private string restKey = "";
        public AsignarPermiso(string restKey)
        {
            InitializeComponent();
            this.restKey = restKey;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var seguridad = new Seguridad.SeguridadClient("https://localhost:44308/api/");
           
            string nif = textBox1.Text;
            string sala = textBox2.Text;
            var res = await seguridad.Seguridad.Post(new Seguridad.Models.Permiso { NIF = nif, Sala = sala, RestKey = restKey });

            try
            {
                if (res.Content == null)
                    MessageBox.Show("Asignado correctamente.");
                else
                    MessageBox.Show("Error: " + res.Content.Codigo + " " + res.Content.Mensaje);
            }
            catch (Exception)
            {
                MessageBox.Show("Asignado correctamente.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home(restKey);
            form.ShowDialog();
            this.Close();
        }

        private void AsignarPermiso_Load(object sender, EventArgs e)
        {

        }
    }
}
