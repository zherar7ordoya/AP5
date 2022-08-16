using BE;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLL_Rol : Informacion, ABSTRACTA.IGestor<BE.BE_Rol>
    {
        readonly MPP.MPP_Rol MPP_ROL;
        readonly string MENSAJE;
        public BLL_Rol() => MPP_ROL = new MPP.MPP_Rol();
        public BLL_Rol(string mensaje = "Soy la clase ROL y sé calcular. ")
        {
            MPP_ROL = new MPP.MPP_Rol();
            MENSAJE = mensaje;
            Informar();
        }

        //              ▂▃▄▅▆▇█▓▒░ IMPLEMENTA INTERFAZ ░▒▓█▇▆▅▄▃▂

        public bool Eliminar(BE_Rol rol)
        {
            return MPP_ROL.Eliminar(rol);
        }


        public bool Guardar(BE_Rol rol)
        {
            return MPP_ROL.Guardar(rol);
        }


        public BE_Rol ListarObjeto(BE_Rol objeto)
        {
            throw new NotImplementedException();
        }


        public List<BE_Rol> ListarTodo()
        {
            return MPP_ROL.ListarTodo();
        }

        // •°*”˜˜”*°•.ƸӜƷ.•°*”˜˜”*°•.ƸӜƷ•°*”˜˜”*°•.ƸӜƷ.•°*”˜˜”*°•.ƸӜƷ•°*”˜˜”*°•

        public override void Informar()
        {
            int calculo = 10;
            string mensaje = MENSAJE + $"Por ejemplo: 1 + 2 + 3 + 4 = {calculo}";
            System
                .Diagnostics
                .Debug
                .WriteLine(mensaje);
        }

    }
}
