﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Todo
{
    public interface IMiInterface
    {
        int Numero { get; set; }
    
        string Apellido { get; set; }

        event EventHandler<MenordeEdadEventArgs> MenorDeEdad;

    }
}
