using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using Abstraccion;

namespace MPP
{
    public class MPPCliente:IGestor<BECliente>
    {
        //defino el objeto datos
        DatosHastable oDatos;
        Hashtable Hdatos;

        //instancio los objeto en el constructor dado q datos lo voy a usar siempre 
        public MPPCliente()
        { oDatos = new DatosHastable();     }

         public List<BECliente> ListarTodo()
        {
             List<BECliente> LClientes = new List<BECliente>();
                    
            DataTable tabla= oDatos.Leer("s_Cliente_ListarT", null);         

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow Item in tabla.Rows)
                {
                    BECliente oCli = new BECliente();
                    oCli.Id = Convert.ToInt32(Item["IdCliente"]);
                    oCli.Nombre = Item["Nombre"].ToString();
                    oCli.Apellido = Item["Apellido"].ToString();
                    oCli.DNI = Convert.ToInt32(Item["DNI"]);
                    BELocalidad oLoc = new BELocalidad();
                    oLoc.Id = Convert.ToInt32(Item["IdLocalidad"]);
                    oLoc.Descripcion = Item["Localidad"].ToString();
                    oCli.Localidad = oLoc;
                    oCli.Activo = Convert.ToBoolean(Item["Activo"]);
                    LClientes.Add(oCli);
                }
                return LClientes;
            }
            else
            {
                return null;
            }
        }
     
        public bool Guardar(BECliente oBECliente)
        {
            Hdatos = new Hashtable();
            string Consulta = "s_Cliente_Crear";
                       
                if (oBECliente.Id != 0)
                {
                Hdatos.Add("@IdCliente", oBECliente.Id);
                Consulta = "s_Cliente_Modificar";
                }

                Hdatos.Add("@Nombre", oBECliente.Nombre);
                Hdatos.Add("@Apellido", oBECliente.Apellido);
                Hdatos.Add("@DNI", oBECliente.DNI);
                Hdatos.Add("@IdLocalidad", oBECliente.Localidad.Id);
                Hdatos.Add("@Activo", true);
               
            if(VerificarExisteCLientexDNI(oBECliente)==false) 

            {  return oDatos.Escribir(Consulta, Hdatos); }

            else
            { return false; }

        }

        bool VerificarExisteCLientexDNI(BECliente oBECli)
        {
            Hashtable Hdatos2 = new Hashtable();
            SqlParameter Param3 = new SqlParameter();

            //verifico para los cliente nuevos
            if (oBECli.Id == 0)
            {
                Hdatos2.Add("@DNI", oBECli.DNI);
                      
             return oDatos.LeerScalar("s_Cliente_Existe_DNI", Hdatos2); 
            }
            else
            { return false; }
        }

       
        public bool Baja(BECliente oBECliente)
        {
            Hdatos = new Hashtable();
            string Consulta = "s_Cliente_Baja";

            Hdatos.Add("@IdCliente", oBECliente.Id);
          

            return oDatos.Escribir(Consulta, Hdatos);

        }

        public BECliente ListarObjeto(BECliente Objeto)
        {
            throw new NotImplementedException();
        }


    

       public List<BECliente> BuscarClienteXApellido(BECliente oBECliente)
        {
            List<BECliente> LClientes = new List<BECliente>();

            Hdatos = new Hashtable();
            Hdatos.Add("@Apellido", oBECliente.Apellido);
        

            DataTable tabla = oDatos.Leer("s_Cliente_BusquedaXApellido", Hdatos);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow Item in tabla.Rows)
                {
                    BECliente oCli = new BECliente();
                    oCli.Id = Convert.ToInt32(Item["IdCliente"]);
                    oCli.Nombre = Item["Nombre"].ToString();
                    oCli.Apellido = Item["Apellido"].ToString();
                    oCli.DNI = Convert.ToInt32(Item["DNI"]);
                    BELocalidad oLoc = new BELocalidad();
                    oLoc.Id = Convert.ToInt32(Item["IdLocalidad"]);
                    oLoc.Descripcion = Item["Localidad"].ToString();
                    oCli.Localidad = oLoc;
                    oCli.Activo = Convert.ToBoolean(Item["Activo"]);
                    LClientes.Add(oCli);
                }
                return LClientes;
            }
            else
            {
                return null;
            }
        }
    }
}
