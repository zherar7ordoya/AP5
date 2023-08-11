using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eventos;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Clase concreta. Si se puede instanciar
            Auto _a = new Auto();
            // Esto no se puede hacer pues las clases abstractas no se pueden instanciar
            // Operacion _o = new Operacion();
            // Una clase sellada puese instanciarse pero no heredarse
            Perro _p = new Perro();
     
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            
            MiEjecucion(new Suma());
        }

        private void button2_Click(object sender, EventArgs e)
        {
          MiEjecucion( new Resta());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MiEjecucion(new Multiplicacion());
        }

        private void MiEjecucion(Operacion pO)
        {

            try
            {
               textBox3.Text = pO.Ejecutar(decimal.Parse(textBox1.Text),decimal.Parse(textBox2.Text)).ToString();
                MessageBox.Show(pO.MuestraValores());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
                
        
        }
    }

    public abstract class Operacion
    {
       
        public abstract decimal Ejecutar(decimal n1, decimal n2);

        public virtual string MuestraValores()
        {
            return $"Se ingresaron dos numeros  !!!";
        }

    }

    public class Suma : Operacion
    {
        
        decimal _n1 = 0;
        decimal _n2 = 0;
        public override decimal Ejecutar(decimal n1, decimal n2)
        {
            _n1 = n1; _n2 = n2;
            return n1 + n2;
        }
        public override string MuestraValores()
        {
            return $"Se ingresaron dos numeros  !!! {_n1} y {_n2}"; ;   
        }
    }
    public class Resta : Operacion
    {
        public override decimal Ejecutar(decimal n1, decimal n2)
        {
            return n1 - n2;
        }
    }

    public class Multiplicacion : Operacion
    {
        public override decimal Ejecutar(decimal n1, decimal n2)
        {
            return n1 * n2;
        }
    }
    public class Auto
    {
        
    }

    public sealed class Perro
    {
        public void Comer() { }
        public void Comer(string alimento_1) { }
        public void Comer(string alimento_1, string suplemento) { }
        public void Comer(string alimento_1, int suplemento) { }
    }
    //Lo siguiente da error pues las clases selladas no pueden heredarse
    //public class caniche : Perro 
    //{ 
    
    //}

    public class Calentador  : Termostato
    {

    }
}
