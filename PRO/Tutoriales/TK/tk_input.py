# Import tkinter and simple dialog
import tkinter as tk
from tkinter import simpledialog
import tkinter.messagebox as msgbox

# Define the root window
ROOT = tk.Tk()

# Define input dialog
ROOT.withdraw()

# Define the input dialog
usuario = simpledialog.askstring(title="Input", prompt="¿Cuál es tu nombre?\t\t")

# Print the user input
if usuario:
    msgbox.showinfo(title="Bienvenida", message=f"¡Hola {usuario}!", icon='info')
