﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My

    'NOTE: This file is auto-generated; do not modify it directly.  To make changes,
    ' or if you encounter build errors in this file, go to the Project Designer
    ' (go to Project Properties or double-click the My Project node in
    ' Solution Explorer), and make changes on the Application tab.
    '
    Partial Friend Class MyApplication

        <DebuggerStepThrough()>
        Public Sub New()
            MyBase.New(AuthenticationMode.Windows)
            Me.IsSingleInstance = False
            Me.EnableVisualStyles = True
            Me.SaveMySettingsOnExit = True
            Me.ShutdownStyle = ShutdownMode.AfterMainFormCloses
        End Sub

        <DebuggerStepThrough()>
        Protected Overrides Sub OnCreateMainForm()
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(DemoForm))
            Dim image As Image = CType(resources.GetObject("ribbonOrbMenuItem1.Image"), Image)
            Me.MainForm = VbDemo.DemoForm
        End Sub
    End Class
End Namespace
