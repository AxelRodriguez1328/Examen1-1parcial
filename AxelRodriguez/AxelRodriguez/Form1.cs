using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxelRodriguez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener capital depositado por la persona
            double capital = Convert.ToDouble(capitalTextBox.Text);

            // Tasa de interés mensual fija
            double tasaInteres = 0.015;

            // Inicializar variable para almacenar el interés mensual
            double interesMensual;

            // Crear arreglo con los nombres de los meses
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            // Limpiar ListBox
            interesListBox.Items.Clear();

            // Calcular el interés mensual para cada mes y agregarlo al ListBox
            for (int i = 0; i < meses.Length; i++)
            {
                // Calcular el interés mensual
                interesMensual = capital * tasaInteres;

                // Agregar el nombre del mes y el interés mensual al ListBox
                interesListBox.Items.Add(meses[i] + ": L " + interesMensual.ToString("N2"));

                // Actualizar el capital para el siguiente mes (capital inicial más interés mensual)
                capital += interesMensual;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
   

