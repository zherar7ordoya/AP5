﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Captura
{
    public class Ciervo : Animal, IAlimento, IHerbivoro
    {
        public override string Nombre { get; }
        public override string FechaInstancia { get; }
        public override string HoraInstancia { get; }
        public override List<IAlimento> ListaAlimentos { get; set; }

        public Ciervo(string nombre)
        {
            Nombre = $"Ciervo {nombre}";
            FechaInstancia = Herramientas.GetFecha();
            HoraInstancia = Herramientas.GetHora();
        }

        public override void Comer(IAlimento alimento)
        {
            throw new NotImplementedException();
        }
    }
}