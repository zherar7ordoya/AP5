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

public class Cliente : ICloneable, ABMC_Interfaces.IID
{
    // Atributos y Propiedades
    private List<Telefono> vTelefonos = new List<Telefono>();
    public List<Telefono> Telefonos { get; set; }

    public int Id { get; set; }
    public string Nombre { get; set; }
    public DateTime FechaAlta { get; set; }
    public bool Activo { get; set; }

    // Clonación Profunda
    public object Clone()
    {
        Cliente RetornoCliente = (Cliente)this.MemberwiseClone();
        if (!this.Telefonos == null)
        {
            foreach (Telefono T in this.Telefonos)
                RetornoCliente.Telefonos.Add(T.Clone);
        }

        return RetornoCliente;
    }

    // Constructores
    public Cliente()
    {
    }

    public Cliente(int QueId, string QueNombre, DateTime QueFechaAlta, bool QueActivo)
    {
        this.Id = QueId;
        this.Nombre = QueNombre;
        this.FechaAlta = QueFechaAlta;
        this.Activo = QueActivo;
    }

    
    // Bueno, bueno, bueno...
    public int RetornaId()
    {
        return this.Id;
    }
}
