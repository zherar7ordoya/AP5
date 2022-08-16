using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DML
{
    public class Pais : ABS.IGestor<BEL.Pais>
    {
        DAL.ConexionSQLServer conexion;


        #region IMPLEMENTA INTERFAZ

        public BEL.Pais Detallar(BEL.Pais pais) => throw new NotImplementedException();
        public bool Eliminar(BEL.Pais pais) => throw new NotImplementedException();
        public bool Guardar(BEL.Pais pais) => throw new NotImplementedException();

        public List<BEL.Pais> Listar()
        {
            conexion = new DAL.ConexionSQLServer();
            string consulta = "SELECT * FROM Paises";
            DataSet datos = conexion.Lectura(consulta);
            List<BEL.Pais> ListaPaises = new List<BEL.Pais>();

            try
            {
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        BEL.Pais pais = new BEL.Pais
                        {
                            Codigo = Convert.ToInt32(fila[0]),
                            Nombre = fila[1].ToString()
                        };
                        ListaPaises.Add(pais);
                    }
                }
                else
                { 
                    ListaPaises = null;
                }
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
            return ListaPaises;
        }
        #endregion
    }
}
