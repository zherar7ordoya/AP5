using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_XML
{
   public class Juego
    {
        public int IdJuego { get; set; }
        public String NombreJuego { get; set; }
        public String GeneroJuego { get; set; }
        public String PlataformaJuego { get; set; }
        public String CompaniaCreadora { get; set; }
        
        public override String ToString()
        {
            return "Juego\n ID= " + IdJuego + "\n Nombre=" + NombreJuego +
                "\n Genero= " + GeneroJuego +
                "\n Plataforma= " + PlataformaJuego +
                "\n Compañia= " + CompaniaCreadora + "\r\n";
        }



    }
}
