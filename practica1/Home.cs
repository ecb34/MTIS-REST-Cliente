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
    public partial class Home : Form
    {
        private string restKey = "";
        public Home(string key = "")
        {
            restKey = key;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmpleado form = new AddEmpleado(restKey);
            form.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarEmpleado form = new EliminarEmpleado(restKey);
            form.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModificarEmpleado form = new ModificarEmpleado(restKey);
            form.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarEmpleado form = new ConsultarEmpleado(restKey);
            form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ValidarUsuario form = new ValidarUsuario(restKey);
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ObtenerNiveles form = new ObtenerNiveles(restKey);
            form.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AsignarPermiso form = new AsignarPermiso(restKey);
            form.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            EliminarPermiso form = new EliminarPermiso(restKey);
            form.ShowDialog();
            this.Close();
        }


        private void button12_Click(object sender, EventArgs e)
        {
            this.restKey = textBox1.Text;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
        }


        private void Home_Load(object sender, EventArgs e)
        {
            textBox1.Text = restKey;
            if (string.IsNullOrEmpty(restKey))
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }
        }
    }
}
