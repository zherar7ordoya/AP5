using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

public class Telefono : ICloneable, IID
{
    public int Id { get; set; }
    public string Numero { get; set; }

    public Telefono()
    {
    }
    public Telefono(int QueId, string QueNumero)
    {
        this.Id = QueId;
        this.Numero = QueNumero;
    }
    public object Clone()
    {
        return this.MemberwiseClone();
    }



    public int RetornaId()
    {
        return this.Id;
    }
}
