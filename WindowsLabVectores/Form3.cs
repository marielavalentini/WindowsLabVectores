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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public struct Operario
        {
            public string nombreOperario;
            public decimal[] sueldos;
        }

        private void btnOperariosySueldos_Click(object sender, EventArgs e)
        {
            Operario []operarios = new Operario[2];

            for(int i = 0; i < operarios.Length; i++)
            {
                string nombre = Interaction.InputBox("Ingrese el nombre del operario");
                operarios[i].nombreOperario = nombre;
                operarios[i].sueldos = new decimal[3];
                

                for (int j=0; j < operarios[i].sueldos.Length; j++)
                {
                    decimal sueldo = Convert.ToDecimal(Interaction.InputBox("Ingrese el sueldo"));
                }

            }
            Operario[] auxAcumulados = new Operario[3];

            AcumuladosArreglo(auxAcumulados);



             
        }

        #region MyRegion
        public decimal sueldosAcumulados(Operario[] operarios)
        {
            decimal total = 0;

            for(int i = 0; i < operarios.Length; i++)
            {
                MessageBox.Show("Nombre: " + operarios[i].nombreOperario);

                for(int j = 0; j < operarios[i].sueldos.Length; j++)
                {
                    total = total + operarios[i].sueldos[j];
                }
            }
            return total;   
        }

        public void sueldosAcumulados2(Operario[] operarios)
        {
            decimal total = 0;

            for (int i = 0; i < operarios.Length; i++)
            {

                for (int j = 0; j < operarios[i].sueldos.Length; j++)
                {
                    total = total + operarios[i].sueldos[j];
                    MessageBox.Show("total: " + total);
                }
            }
          
        }

        public Operario[] AcumuladosArreglo(Operario[] operarios)
        {
            Operario[] aux = new Operario[3];
            decimal acumulado = 0;

            for(int i = 0; i < operarios.Length; i++)
            {
                aux[i].nombreOperario = operarios[i].nombreOperario;
                
                for(int j = 0; j < operarios[i].sueldos.Length ;j++)
                {
                    acumulado = acumulado + operarios[i].sueldos[j];
                    aux[i].sueldos[j] = acumulado;
                    MessageBox.Show("nombre: " + aux[i].nombreOperario + "\nacumulado: " + aux[i].sueldos);
                }
            }

            return aux;
        }
        #endregion
    }
}
