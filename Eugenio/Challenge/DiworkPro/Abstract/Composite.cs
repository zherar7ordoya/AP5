using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Composite : Component
    {
        public List<Component> comp;
        
        public Composite(string Nombre) : base(Nombre)
        {
            comp = new List<Component>();            
        }

        public override void Add(Component c)
        {
            comp.Add(c);
        }

        public override void Remove(Component c)
        {
            comp.Remove(c);
        }
    }
}
