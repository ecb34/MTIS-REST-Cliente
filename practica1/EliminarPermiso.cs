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
    public partial class EliminarPermiso : Form
    {
        private string restKey = "";
        private Seguridad.SeguridadClient seguridad;

        public EliminarPermiso(string restKey)
        {
            InitializeComponent();
            this.restKey = restKey;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string dni = textBox1.Text;
            string sala = textBox2.Text;

            seguridad = new Seguridad.SeguridadClient("https://localhost:44308/api/");
            var seguridadQuery = new Seguridad.Models.DeleteSeguridadQuery
            {
                NIF = dni,
                Sala = sala,
                RestKey = restKey
            };
            var response = await seguridad.Seguridad.Delete(seguridadQuery);
            
            if(response.Content == null)
            {
                MessageBox.Show("Eliminado correctamente");
            }
            else
            {
                MessageBox.Show("Error: " + response.Content.Codigo + " " + response.Content.Mensaje);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home(restKey);
            form.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EliminarPermiso_Load(object sender, EventArgs e)
        {

        }
    }
}
