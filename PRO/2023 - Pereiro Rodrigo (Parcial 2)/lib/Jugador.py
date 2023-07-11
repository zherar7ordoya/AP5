import pygame, random
from lib import Variables
import lib.Funciones as Funciones



class Jugador(pygame.sprite.Sprite):
    def __init__(self):        
        super().__init__()
        #Variables graficas
        self.layer=2

        #Variables de juego
        self.vida = 0        
        self.jugada = None
        
        # Colores
        self.color_vida = Variables.VERDE
        self.color_fondo = Variables.ROJO
        self.ancho_barra_vida = 150
        self.alto_barra_vida = 10

    def elegir_opcion(self):
        self.jugada = random.randint(1, 3)
    
    def recibir_dano(self, dano):
         if self.vida>0:
            self.vida -= dano
            if self.vida < 0:
                self.vida = 0

    def obtener_jugada_texto(self):
        if self.vida>0:
            if self.jugada == 1:
                return "Piedra"
            elif self.jugada == 2:
                return "Papel"
            elif self.jugada == 3:
                return "Tijera"
            else:
                return "Ninguna"
        else:
            return "Eliminado"

    def update(self, pantalla):
        ancho_vida = int(self.ancho_barra_vida * (self.vida / self.max_vida))
        barra_vida = pygame.Rect(self.rect.centerx - self.ancho_barra_vida / 2, self.rect.y - self.alto_barra_vida - 5, ancho_vida, self.alto_barra_vida)
        pygame.draw.rect(pantalla, self.color_vida, barra_vida)
        Funciones.dibujar_texto(True,pygame.font.match_font(Variables.ARIAL),pantalla,"Jugada: "+str(self.obtener_jugada_texto()),18,Variables.GRIS_CLARO,self.rect.centerx,self.rect.y-40)
        barra_vida_fondo = pygame.Rect(self.rect.centerx - self.ancho_barra_vida / 2, self.rect.y - self.alto_barra_vida - 5, self.ancho_barra_vida, self.alto_barra_vida)
        pygame.draw.rect(pantalla, self.color_fondo, barra_vida_fondo, 2)            
        