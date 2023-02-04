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

public class ClienteDatos : ABMC_Interfaces.IABMC<Cliente>
{
    private TelefonoDatos VtelefonoDatos = new TelefonoDatos();

    public void Alta(ref Cliente QueObjeto = null/* TODO Change to default(_) if this is not a reference type */)
    {
        try
        {
            DataTable dt = Comando.ObjStructureTable("cliente");
            DataRow dr = dt.NewRow;

            {
                var withBlock = QueObjeto;
                dr.ItemArray =
                {
                    withBlock.Id,
                    withBlock.Nombre,
                    withBlock.FechaAlta,
                    withBlock.Activo
                };

                dt.Rows.Add(dr);
                Comando.ActualizaBase("cliente", dt);

                if (withBlock.Telefonos.Count > 0)
                {
                    VtelefonoDatos.ObjetoSolicitante = QueObjeto;

                    foreach (Telefono Tr in withBlock.Telefonos)
                        VtelefonoDatos.Alta(Tr);
                }
            }
        }
        catch (Exception ex)
        {
            Interaction.MsgBox("Error en el Alta");
        }
    }
}
