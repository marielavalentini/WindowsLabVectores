using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLabVectores
{
    public partial class Form5Struct : Form
    {
        public Form5Struct()
        {
            InitializeComponent();
        }
        /*Se desea saber la temperatura media trimestral de cuatro provincias. Para ello se tiene como dato las temperaturas medias mensuales de dichas provincias.
Se debe ingresar el nombre de la provincia y seguidamente las tres temperaturas medias mensuales.
Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en memoria.
1.            Ingresar por teclado los nombres de las provincias y las temperaturas medias mensuales.
2.            Imprimir los nombres de las provincias y las temperaturas medias mensuales de las mismas.
3.            Calcular la temperatura media trimestral de cada provincia.
4.            Imprimir el nombre de la provincia con la temperatura media trimestral mayor.*/

        public struct Ciudad
        {
            public string nombreCiudad;
            public decimal[] temperaturas;
        }

        private void btnCiudadesTemperaturas_Click(object sender, EventArgs e)
        {
            Ciudad[] ciudades = new Ciudad[2];
            
            for(int i = 0; i < ciudades.Length; i++)
            {
                string nombreCiudad = Interaction.InputBox("Ingrese el nombre de la ciudad");
                ciudades[i].nombreCiudad = nombreCiudad;
                ciudades[i].temperaturas = new decimal[3];

                for(int j=0; j < ciudades[i].temperaturas.Length; j++)
                {
                    decimal temperatura = Convert.ToDecimal(Interaction.InputBox("Ingrese las temperaturas"));
                    ciudades[i].temperaturas[j] = temperatura;
                }
            }

            imprimir(ciudades);
            calcularPromedio(ciudades);
            mostrarMayor(ciudades); 

            

        }

        #region MyRegion
        public void imprimir(Ciudad[] ciudades)
        {
            for(int i = 0; i < ciudades.Length; i++)
            {
                MessageBox.Show("Nombre de la ciudad: " + ciudades[i].nombreCiudad);

                for(int j=0; j < ciudades[i].temperaturas.Length; j++)
                {
                    MessageBox.Show("Temperatura: " + ciudades[i].temperaturas[j]);
                }
            }
        }

        public void calcularPromedio(Ciudad[] ciudades )
        {
            decimal promedio = 0;   
            for(int i = 0; i < ciudades.Length; i++)
            {
                promedio = ciudades[i].temperaturas.Average();

                MessageBox.Show("El promedio de " + ciudades[i].nombreCiudad + " es: " + promedio.ToString());
                 
            }
                
        }

        public void mostrarMayor(Ciudad[]ciudades)
        {
            decimal mayor = 0;

            for(int i = 0; i < ciudades.Length; i++)
            {
                mayor = ciudades[i].temperaturas.Max();
                MessageBox.Show("La mayor temperatura ingresada de " + ciudades[i].nombreCiudad + " es: " + mayor.ToString()); 
            }
        }
        #endregion
    }
}
