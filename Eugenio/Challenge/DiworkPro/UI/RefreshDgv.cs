using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    internal class RefreshDgv
    {
        public void Refresh(DataGridView dgv, Object lista)
        {
            dgv.DataSource = null;
            dgv.DataSource = lista;
        }
    }
}
