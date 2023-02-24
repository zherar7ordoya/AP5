using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLibrary
{
    public class CarritoDeCompras
    {
        /* Yo sé lo que mi hipotético método necesitaría para mandar ese famoso
        primer return (nota de abajo). Entonces, lo defino aquí, el lugar más
        cómodo para hacerlo. */
        public delegate void MostrarSubtotal(decimal total);
        
        public List<Producto> Items { get; set; } = new List<Producto>();
        
        /* Perdón, pero insisto: aquí vemos lo necesario para los 2 returns:
        el parámetro es un método. Y obviamente, un método no es un tipo (al
        menos, no un tipo ya definido): yo lo tengo que definir, y lo hice,
        líneas arriba, al declarar el delegado. Es más, si lo medito un poco,
        tal vez llamando PUNTERO (apuntador) a DELEGATE, a lo mejor vea el
        asunto con más claridad. Veamos... */
        public decimal CalcularTotal
            (
            MostrarSubtotal metodo,
            Func<List<Producto>, decimal, decimal> CalculateDiscountedTotal,
            Action<string> TellUserWeAreDiscounting
            )
        {
            decimal subtotal = Items.Sum(x => x.Precio);

            /* He "traído" el método declarado en Main hasta aquí (lo he tomado
            "prestado" desde allí) y lo ejecuto aquí. ¿Por qué? Yo aquí tengo
            todos los elementos que Main no tiene y podría pasarle (a Main)
            tanto el subtotal como el total, pero pasar ambos datos mediante
            return... no es muy elegante. Podría también mandarlo por aquí
            a la consola pero violentaría el concepto de librería. Sin embargo,
            en cierta manera (para simplificar el problema) sí lo hago,  y lo
            hago "tomando prestado" un método de Main. */
            metodo(subtotal);
            TellUserWeAreDiscounting("STATUS: APPLYING DISCOUNT...");
            return CalculateDiscountedTotal(Items, subtotal);
        }
    }
}
