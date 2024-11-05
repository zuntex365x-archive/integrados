Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports C1.Win.C1GanttView
Imports GrapeCity.Win.MultiTouch

Public Class C1GanttViewZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1.Win.C1GanttView.C1GanttView)
		End Get
	End Property

	Private _ganttViewGridWidthCache As New Dictionary(Of C1GanttView, Integer)()

	Public Overrides Sub ZoomBounds(control As System.Windows.Forms.Control, infos As ZoomBoundsInfo)
		Dim ganttView As C1GanttView = TryCast(control, C1GanttView)
		SetGanttviewWidth(ganttView, infos.Zoom(GetGanttViewGridWidth(ganttView)))
		ganttView.Timescale.BottomTier.MinWidth = infos.Zoom(ganttView.Timescale.BottomTier.MinWidth)
		ganttView.Timescale.TopTier.MinWidth = infos.Zoom(ganttView.Timescale.TopTier.MinWidth)
		ganttView.Timescale.MiddleTier.MinWidth = infos.Zoom(ganttView.Timescale.MiddleTier.MinWidth)
		For Each column As BaseColumn In ganttView.Columns
			If column.Width > 0 Then
				column.Width = infos.Zoom(column.Width)
			End If
		Next
		MyBase.ZoomBounds(control, infos)
	End Sub

	Private Sub SetGanttviewWidth(ganttView As C1GanttView, value As Integer)
		_ganttViewGridWidthCache(ganttView) = value
		ganttView.GridWidth = value
	End Sub

	Private Function GetGanttViewGridWidth(ganttView As C1GanttView) As Integer
		Dim value As Integer
		If _ganttViewGridWidthCache.TryGetValue(ganttView, value) AndAlso (value = ganttView.GridWidth OrElse (value < 80 AndAlso ganttView.GridWidth = 80)) Then
			Return value
		Else
			_ganttViewGridWidthCache(ganttView) = ganttView.GridWidth
			Return ganttView.GridWidth
		End If
	End Function
End Class
