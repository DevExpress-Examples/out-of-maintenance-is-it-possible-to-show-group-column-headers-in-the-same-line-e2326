Imports System
Imports System.ComponentModel
Imports System.Windows.Forms

Partial Public Class Form1
    Inherits Form

    Dim data As BindingList(Of TestData)

    Public Sub New()
        InitializeComponent()
        data = New BindingList(Of TestData)()
        myGridControl1.DataSource = data
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        InitData()
        myGridView1.CollapseAllGroups()
    End Sub

    Public Sub InitData()
        For i As Integer = 0 To 4
            data.Add(New TestData() With {
                     .Column1 = i, .Column2 = i, .Column3 = i,
                     .Column4 = i, .Column5 = i, .Column6 = i,
                     .Column7 = i, .Column8 = i, .Column9 = i, .Column10 = i})
        Next i
    End Sub
End Class

Public Class TestData
    Public Property Column1 As Integer
    Public Property Column10 As Integer
    Public Property Column2 As Integer
    Public Property Column3 As Integer
    Public Property Column4 As Integer
    Public Property Column5 As Integer
    Public Property Column6 As Integer
    Public Property Column7 As Integer
    Public Property Column8 As Integer
    Public Property Column9 As Integer
End Class