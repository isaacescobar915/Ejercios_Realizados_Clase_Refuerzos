using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoExcepciones
{
    public partial class Form1 : Form

    {

        public Form1()

        {

            InitializeComponent();
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);

            ConfigurarInterfaz();
        }

        private void ConfigurarInterfaz()
        {
            // Configuración básica del formulario
            this.Text = "Manejo de Excepciones";
            this.ClientSize = new Size(400, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;


            // Label


            lblResultado.Location = new Point(100, 160);
            lblResultado.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblResultado.Size = new Size(300, 30);
         
        }

        private void btnDividir_Click(object sender, EventArgs e)

        {

            try

            {

                int numero1 = int.Parse(txtNumero1.Text);

                int numero2 = int.Parse(txtNumero2.Text);



                int resultado = numero1 / numero2;



                lblResultado.Text = $"Resultado: {resultado}";

            }

            catch (FormatException)

            {

                MessageBox.Show("Por favor, introduce números válidos.", "Error de Formato",

                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            catch (DivideByZeroException)

            {

                MessageBox.Show("No es posible dividir entre cero.", "División por cero",

                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch (Exception ex)

            {

                MessageBox.Show($"Error inesperado: {ex.Message}", "Error",

                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally

            {

                txtNumero1.Clear();

                txtNumero2.Clear();

                txtNumero1.Focus();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }

}