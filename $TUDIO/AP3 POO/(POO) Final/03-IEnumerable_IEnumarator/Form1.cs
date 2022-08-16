using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_IEnumerable_IEnumarator
{
    public partial class Form1 : Form
    {
        public Form1(){InitializeComponent(); }

        public class Persona : IEnumerable,IEnumerator
        {
            //Vamos a iterar cada parte de un codigo AAA-123
            public string Nombre { get; set; }
            public string Codigo { get; set; }
            private string _Current; //variable para el IEnumerator
            private bool sigue; //devuelve V o F segun haya o no cosas para iterar
            private int x; //Lo usamos como contador, en este caso va a ser 0 o 1 ya que el codigo tiene 2 partes

            public object Current => _Current; //retorna el _Current 

            public Persona() { }
            public Persona(string pNombre, string pCodigo) { Nombre = pNombre; Codigo = pCodigo;  }

            //Implementacion del IENUMERABLE
            public IEnumerator GetEnumerator()
            {
                return this; ///retorno el mismo objeto para usar como Enumerator
            }
            public bool MoveNext()
            {
                if (x == 0)
                {
                    _Current = Codigo.Substring(0, 3);
                    sigue = true;
                    x++;
                }
                else if (x == 1)
                {
                    _Current = Codigo.Substring(4, 3);
                    sigue = true;
                    x++;
                }
                else Reset();
                return sigue;
            }
            public void Reset()
            {
                _Current = "";
                x = 0;
                sigue = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona P = new Persona();
            P.Codigo = "ABC=123";
            foreach(string s in P) {MessageBox.Show(s);}
        }
    }
}
