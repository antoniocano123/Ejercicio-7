using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        int[] precio;
        public Form1()
        {
            InitializeComponent();
        }
        public void Imprimir ()
        {
            string salida = "";
            int suma = 0;
            llenar();
            double promedio = 0;
            foreach(int n in precio)
            {
                suma += n;
            }
            promedio = (double)suma / (double)precio.Length;


            foreach (int num in precio)
            {
                if (promedio < num)
                {

                     salida = salida + " "+ $"{num}";
                }
                
            }
            lbsalida.Text = $"{salida}";
            
        }

        public void llenar ()
        {
            for (int i = 0 ; i < precio.Length; i++)
            {
                Random aleatorio = new Random();
                int numeroAleatorio = aleatorio.Next(100000, 500000);
                precio[i] = numeroAleatorio;
            }
        }
    }
}
