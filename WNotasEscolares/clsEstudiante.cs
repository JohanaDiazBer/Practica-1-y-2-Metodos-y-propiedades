using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WNotasEscolares
{
    public class clsEstudiante
    {

        public string Nombre { get; set; }
        public int Matricula { get; set; }
        public List<double> Calificaciones { get; set; }

        public clsEstudiante(string nombre, int matricula)
        {
            Nombre = nombre;
            Matricula = matricula;
            Calificaciones = new List<double>();
        }

        public double CalcularPromedio()
        {
            if (Calificaciones.Count == 0)
                return 0;

            double sum = 0;
            foreach (double calificacion in Calificaciones)
            {
                sum += calificacion;
            }
            return sum / Calificaciones.Count;
        }

        public string MostrarHistorialCalificaciones()
        {
            string historial = "";
            foreach (double calificacion in Calificaciones)
            {
                historial += calificacion + "\n";
            }
            return historial;
        }
    }
}
