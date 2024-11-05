Imports C1.Win.C1Command
Imports GrapeCity.Win.MultiTouch
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Class C1MainMenuZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1MainMenu)
		End Get
	End Property

	Public Overrides Function GetChildren(control As Control) As IEnumerable(Of Control)
		Dim controls As New List(Of Control)()
		For Each child As Control In control.Controls
			controls.Add(child)
		Next
		Dim menu As C1MainMenu = TryCast(control, C1MainMenu)
		AddChildren(controls, menu.CommandLinks)
		Return controls
	End Function

	Private Sub AddChildren(controls As List(Of Control), commandLinks As C1CommandLinks)
		For Each commandLink As C1CommandLink In commandLinks
			If TypeOf commandLink.Command Is C1CommandMenu Then
				Dim commandMenu As C1CommandMenu = TryCast(commandLink.Command, C1CommandMenu)
				AddChildren(controls, commandMenu.CommandLinks)
				Continue For
			ElseIf TypeOf commandLink.Command Is C1CommandControl Then
				Dim commandControl As C1CommandControl = TryCast(commandLink.Command, C1CommandControl)
				If commandControl.Control IsNot Nothing AndAlso Not controls.Contains(commandControl.Control) Then
					controls.Add(commandControl.Control)
				End If
			End If
		Next
	End Sub


	Public Overrides Sub ZoomBounds(control As Control, infos As ZoomBoundsInfo)
		Dim menu As C1MainMenu = TryCast(control, C1MainMenu)
		ZoomCommandLinksBounds(infos, menu.CommandLinks)
	End Sub

	Public Overrides Sub ZoomFont(control As Control, infos As ZoomFontInfo)
		control.Font = infos.Zoom(control.Font)
		Dim menu As C1MainMenu = TryCast(control, C1MainMenu)
		ZoomCommandLinksFont(infos, menu.CommandLinks)
	End Sub


	Private Sub ZoomCommandLinksFont(infos As ZoomFontInfo, commandLinks As C1CommandLinks)
		For Each commandLink As C1CommandLink In commandLinks
			If TypeOf commandLink.Command Is C1CommandMenu Then
				Dim commandMenu As C1CommandMenu = TryCast(commandLink.Command, C1CommandMenu)
				If Not SystemInformation.MenuFont.Equals(commandMenu.Font) Then
					commandMenu.Font = infos.Zoom(commandMenu.Font)
				End If
				ZoomCommandLinksFont(infos, commandMenu.CommandLinks)
				Continue For
			End If
		Next
	End Sub

	Private Sub ZoomCommandLinksBounds(infos As ZoomBoundsInfo, commandLinks As C1CommandLinks)
		For Each commandLink As C1CommandLink In commandLinks
			If TypeOf commandLink.Command Is C1CommandMenu Then
				Dim commandMenu As C1CommandMenu = TryCast(commandLink.Command, C1CommandMenu)
				ZoomCommandLinksBounds(infos, commandMenu.CommandLinks)
				Return
			End If
		Next
	End Sub

End Class

Public Class C1DockingTabZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1DockingTab)
		End Get
	End Property

	Public Overrides Sub ZoomBounds(control As Control, infos As ZoomBoundsInfo)
		MyBase.ZoomBounds(control, infos)
		Dim dockingTab As C1DockingTab = TryCast(control, C1DockingTab)
		Try
			dockingTab.ItemSize = infos.Zoom(dockingTab.ItemSize)
		Catch generatedExceptionName As Exception
			
' ドッキングタブが閉じている場合、ItemSizeプロパティの設定で例外が発生する場合があります。
' 例外が発生する場合は、ItemSize プロパティにSize.Emptyを設定することで問題を回避できます。
			dockingTab.ItemSize = Size.Empty
		End Try
		dockingTab.SplitterWidth = infos.Zoom(dockingTab.SplitterWidth)
		dockingTab.TabsSpacing = infos.Zoom(dockingTab.TabsSpacing)
		dockingTab.TabAreaSpacing = infos.Zoom(dockingTab.TabAreaSpacing)
	End Sub

End Class

Public Class C1NavBarZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1NavBar)
		End Get
	End Property

	Public Overrides Sub ZoomBounds(control As Control, infos As ZoomBoundsInfo)
		MyBase.ZoomBounds(control, infos)
		Dim navBar As C1NavBar = TryCast(control, C1NavBar)
		If navBar.ButtonHeight > 0 Then
			navBar.ButtonHeight = infos.Zoom(navBar.ButtonHeight)
		End If
		If navBar.ImageIndent > 0 Then
			navBar.ImageIndent = infos.Zoom(navBar.ImageIndent)
		End If
		If navBar.PanelHeaderHeight > 0 Then
			navBar.PanelHeaderHeight = infos.Zoom(navBar.PanelHeaderHeight)
		End If
		If navBar.SectionHeaderHeight > 0 Then
			navBar.SectionHeaderHeight = infos.Zoom(navBar.SectionHeaderHeight)
		End If
		If navBar.SectionHeaderIndent > 0 Then
			navBar.SectionHeaderIndent = infos.Zoom(navBar.SectionHeaderIndent)
		End If
		If navBar.StripHeight > 0 Then
			navBar.StripHeight = infos.Zoom(navBar.StripHeight)
		End If


		If Not navBar.ImageScalingSize.IsEmpty Then
			navBar.ImageScalingSize = infos.Zoom(navBar.ImageScalingSize)
		End If
	End Sub

	Public Overrides Sub ZoomFont(control As Control, infos As ZoomFontInfo)
		MyBase.ZoomFont(control, infos)

		Dim navBar As C1NavBar = TryCast(control, C1NavBar)
		If navBar.ButtonFont IsNot Nothing Then
			navBar.ButtonFont = infos.Zoom(navBar.ButtonFont)
		End If
		If navBar.PanelHeaderFont IsNot Nothing Then
			navBar.PanelHeaderFont = infos.Zoom(navBar.PanelHeaderFont)
		End If
		If navBar.SectionHeaderFont IsNot Nothing Then
			navBar.SectionHeaderFont = infos.Zoom(navBar.SectionHeaderFont)
		End If
	End Sub
End Class

Public Class C1OutBarZoomPolicy
	Inherits ZoomPolicy
	Public Overrides ReadOnly Property TargetType() As Type
		Get
			Return GetType(C1OutBar)
		End Get
	End Property

	Public Overrides Sub ZoomBounds(control As Control, infos As ZoomBoundsInfo)
		Dim outBar As C1OutBar = TryCast(control, C1OutBar)
		outBar.PageTitleHeight = infos.Zoom(outBar.PageTitleHeight)
		MyBase.ZoomBounds(control, infos)
	End Sub
End Class

