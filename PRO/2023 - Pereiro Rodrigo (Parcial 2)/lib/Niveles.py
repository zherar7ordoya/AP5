from lib import Variables
import lib.J_Humano as Player
import lib.J_Computadora as Enemigo
import lib.Botones as Boton
import  pygame


class Nivel:
    def __init__(self,_lista_elementos,_pantalla):
        
        self.lista_enemigos = pygame.sprite.Group()
        self.lista_elementos =_lista_elementos
        self.lista_botones = pygame.sprite.Group()
        self.pantalla=_pantalla
        self.jugador=0
        self.nivel_actual = 0
        self.cantidad_jugador = 0
        self.cantidad_t800 = 0
        self.cantidad_t1000 = 0
        self.cantidad_tx = 0
        self.cantidad_jefe = 0
        self.cantidad_enemigos=0
        self.tiempo_inicio = 0
        self.fondo=0
        self.victoria=False
        self.GO=False
        self.posiciones_enemigo_x=[400,150,650]
        self.etapa_nivel=0
        self.piedra_btn=None
        self.papel_btn=None
        self.tijera_btn=None
        self.jugar_btn=None
        self.continuar_btn=None
        self.terminator_jugada=False
        self.calculo_dano_jugada=False
        
#Metodos de carga de nivel controla el juego a nivel niveles.          
    def cargar_nivel(self):
        if self.cantidad_enemigos==0 and self.nivel_actual<11:
            self.nivel_actual += 1
            if self.nivel_actual>10:
                self.victoria=True
            else:    
                    for enemigo in self.lista_enemigos:
                        enemigo.kill()
                    nombre_variable = "cantidad_t800_nivel" + str(self.nivel_actual)
                    self.cantidad_t800 = getattr(Variables, nombre_variable)
                    nombre_variable = "cantidad_t1000_nivel" + str(self.nivel_actual)
                    self.cantidad_t1000 = getattr(Variables, nombre_variable)
                    nombre_variable = "cantidad_tx_nivel" + str(self.nivel_actual)
                    self.cantidad_tx = getattr(Variables, nombre_variable)
                    nombre_variable = "cantidad_jefe_nivel" + str(self.nivel_actual)
                    self.cantidad_jefe = getattr(Variables, nombre_variable)
                    nombre_variable = "fondo_nivel" + str(self.nivel_actual)
                    self.fondo = getattr(Variables, nombre_variable)
                    nombre_variable = "cantidad_nivel" + str(self.nivel_actual)
                    self.cantidad_enemigos = getattr(Variables, nombre_variable)
                    self.jugador=Player.Humano()
                    self.jugador.vida=Variables.PLAYERVIDA
                    self.lista_enemigos.empty()
                    self.lista_elementos.empty()
                    self.lista_elementos.add(self.jugador)
                    self.spaw_botones()
                    self.spaw_enemigos()

#Metodos de generacion de botones y enemigos
    def spaw_botones(self):
        self.jugar_btn=Boton.Jugar()
        self.piedra_btn=Boton.Piedra()
        self.papel_btn=Boton.Papel()
        self.tijera_btn=Boton.Tijera()
        self.continuar_btn=Boton.Proxima_Ronda()
        self.lista_elementos.add(self.jugar_btn,self.piedra_btn,self.papel_btn,self.tijera_btn,self.continuar_btn)
        self.lista_botones.add(self.jugar_btn,self.piedra_btn,self.papel_btn,self.tijera_btn,self.continuar_btn)

    def mostrar_botones(self):
        for boton in self.lista_botones:
            boton.mostrar()
    
    def ocultar_botones(self):
        for boton in self.lista_botones:
            boton.ocultar()
       
    def spaw_enemigos(self):
        posiciones_enemigo=[False,False,False]
        for _ in range(self.cantidad_t800):
            i = self.encontrar_posicion_disponible(posiciones_enemigo)
            x =self.posiciones_enemigo_x[i]
            terminator = Enemigo.T800(x)
            self.lista_elementos.add(terminator)
            self.lista_enemigos.add(terminator)
            posiciones_enemigo[i] =True

        for _ in range(self.cantidad_t1000):
            i = self.encontrar_posicion_disponible(posiciones_enemigo)
            x =self.posiciones_enemigo_x[i]
            terminator = Enemigo.T1000(x)
            self.lista_elementos.add(terminator)
            self.lista_enemigos.add(terminator)
            posiciones_enemigo[i] =True

        for _ in range(self.cantidad_tx):
            i = self.encontrar_posicion_disponible(posiciones_enemigo)
            x =self.posiciones_enemigo_x[i]
            terminator = Enemigo.TX(x)
            self.lista_elementos.add(terminator)
            self.lista_enemigos.add(terminator)
            posiciones_enemigo[i] =True

        for _ in range(self.cantidad_jefe):
            terminator = Enemigo.Skynet()
            self.lista_elementos.add(terminator)
            self.lista_enemigos.add(terminator)

    def encontrar_posicion_disponible(self,posiciones):
        for i, posicion in enumerate(posiciones):
            if not posicion:
                return i  
        return None  

#Metodos de control de Juego
    def control_etapas_juego(self,eventos_mouse):
        pos_mouse = pygame.mouse.get_pos()
        if self.etapa_nivel==0:
            self.cargar_nivel()
            self.set_opciones()
            self.mostrar_botones()
            self.jugar_btn.ocultar()
            self.continuar_btn.ocultar()
            self.etapa_nivel=1

        if self.etapa_nivel==1:
            for evento in eventos_mouse:
                if evento.type == pygame.MOUSEBUTTONDOWN:
                    if self.piedra_btn.rect.collidepoint(pos_mouse):
                        self.jugador.elegir_opcion(1)
                        self.jugar_btn.mostrar()
                    elif self.papel_btn.rect.collidepoint(pos_mouse):
                        self.jugador.elegir_opcion(2)
                        self.jugar_btn.mostrar()
                    elif self.tijera_btn.rect.collidepoint(pos_mouse):
                        self.jugador.elegir_opcion(3)
                        self.jugar_btn.mostrar()
                    elif self.jugar_btn.rect.collidepoint(pos_mouse):
                        self.ocultar_botones()
                        self.continuar_btn.mostrar()
                        self.terminator_jugada=True
                        self.calculo_dano_jugada=True
                        self.etapa_nivel=2

        if self.etapa_nivel==2:
            if self.terminator_jugada:
                for terminator in self.lista_enemigos:
                    terminator.elegir_opcion()
                self.terminator_jugada=False
            if self.calculo_dano_jugada:
                self.analisis_dano()
                self.calculo_dano_jugada=False
            for evento in eventos_mouse:
                if evento.type == pygame.MOUSEBUTTONDOWN:
                    if self.continuar_btn.rect.collidepoint(pos_mouse):
                        self.etapa_nivel=0

    def set_opciones(self):
        self.jugador.jugada=None
        for enemigo in self.lista_enemigos:
            enemigo.jugada=None

    def analisis_dano(self):
        for terminator in self.lista_enemigos:
            
            if terminator.vida>0:
                resultado= self.analisis_jugada(terminator)
                if resultado == 0:
                    self.jugador.recibir_dano(terminator.ataque)
                else:
                    if resultado == 1:
                        terminator.recibir_dano(self.jugador.ataque)
                        if terminator.vida ==0:
                            self.cantidad_enemigos -=1
        if self.jugador.vida<1:
            self.GO=True

    def analisis_jugada(self,terminator):
        if self.jugador.jugada == 1 and terminator.jugada == 2:
            return 0
        else:
            if self.jugador.jugada == 1 and terminator.jugada == 3:
                return 1
            else:
                if self.jugador.jugada == 2 and terminator.jugada == 1:
                    return 1
                else:
                    if self.jugador.jugada == 2 and terminator.jugada == 3:
                        return 0
                    else:
                        if self.jugador.jugada == 3 and terminator.jugada == 1:
                            return 0
                        else:
                            if self.jugador.jugada== 3 and terminator.jugada == 2:
                                return 1
                            else:
                                if self.jugador.jugada == terminator.jugada:
                                    return 2

    def update(self,eventos_mouse):
        self.control_etapas_juego(eventos_mouse)
        self.lista_enemigos.update(self.pantalla)
        self.lista_elementos.update(self.pantalla)