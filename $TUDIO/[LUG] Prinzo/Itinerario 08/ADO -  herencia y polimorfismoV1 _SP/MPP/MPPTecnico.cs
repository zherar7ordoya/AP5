using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Abstraccion;
using DAL;
using System.Data;

namespace MPP
{
    public class MPPTecnico : IGestor<BETecnico>
    {
        public MPPTecnico()
        {
            oDatos = new Datos();
            Hdatos = new Hashtable();
        }

        Datos oDatos;
        Hashtable Hdatos;
        public List<BETecnico> ListarTodo()
        {
            //instancio un objeto de la clase datos para operar con la BD
            List<BETecnico> ListaTecnicos = new List<BETecnico>();
     
            string Consulta = "Listar_Tecnicos";
    
            DataTable Tabla = oDatos.Leer(Consulta,null);

            //rcorro la tabla dentro del Dataset y la paso a lista
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BETecnico oBETec = new BETecnico();
                    oBETec.Codigo = Convert.ToInt32(fila[0]);
                    oBETec.Nombre = fila[1].ToString();
                    oBETec.Apellido = fila["Apellido"].ToString();
                    oBETec.DNI = Convert.ToInt32(fila["DNI"]);
                    ListaTecnicos.Add(oBETec);
                }
            }
            return ListaTecnicos;
        }
 

        public bool Guardar(BETecnico oBETec)
        {           
            string Consulta_SQL = "Modificar_Tecnico"; 
            Hdatos.Add("@Cod", oBETec.Codigo);
            //hago el update del campo estado cuando se asigna el tecnico a un equipo
            Hdatos.Add("@Estado", true);
     
            return oDatos.Escribir(Consulta_SQL,Hdatos);
        }

        public bool Baja(BETecnico Objeto)
        {
            throw new NotImplementedException();
        }
        public BETecnico ListarObjeto(BETecnico Objeto)
        {
            throw new NotImplementedException();
        }

     
    }
}
