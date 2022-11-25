class ArticuloBEL:
    def __init__(self, codigo, descripcion, stock):
        self.codigo = codigo
        self.descripcion = descripcion
        self.stock = stock

    def __str__(self):
        return """
                 Código  {}
            Descripción  {}
                  Stock  {}"""\
            .format(self.codigo,
                    self.descripcion,
                    self.stock)

