using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WReservaVuelos
{
    //La clase la llame clsReserva
    internal class clsReserva

    {
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public int AsientosEconomicosDisponibles { get; set; }
        public int AsientosEjecutivosDisponibles { get; set; }
        public int AsientosVIPDisponibles { get; set; }

        public clsReserva(string origen, string destino, DateTime fechaSalida, int asientosEconomicos, int asientosEjecutivos, int asientosVIP)
        {
            Origen = origen;
            Destino = destino;
            FechaSalida = fechaSalida;
            AsientosEconomicosDisponibles = asientosEconomicos;
            AsientosEjecutivosDisponibles = asientosEjecutivos;
            AsientosVIPDisponibles = asientosVIP;
        }

        public void ReservarAsientos(string clase, int cantidad)
        {
            switch (clase.ToLower())
            {
                case "economica":
                    if (AsientosEconomicosDisponibles >= cantidad)
                    {
                        AsientosEconomicosDisponibles -= cantidad;
                        Console.WriteLine($"Reserva exitosa: {cantidad} asientos en clase económica");
                    }
                    else
                    {
                        Console.WriteLine("No hay suficientes asientos disponibles en clase económica");
                    }
                    break;
                case "ejecutiva":
                    if (AsientosEjecutivosDisponibles >= cantidad)
                    {
                        AsientosEjecutivosDisponibles -= cantidad;
                        Console.WriteLine($"Reserva exitosa: {cantidad} asientos en clase ejecutiva");
                    }
                    else
                    {
                        Console.WriteLine("No hay suficientes asientos disponibles en clase ejecutiva");
                    }
                    break;
                case "vip":
                    if (AsientosVIPDisponibles >= cantidad)
                    {
                        AsientosVIPDisponibles -= cantidad;
                        Console.WriteLine($"Reserva exitosa: {cantidad} asientos en clase VIP");
                    }
                    else
                    {
                        Console.WriteLine("No hay suficientes asientos disponibles en clase VIP");
                    }
                    break;
                default:
                    Console.WriteLine("Clase de asiento no válida");
                    break;
            }
        }

        public void MostrarInformacionVuelo()
        {
            Console.WriteLine($"Origen: {Origen}");
            Console.WriteLine($"Destino: {Destino}");
            Console.WriteLine($"Fecha de salida: {FechaSalida}");
            Console.WriteLine($"Asientos disponibles - Económica: " +
                $"{AsientosEconomicosDisponibles}, Ejecutiva: {AsientosEjecutivosDisponibles}, " +
                $"VIP: {AsientosVIPDisponibles}");
        }
    }
}

