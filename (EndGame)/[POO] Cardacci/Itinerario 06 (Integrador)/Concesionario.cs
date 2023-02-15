using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    // TODO Maneja la lista de Autos y Personas.
    class Concesionario
    {
        List<Auto> _la;
        List<Persona> _lp;

        public Concesionario()
        {
            _la = new List<Auto>();
            _lp = new List<Persona>();
        }

        public List<Persona> RetornaListaPersonas()
        {
            List<Persona> _auxlp = new List<Persona>();
            foreach (Persona _p in _lp)
            {
                _auxlp.Add(new Persona(_p.DNI, _p.Nombre, _p.Apellido));
            }
            return _auxlp;
        }


        public void AgregarPersona(Persona pPersona)
        {
            try
            {
                if (pPersona != null)
                {
                    _lp.Add(new Persona(
                        pPersona.DNI,
                        pPersona.Nombre,
                        pPersona.Apellido));
                }
                else
                {
                    throw new Exception("La persona es NULL");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BorrarPersona(Persona pPersona)
        {
            try
            {
                if (pPersona != null)
                {
                    Persona _auxp = _lp.Find(x => x.DNI == pPersona.DNI);
                    if (_auxp != null)
                    {
                        _lp.Remove(_auxp);
                    }
                    else
                    {
                        throw new Exception("La persona que intenta borrar no existe");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void ModificarPersona(Persona pPersona)
        {
            try
            {
                if (pPersona != null)
                {
                    // ¿Funciona porque en auxiliar estoy cargando por referencia?
                    Persona _auxp = _lp.Find(x => x.DNI == pPersona.DNI);
                    if (_auxp != null)
                    {
                        _auxp.DNI = pPersona.DNI;
                        _auxp.Nombre = pPersona.Nombre;
                        _auxp.Apellido = pPersona.Apellido;
                    }
                    else
                    {
                        throw new Exception("La persona que intenta modificar no existe");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
