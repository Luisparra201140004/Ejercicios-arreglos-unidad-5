using System;

namespace Sala_de_juntas
{
    class Program
    {
        class Sala
        {
            double Opcion_menu;
            char Teclas;
            String Empresa1, Empresa2, Empresa3, Dia1, Dia2, Dia3, Hora1, Hora2, Hora3;
            string Respuesta, Respuesta2;
            public void Reunion()
            {
                do
                {
                    Console.Clear();
                    Console.SetCursorPosition(16, 1);
                    Console.WriteLine("     AGENDA DE CONFERENCIAS   ");
                    do
                    {
                        Console.SetCursorPosition(3, 2);
                        if (Opcion_menu == 1)
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sala: 1");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(30, 2);
                        if (Opcion_menu == 2)
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sala: 2");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(60, 2);
                        if (Opcion_menu == 3)
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Sala: 3");

                        Console.ForegroundColor = ConsoleColor.White;
                        Teclas = (char)Console.ReadKey().Key;
                        switch (Teclas)
                        {
                            case (char)ConsoleKey.LeftArrow:
                                if (Opcion_menu == 1) Opcion_menu = 3; else Opcion_menu--;
                                break;
                            case (char)ConsoleKey.RightArrow:
                                if (Opcion_menu == 3) Opcion_menu = 1; else Opcion_menu++;
                                break;
                        }
                    } while (Teclas != (char)ConsoleKey.Escape && Teclas != (char)ConsoleKey.Enter);
                    if (Teclas == (char)ConsoleKey.Escape)
                        Opcion_menu = 0;
                    Console.WriteLine("" + Opcion_menu);

                    if (Opcion_menu == 1)
                    {
                        Console.WriteLine("--> Vienvenido a la sala 1 <-- ");
                        Console.WriteLine("Ingrese el nombre de la empresa: ");
                        Empresa1 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Horario de la cita: ");
                        Hora1 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Dia de la cita: ");
                        Dia1 = Convert.ToString(Console.ReadLine());
                        if (Dia1 == "Domingo")
                        {
                            Console.WriteLine("En este horario no se puede agendar cita");
                        }
                        Console.WriteLine("Para saber su reporte de las citas introdusca -Reporte-");
                        Respuesta = Convert.ToString(Console.ReadLine());
                        if (Respuesta == "Reporte")
                        {
                            Console.WriteLine("____________________________________________________________________");
                            Console.WriteLine(" Sala 1 esta agendada");
                            Console.WriteLine("Nombre de empresa:" + Empresa1);
                            Console.WriteLine("Hora de su cita:" + Hora1);
                            Console.WriteLine("Dia para la sala:" + Dia1);
                            Console.WriteLine("____________________________________________________________________");
                        }
                        Console.WriteLine("¿Necesita crear otra agenda?");
                        Respuesta2 = Convert.ToString(Console.ReadLine());
                    }
                    else if (Opcion_menu == 2)
                    {
                        Console.WriteLine("--> Vienvenido a la sala 2 <--");
                        Console.WriteLine("Nombre de empresa: ");
                        Empresa2 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Hora de su cita: ");
                        Hora2 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Dia para la sala: ");
                        Dia2 = Convert.ToString(Console.ReadLine());
                        if (Dia2 == "Domingo")
                        {
                            Console.WriteLine("En este horario no se puede agendar cita");
                        }
                        Console.WriteLine("Para saber su reporte de las citas introdusca -Reporte-");
                        Respuesta = Convert.ToString(Console.ReadLine());
                        if (Respuesta == "Reporte")
                        {
                            Console.WriteLine("____________________________________________________________________");
                            Console.WriteLine(" Sala 2 esta agendada");
                            Console.WriteLine("Nombre de empresa:" + Empresa2);
                            Console.WriteLine("Hora de su cita:" + Hora2);
                            Console.WriteLine("Dia para la sala:" + Dia2);
                            Console.WriteLine("____________________________________________________________________");
                        }
                        Console.WriteLine("¿Necesita crear otra agenda?");
                        Respuesta2 = Convert.ToString(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("--> Vienvenido a la sala 3 <--");
                        Console.WriteLine("Nombre de empresa: ");
                        Empresa3 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Hora de su cita: ");
                        Hora3 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Dia para la sala: ");
                        Dia3 = Convert.ToString(Console.ReadLine());
                        if (Dia3 == "Domingo")
                        {
                            Console.WriteLine("En este horario no se puede agendar cita");
                        }
                        Console.WriteLine("Para saber su reporte de las citas introdusca -Reporte-");
                        Respuesta = Convert.ToString(Console.ReadLine());
                        if (Respuesta == "Reporte")
                        {
                            Console.WriteLine("____________________________________________________________________");
                            Console.WriteLine(" Sala 3 esta agendada");
                            Console.WriteLine("Nombre de empresa:" + Empresa3);
                            Console.WriteLine("Hora de su cita:" + Hora3);
                            Console.WriteLine("Dia para la sala:" + Dia3);
                            Console.WriteLine("____________________________________________________________________");
                        }
                        Console.WriteLine("¿Necesita crear otra agenda?");
                        Respuesta2 = Convert.ToString(Console.ReadLine());
                    }
                } while (Respuesta2 == "si");
            }
        }
        static void Main(string[] args)
        {
            Sala objreuniones = new Sala();
            objreuniones.Reunion();
        }
    }
}
