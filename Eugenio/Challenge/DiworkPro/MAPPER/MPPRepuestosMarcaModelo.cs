using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAPPER
{
    public class MPPRepuestosMarcaModelo
    {
        public void RepuestoRepetido(DataGridView dgv)
        {
            try
            {
                SqlConnection oCnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Presupuestador;Integrated Security=True");
                SqlCommand comando = new SqlCommand("RepuestosxMarcaModelo", oCnn);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {

            }
        }

        public void PresupuestosMarcaModelo(DataGridView dgv)
        {
            try
            {
                SqlConnection oCnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Presupuestador;Integrated Security=True");
                SqlCommand comando = new SqlCommand("PresupuestoxMarcaModelo", oCnn);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {
            }
            
        }

        public void TotalAutos(DataGridView dgv)
        {
            try
            {
                SqlConnection oCnn = new SqlConnection(@"Data Source = DESKTOP-6MTE8AV\SQLEXPRESS; Initial Catalog = Presupuestador; Integrated Security = True");
                SqlCommand comando = new SqlCommand("TotalesAutos", oCnn);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {

            }
        }

        public void TotalMotos(DataGridView dgv)
        {
            try
            {
                SqlConnection oCnn = new SqlConnection(@"Data Source = DESKTOP-6MTE8AV\SQLEXPRESS; Initial Catalog = Presupuestador; Integrated Security = True");
                SqlCommand comando = new SqlCommand("TotalesMotos", oCnn);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dgv.DataSource = ds.Tables[0];
            }
            catch (Exception)
            {

            }
        }
    }
}
