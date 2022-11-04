using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//uso las librerias de SQL
using System.Data;
using System.Data.SqlClient;
using System.Configuration; // para usar el app.config

namespace DAL
{
    public class Acceso
    {
        //declaro el objeto del tipo conection y uso el constructor para pasar el ConnectionString
        private SqlConnection oCnn = new SqlConnection(ConfigurationManager.ConnectionStrings["MiCadenaDeConexion"].ToString());

        //declaro el objeto transacction
        private SqlTransaction Tranx;

        // creo una funcion para saber el estado de la conexion
        public string TestConnection()
        {
            oCnn.Open();
            //si no uso el metodo Abrir puedo hacer el open 
            //conexion.Open();
            //Cerrar();
            if (oCnn.State == ConnectionState.Open)
            {
                return "Conexion a la BD OK";
            }
            else
            {
                return "No se pudo conectar a la BD, que pacho???";
            }
        }



        //Metodo Generico para leer
        public DataTable Leer(string consulta)
        {
            DataTable tabla = new DataTable();
            try
            {
                //creo el data adapter le paso la consulta y la conexion
                SqlDataAdapter Da = new SqlDataAdapter(consulta, oCnn);
                //lleno la tabla con el metodo fill
                Da.Fill(tabla);

            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            { //cierro la Conexion
                oCnn.Close();
            }
            return tabla;
        }

        //leo un escalar-
        public bool LeerScalar(string consulta)
        {
            oCnn.Open();
            //uso el constructor del objeto Command
            SqlCommand cmd = new SqlCommand(consulta, oCnn);
            cmd.CommandType = CommandType.Text;
            try
            {
                int Respuesta = Convert.ToInt32(cmd.ExecuteScalar());
                oCnn.Close();
                if (Respuesta > 0)
                { return true; }
                else
                { return false; }
            }
            catch (SqlException ex)
            { throw ex; }
        }

        public DataSet Leer2(string Consulta_SQL)
        {
            DataSet Ds = new DataSet();
            try
            {
                //creo el data adapter le paso la consulta y la conexion
                SqlDataAdapter Da = new SqlDataAdapter(Consulta_SQL, oCnn);
                //lleno el DataSet con el metodo fill
                Da.Fill(Ds);
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            { //cierro la Conexion
                oCnn.Close();
            }
            return Ds;
        }

        //realizo un método escribir generico, dado que recibo un string q es la consulta de SQL
        public bool Escribir(string Consulta_SQL)
        {  
      
            oCnn.Open();
            //declaro que comienza la transaccion
            Tranx = oCnn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = oCnn;
            cmd.CommandText = Consulta_SQL;
            //le paso el objeto transaccion al command
            cmd.Transaction = Tranx;
            try
            {
                int respuesta = cmd.ExecuteNonQuery();
                //si esta OK confirma la transaccion
                Tranx.Commit();
                return true;
            }
            catch (SqlException ex)
            {    //si pudo realizar la operacion hace un rollback
                Tranx.Rollback();
                throw ex;
            }
            catch (Exception ex)
            {    //si pudo realizar la operacion hace un rollback
                Tranx.Rollback();
                throw ex;
            }

            finally
            { oCnn.Close(); }



        }
    }
}
