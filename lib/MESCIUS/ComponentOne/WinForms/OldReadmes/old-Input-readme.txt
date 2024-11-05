<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
C1Input for .NET (.NET 2.x/4.x version) maintenance log:
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
MaxLineCount
========================================================================
C1Input for .NET Build 2/4.0.20142.33421 October, 4st, 2014
========================================================================

Correction
------------------------------------------- 
89162: Backcolor is applied for all Textbox based controls on hovering mouse 
when same Office style is set for all controls & BackColor property is set 
for 1 control
89614: [C1DateEdit, C1NumericEdit]value is not changed using Up/Down arrow 
keys when DropDownStyle= DropDownList

========================================================================
C1Input for .NET Build 2/4.0.20142.33420 October, 1st, 2014
========================================================================

Correction
------------------------------------------- 
87939: Text in C1ComboBox can be deleted using the 'Delete' key even when 
its 'DropDownStyle' is set to 'DropDownList'

========================================================================
C1Input for .NET Build 2/4.0.20143.1 September 19th, 2014
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
** C1TextBox
  * Focus move
   bool ExitOnLastChar - Move focus after input completely, i.e. either Text length reached MaxLength or mask is filled completely.
   bool ExitOnLeftRightKey - Move focus by arrow key.

  * Length control
  MaxLengthUnit property - Determines the unit for counting for the MaxLength property.
  MaxLineCount - Maximum numbers of lines

  * Enhancement in masking mode
  New C1textBox property - CharCategory
  Defines rules to filter keyboard input.
  Example:
   // Allows only numbers in hiragana
   this.c1TextBox1.CharCategory = CharCategory.Hiragana | CharCategory.Numbers;
   // Converts input to single byte.
   this.c1TextBox1.CharCategory = CharCategory.SingleByte | CharCategory.AutoConvert;

  New mask symbols for JPN layout supported:
	H	             All SBCS characters.
	K	             SBCS Katakana.
	９	(0xFF19)     DBCS Digit
	Ｋ	(0xFF2B)     DBCS Katakana
	Ｊ	(0xFF2B)     Hiragana
	Ｚ	(0xFF3A)     All DBCS characters.
	N	             All SBCS big Katakana.
	Ｎ	(0xFF2E)     Matches DBCS big Katakana.
	Ｇ	(0xFF27)     Matches DBCS big Hiragana.
	Ｔ  (0xFF34)     Matches surrogate char.

  InvalidInput event - notification for invalid input

** SpinUp and SpinDown
* C1DropDownControl, C1ComboBox, C1DateEdit, C1NumericEdit
  SpinUp() - Spin up programmatically
  SpinDown() - Spin down programmatically
* C1ComboBox
    AllowSpinLoop - loop combobox items on spin action
* C1DateEdit
    SpinUp(TimeSpan)
    SpinDown(TimeSpan) - Increase or decrease date time by specified value
	Example:
		c1DateEdit1.SpinDown(new TimeSpan(0, 2, 0, 0, 0)); - Spin down by 2 hours.
    AllowSpinLoop - loop date time value moves to the minimum value when it reaches the Calendar.MaxDate, 
					or to the maximum when it reaches the Calendar.MinDate.
* C1NumericEdit
    SpinUp(object)
    SpinDown(object) - Increase or decrease numeric value by specified int, Decimall, real, etc.
	Example:
		c1NumericEdit1.SpinUp(); - Spin up by 1
		c1NumericEdit1.SpinDown(2);- Spin down by 2

* UpDownButtonAlignment - a new property. Defines spin alignment. Now can be sidewise.

** С1DateEdit

 * Specific JPN formats support.
 g.	-    Display the era name in alphabet (M, T, S, H).
 g 	-    Display the first character (DBCS) era
 gg -  	 Display the full (DBCS) era
 Note1: to display a negro year:
   1. Select Japanese Culture; 
   2. Select JapaneseCalendar for CalendarType property;
   3. Use 'y' or 'yy' specifiers to show the negro year number.
 Note2: It is impossible to use both Gregorian and Japanese years in a format.
 I.e. formats like "E, MMMM d, yy" won't work.

 * Specific calendars support (JapaneseCalendar, GregorianCalendar, etc.)
 CalendarType property.
 *** POSSIBLE BREAKING CHANGE
 Set it to a specific value of CalendarType enum to use non-default Calendar. 
 Note:
	CalendarType should be convient to used Culture. 
	For example, for Japanese Culture only Default, GregorianCalendar and JapaneseCalendar are supported.
 This is possible breaking because before 2014v3 drop down calendar use CultureInfo.CurrentCulture setting,
 now it depends only on Culture and Calendar properties, so if you need specific culture or calendar,
 use the new properties.

========================================================================
C1Input for .NET Build 2/4.0.20142.33417 August 6th, 2014
========================================================================

Correction
------------------------------------------- 
69257 - Selected item does not change even on pressing up down key, 
in a state where C1ComboBox - dropdown is closed and the C1ComboBox is bound 
with datasource. 
70718 - [C1SplitButton] Surrounding issue with position of the drop down list.

========================================================================
C1Input for .NET Build 2/4.0.20142.33416 August 5th, 2014
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
UseVisualStyleBackColor is hidden from the code-behind of C1CheckBox, 
C1Button and C1SplitButton controls.

========================================================================
C1Input for .NET Build 2/4.0.20142.33415 August 5th, 2014
========================================================================

Correction
------------------------------------------- 
78756 C1TextBox controls use wrong background in a scenario in themed mode.

========================================================================
C1Input for .NET Build 2/4.0.20142.33414 August 4th, 2014
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
** POSSIBLE BREAKING CHANGE
UseVisualStyleBackColor is hidden from the property list of C1CheckBox, 
C1Button and C1SplitButton controls.
Behavior:
If BackColor is set *after* theme or visual style, the control uses the 
value of BackColor.
Related TFS #75665

========================================================================
C1Input for .NET Build 2/4.0.20142.33413 July 31, 2014
========================================================================


Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
** POSSIBLE BREAKING CHANGE
Default value of C1DropDownControl.AutoOpen is False.
It was True until this build. 
C1DropDownControl.AutoOpen was added in build 2/4.0.20141.33337
If you want to use AutoOpen feature in your application, you should 
set it to True explicitly at run time or at design time.
This change resolves #78281. 


========================================================================
C1Input for .NET Build 2/4.0.20142.33412 July 25, 2014
========================================================================

Correction
------------------------------------------- 
72948 Disabled C1Input controls are overlapped and garbled in themed mode.

========================================================================
C1Input for .NET Build 2/4.0.20142.33411 July 21, 2014
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* New Property (tfs 71804)
// Gets or sets a value indicating whether to retain the current time value 
//when the date is changed via the drop down calendar.
bool C1DateEdit.RetainTimeOnDateChange

Correction
------------------------------------------- 
* 69638, 74478 'AutoSize' property of C1Label does not work correctly in 
some cases.
* 75688 C1Label BorderColor not effect when setting BorderStyle at first 
and then BorderColor
* 69257 Selected item does not change even on pressing up down key, in a 
state where C1ComboBox - dropdown is closed
* 69314 The focus movement can not be performed with the Tab key when the 
drop-down of C1ComboBox is opened.
* 71697 "IndexOutOfRangeException" is observed on using C1Input controls 
in multithread environment with aero enabled theme
* 69323 If AutoOpen property of C1ComboBox is set to True, then after 
receiving the focus, the dropdown opens for a moment and then closes 
immediately.
* 69346 C1ComboBox – Even on setting the AutoOpen property of C1ComboBox 
to True from property window, dropdown cannot be automatically opened.
* 75107 The opening the C1SplitButton is activated the overlapped instance.
* 75665 Issues are observed on setting 'BackColor' after setting theme 
using C1Theme.
* 74265 BackColor of C1TextBox does not get set if its 'Enabled' property 
is set to False;
* 70718  Issues are observed when C1Splitbutton has many items in its 
dropdown list.
* 74261, 74262 Issues in are observed in AutoSizing behavior C1Button 
& C1CheckBox, with 'Appearance' set to Button,  when VisualStyle is set 
to Office 

========================================================================
C1Input for .NET Build 2/4.0.20142.33410 July 9, 2014
========================================================================

Correction
------------------------------------------- 
* 40946 - [C1DbNavigator] 'RightToLeftChanged' event is listed in Events tab 
although there is no 'RightToLeft' property.

========================================================================
C1Input for .NET Build 2/4.0.20142.33409 July 9, 2014
========================================================================

Correction
------------------------------------------- 
* 73626 [ C1CheckBox] Theme isn't applied correctly to C1CheckBox which 
Appearance' is 'Button'

========================================================================
C1Input for .NET Build 2/4.0.20142.33407 July 6, 2014
========================================================================

Correction
------------------------------------------- 
* 73100 Checkbox is not rendered correctly when 'Appearance' is set to 
'Button' & theme is set using C1Themes
* 73679 [Win8.1] Visual Studio 2013 restarts unexceptedly by deleting 
C1DBNavigator control after setting its Anchor property to 'Right' and 
'Bottom'


========================================================================
C1Input for .NET Build 2/4.0.20142.33406 July 4, 2014
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
** New "flat" look of C1CheckBox control in Themed mode.
** C1Button changes FlatStyle to Standard on Theme apply
to get the button themed.

========================================================================
C1Input for .NET Build 2/4.0.20142.33404 July 2, 2014
========================================================================

Corrections
------------------------------------------- 
63070 [C1DateEdit] Calendar_BackColorChanged event doesn’t work.

========================================================================
C1Input for .NET Build 2/4.0.20142.33403 July 1, 2014
========================================================================

Corrections
------------------------------------------- 
67389 [C1ComboBox] CurrencyManager for BindingSource object 
is not updated with change in selection from C1ComboBox dropdown.
62921 Selected Tab is changed in C1Ribbon after using mouse wheel to change 
value of C1DateEdit placed in a user control is used as RibbonControlHost.
63495 Case 2 [C1ComboBox] Arabic Sentences then items do not show correct. 

========================================================================
C1Input for .NET Build 2/4.0.20142.33402 June 26, 2014
========================================================================

Corrections
------------------------------------------- 
69769 Exception is observed on applying theme on inherited C1Label using C1ThemeController.
64731 [C1Label] Changing BorderColor of C1Label changes its position.
63167 C1DateEdit buttons appear as flat for Windows 7 'Classic' 
theme when 'VisualStyle' is set to 'System'

========================================================================
C1Input for .NET Build 2/4.0.20141.33362 May 26, 2014
========================================================================

Corrections
------------------------------------------- 
66806 [C1Input] [C1ThemeController]Some input controls doesn't reset to 
default theme when using ResetTheme()
64022  When 'Enabled' and 'DisabledForeColor' properties of C1TextBox control
are set to  'false' and 'any color' at run-time, then their BackColor remains 
grey even when they are enabled at runtime.

========================================================================
C1Input for .NET Build 2/4.0.20141.33361 May 14, 2014
========================================================================

Corrections
------------------------------------------- 
66467 Error invoking 'About ComponentOne C1Input...' exception is occurred 
when opening about box at design time.
66580 No day is highlighted when navigating months by choosing month through 
clicking month name.
C1Button - theme did not reset on call ThemeChanged(null)

========================================================================
C1Input for .NET Build 2/4.0.20141.33360 May 13, 2014
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* 56456 Day is stay selected on navigating months in Dropdown calendar.
* 56615 It is not possible to select date after MaxDate or before MinDate 
in drop down calendar. 
* 56449 New property

bool C1TextBox.LoopPosition 
  
  Gets or sets a value indicating whether the position of the caret 
is automatically moved to the first field when the last field is filled.
  Default value is True

Set LoopPosition  to False if you want to turn C1DateEdit in compatibility 
mode with 1.0.2004x.x versions of C1Input

========================================================================
C1Input for .NET Build 2/4.0.20141.33356, April, 30 2014
========================================================================

Corrections
------------------------------------------- 
64985	[C1ComboBox] MissingMethodException is occurred when setting 
DropDownForm to DropDownFormClassName.

========================================================================
C1Input for .NET Build 2/4.0.20141.33355, April, 29 2014
========================================================================

Corrections
------------------------------------------- 
63354 [C1TextBox] Invalid input of double byte character is displayed incorrectly 
when setting AutoTabWhenFilled and EditMask properties.

========================================================================
C1Input for .NET Build 2/4.0.20141.33353, April, 29 2014
========================================================================

Corrections
------------------------------------------- 
63181 [C1ComboBox] Some properties and event descriptions of C1ComboBox 
are not localized in Japanese evironment

========================================================================
C1Input for .NET Build 2/4.0.20141.33352, April, 28 2014
========================================================================

Corrections
------------------------------------------- 
63708 Data Validation Error message box is not localized in Japanese 
when invalid input for C1SuperProvider is choosen.
63717  [Win8.1] Visual Studio 2013 restarts unexceptedly when deleting 
C1DBNavigator control.
61200 NotSupportedException is occurred when setting AutoCompleteSource to 
‘ListItems’ programmatically
63403 Unhandled exception is occurred by pressing ‘Enter’ while spell-checking 
on C1TextBox which contains custom EditMask 

========================================================================
C1Input for .NET Build 2/4.0.20141.33351, April, 24 2014
========================================================================

Corrections
------------------------------------------- 
English version localized in Japanese.

========================================================================
C1Input for .NET Build 2/4.0.20141.33350, April, 23 2014
========================================================================

Corrections
------------------------------------------- 
* 62880, 56556 (re-worked) In some environments like Japanese or Korean, 
display of year and month of drop down calendar of C1DateEdit is incorrect. 

========================================================================
C1Input for .NET Build 2/4.0.20141.33349, April, 21 2014
========================================================================

Corrections
------------------------------------------- 
60324 Some input controls have thrown an exception after resetting ‘none’ 
in ImageKey property.
63651 C1DbNavigator has thrown an unhandled exception when using in VSTO 
(Visual Studio Tools for Office 2007)
62889 [C1DateEdit] Calendar navigates to “0001“ year when setting ‘False’ 
to ‘ShowTodayButton’ through code.
63579 [C1SplitButton] NullReferenceException is thrown by pressing 
'Enter' Key while opening the dropdown of SplitButton using 'Alt+Up/Down' keys.
63496 Some text of C1Label are cut off when setting ‘FixedSingle’ to BorderStyle.

========================================================================
C1Input for .NET Build 2/4.0.20141.33347, April, 4 2014
========================================================================

Corrections
------------------------------------------- 
* Added missing strings for the Japanese version.

========================================================================
C1Input for .NET Build 2/4.0.20141.33347, April 4, 2014
========================================================================

Corrections
------------------------------------------- 
* Misc Localization issues.
* 56580 On setting EditMask property, input of double byte character 
(2 byte characters) is disabled. 
* 56556 In Japanese environment, display of year and month of drop down 
calendar of C1DateEdit is incorrect.

========================================================================
C1Input for .NET Build 2/4.0.20141.33346, March 17, 2014
========================================================================

Corrections
------------------------------------------- 
* 49574 C1DateEdit and C1NumericEdit controls are not refreshed when their 'DisabledForeColor' 
property is set and the controls are disabled.

========================================================================
C1Input for .NET Build 2/4.0.20141.33345, March 17, 2014
========================================================================

Corrections
------------------------------------------- 
* 50701 [C1Theme][C1SplitButton]Dropdown Theme of SplitButton is overrided by 2nd Theme
* C1ComboBox.Style.TextSpacing does not work when RightToLeft = Yes
* 56343 [C1DropDownControl] Set image disappears when RightToLeft = Yes

========================================================================
C1Input for .NET Build 2/4.0.20141.33344, March 14, 2014
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Refined look of buttons (UpDown,DropDow,Modal,Custom) of C1DropDownControl 
for System VisualStyle.
* 56283 [C1ComboBox] Simplified work with combo item images: 
  1. Add items in C1ComboBox.Items collection
  2. Assign ImageList to C1ComboBox.ItemsImageList;
  3. For each item added in the Items collection add corresponding image 
  in the ImageList. Set Name for the image in the ImageList to the same value as the item in C1ComboBox.Items collection.


 Corrections
-------------------------------------------
* 56359 'NullReferenceException' is thrown when form is inherit from DropDownForm.

========================================================================
C1Input for .NET Build 2/4.0.20141.33342, March 13, 2014
========================================================================

 Corrections
-------------------------------------------
* 52292 Size of some C1Input controls does not reset to original size 
after Padding value is reset.

========================================================================
C1Input for .NET Build 2/4.0.20141.33341, March 5, 2014
========================================================================

 Corrections
-------------------------------------------
* GDI leaks in C1Label and C1ComboBox
* 56141 [ComboBox] Dropdown items does not honor RightToLeft property.
* 51922 Left/Right keys for drop down list navigation 

========================================================================
C1Input for .NET Build 2/4.0.20141.33340, March 5, 2014
========================================================================

 Corrections
-------------------------------------------
[Themes] C1Input\C1TextBox\Disabled\ForeColor does not work.

========================================================================
C1Input for .NET Build 2/4.0.20141.33339, March 4, 2014
========================================================================

 Corrections
-------------------------------------------
51465 If DateEdit control is disable at run time, then its BackColor remains white. (In WinXP env.)
52048 [39840][DateEdit] When Date is Input from keyboard, then calendar doesn't highlight the date
52266 [39976][DateEdit] Calendar Month/Year does not reset to current Month/Year after selecting "Today"


========================================================================
C1Input for .NET Build 2/4.0.20141.33337, March 1, 2014
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
New property:
   C1DropDownControl.DropDownStyle 
   Possible values:
     Default - text portion is editable and the list is .displayed by clicking the down arrow.
	 DropDownList - the list is displayed by clicking any part of the control and that the text portion is not editable. 
 
 New property:
   C1ComboBox.InitialSelectedIndex - determines the selection index will be set on the control initialization.

Style property is made expandable.
Reviewed builtin item styles.

** POSSIBLE BREAKING CHANGE
- Changed look of Fixed3D border of C1TextBox and its descendants. Width of the new border is 1 (was 2).
- C1ComboBox.ItemImageList renamed to C1ComboBox.ItemsImageList
- C1ComboBox.AutoOpen moved to C1DropDownControl.AutoOpen


 Corrections
-------------------------------------------
 43923 [C1SplitButton]  'Click' event is fired when dropdown is closed. 
 51848 [C1DropDownControl] Drop down from items remain open at previous position after the Form moved. 
 52029 [C1TextBox] C1TextBox not get refresh and applied BorderColor does not show.
 51168 [SplitButton][ThemeController] Bottom and Right border are cut off when C1Button.Corners > 0
 Misc C1ComboBox issues: 51864, 52017, 51957, 51922, 51907, 51884, 51856, 52011 

========================================================================
C1Input for .NET Build 2/4.0.20141.33336, Feb 19, 2014
========================================================================

Corrections
-------------------------------------------
* [DateEdit][39437] If DateEdit control is disable at run time, then its BackColor remains white. (51465)
* [DateEdit][39635] If DateEdit control's max-date and min-date is set then we are able to navigate even 
beyond specified date range. (51466)

========================================================================
C1Input for .NET Build 2/4.0.20141.33335, Feb 18, 2014
========================================================================

Corrections
-------------------------------------------
* [C1Theme] Theme do not apply to drop down buttons of a custom class derived from C1DropDownControl.
* [C1TextBox, C1DropDownControl, C1DateEdit, C1NumaricEdit] State of modal buttons sometimes remains
hot after mouse leave the control.

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* C1ComboBox supports C1Theme;
* New property C1ComboBox.Style - custom style of drop down form and combo box items.

========================================================================
C1Input for .NET Build 2/4.0.20141.33333, Feb 12, 2014
========================================================================

2014 v1 

* New C1ComboBox control.
* ComboBoxCases sample.

=================================================================================
C1Input for .NET Build 2/4.0.20133.33332,   Build Date February 4, 2014
=================================================================================

Corrections
-------------------------------------------
* 47355 C1Label does not respect the 'BorderStyle' property when 'BorderColor' is set to 'Transparent'

=================================================================================
C1Input for .NET Build 2/4.0.20133.33331,   Build Date January 27, 2014
=================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* [C1Theme] Improved customization of C1SplitButton\Submenu node.
  - Added ImageBar\BackColor, - Added ImageBar\BackColor, ImageBar\SeparatorColor, ImageBar\Width
  - Fixed drop down button appearance.

=================================================================================
C1Input for .NET Build 2/4.0.20133.33330,   Build Date January 14, 2014
=================================================================================

Corrections
-------------------------------------------
[C1Theme] ForeColor for Hot and HotPressed states are not working for C1SplitButton\Submenu\Item (45834)

=================================================================================
C1Input for .NET Build 2/4.0.20133.33329,   Build Date December 13, 2013
=================================================================================

Corrections
-------------------------------------------
* Fixed #40518 Blinking cursor does not appear in C1TextBox if the language settings are set to Arabic.

=================================================================================
C1Input for .NET Build 2/4.0.20133.33328,   Build Date November 27, 2013
=================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
* [C1Theme] C1Label in Theming mode now supports transparent background.

Corrections
-------------------------------------------
* [C1Theme, C1Label] TextAlign of C1Label does not have effect in Theming mode.
* [C1Theme] Value set to TitleBackColor and BorderColor properties are not applied 
to dropdown calendar of C1DateEdit. (44501)


=================================================================================
C1Input for .NET Build 2/4.0.20133.33327,   Build Date November 13, 2013
=================================================================================

Corrections
-------------------------------------------
  * [C1Theme]Clearing/resetting BackgroundImage property of C1DateEdit dropdown calendar not affect 
"Theme preview: C1Input". (44503)
  
=================================================================================
C1Input for .NET Build 2/4.0.20133.33326,   Build Date November 12, 2013
=================================================================================

Corrections
-------------------------------------------
  * [C1Theme]Error message box shows if user deletes C1Input controls and C1CommandHolder from Form. (45542)

=================================================================================
C1Input for .NET Build 2/4.0.20133.33325,   Build Date November 6, 2013
=================================================================================

Corrections
-------------------------------------------
  * C1SplitButton\Submenu\Item\<state>\ForeColor in Theming does not work.

=================================================================================
C1Input for .NET Build 2/4.0.20133.33324,   Build Date November 5, 2013
=================================================================================

Corrections
-------------------------------------------
  * C1Button corners appearance in Theming.

=================================================================================
C1Input for .NET Build 2/4.0.20133.33323,   Build Date November 1st, 2013
=================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* VisualStyle support in Theming.

=================================================================================
C1Input for .NET Build 2/4.0.20133.33322,   Build Date October 30, 2013
=================================================================================

Corrections
-------------------------------------------
* A fix in C1DbNavigator.
* C1Label disappeared on Theme changed if the new Font is different from previous.

=================================================================================
C1Input for .NET Build 2/4.0.20133.33320,   Build Date October 16, 2013
=================================================================================

Corrections
-------------------------------------------
 * [Forum][C1NumeriEdit] Decimal point s not placed correctly when typed between the digits (39933)

=================================================================================
C1Input for .NET Build 2/4.0.20133.33319,   Build Date October 13, 2013
=================================================================================

Corrections
-------------------------------------------
* A theming/obfuscation issue

=================================================================================
C1Input for .NET Build 2/4.0.20133.33318,   Build Date October 11, 2013
=================================================================================

* 2013 v3 Build

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
* C1Theme support. C1Input controls are supported in the C1ThemeDesigner application. 
  That allows to use default C1 themes or custom ones and to apply them on application level.

========================================================================
C1Input for .NET Build 2/4.0.20132.33306, September, 26 2013
========================================================================
Corrections
-------------------------------------------
* C1NumericEdit replacing "-" with "0". (39769)
* Unhandled exception occurs sometimes on control dispose. (41000)

========================================================================
C1Input for .NET Build 2/4.0.20132.33305, July, 11 2013
========================================================================
Corrections
-------------------------------------------
[SplitButton] 
	True value set to Checked property at Design Time does not apply at Run Time. (37106)
	e.ClickedItem.Checked property always return False in DropDownItemClicked event. (37153)
	If FlatStyle is System, then dropdown area disappeared from C1SplitButton. (37159)
	Although C1SplitButton is deleted its dropdownitems are not deleted. (37102)
	Item does not get re-added to deleted C1SplitButton if delete action is undo. (37712)

========================================================================
C1Input for .NET Build 2/4.0.20132.33304, July, 10 2013
========================================================================

Corrections
-------------------------------------------
[SplitButton] If DropDownItem.Text property is null then NullReferenceException is thrown. (37155)
[SplitButton] Dropdown window of C1SplitButton can be opened from code when Visible=False (37108)
[SplitButton] If Form is resized or AutoSize/AutoSizeMode/TextImageRelation property of another C1SplitButton 
is toggled/changed at Design Time then size of C1SplitButton increased. (38913 Case 1)
[C1DbNavigator] Text and tooltip cannot show correctly. Localization issue.(38904)


========================================================================
C1Input for .NET Build 2/4.0.20132.33303, July, 2 2013
========================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
  [SplitButton] Dropdown of DropDownItem opens when mouse is hovered. (37154)

Corrections
-------------------------------------------
  Size of C1SplitButton is does not fit its text and dropdown. (37103)
  Dropdown window of C1SplitButton can be opened from code when Enabled=False. (37108)
  If DropDownItem.Text property is empty string then its items collection cannot show at RunTime. (37155)
  Warning message box show when Image property is set if Text property is empty string. (37157)

========================================================================
 C1Input for .NET Build 2/4.0.20132.33302, Jun, 30 2013
========================================================================

Corrections
-------------------------------------------
[C1DateEdit] Unlike previous build, 'NullReferenceException' is occured when 'Office xxx' 
 visual style is change. (37700)

[SplitButton] 
   Issues observed if Text property is "-". (37156 Case1, Case3)
   Nothing happen if EditItem from ContextMenu/Commands is clicked. (37104)
   Incorrect behaviors observed when value is set to ImageList or DropDownImageList property. (37105)
   Default value for Text property of DropDownItem at Design Time as soon as item is added to 
 DropDownItem Collection Editor is provided. (37107)
   Checked icon for DropDownItem is incorrect if RightToLeft property is Yes. (37708)
    Setting RightToLeft property to Yes at RunTime does not change layout of dropdown list. (37774)

========================================================================
C1Input for .NET Build 2/4.0.20132.33301, Jun, 10 2013
========================================================================

Corrections
-------------------------------------------
A few fixes in C1SplitButton.

========================================================================
C1Input for .NET Build 2/4.0.20132.33300, May, 27 2013
========================================================================

* New C1SplitButton control.
	Use Items property to set collection of drop down items.
	Use DropDownItemClicked event to handle the Click event on an item.

* New Sample - SplitButtons

========================================================================
C1Input for .NET Build 2/4.0.20131.33298, May, 4 2013
========================================================================

Corrections
-------------------------------------------
* The application does not close when closing the form after choosing date 
in the calendar of the C1DateEdit control. (15496)

========================================================================
C1Input for .NET Build 2/4.0.20131.33297, March, 30 2013
========================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* [C1DateEdit] Full support for Hijri and Um Al Qura calendars. 

C1DateEdit uses Gregorian, Hijri or Um Al Qura calendars depending on 
CultureInfo.CurrentCulture.Calendar 

Example1:
If you add this code on program startup, the calendar will be using 
Um Al Qura calendar:

Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-SA", false); 

Drop down calendar uses Latin or Arabic numbers in years, days, week numbers depending on
CultureInfo.CurrentUICulture

Example2:
If you add this code on program startup, drop down calendar will be using 
Um Al Qura calendar, but with english numbers and month name notations:

Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-SA", false); 
Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US", false); 


Example3:
If you add this code on program startup, drop down calendar will be using 
Um Al Qura calendar, with arabic numbers and islamic month names:

Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-SA", false); 
Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-SA", false); 

The options mentioned above will be working on any operating system regional settings.

========================================================================
C1Input for .NET Build 2/4.0.20131.33296, February, 26 2013
========================================================================

Corrections
-------------------------------------------
* C1DBNavigator not anchoring to Right (34066)

========================================================================
C1Input for .NET Build 2/4.0.20131.33295, February, 25 2013
========================================================================

Corrections
-------------------------------------------
  * Exception 'Specified time is not supported in this calendar...' is 
  thrown with 'ar-SA' CultureInfo. (30299)

========================================================================
C1Input for .NET Build 2/4.0.20131.33294, February, 10 2013
========================================================================

Corrections
-------------------------------------------
  * Misc issues with Paste() method in C1Input controls. (30088, 33951)

========================================================================
C1Input for .NET Build 2/4.0.20131.33292, January, 28 2013
========================================================================

  * 2013 v1 build

========================================================================
C1Input for .NET Build 2/4.0.20123.33291, November, 17 2012
========================================================================

Corrections
-------------------------------------------
* Incorrect font displayed in C1Textbox when 'MarkEmpty' property is set to True. 
(29476, 28268 Case 1)

========================================================================
C1Input for .NET Build 2/4.0.20123.33290, November, 5 2012
========================================================================

 * Added localization for Korean. 
 Used if the CurrentUICulture name is starting with "ko".
 * Added localization for simplified Chinese. 
 Used if the CurrentUICulture name is starting with "zh".

========================================================================
C1Input for .NET Build 2/4.0.20122.33289, October, 12 2012
========================================================================

Corrections
-------------------------------------------
* Different toolbox icon style is observed in VS 2010 and VS2012 (27730)

========================================================================
C1Input for .NET Build 2/4.0.20122.33288, October, 11 2012
========================================================================

  * 2012 v3 build

Enhancements/Documentation/Behavior Changes
------------------------------------------- 
* [C1CheckBox] New event VisualStyleChanged

Corrections
-------------------------------------------
* [C1DateEdit] The whole date time cannot be selected by using Shift+Home key. (28153)
* [C1DateEdit] The selected color is shown on the disabled date. (28154)
* [C1CheckBox] VisualStyle is not preserved for C1CheckBox control inside the UserControl. (27853)

========================================================================
C1Input for .NET Build 2/4.0.20122.33287, September, 24 2012
========================================================================

Enhancements/Documentation/Behavior Changes
------------------------------------------- 
* [C1DateEdit] Added new C1DateEdit.Calendar.DisabledDates property (18249).
New methods of DateEditMonthCalendar class:
  AddDisabledDate
  RemoveDisabledDate
  RemoveAllDisabledDates


========================================================================
C1Input for .NET Build 2/4.0.20122.33286, September, 24 2012
========================================================================

Enhancements/Documentation/Behavior Changes
------------------------------------------- 
* [C1DropDownControl, C1DateEdit, C1NumericEdit]
   New "Custom" Button - a button, next to the Modal button.
   To show the button set "Custom" flag to VisibleButtons property.
   Set image for the "Custom" button using ButtonImages.CustomImage (21443).

* [C1TextBox, C1DropDownControl, C1DateEdit, C1NumericEdit]
	New "MarkEmpty" property - shows red dotted line if Text is empty (21443).

Corrections
-------------------------------------------
* [C1NumericEdit] ValueChanged event is fired twice in some cases. (19727)

========================================================================
C1Input for .NET Build 2/4.0.20122.33285, September, 3 2012
========================================================================

Corrections
-------------------------------------------
* StackOverflowException occurs on binding C1Input control. (27602)
* Visual Studio becomes crash on placing C1DateEdit control on the form. (27609)

========================================================================
C1Input for .NET Build 2/4.0.20122.33284, September, 3 2012
========================================================================

Enhancements/Documentation/Behavior Changes
------------------------------------------- 
- Added Metro-style toolbox icons.

========================================================================
C1Input for .NET Build 2/4.0.20122.33282, July, 24 2012
========================================================================

Corrections
-------------------------------------------
* Formatting event of c1textbox bind to a datatable does not fire if the data 
have the same value. (15462)
* Seconds of the C1TextBox control is not change. (23981)

========================================================================
C1Input for .NET Build 2/4.0.20122.33281, July, 9 2012
========================================================================

Corrections
-------------------------------------------
* updated AssemblyCompany and AssemblyCopyright attributes and about box.

========================================================================
C1Input for .NET Build 2/4.0.20122.33280, June, 22 2012
========================================================================

Corrections
------------------------------------------- 
  * C1DateEdit.Calendar's 'TrailingForeColor' property is not working. (10151)
  * C1DbNavigator.ButtonSize property is not working. (23457)
  Note: Best practice is to use ImageList with the ImageSize less by 6px
  to ButtonSize. For example, if you want to use 24x24 images, set ButtonSize to 30x30.
  In all other cases images will be scaled.

========================================================================
C1Input for .NET Build 2/4.0.20122.33278, June, 4 2012
========================================================================

Corrections
------------------------------------------- 
  * When MouseClickPassThrough is set to True then DropDownForm does not 
  close when  click on any area outside of the DropDown control. (17059)

========================================================================
C1Input for .NET Build 2/4.0.20122.33277, May, 14 2012
========================================================================

  * 2012 v2 build

========================================================================
C1Input for .NET Build 2/4.0.20121.33275, Mar, 29 2012
========================================================================

Corrections
------------------------------------------- 
  * [C1DbNavigator] Navigator always moves to the second record on 
  "left arrow" button click. (20953)
  * Exception occurs when C1TextBox Multiline property is set to True 
  and Padding is set to more than 1. (20400)

========================================================================
C1Input for .NET Build 2/4.0.20121.33274, Feb, 13 2012
========================================================================

Enhancements/Documentation/Behavior Changes
------------------------------------------- 
	TextChanged event is visible in the Properties window.

========================================================================
C1Input for .NET Build 2/4.0.20121.33273, Feb, 9 2012
========================================================================
  
  * 2012 v1 build
 
Enhancements/Documentation/Behavior Changes
------------------------------------------- 
  * Changes in C1DbNavigator control:
    - new Text property; It gets or sets text in Position text box.
	- new TextChanged event;
	- new value NavigatorButtonEnum.Position. It's used in BeforeAction event
	when the text in Position text box is changed.
	- Index property in NavigatorBeforeActionEventArgs is read/write now.
	You can change the navigation if you change the Index.

	Example:

    private void c1DbNavigator1_BeforeAction(object sender, C1.Win.C1Input.NavigatorBeforeActionEventArgs e)
    {
		if (e.Button == C1.Win.C1Input.NavigatorButtonEnum.First)
        {
		   // Goto second record instead of the first
           e.Index = 1;
        }
        
		// Go to the last row if user entered too large position
        if (e.Button == C1.Win.C1Input.NavigatorButtonEnum.Position && e.Cancel)
        {
           e.Cancel = false;
        }
    }

	


========================================================================
C1Input for .NET Build 2/4.0.20113.33272, Feb, 8 2012
========================================================================
 
Enhancements/Documentation/Behavior Changes
------------------------------------------- 
  * [C1DropDownControl] If Size of the DropDownFrom is changed on the fly 
  (while the drop down is opened), the drop down's location is updated 
  on the fly accordingly.

Corrections
------------------------------------------- 
  * [C1DropDownControl] Click outside of the dropdown form provides a 
  DropDownClosedEventArgs object with Selected=true in DropDownClosed 
  event handler.
  * "Null Reference Exception" observed when closed the from contain 
  inherited C1Textbox control. [10852-139] (TFS 19768)
  * [10606-139]"Null Reference Exception" observed on inherited C1DateEdit 
  control. (TFS 19678)
  * [C1DropDown] Unlike MSComboBox control, 'F4' key does not get captured 
  for C1DropDown. [6802-139] (TFS 16799)
  *  "EmptyAsNull' value do not work when 'EditMask' property of C1DateEdit 
  is set. (TFS 15210)

========================================================================
C1Input for .NET Build 2/4.0.20113.33271, Nov, 24 2011
========================================================================

Enhancements/Documentation/Behavior Changes
------------------------------------------- 
Updated licensing to conform with Federal Information Processing Standards requirements (TFS 18562)

========================================================================
C1Input for .NET Build 2/4.0.20113.33270, Oct, 5 2011
========================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Enhanced licensing in environments with some security policy restrictions.

========================================================================
C1Input for .NET Build 2/4.0.20113.33269, Sep, 22 2011
========================================================================

Behavior changes in C1Button:
----------------
  Flat behavior change:
    - VisualStyle has no effect if C1Button.FlatStyle is not Standard;  
	- Changing value of C1Button.VisualStyle property does not change value of FlatStyle.
  These changes above were made to address issues 16040, 16038, 16065.


New public event:
----------------
  C1DropDownControl.BeforeDropDownOpen - Occurs just before the dropdown is opened.
  Setting the CancelEventArgs.Cancel property to True prevents the dropdown form from opening.
  The old event C1DropDownControl.DropDownOpening is deprecated.

Fixed:
----------------
  "Object reference not set to an instance of an object." message seen 
  when reset the C1TextBox1.ErrorInfo.C1ErrorProvider property. (17362)

========================================================================
C1Input for .NET Build 2/4.0.20113.33268, Sep, 15 2011
========================================================================

* New event:
  C1DateEdit.Calendar.MonthChanged
  
  Handles the month change in the Dropdown calendar in C1DateEdit. 
  Occurs when the value of the FirstMonth or LastMonth property changes.
  Can be used to set some dates in the month to bold as user scrolls through the months. (15357)
  

========================================================================
C1Input for .NET Build 2/4.0.20113.33267, Sep, 14 2011
========================================================================

* 2011 v3 Build.

* C1SuperErrorProvider support:
  
  New C1TextBox.ErrorInfo.C1SuperErrorProvider property.

========================================================================
C1Input for .NET Build 2/4.0.20112.33266, Jul, 27 2011
========================================================================

 Fixed:
 *  DropdownForm of C1DropDownControl closes when the user clicks on the 
 dropdown of C1Combo placed on the dropdownform.  (15077, 4687)
 
========================================================================
C1Input for .NET Build 2/4.0.20112.33265, Jul, 11 2011
========================================================================

 Fixed:
 * Red rectangle is not displayed with today's date in dropdown calender. 
 (15821)

========================================================================
C1Input for .NET Build 2/4.0.20112.33263, Jun, 9 2011
========================================================================

 Fixed:
 * [C1NumericEdit] WindowForm crashed when Language property set to 
 two languages simultaneously. (15257)

========================================================================
C1Input for .NET Build 2/4.0.20112.33262, May, 5 2011
========================================================================

* 2011 v2 Build.

========================================================================
C1Input for .NET Build 2/4.0.20111.33261, 14-Apr-2011
========================================================================

 Fixed:
 * Exception is observed on setting Value to String.Empty when datatype 
 is set as Integer (14721)
  
========================================================================
C1Input for .NET Build 2/4.0.20111.33260, 04-Mar-2011
========================================================================

 Fixed:
 * [C1CheckBox] Error 'True is not valid...' is thrown on binding with 
 integer value. (14505)
 * Today BorderColor does not take effect to calendar of C1DateEdit. (14027)

========================================================================
C1Input for .NET Build 2/4.0.20111.33258, 19-Feb-2011
========================================================================

Behavior change:
 * C1DateEdit's dropdown calendar now shows/selects dates in local time.
 This means if you select a date in the dropdown calendar, or Today button, 
 then Value will be adjusted according to CurrentTimeZone and GMToffset  
 properties, but in Text you will always see zero time. 
  . 
 This fixes issues: 
    C1DateEdit control does not shown the exact timing as per 
	the GMToffset. (13860)
	C1DateEdit control does not shown an adjusted time at first time when 
	we set the today date. (13861)

 Fixed:
 * Editmask is removed from C1TextBox after validation error. (11021)
 * C1Checkbox does not get checked on binding string value 'Yes' to the 
 C1Checkbox. (14018)
 * C1checkbox does not bind with Boolean value after binding with Interger 
 value. (14019)
 * BackColor is not shown in C1Button control after setting VisualStyle. (14338)


========================================================================
C1Input for .NET Build 2/4.0.20111.33257, 02-Jan-2011
========================================================================

 * new C1CheckBox control.

 In addition to the standard CheckBox functionality, C1CheckBox 
 
 - supports data binding to data source fields of Boolean, String, or Integer types. 
 
 - supports BorderStyle and BorderColor properties.

 - supports visual styles.

Examples:
1. Bind C1CheckBox to a Boolean field.
c1CheckBox1.DataSource = dt;
c1CheckBox1.DataField = "ColumnBoolean";

2. Bind C1CheckBox to a String field.
c1CheckBox1.DataSource = dt;
c1CheckBox1.DataField = "ColumnString";
c1CheckBox1.DataType = typeof(string);
// Use TranslateValues property to translate string values to/from the check box states. 
c1CheckBox1.TranslateValues.Checked = "Yes";
c1CheckBox1.TranslateValues.Unchecked = "No";

3. Bind C1CheckBox to a String field.
c1CheckBox1.DataSource = dt;
c1CheckBox1.DataField = "ColumnInt";
c1CheckBox1.DataType = typeof(int);
// Use TranslateValues property to translate string values to/from the check box states. 
c1CheckBox1.TranslateValues.Checked = 1;
c1CheckBox1.TranslateValues.Unchecked = 0;

========================================================================
C1Input for .NET Build 2/4.0.20111.33256, 28-Dec-2010
========================================================================

 * 2011 v1 Build.

========================================================================
C1Input for .NET Build 2/4.0.20103.33255, 28-Dec-2010
========================================================================

 Fixed:

 * TodayDate rectangle is drawn on the current date when the 'TodayDate' 
 is set to another date. (10153)

========================================================================
C1Input for .NET Build 2/4.0.20103.33254, 30-Nov-2010
========================================================================

 Fixed:

 * C1Label inside C1DockingTab shows Border at runtime for 
 Office2007 Visual Styles. (5961)

========================================================================
C1Input for .NET Build 2/4.0.20103.33253, 10-Nov-2010
========================================================================

 Fixed:

 * 'C1TextBox.EditMode' gets set to True when 'Enabled' property 
 is set to True. (12294)
 
 * C1DropDownControl gets enabled when the Bindings are set twice. (13330)

========================================================================
C1Input for .NET Build 2/4.0.20103.33251, 13-Oct-2010
========================================================================
  
 Fixed:

 * C1NumericEdito's value is set to null when cleared with 'C' button of 
 the dropdown calculator. (8443)
 Note: if initial value was DBNull, then on 'C' the value returns to null 
 by design.

 * "EmptyAsNull" value do not work when 'EditMask' property of C1NumericEdit 
 is set. (9013)

 * Application crashes when the C1TextBox.Font property is changed in 
 GotFocus event. (11068)

========================================================================
C1Input for .NET Build 2/4.0.20103.33250, 16-Sep-2010
========================================================================
  
  * 2010 V3 Build.

========================================================================
C1Input for .NET Build 2/4.0.20102.33249, 13-Sep-2010
========================================================================

New feature
-----------
  * C1DateEdit.Calendar.CurrentMonthDisplayOffset property.
  
  Allows set the initial current month position in the multi-dimensional 
  drop down calendar. 
   
  Examples:

   c1DateEdit1.Calendar.CalendarDimensions = new Size(3, 1);
   // Display current month at the center of the calendar.
   // Other values for these dimensions 3x1:
   // 0 - (Default) - at the Right
   // 1 - Center
   // 2 - Left
   c1DateEdit1.Calendar.CurrentMonthDisplayOffset = 1;

   c1DateEdit2.Calendar.CalendarDimensions = new Size(5, 1);
   // Display current month at the left of the calendar.
   // Other values for these dimensions 5x1:
   // 0 - (Default) - at the Right
   // 2 - Center
   // 4 - Left
   c1DateEdit2.Calendar.CurrentMonthDisplayOffset = 1;


========================================================================
C1Input for .NET Build 2/4.0.20102.33248, 28-Aug-2010
========================================================================
 * Fixed:
 "MouseClickPassThrough" property does not work (9199)
 
========================================================================
C1Input for .NET Build 2/4.0.20102.33247, 25-May-2010
========================================================================

 * 2010 V2 release.

 * Fixed:
 Sub properties of 'Calculator.UIStrings' property is not shown in the 
 property grid for C1NumericEdit. (10557)
 
 C1DateEdit.Calendar's 'ShowTodayCircle' property does not work if set 
 in the property grid or at page load. (10558)

========================================================================
C1Input for .NET Build 2.0.20101.33246, 4.0.20101.33246, 8-Apr-2010
========================================================================
  * Target framework of C1Input 2.0.20101.33246, 
    changed to .Net Framework 4.0 Client Profile.

========================================================================
C1Input for .NET Build 2.0.20101.33245, 26-Mar-2010
========================================================================
Fixed:
  * Exception is observed when MessageBox is opened in 
C1DbNavigator.BeforeAction event (9842)
  
  * Size is set to 0 when C1Label is placed in a MS Panel & AutoSize 
is set to False & VisualStyle is set to any value except System. (9794)
  
========================================================================
C1Input for .NET Build 2.0.20101.33244, 10-Feb-2010
========================================================================
  * Licensing code updated.
  
Fixed:
  * [C1DateEdit] An exception is observed for 'Office2010' visual styles 
at run time. (8494)
  * [C1DateEdit] Error observed on opening dropdown calendar in C1DateEdit 
when the 'ShowToday' property is set to true for calendar object. (6047)

========================================================================
C1Input for .NET Build 2.0.20101.33243, 25-Jan-2010
========================================================================

Fixed:
  * Property grid does not display the description for 'BorderColor' 
 property. (8493)
  * Applied Visual Style is not getting refreshed in the dropdown at
design time. (8494)
  * On setting the 'BorderColor' property to some value say 'Red' , no
effect on the control's border is observed. (8496)
  * [C1NumericEditorControl] An extra box is observed in dropdown of
C1NumericEditor control when Office2010 Visual styles are applied. (8590)

  * Licensing code updated.

========================================================================
C1Input for .NET Build 2.0.20101.33242, 11-Dec-2009
========================================================================

* 2010 v1 release.

New features
------------

  Support for the Office 2010 visual styles (blue, silver and black).

*  The following values added to the VisualStyle enum:
  - Office2010Blue
  - Office2010Silver
  - Office2010Black

* New public property on C1TextBox, C1DropDownControl, C1DateEdit, C1NumericEdit:

    Color BorderColor {get;set;}
      Gets or sets the border color of the control.

* New public event on C1TextBox, C1DropDownControl, C1DateEdit, C1NumericEdit:

    event EventHandler BorderColorChanged 
      Occurs when the BorderColor property has changed.

* New protected method on C1TextBox, C1DropDownControl, C1DateEdit, C1NumericEdit:

    protected virtual void OnBorderColorChanged(EventArgs e);
      Invokes the BorderColorChanged event.

========================================================================
C1Input for .NET Build 2.0.20093.33241, 22-Oct-2009
========================================================================
  * Fixed:
	DropdownForm of C1DropDownControl closes when the user clicks on the dropdown of C1Combo placed on the dropdownform. (4687)

========================================================================
C1Input for .NET Build 2.0.20093.33240, 12-Oct-2009
========================================================================
  * Fixed:
    C1NumericEdit control throws an exception when if ‘.’ (dot)
    of 'e'/'x' (exponent) is pressed on the Number Pad keys after 
    setting the MaxLength property. (5923)
  * Updated assembly attributes.  

========================================================================
C1Input for .NET Build 2.0.20093.33238, 7-Oct-2009
========================================================================
  
  * Licensing code updated.
  * Added prefix 'C1' in the about box for C1InputControls. (6810)

Fixes:
  * [C1DBNavigator] C1DBNavigator's height and width is not maintained on 
setting property -'AutoSize' to False. (6808)
  * [C1DbNavigator] Image set for 'NavigationButtons' get stretched on setting 
text property with 'Visual Style' set other than 'System'/'Custom'. (6819)
  * [C1Button] Image files getting stretched on setting 'Visual Style' 
other that 'system'/'custom'.  (6821)
  
========================================================================
C1Input for .NET Build 2.0.20093.33237, 21-Sep-2009
========================================================================

  * New toolbox icons.

========================================================================
C1Input for .NET Build 2.0.20093.33236, 14-Sep-2009
========================================================================
  * Fixed:
  The calendar title text slightly overlaps the navigation buttons. (3837)


========================================================================
C1Input for .NET Build 2.0.20092.33234, 18-Aug-2009
========================================================================
  * PublicKeyToken revert:
  The public key of C1.Win.Input.2 2.0.20092.33230-33233 was different from what it was in 2009.V1. 
  This causing the LICX file (with previous entry) failing to recognize the newer build.
  The error was - "The located assembly manifest definition doesn't match the assembly reference".
  Current version reverts the public key to the original.
  
  If you face with the problem "The located assembly manifest definition doesn't match the assembly reference",
  just strip public key information in the licenses.licx, 
  or edit, correct PublicKeyToken is:
  PublicKeyToken=7e7ff60f0c214f9a

  * Fixed:
  Control’s validation code to identify if the user has entered letter or digit is not executing in a particular scenario. (4140)
  

========================================================================
C1Input for .NET Build 2.0.20092.33233, 10-Aug-2009
========================================================================
  * Fixed:
  Evaluation message seen on opening the dropdown of licensed C1NumericEdit. (5677)

========================================================================
C1Input for .NET Build 2.0.20092.33232, 28-Jul-2009
========================================================================
  * Fixed:
  C1DateEdit gives a nag screen at runtime, even when the control is licensed properly.

========================================================================
C1Input for .NET Build 2.0.20092.33230, 16-Jun-2009
========================================================================
  New licensing code.
  
  Bug fix:
  * C1DateEdit's controls are not refreshed when the DisabledForeColor property is set and the control is disabled (#3835)

========================================================================
C1Input for .NET Build 2.0.20091.33229, 15-Mar-2009
========================================================================
  * 'Calendar.ShowWeekNumbers' property of C1DateEdit is not working in the Page Load event. (#17559)
  
========================================================================
C1Input for .NET Build 2.0.20091.33227, 05-Mar-2009
========================================================================
  * Changing the DisabledForeColor property changes the TextAlignment (#19243, #19177)
  * Calendar.VisualStyleChanged' & 'Calendar.BackColorChanged' events are fired multiple times when the VisualStyle of the controls. (#18783)
  * When the 'C1DateEdit.CalendarDimensions' property is changed at design time or at run time, NullReferenceException is observed. (#18772)
  * 'ValidationException' is observed when user enter 0 in the year combobox and dropdown calendar is opened. (#11750)
  * 'ArgumentOutOfRangeException' is observed when the user selects any date in December,9999. This is done by clicking on the disabled dates in November,9998. (#11750)
  
========================================================================
C1Input for .NET Build 2.0.20091.33225, 16-Jan-2009
========================================================================
Bug Fix:
---------
  *  'Calendar.MaxDate' & 'Calendar.MinDate' properties of C1DateEdit do not work correctly in few scenarios. (#11754)
  ArgumentException occurs if value less than Calendar.MinDate is set to Calendar.MaxDate.
  ArgumentException occurs if value greater than Calendar.MaxDate is set to Calendar.MinDate.
  

========================================================================
C1Input for .NET Build 2.0.20083.33223, 22-December-2008
========================================================================

Bug Fix:
---------
  * The right side of C1TextBox crosses over the container control when anchored and text box is positioned at specific locations (#18631)
  
========================================================================
C1Input for .NET Build 2.0.20083.33221, 01-November-2008
========================================================================

Bug Fix:
---------
  * Setting the DisabledForeColor property of a C1TextBox control has no effect. (#17972)
  * C1DateTimePicker renders slowly, if C1DateEdit.Calendar.ShowClearButton or C1DateEdit.Calendar.ShowTodayButton property is set to False. (#18037)
  * C1DbNavigator does not bind to a datatable. (#18285)
  
========================================================================
C1Input for .NET Build 2.0.20083.33220, 22-September-2008
========================================================================

Bug Fix:
---------
  #18211: 'ArgumentException' observed on resizing the form, containing C1Button with set Office2007 style, with C1Sizer/C1SizerLight
  #17822: When a Class Library dll, containing user control with Licensed C1Button placed on it, is reference in another application then Nag screen  is shown on debugging the application.

========================================================================
C1Input for .NET Build 2.0.20082.33219, 02-September-2008
========================================================================

========================================================================
C1Input for .NET Build 2.0.20082.33217, 07-July-2008
========================================================================

Bug fix
---------
  #17586: C1Input contols do not perform layout on C1RibbonForm.

========================================================================
C1Input for .NET Build 2.0.20082.33215, 30-June-2008
========================================================================

Bug fix
---------
 #17427 : C1DateEdit's Today and Clear buttons do not honour the set 'VisualStyle', 'TodayText' and 'ClearText' properties set at design time. 

========================================================================
C1Input for .NET Build 2.0.20082.33214, 30-June-2008
========================================================================

New public event:
---------
  C1DropDownControl.DropDownOpening - Occurs just before the dropdown is opened.
  
Bug fix
---------
 #17523 : Visual Styles applied on the controls placed on the form are not visible unless mouse is hovered on it. 

========================================================================
C1Input for .NET Build 2.0.20082.33212, 20-May-2008
========================================================================

Bug fix
---------
 #17270 : Visual Styles applied on the controls placed on the form are not visible unless mouse is hovered on it. 

========================================================================
C1Input for .NET Build 2.0.20082.33211, 19-May-2008
========================================================================

========================================================================
C1Input for .NET Build 2.0.20082.33210, 19-May-2008
========================================================================

Bug fix
---------
 #17256 - Width of C1NumericEdit, C1DateEdit, C1DbNavigator, C1DropDownControl and C1TextBox is not maintained when placed on the form.
 
========================================================================
C1Input for .NET Build 2.0.20082.33209, 14-May-2008
========================================================================

Bug fixes
---------

* C1DateEdit's calendar margins are not set to the correct size. (VNINP000386)	
* 'ArgumentOutOfRangeException' is observed when the user selects any date in December,9999. Maximum date that can be selected is 31 December,9998. (VNINP000355) 
* When C1DbNavigator is placed in a disabled GroupBox which is enabled at runtime, the C1DbNavigator stays in disabled style. (VNINP000371) 
* When enable at runtime a disabled styled C1TextBox, forecolor of C1TextBox stays in disabled style. 
* "Can not access disposed object." occurs in C1DbNavigator at design-time.
* Button is not released before contextmenu opens, and remains pressed thereafter if user right clicks twice on a C1Button to open a C1ContextMenu  (VNINP000370) 
* Few properties of C1DateEdit.Calendar do not work if set Custom VisualStyle based on Office2007 style.  (VNINP000358)  
* C1DateEdit, C1NumericEdit and C1DropDownControl do not reposition themselves when the form's height is decreased and disappear from the view if the height of form keeps on decreasing. (VNINP000375)
* the VisualStyle property did not inherit its value from the container control (such as a C1RibbonForm) when the visual style is not specified explicitly for the C1Button.
* C1DropDown component throws and error when used in VSTO (Visual Studio Tools for Office 2007) (VNINP000384)
 
========================================================================
C1Input for .NET Build 2.0.20082.33206, 02-May-2008
========================================================================

Bug fixes
---------

* Creation of multiple instances of 'C1DateEdit' and 'C1NumericEdit' Controls 
	takes a lot of time.  (VNINP000352) 
	
* C1DateEdit.Calendar events are not fired. (VNINP000364)


========================================================================
C1Input for .NET Build 2.0.20082.33204, 01-Apr-2008
========================================================================

2008 V2 build.

Behavior changes
----------------

* The C1DropDownControl.DropDownOpened event is now fired later than in 
	previous versions. In particular, the C1DateEdit.Calendar.SelectedDate 
	can now be set in the user-defined C1DateEdit.DropDownOpened event 
	handler (previously, any such setting was overwritten when the 
	calendar opened).

Bug fixes
---------

* When using Office 2007 visual styles, right click on a C1Button showed 
  the button as pressed. Fixed.

* Fixed AutoEllipsis on C1Button using Office 2007 visual styles.

* Fixed several situations when exceptions occurred when the dropdown 
  calendar was shown on a C1DateEdit with the date equal or close to 
  Jan, year 1.

* Improved resizing behavior of C1DropDownControl and inherited controls 
  when used with C1Sizer.

* Creating handlers for C1DateEdit's calendar or C1NumericEdit's 
  calculator at design time did not always work. Fixed.

* The SelectedDate is now not shown at design time (setting it at design 
	time is and was not supported anyway).

* The C1DateEdit.Calendar.DayNameLength property could not be set in 
	some scenarios. Fixed.

* Typing the year in the year numeric up/down box of the C1DateEdit's 
	dropdown calendar did not update the date. Fixed.

* C1TextBox.MaxLength was ignored when C1TextBox.NumericInput was true. 
	Fixed.

========================================================================
C1Input for .NET Build 2.0.20081.33203, 17-Mar-2008
========================================================================

Bug fixes
---------

* Fixed a design time bug introduced in build 33105: on inherited forms,
  C1TextBox and controls based on it appeared as read-only even if they
  were declared as public in the base form.

========================================================================
C1Input for .NET Build 2.0.20081.33202, 10-Mar-2008
========================================================================

Bug fixes
---------

* Re-enabling a container with several C1TextBox or inherited controls
  in some situations could result in those controls having disabled text
  color in the enabled state. Fixed.

========================================================================
C1Input for .NET Build 2.0.20081.33201, 28-Feb-2008
========================================================================

Bug fixes
---------

* When a C1TextBox or inherited control was placed in a container, and
  that container were disabled before the it was shown, enabling the
  container afterwards did not re-enable the C1TextBox control. The bug
  was introduced in build 33103. Fixed. (Please note that now setting
  the Enabled property to false on a C1TextBox causes the handle on it
  to be created immediately if it were not created already.)

========================================================================
C1Input for .NET Build 2.0.20073.33107, 07-Jan-2007
========================================================================

Bug fixes
---------

* In previous builds, when a C1DateEdit or C1NumericEdit control was
  created, the dropdown calendar or calculator for it was also created
  at the same time. This could lead to slow loading of forms containing
  multiple C1DateEdit or C1NumericEdit controls. In this version, the
  calendar (calculator) is only created when it is accessed.

  Note regarding existing forms with a large number of C1DateEdit
  controls: in previous versions, several properties on the calendar
  were assigned their default values when a C1DateEdit was dropped on a
  form in the designer. This has been fixed in this build, but forms
  created with previous versions of C1Input would continue to create
  dropdown calendars for all C1DateEdit controls on the form when they
  are loaded. To avoid this for an existing form, remove all lines
  setting properties on the C1DateEdit.Calendar from the form's
  InitializeComponent method unless you specifically need that setting.
  Alternatively, load the form in the designer and make some change,
  then save the form - this will also remove all unnecessary
  assignments.

========================================================================
C1Input for .NET Build 2.0.20073.33106, 31-Dec-2007
========================================================================

Bug fixes
---------

* Fixed several issues with the dropdown calendar when Windows Classic
  visual style was used.

========================================================================
C1Input for .NET Build 2.0.20073.33105, 14-Dec-2007
========================================================================

Bug fixes
---------

* Improved the speed of creating a new instance of C1DateEdit.

========================================================================
C1Input for .NET Build 2.0.20073.33104, 07-Nov-2007
========================================================================

Bug fixes
---------

* Fixed a bug in C1DBNavigator: TargetInvocationException was thrown
  when the navigator's next button was pressed for a long time, and the
  navigator was on a form used as a control on another form.

========================================================================
C1Input for .NET Build 2.0.20073.33103, 29-Oct-2007
========================================================================

* 2007 T3 release.

Bug fixes
---------

* Fixed a design time issue: whenever a form with a C1Input control was
  loaded in the Visual Studio designer, it was marked as changed even
  when there were no changes made to the form.

* Fixed several dropdown calendar-related issues.

New features
------------

* New public property added on C1TextBox:
    public Color DisabledForeColor {get;set;}
      Gets or sets the foreground color of the disabled control.

========================================================================
C1Input for .NET Build 2.0.20072.33013, 23-Aug-2007
========================================================================

Bug fixes
---------

* The Parsing and the Formatting events of C1TextBox control didn't
  fire when the control was used as an editor control in a C1FlexGrid.

========================================================================
C1Input for .NET Build 2.0.20072.33012, 25-Jul-2007
========================================================================

Bug fixes
---------

* Fixed several issues related to the drop-down calendar used by
  C1DateEdit.

  IMPORTANT (potential existing code breaking change): In prior builds,
  the public class DateEditMonthCalendar inherited from
  System.Windows.Forms.MonthCalendar. In order to fix a number of
  issues, it was changed to inherit from ContainerControl. All public
  properties and methods that were inherited from MonthCalendar are now
  implemented in DateEditMonthCalendar. Still, some existing code
  relying on DateEditMonthCalendar inheriting from MonthCalendar may not
  compile now and will require some simple changes to the source code.

========================================================================
C1Input for .NET Build 2.0.20072.33011, 06-Jul-2007
========================================================================

Bug fixes
---------

* Fixed a crash that occurred if any of C1Input controls were used in a
  Japanese locale.

========================================================================
C1Input for .NET Build 2.0.20072.33010, 25-Jun-2007
========================================================================

Bug fixes
---------

* Fixed an issue with serializing the VisualStyle property on C1TextBox,
  C1Label, C1Button or C1DbNavigator when the control was within a C1
  container (e.g. a C1DockingTab) with a set VisualStyle property.

========================================================================
C1Input for .NET Build 2.0.20072.33009, 05-Jun-2007
========================================================================

Bug fixes
---------

* Fixed: In C1DropDownControl and derived controls (C1DateEdit,
  C1NumericEdit), text in the control was offset 1 pixel to the
  right/down relative to C1TextBox. This resulted in clipping the bottom
  of some chars, e.g. "g".

* Fixed: When C1DropDownControl was used in MDI apps, wrong form could
  be activated when the dropdown was closed.

========================================================================
C1Input for .NET Build 2.0.20072.33007, 08-May-2007
========================================================================

Bug fixes
---------

* In a C1TextBox with NumericInput set to true, upon entering the
  control with an initial integer value, pressing the End key and then
  typing the decimal point, the decimal point is not entered. Fixed.

========================================================================
C1Input for .NET Build 2.0.20072.33004, 23-Apr-2007
========================================================================

* 2007 T2 release.

New features
------------

* New control:

    public C1Button : Button.

  Inherits from the standard Windows Forms button control, adds the
  VisualStyle property and support for the Office 2007 visual styles.

* Added support for VisualStyle, which in addition to System, supports
  MS Office 2007 visual styles (blue, silver and black), to C1TextBox,
  C1Label, C1DbNavigator, C1DropDownControl, C1DateEdit (including the
  drop down calendar) and C1NumericEdit (including the drop down
  calculator).

* New public enum: VisualStyle, with the following allowed values:
  - Custom
  - System
  - Office2007Blue
  - Office2007Silver
  - Office2007Black

* New public property on C1TextBox, C1Label, C1DbNavigator,
  C1DropDownControl, C1DateEdit, C1NumericEdit:

    VisualStyle VisualStyle {get;set;}
      Gets or sets the visual style of the control.

* New public event on C1TextBox, C1Label, C1DbNavigator,
  C1DropDownControl, C1DateEdit, C1NumericEdit:

    event EventHandler VisualStyleChanged {add;remove;}
      Occurs when the VisualStyle property has changed.

* New protected method on C1TextBox, C1Label, C1DbNavigator,
  C1DropDownControl, C1DateEdit, C1NumericEdit:

    protected virtual void OnVisualStyleChanged(EventArgs e);
      Invokes the VisualStyleChanged event.

========================================================================
C1Input for .NET Build 2.0.20071.32003, 08-Feb-2007
========================================================================

* No changes in this build.

========================================================================
C1Input for .NET Build 2.0.20071.32002, 21-Dec-2006
========================================================================

* When a dropdown form (e.g. calendar) is opened, if it would hit bottom
  of screen, the form opens above the control instead of below (before,
  it was shifted just a bit up to fit in screen).

========================================================================
C1Input for .NET Build 2.0.20071.32001, 10-Oct-2006
========================================================================

* 2007 T1 release.

========================================================================
C1Input for .NET Build 2.0.20063.31002, 10-Oct-2006
========================================================================

* Fixed: C1TextBox.BackColor was ignored if ReadOnly were true.

========================================================================
C1Input for .NET Build 2.0.20063.31001, 26-Jul-2006
========================================================================

* T3 2006 release.

* The behavior of Margin and Padding properties of C1TextBox and
  inherited controls is now consistent with the standard .NET 2.0
  behavior.

========================================================================
C1Input for .NET Build 2.0.20062.30142, 21-Mar-2006
========================================================================

* Added the AllowPartiallyTrustedCallers attribute to the assembly.

* Fixed: if MaxLength was specified for a C1TextBox, and the textbox
  contained that number of chars, and they were selected, typing did not
  replace the selection.

* Fixed: changing the Font property was ignored on C1TextBox.

========================================================================
C1Input for .NET Build 2.0.20062.30141, 16-Feb-2006
========================================================================

* T2 2006 release.

* In a multiline C1TextBox, the text was shifted 1 pixel up/left as
  opposed to a single-line text box. This was especially noticeable
  when the text box showed the focus rectangle (as it interfered
  with the caret).

========================================================================
C1Input for .NET Build 2.0.20061.30139, 29-Dec-2005
========================================================================

* T1 2006 release.

========================================================================
C1Input for .NET Build 2.0.20053.30138, 29-Dec-2005
========================================================================

* When a C1TextBox was bound to a data source, and then recevied and
  lost focus, the data set was always updated, even if no changes were
  made in the text box. The issue is .NET 2.0 specific, and is related
  to the new in .NET 2.0 PropertyDescriptor.SupportsChangeEvents
  property. Fixed.

========================================================================
C1Input for .NET Build 2.0.20053.30131, 5-Dec-2005
========================================================================

* Miscellaneous bug fixes.

========================================================================
C1Input for .NET Build 2.0.20053.29911, 3-Nov-2005
========================================================================

* First public .NET 2.x release.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
The End.
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
