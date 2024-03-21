using Calculus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisNumerico
{
    public partial class IngresoDatos : Form
    {
        public IngresoDatos()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            Calculo analizadorFuncion = new Calculo();
            string funcion;
            int cantIteracion;
            double tolerancia, xi, xd;
            funcion = textFuncion.Text;    

            // Agregar validación de iteración y tolerancia
            if (analizadorFuncion.Sintaxis(funcion,'x'))
            {
                MessageBox.Show ("Ok");
                cantIteracion = Convert.ToInt32(textIteracion.Text);
                tolerancia = Convert.ToDouble(textTolerancia.Text);
                // declarar xi, xd
            }
            else
            {
                MessageBox.Show("La sintaxis de la función ingresada es incorrecta");
            }
        }
    }
}
