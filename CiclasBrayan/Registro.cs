using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Principal
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void BtGuardarCliente_Click(object sender, EventArgs e)
        {
            string nombre = NombreCliente.Text;
            string correo = CorreoCliente.Text;
            string contraseña = ContraseñaCliente.Text;
            string codigoVerificacion = GenerarCodigoVerificacion(); // algún método que tengas
            bool verificado = false;

            ClienteController controller = new ClienteController();
            int resultado = controller.GuardarCliente(nombre, correo, contraseña, verificado, codigoVerificacion);

            if (resultado > 0)
            {
                MessageBox.Show("Registro exitoso. Revisa tu correo para verificar tu cuenta.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir formulario de verificación
                Verificasion verificarForm = new Verificasion (correo); // pásale el correo si es necesario
                verificarForm.Show();

                this.Close(); // cerrar el formulario de registro
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para generar un código aleatorio
        private string GenerarCodigoVerificacion()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString(); // Ej: 6 dígitos
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
