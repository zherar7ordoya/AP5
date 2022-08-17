using System.Collections.Generic;

namespace BLL
{
    public class GiftcardNacional : Giftcard, ABS.IGestor<BEL.GiftcardNacional>
    {
        // *---------------------------------------------------------=> COMUNES
        readonly DML.GiftcardNacional dmlGiftcardNacional;
        public GiftcardNacional() => this.dmlGiftcardNacional = new DML.GiftcardNacional();

        // *------------------------------------------------=> IMPLEMENTACIONES
        public override double ObtenerDescuento(double importe) => importe * 0.75;
        public BEL.GiftcardNacional Detallar(BEL.GiftcardNacional giftcard) => this.dmlGiftcardNacional.Detallar(giftcard);
        public bool Eliminar(BEL.GiftcardNacional giftcard) => this.dmlGiftcardNacional.Eliminar(giftcard);
        public bool Guardar(BEL.GiftcardNacional giftcard) => this.dmlGiftcardNacional.Guardar(giftcard);
        public List<BEL.GiftcardNacional> Listar() => this.dmlGiftcardNacional.Listar();

        // *---------------------------------------------------------=> MÉTODOS
        public List<BEL.GiftcardNacional> ListarDisponibles() => this.dmlGiftcardNacional.ListarDisponibles();
    }
}
