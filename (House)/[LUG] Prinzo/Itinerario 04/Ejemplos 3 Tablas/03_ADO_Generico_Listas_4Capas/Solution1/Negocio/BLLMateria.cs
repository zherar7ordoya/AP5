using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using BE;

namespace Negocio
{
  public  class BLLMateria
    {



        //Metodos de la clase Materia

        #region "Metodos"

     

        public List<BEMateria> CargarListaMateria()
        {  //Declaro el objeto datatable para guardar los datos y luego pasarlos a lista
            DataTable Tabla;
            Acceso oDatos = new Acceso();
            Tabla = oDatos.Leer("Select Codigo,Nombre From Materia");
            List<BEMateria> ListaMateria = new List<BEMateria>();

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEMateria oBEMat = new BEMateria();
                    oBEMat.Codigo = Convert.ToInt32(fila[0]);
                    oBEMat.Materia = fila["Nombre"].ToString();
                    ListaMateria.Add(oBEMat);
                }
            }
            else
            { ListaMateria = null; }
            return ListaMateria;
        }


        //Metodo generico para alta y modificacion depende la operacion y consulta

        Acceso oDatos;
        public bool Guardar(BEMateria oBEMat)
        {
            string Consulta_SQL;
            if (oBEMat.Codigo != 0)
            {
                Consulta_SQL = "update Materia SET Nombre = '" + oBEMat.Materia + "' where Codigo = " + oBEMat.Codigo + ""; 
            }
            else
            { 
                Consulta_SQL = "Insert into Materia (Nombre)values('" + oBEMat.Materia + "')";  
            }
           //instancio un objeto de la clase datos para operar con la BD
            oDatos = new Acceso();
            return oDatos.Escribir(Consulta_SQL);
        }

        public bool Baja(BEMateria oBEMat)

        {
            if (Existe_Materia_Asociada(oBEMat) == false)
            {
                string Consulta_SQL = "DELETE FROM Materia where Codigo = " + oBEMat.Codigo + "";
                oDatos = new Acceso();
                return oDatos.Escribir(Consulta_SQL);
            }
            else
            { return false; }
        }
                      

            //busco si existe alguna materia asociada a 1 o varios alumnos
            public bool Existe_Materia_Asociada(BEMateria oBEMat)
            {  //instancio un objeto de la clase datos para operar con la BD
                oDatos = new Acceso();
                return oDatos.LeerScalar("select count(CodMat) from Alumno_Materia where CodMat =" + oBEMat.Codigo + "");

            }

        }
    
    #endregion
    
}

