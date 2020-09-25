using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pollistíco
{
    class Usuario
    {
        private string correo = "" ;
        private Perfil perfil = null ;
        private string hash = "";
        private string sal = "";

        public string Correo { get => correo; set => correo = value; }
        public Perfil Perfil { get => perfil; set => perfil = value; }
        public string Hash { get => hash; set => hash = value; }
        public string Sal { get => sal; set => sal = value; }


        public Partida CrearPartida()
        {
            Partida partida = new Partida();

            return partida ;
        }



    }
}
