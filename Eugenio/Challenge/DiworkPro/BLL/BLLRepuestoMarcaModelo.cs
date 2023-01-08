using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MAPPER;

namespace BLL
{
    public class BLLRepuestoMarcaModelo
    {
        public BLLRepuestoMarcaModelo() 
        {
            mpprmm = new MPPRepuestosMarcaModelo();
        }
        MPPRepuestosMarcaModelo mpprmm;

        public void Rmm(DataGridView dgv)
        {
            mpprmm.RepuestoRepetido(dgv);
        }

        public void Pmm(DataGridView dgv)
        {
            mpprmm.PresupuestosMarcaModelo(dgv);
        }

        public void TotalAuto(DataGridView dgv)
        {
            mpprmm.TotalAutos(dgv);
        }

        public void TotalMoto(DataGridView dgv)
        {
            mpprmm.TotalMotos(dgv);
        }
    }
}
