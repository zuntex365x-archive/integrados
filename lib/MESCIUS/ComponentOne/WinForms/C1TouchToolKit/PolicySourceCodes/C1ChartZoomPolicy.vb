Imports C1.Win.C1Chart
Imports GrapeCity.Win.MultiTouch
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text

Public Class C1ChartZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1Chart)
		End Get
	End Property

	Public Overrides Sub Terminate(control As System.Windows.Forms.Control)
		_zoomedLineStyles.Clear()
		_zoomedSymbolStyle.Clear()
		MyBase.Terminate(control)
	End Sub

	Public Overrides Sub ZoomBounds(control As System.Windows.Forms.Control, infos As ZoomBoundsInfo)
		Dim chart As C1Chart = TryCast(control, C1Chart)
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
		Dim chart As C1Chart = TryCast(control, C1Chart)
		ZoomChartGroups(infos, chart.ChartGroups)
		ZoomChartArea(infos, chart.ChartArea)
		ZoomTitle(infos, chart.Header)
		ZoomTitle(infos, chart.Footer)
		ZoomLegend(infos, chart.Legend)
		ZoomChartLabels(infos, chart.ChartLabels)
		ZoomStyle(infos, chart.Style)
	End Sub

	Private Sub ZoomChartGroups(infos As ZoomBoundsInfo, groups As ChartGroups)
		If groups Is Nothing Then
			Return
		End If
		For Each group As ChartGroup In groups.ChartGroupsCollection
			For Each functionBase As FunctionBase In group.ChartData.FunctionsList
				ZoomLineStyle(infos, functionBase.LineStyle)
			Next
			For Each series As ChartDataSeries In group.ChartData.SeriesList
				ZoomDataSeries(infos, series)
			Next
		Next
	End Sub

	Private Sub ZoomChartGroups(infos As ZoomFontInfo, groups As ChartGroups)
		If groups Is Nothing Then
			Return
		End If
		For Each group As ChartGroup In groups.ChartGroupsCollection
			For Each series As ChartDataSeries In group.ChartData.SeriesList
				ZoomDataSeries(infos, series)
			Next
		Next
	End Sub


	Private Sub ZoomChartLabels(infos As ZoomBoundsInfo, labels As ChartLabels)
		If labels Is Nothing Then
			Return
		End If
		For Each label As Label In labels.LabelsCollection
			ZoomChartLabel(infos, label)
		Next
	End Sub

	Private Sub ZoomChartLabels(infos As ZoomFontInfo, labels As ChartLabels)
		If labels Is Nothing Then
			Return
		End If
		ZoomStyle(infos, labels.DefaultLabelStyle)
		For Each label As Label In labels.LabelsCollection
			ZoomChartLabel(infos, label)
		Next
	End Sub

	Private Sub ZoomChartLabel(infos As ZoomBoundsInfo, label As Label)
		If label Is Nothing Then
			Return
		End If
		If label.AttachMethodData.X > 0 OrElse label.AttachMethodData.Y > 0 Then
			Dim x As Double = label.AttachMethodData.X
			Dim y As Double = label.AttachMethodData.Y
			x = If(x > 0, infos.Zoom(x), x)
			y = If(y > 0, infos.Zoom(y), y)
			label.AttachMethodData.X = x
			label.AttachMethodData.Y = y
		End If
		If label.SizeDefault.Width > 0 OrElse label.SizeDefault.Height > 0 Then
			label.SizeDefault = ZoomSize(infos, label.SizeDefault)
		End If
	End Sub

	Private Sub ZoomChartLabel(infos As ZoomFontInfo, label As Label)
		If label Is Nothing Then
			Return
		End If
		ZoomStyle(infos, label.Style)
	End Sub

	Private Sub ZoomChartArea(infos As ZoomBoundsInfo, area As Area)
		If area Is Nothing Then
			Return
		End If
		For Each axis As Axis In area.Axes
			ZoomAxis(infos, axis)
		Next
		ZoomPlotArea(infos, area.PlotArea)
		If area.LocationDefault.X > 0 OrElse area.LocationDefault.Y > 0 Then
			area.LocationDefault = ZoomPoint(infos, area.LocationDefault)
		End If
		If area.SizeDefault.Width > 0 OrElse area.SizeDefault.Height > 0 Then
			area.SizeDefault = ZoomSize(infos, area.SizeDefault)
		End If
	End Sub

	Private Sub ZoomChartArea(infos As ZoomFontInfo, area As Area)
		If area Is Nothing Then
			Return
		End If
		ZoomStyle(infos, area.Style)
		For Each axis As Axis In area.Axes
			ZoomAxis(infos, axis)
		Next
		ZoomPlotArea(infos, area.PlotArea)
	End Sub

	Private Sub ZoomAxis(infos As ZoomBoundsInfo, axis As Axis)
		If axis Is Nothing Then
			Return
		End If
		axis.Thickness = infos.Zoom(axis.Thickness)
		For Each valueLabel As ValueLabel In axis.ValueLabels
			If valueLabel.MarkerSize > 0 Then
				valueLabel.MarkerSize = infos.Zoom(valueLabel.MarkerSize)
			End If
		Next
	End Sub

	Private Sub ZoomAxis(infos As ZoomFontInfo, axis As Axis)
		If axis Is Nothing Then
			Return
		End If

		If axis.ShouldSerializeFont() Then
			axis.Font = infos.Zoom(axis.Font)
		End If
	End Sub

	Private Sub ZoomPlotArea(infos As ZoomBoundsInfo, plotArea As PlotArea)
		If plotArea Is Nothing Then
			Return
		End If
		If plotArea.LocationDefault.X > 0 OrElse plotArea.LocationDefault.Y > 0 Then
			plotArea.LocationDefault = ZoomPoint(infos, plotArea.LocationDefault)
		End If
		If plotArea.SizeDefault.Width > 0 OrElse plotArea.SizeDefault.Height > 0 Then
			plotArea.SizeDefault = ZoomSize(infos, plotArea.SizeDefault)
		End If
		For Each alarmZone As AlarmZone In plotArea.AlarmZones
			If alarmZone.MinHeight > 0 Then
				alarmZone.MinHeight = infos.Zoom(alarmZone.MinHeight)
			End If
			If alarmZone.MinWidth > 0 Then
				alarmZone.MinWidth = infos.Zoom(alarmZone.MinWidth)
			End If
		Next
	End Sub

	Private Sub ZoomPlotArea(infos As ZoomFontInfo, plotArea As PlotArea)
	End Sub

	Private Sub ZoomDataSeries(infos As ZoomBoundsInfo, dataSeries As ChartDataSeries)
		If dataSeries Is Nothing Then
			Return
		End If
		ZoomSymbolStyle(infos, dataSeries.SymbolStyle)
		ZoomLineStyle(infos, dataSeries.LineStyle)
	End Sub

	Private Sub ZoomDataSeries(infos As ZoomFontInfo, dataSeries As ChartDataSeries)
		If dataSeries Is Nothing Then
			Return
		End If
		If dataSeries.DataLabel IsNot Nothing Then
			ZoomStyle(infos, dataSeries.DataLabel.Style)
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

	Private Sub ZoomLegend(infos As ZoomBoundsInfo, legend As Legend)
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

	Private Sub ZoomLegend(infos As ZoomFontInfo, legend As Legend)
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

	Private _zoomedLineStyles As New List(Of ChartLineStyle)()
	Private Sub ZoomLineStyle(infos As ZoomBoundsInfo, lineStyle As ChartLineStyle)
		If lineStyle.Thickness > 0 AndAlso Not _zoomedLineStyles.Contains(lineStyle) Then
			lineStyle.Thickness = infos.Zoom(lineStyle.Thickness)
			_zoomedLineStyles.Add(lineStyle)
		End If
	End Sub


	Private _zoomedSymbolStyle As New List(Of ChartSymbolStyle)()
	Private Sub ZoomSymbolStyle(infos As ZoomBoundsInfo, symbolStyle As ChartSymbolStyle)
		If symbolStyle.Size > 0 AndAlso Not _zoomedSymbolStyle.Contains(symbolStyle) Then
			symbolStyle.Size = infos.Zoom(symbolStyle.Size)
			_zoomedSymbolStyle.Add(symbolStyle)
		End If
	End Sub

	Private Sub ZoomStyle(infos As ZoomFontInfo, style As Style)
		If style Is Nothing OrElse style.Font Is Nothing Then
			Return
		End If
		style.Font = infos.Zoom(style.Font)
	End Sub


End Class
