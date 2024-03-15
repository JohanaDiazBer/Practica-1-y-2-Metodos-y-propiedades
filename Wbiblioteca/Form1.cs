using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Wbiblioteca
{
    public partial class frmBiblioteca : Form
    {
        private List<clsLibro> libros = new List<clsLibro>();

        public frmBiblioteca()
        {
            InitializeComponent();

            //Asigne una lista de 8 libros
            libros.Add(new clsLibro("El señor de los anillos", "J.R.R. Tolkien", 1954));
            libros.Add(new clsLibro("Cien años de soledad", "Gabriel Garcia Marquez", 1967));
            libros.Add(new clsLibro("Harry Potter y la piedra filosofal", "J.K. Rowling", 1997));
            libros.Add(new clsLibro("Don Quijote de la Mancha", "Miguel de Cervantes", 1605));
            libros.Add(new clsLibro("Orgullo y prejuicio", "Jane Austen", 1813));
            libros.Add(new clsLibro("Matar a un ruiseñor", "Harper Lee", 1960));
            libros.Add(new clsLibro("Crimen y castigo", "Fyodor Dostoevsky", 1866));
            libros.Add(new clsLibro("El gran Gatsby", "F. Scott Fitzgerald", 1925));

            //Se configura el ListBox
            ActualizarListBox();

            //Este es un evento de seleccion 
            lstLibros.SelectedIndexChanged += lstLibros_SelectedIndexChanged;
        }

        private void ActualizarListBox()
        {
            //Se limpia y se agregan los titulos de los libros
            lstLibros.Items.Clear();
            foreach (var libro in libros)
            {
                lstLibros.Items.Add(libro.Titulo);
            }
        }

        private void lstLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se habilitan o se deshabilitan los botones si hay o no un libro seleccionado
            btnPrestar.Enabled = lstLibros.SelectedIndex != -1;

            btnDevolver.Enabled = lstLibros.SelectedIndex != -1;
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            if (lstLibros.SelectedIndex != -1)
            {
                clsLibro libroSeleccionado = libros[lstLibros.SelectedIndex];
                if (!libroSeleccionado.Prestado)
                {
                    libroSeleccionado.PrestarLibro();
                    ActualizarListBox();
                    MessageBox.Show($"Libro prestado: {libroSeleccionado.Titulo}", "Informacion");
                }
                else
                {
                    MessageBox.Show("El libro ya esta prestado.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un libro para prestar.", "Error");
            }
        }


        private void btnDevolver_Click_1(object sender, EventArgs e)
        {
            if (lstLibros.SelectedIndex != -1)
            {
                clsLibro libroSeleccionado = libros[lstLibros.SelectedIndex];
                if (libroSeleccionado.Prestado)
                {
                    libroSeleccionado.DevolverLibro();
                    ActualizarListBox();
                    MessageBox.Show($"Libro devuelto: {libroSeleccionado.Titulo}", "Informacion");
                }
                else
                {
                    MessageBox.Show("El libro no esta prestado.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un libro para devolver.", "Error");
            }
        }
    }
}

