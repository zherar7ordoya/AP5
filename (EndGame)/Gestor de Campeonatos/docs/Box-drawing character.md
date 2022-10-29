# How to type unicode characters in Windows 10?

1. Press and hold down the Alt key.
2. Press the + (plus) key on the numeric keypad.
3. Type the hexidecimal unicode value.
4. Release the Alt key.

        Alas, this appears to require a registry setting:

        1. Under HKEY_Current_User/Control Panel/Input Method
        2. Set EnableHexNumpad to "1"
        3. If you have to add it, set the type to be REG_SZ.

## Box Drawing

Usar Notepad (Block de Notas) cuando "interfiera" con la aplicación de destino

|        |        |        |        |        |        |        |        |        |        |        |        |        |        |        |        |
|--------|--------|--------|--------|--------|--------|--------|--------|--------|--------|--------|--------|--------|--------|--------|--------|
| 2500 ─ | 2501 ━ | 2502 │ | 2503 ┃ | 2504 ┄ | 2505 ┅ | 2506 ┆ | 2507 ┇ | 2508 ┈ | 2509 ┉ | 250A ┊ | 250B ┋ | 250C ┌ | 250D ┍ | 250E ┎ | 250F ┏ |
| 2510 ┐ | 2511 ┑ | 2512 ┒ | 2513 ┓ | 2514 └ | 2515 ┕ | 2516 ┖ | 2517 ┗ | 2518 ┘ | 2519 ┙ | 251A ┚ | 251B ┛ | 251C ├ | 251D ┝ | 251E ┞ | 251F ┟ |
| 2520 ┠ | 2521 ┡ | 2522 ┢ | 2523 ┣ | 2524 ┤ | 2525 ┥ | 2526 ┦ | 2527 ┧ | 2528 ┨ | 2529 ┩ | 252A ┪ | 252B ┫ | 252C ┬ | 252D ┭ | 252E ┮ | 252F ┯ |
| 2530 ┰ | 2531 ┱ | 2532 ┲ | 2533 ┳ | 2534 ┴ | 2535 ┵ | 2536 ┶ | 2537 ┷ | 2538 ┸ | 2539 ┹ | 253A ┺ | 253B ┻ | 253C ┼ | 253D ┽ | 253E ┾ | 253F ┿ |
| 2540 ╀ | 2541 ╁ | 2542 ╂ | 2543 ╃ | 2544 ╄ | 2545 ╅ | 2546 ╆ | 2547 ╇ | 2548 ╈ | 2549 ╉ | 254A ╊ | 254B ╋ | 254C ╌ | 254D ╍ | 254E ╎ | 254F ╏ |
| 2550 ═ | 2551 ║ | 2552 ╒ | 2553 ╓ | 2554 ╔ | 2555 ╕ | 2556 ╖ | 2557 ╗ | 2558 ╘ | 2559 ╙ | 255A ╚ | 255B ╛ | 255C ╜ | 255D ╝ | 255E ╞ | 255F ╟ |
| 2560 ╠ | 2561 ╡ | 2562 ╢ | 2563 ╣ | 2564 ╤ | 2565 ╥ | 2566 ╦ | 2567 ╧ | 2568 ╨ | 2569 ╩ | 256A ╪ | 256B ╫ | 256C ╬ | 256D ╭ | 256E ╮ | 256F ╯ |
| 2570 ╰ | 2571 ╱ | 2572 ╲ | 2573 ╳ | 2574 ╴ | 2575 ╵ | 2576 ╶ | 2577 ╷ | 2578 ╸ | 2579 ╹ | 257A ╺ | 257B ╻ | 257C ╼ | 257D ╽ | 257E ╾ | 257F ╿ |

---

## Block Elements

|        |        |        |        |        |        |        |        |        |        |        |        |        |        |        |        |
|--------|--------|--------|--------|--------|--------|--------|--------|--------|--------|--------|--------|--------|--------|--------|--------|
| 2580 ▀ | 2581 ▁ | 2582 ▂ | 2583 ▃ | 2584 ▄ | 2585 ▅ | 2586 ▆ | 2587 ▇ | 2588 █ | 2589 ▉ | 258A ▊ | 258B ▋ | 258C ▌ | 258D ▍ | 258E ▎ | 258F ▏ |
| 2590 ▐ | 2591 ░ | 2592 ▒ | 2593 ▓ | 2594 ▔ | 2595 ▕ | 2596 ▖ | 2597 ▗ | 2598 ▘ | 2599 ▙ | 259A ▚ | 259B ▛ | 259C ▜ | 259D ▝ | 259E ▞ | 259F ▟ |

---

Las consultas se hicieron en [Wikipedia](https://en.wikipedia.org/wiki/Box-drawing_character), y a su vez, Wikipedia cita a:

* [Box Drawing](http://www.unicode.org/charts/PDF/U2500.pdf)
* [Block Elements](http://www.unicode.org/charts/PDF/U2580.pdf)
* [Geometric Shapes Extended](http://www.unicode.org/charts/PDF/U2580.pdf) (*Este último chart no ha sido desarrollado en este documento*)

Éstos y otros charts se pueden encontrar en [Unicode Charts](http://www.unicode.org/charts/)[^1] siendo los aquí citados los más relevantes para el propósito de este documento y que allí figuran bajo la sección "Geometric Shapes" (que a su vez refiere a [este documento](http://www.unicode.org/charts/PDF/U25A0.pdf) del mismo nombre y que no sé bien qué es).

    Todos estos documentos están en formato PDF y los he agregado al proyecto de la solución. Eventualmente los reubicaré en adendas de la documentación del proyecto.

[^1]: Es decir, en última instancia, la fuente autoritativa es el [Unicode Consortium](https://home.unicode.org/).
