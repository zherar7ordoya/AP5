using System;
using System.Collections.Generic;
using System.Data;

namespace DML
{
    public class GiftcardNacional : ABS.IGestor<BEL.GiftcardNacional>
    {
        DAL.ConexionSQLServer conexion;


        // *---------------------------------------------=> IMPLEMENTA INTERFAZ

        public BEL.GiftcardNacional Detallar(BEL.GiftcardNacional codigo)
        {
            conexion = new DAL.ConexionSQLServer();
            string consulta = 
                "SELECT " +
                "Codigo, Numero, Vencimiento, Estado, Rubro, TipoNacProv, Provincia, Saldo " +
                "FROM Tarjetas " +
                $"WHERE Codigo = { codigo.Codigo }";
            DataSet datos = conexion.Lectura(consulta);

            if (datos.Tables[0].Rows.Count > 0)
            {
                BEL.GiftcardNacional belGifgcardNacional = new BEL.GiftcardNacional();

                foreach (DataRow fila in datos.Tables[0].Rows)
                {
                    belGifgcardNacional.Codigo = Convert.ToInt32(fila[0]);
                    belGifgcardNacional.Numero = Convert.ToInt32(fila[1]);
                    belGifgcardNacional.Vencimiento = Convert.ToDateTime(fila[2]);
                    belGifgcardNacional.Estado = fila[3].ToString();
                    belGifgcardNacional.Rubro = fila[4].ToString();
                    belGifgcardNacional.Pais = fila[5].ToString();
                    belGifgcardNacional.Provincia = fila[6].ToString();

                    if (fila[7].ToString() != "") belGifgcardNacional.Saldo = Convert.ToInt32(fila[7]);
                }
                return belGifgcardNacional;
            }
            else
            {
                return null;
            }
        }


        public bool Eliminar(BEL.GiftcardNacional tarjeta)
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
                    $"WHERE CodTarjeta = {tarjeta.Codigo}";
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


        public bool Guardar(BEL.GiftcardNacional tarjeta)
        {
            string consulta;

            if (tarjeta.Codigo == 0)
            {
                consulta = 
                    "INSERT INTO Tarjetas " +
                    "(Numero, Vencimiento, Estado, Rubro, TipoNacProv, Provincia) " +
                    "VALUES(" +
                    $"{ tarjeta.Numero }, " +
                    $"'{ tarjeta.Vencimiento }', " +
                    $"'{ tarjeta.Estado }', " +
                    $"'{ tarjeta.Rubro }', " +
                    $"'{ tarjeta.Pais }', " +
                    $"'{ tarjeta.Provincia }')";
            }
            else
            {
                consulta =
                    "UPDATE Tarjetas " +
                    "SET " +
                    $"Numero = { tarjeta.Numero }, " +
                    $"Vencimiento = '{ tarjeta.Vencimiento }', " +
                    $"Estado = '{ tarjeta.Estado }', " +
                    $"Saldo = { tarjeta.Saldo }, " +
                    $"Rubro = '{ tarjeta.Rubro }', " +
                    $"TipoNacProv = '{ tarjeta.Pais }', " +
                    $"Provincia = '{ tarjeta.Provincia }' " +
                    $"WHERE Codigo = { tarjeta.Codigo }";
            }
            conexion = new DAL.ConexionSQLServer();
            return conexion.Escritura(consulta);
        }


        public List<BEL.GiftcardNacional> Listar()
        {
            List<BEL.GiftcardNacional> ListaTarjetas = new List<BEL.GiftcardNacional>();
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
                    if (fila[5].ToString() == "Argentina")
                    {
                        BEL.GiftcardNacional tarjeta = new BEL.GiftcardNacional
                        {
                            Codigo = Convert.ToInt32(fila[0]),
                            Numero = Convert.ToInt32(fila[1]),
                            Vencimiento = Convert.ToDateTime(fila[2]),
                            Estado = fila[3].ToString(),
                            Rubro = fila[4].ToString(),
                            Pais = fila[5].ToString(),
                            Provincia = fila[6].ToString()
                        };
                        if (fila[7].ToString() != "") tarjeta.Saldo = Convert.ToInt32(fila[7]);
                        if (fila[8].ToString() != "") tarjeta.Descuento = Convert.ToInt32(fila[8]);
                        ListaTarjetas.Add(tarjeta);
                    }
                }
            }
            return ListaTarjetas;
        }


        // *---------------------------------------------------------=> MÉTODOS

        public List<BEL.GiftcardNacional> ListarDisponibles()
        {
            List<BEL.GiftcardNacional> ListaTarjetas = new List<BEL.GiftcardNacional>();
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
                "AND Tarjetas.Provincia IS NOT NULL;";
            datos = conexion.Lectura(consulta);

            if (datos.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in datos.Tables[0].Rows)
                {
                    BEL.GiftcardNacional tarjeta = new BEL.GiftcardNacional
                    {
                        Codigo = Convert.ToInt32(fila[0]),
                        Numero = Convert.ToInt32(fila[1]),
                        Vencimiento = Convert.ToDateTime(fila[2]),
                        Estado = fila[3].ToString(),
                        Rubro = fila[4].ToString(),
                        Pais = fila[5].ToString(),
                        Provincia = fila[6].ToString()
                    };

                    if (fila[7].ToString() != "") tarjeta.Saldo = Convert.ToInt32(fila[7]);
                    ListaTarjetas.Add(tarjeta);
                }
            }
            return ListaTarjetas;
        }
    }
}
