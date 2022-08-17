using System.Collections.Generic;

namespace BLL
{
    public class GiftcardInternacional : Giftcard, ABS.IGestor<BEL.GiftcardInternacional>
    {
        // *---------------------------------------------------------=> COMUNES
        readonly DML.GiftcardInternacional tarjeta;
        public GiftcardInternacional() => this.tarjeta = new DML.GiftcardInternacional();

        // *------------------------------------------------=> IMPLEMENTACIONES
        public BEL.GiftcardInternacional Detallar(BEL.GiftcardInternacional giftcard) => this.tarjeta.Detallar(giftcard);
        public bool Eliminar(BEL.GiftcardInternacional giftcard) => this.tarjeta.Eliminar(giftcard);
        public bool Guardar(BEL.GiftcardInternacional giftcard) => this.tarjeta.Guardar(giftcard);
        public List<BEL.GiftcardInternacional> Listar() => this.tarjeta.Listar();
        public override double ObtenerDescuento(double importe) => importe * 0.70;

        // *------------------------------------------------=> MÉTODOS
        public List<BEL.GiftcardInternacional> ListarDisponibles() => this.tarjeta.ListarDisponibles();
    }
}
