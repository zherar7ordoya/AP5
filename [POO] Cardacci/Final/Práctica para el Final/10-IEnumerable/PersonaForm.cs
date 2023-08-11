using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Enumerable
{
    public partial class PersonaForm : Form
    {
        Empresa _empresa = new Empresa();

        public PersonaForm() => InitializeComponent();

        private void PersonaForm_Load(object sender, EventArgs e)
        {
            Persona.BienvenidoGerardoEventHandler += new EventHandler<BienvenidoGerardoEventArgs>(FuncionEvento);

            _empresa.AgregaProducto(new Producto("1234-ABCD"));
            _empresa.AgregaProducto(new Producto("1234-BOXT"));
            _empresa.AgregaProducto(new Producto("1234-ZETA"));
            _empresa.AgregaProducto(new Producto("2345-CCCC"));

            try
            {
                _empresa.AgregaPersona(new Persona("Gerardo", 1234));
                _empresa.AgregaPersona(new Persona("Rodolfo", 2345));
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            Mostrar();
        }

        private void FuncionEvento(object sender, BienvenidoGerardoEventArgs e)
        {
            MessageBox.Show($"Bienvenido {e.Nombre}");
        }

        private void Mostrar()
        {
            PersonaProductosDgv.DataSource = null;
            PersonaProductosDgv.DataSource = _empresa.GetPersonaProductos();
            ProductosDgv.DataSource = null;
            ProductosDgv.DataSource = _empresa.GetProductos();
            PersonasDgv.DataSource = null;
            PersonasDgv.DataSource = _empresa.GetPersonas();
        }
    }

    // ************************************************************************

    public class Producto : ICloneable, IEnumerable, IEnumerator
    {
        public string Codigo { get; set; }

        public Producto() { }
        public Producto(string codigo) { Codigo = codigo; }

        // ====================================================================

        // Implementación de IEnumerable
        public IEnumerator GetEnumerator() { return this; }

        // Implementación de ICloneable
        public object Clone() { return MemberwiseClone(); }

        // Implementación de IEnumerator
        /**
         * IEnumerator necesita que se implemente:
         *      => Una propiedad: Current
         *      => Un método: MoveNext()
         *      => Un método: Reset()
         */

        int contador = 0;               // ¿En qué posición del bloque estoy?
        bool continuar;                 // ¿Puedo continuar?
        private string _current;        // ¿En cuál objeto estás ahora?
        public object Current => _current;

        public bool MoveNext()
        {
            if (contador == 0)
            {
                _current = Codigo.Substring(0, 4);
                continuar = true;
                contador++;
            }
            else if (contador == 1)
            {
                _current = Codigo.Substring(5, 4);
                continuar = true;
                contador++;
            }
            else
            {
                Reset();
            }
            return continuar;
        }

        public void Reset()
        {
            continuar = false;
            _current = string.Empty;
            contador = 0;
        }
    }

    // ************************************************************************

    public class BienvenidoGerardoEventArgs : EventArgs
    {
        public string Nombre { get; set; }
        public BienvenidoGerardoEventArgs(string nombre) { Nombre = nombre; }
    }


    public class Persona : ICloneable
    {
        public static event EventHandler<BienvenidoGerardoEventArgs> BienvenidoGerardoEventHandler;

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (value == "Gerardo")
                {
                    BienvenidoGerardoEventHandler?.Invoke(this, new BienvenidoGerardoEventArgs(value));
                }
                _nombre = value;
            }
        }

        public int Codigo { get; set; }

        public Persona() { }
        public Persona(string nombre, int codigo)
        {
            Nombre = nombre;
            Codigo = codigo;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    // ************************************************************************

    public class ExisteException : Exception
    {
        public ExisteException() { }
        public ExisteException(string message) : base(message) { }
    }

    public class Empresa
    {
        private List<Producto> _productos;
        private List<Persona> _personas;

        public Empresa()
        {
            _productos = new List<Producto>();
            _personas = new List<Persona>();
        }

        public void AgregaProducto(Producto producto)
        {
            bool existe = _productos.Exists(item => item.Codigo == producto.Codigo);
            if (existe) throw new Exception("El producto ya existe");
            else _productos.Add(producto);
        }

        public void AgregaPersona(Persona persona)
        {
            bool existe = _personas.Exists(item => item.Codigo == persona.Codigo);
            if (existe) throw new ExisteException("La persona ya existe");
            else _personas.Add(persona);
        }

        // Devolver Persona y Codigo (Producto que le pertenece) usando Join
        public IEnumerable GetPersonaProductos()
        {
            var lista = from persona in _personas
                        join producto in _productos
                        on persona.Codigo equals Convert.ToInt32(producto.Codigo.Substring(0, 4))
                        select new { persona.Nombre, Producto = producto.Codigo };
            return lista.ToList();
        }

        public List<Persona> GetPersonas()
        {
            List<Persona> personas = new List<Persona>();

            foreach (Persona persona in _personas)
            {
                personas.Add((Persona)persona.Clone());
            }
            return personas;
        }

        public IEnumerable GetProductos()
        {
            var productos = from producto
                            in _productos
                            select new { producto.Codigo };
            return productos.ToList();
        }
    }
}
