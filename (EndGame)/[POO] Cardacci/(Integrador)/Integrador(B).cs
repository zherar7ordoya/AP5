public class Persona
{
    public void Compra(Accion _accion, int _cantidad)
    {
        _accion.CambioCotizacion = M1;
    }
    private void M1(object sender, CambioCotizacionEventArg e)
    {
        //e.CotizacionActual;
    }
}
public class Accion
{
    public event EventHandler < CambioCotizacionEventArg > CambioCotizacion;
    decimal _cotActual;
    public decimal CotActual
    {
        get
        {
            return _cotActual;
        }
        set
        {
            _cotActual = value;
            CambioCotizacion?.Invoke(this, new CambioCotizacionEventArg(this));
        }
    }
}
public class CambioCotizacionEventArg: EventArgs
{
    Accion _accion = null;
    public CambioCotizacionEventArg(Accion pAccion)
    {
        _accion = pAccion;
    }
    public decimal CotizacionActual
    {
        get
        {
            return _accion.CotActual;
        }
    }
}