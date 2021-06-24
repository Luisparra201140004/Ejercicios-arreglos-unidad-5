using System;

namespace Programa_que_lee_una_cadena
{
    class Program
    {
        class Cadena
        {
            string Cadena_caracter;
            public void Nombre()
            {
                Console.WriteLine("Un programa que lea una cadena de caracteres y regrese como salida:");
                Console.WriteLine("(A) La cadena escrita al revés.");
                Console.WriteLine("(B) La cadena en mayúsculas.");
                Console.WriteLine("(C) La cadena anterior modificada según las siguientes reglas."); 
                Console.WriteLine("Introduce la palabra: ");
                Cadena_caracter = Convert.ToString(Console.ReadLine());
                char[] cArray = Cadena_caracter.ToCharArray();
                string Reverse = String.Empty;
                for (int i = cArray.Length - 1; i > -1; i--)
                {
                    Reverse += cArray[i];
                }
                //En esta seccion el programa estara regresando la palabra pero al reves
                Console.WriteLine("(A) La palabra escrita al reves es: " + Reverse);
                Console.ReadKey();
            }
            //El siguiente proceso es cambiar la palabra escrita a mayusculas y despues cambiar letras por numeros segun las reglas
            public void Mayus()
            {
                Console.WriteLine("(B) La palabra escrita en mayusculas: {0}", Cadena_caracter.ToUpper());
                Console.ReadKey();
                Console.WriteLine("(C) La palabra modificada cambiando letras por numeros: {0}", Cadena_caracter.Replace("a", "4").Replace("i", "1").Replace("s", "5").Replace("b", "8").Replace("e", "3").Replace("t", "7"));
            }
        }
        static void Main(string[] args)
        {
            Cadena objcade = new Cadena();
            objcade.Nombre();
            Cadena objcadesa = new Cadena();
            objcade.Mayus();
        }
    }
}
