import pygame
import math
import os
from lib.var import *
from lib import bullet

class jugador(pygame.sprite.Sprite):
    
    
    def __init__(self):
        super().__init__()
        self.image = pygame.transform.rotozoom(pygame.image.load(os.path.join('Sprites','nave3.png')).convert_alpha(), 0, ESCALA_JUGADOR)
        self.posicion = pygame.math.Vector2(INICIO_X, INICIO_Y) 
        self.velocidad = VELOCIDAD
        self.base_jugador = self.image
        self.hitbox = self.base_jugador.get_rect(center = self.posicion)
        self.rect = self.hitbox.copy()
        self.shooting = False
        self.vida = 100
        self.puntuacion = 0
       
        
       
    def comandos(self):
        self.velocidad_x = 0
        self.velocidad_y = 0

        keys = pygame.key.get_pressed()

        if keys[pygame.K_UP]:
            self.velocidad_y = -self.velocidad
        if keys[pygame.K_DOWN]:
            self.velocidad_y = self.velocidad
        if keys[pygame.K_RIGHT]:
            self.velocidad_x = self.velocidad
        if keys[pygame.K_LEFT]:
            self.velocidad_x = -self.velocidad


       
    
    def is_shooting(self, evento):

        
           if evento.type == pygame.MOUSEBUTTONDOWN:
             laser = bullet.Bullet(self.posicion[0], self.posicion[1], self.angulo_variacion)
                     
             return laser
        
                 
        

    
    def rotacion(self):
        self.mouse_coordenadas = pygame.mouse.get_pos()
        self.variacion_mouse_x = (self.mouse_coordenadas[0]- self.hitbox.centerx)
        self.variacion_mouse_y = (self.mouse_coordenadas[1]- self.hitbox.centery)
        self.angulo_variacion = math.degrees(math.atan2(self.variacion_mouse_y, self.variacion_mouse_x))
        self.image = pygame.transform.rotate(self.base_jugador, -self.angulo_variacion)
        self.rect = self.image.get_rect(center = self.hitbox.center)

    def movimiento(self):
        self.posicion += pygame.math.Vector2(self.velocidad_x, self.velocidad_y)
        self.hitbox.center = self.posicion
        self.rect.center = self.hitbox.center

        if self.rect.centery >= 650:
            self.posicion.y = 650
        if self.rect.centerx >= 1350:
           self.posicion.x = 1350
        
        if self.rect.centerx < 0:
            self.posicion.x = 0
        if self.rect.centery < 0:
            self.posicion.y = 0
        


    def update(self):
        self.comandos()
        self.movimiento() 
        self.rotacion()

