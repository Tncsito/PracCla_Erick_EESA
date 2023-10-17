using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracCla_Erick_EESA.Datos
{
    public class Lineal
    {
        public void uno() 
        {
            int[] a = { 4, 8, 10, 12, 13, 14, 16, 28, 25, 30 };
            int inicio = 0;
            int fin = a.Length;
            int medio = (inicio + fin +1) / 2;
            int indice = -1;
            Console.WriteLine("Dame un numero para buscar");
            int buscar = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < a.Length; i++)
            {
                if (a[medio] == indice)
                    indice = medio;
                else if (a[indice] > buscar)
                    fin = medio - 1;
                    medio = inicio = (inicio + fin) / 2;
                else
                break;
            }
        }
    }
}
