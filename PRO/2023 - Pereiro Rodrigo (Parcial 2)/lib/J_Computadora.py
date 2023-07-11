import pygame, random, math, time
from lib import Variables
import lib.Jugador as Jugador

class T800(Jugador.Jugador):
    def __init__():
        pass
    def __init__(self,x):
        super().__init__()
        self.superficie=pygame.Surface([Variables.T800ALTO,Variables.T800ANCHO])
        self.image=pygame.image.load(Variables.T800IMAGEGREEN).convert_alpha()
        self.image=pygame.transform.scale(self.image,(150,118))
        self.rect=self.image.get_rect() 
        self.rect.centerx=x
        self.rect.centery= 120
        self.image.set_colorkey(Variables.NEGRO)
        self.vida=100
        self.max_vida=100
        self.ataque=2
        self.dano_recibido=0
        self.jugada = None
      
class T1000(Jugador.Jugador):
    def __init__():
        pass
    def __init__(self,x):
        super().__init__()
        self.superficie=pygame.Surface([Variables.T1000ALTO,Variables.T1000ANCHO])
        self.image=pygame.image.load(Variables.T1000IMAGEGREEN).convert_alpha()
        self.image=pygame.transform.scale(self.image,(150,150))
        self.rect=self.image.get_rect() 
        self.rect.centerx=x
        self.rect.centery= 120
        self.image.set_colorkey(Variables.VERDE)
        self.vida=125
        self.max_vida=125
        self.ataque=4
        self.dano_recibido=0
        self.jugada = None
    
class TX(Jugador.Jugador):
    def __init__():
        pass
    def __init__(self,x):
        super().__init__()        
        self.superficie=pygame.Surface([Variables.TXALTO,Variables.TXANCHO])
        self.image=pygame.image.load(Variables.TXIMAGEGREEN).convert_alpha()
        self.image=pygame.transform.scale(self.image,(75,150))
        self.rect=self.image.get_rect() 
        self.rect.centerx=x
        self.rect.centery= 120
        self.image.set_colorkey(Variables.NEGRO)
        self.vida=150
        self.max_vida=150
        self.ataque=5
        self.dano_recibido=0
        self.jugada = None

class Skynet(Jugador.Jugador):
    def __init__():
        pass
    def __init__(self):
        super().__init__()
        self.superficie=pygame.Surface([Variables.SKYNETALTO,Variables.SKYNETANCHO])
        self.image=pygame.image.load(Variables.SKYNETIMAGEGREEN).convert_alpha()
        self.image=pygame.transform.scale(self.image,(150,208))
        self.rect=self.image.get_rect() 
        self.rect.centerx=Variables.ANCHO/2
        self.rect.y= 50
        self.image.set_colorkey(Variables.NEGRO)
        self.vida=200
        self.max_vida=200
        self.ataque=8
        self.dano_recibido=0
        self.jugada = None
    
   