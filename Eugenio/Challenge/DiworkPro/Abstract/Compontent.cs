using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Component
    {
        protected string Nombre;

        public Component() { }

        public Component(string Nombre)
        {
            this.Nombre = Nombre;
        }            

        public abstract void Add(Component c);
        public abstract void Remove(Component c);

    }
}
