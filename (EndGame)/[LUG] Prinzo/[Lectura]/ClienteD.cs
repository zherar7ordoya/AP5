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

public class ClienteD : ABMC_Interfaces.IABMC<Cliente>
{
    private ClienteDatos VclienteDatos;

    public ClienteDatos ClienteDatos
    {
        get
        {
            return VclienteDatos;
        }

        set
        {
            VclienteDatos = value;
        }
    }



    public ClienteD()
    {
        this.ClienteDatos = new ClienteDatos();
    }

    public void Alta(ref Cliente QueObjeto = null/* TODO Change to default(_) if this is not a reference type */)
    {
        this.ClienteDatos.Alta(QueObjeto);
    }
}
