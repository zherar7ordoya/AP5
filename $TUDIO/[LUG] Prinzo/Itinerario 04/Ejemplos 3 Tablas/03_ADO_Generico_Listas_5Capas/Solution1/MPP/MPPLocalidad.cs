using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BE;
using DAL;

namespace MPP
{
    public class MPPLocalidad
    {
        #region "Metodos Localidad BLL"
        Acceso oDatos;
        public List<BELocalidad> CargarListaLocalidades()
        {  //Declaro el objeto datatable para guardar los datos y luego pasarlos a lista
            DataTable Tabla;
            oDatos = new Acceso();
            Tabla = oDatos.Leer("Select Codigo,Nombre From Localidad");
            List<BELocalidad> ListaLocalidad = new List<BELocalidad>();

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BELocalidad oBELoc = new BELocalidad();
                    oBELoc.Codigo = Convert.ToInt32(fila[0]);
                    oBELoc.Localidad = fila["Nombre"].ToString();
                    ListaLocalidad.Add(oBELoc);
                }
            }
            else
            { ListaLocalidad = null; }
            return ListaLocalidad;
        }

        //busco si existe alguna localidad asociada a un alumno
        public bool Existe_Localidad_Asociada(BELocalidad oBELoc)
        {  //instancio un objeto de la clase datos para operar con la BD
            oDatos = new Acceso();
            return oDatos.LeerScalar("select count(CodLocalidad) from Alumno where CodLocalidad =" + oBELoc.Codigo + "");

        }

        //Metodo para guardar si es alta o modificacion
        public bool Guardar(BELocalidad oBELocalidad)
        {
            string Consulta_SQL;
            if (oBELocalidad.Codigo != 0)
            { Consulta_SQL = "update Localidad SET Nombre = '" + oBELocalidad.Localidad + "' where Codigo = " + oBELocalidad.Codigo + ""; }
            else
            { Consulta_SQL = "Insert into Localidad (Nombre)values('" + oBELocalidad.Localidad + "')"; }

            //instancio un objeto de la clase datos para operar con la BD
            oDatos = new Acceso();
            return oDatos.Escribir(Consulta_SQL);
        }
        public bool Baja(BELocalidad oBELocalidad)
        {
            if (Existe_Localidad_Asociada(oBELocalidad) == false)
            {
                string Consulta_SQL;
                Consulta_SQL = "DELETE FROM Localidad where Codigo = " + oBELocalidad.Codigo + "";
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
