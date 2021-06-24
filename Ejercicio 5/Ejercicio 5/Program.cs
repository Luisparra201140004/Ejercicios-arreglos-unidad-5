using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("Taller mecanico con capacidad de 7 autos");         
            Taller_Mecanico taller = new Taller_Mecanico(7);
            Console.WriteLine(taller.EspacioDisponible());    
            Console.WriteLine("Espacios disponibles en total 7");
            Console.WriteLine("Para salir del programa inserte la letra C");
            char ans; char salir = 'f';
            while (salir != 'C')
            {
                Console.WriteLine("¿Seleccione lo que desea realizar?");
                Console.WriteLine("A) Meter un auto al taller \nB) sacar un auto del taller \n"); Console.WriteLine("Puede seleccionar una opcion por favor: ");
                ans = char.ToUpper(Convert.ToChar(Console.ReadLine()));
               
                Console.Clear(); switch (ans)
                {
                    case 'A':
                        {
                            Console.WriteLine("Usted a seleccionado para meter un nuevo auto");
                            Console.Write("Por favor introduce las placas del auto: "); Console.ForegroundColor = ConsoleColor.White; string placa = Convert.ToString(Console.ReadLine());
                            Console.Write("Favor de introducir el nombre del dueño del auto: "); Console.ForegroundColor = ConsoleColor.White; string nombre = Convert.ToString(Console.ReadLine());
                            if (taller.Meter_Auto(placa, nombre) == false)
                            {
                                Console.WriteLine("El taller esta lleno");
                                Console.ReadKey();
                            }
                            Console.Clear();
                            Console.WriteLine("La tabla ha actualizado nuevos registros");
                            Console.WriteLine(taller.EspacioDisponible());
                            Console.ReadKey(); break;
                        }
                    case 'B':
                        {
                            Console.WriteLine("Usted a entrado a la seccion de sacar un veiculo"); if (taller.Sacar_Carro() == false)
                            {
                                Console.WriteLine("El taller esta vacio");
                                Console.ReadKey();
                            }
                            Console.WriteLine("Datos del taller actualizados"); Console.WriteLine(taller.EspacioDisponible());
                            Console.ReadKey(); break;
                        }
                }
                Console.Clear();
                Console.WriteLine("Si decea salir del programa seleccione la letra C, si decea continuar introdusca la letra n");
                salir = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                Console.Clear();
            }
        }
    }
}
