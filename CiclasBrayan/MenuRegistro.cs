using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class MenuRegistro : Form
    {
        public MenuRegistro()
        {
            InitializeComponent();
        }

        private void BtRegistrarse_Click(object sender, EventArgs e)
        {
            Registro fr = new Registro();
            fr.ShowDialog();
        }

        private void BtVerRegistrador_Click(object sender, EventArgs e)
        {
            VerClientes fr = new VerClientes();
            fr.ShowDialog();
        }

        private void MenuRegistro_Load(object sender, EventArgs e)
        {

        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            Login fr = new Login();
            fr.ShowDialog();
        }
    }
}
