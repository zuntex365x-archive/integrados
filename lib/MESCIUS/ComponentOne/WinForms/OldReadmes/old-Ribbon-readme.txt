==================================================================
C1Ribbon                  ComponentOne, LLC - www.componentone.com
==================================================================

Welcome to ComponentOne Ribbon.

ComponentOne Ribbon is an integral part of Studio Enterprise, the
largest and most complete toolset for developing Win, Web, Mobile
and ASP.NET AJAX enabled applications.

Please direct feedback for C1Ribbon to the following forum:

http://our.componentone.com/groups/winforms/ribbon-for-winforms/forum/

- Support and Feedback Options

ComponentOne is dedicated to providing reliable best-of-breed
components. If you have any issues using our products, we want
to know about it. Please use the following pages for information
to get support:

http://www.componentone.com/SuperProducts/SupportServices/

To submit a support request, report a bug, or request a feature,
please use our online Incident Submission Form. Note that we ask
you to be logged into your ComponentOne Account to submit an incident.

Login or Create an Account: http://www.componentone.com/Members/

- Installed Files

ComponentOne Ribbon installs the following files and components.

 Files: C1.Win.C1Ribbon.2/4.dll, C1.Win.C1Ribbon.2/4.XML,
        C1.Win.C1Ribbon.4.Design.dll

Components: C1Ribbon, C1StatusBar, C1RibbonForm
------------------------------------------------------------------

History of Changes
==================================================================
C1Ribbon Build 2/4.0.20142.597         Build Date: October 6, 2014
==================================================================

- Fixed an issue that causes a StackOverflow exception in
  Doc-To-Help when a user changes the current theme in Windows 7
  from Aero to Classic.

==================================================================
C1Ribbon Build 2/4.0.20142.596      Build Date: September 26, 2014
==================================================================

- Fixed a regression issue introduced in build 584: Resizable
  form borders don't appear after switching VisualStyle from
  Office2010Blue to Custom for a C1RibbonForm.

- Fixed an issue in RibbonNumericBox/RibbonTimePicker: Setting
  the GapBeforeTextArea property causes a NullReferenceException
  when the owner form's VisualStyle is set to Custom.

==================================================================
C1Ribbon Build 2/4.0.20142.595      Build Date: September 25, 2014
==================================================================

- Fixed an issue that causes incorrect layout of the main form
  in Doc-To-Help when the screen resolution is set to 1024x768.

==================================================================
C1Ribbon Build 2/4.0.20142.594      Build Date: September 24, 2014
==================================================================

- Fixed an issue introduced in build 519: Setting the WindowState
  property of C1RibbonForm to 'Maximized' or 'Minimized' before
  updating the Bounds property within the Form.Load event causes
  incorrect layout of C1RibbonForm at the program startup.

==================================================================
C1Ribbon Build 2/4.0.20142.593      Build Date: September 19, 2014
==================================================================

- Fixed an issue: Items beyond the width of the screen are not
  accessible when a large number of items are added to QAT
  (TFS 87356).

==================================================================
C1Ribbon Build 2/4.0.20142.592      Build Date: September 11, 2014
==================================================================

- An attempt to avoid System.NullReferenceException that occurs
  in C1.Win.C1Ribbon dll after resizing the Gallery dropdown in
  VSTO project, then closing the app (TFS 84826).

==================================================================
C1Ribbon Build 2/4.0.20142.591      Build Date: September 10, 2014
==================================================================

- Fixed an issue: MouseLeave event is fired for a RibbonTab when
  the user clicks the tab (TFS 84685).

- Fixed an issue: Switching Windows Theme from Aero to Classic
  then activating a C1RibbonForm with C1Ribbon causes incorrect
  appearance of the Form title bar (TFS 85249).

- Fixed an issue: Dropdown part of RibbonComboBox keeps opening
  on switching a ribbon tab in VSTO project (TFS 84847).

==================================================================
C1Ribbon Build 2/4.0.20142.590       Build Date: September 2, 2014
==================================================================

- Fixed an issue: MouseLeave event is fired even when the mouse
  is not moved from the RibbonButton (TFS 84293).

==================================================================
C1Ribbon Build 2/4.0.20142.589         Build Date: August 26, 2014
==================================================================

- Fixed an issue: Click event is not fired for RibbonButton after
  an unsuccessful attempt to move input focus to that button and
  displaying a messagebox in the LostFocus event (TFS 83353).

==================================================================
C1Ribbon Build 2/4.0.20142.588         Build Date: August 25, 2014
==================================================================

- Fixed an issue: RibbonMenu does not close on navigating to the
  Desktop using 'Windows + D' keys (TFS 83147).

==================================================================
C1Ribbon Build 2/4.0.20142.587         Build Date: August 21, 2014
==================================================================

- Fixed an issue: NullReferenceException is thrown when a
  MessageBox is displayed on switching between the minimized
  RibbonTabs using KeyTips (TFS 82653).

==================================================================
C1Ribbon Build 2/4.0.20142.586           Build Date: July 21, 2014
==================================================================

- Fixed an issue: KeyTips are shown even when C1RibbonForm is
  a minimized MDI child form (TFS 76310).

==================================================================
C1Ribbon Build 2/4.0.20142.585           Build Date: July 19, 2014
==================================================================

- Addressed an issue: Application terminates on changing Windows
  theme from 'Basic' to 'Aero' (TFS 75769).

==================================================================
C1Ribbon Build 2/4.0.20142.584           Build Date: July 16, 2014
==================================================================

- Fixed an issue: KeyTips don't hide when the user resizes the
  C1RibbonForm with VisualStyle set to Custom (TFS 72494).

- Fixed an issue: Unable to localize GrapeCity build of C1Ribbon
  for Chinese (TFS 73880).

- Addressed an issue: When a C1RibbonForm (with VisualStyle set
  to Custom) is set as the owner form other forms, on minimizing
  the owner form and restoring, it does not correctly renders the
  owned forms (TFS 74255).

- Fixed an issue: RibbonMenu dropdown does not open correctly on
  a dual monitor machine (TFS 74345).

==================================================================
C1Ribbon Build 2/4.0.20142.583            Build Date: July 3, 2014
==================================================================

- A very small internal change that may affect the issue in
  Doc2Help (see TFS 70578).

==================================================================
C1Ribbon Build 2/4.0.20142.582           Build Date: June 27, 2014
==================================================================

- Fixed an issue: The layout of RibbonTab is not updated in one
  specific case that is described in the following forum thread:
  http://our.componentone.com/groups/topic/c1ribbonform-
  nullreferenceexception-in-form-dispose/#post-627854

==================================================================
C1Ribbon Build 2/4.0.20142.581           Build Date: June 25, 2014
==================================================================

- Fixed an issue: RichTextBox shows Chinese symbols when
  C1Ribbon.SupportsKeyTips property is set to true and the user
  presses the Alt key, types a number on the numeric pad, then
  releases the Alt key (TFS 71789).

==================================================================
C1Ribbon Build 2/4.0.20142.580           Build Date: June 24, 2014
==================================================================

- Fixed a regression issue: RibbonGallery items are not updated
  correctly when the item image is changed from code while the
  gallery popup is visible (TFS 68994).

==================================================================
C1Ribbon Build 2/4.0.20141.578           Build Date: June 18, 2014
==================================================================

- Fixed an issue: after changing WindowState of an ActiveMdiChild
  window within a handler for C1Ribbon.SelectedTabChanged event
  while the Ribbon is in minimized state, the subsequent attempt
  to show an MDI child window causes a NullReferenceException
  (TFS 68435).

- Fixed an issue in RibbonGallery: when the user clicks already
  selected item in the dropped down gallery, the selected item
  is not focused on the expanded gallery in RibbonGroup.

==================================================================
C1Ribbon Build 2/4.0.20141.577           Build Date: June 17, 2014
==================================================================

- Fixed a regression issue (introduced in build 574): an exception
  is thrown at design-time after clicking the "Localize" link in
  the smart tag menu of C1Ribbon or C1StatusBar (TFS 70652).

==================================================================
C1Ribbon Build 2/4.0.20141.576           Build Date: June 12, 2014
==================================================================

- Fixed an issue:  Incorrect border is rendered on C1RibbonForm
  with Custom VisualStyle, containing nested container controls
  docked to Fill, on changing state of the Form from inactive to
  active (TFS 69558).

==================================================================
C1Ribbon Build 2/4.0.20141.575            Build Date: June 5, 2014
==================================================================

- Fixed a regression issue introduced in build 574:
  RibbonEventHandler and ToolTipLinkClickedEventHander delegates
  are missed in C1.Win.C1Ribbon dll (TFS 68893).

==================================================================
C1Ribbon Build 2/4.0.20141.574            Build Date: June 4, 2014
==================================================================

- Added the ItemsChanged event to RibbonQat. The event occurs
  whenever a RibbonItem or RibbonGroup is added or removed
  to/from the RibbonQat.Items collection (TFS 68689).

==================================================================
C1Ribbon Build 2/4.0.20141.572          Build Date: April 29, 2014
==================================================================

- Fixed an issue: Flickering is observed in the title bar of
  C1RibbonForm when a drop-down, such as the application menu,
  is shown while the current Windows theme is set to "Windows
  7 Basic". The issue also occurs in RDP session to Windows 7.

==================================================================
C1Ribbon Build 2/4.0.20141.570          Build Date: April 22, 2014
==================================================================

- Fixed an issue: Auto-Hidden Taskbar does not appear when
  C1RibbonForm with Custom visual style is maximized (TFS 64455).

- Added a few missed localization strings for Korean.

==================================================================
C1Ribbon Build 2/4.0.20141.569          Build Date: April 21, 2014
==================================================================

- Fixed an issue: C1RibbonForm's Size and Location change while
  a button is pressed and the mouse pointer moves outside the
  Form if its VisualStyle is set as Custom (TFS 64410).

- Fixed a minor issue: MessageBox is not displayed from a handler
  of the RibbonTab.Select event when unchecking "Minimize the
  Ribbon" option in C1Ribbon's context menu (see TFS 64379).

- Added two missed localization strings for Japanese (TFS 63781).

==================================================================
C1Ribbon Build 2/4.0.20141.568           Build Date: April 8, 2014
==================================================================

- Added two missed localization strings for Japanese.

==================================================================
C1Ribbon Build 2/4.0.20141.567           Build Date: April 7, 2014
==================================================================

- Fixed an issue: When the NoSysKeyUp property of a C1Ribbon
  control is set to True, pressing Alt+F4 keys doesn't close
  the owner C1RibbonForm.

==================================================================
C1Ribbon Build 2/4.0.20141.566           Build Date: April 4, 2014
==================================================================

- Fixed a regression issue introduced in build 564: After closing
  the drop down of RibbonMenu in MDI child form, the standard
  Form title appears instead of "styled" title of C1RibbonForm
  (TFS 63269).

==================================================================
C1Ribbon Build 2/4.0.20141.565           Build Date: April 3, 2014
==================================================================

- Fixed one more repainting issue in a C1RibbonForm working in
  RDP session when the server machine is Windows Server 2008 R2.

==================================================================
C1Ribbon Build 2/4.0.20141.564           Build Date: April 2, 2014
==================================================================

- Fixed an issue with not redrawing a C1RibbonForm when the user
  switches applications in a Remote Desktop session.

==================================================================
C1Ribbon Build 2/4.0.20141.563           Build Date: April 1, 2014
==================================================================

- Fixed a show-stopper issue introduced in build 561.

- Updated C1RibbonApplication templates: the ForeColor property
  of RibbonContextualTabGroup is set to its default value.

==================================================================
C1Ribbon Build 2/4.0.20141.561          Build Date: March 31, 2014
==================================================================

- Fixed an issue: CPU usage increases & C1Ribbon repaints when
  the image on RibbonButton is changed in a thread (TFS 43198).

- Addressed an issue: KeyTips are displayed incorrectly when
  the user presses Alt+Tab keys in an application working on
  a remote machine in RDP session (TFS 49668). Now pressing
  the Alt key doesn't show KeyTips in a Remote Desktop session.
  It's still possible to press the F10 key to show KeyTips.

==================================================================
C1Ribbon Build 2/4.0.20141.559          Build Date: March 28, 2014
==================================================================

- Changed priority of collapsed elements when the width of the
  Ribbon control is not enough for displaying all items in full
  size. RibbonGalleries are not collapsed before other elements.

==================================================================
C1Ribbon Build 2/4.0.20141.558          Build Date: March 12, 2014
==================================================================

- Addressed (probably fixed) the following issue: Win32Exception
  occurs when debugging a multi-threaded application containing
  a C1StatusBar (TFS 56446).

==================================================================
C1Ribbon Build 2/4.0.20141.557          Build Date: March 10, 2014
==================================================================

- Fixed an issue: Context menu is shown at design time when a
  user makes a right click on an unselected Tab after setting
  a ContextMenuStrip to C1Ribbon.ContextMenuStrip (TFS 56554).

==================================================================
C1Ribbon Build 2/4.0.20141.556           Build Date: March 9, 2014
==================================================================

- Partially fixed some issues in C1Ribbon in VSTO (Visual Studio
  Tools for Office). See TFS 22305.

==================================================================
C1Ribbon Build 2/4.0.20141.555           Build Date: March 4, 2014
==================================================================

- Fixed an issue: Any changes to RibbonContextualTabGroup's Font
  and ForeColor properties have no effect after applying a theme
  of C1ThemeController to a C1Ribbon control (TFS 56023).

==================================================================
C1Ribbon Build 2/4.0.20141.554           Build Date: March 3, 2014
==================================================================

- Fixed an issue related to theming in RibbonListItem element.

==================================================================
C1Ribbon Build 2/4.0.20141.553       Build Date: February 28, 2014
==================================================================

- Fixed an issue: If C1RibbonForm is too small for displaying
  C1Ribbon control (the Ribbon is in hidden mode), then after
  maximizing and restoring the form its height decreases.

- Fixed an issue: Left and right borders of C1RibbonForm don't
  appear correctly if there is no C1Ribbon control on the form
  and the user maximizes and restores the form.

==================================================================
C1Ribbon Build 2/4.0.20141.552       Build Date: February 25, 2014
==================================================================

- Fixed an issue: An exception occurs after setting some colors
  in RibbonStyle or theme to Color.Transparent (see TFS 51929).

- Fixed an issue: Unhandled exception occurs on clicking the
  cross button after the ArrowDownGlyph property in the Theme
  Designer (TFS 51447).

==================================================================
C1Ribbon Build 2/4.0.20141.551       Build Date: February 24, 2014
==================================================================

- C1Ribbon is now licensed as a part of Studio for Desktop.

- Many small changes to C1Ribbon theme format.

==================================================================
C1Ribbon Build 2/4.0.20141.550       Build Date: February 19, 2014
==================================================================

- Small changes related to theme support.

==================================================================
C1Ribbon Build 2/4.0.20141.549       Build Date: February 18, 2014
==================================================================

- Fixed a few problems in C1Ribbon theme format.

==================================================================
C1Ribbon Build 2/4.0.20141.548       Build Date: February 17, 2014
==================================================================

- Fixed an issue introduced in build 542: RibbonTrackBar's plus
  and minus buttons appear distorted after changing visual style
  from Custom to one of the Office styles.

- A small update to C1Ribbon theme format.

==================================================================
C1Ribbon Build 2/4.0.20141.547       Build Date: February 15, 2014
==================================================================

- Fixed an issue: When C1Ribbon is used in UserControl and this
  is added as a CustomTaskPane in MS Outlook using VSTO (Visual
  Studio Tools for Office 2007), then the Click event of a
  RibbonButton does not get fired (TFS 47192).

==================================================================
C1Ribbon Build 2/4.0.20141.546       Build Date: February 15, 2014
==================================================================

- Fixed an issue: Disabled images are not rendered correctly on
  C1Ribbon and C1StatusBar controls (TFS 51508).

- Many changes to the theme format.

==================================================================
C1Ribbon Build 2/4.0.20141.542       Build Date: February 12, 2014
==================================================================

- Updated theming code for the latest version of C1ThemeDesigner,
  added new style settings.

- Fixed a minor issue in RibbonSplitButton, RibbonToggleButton
  elements displayed on C1StatusBar control.

- Fixed an issue: RibbonQat.Enabled property did not affect the
  QAT drop-down and shevron buttons.

==================================================================
C1Ribbon Build 2/4.0.20133.537        Build Date: February 7, 2014
==================================================================

- Fixed an issue: Glow borders are not displayed sometimes for
  C1RibbonForm if the VisualStyle is switched to Custom within
  the form constructor. The issue observed in C1ThemeDesigner.

==================================================================
C1Ribbon Build 2/4.0.20133.536        Build Date: February 6, 2014
==================================================================

- Fixed an issue: C1RibbonForm's frame gets displayed over the
  form passed to the AddOwnedForm() method when the VisualStyle
  is set to Custom (TFS 50730).

==================================================================
C1Ribbon Build 2/4.0.20133.535        Build Date: February 3, 2014
==================================================================

- Fixed an issue: Selected color of RibbonColorPicker is not
  drawn on the corresponding QAT item when the color picker
  element is moved from QAT schevron ("More controls" drop-down)
  to the QAT directly (TFS 50554).

==================================================================
C1Ribbon Build 2/4.0.20133.534        Build Date: January 29, 2014
==================================================================

- Fixed an issue: System menu icon disappears in C1Ribbon which
  is placed on an MDI child C1RibbonForm when another MDI child
  form is activated (TFS 50395).

- Fixed an issue: Unhandled exception is occurred when setting a
  large number to the TextAreaWidth property of RibbonDatePicker
  (TFS 49434).

==================================================================
C1Ribbon Build 2/4.0.20133.533        Build Date: January 21, 2014
==================================================================

- Added the AltKeyPressDelay property to C1Ribbon. It sets the
  delay (in milliseconds) after pressing the Alt key before
  displaying KeyTips. Setting AltKeyPressDelay to 0 prevents
  KeyTips from showing by timer when the user holds the Alt key
  pressed (see TFS 49668).

- Fixed an issue with scrolling RibbonComboBox and RibbonGallery
  drop-down list. When the user clicks in the PageUp or PageDown
  area of the scrollbar, it scrolled up to the start/end of the
  list regardless of the clicked position. Now it scrolls to the
  position where the scrollbar thumb overlaps the clicked point.

- Fixed an issue with theming support for several elements used
  in menu popups (they were not accessible for C1ThemeDesigner).

==================================================================
C1Ribbon Build 2/4.0.20133.532         Build Date: January 8, 2014
==================================================================

- Fixed an issue: Access modifier of C1Ribbon elements changes
  to private when any change is done in the Form at design time
  and the project references C1Ribbon Design dll (TFS 49050).

==================================================================
C1Ribbon Build 2/4.0.20133.531         Build Date: January 6, 2014
==================================================================

- Fixed an issue: Selected Tab gets changed when RibbonNumericBox
  is scrolled using mouse wheel (TFS 48983).

- Fixed an issue: The contents of a RibbonTab is not updated
  correctly on setting the SelectedTab in C1Ribbon under some
  conditions (TFS 48998).

==================================================================
C1Ribbon Build 2/4.0.20133.530       Build Date: December 24, 2013
==================================================================

- Fixed an issue with one-pixel offset of a RibbonSplitButton
  displayed on C1StatusBar. Also, the split button element was
  not transparent when displayed on QAT or RibbonConfigToolBar.
  The problems occurred for the Custom visual style only.

==================================================================
C1Ribbon Build 2/4.0.20133.529       Build Date: December 23, 2013
==================================================================

- Fixed an issue: Button tooltips were not localized in the
  Tooltip Editor form (displayed as UITypeEditor for the ToolTip
  property of various Ribbon elements).

==================================================================
C1Ribbon Build 2/4.0.20133.528       Build Date: December 22, 2013
==================================================================

- Small internal changes to C1Ribbon and C1RibbonForm to support
  Composite UI Application Block (CAB).

==================================================================
C1Ribbon Build 2/4.0.20133.527       Build Date: December 20, 2013
==================================================================

- Fixed an issue introduced in build 525: When the ribbon is in
  minimized state and the user clicks the tab header and presses
  a button in the tab popup window, then after closing tab popup
  and moving the mouse over the same tab header again, the state
  of tab header is not changed to 'hot' and the user can't click
  it to display the tab popup once again.

==================================================================
C1Ribbon Build 2/4.0.20133.526       Build Date: December 17, 2013
==================================================================

- Fixed an issue: An exception occurs when a Form with C1Ribbon
  control is opened in the Form Designer on a machine where
  ComponentOne Studio for Winforms is not installed (TFS 47806).

==================================================================
C1Ribbon Build 2/4.0.20133.525       Build Date: December 13, 2013
==================================================================

- Fixed an issue: The MouseLeave event is not fired for a
  RibbonButton after clicking it with the mouse and showing
  a new window from the Click event.

- Fixed an issue: Tooltips are distorted when the BackColor
  property of ToolTipSettings is set to Color.Transparent.

==================================================================
C1Ribbon Build 2/4.0.20133.524        Build Date: December 3, 2013
==================================================================

- Fixed an issue: Double clicking at the extreme of the top left
  corner of a non-modal C1RibbonForm with the C1Ribbon control on
  it hides C1Ribbon control so that it doesn't appear next time
  when this form becomes visible.

==================================================================
C1Ribbon Build 2/4.0.20133.523       Build Date: November 29, 2013
==================================================================

- Fixed an issue: An exception is thrown after setting ribbon's
  VisualStyle to Custom and hiding the RibbonQat (TFS 47008).

- Fixed an issue: After setting HideTabHeaderRow to False, not
  only the tab header row but also the content of the selected
  tab is hidden (TFS 47030).

- Fixed an issue: Window borders appear incorrectly sometimes
  after minimizing and, then, maximizing C1RibbonForm with the
  ShowInTaskbar property set to False and Custom visual style
  (TFS 46944).

==================================================================
C1Ribbon Build 2/4.0.20133.522       Build Date: November 28, 2013
==================================================================

- Fixed an issue: Window state of MDI child forms changes from
  Minimized to Normal when the visual style of MDI parent form
  changes from or to the Custom style (TFS 46964).

- Updated default values for the AutomaticColor and DefaultColor
  properties of RibbonColorPicker (TFS 46969).

==================================================================
C1Ribbon Build 2/4.0.20133.521       Build Date: November 26, 2013
==================================================================

- Fixed an issue with cutting off borders of C1RibbonForm after
  switching from Custom visual style to Office2010Blue and other
  visual styles.

==================================================================
C1Ribbon Build 2/4.0.20133.520       Build Date: November 26, 2013
==================================================================

- Fixed an issue: after setting ShowInTaskbar to False for a
  C1RibbonForm its window buttons can not be clicked at runtime
  while the form is in minimized state and the visual style is
  set to Custom (TFS 46845).

==================================================================
C1Ribbon Build 2/4.0.20133.519       Build Date: November 25, 2013
==================================================================

- Fixed an issue: C1RibbonForm has different size at runtime and
  at design-time if its FormBorderStyle is set to FixedSingle or
  FixedDialog and the main application project uses .NET 4.5 as
  the target framework.

==================================================================
C1Ribbon Build 2/4.0.20133.518       Build Date: November 23, 2013
==================================================================

- Fixed a small issue with menu auto-popup for RibbonSplitButton.

- Fixed an issue: RibbonTab's content area disappears when all
  RibbonGroups are hidden (for all styles except Custom). Now
  the content area height doesn't depend on whether any groups
  are visible or not (TFS 46571).

==================================================================
C1Ribbon Build 2/4.0.20133.517       Build Date: November 22, 2013
==================================================================

- Fixed an issue: RibbonComboBox is not displayed correctly in
  drop-down menus (TFS 46524).

- Fixed an issue: Ribbon's tab content area does not disappear
  when all tabs are hidden and the visual style is set to Custom
  (TFS 46557).

==================================================================
C1Ribbon Build 2/4.0.20133.516       Build Date: November 19, 2013
==================================================================

- Fixed an issue: C1RibbonForm throws a Cross Thread exception
  while switching the Windows theme (TFS 46286).

- Fixed an issue: Title bar of C1RibbonForm becomes invisible
  after minimizing C1RibbonForm with C1Ribbon control on it when
  this is an MDI child form and VisualStyle is set to Custom
  (TFS 46343).

- Fixed an issue: Changing TextAlign property of RibbonComboBox,
  RibbonNumericBox, RibbonTextBox, and RibbonDate/TimePicker has
  no effect after switching C1RibbonForm to the Custom style
  (TFS 46344).

- Fixed an issue: RightToLeft mode doesn't work correctly for
  C1RibbonForm when it is set at design time and VisualStyle is
  set to Custom (TFS 46345).

- Fixed an issue: TextImageRelation property has no effect after
  setting C1RibbonForm.VisualStyle to Custom (TFS 46346).

- Fixed an issue: "grip handle" image is not displayed in
  RibbonSplitButton and RibbonMenu drop-downs after setting
  GripHandleVisible property to True if the owner form's
  VisualStyle is set to Custom (TFS 46348).

==================================================================
C1Ribbon Build 2/4.0.20133.514       Build Date: November 17, 2013
==================================================================

- Fixed a potential issue in C1RibbonForm that may cause an
  exception when the visible form is being disposed.

==================================================================
C1Ribbon Build 2/4.0.20133.513       Build Date: November 15, 2013
==================================================================

- Fixed an issue: Caption text for a window based on C1RibbonForm
  starts to flash everytime it changes with Windows Classic color
  theme, if another window overlapped it once (TFS 46235).

- Fixed an issue: When value of 'ContentAreaHeight' is set to 0,
  ribbon content area is hidden. But ribbon content area is
  displayed when negative value is set for 'ContentAreaHeight'
  (TFS 45015).

- Fixed an issue: When Aero theme is selected in Windows 7 and
  system's "Border Padding" is set to 0 then C1RibbonForm has
  black border along its boundary (TFS 44527).

==================================================================
C1Ribbon Build 2/4.0.20133.511       Build Date: November 14, 2013
==================================================================

- Fixed an issue: C1StatusBar remains hidden after setting
  RibbonStyle.ConstSet[StyleConst.StatusBarHeight] to -1, and
  then setting it to 22, for example (TFS 46046).

==================================================================
C1Ribbon Build 2/4.0.20133.510       Build Date: November 12, 2013
==================================================================

- The RibbonApplication templates were updated to support the
  Custom visual style.

- Fixed an issue: An exception is thrown when the user sets a
  value to the RibbonComboBox.Label property (it occurs for the
  Custom visual style only).

- Fixed an issue: The vertical alignment of text labels in menus
  becomes wrong after switching from Office2007 to Custom style.

- Added the HideTabHeaderRow property to C1Ribbon control:

  public bool HideTabHeaderRow { get; set; }

  After setting this property to True the application menu, tab
  header area, and configuration toolbar become hidden. The last
  selected tab remains visible in the Ribbon content area, but
  the user can't switch to another RibbonTab using the mouse or
  keyboard. The window buttons for a maximized MDI child window
  do not appear in this mode.

==================================================================
C1Ribbon Build 2/4.0.20133.509        Build Date: November 8, 2013
==================================================================

- Fixed an issue with drawing inverted image on x64 platform if
  the image is assigned to C1Ribbon.HeaderWatermark property and
  it has white background.

- Added a few new properties to C1Ribbon theme (ActiveButtonColor,
  InactiveButtonColor, DisabledButtonColor).

==================================================================
C1Ribbon Build 2/4.0.20133.507        Build Date: November 8, 2013
==================================================================

- Fixed an internal issue related to themes.

- Added a new property to C1Ribbon theme (WatermarkImage) that
  can be set using the theme designer app.

==================================================================
C1Ribbon Build 2/4.0.20133.504        Build Date: November 7, 2013
==================================================================

- Fixed issues with flickering title and borders of C1RibbonForm
  when the VisualStyle is set to Custom.

- Fixed an issue: Window buttons on C1RibbonForm don't work as
  expected when the user presses the left mouse button then moves
  the mouse pointer away from window button, then releases the
  mouse button.

- Fixed an issue: Items placed after a hidden RibbonSeparator are
  not centered vertically in RibbonGroup (for Custom style only).

- Fixed a regression issue: CodedUI doesn't work when ribbon form
  is shown as MDI child window (TFS 44926).

==================================================================
C1Ribbon Build 2/4.0.20133.499        Build Date: November 4, 2013
==================================================================

- Fixed an issue: Separator is not shown on QAT if the VisualStyle
  property is set to Custom (TFS 45367).

- Fixed an issue: Setting the RibbonButton.Text property to an
  empty string causes an exception for large buttons.

- Applied styles to the Color Picker element and KeyTips.

==================================================================
C1Ribbon Build 2/4.0.20133.498        Build Date: November 3, 2013
==================================================================

- Applied new themes to ribbon items in QAT shevron and to the
  drop-down calendar.

==================================================================
C1Ribbon Build 2/4.0.20133.497        Build Date: October 31, 2013
==================================================================

- Fixed an issue introduced in previous build (496): C1RibbonForm
  borders disappear when switching from Office2007/2010 to Custom
  visual style.

- Added themable menu item separators.

==================================================================
C1Ribbon Build 2/4.0.20133.496        Build Date: October 30, 2013
==================================================================

- Fixed an issue: Updating C1Ribbon's VisualStyle with the smart
  tag panel doesn't mark the owner form as "unsaved" (TFS 44726).

- Removed label and image from RibbonComboBox-like elements
  when adding them to Quick Access Toolbar.

- Fixed an issue: Theme properties don't affect the background
  color of TextBox-like elements.

==================================================================
C1Ribbon Build 2/4.0.20133.495        Build Date: October 29, 2013
==================================================================

- Added theming support (ThemeChanged method) to C1RibbonForm.

- Fixed an issue: An exception occurs when copying a C1StatusBar
  to Clipboard at design time if the status bar uses an ImageList.

- Fixed an issue: An exception occurs when showing an MDI child
  ribbon form after setting its VisualStyle to Custom within the
  Form.Load event handler (TFS 44737).

- Fixed an issue: Window border of C1RibbonForm with Custom style
  appears beneath the parent form.

- Fixed an issue: C1StatusBar without elements looks distorted.

- Fixed an issue: 'Custom' item is not available in the floating
  toolbar for setting C1Ribbon.VisualStyle (TFS 44637).

==================================================================
C1Ribbon Build 2/4.0.20133.492        Build Date: October 28, 2013
==================================================================

- Added support for custom themes to RibbonGalleries, fixed a
  number of internal issues.

==================================================================
C1Ribbon Build 2/4.0.20133.491        Build Date: October 26, 2013
==================================================================

- Added support for customizable themes that mimic Office 2013.
  This is a preliminary build (alpha-version).

==================================================================
C1Ribbon Build 2/4.0.20132.490        Build Date: October 16, 2013
==================================================================

- Fixed an issue: Ribbon buttons do not respond to mouseover if
  the C1RibbonForm is currently not the active form (TFS 43681).

==================================================================
C1Ribbon Build 2/4.0.20132.489      Build Date: September 27, 2013
==================================================================

- Fixed an issue introduced in build 487: changed the order of
  the PressedChanged and Click events in RibbonToggleButton and
  RibbonSplitButton.

==================================================================
C1Ribbon Build 2/4.0.20132.488       Build Date: September 7, 2013
==================================================================

- Fixed an issue: A message box can’t be displayed from a handler
  of the ValueChanged event of a RibbonDatePicker that is placed
  on a popup form. The same issue occurs for a RibbonTimePicker
  element (TFS 41269).

==================================================================
C1Ribbon Build 2/4.0.20132.487         Build Date: August 26, 2013
==================================================================

- Fixed an issue: A message box can't be displayed from a handler
  of the RibbonToggleButton.PressedChanged event if the toggle
  button is placed on a popup form. The same issue occurs for a
  RibbonSplitButton with ToggleOnClick set to true  (TFS 41215).

==================================================================
C1Ribbon Build 2/4.0.20132.486         Build Date: August 24, 2013
==================================================================

- Fixed an issue: When the Ribbon form is maximized by a double
  click on the title bar and the mouse pointer is hovered over
  a RibbonSplitButton, the Click event is fired (TFS 41196).

==================================================================
C1Ribbon Build 2/4.0.20132.485         Build Date: August 23, 2013
==================================================================

- Fixed an issue: Keytips are still displayed for the C1Ribbon
  control after moving the MDI parent form by its title bar,
  maximizing it, or resizing it if C1Ribbon's owner C1RibbonForm
  is used as an MDI child form (see TFS 39990).

==================================================================
C1Ribbon Build 2/4.0.20132.484         Build Date: August 22, 2013
==================================================================

- Fixed an issue: Key tips are erroneously displayed for the
  C1Ribbon control after pressing Alt+Tab keys if the owner
  C1RibbonForm is used as an MDI child form (TFS 41150).

==================================================================
C1Ribbon Build 2/4.0.20132.483         Build Date: August 21, 2013
==================================================================

- Fixed an issue: When the Ribbon form is maximized by a double
  click on the title bar and the mouse pointer is hovered over
  a RibbonButton, the Click event is fired for the RibbonButton
  (TFS 41108).

==================================================================
C1Ribbon Build 2/4.0.20132.482         Build Date: August 16, 2013
==================================================================

- Fixed an issue: If user shows a combobox or other drop-down
  using KeyTips while holding the Alt key pressed then starts
  pressing next KeyTip sequence without releasing the Alt key
  then the dropdown of RibbonComboBox does not close. Now it
  ignores any attempts to start next KeyTip sequence before
  releasing the Alt key (see TFS 40901).

==================================================================
C1Ribbon Build 2/4.0.20132.481         Build Date: August 14, 2013
==================================================================

- Fixed an issue: The opened dropdown of RibbonComboBox does not
  close when a user presses Alt+"KeyTip key" at once (TFS 40901).

- Fixed an issue: Dropdown of RibbonSplitButton and RibbonMenu
  doesn't close and KeyTips don't appear after pressing the Alt
  or F10 keys while the dropdown is open (TFS 40158).

==================================================================
C1Ribbon Build 2/4.0.20132.480         Build Date: August 12, 2013
==================================================================

- Fixed an issue: pressing a disabled ribbon element with the
  mouse and dragging mouse pointer over enabled ribbon buttons
  while keeping the mouse button pressed changes appearance of
  those ribbon buttons to Pressed state (TFS 40266).

- Fixed an issue: pressing key tip keys for disabled elements
  handled inadequately. Now C1Ribbon doesn't allow to press key
  tips for disabled elements as in MS Office (see TFS 40544).

==================================================================
C1Ribbon Build 2/4.0.20132.479          Build Date: August 2, 2013
==================================================================

- Fixed an issue: NullReferenceException is fired when pressing
  the Alt key and the keytip key at the same time (TFS 39843).
  The issue was fixed in build 2/4.0.20132.472, then reintroduced
  accidentally in build 2/4.0.20132.478.

==================================================================
C1Ribbon Build 2/4.0.20132.478           Build Date: July 24, 2013
==================================================================

- Fixed an issue: the Alt+Tab keys don't switch tasks sometimes
  when the NoSysKeyUp property is set to True.

==================================================================
C1Ribbon Build 2/4.0.20132.476           Build Date: July 18, 2013
==================================================================

- Fixed a regression issue: Unlike the previous builds, KeyTips
  don't disappear when a user clicks somewhere in C1Ribbon or
  switches to another RibbonTab with Ctrl+Tab keys (TFS 39990).

==================================================================
C1Ribbon Build 2/4.0.20132.475           Build Date: July 17, 2013
==================================================================

- Added the NoSysKeyUp runtime boolean property to C1Ribbon.
  Setting this property to True can be used as a workaround for
  the bug in the standard WebBrowser control that prevents
  KeyTips from showing in C1Ribbon when the user releases the
  Alt key or presses the F10 key at runtime.

==================================================================
C1Ribbon Build 2/4.0.20132.474           Build Date: July 16, 2013
==================================================================

- Added the KeyTipsVisible boolean property to C1Ribbon. The
  property indicates whether the KeyTips are currently visible
  for a C1Ribbon control. This is a runtime-only property.

==================================================================
C1Ribbon Build 2/4.0.20132.473           Build Date: July 16, 2013
==================================================================

- Fixed an issue: Keytips don't show when the Alt key is pressed
  under "Windows7 Basic" system theme (see 39843).

==================================================================
C1Ribbon Build 2/4.0.20132.472           Build Date: July 15, 2013
==================================================================

- Fixed an issue: NullReferenceException is fired when pressing
  the Alt key and the keytip key at the same time (TFS 39843).

==================================================================
C1Ribbon Build 2/4.0.20132.471           Build Date: July 14, 2013
==================================================================

- Fixed an issue: showing KeyTips deactivated the RibbonForm.

==================================================================
C1Ribbon Build 2/4.0.20132.470           Build Date: July 12, 2013
==================================================================

- Fixed a regression bug: an arrow does not appear on the
  dropdown button of RibbonColorPicker and RibbonSplitButton
  elements which are placed on a C1StatusBar (TFS 39803).

==================================================================
C1Ribbon Build 2/4.0.20132.469           Build Date: July 11, 2013
==================================================================

- Changed word-wrapping rules for Japanese/Chinese strings on
  large ribbon buttons that display text in two lines. Strings
  are normally split at the position of the space characters. If
  the space character is not found in a Japanese/Chinese/Korean
  string it can be split at any convenient position with some
  restrictions. So if you don't want to split a Japanese string
  just add a space at the end (TFS 39731).

==================================================================
C1Ribbon Build 2/4.0.20132.468            Build Date: July 9, 2013
==================================================================

- Fixed a localization issue (see TFS 39604).

==================================================================
C1Ribbon Build 2/4.0.20132.466            Build Date: July 8, 2013
==================================================================

- Moved to the new internal localization model.

==================================================================
C1Ribbon Build 2/4.0.20132.465           Build Date: June 22, 2013
==================================================================

- Fixed an issue: an ArgumentException is thrown on opening a
  RibbonFontComboBox element if its owner RibbonGroup font is
  set to a Font that doesn't support 'Regular' style, such as
  "Brush Script MT" or "Monotype Corsiva" (TFS 38190).

==================================================================
C1Ribbon Build 2/4.0.20132.464           Build Date: June 21, 2013
==================================================================

- Fixed an issue: if a custom font is set for a RibbonGroup and
  the group is wider than the width of the screen, its drop-down
  is positioned incorrectly at the second time of showing the
  collapsed group's drop-down (TFS 38063).

- Fixed an issue: after setting an image which size is larger
  than 16x16 to the RibbonApplicationMenu.SmallImage property the
  application button appears incorrectly for Office2010 visual
  styles and Win7Look mode (TFS 38095).

- Fixed an issue: if the Visual Studio application with C1Ribbon
  designer is not the active window, mouse hovering on a DropDown
  arrow belonging to some ribbon element causes the dropdown to
  continuously open and close (TFS 38161).

==================================================================
C1Ribbon Build 2/4.0.20132.463           Build Date: June 18, 2013
==================================================================

- Fixed an issue: RibbonButton appearance must be changed to
  'unpressed' after moving the mouse pointer with a pressed left
  mouse button out of the RibbonButton area (TFS 37851).

==================================================================
C1Ribbon Build 2/4.0.20132.462           Build Date: June 12, 2013
==================================================================

- A minor change to the localization model.

==================================================================
C1Ribbon Build 2/4.0.20132.461            Build Date: June 4, 2013
==================================================================

- URL changes for GrapeCity JPN AboutBox.

==================================================================
C1Ribbon Build 2/4.0.20132.460            Build Date: May 30, 2013
==================================================================

- Fixed an issue: the Click event of RibbonButton and
  RibbonSplitButton is triggered even if the mouse pointer has
  been moved out of the button area (TFS 37229).

==================================================================
C1Ribbon Build 2/4.0.20132.459            Build Date: May 29, 2013
==================================================================

- Fixed an issue: Unhandled exception occured when user clicks
  the collapsed RibbonGroup's dropdown button while an image is
  updated for some ribbon item by another thread (TFS 37178).

==================================================================
C1Ribbon Build 2/4.0.20131.457            Build Date: May 20, 2013
==================================================================

- Fixed an issue: Unlike MS Office, the key tips are not working
  while the user is holding the Alt key down and presses the key
  tips keys in C1Ribbon (TFS 36816).

==================================================================
C1Ribbon Build 2/4.0.20131.456            Build Date: May 16, 2013
==================================================================

- Fixed an issue: ArgumentNullException is thrown sometimes when
  setting RibbonButton.ShortcutKeys property in a multi-threaded
  application (see TFS 36568, exception 3).

==================================================================
C1Ribbon Build 2/4.0.20131.454             Build Date: May 8, 2013
==================================================================

- Fixed an issue: SplitButton menu does not auto-show when user
  hovers the mouse pointer on it if the form was not created in
  the main GUI thread (see TFS 36137, case 3).

- Fixed an issue: Application freezes if user opened many ribbon
  forms in multiple threads (see TFS 36137, case 4).

==================================================================
C1Ribbon Build 2/4.0.20131.453             Build Date: May 3, 2013
==================================================================

- Added a few missed Chinese and Korean localization strings
  (TFS 35257, 35453).

==================================================================
C1Ribbon Build 2/4.0.20131.452             Build Date: May 2, 2013
==================================================================

- Fixed an issue: the dropdown of RibbonComboBox is not closed
  automatically when activating another form in a multi-threaded
  application (see TFS 36137, case 1).

- Fixed an issue: System.InvalidOperationException occurred when
  displaying a popup window in multi-threaded application while
  updating ribbon in the other thread (see TFS 36137, case 2).

- A BREAKING CHANGE: RibbonItem.Name is now returned by default
  instead of Text as the AccessibleObject.Name property value.
  It allows to search items by their names in Coded UI testing
  even if the Text/Label properties are localized.

==================================================================
C1Ribbon Build 2/4.0.20131.451           Build Date: April 3, 2013
==================================================================

- Moved to the subscription licensing model in Japanese build.

- Added a few missed Japanese localization strings.

==================================================================
C1Ribbon Build 2/4.0.20131.450           Build Date: April 2, 2013
==================================================================

- Added the ButtonEnabled property to RibbonSplitButton. If it
  is set to false, the user can't click the button. She can open
  the drop-down though (if the Enabled property is true).

- Fixed a few small layout issues.

==================================================================
C1Ribbon Build 2/4.0.20131.448          Build Date: March 29, 2013
==================================================================

- Fixed an issue: ArgumentException is occured when setting
  the LargeItemDropDownWidth property at runtime (TFS 20144).

==================================================================
C1Ribbon Build 2/4.0.20131.446          Build Date: March 26, 2013
==================================================================

- Updated hot background color of the RibbonGallery element.
  See the following link for more details on the issue:
  http://our.componentone.com/groups/winforms/ribbon-for-winforms/forum/topic/ribbon-gallaries

==================================================================
C1Ribbon Build 2/4.0.20131.445          Build Date: March 26, 2013
==================================================================

- Added the LargeItemDropDownWidth property to RibbonSplitButton
  and RibbonMenu. It specifies the width of a drop-down menu with
  large items (if the value is greater than 100). Small items are
  displayed in the drop-down menu if this value is less than 100.
  Large buttons and menus show the Description text. The value of
  this property is ignored for elements of the application menu.

- Fixed an issue introduced in build 437: the value assigned to
  RibbonTextBox.Text property is not persisted (TFS 35282).

- Fixed an issue: RibbonSplitButton remains in pressed state
  after setting its ToggleOnClick property to False (TFS 35269).

- Fixed an issue: the Pressed state is not retained for
  RibbonSplitButton with ToggleOnClick set to False after the
  mouse hovers the split button element (TFS 35285).

==================================================================
C1Ribbon Build 2/4.0.20131.444          Build Date: March 21, 2013
==================================================================

- Added the ToggleOnClick property to RibbonSplitButton element.
  The property indicates whether the split button should remain
  in pressed state after clicking on it.

- Added the Pressed property to RibbonSplitButton. It indicates
  whether the split button is pressed (toggled).

- Fixed an issue: Key Tips stay visible although their
  corresponding ribbon items were scrolled by hovering the mouse
  pointer on the menu scroll button (TFS 35243).

==================================================================
C1Ribbon Build 2/4.0.20131.443          Build Date: March 20, 2013
==================================================================

- Fixed an issue introduced in build 441: The drop-down list
  of a RibbonComboBox stays open when the user switches to an
  other application (TFS 35183).

==================================================================
C1Ribbon Build 2/4.0.20131.442          Build Date: March 15, 2013
==================================================================

- Fixed an issue: Users need to click ribbon tabs twice to
  switch between the tabs at design time (TFS 35016).

==================================================================
C1Ribbon Build 2/4.0.20131.441          Build Date: March 14, 2013
==================================================================

- Fixed an issue: When the user opens a drop-down, such as menu
  or combobox list, it brings to frong another C1RibbonForm if
  two ribbon forms are displayed at the same time and both have
  the TopMost property set to True (TFS 34817).

- Fixed an issue: If RibbonItem's SmallImage is changed by timer
  while ribbon tabs are minimized then it becomes impossible to
  open other tabs (TFS 34899).

- Fixed an issue: All label text displayed on the right pane of
  Application Menu (Recent List) becomes corrupted after opening
  the Menu and pressing the Esc key simultaneously (TFS 34903).

==================================================================
C1Ribbon Build 2/4.0.20131.440           Build Date: March 8, 2013
==================================================================

- Fixed an issue: when the user navigates through multiple
  nested submenus it may occur that the parent menu disappears
  while its child menu is still open (TFS 34726).

- Fixed an issue: Assigning a new image to LargeImage or
  SmallImage properties of RibbonApplicationMenu doesn't affect
  the displayed image.

- Fixed an issue: Maximized C1RibbonForm shows a small glitch
  on the second monitor in a multi-monitor system under Windows
  Classic color theme.

==================================================================
C1Ribbon Build 2/4.0.20131.439           Build Date: March 6, 2013
==================================================================

- Fixed an issue: Inconsistent behavior is observed when adding
  new items to a RibbonGallery that is placed on a RibbonGroup
  which is added to QAT (TFS 34630).

==================================================================
C1Ribbon Build 2/4.0.20131.438           Build Date: March 5, 2013
==================================================================

- Fixed an issue: Selected gallery item is not shown in the 
  expanded RibbonGallery for the first time if that gallery is
  on a RibbonGroup which is added to QAT (TFS 34609).

==================================================================
C1Ribbon Build 2/4.0.20131.437           Build Date: March 4, 2013
==================================================================

- Fixed an issue: After hiding the ribbon application menu and
  tabs if the VisualStyle is set to Office2010 the controls at
  top of the form are rendered incorrectly (TFS 34532).
 
- Fixed an issue: After typing text into a RibbonTextBox placed
  on a RibbonGroup which is added to QAT, the entered text is not
  updated in the "clone" of that RibbonTextBox that is placed on
  RibbonTab (TFS 34552). 
 
==================================================================
C1Ribbon Build 2/4.0.20131.436       Build Date: February 27, 2013
==================================================================

- Fixed an issue: SelectedItem property doesn't return an item
  selected in a RibbonComboBox which is added to QAT (TFS 34395).

==================================================================
C1Ribbon Build 2/4.0.20123.433        Build Date: January 18, 2013
==================================================================

- Fixed an issue: RibbonTrackBar becomes distorted after setting
  its Width to 20, then resetting it to 120 (TFS 33249).

- The item height in RibbonFontComboBox is enlarged a little.

==================================================================
C1Ribbon Build 2/4.0.20123.432        Build Date: January 17, 2013
==================================================================

- Fixed an issue: the following events are raised twice in
  RibbonComboBox: GotFocus, LostFocus, HighlightedIndexChanged
  when a user opens its dropdown and clicks an item
  (TFS 33138, 33165).

- Fixed an issue: ObjectDisposedException is thrown when click
  on a minimized RibbonTab after displaying a message box from
  a handler for the RibbonComboBox.GotFocus event (TFS 33178).

- Fixed an issue: DropDownClosed event is not fired sometimes
  in all elements derived from RibbonDropDownBase (TFS 33179).

==================================================================
C1Ribbon Build 2/4.0.20123.431        Build Date: January 12, 2013
==================================================================

- Fixed an issue: an exception may occur when a message box
  is displayed from the GotFocus or DropDownClosed events of a
  RibbonDatePicker (TFS 33123).

- Fixed an issue: the RibbonComboBox.LostFocus event is not fired
  in Ribbon minimized state after clicking an item from the
  dropdown list of RibbonComboBox (TFS 33124).

==================================================================
C1Ribbon Build 2/4.0.20123.430        Build Date: January 11, 2013
==================================================================

- Fixed an issue: various exceptions may occur when a message box
  is displayed from an event handler like RibbonComboBox.GotFocus
  or RibbonComboBox.HighlightedIndexChanged (TFS 33092, 33093).

- Fixed an issue: a message box defined in a handler for the
  RibbonNumericBox.GotFocus event is shown multiple times when
  the user focuses that element. The same problems occurs for
  RibbonTextBox and other like elements (TFS 33100).

==================================================================
C1Ribbon Build 2/4.0.20123.427       Build Date: December 28, 2012
==================================================================

- Fixed an issue: message box is not shown from the Click event
  handler after clicking the PictureBox which is added using
  the RibbonControlHost-derived class to a RibbonGroup while the
  Ribbon is in minimized state (TFS 32320).

==================================================================
C1Ribbon Build 2/4.0.20123.426       Build Date: December 26, 2012
==================================================================

- Added a few preset images (large and small) for using with
  C1Schedule. Their names start with "Sch" prefix.

==================================================================
C1Ribbon Build 2/4.0.20123.425       Build Date: December 13, 2012
==================================================================

- Fixed a Japanese localization issue in the RibbonColorPicker
  element: RibbonColorPicker doesn't show a hotkey and KeyTip
  for the "More Colors..." menu item (TFS 31343).

==================================================================
C1Ribbon Build 2/4.0.20123.424       Build Date: December 12, 2012
==================================================================

- Fixed an issue in C1Ribbon and C1StatusBar:
  a NullReferenceException is observed sometimes after assigning
  the 'Nothing' value to a local variable containing a reference
  to RibbonButton placed on a disposed Form (TFS 30927).

==================================================================
C1Ribbon Build 2/4.0.20123.423       Build Date: December 11, 2012
==================================================================

- An attempt to fix a sporadic issue with redrawing C1RibbonForm
  when it obtains the input focus on Windows XP (the issue seems
  to be not reproducible on the dev machine).

==================================================================
C1Ribbon Build 2/4.0.20123.422       Build Date: November 25, 2012
==================================================================

- Fixed an issue in Ribbon Form/App templates: running a template
  installation command file "as administrator" changes the current
  directory to "c:\windows\system32" and fails (TFS 30291).

==================================================================
C1Ribbon Build 2/4.0.20123.421        Build Date: October 28, 2012
==================================================================

- Removed localization of run-time strings in the Japanese build.
  These strings are always in Japanese regardless of the current
  system locale.

==================================================================
C1Ribbon Build 2/4.0.20123.420        Build Date: October 25, 2012
==================================================================

- The interface language depends now on CurrentUICulture setting
  instead of the CurrentCulture property of CultureInfo.

==================================================================
C1Ribbon Build 2/4.0.20123.419        Build Date: October 22, 2012
==================================================================

- Fixed an issue: ObjectDisposedException occurs on hovering
  mouse pointer over submenus of a RibbonComboBox if this combobox
  has the DropDownStyle property set to 'DropDown' (TFS 29223).

==================================================================
C1Ribbon Build 2/4.0.20123.418        Build Date: October 21, 2012
==================================================================

- Small internal optimization.

==================================================================
C1Ribbon Build 2/4.0.20123.417        Build Date: October 19, 2012
==================================================================

- Fixed a small localization issue in the 'Localize' design-time
  window for Japanese culture.

==================================================================
C1Ribbon Build 2/4.0.20123.416        Build Date: October 18, 2012
==================================================================

- Updated icons for VS2012 project/item templates.

==================================================================
C1Ribbon Build 2/4.0.20123.415        Build Date: October 16, 2012
==================================================================

- Added a missing localized string (TFS 29079).

==================================================================
C1Ribbon Build 2/4.0.20123.413        Build Date: October 13, 2012
==================================================================

- Minor internal changes for better compatibility with VS2012.

==================================================================
C1Ribbon Build 2/4.0.20123.412        Build Date: October 11, 2012
==================================================================

- Added the Chinese and Korean localization strings.

==================================================================
C1Ribbon Build 2/4.0.20122.411      Build Date: September 23, 2012
==================================================================

- Fixed an issue: an exception is thrown after showing multiple
  forms with C1Ribbon on separate threads. Added more internal
  locks to prevent multi-threading collisions (TFS 28046).

==================================================================
C1Ribbon Build 2/4.0.20122.409      Build Date: September 21, 2012
==================================================================

- Added 'ComVisible(true)' attribute to C1RibbonForm, C1Ribbon,
  and C1StatusBar controls. That may facilitate accessing these
  controls by scripting code that is contained within a Web page
  displayed in a WebBrowser control, for example.

- Fixed an issue: hyperlinks didn't work and appeared incorrectly
  in tooltips after setting the RightToLeft property to 'Yes' for
  the owner form (TFS 28011).

==================================================================
C1Ribbon Build 2/4.0.20122.407      Build Date: September 19, 2012
==================================================================

- Fixed an issue: an ArgumentOutOfRangeException is thrown
  (since build 405) when displaying a tooltip with the <table>
  and <td> html tags without visible contents (TFS 27991).

==================================================================
C1Ribbon Build 2/4.0.20122.406      Build Date: September 19, 2012
==================================================================

- Updated templates for C1Ribbon Application and C1Ribbon Form.
  Fixed issues in templates for Visual Studio 2012 (TFS 27949).

==================================================================
C1Ribbon Build 2/4.0.20122.405      Build Date: September 18, 2012
==================================================================

- Fixed an issue: images are clipped in Ribbon tooltips when
  RightToLeft property is set to 'Yes' (TFS 27891).

- Added the HitTestVisible property to the ToolTipSettings class.
  Use this property if you want to add clickable areas to the
  tooltip. Also added the ToolTipLinkClicked event to C1Ribbon
  and C1StatusBar. The event is fired when the user clicks a
  hyperlink in the tooltip (TFS 27829).
  
  Press and hold the Control key to keep the tooltip visible
  while the mouse pointer hovers the hyperlink.

==================================================================
C1Ribbon Build 2/4.0.20122.404      Build Date: September 10, 2012
==================================================================

- Fixed an issue: the RibbonTabs font color became white when
  a user maximized the main C1RibbonForm on Windows Vista.

==================================================================
C1Ribbon Build 2/4.0.20122.403       Build Date: September 7, 2012
==================================================================

- Fixed an issue: Different behavior is observed between tooltips
  and Ribbon Items's text when LTR text is mixed with RTL text
  and the RightToLeft property is set to 'Yes' (TFS 27665).

==================================================================
C1Ribbon Build 2/4.0.20122.402       Build Date: September 5, 2012
==================================================================

- Fixed an issue: the bullet and numbered items aren't displayed
  properly in a tooltip after setting the RightToLeft property
  to 'Yes' (TFS 27646).

==================================================================
C1Ribbon Build 2/4.0.20122.401       Build Date: September 3, 2012
==================================================================

- Fixed an issue: incorrect text is rendered in tooltips and in
  application submenu descriptions if some LTR chars are mixed
  with RTL text and the RightToLeft property is set to 'Yes'.

==================================================================
C1Ribbon Build 2/4.0.20122.400         Build Date: August 15, 2012
==================================================================

- Added VS2012 toolbox icons.

==================================================================
C1Ribbon Build 2/4.0.20122.398          Build Date: August 8, 2012
==================================================================

- Fixed an issue in RibbonDatePicker, RibbonTimePicker, and
  RibbonNumericBox: text label doesn't appear correctly on a
  RibbonConfigToolBar with any of the Office2010 visual styles
  under Windows 7 Aero theme (TFS 24834).

==================================================================
C1Ribbon Build 2/4.0.20122.397          Build Date: August 7, 2012
==================================================================

- Fixed an issue in the RibbonLabel element: it doesn't appear
  correctly on a RibbonConfigToolBar with any of the Office2010
  visual styles under Windows 7 Aero theme.

- Added a few missed Japanese localization strings.

==================================================================
C1Ribbon Build 2/4.0.20122.396          Build Date: August 1, 2012
==================================================================

- Fixed an issue: C1RibbonForm is not posting WM_SYSCOMMAND
  messages properly when the user clicks the child window
  buttons that are being drawn on the Ribbon when an MDI child
  is maximized.

==================================================================
C1Ribbon Build 2/4.0.20122.395           Build Date: July 21, 2012
==================================================================

- Fixed an issue in the RibbonApplicationMenu class: if an image
  of non-standard size (neither 16x16 nor 32x32) is assigned to
  the LargeImage or SmallImage properties of RibbonApplicationMenu
  the bottom part of the application button appears incorrectly
  in the application menu dropdown (TFS 24257).

==================================================================
C1Ribbon Build 2/4.0.20122.394           Build Date: July 18, 2012
==================================================================

- Added the AllowContextMenu property to the C1Ribbon control 
  (True by default). The property specifies whether the special
  context menu should appear when a user clicks the Ribbon with
  the right mouse button (TFS 24203).

==================================================================
C1Ribbon Build 2/4.0.20122.393           Build Date: July 12, 2012
==================================================================

- Fixed an issue: an attempt to display a modal dialog box
  from the RibbonComboBox.ChangeCommitted event handler causes
  an ObjectDisposedException (TFS 24039).

==================================================================
C1Ribbon Build 2/4.0.20122.392           Build Date: July 10, 2012
==================================================================

- Fixed an issue in RibbonComboBox: the ChangeCommitted event
  is not fired when the RibbonComboBox looses the input focus.

==================================================================
C1Ribbon Build 2/4.0.20122.391            Build Date: July 6, 2012
==================================================================

- Added a few preset images to be used in conjunction with the
  C1GanttView control. Their names start with 'Gantt' prefix.

==================================================================
C1Ribbon Build 2/4.0.20122.390            Build Date: July 4, 2012
==================================================================

- Fixed an issue: If the Display color is changed to High Color
  (16 bit) while the RibbonForm is on display, the rendering and
  the behavior become incorrect (TFS 23805).

- Fixed an issue: an ArgumentException is observed sometimes
  after minimizing the ribbon form under Windows 7 Basic/Classic
  Themes (TFS 23838).

==================================================================
C1Ribbon Build 2/4.0.20122.388           Build Date: June 25, 2012
==================================================================

- Fixed issue 23556: item text is clipped on setting the Font
  property of RibbonMenu/RibbonSplitButton if its dropdown was
  opened once before setting the new font.

- Fixed an issue: unlike the previous builds, focus is moved
  to the first control of RibbonGroup after editing in other
  controls (TFS 23561).

==================================================================
C1Ribbon Build 2/4.0.20122.387           Build Date: June 20, 2012
==================================================================

- Fixed issue 23486: on opening a modal window from a button
  placed in a Ribbon group, the highlighting does not get removed
  from Ribbon group.

==================================================================
C1Ribbon Build 2/4.0.20122.386           Build Date: June 18, 2012
==================================================================

- Fixed issue 23442: the user can't add a new Tab or
  ContextualTabGroup using the SmartDesigner when two or more
  C1Ribbon controls are placed inside a TabControl.

- Fixed issue 23449: Unlike C1StatusBar, C1Ribbon layout is not
  affected by changing the RightToLeft property value.

==================================================================
C1Ribbon Build 2/4.0.20122.385           Build Date: June 18, 2012
==================================================================

- Added the MinTextWidth property to RibbonLabel. The property
  specifies the minimum width of label text, in pixels.

==================================================================
C1Ribbon Build 2/4.0.20122.384            Build Date: June 8, 2012
==================================================================

- Fixed an issue in C1Ribbon: when C1Ribbon.ApplicationMenu is
  visible and its Win7Look property is set to false, the owner
  C1RibbonForm has no border and RibbonQat.BelowRibbon is set to
  true, then the height of ribbon tabs increases and all
  contextual tab headers disappear (TFS 23228).

==================================================================
C1Ribbon Build 2/4.0.20122.383            Build Date: June 7, 2012
==================================================================

- Fixed an issue in C1Ribbon: when the KeyTips property is set
  in MDI form and the Alt key is pressed, once the key tips are
  displayed after clicking on the child form again, the key
  events are not fired for child form anymore (see TFS 23019).

==================================================================
C1Ribbon Build 2/4.0.20122.382            Build Date: June 5, 2012
==================================================================

- The AllowSelection property of RibbonButton has been renamed
  to SelectableInListItem. The old property is still available
  at runtime for backward compatibility.

==================================================================
C1Ribbon Build 2/4.0.20121.381            Build Date: June 4, 2012
==================================================================

- Fixed an issue in C1RibbonForm: if an MDI parent form derives
  from C1RibbonForm and the Alt key is pressed in a child ribbon
  form, KeyTips are not displayed in the child form (TFS 23102).

==================================================================
C1Ribbon Build 2/4.0.20121.380            Build Date: May 31, 2012
==================================================================

- Breaking change: the default value for the Selectable property
  of C1Ribbon and C1StatusBar controls has been changed from True
  to False to get rid of the issues with input focus (TFS 23019).

- C1StatusBar can now partly display the ribbon label's text if
  there is not enough space for displaying the whole text. Also,
  it displays text that extends beyond the width of the label
  when the user passes over the lable with the mouse (TFS 23040).

==================================================================
C1Ribbon Build 2/4.0.20121.379            Build Date: May 30, 2012
==================================================================

- Fixed an issue in C1RibbonForm: Key events for MDI child form
  are not fired after the child form has been maximized and then
  restored to the normal state (TFS 23019).

==================================================================
C1Ribbon Build 2/4.0.20121.378            Build Date: May 29, 2012
==================================================================

- Fixed an issue in C1RibbonForm: NullReferenceException is
  observed after pressing the F10 key in a child ribbon form when
  the CaptureF10Key property is set to False (TFS 22982).

==================================================================
C1Ribbon Build 2/4.0.20121.377            Build Date: May 21, 2012
==================================================================

- Fixed an issue in C1Ribbon: a NullReferenceException occurred
  at design time, when setting the Small/LargeImage properties of
  a ribbon element which is added directly to QAT, i.e. doesn't
  belong to any ribbon group or ribbon menu (TFS 22510).

==================================================================
C1Ribbon Build 2/4.0.20121.375            Build Date: May 17, 2012
==================================================================

- Added the CaptureF10Key boolean property to C1Ribbon (True by
  default). The property indicates whether the F10 key can be
  used for displaying KeyTips. If the value of the property is
  False the F10 key can be captured by user code (TFS 22395).

==================================================================
C1Ribbon Build 2/4.0.20121.374            Build Date: May 15, 2012
==================================================================

- Added a new property to the RibbonGroup component:

  public bool TrimLongCaption { get; set; }
  
  The property specifies whether the group caption should be
  trimmed if it is longer than the contents of the group.

==================================================================
C1Ribbon Build 2/4.0.20121.373             Build Date: May 3, 2012
==================================================================

- Fixed an issue: if the drop-down portion of a RibbonComboBox
  was opened once and the system date was changed to a lower
  date (i.e. less the current date), then after clicking on the
  drop-down button of RibbonComboBox once again, the drop-down
  portion does not appear any more. The same issue also occured
  for RibbonMenu, RibbonDatePicker, and other elements having
  a drop-down portion (TFS 21522).

- Fixed a few show-stopper issues that were introduced in the
  previous build (372).

==================================================================
C1Ribbon Build 2/4.0.20121.372          Build Date: April 30, 2012
==================================================================

- Fixed an issue: a NullReferenceException occurred when loading
  a Ribbon definition from an XML file.

==================================================================
C1Ribbon Build 2/4.0.20121.371          Build Date: April 23, 2012
==================================================================

- Fixed an issue: ArgumentOutOfRangeException was observed when
  the RestrictedGroupSizing property is set to False and there is
  a button which text ends with the '&' character (TFS 21240).

==================================================================
C1Ribbon Build 2/4.0.20121.370           Build Date: April 4, 2012
==================================================================

- Removed the "First-chance" exception that was thrown during
  the application start-up after setting "Enable unmanaged code
  debugging" on Debug tab of the project options (TFS 15044).

==================================================================
C1Ribbon Build 2/4.0.20121.369          Build Date: March 28, 2012
==================================================================

- Fixed a regression issue: InputBox and MessageBox can't be
  displayed from the Click event of a ribbon button which appears
  in a menu and has the AllowSelection property set to true. The
  issue was introduced in build 2/4.0.20112.339 (TFS 20904).

==================================================================
C1Ribbon Build 2/4.0.20121.368          Build Date: March 12, 2012
==================================================================

- Fixed a bug: empty title bar gets displayed on top of C1Ribbon
  even if the FormBorderStyle property of the owner C1RibbonForm
  is set to None (TFS 20499).

==================================================================
C1Ribbon Build 2/4.0.20121.367           Build Date: March 2, 2012
==================================================================

- Fixed a bug: RibbonToggleButton became pressed after maximizing
  a C1RibbonForm by double-clicking its title bar if this toggle
  button appears under the mouse pointer.

==================================================================
C1Ribbon Build 2/4.0.20121.366       Build Date: February 21, 2012
==================================================================

- Improved text wrapping for Japanese/Chinese/Korean text
  (TFS 18535).

==================================================================
C1Ribbon Build 2/4.0.20121.364       Build Date: February 10, 2012
==================================================================

- Fixed an issue in RibbonToggleButton: toggle buttons with the
  same non-empty value of the ToggleGroupName property were not
  mutually exclusive if they belong to different RibbonToolBars
  which are located on the same RibbonGroup.

- A small change to the RibbonItem Collection Editor: the item
  names become visible in the item list (at the left part of the
  collection editor window).

==================================================================
C1Ribbon Build 2/4.0.20121.363        Build Date: January 23, 2012
==================================================================

- Fixed an issue with displaying reversed text in tooltips when
  the RightToLeft property is set to 'Yes' and RightToLeftLayout
  is set to True for a C1RibbonForm (TFS 19475).

==================================================================
C1Ribbon Build 2/4.0.20121.362        Build Date: January 19, 2012
==================================================================

- Added Persian (Farsi) strings for runtime localization.

==================================================================
C1Ribbon Build 2/4.0.20121.361        Build Date: January 18, 2012
==================================================================

- Added the MenuVisible boolean property to the RibbonQat class.
  The property specifies whether the 'Customize QAT' drop-down
  button is visible (TFS 19394).

==================================================================
C1Ribbon Build 2/4.0.20121.360        Build Date: January 16, 2012
==================================================================

- Fixed a bug: if the parent control for a C1Ribbon or C1StatusBar
  is not a Form (for example, if they lie on a Panel control which
  lies on a C1RibbonForm) changing VisualStyle for the owner
  C1RibbonForm did not affect the visual style of the C1Ribbon
  and C1StatusBar controls.

==================================================================
C1Ribbon Build 2/4.0.20121.359        Build Date: January 13, 2012
==================================================================

- Fixed an issue in C1Ribbon: the MDI child form's buttons were
  not displayed on C1Ribbon when the user maximizes the child
  form if the ribbon which has no visible tabs or items on the
  config toolbar and it has the RibbonApplicationMenu.Visible
  property set to false (TFS 19297).

==================================================================
C1Ribbon Build 2/4.0.20113.357       Build Date: December 27, 2011
==================================================================

- Fixed an issue: maximized or minimized child form is restored
  after changing the Windows Color Theme when a C1RibbonForm is
  displayed as MDI parent (TFS 19019).

==================================================================
C1Ribbon Build 2/4.0.20113.355       Build Date: December 14, 2011
==================================================================

- Fixed an issue in C1Ribbon: if a C1RibbonForm is displayed as
  MDI child form it loses the input focus after displaying
  KeyTips for the Ribbon control (TFS 18813).

==================================================================
C1Ribbon Build 2/4.0.20113.354       Build Date: December 13, 2011
==================================================================

- Fixed an issue in C1RibbonForm. It caused the ArgumentException
  (occasionally) when a standard MessageBox window appears before
  displaying a C1RibbonForm. The problem was introduced in the
  build 2/4.0.20113.344.

==================================================================
C1Ribbon Build 2/4.0.20113.353       Build Date: November 30, 2011
==================================================================

- Updated licensing to conform with Federal Information Processing
  Standards requirements (TFS 18562).

==================================================================
C1Ribbon Build 2/4.0.20113.351        Build Date: November 4, 2011
==================================================================

- Fixed an issue: when the active MDI Child is not derived from
  C1RibbonForm and it is maximized in an MDI container form that
  is derived from C1RibbonForm the following problem occurs under
  Windows Classic theme - changing the caption text (Form.Text)
  on the MDI Child form doesn't affect the text in the title of
  the container form, i.e. MDI Parent caption (TFS 18206).

==================================================================
C1Ribbon Build 2/4.0.20113.350        Build Date: November 1, 2011
==================================================================

- Fixed an issue: when a C1RibbonForm is displayed as MDI child
  with a C1Ribbon control on it, the form title bar disappears
  after removing the Ribbon control from the Controls collection
  of C1RibbonForm. See the following code, for example:
  
  private void ChildRibbonForm_Load(object sender, EventArgs e)
  {
      this.Controls.Remove(c1Ribbon1);
  }
  
  The issue only occurs with Windows Basic and Classic themes.

==================================================================
C1Ribbon Build 2/4.0.20113.349         Build Date: October 5, 2011
==================================================================

- Fixed issue: a NullReferenceException is observed at design
  time when removing groups from a not selected tab in the
  collection editor, then selecting the tab (TFS 17582).

==================================================================
C1Ribbon Build 2/4.0.20113.348         Build Date: October 4, 2011
==================================================================

- Fixed issue: a NullReferenceException is observed at design
  time when adding groups to a not selected ribbon tab with the
  collection editor and selecting this tab in the designer
  (TFS 17582).

==================================================================
C1Ribbon Build 2/4.0.20113.347         Build Date: October 3, 2011
==================================================================

- Fixed issue: a popup RibbonTab appears outside of the owner
  ribbon form when the form uses right-to-left layout and is
  resized to smaller size (TFS 17538).

- Fixed issue: an MDI child form disappears on maximizing it in
  a maximized C1RibbonForm used as MDI container if these two
  forms have different values of the RightToLeftLayout property
  (TFS 17539).

==================================================================
C1Ribbon Build 2/4.0.20113.346      Build Date: September 30, 2011
==================================================================

- Fixed an issue: C1Ribbon localization has no effect at runtime
  if the default namespace of the application project is not the
  same as the output assembly name.

==================================================================
C1Ribbon Build 2/4.0.20113.345      Build Date: September 29, 2011
==================================================================

- The RightPaneWidth property of C1StatusBar now returns the
  current width of the right pane at runtime if it was set to -1
  at design time (TFS 17453).

- If the F10 key is assigned as a shortcut to RibbonButton or
  RibbonSplitButton in C1Ribbon or C1StatusBar controls the F10
  key won't activate the Ribbon KeyTips anymore. Only the Alt
  key remains as a method of activating the KeyTips (TFS 17444).

==================================================================
C1Ribbon Build 2/4.0.20113.344      Build Date: September 28, 2011
==================================================================

- Re-added the RightToLeftLayout property to C1RibbonForm (this
  property was hidden in the previous builds).

- The RightToLeft property now affects the layout of C1Ribbon and
  C1StatusBar controls (TFS 15406). It works so if the owner
  C1RibbonForm has RightToLeftLayout set to true.

==================================================================
C1Ribbon Build 2/4.0.20112.342         Build Date: August 23, 2011
==================================================================

- Fixed an issue: the '&' character does not get displayed for
  items of the dropdown list in RibbonComboBox (TFS 16860).

- Fixed an issue: ribbon items are not refreshed when adding new
  items or removing existing items at the 3 level of a RibbonMenu
  or RibbonSplitButton for the second time (TFS 16855).

- Fixed an issue: Key Tips are still displayed although the
  corresponding ribbon items are beyond the visible scope in a
  scrollable menu (TFS 16856).

==================================================================
C1Ribbon Build 2/4.0.20112.341         Build Date: August 19, 2011
==================================================================

- Fixed a bug: “A generic error occurred in GDI+” exception is
  thrown sometimes when scrolling the list of available fonts in
  the drop-down portion of RibbonFontComboBox (TFS 16788).

==================================================================
C1Ribbon Build 2/4.0.20112.340           Build Date: July 11, 2011
==================================================================

- Fixed issue 16199 (a NullReferenceException is thrown after
  pressing the Enter key in a dropped down RibbonDatePicker).
  The issue was introduced in the previous build (339).

==================================================================
C1Ribbon Build 2/4.0.20112.339            Build Date: July 5, 2011
==================================================================

- Now the internal popup forms are disposed each time when the
  user closes the corresponding popup menu or a drop-down element.
  In the previous builds the value of Application.OpenForms.Count
  might grow while the application is running because the popup
  forms were not disposed until the RibbonForm is closed.

- Fixed issue 15576: QAT is displayed in C1Ribbon although ribbon
  items are not added in the QAT.

==================================================================
C1Ribbon Build 2/4.0.20112.338            Build Date: June 9, 2011
==================================================================

- Added the ReadOnly boolean property to the following ribbon
  elements: RibbonTimePicker, RibbonDatePicker, RibbonNumericBox,
  RibbonTextBox, RibbonComboBox. The property specifies whether
  the contents of the component can be changed by the user.

- Removed dummy XML comments from some protected methods.

==================================================================
C1Ribbon Build 2/4.0.20112.337            Build Date: June 2, 2011
==================================================================

- Removed a white line that appeared inside the QAT when there
  is no ribbon item added (TFS 15576).

==================================================================
C1Ribbon Build 2/4.0.20112.336            Build Date: May 18, 2011
==================================================================

- Fixed issue 15355 (C1Ribbon has to be deactivated twice with
  Report Designer License Key).

==================================================================
C1Ribbon Build 2/4.0.20112.335            Build Date: May 12, 2011
==================================================================

- Fixed issue 15314 (C1Ribbon tabs' height is increased when the
  BelowRibbon property is set to true for the QAT and a regular
  Form is used as the parent for the C1Ribbon control).

==================================================================
C1Ribbon Build 2/4.0.20112.334            Build Date: May 11, 2011
==================================================================

- Fixed issue 15307 (Contextual Tabs are not displayed if the
  QAT appears below the Ribbon and a regular Form is used as
  the parent for the Ribbon control).

==================================================================
C1Ribbon Build 2/4.0.20111.332             Build Date: May 6, 2011
==================================================================

- Some minor improvements to a RibbonNumericBox (see the related
  issue 15209 in C1InputPanel).

- Added a few Japanese strings for design-time localization.

==================================================================
C1Ribbon Build 2/4.0.20111.331             Build Date: May 3, 2011
==================================================================

- Added the new SupportsKeyTips property to the Ribbon control.
  The property indicates whether the Ribbon can show KeyTips when
  the user presses the Alt/F10 keys. It may be useful for old
  applications which aren't compatible with the KeyTip concept.

==================================================================
C1Ribbon Build 2/4.0.20111.330          Build Date: April 27, 2011
==================================================================

- Fixed an issue: "1.123456789e-5" and "1.123456789e5" values
  are not formatted in a RibbonNumericBox although the Format
  property is set to "G5".

==================================================================
C1Ribbon Build 2/4.0.20111.329          Build Date: April 22, 2011
==================================================================

- Fixed an issue: Overflow Exception was thrown after typing
  '1e+60' into a RibbonNumericBox.

==================================================================
C1Ribbon Build 2/4.0.20111.328          Build Date: April 10, 2011
==================================================================

- Fixed issue 14962 (Drop-down portion of a RibbonComboBox
  remains visible after navigating to another RibbonTab using
  KeyTips or by pressing the 'Ctrl+Tab' keys).

- Fixed a bug in RibbonNumericBox: IndexOutOfRangeException was
  thrown after typing more than 29 digits into the numeric box.

- Fixed sporadic incorrect highlighting of a RibbonComboBox and
  other components with text edit portion when a user performs
  some actions using the keyboard.

- Ribbon templates slightly updated.

==================================================================
C1Ribbon Build 2/4.0.20111.326           Build Date: April 5, 2011
==================================================================

- Fixed issue 14908 (Hiding and showing some Ribbon elements via
  the "Hide/Show Ribbon Items" designer do not work properly).

- Fixed issue 14911 (When copying and pasting a C1Ribbon control,
  contextual tab groups are not added to the newly pasted Ribbon).

- Fixed a bug in C1StatusBar: opening a form with a C1StatusBar
  in Visual Studio 2010 designer shows the form as changed. To
  get rid of this you have to save such a form once using a new
  C1Ribbon build (326 or newer).

- Added a few Japanese strings for design-time localization.

==================================================================
C1Ribbon Build 2/4.0.20111.325           Build Date: April 4, 2011
==================================================================

- Fixed issue 14896 (Tooltips don't appear for any ribbon items
  anymore after restoring C1Ribbon from the minimized state by
  double-clicking a ribbon tab).

==================================================================
C1Ribbon Build 2/4.0.20111.324           Build Date: April 1, 2011
==================================================================

- Fixed issue 14858 ('MouseEnter' and 'MouseLeave' events aren't
  fired or fired incorrectly for the following ribbon elements:
  RibbonGroup, RibbonTextBox, RibbonDatePicker, RibbonTimePicker,
  RibbonComboBox, RibbonNumericBox).

- Fixed issue 14866 (On clicking a minimized tab on a form
  displayed slightly out of the screen, the tab gets displayed
  outside the ribbon form).

- Fixed a bug that occurs when a C1Ribbon is hosted in a regular
  Form (not C1RibbonForm): a double click on a minimized ribbon
  tab hides QAT items and shows the QAT chevron button.

==================================================================
C1Ribbon Build 2/4.0.20111.323          Build Date: March 31, 2011
==================================================================

- Fixed issue 14857 (Even after closing the main form the
  application does not end - its process continues working if
  any popup form displayed while the main form was open.
  This issue only occurs when [Application | Shutdown mode] is
  set to [when the Last form closes] in project settings of
  a Visual Basic project).

==================================================================
C1Ribbon Build 2/4.0.20111.322          Build Date: March 29, 2011
==================================================================

- Fixed issue 14808 (Click event is not fired after clicking
  with the mouse a RibbonToogleButton, RibbonSplitButton, or
  RibbonButton in the application menu displayed with KeyTips).

- Fixed issue 14809 (After deleting a RibbonContextualTabGroup
  using its Dispose method the associated RibbonGroups are not
  removed automatically from QAT and HOT lists).

- Fixed issue 14823 (RibbonTrackBar is visible on a C1StatusBar
  even when setting "Visible = False" in a certain scenario).

==================================================================
C1Ribbon Build 2/4.0.20111.321          Build Date: March 24, 2011
==================================================================

- Fixed a few small issues that prevented using a C1Ribbon and
  C1StatusBar in the WindowFormsHost WPF element.

==================================================================
C1Ribbon Build 2/4.0.20111.320          Build Date: March 23, 2011
==================================================================

- Fixed a potential issue that may occur on a machine with
  multiple installed versions of C1Ribbon for .NET 4.x and its
  designer dll (C1.Win.C1Ribbon.4.Design.dll).

==================================================================
C1Ribbon Build 2/4.0.20111.319          Build Date: March 22, 2011
==================================================================

- Fixed issue 14734 (Only 'Localize..' link is shown in Smart
  Tag when accessed at run time).

==================================================================
C1Ribbon Build 2/4.0.20111.318          Build Date: March 21, 2011
==================================================================

- Fixed issue 14724 (checking/unchecking RibbonContextualTabGroup
  items did not work correctly in 'C1Ribbon-Hide/Show Ribbon Item'
  window).

- Fixed issue 14727 (when setting 'BelowRibbon' to True for QAT
  at design time, QAT is shown above the Ribbon at run time).

==================================================================
C1Ribbon Build 2/4.0.20111.317          Build Date: March 17, 2011
==================================================================

- C1.Win.C1Ribbon.2.dll and C1.Win.C1Ribbon.2.Design.dll are
  combined into a single dll (C1.Win.C1Ribbon.2.dll) to avoid
  issues when multiple versions of C1Ribbon and its designer
  dll are installed on the same machine. This change doesn't
  affect the version of C1Ribbon for .NET 4.x.

==================================================================
C1Ribbon Build 2/4.0.20111.316           Build Date: March 7, 2011
==================================================================

- Added the DropDownAlign property to RibbonComboBox, RibbonMenu,
  RibbonSplitButton, RibbonDatePicker, and RibbonGallery. The
  property sets the alignment of the drop-down portion relative
  to the given component.

- Added the KeyTip property to a RibbonListItem. Items of the
  'Recent Documents' list at the right pane of the application
  menu are now accessible by their KeyTips.

- Fixed a bug: item images did not appear in the drop-down list
  of a RibbonComboBox.

- Slightly updated the C1RibbonApplication project template.

==================================================================
C1Ribbon Build 2/4.0.20111.315       Build Date: February 23, 2011
==================================================================

- Added the Font and ForeColor properties to the contextual tab
  group object (RibbonContextualTabGroup component).

- C1Ribbon Application templates are slightly updated.

==================================================================
C1Ribbon Build 2/4.0.20111.314       Build Date: February 22, 2011
==================================================================

- Added a few Japanese strings for design-time localization.

==================================================================
C1Ribbon Build 2/4.0.20111.313       Build Date: February 22, 2011
==================================================================

- Fixed a few minor bugs.

==================================================================
C1Ribbon Build 2/4.0.20111.312       Build Date: February 21, 2011
==================================================================

- Improved the speed of KeyTips showing up under the Aero theme.

- Updated the Ribbon Application templates (added KeyTips to all
  ribbon items).

==================================================================
C1Ribbon Build 2/4.0.20111.311       Build Date: February 21, 2011
==================================================================

- Now you can display KeyTips for ribbon items after pressing
  the Alt or F10 key in a C1RibbonForm with the C1Ribbon control.
  Added the KeyTip property to RibbonButton, RibbonTab, and other
  ribbon items. Also, added the GroupKeyTip and LauncherKeyTip
  properties to the RibbonGroup component.

- Improved appearance of text labels on the Quick Access Toolbar.

- RibbonGroup.ToolTip property renamed to LauncherToolTip. The
  old property is now hidden but still available for backward
  compatibility.

- Added the GroupToolTip property to RibbonGroup. The property
  specifies the tooltip string for a collapsed group button or
  a group button on the QAT.

- Added the Active property to the ToolTipSettings class. The
  property indicates whether the tooltip is currently active.

==================================================================
C1Ribbon Build 2/4.0.20111.309        Build Date: January 24, 2011
==================================================================

- Fixed issue 14249 (the contents of the selected RibbonTab in a
  RibbonContextualTabGroup is still visible although the Visible
  property of the ContextualTabGroup is set to False).

==================================================================
C1Ribbon Build 2/4.0.20111.308        Build Date: January 20, 2011
==================================================================

- Fixed issue 14218 (an error is observed after adding a
  ContextualTabGroup with one or more Tabs from the Collection
  Editor, then cancelling this operation).

- Added a few Japanese strings for design-time localization.

==================================================================
C1Ribbon Build 2/4.0.20111.307        Build Date: January 18, 2011
==================================================================

- Fixed issue 14204 (inconsistency is observed between border
  color of the ribbon tabs at design time and at runtime when
  C1Ribbon’s VisualStyle is set to Windows7).

==================================================================
C1Ribbon Build 2/4.0.20111.305        Build Date: January 18, 2011
==================================================================

- Added the Color property to the RibbonTab component. The new
  property allows changing color of individual tabs.

  public RibbonTabColor Color { get; set; }

- Fixed issue 14192 (the 'More controls' QAT popup window
  disappears while opening QAT menu after clicking on Ribbon
  Numeric updown button).

==================================================================
C1Ribbon Build 2/4.0.20111.304        Build Date: January 17, 2011
==================================================================

- Fixed a problem with drawing the 'More controls' button (next
  to the QAT) for the first time.

- Fixed a bug: an incorrect element appeared at the end of the
  tabs row after deleting a contextual tab group.

- Fixed a bug: RibbonNumericBox and RibbonDatePicker components
  were not editable if they are located on a contextual tab.

==================================================================
C1Ribbon Build 2/4.0.20111.300        Build Date: January 14, 2011
==================================================================

- Added the ContextualTabGroups property to C1Ribbon. This is
  the collection of RibbonContextualTabGroup components. Each
  tab group can contain a few RibbonTabs. The contextual tab
  groups appear in the title of C1RibbonForm.

- Added the special 'More controls' button next to the Quick
  Access Toolbar. The button displays a popup window with more
  QAT items which were hidden because of lack of space.

- Changed the order in which ribbon groups are collapsed when
  resizing the ribbon. Now the right-most group collapses first,
  followed by the next right-most group, and so on.

==================================================================
C1Ribbon Build 2/4.0.20103.299       Build Date: December 28, 2010
==================================================================

- Added the MaxTextWidth property to the RibbonLabel component
  (0 by default - no restrictions). The property sets the maximum
  width of the label text, in pixels. The ellipsis character (...)
  appears at the right edge of the label, denoting that the text
  width extends beyond the specified width.

- Fixed a bug: an InvalidOperationException was thrown if visual
  styles are not applied to the client area of application windows
  (for example, if Application.VisualStyleState = NoneEnabled).

==================================================================
C1Ribbon Build 2/4.0.20103.298       Build Date: December 17, 2010
==================================================================

- Added the Selectable boolean property to C1Ribbon and
  C1StatusBar. The property indicates whether the control can
  receive the input focus (it's True by default).

==================================================================
C1Ribbon Build 2/4.0.20103.297        Build Date: December 9, 2010
==================================================================

- Fixed issue 13565 (Unhandled exception seen when using QAT
  mnemonic character (Alt+S) for the second time).

==================================================================
C1Ribbon Build 2/4.0.20103.296        Build Date: December 1, 2010
==================================================================

- Fixed a minor drawing issue at the bottom left/right corners
  of C1StatusBar "wearing" the Office2010Silver visual style.

- Fixed a minor layout issue with drawing the icon for an MDI
  child form under the "Windows Aero" color theme.

- Updated editor for the ToolTip property of various components.

- The MDI window switching code became more generalized in the
  C1Ribbon Application template.

==================================================================
C1Ribbon Build 2/4.0.20103.295       Build Date: November 25, 2010
==================================================================

- Fixed a bug: the title bar of C1RibbonForm may be corrupted
  after changing Form's visual style from Office2010 to Windows7
  (or vice versa) while C1Ribbon is in minimized state.

- Fixed an issue: all semi-transparent pixels appeared as black
  in the form icon if C1RibbonForm.VisualStyle is Office2010 or
  Windows7 or if RibbonApplicationMenu.Win7Look is True.

- Ribbon templates are updated. Changed appearance and behavior
  of the "Minimize Ribbon" button on the ConfigToolBar panel.

==================================================================
C1Ribbon Build 2/4.0.20103.294       Build Date: November 15, 2010
==================================================================

- Added Japanese localization string for the MouseUp event of
  RibbonTrackBar.

==================================================================
C1Ribbon Build 2/4.0.20103.293       Build Date: November 13, 2010
==================================================================

- Fixed issue 13290 (Flickering occurs on resizing the form by
  dragging the grip section of the status bar). It occurred in
  Japanese Windows XP only.

==================================================================
C1Ribbon Build 2/4.0.20103.292        Build Date: November 9, 2010
==================================================================

- Fixed a few problems in Accessibility (MSAA) implementation.

==================================================================
C1Ribbon Build 2/4.0.20103.291        Build Date: November 8, 2010
==================================================================

- Accessibility is now supported in C1Ribbon and C1StatusBar.

- Added the MouseUp event to RibbonTrackBar. It occurs when the
  mouse pointer is over the RibbonTrackBar and the left mouse
  button is released.

==================================================================
C1Ribbon Build 2/4.0.20103.289        Build Date: October 25, 2010
==================================================================

- Fixed a bug: when a user presses the Tab key and moves the
  input focus to another control from RibbonComboBox the combo
  box remains highlighted and its owner RibbonGroup becomes
  highlighted as well. The same problem occurs for other TextBox-
  based components, such as RibbonDatePicker, RibbonTimePicker,
  RibbonNumericBox, and RibbonTextBox.

- Fixed a bug: the application menu button appears as a tiny
  rectangle for 'Office2010' and 'Windows7' visual styles if the
  RibbonApplicationMenu.Text property contains an empty string.

==================================================================
C1Ribbon Build 2/4.0.20103.287        Build Date: October 19, 2010
==================================================================

- After dropping down a RibbonGallery with many items it did not
  scroll to the selected item if this item was out of the visible
  scope.

- A small change in behavior of RibbonGallery: assigning the same
  value to RibbonGallery.SelectedIndex scrolls the gallery to the
  selected item (there were no actions in previous builds after
  setting the SelectedIndex property to the same value).

==================================================================
C1Ribbon Build 2/4.0.20103.286        Build Date: October 15, 2010
==================================================================

- Fixed a crash in Visual Studio when a user clicks "Change
  Ribbon's Visual Style" button on C1Ribbon's floaty toolbar
  at design time.

==================================================================
C1Ribbon Build 2/4.0.20103.284        Build Date: October 14, 2010
==================================================================

- Improved appearance of the ribbon caption area when applying
  the following visual styles: Office2010Black, Office2010Blue,
  and Office2010Silver.

- Changed background color for Windows7 style of C1StatusBar.

- Added Japanese localization string for the ColoredButton
  property of RibbonApplicationMenu.

==================================================================
C1Ribbon Build 2/4.0.20103.283        Build Date: October 12, 2010
==================================================================

- Fixed issue 13048 (Status Bar of C1Ribbon gets Clipped at both
  design time and run time).

==================================================================
C1Ribbon Build 2/4.0.20103.282        Build Date: October 11, 2010
==================================================================

- Added the following items to the VisualStyle enumeration:
  Office2010Black, Office2010Blue, Office2010Silver, Windows7.

- Added the ColoredButton property to RibbonApplicationMenu.
  This property sets the color of the application menu button.

- The RibbonColorPicker.Themes property has been renamed to
  OfficeColorPalette. The same property of RibbonColorPickerItem
  has also been renamed. This change doesn't affect backward
  compatibility.
  
- The C1Ribbon.HotTransitionEffect property has no effect in the
  current version and becomes hidden. It will be reintroduced in
  subsequent releases.

==================================================================
C1Ribbon Build 2/4.0.20102.280      Build Date: September 27, 2010
==================================================================

- Fixed issue 12896 (Painting issue is observed when form is
  resized using 'C1StatusBar' grip).

==================================================================
C1Ribbon Build 2/4.0.20102.279         Build Date: August 31, 2010
==================================================================

- Fixed issue 12462 (System.ComponentModel.Win32Exception is
  thrown when the End command is executed from the Form.Load
  event of a C1RibbonForm).

==================================================================
C1Ribbon Build 2/4.0.20102.278          Build Date: August 6, 2010
==================================================================

- Fixed a bug: an ArgumentOutOfRangeException occurred if the
  RibbonApplicationMenu.BottomPaneItems collection is empty and
  the user presses the Left or Right arrow keys after dropping
  down the application menu.

==================================================================
C1Ribbon Build 2/4.0.20102.277          Build Date: August 3, 2010
==================================================================

- Fixed a bug: setting the RibbonGalleryItem.LargeImage property
  to a bitmap has no effect since build 264.

==================================================================
C1Ribbon Build 2/4.0.20102.276           Build Date: July 26, 2010
==================================================================

- Fixed issue 11918 (Shadow appears on the top of RibbonComboBox
  if the environment is Windows 2000).

==================================================================
C1Ribbon Build 2/4.0.20102.275           Build Date: July 22, 2010
==================================================================

- Fixed an issue introduced in build 2.0.20093.215: minimizing
  then restoring a C1RibbonForm with a C1Ribbon control on it
  shows a Form of zero size under Windows Aero color theme.

==================================================================
C1Ribbon Build 2/4.0.20102.274            Build Date: July 1, 2010
==================================================================

- Fixed issue 11485 (First control in C1StatusBar disappears when
  Layout is saved and loaded in the same StatusBar).

==================================================================
C1Ribbon Build 2/4.0.20102.273           Build Date: June 30, 2010
==================================================================

- Fixed issue 11455 (SmallImageIndex/Key and LargeImageIndex/Key
  set on RibbonItems cannot be changed on inherited Form).

- Fixed issue 11456 (Visual Studio stops working if LargeImage/
  SmallImage properties of RibbonItems are changed on a Form
  derived from a Form containing Ribbon).

==================================================================
C1Ribbon Build 2/4.0.20102.272           Build Date: June 29, 2010
==================================================================

- Fixed issue 11435 (Setting 'GripHandleVisible' to False removes
  the vertical scrollbar from the popup window when large number
  of items are present in RibbonGallery).

==================================================================
C1Ribbon Build 2/4.0.20102.271           Build Date: June 25, 2010
==================================================================

- Fixed issue 10756 (C1Ribbon 2.0 build gets added to VS toolbox
  when using .NET 4.0/3.5 Client Profile as Target Framework).

==================================================================
C1Ribbon Build 2/4.0.20102.270           Build Date: June 24, 2010
==================================================================

- Fixed an issue in the version of C1Ribbon for .NET 2.0 that
  prevented using this version after switching to '.NET 4.0' or
  '.NET 4.0 Client Profile' in the project settings. The form
  caption appeared in black when doing it with previous builds.

==================================================================
C1Ribbon Build 2/4.0.20102.269           Build Date: June 22, 2010
==================================================================

- Hidden a disabled scrollbar in ribbon gallery's popup window
  if the grip handle is not visible (GripHandleVisible = False).

==================================================================
C1Ribbon Build 2/4.0.20102.268           Build Date: June 11, 2010
==================================================================

- Fixed a bug: Images did not appear on Ribbon elements when the
  SmallImageList or LargeImageList properties are set at runtime.

==================================================================
C1Ribbon Build 2/4.0.20102.267            Build Date: June 8, 2010
==================================================================

- Fixed a bug that prevented using C1RibbonForm in Windows 98
  and other ANSI platforms.

==================================================================
C1Ribbon Build 2/4.0.20102.266            Build Date: May 31, 2010
==================================================================

- Added a few Japanese strings for design-time localization.

==================================================================
C1Ribbon Build 2/4.0.20102.265            Build Date: May 30, 2010
==================================================================

- Fixed a bug introduced in build 264: it was not possible to
  reset the SmallImageList and LargeImageList properties to
  null (Nothing in VB).

==================================================================
C1Ribbon Build 2/4.0.20102.264            Build Date: May 29, 2010
==================================================================

- Added the SmallImageList and LargeImageList properties to
  C1Ribbon and C1StatusBar:
  
  public ImageList SmallImageList { get; set; }
  public ImageList LargeImageList { get; set; }
  
  These properties allow to use an ImageList as the source of
  images to display on C1Ribbon and C1StatusBar.

- Added the SmallImageIndex and SmallImageKey properties to
  the RibbonGroup and RibbonTab components:
  
  public int SmallImageIndex { get; set; }
  public string SmallImageKey { get; set; }
  
  SmallImageIndex specifies the index of an image in the
  owner control's SmallImageList. The SmallImageKey property
  provides the image key (as a string).

- Added the following properties to the RibbonItem component:

  public virtual int SmallImageIndex { get; set; }
  public virtual string SmallImageKey { get; set; }
  public virtual int LargeImageIndex { get; set; }
  public virtual string LargeImageKey { get; set; }
  
  These properties specify the image index or the image string
  key in the owner control's SmallImageList or LargeImageList
  if these ImageLists are not null (Nothing in VB).

- Added the GripHandleVisible property to RibbonGallery:

  public bool GripHandleVisible { get; set; }

  This property indicates whether the dropped down gallery
  can be resized (True by default).

- Fixed issue 10006 (Clicking on FontComboBox shows a very small
  empty dropdown when ShouldDraw = False is set for all fonts in
  ShouldDrawFont event).

==================================================================
C1Ribbon Build 2/4.0.20102.263            Build Date: May 25, 2010
==================================================================

- Fixed issue 10946 (InvalidOperationException is thrown after
  closing running Form in which ribbonGallery is added to
  C1StatusBar control).

- Fixed issue 10953 (Error message is thrown on deleting a
  C1StatusBar which contains some ribbon items by pressing the
  Delete key on a keyboard).

- Fixed issue 10954 (Endless repainting occurs when many items
  are added to C1StatusBar).

- Fixed issue 10958 (ArgumentException is thrown on removing
  an item from RibbonFontComboBox.Items collection at runtime).

==================================================================
C1Ribbon Build 2/4.0.20102.262            Build Date: May 24, 2010
==================================================================

- Fixed issue 10935 (At Design time, multiple problems are seen
  when removing added ribbonGroup inside ribbonGroup collection
  editor).

==================================================================
C1Ribbon Build 2/4.0.20102.261            Build Date: May 22, 2010
==================================================================

- Fixed issue 10930 (When a disabled item is present in the
  main ApplicationMenu's submenu, then scrolling the mouse wheel
  up/down over the disabled item does not work).

- Fixed a small layout problem with very long popup groups which
  don't fit into the screen size (issue 10934).

==================================================================
C1Ribbon Build 2/4.0.20102.260            Build Date: May 21, 2010
==================================================================

- Fixed issue 10917 (The ToolTipSettings.Opacity property does
  not affect items in popup/drop-down windows, such as menus and
  collapsed groups).

- Fixed issue 10928 (Hovering back to main menu items is not
  possible after a submenu having items with long text has been
  opened).

==================================================================
C1Ribbon Build 2/4.0.20102.259            Build Date: May 20, 2010
==================================================================

- Fixed issue 10906 (NullReferenceException is thrown when
  RibbonGallery.Items.ClearAndDisposeItems() method is invoked).

- Addressed issue 10911 (In some cases, when unsupported items
  are added in Items collection, a NullReferenceException is
  observed instead of ArgumentException).

==================================================================
C1Ribbon Build 2/4.0.20102.257            Build Date: May 19, 2010
==================================================================

- Fixed issue 10893 (RibbonGallery is shown for a flash of a
  second and then closes, on opening it for the first time, when
  present inside some container controls).

- An ArgumentException was not fired since build 240 when a user
  tries to insert an unsupported item to any item collection.
  Now the exception is fired again when adding an item which is
  unacceptable for a given collection.

- Fixed a small problem with moving selection in a RibbonGallery
  using the arrow keys.

==================================================================
C1Ribbon Build 2/4.0.20102.256            Build Date: May 14, 2010
==================================================================

- Fixed issue 10832 (Japanese localized description is not shown
  for newly added property of C1Ribbon and this property is also
  added to C1StatusBar’s items where this property is not useful
  and affected in C1StatusBar).

==================================================================
C1Ribbon Build 2/4.0.20102.255            Build Date: May 14, 2010
==================================================================

- Added the CanBeAddedToQat boolean property to the RibbonGroup
  and RibbonItem components. The property specifies whether the
  user can add this item to the Quick Access Toolbar at runtime.
  If the value of this property is False the corresponding menu
  item will be disabled in the item's context menu.

- Minor changes to the ToolTip editor.

==================================================================
C1Ribbon Build 2/4.0.20102.254             Build Date: May 7, 2010
==================================================================

- Fixed issue 10736 (RibbonGallery’s selected item is not
  retained in visible items list after open and close action of
  ribbonGallery’s dropped list).

==================================================================
C1Ribbon Build 2/4.0.20102.253             Build Date: May 7, 2010
==================================================================

- Added a few Japanese strings for design-time localization.

==================================================================
C1Ribbon Build 2/4.0.20102.252             Build Date: May 6, 2010
==================================================================

- Added the Opacity property to the ToolTipSettings class:

  public double Opacity { get; set; }

  The property gets or sets the opacity of the tooltips between
  zero (totally transparent) and one (totally opaque).

- Fixed issue 10728 (ArgumentOutOfRangeException is thrown on
  adding the RibbonGroup to Quick Access Toolbar after calling
  RibbonGallery.Items.Clear() method).

==================================================================
C1Ribbon Build 2/4.0.20102.251             Build Date: May 5, 2010
==================================================================

- Added the Expanded boolean property to the RibbonGallery item.
  This property (True by default) indicates whether the gallery
  should appear expanded in a RibbonGroup. It is also possible to
  add ribbon galleries to QAT, C1StatusBar, and other containers.

- Fixed issue 10682 (C1Ribbon doesn't appear at runtime after
  setting the Visible property to True if it was set to False
  at design-time).

- Fixed issue 10689 (NullReferenceException is thrown when the
  user opens RibbonGallery after deleting some gallery Items).

==================================================================
C1Ribbon Build 2/4.0.20102.250             Build Date: May 1, 2010
==================================================================

- Added a few methods to the RibbonQatItemCollection class
  allowing to add/search/delete a RibbonGroup on the QAT:

  public bool Contains(RibbonGroup group)
  public int IndexOf(RibbonGroup group)
  public RibbonQatGroupButton Add(RibbonGroup group)
  public void Insert(int index, RibbonGroup group)
  public void Remove(RibbonGroup group)

- Fixed issue 10625 (IndexOutOfRange exception is seen when
  deleting ribbbonControlHost which is added in ribbonComboBox’s
  MenuItems and ribbonGroup is added to QAT).

- Fixed a few small problems in the RibbonGallery component.

==================================================================
C1Ribbon Build 2/4.0.20101.249          Build Date: April 29, 2010
==================================================================

- Fixed issue 10609 (current time is not shown when a user sets
  the ValueIsNull property to False for RibbonTimePicker).

- Fixed issue 10614 (at runtime, RibbonComboBox’s
  SelectedIndexChanged event is fired inconsistently while this
  RibbonComboBox is added to QAT).

==================================================================
C1Ribbon Build 2/4.0.20101.248          Build Date: April 25, 2010
==================================================================

- Fixed issue 10598 (the whole text is cleared when pressing
  the 'delete' key in RibbonComboBox if a message box pops up
  from the RibbonComboBox.SelectedIndexChanged event handler).

==================================================================
C1Ribbon Build 2/4.0.20101.246          Build Date: April 20, 2010
==================================================================

- Minor changes to the Ribbon templates for Visual Studio 2010.

==================================================================
C1Ribbon Build 2/4.0.20101.245          Build Date: April 16, 2010
==================================================================

- Fixed an issue in RibbonGroup: the last items of a collapsed
  group are cut off when showing in drop-down if the number of
  items exceeds the current screen width.

==================================================================
C1Ribbon Build 2/4.0.20101.243          Build Date: April 14, 2010
==================================================================

- C1Ribbon and C1StatusBar control designers are moved to the
  special Design dll. C1.Win.C1Ribbon.Design.2.dll is renamed
  to C1.Win.C1Ribbon.2.Design.dll.

==================================================================
C1Ribbon Build 2.0.20101.241            Build Date: March 26, 2010
==================================================================

- Fixed issue 9932 (Spelling error in description of
  'ShouldDrawFontEventArgs.DrawUsingDefaultFont' property).

==================================================================
C1Ribbon Build 2.0.20101.240            Build Date: March 25, 2010
==================================================================

- An ArgumentException is not fired any more when a user tries to
  insert an unsupported item to any item collection (issue 8991).

==================================================================
C1Ribbon Build 2.0.20101.239            Build Date: March 18, 2010
==================================================================

- Fixed issue 9798 (RibbonMenu doesn't appear on a C1StatusBar).

==================================================================
C1Ribbon Build 2.0.20101.238            Build Date: March 17, 2010
==================================================================

- Added the ShouldDrawFont event to RibbonFontComboBox. It allows
  to hide some fonts in the drop-down list or display their names
  using the default font.

==================================================================
C1Ribbon Build 2.0.20101.237         Build Date: February 26, 2010
==================================================================

- Fixed issue 9278 (GetItemBounds() method does not work properly
  for ribbon items at QAT which are not from any RibbonGroup).

- Fixed issue 9290 (There is a blank space inside RibbonComboBox
  after deleting all ribbon combo items from it if dropped list
  was opened before deleting ribbon combo items).

==================================================================
C1Ribbon Build 2.0.20101.236         Build Date: February 24, 2010
==================================================================

- Fixed issue 9200 (When setting font size for RibbonFontComboBox,
  the items inside it have got different font size).

==================================================================
C1Ribbon Build 2.0.20101.235         Build Date: February 23, 2010
==================================================================

- Fixed issue 6630 (At run time, QAT’s dropped group disappears
  after placing cursor inside a textbox-based ribbon item and
  opening context menu).
  
- Fixed issue 9184 (Unlike MSNumericUpDown, ribbonNumericBox’s
  ValueChanged event fires when setting existing value again
  inside ribbonNumericBox).

==================================================================
C1Ribbon Build 2.0.20101.234         Build Date: February 19, 2010
==================================================================

- Fixed issue 8993 (RibbonGroup added after collapsed group adds
  in collapsed state).
  
- Fixed issue 9112 (At runtime, RibbonComboBox's entered text is
  not affected when the combobox element is added to QAT).

- Fixed issue 9113 (While RibbonComboBox is inside RibbonGroup
  which is added to QAT, entered text disappears after pressing
  the Enter key).
  
- Fixed issue 9121 (IDE restarts when setting invalid value for
  ribbonProgressBar Height property from Miscellaneous settings).

==================================================================
C1Ribbon Build 2.0.20093.232          Build Date: February 3, 2010
==================================================================

- Fixed issue 8905 (When resizing the form size to hide a Ribbon
  item on the status bar, then CPU usage goes up to 100% stays
  there until the form is closed).

==================================================================
C1Ribbon Build 2.0.20093.231           Build Date: January 5, 2010
==================================================================

- Added a few Japanese strings for design-time localization.

==================================================================
C1Ribbon Build 2.0.20093.228         Build Date: December 15, 2009
==================================================================

- Fixed issue 8131 (ArgumentException is being observed on adding
  RibbonControlHost to C1StatusBar).

==================================================================
C1Ribbon Build 2.0.20093.227         Build Date: December 10, 2009
==================================================================

- Fixed issue 8271 (C1Ribbon control can't be added dynamically
  whereas C1StatusBar can be added).

==================================================================
C1Ribbon Build 2.0.20093.226         Build Date: December 10, 2009
==================================================================

- Fixed a bug: the Form.Activated event did not fire sometimes
  for a C1RibbonForm that is used as MDI child window.

- Fixed a minor issue in RibbonSplitButton when it appears in a
  submenu of the application menu.

==================================================================
C1Ribbon Build 2.0.20093.225          Build Date: December 4, 2009
==================================================================

- Fixed issue 8177 (Items within a RibbonGroup are disappeared
  after removing this RibbonGroup from QAT at design time).

==================================================================
C1Ribbon Build 2.0.20093.224          Build Date: December 3, 2009
==================================================================

- Fixed a bug: When the number of items within the sub-menu goes
  beyond those that fit on the screen, those items are not shown
  when the sub-menu is displayed.

- Fixed issue 8131 (ArgumentException is observed on adding a
  RibbonControlHost to RibbonSplitButton's Items collection).

==================================================================
C1Ribbon Build 2.0.20093.223         Build Date: November 27, 2009
==================================================================

- Slightly changed behavior of several ribbon items at runtime:
  RibbonComboBox, RibbonNumericBox, and other like components now
  lose the input focus when the user commits or cancels changes.

==================================================================
C1Ribbon Build 2.0.20093.222         Build Date: November 19, 2009
==================================================================

- Fixed an issue: inconsistent behavior of popup windows observed
  in C1Ribbon after the RibbonComboBox.DroppedDown property is set
  to True in the RibbonComboBox.ChangeCommitted event handler.

- Added a few Japanese strings for design-time localization.

==================================================================
C1Ribbon Build 2.0.20093.221          Build Date: November 5, 2009
==================================================================

- The TextImageRelation property has been revivified in several
  Ribbon components: RibbonButton, RibbonToggleButton, RibbonMenu,
  RibbonSplitButton. This property specifies the position of text
  and image relative to each other when the corresponding item
  appears on a RibbonGroup.

==================================================================
C1Ribbon Build 2.0.20093.220          Build Date: November 3, 2009
==================================================================

- Fixed an issue in the RibbonGallery component: the MouseEnter
  and MouseLeave events were not fired when the mouse pointer
  enters/leaves the component.

==================================================================
C1Ribbon Build 2.0.20093.219          Build Date: October 30, 2009
==================================================================

- A small correction for the sake of Visual Studio 2010.

==================================================================
C1Ribbon Build 2.0.20093.218          Build Date: October 17, 2009
==================================================================

- Fixed issue 7207 (RibbonComboBox’s items are not shown when
  running application after removing this ribbonComboBox from QAT
  or HOT list at Design time).

==================================================================
C1Ribbon Build 2.0.20093.217          Build Date: October 16, 2009
==================================================================

- Fixed issue 7174 (When a user clicks the 'OK' button in the
  RibbonToolBar collection editor this removes all toolbar's
  items from the QAT item list in C1Ribbon).

- Fixed issue 7178 (At Design time, an exception is thrown when
  deleting a ribbon item from both of QAT and Hot item list).

- Fixed issue 7192 (At Run time, RibbonGallery’s dropdown is
  shown as distorted in a certain scenario).

==================================================================
C1Ribbon Build 2.0.20093.216          Build Date: October 14, 2009
==================================================================

- Fixed issue 7156 (Unlike ribbonDatePicker, ribbonTimePicker’s
  selected value cannot be cleared sometimes).

==================================================================
C1Ribbon Build 2.0.20093.215          Build Date: October 14, 2009
==================================================================

- Fixed issue 7111 (Inconsistent behavior is observed at runtime
  in RibbonDatePicker when adding its parent RibbonGroup to the
  "Customize QAT" menu).

- Fixed an issue in C1RibbonForm: the size of form was incorrect
  under Windows Aero color theme if the FormBorderStyle property
  is equal to FixedSingle or FixedDialog.

- The ControlAdded and ControlRemoved events have been hidden
  in the C1Ribbon and C1StatusBar controls.

==================================================================
C1Ribbon Build 2.0.20093.214          Build Date: October 13, 2009
==================================================================

- Fixed issue 7079 (At runtime, the SelectedIndexChanged event
  is fired inconsistently for RibbonGallery).

- Fixed issue 7080 (Minimized RibbonTab is disappeared but its
  child RibbonGroup is still opened at runtime).

- Fixed issue 7083 (The VisibleChanged event fired many times
  for C1Ribbon and C1StatusBar before showing the form).

==================================================================
C1Ribbon Build 2.0.20093.213          Build Date: October 12, 2009
==================================================================

- Fixed issue 6958 (At run time, ribbon items on a ribbonToolBar
  are shown distorted in the group popup window when add too many
  ribbon items to the ribbonToolBar container).

- Fixed issue 6968 (Ribbon item which is added to QAT and hot
  list is not removed from QAT and hot list after deleting this
  item from the owner group at runtime).

- Fixed issue 7009 (At run time, ribbonGroupQAT’s popup window is
  partially seen or has some white space if the inner group was
  resized while the window is open).

- Fixed issue 7012 (At run time, QAT dropdown arrow disappears
  when adding multiple ribbon items to QAT and the QAT bar is
  shown below the ribbon).

- Fixed issue 7014 (At run time, copy-cut-paste hotkeys don't
  work for ribbonTextBox in ComponentOne Ribbon Application).

- Fixed an issue in RibbonDatePicker/RibbonTimePicker: The
  TextChanged and ValueChanged events were fired incorrectly in
  these ribbon components.

==================================================================
C1Ribbon Build 2.0.20093.212           Build Date: October 7, 2009
==================================================================

- Fixed issue 6907 (Unlike MS NumericUpDown, RibbonNumericBox's
  ValueChanged event fires twice when type the value manually).

- Fixed issue 6908 (RibbonNumericBox’s ValueChanged event fires
  again automatically when a messagebox is poped up in the event
  handler).

- Fixed issue 6914 (At run time, ribbonGallery's menu items are
  partially seen if the VisibleItems property is set to 1).

- Fixed issue 6935 (At run time, RibbonCheckBox’s CheckChanged
  event fires incorrectly).

==================================================================
C1Ribbon Build 2.0.20093.211           Build Date: October 6, 2009
==================================================================

- Fixed issue 6868 (Date shown inside ribbonDatePicker is not
  same date shown in DatePicker’s calendar if year is over 3000).

- Fixed issue 6872 (Inconsistent behavior is observed when adding
  items to the RightPaneItems or BottomPaneItems collections of
  the ribbonApplicationMenu. These items doesn't appear in the
  QAT collection editor and in the "Hide/Show Ribbon Items"
  floatie window).

==================================================================
C1Ribbon Build 2.0.20093.210           Build Date: October 3, 2009
==================================================================

- Fixed issue 6747 (RibbonItem’s event name inside ribbonGroup
  is not same as RibbonItem’s event name in QAT items list when
  creating event handler in codeview).

- Fixed issue 6765 (Exception is thrown when saving or rebuilding
  application after add ribbonItems to a RibbonComboBox on QAT).

- Fixed issue 6786 (Exception is thrown when click 'Cancel'
  without setting any class name at ‘Adding RibbonControlHost’
  input box from RibbonGroup Items Collection Editor).

- Fixed issue 6802 (Inconsistent behavior is observed when delete
  a ribbonGroup in which ribbonToolbar was selected).

- Fixed issue 6814 (QAT items are disappeared when making some
  changes of QAT items from Collection Editor and do Cancel).

- Fixed issue 6830 (IDE restarts after setting image for
  ribbonGroup from ribbonQatGroupButton’s property grid).

- Fixed issue 6781 (RibbonTab which has no ribbonGroup is still
  opened when click other location in the form while C1Ribbon
  control is minimized at Run time).

==================================================================
C1Ribbon Build 2.0.20093.209        Build Date: September 29, 2009
==================================================================

- Fixed issue 6745 (An exception is thrown at design time when
  saving or rebuilding application after deleting a tab using
  the collection editor if this tab contains a ribbonGroup
  which is added to QAT).

==================================================================
C1Ribbon Build 2.0.20093.208        Build Date: September 29, 2009
==================================================================

- Added the SelectedColorChanged event to RibbonColorPickerItem.
  This event occurs when the Color property changes.

- Fixed issue 6734 (C1Ribbon does not persist some QAT's and app
  menu's properties loaded from xml file in certain scenario).
  
- Fixed an issue in RibbonColorPicker: When the user assigns a
  new value to the RibbonColorPicker.Color property at runtime
  the DefaultColor property was changed to the same value.
  
- Fixed a bug in RibbonColorPickerItem: The Click event was fired
  incorrectly. Now this event occurs when the user clicks some
  color in the RibbonColorPickerItem element.

==================================================================
C1Ribbon Build 2.0.20093.207        Build Date: September 27, 2009
==================================================================

- Fixed issue 6712 (Exception is thrown and designer is disabled
  at design time after cutting ribbonGroup from its context menu
  while C1Ribbon's smart tag panel is open). A similar issue has
  been fixed in C1StatusBar as well.

- Fixed issue 6725 (Black space or Error message is thrown when
  setting QAT is below the ribbon and ribbonApplicationMenu’s
  Win7Look property to True).

- Fixed issue 6727 (Deselected tab appears in highlighted state
  after it was disabled in RibbonTab.Select event handler. It
  appears as highlighted even if this tab becomes enabled and
  other tabs are actually hovered and selected).

==================================================================
C1Ribbon Build 2.0.20093.206        Build Date: September 26, 2009
==================================================================

- Fixed issue 6715 (Whenever adding new RibbonTab, always
  contain default RibbonGroup but this RibbonGroup is not shown
  in RibbonTab Collection Editor). Now the default RibbonGroup
  is not added automatically to a new RibbonTab when adding it
  using the Collection Editor.

- Added some Japanese strings for design-time localization.

==================================================================
C1Ribbon Build 2.0.20093.205        Build Date: September 25, 2009
==================================================================

- Fixed issue 6681 (At design time, QAT group button doesn't
  appear after showing the corresponding RibbonGroup if the
  group's ShowInQat property was set to True while the group's
  Visible property is False).

- Fixed issue 6687 (RibbonApplicationMenu’s floating toolbar
  contains some wrong items after loading from xml file).

==================================================================
C1Ribbon Build 2.0.20093.204        Build Date: September 24, 2009
==================================================================

- Fixed issue 6675 (Even through RibbonGroup.Visible is set to
  False, the corresponding QAT group button is shown and a blank
  QAT dropdown appears on clicking the group button on the QAT).

==================================================================
C1Ribbon Build 2.0.20093.203        Build Date: September 23, 2009
==================================================================

- Fixed issue 6586 (Ribbon items with the text input field still
  allow typing in when appear within a disabled RibbonGroup).

- Fixed issues 6597, 6598 (Invisible or disabled group button on
  QAT is still visible and enabled at run time; "Object reference
  not set to an instance of an object" is thrown when click the
  'Ellipse' button of the ToolTip property in QAT group button's
  property grid). The Enabled, Visible, Description, ToolTip, and
  Tag properties are hidden in the RibbonQatGroupButton component.
  These properties have no effect on RibbonQatGroupButton.

- Fixed issue 6601 (At design time, not able to set ValueIsNull
  property of TimePicker or DatePicker or Numeric Box to 'False'
  once again after setting it to 'True').

- Fixed issue 6605 ("Object reference not set to an instance of
  an object" is thrown when adding ribbon items to the Items
  collection of a RibbonDatePicker from the collection editor).
  The Items property has been hidden in the RibbonDatePicker
  component. It is not applicable to this class.

- Fixed issue 6616 (Unexpected behavior of C1StatusBar is
  observed when RibbonProgressBar item’s Height property is set
  manually to a large value).

- Fixed issue 6630 (At run time, a popup group or tab disappear
  after placing cursor inside a text edit field (for example,
  in a RibbonDatePicker) and opening context menu).

- Fixed issue 6648 (Exception is thrown at runtime after adding
  some ribbon items (ComboBox, DatePicker, etc.) to the QAT).

- Fixed an issue: Long label element in RibbonListItem's Items
  collection (in RibbonApplicationMenu.RightPaneItems) hid next
  items, such as a pin button in the Recent Documents list.

- Embedded Norwegian strings for runtime localization.

==================================================================
C1Ribbon Build 2.0.20093.201        Build Date: September 19, 2009
==================================================================

- Fixed issue 6523 (Today date is not shown in editable portion
  of a RibbonDatePicker on clicking the 'Today' button when the
  ValueIsNull property is True for this RibbonDatePicker).

- Fixed issue 6526 (Visual Studio IDE restarts when enter
  incorrect text into RibbonDatePicker or RibbonTimePicker at
  design time).

- Fixed issue 6538 (Can’t delete the first RibbonGroup of the
  first tab in C1Ribbon control).

- Fixed issue 6543 (At run time, the DatePicker and TimePicker
  elements inside a RibbonGroup are not working fine when this
  RibbonGroup is added to QAT).

- Fixed issue 6548 (Group of rest tabs are not shown if the
  RibbonGroup of first tab is invisible and making minimize the
  Ribbon at runtime).

- Fixed issue 6549 (At run time, InvalidCastException is thrown
  when a RibbonGroup is added to QAT and this RibbonGroup is
  invisible).

==================================================================
C1Ribbon Build 2.0.20093.200        Build Date: September 18, 2009
==================================================================

- Added the RibbonApplicationMenu.Visible property. It is now
  possible to hide/show the application menu button.

- Fixed issue 6494 (Unlike MS-NumericUpDown and RibbonTrackBar,
  exception is not thrown on setting invalid value to
  RibbonNumericBox.Value property).

- Fixed issue 6505 (Clicking Today button in RibbonDatePicker
  navigate the calendar to current month only at the first time).

- Fixed issue 6508 (C1Ribbon Application Menu can’t be hided at
  Design time).
  
==================================================================
C1Ribbon Build 2.0.20093.199        Build Date: September 16, 2009
==================================================================

- Fixed issue 6476 (RibbonGroup can’t be added to the Quick
  Access Toolbar (QAT)).

==================================================================
C1Ribbon Build 2.0.20093.198        Build Date: September 16, 2009
==================================================================

- Added user-defined localization for run-time string resources.
  A set of resource files (with the extension resx) can be created
  (a separate file for each required culture) for C1Ribbon
  assembly. Creating the resource files is easy using the new
  design time editor accessible via the “Localize” context menu/
  action item available on the C1Ribbon and C1StatusBar controls.
  
  All parts of your app using components from a C1Ribbon dll must
  use the same localization resource. It is recommended that the
  following conventions are followed when resx files are created:
  
• All resx files should live in the subfolder C1LocalizedResources
    of your project;
    
• Files should be named as follows:
    XXX.YYY.resx, where:
      – XXX is the name of Component one assembly;
      – YYY is the culture code of the resource.
    For example:
      – C1.Win.C1Ribbon.2.de.resx – German (de) resource for
        C1.Win.C1Ribbon.2 assembly;
      – C1.Win.C1Ribbon.2.resx – Invariant culture resource
        for C1.Win.C1Ribbon.2 assembly.

- Added the LabelWidth property to the following ribbon
  components: RibbonComboBox, RibbonTextBox, RibbonDatePicker,
  RibbonTimePicker, RibbonNumericBox. This property specifies the
  width of the text label. Set it to -1 (default value) to let
  the label calculate width automatically.

==================================================================
C1Ribbon Build 2.0.20093.197         Build Date: September 9, 2009
==================================================================

- The input focus did not move out of a RibbonTextBox and other
  like components when the user clicks a button on C1Ribbon.

- Improved behavior of several ribbon components (RibbonTextBox,
  RibbonNumericBox, RibbonDatePicker, RibbonTimePicker) in case
  they appear on a popped up panel.

- Updated the templates for ComponentOne Ribbon Application.

==================================================================
C1Ribbon Build 2.0.20093.196         Build Date: September 7, 2009
==================================================================

- Fixed issue 6291 (When a tab's 'Visible' property is set to
  False, and an item placed in that tab is added to QAT: a user
  was not able to click the item on QAT).

==================================================================
C1Ribbon Build 2.0.20093.195         Build Date: September 7, 2009
==================================================================

- Added the RibbonDatePicker component. It allows the user to
  select a date and to display the date with a specified format.

- Added the RibbonTimePicker component. It is an up-down control
  that displays "the time of day" values in C1Ribbon.

- Added the ShowAutomaticColor property to RibbonColorPicker.
  This property gets or sets whether the 'Automatic' item should
  appear in the dropdown. If it's True and the user clicks the
  'Automatic' item the Color property will be set to Color.Empty.

- Added the AutomaticColor property to RibbonColorPicker. This
  property sets the color that will appear on the 'Automatic'
  item in the dropdown and on the RibbonColorPicker after the
  user clicked the 'Automatic' item.

- Added the DefaultColor property to RibbonColorPicker. It gets
  or sets the color that appears on the RibbonColorPicker. This
  color will be assigned to the Color property of the component
  if the user clicks the color picker's button.

==================================================================
C1Ribbon Build 2.0.20093.193           Build Date: August 25, 2009
==================================================================

- The RibbonEditBox component has been renamed to RibbonTextBox.
  Backward compatibility is maintained.

==================================================================
C1Ribbon Build 2.0.20093.192           Build Date: August 24, 2009
==================================================================

- RibbonComboBox and RibbonNumericBox displayed incorrectly on
  QAT (their background color was Black) under Vista Aero mode if
  the owner C1RibbonForm has FormBorderStyle = None.

==================================================================
C1Ribbon Build 2.0.20093.191           Build Date: August 24, 2009
==================================================================

- Added the RibbonNumericBox component. It represents an up-down
  control that displays numeric values in C1Ribbon.

- The RibbonEditBox component can now be added to C1StatusBar.

==================================================================
C1Ribbon Build 2.0.20093.190           Build Date: August 20, 2009
==================================================================

- If the width of C1Ribbon is not enough to display all tabs
  these tabs can now be shrinked a little. Also, the tabs with
  text and image can hide their text to save some space.

==================================================================
C1Ribbon Build 2.0.20093.189           Build Date: August 14, 2009
==================================================================

- Fixed issue: a double click on the window icon did not close
  C1RibbonForm when RibbonApplicationMenu.Win7Look is True.
  
- Fixed a bug: the window icon shouldn't appear in Win7Look mode
  if the ControlBox property is False for the ribbon form.

- Fixed several small drawing issues appeared on C1Ribbon when
  the owner RibbonForm has (FormBorderStyle = FixedSingle).

==================================================================
C1Ribbon Build 2.0.20093.188           Build Date: August 12, 2009
==================================================================

- Added the Win7Look boolean property to RibbonApplicationMenu.
  This property specifies whether the Application menu button
  should be rectangular as in Windows 7's WordPad.

- Added the Text property to RibbonApplicationMenu. The property
  specifies the text associated with the Application menu when
  the Win7Look property is True.

==================================================================
C1Ribbon Build 2.0.20092.187            Build Date: August 4, 2009
==================================================================

- Fixed issue introduced in build 185: it was impossible to add
  a user-defined item that is derived from some ribbon component,
  such as the RibbonListItem class, to the Items collection of a 
  RibbonGroup and other like containers.

==================================================================
C1Ribbon Build 2.0.20092.186            Build Date: August 3, 2009
==================================================================

- Fixed issue 5641 introduced in build 185: Visual Studio crashes
  on adding RibbonControlHost to a RibbonGroup.

- Fixed an issue: long font names were clipped in the drop-down
  list of a RibbonFontComboBox.

==================================================================
C1Ribbon Build 2.0.20092.185            Build Date: August 2, 2009
==================================================================

- Addressed issue 5584 (Unhandled exception observed on adding
  RibbonCheckBox, RibbonEditBox, RibbonToggleButton, and others
  to the Items collection of a RibbonComboBox at runtime). The
  explicit ArgumentException is fired now when the user adds an
  unsupported element to the Items (or MenuItems) collection.

- Fixed issue 5590 (Fonts present in RibbonFontComboBox are not
  getting properly displayed).

==================================================================
C1Ribbon Build 2.0.20092.184             Build Date: July 30, 2009
==================================================================

- Fixed an issue: there were several unreadable font names in
  the drop-down list of a RibbonFontComboBox.

- Added some Hungarian strings for runtime localization.

==================================================================
C1Ribbon Build 2.0.20092.183             Build Date: July 28, 2009
==================================================================

- Removed the 'True Type' image from font preview items displayed
  in drop-down list for the RibbonFontComboBox component.
  
- Fixed an issue with showing incorrect QAT background and window
  title in the caption of a maximized RibbonForm under Windows 7.

- The hot transition effect has been disabled temporarily for
  ribbon groups under Windows 7 Aero theme. Moving the mouse
  pointer over a RibbonGroup produced annoying flickering under
  Windows 7 RC.

==================================================================
C1Ribbon Build 2.0.20092.182             Build Date: July 24, 2009
==================================================================

- Addressed issue 5465: the Clickable property has been added to
  RibbonTab (it is True by default). The property gets or sets
  whether it is allowed to click/select the tab. This doesn't
  depend on the RibbonTab.Enabled property.

- Added the PreviewFonts boolean property to RibbonFontComboBox.
  This property specifies whether font names should be drawn
  using the same fonts in the drop-down list (True by default).

==================================================================
C1Ribbon Build 2.0.20092.181             Build Date: July 23, 2009
==================================================================

- The standard context menu (with the "Add to Quick Access
  Toolbar" item) did not appear when the user make a right-click
  in the text area of RibbonComboBox which has the DropDownStyle
  property equals to 'DropDownList'.

- Fixed an issue: if the user opens a submenu (RibbonMenu in the
  other RibbonMenu or RibbonApplicationMenu), and then she clicks
  the submenu buttom once again, the submenu and parent menus
  disappeared from the screen.

==================================================================
C1Ribbon Build 2.0.20092.179             Build Date: July 20, 2009
==================================================================

- A NullReferenceException occurred after adding/deleting items
  to/from a RibbonComboBox at runtime if this combobox has been
  added to Quick Access Toolbar (QAT).

- RibbonSplitButton that appears on menu did not fire the Click
  event after a single mouse click.

- C1RibbonForm did not repaint itself if there is another modal
  form on top of it and the user clicks the C1RibbonForm in order
  to switch from another application (this occurred with all color
  schemes except Vista Aero).

==================================================================
C1Ribbon Build 2.0.20092.178             Build Date: July 15, 2009
==================================================================

- Fixed issue 5319 (Minimize\Restore button do not work when
  child RibbonForm is in maximized state in a MDI application).
  The issue was introduced in build 177.

- Resizing a Form (not C1RibbonForm) using C1StatusBar's sizing
  grip produced visual artifacts if this is an MDI parent form
  and the active MDI child is maximized.

- Fixed an issue: the vertical scroll bar of C1FlexGrid did not
  work sometimes on C1RibbonForm. When a user moves the Ribbon
  Form by its caption to the left a little bit, a right scroll
  bar of the Flex Grid did not work under XP/Vista Basic.

==================================================================
C1Ribbon Build 2.0.20092.177             Build Date: July 13, 2009
==================================================================

- Fixed an issue: when a C1RibbonForm is used as MDI child and it
  is maximized within its MDI parent the client area size of that
  C1RibbonForm was incorrect when using large system fonts. The
  client area of the maximized MDI child was cut off at the top.

- Editable text in RibbonComboBox and RibbonEditBox was misplaced
  by one pixel.
  
==================================================================
C1Ribbon Build 2.0.20092.176              Build Date: July 9, 2009
==================================================================

- Fixed an issue: group sizing was limited to the Maximized and
  Collapsed states when the Ribbon is minimized.

- Updated the "ComponentOne Ribbon Application" template.

==================================================================
C1Ribbon Build 2.0.20092.175              Build Date: July 6, 2009
==================================================================

- RibbonComboBox did not work correctly when it is added to
  the MenuItems collection of a RibbonGallery.

- Fixed a minor issue in RibbonEditBox: when placing a ribbon
  toolbar with a button and a RibbonEditBox right beside it to
  the left, with no label there was a small gap between the
  button and the text field.

- The RibbonGallery.HighlightedItemChanged event did not fire
  when the mouse pointer leaves the last gallery item.

- Improved appearance of a RibbonComboBox on the C1StatusBar
  control and on the QAT.

==================================================================
C1Ribbon Build 2.0.20092.174              Build Date: July 6, 2009
==================================================================

- Fixed issue 5111 (Runtime error is thrown when a comboBox is
  added to the Items of a RibbonSplitButton or RibbonMenu).
  
- The GapBeforeTextArea property did not work for RibbonComboBox
  and RibbonEditBox since build 168.

- Added some Chinese strings for runtime localization.

==================================================================
C1Ribbon Build 2.0.20092.173              Build Date: July 2, 2009
==================================================================

- Automatic searching (when a user types keys) is now supported
  for a RibbonComboBox with the DropDownStyle property equals to
  DropDownList while the combobox is dropped down.

- It was not possible to navigate to the new item in a closed
  RibbonComboBox using the Up/Down arrow keys or the automatic
  completion feature if this item has just been added from code.

==================================================================
C1Ribbon Build 2.0.20092.172              Build Date: July 1, 2009
==================================================================

- Improved appearance of the C1Ribbon control when working with
  non-standard DPI scaling.

==================================================================
C1Ribbon Build 2.0.20092.171             Build Date: June 29, 2009
==================================================================

- Fixed issue 5009 (Visual Studio crashes if minimum/maximum
  property is set for RibbonProgressBar or RibbonTrackBar using
  the floatie designer).

- Updated the floatie designers for the RibbonComboBox and
  RibbonEditBox components.

==================================================================
C1Ribbon Build 2.0.20092.170             Build Date: June 28, 2009
==================================================================

- Added the DropDownStyle property to RibbonComboBox. This
  property specifies whether the text portion of the combobox
  is editable (RibbonComboBoxStyle.DropDown) or not editable
  (RibbonComboBoxStyle.DropDownList).

- Reduced the number of situations when C1RibbonForm has to be
  repainted, i.e. when the Paint event is fired.

==================================================================
C1Ribbon Build 2.0.20092.169             Build Date: June 26, 2009
==================================================================

- Fixed an issue that was introduced in build 168: when the mouse
  pointer hovers over a menu item such as a menu or split button
  the submenu appears but the parent menu disappears at the same
  moment. The parent menu should stay open in this situation.

==================================================================
C1Ribbon Build 2.0.20092.168             Build Date: June 25, 2009
==================================================================

- Appearance of the RibbonEditBox and RibbonComboBox components
  has been updated.

- Added the MarginTop and MarginBottom properties to the
  RibbonToolBar component. These properties specify the top and
  the bottom margins for the RibbonToolBar when it appears on a
  RibbonGroup.

- Added the TextAlign property to the RibbonComboBox and
  RibbonEditBox components. The property specifies how the typed
  text is aligned.

- Reduced the number of situations when C1RibbonForm has to be
  repainted, i.e. when the Paint event is fired.

- An image assigned to the RibbonTab.Image property was scaled
  to 16x16. Now the original size of the image is preserved.

==================================================================
C1Ribbon Build 2.0.20092.167             Build Date: June 24, 2009
==================================================================

- Fixed a bug: creating and showing a C1RibbonForm dynamically
  from code displayed an empty form without title and borders
  under Windows XP and Vista Basic/Standard color themes.

==================================================================
C1Ribbon Build 2.0.20092.166             Build Date: June 23, 2009
==================================================================

- The Paint event fired repeatedly for C1RibbonForm when the user
  moves the mouse pointer over the form.

==================================================================
C1Ribbon Build 2.0.20092.165             Build Date: June 21, 2009
==================================================================

- A NullReferenceException occurred sometimes in C1Ribbon after
  closing a popup window, such as a collapsed RibbonGroup.

==================================================================
C1Ribbon Build 2.0.20092.164             Build Date: June 17, 2009
==================================================================

- Added the SizingGrip boolean property to C1StatusBar. The new
  property determines whether the status bar has a sizing grip.

- Added the GetItemBounds() method to C1Ribbon and C1StatusBar.
  This method returns the size and location of the given item, in
  pixels, relative to the parent control.

==================================================================
C1Ribbon Build 2.0.20091.162              Build Date: May 26, 2009
==================================================================

- Fixed a bug: the caption of MDI Parent C1RibbonForm did not
  update while MDI Child form is maximized and the caption of
  this child form is changed.

==================================================================
C1Ribbon Build 2.0.20091.161              Build Date: May 12, 2009
==================================================================

- The FontPadding property had no effect on the RibbonGalleryItem
  elements.

- Text height in a RibbonGalleryItem is not restricted now. This
  prevents text clipping when using a large font in the gallery.

==================================================================
C1Ribbon Build 2.0.20091.160               Build Date: May 7, 2009
==================================================================

- It is now possible to add a RibbonControlHost to RibbonToolBar
  and RibbonConfigToolBar item collections.

- Dragging the RibbonControlHost item over a RibbonGroup has been
  forbidden. This caused problems in previous builds.

- The sizing grip on a C1StatusBar was able to change form size
  beyond the limits specified in the MinimumSize and MaximumSize
  properties. The issue occurred on an MDI form.

==================================================================
C1Ribbon Build 2.0.20091.159            Build Date: April 30, 2009
==================================================================

- The DoubleClick event is not fired now for a RibbonButton if
  the value of the RepeatPressDelay property is more than zero.

- Removed the LocationChanged event from the RibbonControlHost
  class. This event was not fired anyway.

- Fixed a minor issue in the title bar of a C1RibbonForm under
  Windows XP when the user switches to another application.

- Removed the GripHandleVisible property from RibbonColorPicker.

- Added the MaxDropDownItems property to the RibbonSplitButton
  and RibbonMenu components. This property sets the maximum
  number of items to display in the drop-down list.

==================================================================
C1Ribbon Build 2.0.20091.158            Build Date: April 28, 2009
==================================================================

- Several missed Japanese strings have been added.

==================================================================
C1Ribbon Build 2.0.20091.157            Build Date: April 27, 2009
==================================================================

- A NullReferenceException occurred in build 156 after the user
  executes the RibbonComboBox.Items.ClearAndDisposeItems() method
  from the RibbonComboBox.SelectedIndexChanged event handler.

==================================================================
C1Ribbon Build 2.0.20091.156            Build Date: April 25, 2009
==================================================================

- Fixed issue 19546 (NullReferenceException occurs on clicking
  three times on RibbonTab containing no RibbonGroup).

- Fixed a bug in C1RibbonForm: the form parts (title and corners)
  were not updated correctly when a C1Ribbon or C1StatusBar hide.

- Fixed several minor problems with drawing the window caption
  when the C1Ribbon control appears on a C1RibbonForm.

- Fixed a bug: ribbon groups were not resized correctly (did not
  switch their layout between large/medium/small) when the Visible
  property changes for individual items on a RibbonGroup.

- Added the CaptionFont property to C1RibbonForm. This property
  sets the font that is used to display text in the title bar of
  the C1RibbonForm. If the value of this property is 'null' the
  standard system font is used (fixed issue 19543).

- Added the ShortcutKeys property to RibbonSplitButton. To enable
  shortcut keys the split button must belong to a C1Ribbon or
  C1StatusBar which are placed on a C1RibbonForm.

- Added the RepeatPressDelay and RepeatPressInterval properties
  to RibbonButton. The first property sets the interval before
  the button starts firing click events, in milliseconds.
  If it is equal to 0 (default value) the Click events are not
  fired repeatedly. The second property (RepeatPressInterval)
  sets the interval between clicks when the button is kept
  pressed, in milliseconds.

- Added the SupportedGroupSizing property to the RibbonItem
  class. This property imposes a restriction on sizing the item
  when it appears on a RibbonGroup. Possible values:
  Any (no restrictions on sizing the item), TextAlwaysVisible
  (prevents the item from hiding its text label), LargeImageOnly
  (prevents the item from switching to a small image).

- Partially visible ribbon items hide themselves on a C1StatusBar.

==================================================================
C1Ribbon Build 2.0.20091.155            Build Date: April 19, 2009
==================================================================

- The hidden Text (or Label text) appears in tooltip for items
  of a RibbonGroup in its narrowest state if these items have
  empty string in the ToolTip property.

- Large images can now be assigned to the SmallImage property
  of items on a RibbonGroup. They are not scaled to 16x16.

- The contents of a RibbonGroup is now centered horizontally.

- The contents of a RibbonGalleryItem in now centered.

- Added the RestrictedGroupSizing boolean property to C1Ribbon.
  This property turns the Ribbon into the mode when the group
  sizing is limited to the Maximized and Collapsed states.

==================================================================
C1Ribbon Build 2.0.20091.154            Build Date: April 16, 2009
==================================================================

- Item tooltips use the parent Ribbon or StatusBar font as
  the default font.

- Added the AutoCompleteMode property to RibbonComboBox. This
  property gets or sets an option that controls how automatic
  completion works for RibbonComboBox. Possible values:

  [None]
  Disables the automatic completion feature.

  [Suggest]
  Displays the auxiliary drop-down list associated with the edit
  control. This drop-down is populated with one or more suggested
  completion strings.

  [Append] - default option
  Appends the remainder of the most likely candidate string to
  the existing characters, highlighting the appended characters.

- The RibbonTrackBar and RibbonProgressBar components can be
  added to RibbonGroup, RibbonToolBar, and RibbonConfigToolBar
  item collections.

- Added several properties to RibbonTrackBar:

  public int StepFrequency { get; set; }
  This property gets or sets the delta between thumb positions
  on the RibbonTrackBar.

  public int TickFrequency { get; set; }
  Specifies the delta between ticks drawn on the RibbonTrackBar.

  public int ButtonPressDelay { get; set; }
  The interval before the '+' and '-' buttons start firing click
  events, in milliseconds.

  public int ButtonPressInterval { get; set; }
  The interval between clicks when the '+' or '-' buttons are
  kept pressed, in milliseconds.

  public int Width { get; set; }
  Gets or sets the width of the RibbonTrackBar.

- Added the ValueChanged event to the RibbonTrackBar component.
  The event occurs when the Value property changes (as opposed
  to the Scroll event which fires when either a mouse or keyboard
  action moves the thumb).

- The SmallChange and LargeChange properties of RibbonTrackBar
  have been hidden. Since then both properties return the value
  of the new StepFrequency property.

- Added several properties to RibbonProgressBar:

  public int Step { get; set; }
  The amount to increment current value of the progress bar by
  when the PerformStep() method is called.

  public int Height { get; set; }
  Gets or sets the height of the progress bar.

- Added the ValueChanged event to RibbonProgressBar. It occurs
  when the Value property changes.

- Added the PerformStep() and Increment(int) public methods to
  the RibbonProgressBar component. These methods advance the
  current position of the progress bar.

==================================================================
C1Ribbon Build 2.0.20091.153             Build Date: April 9, 2009
==================================================================

- Added support for big images (greater than 32x32, up to 50x50)
  to the following ribbon items: RibbonButton, RibbonToggleButton,
  RibbonMenu, RibbonSplitButton. Such images can be used with
  items of a RibbonGroup.

- Large buttons with empty text label are now vertically centered
  in the owner RibbonGroup.

- The RibbonToggleGroup has been hidden as the available option
  when adding new items to RibbonGroup and other containers.
  You shouldn't use RibbonToggleGroup in the new applications.
  Several RibbonToggleButton components can be grouped now using
  their ToggleGroupName property. This is a workaround for the
  issue 18273 (Unable to align a toggle group vertically in a
  RibbonGroup).

- Added the ToggleGroupName string property to RibbonToggleButton.
  It allows to create a group of mutually exclusive toggle buttons
  which doesn't use the RibbonToggleGroup component.

- Added the CanDepress boolean property to RibbonToggleButton.
  This property indicates whether the second click depresses the
  button. It can be considered as a replacement or duplicate for
  the RibbonToggleGroup.AllowAllButtonsUp property.

- Added the PressedButton property to RibbonToggleButton. This
  property gets or sets the pressed button in this toggle group
  (within or outside the RibbonToggleGroup container).

- Added the PressedButtonChanged event to RibbonToggleButton.
  It occurs when the Pressed property is changed for some button
  that belongs to the same toggle group.

- Several missed Japanese strings have been added.

==================================================================
C1Ribbon Build 2.0.20091.152             Build Date: April 8, 2009
==================================================================

- Fixed issue 19537 ('System.ArgumentException' occurs on creating
  C1Ribbon object). The problem was introduced in build 151.

==================================================================
C1Ribbon Build 2.0.20091.151             Build Date: April 6, 2009
==================================================================

- Several missed Japanese strings have been added.

==================================================================
C1Ribbon Build 2.0.20091.150            Build Date: March 31, 2009
==================================================================

- Fixed issue 19524 (NullReferenceException occurs on adding
  RibbonItem to C1Ribbon.Qat.Items collection if this item is not
  already added to RibbonGroup).

- Several missed Japanese strings have been added.

==================================================================
C1Ribbon Build 2.0.20091.149            Build Date: March 30, 2009
==================================================================

- Fixed issue 19483 (RibbonGroup resizing has been improved.
  It is now more faithful to Office Ribbon).

- Improved the hot transition effect for RibbonGroups. Now it
  works for groups in popup panes as well. The group overlapped
  with other windows doesn't show smooth style transition.

- The TextImageRelation property has been hidden in the
  RibbonItem component. Now the alignment (vertical/horizontal)
  of the button elements depends on the group sizing. It can be
  updated dynamically at runtime.

- Added the VerticalLayout property to the RibbonGalleryItem.
  This property replaces the TextImageRelation.

==================================================================
C1Ribbon Build 2.0.20091.148            Build Date: March 17, 2009
==================================================================

- The ClearAndDisposeItems() method of RibbonItemCollectionBase
  did not clear the items in a RibbonComboBox, RibbonSplitButton,
  RibbonMenu which are on the QAT.

- Fixed issue 19455 (Floating Toolbar does not appear after
  clicking on dropdown-button of an empty RibbonComboBox or
  RibbonMenu at design-time).

- Fixed issue 19464 (Images cannot be selected by using up/down
  arrow keys in Property Window).

==================================================================
C1Ribbon Build 2.0.20091.147             Build Date: March 5, 2009
==================================================================

- One more attempt to fix issue 18895 (Ribbon Form activated
  with mdi child doesn't fully repaint or go away).

==================================================================
C1Ribbon Build 2.0.20091.146         Build Date: February 27, 2009
==================================================================

- Assigning (from code) a large image to an item of submenu of
  the application menu scaled this image to small size.

==================================================================
C1Ribbon Build 2.0.20091.145         Build Date: February 26, 2009
==================================================================

- Too many preset images appeared in UITypeEditor's drop-down for
  the SmallImage and LargeImage properties of the ribbon items.

- Attached the proper UITypeEditor to the Image property of the
  RibbonGroup and RibbonTab components.

==================================================================
C1Ribbon Build 2.0.20091.144         Build Date: February 25, 2009
==================================================================

- Fixed issue 19302 (A Ribbon Form does not restore to original
  size in Aero theme if it was maximized or minimized in the
  OnLoad event handler).

- Fixed issue 18895 (On clicking the two Forms in the MDIChild
  area, a white border appears on the edges of the maximized
  MDIChild Forms under Vista Basic theme).

==================================================================
C1Ribbon Build 2.0.20091.143         Build Date: February 20, 2009
==================================================================

- Fixed issue 19297 ("Save StatusBar Template" throws error on
  saving XML file).

==================================================================
C1Ribbon Build 2.0.20091.142         Build Date: February 19, 2009
==================================================================

- Fixed issue 19284 (Gap observed below Ribbon on the Parent
  form when MDI child form inheriting RibbonForm is opened).

- Fixed an issue: If an MDI child form appeared as maximized
  for the first time under Vista Aero it was restored then to
  wrong size when the user clicks the Restore Window button.

- The Active property has been hidden in the ToolTipSettings.

- When saving the Ribbon/StatusBar definition into an XML file
  all colors are now stored as hexadecimal values to facilitate
  manual editing of the XML file.

- Several properties of the base ScrollableControl class have
  been hidden in the C1Ribbon/C1StatusBar controls: ScrollBars,
  ScrollPosition, ScrollSize, ScrollTrack.

==================================================================
C1Ribbon Build 2.0.20091.141         Build Date: February 12, 2009
==================================================================

- Added the Font, FontPadding, ForeColorDisabled, ForeColorInner,
  ForeColorMenuItem, ForeColorOuter, ForeColorTextBox properties
  to the C1Ribbon, C1StatusBar, RibbonTab, RibbonGroup, and
  RibbonItem components. These properties provide some degree of
  customization to the C1Ribbon/C1StatusBar controls.

- Added TextRenderingHint property to C1Ribbon and C1StatusBar.
  This property controls text rendering quality.

- Improved support for 120 DPI mode. Now the Ribbon can display
  large fonts when working in this mode.

- Fixed issue 18740 (RibbonGroup added after a collapsed group
  is seen as collapsed by default).

- Fixed an issue in the RibbonComboBox. The wrong item was
  sometimes selected in the dropped-down list. This might occur,
  for example, if item1 is "png & ico", item2 is "png", and
  the combo's Text is "png". Then, if a user opens the dropdown
  list the item1 appeared as selected (incorrect).

- Fixed an issue: An exception occurred sometimes if the user
  changes the Windows Color Scheme or DPI mode before showing
  a C1RibbonForm while the form's Visible property is False.

==================================================================
C1Ribbon Build 2.0.20083.139          Build Date: January 29, 2009
==================================================================

- Fixed issue 18992 (Ribbon Form doesn't close C1Combo when
  losing focus by Alt-Tab). The issue was partly fixed in the
  previous build but it still occurred if there is a C1Ribbon
  control on the Ribbon Form.

- Fixed a minor bug in the RibbonToggleButton.

==================================================================
C1Ribbon Build 2.0.20083.137          Build Date: January 26, 2009
==================================================================

- The C1Ribbon.QatItemIDs property has been replaced with the
  QatItemNames property. The old property is still available.
  It is only hidden from code completion.

- Fixed issue: The ribbon items that don't belong to any ribbon
  tab, menu, or toolbar can't be added to the QAT using the
  QatItemIDs property. These items were ignored by the setter
  of the QatItemIDs property in previous builds.

==================================================================
C1Ribbon Build 2.0.20083.136          Build Date: January 26, 2009
==================================================================

- When the user makes a right-click in the caption of a disable
  ribbon group the context menu for this group appeared after the
  second click only. It did't appear after the first right-click.

- The MouseEnter/MouseLeave events shouldn't be fired for the
  ribbon group when the mouse pointer hovers the drop-down button
  for the minimized group on a tab or QAT. Also, this drop-down
  button shouldn't be disabled when the group is disabled.

- It was not possible for the user to select a disabled tab on
  the C1Ribbon at runtime.

- Fixed issue: A clone of a ribbon item should be disable on the
  QAT if its source item is placed in a disabled RibbonGroup or
  disabled/invisible RibbonTab.

==================================================================
C1Ribbon Build 2.0.20083.135          Build Date: January 23, 2009
==================================================================

- If C1RibbonForm with the C1Ribbon control appears maximized
  or minimized at the first time, the form did not restore its
  original size when the user clicks the Restore window button.

- Fixed a small issue when drawing a maximized C1RibbonForm
  without a C1Ribbon control under Vista Basic color theme.

- C1RibbonForm without a C1Ribbon control was not deactivated
  properly when a user switches to another application.

==================================================================
C1Ribbon Build 2.0.20083.134          Build Date: January 19, 2009
==================================================================

- Fixed issue 18948 (When showing a modal form, such as a dialog
  box, on C1RibbonForm, the focus doesn't move to the dialog).
  The issue was introduced in build 133.

- If a C1RibbonForm appears as maximized at the first time, the
  form didn't restore its original size when the user clicks the
  Restore button under Windows Vista Aero color theme.

- When the user makes a right-click on a disable ribbon button
  the context menu for this button appeared after the second
  click only. It did't appear after the first right-click.

- If some other application is currently active the user had to
  click the min/max/close window buttons twice on C1RibbonForm.
  The first click activated the ribbon form and the second click
  invoked the button action. The standard Form executes these
  actions after the first click on the window buttons.

- The application menu had a small visual defect when it appears
  for the first time.

- Multiline description text in the application sub menu appeared
  truncated sometimes if the corresponding menu item was added
  from code at runtime.

==================================================================
C1Ribbon Build 2.0.20083.133          Build Date: January 16, 2009
==================================================================

- Fixed issue 18895 (C1RibbonForm with MDI child does not repaint
  properly when overlapped with other windows).

==================================================================
C1Ribbon Build 2.0.20083.132          Build Date: January 13, 2009
==================================================================

- The RibbonToggleButton component had a problem with persisting
  it in XML. The closing tag was missed for this element.

- The ResizeBegin and ResizeEnd events were not fired for a Form
  when the user resizes it using C1StatusBar's sizing grip.

==================================================================
C1Ribbon Build 2.0.20083.130           Build Date: January 9, 2009
==================================================================

- Fixed an issue in C1RibbonForm under Windows XP. If this form
  has a maximized MDI child window the standard min/max/close
  buttons for this window appeared in the form title bar when the
  user switches to another application.

==================================================================
C1Ribbon Build 2.0.20083.129         Build Date: December 26, 2008
==================================================================

- Fixed a problem in RibbonComboBox that caused an exception.

==================================================================
C1Ribbon Build 2.0.20083.128         Build Date: December 23, 2008
==================================================================

- Fixed issue 18760 for empty drop-downs (Opening a minimized
  C1Ribbon having a group containing a RibbonComboBox with empty
  Items collection throws an exception).

==================================================================
C1Ribbon Build 2.0.20083.127         Build Date: December 22, 2008
==================================================================

- Fixed issue 18760 (Opening a minimized C1Ribbon having a group
  containing a drop down control throws error).

- The ID property of the RibbonItem, RibbonGroup, and RibbonTab
  has been hidden. The Name property has been added instead.

- The GetItemByID() method has been hidden in the C1Ribbon and
  C1StatusBar controls. It is replaced with the GetItemByName().
  The new method searches for the RibbonItem, RibbonGroup, or
  RibbonTab with the given name through the whole C1Ribbon or
  C1StatusBar.

==================================================================
C1Ribbon Build 2.0.20083.126         Build Date: December 18, 2008
==================================================================

- Fixed issue 18725 (RibbonTabs do not show their content on
  single click over the tab at design time).

- Fixed issue 18727 (RibbonTab page appears in a popup window
  after double clicking the tab at design time).

- Fixed issue 18729 (Reverting back to System.Windows.Forms.Form
  from C1RibbonForm does not restore the BackColor of the Form).

- Fixed issue 18735 (Setting Text property for any ribbon item,
  tab, or group using a floatie form at design time does not
  update the text immediately).

- Fixed issue 18736 (RibbonComboxBox does not show Tooltips for
  dropped-down elements at runtime).

- Removed overloads of the C1Ribbon.Save() and C1StatusBar.Save()
  methods that accepted 'withImages' argument. This last argument
  was not used anyway.

- The BackColor property has been hidden in the C1RibbonForm.
  The BackgroundColor has been added instead. It was necessary
  for fixing the issue 18729.

==================================================================
C1Ribbon Build 2.0.20083.125         Build Date: December 16, 2008
==================================================================

- Some ribbon components (such as RibbonGallery, RibbonComboBox,
  RibbonColorPicker, and others) released the mouse capture when
  it was not necessary. This caused problems in some scenarios
  of the user interaction.

==================================================================
C1Ribbon Build 2.0.20083.124         Build Date: November 25, 2008
==================================================================

- Fixed issue 18628: Clicking an MDI child on its partially
  visible area (not on title bar or on its border) doesn't bring
  that MDI child on the top under Vista Aero environment.

- Fixed issue 18375 for the 'Vista Basic' color scheme (White
  border appears around C1RibbonForm, when focus is shifted out
  of the form at runtime).

==================================================================
C1Ribbon Build 2.0.20083.123         Build Date: November 21, 2008
==================================================================

- Fixed a common interaction problem: if a form with C1Ribbon is
  currently inactive and the user clicks some item on the C1Ribbon
  or C1StatusBar the form should be activated but the associated
  RibbonItem's event (such as a button click) shouldn't be fired.

==================================================================
C1Ribbon Build 2.0.20083.122         Build Date: November 19, 2008
==================================================================

- Fixed issue 18375 (White border appears around C1RibbonForm
  under Vista, when focus is shifted out of the MDI child form
  at runtime).

==================================================================
C1Ribbon Build 2.0.20083.121         Build Date: November 19, 2008
==================================================================

- C1Ribbon might hang the whole application when a context menu
  appears for an item that shows submenu (such as a RibbonMenu
  or RibbonSplitButton) within a dropped down menu. This bug fix
  addresses the issue 18587 in Doc-To-Help.

- The point of the balloon tooltip was in the wrong location.

- Tooltips for dropped down elements did not acquire properties
  from the ribbon's ToolTipSettings.

- Optimized internal storage for the embedded images.

==================================================================
C1Ribbon Build 2.0.20083.120          Build Date: October 25, 2008
==================================================================

- Fixed issue 18455 (C1Ribbon blackens out on entering incorrect
  values in property grid in Tooltip Editor).

==================================================================
C1Ribbon Build 2.0.20083.119          Build Date: October 23, 2008
==================================================================

- Fixed issue 18435 (C1Ribbon control blackens out on pressing
  Cancel button in the Tooltip editor).

- Fixed issue 18438 (Distance between control and the tooltip
  which opens increases if more than one C1Ribbon control is
  placed on the form).

==================================================================
C1Ribbon Build 2.0.20083.118          Build Date: October 21, 2008
==================================================================

- Fixed issue 18431 (Ctrl+Z does not work on text added through
  the toolbar or shortcut in the ToolTip property editor).

==================================================================
C1Ribbon Build 2.0.20083.117          Build Date: October 21, 2008
==================================================================

- Fixed an issue in the ToolTip property editor:

  When a user selects '(Add image...)' from the dropdown list
  for the Image or Subimage combos in the Office tab page the
  "Open" window appears. If the user clicks the Cancel button
  in this window an internal exception occurred and the whole
  property editor was closed with losing recent changes.

==================================================================
C1Ribbon Build 2.0.20083.116          Build Date: October 13, 2008
==================================================================

- Fixed issue 18381 (inconsistent behavior with C1Ribbon control
  when the RibbonItem components are hidden in the RibbonGroup).

- Fixed issue 18375 (white border appears around C1RibbonForm
  under Vista, when focus is shifted out of the design form).

==================================================================
C1Ribbon Build 2.0.20083.115        Build Date: September 23, 2008
==================================================================

- Fixed an issue in the RibbonControlHost element that caused an
  ArgumentNullException when the Form with a C1Ribbon closes up.

==================================================================
C1Ribbon Build 2.0.20082.114        Build Date: September 17, 2008
==================================================================

- Added a new designer (UITypeEditor) for the ToolTip property
  of the next elements: RibbonItem, RibbonGroup, and RibbonTab.

- Added the ToolTipSettings property to the C1Ribbon and
  C1StatusBar controls. It allows to adjust various settings
  of the built-in rich tooltip.

- The ToolTipMaxWidth property has been hidden in C1Ribbon and
  C1StatusBar. You should use the ToolTipSettings.MaximumWidth
  property instead of the obsolete one.

- Fixed issue 18165 (HScrollBar and VScrollBar do not scroll
  properly when hosted in RibbonControlHost).

- Added the GetToolTip() method to the C1Ribbon control:

  public string GetToolTip(Control control)

  This method retrieves the rich tooltip text associated with
  the specified control. It's a complement to the SetToolTip()
  method.

==================================================================
C1Ribbon Build 2.0.20082.113         Build Date: September 3, 2008
==================================================================

- Added the IC1RibbonHolder and IC1StatusBarHolder public
  interfaces to the C1.Win.C1Ribbon namespace:

  public interface IC1RibbonHolder
  {
      C1Ribbon GetRibbonControl();
  }

  public interface IC1StatusBarHolder
  {
      C1StatusBar GetStatusBarControl();
  }

  These interfaces should be supported by a UserControl that
  contains a C1Ribbon or C1StatusBar. Then, the UserControl can
  be "seamlessly" integrated into a C1RibbonForm. The standard
  form caption will be replaced by the C1Ribbon. The C1StatusBar
  will appear correctly at the form bottom.

  The UserControl should also override the WndProc() method
  for special processing of the WM_NCHITTEST window message.

  Here is an example of the UserControl that contains both
  C1Ribbon and C1StatusBar:

  public partial class MySuperControl : UserControl, IC1RibbonHolder, IC1StatusBarHolder
  {
      public MySuperControl()
      {
          InitializeComponent();
      }

      C1Ribbon IC1RibbonHolder.GetRibbonControl()
      {
          return c1Ribbon1;
      }

      C1StatusBar IC1StatusBarHolder.GetStatusBarControl()
      {
          return c1StatusBar1;
      }

      protected override void WndProc(ref Message m)
      {
          if (m.Msg == 0x0084 /*WM_NCHITTEST*/)
          {
              int pt = m.LParam.ToInt32();
              if (c1Ribbon1.Visible)
              {
                  Rectangle rc = RectangleToScreen(c1Ribbon1.Bounds);
                  if (rc.Contains(pt & 0xFFFF, pt >> 16))
                  {
                      m.Result = new IntPtr(-1 /* HTTRANSPARENT */);
                      return;
                  }
              }
              if (c1StatusBar1.Visible)
              {
                  Rectangle rc = RectangleToScreen(c1StatusBar1.Bounds);
                  if (rc.Contains(pt & 0xFFFF, pt >> 16))
                  {
                      m.Result = new IntPtr(-1 /* HTTRANSPARENT */);
                      return;
                  }
              }
          }
          base.WndProc(ref m);
      }
  }

  The UserControl with a C1Ribbon should be docked to the top,
  with a C1StatusBar - docked to the bottom, with both controls -
  docked to all edges.

==================================================================
C1Ribbon Build 2.0.20082.112           Build Date: August 29, 2008
==================================================================

- Changing the Text property of a RibbonLabel, RibbonMenu, or
  other like element from the program code did not resize this
  element correctly if it is placed on a ribbon tab that is
  not currently selected (but it was selected once since the
  program startup).

- While a RibbonGallery component is displayed on the selected
  RibbonTab an attempt to populate it with new gallery items
  caused incorrect appearance of the items being added.

==================================================================
C1Ribbon Build 2.0.20082.111           Build Date: August 26, 2008
==================================================================

- Fixed an issue: when the C1RibbonForm is maximized, and the
  user clicks a button to open another form the C1RibbonForm's
  title bar flickers. The issue is specific to Windows XP.

==================================================================
C1Ribbon Build 2.0.20082.110           Build Date: August 26, 2008
==================================================================

- Standard window caption appeared sometimes over the C1Ribbon
  control while the C1RibbonForm is in maximized state (under
  Windows XP only). For example, the problem occurred when the
  user clicks the application button.

- The C1RibbonForm remained in active state after the user
  switches from this form to another application while a popup
  menu (such as the application menu) is visible. The issue is
  specific to Windows XP.

==================================================================
C1Ribbon Build 2.0.20082.109           Build Date: August 22, 2008
==================================================================

- RibbonCheckBox appeared incorrectly on the QAT under Windows
  Vista. The same issue observed with RibbonButton, RibbonMenu,
  RibbonToggleButton, RibbonSplitButton if these elements have
  only text label (no image) and they were added to the QAT.

==================================================================
C1Ribbon Build 2.0.20082.108           Build Date: August 21, 2008
==================================================================

- A black line appeared along the ribbon tabs after running an
  application with C1Ribbon under Vista if the Qat.BelowRibbon
  property was set to True at design time.

==================================================================
C1Ribbon Build 2.0.20082.107           Build Date: August 14, 2008
==================================================================

- Fixed a couple of small problems with using the C1StatusBar
  on an inherited form (issue 17786).

==================================================================
C1Ribbon Build 2.0.20082.106           Build Date: August 14, 2008
==================================================================

- The TTP issue 17786 (Smart Tags and Smart Designers are not
  visible on an inherited form) has been fixed for C1StatusBar
  and individual ribbon items, such as groups, buttons, etc.

==================================================================
C1Ribbon Build 2.0.20082.105           Build Date: August 11, 2008
==================================================================

- Fixed issue 17591 (C1Ribbon is not repainted properly when
  "Alt+Tab" keys are used to switch between applications).

- Fixed issue 17639 (C1Ribbon child form does not redraw correctly
  when it is maximized and then restored).

- Fixed issue 17786 (Smart Tags and Smart Designers of C1Ribbon
  are not visible on an inherited form).

==================================================================
C1Ribbon Build 2.0.20082.103              Build Date: July 9, 2008
==================================================================

- Fixed a design-time issue that was introduced in build 102.
  A NullReferenceException occurred sometimes in C1Ribbon and
  C1StatusBar on the inherited form.

==================================================================
C1Ribbon Build 2.0.20082.102              Build Date: July 7, 2008
==================================================================

- Fixed an issue:
  After double clicking in the title bar of ribbon MDI child
  form, the form gets maximized but colors change and form looks
  different.

- Fixed a small misalignment problem when the Enabled property
  of a RibbonEditBox is set to False.

- Removed a one-pixel line at the bottom of a C1RibbonForm (in
  Normal window state) under Vista.

- Fixed TTP issue 17544: When the form containing C1Ribbon control
  which is declared as 'private' is inherited by another form, the
  RibbonComponents remain editable on the inherited form & VS IDE
  crashes on changing its properties.

- Keyboard events were not processed correctly for the opened
  RibbonComboBox that is used within a RibbonMenu.

- The auto-search did not work correctly in the RibbonComboBox.

- RibbonComboBox highlighted previous selected option in the
  dropdown when the user clears text in the editable portion,
  then drops down the combobox.

==================================================================
C1Ribbon Build 2.0.20082.101             Build Date: June 25, 2008
==================================================================

- An exception with message: "one of the types could not be
  loaded" occurred sometimes in the RibbonControlHost when adding
  this element to a ribbon group at design time.

- The predefined images did not appear sometimes for C1Ribbon
  elements at design time.

==================================================================
C1Ribbon Build 2.0.20082.100             Build Date: June 18, 2008
==================================================================

- Fixed TTP issue 17317 for several ribbon components.

- Fixed TTP issue 17491:
  Windows TaskBar (with AutoHide checked) does not appear when
  C1RibbonForm Application is maximized.

- Fixed a minor issue that causes incorrect size of maximized
  MDI child windows under Windows Vista.

==================================================================
C1Ribbon Build 2.0.20082.99              Build Date: June 16, 2008
==================================================================

- Fixed TTP issue 17497:
  Minimized C1Ribbon Tab disappears when item is added to
  RibbonComboBox/FontComboBox in the DropDown event.

==================================================================
C1Ribbon Build 2.0.20082.98               Build Date: June 6, 2008
==================================================================

- Fixed TTP issue 17317:
  When a call to an ActiveX-DLL (which has a form with button
  placed on it) is made from a C1RibbonButton_click event, the
  button needs to be clicked twice to execute the click event
  of the button.

==================================================================
C1Ribbon Build 2.0.20082.97               Build Date: May 31, 2008
==================================================================

- Scrollbars did not appear on the MdiClient window within the
  C1RibbonForm when a user executes the LayoutMdi() method and
  the MDI child forms have (FormBorderStyle = FixedSingle).

- If there is a simple control in the RibbonControlHost item,
  when a user points the mouse over it the RibbonGroup became
  un-highlighted, when he leaves the control host became
  highlighted again. The same effect was observed when moving
  the mouse over a ribbon group containg a separator.

- It was impossible to right-click a disabled item in a ribbon
  group to display its context menu that allows to add the
  clicked item to QAT.

==================================================================
C1Ribbon Build 2.0.20082.96               Build Date: May 21, 2008
==================================================================

- When a class inherits from RibbonControlHost, following
  warning message was displayed for the class's design:
  "Constructor on type 'C1.Win.C1Ribbon.RibbonControlHost'
  not found."

- A small bug has been fixed in the C1RibbonForm.

==================================================================
C1Ribbon Build 2.0.20082.95               Build Date: May 20, 2008
==================================================================

- The BackColor of MdiClient window (if IsMdiContainer is set
  to true for the C1RibbonForm) shouldn't depend on the
  VisualStyle of the owner C1RibbonForm. The MdiClient should
  always use KnownColor.AppWorkspace for the BackColor.

==================================================================
C1Ribbon Build 2.0.20082.94               Build Date: May 15, 2008
==================================================================

- MDI child window with (WindowState = Maximized) appeared
  as normal window without title until the user resizes the
  MDI parent C1RibbonForm.

==================================================================
C1Ribbon Build 2.0.20082.93               Build Date: May 12, 2008
==================================================================

- The C1RibbonForm.MainMenuStrip property was hidden in
  build 92. It is now restored to allow using the MenuStrip
  control on the C1RibbonForm.

==================================================================
C1Ribbon Build 2.0.20082.92                Build Date: May 9, 2008
==================================================================

- Maximized MDI child showed standard title bar over the
  C1Ribbon control under Windows Vista.

- The currently focused control lost the input focus when
  the user clicks a button on the C1Ribbon or C1StatusBar.

- The following properties have been hidden:

  C1Ribbon.TabStop
  C1Ribbon.TabIndex
  C1RibbonForm.MainMenuStrip
  C1StatusBar.TabStop
  C1StatusBar.TabIndex

==================================================================
C1Ribbon Build 2.0.20082.91                Build Date: May 8, 2008
==================================================================

- Corners of an MDI child ribbon form flickered when the
  user drags the form with the mouse.

- The BackColor property of an MDI child ribbon form was
  not updated when the VisualStyle of an MDI parent ribbon
  form changes.

==================================================================
C1Ribbon Build 2.0.20082.90                Build Date: May 7, 2008
==================================================================

- Unlike Office-2007 Ribbon, tooltip for 'RibbonComboBox'
  appears on hovering the mouse over drop down button even
  if its drop down list is open.

==================================================================
C1Ribbon Build 2.0.20082.89                Build Date: May 2, 2008
==================================================================

- Steps to reproduce the issue: populated the ribbon gallery,
  move down one row. Press the popdown key to see full list.
  Click off to the side, choose not to pick any of the images.
  The up arrow on the gallery is disabled even though there
  is still one row above it.

- When the user moves the mouse cursor over top of a ribbon
  group this group may draw itself for half a second on top
  of a non-modal form that overlays the ribbon group.

==================================================================
C1Ribbon Build 2.0.20082.88             Build Date: April 30, 2008
==================================================================

- C1RibbonForms disappeared from the Application.OpenForms
  collection when the windows theme is changed, for example,
  from Windows Classic to Windows XP. (VNRIB000387)

- The C1Ribbon control threw an error when adding items to
  a group through the property grid at runtime. (VNRIB000425)

- MDIParent C1RibbonForm showed incorrect backcolor at
  runtime. (VNRIB000426)

- The default value for the C1Ribbon.MinimumWidth and
  MinimumHeight properties has been changed from 200 to 0.
  (VNRIB000423 and VNRIB000424)

==================================================================
C1Ribbon Build 2.0.20082.87             Build Date: April 24, 2008
==================================================================

- C1RibbonForm with C1Ribbon present on it did not resize
  properly when Form.AutoSize = True and Form.AutoSizeMode
  = GrowAndShrink. (VNRIB000388)

- C1RibbonForm returned incorrect height at runtime.
  (VNRIB000394)

- Form flickered across the right margin in the C1RibbonForm,
  if padding of the form is set. (VNRIB000395)

- Child C1RibbonForm shown incorrect theme when MDIParent
  has a C1Ribbon control. (VNRIB000396)

- Ribbon tab caption being cut off at ends at runtime.
  (VNRIB000398)

- Controls overlap with the Ribbon in C1RibbonForm when
  Control's Dock is set to Top. (VNRIB000399)

- When a C1Ribbon control is placed on a C1RibbonForm, the
  title bar of the C1RibbonForm was overlapped by the
  Ribbon control at run time. Thus the title and Minimize/
  Maximize/Close buttons did not appear. (VNRIB000415)

- Tab area became black if the only available tab is made
  invisible. (VNRIB000416)

- Fixed an issue with control scrollbars on a C1RibbonForm.

==================================================================
C1Ribbon Build 2.0.20082.86              Build Date: April 2, 2008
==================================================================

- When the user places the mouse cursor over the gallery
  element and uses the scroll wheel it moved the gallery
  to the next row and also switched the ribbon to the next
  tab. Now the scroll wheel only switches the ribbon to
  the next tab without scrolling the gallery element.

==================================================================
C1Ribbon Build 2.0.20082.85             Build Date: March 27, 2008
==================================================================

- A NullReferenceException occurred when disposing a form
  with the C1Ribbon control after clicking the "close" item
  in a ribbon drop-down (such as a RibbonMenu).

==================================================================
C1Ribbon Build 2.0.20082.84             Build Date: March 25, 2008
==================================================================

- Tooltip did not appear for the RibbonEditBox and
  RibbonComboBox elements when the mouse pointer hovers
  text part of the element.

- Added the RibbonControlHost element. It allows to embed
  an arbitrary control into the C1Ribbon.

  For example, let's add the TextBox control to a ribbon
  group. We have to define the following class:

  VB:

  Public Class TextBoxHost
      Inherits C1.Win.C1Ribbon.RibbonControlHost

      Public Sub New()
          MyBase.New(New System.Windows.Forms.TextBox())
      End Sub

  End Class

  C#:

  public class TextBoxHost : C1.Win.C1Ribbon.RibbonControlHost
  {
      public TextBoxHost()
          : base(new System.Windows.Forms.TextBox())
      {
      }
  }

  Now we should build the project and open a form with the
  C1Ribbon control in the designer.

  Open the action floatie for the RibbonGroup, then select
  "Add ControlHost". This will open a dialog box where you
  should type the class name of our control host, such as
  "RibbonApplication1.TextBoxHost". When you click the OK
  button the control will be added to the ribbon group.

  Next time, when you want to add the TextBoxHost element
  you don't have to type its name. The name of this class
  can be selected from the drop-down list in the "Adding
  RibbonControlHost" dialog box.

  The RibbonControlHost class publishes the standard
  properties and events of the hosted control. To access
  other properties, methods, and events of the hosted
  control use the RibbonControlHost.Control property.

  It is also possible to override methods such as
  RibbonControlHost.OnSubscribeControlEvents to handle
  events raised by the hosted control. You can put custom
  functionality into properties to enhance the hosted
  control.

==================================================================
C1Ribbon Build 2.0.20081.83             Build Date: March 15, 2008
==================================================================

- Incorrect header appeared above the C1RibbonForm if this
  form is shown from its Load event handler behind a splash
  screen and the value of the Localizable property is True
  for that form.

- An issue was introduced in the previous build (82). The
  standard window caption and buttons appeared sometimes
  on a C1RibbonForm under Windows XP.

==================================================================
C1Ribbon Build 2.0.20081.82             Build Date: March 14, 2008
==================================================================

- A white horizontal bar appeared on a C1RibbonForm under
  Vista when this form is resized to small size and the
  C1Ribbon control on this form should be hidden.

- If the C1Ribbon control doesn't appear because the parent
  C1RibbonForm has too small size there was a problem when
  the user maximizes then restores that C1RibbonForm.

- The Form.LayoutMdi() method did nothing if the MDI child
  forms are based on C1RibbonForm.

==================================================================
C1Ribbon Build 2.0.20081.81           Build Date: February 5, 2008
==================================================================

- Added new properties to the RibbonEditBox element:
  PasswordChar and UseSystemPasswordChar. These are
  counterparts of the same properties of the standard
  TextBox control.

- Added some French strings for runtime localization.

==================================================================
C1Ribbon Build 2.0.20081.80           Build Date: January 15, 2008
==================================================================

- Minimizing the Ribbon and then maximizing it always
  returned to the first tab.

- The Tag property of the RibbonGroup and RibbonTab elements
  is now visible in the property grid and can be assigned at
  design time. The type of this property is Object. We can't
  preserve its value in the Ribbon XML Template.

- The FormBorderStyle property of the C1RibbonForm can now
  be set to None.

- The RibbonToggleButton element with the Pressed property
  set to True at design time did not appear correctly in the
  RibbonApplicationMenu at run time.

- There were some problems with a C1RibbonForm which has
  FixedSingle or FixedDialog border style. Each attempt to
  open this form without recreating it caused a loss of 10
  pixels in width and height.

- A double click in the caption of a C1RibbonForm is ignored
  and doesn't maximize the form if the Maximize window
  button is hidden or not enabled.

==================================================================
C1Ribbon Build 2.0.20073.79          Build Date: December 27, 2007
==================================================================

- Several localization strings were updated.

==================================================================
C1Ribbon Build 2.0.20073.78          Build Date: December 26, 2007
==================================================================

- If RibbonProgressBar.Minimum >= RibbonProgressBar.Maximum
  the value of "Maximum" and "Value" didn't become equal to
  "Minimum" (the issue was not fixed correctly in build 76).

- Added several missing localization strings.

==================================================================
C1Ribbon Build 2.0.20073.77          Build Date: December 21, 2007
==================================================================

- Instances of the C1RibbonForm class were excluded from the
  Application.OpenForms collection when windows theme is
  changed, for example, from Windows Classic to Windows XP.

- The Size, Location, and Padding properties of the C1Ribbon
  and C1StatusBar controls have been hidden because these
  controls are autosized and can't contain nested controls.

- Refixed a problem with RibbonMenu/RibbonSplitButton items
  present in the MenuItems collection of a RibbonComboBox
  (VNRIB000374).

- Added Project and Item Templates for Visual Studio 2008.

==================================================================
C1Ribbon Build 2.0.20073.76          Build Date: December 14, 2007
==================================================================

- The RibbonSeparator.HiddenMode property was not working
  on QAT.

- The RibbonSeparator.ShowInQATMenu property has been hidden.

- Added default context menu having an option to remove the
  RibbonSeparator item from QAT.

- Fixed a problem with RibbonMenu/RibbonSplitButton items
  present in the MenuItems collection of a RibbonComboBox.

- It was not possible to select a RibbonToggleButton in
  RibbonToggleGroup when added to the MenuItems collection
  of RibbonComboBox/RibbonFontComboBox.

- Added the navigation through Keyboard feature for Items
  and MenuItems in the RibbonGallery element.

- If RibbonProgressBar.Minimum >= RibbonProgressBar.Maximum
  the value of "Maximum" and "Value" didn't become equal to
  "Minimum".

- No error occurred on setting 'Value' property of
  RibbonProgressBar/RibbonTrackBar to a value lying outside
  the range specified by "Minimum" and "Maximum".

- Black area appeared and C1StatusBar control appeared on
  top of this black area when the C1StatusBar control is
  resized from top at design time. The same issue occurred
  for the C1Ribbon control when it is resized from bottom
  at design time.

- Hotkeys for the RibbonColorPicker and RibbonSplitButton
  components did not work as expected.

- Hotkeys and shortcuts for the Ribbon components added in
  the C1StatusBar control did not work.

- The RibbonItem.Tag property is now visible in the property
  grid and can be assigned at design time. The type of this
  property is Object. We can't preserve its value in the
  Ribbon XML Template.

- GotFocus/LostFocus for RibbonItems with text area fired
  multiple times on placing focus on them then shifting to
  some other and back to these controls.

- MouseEnter/MouseLeave for all the items added in
  RibbonMenu/RibbonSplitButton items collection fired even
  on navigating through keyboard.

==================================================================
C1Ribbon Build 2.0.20073.75           Build Date: December 4, 2007
==================================================================

- The Ribbon changes the selected tab when the mouse wheel
  moves while the mouse pointer is within the Ribbon.

- Added the HiddenMode boolean property to the
  RibbonSeparator class (false by default). When this
  property is True the separator doesn't appear in a
  RibbonGroup but it works still as usual.

==================================================================
C1Ribbon Build 2.0.20073.74          Build Date: November 30, 2007
==================================================================

- Incorrect height retrieved after the Form_Load of a run
  time instance of C1RibbonForm containing C1Ribbon control.

==================================================================
C1Ribbon Build 2.0.20073.73          Build Date: November 28, 2007
==================================================================

- InvalidOperationException observed when multiple instances
  of C1Ribbon involved in a multithreaded application.

- Some unexpected key combinations (such as 'Ctrl+Ins',
  'Ctrl+Y', 'Ctrl+]', and so on) were captured by the Ribbon
  and selected the next ribbon tab.

- ArgumentOutOfRange exception was thrown in the RibbonMenu
  and RibbonSplitButton drop-downs when they have a
  RibbonToggleGroup element and the user presses the arrow
  keys to navigate through the menu.

- Added setters for the RibbonComboBox.SelectedIndex and the
  RibbonComboBox.SelectedItem properties. Both of these
  properties were readonly in previous builds.

- Added the ShowContextMenu event to the RibbonGalleryItem
  component. There is no standard context menu for this
  element. The user can display his own context menu from
  the handler for the ShowContextMenu event.

==================================================================
C1Ribbon Build 2.0.20073.72          Build Date: November 19, 2007
==================================================================

- Fixed a problem that caused SLE to crash on exit.

==================================================================
C1Ribbon Build 2.0.20073.71          Build Date: November 15, 2007
==================================================================

- Trapped an InvalidOperationException that may occur in a
  C1RibbonForm if the application has multiple GUI threads.

- Fixed some issues in C1RibbonForm under Vista when the
  FormBorderStyle property is FixedDialog.

- The caption of a C1RibbonForm was not updated in the
  Task Bar when the user assigns a new value to the Text
  property of the C1RibbonForm from code.

==================================================================
C1Ribbon Build 2.0.20073.70           Build Date: November 1, 2007
==================================================================

- The title of C1RibbonForm was incorrect if such a form
  contains a maximized childform. It was not fixed correctly
  in build 69.

- If the C1Ribbon control placed on a C1RibbonForm is
  disabled, then the window buttons(min,max,close) did not
  inherit VisualStyle of the form and showed the standard
  theme buttons when clicked.

- ApplicationMenu button properties showed 'Object Reference
  Not Set' on an existing RibbonForm when a new Windows Form
  with StatusBar added to the Project.

- The next properties inherited from the Control class have
  been hidden in C1Ribbon and C1StatusBar classes: Anchor,
  MaximumSize, MinimumSize.

- The tab area turned black when the 'Visible' property of
  the only present tab is set to 'False'.

- The BackColor of the C1RibbonForm didn't get changed if
  VisualStyle of C1Ribbon is changed while the layout logic
  for the form is suspended.

- When the WindowState property of a C1RibbonForm is set to
  'Maximized' at design time the form appeared at the wrong
  location at runtime.

- Hightlighting on a ribbon button existed after disabling
  and enabling the button if the button was disabled in the
  Click event handler.

- Added the AllowMinimize property to the C1Ribbon control.
  The property specifies whether the ribbon can be minimized
  when the user double-clicks on tab header.

==================================================================
C1Ribbon Build 2.0.20073.69           Build Date: October 29, 2007
==================================================================

- The default tooltips appeared for all items on the QAT if
  the user adds any other item to QAT.

- A number of exceptions were thrown on trying to add the
  C1Ribbon or C1StatusBar controls on a Windows form added
  in a Ribbon application.

- On toggling the properties "ShowInQat","ShowInQatMenu"
  from the property grid, the ribbon items were removed from
  the property grid.

- The title of C1RibbonForm was incorrect when such a form
  containing a maximized childform.

- The Visible property of the RibbonApplicationMenu object
  has been hidden.

- Fixed a couple of issues when the Quick Access Toolbar is
  hidden: removed unnecessary item from RibbonItem's context
  menu, removed the selection glyph for a hidden QAT.

- A big black rectangle displayed in the content area of the
  C1Ribbon control that was in minimized state when the user
  unchecked the "Minimize the Ribbon" option in the context
  menu for a RibbonItem on a popped up RibbonTab.

- Added the IsDisposed runtime property to the following
  classes: RibbonItem, RibbonGroup, and RibbonTab. The
  property returns a boolean value indicating whether the
  corresponding object has been disposed of.

- Fixed a one-pixel misalignment problem under Vista that
  occurred when the QAT is above the Ribbon and has no items.

- After defining the MinimumSize property in a form that
  inherits from C1RibbonForm, there were very strange
  behaviors: 1) the StartPosition property were not
  respected 2) when the application looses the focus and you
  use Alt+Tab or click on the application's icon in the task
  bar, the calling form of the C1RibbonForm was displayed
  instead of the C1RibbonForm itself.

==================================================================
C1Ribbon Build 2.0.20073.68           Build Date: October 21, 2007
==================================================================

- Added the TabPopupWidth property that specifies the
  maximum width of the tab popup window when the Ribbon is
  minimized. The default value is -1. This stretches the
  popup window to the whole width of the owner window.

- The RibbonComboBox.Text property returned wrong (old)
  value in the handler for the SelectedIndexChanged event
  of this RibbonComboBox.

==================================================================
C1Ribbon Build 2.0.20073.67           Build Date: October 15, 2007
==================================================================

- Fixed artefacts with the larger scale (120DPI) mode
  under Vista.

- Fixed a misalignment in the ribbon caption when the
  C1Ribbon control is placed on an arbitrary Form (not
  C1RibbonForm) and QAT is below the ribbon.

==================================================================
C1Ribbon Build 2.0.20073.66           Build Date: October 10, 2007
==================================================================

- When a user control was created by using C1Ribbon or
  C1StatusBar, a license popup appeared for the control
  at runtime when it is used in a new project.

- When the RibbonProgressBar control is added in the
  RightPaneItems collection of C1StatusBar control and its
  Width property is set to some large value (say 200), the
  RightPane does not resize itself and results in the
  clipping of RibbonProgressBar control.

- The DoubleClick event shouldn't be fired and processed
  after double-clicking the right mouse button.

- Added the GetHostRibbonItem static method to the C1Ribbon
  class. This method allows to find out the owner RibbonItem
  for the specified control, such as a TextBox, that is used
  internally in the RibbonItem (e.g. in the RibbonEditBox).

- The RibbonGroup.MouseLeave event was not fired when the
  user moves the mouse pointer slowly out of the group.

- Tooltips may appear off the screen.

- Values of 'MinimumWidth' and 'MinimumHeight' properties
  of C1Ribbon control not retained on saving and loading
  the Ribbon template XML.

- 'ObjectDisposedException' observed when 'MinimumWidth'/
  'MinimumHeight' property is set inside any event handler
  of any C1RibbonItem.

==================================================================
C1Ribbon Build 2.0.20073.65            Build Date: October 5, 2007
==================================================================

- When the user adds the C1StatusBar control to the form
  there was a one-pixel displacement of the status bar.

- When the user adds an item to the left pane of the
  newly added C1StatusBar control the right pane shrinked.
  It was then impossible to click the right pane to enable
  the smart designer for the right pane.

- When the user removes the C1StatusBar control the owner
  C1RibbonForm was not redrawn.

==================================================================
C1Ribbon Build 2.0.20073.64         Build Date: September 27, 2007
==================================================================

- Added several missing localization strings.

==================================================================
C1Ribbon Build 2.0.20073.63         Build Date: September 24, 2007
==================================================================

- When the form is minimized from bottom to top, still the
  C1Ribbon remains visible unlike the MS Word 2007.

- Added the MinimumHeight property to the C1Ribbon control.
  This property sets the minimum height of the parent
  container. The C1Ribbon will disappear if the container
  height become less than the specified value.

- Provided an upper limit for the GapBeforeTextArea property
  of RibbonComboBox/RibbonEditBox. The maximum allowable
  value for this property has been set to 80.

- Setting C1Ribbon.Enabled or C1RibbonForm.Enabled to False
  also disabled the window buttons (min, max, close) on the
  C1RibbonForm.

- Copying then pasting the RibbonComboBox/RibbonEditBox
  elements at design time did not retain their value of
  the GapBeforeTextArea property.

==================================================================
C1Ribbon Build 2.0.20073.62         Build Date: September 19, 2007
==================================================================

- The menus, comboboxes, and split buttons did not always
  drop open if they are clicked on when the Form is not
  currently active. The user had to click off and back on
  to get them to open.

- The SetTooltip() method of the C1Ribbon control has been
  renamed to SetToolTip().

==================================================================
C1Ribbon Build 2.0.20073.61          Build Date: September 4, 2007
==================================================================

- Added several missed Japanese resource strings.

==================================================================
C1Ribbon Build 2.0.20073.60            Build Date: August 31, 2007
==================================================================

- Items on the C1StatusBar used black (invisible) text color
  when the C1StatusBar has black visual style.

- Added support for the FixedSingle and FixedDialog border
  styles to the C1RibbonForm under Windows Vista.

- The ControlBox, MaximizeBox, and MinimizeBox properties
  of the child MDI form were not honored when the child form
  is maximized in the C1RibbonForm with the C1Ribbon on it.

==================================================================
C1Ribbon Build 2.0.20073.59            Build Date: August 29, 2007
==================================================================

- Removed a one-pixel displacement of the C1StatusBar under
  Windows Vista with Aero (Glass) interface.

- The standard context menu appears now on a right button
  click in the tab area and app menu button of the C1Ribbon.

- The ribbon items can now serialize their strings into the
  .resx file. So, if the Localizable property of the owner
  form is True it is possible to localize the strings in
  ribbon items using the resource file.

- Updated several localized strings on the C1Ribbon.

- Adjusted styles for some elements (such as RibbonButton,
  RibbonMenu, and others) on the C1StatusBar.

- Added the Width property to the RibbonProgressBar. It was
  impossible to change width of this element.

==================================================================
C1Ribbon Build 2.0.20073.58            Build Date: August 23, 2007
==================================================================

- The MouseEnter and MouseLeave events were not fired for
  collapsed groups on the ribbon. These events are fired
  now as though this is a regular group, not a drop-down
  button that shows the group.

- Added the group context menu to collapsed ribbon groups.

- Added a couple of new methods to C1Ribbon and C1StatusBar:

  public void BeginUpdate()
  public void EndUpdate()

  These methods maintain performance while items are being
  added or removed. When adding a large number of items, you
  should use the BeginUpdate method to prevent item
  collections from updating their internal state each time
  an item is added. Once you have completed the task of
  adding items, call the EndUpdate method to resume regular
  processing.

- Added a new property to RibbonComboBox and RibbonEditBox:

  public int GapBeforeTextArea { get; set; }

  This property specifies the gap (in pixels) between the
  "label" and "textbox" parts of the element. This allows
  to line up "textbox" parts of several combo/editboxes
  vertically on a ribbon group.

==================================================================
C1Ribbon Build 2.0.20073.57            Build Date: August 22, 2007
==================================================================

- There were major problems in C1RibbonForm when the user
  switched the current desktop theme from Aero (Glass) to
  Vista Basic/Standard and vice versa.

- When the user dropped down a menu (app menu, qat menu,
  or a ribbon menu) and clicked on some other window, the
  Deactivate event did not fire for the C1RibbonForm.

- Added a new run-time property to the C1Ribbon control:

  public string QatItemIDs { get; set; }

  This property allows to preserve QAT items added by the
  user at run-time. It gets or sets the string that specifies
  the list of item IDs on the QAT.

- Added a new public method to C1Ribbon and C1StatusBar:

  public Component GetItemByID(string ID)

  The method searches for the first item with the specified
  ID through the whole C1Ribbon or C1StatusBar. The returned
  value can be either RibbonItem or RibbonGroup (or null).

==================================================================
C1Ribbon Build 2.0.20073.56            Build Date: August 21, 2007
==================================================================

- An unpredictable runtime exception occurred sometimes during
  interaction with the ribbon if the HotTransitionEffect
  property of that control is True.

- Changing the VisualStyle property of the C1RibbonForm also
  updates the BackColor property of this form.

- Fixed a number of issues under Windows Vista including some
  fixes in the title bar of C1RibbonForm and the problem that
  caused C1RibbonForm to grow in height each time when the
  user restores the form from minimized or maximized state.

==================================================================
C1Ribbon Build 2.0.20072.55              Build Date: July 27, 2007
==================================================================

- When the ribbon is hidden (minimized), the topmost ribbon
  form continued to remain on top of other windows even after
  the code sets the TopMost property to False from the
  RibbonCheckBox.CheckedChanged event handler.

- Added the OwnerControl property to RibbonItem instead of the
  RibbonItem.Ribbon property that was removed by accident from
  the previous build of the product. The OwnerControl property
  returns either C1Ribbon or C1StatusBar that this RibbonItem
  belongs to.

- The RibbonDropDownBase.DropDown event fired after the popup
  window has already appeared. There was no way to modify the
  drop-down menu from the event handler. Now the DropDown event
  occurs before laying out the popup window.

==================================================================
C1Ribbon Build 2.0.20072.53              Build Date: July 24, 2007
==================================================================

- The Activated/Deactivate events of the C1RibbonForm were
  fired when the user clicked on a ribbon menu item or the
  ribbon application menu.

- The ribbon theme font has been changed from "Tahoma" to
  "Segoe UI" when the control works under Windows Vista.

- There was a problem with updating the title bar of a narrow
  ribbon form under Windows Vista.

==================================================================
C1Ribbon Build 2.0.20072.52              Build Date: July 11, 2007
==================================================================

- It was not possible to move the C1RibbonForm on the second
  monitor if it was on the left of the primary monitor. The
  C1RibbonForm seemed to be frozen on the second monitor.

==================================================================
C1Ribbon Build 2.0.20072.51              Build Date: July 11, 2007
==================================================================

- An unhandled NullReferenceException occurred when the
  user removed an item from ribbon's QAT at runtime
  if the TopMost property of the owner form was True.

- A small change applied to the ribbon templates - the
  status bar in the templates now uses dynamic width
  for the right pane.

==================================================================
C1Ribbon Build 2.0.20072.50              Build Date: July 10, 2007
==================================================================

- Added a smart designer (with drag&drop, copy&paste, etc.)
  to the C1StatusBar control.

- Fixed a problem with disposing of the ribbon designer.

- The default value for the C1StatusBar.RightPaneWidth
  property has been set to -1. This allows to update the
  width of status bar's right pane automatically.

==================================================================
