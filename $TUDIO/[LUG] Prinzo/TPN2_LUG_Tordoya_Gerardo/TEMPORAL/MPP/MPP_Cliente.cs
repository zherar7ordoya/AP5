using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

namespace MPP
{
    public class MPP_Cliente : Abstraccion.IGestor<BE.BE_Cliente>
    {
        //defino el objeto datos
        readonly DAL.Conexion conexion;
        Hashtable htabla;

        //instancio los objeto en el constructor dado q datos lo voy a usar siempre 
        public MPP_Cliente()
        {
            conexion = new DAL.Conexion();
        }


        public List<BE.BE_Cliente> ListarTodo()
        {
            List<BE.BE_Cliente> clientes = new List<BE.BE_Cliente>();

            DataTable dtabla = conexion.Leer("s_Cliente_ListarT", null);

            if (dtabla.Rows.Count > 0)
            {
                foreach (DataRow item in dtabla.Rows)
                {
                    BE.BE_Cliente cliente = new BE.BE_Cliente
                    {
                        Id = Convert.ToInt32(item["IdCliente"]),
                        Nombre = item["Nombre"].ToString(),
                        Apellido = item["Apellido"].ToString(),
                        DNI = Convert.ToInt32(item["DNI"])
                    };

                    BE.Localidad localidad = new BE.Localidad
                    {
                        Id = Convert.ToInt32(item["IdLocalidad"]),
                        Descripcion = item["Localidad"].ToString()
                    };
                    cliente.Localidad = localidad;
                    cliente.Activo = Convert.ToBoolean(item["Activo"]);

                    clientes.Add(cliente);
                }
                return clientes;
            }
            else
            {
                return null;
            }
        }

        public bool Guardar(BE.BE_Cliente cliente)
        {
            htabla = new Hashtable();
            string consulta = "s_Cliente_Crear";

            if (cliente.Id != 0)
            {
                htabla.Add("@IdCliente", cliente.Id);
                consulta = "s_Cliente_Modificar";
            }

            htabla.Add("@Nombre", cliente.Nombre);
            htabla.Add("@Apellido", cliente.Apellido);
            htabla.Add("@DNI", cliente.DNI);
            htabla.Add("@IdLocalidad", cliente.Localidad.Id);
            htabla.Add("@Activo", true);

            if (VerificarExisteCLientexDNI(cliente) == false)
            {
                return conexion.Escribir(consulta, htabla);
            }
            else
            {
                return false;
            }
        }


        bool VerificarExisteCLientexDNI(BE.BE_Cliente cliente)
        {
            Hashtable tabla = new Hashtable();

            //verifico para los cliente nuevos
            if (cliente.Id == 0)
            {
                tabla.Add("@DNI", cliente.DNI);
                return conexion.LeerEscalar("s_Cliente_Existe_DNI", tabla);
            }
            else
            {
                return false;
            }
        }


        public bool Eliminar(BE.BE_Cliente cliente)
        {
            htabla = new Hashtable();
            string consulta = "s_Cliente_Baja";
            htabla.Add("@IdCliente", cliente.Id);
            return conexion.Escribir(consulta, htabla);
        }


        public List<BE.BE_Cliente> BuscarClienteXApellido(BE.BE_Cliente cliente)
        {
            List<BE.BE_Cliente> clientes = new List<BE.BE_Cliente>();

            htabla = new Hashtable
            {
                { "@Apellido", cliente.Apellido }
            };

            DataTable tabla = conexion.Leer("s_Cliente_BusquedaXApellido", htabla);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow item in tabla.Rows)
                {
                    BE.BE_Cliente _cliente = new BE.BE_Cliente
                    {
                        Id = Convert.ToInt32(item["IdCliente"]),
                        Nombre = item["Nombre"].ToString(),
                        Apellido = item["Apellido"].ToString(),
                        DNI = Convert.ToInt32(item["DNI"])
                    };

                    BE.Localidad _localidad = new BE.Localidad
                    {
                        Id = Convert.ToInt32(item["IdLocalidad"]),
                        Descripcion = item["Localidad"].ToString()
                    };

                    _cliente.Localidad = _localidad;
                    _cliente.Activo = Convert.ToBoolean(item["Activo"]);
                    clientes.Add(_cliente);
                }
                return clientes;
            }
            else
            {
                return null;
            }
        }


        public BE.BE_Cliente ListarObjeto(BE.BE_Cliente cliente)
        {
            throw new NotImplementedException();
        }


    }
}
