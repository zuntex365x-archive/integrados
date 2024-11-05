Imports C1.Framework
Imports C1.Win.BarCode
Imports GrapeCity.Win.MultiTouch
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Class C1BarcodeZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1BarCode)
		End Get
	End Property

	Public Overrides Sub ZoomBounds(control As Control, infos As ZoomBoundsInfo)
		Dim barcode As C1BarCode = TryCast(control, C1BarCode)
		barcode.ModuleSize = infos.Zoom(barcode.ModuleSize)
		barcode.BarHeight = infos.Zoom(barcode.BarHeight)
		MyBase.ZoomBounds(control, infos)
	End Sub
End Class
