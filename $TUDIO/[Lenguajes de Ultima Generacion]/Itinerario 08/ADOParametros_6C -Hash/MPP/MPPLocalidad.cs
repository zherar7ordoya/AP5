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
using System.Collections;//para el arraylist

namespace MPP
{
    public class MPPLocalidad : IGestor<BELocalidad>
    {
        DatosHastable oDatos;

        public MPPLocalidad()
        {  oDatos = new DatosHastable();
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


        //defino el Hastable
        Hashtable Hdatos;
        public bool Baja(BELocalidad oBELoc)
        {
            if (Existe_Localidad_Asociada(oBELoc) == false)
            {
                //como esta definido fuera de un bloque el AL uso el mismo que defini en Existe_Localidad_Asociada
                return oDatos.Escribir("s_Localidad_Borrar", Hdatos);
            }
            else
            { return false; }
        }


        //busco si existe alguna localidad asociada a un cliente
        public bool Existe_Localidad_Asociada(BELocalidad oBELoc)
        {  //instancio el array lista para pasar los parametros

            Hdatos = new Hashtable();

            Hdatos.Add("@IdLoc", oBELoc.Id);
           
            return oDatos.LeerScalar("s_Localidad_Asociada",Hdatos);
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


