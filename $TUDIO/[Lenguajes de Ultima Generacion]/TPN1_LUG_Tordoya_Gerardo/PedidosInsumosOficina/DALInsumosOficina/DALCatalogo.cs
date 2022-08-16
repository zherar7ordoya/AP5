using System;
using System.Data;
using System.Data.SqlClient;

namespace DALInsumosOficina
{
    public class DALCatalogo
    {
        public DataSet ObtenerInfoProducto()
        {
            DataSet productos;
            string bbdd = DALConector.ObtenerConexionSQL("ConexionConBBDD");

            using (SqlConnection conexion = new SqlConnection(bbdd))
            {
                productos = new DataSet("Productos");

                String cadenaCategoria =
                    "SELECT ID_Categoria, Nombre, Descripcion " +
                    "FROM Categorias";
                using (SqlCommand comandoCategoria = new SqlCommand(cadenaCategoria, conexion))
                {
                    using (SqlDataAdapter adaptadorCategoria = new SqlDataAdapter(comandoCategoria))
                    {
                        adaptadorCategoria.Fill(productos, "Categorias");
                    }
                }

                String cadenaProducto =
                    "SELECT ID_Producto, ID_Categoria, Nombre, Descripcion, Precio " +
                    "FROM Productos";
                using (SqlCommand comandoProducto = new SqlCommand(cadenaProducto, conexion))
                {
                    using (SqlDataAdapter adaptadorProducto = new SqlDataAdapter(comandoProducto))
                    {
                        adaptadorProducto.Fill(productos, "Productos");
                    }
                }
            }

            DataRelation relacion = new DataRelation("relacion",
                productos.Tables["Categorias"].Columns["ID_Categoria"],
                productos.Tables["Productos"].Columns["ID_Categoria"], false);
            productos.Relations.Add(relacion);
            return productos;
        }
    }
}