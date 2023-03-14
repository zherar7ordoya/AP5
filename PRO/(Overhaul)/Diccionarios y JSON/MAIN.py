import json
import pprint

with open('data.json', 'r') as archivo:
  diccionario = json.load(archivo)
archivo.close()

#diccionario = {
#  "name": "John",
#  "age": 30,
#  "married": True,
#  "divorced": False,
#  "children": ("Ann","Billy"),
#  "pets": None,
#  "cars": [
#    {"model": "BMW 230", "mpg": 27.5},
#    {"model": "Ford Edge", "mpg": 24.1}
#  ]
#}

# convert into JSON:
jayson = json.dumps(diccionario, indent=4)

with open('data.json', 'w') as archivo:
  json.dump(diccionario, archivo)

print(jayson)   # the result is a JSON string:

print("************************")

# convert into dictionary:
diccionario = json.loads(jayson)
pprint.pprint(diccionario, indent=4)
