

using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_IEnumerable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Empresa MiEmpresa = new Empresa();

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona.SeCargoJuan += FuncionEvento; //Como es estatico no necesito una instancia
            Persona.SeCargoJuan += new EventHandler<SeCargoJuanEventArgs>(FuncionEvento); //forma larga
            Producto P = new Producto();
            P.Codigo = "1234-ABCD";
            MiEmpresa.AgregarProducto(P);
            P = new Producto("2222-CCCC");
            MiEmpresa.AgregarProducto(P);
            Persona Per = new Persona("Juan", 1234);
            
           
            //Per.Nombre = "Juan";
            MiEmpresa.AgregarPersona(Per);
            Per = new Persona("Perdro", 2222);
            MiEmpresa.AgregarPersona(Per);

            Mostrar();
        }

        private void FuncionEvento(object sender, SeCargoJuanEventArgs e)
        {
            MessageBox.Show("Se cargó " + e.Nombre);
        }

        private void Mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = MiEmpresa.RetornaPersonaProducto();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = MiEmpresa.RetornaProductos();
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = MiEmpresa.RetornaPersonas();
        }
    }

    public class Producto:IEnumerable,IEnumerator,ICloneable
    {
        /// <summary>
        /// 1234-ABCD
        /// </summary>
        public string Codigo { get; set; }
        private string _Current;
        public object Current => _Current; //Devuelve el elemento que ese está iterando
        bool sigue; //Para el movenext
        int c=0; //el contador

        public Producto()
        {

        }
        public Producto(string pCodigo)
        {
            Codigo = pCodigo;

        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (c == 0)
            {
                _Current = Codigo.Substring(0, 4);
                sigue = true;
                c++;
            }
            else if (c == 1)
            {
                _Current = Codigo.Substring(5, 4);
                sigue = true;
                c++;

            }
            else
                Reset();
            return sigue;
        }

        public void Reset()
        {
            sigue = false;
            _Current = "";
            c = 0;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    public class Persona : ICloneable
    {
        //declaro el evento
        public static event EventHandler<SeCargoJuanEventArgs> SeCargoJuan;


        private string _Nombre;
        public string Nombre 
        {
            get { return _Nombre; }
            set {
                //aca voy a invocar el evento si se carga Juan

                if (value == "Juan")
                {
                    SeCargoJuan?.Invoke(this, new SeCargoJuanEventArgs(value));
                }

               
                _Nombre = value;
            
            
            }
        }
        public int Codigo { get; set; } /// <summary>
        /// el codigo es la primera parte del codigo del producto.
        /// para poder usar el linq
        /// </summary>

        public Persona()
        { }
        public Persona(string pNombre, int pCodigo)
        {
            Nombre = pNombre;
            Codigo = pCodigo;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    public class Empresa
    {
        private List<Producto> LProducto;
        private List<Persona> LPersona;

        public Empresa()
        {
            LProducto = new List<Producto>();
            LPersona = new List<Persona>();
        }

        public void AgregarProducto(Producto pP)
        {
            ///verifico con LAMBDA
            ///

            //if (!LP.Exists(x => x.Codigo == pP.Codigo))
            //{
            //    LP.Add(pP);
            //}

            //verifico con LINQ

            var v = from P in LProducto where P.Codigo == pP.Codigo select P;
            if (v.Count() > 0)
            {
                MessageBox.Show("Ya existe");
            }
            else
            {
                LProducto.Add(pP);
            }
        }
        public void AgregarPersona(Persona pPersona)
        {
            if (!LPersona.Exists(x => x.Codigo == pPersona.Codigo))
            {
                LPersona.Add(pPersona);
            }
        }

        //retornar Persona y Codigo de producto que le pertenece usando join

        public IEnumerable RetornaPersonaProducto()
        {
            var v = from Per in LPersona
                    join
                    Pro in LProducto
                    on Per.Codigo equals Convert.ToInt32(Pro.Codigo.Substring(0, 4))
                    select new { Nombre = Per.Nombre, Prod = Pro.Codigo };
            return v.ToList();
        }

        public List<Persona> RetornaPersonas()
        {
            List<Persona> Lp = new List<Persona>();
            foreach(Persona p in LPersona)
            {
                Lp.Add((Persona)p.Clone());
            }

            return Lp;
        }

        public IEnumerable RetornaProductos()
        {
            var v = from p in LProducto select new { CodigoProducto = p.Codigo };

            return v.ToList();
        }

    }

    public class SeCargoJuanEventArgs: EventArgs
    {
        public string Nombre { get; set; }
       

        public SeCargoJuanEventArgs(string pNombre)
        {
            Nombre = pNombre;
            
        }
    }
}
