using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  public  class DNI: TextBox
    { // validar si se ingresa un dni correcto con expresiones regulares
        public Boolean validar()
        {
            return Regex.IsMatch(base.Text, @"^[0-9]{8}$");
        }
    }
}
