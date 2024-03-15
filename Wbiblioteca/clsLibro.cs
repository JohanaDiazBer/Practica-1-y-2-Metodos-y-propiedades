using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wbiblioteca
{
    //internal class clsLibro
    public class clsLibro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int FechaPublicacion { get; set; }
        public bool Prestado { get; private set; }

        public clsLibro(string titulo, string autor, int fechaPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            FechaPublicacion = fechaPublicacion;
            Prestado = false;
        }

        public void PrestarLibro()
        {
            Prestado = true;
        }

        public void DevolverLibro()
        {
            Prestado = true;
        }

        public override string ToString()
        {
            return $"{Titulo} - {Autor} ({FechaPublicacion})";
        }
    }
}

