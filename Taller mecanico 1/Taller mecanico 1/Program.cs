using System;

namespace Taller_mecanico_1
{
    class Reparaciones
    {
        string Dueño, Respuesta1, Respuestas, Placas;
        int Capadidad_del_Taller, vacio;
        double tarifa, tarifa_Total;
        string[] Placas_del_Auto;
        string[] Nombre_del_Dueño;
        double[] Cobros_por_carro;
        public double Tarifa
        {
            get { return tarifa; }
            set { tarifa = value; }
        }
        public double TarifaTotal
        {
            get { return tarifa_Total; }
            set { tarifa_Total = value; }
        }
        public string DUEÑO
        {
            get { return Dueño; }
            set { Dueño = value; }
        }
        public string PLACAS
        {
            get { return Placas; }
            set { Placas = value; }
        }
        public string RESPUESTA1
        {
            get { return Respuesta1; }
            set { Respuesta1 = value; }
        }
        public string RespuestaS
        {
            get { return Respuestas; }
            set { Respuestas
                    = value; }
        }
        public int CapacidadTaller
        {
            get { return Capadidad_del_Taller; }
            set { Capadidad_del_Taller = value; }
        }
        public int Vacio
        {
            get { return vacio; }
            set { vacio = value; }
        }
        public void REGISTRO_PRINCIPAL()
        {
            //Aqui es donde se solicita al dueño del taller que infrese los datos del cohe ppara llevar un control
            Console.WriteLine("-----> Taller mecanico el guapo <-----");
   
            for (int i = 0; i < 5; i++)
            {
                tarifa_Total = -1;
                Console.WriteLine("_________________________________________________________");
                Console.Write("Por favor introduce el numero de placas: ");
                PLACAS = Console.ReadLine().ToString();
                Console.Write("Nombre del dueño del carro: ");
                DUEÑO = Console.ReadLine().ToString();
                Console.Write("Cobro por la reparacion: " + "$");
                Tarifa = double.Parse(Console.ReadLine());
                TarifaTotal = TarifaTotal + Tarifa;
                CapacidadTaller += 1;
                Vacio += 1;
            }
        }
        public void FINAL()
        {
            Console.WriteLine("Capacidad taller: " + CapacidadTaller);
            Console.WriteLine("El taller esta lleno y no puede meter otro carro. Espere su turno.......");
            do
            {
                Console.Write("¿Saldra un auto del taller? responder: si o no ");
                RESPUESTA1 = Console.ReadLine().ToLower();
                if (RESPUESTA1 == "si")
                {
                    Vacio -= 1;
                    TarifaTotal += Tarifa;
                    Console.Write("¿Ingreso un nuevo coche al taller? responder: si o no ");
                    RESPUESTA1 = Console.ReadLine().ToLower();
                    if (RESPUESTA1 == "si")
                    {
                        Console.WriteLine("_________________________________________________________");
                        Console.Write("Por favor introduce el numero de placas: ");
                        Placas = Console.ReadLine().ToString();
                        Console.Write("Nombre del dueño del carro: ");
                        DUEÑO = Console.ReadLine().ToString();
                        Console.Write("Cobro por la reparacion:  " + "$");
                        Tarifa = double.Parse(Console.ReadLine());
                        CapacidadTaller = CapacidadTaller + 1;
                        Vacio = Vacio + 1;
                        Console.WriteLine("---------->" + CapacidadTaller);
                        Console.WriteLine("---------->" + Vacio);
                    }
                    else
                    {
                        Console.WriteLine("Por favor espere su turno...");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Por favor espere su turno...");
                    Console.ReadLine();
                }

            } while (Vacio > 0);
        }
        public void INTRODUCIR_OTRO_AUTO()
        {
            Console.WriteLine("Numero total de autos atendidos en el dia: " + CapacidadTaller);
            Placas_del_Auto = new string[CapacidadTaller];
            Nombre_del_Dueño = new string[CapacidadTaller];
            Cobros_por_carro = new double[CapacidadTaller];
            for (int i = 0; i < CapacidadTaller; i++)
            {
                Placas_del_Auto[i] = PLACAS;
                Nombre_del_Dueño[i] = DUEÑO;
                Cobros_por_carro[i] = Tarifa;
            }
            Console.WriteLine("Ganancia total del dia: " + "$" + TarifaTotal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Reparaciones taller = new Reparaciones();

            taller.REGISTRO_PRINCIPAL();
            taller.FINAL();
            taller.INTRODUCIR_OTRO_AUTO();
        }
    }
}
