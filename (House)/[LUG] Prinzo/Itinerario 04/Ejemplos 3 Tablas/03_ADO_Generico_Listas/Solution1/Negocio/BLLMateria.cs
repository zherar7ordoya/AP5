using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocio
{
  public  class BLLMateria
    {

        #region "Propiedades"
        //propiedades de Materia

        public int Codigo { get; set; }
        public string Materia{ get; set; }


        #endregion

        //Metodos de la clase Materia

        #region "Metodos"

        public override string ToString()
        {
            return Codigo + " " + Materia;
        }

        public List<BLLMateria> CargarListaMateria()
        {  //Declaro el objeto datatable para guardar los datos y luego pasarlos a lista
            DataTable Tabla;
            Acceso oDatos = new Acceso();
            Tabla = oDatos.Leer("Select Codigo,Nombre From Materia");
            List<BLLMateria> ListaMateria = new List<BLLMateria>();

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BLLMateria oBLLMat = new BLLMateria();
                    oBLLMat.Codigo = Convert.ToInt32(fila[0]);
                    oBLLMat.Materia = fila["Nombre"].ToString();
                    ListaMateria.Add(oBLLMat);
                }
            }
            else
            { ListaMateria = null; }
            return ListaMateria;
        }


        //Metodo generico para alta y modificacion depende la operacion y consulta

        Acceso oDatos;
        public bool Guardar(BLLMateria oBLLMat)
        {
            string Consulta_SQL;
            if (oBLLMat.Codigo != 0)
            {
                Consulta_SQL = "update Materia SET Nombre = '" + oBLLMat.Materia + "' where Codigo = " + oBLLMat.Codigo + ""; 
            }
            else
            { 
                Consulta_SQL = "Insert into Materia (Nombre)values('" + oBLLMat.Materia + "')";  
            }
           //instancio un objeto de la clase datos para operar con la BD
            oDatos = new Acceso();
            return oDatos.Escribir(Consulta_SQL);
        }

        public bool Baja(BLLMateria oBLLMat)

        {
            if (Existe_Materia_Asociada(oBLLMat) == false)
            {
                string Consulta_SQL = "DELETE FROM Materia where Codigo = " + oBLLMat.Codigo + "";
                oDatos = new Acceso();
                return oDatos.Escribir(Consulta_SQL);
            }
            else
            { return false; }
        }
                      

            //busco si existe alguna materia asociada a 1 o varios alumnos
            public bool Existe_Materia_Asociada(BLLMateria oBLLMat)
            {  //instancio un objeto de la clase datos para operar con la BD
                oDatos = new Acceso();
                return oDatos.LeerScalar("select count(CodMat) from Alumno_Materia where CodMat =" + oBLLMat.Codigo + "");

            }

        }
    
    #endregion
    
}

