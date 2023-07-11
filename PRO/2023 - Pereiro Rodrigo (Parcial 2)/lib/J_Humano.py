import pygame, random, math, time
from lib import Variables
import lib.Jugador as Jugador

class Humano(Jugador.Jugador):
    def __init__():
        pass
    
    def __init__(self):
        super().__init__()
        self.superficie=pygame.Surface([Variables.PLAYERALTO,Variables.PLAYERANCHO])
        self.image=pygame.image.load(Variables.PLAYERIMAGEGREEN).convert_alpha()
        self.image=pygame.transform.scale(self.image,(150,150))
        self.rect=self.image.get_rect() 
        self.rect.centerx=Variables.ANCHO/2
        self.rect.centery=Variables.ALTURA-90
        self.image.set_colorkey(Variables.NEGRO)
        self.vida=Variables.PLAYERVIDA
        self.max_vida=Variables.PLAYERVIDA
        self.ataque=25
        self.dano_recibido=0
        self.jugada = 0

    def elegir_opcion(self, opcion):
        if self.vida>0:
            self.jugada = opcion

    