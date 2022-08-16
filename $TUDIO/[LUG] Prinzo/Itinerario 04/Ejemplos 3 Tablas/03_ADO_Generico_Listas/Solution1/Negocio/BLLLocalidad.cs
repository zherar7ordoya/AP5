using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//uso la libreria de system.Data, para instanciar Datatable
using System.Data;


namespace Negocio
{
   public class BLLLocalidad
    {

        #region "Propiedades"
        //propiedades de Localidad

        public int Codigo { get; set; }
        public string Localidad { get; set; }


        #endregion

        //Metodos de la clase Localidad

        #region "Metodos"

        public override string ToString()
        {
            return Codigo + " " + Localidad;
        }


        Acceso oDatos;
        public List<BLLLocalidad> CargarListaLocalidades()
        {  //Declaro el objeto datatable para guardar los datos y luego pasarlos a lista
            DataTable Tabla;
            oDatos = new Acceso();
            Tabla = oDatos.Leer("Select Codigo,Nombre From Localidad");
            List<BLLLocalidad> ListaLocalidad = new List<BLLLocalidad>();

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BLLLocalidad oBLLLoc = new BLLLocalidad();
                    oBLLLoc.Codigo = Convert.ToInt32(fila[0]);
                    oBLLLoc.Localidad = fila["Nombre"].ToString();
                    ListaLocalidad.Add(oBLLLoc);
                }
            }
            else
            { ListaLocalidad = null; }
            return ListaLocalidad;
        }

        //busco si existe alguna localidad asociada a un alumno
        public bool Existe_Localidad_Asociada(BLLLocalidad oBLLLoc)
        {  //instancio un objeto de la clase datos para operar con la BD
             oDatos = new Acceso();
            return  oDatos.LeerScalar("select count(CodLocalidad) from Alumno where CodLocalidad =" +oBLLLoc.Codigo+"");
       
        }

        //Metodo para guardar si es alta o modificacion
        public bool Guardar (BLLLocalidad oBLLLocalidad)
        {   
            string Consulta_SQL;
            if (oBLLLocalidad.Codigo != 0)
            { Consulta_SQL = "update Localidad SET Nombre = '" + oBLLLocalidad.Localidad + "' where Codigo = " + oBLLLocalidad.Codigo + ""; }
            else
            { Consulta_SQL = "Insert into Localidad (Nombre)values('" + oBLLLocalidad.Localidad + "')"; }
          
                      //instancio un objeto de la clase datos para operar con la BD
            oDatos = new Acceso();
            return oDatos.Escribir(Consulta_SQL);
        }
        public bool Baja(BLLLocalidad oBLLLocalidad)
        {
            if (Existe_Localidad_Asociada(oBLLLocalidad) == false)
            {
                string Consulta_SQL;
                Consulta_SQL = "DELETE FROM Localidad where Codigo = " + oBLLLocalidad.Codigo + "";
                //si lo escribe bien devuelve true
                oDatos = new Acceso();
                return oDatos.Escribir(Consulta_SQL);
            }
            else
            { return false; }

        }
      
        #endregion
    }
}
