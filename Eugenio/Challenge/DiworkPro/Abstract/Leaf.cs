using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Leaf : Component
    {

        public List<Component> le;
        //public Leaf() { }
        public Leaf(string Nombre) : base(Nombre)
        {
            le = new List<Component>();
        }
        public override void Add(Component c)
        {
            le.Add(c);
        }

        public override void Remove(Component c)
        {
            le.Remove(c);
        }
    }
}
