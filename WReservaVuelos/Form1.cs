using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WReservaVuelos
{
    public partial class frmReservaVuelos : Form
    {
        private clsReserva vueloActual;

        public frmReservaVuelos()
        {
            InitializeComponent();

            //Se creo una instancia de la clase clsReserva con ciudades diferentes ciudades y fechas
            vueloActual = new clsReserva("Bogotá", "Medellín", DateTime.Now.AddDays(10), 50, 20, 10);

            //Se agregan las ciudades al ComboBox
            ActualizarCiudades();

            //Se agregan fechas al ComboBox
            ActualizarFechas();

            //Se selecciona la primera ciudad y fecha por defecto
            cmbCiudadOrigen.SelectedIndex = 0;

            //Para el destino se selecciona la segunda ciudad por defecto
            cmbCiudadDestino.SelectedIndex = 1; 
            cmbFecha.SelectedIndex = 0;

            //Se agregan clases al ComboBox
            ActualizarClases();

            //Se selecciona la primera clase por defecto
            if (cmbClase.Items.Count > 0)
            {
                cmbClase.SelectedIndex = 0;
            }

            //Se actualiza la informacion del vuelo
            ActualizarInformacionVuelo();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            //Se obtiebe origen, destino, fecha y clase seleccionada
            string ciudadOrigen = cmbCiudadOrigen.SelectedItem.ToString();
            string ciudadDestino = cmbCiudadDestino.SelectedItem.ToString();
            DateTime fechaSalida = (DateTime)cmbFecha.SelectedItem;

            //Se verifica si hay elementos seleccionados 
            if (cmbClase.SelectedItem != null)
            {
                string claseSeleccionada = cmbClase.SelectedItem.ToString().ToLower();
                int cantidadReservas = Convert.ToInt32(numCantidad.Value);

                //Se realiza la reserva
                vueloActual.ReservarAsientos(claseSeleccionada, cantidadReservas);

                //Se muestra sms con la reserva generada
                string mensajeReserva = $"Reserva exitosa de {cantidadReservas} asientos en clase {claseSeleccionada} " +
                                        $"de {ciudadOrigen} a {ciudadDestino} para la fecha {fechaSalida.ToShortDateString()}.";
                MessageBox.Show(mensajeReserva, "Reserva Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Se actaliza la informacion despues de realizada la reserva
                ActualizarInformacionVuelo();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una clase antes de realizar la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarInformacionVuelo()
        {
            vueloActual.MostrarInformacionVuelo();
            lblInfoAsientos.Text = $"Asientos disponibles - Económica: {vueloActual.AsientosEconomicosDisponibles}, " +
                                   $"Ejecutiva: {vueloActual.AsientosEjecutivosDisponibles}, " +
                                   $"VIP: {vueloActual.AsientosVIPDisponibles}";
        }

        private void ActualizarCiudades()
        {
            //Ciudades de orige y destino
            cmbCiudadOrigen.Items.Add("Bogotá");
            cmbCiudadOrigen.Items.Add("Medellín");
            cmbCiudadOrigen.Items.Add("Cali");
            cmbCiudadOrigen.Items.Add("Cartagena");
            cmbCiudadOrigen.Items.Add("Santa Marta");
            cmbCiudadOrigen.Items.Add("Valledupar");
            cmbCiudadOrigen.Items.Add("Bucaramanga");
            cmbCiudadOrigen.Items.Add("Córdoba");
            cmbCiudadOrigen.Items.Add("Barranquilla");

            //Se selecciona la primera ciudad por defecto
            cmbCiudadOrigen.SelectedIndex = 0;

            //Se clonan las ciudades para el ComboBox de destino
            foreach (var ciudad in cmbCiudadOrigen.Items)
            {
                cmbCiudadDestino.Items.Add(ciudad);
            }

            //Segunda ciudad por defecto para destino
            cmbCiudadDestino.SelectedIndex = 1;
        }

        private void ActualizarFechas()
        {
            //Se agregan diferentes fechas 
            DateTime fechaActual = DateTime.Now.Date;
            for (int i = 0; i < 8; i++)
            {
                cmbFecha.Items.Add(fechaActual.AddDays(i));
            }

            //Se selecciona la primera fecha por defecto
            cmbFecha.SelectedIndex = 0;
        }

        private void ActualizarClases()
        {
            //Se agregan las clases Economica, Ejecutiva y VIP
            cmbClase.Items.Add("Economica");
            cmbClase.Items.Add("Ejecutiva");
            cmbClase.Items.Add("VIP");
        }

        private void cmbCiudadOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se actualiza  la informacion del vuelo cuando se selecciona un origen diferente
            vueloActual = ObtenerVueloPorCiudad(cmbCiudadOrigen.SelectedItem.ToString());
            ActualizarInformacionVuelo();
        }

        private void cmbCiudadDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se actualiza la informacion del vuelo cuando se selecciona un destino diferente
            vueloActual = ObtenerVueloPorCiudad(cmbCiudadDestino.SelectedItem.ToString());
            ActualizarInformacionVuelo();
        }

        private clsReserva ObtenerVueloPorCiudad(string ciudad)
        {
            // Metodo para el vuelo segun la ciudad seleccionada
            //Se creo un nuevo vuelo con ciudades y fechas diferentes
            DateTime fechaSalida = DateTime.Now.AddDays(10);
            int asientosEconomicos = 50;
            int asientosEjecutivos = 20;
            int asientosVIP = 10;

            return new clsReserva(ciudad, "Destino Dummy", fechaSalida, asientosEconomicos, asientosEjecutivos, asientosVIP);
        }
    }
}






