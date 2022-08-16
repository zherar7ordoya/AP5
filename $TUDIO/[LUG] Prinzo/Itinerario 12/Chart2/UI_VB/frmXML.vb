Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmXML



    Private Sub frmXML_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosXML()
    End Sub


    Sub CargarDatosXML()
        'Inicializo una instancia de un Dataset
        Dim DS As New DataSet()
        ' Leeo el achivo XML y lo almaceno en el Dataset.
        DS.ReadXml("Personas.xml")
        Chart1.DataSource = DS
        ' Especifique los miembros de datos de argumento y valor para la serie.
        Chart1.Series(0).XValueMember = "nombre"
        Chart1.Series(0).YValueMembers = "saldo"
        'digo q tipo de grafico quiero 
        Chart1.Series(0).ChartType = SeriesChartType.StackedColumn
        'y si lo quiero en 3D
        Chart1.ChartAreas(0).Area3DStyle.Enable3D = True
        Chart1.DataBind()
    End Sub
End Class