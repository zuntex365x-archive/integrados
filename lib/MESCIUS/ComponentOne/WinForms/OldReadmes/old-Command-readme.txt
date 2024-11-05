========================================================================
C1Command for .NET Build 2/4.0.20142.19716 September 5, 2014
========================================================================

Corrections
-------------------------------------------
Fixed regressions: 84774, 84800

========================================================================
C1Command for .NET Build 2/4.0.20142.19715 September 5, 2014
========================================================================

Corrections
-------------------------------------------
48897 [Forum][C1DockingTab] Incorrect Docking indicators displayed while 
docking C1TabControl in Vertically Stacked C1TabControls
47555 [C1DockingTab] RestoreLayout/SaveLayout does not save/restore height 
and width of auto hiding tabs.

========================================================================
C1Command for .NET Build 2/4.0.20142.19713 August 28, 2014
========================================================================

Corrections
-------------------------------------------
82121 Bottom docked position does not retain while re-dock the DockingTab 
after auto hiding.
81929 [C1CommandHolder, C1TopicBar] C1TopiBar does not change appearance 
in design time although VisualStyle is changed after adding C1CommandHolder 
on the form.
30923 [C1NavBar] When adding C1NavBar to WinForm, incorrect Visual Style 
is shown in its properties.

========================================================================
C1Command for .NET Build 2/4.0.20142.19711 August 20, 2014
========================================================================

Corrections
-------------------------------------------
43298 [C1NavBar] "NullReferenceException" is observed when delete all 
buttons in NavBarPanel at Design Time.


========================================================================
C1Command for .NET Build 2/4.0.20142.19711 August 20, 2014
========================================================================

Corrections
-------------------------------------------
81912: C1NavBar.SelectedPanelChanging event fired while initializating the control

========================================================================
C1Command for .NET Build 2/4.0.20142.19710
========================================================================

Enhancement
-------------------------------------------
C1NavBar.SelectedPanelChanging - Allows to cancel changing the panel.

========================================================================
C1Command for .NET Build 2/4.0.20142.19709 
========================================================================

Corrections
-------------------------------------------
74198 Flicking occurs on removing tab page when C1DockingTab is AutoHide

========================================================================
C1Command for .NET Build 2/4.0.20142.19708 July 9, 2014 
========================================================================

Corrections
-------------------------------------------
34792:[DockingTab][Regression]Parallel DockingTab lost their position 
after AutoHiding and shown as Stacked Position
33787 c1DockingTabPage is disappeared when individual c1DockingTabPage of 
c1DockingTab  is pinned after unpinned.

========================================================================
C1Command for .NET Build 2/4.0.20142.19707 July 9, 2014 
========================================================================

Corrections
-------------------------------------------
47099 The position of the container placed on C1DockingTab is automatically 
changed after close and reopen the form
61230: C1Dockingpage is not rendered when C1DockinTab contains 1 Tabpage 
and 'AutoHiding' property is set to True on Load

========================================================================
C1Command for .NET Build 2/4.0.20142.19706 July 8, 2014 
========================================================================

Corrections
-------------------------------------------
70617 C1DockingTabPage throws handled exceptions for every call to 
Controls.Add() method.


========================================================================
C1Command for .NET Build 2/4.0.20142.19705 July 7, 2014 
========================================================================

Corrections
-------------------------------------------
64473 Flickering occurs on adding a tab page with AutoHiding set to True in C1DockingTab

========================================================================
C1Command for .NET Build 2/4.0.20142.19704 July 3, 2014 
========================================================================

Corrections
-------------------------------------------

50148 [C1Toolbar] “NullReferenceException” is occurred by opening the Toolbar 
Option in the c1DockingTab.
65480 C1DockingTabPages are hidden when the container form is restored after minimizing

========================================================================
C1Command for .NET Build 2/4.0.20142.19703 Jun 30, 2014 
========================================================================

Corrections
-------------------------------------------
37633 [C1DockingTab] When c1DockingTab’s TabStyle is set to “WindowXP”, 
an Exception is observed.
64195 Form designer crashes on deleting any event in the code behind
63048 Case 2 Some characters are not visible when used as the C1DockingTabPage's Text.
64293 An ArgumentOutOfRangeException occurs on calling C1DockingTab.RestoreLayout method.

========================================================================
C1Command for .NET Build 2/4.0.20142.19702 Jun 24, 2014 
========================================================================

Corrections
-------------------------------------------
52173 Auto-Hided DockingTab is come out automatically when loading 
saved auto-hided DockState.

========================================================================
C1Command for .NET Build 2/4.0.20141.19619 Apr 25, 2014 
========================================================================

Corrections
-------------------------------------------
64653 [C1DockingTab] BackColor is not applied by setting color from Design time.

========================================================================
C1Command for .NET Build 2/4.0.20141.19618 Apr 23, 2014 
========================================================================

Corrections
-------------------------------------------
50138 [C1Toolbar] Toolbar click event is fired by clicking the dropdown 
arrow of  the Toolbar option.
47145 [C1DockingTab] Non-Selected items can’t be retained by resizing the Form. 
33818 C1DockingTab position is changed after try to make floating state When c1CommandDock‘s ‘AllowFloat’ is set to ‘False’.

========================================================================
C1Command for .NET Build 2/4.0.20141.19617 March 14, 2014 
========================================================================

Corrections
-------------------------------------------
57272 [C1DockingTab] ‘NullReferenceException’ has occurred and C1DockingTab 
is getting crash by setting TabStyle=Office2003 when a Theme is applied.

========================================================================
C1Command for .NET Build 2/4.0.20141.19616 March 13, 2014 
========================================================================

Corrections
-------------------------------------------
56469 * Issues occur if Transparent background is set to C1OutBar.
Note, Transparent BackColor for C1OutBar is not allowed by design.

========================================================================
C1Command for .NET Build 2/4.0.20141.19615 March 13, 2014 
========================================================================
POSSIBLE BREAKING CHANGE:
If you use custom not built-in theme, it is possible you need to review 
   C1DockingTab\Tabs\Unpinned
   C1DockingTab\Tabs\UnpinnedSelected 
nodes.

*[C1DockingTab] Theme-related changes
 - colors for arrows/list/close glyphs in different parts:  
  Added ArrowColor, HotArrowBorderColor, HotArrowBorderBackground in nodes:
            Tabs\TabArea
            Tabs\Default
            Tabs\Selected
            Caption\Inactive
            Caption\Active
- Reviewed unpinned tabs properties.

Corrections
-------------------------------------------
56073 Caption of C1DockingTab Page is shown by setting ‘Show Caption’ 
to 'False' 

========================================================================
C1Command for .NET Build 2/4.0.20141.19613 March 12, 2014 
========================================================================

Corrections
-------------------------------------------
48906 [C1DockingTab] Incorrect docking action occuring for overlapping Floating C1DockingTab controls.
52173 case1 [C1DockingTab] Page slides on change TabVisible when AutoHide mode is True.
55891 Auto hide icon is not changed although C1DockingTab is changed as ‘Auto hide’ state.
46788 [C1Theme]Unhandled exception is occurred if transparent  background is set to 
“BaseThemeProperties\Styles\Header”
55847 "Strings" property causing ambiguity issue in Visual Basic projects.
51706 [39719][C1DockingTab] Focus moves to Hidden Tabpage when navigating using Arrow keys.

========================================================================
C1Command for .NET Build 2/4.0.20141.19611 March 6, 2014 
========================================================================

*[C1DockingTab] Theme-related changes
 - added theme nodes:
  C1Command\C1DockingTab\Caption\Inactive\ForeColor
  C1Command\C1DockingTab\Caption\Inactive\BorderColor
  C1Command\C1DockingTab\Caption\Inactive\ArrowColor
  C1Command\C1DockingTab\Caption\Inactive\Background

  C1Command\C1DockingTab\Caption\Active\ForeColor
  C1Command\C1DockingTab\Caption\Active\BorderColor
  C1Command\C1DockingTab\Caption\Active\ArrowColor
  C1Command\C1DockingTab\Caption\Active\Background

Info: Caption is a top part of a docking tap page. It's shown if C1DockingTab.ShowCaption is True.
The page is "active" if it contains focus.

========================================================================
C1Command for .NET Build 2/4.0.20141.19610 February 25, 2014 
========================================================================
* [C1NavBar] Theme-related changes
 - added theme nodes:
   C1Command\C1NavBar\Button\Default\MoreArrowColor
   C1Command\C1NavBar\Button\Hot\MoreArrowColor
   C1Command\C1NavBar\Button\Hot & Pressed\MoreArrowColor

   C1Command\C1NavBar\Button\Default\CollapseArrowColor
   C1Command\C1NavBar\Button\Hot\CollapseArrowColor
   C1Command\C1NavBar\Button\Hot & Pressed\CollapseArrowColor

*[C1TopicBar] Theme-related changes
 - added theme node:
 C1Command\C1TopicBar\Page\HotSpecial\ArrowColor

 *[C1DockingTab] Theme-related changes
 - added theme node:
 C1Command\C1DockingTab\Tabs\Default\ArrowColor
 C1Command\C1DockingTab\Tabs\Selected\ArrowColor

========================================================================
C1Command for .NET Build 2/4.0.20141.19609 February 19, 2014 
========================================================================

* Misc theme-related changes

========================================================================
C1Command for .NET Build 2/4.0.20141.19608 February 4, 2014 
========================================================================

Corrections
-------------------------------------------
* 49343 [38569-139] Tabs in the C1DockingTab are still visible if the 'ShowTabs' property is set to 'False'.

========================================================================
C1Command for .NET Build 2/4.0.20133.19607 February 4, 2014 
========================================================================

Corrections
-------------------------------------------
* 50462 [C1Theme][C1DockingTab]Removing of applied Theme throws Object Reference exception.

========================================================================
C1Command for .NET Build 2/4.0.20133.19606 January 27, 2014 
========================================================================

Corrections
-------------------------------------------
* [C1Theme, C1CommandMenu] SideCaption is always shown in Theming mode.

========================================================================
C1Command for .NET Build 2/4.0.20133.19605 January 24, 2014 
========================================================================

Corrections
-------------------------------------------
* 49576 All tab Pages are disappeared by clicking the close button of  the one 
TabPage at ‘AutoHide’. 
* 13665 (Regression) The position of the container placed on C1DockingTab is automatically changed 
after close and reopen the form.

========================================================================
C1Command for .NET Build 2/4.0.20133.19604 January 15, 2014 
========================================================================

Corrections
------------------------------------------- 
* C1CommandMDIList Behaves inconsistent when the C1CommandMenu, which contains C1CommandMDIList, 
is merged. (10384)
* "NullReferenceException" is received, when a form containing C1Command control is opened 
in a separate thread (48270)

========================================================================
C1Command for .NET Build 2/4.0.20133.19600 January 12, 2014 
========================================================================

Corrections
------------------------------------------- 
* Misc themes-related fixes.

========================================================================
C1Command for .NET Build 2/4.0.20133.19599 January 6, 2014 
========================================================================

Corrections
------------------------------------------- 
* [C1Theme, C1DockingTab] Theme does not apply to the tab page list of the C1DockingTab.

========================================================================
C1Command for .NET Build 2/4.0.20133.19598 November 25, 2013 
========================================================================

Corrections
------------------------------------------- 
* C1DockingTab remains visible if no visible tabs on RestoreLayout(). (38442)
* Default theme is not applied to C1DockingTab at design time after adding the docking tab on the form. 
* [C1Theme] Settings from c1Theme not applied to C1Toolbar items under ‘More…’ button. (44060)

========================================================================
C1Command for .NET Build 2/4.0.20133.19597 November 12, 2013 
========================================================================

Corrections
------------------------------------------- 
* [C1RadialMenu] Incorrect icon was used in VS2012 toolbox.

========================================================================
C1Command for .NET Build 2/4.0.20133.19596 November 7, 2013 
========================================================================

Corrections
------------------------------------------- 
* [Theming] White dots in corners of submenu item's check mark if CheckMark\BorderColor set to Transparent.
* [C1DockingTab] Mics issues when using C1DockingTab in multi-threading applications. (44073)

========================================================================
C1Command for .NET Build 2/4.0.20133.19595 November 6, 2013 
========================================================================

Corrections
------------------------------------------- 
* C1CommandMenu delimiter does not fit in Theming mode.
* C1DockingTab\Tabs\Selected\Background does not work in Theming.
* Border of C1NavBar's button is shifted by 1 pixel.

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Theming for SideCaption of C1CommandMenu.

========================================================================
C1Command for .NET Build 2/4.0.20133.19594 November 1st, 2013 
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* VisualStyle support in Theming.

Corrections
------------------------------------------- 
* Semi-transparent PNG icons of C1Command are distorted when used on non-white background. (44999)

========================================================================
C1Command for .NET Build 2/4.0.20133.19593 October 21, 2013 
========================================================================

Corrections
------------------------------------------- 
* Title caption of C1DockingTab doesn't show initially. (43443)
* C1DockingTabPage is auto come out without mouse hang over 
the tab page at auto-hiding mode. (41751)

========================================================================
C1Command for .NET Build 2/4.0.20133.19592 October 16, 2013 
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* new property
 C1TopicPage.ShowButton - whether the expand/collapse button is shown on the page title.

Corrections
------------------------------------------- 
* Theme drawing of borders.
* No Local Tab placement indicator is shown for floating Tab. (37857)
* C1NavBar issue when child control is not validated. (19438)
* C1MainMenu is not displayed on switch Visible to True. (33730)
* C1Toolbar is not wrapped after docking the floating C1Toolbar although the Wrap property is true. (43253)
* [C1TopicBar] FindLinkByTag() Method  throws a NullReference exception instead of returning null 
when searching for a string tag that is not defined for any of the links in c1TopicBar. (39159)

========================================================================
C1Command for .NET Build 2/4.0.20133.19591 October 12, 2013 
========================================================================

Corrections
------------------------------------------- 
* Theme support fixes

========================================================================
C1Command for .NET Build 2/4.0.20133.19590 October 11, 2013 
========================================================================

* 2013 v3 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* new C1RadialMenu control
* C1Theme support. All C1Command controls are supported in the C1ThemeDesigner application. 
  That allows to use default C1 themes or custom ones and to apply them on application level.

========================================================================
C1Command for .NET Build 2/4.0.20132.19579 October 9, 2013 
========================================================================

Corrections
------------------------------------------- 
* [C1DockingTab] C1DockingTab autohides everytime even if the focus 
is inside the tabcontrol placed within it. (36934)
* DockingTab and DockingTabPage cannot be locked to specific CommandDock. (39138)

========================================================================
C1Command for .NET Build 2/4.0.20132.19578 September 9, 2013 
========================================================================

Corrections
------------------------------------------- 
* Fixed a regression (41701)

========================================================================
C1Command for .NET Build 2/4.0.20132.19577 September 9, 2013 
========================================================================

Corrections
------------------------------------------- 
* [Localization Issue] Descriptions from some properties of C1DockingTab are not localized in 
Japan environment. (37843)
*  [C1Command] When the width of Form containing C1ToolBar is narrowed,  the display becomes 
abnormal and exception occurs on clicking. (41028) 

========================================================================
C1Command for .NET Build 2/4.0.20132.19574 August 25, 2013 
========================================================================

Corrections
------------------------------------------- 
* When a form containing C1CommandDock and C1DockingTab controls is resized 
 to  narrow height in a scenario, order and proportion of docking tab height is changed. (40534)

========================================================================
C1Command for .NET Build 2/4.0.20132.19574 August 10, 2013 
========================================================================

Corrections
------------------------------------------- 
 * When a form containing C1CommandDock and C1DockingTab controls is resized 
 to  narrow height in a scenario, the error “Divided by 0” occurs. (40534)
 * The size of C1CommandDock does not get correctly reflected after C1DockingTab movements 
 and run 'RestoreLayout' (39811)

========================================================================
C1Command for .NET Build 2/4.0.20132.19573 August 9, 2013 
========================================================================

Corrections
------------------------------------------- 
 * [C1DockingTab] Multiple issues related to Hide/Close page behavior:
  - C1DockingTabPage is not closed immediately by clicking close box icon  in auto-hiding mode. (40401)
  - Although C1DockingTabpage’s CloseTabBehavior is set to “Hide”, On Click Close box the tab page 
  is closed and removed from the TabPage Collection. (40373)
  - NullReferenceException is  occurred while editing tab’s name  in auto-hiding mode. (40349)
  - After Tabvisible of the last two Tab Pages  are  set to “False” at Run time, any items are not selected. (40285)
  - Hidden pages are shown in the TabList. (40285) 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
  - Page image has been removed from the TabList dropdown. (39297)

========================================================================
C1Command for .NET Build 2/4.0.20132.19572 August 8, 2013 
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
*POSSIBLE BREAKING CHANGES*

** Changes in Hide/Close page behavior (related to 40101).

* New C1DockingTabPage.Closing and C1DockingTabPage.Closed events.

*Clicking on close box, behavior is changed:

  1. If C1DockingTabPage.CloseTabBehavior is Close (default) then on clicking the CloseBox:
      - TabVisible property is not changed;
     - TabVisibleChanged event is not fired;  
     - TabClosing and TabClosed event of C1DockingTab containing the page are fired;
     - Closing and Closed event of C1DockingTabPage are fired.
Note: to show closed C1DockingTabPage you should add the page to a C1DockingTab.TabPages collection. 

  3. If C1DockingTabPage.CloseTabBehavior is Hide then
     - TabVisible property is changed to False;
     - TabVisibleChanged event is fired;  
     - TabClosing and TabClosed event of C1DockingTab are not fired;
     - Closing and Closed event of C1DockingTabPage are not fired.
Note: to show closed C1DockingTabPage you set TabVisible = True


========================================================================
C1Command for .NET Build 2/4.0.20132.19571 June 17, 2013 
========================================================================

Corrections
------------------------------------------- 
  *  "NullReferenceException" is observed when click 'Auto Hide' button and renaming tabs at Run time. (37817)

========================================================================
C1Command for .NET Build 2/4.0.20132.19570 June 17, 2013 
========================================================================

Corrections
------------------------------------------- 
  * [C1DockingTab] If Tabvisible of the last TabPage is set to true, the whole of c1DockingTab 
  is disappeared. (39738)

========================================================================
C1Command for .NET Build 2/4.0.20132.19569 June 17, 2013 
========================================================================

Corrections
------------------------------------------- 
  * C1DockingTab.RestoreLayout/SaveLayout does not save/restore the layout correctly. (37491, 37734) 


========================================================================
C1Command for .NET Build 2/4.0.20132.19568 June 13, 2013 
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* New property:
    C1DockingTabPage.CloseTabBehavior 
		Two values:
			Close - on click Close box the tab page is closed and removed from the TabPages collection. Default.
			Hide - on click Close box the tab page just hidden. TabVisible = false. 
	related issue - 37533

========================================================================
C1Command for .NET Build 2/4.0.20132.19567 June 5, 2013 
========================================================================

2013 v2 Build

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* New property:
  C1DockingTab.CanRenameTabs - whether the end user can rename tabs by double clicking on the tab's text (32201).

* Sample - RenamingTabs

===============================================================================
C1Command for .NET Build 2/4.0.20131.19566 June 4, 2013
===============================================================================

Corrections
------------------------------------------- 
* At registered state Nag screen is shown sometimes. (37096)
* When command tabs hidden they can still be selected with mouse. (36163)
* C1DockingTab.RestoreLayout/SaveLayout does not save/restore 
the layout correctly. (35922)
* Although TabVisible is set to 'False' at design time/ run time,
the TabPage is appeared when reducing the Window form size if C1DockingTab 
is auto-hide.(30391)
* NavBarCollapsedBarText is appeared in NavBarPanel After setting 
'AllowCollapse=False' (33620)
* C1CommandDock cannot enlarge as required if another C1CommandDock 
with same Dock value on the Form is AutoHide. (35668)
* [C1DockingTab]Validation message box is raised all the time after cancelling 
the “Validating” event of textbox in the docking tab. (32358)

===============================================================================
C1Command for .NET Build 2/4.0.20131.19564 May 18, 2013
===============================================================================

Corrections
------------------------------------------- 
* Collapse button's direction is not changed to 'Right' (>>) in some conditions. (36139) 

===============================================================================
C1Command for .NET Build 2/4.0.20131.19563 May 1, 2013
===============================================================================

Corrections
------------------------------------------- 
* C1DockingTabPage moves to incorrect position when the TabPage next to it, 
with a large text is closed. (34450)
* Saving the layout of C1DockingTab and reloading it does not retain the size 
of the Tab page. (14138)
*  C1DockingTab does not show the ‘SelectedIndex’ at Design Time. (29594)

========================================================================
C1Command for .NET Build 2/4.0.20131.19561 April 4, 2013
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* [Localization Issue] English Strings are observed in Japanese version 
of C1Command. (34205) 
* new licensing model applied in JPN version.

========================================================================
C1Command for .NET Build 2/4.0.20131.19559 March 8, 2013
========================================================================

Corrections
------------------------------------------- 
* Regression: C1DockingTab in AutoHide state is added to second column in 
runtime. (34664, 27981)

========================================================================
C1Command for .NET Build 2/4.0.20131.19558 March 8, 2013
========================================================================

Corrections
------------------------------------------- 
POSSIBLE BREACKING CHANGES!
* When C1DockingTab is Visible OFF after moving outside the form, 
the outer border or the docking tab remains displayed. (34295)

Note: 
	A floating docking tab always has a parent "floatie" window.

Before build 19558 making the floating docking tab invisible did not 
hide the "floatie" window.

Starting from build 19558 making the floating docking tab invisible 
or hiding the all pages by TabVisible=False for all pages 
hides the "floatie" window.

To hide/show a DockingTab or a DockingTabPage no matter floating or 
not it is enough to set C1DockingTab.Visible=False/True or
C1DockingTabPage.TabVisible=False/True


========================================================================
C1Command for .NET Build 2/4.0.20131.19557 February 23, 2013
========================================================================
* Different behavior observed when setting AutoHiding=True at 
Design and Run Time while C1CommandDock is docked at Right/Left. (34222)
* C1DockingTab is distorted if user docked center at run time. (34220)
* C1DockingTab does not dock inside C1CommandDock at Design Time. (34219)

========================================================================
C1Command for .NET Build 2/4.0.20131.19556 February 20, 2013
========================================================================
* C1DockingTab in AutoHide state is added to second column in runtime.

========================================================================
C1Command for .NET Build 2/4.0.20131.19555 February 20, 2013
========================================================================

Corrections
------------------------------------------- 
* [C1Menu] Setting “Delimiter” property of child form sub menu to on and 
off is not working at run time when theses menu are merge with 
parent form menu. (30806)

========================================================================
C1Command for .NET Build 2/4.0.20131.19554 February 4, 2013
========================================================================

Corrections
------------------------------------------- 
* [C1DockingTab] Misc layout issues. (33730, 33734, 33727)

========================================================================
C1Command for .NET Build 2/4.0.20131.19553 February 3, 2013
========================================================================

Corrections
------------------------------------------- 
* [C1DockingTab] Misc layout issues. (33700, 33702, 33704, 33706)

========================================================================
C1Command for .NET Build 2/4.0.20131.19552 February 1, 2013
========================================================================

Corrections
------------------------------------------- 
* After C1DockingTab is changed to floating and docked again, it is not 
docked at intended place. (33668)
* C1DockingTab is not retained DockingTabPage position after Autohiding. (33485)

========================================================================
C1Command for .NET Build 2/4.0.20131.19551 January 30, 2013
========================================================================

Corrections
------------------------------------------- 
* [C1DockingTab] Surrounding issues for TFS 30907 (33111, 33494)

========================================================================
C1Command for .NET Build 2/4.0.20131.19550 January 28, 2013
========================================================================

* 2013 v1 Release

Corrections
------------------------------------------- 
POSSIBLE BREACKING CHANGES!
* License entry not created for C1Toolbar and C1ContextMenu. (7587)

Note: Previous versions of C1Command did not create license entry for 
C1ContextMenu and C1Toolbar in license.licx file and did not show nag screen 
if the license entry is missing in license.licx.

Now it's fixed. 
THIS MEAN YOU MAY FACE WITH NAG SCREEN IN YOUR EXISTING APPLICATIONS.
Solution:
If C1Command shows nag screen next two lines in license.licx file and 
re-build application:

C1.Win.C1Command.C1ContextMenu, C1.Win.C1Command.2
C1.Win.C1Command.C1ToolBar, C1.Win.C1Command.2

or 

C1.Win.C1Command.C1ContextMenu, C1.Win.C1Command.4
C1.Win.C1Command.C1ToolBar, C1.Win.C1Command.4

* [Design Time]Changes in C1ContextMenu's smart tag. 
Now it contains "Visual Style", "Edit Menu" and "About".

========================================================================
C1Command for .NET Build 2/4.0.20123.19548,  January 22, 2013
========================================================================

Corrections
------------------------------------------- 
* Resizing DockingTabPage after Move and Dock, order of DockingTabPages 
are changed. (33166)

========================================================================
C1Command for .NET Build 2/4.0.20123.19547,  January 22, 2013
========================================================================

Corrections
------------------------------------------- 
* [C1DockingTab] Surrounding issue for TFS 30907:[C1Command] Display order 
changes when Tab page is set to non-display. (33111)

========================================================================
C1Command for .NET Build 2/4.0.20123.19546,  January 21, 2013
========================================================================

Corrections
------------------------------------------- 
* [27065-139] Multiple behaviors observed for More button(>>) of C1Toolbar 
if there are 3 C1CommandDock inside container. (33133)
* C1DockingTab’s items are not refreshed after resizing Window Form 
if c1DockingTab is auto-hide. (30931)
* c1DockingTab page is disappeared when Window is switched to ‘Maximize’ 
or ‘Minimize’. (33110)

========================================================================
C1Command for .NET Build 2/4.0.20123.19545,  January 10, 2013
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* New boolean property:
   C1DockingTab.TabsShowFocusCues 
Gets or sets a value indicating whether tabs should display focus rectangles. 

* "C1Command" extender property is available for custom buttons, derived 
from "object" type (not Control). For example, for C1RibbonButton.

POSSIBLE BREACKING CHANGES  
------------------------------------------- 
* Type of the first parameter of GetC1Command/SetC1Command methods of 
C1CommandHolder is changed from "Control" to "object".

========================================================================
C1Command for .NET Build 2/4.0.20123.19544,  January 10, 2013
========================================================================

Corrections
------------------------------------------- 
* Display order changes when Tab page is set to non-display. (30907)

========================================================================
C1Command for .NET Build 2/4.0.20123.19543,  December 14, 2012
========================================================================

Corrections
------------------------------------------- 
* “ObjectDisposedException’ is occurred when clicking C1menu inside 
C1DockingTab after C1DockingTab is changed from floating state 
to docked state. (28076)

========================================================================
C1Command for .NET Build 2/4.0.20123.19542,  December 11, 2012
========================================================================

Corrections
------------------------------------------- 
* An exception throws when C1ToolBar placed on C1DockingTab once made 
into floating state is clicked. (30456)

========================================================================
C1Command for .NET Build 2/4.0.20123.19541,  November 23, 2012
========================================================================

Corrections
------------------------------------------- 
* The Second horizontal Toolbar is entered into the Right border 
of the form by dragging. (28149)

========================================================================
C1Command for .NET Build 2/4.0.20123.19540,  November 21, 2012
========================================================================

Corrections
------------------------------------------- 
* C1DockingTabPage disappear when trying to resize this tab page after 
another tab page is docked to left. (27413)
* [C1MainMenu, C1OutBar, C1ToolBar] ‘ShowToolTipChanged’ event is getting 
fired when setting of same value. (29891)

========================================================================
C1Command for .NET Build 2/4.0.20123.19539,  November 15, 2012
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added localized event descriptions for simplified Chinese. (29742)

Corrections
------------------------------------------- 
* Application hangs after the form containing C1DockingTab is minimize 
when “ScrollToSelectedTab” method is called in C1DockingTab1_SizeChanged event. (29512)

========================================================================
C1Command for .NET Build 2/4.0.20123.19538,  November 5, 2012
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added localization for simplified Chinese. 
 Used if the CurrentUICulture name is starting with "zh".

========================================================================
C1Command for .NET Build 2/4.0.20123.19537,  November 2, 2012
========================================================================

Corrections
-------------------------------------------
* When DockingTabPage is moved from C1DockingTab, square border 
appeared in DockingTab. (29207)
* MoveUp/MoveDown twice on uncheck Panel in 'Navigation Panel Options..' 
Dialog ,the panel is getting checked. (29215)
* Page is not selected at application start if Enabled set to False 
in design time. (29222)

========================================================================
C1Command for .NET Build 2/4.0.20123.19536,  October, 14, 2012
========================================================================

Corrections
-------------------------------------------
* [C1ToolBar] Exception is thrown in the designer when changing to “System” 
visual Style after Window Aero theme is changed from Window Classic theme. (21447)
* [C1DockingTab] C1ContextMenu  is not shown when the Form containing 
the context menu is docked in a C1DockingTab. (28989)
* [VS2012] [C1Command] The icons of C1OutBar and C1TopicBar are the same in VS2012. (27615)
* Toolbar icon design for C1Toolbar in VS 2012 is different with C1Toolbar icon in VS2012. (27746)

========================================================================
C1Command for .NET Build 2/4.0.20123.19534,  October, 11, 2012
========================================================================

* 2012 v3 Drop

Corrections
-------------------------------------------
* [C1NavBar] ForeColor and BackColor of C1NavBarSectionHeader 
do not get reflected. (27606)
* [C1DockingTab] DockingTab is disappear after resizing when there is a control 
which is dock to fill is placed in the same form with the dockingTab. (28720)
* [C1DockingTab]The child docking tab is unable to tabs under the ribbon controls 
and it always docked on the right and left of the ribbon in certain scenarios. (17917)
* ‘NullReferenceException’ is observed after overriding the “OnLoad”  method of 
UserControl which contain c1DockingTab in certain scenarios (32984).

========================================================================
C1Command for .NET Build 2/4.0.20122.19532,  September, 30, 2012
========================================================================

Corrections
-------------------------------------------
* [C1ToolBar] Multiple issues are observed in C1ToolBar when the OS has 
activated visual styles like Win7 Aero. (16549)
* [C1ToolBar] ‘ArgumentException’ is occurred when c1Toolbar placed  
inside MS-Tab control is dragged out. (28119)
* [C1DockingTab] Disabled c1DockingTabPage is shown in TabList 
as active state. (24476)
* [C1NavBar] “Collapse Button” is still occured although “AllowCollaspe” 
is set to ‘False’ from run time. (23180)
* C1Docking Tab is incorrectly scaled after switching of a font size to 
125% (19844)

========================================================================
C1Command for .NET Build 2/4.0.20122.19531,  September, 3, 2012
========================================================================

Corrections
-------------------------------------------
* [VS2012] Different Toolbox icons are observed for FW 2.0 and 4.0 versions.

========================================================================
C1Command for .NET Build 2/4.0.20122.19529,  Aug, 21, 2012
========================================================================

Corrections
-------------------------------------------
* C1Command components' Icons are not shown correctly in ToolBox. (26377, 26742)
* Updated CompanyName and Copyright for “C1.Win.C1Command.4.Design.dll” (26771)
* Added localization string for "Enabled" in C1TopicLink properties form.
* Docking cannot be done spread across the whole form. (19107)
* (Re-fix) Tabs do not function properly when they are lined up sideways and 
the horizontal width is changed. (18273) 

========================================================================
C1Command for .NET Build 2/4.0.20122.19527,  Aug, 17, 2012
========================================================================

Corrections
-------------------------------------------
* Tabs do not function properly when they are lined up sideways and 
the horizontal width is changed. (18273) 

========================================================================
C1Command for .NET Build 2/4.0.20122.19526,  Aug, 16, 2012
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added Metro-style toolbox icons.

Corrections
-------------------------------------------
* “NullReferenceException was unhandled” Exception is occurred on  
docking c1dockingtab when DockingStyle is set to custom value (VS2005 or VS2008 or VS2010) 
and any property (AutoDockLeft OR AutoDockRight OR AutoDockTop or AutoDockBottom) is set to False. (25472)
* If there is a CheckBox or Radiobutton in MDI form, the form does not 
display at the front of the screen. (17980)
* C1DockingTapPage disappears when position change if DockingStyle 
is set as VS2005/VS2008 /VS2010 (19273, 25475)

========================================================================
C1Command for .NET Build 2/4.0.20122.19524,  Aug, 12, 2012
========================================================================

Corrections
-------------------------------------------
* Tabs do not function properly when they are lined up sideways and 
the horizontal width is changed. (18273) 

========================================================================
C1Command for .NET Build 2/4.0.20122.19523,  Aug, 7, 2012
========================================================================

Corrections
-------------------------------------------
 * When 'Enabled' property of an active tab is set to False, other tabs 
 cannot be selected. (24466)
 * Error occurs when C1CommandDock is placed on C1Sizer and changed to 
 Floating state. (24525)

========================================================================
C1Command for .NET Build 2/4.0.20122.19522,  Aug, 7, 2012
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * New public property
  C1TopicLink.Enabled - Gets or sets a value indicating whether the link 
  can respond to user interaction. (18796)

Corrections
-------------------------------------------
*  C1DockingTab.Parent property fetched by FloatingChanged event becomes 
Null. (24345)
* When navigating C1DockingTabPage, the shadow size and the docked size are 
different. (19353)

========================================================================
C1Command for .NET Build 2/4.0.20122.19521,  July, 23, 2012
========================================================================

Corrections
-------------------------------------------
* C1DockingTab’s Close button imaging is distorted during form resizing. (23087, 23858, 23252)
* In the ‘Navigation Panel Options’  dialog, some moved up/down (swapped) items are 
disappeared on clicking the ‘Reset’ button. (10588)
* SelectedIndexChanged Event is fired at loading time even when C1OutBar.SelectedIndex 
property is not changed. (23989)

========================================================================
C1Command for .NET Build 2/4.0.20122.19520,  July, 9, 2012
========================================================================

Corrections
-------------------------------------------
* updated AssemblyCompany and AssemblyCopyright attributes and about box.

========================================================================
C1Command for .NET Build 2/4.0.20122.19519,  Jun, 12, 2012
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * New public event
   C1DockingTab.SelectedTabChanged 

   Behavior:
   - C1DockingTab.SelectedTabChanged fires when C1DockingTab.SelectedTab property changed.  
   - C1OutBar.SelectedPageChanged fires when C1OutBar.SelectedPage property changed.  
   - C1DockingTab.SelectedIndexChanged fires when C1DockingTab.SelectedIndex property changed.  
   - C1OutBar.SelectedIndexChanged fires when C1OutBar.SelectedIndex property changed.  

   Note: if SelectedTab is changed, but SelectedIndex the same (for example on SelectedTab removing),
   SelectedIndexChanged is not fired. Versa vista. (15694)

Corrections 
------------------------------------------- 
  *  “LinkClick” event of C1TopicBar does not thrown an error although an 
  exception is thrown in the  event. (15383)
  * Changes made in C1NavBarButton designer are not saved. (16393)

========================================================================
C1Command for .NET Build 2/4.0.20122.19518,  Jun, 11, 2012
========================================================================

Corrections 
------------------------------------------- 
  * On hiding a particular C1OutPage, the other C1OutPage also gets hidden. (21199) 

========================================================================
C1Command for .NET Build 2/4.0.20121.19517,  May, 30, 2012
========================================================================

Corrections 
------------------------------------------- 
  * [C1TopicBar] Links Click event seem to fired twice  after the visible 
  topic page that is clicked is hidden and showing back another invisible 
  topic page. (18659) 

========================================================================
C1Command for .NET Build 2/4.0.20121.19516,  Apr, 23, 2012
========================================================================

Corrections 
------------------------------------------- 
  * [C1ToolBar] Multiple issues are observed in C1ToolBar when the OS has 
  activated visual styles like Win7 Aero. [6583-139] (16549)
  * [C1ToolBar]The tooltip overlaps the context menu when ContextMenuStrip 
  is added below the c1Toolbar. [6722-139] (16649)

========================================================================
C1Command for .NET Build 2/4.0.20121.19515,  Apr, 9, 2012
========================================================================

Corrections 
------------------------------------------- 
  * “ArgumentOutOfRangeException” is thrown, after double clicking on the 
  title of C1Dockng Tab window when it is in floating state. (20553)

========================================================================
C1Command for .NET Build 2/4.0.20121.19514,  Mar, 20, 2012
========================================================================

Corrections 
------------------------------------------- 
 * Docking options screen is distorted in Windows 7 Medium font mode. (20359)

========================================================================
C1Command for .NET Build 2/4.0.20121.19513,  Mar, 20, 2012
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
  * New public property C1CommandDock.FloatHide defines behavior of floating 
  windows when the application loses focus.

  Default behavior is changed. Since build 19513 c1CommandDock does not hide 
  floating windows when application loses focus.

========================================================================
C1Command for .NET Build 2/4.0.20121.19512,  Mar, 13, 2012
========================================================================

Correction 
------------------------------------------- 
  * [C1DockingTab] Strips are shown in the C1CommandDock after dockingTab 
  pages are in auto hiding state. (19591)
  * “NullReferenceException” is observed at design time after form is resize 
  when C1CommandDock is added on the form for second time. (19592)

========================================================================
C1Command for .NET Build 2/4.0.20121.19511,  Feb, 20, 2012
========================================================================

Correction 
------------------------------------------- 
  * 'ArgumentOutofRange 'Exception is thrown on double-clicking a tab 
  restored to Floating state. (19731)

========================================================================
C1Command for .NET Build 2/4.0.20121.19510,  Feb, 16, 2012
========================================================================

Correction 
------------------------------------------- 
  * New ‘C1ContextMenu’ extender property is not added to NotifyIcon if the 
  NotifyIcon is added to the form after adding the C1ContextMenu. (19731)
  * ‘C1ContextMenu1 on C1CommandHolder’ property is missing from the 
  properties window. (19797)

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
  Public methods of C1CommandHolder component:
	public C1ContextMenu GetC1ContextMenu(Control control)
	public C1ContextMenu GetC1ContextMenu(NotifyIcon notifyIcon)
  replaced with more common method:
    public C1ContextMenu GetC1ContextMenu(object control)
  
  Methods of C1CommandHolder component:
	public void SetC1ContextMenu(Control control, C1ContextMenu value)
	public void SetC1ContextMenu(NotifyIcon notifyIcon, C1ContextMenu value)
  replaced with more common method:
	public void SetC1ContextMenu(object control, C1ContextMenu value)
  
This change should not break any existing code. 

========================================================================
C1Command for .NET Build 2/4.0.20121.19509,  Feb, 13, 2012
========================================================================

 * Corrections:
	Size of another tab, which is thought to have no influence on docking, 
   gets changed at the time of docking  (19667).
	Size and arrangement of other DockingTabPages gets changed even though 
   docking of one DockingTabPage has not been completed  (19354).

========================================================================
C1Command for .NET Build 2/4.0.20121.19508,  Feb, 10, 2012
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * New C1Command.ShortcutText property.
   Use this property to localize shortcuts.
   If Shortcut property is empty or ShowShortcut is False, then the ShortcutText has no any effect.
   If ShortcutText property is empty, then default value is used for the shortcut.

========================================================================
C1Command for .NET Build 2/4.0.20121.19507,  Feb, 7, 2012
========================================================================

 * Corrections:
   The C1NavBar allows to switch panel even if an child control 
   is not validated (19438).

========================================================================
C1Command for .NET Build 2/4.0.20121.19506,  Feb, 1, 2012
========================================================================

* 2012 v1 Drop

========================================================================
C1Command for .NET Build 2/4.0.20113.19505,  Jan, 24, 2012
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
  "Whole form docking layout support."
	To use the all space of the form for docking,
	place a C1CommandDock with Dock = DockStyle.Fill on the form.
	In this case when user drags a C1DockingTab over the "Fill" C1CommandDock,
	a "Fill" anchor is shown.
  
  Note: This feature works only with VS2005/VS2008/VS2010 DockingStyle.

  This feature also resolves issue "Docking cannot be done spread across the whole form" (19107)


========================================================================
C1Command for .NET Build 2/4.0.20113.19504,  Jan, 13, 2012
========================================================================

* Corrections:
  C1DockingTab gets arranged below C1StatusBar  (19273) 

========================================================================
C1Command for .NET Build 2/4.0.20113.19503,  Nov, 30, 2011
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
  New functionality of C1ContextMenu that works with the standard notify icon. (13553)

  There are 3 possibilities:

  1. C1ContextMenu can be shown from a notify icon's MouseUp or MouseDown event.
        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = Cursor.Position;
            c1ContextMenu1.ShowContextMenu(null, p);
        }
  2. C1ContextMenu can be linked to a NotifyIcon component using a new method:
        c1CommandHolder1.SetC1ContextMenu(notifyIcon1, c1ContextMenu1);

  3. C1ContextMenu can be linked to a NotifyIcon in designer.
  New extender property "C1ContextMenu" is added to NotifyIcon component in design time.

  New public methods of C1CommandHolder component:
	public C1ContextMenu GetC1ContextMenu(NotifyIcon notifyIcon)
	public void SetC1ContextMenu(NotifyIcon notifyIcon, C1ContextMenu value)


========================================================================
C1Command for .NET Build 2/4.0.20113.19503,  Nov, 30, 2011
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Updated licensing to conform with Federal Information Processing Standards requirements (TFS 18562)

========================================================================
C1Command for .NET Build 2/4.0.20113.19502,  Nov, 24, 2011
========================================================================

Enhancements/Documentation/Behavior Changes
------------------------------------------- 
- Updated licensing to conform with Federal Information Processing Standards requirements. (18460)

========================================================================
C1Command for .NET Build 2/4.0.20113.19501,  Nov, 22, 2011
========================================================================
* Corrections:
  If there is a CheckBox or Radiobutton in MDI form, the form does not 
  display at the front of the screen. (17980) 

========================================================================
C1Command for .NET Build 2/4.0.20113.19499,  Nov, 7, 2011
========================================================================
* Corrections:
  Docked toolbar move around when another toolbar gets close to it. (16923) 

========================================================================
C1Command for .NET Build 2/4.0.20113.19498,  Oct, 17, 2011
========================================================================

* Corrections:
 - Select event of a menu does not get fired in Mdi form. (17228)

========================================================================
C1Command for .NET Build 2/4.0.20113.19497,  Oct, 13, 2011
========================================================================

* Corrections:
 - Misc issues with merged menus. (16835, 17480)

========================================================================
C1Command for .NET Build 2/4.0.20113.19496,  Oct, 5, 2011
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Enhanced licensing in environments with some security policy restrictions.

========================================================================
C1Command for .NET Build 2/4.0.20113.19495,  Sep, 26, 2011
========================================================================

* Corrections:
  Menu become disable and Flicking is observed when the menu is unmerges. (16835)
  C1DockingTabs overlaps the toolbar after save and restores the docking tab. (15826)
  
========================================================================
C1Command for .NET Build 2/4.0.20113.19493,  Sep, 12, 2011
========================================================================

* Corrections:
  Sizer cursor is not shown in dual monitor when C1DockingTab is placed in MDI. (16440) 
  Exception is observed when closing Form in MouseUp event. (15661)

========================================================================
C1Command for .NET Build 2/4.0.20113.19492,  Sep, 12, 2011
========================================================================

* Corrections:
  Multiple Issues is observed with C1DockingTab when using C1CommondDock. (14264) 

========================================================================
C1Command for .NET Build 2/4.0.20113.19491,  Sep, 12, 2011
========================================================================

* 2011 v3 Drop

* Corrections:
  Docked toolbar move around when another toolbar gets close to it. (16923) 


========================================================================
C1Command for .NET Build 2/4.0.20112.19490,  Sep, 1, 2011
========================================================================

* Corrections:
	Docking a DockingTab/Page to right or left pushes the StatusBar control 
	and docks the DockingTab/Page in the entire area. (9865)

========================================================================
C1Command for .NET Build 2/4.0.20112.19489,  Jul, 27, 2011
========================================================================

* Corrections:
	While C1ToolBar is placed on C1CommandDock and then C1CommandDock 
	is deleted, at times C1CommandLink remains in the project. (16258)

========================================================================
C1Command for .NET Build 2/4.0.20112.19488,  Jul, 6, 2011
========================================================================

* Corrections:
	Docking a DockingTab/Page to right or left pushes the control placed 
	at top and docks the DockingTab/Page in the entire area. (9865)

========================================================================
C1Command for .NET Build 2/4.0.20112.19487,  Jun, 14, 2011
========================================================================

* Corrections:
	An exception 'Object of type System.EventHandler...' is occurred on using 
	C1ContextMenu in C1TopicBar (15066)

	[C1DockingTab] If “CloseBox” is set to “AllPages” ,  the whole docking tab 
	is closed after close button of one of the docking tab page is click 
	when it is in floating state. (15699)

	[C1DockingTab]Text and images in the tab header are not displayed after 
	setting “CloseBox” property to “AllPages”. (15700)

	[C1DockingTab]Unable to dock although clicking “AutoHide” button after 
	setting “CloseBox” to “AllPages” or “ActivePage”. (15703)

	[C1NavBar]The theme color  of applied “C1NavBar” is not retain at 
	design time after saving and closing the form and opening it again. (15704)

========================================================================
C1Command for .NET Build 2/4.0.20112.19486,  Jun, 10, 2011
========================================================================

* Enhancements\New property:
  New public property of C1NavBar:
        // Represents a set of color properties to customize appearance of C1NavBar. 
		public C1NavBarTheme Theme

        The theme colors are reset when VisualStyle property is changed to a new value.

        Some theme colors have effect only with certain visual styles.
		
		List of the Theme properties, which have effect in Classic, OfficeXP, Office2003 visual styles:
			BorderColor
			ButtonNormalGradientBegin
			ButtonNormalGradientEnd
			ButtonPressedGradientBegin
			ButtonPressedGradientEnd
			ButtonHighlightedGradientBegin
			ButtonHighlightedGradientEnd
			ButtonCheckedGradientBegin
			ButtonCheckedGradientEnd
			ButtonNormalForeColor
			ButtonPressedForeColor
			ButtonHighlightedForeColor
			ButtonCheckedForeColor
			PanelHeaderGradientBegin
			PanelHeaderGradientEnd
			PanelHeaderForeColor
			GripGradientBegin
			GripGradientEnd
			SeparatorNormalColor
			SeparatorLightColor
			SectionHeaderGradientBegin
			SectionHeaderGradientEnd
			SectionHeaderForeColor


		List of the Theme properties, which have effect in WindowsXP visual style:
			BorderColor
			ButtonNormalForeColor
			PanelHeaderForeColor
			ButtonHighlightedGradientBegin
			ButtonHighlightedGradientEnd
			ButtonPressedGradientBegin
			ButtonPressedGradientEnd
			SeparatorNormalColor
			SectionHeaderForeColor

		Note, Theme does not have effect in Office2007, Office2010 visual styles.

========================================================================
C1Command for .NET Build 2/4.0.20112.19485,  Jun, 10, 2011
========================================================================

* Enhancements\New property:

  New public property of C1DockingTab:
    // Gets or sets position of close box.
    public CloseBoxPositionEnum CloseBox

  New public class:
    // Specifies position of close box in locked mode.
    public enum CloseBoxPositionEnum
    {
        // Default position of close box.
        Default,
        // Close box on the active tab.
        ActivePage,
        // Close boxes on the all tabs.
        AllPages,
    }

========================================================================
C1Command for .NET Build 2/4.0.20112.19484,  Jun, 2, 2011
========================================================================

* Corrections:
  - [C1Toolbar] Border is not removed when Border is disabled 
  for Office styles. (15575)

========================================================================
C1Command for .NET Build 2/4.0.20112.19483,  Jun, 1, 2011
========================================================================

* Corrections:
  - Validating event of textbox fired when it is place on the tab and 
  “Auto hiding” button is click. (15521)
  - “ShowCaption” property is not working in c1DockingTab. (15517)
  - C1TopicBar is not refreshed When Changing value of “RightToLeft”  from 
  Property Grid. (14733)
  - Dragging a C1DockingTab outside the Form and double-clicking it to 
  dock it back, positions it at a different location on Form than 
  original. (9204)

========================================================================
C1Command for .NET Build 2/4.0.20111.19482,  May, 24, 2011
========================================================================

* Corrections:
  - Layout is not restored correctly by the ' RestoreLayout' method with 
  StatusStrip control or MenuStrip control. (15402)
  - At RunTime ,”PanelHeaderFont” property is not applied in NavBar panel 
  header. (15436)

========================================================================
C1Command for .NET Build 2/4.0.20111.19481,  May, 23, 2011
========================================================================

* Corrections:
  - Focus does not returned back to the textbox inside C1DockingTab although
   it's validating event is cancelled. (11977)
  - Validating event of TextBox fired for every textbox when it is place 
  on the tab and changing the tab. (14645)
  - The second horizontal toolbar is shown below the first in C1CommandDock 
  at design time. (15133)

========================================================================
C1Command for .NET Build 2/4.0.20111.19480,  May, 9, 2011
========================================================================

* Corrections:
  - Layout is not restored correctly on using RestoreLayout method. (13884) 
  - ToolBar is not shown when it is placed inside C1Sizer. (15047)
  - Label add in the form hide behind the C1DockingTab Page in 
  some scenarios. (14617)

========================================================================
C1Command for .NET Build 2/4.0.20111.19479,  May, 3, 2011
========================================================================

* Corrections:
  - A window in floating state cannot be moved by using a mouse. (14538)
  - C1DockingTab cannot be resized as required. (13751)
  - The position of the container placed on C1DockingTab is automatically 
  changed after close and reopen the form. (13665)

========================================================================
C1Command for .NET Build 2/4.0.20111.19478,  19-Apr-2011
========================================================================

* Corrections:
  - C1DockingTab creates a C1ContextMenu internally and doesn't release it.

========================================================================
C1Command for .NET Build 2/4.0.20111.19477,  8-Apr-2011
========================================================================

* Corrections:
 - Added some JPN translated strings.
 - RestoreLayout with floated tab causes error when dragged. (14929)

========================================================================
C1Command for .NET Build 2/4.0.20111.19476,  24-Mar-2011
========================================================================

* Corrections:
  - [C1DockingTab]‘ArgumentOutOfRangeException’ is thrown after setting 
  ‘ItemSize’ property. (14568)
  - An exception is thrown if the width of a docking tab is reduced when 
  VisualStyle is set to Office2007. (14536 Case 2)
  - Fixed a probable WinForms 4.x designer issue that may occur
  on a machine with multiple installed versions of the same
  designer dll. 

========================================================================
C1Command for .NET Build 2/4.0.20111.19475,  8-Mar-2011
========================================================================

* Fixes: 
  - After scrolling the scroll bar of C1TopicBar,CollapseButtons and 
  Link Images stay in the same position and does not move along with 
  the scrollbar. (14532)

========================================================================
C1Command for .NET Build 2/4.0.20111.19474,  4-Mar-2011
========================================================================

* Fixes: 
  - An exception is thrown if the height of a docking tab is reduced when 
  VisualStyle is set to Office2007. (14536)
  - An exception is thrown when C1ToolBar is used in a multithreaded 
  environment. (13965)
  - Tab is displayed as a cross in red when the form is maximized/minimized. (13820)
  - Menu expands in the upward direction in MDI child form. (13964)

========================================================================
C1Command for .NET Build 2/4.0.20111.19473,  24-Feb-2011
========================================================================

* Fixes: 
  - HitTest method does not respect scroll position of the C1TopicBar. (13457)
 
========================================================================
C1Command for .NET Build 2/4.0.20111.19472,  19-Feb-2011
========================================================================
* Enhancements:
  New methods of C1TopicBar (resolves 13457):
    // Returns information about the control at at the current mouse position
    public C1TopicBarHitTestInfo HitTest()
    //Returns information about the control at a specified point on the control surface.
	public C1TopicBarHitTestInfo HitTest(int x, int y)
	public C1TopicBarHitTestInfo HitTest(Point p)
	 
	New public:
	  enum C1TopicBarHitTestTypeEnum  
	  struct C1TopicBarHitTestInfo

* Fixes: 
  - If a command dock has multiple tabs with CombBoxes, and one combo box 
  is dropped open, then a second tab is clicked on, the first tab migrates 
  to where the click action happened. (14428)

========================================================================
C1Command for .NET Build 2/4.0.20111.19471,  27-Dec-2010
========================================================================

* 2011 v1 Drop

========================================================================
C1Command for .NET Build 2/4.0.20103.19469,  7-Dec-2010
========================================================================

* Fixes: 
  - SaveLayout and RestoreLayout methods of C1DockingTab resizes 
  C1DockingTabPages. (9855)

========================================================================
C1Command for .NET Build 2/4.0.20103.19468,  6-Dec-2010
========================================================================

* Fixes: 
  - Setting “Imageindex” to -1 does not removed the image in C1Docking 
  TabPages at run time. (13579)
  - Floating DockingTabPage docks back on a single click if floated in 
  Form_Load method. (11655)
  - Focus does not returned back to the textbox inside C1DockingTab although
  it's validating event is cancelled. (11977)
  - CloseButton and Collapse Button is not shown in C1NavBar when “VisualStyle” 
  is set to “System” or “WindowXP”. (13551)

========================================================================
C1Command for .NET Build 2.0/4.0.20103.19467,  30-Nov-2010
========================================================================

* Fixes: 
  - Validating event does not fire for controls inside C1DockingTab. (8270)

========================================================================
C1Command for .NET Build 2.0/4.0.20103.19466,  25-Nov-2010
========================================================================

* Fixes: 
  - Minimize/Restore/Close buttons of child form appear hazy & without 
  set VisualStyle on the C1MainMenu when viewed in MDI application. (5491)

========================================================================
C1Command for .NET Build 2.0/4.0.20103.19465,  20-Oct-2010
========================================================================

* Fixes:
   - Accessing C1Command click event in C1ToolBar through Shortcut key calls 
  unhandled exception handler. (8092)
  - [C1ToolBar] Hover style is half rendered on hovering over C1CommandMenus 
  for Office2007/2010 styles in RightToLeft form. (11657)
  - The title of the C1OutPage is cut off when the ‘PageLayout’ property of 
  C1OutBar is not ‘TextOnRight’. (10749)

========================================================================
C1Command for .NET Build 2.0/4.0.20103.19464,  12-Oct-2010
========================================================================

* Enhancements:
  C1DockingTab prevents docking in a floating page if the CanMoveTabs
  of the C1DockingTab is False.

* Fixes:
  - C1ContextMenu don't popup on WebBrowser control. 
  - C1CommandDock keeps unused empty space when a minimized docking tab maximized. (6260)
  - Pinning C1DockingTab inside MDI Form changes the focus of child forms. (6768)
  - ProcessCmdKey() is not working on C1DockingTab control. (7520)
  - Saving Layout of a floating DockingTab with Auto-Hiding set to True, 
    but in pinned mode, restores the layout of the DockingTab in hidden mode. (11532)
  - [C1CommandDock] AllowFloat=false doesn't work with VS2005/VS2008/VS2010 docking styles. 


========================================================================
C1Command for .NET Build 2.0/4.0.20103.19463,  07-Oct-2010
========================================================================

* Enhancements\New property:
  The CollapsedBarText is displayed vertically, when the C1NavBar 
	is collapsed for the all visual styles, not only Office 2010.

  New public property of C1NavBar:
    // Gets or sets a value indicating whether the vertical text is 
	// displayed in collapsed C1NavBar control.
	// Default is false
    public bool ShowVerticalTextOnCollapse;
   
  Added the public setter for the Collapsed property.
  Now you can collapse/expand C1NavBar in the code:
    c1NavBar1.Collapsed = True; // Collapse  

  C1NavBar UIStrings.NavBarOptionsMenuText reflects on the NavBar Options 
	dialog title now.

* Fixes:
  [4.0][C1MainMenu,C1ToolBar,C1OutBar] Visual Studio crash when clicking 
  on the menu item after setting “Text” in the ‘Link To Command’ Designer 
  of C1MainMenu (12988)

========================================================================
C1Command for .NET Build 2.0/4.0.20103.19462,  02-Oct-2010
========================================================================

* Fixed a few issues with floating tab and zone selectors appearance.
 
========================================================================
C1Command for .NET Build 2.0/4.0.20103.19461,  28-Sep-2010
========================================================================

* Enhancements in the C1NavBar Office 2010 Style:

  New public properties and event of C1NavBar
    // Gets or sets the image that is displayed on the header of the active panel.
	public Image PanelHeaderImage;
	// Gets or sets the color to treat as transparent in PanelHeaderImage images.
	public Color PanelHeaderImageTransparentColor;  
	// Occurs when the panel header is clicked.
	public event EventHandler PanelHeaderClick;
	// Occurs when the panel header is double clicked.
	public event EventHandler PanelHeaderDoubleClick
	// Occurs when the panel header image is clicked.
	public event EventHandler PanelHeaderImageClick

  New UI string:
    CollapsedBarText - The text displayed vertically, when the C1NavBar is collapsed.
	Note: This text appears only in Office2010 style.

 Other Office2010 style - related changes:
  - new panel header collapse arrow design;  
  - the splitter for stacking buttons has a different design;
  - the buttons have new hover states and active states;
  - when collapsed the CollapsedBarText is displayed vertically.

* New docking styles: Visual Studio 2008 and Visual Studio 2010 - like docking:
    public enum DockingStyle
    {
       Default,
       VS2005,
       VS2008,
	   VS2010,
    }

* New public property of C1OutPage:

    public bool IsHot {get;}
    Gets a value indicating whether the mouse pointer is located over 
    caption area of the page.

* New public method of C1DockingTab:

    public bool IsHot(C1DockingTabPage page)
    Returns true if the specified tab is in the hot state, otherwise false.

========================================================================
C1Command for .NET Build 2.0/4.0.20102.19460,  02-Sep-2010
========================================================================

* New public property on C1DockingTabPage:

    public bool IsHot {get;}
    Gets a value indicating whether the mouse pointer is located over 
    tab area of the page.
    
 * Fixed:
    Problems with automatic build. (12495)
    
========================================================================
C1Command for .NET Build 2.0/4.0.20102.19458,  08-Jul-2010
========================================================================
 * Fixed:
   TabPage window disappears when docked in any container in case of 
   "DockingStyle" set as "VS2005". (10373)
   
   Arrow keys cannot be set as shortcut key combination in C1MainMenu 
   and C1ToolBar. (11380)
   
   "More" button remains as ">>" instead of "<<" on setting "RightToLeft"
   to True in C1ToolBar. (11389)
   
   Multiple issue with "More" button in C1MainMenu. (11391)

========================================================================
C1Command for .NET Build 2.0/4.0.20102.19457,  22-Jun-2010
========================================================================
 * Fixed:
   C1DockingTab throws NullRefernceException when MS TextBox is placed on 
   a tab page and "Image" property of the tab page is set. (11130)
   
   Tabs can still be selected when ShowTabs property is false at deisgn 
   time as the in-place editing. (11127)
   
========================================================================
C1Command for .NET Build 2.0/4.0.20102.19456,  2-Jun-2010
========================================================================

New features
------------

* New public property on C1DockingTab:

    public bool ShowTabs {get;set;}
    Gets or sets whether tabs area is displayed within the C1DockingTab.

* New public event on C1DockingTab:

	public event EventHandler ShowTabsChanged
	Occurs when the ShowTabs property is changed.

Office 2010 schemes:
	
* New values in the VisualStyle enum:
  - Office2010Blue - MS Office 2010 Blue color scheme.
  - Office2010Black - MS Office 2010 Black color scheme.
  - Office2010Silver - MS Office 2010 Silver color scheme.
  
* New value in TabStyleEnum:
  - Office2010 - MS Office 2010 Tab style.  

 
========================================================================
C1Command for .NET Build 2.0/4.0.20102.19455,  24-May-2010
========================================================================
 * Fixed a JPN localization issue. (10932) 

========================================================================
C1Command for .NET Build 2.0/4.0.20102.19453,  20-May-2010
========================================================================
 * 2010 V2 release.

========================================================================
C1Command for .NET Build 2.0/4.0.20101.19452,  11-May-2010
========================================================================
 * Fixed:
   C1Command gets licensed with Reports for .NET Designer Edition keys. (10777)
   
 * A few strings localized in JPN version. 
 
========================================================================
C1Command for .NET Build 2.0/4.0.20101.19450,  7-May-2010
========================================================================
 * Fixed:
   “Object reference not set to an instance of an object” is thrown when 
   removing Topic Page from TopicBar by code using 'FindPageByTag' (10372)

   [FW 4.0] Standard Commands are not contain in list box of  
   ‘Link To Command’ Designer. (10346)

   [FW 4.0] C1Command object is not created using "Link to Command" editor. (10235)


========================================================================
C1Command for .NET Build 2.0/4.0.20101.19449,  14-Apr-2010
========================================================================
 * C1Command control designers has been moved to a separate dll 
 in the version for .NET 4.0. 
 * Target framework of C1Command 4.0.20101.19449 is changed to 
 .Net Framework 4.0 Client Profile.

========================================================================
C1Command for .NET Build 2.0.20101.19448,  7-Mar-2010
========================================================================
 * Fixed:
   If a docking tab/page is moved (VS2005 docking style) and is placed 
   over a docking zone selector while the mouse is still pressed, 
   then pressing Ctrl key after this and leaving the mouse button 
   still docks the page. (9281)

   [Docking] Order of the pages reverses (9227 case2)    
   
   Moving a C1DockingTabPage outside the docking tab and docking it back 
   by double-clicking on the title area does not bring it in focus. (9529)
   
   SelectedIndexChanging/Changed events fire multiple times when floating 
   C1DockingTab containing a merged DockingTab is docked back. (9264)
   
   Docking a page to right of a docking tab docks it to left. (9277)
   
========================================================================
C1Command for .NET Build 2.0.20101.19447,  4-Mar-2010
========================================================================
 * Fixed:
   Misc issues when 'Fill' button of docking zone selector is chosen. (9227)
   
========================================================================
C1Command for .NET Build 2.0.20101.19446,  3-Mar-2010
========================================================================
 * Fixed:
   In WinXP and Windows Classic theme, no shadows are created of the 
   floating docking tab/page when a button of docking zone selector is 
   chosen before releasing the mouse. (9231)
   
========================================================================
C1Command for .NET Build 2.0.20101.19445, 23-Feb-2010
========================================================================
 * Fixed:
   MissingManifestResourceException occurs in C1DockingTab control
   if DockingStyle is VS2005.
   
========================================================================
C1Command for .NET Build 2.0.20101.19444, 19-Feb-2010
========================================================================
 * Some fixes in the "Visual Studio 2005 docking style" feature.

========================================================================
C1Command for .NET Build 2.0.20101.19443, 18-Feb-2010
========================================================================

* Licensing code updated

* New feature: Visual Studio 2005 docking style.
   The docking style feedback is similar to VS 2005, using docking zone 
   selectors to specify where the dragged view will be docked if you release it.
   
   New public enumeration
	   DockingStyle ( Default, VS2005 ).
   If the DockingStyle property is set to Default, 
   docking works without the selectors: when you drag a floating panel over another panel, 
   a gray frame appears to show you the position that the instance of C1DockingTab will 
   have once you release it.

   The VS2005 docking style feedback is similar to Visual Studio 2005, using docking zone 
   selectors to specify where the dragged view will be docked if you release it.
   
   New public property
       C1CommandDock.DockingStyle. 
   This property stores the enumerator value from DockingStyle. 
   DockingStyle has two styles: Default and VS2005. 
   By default, it is set to the Default style.
     
========================================================================
C1Command for .NET Build 2.0.20093.19441, 25-Nov-2009
========================================================================
New features
------------
  * New public property on C1ContextMenu
  
        public Control SourceControl {get;}
		      Gets the control that is displaying the shortcut menu.

========================================================================
C1Command for .NET Build 2.0.20093.19440, 29-Oct-2009
========================================================================
Fixed:
  * InvalidOperationException thrown on resizing C1CommandDock when 
  threading is used to invoke new form. (7236)

========================================================================
C1Command for .NET Build 2.0.20093.19439, 12-Oct-2009
========================================================================
  * Updated assembly attributes.
  * Updated licensing code.

========================================================================
C1Command for .NET Build 2.0.20093.19438, 21-Sep-2009
========================================================================
  * Fixed:
  Tab key does not set focus to CommandControl inside the toolbar.(5954)
  
  * New toolbox icons.
 
========================================================================
C1Command for .NET Build 2.0.20093.19437, 10-Sep-2009
========================================================================
  * Fixed:
  Tab page does not close when the validating events is fired for the controls placed inside the C1DockingTab. (4338)

========================================================================
C1Command for .NET Build 2.0.20092.19434, 20-Aug-2009
========================================================================
  * PublicKeyToken revert:
  The public key of C1.Win.C1Command.2 2.0.20092.19431-19433 was different from what it was in 2009.V1. 
  This causing the LICX file (with previous entry) failing to recognize the newer build.
  The error was - "The located assembly manifest definition doesn't match the assembly reference".
  Current version reverts the public key to the original.
  
  If you face with the problem "The located assembly manifest definition doesn't match the assembly reference",
  just strip public key information in the licenses.licx, 
  or edit, correct PublicKeyToken is:
  PublicKeyToken=e808566f358766d8

========================================================================
C1Command for .NET Build 2.0.20092.19433, 16-Jul-2009
========================================================================
Bug fixes
---------
 *  Nag screen shown for a licensed C1MainMenu at runtime. (5376)

========================================================================
C1Command for .NET Build 2.0.20092.19432, 30-Jun-2009
========================================================================
Bug fixes
---------
 * ShortcutKey handler is not called for an item of C1ToolBar from a textbox inside the toolbar. (4538)
 * Shortcut keys do not work after merging command links. (4870)
 * "Failed to create component 'C1NavBar'" error thrown on dropping C1NavBar on the form. (4882)
 * Property Descriptions do not show in proper manner in the property grid. (4883)
 * VisualStyle of C1CommandHolder does not reflect on a merged C1MainMenu. (4881)

========================================================================
C1Command for .NET Build 2.0.20092.19431, 16-Jun-2009
========================================================================
  * New licensing code.

========================================================================
C1Command for .NET Build 2.0.20091.19429, 29-Apr-2009
========================================================================

Enhancement
-----------
  * Speed up of menu animation.

Fixed
-----------
  * If C1CommandHolder.Animation=System and system uses Fade effect for menus,
  c1command slides menus istead of using fade effect.
 

========================================================================
C1Command for .NET Build 2.0.20091.19428, 23-Mar-2009
========================================================================
Localization:
---------
 * "C1TopicBar can’t be a parent of any child control." localized in JPN version.

========================================================================
C1Command for .NET Build 2.0.20091.19425, 03-Mar-2009
========================================================================
Bug fixes
---------
 * [Runtime] Move toolbar(s) inside CommandDock and reduce form size causes toolbar(s) rearranged to original positon (#19326)
 * Toolbar flickers on reduce form size (resize by cursor).
 * CommandLinks disappear on a toolbar on reduce form size (resize by cursor) if the toolbar has Wrap=true.

========================================================================
C1Command for .NET Build 2.0.20091.19424, 25-Feb-2009
========================================================================
Bug fixes
---------
 * [Design Time] Once toolbar inside C1CommandDock is moved to new position, not able to placed back to original position (#19329)

========================================================================
C1Command for .NET Build 2.0.20091.19423, 18-Feb-2009
========================================================================
Bug fixes
---------
 * Inconsistency in C1Toolbar's layout inside C1CommandDock after form resizing (#18989)

========================================================================
C1Command for .NET Build 2.0.20091.19421, 16-Jan-2009
========================================================================
Bug fixes
---------
 * Disabled commandlinks appear in place of arbitrary controls in C1Toolbar on pressing 'Cancel' button of Customize dialog box. #9447

========================================================================
C1Command for .NET Build 2.0.20083.19419, 22-Dec-2008
========================================================================
Bug fixes
---------
 * Submenus of C1MainMenu opened on Secondary monitor show up on Primary screen in Dual Monitor Environment. (#18681)

========================================================================
C1Command for .NET Build 2.0.20083.19417, 10-nov-2008
========================================================================
Bug fixes
---------
 * A single C1CommandLink added in a C1Toolbar is not visible at runtime. (#18496)
 * LinkClick Event fires twice for C1TopicBar when the visibility of the link is set to False (#18477)
 
========================================================================
C1Command for .NET Build 2.0.20083.19416, 26-oct-2008
========================================================================
New features
------------

* New public methods on C1DockingTabPage:
    public void Float()
		Floats the page out from the form to a default position.
    public void Float(Point position)
		Floats the page out from the form to the specified position.
	public void Float(int x, int y)
		Floats the page out from the form to the specified coordinates.
		
	public void DockTo(C1DockingTabPage targetPage)
		Docks the page to the another target page.
		The page becomes the next page after the target page.
	public void DockTo(C1DockingTab targetDockingTab)
		Docks the page to the target DockingTab.
		The page becomes the first page at the target DockingTab.

* New public methods on C1DockingTab
	public void Float(C1DockingTabPage tabPage)
		Floats the page out from the form.
	public void Float(C1DockingTabPage tabPage, Point position)
		Floats the specified tab page out from the form to the specified screen position.	
	public void Float(C1DockingTabPage tabPage, int x, int y)
		Floats the specified tab page out from the form to the specified screen coordinates.	
		
Bug fixes
---------
  * On closing all tab pages of DockingTab at runtime, DockingTab becomes invisible. (#9774)
  * On changing C1Toolbar Location, C1ToolBar repositions itself to original position. (#17754)
  * [Vista-Aero] C1DockingTabPage does not appear when mouse is hovered over pages of DockingTab in auto-hide state in Vista. (#17259)
   
========================================================================
C1Command for .NET Build 2.0.20082.19414, 01-oct-2008
========================================================================
   * Fixed 
     A Memory Leak. It was in the all c1command controls.

========================================================================
C1Command for .NET Build 2.0.20082.19413, 07-September-2008
========================================================================
   * Fixed 
     A null-reference error occured when edit collection of tab pages in C1DockingTab.
     
========================================================================
C1Command for .NET Build 2.0.20082.19412, 29-May-2008
========================================================================

 * No changes in English version.

========================================================================
C1Command for .NET Build 2.0.20082.19410, 27-May-2008
========================================================================

 * No changes in English version.

========================================================================
C1Command for .NET Build 2.0.20082.19409, 20-May-2008
========================================================================

Bug fix
---------
 * C1OutBar animation does not draw correct under Vista Aero theme. #9789

========================================================================
C1Command for .NET Build 2.0.20082.19408, 15-May-2008
========================================================================

Bug fixes
---------
  * Tab DropDown list becomes empty when ShowTabList drop down button is double clicked. (#9791)

Enhancement
-----------
  * Padding property of C1DockingTabPage in C1DockingTab does work. (#17128)

========================================================================
C1Command for .NET Build 2.0.20082.19406, 11-May-2008
========================================================================

Bug fixes
---------
  * Draggable window of C1DockingTab doesn't dock back under Vista.
  * C1DockingTab hides when C1Ribbon selected.
  The fix will work with 92 build of C1Ribbon and upper.
   
Enhancement
-----------
  * C1DockingTab restoring to original position on double-click on header of draggable window.

========================================================================
C1Command for .NET Build 2.0.20082.19404, 28-Apr-2008
========================================================================

* 2008 V2 release.

Bug fixes
---------

* Controls do not re-appear in the C1Toolbar after rechecking the option in Add or Remove Drop Down list if the ToolBar is shifted towards Form's edge. (VNCMD000699)
* On setting the visibile property of CommandButton in C1TooBar to False, the corresponding CommandLink still appears checked in Add or Remove Button. (VNCMD000682)
* C1SuperToolTip for a C1DockingTab is not shown in the tab area for a docked tab page. (VNCMD000695)
* When a DockingTab is inside of a CommandDock, the CommandDock hides the animation does not draw correctly under Vista Aero theme. (VNCMD000701)
* Outline frame of C1DockingTab draws too slow on Vista Aero theme. (VNCMD000702)
* Adding a TopicPage to collection of pages of C1TopicBar on LinkClick event of C1TopicLink throws error. (VNCMD000688)
* FindActiveHolderC1DockingTab, C1NavBar, C1MainMenu and C1Toolbar throwing error while implemented in a MultiThreading Application (VNCMD000681)

========================================================================
C1Command for .NET Build 2.0.20081.19402, 18-Mar-2007
========================================================================

* 2008 V1 release.

Bug fixes
---------

* Fixed a memory leak which occurred during menu merge.

* If one of several docking tabs in a C1CommandDock were made invisible 
  and then visible again by the user, it became 1/2 smaller each time. 
  Fixed.

* Improved the positioning of movable toolbars on a C1CommandDock when a 
  toolbar was moved around.

* If a container with a movable C1ToolBar was disabled, the drag anchor 
  on the toolbar was hidden. This lead to unnecessary flickering of the 
  toolbars on the form. Now the drag anchors are not hidden in this 
  situation.

* When auto-docking, sometimes the C1DockingTab was incorrectly drawn 
  over a status bar on the form. Fixed.

* C1TopicLink: fire the Click event only if the left mouse button was 
  clicked.

========================================================================
C1Command for .NET Build 2.0.20073.19307, 31-Dec-2007
========================================================================

Bug fixes
---------

* If an arbitrary control is embedded in a C1ToolBar (via 
  C1CommandControl), and the TabStop property on that control is set to 
  false, it is now skipped when the toolbar has focus, and the Tab key 
  is pressed.

========================================================================
C1Command for .NET Build 2.0.20073.19306, 06-Nov-2007
========================================================================

* 2007 T3 release.

Bug fixes
---------

* RightToLeft is now correctly supported by all C1Command controls.

* Miscellaneous bug fixes.

New features
------------

* New public method on C1ContextMenu:
    public void CloseContextMenu();
      Closes the currently open context menu if there is one.

* VisualStyle property's behavior enhancement: controls which do not
  have VisualStyle explicitly specified will now inherit the style from
  the closest parent that has VisualStyle set, or from the command
  holder.

========================================================================
C1Command for .NET Build 2.0.20072.19210, 09-Jul-2007
========================================================================

Bug fixes
---------

* Fixed a C1NavBar painting issue when System visual style was used.

* Fixed a problem with C1OutBar painting when its Anchor property was
  set to top or bottom, and the form was resized at runtime.

========================================================================
C1Command for .NET Build 2.0.20072.19209, 22-Jun-2007
========================================================================

* 2007 T2 release.

Bug fixes
---------

* Miscellaneous bug fixes.

* Accessibility: tracking menus was not picked up by screen readers
  such as Narrator. Fixed.

* If a C1DockingTab or C1OutBar is on a transparent form, animation is
  disabled.

New features
------------

* New public property on C1DockingTab:

    public Keys DockPreventModifierKey {get;set;}

      Gets or sets modifier key which, if pressed, will prevent the
      floating control from docking when it is moved around at runtime.
      Remarks: If several modifier keys are specified, pressing any one
      will prevent docking.

* New public enum VisualStyle, Determines the visual style of a control.
  Has the following members:
  - Custom - Custom style.
  - System - Standard system style.
  - Office2007Blue - MS Office 2007 Blue color scheme.
  - Office2007Black - MS Office 2007 Black color scheme.
  - Office2007Silver - MS Office 2007 Silver color scheme.
  - Office2003Blue - MS Office 2003 Blue color scheme.
  - Office2003Olive - MS Office 2003 Olive color scheme.
  - Office2003Silver - MS Office 2003 Silver color scheme.
  - OfficeXP - MS Office XP color scheme.
  - Classic - Classic color scheme.
  - WindowsXP - Windows XP color scheme.

  New public property added to C1CommandHolder:

  public VisualStyle VisualStyle {get;set;}

    Gets or sets the visual style of all C1Command controls on the form
    (can be overridden by individual controls).

  New public property added to C1MainMenu, C1CommandMenu, C1ToolBar,
  C1DockingTab, C1NavBar, C1OutBar, C1TopicBar:

  public VisualStyle VisualStyle {get;set;}

    Gets or sets the visual style of the control.

  The VisualStyle property and enumeration supersede the
  LookAndFeel/LookAndFeelEnum property and enumeration, which are now
  obsolete.

* C1DockingTab: new public property:

  public bool KeepClosedPages {get;set;}

    Gets or sets a value indicating whether a tab page closed by the end
    user should be kept in an internal array (used when a previously
    saved tabs layout is restored). The default is true.

* C1NavBar: new public members:

  public C1NavBarCloseButtonEnum CloseButton {get;set;}

    Gets or sets a value indicating whether the close button is shown in
    panel caption, and what is closed when it is clicked.

  public bool AllowCollapse {get;set;}

    Gets or sets a value indicating whether the collapse button is
    visible.

  public CollapseDirectionEnum CollapseDirection {get;set;}

    Gets or sets a value indicating the direction in which to collapse
    the control.

  public bool Collapsed {get;}

    Gets the value indicating whether the control is currently in a
    collapsed state. (Runtime-only.)

  public bool ShowOptionsMenu {get;set;}

    Gets or sets a value indicating whether the runtime options menu is
    visible.

  public event CancelEventHandler CloseButtonClick {add;remove;}

    Occurs when the close button on the panel header is clicked.

  public event CancelEventHandler CollapseButtonClick {add;remove;}

    Occurs when the collapse button on the panel header is clicked.
    Allows to cancel collapsing.

  public event PanelCancelEventHandler PanelClosing {add;remove;}

    Occurs when the currently selected panel is about to be closed by
    the user. Allows to cancel closing the panel.

  public event PanelEventHandler PanelClosed {add;remove;}

    Occurs after a panel has closed.

  public event EventHandler ShowOptionsMenuChanged {add;remove;}

    Occurs when the ShowOptionsMenu property is changed.

  public event EventHandler AllowCollapseChanged {add;remove;}

    Occurs when the AllowCollapse property is changed.

  public event EventHandler CollapseDirectionChanged {add;remove;}

    Occurs when the CollapseDirection property is changed.

  public event EventHandler CloseButtonChanged {add;remove;}

    Occurs when the CloseButton property is changed.

========================================================================
C1Command for .NET Build 2.0.20071.19105, 08-Feb-2007
========================================================================

Bug fixes
---------

* Miscellaneous design time fixes.

* The Text property of C1NavBar buttons was not localizable. Fixed.

* Fixed a problem with painting anchored C1OutBar when the form is
  resized.

* Fixed side menu caption painting issues when it did not fit in the
  menu.

* Multiple ampersands in a command text all appeared underlined. Fixed.

* Fixed a painting problem when expanding a topic page using XP look.

* Fixed an issue with image layout when using C1DockingTab's sloping
  style when there was not enough space for the tab.

========================================================================
C1Command for .NET Build 2.0.20071.19104, 26-Jan-2007
========================================================================

Object model changes
--------------------

* C1NavBar object model was changed in a backwards-INCOMPATIBLE way. In
  the previous versions of C1Command, the C1NavBar contained two
  separate editable collections: Panels and Buttons. Each panel had to
  have a corresponding button, the correspondence between the two was
  established via the ID property set on the panel and the corresponding
  button. Buttons were explicitly created and added to the Buttons
  collection. Starting with this build, this was changed. The Buttons
  colleciton is no longer editable. A button is automatically created on
  the panel when that panel is created, and can NOT be created
  standalone. The Buttons collection can no longer be edited at design
  time, the buttons' properties can be set via the Button property of
  the panel (panels are accessible at design time via the Panels
  collection, as before). (The Buttons collection can be accessed for
  enumerating and editing the buttons' properties at run time though.)
  Buttons' properties are now persisted as panel.Button.<property-name>
  in the InitializeComponent code. The IndexOf method on both
  collections (Panels and Buttons) was changed - it now accepts an
  object, and returns the index of the specified panel or button. The
  old IndexOf (which accepted int ID as the parameter) was renamed to
  IndexOfID.

  Because the changes are backwards-incompatible, existing code using
  C1NavBar will have to be changed. The following steps should allow you
  to convert existing InitializeComponent code to work with the new
  version of C1NavBar:

  (1) In InitializeComponent(), remove explicit construction of
  C1NavBarButton objects:

  C1.Win.C1Command.C1NavBarButton c1NavBarButton1 = new C1.Win.C1Command.C1NavBarButton();

  (2) Locate the lines assigning buttons' and panels' ID, such as:

  c1NavBarButton1.ID = 1;
  ...
  this.c1NavBarPanel4.Button.ID = 1;

  In the old model, correspondence between panels and buttons was
  established via IDs, so note which button corresponds to which panel,
  you will need this info when changing the lines assigning properties
  to buttons.

  (3) Locate the line or lines adding buttons to the C1NavBar, those
  should look similar to this:

  this.c1NavBar1.Buttons.AddRange(new C1.Win.C1Command.C1NavBarButton[]{
    c1NavBarButton1,
    c1NavBarButton2,
    c1NavBarButton3,
    c1NavBarButton4});

  Delete this line or lines (buttons always exist on panels, and need
  not be explicitly added).

  (4) Change the way buttons are referenced in the properties'
  assignments. For each button, whenever it is referenced in a property
  assignment, instead of direct referencing the button variable (those
  were deleted in step 1 above), reference the button via its panel
  instead. (Which panel corresponds to which button was determined by
  IDs, you should have this info from step 2 above.) So e.g. if
  c1NavBarButton1 corresponded to c1NavBarPanel1, replace all
  occurrences of "this.c1NavBarButton1" with
  "this.c1NavBarPanel1.Button", e.g. instead of

  c1NavBarButton1.Image = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton1.Image")));

  you will have

  c1NavBarPanel.Button.Image = ((System.Drawing.Image)(resources.GetObject("c1NavBarButton1.Image")));

  Repeat this for all button properties' assignments EXCEPT assignments
  of IDs - just delete those lines, as buttons' IDs are determined by
  the panels they belong to.

  (5) Finally, remove lines adding panels to the C1NavBar's Controls
  collection - this is no longer needed as adding panels to the Panels
  collection automatically adds them to the Controls collection as well.
  I.e. lines like the following:

  this.c1NavBar1.Controls.Add(this.c1NavBarPanel4);

  should be deleted.

  This completes the process, now the project should build and run with
  the new version of C1Command.

* The method C1NavBarPanel C1NavBarPanel.PanelCollection.FindID(int id)
  threw an exception when the specified panel was not found. Now it
  returns null.

* The C1NavBar.ButtonClick event was raised whenever the panel selected
  in the C1NavBar changed. Now this event only fires on actual button
  clicks. A new public event C1NavBar.SelectedPanelChanged was added
  inseted, it fires whenever the selected panel changes.

Bug fixes
---------

* Japanese localization fixes.

* Miscellaneous design time fixes.

* Miscellaneous C1NavBar issues fixed due to the object model change.

* Fixed incorrect layout of C1DockingTab with only one page, TabSizeMode
  set to FillToEnd, and not enough space for the tab.

* Fixed: floating toolbars were not hidden when the corresponding MDI
  child form was minimized.

========================================================================
C1Command for .NET Build 2.0.20071.19008, 04-Jan-2007
========================================================================

* 2007 T1 release.

* New intuitive designers provided for all controls in the suite.

* Miscellaneous bug fixes.

========================================================================
C1Command for .NET Build 1.0.20063.18008, 27-Oct-2006
========================================================================

Bug fixes
---------

* Miscellaneous bug fixes.

========================================================================
C1Command for .NET Build 1.0.20063.18007, 08-Sep-2006
========================================================================

Bug fixes
---------

* Fixed a C1NavBar repainting issue when the control is docked and its
  parent is resized.

* Fixed issue: KeyUp event of the TextBox did not get fired when placed
  in a C1ToolBar.

========================================================================
C1Command for .NET Build 2.0.20063.18006, 05-Sep-2006
========================================================================

New features
------------

* Added accessibility features to C1Command components.

* New controls added to the suite: C1NavBar, C1TopicBar.

* C1DockingTab: if focus is inside the docking tab, pages can be
  switched by pressing hot key combinations Alt+<letter>, where letter
  is a letter of the tab caption prefixed by an ampersand.

* New public property:
    bool C1DockingTab.ShowTabList {get;set;}
  Gets or sets the value indicating whether to show a button with
  dropdown list of all tabs (ignored in multiline mode).

  New event: C1DockingTab.ShowTabListChanged.

* New public property:
    C1ContextMenu C1Command.C1ContextMenu {get;set;}
  Gets or sets the C1ContextMenu component associated with this command.

* New public method:
    C1DockingTab[] C1DockingTab.GetCreatedDockingTabs();

  Returns the collection of all C1DockingTab components that were
  automatically created as the result of user interaction with the
  current C1DockingTab (e.g. when a page is teared off and dropped to
  float outside of the form).

  Return value: The array of automatically created C1DockingTab
  controls.

* New public property:
    bool C1CommandMenu.CloseOnItemClick {get;set;}
  Gets or sets the value indicating whether to close the menu when an
  item is clicked.
  The default is true. This property allows to created menus with the
  functionality of check lists, where multiple items can be checked or
  unchecked as needed, without the menu closing.

Bug fixes
---------

* Miscellaneous bug fixes.

========================================================================
C1Command for .NET Build 2.0.20062.17012, 17-Apr-2006
========================================================================

New features
------------

* New public indexer added to C1Commands, C1DockingTabPages, C1OutPages
  collections:
    C1Command C1Commands.this[string key] {get;}
    C1DockingTabPage C1DockingTabPages.this[string key] {get;}
    C1OutPage C1OutPages.this[string key] {get;}
  where the key parameter corresponds to the Name property of the
  component (command, docking tab or out page).

Bug fixes
---------

* Multiple bug fixes (see the list of fixes for build 1.0.20062.172 in
  the readme-dotnet_1.txt file).

========================================================================
C1Command for .NET Build 2.0.20062.17011, 21-Mar-2006
========================================================================

* 2006 T2 build.

* At design time, menu/toolbar items' texts can be edited in-place.
  For this, highlight the item (either with the mouse or with the
  keyboard), and press Enter to activate the in-place editor. Press
  Enter again to finish editing and accept changes, or Esc to cancel
  changes.

* Please see the readme-dotnet_1.txt file for details on new features
  common to .NET 1.* and 2.0 versions.

========================================================================
C1Command for .NET Build 2.0.20061.15050, 15-Dec-2005
========================================================================

* 2006 T1 build.

========================================================================
C1Command for .NET Build 2.0.20053.15030, 15-Dec-2005
========================================================================

* Multiple bug fixes (see the list of fixes for build 1.0.20053.149 in
  the readme-dotnet_1.txt file).

========================================================================
C1Command for .NET Build 2.0.20053.139, 3-Nov-2005
========================================================================

* First public .NET 2.x release.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
The End.
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
