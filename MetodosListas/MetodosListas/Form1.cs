using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodosListas
{
    public partial class Form1 : Form
    {
        // Lista para almacenar elementos
        private List<string> elementos = new List<string>();

        public Form1()
        {
            InitializeComponent();
            ConfigurarInterfaz();
        }

        private void ConfigurarInterfaz()
        {
            // Configuración básica del formulario
            this.Text = "Gestión de Elementos";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(350, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Configuración de controles
            txtElemento.Location = new Point(20, 50);
            txtElemento.Width = 200;

            lstElementos.Location = new Point(20, 80);
            lstElementos.Width = 200;
            lstElementos.Height = 120;

            btnAgregar.Location = new Point(230, 50);
            btnAgregar.Text = "Agregar";
            btnAgregar.Width = 80;

            btnEliminar.Location = new Point(230, 80);
            btnEliminar.Text = "Eliminar";
            btnEliminar.Width = 80;

            // Etiqueta de título
            Label lblTitulo = new Label();
            lblTitulo.Text = "Lista de Elementos";
            lblTitulo.Font = new Font("Arial", 12, FontStyle.Bold);
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.AutoSize = true;
            this.Controls.Add(lblTitulo);
        }

        // Método para agregar elementos
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nuevoElemento = txtElemento.Text;

            if (!string.IsNullOrWhiteSpace(nuevoElemento))
            {
                elementos.Add(nuevoElemento);
                ActualizarLista();
                txtElemento.Clear();
                txtElemento.Focus();
            }
            else
            {
                MessageBox.Show("Por favor ingresa un elemento válido.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método para eliminar elementos seleccionados
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstElementos.SelectedItem != null)
            {
                elementos.Remove(lstElementos.SelectedItem.ToString());
                ActualizarLista();
            }
            else
            {
                MessageBox.Show("Selecciona un elemento para eliminar.", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método para actualizar ListBox
        private void ActualizarLista()
        {
            lstElementos.DataSource = null;
            lstElementos.DataSource = elementos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}