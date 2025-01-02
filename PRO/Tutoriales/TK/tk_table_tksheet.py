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

import tkinter as tk

import tksheet

top = tk.Tk()

sheet = tksheet.Sheet(top)

sheet.grid()

sheet.set_sheet_data([[f"{ri+cj}" for cj in range(4)] for ri in range(1)])

# table enable choices listed below:

sheet.enable_bindings(("single_select",

                       "row_select",

                       "column_width_resize",

                       "arrowkeys",

                       "right_click_popup_menu",

                       "rc_select",

                       "rc_insert_row",

                       "rc_delete_row",

                       "copy",

                       "cut",

                       "paste",

                       "delete",

                       "undo",

                       "edit_cell"))

top.mainloop()