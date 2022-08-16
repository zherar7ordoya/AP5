Public Class Menu

    Private Sub VectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VectoresToolStripMenuItem.Click
        Dim ofrmV As New frmvectores
        ofrmV.MdiParent = Me
        ofrmV.Show()
    End Sub

    Private Sub DataviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataviewToolStripMenuItem.Click
        Dim ofrmDV As New frmDataview
        ofrmDV.MdiParent = Me
        ofrmDV.Show()
    End Sub




    Private Sub TablaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TablaToolStripMenuItem.Click
        Dim ofrmDt As New frmTabla
        ofrmDt.MdiParent = Me
        ofrmDt.Show()
    End Sub

    Private Sub XmlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XmlToolStripMenuItem.Click
        Dim ofrmxml As New frmXML
        ofrmxml.MdiParent = Me
        ofrmxml.Show()
    End Sub

    Private Sub ExportarimportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarimportarToolStripMenuItem.Click
        Dim ofrmEI As New frmImpor_Export
        ofrmEI.MdiParent = Me
        ofrmEI.Show()
    End Sub

    Private Sub ListasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListasToolStripMenuItem.Click
        Dim ofrl As New frmListas
        ofrl.MdiParent = Me
        ofrl.Show()
    End Sub
End Class