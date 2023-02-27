using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador
{

    class Concesionario
    {
        List<Auto> _la;
        List<Cliente> _lp;

        public Concesionario()
        {
            _la = new List<Auto>();
            _lp = new List<Cliente>();
        }


        private void OrdenEjecucion(object sender, OrdenEventArgs e)
        {
            MessageBox.Show($"Orden ejecutada por {e.ValorDevuelto}) {e.EnEjecucion.Nombre} {e.EnEjecucion.Apellido}");
        }


        public List<Cliente> RetornaListaPersonas()
        {

            List<Cliente> _auxlp;
            try
            {
                _auxlp = new List<Cliente>();
                foreach (Cliente _p in _lp)
                {
                    _auxlp.Add(new Cliente(_p.DNI, _p.Nombre, _p.Apellido));
                }
                foreach (Cliente _p in _auxlp)
                {
                    _p.OrdenEventHandler += OrdenEjecucion;
                }
                _auxlp.Sort();
            }
            catch (Exception ex) { throw ex; }

            return _auxlp;
        }
        public List<Auto> RetornaListaAutos()
        {

            List<Auto> _auxla;
            try
            {
                _auxla = new List<Auto>();
                foreach (Auto _a in _la)
                {
                    _auxla.Add(new Auto(_a.Patente, _a.Marca, _a.Modelo, _a.Axo, _a.Precio,
                                        _a.Get_Dueno() != null ? new Cliente(_a.Get_Dueno().DNI, _a.Get_Dueno().Nombre, _a.Get_Dueno().Apellido) : null));
                }
            }
            catch (Exception ex) { throw ex; }

            return _auxla;
        }
        public void AgregaPersona(Cliente pPersona)
        {
            try
            {
                if (pPersona != null)
                {
                    _lp.Add(new Cliente(pPersona.DNI, pPersona.Nombre, pPersona.Apellido));
                }
                else { throw new Exception("La Persona que intenta agregar es null"); }
            }
            catch (Exception ex) { throw ex; }
        }
        public void AgregaAuto(Auto pAuto)
        {
            try
            {
                if (pAuto != null)
                {
                    _la.Add(new Auto(pAuto.Patente, pAuto.Marca, pAuto.Modelo, pAuto.Axo, pAuto.Precio));
                }
                else { throw new Exception("El auto que intenta agregar es null"); }
            }
            catch (Exception ex) { throw ex; }
        }
        public void BorraPersona(Cliente pPersona)
        {
            try
            {
                // Se observa que pPersona sea distinta de nulo
                if (pPersona != null)
                {
                    // Se obtiene la Persona de la lista de personas del concecionario por el DNI de la persona enviada
                    Cliente _auxPersona = _lp.Find(x => x.DNI == pPersona.DNI);

                    // Si la persona existe y non tiene autos asignados se permite el borrado
                    if (_auxPersona != null && _auxPersona.RetornaListaAutos().Count == 0)
                    {
                        // Se borra la persona de la lista de personas del concesionario
                        _lp.Remove(_auxPersona);

                        // Con esto disparo el evento de la clase Persona que
                        // avisa que se ha llamado al destructor.
                        _auxPersona = null;
                    }
                    else
                    {
                        throw new Exception("La Persona que intenta borrar no existe o posee Autos asignados !!!");
                    }

                }
                else { throw new Exception("La Persona que intenta borrar es null"); }
            }
            catch (Exception ex) { throw ex; }
        }
        public void BorraAuto(Auto pAuto)
        {
            try
            {
                // Verifica que pAuto se a distinto de  ulo
                if (pAuto != null)
                {
                    // Se obtiene el auto de la lista de autos del concecionario por la patente del auto enviado
                    Auto _auxAuto = _la.Find(x => x.Patente == pAuto.Patente);
                    // Si el auto existe y no está asignado se permite su borrado
                    if (_auxAuto != null && _auxAuto.Get_Dueno() == null)
                    {
                        // Se borra el auto del la lista de autos del concesionario
                        _la.Remove(_auxAuto);
                    }
                    else
                    {
                        throw new Exception("El auto que intenta borrar no existe o está asignado !!!");
                    }

                }
                else { throw new Exception("El auto que intenta borrar es null"); }
            }
            catch (Exception ex) { throw ex; }
        }

        public void ModificaPersona(Cliente pPersona)
        {
            try
            {
                // Verifica si la persona es distinto de nulo
                if (pPersona != null)
                {
                    // Se ubica la persona en la lista de personas del concesionario usando el DNI de la prsona enviada
                    Cliente _auxPersona = _lp.Find(x => x.DNI == pPersona.DNI);
                    // Verifica que la persona exista
                    if (_auxPersona != null)
                    {
                        // Si la persona existe actualiza su estado
                        _auxPersona.DNI = pPersona.DNI;
                        _auxPersona.Nombre = pPersona.Nombre;
                        _auxPersona.Apellido = pPersona.Apellido;
                        // Si la Persona tiene Autos los recorrer y actualizar el datos de dueño
                        if (_auxPersona.RetornaListaAutos().Count > 0)
                        {
                            foreach (Auto _a in _auxPersona.RetornaListaAutos())
                            {
                                Cliente _p = _a.Get_Dueno();
                                if (_p != null)
                                {
                                    _p.DNI = pPersona.DNI;
                                    _p.Nombre = pPersona.Nombre;
                                    _p.Apellido = pPersona.Apellido;
                                    // Ubica el auto en la lista de autos del concesionario usando la patente del auto
                                    // que se está recorriendo de la persona ubicada en la lista de personas
                                    Auto _auto = _la.Find(a => a.Patente == _a.Patente);
                                    if (_auto != null)
                                    {
                                        // Se actualiza el estado del dueño de ese auto 
                                        Cliente _persona = _auto.Get_Dueno();
                                        _persona.DNI = pPersona.DNI;
                                        _persona.Nombre = pPersona.Nombre;
                                        _persona.Apellido = pPersona.Apellido;
                                    }

                                }
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("La Persona que intenta modificar no existe !!!");
                    }

                }
                else { throw new Exception("La Persona que intenta borrar es null"); }
            }
            catch (Exception ex) { throw ex; }
        }


        public void ModificaAuto(Auto pAuto)
        {
            try
            {
                // Se verifica si pAuto es distinto de nulo
                if (pAuto != null)
                {
                    // Ubica el auto de la lista de auto del concesionario
                    Auto _auxAuto = _la.Find(x => x.Patente == pAuto.Patente);
                    if (_auxAuto != null)
                    {

                        // Actualiza el estado del auto
                        _auxAuto.Patente = pAuto.Patente;
                        _auxAuto.Marca = pAuto.Marca;
                        _auxAuto.Modelo = pAuto.Modelo;
                        _auxAuto.Axo = pAuto.Axo;
                        _auxAuto.Precio = pAuto.Precio;
                        // Si el auto posee un dueño, se modifica el auto que tiene cargado la persona (Dueño)
                        if (_auxAuto.Get_Dueno() != null)
                        {
                            //Actualiza el auto de la persona de la lista de personas del concesionario.
                            _lp.Find(p => p.DNI == _auxAuto.Get_Dueno().DNI).ModificarAuto(pAuto);
                        }
                    }
                    else { throw new Exception("El auto que intenta modificar no existe !!!"); }
                }
                else { throw new Exception("El auto que intenta borrar es null"); }
            }
            catch (Exception ex) { throw ex; }
        }


        public void AsignaAuto(Cliente pPersona, Auto pAuto)
        {
            try
            {
                // Ubica la persona en la lista de personas del concesionario por el DNI de la Persona
                // que llegó por parámetro
                Cliente _auxPersona = _lp.Find(x => x.DNI == pPersona.DNI);
                // Ubica el auto en la lista de autos del concisionario por la PATENTE del Auto
                // que llegó por parámetro
                Auto _auxAuto = _la.Find(x => x.Patente == pAuto.Patente);
                //  Verifica si el auto no está asignado. Caso afirmativo permite la asignación
                if (_auxAuto.Get_Dueno() == null)
                {
                    // Al auto de la lista de Autos del concesionario de asigna el dueño que es la persona que se
                    // encontró en la lista de personas del concesionario
                    _auxAuto.Set_Dueno(_auxPersona);
                    // A la persona de la lista de Personas del concesionarios le agrega un auto del que es propietario
                    _auxPersona.AgregarAuto(_auxAuto);
                }
                else { throw new Exception("El auto ya está asignado !!!"); }
            }
            catch (Exception ex) { throw ex; }
        }




        /* EN REALIDAD, (SEGÚN CARDACCI), NO HACÍA FALTA ENVIAR COMO PARÁMETRO
         * A LA PERSONA, CON ENVIAR AL AUTO SOLO ES SUFICIENTE PARA PODER
         * HACER ESTA OPERACIÓN */
        public void DesasignaAuto(Cliente pPersona, Auto pAuto)
        {
            try
            {
                // Se obtiene la persona de la lista de personas del concesionario
                Cliente _auxPersona = _lp.Find(x => x.DNI == pPersona.DNI);
                // Se obtiene el auto de la lista de autos de esa persona del concesionario cuya patente
                // coincide con la paternte del auto enviado. (Recordar que el auto que tiene cargado la persona
                // en su lista de autos y el auto de la lista de autos del concesionario son distintos pues lo clonamos)
                Auto _auxAuto = _auxPersona.RetornaListaAutos().Find(x => x.Patente == pAuto.Patente);
                // Pasa a null el dueño del auto en la lista de autos del concecionario
                _la.Find(x => x.Patente == pAuto.Patente).Set_Dueno(null);
                // Borra el auto de la colección de autos de la persona ubicada en la lista de personas del concesionario
                _auxPersona.BorrarAuto(_auxAuto);

            }
            catch (Exception ex) { throw ex; }



        }
        public List<Auto> ListaAutosDePersona(Cliente pPersona)
        {
            List<Auto> _listaAutos = new List<Auto>();
            try
            {
                Cliente _auxPersona = _lp.Find(x => x.DNI == pPersona.DNI);
                _listaAutos = _auxPersona.RetornaListaAutos();
            }
            catch (Exception ex) { throw ex; }
            return _listaAutos;
        }





    }
}
