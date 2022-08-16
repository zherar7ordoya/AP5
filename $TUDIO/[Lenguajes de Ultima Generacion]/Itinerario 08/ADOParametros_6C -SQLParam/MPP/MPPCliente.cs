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
        DatosParametros oDatos;
        ArrayList AL;

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
            AL = new ArrayList();
            string Consulta = "s_Cliente_Crear";

           
                if (oBECliente.Id != 0)
                {
                    SqlParameter Param6 = new SqlParameter();
                    Param6.ParameterName = "@IdCliente";
                    Param6.Value = oBECliente.Id;
                    Param6.SqlDbType = SqlDbType.Int;
                    AL.Add(Param6);
                    Consulta = "s_Cliente_Modificar";
                }

                SqlParameter Param1 = new SqlParameter();
                Param1.ParameterName = "@Nombre";
                Param1.Value = oBECliente.Nombre;
                Param1.SqlDbType = SqlDbType.VarChar;
                AL.Add(Param1);

                SqlParameter Param2 = new SqlParameter();
                Param2.ParameterName = "@Apellido";
                Param2.Value = oBECliente.Apellido;
                Param2.SqlDbType = SqlDbType.VarChar;
                AL.Add(Param2);

                SqlParameter Param3 = new SqlParameter();
                Param3.ParameterName = "@DNI";
                Param3.Value = oBECliente.DNI;
                Param3.SqlDbType = SqlDbType.Int;
                AL.Add(Param3);


                SqlParameter Param4 = new SqlParameter();
                Param4.ParameterName = "@IdLocalidad";
                Param4.Value = oBECliente.Localidad.Id;
                Param4.SqlDbType = SqlDbType.Int;
                AL.Add(Param4);

                SqlParameter Param5 = new SqlParameter();
                Param5.ParameterName = "@Activo";
                Param5.Value = true;
                Param5.SqlDbType = SqlDbType.Bit;
                AL.Add(Param5);

            if(VerificarExisteCLientexDNI(oBECliente)==false) 

            {  return oDatos.Escribir(Consulta, AL); }

            else
            { return false; }

        }

        bool VerificarExisteCLientexDNI(BECliente oBECli)
        {
            ArrayList AL2 = new ArrayList();
            SqlParameter Param3 = new SqlParameter();

            //verifico para los cliente nuevos
            if (oBECli.Id == 0)
            {  
            Param3.ParameterName = "@DNI";
            Param3.Value = oBECli.DNI;
            Param3.SqlDbType = SqlDbType.Int;
            AL2.Add(Param3);
           
             return oDatos.LeerScalar("s_Cliente_Existe_DNI", AL2); 
            }
            else
            { return false; }
        }

       
        public bool Baja(BECliente oBECliente)
        {
            AL = new ArrayList();
            string Consulta = "s_Cliente_Baja";

            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@IdCliente";
            Param1.Value = oBECliente.Id;
            Param1.SqlDbType = SqlDbType.Int;
            AL.Add(Param1);

            return oDatos.Escribir(Consulta, AL);

        }

        public BECliente ListarObjeto(BECliente Objeto)
        {
            throw new NotImplementedException();
        }


    

       public List<BECliente> BuscarClienteXApellido(BECliente oBECliente)
        {
            List<BECliente> LClientes = new List<BECliente>();

            AL = new ArrayList();
            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@Apellido";
            Param1.Value = oBECliente.Apellido;
            Param1.SqlDbType = SqlDbType.VarChar;
            AL.Add(Param1);

            DataTable tabla = oDatos.Leer("s_Cliente_BusquedaXApellido", AL);

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
