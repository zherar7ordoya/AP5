using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    internal class Cat
    {
        private int _health;

        public int Id { get; set; }
        public string Name { get; set; }

        public int Health
        {
            get => _health;
            set
            {
                _health = value;
                OnHealthChanged?.Invoke(this, _health);
            }
        }

        public event EventHandler<int> OnHealthChanged;
    }
}
