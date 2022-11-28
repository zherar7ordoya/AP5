import re

from MPP.articulo_mapper import ArticuloMapper


class Valida(ArticuloMapper):

    def __init__(self):
        super().__init__()
        self.articulo_mpp = ArticuloMapper()

    def existe_codigo(self, codigo):
        listado = self.articulo_mpp.leer()
        if any(codigo in lista_anidada for lista_anidada in listado):
            return True
        return False

    @staticmethod
    def valida_codigo(codigo):
        if re.match(r"([A-Z]\d{3})", codigo):
            return True
        return False

    @staticmethod
    def valida_descripcion(descripcion):
        if re.match(r"([A-Z]\w{3,})", descripcion):
            return True
        return False

    @staticmethod
    def valida_stock(stock):
        if re.match(r"([1-9]\d*)", stock):
            return True
        return False

    @staticmethod
    def valida_fecha(fecha):
        if re.match(r"(\d{2}/\d{2}/\d{4})", fecha):
            return True
        return False

    @staticmethod
    def valida_vendedor(vendedor):
        if re.match(r"([A-Za-z]\w{3,})", vendedor):
            return True
        return False

    @staticmethod
    def valida_sucursal(sucursal):
        if re.match(r"([A-Z]{3}\d{3})", sucursal):
            return True
        return False

    @staticmethod
    def valida_importe(importe):
        if re.match(r"(\d*\.?\d*)", importe):
            return True
        return False
