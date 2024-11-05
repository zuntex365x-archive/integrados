==================================================================
C1InputPanel              ComponentOne, LLC - www.componentone.com
==================================================================

Welcome to ComponentOne Input Panel.  

The C1InputPanel allows users to create input forms very quickly
and consistently. It is a panel that contains many simple input
controls (buttons, textboxes, combo boxes, etc). The C1InputPanel
can be bound to a data source.
------------------------------------------------------------------

ComponentOne Input Panel is an integral part of Studio Enterprise,
the largest and most complete toolset for developing Win, Web,
Mobile and ASP.NET AJAX enabled applications.

Please direct feedback for C1InputPanel to the following forum:

http://our.componentone.com/groups/winforms/inputpanel-for-winforms/forum/

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

 Files: C1.Win.C1InputPanel.2/4.dll, C1.Win.C1InputPanel.2/4.XML,
        C1.Win.C1InputPanel.4.Design.dll

Component: C1InputPanel
------------------------------------------------------------------

It is possible to embed an arbitrary control into a C1InputPanel.
For example, let's add the MonthCalendar control to the input panel.
We have to define the following class:

VB:

Public Class MonthCalendarHost
    Inherits C1.Win.C1InputPanel.InputControlHost

    Public Sub New()
        MyBase.New(New System.Windows.Forms.MonthCalendar())
    End Sub

End Class

C#:

public class MonthCalendarHost : C1.Win.C1InputPanel.InputControlHost
{
    public MonthCalendarHost()
        : base(new System.Windows.Forms.MonthCalendar())
    {
    }
}

Now we should build the project and open a form with the
C1InputPanel control in the designer.

Open the action list (SmartTag) for the C1InputPanel, then select
"InputControlHost" in the "Add New Item" combobox. This will open
a dialog box where you should type the class name of our control
host, such as "WindowsApplication1.MonthCalendarHost". If you
click the OK button the control will be added to the input panel.

Next time, when you want to add the MonthCalendarHost component
you don't have to type its name. The name of this class can be
selected from the drop-down list in the "Adding InputControlHost"
dialog box.

It is highly recommended to move all the InputControlHost-based
components to a separate dll project that will not be rebuilt
together with the main application. This allows to avoid the
well-known issue: In VS2008 and VS2010 IDE, no property of the
form or the C1InputPanel containing a InputControlHost can be
changed when the application is debugged once.
------------------------------------------------------------------

History of Changes
==================================================================
C1InputPanel Build 2/4.0.20142.183                   July 26, 2014
==================================================================

- Fixed an issue: Unlike MS ComboBox, InputComboBox's dropdown
  doesn't open while typing when setting AutoCompleteMode and
  DropdownStyle to 'Suggest' and 'DropDownList' (TFS 76934).

==================================================================
C1InputPanel Build 2/4.0.20142.182                   July 16, 2014
==================================================================

- Fixed an issue: InputComboBox.MismatchValueErrorText property
  cannot be set to a string not containing '{0}' (see TFS 72306).

==================================================================
C1InputPanel Build 2/4.0.20141.179               February 27, 2014
==================================================================

- Fixed an issue: InputProgressBar disappears after setting
  HorizontalAlign to Near, Far or Center (TFS 54407).

==================================================================
C1InputPanel Build 2/4.0.20141.178               February 25, 2014
==================================================================

- Fixed an issue: An exception occurs after setting some colors
  in InputStyle or theme to Color.Transparent (see TFS 51929).

==================================================================
C1InputPanel Build 2/4.0.20141.177               February 24, 2014
==================================================================

- Added support for gradient backgrounds to styles.

- Fixed an issue: When setting DropDownArrowPressed to any color,
  the color of dropdown arrows is not applied although pressing
  the dropdown button (TFS 52188).

- Fixed an issue with not applying style to the text of disabled
  InputTextBox/InputComboBox and other like elements.

- C1InputPanel is now licensed as a part of Studio for Desktop.

==================================================================
C1InputPanel Build 2/4.0.20141.176               February 19, 2014
==================================================================

- Fixed an issue introduced in build 174: Unlike previous build,
  dropdown of InputComboBox is not dropped when the DroppedDown
  property is set True within the ChangeCommitted event handler
  (TFS 51764).

- Small changes related to theme support.

==================================================================
C1InputPanel Build 2/4.0.20141.174               February 18, 2014
==================================================================

- Fixed an issue: InputComboBox’s dropdown border color is shown
  as red color by setting Custom style at second time (TFS 51723).

- Many changes to the theme format.

==================================================================
C1InputPanel Build 2/4.0.20141.171               February 10, 2014
==================================================================

- Updated theming code for the latest version of C1ThemeDesigner.

==================================================================
C1InputPanel Build 2/4.0.20141.170                February 2, 2014
==================================================================

- Added the Custom visual style to C1InputPanel control.

==================================================================
C1InputPanel Build 2/4.0.20132.167                October 17, 2013
==================================================================

- Fixed an issue: When a message box is displayed from the
  LinkClicked event of the InputHtmlLabel then the sender object
  is not updated after clicking on different InputHtmlLabel link
  (TFS 43922).

==================================================================
C1InputPanel Build 2/4.0.20132.166              September 10, 2013
==================================================================

- Internal localization code is updated.

==================================================================
C1InputPanel Build 2/4.0.20132.165                   July 12, 2013
==================================================================

- InputComponent.Tag property is now visible in the property grid
  and serializable in code-behind. It is still not persisted when
  saving the input panel definition into an XML file. (TFS 39656)

==================================================================
C1InputPanel Build 2/4.0.20132.164                    June 4, 2013
==================================================================

- URL changes for GrapeCity JPN AboutBox.

==================================================================
C1InputPanel Build 2/4.0.20131.162                   April 3, 2013
==================================================================

- Moved to the subscription licensing model in Japanese build.

==================================================================
C1InputPanel Build 2/4.0.20123.159                January 15, 2013
==================================================================

- Fixed an issue: binding C1InputPanel to a table with columns
  of enumeration type did not properly configure the combobox
  elements for such columns.

==================================================================
C1InputPanel Build 2/4.0.20123.157               December 14, 2012
==================================================================

- Fixed an issue: Two different tooltips are displayed for an
  InputNumericBox depending on the mouse pointer position after
  setting its Minimum and Maximum properties and also using the
  Validating event to update the ErrorText message (TFS 31375).

==================================================================
C1InputPanel Build 2/4.0.20123.156                October 25, 2012
==================================================================

- The interface language depends now on CurrentUICulture setting
  instead of the CurrentCulture property of CultureInfo.

==================================================================
C1InputPanel Build 2/4.0.20123.155                October 21, 2012
==================================================================

- Small internal optimization.

==================================================================
C1InputPanel Build 2/4.0.20123.154                October 15, 2012
==================================================================

- Fixed an issue: InputLabel text appears clipped when the next
  item's Visibility is set to Hidden and that item is the last
  in the Items collection (TFS 29067).

- Fixed an issue: No validation occurred for 'MaxDropDownItems'
  property of InputComboBox (TFS 29065).

- Fixed an issue: In InputComboBox, the Click event is not fired
  when the drop-down button is clicked at runtime (TFS 29069).

==================================================================
C1InputPanel Build 2/4.0.20123.153                October 13, 2012
==================================================================

- Fixed an issue: when the Pressed property is set to true for
  an InputButton it gets in pressed state at the design time even
  if the CheckOnClick property is false (TFS 29028).

- Minor internal changes for better compatibility with VS2012.

==================================================================
C1InputPanel Build 2/4.0.20123.151                October 12, 2012
==================================================================

- Fixed an issue: a few strings are not localized for Chinese
  and Korean in the Item Collection Editor (TFS 28991).

==================================================================
C1InputPanel Build 2/4.0.20123.150                October 11, 2012
==================================================================

- Added the Chinese and Korean localization strings.

==================================================================
C1InputPanel Build 2/4.0.20122.149                 August 27, 2012
==================================================================

- Updated the toolbox icon for VS2012 (TFS 27343).

==================================================================
C1InputPanel Build 2/4.0.20122.148                 August 23, 2012
==================================================================

- Fixed an issue: entered values hide in InputDatePicker and
  InputTimePicker fields when adding a new data row, typing the
  date and time values with the keyboard, and applying changes
  using the InputDataNavigator element (TFS 27045).

==================================================================
C1InputPanel Build 2/4.0.20122.147                 August 15, 2012
==================================================================

- Added VS2012 toolbox icon.

==================================================================
C1InputPanel Build 2/4.0.20122.145                   July 10, 2012
==================================================================

- Fixed an issue in a multiline InputTextBox: if the AcceptsReturn
  property is set to False, pressing the Enter key cleared the
  contents of the InputTextBox and added a line break. The correct
  behavior is the following: pressing the Enter key commits last
  changes and selects the whole contents of the InputTextBox;
  pressing Ctrl+Enter adds a line break.

==================================================================
C1InputPanel Build 2/4.0.20121.142                  April 25, 2012
==================================================================

- Fixed a bug: when an empty array is assigned to the DataSource
  property of InputComboBox the previously assigned list of items
  is not cleared and still appears in the drop-down (TFS 21341).

==================================================================
C1InputPanel Build 2/4.0.20121.141                   April 6, 2012
==================================================================

- Fixed a bug: the original data value is not stored to the data
  source after an attempt to store incorrect data and cancelling
  changes using the Esc key in InputTextBox (TFS 21124).

==================================================================
C1InputPanel Build 2/4.0.20121.140               February 17, 2012
==================================================================

- Fixed a bug: InputDataNavigator doesn't restore its default
  size when "Reset Images" is clicked although default images
  are restored (TFS 20013).

==================================================================
C1InputPanel Build 2/4.0.20121.139               February 13, 2012
==================================================================

- Fixed a bug: when the 'Reset Images' link is clicked, all the
  images in InputDataNavigator become corrupted (TFS 19909).

==================================================================
C1InputPanel Build 2/4.0.20121.138                January 17, 2012
==================================================================

- Added support for transparent or semi-transparent colors in
  the BackColor property of C1InputPanel.

==================================================================
C1InputPanel Build 2/4.0.20113.136               December 22, 2011
==================================================================

- Added the BoundToTimeField property to the InputTimePicker
  component:

  public bool BoundToTimeField { get; set; }

  Setting the value of this property to True (default value is
  False) specifies that the BoundValue property should return
  a TimeSpan value instead of DateTime. It is necessary to set
  the BoundToTimeField property to True when binding the
  InputTimePicker to a 'time' column of SQLServer table. It
  should otherwise be set to False (see TFS 18978).

==================================================================
C1InputPanel Build 2/4.0.20113.135               November 30, 2011
==================================================================

- Updated licensing to conform with Federal Information Processing
  Standards requirements (TFS 18562).

==================================================================
C1InputPanel Build 2/4.0.20113.132               September 8, 2011
==================================================================

- Fixed a minor issue in InputTextBox: the contents did not
  scroll to the first row when the input focus leaves a multiline
  InputTextBox (related to TFS 17126).

==================================================================
C1InputPanel Build 2/4.0.20112.130                   July 28, 2011
==================================================================

- Fixed a bug: the ContextMenuShowing event of InputMaskedTextBox
  is not fired although context menu is displayed (TFS 16452).

==================================================================
C1InputPanel Build 2/4.0.20112.129                   July 25, 2011
==================================================================

- Fixed an issue in the InputControlHost component: the hosted
  control's Click and DoubleClick event handlers executed the
  ReleaseCapture method from Win32 API. It was incompatible with
  some controls, such as the standard ComboBox control.

==================================================================
C1InputPanel Build 2/4.0.20112.128                   June 13, 2011
==================================================================

- Fixed a bug: InputComboBox, InputMenu and other like elements
  can't be "dropped-down" if the input panel control is embedded
  into an unmanaged VB6 form using Microsoft InterOp-Toolkit.

- Fixed an issue: inconsistent license key is observed sometimes
  in the Deactivate License Dialog (TFS 15701).

==================================================================
C1InputPanel Build 2/4.0.20112.127                    June 8, 2011
==================================================================

- Added a bunch of ShowToolTip() methods to C1InputPanel:

  public void ShowToolTip(string text, Control control, Point pt)
  public void ShowToolTip(string text, Control control, Point pt, int duration)
  public void ShowToolTip(string text, Control control, int x, int y)
  public void ShowToolTip(string text, Control control, int x, int y, int duration)

  public void ShowToolTip(InputComponent inputComponent, Point pt)
  public void ShowToolTip(InputComponent inputComponent, Point pt, int duration)
  public void ShowToolTip(InputComponent inputComponent, int x, int y)
  public void ShowToolTip(InputComponent inputComponent, int x, int y, int duration)

  The methods show the rich tooltip for a given Control or
  InputComponent at the specified location for a specified amount
  of time. Also, added the HideToolTip() method to C1InputPanel:
  
  public void HideToolTip()

- Added the ScrollIntoView() method to C1InputPanel. The method
  scrolls the specified InputComponent into view:
  
  public void ScrollIntoView(InputComponent inputComponent)

- The GetItemRectangle() method of C1InputPanel is renamed to
  GetItemBounds(). The previous version of this method is still
  available at runtime for backward compatibility. Also, added
  an overloaded version of the GetItemBounds() method:
  
  public Rectangle GetItemBounds(InputComponent inputComponent,
      InputElementType elementType)

  Here the elementType parameter sets the type of the specific
  element in the input component whose bounds are calculated.
  It may be set to one of the following values: WholeComponent,
  ContentElement, ToolTippedElement.

- Removed dummy comments from the XML documentation file.

==================================================================
C1InputPanel Build 2/4.0.20112.126                    May 26, 2011
==================================================================

- Fixed an issue: pressing the Delete key in C1InputPanel Item
  Collection Editor has no effect (TFS 15482).

==================================================================
C1InputPanel Build 2/4.0.20112.125                    May 20, 2011
==================================================================

- Fixed an issue in C1InputPanel: a NullReferenceException was
  thrown when trying to close the owner Form in the Click event
  of an InputButton if this button is located in a menu or split
  button's drop-down list.

==================================================================
C1InputPanel Build 2/4.0.20112.124                     May 9, 2011
==================================================================

- Fixed issue 15253 (C1InputPanel’s tooltip does not show after
  the mouse hovers the panel's input components).

==================================================================
C1InputPanel Build 2/4.0.20112.123                     May 5, 2011
==================================================================

- Fixed issue 15209 (Multiple issues observed in InputNumericBox
  after entering "1e+60" or "1e-80").

==================================================================
C1InputPanel Build 2/4.0.20111.121                  April 27, 2011
==================================================================

- Fixed issue 15091 ("1.123456789e-5" or "1.123456789e5" values
  are not formatted in an InputNumericBox although the "Format"
  property is set to "G5").

==================================================================
C1InputPanel Build 2/4.0.20111.120                  April 22, 2011
==================================================================

- Fixed issue 15030 (The value outside the bounds can be passed
  to a data source without any validation when the Tab key is
  pressed in InputNumericBox).

- Fixed issue 15032 (Overflow Exception is thrown after typing
  '1e+60' into an InputNumericBox).

- Fixed issue 15041 (Multiple issues were observed with the
  Format property of InputNumericBox).

==================================================================
C1InputPanel Build 2/4.0.20111.119                  April 11, 2011
==================================================================

- Fixed issue 14971 (Tooltip does not appear for an InputImage).
  The same problem occured in an InputLabel when its Padding is
  set to a positive value.

- Fixed a bug in an InputProgressBar: the Click event did not
  fire sometimes.

==================================================================
C1InputPanel Build 2/4.0.20111.118                   April 9, 2011
==================================================================

- Fixed issue 14958 (IndexOutOfRangeException is thrown after
  typing more than 29 digits into an InputNumericBox).

==================================================================
C1InputPanel Build 2/4.0.20111.117                  March 23, 2011
==================================================================

- Fixed a potential issue that may occur on a machine with
  multiple installed versions of C1InputPanel for .NET 4.x and
  its designer dll (C1.Win.C1InputPanel.4.Design.dll).

==================================================================
C1InputPanel Build 2/4.0.20111.116               February 21, 2011
==================================================================

- Added the Active property to the ToolTipSettings class. The
  property indicates whether the tooltip is currently active.

- Changed the default value for the ToolTipSettings.BorderColor
  property from SystemColors.InfoText to Color.Gray.

==================================================================
C1InputPanel Build 2/4.0.20111.115               February 19, 2011
==================================================================

- Fixed issue 14481 (Focus remains in the InputNumericBox forever
  after the component is bound to a data source, the Minimum and
  Maximum properties are set, and the current value is outside
  of the allowable range).

==================================================================
C1InputPanel Build 2/4.0.20111.114                February 2, 2011
==================================================================

- Added a few visual styles to C1InputPanel:
  Office2010Black, Office2010Blue, Office2010Silver, Windows7.

==================================================================
C1InputPanel Build 2/4.0.20111.113                January 21, 2011
==================================================================

- Fixed issue 14242 (KeyDown, KeyUp, and KeyPress events don't
  fire on an InputComboBox when its "DropDownStyle" property is
  set to "DropDownList").

==================================================================
C1InputPanel Build 2/4.0.20111.112                January 19, 2011
==================================================================

- Added the FocusedComponent property to C1InputPanel:

  public InputComponent FocusedComponent { get; }
  
  The property returns the component which has input focus.
  
- Added the Focused property to the InputComponent class:

  public virtual bool Focused { get; }
  
  The property indicates whether the component has input focus.  

==================================================================
C1InputPanel Build 2/4.0.20111.111                January 19, 2011
==================================================================

- Added one more button to the InputDataNavigator component.
  When clicked, the new 'Edit' button fires the Editing event:
  
  public event InputNavigatorEditingEventHandler Editing;
  
  The image associated with the new button can be assigned
  using the EditImage property:
  
  public Image EditImage { get; set; }
  
  The EditToolTip property sets the tooltip text associated
  with the 'Edit' button:
  
  public string EditToolTip { get; set; }
  
  The new ShowEditButton property (false by default) specifies
  whether the new button should appear on InputDataNavigator:
  
  public bool ShowEditButton { get; set; }

- Updated a few XML comments and property descriptions.

==================================================================
C1InputPanel Build 2/4.0.20111.110               December 31, 2010
==================================================================

- Updated editor for the ToolTipText and ErrorText properties.

==================================================================
C1InputPanel Build 2/4.0.20103.108              September 30, 2010
==================================================================

- Fixed issue 12940 (Cannot click link from ToolTip when
  HitTestVisible property is set to True).

- Added the ToolTipLinkClicked event to the C1InputPanel control.
  It fires when the user clicks a hyperlink within a tooltip.

- Added the ToolTipLinkClickedEventArgs class that provides data
  for the C1InputPanel.ToolTipLinkClicked event.

==================================================================
C1InputPanel Build 2/4.0.20103.107              September 25, 2010
==================================================================

- Fixed a minor issue in description of the Width and Height
  properties of the InputSeparator component.

==================================================================
C1InputPanel Build 2/4.0.20103.106              September 17, 2010
==================================================================

- Added the HitTestVisible property to the ToolTipSettings class.
  If it is set to True the tooltip becomes visible to the mouse
  and handles the mouse events itself instead of passing them to
  the control under the tooltip.

==================================================================
C1InputPanel Build 2/4.0.20102.104                 August 11, 2010
==================================================================

- Fixed an issue: the Validating and Validated events fired twice
  for the following input components: InputTextBox, InputComboBox,
  InputMaskedTextBox, InputDatePicker, InputTimePicker,
  InputNumericBox.

==================================================================
C1InputPanel Build 2/4.0.20102.102                   June 18, 2010
==================================================================

- The position, size, and settings of the Items Collection Editor
  are now saved and restored when the user opens the collection
  editor next time.

==================================================================
C1InputPanel Build 2/4.0.20102.101                   June 16, 2010
==================================================================

- Fixed issue 11202 (Data is not shown in InputControlHost
  containing C1Combo/C1TrueDBGrid).

- Fixed issue 11216 (C1InputPanel container is not shown in
  inherited Form when it is declared with Public modifier in
  base Form).

==================================================================
C1InputPanel Build 2/4.0.20102.100                   June 11, 2010
==================================================================

- Fixed issue 11179 (Images are not shown when the ImageList
  property of C1InputPanel is set at runtime).

==================================================================
C1InputPanel Build 2/4.0.20102.99                     June 9, 2010
==================================================================

- Added the ShowSpinButtons boolean property (True by default)
  to InputNumericBox and InputTimePicker. The property allows
  to hide spin buttons in the input components.

==================================================================
C1InputPanel Build 2/4.0.20102.98                     May 30, 2010
==================================================================

- Added the ImageList property to C1InputPanel:
  
  public ImageList ImageList { get; set; }
  
  This property allows to use an ImageList as the source of
  images to display on the next input components: InputButton,
  InputMenu, InputSplitButton, InputGroupHeader.

- Added the ImageIndex and ImageKey properties to InputButton,
  InputMenu, InputSplitButton, and InputGroupHeader:
  
  public int ImageIndex { get; set; }
  public string ImageKey { get; set; }
  
  The ImageIndex property specifies the index of an image in
  the owner panel's ImageList. The ImageKey property provides
  the image key (as a string).

- Fixed a bug: the ToolTipSettings.Opacity property did not
  affect items in dropped down menus and combo boxes.

==================================================================
C1InputPanel Build 2/4.0.20102.97                     May 14, 2010
==================================================================

- Minor changes to the ToolTip editor.

==================================================================
C1InputPanel Build 2/4.0.20102.96                      May 2, 2010
==================================================================

- Added the Opacity property to the ToolTipSettings class:

  public double Opacity { get; set; }

  The property gets or sets the opacity of the tooltips between
  zero (totally transparent) and one (totally opaque).

==================================================================
C1InputPanel Build 2/4.0.20101.94                   April 30, 2010
==================================================================

- InputComponent.ErrorText property uses the same UITypeEditor
  as the ToolTipText property. It allows to edit HTML code.

==================================================================
C1InputPanel Build 2/4.0.20101.93                   April 29, 2010
==================================================================

- Fixed an issue: the whole text is cleared when pressing the
  'delete' key in InputComboBox if a message box pops up from
  the InputComboBox.SelectedIndexChanged event handler.

- Fixed an issue: current time is not shown when a user sets
  the ValueIsNull property to False for InputTimePicker.

==================================================================
C1InputPanel Build 2/4.0.20101.91                   April 15, 2010
==================================================================

- Fixed issue 10229 (Text of InputLabel gets hidden when user
  adds InputGroupHeader below InputLabel).

==================================================================
C1InputPanel Build 2/4.0.20101.90                    April 9, 2010
==================================================================

- C1InputPanel control designer has been moved to a separate dll
  in the version for .NET 4.0.

==================================================================
C1InputPanel Build 2.0.20101.88                      March 4, 2010
==================================================================

- Added the HotkeyPrefix property to the InputGroupHeader
  component. It allows to specify the type of display for hot-key
  prefixes in the group header text.

==================================================================
C1InputPanel Build 2.0.20101.87                      March 1, 2010
==================================================================

- Fixed an issue that was introduced in build 84: InputComboBox
  binds sometimes to a wrong datasource.

==================================================================
C1InputPanel Build 2.0.20101.85                  February 25, 2010
==================================================================

- Added the HotkeyPrefix property to the InputLabel component.
  It allows to specify the type of display for hot-key prefixes
  in the label text.

==================================================================
C1InputPanel Build 2.0.20101.84                  February 22, 2010
==================================================================

- Fixed issue 9160 (InputComboBox can't bind to a string array).

==================================================================
C1InputPanel Build 2.0.20101.83                  February 19, 2010
==================================================================

- Fixed issue 8999 (Up/Down buttons of InputNumericBox &
  InputTimePicker render incorrectly when DPI settings are set
  to 120). Also, fixed a few problems in C1InputPanel designer
  when working in 120 DPI mode.

==================================================================
C1InputPanel Build 2.0.20093.81                  December 30, 2009
==================================================================

- Minor internal changes.

==================================================================
C1InputPanel Build 2.0.20093.79                  November 19, 2009
==================================================================

- Fixed an issue: inconsistent behavior of popup windows observed
  in C1InputPanel after the InputComboBox.DroppedDown property is
  set to True in the InputComboBox.ChangeCommitted event handler.

==================================================================
C1InputPanel Build 2.0.20093.78                   November 8, 2009
==================================================================

- The InputComboBox.SelectedValue property now returns 'null'
  ('Nothing' in VB) instead of 'DBNull' if the component works
  in unbound mode.

==================================================================
C1InputPanel Build 2.0.20093.77                   October 15, 2009
==================================================================

- Fixed an issue in InputDatePicker and InputTimePicker: the
  selected value cannot be cleared sometimes.

- The VisibleChanged event fired many times for the C1InputPanel
  control before showing the form.

- Fixed an issue: Date shown inside InputDatePicker is not same
  date shown in DatePicker’s calendar if year is over 3000.
  
- Fixed an issue: InputNumericBox’s ValueChanged event fires
  again automatically when a messagebox is poped up in the event
  handler.
  
- The ControlAdded and ControlRemoved events have been hidden
  in the C1InputPanel control.

==================================================================
C1InputPanel Build 2.0.20093.75                 September 25, 2009
==================================================================

- Fixed an issue in InputNumericBox: It was impossible to change
  the value of InputNumericBox.ValueIsNull property from True to
  False in the property grid.

==================================================================
C1InputPanel Build 2.0.20093.74                 September 18, 2009
==================================================================

- Fixed a bug in InputDatePicker: Today date was not shown in
  editable portion of a RibbonDatePicker on clicking the 'Today'
  button when the ValueIsNull property is True.

==================================================================
C1InputPanel Build 2.0.20093.73                 September 17, 2009
==================================================================

- Fixed an issue: Unlike MS-NumericUpDown and InputTrackBar,
  exception is not thrown on setting invalid value to
  InputNumericBox.Value property.

- Fixed a bug: Clicking Today button in InputDatePicker navigate
  the calendar to current month only at the first time.

==================================================================
C1InputPanel Build 2.0.20093.72                 September 12, 2009
==================================================================

- Fixed issue 6394 (InputComboBox does not update the last value
  when bound to a datasource and all the records of datasource
  have been deleted).

- Fixed a bug: If an InputComboBox is bound to a datasource and
  the UpdateListPosition property is False, the user was unable
  to click an item in the drop-down list after deleting a row
  from the datasource.

==================================================================
C1InputPanel Build 2.0.20093.70                 September 11, 2009
==================================================================

- Fixed issue 6380 (The value of the SelectedItem property is
  always null (Nothing in VB) for an unbound InputComboBox).
  Now the SelectedItem works as a duplicate for SelectedOption
  when the InputComboBox is unbound.

- A few minor bug fixes in InputDatePicker, InputTimePicker.

==================================================================
C1InputPanel Build 2.0.20093.69                    August 17, 2009
==================================================================

- Fixed an issue: the input panel did not auto add the necessary
  components for nullable data types, i.e. 'int?', 'DateTime?'.
  Such data types are widely used in ADO.NET Entity Framework.

==================================================================
C1InputPanel Build 2.0.20093.68                    August 16, 2009
==================================================================

- Added the following new properties to InputGroupHeader: Image,
  ImageSize, ImageAlign, ImageScaling. They allow to display an
  image on the group header. These properties are analogous to
  the same properties of the InputButton component.

- Added the SelectedItem runtime-only property to InputComboBox.
  The property gets or sets the data item selected in the bound
  combobox. It allows to bind an InputComboBox to ADO.NET Entity
  Framework Navigation Property.

- Fixed an issue: InputComboBox did not scroll its dropdown list
  to the highlighted item when the dropdown appears for the first
  time and the highlighted item is out of the visible scope.

==================================================================
C1InputPanel Build 2.0.20092.67                    August 14, 2009
==================================================================

- Fixed issue 5846 (InputComponent is clipped or its Y position
  is wrong when the components before it are collapsed such that
  its X and Y both positions are changed).

==================================================================
C1InputPanel Build 2.0.20092.66                    August 10, 2009
==================================================================

- Fixed a bug: if the clicked InputButton component closes the
  owner Form this might produce the ObjectDisposedException.

==================================================================
C1InputPanel Build 2.0.20092.65                      June 29, 2009
==================================================================

- Text was always left-aligned in a not editable InputComboBox
  (i.e. with DropDownStyle equal to DropDownList) regardless of
  the TextAlign property value.

==================================================================
C1InputPanel Build 2.0.20091.62                     April 23, 2009
==================================================================

- Fixed a bug in the InputTimePicker/InputDatePicker components.
  There was a problem with typing a number into the last field,
  such as 'minute' or 'second', using keyboard.

==================================================================
C1InputPanel Build 2.0.20091.61                     April 20, 2009
==================================================================

- Fixed a bug in the InputCheckBox: the CheckState property of
  a bound checkbox did not update its value from 'Indeterminate'
  to 'Unchecked' when the current row changes.

- An IndexOutOfRangeException occured in the DataGridView control
  that follows the input panel in tab order if both controls
  (C1InputPanel and DataGridView) are bound to the same data
  source and the user refreshes data using the Reload button on
  the InputDataNavigator.

==================================================================
C1InputPanel Build 2.0.20091.60                     April 16, 2009
==================================================================

- Tooltips now use the owner input panel font as the default font.

==================================================================
C1InputPanel Build 2.0.20091.59                     April 15, 2009
==================================================================

- Added the AutoCompleteMode property to InputComboBox. This
  property gets or sets an option that controls how automatic
  completion works for InputComboBox. Possible values:

  [None]
  Disables the automatic completion feature.
  
  [Suggest]
  Displays the auxiliary drop-down list associated with the edit
  control. This drop-down is populated with one or more suggested
  completion strings.
  
  [Append] - default option
  Appends the remainder of the most likely candidate string to
  the existing characters, highlighting the appended characters.

  The automatic completion feature works if the DropDownStyle
  property is equal to 'InputComboBoxStyle.DropDown'.

- InputComboBox did not restore the previously selected option
  when the user presses the Escape key to close the dropdown list.

- Fixed a minor issue in XML persistence code of InputProgressBar
  and InputTrackBar.

==================================================================
C1InputPanel Build 2.0.20091.58                      April 3, 2009
==================================================================

- If the validation failed for an InputComponent, it was still
  possible to click other buttons, display menus, and combobox
  lists, change numeric and time values using spin buttons.

- The IndexOutOfRangeException occured sometimes in the
  InputComboBox component (e.g. take a look at the Output window
  of the DataBinding sample running in debug mode).

- It was not possible to reset the selected value in a bound
  InputComboBox to DBNull. Now the user can clear the contents
  of the combobox to reset the underlying data field to DBNull.

- If the user types something that is out of the allowable range
  into the InputNumericBox, the new value was lost without any
  notifications when the user moves the focus to another control.

- The original value was not restored in the InputComboBox when
  the user presses the Esc key if the previous attempt to leave
  the combobox was unsuccessful due to validation.

- Added the WrongPositionErrorText property to InputDataNavigator.
  It allows to change the error message that appears as tooltip
  when the position text contains incorrect value.

- Added the MismatchValueErrorText property to InputComboBox.
  This property sets the error message that appears as tooltip
  if the typed text doesn't match any row in the lookup table.

==================================================================
C1InputPanel Build 2.0.20091.57                  February 16, 2009
==================================================================

- Fixed issue 19203 (BackColor of GroupHeader is not applied when
  changed at designtime\runtime).

- Fixed issue 19211 (Navigation buttons on an InputDataNavigator
  remain disabled when data is added to empty collection to which
  the InputPanel is bound).

- Fixed issue 19224 (Setting the C1InputPanel.ReadOnly property
  to False doesn't affect components that will be added later).

==================================================================
C1InputPanel Build 2.0.20091.56                   January 21, 2009
==================================================================

- Added the BackColor property to the InputGroupHeader component.
  If the value of this property is not equal to Color.Transparent
  (default value) the specified color fills the background of the
  group header.
  
- Added the BackColorChanged event to the InputGroupHeader. This
  event is fired when the value of the BackColor property changes.

- When saving the input panel definition into an XML file all
  colors are now stored as hexadecimal values to facilitate manual
  editing of the XML file.

==================================================================
C1InputPanel Build 2.0.20083.55                   January 13, 2009
==================================================================

- The following properties of the base ScrollableControl class
  have been hidden in the C1InputPanel: ScrollBars, ScrollSize,
  ScrollTrack.

- The Active property has been hidden in the ToolTipSettings.

- The C1InputPanel.ScrollPosition property always returned {0,0}
  in previous builds. Now it returns negative or zero pixel
  offset of the left upper corner of the scrollable area.

- Added the read-only ScrollLimits property to C1InputPanel.
  It is equal to the value of the ScrollPosition property when
  the right bottom corner of the scrollable area is visible.

- Added the ForceScrollBars boolean property to C1InputPanel.
  If it's True, the scrollbars remain visible even if they are
  not needed.

- Added the GetItemRectangle() method to C1InputPanel that
  returns the size and location of the given input component
  in pixels relative to the parent C1InputPanel control.
  
==================================================================
C1InputPanel Build 2.0.20083.54                  December 23, 2008
==================================================================

- Fixed issue 18743 (Dropdown panes are clipped in C1InputPanel
  when the form is shifted to the extreme left of the monitor).

==================================================================
C1InputPanel Build 2.0.20083.53                  December 16, 2008
==================================================================

- Fixed issue 18714 (exception is observed on running the
  application when C1InputPanel is placed in C1DockingTabPage
  in MDI child form).

==================================================================
C1InputPanel Build 2.0.20083.52                  November 23, 2008
==================================================================

- The input components appear now in 'hot' state when the mouse
  hovers them while the host application is inactive.

- Fixed several small issues that occured when the user switches
  to/from another application.
  
- Added the ReadOnly property to C1InputPanel. If this property
  is True the panel operates in the read-only mode when the user
  can't change any data in the input components.

==================================================================
C1InputPanel Build 2.0.20083.51                  November 19, 2008
==================================================================

- Tooltips for dropped down elements did not acquire properties
  from the panel's ToolTipSettings.

==================================================================
C1InputPanel Build 2.0.20083.50                   November 3, 2008
==================================================================

- Fixed a bug: If the C1InputPanel is placed on a tab page the
  designer appeared for individual input components even when
  the other tab page is currently selected.

==================================================================
C1InputPanel Build 2.0.20083.49                   October 25, 2008
==================================================================

- The C1InputPanel did not inherit the VisualStyle of the owner
  C1RibbonForm when the form shows up if this input panel is
  placed on a GroupBox or Panel, not on the form directly.

==================================================================
C1InputPanel Build 2.0.20083.48                   October 23, 2008
==================================================================

- A not empty BackgroundImage appears now in the Preview pane
  of the ToolTip property editor regardless of the current
  VisualStyle that is used for this input panel. In previous
  builds it was only shown for the System visual style.

==================================================================
C1InputPanel Build 2.0.20083.47                   October 21, 2008
==================================================================

- Fixed issue in the ToolTipText property editor: Ctrl+Z did not
  work on text added through the toolbar or shortcut. This is
  the same issue as #18431 for C1Ribbon.

==================================================================
C1InputPanel Build 2.0.20083.46                   October 21, 2008
==================================================================

- Fixed an issue in the ToolTipText property editor:

  When a user selects '(Add image...)' from the dropdown list
  for the Image or Subimage combos in the Office tab page the
  "Open" window appears. If the user clicks the Cancel button
  in this window an internal exception occured and the whole
  property editor was closed with losing recent changes.

==================================================================
C1InputPanel Build 2.0.20083.45                   October 18, 2008
==================================================================

- Fixed issue 18423 (InputTextBox and InputMaskedTextBox can not
  bind to columns of type integer/double).

==================================================================
C1InputPanel Build 2.0.20083.44                   October 16, 2008
==================================================================

- Fixed issue 18413 (in 'master-detail' scenario where the
  InputDataNavigator is bound to child records the navigation
  buttons stay disabled/enabled incorrectly (sometimes) when
  master rows are navigated).

==================================================================
C1InputPanel Build 2.0.20083.43                   October 16, 2008
==================================================================

- Added the BeforeButtonClick event to the InputDataNavigator.
  It occurs when a navigator button is clicked, before its
  built-in processing. The user can skip the standard action
  by setting e.Handled = true in the event handler.
  
- Added the Handled property to the InputNavigatorClickEventArgs
  class:
  
  public bool Handled { get; set; }
  
  This allows to set whether the built-in processing of the
  navigator button click should be omitted. It is used for the
  InputDataNavigator.BeforeButtonClick event only.

- Added the SpinButtonClick event to the InputNumericBox and
  InputTimePicker components. It occurs when the up/down buttons
  are clicked, before their built-in processing. The user can
  skip the standard action by setting e.Handled = true in the
  event handler.

- Added the SpinButtonClickEventArgs class that provides data
  for the above mentioned SpinButtonClick event.

- Added the UpButton() and DownButton() public methods to the
  InputNumericBox and InputTimePicker components:
  
  public void UpButton();
  public void DownButton();
  
  They simulate a click of the corresponding spin button.

==================================================================
C1InputPanel Build 2.0.20083.42                    October 9, 2008
==================================================================

- The List<item> is now partly supported in the DataSource
  property of the InputDataNavigator. The navigator was disabled
  in the previous versions after the user assigns a List<item>
  to the DataSource property.

- The InputButton.PerformClick(), InputSplitButton.PerformClick(),
  and InputDataNavigator.ClickButton() methods generate a button
  click if only this component is visible and enabled. Also, the
  InputDropDown.DroppedDown property can be set to True if only
  this InputDropDown is visible and enabled.

==================================================================
C1InputPanel Build 2.0.20083.41                    October 6, 2008
==================================================================

- Fixed TTP issue 12517 (editing options in the Context menu
  gets disabled when all controls on the form including the
  C1InputPanel controls are selected using 'Ctrl + A').

==================================================================
C1InputPanel Build 2.0.20083.40                    October 5, 2008
==================================================================

- Fixed issue 17099 by adding the DialogResult property to the
  InputButton component:
  
  public DialogResult DialogResult { get; set; }

  This property specifies the dialog-box result produced in a
  modal form by clicking the button.

- Fixed issue 18237 by adding a new method to the C1InputPanel:

  public InputComponent GetItemAt(Point point)

  This method returns the InputComponent that is located at the
  specified client point of the C1InputPanel control.

- Added the PerformClick() method to the InputSplitButton and
  InputButton components. This method generates a Click event.

- Added the ContextMenuShowing event to the InputComponent class.
  This allows to display either the ContextMenuStrip or the
  ContextMenu from the event handler. For example:
  
  VB:

  Private Sub InputMenu1_ContextMenuShowing(ByVal sender As _
    System.Object, ByVal e As ContextMenuShowingEventArgs) _
    Handles InputMenu1.ContextMenuShowing
  
      ContextMenuStrip1.Show(e.X, e.Y)
      e.Handled = True
    
  End Sub

  Private Sub InputNumericBox1_ContextMenuShowing(ByVal sender _
    As System.Object, ByVal e As ContextMenuShowingEventArgs) _
    Handles InputNumericBox1.ContextMenuShowing
  
      Dim p As Point = C1InputPanel1.PointToClient(e.Location)
      ContextMenu1.Show(C1InputPanel1, p)
      e.Handled = True
    
  End Sub

  C#:

  private void inputMenu1_ContextMenuShowing(object sender,
      ContextMenuShowingEventArgs e)
  {
      contextMenuStrip1.Show(e.X, e.Y);
      e.Handled = true;
  }
  private void inputNumericBox1_ContextMenuShowing(object sender,
      ContextMenuShowingEventArgs e)
  {
      Point p = c1InputPanel1.PointToClient(e.Location);
      contextMenu1.Show(c1InputPanel1, p);
      e.Handled = true;
  }

==================================================================
C1InputPanel Build 2.0.20083.39                    October 1, 2008
==================================================================

- Fixed an issue in the collection editor. When the user adds
  new items to a submenu, then adds a new item to the parent
  menu, the collection editor may close unexpectedly.
  
- Fixed minor issues in behavior of several input components.

==================================================================
C1InputPanel Build 2.0.20083.38                 September 29, 2008
==================================================================

- Fixed several small issues in the InputComboBox that is bound
  to a data source.

- Added a new property to the InputComboBox component:

  public bool UpdateListPosition { get; set; }
  
  This property (True by default) indicates whether the Position
  property of the underlying CurrencyManager should be updated
  when the InputComboBox.SelectedIndex property changes.

==================================================================
C1InputPanel Build 2.0.20082.37                 September 19, 2008
==================================================================

- Removed the ToolTipSettings.BackgroundGradient property.
  It was ambiguous. Actually, the tooltip background gradient
  depends on the current visual style.

- The ToolTipBackgroundImageLayout enumeration renamed to
  InputImageLayout.

- Focus rectangle is now drawn around the following input
  components when they have the input focus: InputButton,
  InputCheckBox, InputComboBox, InputMenu, InputRadioButton,
  InputSplitButton, InputTrackBar.

- The default value of the Padding property changed from
  (0, 0, 0, 0) to (2, 2, 2, 2) for the next input components:
  InputCheckBox, InputRadioButton, InputTrackBar.

==================================================================
C1InputPanel Build 2.0.20082.36                 September 17, 2008
==================================================================

- Added a new full-fledged designer (UITypeEditor) for the
  InputComponent.ToolTipText property.

- Added the ToolTipSettings property to C1InputPanel. It allows
  to adjust various settings of the built-in rich tooltip.

- The progress width on the InputProgressBar component was
  incorrect for small values.

- Fixed an issue: HScrollBar and VScrollBar did not scroll
  properly when hosted in an InputControlHost.

- Added the SetToolTip() and GetToolTip() methods to C1InputPanel:

  public void SetToolTip(Control control, string text)
  public string GetToolTip(Control control)
  
  These allow to use the C1InputPanel built-in rich tooltip
  instead of the regular ToolTip component in order to provide
  a consistent look between the tooltips associated with input
  panel components and other controls on the same form.

==================================================================
C1InputPanel Build 2.0.20082.35                  September 5, 2008
==================================================================

- Added the DataSource and DataField properties to the
  InputComponent:

  public virtual object DataSource { get; set; }
  public virtual string DataField { get; set; }

  These properties make it easy to bind the BoundValue property
  to a data source.

- Added the DisableOnNoData property to the InputComponent:

  public virtual bool DisableOnNoData { get; set; }

  This boolean property (True by default) specifies whether
  the component should be disabled when it is bound to an
  empty data source, i.e. when CurrencyManager.Count = 0.

- Added the SetDataBinding() method to C1InputPanel:

  public void SetDataBinding(object dataSource, string dataMember, bool populate)

  It allows to update both DataSource and DataMember properties
  at run time, and populate C1InputPanel with bound input
  components.

- Fixed issue 17823 (License Nag Screen is shown with UserControl
  created using licensed C1InputPanel).

- Fixed issue 17896 (Controls are not added to C1InputPanel when
  bound to list collection at runtime).

- Fixed issue 17905 (When LINQ objects are assigned to
  C1InputPanel as DataSource, the panel does not populate).

- Fixed issue 17910 (InputDataNavigator not created when
  C1InputPanel is bound to a DataTable at runtime).

==================================================================
C1InputPanel Build 2.0.20082.34                    August 12, 2008
==================================================================

- Added the 'Save Data' and 'Reload Data' buttons to the
  InputDataNavigator. The ShowSaveButton and ShowReloadButton
  boolean properties can make them visible (if their value is
  True). These buttons fire the new SaveData and ReloadData
  events correspondingly. The SaveToolTip and ReloadToolTip
  set the ToolTip associated with the new buttons. SaveImage
  and ReloadImage set the corresponding button images.

- Added the TextAlign property to the InputDataNavigator.
  This property sets how text is aligned in the position box.

- Added the ClickButton() method to the InputDataNavigator.
  It allows to click any navigator button programmatically.

- Added the ConfirmDelete event to the InputDataNavigator.
  It is now possible, for example, to display a message box
  from this event handler and ask the user whether or not
  she wants to delete a row.

- Added the Error event to the InputDataNavigator. It is
  fired when an exception is thrown performing an action on
  button click. The user can intercept this exception setting
  (e.Handled = True) in the event handler.

- Validating and Validated events were not fired for the
  focused component bound to a data source when a user
  navigates to the other row using the InputDataNavigator.
  Also, these events fired incorrectly when a user clicks
  the InputTextBox or other like component with the mouse.

- Added the ImageAlign property to the InputImage. It allows
  to specify how the image is aligned within the component.
  
- Fixed TTP issue 17098: added new properties: ImageSize,
  ImageAlign, ImageScaling to the InputButton, InputMenu,
  InputSplitButton, and InputDataNavigator. They help to
  scale the inner image to the desired size, then align it.
  
- The InputComponent.HorizontalAlignment property has been
  replaced with the 'HorizontalAlign'. The VerticalAlignment
  property has been replaced with the 'VerticalAlign'. Both
  new properties are of the InputContentAlignment data type
  while the old properties were of the ContentAlignment type.
  It was done to avoid conflicts with the standard type:
  System.Drawing.ContentAlignment.

- Added designer verbs that allow to reset button images of
  the InputDataNavigator to the predefined images and reset
  button tooltips to the original strings.

- Added the Step property to the InputProgressBar. Also,
  added the PerformStep() and Increment() methods. The new
  property and methods work similarly to the same members
  of the standard ProgressBar control.

==================================================================
C1InputPanel Build 2.0.20082.33                     August 3, 2008
==================================================================

- Fixed TTP issue 12466: gif images can now be shown as
  animations instead of static images.

- The InputImage.SizeMode property has been replaced with
  the ImageScaling property of the InputImageScaling type.
  It supports more options for scaling the image. The old
  property has been marked with the Obsolete attribute.

- Added the ImageChanged and ImageScalingChanged events
  to the InputImage component. These events fire when
  the Image and ImageScaling properties are modified.

- Added designer verbs: 'Choose Image' to the InputImage,
  'Rotate 90°' to the InputSeparator, 'Reset Size' to
  all input components except the InputOption.

- It is now possible to assign multiline text to the Text
  property of the following components: InputButton,
  InputCheckBox, InputLabel, InputMenu, InputRadioButton,
  InputSplitButton at design time.

==================================================================
C1InputPanel Build 2.0.20082.32                     August 1, 2008
==================================================================

- Added the AutoEllipsis property (True by default) to the
  next components: InputButton, InputCheckBox, InputComboBox,
  InputLabel, InputMenu, InputRadioButton, InputSplitButton.
  It works like the same property of the standard Label.

- Tooltips appeared incorrectly for several input components,
  such as InputCheckBox, InputRadioButton, InputProgressBar,
  InputTrackBar.

- Fixed multiple small issues with processing keyboard/mouse
  events in the input components.
  
==================================================================
C1InputPanel Build 2.0.20082.31                      July 29, 2008
==================================================================

- Added a possibility to export/import XML layout for the
  input panel at design time. Also, added the Load() and Save()
  methods to the C1InputPanel class that allow to import and
  export XML at runtime.

- Added the PasswordChar and UseSystemPasswordChar properties
  to the InputTextBox component. They work as the same
  properties of the standard TextBox control.

==================================================================
C1InputPanel Build 2.0.20082.30                      July 23, 2008
==================================================================

- Fixed TTP issues: 12461, 17580.

- Added new properties to the InputDatePicker component:
  ReadOnly, TextAlign, ContextMenu, TextBox. Also, added the
  FormatChanged event.

- Added the StandardFormat property to the InputTimePicker,
  InputDatePicker, and InputNumericBox components.

- Added the TimeFormat property and PrepareTimeFormat event
  to the InputTimePicker component. They allow to customize
  the time format settings.
  
- Added the DateFormat property and PrepareDateFormat event
  to the InputDatePicker component. They allow to customize
  the date format settings.

- Added new formatting properties to the InputNumericBox:
  DecimalPlaces, CurrencySymbol, PositivePattern,
  NegativePattern, NumberFormat, OutOfRangeErrorText. Also,
  added the PrepareNumberFormat and FormatChanged events.

- Added the ReadOnly property to the InputComboBox.

==================================================================
C1InputPanel Build 2.0.20082.29                       June 6, 2008
==================================================================

- Fixed C1Ribbon issue 17317 for C1InputPanel as well:
  When a call to an ActiveX-DLL (which has a form with button
  placed on it) is made from a C1RibbonButton_click event, the
  button needs to be clicked twice to execute the click event
  of the button.

- Fixed a bug that was introduced in build 28: InputTextBox,
  InputComboBox, and other like components appear as "not hot"
  when the mouse pointer hovers their text input area.

==================================================================
C1InputPanel Build 2.0.20082.28                       June 3, 2008
==================================================================

- Fixed TTP issue 12498.

- Fixed an issue that caused an exception in SLE.

==================================================================
C1InputPanel Build 2.0.20082.27                       May 23, 2008
==================================================================

- The VerticalAlignment property of the InputTextBox is now
  changed from NotSet to Spread when a user sets the Multiline
  property to True.

==================================================================
C1InputPanel Build 2.0.20082.26                       May 23, 2008
==================================================================

- Fixed TTP issues: 12501, 17313.

- Fixed small problems on the Keyboard Accelerators form.

==================================================================
C1InputPanel Build 2.0.20082.25                       May 21, 2008
==================================================================

- Fixed TTP issue 17092.

==================================================================
C1InputPanel Build 2.0.20082.24                       May 21, 2008
==================================================================

- Fixed TTP issues: 12519, 17087, 17140.

==================================================================
C1InputPanel Build 2.0.20082.23                       May 20, 2008
==================================================================

- Fixed several problems with processing keyboard events
  in the InputTimePicker component.

==================================================================
C1InputPanel Build 2.0.20082.22                       May 20, 2008
==================================================================

- Fixed TTP issue 12467.

- Added the MouseWheelEdit property to the C1InputPanel.
  It allows to disable editing values in the input components
  using the mouse wheel.

- Fixed a problem with moving the input focus to hidden
  components that should be scrolled into the view area.

==================================================================
C1InputPanel Build 2.0.20082.21                       May 20, 2008
==================================================================

- Fixed TTP issues: 12473, 12477, 12495, 12501, 12507, 12511.

==================================================================
C1InputPanel Build 2.0.20082.20                       May 19, 2008
==================================================================

- Fixed issue 12513 once again. It is now possible to bind
  C1InputPanel with the Table that contains a Column having
  Space character in its name.

==================================================================
C1InputPanel Build 2.0.20082.19                       May 19, 2008
==================================================================

- Fixed TTP issues: 17261, 17263.

==================================================================
C1InputPanel Build 2.0.20082.18                       May 18, 2008
==================================================================

- Fixed TTP issue 12458.

==================================================================
C1InputPanel Build 2.0.20082.17                       May 18, 2008
==================================================================

- TTP issue 12483 has been fixed for the InputControlHost.

==================================================================
C1InputPanel Build 2.0.20082.16                       May 18, 2008
==================================================================

- Fixed a problem that caused a NullReferenceException in
  the InputDataNavigator.

==================================================================
C1InputPanel Build 2.0.20082.15                       May 18, 2008
==================================================================

- Fixed TTP issues: 12464, 12475, 12492.

- Added the GroupIndent property to the C1InputPanel. This
  property allows to specify group indentation before input
  components.
  
- Changed behavior of the C1InputPanel.Padding property.
  This property now changes interiour spacing for the outer
  panel element, not for the scrollable content element.  
  
==================================================================
C1InputPanel Build 2.0.20082.14                       May 17, 2008
==================================================================

- The RightToLeft property and RightToLeftChanged event have
  been hidden in C1InputPanel. This feature is not currently
  supported and will be added later (issue 17139).

- The error frame appeared around the whole input component
  when the ErrorText property is not empty. It should apprear
  around the inner element.
  
- Added the Localizable attribute to several properties of
  the input components.
  
- The Padding property of the C1InputPanel did not work.

==================================================================
C1InputPanel Build 2.0.20082.12                       May 16, 2008
==================================================================

- Fixed TTP issue: 12458.

==================================================================
C1InputPanel Build 2.0.20082.11                       May 16, 2008
==================================================================

- Fixed TTP issues: 12500, 12514, 17187.

- Added the InputComponent.FontPadding boolean property that
  allows to avoid text clipping when Font.Italic is set to
  true (issue 12519).

- InputCheckBox and InputRadioButton did not appear correctly
  if the CheckAlign property is Center.

==================================================================
C1InputPanel Build 2.0.20082.10                       May 15, 2008
==================================================================

- The Validating event did not work correctly for the
  InputNumericBox and InputTimePicker components.

==================================================================
C1InputPanel Build  2.0.20082.9                       May 15, 2008
==================================================================

- Fixed TTP issues: 12459, 12483, 12489, 12494, 12496, 12502,
  12510, 12516, 17085, 17104.

- Added the InputComponent.Name property and several related
  methods to the InputComponentCollection (issue 12504).

==================================================================
C1InputPanel Build  2.0.20082.8                       May 14, 2008
==================================================================

- Fixed TTP issues: 12452, 12454, 12456, 12465, 12469, 12470,
  12490, 12493, 12498, 12499, 12503, 12512, 12513, 12515, 17101.

- C1InputPanel can now inherit the value of the VisualStyle
  property from the parent C1RibbonForm.

==================================================================
C1InputPanel Build  2.0.20082.7                     April 26, 2008
==================================================================

- The CustomStyle class has been hidden (it is redeclared as
  'internal' class).

- Pressing the 'Esc' key reverted a bound InputTextBox and
  other like input components to a wrong value.

- The Validating event did not fire when the user presses
  the 'Enter' key in an InputTextBox with modified contents.

==================================================================
C1InputPanel Build  2.0.20082.6                     April 21, 2008
==================================================================

- Added the TextAlign property to the InputGroupHeader.

- The group header's Padding property didn't work as expected.

- Removed the Border property from the InputGroupHeader
  for a while. It did not really work.

==================================================================
C1InputPanel Build  2.0.20082.5                     April 19, 2008
==================================================================

- The ErrorMarkerColor property renamed to ErrorFrameColor,
  ErrorIndicatorThickness renamed to ErrorFrameThickness.

==================================================================
C1InputPanel Build  2.0.20082.4                     April 19, 2008
==================================================================

- Added the ErrorMarkerColor and ErrorIndicatorThickness
  properties to the C1InputPanel control. They allow users
  to customize the invalid input visual alert.

==================================================================
C1InputPanel Build  2.0.20082.3                     April 16, 2008
==================================================================

- Added new input components:

  InputMaskedTextBox
  InputDataNavigator

- Added new properties to existing components, such as

  InputComponent.Font
  InputComponent.ForeColor
  InputComponent.Padding, and others

- Some bugs were fixed.

==================================================================
C1InputPanel Build  2.0.20082.2                     March 21, 2008
==================================================================

- The InputControlHost.ToolTipText property did not work as
  expected.

==================================================================
C1InputPanel Build  2.0.20082.1                     March 17, 2008
==================================================================

- The first drop of the C1InputPanel.

==================================================================
