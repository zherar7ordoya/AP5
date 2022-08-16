using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DAL
{
    public class Conexion
    {

        // @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ADO_en_Capas;Integrated Security=True";


        #region |||||||||||||||||||||||||||||||||||||||||||| VARIABLES DE CLASE
        private readonly SqlConnection CONEXION_OBJECT = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ADO_en_Capas;Integrated Security=True");
        private readonly string CONEXION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ADO_en_Capas;Integrated Security=True";
        private SqlTransaction TRANSACCION;
        private SqlCommand COMANDO;
        #endregion

        #region ||||||||||||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS
        /**
         * 1. LEER
         * 2. LEER (ESCALAR)
         * 3. ESCRIBIR
         */
        public DataTable Leer(string consulta, Hashtable htabla)
        {
            DataTable dtabla = new DataTable();
            SqlDataAdapter adaptador;

            COMANDO = new SqlCommand(consulta, CONEXION_OBJECT)
            {
                CommandType = CommandType.StoredProcedure
            };

            try
            {
                adaptador = new SqlDataAdapter(COMANDO);

                if (htabla != null)
                {
                    foreach (string dato in htabla.Keys)
                    {
                        COMANDO.Parameters.AddWithValue(dato, htabla[dato]);
                    }
                }

                adaptador.Fill(dtabla);

                CONEXION_OBJECT.Close();

                return dtabla;


            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }

            
        }

        //---------------------------------------------------------------------

        public bool LeerEscalar(string consulta, Hashtable htabla)
        {
            CONEXION_OBJECT.Open();
            COMANDO = new SqlCommand(consulta, CONEXION_OBJECT)
            {
                CommandType = CommandType.StoredProcedure
            };

            try
            {
                if (htabla != null)
                {
                    foreach (string dato in htabla.Keys)
                    {
                        COMANDO.Parameters.AddWithValue(dato, htabla[dato]);
                    }
                }

                int respuesta = Convert.ToInt32(COMANDO.ExecuteScalar());
                CONEXION_OBJECT.Close();

                if (respuesta > 0) return true;
                else { return false; }
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }

        //---------------------------------------------------------------------

        public bool Escribir(string consulta, Hashtable htabla)
        {
            if (CONEXION_OBJECT.State == ConnectionState.Closed)
            {
                CONEXION_OBJECT.ConnectionString = CONEXION_STRING;
                CONEXION_OBJECT.Open();
            }

            try
            {
                TRANSACCION = CONEXION_OBJECT.BeginTransaction();
                COMANDO = new SqlCommand(consulta, CONEXION_OBJECT, TRANSACCION)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (htabla != null)
                {
                    foreach (string dato in htabla.Keys)
                    {
                        COMANDO.Parameters.AddWithValue(dato, htabla[dato]);
                    }
                }

                int respuesta = COMANDO.ExecuteNonQuery();
                TRANSACCION.Commit();
                return true;
            }

            catch (SqlException)
            {
                TRANSACCION.Rollback();
                return false;
            }
            catch (Exception)
            {
                TRANSACCION.Rollback();
                return false;
            }
            finally
            {
                CONEXION_OBJECT.Close();
            }
        }
        #endregion






























        //private SqlTransaction transaccion;
        //private SqlCommand comando;

        //// con arraylist
        //public DataTable Leer(string consulta, Hashtable datos)
        //{
        //    DataTable tabla = new DataTable();
        //    SqlDataAdapter adaptador;

        //    //paso la consulta y el objeto conection en el constructor
        //    comando = new SqlCommand(consulta, ConexionObjeto)
        //    {
        //        CommandType = CommandType.StoredProcedure
        //    };

        //    try
        //    {
        //        adaptador = new SqlDataAdapter(comando);

        //        if (datos != null)
        //        {
        //            //si la hashtable no esta vacia, y tiene el dato q busco 
        //            foreach (string dato in datos.Keys)
        //            {
        //                //cargo los parametros que le estoy pasando con la Hash
        //                comando.Parameters.AddWithValue(dato, datos[dato]);
        //            }
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    adaptador.Fill(tabla);
        //    return tabla;

        //}


        //public bool LeerEscalar(string consulta, Hashtable datos)
        //{
        //    ConexionObjeto.Open();
        //    //uso el constructor del objeto Command al instanciar el objeto
        //    comando = new SqlCommand(consulta, ConexionObjeto)
        //    {
        //        CommandType = CommandType.StoredProcedure
        //    };
        //    try
        //    {
        //        if (datos != null)
        //        {
        //            //si la hashtable no esta vacia, y tiene el dato q busco 
        //            foreach (string dato in datos.Keys)
        //            {
        //                //cargo los parametros que le estoy pasando con la Hash
        //                comando.Parameters.AddWithValue(dato, datos[dato]);
        //            }
        //        }

        //        int respuesta = Convert.ToInt32(comando.ExecuteScalar());
        //        ConexionObjeto.Close();

        //        if (respuesta > 0) return true;
        //        else { return false; }
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}


        //public bool Escribir(string consulta, Hashtable datos)
        //{

        //    if (ConexionObjeto.State == ConnectionState.Closed)
        //    {
        //        ConexionObjeto.ConnectionString = ConexionTexto;
        //        ConexionObjeto.Open();
        //    }

        //    try
        //    {
        //        transaccion = ConexionObjeto.BeginTransaction();
        //        //uso el constructor del objeto command
        //        comando = new SqlCommand(consulta, ConexionObjeto, transaccion)
        //        {
        //            CommandType = CommandType.StoredProcedure
        //        };

        //        if (datos != null)
        //        {
        //            //si la hashtable no esta vacia, y tiene el dato q busco 
        //            foreach (string dato in datos.Keys)
        //            {
        //                //cargo los parametros que le estoy pasando con la Hash
        //                comando.Parameters.AddWithValue(dato, datos[dato]);
        //            }
        //        }

        //        int respuesta = comando.ExecuteNonQuery();
        //        transaccion.Commit();
        //        return true;
        //    }

        //    catch (SqlException)
        //    {
        //        transaccion.Rollback();
        //        return false;
        //    }
        //    catch (Exception)
        //    {
        //        transaccion.Rollback();
        //        return false;
        //    }
        //    finally
        //    {
        //        ConexionObjeto.Close();
        //    }


        //}

    }
}
