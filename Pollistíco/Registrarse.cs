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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void linkIniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IniciarSesion ventana_ins = new IniciarSesion();
            ventana_ins.Show();
            this.Hide();
        }
    }
}
