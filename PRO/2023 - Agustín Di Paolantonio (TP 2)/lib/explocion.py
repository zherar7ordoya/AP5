import pygame
import os 
from lib.color import *
from lib.var import *

class Explocion(pygame.sprite.Sprite):
    
   
    def __init__(self,center):
        super().__init__()

        self.explosion_animacion = []
        self.posicion = 0
        self.center_explocion = []


        for i in range(9):
              imag = pygame.image.load(os.path.join('Sprites','regularExplosion{}.png'.format(i))).convert()
              image_scale = pygame.transform.scale(imag, (70, 70))
              image_scale.set_colorkey(BLACK)
              self.explosion_animacion.append(image_scale)
            
        self.image = pygame.Surface([46,47])
        self.rect = self.image.get_rect()
        self.rect.center = center
        self.ultimo_update = pygame.time.get_ticks()
        self.frame_rate = 50
        self.image = self.explosion_animacion[self.posicion]
        self.center_explocion = center
        
    
    def update(self):
      
        self.posicion += 1
      
        if self.posicion >= len(self.explosion_animacion):
            self.kill()
       
        else:
            
            self.image = pygame.Surface([46,47])
            self.rect = self.image.get_rect()
            self.rect.center = self.center_explocion
            self.image = self.explosion_animacion[self.posicion]
		   
						  
        
            
    

