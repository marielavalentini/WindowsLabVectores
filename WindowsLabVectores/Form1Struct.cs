using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsLabVectores
{
    public partial class Form1Struct : Form
    {
        public Form1Struct()
        {
            InitializeComponent();
        }
        public struct Alumno
        {
            public string Nombre;
            public int[] notas;
        }


        private void btnStructAlumno_Click(object sender, EventArgs e)
        {
            Alumno[] alumnos = new Alumno[2];

            for(int i = 0; i < alumnos.Length; i++)
            {
                string nombre = Interaction.InputBox("Ingre el nombre del alumno");
                alumnos[i].Nombre = nombre;
                alumnos[i].notas = new int[3];

                for( int j = 0; j < alumnos[i].notas.Length; j++)
                {
                    int nota = Convert.ToInt32(Interaction.InputBox("Ingrese las notas de " + alumnos[i].Nombre));
                    alumnos[i].notas[j] = nota;

                }
            }

            promedioYMayor(alumnos);

        }

        #region MyRegion

        public void promedioYMayor( Alumno []alumnos)
        {
            for (int i = 0; i < alumnos.Length; i++)
            {
                int mayor = alumnos[i].notas.Max();
                double promedio = alumnos[i].notas.Average();
                MessageBox.Show("El promedio de " + alumnos[i].Nombre + " es: " + promedio.ToString() + "\nSu mayor nota es: " + mayor);
                if(promedio<4)
                {
                    MessageBox.Show(alumnos[i].Nombre + " debe ir a recuperatorio");

                }else if (promedio >= 4 && promedio < 7)
                {
                    MessageBox.Show(alumnos[i].Nombre + " lo hizo bien");

                }else
                {
                    MessageBox.Show(alumnos[i].Nombre + " lo hizo MUY bien");
                }
            }
        }


        #endregion
    }
}
