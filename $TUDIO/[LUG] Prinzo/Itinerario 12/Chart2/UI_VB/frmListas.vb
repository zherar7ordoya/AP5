Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmListas
    Private Sub frmListas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGraficoListas()
    End Sub

    Private Lpersonas As List(Of Persona) = New List(Of Persona)()

    Private Sub CargarLista()
        Lpersonas.Add(New Persona() With {.Codigo = 1, .Nombre = "Juan", .Apellido = "Perez", .Sueldo = 70000})
        Lpersonas.Add(New Persona() With {.Codigo = 2, .Nombre = "Pedro", .Apellido = "Fernandez", .Sueldo = 70000})
        Lpersonas.Add(New Persona() With {.Codigo = 3, .Nombre = "Jose", .Apellido = "Gonzalez", .Sueldo = 50000})
        Lpersonas.Add(New Persona() With {.Codigo = 4, .Nombre = "Martin", .Apellido = "Garcia", .Sueldo = 170000})
        Lpersonas.Add(New Persona() With {.Codigo = 5, .Nombre = "Roman", .Apellido = "Riquelme", .Sueldo = 180000})
        Lpersonas.Add(New Persona() With {.Codigo = 6, .Nombre = "Analia", .Apellido = "Lopez", .Sueldo = 40000})
        Lpersonas.Add(New Persona() With {.Codigo = 7, .Nombre = "Lorena", .Apellido = "Legrand", .Sueldo = 15000})
        Lpersonas.Add(New Persona() With {.Codigo = 8, .Nombre = "Maria", .Apellido = "DelCerro", .Sueldo = 39000})
        Lpersonas.Add(New Persona() With {.Codigo = 9, .Nombre = "Fernanda", .Apellido = "Parente", .Sueldo = 50000})
        Lpersonas.Add(New Persona() With {.Codigo = 10, .Nombre = "Ignacio", .Apellido = "Claus", .Sueldo = 70000})

    End Sub

    Private Sub CargarGraficoListas()
        CargarLista()
        Dim ListaDatos As Dictionary(Of String, Double) = New Dictionary(Of String, Double)

        For Each objeto As Persona In Lpersonas
            Dim oPer As Persona = New Persona()
            oPer = objeto
            ListaDatos.Add(oPer.Apellido, oPer.Sueldo)
        Next

        Chart1.Titles.Clear()
        Chart1.ChartAreas.Clear()
        Chart1.Series.Clear()

        'agrego el titulo
        Dim Titulo As Title = New Title("Chart enlazado con Listas")
        Titulo.Font = New Font("Tahoma", 20, FontStyle.Bold)
        Chart1.Titles.Add(Titulo)

        'creo el area y habilito el gráfico en 3D
        Dim Area As ChartArea = New ChartArea()
        Area.Area3DStyle.Enable3D = True
        Chart1.ChartAreas.Add(Area)

        'agrego la serie
        Dim serie As Series = New Series("Sueldo")
        'digo q tipo de grafico quiero 
        serie.ChartType = SeriesChartType.Line
        serie.Points.DataBindXY(ListaDatos.Keys, ListaDatos.Values)

        Chart1.Series.Add(serie)
    End Sub



End Class