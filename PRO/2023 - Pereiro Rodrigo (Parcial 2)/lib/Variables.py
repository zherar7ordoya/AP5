import os, sys
from os import path

# Carpetas a Manejar
lib_folder = os.path.dirname(__file__)
main_folder = os.path.abspath(os.path.join(lib_folder, '..'))
sprite_folder = os.path.join(main_folder, 'Sprite')
sprites_player_folder = path.join(sprite_folder, 'Player')
sprites_enemigos_folder = path.join(sprite_folder, 'Enemigos')
sprites_fondo_folder = path.join(sprite_folder, 'Fondo')
sprites_boton_folder = path.join(sprite_folder, 'Botones')

# Resolucion de pantalla. 
ANCHO = 800
ALTURA = 450
FONDORELATO= os.path.join(sprites_fondo_folder,"FondoRelato.jpeg")
FONDO1= os.path.join(sprites_fondo_folder,"Fondo1.jpeg")
FONDO2= os.path.join(sprites_fondo_folder,"Fondo2.jpg")

# COLORES NDP(Nota del programador): El programador es daltonico. 
ROJO = (255, 0, 0)
VERDE = (0, 255, 0)
AZUL = (0, 0, 255)
AMARILLO = (255, 255, 0)
MAGENTA = (255, 0, 255)
CIAN = (0, 255, 255)
NARANJA = (255, 165, 0)
PURPURA = (128, 0, 128)
BLANCO = (255, 255, 255)
NEGRO = (0, 0, 0)
GRIS_CLARO = (192, 192, 192)
GRIS_MEDIO = (128, 128, 128)
GRIS_OSCURO = (64, 64, 64)
AZUL_CLARO = (0, 0, 128)
VERDE_MARINO = (0, 128, 128)
MARRON = (128, 0, 0)

PLAYERALTO = 3900
PLAYERANCHO = 2600
PLAYERIMAGEGREEN= os.path.join(sprites_player_folder,"JugadorOriginal.png")
PLAYERVIDA=100

T800ALTO = 1229
T800ANCHO = 964
T800IMAGEGREEN= os.path.join(sprites_enemigos_folder,"T-0800.png")

T1000ALTO = 512
T1000ANCHO = 512
T1000IMAGEGREEN= os.path.join(sprites_enemigos_folder,"T-1000.png")

TXALTO = 568
TXANCHO = 281
TXIMAGEGREEN= os.path.join(sprites_enemigos_folder,"T-X.png")

SKYNETALTO = 1159
SKYNETANCHO = 1600
SKYNETIMAGEGREEN= os.path.join(sprites_enemigos_folder,"SKYNET.png")

JUGARALTO = 42
JUGARANCHO = 92
JUGARIMAGEGREEN= os.path.join(sprites_boton_folder,"JUGAR.png")

PAPELALTO = 26
PAPELANCHO = 80
PAPELIMAGEGREEN= os.path.join(sprites_boton_folder,"Papel.png")

PIEDRAALTO = 26
PIEDRAANCHO = 80
PIEDRAIMAGEGREEN= os.path.join(sprites_boton_folder,"Piedra.png")

TIJERASALTO = 26
TIJERASANCHO = 80
TIJERASIMAGEGREEN= os.path.join(sprites_boton_folder,"Tijera.png")

# FPS
FPS = 60

#Fuentes
SEGOE = 'Segoe UI'
ARIAL = 'Arial'
TAHOMA = 'Tahoma'

#Nivel1
cantidad_t800_nivel1 =1
cantidad_t1000_nivel1 = 0
cantidad_tx_nivel1 = 0
cantidad_jefe_nivel1 = 0
cantidad_nivel1 = 1
fondo_nivel1 = FONDO1

#Nivel2
cantidad_t800_nivel2 =2 
cantidad_t1000_nivel2 = 0
cantidad_tx_nivel2 = 0
cantidad_jefe_nivel2 = 0
cantidad_nivel2 = 2
fondo_nivel2 = FONDO2

#Nivel3
cantidad_t800_nivel3 =3
cantidad_t1000_nivel3 = 0
cantidad_tx_nivel3 = 0
cantidad_jefe_nivel3 = 0
cantidad_nivel3 = 3
fondo_nivel3 = FONDO1

#Nivel4
cantidad_t800_nivel4 =1
cantidad_t1000_nivel4 = 1
cantidad_tx_nivel4 = 0
cantidad_jefe_nivel4 = 0
cantidad_nivel4 = 2
fondo_nivel4 = FONDO2

#Nivel5
cantidad_t800_nivel5 =0
cantidad_t1000_nivel5 = 2
cantidad_tx_nivel5 = 0
cantidad_jefe_nivel5 = 0
cantidad_nivel5 = 2
fondo_nivel5 = FONDO1

#Nivel6
cantidad_t800_nivel6 =0
cantidad_t1000_nivel6 = 3
cantidad_tx_nivel6 = 0
cantidad_jefe_nivel6 = 0
cantidad_nivel6 = 3
fondo_nivel6 = FONDO2

#Nivel7
cantidad_t800_nivel7 =0
cantidad_t1000_nivel7 = 1
cantidad_tx_nivel7 = 1
cantidad_jefe_nivel7 = 0
cantidad_nivel7 = 2
fondo_nivel7 = FONDO1

#Nivel8
cantidad_t800_nivel8 =0
cantidad_t1000_nivel8 = 0
cantidad_tx_nivel8 = 2
cantidad_jefe_nivel8 = 0
cantidad_nivel8 = 2
fondo_nivel8 = FONDO2

#Nivel9
cantidad_t800_nivel9 =0
cantidad_t1000_nivel9 = 0
cantidad_tx_nivel9 = 3
cantidad_jefe_nivel9 = 0
cantidad_nivel9 = 3
fondo_nivel9 = FONDO1

#Nivel10
cantidad_t800_nivel10 =0
cantidad_t1000_nivel10 = 0
cantidad_tx_nivel10 = 0
cantidad_jefe_nivel10 = 1
cantidad_nivel10 = 1
fondo_nivel10 = FONDO2