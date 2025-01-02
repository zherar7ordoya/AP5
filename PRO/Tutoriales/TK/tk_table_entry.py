"""
@title: How To Display Data In A Table Using Tkinter
@description: This article shows 4 ways to display data in a table using Tkinter.
@url: https://www.activestate.com/resources/quick-reads/how-to-display-data-in-a-table-using-tkinter/
@author: Gerardo Tordoya
@date: 2022-10-21
@license: MIT
@version: 1.0.0
@python: 3.7.9
@tags: tkinter, table, display, data
"""

from tkinter import *

rows = []

for i in range(5):

    cols = []

    for j in range(4):
        e = Entry(relief=GROOVE)

        e.grid(row=i, column=j, sticky=NSEW)

        e.insert(END, '%d.%d' % (i, j))

        cols.append(e)

    rows.append(cols)

mainloop()
