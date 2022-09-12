#!/usr/bin/env python

""" *------------------>= [DESCRIPCIÓN DE ESTE MÓDULO] <=----------------------*
This program is free software: you can redistribute it and/or modify it under
the terms of the GNU General Public License as published by the Free Software
Foundation, either version 3 of the License, or (at your option) any later
version.
"""
__author__ = "Gerardo Tordoya"
__date__ = "2022/09/12"

# *------------------------->= [Run Forest, run!] <=---------------------------*

word = input("Introduce una palabra: ")
vocals = ['a', 'e', 'i', 'o', 'u']

for vocal in vocals:
    TIMES = 0
    for letter in word:
        if letter == vocal:
            TIMES += 1
    print("La vocal " + vocal + " aparece " + str(TIMES) + " veces")
    