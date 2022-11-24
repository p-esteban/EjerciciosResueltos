using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCarrera : Form
    {
        private Carrera carrera;
        //private Thread thread;
        private AutoF1 v1;
        private AutoF1 v2;
        public FrmCarrera()
        {
            InitializeComponent();
            this.pcbAutoUno.Image = this.imgListAutos.Images[0];
            this.pcbAutoDos.Image = this.imgListAutos.Images[0];
        }

        private void FrmCarrera_Load(object sender, EventArgs e)
        {
            this.InitializeAutosYCarrera();

            //Alumno:Metodo donde se agregaran los manejadores al evento de carrera
            carrera.InformarAvance += AvanzarAuto;
            carrera.InformarLlegada += ImprimirMensaje;
        }

       

        private void FrmCarrera_Shown(object sender, EventArgs e)
        {
            //Alumno:Instanciar Hilo secundario

            Task task = Task.Run(carrera.IniciarCarrera);
           
            
        }
        private void AvanzarAuto()
        {
            //Alumno:Metodo que maneja el evento InformarAvance

            if (this.InvokeRequired)
            {
                Action d = AvanzarAuto;
                this.Invoke(d);
            }
            else
            {


            this.pcbAutoUno.Location = new Point(this.v1.UbicacionEnPista, this.pcbAutoUno.Location.Y);
            this.pcbAutoDos.Location = new Point(this.v2.UbicacionEnPista, this.pcbAutoDos.Location.Y);

            }

        }
        private void InitializeAutosYCarrera()
        {
            Random random = new Random();
            this.v1 = new AutoF1("Ferrari", random.Next(5, 20), this.pcbAutoUno.Location.X);
            Thread.Sleep(2000);//pongo un sleep para el random
            this.v2 = new AutoF1("Renault", random.Next(5, 20), this.pcbAutoDos.Location.X);

            this.carrera = new Carrera(this.Size.Width); //instancion la carrera y le envio el maximo del form

            //Agrego vehiculos a la carrera
            this.carrera += v1;
            this.carrera += v2;

        }
        private void ImprimirMensaje(string mensaje)
        {
            //Alumno:Metodo que maneja el evento InformarLlegada

            // GestorBaseDeDatos bd = new GestorBaseDeDatos().Guardar();


            MessageBox.Show(mensaje, "Llegadas", MessageBoxButtons.OK, MessageBoxIcon.Hand);


        }
    }
}
