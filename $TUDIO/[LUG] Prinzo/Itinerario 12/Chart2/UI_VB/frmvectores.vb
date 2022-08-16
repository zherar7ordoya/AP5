Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmvectores

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrafico()
    End Sub

    Sub cargarGrafico()
        'creo los array y le asigno valores
        Dim yValores As Double() = {15, 28.5, 9, 17, 41.5}
        Dim xNombres As String() = {" Juan", " Perdro", " Martin", " Julio", " Anibal"}
        'bindeo los valores con la serie del chart
        Chart1.Series(0).Points.DataBindXY(xNombres, yValores)
        'digo q tipo de grafico quiero (pie= torta)
        Chart1.Series(0).ChartType = SeriesChartType.Pie
        'y si lo quiero en 3D
        Chart1.ChartAreas(0).Area3DStyle.Enable3D = True
    End Sub



End Class
