from tkinter import *

def boton_numerico(numeros):
    global operador
    operador = operador + str(numeros)
    display_texto.set(operador)

def boton_limpiar():
    global operador
    operador = ""
    display_texto.set("")

def boton_igual():
    global operador
    calculado = str(eval(operador)) # eval() es una función que interpreta una cadena como código.
    display_texto.set(calculado)
    operador = ""

calculadora = Tk()
calculadora.title("Calculadora")
operador = ""
display_texto = StringVar()

textbox_display = Entry(calculadora, font=('arial', 20, 'bold'), textvariable=display_texto, bd=30, insertwidth=4,
                   bg="powder blue", justify='right').grid(columnspan=4)

btn7 = Button(calculadora,
              padx=16,
              bd=8,
              fg="black",
              font=('arial', 20, 'bold'),
              text="7",
              bg="powder blue",
              command=lambda: boton_numerico(7)).grid(row=1, column=0)

btn8 = Button(calculadora, padx=16, bd=8, fg="black", font=('arial', 20, 'bold'), text="8", bg="powder blue",
              command=lambda: boton_numerico(8)).grid(row=1, column=1)

btn9 = Button(calculadora, padx=16, bd=8, fg="black", font=('arial', 20, 'bold'), text="9", bg="powder blue",
              command=lambda: boton_numerico(9)).grid(row=1, column=2)

Addition = Button(calculadora, padx=16, bd=8, fg="black", font=('arial', 20, 'bold'), text="+", bg="powder blue",
                  command=lambda: boton_numerico("+")).grid(row=1, column=3)

# =====================================================================================================================
btn4 = Button(calculadora, padx=16, bd=8, fg="black", font=('arial', 20, 'bold'), text="4", bg="powder blue",
              command=lambda: boton_numerico(4)).grid(row=2, column=0)

btn5 = Button(calculadora, padx=16, bd=8, fg="black", font=('arial', 20, 'bold'), text="5", bg="powder blue",
              command=lambda: boton_numerico(5)).grid(row=2, column=1)

btn6 = Button(calculadora, padx=16, bd=8, fg="black", font=('arial', 20, 'bold'), text="6", bg="powder blue",
              command=lambda: boton_numerico(6)).grid(row=2, column=2)

Subtraction = Button(calculadora, padx=16, bd=8, fg="black", font=('arial', 20, 'bold'), text="-", bg="powder blue",
                     command=lambda: boton_numerico("-")).grid(row=2, column=3)

# ======================================================================================================
btn1 = Button(calculadora, padx=16, bd=8, fg="black", font=('arial', 20, 'bold'), text="1", bg="powder blue",
              command=lambda: boton_numerico(1)).grid(row=3, column=0)

btn2 = Button(calculadora, padx=16, bd=8, fg="black", font=('arial', 20, 'bold'), text="2", bg="powder blue",
              command=lambda: boton_numerico(2)).grid(row=3, column=1)

btn3 = Button(calculadora, padx=16, bd=8, fg="black", font=('arial', 20, 'bold'), text="3", bg="powder blue",
              command=lambda: boton_numerico(3)).grid(row=3, column=2)

Multiply = Button(calculadora, padx=16, bd=8, fg="black", font=('arial', 20, 'bold'), text="*", bg="powder blue",
                  command=lambda: boton_numerico("*")).grid(row=3, column=3)

# ======================================================================================================
btn0 = Button(calculadora, padx=16, bd=8, fg="black", font=('arial', 20, 'bold'), text="0", bg="powder blue",
              command=lambda: boton_numerico(0)).grid(row=4, column=0)

btnClear = Button(calculadora, padx=16, bd=8, fg="black", font=('arial', 20, 'bold'), text="C", bg="powder blue",
                  command=boton_limpiar).grid(row=4, column=1)

btnEquals = Button(calculadora, padx=16, bd=8, fg="black", font=('arial', 20, 'bold'), text="=", bg="powder blue",
                   command=boton_igual).grid(row=4, column=2)

Division = Button(calculadora, padx=16, bd=8, fg="black", font=('arial', 20, 'bold'), text="/", bg="powder blue",
                  command=lambda: boton_numerico("/")).grid(row=4, column=3)

calculadora.mainloop()
