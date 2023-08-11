using System.Collections.Generic;

namespace SistemaDeCobros
{
    public class CCliente
    {
        // Atributos
        private int legajo;
        private string nombreCliente;
        private List<CCobro> CobrosPendientes = new List<CCobro>();
        private List<CPago> CobrosCancelados  = new List<CPago>();

        // Propiedades
        public int Legajo
        {
            get => legajo;
            set => legajo = value;
        }
        public string NombreCliente
        {
            get => nombreCliente;
            set => nombreCliente = value;
        }
        public List<CCobro> VerPendientes() { return CobrosPendientes; }
        public List<CPago> VerCancelados() { return CobrosCancelados; }

        // Constructores
        public CCliente(int pLegajo, string pNombreCliente)
        {
            legajo        = pLegajo;
            nombreCliente = pNombreCliente;
        }

        // Métodos
        public bool EsDuplicado(int pCodigo)
        {
            if (CobrosPendientes.Count > 0)
            {
                foreach (var x in CobrosPendientes)
                {
                    if (x.Codigo == pCodigo) { return true; }
                }
            }

            if (CobrosCancelados.Count > 0)
            {
                foreach(var x in CobrosCancelados)
                {
                    if(x.Codigo == pCodigo) { return true; }
                }
            }
            return false;
        }
        public void AltaPendiente(CCobro pCobro)
        { CobrosPendientes.Add(pCobro); }

        public void BajaPendiente(CCobro pCobro)
        { CobrosPendientes.Remove(pCobro); }

        public void AltaCancelado(CPago pPago)
        { CobrosCancelados.Add(pPago); }
    }
}
