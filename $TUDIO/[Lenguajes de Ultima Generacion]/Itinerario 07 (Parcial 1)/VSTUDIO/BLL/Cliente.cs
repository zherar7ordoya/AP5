using System.Collections.Generic;

namespace BLL
{
    public class Cliente : ABS.IGestor<BEL.Cliente>
    {
        // *---------------------------------------------------------=> COMUNES
        readonly DML.Cliente cliente;
        public Cliente() => this.cliente = new DML.Cliente();


        // *------------------------------------------------=> IMPLEMENTACIONES
        public BEL.Cliente Detallar(BEL.Cliente cliente) => this.cliente.Detallar(cliente);
        public bool Eliminar(BEL.Cliente cliente) => this.cliente.Eliminar(cliente);
        public bool Guardar(BEL.Cliente cliente) => this.cliente.Guardar(cliente);
        public List<BEL.Cliente> Listar() => cliente.Listar();
        

        // *---------------------------------------------------------=> MÉTODOS
        public bool AsociarGiftcardInternacional(BEL.Cliente cliente, BEL.GiftcardInternacional giftcard) => this.cliente.AsociarGiftcardInternacional(cliente, giftcard);
        public bool AsociarGiftcardNacional(BEL.Cliente cliente, BEL.GiftcardNacional giftcard) => this.cliente.AsociarGiftcardNacional(cliente, giftcard);
        public bool DesasociarGiftcardInternacional(BEL.Cliente cliente, BEL.GiftcardInternacional giftcard) => this.cliente.DesasociarGiftcardInternacional(cliente, giftcard);
        public bool DesasociarGiftcardNacional(BEL.Cliente cliente, BEL.GiftcardNacional giftcard) => this.cliente.DesasociarGiftcardNacional(cliente, giftcard);
    }
}
