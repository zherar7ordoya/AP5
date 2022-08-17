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
    public class MPPCliente:IGestor<BECliente>
    {
        //defino el objeto datos
        DatosParametros oDatos;
        List<SqlParameter> LP;

        //instancio los objeto en el constructor dado q datos lo voy a usar siempre 
        public MPPCliente()
        { oDatos = new DatosParametros();     }

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
            LP = new List<SqlParameter>();
            string Consulta = "s_Cliente_Crear";

           
                if (oBECliente.Id != 0)
                {
                    SqlParameter Param6 = new SqlParameter();
                    Param6.ParameterName = "@IdCliente";
                    Param6.Value = oBECliente.Id;
                    Param6.SqlDbType = SqlDbType.Int;
                    LP.Add(Param6);
                    Consulta = "s_Cliente_Modificar";
                }

                SqlParameter Param1 = new SqlParameter();
                Param1.ParameterName = "@Nombre";
                Param1.Value = oBECliente.Nombre;
                Param1.SqlDbType = SqlDbType.VarChar;
                LP.Add(Param1);

              //USANDO EL CONSTRUCTOR DEL OBJETO
               SqlParameter Param2 = new SqlParameter("@Apellido", oBECliente.Apellido);
               LP.Add(Param2);

                SqlParameter Param3 = new SqlParameter("@DNI", oBECliente.DNI);    
                LP.Add(Param3);

            //PARA HACERLO TODO EN 1 LINEA
            SqlParameter Param4;
            SqlParameter Param5;

            LP.Add(Param4 = new SqlParameter() { ParameterName = "@IdLocalidad", Value = oBECliente.Localidad.Id });
            LP.Add(Param5 = new SqlParameter() { ParameterName = "@Activo", Value = true });

           
            if(VerificarExisteCLientexDNI(oBECliente)==false) 

            {  return oDatos.Escribir(Consulta, LP); }

            else
            { return false; }

        }

        bool VerificarExisteCLientexDNI(BECliente oBECli)
        {
            List<SqlParameter> LP2 = new List<SqlParameter>();
            SqlParameter Param3 = new SqlParameter();

            //verifico para los cliente nuevos
            if (oBECli.Id == 0)
            {  
            Param3.ParameterName = "@DNI";
            Param3.Value = oBECli.DNI;
            Param3.SqlDbType = SqlDbType.Int;
            LP2.Add(Param3);
           
             return oDatos.LeerScalar("s_Cliente_Existe_DNI", LP2); 
            }
            else
            { return false; }
        }

       
        public bool Baja(BECliente oBECliente)
        {
            LP = new List<SqlParameter>();
            string Consulta = "s_Cliente_Baja";

            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@IdCliente";
            Param1.Value = oBECliente.Id;
            Param1.SqlDbType = SqlDbType.Int;
            LP.Add(Param1);

            return oDatos.Escribir(Consulta, LP);

        }

        public BECliente ListarObjeto(BECliente Objeto)
        {
            throw new NotImplementedException();
        }


    

       public List<BECliente> BuscarClienteXApellido(BECliente oBECliente)
        {
            List<BECliente> LClientes = new List<BECliente>();

            LP = new List<SqlParameter>();
            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@Apellido";
            Param1.Value = oBECliente.Apellido;
            Param1.SqlDbType = SqlDbType.VarChar;
            LP.Add(Param1);

            DataTable tabla = oDatos.Leer("s_Cliente_BusquedaXApellido", LP);

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
