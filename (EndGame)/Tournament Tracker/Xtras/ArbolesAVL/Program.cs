/*
  @title        GESTOR DE CAMPEONATOS
  @description  Aplicación para crear, organizar y administrar campeonatos.
  @author       Gerardo Tordoya
  @date         2022-10-10
  @credits      https://stackoverflow.com/a/36496436/14009797
*/

using System;
using Video1ArbolesAVL;
using static System.Console;

Nodo raiz = new()
{
    Nombre = "A".PadLeft(2, ' ').PadRight(3, ' '),
    Izquierda = new Nodo
    {
        Nombre = "B".PadLeft(2, ' ').PadRight(3, ' ')
    },
    Derecha = new Nodo
    {
        Nombre = "C".PadLeft(2, ' ').PadRight(3, ' ')
    }
};

raiz.Izquierda.Derecha = new Nodo
{
    Nombre = "D".PadLeft(2, ' ').PadRight(3, ' ')
};

raiz.Derecha.Izquierda = new Nodo
{
    Nombre = "E".PadLeft(2, ' ').PadRight(3, ' ')
};

raiz.Derecha.Derecha = new Nodo
{
    Nombre = "F".PadLeft(2, ' ').PadRight(3, ' ')
};

BTreePrinter.Print(raiz);

WriteLine(Environment.NewLine);
