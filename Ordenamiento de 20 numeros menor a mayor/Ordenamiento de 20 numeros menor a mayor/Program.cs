using System;

namespace Ordenamiento_de_20_numeros_menor_a_mayor
{
    class Program
    {
        class menor_a_mayor
        {
            int Num1, Num2, Num3, Num4, Num5, Num6, Num7, Num8, Num9, Num10, Num11, Num12, Num13, Num14, Num15, Num16, Num17, Num18, Num19, Num20;

            public void Menor_a_Mayor()
            {
                Console.WriteLine("introduce el numero 1: ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 2: ");
                Num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 3: ");
                Num3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 4: ");
                Num4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 5: ");
                Num5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 6: ");
                Num6 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 7: ");
                Num7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 8: ");
                Num8 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 9: ");
                Num9 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 10: ");
                Num10 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 11: ");
                Num11 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 12: ");
                Num12 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 13: ");
                Num13 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 14: ");
                Num14 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 15: ");
                Num15 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 16: ");
                Num16 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 17: ");
                Num17 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 18: ");
                Num18 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 19: ");
                Num19 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("introduce el numero 20: ");
                Num20 = Convert.ToInt32(Console.ReadLine());
                //En esta parte se acomodan los numeros de menor a mayor 
                int[] Numeros = { Num1, Num2, Num4, Num5, Num6, Num7, Num8, Num9, Num10, Num3, Num11, Num12, Num14, Num15, Num16, Num17, Num18, Num19, Num20, Num13 };
                Array.Reverse(Numeros);             
                Array.Sort(Numeros);
                Console.WriteLine("Aqui estan Ordenados de menor a mayor: ");
                //se imprime en pantalla el arreglo con un ciclo for
                for (int i = 0; i < Numeros.Length; i++)
                {
                    Console.WriteLine("Numero: " + Numeros[i].ToString());
                }
                Console.ReadLine();//sedetiene pantalla
            }
        }
        static void Main(string[] args)
        {
            menor_a_mayor OBJMenorMayor = new menor_a_mayor();
            OBJMenorMayor.Menor_a_Mayor();
        }
    }
}
