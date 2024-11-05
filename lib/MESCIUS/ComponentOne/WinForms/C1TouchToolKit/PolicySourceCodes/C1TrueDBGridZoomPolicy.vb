Imports C1.Win.C1TrueDBGrid
Imports C1.Win.C1TrueDBGrid.BaseGrid
Imports GrapeCity.Win.MultiTouch
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Class C1TrueDBGridZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1TrueDBGrid)
		End Get
	End Property

	Public Overrides Sub ZoomBounds(control As Control, infos As ZoomBoundsInfo)
		Dim trueDBGrid As C1TrueDBGrid = TryCast(control, C1TrueDBGrid)
		If trueDBGrid.CellTipsWidth > 0 Then
			trueDBGrid.CellTipsWidth = infos.Zoom(trueDBGrid.CellTipsWidth)
		End If
		If trueDBGrid.DefColWidth > 0 Then
			trueDBGrid.DefColWidth = infos.Zoom(trueDBGrid.DefColWidth)
		End If
		If trueDBGrid.RecordSelectorWidth > 0 Then
			trueDBGrid.RecordSelectorWidth = infos.Zoom(trueDBGrid.RecordSelectorWidth)
		End If
		If trueDBGrid.ViewCaptionWidth > 0 Then
			trueDBGrid.ViewCaptionWidth = infos.Zoom(trueDBGrid.ViewCaptionWidth)
		End If
		If trueDBGrid.ViewColumnWidth > 0 Then
			trueDBGrid.ViewColumnWidth = infos.Zoom(trueDBGrid.ViewColumnWidth)
		End If
		If trueDBGrid.CaptionHeight > 0 Then
			trueDBGrid.CaptionHeight = infos.Zoom(trueDBGrid.CaptionHeight)
		End If
		If trueDBGrid.RowHeight > 0 Then
			trueDBGrid.RowHeight = infos.Zoom(trueDBGrid.RowHeight)
		End If
		If Not trueDBGrid.SplitDividerSize.IsEmpty Then
			trueDBGrid.SplitDividerSize = infos.Zoom(trueDBGrid.SplitDividerSize)
		End If
		For Each split As Split In trueDBGrid.Splits
			If split.CaptionHeight > 0 Then
				split.CaptionHeight = infos.Zoom(split.CaptionHeight)
			End If
			If split.ColumnCaptionHeight > 0 Then
				split.ColumnCaptionHeight = infos.Zoom(split.ColumnCaptionHeight)
			End If
			If split.ColumnFooterHeight > 0 Then
				split.ColumnFooterHeight = infos.Zoom(split.ColumnFooterHeight)
			End If
			If split.Height > 0 Then
				split.Height = infos.Zoom(split.Height)
			End If
			If split.MinHeight > 0 Then
				split.MinHeight = infos.Zoom(split.MinHeight)
			End If
			If split.MinWidth > 0 Then
				split.MinWidth = infos.Zoom(split.MinWidth)
			End If
			If split.SplitSize > 0 Then
				split.SplitSize = infos.Zoom(split.SplitSize)
			End If
			For Each column As C1DisplayColumn In split.DisplayColumns
				If column.Width > 0 Then
					column.Width = infos.Zoom(column.Width)
				End If
				If column.Height > 0 Then
					column.Height = infos.Zoom(column.Height)
				End If
			Next
			For Each row As ViewRow In split.Rows
				If row.Width > 0 Then
					row.Width = infos.Zoom(row.Width)
				End If
				If row.Height > 0 Then
					row.Height = infos.Zoom(row.Height)
				End If
			Next
		Next
		For Each column As C1DataColumn In trueDBGrid.Columns
			If column.DataWidth > 0 Then
				column.DataWidth = infos.Zoom(column.DataWidth)
			End If
		Next
		MyBase.ZoomBounds(control, infos)
	End Sub

	Public Overrides Sub ZoomFont(control As Control, infos As ZoomFontInfo)
		Dim trueDBGrid As C1TrueDBGrid = TryCast(control, C1TrueDBGrid)

		Dim baseFont As Font = trueDBGrid.Font
		For Each style As Style In trueDBGrid.Styles
			ZoomStyle(infos, baseFont, style)
		Next

		For Each split As Split In trueDBGrid.Splits
			baseFont = trueDBGrid.Font
			If split.Style IsNot Nothing AndAlso split.Style.Font IsNot Nothing AndAlso Not Object.ReferenceEquals(split.Style.Font, baseFont) Then
				ZoomStyle(infos, baseFont, split.Style)
				baseFont = split.Style.Font
			End If

			For Each column As C1DisplayColumn In split.DisplayColumns
				ZoomStyle(infos, baseFont, column.Style)
			Next
		Next

		baseFont = trueDBGrid.Font
		MyBase.ZoomFont(control, infos)
	End Sub

	Private Sub ZoomStyle(infos As ZoomFontInfo, baseFont As Font, style As Style)
		If style Is Nothing OrElse style.Font Is Nothing Then
			Return
		End If
		style.Font = infos.Zoom(style.Font)
	End Sub

	Private _firstRowCache As New Dictionary(Of Control, Integer)()

	Public Overrides Sub Initialize(control As Control)
		Dim trueDBGrid As C1TrueDBGrid = TryCast(control, C1TrueDBGrid)
		If trueDBGrid.EditActive Then
			trueDBGrid.EditActive = False
		End If
		' TrueDBGrid最初の行を保持して、ズーム後に復元することで、ズームした場合にも
' 最初の行が変更されないようにします。
		_firstRowCache.Add(trueDBGrid, trueDBGrid.FirstRow)

		MyBase.Initialize(control)
	End Sub

	Public Overrides Sub Terminate(control As Control)
		Dim trueDBGrid As C1TrueDBGrid = TryCast(control, C1TrueDBGrid)

		trueDBGrid.FirstRow = _firstRowCache(trueDBGrid)
		_firstRowCache.Remove(trueDBGrid)

		MyBase.Terminate(control)
	End Sub

	Public Overrides Function GetChildren(control As Control) As IEnumerable(Of Control)
		Dim children As New List(Of Control)()
		For Each child As Control In control.Controls
			If TypeOf child Is ScrollBar Then
				Continue For
			End If
			children.Add(child)
		Next
		Return children
	End Function
End Class

Public Class C1TDBDropDownZoomPolicy
	Inherits NoZoomFontZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1TrueDBDropdown)
		End Get
	End Property

	Public Overrides Function CanZoom(control As Control) As Boolean
		Return False
	End Function

	Public Overrides Function CanZoomChildren(control As Control) As Boolean
		Return False
	End Function
End Class

