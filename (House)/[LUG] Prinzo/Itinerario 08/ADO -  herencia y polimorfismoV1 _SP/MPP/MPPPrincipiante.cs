using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Abstraccion;
using BE;

namespace MPP
{
    public class MPPPrincipiante : IGestor<BEPrincipiante>
    {

        public MPPPrincipiante()      
        {
            oDatos = new Datos();
        

        }

        Datos oDatos;
        Hashtable Hdatos;

        public bool Guardar(BEPrincipiante oBEPrin)
        {
           
            string Consulta = "Alta_JPrincipiante";
            Hdatos = new Hashtable();
            Hdatos.Add("@TAmarilla", oBEPrin.CantidadAmarillas);
            Hdatos.Add("@TRojas", oBEPrin.CantidadRojas);
            Hdatos.Add("@GolesR", oBEPrin.GolesRealizados);
            Hdatos.Add("@Rapado", oBEPrin.Rapado);
            Hdatos.Add("@Nombre", oBEPrin.Nombre);
            Hdatos.Add("@Apellido", oBEPrin.Apellido);
            Hdatos.Add("@DNI", oBEPrin.DNI);

            return oDatos.Escribir(Consulta, Hdatos);
        }

        public BEPrincipiante ListarObjeto(BEPrincipiante oBEprin)
        {
            string Consulta = "Buscar_Jugador_DNI";
            Hdatos = new Hashtable();
            Hdatos.Add("@DNI", oBEprin.DNI);
            DataTable Tabla = oDatos.Leer(Consulta, Hdatos);

            if (Tabla.Rows.Count > 0)

            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEPrincipiante oBEP = new BEPrincipiante();
                    oBEP.Codigo = Convert.ToInt32(fila["Codigo"]);
                    oBEP.Nombre = fila["Nombre"].ToString();
                    oBEP.Apellido = fila["Apellido"].ToString();
                    oBEP.DNI = Convert.ToInt32(fila["DNI"]);
                    return oBEP;
                }
               
            }
            return null;
        }

        public bool Guardar_JugadorXEquipo(BEEquipo oBEEq, BEPrincipiante oBEEPri)
        { //para graabar en la tabla intermedia necesito el codigo de equipo y el codigo de jugador
           //como al jugador lo di de alta recien, necesito el codigo, por eso listo el obejto por DNI
           //si se grabo lo recupero y escribo en la tabla intermedia
           //sino devuelvo falso
            string Consulta;
            BEPrincipiante oBEPriBuscado = new BEPrincipiante();
            oBEPriBuscado = ListarObjeto(oBEEPri);
            if (oBEPriBuscado.Codigo != 0)
            {  
                Consulta = "Alta_Jugador_Equipo";
                Hdatos = new Hashtable();
                Hdatos.Add("@CodEquipo", oBEEq.Codigo);
                Hdatos.Add("@CodJugador", oBEPriBuscado.Codigo);
                return oDatos.Escribir(Consulta, Hdatos);
            }
            else
            {
                return false;
            }
            
        }
  
        public List<BEPrincipiante> ListarTodo()
        {
            throw new NotImplementedException();
        }

      
        public bool Baja(BEPrincipiante Objeto)
        {
            throw new NotImplementedException();
        }

    }
}
