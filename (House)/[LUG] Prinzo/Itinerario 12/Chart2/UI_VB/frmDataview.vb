Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data

Public Class frmDataview
    Dim Ds As New DataSet
    Private Sub frmDataview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearDataset()
        cargargraficoDS()
    End Sub

    Private Sub cargargraficoDS()
        'instancio una vista del DS
        Dim Dvista As New DataView(Ds.Tables(0))
        'bindeo los valores con la serie del chart
        chart1.Series(0).Points.DataBindXY(Dvista, "Nombre", Dvista, "Saldo")
        'digo q tipo de grafico quiero (bar= narras)
        chart1.Series(0).ChartType = SeriesChartType.Bar
        'y si lo quiero en 3D
        chart1.ChartAreas(0).Area3DStyle.Enable3D = True
    End Sub

    Private Sub CrearDataset()

        'DESDE ADO.NET SE PUEDE INSTANCIAR UN DATATABLE FUERA DE UN DATASET
        Dim Dt As New DataTable("Persona")

        'LAS COLUMNAS SE PUEDEN INSTANCIAR FUERA DEL DATATABLE Y AGREGAR LUEGO
        Dim Dcolum As New DataColumn("Id", GetType(System.Int32))
        Dt.Columns.Add(Dcolum)
        'O SE PUEDEN AGREGAR DIRECTAMENTE
        Dt.Columns.Add("Nombre", GetType(System.String))
        Dt.Columns.Add("Apellido", GetType(System.String))
        Dt.Columns.Add("Direccion", GetType(System.String))
        Dt.Columns.Add("Saldo", GetType(System.Double))
        Ds.Tables.Add(Dt)

        'LLENAMOS LA TABLA PERSONA
        Dim _with2 = Ds.Tables("Persona").Rows
        _with2.Add(1, "Jose", "San Martín", "Libertador 1212", 9000)
        _with2.Add(2, "Pedro", "Rivadavia", "Rivadavia 2150", 30000)
        _with2.Add(3, "Domingo", "Sarmiento", "Sarmiento 2500", 18000)
        _with2.Add(4, "Laura", "O Higgins", "O Higgins 710", 25000)
        _with2.Add(5, "Sofia", "Bolivar", "Bolivar 2100", 65000)

    End Sub
End Class