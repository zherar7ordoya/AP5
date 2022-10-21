import re
if re.match("python", "python"):
    print ("cierto")

if re.match(".ython", "python"):
    print("cierto")

if re.match(".ython", "jython"): 
    print("cierto")

if re.match("python|jython|cython", "python"):
    print("cierto")

if re.match("(p|j|c)ython", "python"): 
    print("cierto")

if re.match("python[0-9]", "python0"):
    print("cierto")
    
if re.match("python[0-9a-zA-Z]", "pythonp"):
    print("cierto")


if re.match("python[.,]", "python."):
    print("cierto")

#if re.match("python[\.,]", "python."):
#    print("cierto")

if re.match("python[^0-9a-z]", "python+"):
    print("cierto")



mo = re.match("http://.+net", "http://mundogeek.net")
print(mo.group())

mo = re.match("http://(.+).net", "http://mundogeek.net")
print(mo.group(0))
print(mo.group(1))

mo = re.match("http://(.+)(.{3})", "http://mundogeek.net")
print (mo.groups())



