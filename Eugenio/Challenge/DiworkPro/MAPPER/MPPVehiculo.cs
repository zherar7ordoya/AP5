using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace MAPPER
{
    public class MPPVehiculo
    {
        Conexion Oc;
        ArrayList ArrList;

        public MPPVehiculo()
        {
            Oc = new Conexion();
        }
        Hashtable hash;
        public bool Guardar(Vehiculo vehiculo)
        {
            string Consulta = "Vehiculo_Crear";
            hash = new Hashtable();

            if (vehiculo.Id != 0)
            {
                hash.Add("@Id", vehiculo.Id);
                Consulta = "Vehiculo_Modificar";
            }
            hash.Add("@Marca", vehiculo.Marca);
            hash.Add("@Modelo", vehiculo.Modelo);
            hash.Add("@Patente", vehiculo.Patente);

            return Oc.EscribirGenerico(Consulta, hash);
        }

        public List<Vehiculo> ListarTodo()
        {
            List<Vehiculo> ListaVehiculos = new List<Vehiculo>();

            DataTable dt = Oc.Leer("Vehiculo_ListarT", null);


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Vehiculo vehiculo = null;

                    vehiculo.Id = int.Parse(fila["Id"].ToString());
                    vehiculo.Marca = fila["Marca"].ToString();
                    vehiculo.Modelo = fila["Modelo"].ToString();
                    vehiculo.Patente = fila["Patente"].ToString();

                    ListaVehiculos.Add(vehiculo);
                }
            }
            else
            {
                ListaVehiculos = null;
            }

            return ListaVehiculos;
        }

        public List<Vehiculo> ListarTodoAuto()
        {
            List<Vehiculo> ListaVehiculos = new List<Vehiculo>();

            DataTable dt = Oc.Leer("Vehiculo_ListarT", null);


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Vehiculo vehiculo = new Automovil();

                    vehiculo.Id = int.Parse(fila["Id"].ToString());
                    vehiculo.Marca = fila["Marca"].ToString();
                    vehiculo.Modelo = fila["Modelo"].ToString();
                    vehiculo.Patente = fila["Patente"].ToString();

                    ListaVehiculos.Add(vehiculo);
                }
            }
            else
            {
                ListaVehiculos = null;
            }

            return ListaVehiculos;
        }
        public List<Vehiculo> ListarTodoMoto()
        {
            List<Vehiculo> ListaVehiculos = new List<Vehiculo>();

            DataTable dt = Oc.Leer("Vehiculo_ListarT", null);


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    Vehiculo vehiculo = new Moto();

                    vehiculo.Id = int.Parse(fila["Id"].ToString());
                    vehiculo.Marca = fila["Marca"].ToString();
                    vehiculo.Modelo = fila["Modelo"].ToString();
                    vehiculo.Patente = fila["Patente"].ToString();

                    ListaVehiculos.Add(vehiculo);
                }
            }
            else
            {
                ListaVehiculos = null;
            }

            return ListaVehiculos;
        }

        
        public bool Borrar(Vehiculo vehiculo)
        {
            ArrList = new ArrayList();
            SqlParameter Param1 = new SqlParameter();
            Param1.ParameterName = "@Id";
            Param1.Value = vehiculo.Id;
            Param1.SqlDbType = SqlDbType.Int;
            ArrList.Add(Param1);
            return Oc.EscribirGenerico("Vehiculo_Borrar", ArrList);
        }
    }
}
