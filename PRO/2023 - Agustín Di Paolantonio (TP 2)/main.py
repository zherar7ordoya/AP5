import pygame
import os
from sys import exit
from lib.var import *
import lib.juego as juego

def main():
    pygame.init()
       
    game = juego.juego()

    win = False    
    game_over = False
    running = True

    while running:
       
        if game_over is False and win is False:
            for evento in pygame.event.get():

                if evento.type == pygame.QUIT:
                    running = False

                
                if evento.type == pygame.MOUSEBUTTONDOWN:
                    laser = game.jugador.is_shooting(evento)
                    game.listado_laser.add(laser)
                    game.listado_sprites.add(laser)
            
            game_over, win = game.detector_colisiones()
            game.dibujarpantalla()
            
       

        elif game_over is True and win is False:
            game.game_over_screen()
            for evento in pygame.event.get():
                if evento.type == pygame.QUIT:
                    running = False
           
            key = pygame.key.get_pressed()
            if key[pygame.K_SPACE]:
                    main()
       
        elif game_over is False and win is True:
            game.win_screen()  
            for evento in pygame.event.get():
                if evento.type == pygame.QUIT:
                    running = False
            
            key = pygame.key.get_pressed()
            if key[pygame.K_SPACE]:
                    main()         
              
                  


    pygame.quit()
    exit()

    
     


if __name__ == "__main__":
        main()
