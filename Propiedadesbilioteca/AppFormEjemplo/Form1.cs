using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEjemplo;

namespace AppFormEjemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarInterfaz();
        }

        private void ConfigurarInterfaz()
        {
            // Configuración básica del formulario
            this.Text = "Gestión de Productos";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(400, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Configuración de controles
            lblNombre.Location = new Point(20, 20);
            lblNombre.Text = "Nombre:";
            lblNombre.AutoSize = true;

            txtNombre.Location = new Point(120, 20);
            txtNombre.Width = 200;

            lblPrecio.Location = new Point(20, 50);
            lblPrecio.Text = "Precio:";
            lblPrecio.AutoSize = true;

            txtPrecio.Location = new Point(120, 50);
            txtPrecio.Width = 100;

            btnMostrar.Location = new Point(120, 80);
            btnMostrar.Text = "Mostrar Producto";
            btnMostrar.Width = 200;
            btnMostrar.Click += btnMostrar_Click;

            lblResultado.Location = new Point(20, 120);
            lblResultado.AutoSize = false;
            lblResultado.Width = 350;
            lblResultado.Height = 80;
            lblResultado.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingresa un nombre válido.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Ingresa un precio válido (mayor que 0).", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Producto producto = new Producto
            {
                Nombre = txtNombre.Text.Trim(),
                Precio = precio
            };

            lblResultado.Text = producto.ObtenerDescripcion();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}