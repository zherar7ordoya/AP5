using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Abstract;
using MAPPER;


namespace BLL
{
    public class BLLVehiculo : IGestor<Vehiculo>
    {
        MPPVehiculo mppvehiculo;
        public BLLVehiculo() 
        {
            mppvehiculo = new MPPVehiculo();
        }
        public bool Borrar(Vehiculo Objeto)
        {
            return mppvehiculo.Borrar(Objeto);
        }

        public bool Guardar(Vehiculo Objeto)
        {
            return mppvehiculo.Guardar(Objeto);
        }

        public List<Vehiculo> ListarTodo()
        {
            return mppvehiculo.ListarTodo();
        }
        
        public List<Vehiculo> ListarTodoAuto()
        {
            return mppvehiculo.ListarTodoAuto();
        }

        public List<Vehiculo> ListarTodoMoto()
        {
            return mppvehiculo.ListarTodoMoto();
        }
        public bool Modificar(Vehiculo Objeto)
        {
            return mppvehiculo.Guardar(Objeto);
        }
    }
}
