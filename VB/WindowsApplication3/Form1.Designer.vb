Imports Microsoft.VisualBasic
Imports System
Partial Public Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.myGridControl1 = New MyGridControl()
        Me.myGridView1 = New MyGridView()
        Me.colColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'myGridControl1
        '
        Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.myGridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
        Me.myGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.myGridControl1.LookAndFeel.SkinName = "Blue"
        Me.myGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.myGridControl1.MainView = Me.myGridView1
        Me.myGridControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.myGridControl1.Name = "myGridControl1"
        Me.myGridControl1.Size = New System.Drawing.Size(437, 361)
        Me.myGridControl1.TabIndex = 0
        Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.myGridView1})
        '
        'myGridView1
        '
        Me.myGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colColumn1, Me.colColumn2, Me.colColumn3, Me.colColumn4, Me.colColumn5, Me.colColumn6, Me.colColumn7, Me.colColumn8, Me.colColumn9, Me.colColumn10})
        Me.myGridView1.GridControl = Me.myGridControl1
        Me.myGridView1.GroupCount = 4
        Me.myGridView1.Name = "myGridView1"
        Me.myGridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colColumn3, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colColumn4, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colColumn5, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colColumn6, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colColumn1
        '
        Me.colColumn1.FieldName = "Column1"
        Me.colColumn1.Name = "colColumn1"
        Me.colColumn1.Visible = True
        Me.colColumn1.VisibleIndex = 0
        Me.colColumn1.Width = 104
        '
        'colColumn2
        '
        Me.colColumn2.FieldName = "Column2"
        Me.colColumn2.Name = "colColumn2"
        Me.colColumn2.Visible = True
        Me.colColumn2.VisibleIndex = 2
        '
        'colColumn3
        '
        Me.colColumn3.FieldName = "Column3"
        Me.colColumn3.Name = "colColumn3"
        '
        'colColumn4
        '
        Me.colColumn4.FieldName = "Column4"
        Me.colColumn4.Name = "colColumn4"
        Me.colColumn4.Visible = True
        Me.colColumn4.VisibleIndex = 1
        '
        'colColumn5
        '
        Me.colColumn5.FieldName = "Column5"
        Me.colColumn5.Name = "colColumn5"
        Me.colColumn5.Visible = True
        Me.colColumn5.VisibleIndex = 2
        '
        'colColumn6
        '
        Me.colColumn6.FieldName = "Column6"
        Me.colColumn6.Name = "colColumn6"
        Me.colColumn6.Visible = True
        Me.colColumn6.VisibleIndex = 3
        '
        'colColumn7
        '
        Me.colColumn7.FieldName = "Column7"
        Me.colColumn7.Name = "colColumn7"
        Me.colColumn7.Visible = True
        Me.colColumn7.VisibleIndex = 1
        '
        'colColumn8
        '
        Me.colColumn8.FieldName = "Column8"
        Me.colColumn8.Name = "colColumn8"
        Me.colColumn8.Visible = True
        Me.colColumn8.VisibleIndex = 3
        '
        'colColumn9
        '
        Me.colColumn9.FieldName = "Column9"
        Me.colColumn9.Name = "colColumn9"
        Me.colColumn9.Visible = True
        Me.colColumn9.VisibleIndex = 4
        '
        'colColumn10
        '
        Me.colColumn10.FieldName = "Column10"
        Me.colColumn10.Name = "colColumn10"
        Me.colColumn10.Visible = True
        Me.colColumn10.VisibleIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 361)
        Me.Controls.Add(Me.myGridControl1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private myGridControl1 As MyGridControl
    Private myGridView1 As MyGridView
    Private colColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Private colColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Private colColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Private colColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Private colColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Private colColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Private colColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Private colColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Private colColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Private colColumn10 As DevExpress.XtraGrid.Columns.GridColumn
End Class
