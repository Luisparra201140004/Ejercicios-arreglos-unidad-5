using System;

namespace Aplicacion_que_lea_10_numeros_enteros_y_genera
{
    class Program
    {
        class Numeros_10
        {
            public int Num1, Num2, Num4, Num5, Num6, Num7, Num8, Num9, Num10, Num3, Suma, Promedio;

            public void SUMA()
            {
                //Primero estamos pidiendo al usuario los 10 numeros 
                Console.WriteLine("Ingrese el numero 1: ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el numero 2");
                Num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el numero 3");
                Num3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el numero 4");
                Num4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el numero 5");
                Num5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el numero 6");
                Num6 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el numero 7");
                Num7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el numero 8");
                Num8 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el numero 9");
                Num9 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el numero 10");
                Num10 = Convert.ToInt32(Console.ReadLine());
                //el primer inciso del ejercicio es obtener la suma de los 10 numeros
                Suma = Num1 + Num2 + Num3 + Num4 + Num5 + Num6 + Num7 + Num8 + Num9 + Num10;
                Console.WriteLine("(A) Suma de los 10 digitos: " + Suma);

            }
            //para obtener el promedio de los 10 numeros es necesario sumarlos y dividir el resultado entre 10
            public void PROMEDIO()
            {
                Promedio = Suma / 10;
                Console.WriteLine("(B) El promedio de los elemntos leidos es: " + Promedio);
            }
            //Primero compararemos numero por numero cual sera el mayor de todos los 10 que ingresamos
            public void Numero_Mas_Grande()
            {
                if (Num1 > Num2 && Num1 > Num3 && Num1 > Num4 && Num1 > Num5 && Num1 > Num6 && Num1 > Num7 && Num1 > Num8 && Num1 > Num9 && Num1 > Num10)
                {
                    Console.WriteLine(" (C) El numero mas grande de los numeros leidos es el: " + Num1);
                }
                if (Num2 > Num1 && Num2 > Num3 && Num2 > Num4 && Num2 > Num5 && Num2 > Num6 && Num2 > Num7 && Num2 > Num8 && Num2 > Num9 && Num2 > Num10)
                {
                    Console.WriteLine(" (C) El numero mas grande de los numeros leidos es el: " + Num2);
                }
                if (Num3 > Num1 && Num3 > Num2 && Num3 > Num4 && Num3 > Num5 && Num3 > Num6 && Num3 > Num7 && Num3 > Num8 && Num3 > Num9 && Num3 > Num10)
                {
                    Console.WriteLine(" (C) El numero mas grande de los numeros leidos es el: " + Num3);
                }
                if (Num4 > Num1 && Num4 > Num2 && Num4 > Num3 && Num4 > Num5 && Num4 > Num6 && Num4 > Num7 && Num4 > Num8 && Num4 > Num9 && Num4 > Num10)
                {
                    Console.WriteLine(" (C) El numero mas grande de los numeros leidos es el: " + Num4);
                }
                if (Num5 > Num1 && Num5 > Num2 && Num5 > Num3 && Num5 > Num4 && Num5 > Num6 && Num5 > Num7 && Num5 > Num8 && Num5 > Num9 && Num5 > Num10)
                {
                    Console.WriteLine(" (C) El numero mas grande de los numeros leidos es el: " + Num5);
                }
                if (Num6 > Num1 && Num6 > Num2 && Num6 > Num3 && Num6 > Num4 && Num6 > Num5 && Num6 > Num7 && Num6 > Num8 && Num6 > Num9 && Num6 > Num10)
                {
                    Console.WriteLine(" (C) El numero mas grande de los numeros leidos es el: " + Num6);
                }
                if (Num7 > Num1 && Num7 > Num2 && Num7 > Num3 && Num7 > Num4 && Num7 > Num5 && Num7 > Num6 && Num7 > Num8 && Num7 > Num9 && Num5 + 7 > Num10)
                {
                    Console.WriteLine(" (C) El numero mas grande de los numeros leidos es el: " + Num7);
                }
                if (Num8 > Num1 && Num8 > Num2 && Num8 > Num3 && Num8 > Num4 && Num8 > Num5 && Num8 > Num6 && Num8 > Num7 && Num8 > Num9 && Num8 > Num10)
                {
                    Console.WriteLine(" (C) El numero mas grande de los numeros leidos es el:" + Num8);
                }
                if (Num9 > Num1 && Num9 > Num2 && Num9 > Num3 && Num9 > Num4 && Num9 > Num5 && Num9 > Num6 && Num9 > Num7 && Num9 > Num8 && Num9 > Num10)
                {
                    Console.WriteLine(" (C) El numero mas grande de los numeros leidos es el: " + Num9);
                }
                if (Num10 > Num1 && Num10 > Num2 && Num10 > Num3 && Num10 > Num4 && Num10 > Num5 && Num10 > Num6 && Num10 > Num7 && Num10 > Num8 && Num10 > Num9)
                {
                    Console.WriteLine(" (C) El numero mas grande de los numeros leidos es el: " + Num10);
                }

            }
            //En este proceso se compara cual es el numero menor de los 10 numeros que ingresamos y uno a uno se compara

            public void Numero_Menor()
            {
                if (Num1 < Num2 && Num1 < Num3 && Num1 < Num4 && Num1 < Num5 && Num1 < Num6 && Num1 < Num7 && Num1 < Num8 && Num1 < Num9 && Num1 < Num10)
                {
                    Console.WriteLine(" (D) El numero mas pequeño de los numeros leidos es el: " + Num1);
                }
                if (Num2 < Num1 && Num2 < Num3 && Num2 < Num4 && Num2 < Num5 && Num2 < Num6 && Num2 < Num7 && Num2 < Num8 && Num2 < Num9 && Num2 < Num10)
                {
                    Console.WriteLine("(D) El numero mas pequeño de los numeros leidos es el: " + Num2);
                }
                if (Num3 < Num1 && Num3 < Num2 && Num3 < Num4 && Num3 < Num5 && Num3 < Num6 && Num3 < Num7 && Num3 < Num8 && Num3 < Num9 && Num3 < Num10)
                {
                    Console.WriteLine("(D) El numero mas pequeño de los numeros leidos es el: " + Num3);
                }
                if (Num4 < Num1 && Num4 < Num2 && Num4 < Num3 && Num4 < Num5 && Num4 < Num6 && Num4 < Num7 && Num4 < Num8 && Num4 < Num9 && Num4 < Num10)
                {
                    Console.WriteLine("(D) El numero mas pequeño de los numeros leidos es el: " + Num4);
                }
                if (Num5 < Num1 && Num5 < Num2 && Num5 < Num3 && Num5 < Num4 && Num5 < Num6 && Num5 < Num7 && Num5 < Num8 && Num5 < Num9 && Num5 < Num10)
                {
                    Console.WriteLine("(D) El numero mas pequeño de los numeros leidos es el: " + Num5);
                }
                if (Num6 < Num1 && Num6 < Num2 && Num6 < Num3 && Num6 < Num4 && Num6 < Num5 && Num6 < Num7 && Num6 < Num8 && Num6 < Num9 && Num6 < Num10)
                {
                    Console.WriteLine("(D) El numero mas pequeño de los numeros leidos es el: " + Num6);
                }
                if (Num7 < Num1 && Num7 < Num2 && Num7 < Num3 && Num7 < Num4 && Num7 < Num5 && Num7 < Num6 && Num7 < Num8 && Num7 < Num9 && Num7 < Num10)
                {
                    Console.WriteLine("(D) El numero mas pequeño de los numeros leidos es el: " + Num7);
                }
                if (Num8 < Num1 && Num8 < Num2 && Num8 < Num3 && Num8 < Num4 && Num8 < Num5 && Num8 < Num6 && Num8 < Num7 && Num8 < Num9 && Num8 < Num10)
                {
                    Console.WriteLine("(D) El numero mas pequeño de los numeros leidos es el: " + Num8);
                }
                if (Num9 < Num1 && Num9 < Num2 && Num9 < Num3 && Num9 < Num4 && Num9 < Num5 && Num9 < Num6 && Num9 < Num7 && Num9 < Num8 && Num9 < Num10)
                {
                    Console.WriteLine("(D) El numero mas pequeño de los numeros leidos es el: " + Num9);
                }
                if (Num10 < Num1 && Num10 < Num2 && Num10 < Num3 && Num10 < Num4 && Num10 < Num5 && Num10 < Num6 && Num10 < Num7 && Num10 < Num8 && Num10 < Num9)
                {
                    Console.WriteLine("(D) El numero mas pequeño de los numeros leidos es el: " + Num10);
                }
            }
        }
        static void Main(string[] args)
        {
            Numeros_10 ObjNUM = new Numeros_10();
            ObjNUM.SUMA();
            Numeros_10 ObjNUMP = new Numeros_10();
            ObjNUM.PROMEDIO();
            Numeros_10 ObjNUMM = new Numeros_10();
            ObjNUM.Numero_Mas_Grande();
            Numeros_10 ObjNUMMENOR = new Numeros_10();
            ObjNUM.Numero_Menor();
        }
    }
}

