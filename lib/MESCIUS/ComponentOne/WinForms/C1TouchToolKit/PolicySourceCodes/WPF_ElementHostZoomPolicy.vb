Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms.Integration
Imports System.Windows.Media
Imports GrapeCity.Win.MultiTouch
Imports System.Windows

Public Class WPF_ElementHostZoomPolicy
	Inherits NoZoomFontZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(ElementHost)
		End Get
	End Property

	Public Overrides Function CanZoomChildren(control As System.Windows.Forms.Control) As Boolean
		Return False
	End Function

	Public Overrides Sub ZoomBounds(control As System.Windows.Forms.Control, infos As ZoomBoundsInfo)
		Dim host As ElementHost = TryCast(control, ElementHost)
		If TypeOf host.Child Is FrameworkElement Then
			TryCast(host.Child, FrameworkElement).LayoutTransform = New ScaleTransform(infos.TargetFactor, infos.TargetFactor)
		End If
		MyBase.ZoomBounds(control, infos)
	End Sub
End Class
