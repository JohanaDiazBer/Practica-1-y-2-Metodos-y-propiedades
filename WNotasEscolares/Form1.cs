using System;
using System.Windows.Forms;
using System.Collections.Generic;


namespace WNotasEscolares
{
    public partial class frmNotasEscolares : Form
    {
        List<clsEstudiante> estudiantes;
        public frmNotasEscolares()
        {
            InitializeComponent();
            estudiantes = new List<clsEstudiante>();

            //Nombres y matriculas para los 10 estudiantes
            string[] nombresEstudiantes = { "Juan Caceres Martinez", "Maria Lopez Lopez", "Lina Maria Diaz", 
                  "Luis Mario Perez", "Natalia Marin Rangel", "Patricia Hernandez", "Raquel Hernandez Diaz", 
                  "Luna Daza Daza", "Oscar Buitrago Moreno", "Yeison Sosa Toro" };

            //Se agregan matricula y nombre correspondiente a cada estudiante
            for (int i = 0; i < nombresEstudiantes.Length; i++)
            {
                estudiantes.Add(new clsEstudiante(nombresEstudiantes[i], i + 1));
                cmbNombre.Items.Add(nombresEstudiantes[i]);
            }
        }
        private void frmNotasEscolares_Load(object sender, EventArgs e)
        {

        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = cmbNombre.SelectedIndex;
            clsEstudiante estudianteSeleccionado = estudiantes[indiceSeleccionado];

            double calificacion;
            if (double.TryParse(txtCalificacion.Text, out calificacion))
            {
                estudianteSeleccionado.Calificaciones.Add(calificacion);
                MessageBox.Show("Calificación agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCalificacion.Clear();
            }
            else
            {
                MessageBox.Show("Favor ingresar una calificación válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = cmbNombre.SelectedIndex;
            clsEstudiante estudianteSeleccionado = estudiantes[indiceSeleccionado];
            txtMatricula.Text = estudianteSeleccionado.Matricula.ToString();
        }
        private void rbtHistorialCalificaciones_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtHistorialCalificaciones.Checked)
            {
                int indiceSeleccionado = cmbNombre.SelectedIndex;
                clsEstudiante estudianteSeleccionado = estudiantes[indiceSeleccionado];
                MessageBox.Show(estudianteSeleccionado.MostrarHistorialCalificaciones(), "Historial de Calificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rbtHistorialCalificaciones.Checked = false;
            }
        }
        private void rbtCalcularPromedio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCalcularPromedio.Checked)
            {
                int indiceSeleccionado = cmbNombre.SelectedIndex;
                clsEstudiante estudianteSeleccionado = estudiantes[indiceSeleccionado];
                MessageBox.Show("El promedio del estudiante es: " + estudianteSeleccionado.CalcularPromedio(), "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rbtCalcularPromedio.Checked = false;
            }
        }

        
    }
}




/**********************************************************************************************
****************************************************************************+++***************/



       

           

        

       

     

       

































