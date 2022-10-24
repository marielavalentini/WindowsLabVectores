using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/*Empleando arreglos mostrar los nombres de 4 alumnos con sus respectivas notas de 3 materias.

Calcular el promedio de las notas por alumno.
Mostrar la mayor nota de las notas ingresadas por cada alumno.
Por cada Alumno:
si la nota es menor a 4 debe informar debe ir a recuperatorio.
si la nota es igual mayor a 4 y menor igual a 7 informar bien.
si la nota es mayor a 7 informar  muy bien.*/


namespace WindowsLabVectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresarNotas_Click(object sender, EventArgs e)
        {
            int[] notas;

            notas = new int[3];

            for(int i = 0; i < notas.Length  ; i++)
            {
                int nota = Convert.ToInt32(Interaction.InputBox("Ingrese una nota"));
                notas[i] = nota;
                aprobadoOdesaprobado(notas[i]);

            }

            int notaMayor = buscarNotaMayor(notas);
            double promedio = Buscarpromedio(notas);

            MessageBox.Show("La mayor nota de las ingresadas es: " + notaMayor + "\nEl promedio del alumno es: " + promedio);

        }

        #region Metodos

        public int buscarNotaMayor(int[] arreglo)
        {
            int mayorNota = arreglo.Max();
            return mayorNota;
        }

        public double Buscarpromedio(int[] arreglo)
        {
            double promedio =arreglo.Average();
            return promedio;
        }

        public void aprobadoOdesaprobado(int nota)
        {
            
           
                if (nota < 4)
                {
                    MessageBox.Show("La nota es menor a 4, debe ir a recuperatorio");

                } else if (nota > 4 && nota < 7)
                {
                    MessageBox.Show("Bien!");

                }else
                {
                    MessageBox.Show("Muy Bien!");
                }
            
        }
        #endregion
        //FUNCIONA PARA UN SOLO ALUMNO
    }
}
