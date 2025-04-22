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
using Modelo;
using Modelo.Entity;

namespace Principal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtIniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = Correo.Text;
            string contraseña = Contraseña.Text;

            ClienteController controller = new ClienteController();
            ClienteEntity cliente = controller.IniciarSesion(correo, contraseña);

            if (cliente != null)
            {
                // Verificamos si el usuario está verificado en la base de datos
                BaseDeDatos db = new BaseDeDatos();
                bool estaVerificado = db.UsuarioEstaVerificado(correo);

                if (estaVerificado)
                {
                    MessageBox.Show("¡Bienvenido, " + cliente.nombre + "!");
                    // Redirigir a la aplicación principal
                }
                else
                {
                    MessageBox.Show("Tu cuenta aún no está verificada. Revisa tu correo.");
                }
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
