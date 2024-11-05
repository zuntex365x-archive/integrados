Imports C1.Win.C1Preview
Imports GrapeCity.Win.MultiTouch
Imports System.Collections.Generic
Imports System.Text

Public Class C1PrintPreviewControlZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1PrintPreviewControl)
		End Get
	End Property

	Public Overrides Function CanZoomChildren(control As System.Windows.Forms.Control) As Boolean
		Return False
	End Function

	Public Overrides Sub ZoomFont(control As System.Windows.Forms.Control, infos As ZoomFontInfo)
		control.Font = New System.Drawing.Font(control.Font.FontFamily, infos.CurrentFontSize)
	End Sub

	Public Overrides Sub ZoomBounds(control As System.Windows.Forms.Control, infos As ZoomBoundsInfo)
		Dim previewControl = TryCast(control, C1PrintPreviewControl)

		If previewControl.PreviewPane.ZoomMode = ZoomModeEnum.[Custom] OrElse previewControl.PreviewPane.ZoomMode = ZoomModeEnum.ActualSize Then
			previewControl.PreviewPane.ZoomFactor = infos.Zoom(previewControl.PreviewPane.ZoomFactor)
		End If

		MyBase.ZoomBounds(control, infos)
	End Sub
End Class

Public Class C1PreviewPaneZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1PreviewPane)
		End Get
	End Property

	Public Overrides Sub ZoomBounds(control As System.Windows.Forms.Control, infos As ZoomBoundsInfo)
		Dim previewPane = TryCast(control, C1PreviewPane)

		If previewPane.ZoomMode = ZoomModeEnum.[Custom] OrElse previewPane.ZoomMode = ZoomModeEnum.ActualSize Then
			previewPane.ZoomFactor = infos.Zoom(previewPane.ZoomFactor)
		End If

		MyBase.ZoomBounds(control, infos)
	End Sub
End Class
