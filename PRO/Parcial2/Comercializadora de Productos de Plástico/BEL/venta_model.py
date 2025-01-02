class VentaModel:
    def __init__(self, fecha, codigo, vendedor, sucursal, importe):
        self.fecha = fecha
        self.codigo = codigo
        self.vendedor = vendedor
        self.sucursal = sucursal
        self.importe = importe

    def __str__(self):
        return """
               Fecha  {}
              Código  {}
            Vendedor  {}
            Sucursal  {}
             Importe  {}"""\
            .format(self.fecha,
                    self.codigo,
                    self.vendedor,
                    self.sucursal,
                    self.importe)

