import re

txt = "9999000011112222"

x = re.match("9{4}|8{4}|7{4}\d{12}$", txt)

print("Validado" if x else "Rechazado")