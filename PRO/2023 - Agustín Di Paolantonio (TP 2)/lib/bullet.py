import pygame
import math
import os
from lib.var import *


class Bullet(pygame.sprite.Sprite):
   
    def __init__(self,x,y,angle):
        
        super().__init__()
        self.angle = angle
        self.image = pygame.transform.rotozoom(pygame.image.load(os.path.join('Sprites','laser2.png')).convert_alpha(),0 ,ESCALA_BULLET)
        self.rect = self.image.get_rect()
        self.rect.center = (x,y)
        self.hitbox = self.rect.copy()
        self.x= x
        self.y= y
        self.velocidad = VELOCIDAD_BULLET
        self.velocidad_x = math.cos(self.angle * (2*math.pi/360))* self.velocidad
        self.velocidad_y = math.sin(self.angle * (2*math.pi/360))* self.velocidad
        
    def movimiento(self):
       
        self.x += self.velocidad_x
        self.y += self.velocidad_y

        self.rect.x = int(self.x)
        self.rect.y = int(self.y)
    
    def control_flujo(self):
       
        if self.rect.centerx < 0 or self.rect.centery < 0 or self.rect.centerx > ANCHO_PANTALLA or self.rect.centery > ALTO_PANTALLA:
            self.kill()

    def update(self):

        self.movimiento()    
        self.control_flujo()
