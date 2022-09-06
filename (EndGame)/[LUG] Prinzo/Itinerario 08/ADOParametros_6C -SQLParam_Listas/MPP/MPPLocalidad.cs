using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Data;
using System.Data.SqlClient;
using Abstraccion;


namespace MPP
{
    public class MPPLocalidad : IGestor<BELocalidad>
    {
        DatosParametros oDatos;

        //intancio el objeto oDatos en el constructor del Mapper
        public MPPLocalidad()
        {  oDatos = new DatosParametros();
        }



    public List<BELocalidad> ListarTodo()      
           {
            
            List<BELocalidad> listlocalidades = new List<BELocalidad>();
            DataTable Dt = oDatos.Leer("s_Localidad_ListarT", null);


            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow Item in Dt.Rows)
                {
                    BELocalidad oLoca = new BELocalidad();
                    oLoca.Id = Convert.ToInt32(Item[0]);
                    oLoca.Descripcion = Item[1].ToString();
                    listlocalidades.Add(oLoca);
                }
                return listlocalidades;
            }
            else
            {
                return null;
            }
        }


        //defino LA LISTA DE SQLPARAMETER
        List<SqlParameter> LP;
        public bool Baja(BELocalidad oBELoc)
        {
            if (Existe_Localidad_Asociada(oBELoc) == false)
            {
                //como esta definido fuera de un bloque el AL uso el mismo que defini en Existe_Localidad_Asociada
                return oDatos.Escribir("s_Localidad_Borrar", LP);
            }
            else
            { return false; }
        }


        //busco si existe alguna localidad asociada a un cliente
        public bool Existe_Localidad_Asociada(BELocalidad oBELoc)
        {  //instancio LA lista para pasar los parametros
           
            LP = new List<SqlParameter>();
          
            SqlParameter Param1 = new SqlParameter("@IdLoc", oBELoc.Id);
           LP.Add(Param1);
          
            return oDatos.LeerScalar("s_Localidad_Asociada",LP);

          
        }

        public bool Guardar(BELocalidad Objeto)
        {
            throw new NotImplementedException();
        }

        public BELocalidad ListarObjeto(BELocalidad Objeto)
        {
            throw new NotImplementedException();
        }

    }
  }


