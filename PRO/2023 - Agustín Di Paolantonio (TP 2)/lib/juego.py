import pygame
import math
import os
from sys import exit
from lib.var import *
from lib import Jugador
from lib import asteroide 
from lib import bullet
from lib import explocion
from lib import coin
from lib.color import * 

class juego(object):

   
    def __init__(self):
        
        self.pantalla = pygame.display.set_mode((ANCHO_PANTALLA, ALTO_PANTALLA))
        self.fondo = pygame.transform.scale(pygame.image.load(os.path.join('Sprites','fondo galaxia.jpg')).convert(),(ANCHO_PANTALLA, ALTO_PANTALLA,))
        pygame.display.set_caption('Galaxy Travel')
        self.clock = pygame.time.Clock()
        self.listado_laser = pygame.sprite.Group()
        self.listado_ateroides = pygame.sprite.Group()
        self.listado_explosiones = pygame.sprite.Group()
        self.listado_coins = pygame.sprite.Group()
        self.listado_sprites = pygame.sprite.Group()
        
                
        self.puntuacion = 0
        self.game_over = False  
        self.win = False
        self.jugador = Jugador.jugador()
        self.listado_sprites = pygame.sprite.Group()
        self.listado_sprites.add(self.jugador)
        
        
       
        for i in range(8):
            ast = asteroide.Asteroide()
            self.listado_sprites.add(ast)
            self.listado_ateroides.add(ast)
    
    def barra_vida(self,x, y, porcentage,pantalla):
	
         fill = (porcentage / 100) * BAR_LARGO
         border = pygame.Rect(x, y, BAR_LARGO, BAR_ALTO)
         fill = pygame.Rect(x, y, fill, BAR_ALTO)
         pygame.draw.rect(pantalla, GREEN, fill)
         pygame.draw.rect(pantalla, WHITE, border, 2)
   
    def marcador(self, text, size, x, y):
         font =pygame.font.SysFont("serif", size)
         text_surface = font.render(text, True, WHITE)
         text_rect = text_surface.get_rect()
         text_rect.midtop=(x,y)
         self.pantalla.blit(text_surface, (0,0))
    
    def game_over_screen(self):
         font =pygame.font.SysFont("serif", 80)
         text_surface = font.render("Game Over", True, WHITE)
         text_rect = text_surface.get_rect()
         text_rect.midtop=(ANCHO_PANTALLA/2,ALTO_PANTALLA/2)
         
         self.pantalla.blit(text_surface, (ANCHO_PANTALLA/2 - 200 , ALTO_PANTALLA/2))

         pygame.display.update()
         self.clock.tick(FRAMES)

       

    def detector_colisiones(self):
            
            hits = pygame.sprite.spritecollide(self.jugador, self.listado_ateroides, True)
            for hit1 in hits:
            
                self.jugador.vida -= 25
                ast = asteroide.Asteroide()
                self.listado_ateroides.add(ast)
                self.listado_sprites.add(ast)
                

                if self.jugador.vida <= 0:
                    
                    self.game_over = True
                                    


            hits2 = pygame.sprite.groupcollide(self.listado_laser, self.listado_ateroides, True, True)
            for hit2 in hits2:
                
                    
                self.jugador.puntuacion += 10
                explo = explocion.Explocion(hit2.rect.center)
                ast = asteroide.Asteroide()
                self.listado_explosiones.add(explo)
                self.listado_sprites.add(ast)
                self.listado_ateroides.add(ast)

                if self.jugador.puntuacion == 80:
                    c = coin.Coin(hit2.rect.center)
                    self.listado_coins.add(c)
            
            hits3 = pygame.sprite.spritecollide(self.jugador, self.listado_coins, True)
            if hits3:
                self.win = True

            return self.game_over, self.win
    
    def dibujarpantalla(self):   
                 
            self.pantalla.blit(self.fondo,(0 ,0))
            self.listado_sprites.draw(self.pantalla)
            self.listado_sprites.update()
            self.listado_explosiones.draw(self.pantalla)
            self.listado_explosiones.update()
            self.listado_coins.draw(self.pantalla)
            self.listado_coins.update()
            self.marcador(str(self.jugador.puntuacion), 20,(ANCHO_PANTALLA/2),0)
            self.barra_vida(0,30,self.jugador.vida, self.pantalla)
            pygame.display.update()
            self.clock.tick(FRAMES)
    
    def win_screen(self):
         font =pygame.font.SysFont("serif", 80)
         text_surface = font.render("WINNER", True, WHITE)
         text_rect = text_surface.get_rect()
         text_rect.midtop=(ANCHO_PANTALLA/2,ALTO_PANTALLA/2)
         self.pantalla.blit(text_surface, (ANCHO_PANTALLA/2 - 150,ALTO_PANTALLA/2))
         pygame.display.update()
         