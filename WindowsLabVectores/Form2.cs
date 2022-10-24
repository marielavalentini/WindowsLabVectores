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
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;

namespace WindowsLabVectores
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Caso 2
       // Mostrar la suma de 8 precios de los productos ingresados por teclado.

        private void btnSuma_Click(object sender, EventArgs e)
        {
            decimal[] precios;
            precios = new decimal[8];
            CargaArreglo(precios);
            decimal suma = Sumar(precios);

            MessageBox.Show("La suma de los precios ingresados es: $ " + suma);


           
        }

        #region MyRegion
        public void CargaArreglo(decimal[] precios)
        {
            for (int i = 0; i < precios.Length; i++)
            {
                decimal precio = Convert.ToDecimal(Interaction.InputBox("Ingrese un precio"));
                precios[i] = precio;
            }
        }
        public decimal Sumar(decimal[] arreglo)
        {
            decimal suma = 0;

            for(int i = 0; i < arreglo.Length; i++)
            {
                suma = suma + arreglo[i];   
            }
            return suma;
        }
        #endregion
    }
}
