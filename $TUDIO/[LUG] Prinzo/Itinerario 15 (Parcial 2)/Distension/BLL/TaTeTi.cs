using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaTeTi : Juego
    {
        public override int CalcularPuntaje(string estado)
        {
            switch (estado)
            {
                case "gana":
                    return 5;
                case "empata":
                    return 1;
                default:
                    return 0;
            }
        }
    }
}
