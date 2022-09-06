using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using Abstraccion;
using System.Data;
using System.Collections;

namespace MPP
{
    public class MPPCliente:IGestor<BECliente>
    {
        #region "Constructor"
        public MPPCliente()
        {
            oDatos = new Acceso();
        }
        Acceso oDatos;
        #endregion

        #region "Metodos"
        public bool Guardar(BECliente Objeto)
        {
            Hdatos = new Hashtable();
            string Consulta = "s_Cliente_Alta";

            //Verifico si es un cliente nuevo o ya cargado
            if (Objeto.Codigo != 0)
            {
                Hdatos.Add("@Codigo", Objeto.Codigo);
                //Si ya esta cargado cambio la consulta a modificar
                Consulta = "s_Cliente_Modificar";


                //Valido que tipo de tarjeta tiene el cliente y asigno los parametros
                if (Objeto.TarjetaInternacional != null)
                {
                    Hdatos.Add("@CodTarjeta", Objeto.TarjetaInternacional.Codigo);
                }

                if (Objeto.TarjetaNacional != null)
                { 
                    Hdatos.Add("@CodTarjeta", Objeto.TarjetaNacional.Codigo);             
                }
                //Si no tiene tarjetas asociadas, enviar un null a tarjeta 
                if (Objeto.TarjetaNacional == null && Objeto.TarjetaInternacional == null)
                {

                    Hdatos.Add("@CodTarjeta", DBNull.Value); 
                }
            }
            //Cargo los parametros
            Hdatos.Add("@Nombre", Objeto.Nombre);
            Hdatos.Add("@Apellido", Objeto.Apellido);
            Hdatos.Add("@DNI", Objeto.DNI);
            Hdatos.Add("@FechaNac", Objeto.FechaNacimiento.ToShortDateString());
      
            
            //Si bien el codigo es autoincremental en la base, se verifica que no haya DNIs repetidos
            //Tambien se chequea que se trate de una modificacion y no de un nuevo usuario
            if (Existe_DNI(Objeto) == false) { return oDatos.Escribir(Consulta, Hdatos); }
            else { return false; }

        }
        //Defino hashtable
        Hashtable Hdatos;
        public bool Baja(BECliente Objeto)
        {
            //Verificacion de si tiene tarjetas asociadas en UI
            Hdatos = new Hashtable();
            //Parametro de baja
            Hdatos.Add("@Codigo", Objeto.Codigo);
                return oDatos.Escribir("s_Cliente_Baja", Hdatos);
          
        }

        public List<BECliente> ListarTodo()
        {
            List<BECliente> listaclientes = new List<BECliente>();
            DataTable Dt = oDatos.Leer("s_Cliente_Listar", null);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow Item in Dt.Rows)
                {
                    //Creo objeto cliente auxiliar
                    BECliente aux = new BECliente();
                    //Asigno los datos traidos del datatable
                    aux.Codigo = Convert.ToInt32(Item[0]);
                    aux.Nombre = Item[1].ToString();
                    aux.Apellido = Item[2].ToString();
                    aux.DNI = Convert.ToInt32(Item[3]);
                    aux.FechaNacimiento = Convert.ToDateTime(Item[4]);
                    //Creo un objeto auxiliar cualquiera, de la clase BETarjeta pero instanciado como TarjetaInter
                    //solo para tomar el codigo de la base
                    BETarjeta auxiliar= new BETarjetaInternacional();

                    if (!(Item[5] is DBNull)) auxiliar.Codigo = Convert.ToInt32(Item[5]);
                    //aux.Tarjeta.Codigo = Convert.ToInt32(Item[5]);

                    //Cargo el objeto Tarjeta del Cliente
                    Hdatos = new Hashtable();
                    Hdatos.Add("@CodTarjeta", auxiliar.Codigo);
                    DataTable Dt2 = oDatos.Leer("s_ClienteTarjeta_Asignada", Hdatos);

                    if (Dt2.Rows.Count > 0)
                    {
                        foreach (DataRow Item2 in Dt2.Rows)
                        {
                            if ((string)Item2[6] ==string.Empty)
                            {
                                //Entonces es Internacional
                                BETarjetaInternacional tarjeta = new BETarjetaInternacional();
                                tarjeta.Codigo = Convert.ToInt32(Item2[0]);
                                tarjeta.Numero = Convert.ToInt32(Item2[1]);
                                tarjeta.FechaVencimiento = (DateTime)Item2[2];
                                tarjeta.Saldo = Convert.ToDouble(Item2[3]);
                                tarjeta.EnumEstado = (BETarjeta.Estado)Enum.Parse(typeof(BETarjeta.Estado), Item2[4].ToString());
                                tarjeta.EnumRubro = (BETarjeta.Rubro)Enum.Parse(typeof(BETarjeta.Rubro), Item2[5].ToString());
                                //Se chequea que el descuento acumulado no sea null
                                if(Item2[8] is DBNull)
                                {
                                    tarjeta.DescuentoAcumulado = 0;
                                }
                                else { tarjeta.DescuentoAcumulado = Convert.ToDouble(Item2[8]); }
                                
                                
                                tarjeta.Pais = Item2[7].ToString();
                                //Se carga el objeto tarjeta dentro del cliente
                                aux.TarjetaInternacional = tarjeta;
                            }
                            if ((string)Item2[7] == string.Empty)
                            {
                                //Entonces es Nacional
                                BETarjetaNacional tarjeta = new BETarjetaNacional();
                                tarjeta.Codigo = Convert.ToInt32(Item2[0]);
                                tarjeta.Numero = Convert.ToInt32(Item2[1]);
                                tarjeta.FechaVencimiento = (DateTime)Item2[2];
                                tarjeta.Saldo = Convert.ToDouble(Item2[3]);
                                tarjeta.EnumEstado = (BETarjeta.Estado)Enum.Parse(typeof(BETarjeta.Estado), Item2[4].ToString());
                                tarjeta.EnumRubro = (BETarjeta.Rubro)Enum.Parse(typeof(BETarjeta.Rubro), Item2[5].ToString());
                                //Se chequea que el descuento acumulado no sea null
                                if (Item2[8] is DBNull)
                                {
                                    tarjeta.DescuentoAcumulado = 0;
                                }
                                else { tarjeta.DescuentoAcumulado = Convert.ToDouble(Item2[8]); }

                                tarjeta.Provincia = Item2[6].ToString();
                                //Se carga el objeto tarjeta dentro del cliente
                                aux.TarjetaNacional = tarjeta;
                            }

                        }
                    }

                    //Cargo la lista de clientes junto con sus tarjetas
                    listaclientes.Add(aux);

                }

               

                

                return listaclientes;
            }
            else
            {
                return null;
            }
           
        }

        public BECliente ListarObjeto(BECliente Objeto)
        {
            throw new NotImplementedException();
        }


        //Metodo para corroborar si existe DNI duplicado
        private bool Existe_DNI(BECliente obj)
        {
            Hashtable Hdatos2 = new Hashtable();

            if (obj.Codigo == 0)
            {
                Hdatos2.Add("@DNI", obj.DNI);

                return oDatos.LeerScalar("s_Cliente_ExisteDNI", Hdatos2);

            }
            else { return false; }
        }
        #endregion
    }
}
