public class ClienteVista : ABMC_Interfaces.IABMC<Cliente> // Referencia a Interfaz
{
    // Atributos
    private Cliente Vcliente;   // Referencia a Estructura
    private ClienteD VclienteD; // Referencia a Lógica
    private Form Vgui;          // Referencia a GUI

    // Constructor
    public ClienteVista(Form pGUI)
    {
        this.Cliente = new Cliente();
        this.ClienteD = new ClienteD();
        this.Vgui = pGUI;
    }

    // Propiedades
    public Cliente Cliente
    {
        get
        {
            return Vcliente;
        }
        set
        {
            Vcliente = value;
        }
    }

    public ClienteD ClienteD
    {
        get
        {
            return VclienteD;
        }

        set
        {
            VclienteD = value;
        }
    }
}