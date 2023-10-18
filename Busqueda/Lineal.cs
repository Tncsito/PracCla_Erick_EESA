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
            int[] a = { 4, 8, 10, 12, 13, 14, 16, 28, 25, 30 }; //Creación del arreglo (ya inicializado)
            int inicio = 0; //Inicio del parametro de busqueda lineal
            int fin = a.Length - 1; // Ajustar el valor de fin para que sea el último índice válido
            int indice = -1;//Centinela del programa
            Console.WriteLine("Dame un número para buscar");//Comienzo del programa
            int buscar = Convert.ToInt32(Console.ReadLine());//Continuación del comienzo del programa
            //Espacio
            while (inicio <= fin)
            {//Parentesis
                int medio = (inicio + fin) / 2; // Calcular el punto medio en cada iteración
                //Espacio
                if (a[medio] == buscar) // Comparar con el valor a[medio], no con indice
                {//Parentesis
                    indice = medio;
                    break; //Se termina la condicional ahí
                }//Parentesis
                else if (a[medio] > buscar) //Siguiente parte de la condicional
                {//Parentesis
                    fin = medio - 1;
                }//Parentesis
                else//Parte final de la condicional
                {//Parentesis
                    inicio = medio + 1;
                } //Parentesis
            }//Parentesis
            //Espacio
            if (indice != -1)//Declarando si ya está el resultado esperado
            {//Parentesis
                Console.WriteLine($"Tu número está en la posición: {indice + 1}");//Resultado positivo del trabajo
            }//Parentesis
            else//Declarando si no está el resultado esperado
            {//Parentesis
                Console.WriteLine("No existe tu número en el arreglo.");//Resultado negativo del trabajo
            }//Parentesis
        }
        public void dos()
        {
            string[] a = { "H", "O", "L", "A", "M", "U", "N", "D", "O" };
            Console.WriteLine("Dame una letra para buscar de este texto:\nHOLAMUNDO");
            string buscar = Console.ReadLine();
            int indice = -1; // Centinela del programa

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == buscar)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                Console.WriteLine($"Tu letra está en la posición: {indice + 1}");
            }
            else
            {
                Console.WriteLine("No existe tu letra en el arreglo.");
            }
        }
        public void tres()
        {
            Console.WriteLine("Para empezar vamos a crear el arreglo de 5 posiciones:\nDame un numero");
            int[] a = new int[5];
            a[0] = Convert.ToInt32(Console.ReadLine());
            for (int fila = 1; fila < a.GetLength(0); fila++)
            {
                Console.WriteLine("Dame otro numero:");
                a[fila] = Convert.ToInt32(Console.ReadLine());
            }

            int posicion = -1;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"El primer número par se encuentra en la posición {posicion + 1}");
            }
            else
            {
                Console.WriteLine("No se encontraron números pares en el arreglo.");
            }
        }
        public void cuatro()
        {
            Console.WriteLine("Dame un numero: ");
            int[] a = new int[5];
            a[0] = Convert.ToInt32(Console.ReadLine());
            for (int fila = 1; fila < a.GetLength(0); fila++)
            {
                Console.WriteLine("Dame otro numero:");
                a[fila] = Convert.ToInt32(Console.ReadLine());
            }

            for (int fila = 0; fila < a.GetLength(0); fila++)
            {
                if (a[fila] % 2 == 0)
                {
                    Console.WriteLine($"Número par encontrado en la posición [{fila}]");
                }
            }
        }
    }
}
