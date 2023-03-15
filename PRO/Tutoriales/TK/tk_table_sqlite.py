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

from tkinter import ttk

import tkinter as tk

import sqlite3


def connect():
    con1 = sqlite3.connect("tk_table_sqlite.db")

    cur1 = con1.cursor()

    cur1.execute("CREATE TABLE IF NOT EXISTS table1(id INTEGER PRIMARY KEY, First TEXT, Surname TEXT)")

    con1.commit()

    con1.close()


def view():
    con1 = sqlite3.connect("tk_table_sqlite.db")

    cur1 = con1.cursor()

    cur1.execute("SELECT * FROM table1")

    rows = cur1.fetchall()

    for row in rows:
        print(row)

        tree.insert("", tk.END, values=row)

    con1.close()


# connect to the database

connect()

root = tk.Tk()

tree = ttk.Treeview(root, column=("c1", "c2", "c3"), show='headings')

tree.column("#1", anchor=tk.CENTER)

tree.heading("#1", text="ID")

tree.column("#2", anchor=tk.CENTER)

tree.heading("#2", text="FNAME")

tree.column("#3", anchor=tk.CENTER)

tree.heading("#3", text="LNAME")

tree.pack()

button1 = tk.Button(text="Display data", command=view)

button1.pack(pady=10)

root.mainloop()
