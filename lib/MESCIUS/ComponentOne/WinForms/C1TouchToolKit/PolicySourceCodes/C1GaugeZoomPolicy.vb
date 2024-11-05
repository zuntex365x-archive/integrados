Imports System.Collections.Generic
Imports System.Text
Imports C1.Win.C1Gauge
Imports GrapeCity.Win.MultiTouch

Public Class C1GaugeZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1Gauge)
		End Get
	End Property

	#Region "Zoom Bounds"

	Public Overrides Sub ZoomBounds(control As System.Windows.Forms.Control, infos As ZoomBoundsInfo)
		Dim gauge As C1Gauge = TryCast(control, C1Gauge)
		ZoomGaugeBaseViewport(infos, gauge.Viewport)
		ZoomGauges(infos, gauge.Gauges)
		ZoomFaceShapes(infos, gauge.FaceShapes)

		MyBase.ZoomBounds(control, infos)
	End Sub


	Private Shared Sub ZoomFaceShapes(infos As ZoomBoundsInfo, shapes As ShapeCollection)
		If shapes Is Nothing Then
			Return
		End If
		For Each shape As C1GaugeBaseShape In shapes
			ZoomGaugeBaseViewport(infos, shape.Viewport)
		Next
	End Sub

	Private Shared Sub ZoomGauges(infos As ZoomBoundsInfo, gauges As GaugeCollection)
		If gauges Is Nothing Then
			Return
		End If
		For Each subGauge As C1GaugeBase In gauges
			ZoomGaugeBaseViewport(infos, subGauge.Viewport)
			ZoomFaceShapes(infos, subGauge.FaceShapes)
		Next
	End Sub

	Private Shared Sub ZoomGaugeBaseViewport(infos As ZoomBoundsInfo, viewport As C1GaugeViewport)
		viewport.X = infos.Zoom(viewport.X)
		viewport.Y = infos.Zoom(viewport.Y)
		viewport.Width = infos.Zoom(viewport.Width)
		viewport.Height = infos.Zoom(viewport.Height)
		viewport.MarginX = infos.Zoom(viewport.MarginX)
		viewport.MarginY = infos.Zoom(viewport.MarginY)
	End Sub

	#End Region

	#Region "Zoom Font"

	Public Overrides Sub ZoomFont(control As System.Windows.Forms.Control, infos As ZoomFontInfo)
		Dim gauge As C1Gauge = TryCast(control, C1Gauge)
		ZoomGaugesFont(infos, gauge.Gauges)
		ZoomFaceShapesFont(infos, gauge.FaceShapes)

		MyBase.ZoomFont(control, infos)
	End Sub

	Private Sub ZoomFaceShapesFont(infos As ZoomFontInfo, shapes As ShapeCollection)
		If shapes Is Nothing Then
			Return
		End If
		For Each shape As C1GaugeBaseShape In shapes
			ZoomGaugeCaptionFont(infos, shape)
		Next
	End Sub

	Private Sub ZoomGaugesFont(infos As ZoomFontInfo, gauges As GaugeCollection)
		For Each subGauge As C1GaugeBase In gauges
			ZoomDecoratorsFont(infos, subGauge)
			ZoomFaceShapesFont(infos, subGauge.FaceShapes)
		Next
	End Sub

	Private Shared Sub ZoomDecoratorsFont(infos As ZoomFontInfo, subGauge As C1GaugeBase)
		For Each decorator As C1GaugeDecorator In subGauge.Decorators
			ZoomDecoratorLableFont(infos, decorator)
		Next
	End Sub

	Private Shared Sub ZoomDecoratorLableFont(infos As ZoomFontInfo, decorator As C1GaugeDecorator)
		Dim lable As C1GaugeSingleLabel = TryCast(decorator, C1GaugeSingleLabel)
		If lable IsNot Nothing Then
			lable.Font = infos.Zoom(lable.Font)
		End If
	End Sub

	Private Shared Sub ZoomGaugeCaptionFont(infos As ZoomFontInfo, shape As C1GaugeBaseShape)
		Dim caption As C1GaugeCaption = TryCast(shape, C1GaugeCaption)
		If caption Is Nothing Then
			Return
		End If
		caption.Font = infos.Zoom(caption.Font)
	End Sub

	#End Region
End Class
