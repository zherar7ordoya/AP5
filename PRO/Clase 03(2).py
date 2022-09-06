'''
@created 2022-09-06
@author Gerardo Tordoya
'''

class Vector:
    def inicializa(self):
        self.x = 0
        self.y = 0

v1 = Vector()
v1.inicializa()
print(v1.x, v1.y)

v1.x = 5
print(v1.x, v1.y)

v2 = Vector()
v2.inicializa()
print(v2.x, v2.y)

v2.x = 3
v2.y = 7
print(v1.x, v1.y)
print(v2.x, v2.y)

v1.z = 6 # Creado "al vuelo"...
print(v1.x, v1.y, v1.z)