import pygame
import os
from lib.var import *
from lib.color import *

class Coin(pygame.sprite.Sprite):
    def __init__(self, center):
        super().__init__()
        self.image = pygame.Surface([46,47])
        self.rect = self.image.get_rect()
        self.rect.center = center
        self.image = pygame.transform.rotozoom(pygame.image.load(os.path.join('Sprites','gema.png')).convert(),0 ,ESCALA_COIN)
        self.image.set_colorkey(WHITE)

        
