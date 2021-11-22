using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        Persona persona;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void NotificarCambio(string msg)
        {
            MessageBox.Show(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (persona is  null)
            {
                persona = new Persona();
                persona.EventoString += NotificarCambio;
                button1.Text = "Actualizar";
            }

            if (textBox1.Text != persona.Nombre)
            {
                persona.Nombre = textBox1.Text;
            }
            if (textBox2.Text != persona.Apellido)
            {
                persona.Apellido = textBox2.Text;
            }
            label3.Text = persona.Mostrar();


        }
    }
}
