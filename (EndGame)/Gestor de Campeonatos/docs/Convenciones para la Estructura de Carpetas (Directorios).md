# Convenciones para la Estructura de Carpetas (Directorios)

> Opciones de estructura de carpetas y convenciones de nomenclatura para proyectos de software

## Un diseño típico de directorio de nivel superior

    .
    ├── build       # Archivos compilados (alternativamente «dist»)
    ├── docs        # Archivos de documentación (alternativamente «doc»)
    ├── src         # Archivos de código fuente (alternativamente «lib» o «app»)
    ├── test        # Pruebas automatizadas (alternativamente «spec» o «tests»)
    ├── tools       # Herramientas y utilidades
    ├── LICENSE
    └── README.md

> Use nombres cortos en minúsculas al menos para los archivos y carpetas de nivel superior, excepto para los archivos `LICENSE` y `README.md`

## Archivos de Código Fuente

Los archivos de código fuente de un proyecto de software generalmente se almacenan dentro de la carpeta `src`. Alternativamente, puede colocarlos en `lib` (si está desarrollando una biblioteca), o en la carpeta `app` (si se supone que los archivos de código fuente de su aplicación no deben compilarse).

---
