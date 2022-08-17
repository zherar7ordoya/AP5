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
    public class MPPTarjetaNacional : IGestor<BETarjetaNacional>
    {
        #region "Constructor"
        public MPPTarjetaNacional()
        {
            oDatos = new Acceso();
        }
        Acceso oDatos;
        Hashtable Hdatos;
        #endregion

        #region "Metodos"
        public bool Baja(BETarjetaNacional Objeto)
        {
            Hdatos = new Hashtable();
            //Parametro de baja
            Hdatos.Add("@Codigo", Objeto.Codigo);
            return oDatos.Escribir("s_Tarjeta_Baja", Hdatos);
        }

        public bool Guardar(BETarjetaNacional Objeto)
        {
            Hdatos = new Hashtable();
            string Consulta = "s_Tarjeta_Alta";

            //Verifico si es un cliente nuevo o ya cargado
            if (Objeto.Codigo != 0)
            {
                Hdatos.Add("@Codigo", Objeto.Codigo);
                //Si ya esta cargado cambio la consulta a modificar
                Consulta = "s_Tarjeta_Modificar";
                //Si ya existe, que no altere su estado
                Hdatos.Add("@Estado", Objeto.EnumEstado);
            }
            else
            {
                //Si la tarjeta es nueva, se crea con estado sin asignar
                Objeto.EnumEstado = BETarjeta.Estado.Sin_Asignar;
                Hdatos.Add("@Estado", Objeto.EnumEstado);
            }
            //Cargo los parametros
            Hdatos.Add("@Numero", Objeto.Numero);
            Hdatos.Add("@FechaVencimiento", Objeto.FechaVencimiento.ToShortDateString());
            Hdatos.Add("@Saldo", Objeto.Saldo);
            Hdatos.Add("@Rubro", Objeto.EnumRubro);
            Hdatos.Add("@Provincia", Objeto.Provincia);
            Hdatos.Add("@Pais", String.Empty);
            Hdatos.Add("@DescuentoAcumulado", Objeto.DescuentoAcumulado);



            //Se verifica que no haya Numeros de tarjeta repetidos
            //Tambien se chequea que se trate de una modificacion y no de un nuevo usuario
            if (Existe_NumTarjeta(Objeto) == false) { return oDatos.Escribir(Consulta, Hdatos); }
            else
            {
                System.Windows.Forms.MessageBox.Show("El numero de tarjeta ingresado ya existe","Error");
                return false; 
            }
        }

        public BETarjetaNacional ListarObjeto(BETarjetaNacional Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BETarjetaNacional> ListarTodo()
        {
            List<BETarjetaNacional> listatarjetas = new List<BETarjetaNacional>();

            DataTable Dt = oDatos.Leer("s_Tarjeta_Listar", null);


            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow Item in Dt.Rows)
                {
                    //Si es null, es nacional (campo pais=null)
                    if ((string)Item[7]=="")
                    {
                        BETarjetaNacional aux = new BETarjetaNacional();
                        aux.Codigo = Convert.ToInt32(Item[0]);
                        aux.Numero = Convert.ToInt32(Item[1]);
                        aux.FechaVencimiento = Convert.ToDateTime(Item[2]);
                        aux.Saldo = Convert.ToDouble(Item[3]);
                        aux.EnumEstado = (BETarjeta.Estado)Enum.Parse(typeof(BETarjeta.Estado), Item[4].ToString());
                        aux.EnumRubro = (BETarjeta.Rubro)Enum.Parse(typeof(BETarjeta.Rubro), Item[5].ToString());
                        aux.Provincia = Item[6].ToString();
                        if (Item[8] is DBNull)
                        {
                            aux.DescuentoAcumulado = 0;
                        }
                        else { aux.DescuentoAcumulado = Convert.ToDouble(Item[8]); }
                        listatarjetas.Add(aux);
                    }


                }
                return listatarjetas;
            }
            return null;
        }

        bool Existe_NumTarjeta(BETarjetaNacional obj)
        {
            Hashtable Hdatos2 = new Hashtable();

            if (obj.Codigo == 0)
            {
                Hdatos2.Add("@Numero", obj.Numero);

                return oDatos.LeerScalar("s_Tarjeta_ExisteNum", Hdatos2);

            }
            else { return false; }
        }
        #endregion  
    }

}
