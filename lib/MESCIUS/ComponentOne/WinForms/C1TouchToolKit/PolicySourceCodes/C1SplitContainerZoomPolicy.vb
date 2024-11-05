
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.C1SplitContainer
Imports GrapeCity.Win.MultiTouch

Public Class C1SplitContainerZoomPolicy
	Inherits ZoomPolicy
	Private _originalValueCache As New Dictionary(Of C1SplitContainer, CacheValue)()

	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1SplitContainer)
		End Get
	End Property

	Public Overrides Sub Initialize(control As Control)
		control.SuspendLayout()
		MyBase.Initialize(control)
	End Sub

	Public Overrides Sub Terminate(control As Control)
		control.ResumeLayout(True)
		MyBase.Terminate(control)
	End Sub

	Public Overrides Sub ZoomBounds(control As System.Windows.Forms.Control, infos As ZoomBoundsInfo)
		Dim splitContainer As C1SplitContainer = TryCast(control, C1SplitContainer)
		' C1SplitContainerの一部のプロパティで一定以上に大きい値を設定することはできません。例えば、HeaderHeightプロパティの設定可能な最大値は100です。
' HeaderHeightプロパティが30の場合、4倍にズームすると120になりますが、最大値の制限によって実際には100が設定されます。
' その後、1/4のサイズにズームを戻すと、HeaderHeightプロパティは最初の30ではなく25に変更されます。
		If infos.CurrentFactor = 1F Then
			Dim cacheValue As New CacheValue()
			cacheValue.HeaderHeight = splitContainer.HeaderHeight
			cacheValue.SplitterWidth = splitContainer.SplitterWidth
			cacheValue.FixedLineWidth = splitContainer.FixedLineWidth
			cacheValue.HeaderTextOffset = splitContainer.HeaderTextOffset
			cacheValue.HeaderLineWidth = splitContainer.HeaderLineWidth

			_originalValueCache(splitContainer) = cacheValue
		End If

		If _originalValueCache.ContainsKey(splitContainer) Then
			Dim cacheValue As CacheValue = _originalValueCache(splitContainer)
			splitContainer.HeaderHeight = CInt(Math.Round(cacheValue.HeaderHeight * infos.TargetFactor))
			splitContainer.SplitterWidth = CInt(Math.Round(cacheValue.SplitterWidth * infos.TargetFactor))
			splitContainer.FixedLineWidth = CInt(Math.Round(cacheValue.FixedLineWidth * infos.TargetFactor))
			splitContainer.HeaderTextOffset = CInt(Math.Round(cacheValue.HeaderTextOffset * infos.TargetFactor))
			splitContainer.HeaderLineWidth = CInt(Math.Round(cacheValue.HeaderLineWidth * infos.TargetFactor))
		Else
			splitContainer.HeaderHeight = infos.Zoom(splitContainer.HeaderHeight)
			splitContainer.SplitterWidth = infos.Zoom(splitContainer.SplitterWidth)
			splitContainer.FixedLineWidth = infos.Zoom(splitContainer.FixedLineWidth)
			splitContainer.HeaderTextOffset = infos.Zoom(splitContainer.HeaderTextOffset)
			splitContainer.HeaderLineWidth = infos.Zoom(splitContainer.HeaderLineWidth)
		End If


		MyBase.ZoomBounds(control, infos)
	End Sub

	Private Class CacheValue
		Public Property HeaderHeight() As Integer
			Get
				Return m_HeaderHeight
			End Get
			Set
				m_HeaderHeight = Value
			End Set
		End Property
		Private m_HeaderHeight As Integer
		Public Property SplitterWidth() As Integer
			Get
				Return m_SplitterWidth
			End Get
			Set
				m_SplitterWidth = Value
			End Set
		End Property
		Private m_SplitterWidth As Integer
		Public Property FixedLineWidth() As Integer
			Get
				Return m_FixedLineWidth
			End Get
			Set
				m_FixedLineWidth = Value
			End Set
		End Property
		Private m_FixedLineWidth As Integer
		Public Property HeaderTextOffset() As Integer
			Get
				Return m_HeaderTextOffset
			End Get
			Set
				m_HeaderTextOffset = Value
			End Set
		End Property
		Private m_HeaderTextOffset As Integer
		Public Property HeaderLineWidth() As Integer
			Get
				Return m_HeaderLineWidth
			End Get
			Set
				m_HeaderLineWidth = Value
			End Set
		End Property
		Private m_HeaderLineWidth As Integer
	End Class
End Class

Public Class C1SplitPanelZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1SplitterPanel)
		End Get
	End Property
	Private Class CacheValue
		Public Property SizeOffSet() As Size
			Get
				Return m_SizeOffSet
			End Get
			Set
				m_SizeOffSet = Value
			End Set
		End Property
		Private m_SizeOffSet As Size
		Public Property Visible() As Boolean
			Get
				Return m_Visible
			End Get
			Set
				m_Visible = Value
			End Set
		End Property
		Private m_Visible As Boolean
	End Class
	Private ReadOnly sizeOffsetCache As New Dictionary(Of C1SplitterPanel, CacheValue)()
	Public Overrides Sub Initialize(control As Control)
		MyBase.Initialize(control)
		Dim splitPanel As C1SplitterPanel = DirectCast(control, C1SplitterPanel)
		Dim cache = New CacheValue()
		cache.SizeOffSet = New Size(splitPanel.Width - splitPanel.Bounds.Width, splitPanel.Height - splitPanel.Bounds.Height - (If(splitPanel.SplitContainer IsNot Nothing, (splitPanel.SplitContainer).HeaderHeight, 0)))
		cache.Visible = splitPanel.Visible
		sizeOffsetCache(splitPanel) = cache
		splitPanel.Visible = True
	End Sub

	Public Overrides Sub Terminate(control As Control)
		Dim splitPanel As C1SplitterPanel = DirectCast(control, C1SplitterPanel)
		splitPanel.Visible = sizeOffsetCache(splitPanel).Visible
		MyBase.Terminate(control)
		sizeOffsetCache.Remove(splitPanel)
	End Sub

	Public Overrides Sub ZoomBounds(control As System.Windows.Forms.Control, infos As ZoomBoundsInfo)

		Dim splitPanel As C1SplitterPanel = DirectCast(control, C1SplitterPanel)
		splitPanel.Width = infos.Zoom(infos.CurrentBounds).Width + sizeOffsetCache(splitPanel).SizeOffSet.Width
		splitPanel.Height = infos.Zoom(infos.CurrentBounds).Height + sizeOffsetCache(splitPanel).SizeOffSet.Height + (If(splitPanel.SplitContainer IsNot Nothing, (splitPanel.SplitContainer).HeaderHeight, 0))

	End Sub

	Public Overrides Sub ZoomFont(control As Control, infos As ZoomFontInfo)
		' block base logic
	End Sub

	Public Overrides Function GetChildren(control As Control) As IEnumerable(Of Control)
		Dim controls As New List(Of Control)()
		For Each child As Control In control.Controls
			If TypeOf child Is C1SplitContainer Then
				controls.AddRange(GetChildren(child))
				Continue For
			End If
			controls.Add(child)
		Next
		Return controls
	End Function
End Class
