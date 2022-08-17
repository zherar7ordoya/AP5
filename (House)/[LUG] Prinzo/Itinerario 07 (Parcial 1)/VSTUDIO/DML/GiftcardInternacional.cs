using System;
using System.Collections.Generic;
using System.Data;

namespace DML
{
    public class GiftcardInternacional : ABS.IGestor<BEL.GiftcardInternacional>
    {
        DAL.ConexionSQLServer conexion;


        #region IMPLEMENTA INTERFAZ.-------------------------------------------

        public BEL.GiftcardInternacional Detallar(BEL.GiftcardInternacional codigo)
        {
            conexion = new DAL.ConexionSQLServer();
            string consulta =
                "SELECT " +
                "Codigo, Numero, Vencimiento, Estado, Rubro, TipoNacProv, Saldo " +
                "FROM Tarjetas " +
                $"WHERE Codigo = { codigo.Codigo }";
            DataSet datos = conexion.Lectura(consulta);

            if (datos.Tables[0].Rows.Count > 0)
            {
                BEL.GiftcardInternacional belGiftcardInternacional = new BEL.GiftcardInternacional();

                foreach (DataRow fila in datos.Tables[0].Rows)
                {
                    belGiftcardInternacional.Codigo = Convert.ToInt32(fila[0]);
                    belGiftcardInternacional.Numero = Convert.ToInt32(fila[1]);
                    belGiftcardInternacional.Vencimiento = Convert.ToDateTime(fila[2]);
                    belGiftcardInternacional.Estado = fila[3].ToString();
                    belGiftcardInternacional.Rubro = fila[4].ToString();
                    belGiftcardInternacional.Pais = fila[5].ToString();

                    if (fila[7].ToString() != "") belGiftcardInternacional.Saldo = Convert.ToInt32(fila[7]);
                }
                return belGiftcardInternacional;
            }
            else
            {
                return null;
            }
        }


        public bool Eliminar(BEL.GiftcardInternacional tarjeta)
        {
            conexion = new DAL.ConexionSQLServer();

            string consulta =
                "SELECT COUNT(CodTarjeta) " +
                "FROM ClientesGiftcards " +
                $"WHERE CodTarjeta = { tarjeta.Codigo }";
            bool bandera = conexion.Conteo(consulta);

            if (bandera)
            {
                consulta =
                    "DELETE FROM ClientesGiftcards " +
                    $"WHERE CodTarjeta = { tarjeta.Codigo }";
                conexion.Escritura(consulta);

                consulta =
                    "UPDATE Clientes " +
                    "SET CodTarjeta = 'NULL' " +
                    $"WHERE Codigo = { tarjeta.Codigo }";
                conexion.Escritura(consulta);
            }

            consulta = 
                "DELETE FROM Tarjetas " +
                $"WHERE Codigo = { tarjeta.Codigo }";
            return conexion.Escritura(consulta);
        }


        public bool Guardar(BEL.GiftcardInternacional giftcard)
        {
            string consulta;
            if (giftcard.Codigo == 0)
            {
                consulta =
                    "INSERT INTO " +
                    "Tarjetas(Numero, Vencimiento, Estado, Rubro, TipoNacProv) " +
                    "VALUES(" +
                    $"{ giftcard.Numero }, " +
                    $"'{ giftcard.Vencimiento }', " +
                    $"'{ giftcard.Estado }', " +
                    $"'{ giftcard.Rubro }', " +
                    $"'{ giftcard.Pais }')";
            }
            else
            {
                consulta = 
                    "UPDATE Tarjetas " +
                    "SET " +
                    $"Numero = { giftcard.Numero }, " +
                    $"Vencimiento = '{ giftcard.Vencimiento }', " +
                    $"Estado = '{ giftcard.Estado }', " +
                    $"Rubro = '{ giftcard.Rubro }', " +
                    $"Saldo = { giftcard.Saldo }, " +
                    $"TipoNacProv = '{ giftcard.Pais }' " +
                    $"WHERE Codigo = { giftcard.Codigo }";
            }
            conexion = new DAL.ConexionSQLServer();
            return conexion.Escritura(consulta);
        }


        public List<BEL.GiftcardInternacional> Listar()
        {
            List<BEL.GiftcardInternacional> ListaTarjetas = new List<BEL.GiftcardInternacional>();
            DataSet datos;
            conexion = new DAL.ConexionSQLServer();
            string consulta = "SELECT Tarjetas.Codigo, Numero, Vencimiento, Estado, Rubro, TipoNacProv, Provincia, Saldo, DescuentoOtorgado.MontoDescuento FROM Tarjetas LEFT JOIN DescuentoOtorgado ON Tarjetas.Numero = DescuentoOtorgado.NumeroTarjeta";
                //"SELECT " +
                //"Codigo, Numero, Vencimiento, Estado, Rubro, TipoNacProv, Provincia, Saldo " +
                //"FROM Tarjetas";
            datos = conexion.Lectura(consulta);

            if (datos.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in datos.Tables[0].Rows)
                {
                    if (fila[5].ToString() != "Argentina")
                    {
                        BEL.GiftcardInternacional tarjeta = new BEL.GiftcardInternacional
                        {
                            Codigo = Convert.ToInt32(fila[0]),
                            Numero = Convert.ToInt32(fila[1]),
                            Vencimiento = Convert.ToDateTime(fila[2]),
                            Estado = fila[3].ToString(),
                            Rubro = fila[4].ToString(),
                            Pais = fila[5].ToString()
                        };

                        if (fila[7].ToString() != "") tarjeta.Saldo = Convert.ToInt32(fila[7]);
                        if (fila[8].ToString() != "") tarjeta.Descuento = Convert.ToInt32(fila[8]);
                        ListaTarjetas.Add(tarjeta);
                    }
                }
            }
            return ListaTarjetas;
        }
        #endregion


        // *---------------------------------------------------------=> MÉTODOS

        public List<BEL.GiftcardInternacional> ListarDisponibles()
        {
            List<BEL.GiftcardInternacional> ListaTarjetas = new List<BEL.GiftcardInternacional>();
            DataSet datos;
            conexion = new DAL.ConexionSQLServer();
            string consulta =
                "SELECT " +
                "Codigo, Numero, Vencimiento, Estado, Rubro, TipoNacProv, Provincia, Saldo " +
                "FROM Tarjetas " +
                "FULL OUTER JOIN ClientesGiftcards " +
                "ON Tarjetas.Codigo = ClientesGiftcards.CodTarjeta " +
                "WHERE Tarjetas.Codigo IS NULL " +
                "OR ClientesGiftcards.CodTarjeta IS NULL " +
                "AND Tarjetas.Provincia IS NULL;";
            datos = conexion.Lectura(consulta);

            if (datos.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in datos.Tables[0].Rows)
                {
                    BEL.GiftcardInternacional tarjeta = new BEL.GiftcardInternacional
                    {
                        Codigo = Convert.ToInt32(fila[0]),
                        Numero = Convert.ToInt32(fila[1]),
                        Vencimiento = Convert.ToDateTime(fila[2]),
                        Estado = fila[3].ToString(),
                        Rubro = fila[4].ToString(),
                        Pais = fila[5].ToString()
                    };

                    if (fila[7].ToString() != "") tarjeta.Saldo = Convert.ToInt32(fila[7]);
                    ListaTarjetas.Add(tarjeta);
                }
            }
            return ListaTarjetas;
        }
    }
}
