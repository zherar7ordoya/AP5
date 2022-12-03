from colors import color


class Compartido:

    @staticmethod
    def obtener_idx(listado):
        for idx, x in enumerate(listado):
            print(idx, x)

        while True:
            try:
                # Compruebo que el índice sea un número entero
                idx = int(input("\nIngrese el número de registro del artículo a modificar: "))
                # Compruebo que el índice esté dentro del rango de la lista
                if idx < 0 or idx > len(listado) - 1:
                    print(color("\nDebe ingresar un número de registro válido", fg='red'))
                else:
                    break
            except ValueError:
                print(color("\nDebe ingresar un número entero", fg='red'))

        return idx
