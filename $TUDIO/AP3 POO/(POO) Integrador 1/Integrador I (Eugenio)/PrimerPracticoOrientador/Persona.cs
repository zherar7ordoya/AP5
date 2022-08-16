using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;


namespace PrimerPracticoOrientador
{
    public class Persona
    {
        public string Dni { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        Principal _principal = new Principal(); 
        
        public Persona(String dni, String nombre, String apellido)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
        }
        ~Persona() { Trace.WriteLine("El DNI de las personas finalizadas es " + Dni); }

        public int CantAutos() { return 0; }
        public List<Auto> ListaAutos() { return ListaAutos(); } 
    }
}
