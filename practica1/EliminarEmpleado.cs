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
    public partial class EliminarEmpleado : Form
    {
        private string restKey = "";
        public EliminarEmpleado(string restKey)
        {
            InitializeComponent();
            this.restKey = restKey;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var empleado = new Empleado.EmpleadoClient("https://localhost:44308/");

            var res = await empleado.EmpleadoNif.Delete(textBox1.Text);
            try
            {
                MessageBox.Show("Error: " + res.Content.Codigo + " " + res.Content.Mensaje);
            }
            catch (Exception)
            {
                MessageBox.Show("Borrado correctamente");

                this.Hide();
                Home form = new Home(restKey);
                form.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home(restKey);
            form.ShowDialog();
            this.Close();
        }

        private void EliminarEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
