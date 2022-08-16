using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DML
{
    public class Cliente : ABS.IGestor<BEL.Cliente>
    {
        DAL.ConexionSQLServer conexion;

        #region IMPLEMENTA INTERFAZ
        // *---------------------------------------------------------------=> *
        public bool Eliminar(BEL.Cliente cliente)
        {
            conexion = new DAL.ConexionSQLServer();
            string consulta;

            if (cliente.Tarjeta != null)
            {
                foreach (BEL.GiftcardNacional tarjeta in cliente.Tarjeta)
                {
                    consulta =
                        "UPDATE Tarjetas " +
                        "SET Estado = 'Baja' " +
                        $"WHERE Codigo = { tarjeta.Codigo }";
                    conexion.Escritura(consulta);
                }
            }
            consulta = 
                "DELETE FROM Clientes " +
                $"WHERE Codigo = { cliente.Codigo }";
            return conexion.Escritura(consulta);
        }

        // *---------------------------------------------------------------=> *
        public bool Guardar(BEL.Cliente cliente)
        {
            string consulta;

            if (cliente.Codigo == 0)
            {
                consulta = 
                    "INSERT INTO Clientes(Nombre, Apellido, DNI, FechaNacimiento) " +
                    "VALUES(" +
                    $"'{ cliente.Nombre }', " +
                    $"'{ cliente.Apellido }', " +
                    $"{ cliente.DNI }, " +
                    $"'{ cliente.FechaNacimiento }')";
            }
            else
            {
                consulta =
                    "UPDATE Clientes " +
                    "SET " +
                    $"Nombre = '{ cliente.Nombre }', " +
                    $"Apellido = '{ cliente.Apellido }', " +
                    $"DNI = { cliente.DNI }, " +
                    $"FechaNacimiento = '{ cliente.FechaNacimiento }'" +
                    $"WHERE Codigo = { cliente.Codigo }";
            }
            conexion = new DAL.ConexionSQLServer();
            return conexion.Escritura(consulta);
        }

        // *---------------------------------------------------------------=> *
        public List<BEL.Cliente> Listar()
        {
            List<BEL.Cliente> ListaClientes = new List<BEL.Cliente>();

            try
            {
                DataSet DatosCliente;
                conexion = new DAL.ConexionSQLServer();

                string consulta =
                    "SELECT Codigo, Nombre, Apellido, DNI, FechaNacimiento " +
                    "FROM Clientes";

                DatosCliente = conexion.Lectura(consulta);

                if (DatosCliente.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow FilaCliente in DatosCliente.Tables[0].Rows)
                    {
                        BEL.Cliente cliente = new BEL.Cliente
                        {
                            Codigo = Convert.ToInt32(FilaCliente[0]),
                            Nombre = FilaCliente[1].ToString(),
                            Apellido = FilaCliente[2].ToString(),
                            DNI = Convert.ToInt32(FilaCliente[3]),
                            FechaNacimiento = Convert.ToDateTime(FilaCliente[4])
                        };

                        DataSet DatosTarjeta;

                        consulta =
                            "SELECT " +
                            "Tarjetas.Codigo, " +
                            "Numero, " +
                            "Vencimiento, " +
                            "Estado, " +
                            "Rubro, " +
                            "TipoNacProv, " +
                            "Provincia, " +
                            "Saldo " +
                            "FROM Tarjetas, ClientesGiftcards " +
                            "WHERE ClientesGiftcards.CoDTarjeta = Tarjetas.Codigo " +
                            $"AND ClientesGiftcards.CodCliente = { cliente.Codigo }";

                        DatosTarjeta = conexion.Lectura(consulta);

                        if (DatosTarjeta.Tables[0].Rows.Count > 0)
                        {
                            List<BEL.Giftcard> ListaTarjetas = new List<BEL.Giftcard>();

                            foreach (DataRow FilaTarjeta in DatosTarjeta.Tables[0].Rows)
                            {
                                if (FilaTarjeta[7] == null)
                                {
                                    BEL.GiftcardInternacional tarjeta = new BEL.GiftcardInternacional
                                    {
                                        Codigo = Convert.ToInt32(FilaTarjeta[0]),
                                        Numero = Convert.ToInt32(FilaTarjeta[1]),
                                        Vencimiento = Convert.ToDateTime(FilaTarjeta[2]),
                                        Estado = FilaTarjeta[3].ToString(),
                                        Rubro = FilaTarjeta[4].ToString(),
                                        Pais = FilaTarjeta[5].ToString()
                                    };
                                    if (FilaTarjeta[7].ToString() != "") tarjeta.Saldo = Convert.ToInt32(FilaTarjeta[7]);
                                    ListaTarjetas.Add(tarjeta);
                                }
                                else
                                {
                                    BEL.GiftcardNacional tarjeta = new BEL.GiftcardNacional
                                    {
                                        Codigo = Convert.ToInt32(FilaTarjeta[0]),
                                        Numero = Convert.ToInt32(FilaTarjeta[1]),
                                        Vencimiento = Convert.ToDateTime(FilaTarjeta[2]),
                                        Estado = FilaTarjeta[4].ToString(),
                                        Rubro = FilaTarjeta[5].ToString(),
                                        Pais = FilaTarjeta[6].ToString(),
                                        Provincia = FilaTarjeta[7].ToString()
                                    };
                                    if (FilaTarjeta[7].ToString() != "") tarjeta.Saldo = Convert.ToInt32(FilaTarjeta[7]);
                                    ListaTarjetas.Add(tarjeta);
                                }
                            }
                        }
                        ListaClientes.Add(cliente);
                    }
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

            return ListaClientes;
        }

        // *---------------------------------------------------------------=> *
        public BEL.Cliente Detallar(BEL.Cliente codigo)
        {
            BEL.Cliente cliente = new BEL.Cliente();
            try
            {
                DataSet DatosCliente;
                conexion = new DAL.ConexionSQLServer();

                string consulta =
                    "SELECT Codigo, Nombre, Apellido, DNI, FechaNacimiento " +
                    "FROM Clientes " +
                    $"WHERE Codigo = { codigo.Codigo }";

                DatosCliente = conexion.Lectura(consulta);

                if (DatosCliente.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow FilaCliente in DatosCliente.Tables[0].Rows)
                    {
                        cliente.Codigo = Convert.ToInt32(FilaCliente[0]);
                        cliente.Nombre = FilaCliente[1].ToString();
                        cliente.Apellido = FilaCliente[2].ToString();
                        cliente.DNI = Convert.ToInt32(FilaCliente[3]);
                        cliente.FechaNacimiento = Convert.ToDateTime(FilaCliente[4]);

                        DataSet DatosTarjeta;

                        consulta =
                            "SELECT " +
                            "Tarjetas.Codigo, " +
                            "Numero, " +
                            "Vencimiento, " +
                            "Estado, " +
                            "Rubro, " +
                            "TipoNacProv, " +
                            "Saldo, " +
                            "Provincia " +
                            "FROM Tarjetas, ClientesGiftcards " +
                            "WHERE ClientesGiftcards.CodTarjeta = Tarjetas.Codigo " +
                            $"AND ClientesGiftcards.CodCliente = { codigo.Codigo }";

                        DatosTarjeta = conexion.Lectura(consulta);

                        if (DatosTarjeta.Tables[0].Rows.Count > 0)
                        {
                            List<BEL.Giftcard> ListaTarjetas = new List<BEL.Giftcard>();

                            foreach (DataRow FilaTarjeta in DatosTarjeta.Tables[0].Rows)
                            {
                                if (FilaTarjeta[7].ToString() == "")
                                {
                                    BEL.GiftcardInternacional tarjeta = new BEL.GiftcardInternacional
                                    {
                                        Codigo = Convert.ToInt32(FilaTarjeta[0]),
                                        Numero = Convert.ToInt32(FilaTarjeta[1]),
                                        Vencimiento = Convert.ToDateTime(FilaTarjeta[2]),
                                        Estado = FilaTarjeta[3].ToString(),
                                        Rubro = FilaTarjeta[4].ToString(),
                                        Pais = FilaTarjeta[5].ToString()
                                    };

                                    if (FilaTarjeta[6].ToString() != "") tarjeta.Saldo = Convert.ToInt32(FilaTarjeta[6]);
                                    ListaTarjetas.Add(tarjeta);
                                }
                                else
                                {
                                    BEL.GiftcardNacional tarjeta = new BEL.GiftcardNacional
                                    {
                                        Codigo = Convert.ToInt32(FilaTarjeta[0]),
                                        Numero = Convert.ToInt32(FilaTarjeta[1]),
                                        Vencimiento = Convert.ToDateTime(FilaTarjeta[2]),
                                        Estado = FilaTarjeta[3].ToString(),
                                        Rubro = FilaTarjeta[4].ToString(),
                                        Pais = FilaTarjeta[5].ToString()
                                    };

                                    if (FilaTarjeta[6].ToString() != "") tarjeta.Saldo = Convert.ToInt32(FilaTarjeta[6]);
                                    tarjeta.Provincia = FilaTarjeta[7].ToString();
                                    ListaTarjetas.Add(tarjeta);
                                }
                                cliente.Tarjeta = ListaTarjetas;
                            }
                        }
                    }
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

            return cliente;
        }
        #endregion


        #region MÉTODOS
        public bool AsociarGiftcardInternacional(BEL.Cliente cliente, BEL.GiftcardInternacional tarjeta)
        {
            string consulta =
                "INSERT INTO ClientesGiftcards(CodCliente, CodTarjeta) " +
                $"VALUES({ cliente.Codigo }, { tarjeta.Codigo })";
            return EscribirConsulta(consulta);
        }

        public bool AsociarGiftcardNacional(BEL.Cliente cliente, BEL.GiftcardNacional tarjeta)
        {
            string consulta =
                "INSERT INTO ClientesGiftcards(CodCliente, CodTarjeta) " +
                $"VALUES({ cliente.Codigo }, { tarjeta.Codigo })";
            return EscribirConsulta(consulta);
        }

        public bool DesasociarGiftcardInternacional(BEL.Cliente cliente, BEL.GiftcardInternacional tarjeta)
        {
            string consulta = 
                "DELETE FROM ClientesGiftcards " +
                $"WHERE CodCliente = { cliente.Codigo } " +
                $"AND CodTarjeta = { tarjeta.Codigo }";
            return EscribirConsulta(consulta);
        }

        public bool DesasociarGiftcardNacional(BEL.Cliente cliente, BEL.GiftcardNacional tarjeta)
        {
            string consulta = 
                "DELETE FROM ClientesGiftcards " +
                $"WHERE CodCliente = { cliente.Codigo } " +
                $"AND CodTarjeta = { tarjeta.Codigo }";
            return EscribirConsulta(consulta);
        }

        internal bool EscribirConsulta(string consulta)
        {
            conexion = new DAL.ConexionSQLServer();
            return conexion.Escritura(consulta);
        }
        #endregion
    }
}
