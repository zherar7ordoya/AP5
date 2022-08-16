using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Abstraccion;
using BE;
using System.Data;

namespace MPP
{
    public class MPPProfesional:IGestor<BEProfesional>
    {

        public MPPProfesional()
        {
            oDatos = new Datos();
        
        }

        Datos oDatos;
        Hashtable Hdatos;



        public bool Guardar(BEProfesional oBEProf)
        {
            
            string Consulta = "Alta_JProfesional";
            Hdatos = new Hashtable();
            Hdatos.Add("@TAmarilla", oBEProf.CantidadAmarillas);
            Hdatos.Add("@TRojas", oBEProf.CantidadRojas);
            Hdatos.Add("@GolesR", oBEProf.GolesRealizados);
            Hdatos.Add("@Nombre", oBEProf.Nombre);
            Hdatos.Add("@Apellido", oBEProf.Apellido);
            Hdatos.Add("@DNI", oBEProf.DNI);

            return oDatos.Escribir(Consulta, Hdatos); 
        }

        public BEProfesional ListarObjeto(BEProfesional oBEProf)
        {
            string Consulta = "Buscar_Jugador_DNI";
            Hdatos = new Hashtable();
            Hdatos.Add("@DNI",oBEProf.DNI);
            DataTable Tabla = oDatos.Leer(Consulta,Hdatos);

            if (Tabla.Rows.Count > 0)

            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEProfesional oBEP = new BEProfesional();
                    oBEP.Codigo = Convert.ToInt32(fila["Codigo"]);
                    oBEP.Nombre = fila["Nombre"].ToString();
                    oBEP.Apellido = fila["Apellido"].ToString();
                    oBEP.DNI = Convert.ToInt32(fila["DNI"]);
                    return oBEP;
                }

            }
            return null;
        }

        public bool Guardar_JugadorXEquipo(BEEquipo oBEEq, BEProfesional oBEEProf)
        { //para graabar en la tabla intermedia necesito el codigo de equipo y el codigo de jugador
          //como al jugador lo di de alta recien, necesito el codigo, por eso listo el obejto por DNI
          //si se grabo lo recupero y escribo en la tabla intermedia
          //sino devuelvo falso
            string Consulta;
            BEProfesional oBEProfBuscado = new BEProfesional();
            oBEProfBuscado = ListarObjeto(oBEEProf);
            if (oBEProfBuscado.Codigo != 0)
            {
                Consulta = "Alta_Jugador_Equipo";
                Hdatos = new Hashtable();
                Hdatos.Add("@CodEquipo", oBEEq.Codigo);
                Hdatos.Add("@CodJugador", oBEProfBuscado.Codigo);
                return oDatos.Escribir(Consulta,Hdatos);
            }
            else
            {
                return false;
            }

        }

        public bool Baja(BEProfesional Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEProfesional> ListarTodo()
        {
            throw new NotImplementedException();
        }

 
    }
}
