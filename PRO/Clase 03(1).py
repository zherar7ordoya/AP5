"""_Ejercicio_
"""

word = input("Introduce una palabra: ")
vocals = ['a', 'e', 'i', 'o', 'u']

for vocal in vocals:
    TIMES = 0
    for letter in word:
        if letter == vocal:
            TIMES += 1
    print("La vocal " + vocal + " aparece " + str(TIMES) + " veces")
    