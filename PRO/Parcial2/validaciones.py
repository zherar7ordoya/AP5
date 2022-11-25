import re
from articulo_bll import ArticuloBLL


class Valida:
    def __init__(self):
        self.articulo_bll = ArticuloBLL()

    def existe_codigo(self, codigo):
        listado = self.articulo_bll.leer()
        if any(codigo in lista_anidada for lista_anidada in listado):
            return True
        return False

    @staticmethod
    def valida_codigo(codigo):
        if re.match("([A-Z]\d{3})", codigo):
            return True
        return False

    @staticmethod
    def valida_descripcion(descripcion):
        if re.match("([A-Z]\w{3,})", descripcion):
            return True
        return False

    @staticmethod
    def valida_stock(stock):
        if re.match("([1-9]\d*)", stock):
            return True
        return False

    @staticmethod
    def valida_fecha(fecha):
        if re.match("(\d{2}/\d{2}/\d{4})", fecha):
            return True
        return False

    @staticmethod
    def valida_vendedor(vendedor):
        if re.match("([A-Za-z]\w{3,})", vendedor):
            return True
        return False

    @staticmethod
    def valida_sucursal(sucursal):
        if re.match("([A-Z]{3}\d{3})", sucursal):
            return True
        return False

    @staticmethod
    def valida_importe(importe):
        if re.match("(\d*\.?\d*)", importe):
            return True
        return False
