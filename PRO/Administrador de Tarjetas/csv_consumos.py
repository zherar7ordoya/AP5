# ========================================================
# Author:      Gerardo Tordoya
# Create date: 2022-10-16
# Description: Persistencia en archivo CSV de los consumos
# ========================================================

import pandas

ARCHIVO_TARJETAS = 'tarjetas.csv'


class Consumo:
    def __init__(self):
        self.tarjetas = pandas.read_csv(ARCHIVO_TARJETAS)

    def consumo_pesos(self, id_tarjeta, pesos):
        """ Ingresa un consumo en pesos """
        conteo = 0
        for index in self.tarjetas.index:
            if self.tarjetas.loc[index, 'TarjetaNumero'] == int(id_tarjeta):
                saldo = self.tarjetas.loc[index, 'SaldoPesos']
                self.tarjetas.loc[index, 'SaldoPesos'] = int(saldo) - int(pesos)
                conteo += 1
        self.tarjetas.to_csv(ARCHIVO_TARJETAS, index=False)
        if conteo == 0:
            print('No se encontró la tarjeta especificada.')
        else:
            print('Consumo ingresado con éxito.')

    def consumo_dolares(self, id_tarjeta, dolares):
        """ Ingresa un consumo en dólares """
        conteo = 0
        for index in self.tarjetas.index:
            if self.tarjetas.loc[index, 'TarjetaNumero'] == int(id_tarjeta):
                saldo = self.tarjetas.loc[index, 'SaldoDolares']
                self.tarjetas.loc[index, 'SaldoDolares'] = int(saldo) - int(dolares)
                conteo += 1
        self.tarjetas.to_csv(ARCHIVO_TARJETAS, index=False)
        if conteo == 0:
            print('No se encontró la tarjeta especificada.')
        else:
            print('Consumo ingresado con éxito.')
