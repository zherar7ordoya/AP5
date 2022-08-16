using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DML
{
    public class DescuentoCalculado : ABS.IGestor<BEL.DescuentoCalculado>
    {

        DAL.ConexionSQLServer conexion;

        public BEL.DescuentoCalculado Detallar(BEL.DescuentoCalculado descuento)
        {
            throw new NotImplementedException();
        }


        public bool Eliminar(BEL.DescuentoCalculado descuento)
        {
            conexion = new DAL.ConexionSQLServer();
            string consulta =
                "DELETE FROM DescuentoOtorgado " +
                $"WHERE Codigo = { descuento.Codigo }";
            return conexion.Escritura(consulta);
        }


        public bool Guardar(BEL.DescuentoCalculado descuento)
        {
            string consulta;

            if (descuento.Codigo == 0)
            {
                consulta =
                    "INSERT INTO DescuentoOtorgado(NumeroTarjeta, Tipo, MontoDescuento) " +
                    "VALUES(" +
                    $"{ descuento.NumeroTarjeta }, " +
                    $"'{ descuento.Tipo }', " +
                    $"{ descuento.DescuentoOtorgado })";
            }
            else
            {
                consulta =
                    "UPDATE DescuentoOtorgado " +
                    "SET " +
                    $"NumeroTarjeta = { descuento.NumeroTarjeta }, " +
                    $"Tipo = { descuento.Tipo }, " +
                    $"MontoDescuento = { descuento.DescuentoOtorgado } " +
                    $"WHERE Codigo = { descuento.Codigo }";
            }

            conexion = new DAL.ConexionSQLServer();
            return conexion.Escritura(consulta);
        }


        public List<BEL.DescuentoCalculado> Listar()
        {
            conexion = new DAL.ConexionSQLServer();

            DataSet datos = conexion.Lectura(
                "SELECT Codigo, NumeroTarjeta, Tipo, MontoDescuento " +
                "FROM DescuentoOtorgado;");

            List<BEL.DescuentoCalculado> ListaDescuentos = new List<BEL.DescuentoCalculado>();
            try
            {
                if (datos.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        BEL.DescuentoCalculado descuento = new BEL.DescuentoCalculado
                        {
                            Codigo = Convert.ToInt32(fila[0]),
                            NumeroTarjeta = Convert.ToInt32(fila[1]),
                            Tipo = fila[2].ToString(),
                            DescuentoOtorgado = Convert.ToInt32(fila[3])
                        };
                        ListaDescuentos.Add(descuento);
                    }
                }
                else
                { 
                    ListaDescuentos = null;
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

            return ListaDescuentos;
        }
    }
}
