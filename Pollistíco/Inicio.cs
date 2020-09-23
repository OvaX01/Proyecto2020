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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            IniciarSesion ventana_is = new IniciarSesion();
            ventana_is.Show();
            
            this.Hide(); 

        }

     //estas lineas de codigo  llaman a la ventana iniciar sesion para justamente llevarme a la ventana de iniciar sesion de paso 
     //cerrando la ventana anterior con el objetivo de que no se pierda rendimiento manteniendo una ventana abierta que no esta siendo usada
     
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            Registrarse ventana_reg = new Registrarse();
            ventana_reg.Show();
            this.Hide();
        }
    }
}
