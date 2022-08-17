using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UI_Transacciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection("Data Source=.\\SQL_UAI;Initial Catalog=Empleados;Integrated Security=True");

            Conn.Open();

            //creo el objeto transaction
            SqlTransaction myTrans;

            SqlCommand Comando ;

            //asigno la coneccions al objeto  transaction
            myTrans = Conn.BeginTransaction();


            try
            {
                Comando = new SqlCommand("INSERT INTO EMPLEADO (IdEmpleado, Nombre, Sueldo) Values(7,'JOSE',2000)", Conn);

                //al objeto comand le paso la transaction
                Comando.Transaction = myTrans;

                Comando.ExecuteNonQuery();
/* comienza ejemplo para atomicidad*/
                Comando = new SqlCommand("INSERT INTO EMPLEADO (IdEmpleado, Nombre, Sueldo) Values(8,'LUIS',5000)", Conn);

                //al objeto comand le paso la transaction
                Comando.Transaction = myTrans;

                Comando.ExecuteNonQuery();

                Comando = new SqlCommand("INSERT INTO EMPLEADO (IdEmpleado, Nombre, Sueldo) Values(8,'PEDRO',4000)", Conn);

                //al objeto comand le paso la transaction
                Comando.Transaction = myTrans;

                Comando.ExecuteNonQuery();
 /*finaliza ejemplo para atomicidad */

                //si esta todo ok la transaction se ejecuta
                myTrans.Commit();

             MessageBox.Show("Datos Ingresados");


            }
            catch (Exception ex)
            {
                //si no se realizo la transaction OK se hace un rollback
                myTrans.Rollback();

                MessageBox.Show(ex.Message);

            }


            Conn.Close();
        }
    }
}
