Imports C1.Win.C1Chart3D
Imports GrapeCity.Win.MultiTouch
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text

Public Class C1Chart3DZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1Chart3D)
		End Get
	End Property

	Public Overrides Sub Terminate(control As System.Windows.Forms.Control)
		_zoomedContourStyles.Clear()
		MyBase.Terminate(control)
	End Sub

	Public Overrides Sub ZoomBounds(control As System.Windows.Forms.Control, infos As ZoomBoundsInfo)
		Dim chart As C1Chart3D = TryCast(control, C1Chart3D)
		ZoomChartGroups(infos, chart.ChartGroups)
		ZoomChartArea(infos, chart.ChartArea)
		ZoomTitle(infos, chart.Header)
		ZoomTitle(infos, chart.Footer)
		ZoomLegend(infos, chart.Legend)
		ZoomChartLabels(infos, chart.ChartLabels)
		MyBase.ZoomBounds(control, infos)
	End Sub

	Public Overrides Sub ZoomFont(control As System.Windows.Forms.Control, infos As ZoomFontInfo)
		MyBase.ZoomFont(control, infos)
		Dim chart As C1Chart3D = TryCast(control, C1Chart3D)
		ZoomChartGroups(infos, chart.ChartGroups)
		ZoomChartArea(infos, chart.ChartArea)
		ZoomTitle(infos, chart.Header)
		ZoomTitle(infos, chart.Footer)
		ZoomLegend(infos, chart.Legend)
		ZoomChartLabels(infos, chart.ChartLabels)

		ZoomStyle(infos, chart.Style)
		ZoomStyle(infos, chart.AreaStyle)
		ZoomStyle(infos, chart.DefaultLabelStyle)
		ZoomStyle(infos, chart.FooterStyle)
		ZoomStyle(infos, chart.HeaderStyle)
		ZoomStyle(infos, chart.LegendStyle)
	End Sub

	Private Sub ZoomChartGroups(infos As ZoomBoundsInfo, groups As Chart3DGroups)
		If groups Is Nothing Then
			Return
		End If
		For Each style As Chart3DStyle In groups.ChartStyles
			ZoomChart3DStyle(infos, style)
		Next
		For Each style As Chart3DContourStyle In groups.ContourStyles.Styles
			ZoomContourStyles(infos, style)
		Next
		For Each group As Chart3DGroup In groups.ChartGroupsCollection
			If group.Contour IsNot Nothing Then
				For Each level As Chart3DContourLevel In group.Contour.Levels
					ZoomContourStyles(infos, level.Style)
				Next
			End If
			If group.ChartData.SetPoint IsNot Nothing Then
				For Each series As Chart3DPointSeries In group.ChartData.SetPoint.SeriesCollection
					ZoomDataSeries(infos, series)
				Next
			End If
		Next
	End Sub

	Private Sub ZoomChartGroups(infos As ZoomFontInfo, groups As Chart3DGroups)
		If groups Is Nothing Then
			Return
		End If
		For Each group As Chart3DGroup In groups.ChartGroupsCollection
			If group.ChartData.SetPoint IsNot Nothing Then
				For Each series As Chart3DPointSeries In group.ChartData.SetPoint.SeriesCollection
					ZoomDataSeries(infos, series)
				Next
			End If
		Next
	End Sub


	Private Sub ZoomChartLabels(infos As ZoomBoundsInfo, labels As Chart3DLabels)
		If labels Is Nothing Then
			Return
		End If
		For Each label As Chart3DLabel In labels.LabelsCollection
			ZoomChartLabel(infos, label)
		Next
	End Sub

	Private Sub ZoomChartLabels(infos As ZoomFontInfo, labels As Chart3DLabels)
		If labels Is Nothing Then
			Return
		End If
		ZoomStyle(infos, labels.DefaultStyle)
		For Each label As Chart3DLabel In labels.LabelsCollection
			ZoomChartLabel(infos, label)
		Next
	End Sub

	Private Sub ZoomChartLabel(infos As ZoomBoundsInfo, label As Chart3DLabel)
		If label Is Nothing Then
			Return
		End If
		If label.AttachMethodData.X > 0 OrElse label.AttachMethodData.Y > 0 Then
			Dim x As Single = label.AttachMethodData.X
			Dim y As Single = label.AttachMethodData.Y
			x = If(x > 0, infos.Zoom(x), x)
			y = If(y > 0, infos.Zoom(y), y)
			label.AttachMethodData.X = x
			label.AttachMethodData.Y = y
		End If
		If label.SizeDefault.Width > 0 OrElse label.SizeDefault.Height > 0 Then
			label.SizeDefault = ZoomSize(infos, label.SizeDefault)
		End If
	End Sub

	Private Sub ZoomChartLabel(infos As ZoomFontInfo, label As Chart3DLabel)
		If label Is Nothing Then
			Return
		End If
		ZoomStyle(infos, label.Style)
	End Sub

	Private Sub ZoomChartArea(infos As ZoomBoundsInfo, area As Chart3DArea)
		If area Is Nothing Then
			Return
		End If
		For Each axis As Chart3DAxis In area.Axes
			ZoomAxis(infos, axis)
		Next
		ZoomChartView(infos, area.View)
		If area.LocationDefault.X > 0 OrElse area.LocationDefault.Y > 0 Then
			area.LocationDefault = ZoomPoint(infos, area.LocationDefault)
		End If
		If area.SizeDefault.Width > 0 OrElse area.SizeDefault.Height > 0 Then
			area.SizeDefault = ZoomSize(infos, area.SizeDefault)
		End If
	End Sub

	Private Sub ZoomChartArea(infos As ZoomFontInfo, area As Chart3DArea)
		If area Is Nothing Then
			Return
		End If
		ZoomStyle(infos, area.Style)
		For Each axis As Chart3DAxis In area.Axes
			ZoomAxis(infos, axis)
		Next
		ZoomChartView(infos, area.View)
	End Sub

	Private Sub ZoomAxis(infos As ZoomBoundsInfo, axis As Chart3DAxis)
		If axis Is Nothing Then
			Return
		End If
		If axis.MajorGrid.Style.Thickness > 0 Then
			axis.MajorGrid.Style.Thickness = infos.Zoom(axis.MajorGrid.Style.Thickness)
		End If
	End Sub

	Private Sub ZoomAxis(infos As ZoomFontInfo, axis As Chart3DAxis)
		If axis Is Nothing Then
			Return
		End If
	End Sub

	Private Sub ZoomChartView(infos As ZoomBoundsInfo, view As Chart3DView)
		If view Is Nothing Then
			Return
		End If
	End Sub

	Private Sub ZoomChartView(infos As ZoomFontInfo, view As Chart3DView)
		If view Is Nothing Then
			Return
		End If
	End Sub

	Private Sub ZoomDataSeries(infos As ZoomBoundsInfo, dataSeries As Chart3DPointSeries)
		If dataSeries Is Nothing Then
			Return
		End If
		ZoomChart3DStyle(infos, dataSeries.Style)
	End Sub

	Private Sub ZoomChart3DStyle(infos As ZoomBoundsInfo, Style As Chart3DStyle)
		If Style.SymbolStyle.Size > 0 Then
			Style.SymbolStyle.Size = infos.Zoom(Style.SymbolStyle.Size)
		End If
		Style.LineStyle.Thickness = infos.Zoom(Style.LineStyle.Thickness)
	End Sub

	Private Sub ZoomDataSeries(infos As ZoomFontInfo, dataSeries As Chart3DPointSeries)
		If dataSeries Is Nothing Then
			Return
		End If
	End Sub

	Private Sub ZoomTitle(infos As ZoomBoundsInfo, title As Title)
		If title Is Nothing Then
			Return
		End If
		If title.LocationDefault.X > 0 OrElse title.LocationDefault.Y > 0 Then
			title.LocationDefault = ZoomPoint(infos, title.LocationDefault)
		End If
		If title.SizeDefault.Width > 0 OrElse title.SizeDefault.Height > 0 Then
			title.SizeDefault = ZoomSize(infos, title.SizeDefault)
		End If
	End Sub

	Private Sub ZoomTitle(infos As ZoomFontInfo, title As Title)
		If title Is Nothing Then
			Return
		End If
		ZoomStyle(infos, title.Style)
	End Sub

	Private Sub ZoomLegend(infos As ZoomBoundsInfo, legend As Chart3DLegend)
		If legend Is Nothing Then
			Return
		End If
		If legend.LocationDefault.X > 0 OrElse legend.LocationDefault.Y > 0 Then
			legend.LocationDefault = ZoomPoint(infos, legend.LocationDefault)
		End If
		If legend.SizeDefault.Width > 0 OrElse legend.SizeDefault.Height > 0 Then
			legend.SizeDefault = ZoomSize(infos, legend.SizeDefault)
		End If
	End Sub

	Private Sub ZoomLegend(infos As ZoomFontInfo, legend As Chart3DLegend)
		If legend Is Nothing Then
			Return
		End If
		ZoomStyle(infos, legend.Style)
	End Sub

	Private Function ZoomPoint(infos As ZoomBoundsInfo, point As Point) As Point
		Dim x As Integer = point.X
		Dim y As Integer = point.Y
		x = If(x > 0, infos.Zoom(x), x)
		y = If(y > 0, infos.Zoom(y), y)
		Return New Point(x, y)
	End Function

	Private Shared Function ZoomSize(infos As ZoomBoundsInfo, size As Size) As Size
		Dim width As Integer = size.Width
		Dim height As Integer = size.Height
		width = If(width > 0, infos.Zoom(width), width)
		height = If(height > 0, infos.Zoom(height), height)
		Return New Size(width, height)
	End Function

	Private _zoomedContourStyles As New List(Of Chart3DContourStyle)()
	Private Sub ZoomContourStyles(infos As ZoomBoundsInfo, style As Chart3DContourStyle)
		If style.LineStyle.Thickness > 0 AndAlso Not _zoomedContourStyles.Contains(style) Then
			style.LineStyle.Thickness = infos.Zoom(style.LineStyle.Thickness)
			_zoomedContourStyles.Add(style)
		End If
	End Sub

	Private Sub ZoomStyle(infos As ZoomFontInfo, style As Style)
		If style Is Nothing OrElse style.Font Is Nothing Then
			Return
		End If
		style.Font = infos.Zoom(style.Font)
	End Sub


End Class
