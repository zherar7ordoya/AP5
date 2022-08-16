using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MPP
{
    public class Historial
    {
        private XDocument DOCUMENTOX;

        public DataSet CargarDatosXML(BE.Historial objeto)
        {
            DataSet dataset = new DataSet();
            dataset.ReadXml(objeto.ArchivoXML);
            return dataset;
        }

        public void ActualizarHistorial(BE.Historial objeto)
        {
            XElement registro;
            int contador, acumulador;
            DOCUMENTOX = XDocument.Load(objeto.ArchivoXML);

            if (objeto.ArchivoXML == "JuegosHistorial.xml")
            {
                registro =
                        DOCUMENTOX
                        .Descendants("Juego")
                        .FirstOrDefault
                        (x => x.Attribute("Nombre").Value == objeto.NombreJuego);
                contador = Convert.ToInt32(registro.Element("Contador").Value);
                contador++;
                registro.Element("Contador").Value = Convert.ToString(contador);
                DOCUMENTOX.Save(objeto.ArchivoXML);
            }
            else
            {
                registro =
                    DOCUMENTOX
                    .Descendants("Jugador")
                    .FirstOrDefault
                    (x => x.Attribute("Nombre").Value == objeto.Jugador);

                contador = Convert.ToInt32(registro.Element(objeto.Estado).Value);
                contador++;
                registro.Element(objeto.Estado).Value = Convert.ToString(contador);

                acumulador = Convert.ToInt32(registro.Element("Puntos").Value);
                acumulador += objeto.Puntos;
                registro.Element("Puntos").Value = Convert.ToString(acumulador);

                DOCUMENTOX.Save(objeto.ArchivoXML);
            }

            
        }


    }
}
