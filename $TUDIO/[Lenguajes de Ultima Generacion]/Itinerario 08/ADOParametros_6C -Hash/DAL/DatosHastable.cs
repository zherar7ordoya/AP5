using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections; //para el arraylist

namespace DAL
{
   public class DatosHastable
    {
      string CadenaC = @"Data Source=.\SQLEXPRESS02;Initial Catalog=ADO_en_Capas;Integrated Security=True";
       private SqlConnection oCnn = new SqlConnection(@"Data Source=.\SQLEXPRESS02;Initial Catalog=ADO_en_Capas;Integrated Security=True");
      private SqlTransaction Tranx;
      private SqlCommand Cmd;
   
        // con arraylist
       public DataTable Leer(string Consulta, Hashtable  Hdatos)
        {
            DataTable Dt = new DataTable();
            SqlDataAdapter Da;
            //paso la consulta y el objeto conection en el constructor
            Cmd = new SqlCommand(Consulta,oCnn);
            Cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                Da = new SqlDataAdapter(Cmd);

                if ((Hdatos != null))
                {
                    //si la hashtable no esta vacia, y tiene el dato q busco 
                    foreach (string dato in Hdatos.Keys)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        Cmd.Parameters.AddWithValue(dato, Hdatos[dato]);
                    }
                }
            }

            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
                Da.Fill(Dt);
		        return Dt;
                
        }


        public bool LeerScalar(string Consulta, Hashtable Hdatos)
        {
            oCnn.Open();
            //uso el constructor del objeto Command al instanciar el objeto
            Cmd = new SqlCommand(Consulta, oCnn);
            Cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if ((Hdatos != null))
                {
                    //si la hashtable no esta vacia, y tiene el dato q busco 
                    foreach (string dato in Hdatos.Keys)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        Cmd.Parameters.AddWithValue(dato, Hdatos[dato]);
                    }
                }

                int Respuesta = Convert.ToInt32(Cmd.ExecuteScalar());
                oCnn.Close();
                if (Respuesta > 0)
                { return true; }
                else
                { return false; }
            }
            catch (SqlException ex)
            { throw ex; }
        }
        public bool Escribir(string consulta, Hashtable Hdatos)
       {

           if (oCnn.State == ConnectionState.Closed)
           {
               oCnn.ConnectionString = CadenaC;
               oCnn.Open();
           }

            try
            {
                Tranx = oCnn.BeginTransaction();
                //uso el constructor del objeto command
                Cmd = new SqlCommand(consulta, oCnn, Tranx);
                //Cmd.Connection = oCnn;
                //Cmd.CommandText = consulta;
                //Cmd.Transaction = Tranx;
                Cmd.CommandType = CommandType.StoredProcedure;
                    
                if ((Hdatos != null))
                {
                    //si la hashtable no esta vacia, y tiene el dato q busco 
                    foreach (string dato in Hdatos.Keys)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        Cmd.Parameters.AddWithValue(dato, Hdatos[dato]);
                    }
                }

                int respuesta = Cmd.ExecuteNonQuery();
                Tranx.Commit();
                return true;

            }

            catch (SqlException ex)
            {
                Tranx.Rollback();
                return false;
            }
            catch (Exception ex)
            {
                Tranx.Rollback();
                return false;
            }
            finally
            { oCnn.Close(); }


       }

    }
}
