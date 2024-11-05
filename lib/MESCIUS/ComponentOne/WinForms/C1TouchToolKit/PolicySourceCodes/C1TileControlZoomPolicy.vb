Imports System.Collections.Generic
Imports System.Windows.Forms
Imports C1.Win.C1Tile
Imports GrapeCity.Win.MultiTouch

Public Class C1TileControlZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1TileControl)
		End Get
	End Property

	Public Overrides Sub ZoomBounds(control As System.Windows.Forms.Control, infos As ZoomBoundsInfo)
		Dim tileControl As C1TileControl = TryCast(control, C1TileControl)
		tileControl.CellWidth = infos.Zoom(tileControl.CellWidth)
		tileControl.CellHeight = infos.Zoom(tileControl.CellHeight)
		tileControl.CellSpacing = infos.Zoom(tileControl.CellSpacing)

		tileControl.Padding = ZoomPadding(tileControl.Padding, infos)
		tileControl.GroupPadding = ZoomPadding(tileControl.GroupPadding, infos)

		For Each template As Template In tileControl.Templates
			Dim elements As ElementCollection = template.Elements
			For Each templateElement As BaseElement In GetTemplateElements(elements)
				templateElement.FixedWidth = infos.Zoom(templateElement.FixedWidth)
				templateElement.FixedHeight = infos.Zoom(templateElement.FixedHeight)
				templateElement.Margin = New Padding(infos.Zoom(templateElement.Margin.Left), infos.Zoom(templateElement.Margin.Top), infos.Zoom(templateElement.Margin.Right), infos.Zoom(templateElement.Margin.Bottom))
			Next
		Next
		MyBase.ZoomBounds(control, infos)
	End Sub

	Private Function ZoomPadding(padding As Padding, infos As ZoomBoundsInfo) As Padding
		If padding.All <> -1 Then
			Return New Padding(infos.Zoom(padding.All))
		Else
			Return New Padding(infos.Zoom(padding.Left), infos.Zoom(padding.Top), infos.Zoom(padding.Right), infos.Zoom(padding.Bottom))
		End If
	End Function

	Public Function GetTemplateElements(elements As ElementCollection) As IEnumerable(Of BaseElement)
		Dim list As New List(Of BaseElement)()
		For Each element As BaseElement In elements
			list.Add(element)
			Dim panelElement As PanelElement = TryCast(element, PanelElement)
			If panelElement IsNot Nothing Then
				list.AddRange(GetTemplateElements(panelElement.Children))
			End If
		Next
		Return list
	End Function

	Public Overrides Sub ZoomFont(control As Control, infos As ZoomFontInfo)
		Dim tileControl As C1TileControl = TryCast(control, C1TileControl)
		For Each template As Template In tileControl.Templates
			Dim elements As ElementCollection = template.Elements
			For Each templateElement As BaseElement In GetTemplateElements(elements)
				Dim textElement As TextElement = TryCast(templateElement, TextElement)
				If textElement IsNot Nothing Then
					textElement.FontSize = textElement.FontSize * infos.DeltaFactor
				End If

			Next
		Next
		tileControl.TextSize = tileControl.TextSize * infos.DeltaFactor
		tileControl.GroupTextSize = tileControl.GroupTextSize * infos.DeltaFactor
		MyBase.ZoomFont(control, infos)
	End Sub
End Class
