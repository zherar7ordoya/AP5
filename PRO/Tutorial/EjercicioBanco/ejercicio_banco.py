"""
  @title        CAJERO BANCARIO
  @description  Ejercicio adicional del banco en poo
  @author       Gerardo Tordoya
  @date         2022-09-XX
  @credits      * * [] * *
"""

from dataclasses import dataclass
from getpass import getpass
from random import randrange
from secrets import randbelow
from time import sleep
from typing import Dict, Tuple, Callable, ClassVar


class Menu:
    """ Clase Menu """
    MENU: ClassVar[Tuple[
        Tuple[
            str, Callable[['Menu'], bool]
        ], ...
    ]]

    def screen(self):
        """ Pantalla """
        prompt = '\n'.join(
            f'{i}. {name}'
            for i, (name, fun) in enumerate(self.MENU)
        ) + '\n'

        while True:
            choice = input(prompt)

            try:
                name, fun = self.MENU[int(choice)]
            except ValueError:
                print('Invalid integer entered')
            except IndexError:
                print('Choice out of range')
            else:
                if fun(self):
                    break


@dataclass
class Account(Menu):
    """ Clase Account """
    card: str
    pin: str

    @classmethod
    def generate(cls) -> 'Account':
        """ Generar cuenta """
        return cls(
            card=f'400000{randrange(1e10):010}',
            pin=f'{randbelow(10_000):04}',
        )

    def dump(self):
        """ Mostrar datos """
        print(
            f"Your card number: {self.card}\n"
            f"Your PIN: {self.pin}"
        )

    def balance(self):
        """ Saldo """
        print('Balance: 0')

    def logout(self) -> bool:
        """ Cerrar sesión """
        print('You have successfully logged out!')
        return True

    def exit(self):
        """ Salir """
        print('Bye!')
        exit()

    MENU = (
        ('Exit', exit),
        ('Balance', balance),
        ('Log out', logout),
    )


class BankingSystem(Menu):
    """ Clase BankingSystem """
    def __init__(self):
        self.accounts: Dict[str, Account] = {}

    def create_account(self):
        """ Crear cuenta """
        account = Account.generate()
        print('Your card has been created')
        account.dump()
        self.accounts[account.card] = account

    def log_in(self):
        """ Iniciar sesión """
        for _ in range(3):
            card = input('Enter your card number: ')
            pin = getpass('Enter your PIN: ')

            account = self.accounts.get(card)
            if account is None or account.pin != pin:
                print('Wrong card or PIN')
                sleep(2)
            else:
                print('You have successfully logged in!')
                account.screen()
                break

    def exit(self) -> bool:
        """ Salir """
        print('Bye!')
        return True

    MENU = (
        ('Exit', exit),
        ('Create an account', create_account),
        ('Log into an account', log_in),
    )


BankingSystem().screen()
