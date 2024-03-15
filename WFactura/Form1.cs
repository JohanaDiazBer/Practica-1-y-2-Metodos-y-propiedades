using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace WFactura
{
    public partial class frmGestionFacturas : Form
    {
        private clsFactura factura;
        private bool estado = false;
        public frmGestionFacturas()
        {
            InitializeComponent();
            factura = new clsFactura();
        }

        private void frmGestionFacturas_Load(object sender, EventArgs e)
        {//Se inicializa el ComboBox
           

            //Se carga la fecha al formulario
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Se obienen los valores del formulario
            string articulo = cmbArticulo.SelectedItem.ToString();
            int cantidad = int.Parse(txtCantidad.Text);
            double precio = double.Parse(txtPrecio.Text);

            //Se agregan los elemento a la factura
            factura.AgregarElemento(articulo, cantidad, precio);

            //Se muestran los elementos en el ListBox
            lstElementos.Items.Add($"{cantidad} x {articulo} - ${precio * cantidad}");

            //Se limpian los campos de entrada
            //cmbArticulo.SelectedIndex = -1;
            txtCantidad.Clear();
            txtPrecio.Clear();

            //e calcula y se muestra el total
            CalcularTotal();
        }


        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            //Se muestra el total en el campo correspondiente
            txtTotal.Text = factura.CalcularTotal().ToString("C");

            //Se muestra el mensaje por pantalla
            MessageBox.Show("¡Factura generada correctamente!");
        }

        private void CalcularTotal()
        {
            double total = factura.CalcularTotal();
            txtTotal.Text = total.ToString("C");
        }

        private void cmbArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string articuloSeleccionado = cmbArticulo.SelectedItem.ToString();
            MessageBox.Show($"Artículo seleccionado: {articuloSeleccionado}");
        }

        private void cmbArticulo_Click(object sender, EventArgs e)
        {
            if(!estado)
            {
                cmbArticulo.Items.AddRange(new string[]
                {
                "Tijeras", "Lapiz", "Block", "Lapiceros", "Cuadernos",
                "Agendas", "Bolsos", "Borrador", "Taja lapiz", "Colbon", "Silicona"
                });
                estado = true;
            }
            
        }
    }
}

