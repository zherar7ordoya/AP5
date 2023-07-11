import os,sys, pygame, time
import lib.Variables as Variables
import lib.Funciones as Funciones
import lib.Niveles as Nivel


def main():

    # Inicio PYGAME
    pygame.init()
    # Creo Pantalla
    _pantalla = pygame.display.set_mode((Variables.ANCHO,Variables.ALTURA))
    pygame.display.set_caption('Rodrigo Pereiro - Segundo Parcial')
    _fuente_score=pygame.font.match_font(Variables.ARIAL)
    _fuente_vidas=pygame.font.match_font(Variables.TAHOMA)
    _fuente_go=pygame.font.match_font(Variables.ARIAL)
    fondo=pygame.image.load(Variables.FONDORELATO).convert()
    fondo_rect= fondo.get_rect()
    
    # Establezco Reloj
    reloj = pygame.time.Clock()

    #creo las listas a utilizar
    _lista_elementos = pygame.sprite.LayeredUpdates()
    mostrar_inicio(_lista_elementos,_fuente_go,_pantalla,reloj)
    _salir=False
    nivel = Nivel.Nivel(_lista_elementos,_pantalla)
    
    while not _salir:
        _pantalla.fill((Variables.NEGRO))
        _pantalla.blit(fondo, fondo_rect)
       
        
    # Captura de eventos de teclado y mouse
        eventos_mouse = []
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                _salir = True
            if event.type == pygame.KEYDOWN:
                if event.key == pygame.K_ESCAPE:
                    _salir = True
            if event.type in (pygame.MOUSEBUTTONDOWN, pygame.MOUSEBUTTONUP):
                eventos_mouse.append(event)
        
    # Actualizacion de Pantalla
        nivel.update(eventos_mouse)
        fondo=pygame.image.load(nivel.fondo).convert()
        fondo_rect= fondo.get_rect()
        Funciones.dibujar_texto(True,_fuente_vidas,_pantalla,"NIVEL: "+str(nivel.nivel_actual),18,Variables.GRIS_CLARO,Variables.ANCHO/2,Variables.ALTURA-25)
        _lista_elementos.draw(_pantalla)       
        pygame.display.flip()        
        reloj.tick(Variables.FPS)   
        if nivel.jugador.vida <= 0 or nivel.victoria:
            _salir = True

    if nivel.jugador.vida <= 0:
        mostrar_game_over(_lista_elementos, _fuente_go, _pantalla, reloj)
    if nivel.victoria:
        mostrar_victoria(_lista_elementos, _fuente_go, _pantalla, reloj)
    pygame.quit()
    sys.exit()

# Muestra Relato Inicial
def mostrar_inicio(_lista_elementos,_fuente_go,_pantalla,reloj):
    fondo=pygame.image.load(Variables.FONDORELATO).convert()
    _pantalla.fill((Variables.NEGRO))
    _fondo_rect= fondo.get_rect()
    _pantalla.blit(fondo, _fondo_rect)
    _lista_elementos.empty()
    Funciones.dibujar_texto(True,_fuente_go,_pantalla,"En uno de los universos del multiverso de TERMINATOR. ",30,Variables.ROJO,Variables.ANCHO/2,5)
    Funciones.dibujar_texto(False,_fuente_go,_pantalla,"Debido a un bug en el programa de SKYNET las unidades terminator pueden atacar",24,Variables.GRIS_CLARO,Variables.ANCHO/2,65)
    Funciones.dibujar_texto(False,_fuente_go,_pantalla,"luego de ganar en piedra papel o tijera. Si pierden su defensa se deshabilita y",24,Variables.GRIS_CLARO,Variables.ANCHO/2,95)   
    Funciones.dibujar_texto(False,_fuente_go,_pantalla,"podemos contratacar. Tambien debido a que una mano de mono concedio un deseo de",24,Variables.GRIS_CLARO,Variables.ANCHO/2,125)     
    Funciones.dibujar_texto(False,_fuente_go,_pantalla,"que no existan las armas solo podemos atacar o ser atacados con un una madera",24,Variables.GRIS_CLARO,Variables.ANCHO/2,155)
    Funciones.dibujar_texto(False,_fuente_go,_pantalla,"con un clavo. Ayuda a John Connor y a la resistencia a destruir a las maquinas.",24,Variables.GRIS_CLARO,Variables.ANCHO/2,185)
    Funciones.dibujar_texto(False,_fuente_go,_pantalla,"Presione cualquier tecla para comenzar",24,Variables.AMARILLO,Variables.ANCHO/2,(Variables.ALTURA*4/5)+58)
    pygame.display.flip()
    _esperar = True
    while _esperar:
        reloj.tick(Variables.FPS)
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                pygame.quit()
                sys.exit()
            elif event.type == pygame.KEYUP:
                _esperar=False

# Muestra Relato Game Over
def mostrar_game_over(_lista_elementos,_fuente_go,_pantalla,reloj):
    fondo=pygame.image.load(Variables.FONDORELATO).convert()
    _pantalla.fill((Variables.NEGRO))
    _fondo_rect= fondo.get_rect()
    _pantalla.blit(fondo, _fondo_rect)
    _lista_elementos.empty()
    Funciones.dibujar_texto(True,_fuente_go,_pantalla,"GAMEOVER",30,Variables.ROJO,Variables.ANCHO/2,5)
    Funciones.dibujar_texto(False,_fuente_go,_pantalla,"¡¡¡La humanidad a perecido!!!",24,Variables.GRIS_CLARO,Variables.ANCHO/2,65)
    Funciones.dibujar_texto(False,_fuente_go,_pantalla,"El ultimo humano ha sucumbido al grito de:",24,Variables.GRIS_CLARO,Variables.ANCHO/2,95)   
    Funciones.dibujar_texto(False,_fuente_go,_pantalla,"¿POR QUE CREAMOS IAs?",24,Variables.GRIS_CLARO,Variables.ANCHO/2,125)     
    pygame.display.flip()
    _esperar = True
    while _esperar:
        reloj.tick(Variables.FPS)
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                pygame.quit()
                sys.exit()
            elif event.type == pygame.KEYUP:
                _esperar=False

# Muestra Relato Victoria
def mostrar_victoria(_lista_elementos,_fuente_go,_pantalla,reloj):
    fondo=pygame.image.load(Variables.FONDORELATO).convert()
    _pantalla.fill((Variables.NEGRO))
    _fondo_rect= fondo.get_rect()
    _pantalla.blit(fondo, _fondo_rect)
    _lista_elementos.empty()
    Funciones.dibujar_texto(True,_fuente_go,_pantalla,"VICTORIA",30,Variables.VERDE,Variables.ANCHO/2,5)
    Funciones.dibujar_texto(False,_fuente_go,_pantalla,"¡¡¡La humanidad se ha salvado!!!",24,Variables.GRIS_CLARO,Variables.ANCHO/2,65)
    Funciones.dibujar_texto(False,_fuente_go,_pantalla,"Nuestro anonimo salvador a eliminado a Skynet al grito de:",24,Variables.GRIS_CLARO,Variables.ANCHO/2,95)   
    Funciones.dibujar_texto(False,_fuente_go,_pantalla,"AHORA VOY POR TI ESTUPIDO FLANDERS POR HACER ESE DESEO",24,Variables.GRIS_CLARO,Variables.ANCHO/2,125)     
    pygame.display.flip()
    _esperar = True
    while _esperar:
        reloj.tick(Variables.FPS)
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                pygame.quit()
                sys.exit()
            elif event.type == pygame.KEYUP:
                _esperar=False

if __name__ == "__main__":
    main()
