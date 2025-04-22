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
using Modelo.Entity;

namespace Principal
{
    public partial class VerClientes : Form
    {
        public VerClientes()
        {
            InitializeComponent();
        }

        private void BtVerClientes_Click(object sender, EventArgs e)
        {
            ClienteController controller = new ClienteController();
            List<ClienteEntity> todosLosUsuarios = controller.MostrarClientes();

            string texto = "";
            foreach (var cliente in todosLosUsuarios)
            {
                texto += cliente.nombre + "\n correo: ";
                texto += cliente.correo + "  nombre: ";
            }

            ClientesGuardados.Text = texto;

        }

        private void VerClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
