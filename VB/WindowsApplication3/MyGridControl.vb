Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid.Registrator
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing

Public Class MyGridControl
    Inherits GridControl
    Protected Overrides Function CreateDefaultView() As BaseView
        Return CreateView("MyGridView")
    End Function
    Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
        MyBase.RegisterAvailableViewsCore(collection)
        collection.Add(New MyGridViewInfoRegistrator())
    End Sub
End Class

Public Class MyGridView
    Inherits GridView
    Public Sub New()
        Me.New(Nothing)
    End Sub
    Public Sub New(ByVal grid As DevExpress.XtraGrid.GridControl)
        MyBase.New(grid)
    End Sub

    Protected Overrides ReadOnly Property ViewName() As String
        Get
            Return "MyGridView"
        End Get
    End Property
End Class

Public Class MyGridViewInfo
    Inherits GridViewInfo
    Public Sub New(ByVal gridView As GridView)
        MyBase.New(gridView)
    End Sub

    Protected Overrides Function CalcGroupPanelHeight() As Integer
        MyBase.CalcGroupPanelHeight()
        Return GroupLineDY * 2 + ColumnRowHeight
    End Function

    Protected Overrides Function CalcGroupPanelRowDrawInfo(ByVal bounds As Rectangle, ByVal showCaption As Boolean, ByVal lineStyle As Boolean) As GroupPanelRow
        Dim groupPanelRow As GroupPanelRow = MyBase.CalcGroupPanelRowDrawInfo(bounds, showCaption, lineStyle)
        If groupPanelRow.ColumnsInfo.Count > 1 Then
            Dim y As Integer = groupPanelRow.ColumnsInfo(0).Bounds.Y
            For Each args As GridColumnInfoArgs In groupPanelRow.ColumnsInfo
                args.Bounds = New Rectangle(args.Bounds.X, y, args.Bounds.Width, args.Bounds.Height)
            Next args
        End If
        Return groupPanelRow
    End Function
End Class

Public Class MyGridViewInfoRegistrator
    Inherits GridInfoRegistrator
    Public Overrides Function CreateView(ByVal grid As GridControl) As BaseView
        Return New MyGridView(grid)
    End Function
    Public Overrides Function CreateViewInfo(ByVal view As BaseView) As BaseViewInfo
        Return New MyGridViewInfo(TryCast(view, MyGridView))
    End Function

    Public Overrides ReadOnly Property ViewName() As String
        Get
            Return "MyGridView"
        End Get
    End Property
End Class
