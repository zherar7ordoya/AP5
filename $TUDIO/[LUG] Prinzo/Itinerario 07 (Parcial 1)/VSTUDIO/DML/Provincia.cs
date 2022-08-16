using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DML
{
    public class Provincia : ABS.IGestor<BEL.Provincia>
    {
        DAL.ConexionSQLServer conexion;


        #region IMPLEMENTA INTERFAZ

        public BEL.Provincia Detallar(BEL.Provincia provincia) => throw new NotImplementedException();
        public bool Eliminar(BEL.Provincia provincia) => throw new NotImplementedException();
        public bool Guardar(BEL.Provincia provincia) => throw new NotImplementedException();

        public List<BEL.Provincia> Listar()
        {
            conexion = new DAL.ConexionSQLServer();
            string consulta = "SELECT * FROM Provincias";
            DataSet datos = conexion.Lectura(consulta);
            List<BEL.Provincia> ListaProvincias = new List<BEL.Provincia>();

            try
            {
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        BEL.Provincia provincia = new BEL.Provincia
                        {
                            Codigo = Convert.ToInt32(fila[0]),
                            Nombre = fila[1].ToString()
                        };
                        ListaProvincias.Add(provincia);
                    }
                }
                else
                {
                    ListaProvincias = null;
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
            return ListaProvincias;
        }
        #endregion
    }
}
