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
    public partial class Verificasion : Form
    {
        public Verificasion(string correo)
        {
            InitializeComponent();
        }

        private void BtVerificar_Click(object sender, EventArgs e)
        {
            string correo = CorreoV.Text;
            string codigo = CodigoV.Text;

            ClienteController controller = new ClienteController();
            bool verificado = controller.VerificarCodigo(correo, codigo);

            if (verificado)
            {
                MessageBox.Show("¡Correo verificado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir formulario de inicio de sesión
                Login loginForm = new Login();
                loginForm.Show();

                this.Hide(); // Oculta el formulario de verificación actual
            }
            else
            {
                MessageBox.Show("Código incorrecto o correo inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Verificasion_Load(object sender, EventArgs e)
        {

        }
    }
}
