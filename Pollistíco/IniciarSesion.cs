using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pollistíco
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void LinkRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrarse ventana_reg = new Registrarse();

            ventana_reg.Show();
            this.Hide();

        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
