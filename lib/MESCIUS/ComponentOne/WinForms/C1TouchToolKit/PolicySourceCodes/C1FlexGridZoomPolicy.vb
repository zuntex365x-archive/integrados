Imports C1.Win.C1FlexGrid
Imports GrapeCity.Win.MultiTouch
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Class C1FlexGridZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1FlexGrid)
		End Get
	End Property

	Private _flexGridInfoCache As New Dictionary(Of Control, FlexGridInitInfo)()
	Private _zoomedCols As New Dictionary(Of RowColCollection, Object)()

	Public Overrides Sub Initialize(control As System.Windows.Forms.Control)
		Dim flexGrid As C1FlexGrid = TryCast(control, C1FlexGrid)
		_flexGridInfoCache.Add(flexGrid, New FlexGridInitInfo(flexGrid.Rows.DefaultSize, flexGrid.Cols.DefaultSize, flexGrid.TopRow, flexGrid.LeftCol))

		flexGrid.Styles(CellStyleEnum.FilterEditor).Font = TryCast(flexGrid.Styles(CellStyleEnum.FilterEditor).Font.Clone(), Font)

		MyBase.Initialize(control)
	End Sub

	Public Overrides Sub Terminate(control As Control)
		Dim flexGrid As C1FlexGrid = TryCast(control, C1FlexGrid)
		flexGrid.TopRow = _flexGridInfoCache(control).TopRow
		flexGrid.LeftCol = _flexGridInfoCache(control).LeftCol

		_flexGridInfoCache.Remove(control)
		_zoomedCols.Clear()
		MyBase.Terminate(control)
	End Sub

	Public Overrides Sub ZoomBounds(control As System.Windows.Forms.Control, infos As ZoomBoundsInfo)
		Dim flexGrid As C1FlexGrid = TryCast(control, C1FlexGrid)
		flexGrid.Cols.DefaultSize = infos.Zoom(_flexGridInfoCache(control).DefaultColSize)
		flexGrid.Rows.DefaultSize = infos.Zoom(_flexGridInfoCache(control).DefaultRowSize)
		If flexGrid.Rows.MinSize > 0 Then
			flexGrid.Rows.MinSize = infos.Zoom(flexGrid.Rows.MinSize)
		End If
		If flexGrid.Cols.MinSize > 0 Then
			flexGrid.Cols.MinSize = infos.Zoom(flexGrid.Cols.MinSize)
		End If

		If Not _zoomedCols.ContainsKey(flexGrid.Cols) Then
			' 列の設定は、複数のFlexGridで共有される場合があります。
			_zoomedCols.Add(flexGrid.Cols, Nothing)
			For Each column As Column In flexGrid.Cols
				If column.Width > 0 Then
					column.Width = infos.Zoom(column.Width)
				End If
			Next
		End If

		If Not _zoomedCols.ContainsKey(flexGrid.Rows) Then
			' 行の設定は、複数のFlexGridで共有される場合があります。
			_zoomedCols.Add(flexGrid.Rows, Nothing)
			For Each row As Row In flexGrid.Rows
				If row.Height > 0 Then
					row.Height = infos.Zoom(row.Height)
				End If
			Next
		End If

		MyBase.ZoomBounds(control, infos)
	End Sub

	Private Sub ZoomStyle(infos As ZoomFontInfo, style As CellStyle)
		If style Is Nothing OrElse style.Font Is Nothing Then
			Return
		End If
		Dim newFont As Font = infos.Zoom(style.Font)
		If Not Object.ReferenceEquals(newFont, style.Font) Then
			style.Font = newFont
		End If
	End Sub

	Private Structure FlexGridInitInfo
		Public Sub New(defaultRowSize__1 As Integer, defaultColSize__2 As Integer, topRow__3 As Integer, leftCol__4 As Integer)
			DefaultRowSize = defaultRowSize__1
			DefaultColSize = defaultColSize__2
			TopRow = topRow__3
			LeftCol = leftCol__4
		End Sub
		Public DefaultRowSize As Integer
		Public DefaultColSize As Integer
		Public TopRow As Integer
		Public LeftCol As Integer
	End Structure
End Class
