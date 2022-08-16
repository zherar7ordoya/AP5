Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO
Imports System.IO.Stream  'para exportar archivos

Public Class frmImpor_Export

    Private Sub frmImpor_Export_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGraficos()
    End Sub

    Sub CargarGraficos()
        'datos de los graficos
        Dim xValores As Array = {"Ganados", "Perdidos", "Empatados"}
        Dim yValores As Array = {67, 29.48, 49.35}
        'asocio los valores al control
        Chart1.Series("Series1").Points.DataBindXY(xValores, yValores)
        'titulo
        Chart1.Titles.Add("Estadisticas Partidos")
        'Tipo de grafico
        'chart1.Series["Series1"].ChartType = SeriesChartType.Pie; // tipo de gafico
        Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
        'Muesto las legendas de cada tipo con su color
        Chart1.Legends(0).Enabled = True
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox1.SelectedIndexChanged
        Chart1.Series("Series1").ChartType = [Enum].Parse(GetType(SeriesChartType), comboBox1.SelectedItem.ToString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Chart1.SaveImage(TextBox1.Text & "." & ComboBox2.SelectedItem.ToString, [Enum].Parse(GetType(ChartImageFormat), ComboBox2.SelectedItem.ToString))
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Creo la instancia del control  Openfiledialog
        Dim AbrirArchivo As New OpenFileDialog
        Dim nombreArchivo As String
        'Seteo las opciones del filtro
        AbrirArchivo.Filter = "Imagenes (*.Jpeg,*.Gif,*.Png,*.Bmp,*.Tiff)|*.Jpeg;*.Gif;*.Bmp;*.Tiff;*.Png"

        If AbrirArchivo.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            'uso el opendialog para traer el archivo y paso el nombre(ruta hasta el arhivo)
            nombreArchivo = AbrirArchivo.FileName
            Dim Miimage1 As Image = Image.FromFile(nombreArchivo)
            GroupBox2.BackgroundImage = ResizeImage(Miimage1)
        End If

    End Sub

    'utilizo la funcionm para redimensionar la imagen al tamaño del grpupbox2
    Public Shared Function ResizeImage(ByVal LaImagen As Image) As Image
        Return New Bitmap(LaImagen, New Size(305, 217))
    End Function

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Chart1.Palette = [Enum].Parse(GetType(ChartColorPalette), ComboBox3.SelectedItem.ToString)
    End Sub
End Class