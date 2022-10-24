using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static WindowsLabVectores.Form4Struct;

namespace WindowsLabVectores
{
    public partial class Form4Struct : Form
    {
        public Form4Struct()
        {
            InitializeComponent();
        }

        public struct Persona
        {
            public string nombre;
            public int edad;
        }
        //Desarrollar un programa que permita cargar 5 nombres de personas y sus edades respectivas. 
        //Luego de realizar la carga por teclado de todos los datos imprimir los nombres de las personas mayores de edad
        //(mayores o iguales a 18 años)
        private void btnPersonasEdades_Click(object sender, EventArgs e)
        {
            Persona[] personas = new Persona[5];
            
            for(int i = 0; i < personas.Length; i++)
            {
                string nombre = Interaction.InputBox("Ingrese el nombre de la presona");
                int edad = Convert.ToInt32(Interaction.InputBox("Ingrese la edad"));
                personas[i].nombre = nombre;
                personas[i].edad = edad;
                
            }

            imprimir(personas);
        }

        #region MyRegion
        public void imprimir(Persona[] arreglo )
        {
            for(int i = 0; i<arreglo.Length; i++)
            {
                if (arreglo[i].edad >= 18)
                {
                    MessageBox.Show("Nombre: " + arreglo[i].nombre + "\nEdad: " + arreglo[i].edad);
                }
            }
        }
        #endregion
    }
}
