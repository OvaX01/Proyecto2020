using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pollistíco
{
    public class Perfil
    {

        private string nombre = "";
        private string apellido = "";
        private string nick = "";
        private int numPartidas = 0 ;

        public int NumPartidas { get => numPartidas; set => numPartidas = value; }
        public string Nick { get => nick; set => nick = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
