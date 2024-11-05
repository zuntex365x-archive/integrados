Imports C1.Framework
Imports C1.Win.C1Schedule
Imports GrapeCity.Win.MultiTouch
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Class C1CalendarZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1Calendar)
		End Get
	End Property

	Public Overrides Sub ZoomBounds(control As Control, infos As ZoomBoundsInfo)
		Dim size = control.MaximumSize
		' Sizeプロパティの値が変更できるようにするため、MaxSizeプロパティの値を変更します。
		control.MaximumSize = New Size(control.Width, control.Height)

		MyBase.ZoomBounds(control, infos)

		control.MaximumSize = infos.Zoom(size)

		control.Refresh()
	End Sub
End Class

Public Class C1ScheduleZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1Schedule)
		End Get
	End Property

	Public Overrides Sub ZoomBounds(control As Control, infos As ZoomBoundsInfo)
		MyBase.ZoomBounds(control, infos)
		Dim schedule As C1Schedule = TryCast(control, C1Schedule)
		If schedule.AppointmentHeight > 0 Then
			schedule.AppointmentHeight = infos.Zoom(schedule.AppointmentHeight)
		End If
		control.Refresh()
	End Sub
End Class
