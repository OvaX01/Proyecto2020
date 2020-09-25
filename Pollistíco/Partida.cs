using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pollistíco
{
   public class Partida
    {
        private List<Jugada> jugadas = new List<Jugada>();

       public List<Jugada> Jugadas { get => jugadas; set => jugadas = value; }
    
    public void AgregarJugada (Jugada jugada)
        {
            jugadas.Add(jugada);


        }


    }
}
