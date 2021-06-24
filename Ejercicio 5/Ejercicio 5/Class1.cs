using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    class Taller_Mecanico 
    {
         
        private string[,] carros;
        private List<string> Carros_Acumulados;
        private List<int> Monto;
        private int Indice;
        private int indiceS;
           
        public Taller_Mecanico(int n)
        {
            
            N = n;
            Carros = new string[N, 2];
            MONTO = new List<int>();
            CarrosAcumulados = new List<string>();
            IndiceS = 0;
            INDICE = 0;
            for (int rows = 0; rows < N; rows++)
            {
                for (int columns = 0; columns < 2; columns++)
                {
                    Carros[rows, columns] = " - ";
                }
            }
        }
        
        public Boolean Meter_Auto(string Placas, string Nombre_del_Dueño)
        {
            if (INDICE < N)
            {
                for (int i = 0; i < N; i++)
                {
                    if (Carros[i, 0] == " _ ")
                    {
                        INDICE = i; break;
                    }
                }
                Carros[INDICE, 0] = Placas;
                Carros[INDICE, 1] = Nombre_del_Dueño; string value = $"{Placas}, {Nombre_del_Dueño}";
                CarrosAcumulados.Add(value); return true;
            }
            return false;
        }
        public Boolean Sacar_Carro()
        {
            if (INDICE - 1 >= 0)
            {
                for (int i = 0; i < N; i++)
                {
                    if (Carros[i, 0] != " _ ")
                    {
                        Carros[i, 0] = Carros[i + 1, 0];
                        Carros[i, 1] = Carros[i + 1, 1];
                    }
                }
                Carros[N - 1, 0] = " - "; Carros[N - 1, 1] = " - "; return true;
            }
            return false;
        }
        public string EspacioDisponible()
        {
            String ans = "";
            for (int rows = 0; rows < N; rows++)
            {
                ans += carros[rows, 0] + " , "; ans += carros[rows, 1] + "\n";
            }
            return ans;
        }
        public void Cobrar(int monto)
        {
            MONTO.Add(monto);
        }
        public int[] GetMonto()
        {
            int[] Monto_A = MONTO.ToArray(); return Monto_A;
        }
        public string[] GetCarrosAcumulados()
        {
            string[] ACarrosAcumulados = CarrosAcumulados.ToArray(); return ACarrosAcumulados;
        }
            
        public string[,] Carros
        {
            get => carros; set => carros = value;
        }
        public int N
        {
            get;
        }
        public List<int> MONTO
        {
            get => Monto; set => Monto = value;
        }
        public int INDICE
        {
            get => Indice; set => Indice = value;
        }
        public List<string> CarrosAcumulados
        {
            get => Carros_Acumulados; set => Carros_Acumulados = value;
        }
        public int IndiceS { get => indiceS; set => indiceS = value; }

    }
}
