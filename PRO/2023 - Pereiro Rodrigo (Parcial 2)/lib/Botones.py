import pygame, random
from lib import Variables

class Boton(pygame.sprite.Sprite):
    def __init__(self):
        super().__init__()
           
    def ocultar(self):
        self.rect.x=-100
        self.rect.y=-100

    def mostrar(self):
        self.rect.centerx=self.x_original
        self.rect.centery=self.y_original

    def update(self,pantalla):
        pass

class Jugar(Boton):
    def __init__(self):
        super().__init__()
        self.x_original = Variables.ANCHO/2 
        self.y_original = Variables.ALTURA/2 
        self.superficie=pygame.Surface([Variables.JUGARALTO,Variables.JUGARANCHO])
        self.image=pygame.image.load(Variables.JUGARIMAGEGREEN).convert_alpha()
        self.rect=self.image.get_rect() 
        self.rect.centerx=self.x_original
        self.rect.centery=self.y_original
        self.image.set_colorkey(Variables.NEGRO)

class Proxima_Ronda(Boton):
    def __init__(self):
        super().__init__()
        self.x_original = Variables.ANCHO/2 + 100
        self.y_original = Variables.ALTURA/2 
        self.superficie=pygame.Surface([Variables.JUGARALTO,Variables.JUGARANCHO])
        self.image=pygame.image.load(Variables.JUGARIMAGEGREEN).convert_alpha()
        self.rect=self.image.get_rect() 
        self.rect.centerx=self.x_original
        self.rect.centery=self.y_original
        self.image.set_colorkey(Variables.NEGRO)    

class Piedra(Boton):
    def __init__(self):
        super().__init__()
        self.x_original = 100 
        self.y_original = Variables.ALTURA/2 
        self.superficie=pygame.Surface([Variables.PIEDRAALTO,Variables.PIEDRAANCHO])
        self.image=pygame.image.load(Variables.PIEDRAIMAGEGREEN).convert_alpha()
        self.rect=self.image.get_rect() 
        self.rect.centerx=self.x_original
        self.rect.centery=self.y_original
        self.image.set_colorkey(Variables.NEGRO)
    
class Papel(Boton):
    def __init__(self):
        super().__init__()
        self.x_original = 100  
        self.y_original = (Variables.ALTURA/2)+40
        self.superficie=pygame.Surface([Variables.PAPELALTO,Variables.PAPELANCHO])
        self.image=pygame.image.load(Variables.PAPELIMAGEGREEN).convert_alpha()
        self.rect=self.image.get_rect() 
        self.rect.centerx=self.x_original
        self.rect.centery=self.y_original
        self.image.set_colorkey(Variables.NEGRO)
    
class Tijera(Boton):
    def __init__(self):
        super().__init__()
        self.x_original = 100  
        self.y_original = (Variables.ALTURA/2)+80 
        self.superficie=pygame.Surface([Variables.TIJERASALTO,Variables.TIJERASANCHO])
        self.image=pygame.image.load(Variables.TIJERASIMAGEGREEN).convert_alpha()
        self.rect=self.image.get_rect() 
        self.rect.centerx=self.x_original
        self.rect.centery=self.y_original
        self.image.set_colorkey(Variables.NEGRO)

    