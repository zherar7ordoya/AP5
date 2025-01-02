import pygame
import math
import os 
from lib.var import *
import random

class Asteroide(pygame.sprite.Sprite):
    def __init__(self):
        super().__init__()
        self.velocidad = random.randrange(2,4)
        self.image = pygame.transform.rotozoom(pygame.image.load(os.path.join('Sprites','meteorGrey_med1.png')).convert_alpha(),0,ESCALA_METEORITO)
        self.posicion = pygame.math.Vector2(random.randrange(PARAMETRO_APARICION_X[0],PARAMETRO_APARICION_X[1]), random.randrange(PARAMETRO_APARICION_Y[0],PARAMETRO_APARICION_Y[1])) 
        self.rect = self.image.get_rect()
        self.rect.center = (self.posicion[0], self.posicion[1])
        self.hitbox = self.rect.copy()
        self.x = self.posicion[0]
        self.y = self.posicion[1]
        
        self.angle = random.randrange(360)
        self.velocidad_x = math.cos(self.angle * (2*math.pi/360))* self.velocidad
        self.velocidad_y = math.sin(self.angle * (2*math.pi/360))* self.velocidad

    def movimiento(self):
        
        self.x += self.velocidad_x
        self.y += self.velocidad_y

        self.rect.x = int(self.x)
        self.rect.y = int(self.y)



    def control_flujo(self):
        if self.rect.centerx < 0 or self.rect.centery < 0 or self.rect.centerx > ANCHO_PANTALLA or self.rect.centery > ALTO_PANTALLA:
            self.posicion = pygame.math.Vector2(random.randrange(PARAMETRO_APARICION_X[0],PARAMETRO_APARICION_X[1]), random.randrange(PARAMETRO_APARICION_Y[0],PARAMETRO_APARICION_Y[1]))
            self.x = self.posicion[0]
            self.y = self.posicion[1]
            self.angle = random.randrange(360)
            self.velocidad_x = math.cos(self.angle * (2*math.pi/360))* self.velocidad
            self.velocidad_y = math.sin(self.angle * (2*math.pi/360))* self.velocidad
        


    def update(self):
        self.movimiento()
        self.control_flujo()
        