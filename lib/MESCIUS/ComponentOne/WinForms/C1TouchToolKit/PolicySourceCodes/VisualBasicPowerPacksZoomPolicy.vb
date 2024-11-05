Imports Microsoft.VisualBasic.PowerPacks
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports GrapeCity.Win.MultiTouch

Public Class ShapeContainerZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(ShapeContainer)
		End Get
	End Property

	Public Overrides Sub ZoomBounds(control As Control, infos As ZoomBoundsInfo)
		Dim shapeContainer As ShapeContainer = TryCast(control, ShapeContainer)
		For Each shape As Shape In shapeContainer.Shapes
			If TypeOf shape Is SimpleShape Then
				Dim simpleShape As SimpleShape = TryCast(shape, SimpleShape)
				simpleShape.Bounds = infos.Zoom(simpleShape.Bounds)
			ElseIf TypeOf shape Is LineShape Then
				Dim lineShape As LineShape = TryCast(shape, LineShape)
				lineShape.StartPoint = infos.Zoom(lineShape.StartPoint)
				lineShape.EndPoint = infos.Zoom(lineShape.EndPoint)
			End If
		Next
		MyBase.ZoomBounds(control, infos)
	End Sub
End Class
