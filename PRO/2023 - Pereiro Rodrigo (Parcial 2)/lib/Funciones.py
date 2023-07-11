import os,sys, pygame, time
import lib.Variables as Variables

def dibujar_texto(negrita,_fuente,superficie,texto, tamano,color,x,y):
        fuente = pygame.font.Font(_fuente, tamano)
        fuente.set_bold(negrita)
        superficie_texto = fuente.render(texto, True, color)
        rect_texto = superficie_texto.get_rect()
        rect_texto.midtop=(x,y)
        superficie.blit(superficie_texto,rect_texto)