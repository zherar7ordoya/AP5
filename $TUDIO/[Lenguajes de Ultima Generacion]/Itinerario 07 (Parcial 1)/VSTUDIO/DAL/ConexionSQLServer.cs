using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

/**
 * NOTA:
 * A falta de precisiones, se ha implementado transacciones en las operaciones
 * de escritura (pues ¿las requieren las de lectura?).
 */


namespace DAL
{
    public class ConexionSQLServer
    {
        private readonly SqlConnection conexion = 
            new SqlConnection(ConfigurationManager
            .ConnectionStrings["CadenaConexion"].ToString());


        /// <summary>
        /// Para consultas SQL que retornan registros.
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        
        public DataSet Lectura(string consulta)
        {
            DataSet datos = new DataSet();

            try
            {
                SqlDataAdapter adaptador = 
                    new SqlDataAdapter(
                        consulta,
                        conexion);
                adaptador.Fill(datos);
            }
            catch (SqlException ex)
            {
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
            finally
            {
                conexion.Close();
            }
            return datos;
        }


        /// <summary>
        /// Para consultas SQL que no retornan nada.
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>

        public bool Escritura(string consulta)
        {
            conexion.Open();
            //SqlTransaction transaccion;
            //SqlCommand comando;
            //transaccion = conexion.BeginTransaction();

            SqlTransaction transaccion = conexion.BeginTransaction();
            SqlCommand comando = new SqlCommand(consulta, conexion);

            try
            {
                //comando = new SqlCommand(consulta, conexion);
                comando.Transaction = transaccion;
                comando.ExecuteNonQuery();
                transaccion.Commit();
                MessageBox.Show("Datos ingresados correctamente.");
                return true;
            }
            catch (SqlException ex)
            {
                transaccion.Rollback();
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
                throw ex;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }


        /**
         * NOTA:
         * Se mantiene sin transacciones para respetar lo impartido en el 
         * Itinerario 4: "Para ejecutar un command se debe respetar los
         * siguientes pasos...".
         */

        /// <summary>
        /// Consulta SQL que retorna un escalar.
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>

        public bool Conteo(string consulta)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = consulta,
                Connection = conexion
            };

            try
            {
                int respuesta = Convert.ToInt32(comando.ExecuteScalar());
                if (respuesta > 0) return true;
                else { return false; }
            }
            catch (SqlException ex)
            {
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
                throw ex;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
