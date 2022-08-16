using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Data;
using System.Text.RegularExpressions;

namespace MPP
{
    public class Jugador : ABSTRACTA.IGestor<BE.Jugador>
    {
        /* ----------------------------------------------------------------- *\
         * ARRANQUE                                                          *
        \* ----------------------------------------------------------------- */

        private XDocument DOCUMENTOX;
        private readonly string ARCHIVO = "Jugadores.xml";
        private List<BE.Jugador> JUGADORES;

        public Jugador() => JUGADORES = new List<BE.Jugador>();

        /* ----------------------------------------------------------------- *\
         * IMPLEMENTACIÓN                                                    *
        \* ----------------------------------------------------------------- */

        public BE.Jugador DetallarObjeto(BE.Jugador objeto)
        {
            throw new NotImplementedException();
        }

        //

        public bool Guardar(BE.Jugador jugador)
        {
            try
            {
                XElement registro;

                if (jugador.Codigo == 0)
                {
                    int maximo =
                        XDocument
                        .Load(ARCHIVO)
                        .Descendants("Jugador")
                        .Max(x => (int)x.Attribute("Codigo"));
                    maximo++;

                    registro =
                    new XElement("Jugador",
                    new XAttribute("Codigo", maximo),
                    new XElement("Nombre", jugador.Nombre),
                    new XElement("Apellido", jugador.Apellido),
                    new XElement("DNI", jugador.DNI),
                    new XElement("Email", jugador.Email),
                    new XElement("FechaNacimiento", jugador.FechaNacimiento),
                    new XElement("LocalidadResidencia", jugador.LocalidadResidencia)
                    );

                    DOCUMENTOX.Root.Add(registro);
                    DOCUMENTOX.Save(ARCHIVO);
                    return true;
                }
                else
                {
                    registro =
                        DOCUMENTOX
                        .Descendants("Jugador")
                        .FirstOrDefault
                        (x => x.Attribute("Codigo").Value == Convert.ToString(jugador.Codigo));

                    registro.Element("Nombre").Value = jugador.Nombre;
                    registro.Element("Apellido").Value = jugador.Apellido;
                    registro.Element("DNI").Value = Convert.ToString(jugador.DNI);
                    registro.Element("Email").Value = jugador.Email;
                    registro.Element("FechaNacimiento").Value = Convert.ToString(jugador.FechaNacimiento);
                    registro.Element("LocalidadResidencia").Value = jugador.LocalidadResidencia;

                    DOCUMENTOX.Save(ARCHIVO);
                    return true;
                }
            }
            catch (Exception) { throw; }
        }

        //

        public List<BE.Jugador> RecopilarObjetos()
        {
            try
            {
                DOCUMENTOX = XDocument.Load(ARCHIVO);

                JUGADORES = DOCUMENTOX.Descendants("Jugador").Select(x => new BE.Jugador
                {
                    Codigo = Convert.ToInt32(x.Attribute("Codigo").Value),
                    Nombre = x.Element("Nombre").Value,
                    Apellido = x.Element("Apellido").Value,
                    DNI = Convert.ToInt32(x.Element("DNI").Value),
                    Email = x.Element("Email").Value,
                    FechaNacimiento = Convert.ToDateTime(x.Element("FechaNacimiento").Value),
                    LocalidadResidencia = x.Element("LocalidadResidencia").Value
                }).OrderBy(x => Convert.ToInt32(x.Codigo)).ToList();

                return JUGADORES;
            }
            catch (Exception) { throw; }
        }

        //

        public bool Remover(BE.Jugador jugador)
        {
            try
            {
                XElement registro =
                    DOCUMENTOX
                    .Descendants("Jugador")
                    .FirstOrDefault
                    (x => x.Attribute("Codigo").Value == Convert.ToString(jugador.Codigo));

                registro.Remove();
                DOCUMENTOX.Save(ARCHIVO);

                return true;
            }
            catch (Exception) { throw; }
        }

        /* ----------------------------------------------------------------- *\
         * MÉTODOS                                                           *
        \* ----------------------------------------------------------------- */

        public XmlNodeList ListarJugadores()
        {
            XmlDocument archivo = new XmlDocument();
            archivo.Load("Jugadores.xml");
            XmlNodeList jugadores = archivo.SelectNodes("Jugadores/Jugador/Nombre");
            return jugadores;
        }

        /* ----------------------------------------------------------------- *\
         * FINALIZACIÓN                                                      *
        \* ----------------------------------------------------------------- */

    }
}
