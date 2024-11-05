=================================================================================
C1TrueDBGrid Build Number 2/4.0.20142.61406,   Build Date September 11, 2014
=================================================================================

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
85178 Auto-set C1TrueDBGrid.PrintInfo.VarRowHeight:
      - On set PrintInfo.WrapText to NoWrap VarRowHeight is set to LikeGrid.
	  - On set PrintInfo.WrapText to Wrap VarRowHeight is set to StretchToFit.


=================================================================================
C1TrueDBGrid Build Number 2/4.0.20142.61405,   Build Date September 11, 2014
=================================================================================

Corrections    
--------------------------------------------------------
10661 'CellTipsWidth' property setting does not have effect
86717 Setting of CellTipsWidth does not become effective.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20142.61404,   Build Date August 28, 2014
=================================================================================

Corrections    
--------------------------------------------------------
82018 TrueDBGrid - Can't click on filter columns when column is frozen.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20142.61403,   Build Date August 27, 2014
=================================================================================

Corrections    
--------------------------------------------------------
82660 When a cell chip is displayed on the column header which WrapText is set to False, 
the cell chip will become longwise unusually.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20142.61402,   Build Date August 19, 2014
=================================================================================

Corrections    
--------------------------------------------------------
78902: When the Locked property of Split is changed, the ComboBox column using 
ValueItems carries out incorrectly.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20142.61401
=================================================================================

Corrections    
--------------------------------------------------------
75883: Column data disappear when rebinding the grid with focus in the filter row.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20142.61400
=================================================================================

Corrections    
--------------------------------------------------------
62882: Unable to resize Column's width using Column divider when groupby in designer.
64616: True DBGrid +/- grouping icons oversized when screen display is greater than 100%
60873: ArgumentOutOfRangeException is thrown with all the grid rows hidden
60885:[Forum] Cast error is thrown on trying to set the 'FilterText' of a column in C1TrueDBDropDown
68196: Exception occurs on clicking Filter button
69578: 'InvalidCastException' is observed when 'FilterDefinition' is saved to string & then set again
68064: Records in a column disappear on rebinding TrueDBGrid at runtime
65603: Layout does not save Column Positions during ColMove event
(ColMove event was fired BEFORE adjusting columns according to the move).
67252: WF True DBGrid TreeView collapses with Sorting

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20141.61352,   Build Date May 27, 2014
=================================================================================

* 67788 Impossible to set filter through code.
 
=================================================================================
C1TrueDBGrid Build Number 2/4.0.20141.61351,   Build Date May 22, 2014
=================================================================================

Corrections    
--------------------------------------------------------
* 60633 Unwanted blank row space is observed with EmptyRows set to True and all 
the rows visibility set to False.
* 61302 Calling  the 'SetDatBinding' method clears the 'FilterText' in C1TrueDBGrid.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20141.61349,   Build Date 
=================================================================================

Corrections    
--------------------------------------------------------
* 49769 Filter is not cleared for the first C1DisplayColumn of C1TrueDBGrid when 
the data type of Column is string or boolean.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20141.61348,   Build Date March 31, 2014
=================================================================================

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
 * Text property is hidden from properties window since 
 this member is not meaningful for this control.

** POSSIBLE BREAKING CHANGE **
New boolean property UseCompatibleTextRendering.

This property determines whether the control should render text using the Graphics 
class (compatible with previous versions), or the TextRenderer class 
(available in .NET 2.0 and later)

The TextRenderer class supports complex scripts and Uniscribe APIs, making 
it better suited for some international applications

However, the TextRenderer class seems to render about 25% slower than the 
traditional method.

You may want to try both modes and select the one that matches the appearance of other 
controls and forms in your application.

This resolves issues 60888, 60186. 

Corrections    
--------------------------------------------------------
* 61584: [2.0 DLL] [TrueDBGrid]: On displaying sort indicator, character on right end of caption disappears.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20141.61347,   Build Date March 13, 2014
=================================================================================

Corrections    
--------------------------------------------------------
* 43086 [35745-139] BeforeColUpdate event is fired if the focus is on a cell of Enabled CheckBox Column and a cell 
of Disabled CheckBox Column is clicked CheckBox.
* 51794 Application is hang and data are not shown properly when changing of different data by using SetDataBinding() 
with keepPosition=True.
* 51812 ArgumentOutOfRange exception occurrs in changing of DataSource in grouped C1TureDBGrid by using SetDataBinding() 
with keepPosition =True
* 51890 Filter can be set to the same column while FilterDropdown of previous filter keeps opening due to invalid value
* 51863 SetDataBinding() does not clear Filter icon in ColumnHeader or FilterText in FilterBar
* 52040 Case3  

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20141.61345,   Build Date March 4, 2014
=================================================================================

Corrections    
--------------------------------------------------------
* 51880 [39471] ColumnHeader's caption is clipped  if it has two words with space & column is resized 
using double clicking divider.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20141.61344,   Build Date February 12, 2014
=================================================================================

* New parameter keepPosition for SetDataBinding method.
Set it to true if you want to keep expanded goups in GroupBy mode.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20141.61343,   Build Date February 10, 2014
=================================================================================

* Misc Theme-related changes.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20133.61342,   Build Date January 23, 2014
=================================================================================

Corrections    
--------------------------------------------------------
* 27369 “AutoDropDown” is not display properly when the same cell is in focus and edited twice without changing 
the focus to another cell.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20133.61341,   Build Date January 22, 2014
=================================================================================

Corrections    
--------------------------------------------------------
* 47506 Misc issues using some custom editors in IME mode.
* 18663 If the cursor is placed  by double clicking the cell, no digit can not be entered in cell with Mask set.
* 49304 Edit Mode of C1TrueDBGrid does not show Focus cursor and Text Selection at that cell.

===========================================-======================================
C1TrueDBGrid Build Number 2/4.0.20133.61336,   Build Date December 18, 2013
=================================================================================

Enhancements/Documentation/Behavior Changes   
--------------------------------------------------------
 New property and a method of C1TrueDbGrid:
        
		/// Gets a top-level object bound to a current  data row.
		public object CurrentDataBoundItem { get; }

        /// Gets a top-level object bound to the specified view row.
        public object GetDataBoundItem(int viewrow)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20133.61335,   Build Date November 22, 2013
=================================================================================

Corrections    
--------------------------------------------------------
* 'Ellipsis' is shown in a cell when a 'ForegroundImage' property is set for the cell 
and the text length is less than 4 in C1TrueDBGrid. (45698)
* The blank area gets enlarged when splitter line is moved if SplitDividerSize 
property is set to a value other than the existing value. (45946)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20133.61334,   Build Date November 19, 2013
=================================================================================

Corrections    
--------------------------------------------------------
* Obfuscation issue: 
  Adding C1TrueDbGrid on the form at design time gives Exception.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20133.61333,   Build Date November 1st, 2013
=================================================================================

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
** POSSIBLE BREAKING CHANGE **
* Background and foreground colors of heading and record selectors in the Form view
are defined by Heading and RecordSelector styles.
They were always Blue/White before.

* VisualStyle support in Theming.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20133.61332,   Build Date October 28, 2013
=================================================================================

Corrections    
--------------------------------------------------------
* Theming issue - BackColor & RowDivider properties.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20133.61331,   Build Date October 16, 2013
=================================================================================

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
* C1Theme support for C1TrueDBDropdown control. 

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20133.61329,   Build Date October 13, 2013
=================================================================================

Corrections    
--------------------------------------------------------
* An obfuscation/theming issue.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20133.61328,   Build Date October 11, 2013
=================================================================================

* 2013 v3 Build

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
* C1Theme support. Both C1TrueDbGrid and C1TrueDBDropdown controls are supported in the C1ThemeDesigner application. 
  That allows to use default C1 themes or custom ones and to apply them on application level.


* Expand/Collapse events is fired on collapse/expand group in GroupBy view.
e.Band is the group row index.
e.Cancel can be used to cancel expand/collapse operation.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20132.61318,   Build Date September, 26 2013
=================================================================================

Corrections    
--------------------------------------------------------
* DropDown appears by pressing [Alt + Down Arrow] although 'AutoDropDown=False' 
and 'FilterDropdown=False' are set. (42558)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20132.61317,   Build Date September, 13 2013
=================================================================================

Corrections    
--------------------------------------------------------
* Filterdropdown is still appear in certain scenarios although setting “FilterDropDown” property to false. (15831)
* Some options are missing in the Input Mask dialogue box. (41687)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20132.61316,   Build Date August, 9 2013
=================================================================================

Corrections    
--------------------------------------------------------
* When a column is moved in multi lines display (MultipleLinesFixed), it goes to one column before 
the specified column. (40056)
* Setting AutoDropDown to False does not prevent opening dropdown automatically. (21912)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20132.61315,   Build Date July, 18 2013
=================================================================================

Corrections    
--------------------------------------------------------
*  'RowColChange' event doesn't fire when clicking the cell of FilterBar at 'GroupBy' view. (39953)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20132.61314,   Build Date July, 16 2013
=================================================================================

Corrections    
--------------------------------------------------------
* In the RowColChange event fired on the filterbar, the Col property value shows the column 
number before moving. (38520)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20132.61313,   Build Date July, 11 2013
=================================================================================

Corrections    
--------------------------------------------------------
  * Misc issues with Tab navigation. (37676)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20132.61312,   Build Date July, 11 2013
=================================================================================

Corrections    
--------------------------------------------------------
  * Some data are displayed at Record selector column. (36445, 36524, 39435)
  * Pressing EnterKey does not navigate through the grid after selcting entry one entry in the AutoDropDown. (39157)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20132.61311,   Build Date July, 3 2013
=================================================================================

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
  * XLSX (Office2007) format is used in ExportToExcel() function if the file name has "xlsx" extention. 
    This makes it possible to export more than 255 columns and more than 65K rows. (10926)
  
  * ColContaining method overload: 
  public int ColContaining(Point p)
  Use this method to determine the column index for the column containing the specified point in multiple lines grid.

Corrections    
--------------------------------------------------------
   * Added a few missed JPN property & event descriptions. (34245)
   * When exporting with 'OnePagePerSheet'  option to excel file, 
   the exported excel does not show complete data. (30161)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20132.61310,   Build Date Jun, 7 2013
=================================================================================

Corrections    
--------------------------------------------------------
* Focus is lost for the current cell when using Tab Key for Column Navigation in 
the Last Column. (related 28850)
* Issues are observed in when grid is bound to list items containing 
VbCrLf character. (36644)
* While Form.TopMost=True, opening of C1TrueDBGridDropdown hides Current Form 
and shows opened forms behind it  with the dropdown box. (35847)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20132.61309,   Build Date Jun, 7 2013
=================================================================================

Corrections    
--------------------------------------------------------
* Exception is observed on moving Unbound columns before the bound columns 
in grouped grid. (37344)
* Clicking the arrows of the Scrollbar gets wrong values in e.OldValue property 
of Scroll Event in C1TruedbGrid. (32278)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20132.61308,   Build Date Jun, 5 2013
=================================================================================

2013 v2 Build

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20131.61307,   Build Date May, 10 2013
=================================================================================

Corrections    
--------------------------------------------------------
* Windows freezes when hitting 'Tab' key in grid filter. (33192)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20131.61306,   Build Date May, 8 2013
=================================================================================

Corrections    
--------------------------------------------------------
* Bold Grouped Header row Data appears slightly condensed towards the end of text. (35785)
Note: This fix works only in 4.0.xxxxx.xxx version and does not work in .Net 2.0.
* SelectionRows collection values are not updated according the user selection. (35529)

POSSIBLE BREAKING CHANGE!
* If the EditorStyle is not explicitly set, then at the time of editing, 
the HighLightRowStyle setting remains applied. (36007)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20131.61305,   Build Date May, 6 2013
=================================================================================

Corrections    
--------------------------------------------------------
* ViewRow.DataRowIndex does not work in Normal DataView. (26797)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20131.61304,   Build Date April, 23 2013
=================================================================================

Corrections    
--------------------------------------------------------
*  The horizontal scroll operation in case of multi-line display differs 
with normal operation. (35541)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20131.61303,   Build Date April, 20 2013
=================================================================================

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
* New property ViewRow.DataRowIndex. (26797)

In FetchCellStyle and FetchRowStyle events e.Row returns view row index.
In normal mode, in matches to data row index.

But in GroupBy mode it does not.

To translate view row index to data row index use the new ViewRow.DataRowIndex 
property.

Example:
        private void c1TrueDBGrid1_FetchCellStyle(object sender, C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs e)
        {
            ViewRow row = this.c1TrueDBGrid1.Splits[0].Rows[e.Row];
            if (row.RowType == RowTypeEnum.DataRow)
            {
				// use the data row index
                bool val = (bool)this.c1TrueDBGrid1[row.DataRowIndex, 3];
                if (val == true)
                    e.CellStyle.BackColor = Color.Red;
            }
        }

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20131.61302,   Build Date April, 11 2013
=================================================================================

Corrections    
--------------------------------------------------------
* On setting Editmask property, the new line code gets pasted as "0". (35369)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20131.61301,   Build Date April, 5 2013
=================================================================================

Corrections    
--------------------------------------------------------
*  “AutoDropDown” is not display properly when the same cell is in focus and 
edited twice without changing the focus to another cell. (27369)
* A change to resolve 24013.
* While MarqueeStyle is set to 'FloatingEditor' ,FetchRowStyle & FetchCellStyle 
events are getting fired. (34235)
* While MarqueeStyle is set to 'FloatingEditor' and click twice to locked column,
the text "False" (or "True") is  displayed. (30488)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20131.61299,   Build Date March, 19 2013
=================================================================================

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
* C1TrueDbGrid now supports ArrayList type in hierarchical data sources (ITypedList). (34382)
 
=================================================================================
C1TrueDBGrid Build Number 2/4.0.20131.61298,   Build Date February, 9 2013
=================================================================================

Corrections    
--------------------------------------------------------
* ArgumentOutOfRangeException is observed after loading the saved xml 
layout in another grid and this layout is save again as xml and loaded again. (24013)
* C1TrudDBDropdown missing values after applying the filter and clear the filter. (33547) 
 
- Potentially BREAKING CHANGE:    
--------------------------------------------------------
* If selected rows added or removed by code,
the selection change can not be canceled in SelChange event.

Example:

Sub AddRowToSelection(row As Integer)
  Grid.SelectedRows.Add(row)
End Sub

' In builds 61252 - 61297 the code below cancels selection change made in AddRowToSelection function
' In builds 61298 and above the code does not cancel the selection change even if e.Cancel set to True
Private Sub Grid_SelChange(sender As Object, e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles Grid.SelChange
    e.Cancel = True
End Sub

This change fixes issue 33545.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20131.61297,   Build Date January, 28 2013
=================================================================================

2013 v1.

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
* (33503) new property
    string BaseGridView.FilterDefinition
Gets or sets an XML string containing the current filter state.

Remark: 
  FilterDefinition property works only with FlexGrid-like (or Excel-like) filtering.

Using:
     // to save filter
	string oldFilter = this.c1TrueDBGrid1.Splits[0].FilterDefinition;
    // To restore filter
    c1TrueDBGrid1.Splits[0].FilterDefinition = oldFilter;

Added CS sample: 
    FilterDefinitionTdbg

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20123.61296,   Build Date January, 15 2013
=================================================================================

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
Potentially BREAKING CHANGES:    
* Last column can not be grouped in GroupByView. (32142)

Corrections    
--------------------------------------------------------
* Horizontal scrollbar disappear when loading the data using SetDataBinding method 
and setting holdsFields to true. (31341)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20123.61295,   Build Date January, 14 2013
=================================================================================

Corrections    
--------------------------------------------------------
* Unlike previous build, applied filter is not updated in filter drop down 
for ‘Radio Button’ column. (33076)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20123.61294,   Build Date January, 10 2013
=================================================================================

Corrections    
--------------------------------------------------------
* While MarqueeStyle is set to 'FloatingEditor' and click twice to locked column,
the text "False" (or "True") is  displayed. (30488)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20123.61293,   Build Date January, 9 2013
=================================================================================

Corrections    
--------------------------------------------------------
* If the height of the caption is changed after grouping, the height does not get 
changed appropriately. (31362)

 
=================================================================================
C1TrueDBGrid Build Number 2/4.0.20123.61292,   Build Date January, 3 2013
=================================================================================

- Potentially BREAKING CHANGES:    
--------------------------------------------------------
* Filter-related:
1. C1DisplayColumn.FilterText is set to "" after condition filter is applied.
2. C1DisplayColumn.FilterText is set to comma separated list of values after value filter is applied.
Related issue is #31377.

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20123.61291,   Build Date December 18, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
* Sorted grid selects the row that is previously edited before the row is sorted.
(23524)

Corrections    
--------------------------------------------------------
* Applying filter to c1TrueDBGrid via code, filter icon is not shown and applied 
filter is not updated in FilterDropDown. (31377)
* Floating editor is hidden on Tab navigation when AllowUpdate is False and 
MarqueeStyle is FloatingEditor. (15849)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20123.61288,   Build Date December 16, 2012
=================================================================================

Corrections    
--------------------------------------------------------
* Exception is observed when same layout is loaded in a C1TrueDBGrid multiple times. (28894)
* Some Shortcuts like Ctrl+I & Ctrl+M are intercepted by C1TrueDBGrid. (30878)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20123.61287,   Build Date November 21, 2012
=================================================================================

Corrections    
--------------------------------------------------------
* Messagebox [Syntax error: The IN keyword must be followed ...] is shown twice when 
typing into filterbar of DateTime column. (30159)
* Grid is not cleared by de-selecting all filter items in ‘DateTime’ column and 
'Boolean' column. (27701)

=================================================================================
C1TrueDBGrid Build Number 2/4.0.20123.61284,   Build Date November 19, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
* Default filter operator for multiple select string columns is 'IN'.
In previous versions it was 'IN' operator if more than one values are selected 
in the combo box and "field LIKE 'VALUE%'" if only single value is selected 
in the combo box. (30042 case 2)
  New possible values for columns with STRING data types:
    "like" - acts as "field LIKE 'VALUE'"
	"like%" -  acts as "field LIKE 'VALUE%'"
	"%like" -  acts as "field LIKE '%VALUE'"
	"%like%" -  acts as "field LIKE '%VALUE%'"

Corrections    
--------------------------------------------------------
* Conditional Filter does not work if applied with the value that is not available 
in the DataTime column having format as "dd/MM/yyyy". (27434)
* Changing of DataSource and clicking of 'Column Tasks' link, 
throw Object Reference exception. (30109)

=================================================================================
C1TrueDBGrid Build Number 2.0.20123.61283/4.0.20123.61283 November 17, 2012
=================================================================================

Corrections    
--------------------------------------------------------
* When VScrollBar.Style property is set to "Always", if DataView property is changed 
to MultipleLines, then an error may occur. (28181)

=================================================================================
C1TrueDBGrid Build Number 2.0.20123.61282/4.0.20123.61282 November 16, 2012
=================================================================================

Corrections    
--------------------------------------------------------
*  Listbox of filter items is not correctly displayed in filter dropdown. (30042)
* Horizontal scrollbar and vertical scrollbar are not displayed even 
if the data content are beyond its border. (30046)
*  Filtering from filterbar does not work if the cell value contains "(null)" value. (30047)

=================================================================================
C1TrueDBGrid Build Number 2.0.20123.61281/4.0.20123.61281 November 15, 2012
=================================================================================

Corrections    
--------------------------------------------------------
*  If ‘DataView’ is set to ‘MultipleLines’, column headers are disappeared at run time. (29990)

=================================================================================
C1TrueDBGrid Build Number 2.0.20123.61280/4.0.20123.61280 November 13, 2012
=================================================================================

Corrections    
--------------------------------------------------------
* [Localization]ArgumentException is occurred when ‘C1TrueDBGrid’ is data bound and UI language 
is Japanese or Chinese. (30035)
* Filtering does not work if the cell value is "" (empty string). (29383)
* RowColChange event does not fire when focus is moved to another split. (30009)

=================================================================================
C1TrueDBGrid Build Number 2.0.20123.61279/4.0.20123.61279 November 13, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
* Added Chinese/Japanese/Korean translations for some properties/events missed in the previous build. 
(29396, 29405)

Corrections    
--------------------------------------------------------
* Filtering does not work if the cell value contains "(null)" value. (29383)
* Filtering does not work when typing the text and pressing "Enter" key in filter bar 
if filter dropdown is opening. (29389)
*  NullReferenceException occurs on double clicking the C1TrueDBGrid if all columns 
are placed in GroupBy area. (28968)

=================================================================================
C1TrueDBGrid Build Number 2.0.20123.61278/4.0.20123.61278 November 12, 2012
=================================================================================

Corrections    
--------------------------------------------------------
 * Incorrect values are returned for  “Col” and “e.LastCol” properties in the 
 RowColChangeEvent of the grid if the grid contain Splits. (29202) 

=================================================================================
C1TrueDBGrid Build Number 2.0.20123.61277/4.0.20123.61277 November 5, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
 * All localizations including design time depend on CurrentUICulture.
 It was CurrentCulture before this build.
 * Added localization for simplified Chinese. 
 Used if the CurrentUICulture name is starting with "ko".

Corrections    
--------------------------------------------------------
 * With simplified Chinese localization, the Designer dialog is not localized. (29397)

=================================================================================
C1TrueDBGrid Build Number 2.0.20123.61276/4.0.20123.61276 November 1, 2012
=================================================================================

Corrections    
--------------------------------------------------------
  * Data are changed when user selected the cell in C1TrueDBGrid with DataView 
  set as "Form". (24712)
  * Filter Icon become stretched when the columnCaptionHeight in the grid 
  is increased. (27882)

=================================================================================
C1TrueDBGrid Build Number 2.0.20123.61275/4.0.20123.61275 October 25, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
 * Support of null values in 'FilterDropDown' list. (19142)
 * Added localization for simplified Chinese. 
 Used if the CurrentUICulture name is starting with "zh".

=================================================================================
C1TrueDBGrid Build Number 2.0.20123.61274/4.0.20123.61274 October 23, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------

  * Change in Designer - now grid fills the all available area of designer surface 
  independently on what size the grid takes on the form. (24682)

Corrections    
--------------------------------------------------------
  * The height of column header does not get adjusted automatically when printing. (28714)

=================================================================================
C1TrueDBGrid Build Number 2.0.20123.61273/4.0.20123.61273 October 16, 2012
=================================================================================

2012 v3.

Corrections    
--------------------------------------------------------
* Some internal fields serialized on SaveLayout.

=================================================================================
C1TrueDBGrid Build Number 2.0.20122.61272/4.0.20122.61272 September 22, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
   * New event SplitAdded - occurs when a split is added.

Corrections    
--------------------------------------------------------
   * SplitChange event gets fired when split is deleted. (27592)
   * Exception is observed on adding new rows in a custom grid in Windows Classic theme. (28430)

=================================================================================
C1TrueDBGrid Build Number 2.0.20122.61271/4.0.20122.61271 September 21, 2012
=================================================================================
Corrections    
--------------------------------------------------------
   * Error may occur when split is added using the SplitBox at runtime. (27591)

=================================================================================
C1TrueDBGrid Build Number 2.0.20122.61270/4.0.20122.61270 September 19, 2012
=================================================================================
Corrections    
--------------------------------------------------------
  * (re-fix) “CellStyle.Locked” property is not working in “FetchRowStyle” event. (26374)

=================================================================================
C1TrueDBGrid Build Number 2.0.20122.61269/4.0.20122.61269 September 18, 2012
=================================================================================
Corrections    
--------------------------------------------------------
  * ArgumentOutOfRangeException is observed after loading the saved xml layout 
  in another grid and this layout is save again as xml and loaded again. (24013)
  * “ArgumentException” was thrown after starting a multiple forms on separate thread. (20970)

=================================================================================
C1TrueDBGrid Build Number 2.0.20122.61267/4.0.20122.61267 September 7, 2012
=================================================================================
Corrections    
--------------------------------------------------------
  * Dropdown opens to the bottom right for Frozen cells. (27350)

=================================================================================
C1TrueDBGrid Build Number 2.0.20122.61266/4.0.20122.61266 September 3, 2012
=================================================================================
Corrections    
--------------------------------------------------------
  * [VS2012] Different Toolbox icons are observed for FW 2.0 and 4.0 versions (27495).

=================================================================================
C1TrueDBGrid Build Number 2.0.20122.61264/4.0.20122.61264 August 28, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
  * New method of C1DisplayColumn:
      GetFilterExpression()
  It helps to build filter expressions for custom filtering.
  * Allowed copy to clipboard operation in AllowUpdate = False grid. 
  This works if MarqueeStyle is FloatingEditor. (15849)

Corrections    
--------------------------------------------------------
  * Added Metro-style toolbox icons.
  * Copyright/company message of "C1.Win.C1TrueDBGrid.4.Design.dll" is updated to 
  "GrapeCity, Inc". (24334)
  * Multiple issues are observed when C1TrueDbDropDown rendering. (22299)
  * TrueDBGrid Not Allowing Custom Filtering in some cases. (24072)
  * Conditional Filtering is not working in the custom filtered grid (20271)

=================================================================================
C1TrueDBGrid Build Number 2.0.20122.61262/4.0.20122.61262 July 22, 2012
=================================================================================

Corrections/Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
*  [Enhancement] DataField property of C1DataColumn case-insensitive now. (24263)


=================================================================================
C1TrueDBGrid Build Number 2.0.20122.61261/4.0.20122.61261 July 14, 2012
=================================================================================

Corrections
-------------------------------------------
* Vertical scrollbar of the form is scroll along with the grid’s scrollbar when 
using mouse scroll button to scroll it. (23744)
* Error message is shown when filter is applied on DateTime column. (21213)
* Cell value cannot be deleted in C1TrueDBGrid's column which is bounded to the 
C1TrueDBDropdown. (21441)
* Cell value is not displayed in edit mode if EditMask is set in C1TrueDBGrid. (21235)
* When C1TrueDBGrid is placed on RibbonForm and Custom VisualStyle is set at design time, 
then style settings are not updated. (21510)
* DisplayColumn.Style.Padding does not work for radio, checkbox and translate value 
items columns. 
Note: 
Always create a new System.Drawing.Printing.Margins object if you set a column padding,
like this:
  c1TrueDBGrid1.Splits[0].DisplayColumns[0].Style.Padding = new System.Drawing.Printing.Margins(5, 5, 5, 5);
The code below won't work, it's a limitation: (related issue 23095)
  c1TrueDBGrid1.Splits[0].DisplayColumns[0].Style.Padding.Top = 5; 



=================================================================================
C1TrueDBGrid Build Number 2.0.20122.61260/4.0.20122.61260 July 9, 2012
=================================================================================

Corrections
-------------------------------------------
* updated AssemblyCompany and AssemblyCopyright attributes and about box.

=================================================================================
C1TrueDBGrid Build Number 2.0.20122.61259/4.0.20122.61259 June 18, 2012
=================================================================================

Corrections/Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
*BREAKING CHANGE* Style.WrapText has effect for radio button presentation. 
If it's FALSE then radio buttons placed horizontally (in one line).
* C1TrueDBGrid designer close after clicking on the column header when setting 
“DataView” property to “MultipleLines”. (18792)
* When font size of RadioButton is increased, the vertical alignment is not correctly 
reflected (23094).
* After Merge of a Column is changed C1TrueDbGrid is not refreshed. (23218)
* Value gets multiplied by 100 after selecting the whole text when the “NumberFormat” 
property of a Column is set to “P2” (23236)
*  Data are disappear when new row is added and existing row is hidden at run time 
in “Form” DataView of the grid. (18875)
* If user enters invalid input then error icon is shown and clicking Cancel/Clear 
does not close the Filter Form. (23037)

=================================================================================
C1TrueDBGrid Build Number 2.0.20122.61258/4.0.20122.61258 May 6, 2012
=================================================================================

Corrections/Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
 * [Regression] Application hangs on setting LinesPerRow property. (23192)

=================================================================================
C1TrueDBGrid Build Number 2.0.20122.61257/4.0.20122.61257 May 6, 2012
=================================================================================

Corrections/Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
 * After setting the DataView to 'MultipleLinesFixed', 
 only 2 rows are displayed even if "LinesPerRow" is set to above 3. (22317)

=================================================================================
C1TrueDBGrid Build Number 2.0.20122.61256/4.0.20122.61256 May 4, 2012
=================================================================================

2012 v2.

Corrections/Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
  * NullReferenceException occurs when PrintInfo.PrintPreview is called in German 
  environment. (22877)

=================================================================================
C1TrueDBGrid Build Number 2.0.20121.61254/4.0.20121.61254 Apr 27, 2012
=================================================================================

Corrections/Enhancements/Documentation/Behavior Changes 
--------------------------------------------------------
  * BREAKING CHANGE *
  C1TrueDBDropdown is opening right under cell's combo button,
  not under the row.  

  This behavior change fixes issue #15945:
  * The dropdown appears outside the parent form when grid’s row height is greater 
  than form’s  height.

=================================================================================
C1TrueDBGrid Build Number 2.0.20121.61253/4.0.20121.61253 Apr 11, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
  * Added localization for TrueDBGrid Print/Export Options form to German and Russian.
  (18835)
  
  * There is a limitation in C1TrueDbGrid: Condition filters can not be applied to 
  columns with translated values. 
	But in the previous builds the "Text" button (enter the Condition Filter mode) 
  was enabled.
	In the 61253 build this button is disabled to avoid confusion. (20666)


Corrections
-----------
  * Flat FilterBarBorder is shown although Standard FlatStyle is set (21200).
  * When filter-bar is set in multiple row display, the display of dividing line 
  below the filter-bar differs depending upon the number of sub-rows. (20903)
  * Cannot move to another row even after confirming the cell edit by pressing 
  the Enter key or DOWN key. (20908)
  * The checkbox column in the grid is not exported as checkbox image when exporting 
  to html format or  any other format. (20903)
  * 
=================================================================================
C1TrueDBGrid Build Number 2.0.20121.61252/4.0.20121.61252 Mar 14, 2012
=================================================================================

Corrections
-----------
  * StackOverflowException is raised on selecting the row and calling SelChange event. 
  (20469)

Note: Code of MultipleSelection sample is changed, since SelChange behavior was changed in 
build 61251

=================================================================================
C1TrueDBGrid Build Number 2.0.20121.61251/4.0.20121.61251 Mar 9, 2012
=================================================================================

Corrections
-----------
- Potentially BREAKING CHANGES:    
--------------------------------------------------------
  * “SelChange” event does not fired after  “Selected rows” are changed by code. 
  (15185)

  

=================================================================================
C1TrueDBGrid Build Number 2.0.20121.61250/4.0.20121.61250 Mar 9, 2012
=================================================================================

Corrections
-----------
  * Unlike previous build, "EnableDateTimeEditor" property does not work. (20299)
  * Unlike previous build, millisecond values cannot be edited. (20309)
  * Vertical Scrollbar of C1TrueDBDropdown appears on right instead of left when 
  'RightToLeft' property is set to true. (19770)

=================================================================================
C1TrueDBGrid Build Number 2.0.20121.61249/4.0.20121.61249 Mar 1, 2012
=================================================================================

Corrections
-----------
  * First column is removed after removing the last column which is hidden 
  in the designer. (19486)
  * ArgumentException is thrown after clicking filter icon in the Conditional 
  filtering in certain scenarios. (19221)
  * Month disappear after focusing on the date column when “EditMask” and 
  “NumberFormat” are set. (19323)
  * RowColChange event fire for every split present in C1TrueDBGrid. (19978)
  * DestinationRow and DestinationCol properties are not correctly updated in 
  BeforeRowColChange event if the row column is changed. (20127) 

=================================================================================
C1TrueDBGrid Build Number 2.0.20121.61248/4.0.20121.61248 Feb 23, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
  * 'IN' operator is available to use in C1DataColumn.FilterOperator.
  The 'IN' operator is now default for filters if FilterMultiSelect for
  the column is True, and more than one value is selected. 
  This fixes issue #19429.

=================================================================================
C1TrueDBGrid Build Number 2.0.20121.61247/4.0.20121.61247 Feb 6, 2012
=================================================================================

Corrections
-----------
  * [9795-139] Existing column is overlap after setting visible property to true 
  for invisible column in “MultipleLinesFixed” dataview of the grid. (18873)

=================================================================================
C1TrueDBGrid Build Number 2.0.20121.61246/4.0.20121.61246 Jan 24, 2012
=================================================================================

Corrections
-----------
  * [4956-139]FilterDropDown is not display by clicking DropDownButton, 
  after clicking one of the “locked” cell. (15323)

=================================================================================
C1TrueDBGrid Build Number 2.0.20113.61244/4.0.20113.61244 Jan 15, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
  * Initial sort direction of grouped columns. (TFS 18211).
  Before this build on moving a column in the group area, this column was sorted 
  in ascending order. Since build 61244 this order can be changed to descending  
  order in GroupColMove event.

  Example:
  // When user move the "Last" column to the group area,
  // it will be initially sorted in Descending order.
  void c1TrueDBGrid1_GroupColMove(object sender, C1.Win.C1TrueDBGrid.GroupColMoveEventArgs e)
  {
       if (e.Column.Name == "Last")
       {
           e.Column.DataColumn.SortDirection =  C1.Win.C1TrueDBGrid.SortDirEnum.Descending;
       }
  }

=================================================================================
C1TrueDBGrid Build Number 2.0.20121.61244/4.0.20121.61244 Jan 2, 2012
=================================================================================

2012 v1 Release.

=================================================================================
C1TrueDBGrid Build Number 2.0.20113.61243/4.0.20113.61243 Jan 2, 2012
=================================================================================

Corrections
-----------
  * [9900-139] There is no difference of page size between landscape and portrait 
  mode when exporting to pdf files  where there is no printers installed. (19105)
  * [9724-139][Regression] 'System.StackOverflowException ' is observed when grid 
  is changed to normal data view in certain scenarios. (18986)
  * [8023-139][Regression]Design error is observed after setting “MarqueeStyle” 
  at design time and save and close the form and reopen the form again. (18550)
  * [9504-139] “Specified cast is not valid” error is observed when two or more 
  filter items are selected in C1TrueDBGrid after binding with C1DataSource. (18784)
  * [Forum][9326-139][Regression] “ArgumentOutOfRangeException” is observed after 
  “EanbledDateTimeEditor” property is set to false and “EditMask” property is set. (18683)
  * [C1TrueDBGrid] On setting the NumberFormat property and EditMask property, 
  Dates can only be entered upto 2 digits. (18663)

=================================================================================
C1TrueDBGrid Build Number 2.0.20113.61242/4.0.20113.61242
=================================================================================

Corrections
-----------
  * Conditional filtering triggers sort if Windows Classic color theme is set 
  in operating system.(18824)
  * If you set Translate to True, the background of the column gets the same 
  gradation as the column header. (18082)
  * On setting the NumberFormat property and EditMask property, Dates can only be 
  entered upto 2 digits. (18663)
  * An Error “Syntax error: Missing operand after ‘=’ operator” is  occur after 
  filtering in datetime column in certain scenarios. (16045)
  Note: 
	If “Equal”, "GreaterThan", "GreaterThanOrEqualTo", "LessThan" or "LessThanOrEqualTo" 
	condition is set in “Date Filter” without entering any date as the parameter, 
	then we act as we had " January 1, 0001" parameter for compare operations. 
  * 'RemoveFilter()' method of the BindingSource doesn't remove the checkbox from 
  the right of ColumnHeader even on removing filtering. (18640)

=================================================================================
C1TrueDBGrid Build Number 2.0.20113.61241/4.0.20113.61241
=================================================================================

Corrections
-----------
  * When call GetCellBounds in RowColChange event, "Row not visible" exception thrown. (18748)

=================================================================================
C1TrueDBGrid Build Number 2.0.20113.61240/4.0.20113.61240
=================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Updated licensing to conform with Federal Information Processing Standards requirements (TFS 18562)

=================================================================================
C1TrueDBGrid Build Number 2.0.20113.61239/4.0.20113.61239
=================================================================================

Enhancements/Documentation/Behavior Changes
------------------------------------------- 
- Updated licensing to conform with Federal Information Processing Standards requirements. (18460)

=================================================================================
C1TrueDBGrid Build Number 2.0.20113.61238/4.0.20113.61238
=================================================================================

Corrections
-----------
  * Response of SaveLayout and LoadLayout methods is much worse as 
  compared to the previous version. (18269)
  * [8023-139] When C1TrueDBGrid is display as hierarchical data  with filter 
  drop down, after filtering the value in the filter bar which no rows exit in 
  the grid, “Index was out of range” exception is thrown. (17675)
  * An Error “Syntax error: Missing operand after ‘=’ operator” is  occur after 
  filtering in number column in certain scenarios. (16045)
  Note: 
      If “Equal”, "GreaterThan", "GreaterThanOrEqualTo", "LessThan" or "LessThanOrEqualTo" 
      condition is set in “Numeric Filter” without entering any number as the parameter, 
      then we act as we had "0" parameter for compare operations. 

=================================================================================
C1TrueDBGrid Build Number 2.0.20113.61237/4.0.20113.61237
=================================================================================

Corrections
-----------
  * C1TrueDbGrid does not property work with hierarchical data from C1DataSource. (16887)

=================================================================================
C1TrueDBGrid Build Number 2.0.20113.61236/4.0.20113.61236
=================================================================================

Corrections
-----------
  * The text gets appended to auto completed entry instead of original text 
  while typing in the dropdown column of the grid. (16550)

=================================================================================
C1TrueDBGrid Build Number 2.0.20113.61235/4.0.20113.61235
=================================================================================

Corrections
-----------
  * [4.0] Error occurs on clicking "OK" button in C1TrueDBGrid Designer (17209).
  * [4.0] C1TrueDBGrid Designer is not refresh when setting any properties from 
  the TDBGrid designer. (17211) 
  * C1TrueDBGridDesigner close automatically after clicking “ConditionFiltering” 
  icon at the column header in the preview of Designer. (16822)
  * “ArgumentOutOfRangeException” is observed after clicking “Condition Filtering” 
  button icon of a filtered column in “Hierarchical”   data view. (16816)

=================================================================================
C1TrueDBGrid Build Number 2.0.20113.61234/4.0.20113.61234
=================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Enhanced licensing in environments with some security policy restrictions.

=================================================================================
C1TrueDBGrid Build Number 2.0.20113.61233/4.0.20113.61233
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
  * FilterBar does not deactivate after rebinding the grid in custom filtering mode 
  (when AllowFilter = False) (5929)

=================================================================================
C1TrueDBGrid Build Number 2.0.20113.61232/4.0.20113.61232
=================================================================================

2011 v3 Release.

=================================================================================
C1TrueDBGrid Build Number 2.0.20112.61231/4.0.20112.61231
=================================================================================

Corrections
-----------
  * Checkbox in the filterbar of Checkbox column with width 25 is uncheckable if 
  it is placed on extreme left and two columns are grouped. (17039) 

Enhancements/Documentation/Behavior Changes
-------------------------------------------
  * Pass No is shown in the Progress dialog When generating preview of "DataView= Hierarchical" 
  of C1TrueDBGrid.  (16397)

=================================================================================
C1TrueDBGrid Build Number 2.0.20112.61230/4.0.20112.61230
=================================================================================

Corrections
-----------
  * If DataView is set to MultipleLinesFixed, and a column name is clicked on the 
  designer, the designer gets closed. (16864)
  * Language property of C1TrueDBGrid (2.0 version) can not be set custom value and always show 
  default language. (16356)

=================================================================================
C1TrueDBGrid Build Number 2.0.20112.61229/4.0.20112.61229
=================================================================================

Corrections
-----------
  * Only the last cell is displayed in the grid after loading and resizing the sizer. (16431)

=================================================================================
C1TrueDBGrid Build Number 2.0.20112.61228/4.0.20112.61228
=================================================================================

Corrections
-----------
  * When ‘Frozen’ is set true and ‘DataView’ is ‘MultipleLines’ or ‘MultipleLinesFixed’, 
  filter cell is not able to enter text at run time. (10815)
  * Performance request while collapsing/expanding the Hierarchical view C1TrueDBGrid 
  with over 10,000 data. (14485)
  * TargetInvocationException is thrown when C1TrueDBGrid.ExportToExcel() method is called 
  in Inverted DataView if bound to datasource with more than or equal to 255 records. (10926)
  Now: A warning is shown, export is not stopped, but extra columns are not saved.

=================================================================================
C1TrueDBGrid Build Number 2.0.20112.61227/4.0.20112.61227
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added Language property to allow control over the localization

  By default, the C1TrueDbGrid localizes the column filter editor to use the language
  specified by the CurrentUICulture setting. This property allows you to override that
  default and specify the language that should be used when the grid displays the 
  column filter editor.

  The default setting for this property is "Default", which corresponds to the original
  behavior.

  The built-in localization supports following languages: 
  English, Spanish, French, Italian, Portuguese, German, Dutch, Russian, Japanese, Turkish. 
  

=================================================================================
C1TrueDBGrid Build Number 2.0.20112.61226/4.0.20112.61226
=================================================================================

Corrections
-----------
  * Exception is observed when closing Form in MouseUp event. (15662)
  * ”BeforeUpdate” event triggered twice when e.Cancel is set to true. (15328)
  * Inconsistence between filtering data in Condition Filtering and data displayed 
  in the grid. (15861)
  * Inconsistence issues are observe between “Condition Filtering” (C1FlexGrid-like 
  filtering) and normal filtering (C1TrueDBGrid default filtering). (15859)

Enhancements/Documentation/Behavior Changes
-------------------------------------------
  * New Property C1TrueDBGrid1.PrintInfo.RowCanSplit
  Indicates whether the grid rows can split between pages.
  Default value is False.
  This new property helps to print very long text in columns on multiple pages. 
  Example:
	this.c1TrueDBGrid1.PrintInfo.RowCanSplit = true;

  * On change C1TrueDbGrid.FilterBar value, FilterText and filters of all columns are clear.


=================================================================================
C1TrueDBGrid Build Number 2.0.20112.61225/4.0.20112.61225
=================================================================================

Corrections
-----------
  * Setting the Filterbar property to true on an empty grid was throwing an exception.  (15745)
  
=================================================================================
C1TrueDBGrid Build Number 2.0.20112.61224/4.0.20112.61224
=================================================================================

2011 v2 Release.

Enhancements/Documentation/Behavior Changes
-------------------------------------------

New feature:
   Condition Filtering. (Or C1FlexGrid-like filtering).

   If you set the FilterBar property to false, and the C1DisplayColumn.FilterDropdown 
   property to true, C1TrueDBGrid control will allow to use the new filters in the column.

   The data filtering feature follows the pattern used by C1FlexGrid. 
   When users move the mouse over column headers, the grid displays a filter icon on the header. 
   Clicking the icon invokes the filter editor which selects the data that should be displayed. 
   Every column has a filter, and rows must pass all filters in order to be displayed.
   The built-in filters include value filter, which allows users to select specific values for display, 
   as well as a condition filter, which allows them to specify conditions 
   such as "Greater than" or "Contains".

   This feature does not change object model.
=================================================================================
C1TrueDBGrid Build Number 2.0.20111.61224/4.0.20111.61224
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added Metro-style toolbox icons.

=================================================================================
C1TrueDBGrid Build Number 2.0.20111.61223/4.0.20111.61223
=================================================================================

Corrections
-----------
  * Dropdown is not correctly rendered when the column width is less default width 
  of the dropdown. (15102)

=================================================================================
C1TrueDBGrid Build Number 2.0.20111.61222/4.0.20111.61222
=================================================================================

Corrections
-----------
  * ‘ArgumentException’ was thrown after clicking one of the column dropdown button.
  (15056 & 15057)
  
=================================================================================
C1TrueDBGrid Build Number 2.0.20111.61221/4.0.20111.61221
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
  * C1DataColumn.DefaultValue property takes effect in check boxes in the "new" row.

      By default, the if a column has checkbox presentation, then in the "new" row 
	the checkbox is displayed in the indeterminate state.
      Now, if the DefaultValue of a column is "true" or "false", the checkbox is 
	displayed in the corresponding state.

  Example:
    this.c1TrueDBGrid1.Columns["Check"].DefaultValue = "false";

=================================================================================
C1TrueDBGrid Build Number 2.0.20111.61219/4.0.20111.61219
=================================================================================

Corrections
-----------
  * Multiple Issues in C1TrueDBGrid Filtering (13438)

=================================================================================
C1TrueDBGrid Build Number 2.0.20111.61218/4.0.20111.61218
=================================================================================

Corrections
-----------
  * When ‘DataView’ property is set to ‘GroupBy’, desired cell cannot be selected.
  (14170)

=================================================================================
C1TrueDBGrid Build Number 2.0.20111.61217/4.0.20111.61217
=================================================================================

Corrections
-----------
  * Image of a column overlaps the caption of the column header when translate items 
  in a grid by an image. (13909)
  * Items in the column drop down is unable to select after setting 
  ‘FilterMultiselect’ property is set to true. (14600)

=================================================================================
C1TrueDBGrid Build Number 2.0.20111.61216/4.0.20111.61216
=================================================================================

Corrections
-----------
  * New data and row disappear in one scenario. (14828, 14460) 

=================================================================================
C1TrueDBGrid Build Number 2.0.20111.61215/4.0.20111.61215
=================================================================================

Corrections
-----------
  * Setting AllowSort to False at runtime does not reset the sort direction.
  * “FetchRowStyle” event does not fired when rows are group  and column is 
  sorted. (13407)

=================================================================================
C1TrueDBGrid Build Number 2.0.20111.61214/4.0.20111.61214
=================================================================================

Corrections
-----------
  * Error image is shown on the Checkbox position & Checkbox becomes non clickable 
  when cell is bound to class implement  IDataErrorInfo interface. (14705) 

=================================================================================
C1TrueDBGrid Build Number 2.0.20111.61213/4.0.20111.61213
=================================================================================

Corrections
-----------
  * The focus skips directly to the last column of second split when using Tab key 
  to navigate between splits. (14110) 

=================================================================================
C1TrueDBGrid Build Number 2.0.20111.61212/4.0.20111.61212
=================================================================================

Corrections
-----------
  * An error ”Filter expression [x]does not evaluate to a Boolean term” is observed 
  when any operator is set in “FilterOperator” property. (14210) 
  * RowColChange event fires when you switch the MS tab control that containing 
  C1TrueDBGrid. (12671)
  * Even when the HeaderDivider property of a column is set to False, the divider 
  is displayed between the headers at runtime. (14616)
  * All columns of second split of a grid disappear when an application created in 
  VS2003 is shifted to VS2010, and BorderStyle is set to “Fixed3D”. (14615)

=================================================================================
C1TrueDBGrid Build Number 2.0.20111.61211/4.0.20111.61211
=================================================================================

Corrections
-----------
  * ‘ArgumentOutOfRangeException’ is thrown after click the filter button. (14275) 

=================================================================================
C1TrueDBGrid Build Number 2.0.20111.61210/4.0.20111.61210
=================================================================================

Corrections
-----------
  * Values in filter dropdown of filter bar are not displayed in the grid on 
  a machine which only have .net Framework 2.0 (14541)
  * An exception is throw when clicking filterbar drop down on window 2000 machine 
  with .NET framework 2.0 only (14541)

=================================================================================
C1TrueDBGrid Build Number 2.0.20111.61209/4.0.20111.61209
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added Microsoft Office 2010 visual styles.
    The VisualStyle property has three new settings that pretty match 
	the look of Excel 2010:
        Office2010Blue, Office2010Silver, and Office2010Black.

=================================================================================
C1TrueDBGrid Build Number 2.0.20103.61207/4.0.20103.61207
=================================================================================

Corrections
-----------
  * Exception is thrown when deleting the selected data row after sorting. (13428) 
  * Locked combobox column can be expanded after expanding other unlock combobox 
  column. (13287)
  * ‘ArgumentOutOfRangeException’ is thrown when inserting horizontal split after 
  resizing the form. (14005)

=================================================================================
C1TrueDBGrid Build Number 2.0.20103.61206/4.0.20103.61206
=================================================================================

Corrections
-----------
  * 'BeforeRowColumnChange' event does not fire when the Column value is set 
  using code. (13977)

=================================================================================
C1TrueDBGrid Build Number 2.0.20103.61205/4.0.20103.61205
=================================================================================

Corrections
-----------
  * Even after setting the column’s "AllowFocus" property to False in the split , 
  it is possible to shift focus on the first display. (13324)

=================================================================================
C1TrueDBGrid Build Number 2.0.20103.61204/4.0.20103.61204
=================================================================================

Corrections
-----------
  * An exception is thrown if all columns are hidden in a multiple row display. 
  (13291)
  *  While using split, Update event cannot be executed without ending 
  the Editable state (13292)
  * On setting a background color to the column header, the border of the record 
  selector gets removed. (13336)

=================================================================================
C1TrueDBGrid Build Number 2.0.20103.61203/4.0.20103.61203
=================================================================================

Corrections
-----------
  * RowColChange event is not fired, if Col property is changed through code. (12933)

=================================================================================
C1TrueDBGrid Build Number 2.0.20103.61202/4.0.20103.61202
=================================================================================

Corrections
-----------
  * DisplayColumns of C1TrueDbGridDropdown is not shown in Property sheets.
  * [Win7] Column position pointer (Red arrow) is not visible on moving columns. (10594)
  * "ArgumentOutOfRangeException was unhandled" occurs with data layout=groupby. (13090)

=================================================================================
C1TrueDBGrid Build Number 2.0.20103.61201/4.0.20103.61201
=================================================================================

Corrections
-----------
  * .NET Exception error "No printers are installed" occurs in ExportToExcel 
  function if no printers installed on PC.

=================================================================================
C1TrueDBGrid Build Number 2.0.20103.61200/4.0.20103.61200
=================================================================================

Corrections
-----------
  * In C1TrueDBGrid Designer, selected font is not affected for grid's column. (12911)

=================================================================================
C1TrueDBGrid Build Number 2.0.20103.61199/4.0.20103.61199
=================================================================================

Corrections
-----------
  * C1TrueDBGrid1.Columns[x].ButtonPicuture.Tag property is not working if it is 
  set via designer. (12140)
  * NullReferenceException occur when one of the columns of grid is set to Nullable
  (of system.DateTime) data type and using custom editor to edit the column. (12302)
  * Build-In DateTimeEditor is not working when the grid is populated using Linq 
  data source. (12480)
  * "Object of type 'System.DBNull' cannot be converted to type 'System.Nullable'1" 
  error is occur when deleteing a cell text in any column and moves to another row 
  using LINQ data source (12421)
  * The record in the new row does not cancel although  pressing “Esc” key twice 
  after typing first cell and move to another cell. (12372)
  
=================================================================================
C1TrueDBGrid Build Number 2.0.20103.61198/4.0.20103.61198
=================================================================================

Corrections
-----------
  * Inconsistency between saving grid layout from C1TrueDBGrid Designer window and  
  its context menu. (11986)
  * Horizontal scroll bar does not appear. (5563)
  * Orange patches seen when Form containing C1TDBGrid is moved over another form 
  with C1TDBGrid as well. (5676)
  * Exception thrown on clicking Filter dropdown button when C1TDBGrid placed in 
  a user control is hosted in VB6 form. (10380)
  *  'SelChange' event does not fire and cells do not get selected, when 
  highlighted in a single row or column. (9004) 

=================================================================================
C1TrueDBGrid Build Number 2.0.20102.61197/4.0.20102.61197
=================================================================================

Corrections
-----------
  * Misc issues in multi-threading applications. (11803)

=================================================================================
C1TrueDBGrid Build Number 2.0.20102.61196/4.0.20102.61196
=================================================================================

Corrections
-----------
  * NumberFormat of DateTime column does not work in Edit mode. (11832)

=================================================================================
C1TrueDBGrid Build Number 2.0.20102.61195/4.0.20102.61195
=================================================================================

Corrections
-----------
  * Filter and FilterChange events fire on setting AllowFilter to false when Form loads. (11771)
  * Setting AllowFilter to True at runtime does not filter the grid. (11781)

  Note: If filterbar is not empty (has some value) and the AllowFilter property is changing,
  then the FilterChange event occurs.

=================================================================================
C1TrueDBGrid Build Number 2.0.20102.61194/4.0.20102.61194
=================================================================================

Corrections
-----------
  * A few regression issues with RowColChange event (11055, 11293). 
  * Typing in FilterBar while the FilterDropdown is open and FilterMultiSelect 
  is true and pressing enter does not filter the grid. (11743)
  The Enter key behavior for the filter multiselect dropdown:
  - If text in the filter box is changed by typing, the Enter leaves the text in the box.
  - If text in the filter box is not changed, the Enter acts as Apply button.

=================================================================================
C1TrueDBGrid Build Number 2.0.20102.61193/4.0.20102.61193
=================================================================================

Corrections
-----------
  * Intermediate state of a checkbox type column doesn't have a tickmark 
  in Windows Classic theme. (11708)

Note to FilterMultiSelect: if FilterMultiSelect is changed then FilterChanged event occurs.

=================================================================================
C1TrueDBGrid Build Number 2.0.20102.61192/4.0.20102.61192
=================================================================================

Corrections
-----------
  * [C1TDBGrid 4.0] "Add" and "Remove" buttons are present in SplitCollection 
  editor and DisplayColumns Collection editor. (11194)

=================================================================================
C1TrueDBGrid Build Number 2.0.20102.61191/4.0.20102.61191
=================================================================================

Corrections
-----------
  * RowColChange event fires twice if text typed in FilterBar is not present 
  in the grid and resulting rows are zero. (11557)
  * RowColChange event fires twice when we click inside FilterBar in a grid which 
  is in GroupBy mode. (11293)

  Note: Border of the in-build or C1TrueDBDropdown is canged from single to shadowed 
  from build 2/4.0.20102.61180 onwards.

=================================================================================
C1TrueDBGrid Build Number 2.0.20102.61190/4.0.20102.61190
=================================================================================

Corrections
-----------
  * Access Violation Exception message appears when Frozen property of Column is 
  set to True. (3278)
  * Resizing a column and dragging it in Grouping area does not render columns 
  in the grouping area properly. (11307)
  * Sort event does not fire on moving the column to Grouping area.  (9120)
  * [VS2008] Adding C1TrueDBGrid to VB.Net form makes "Option Infer" feature of 
  the VisualStudio to stop working. (11149)

=================================================================================
C1TrueDBGrid Build Number 2.0.20102.61189/4.0.20102.61189
=================================================================================

Corrections
-----------
  * Applying multi-select filtering and then setting AllowFilter to False at 
  runtime does not refresh the grid to show all rows again. (11079)

=================================================================================
C1TrueDBGrid Build Number 2.0.20102.61188/4.0.20102.61188
=================================================================================

Corrections
-----------
  * Column headers are shown although toggle off the ‘Column Headers’ button in 
  C1TrueDBGrid Designer. (10702)
  * If ‘FilterDropDown’ is set to 'true' once, dropdown button is displayed 
  although ‘FilerDropDown’ is set back to false. (10814)
  * Scrolling does not occur using MouseScroll inside FilterDropdown. (11070)
  * ‘FilterApplyText’, ‘FilterClearText’ and ‘FilterCancelText’ do not work using 
  keyboard support. (10797)
  * Multiple issues in C1TrueDBGrid 4.0 build. (10616, 11092)

=================================================================================
C1TrueDBGrid Build Number 2.0.20102.61183/4.0.20102.61183
=================================================================================

Corrections
-----------
  * NullReferenceException is thrown on clicking the column in which AutoDropDown=True 
  and  Presentation=ComboBox / SortedComboBox. (10770)
  * ‘InvalidCastException’ is thrown  after selecting an item from C1TrueDBDropDown 
  control when ‘FilterMultiSelect’ is set True. (10873)
  * ‘AfterFilterEvent’ is not properly fired when ‘FilterMultiSelect’ is set True. (10872)

=================================================================================
C1TrueDBGrid Build Number 2.0.20102.61182/4.0.20102.61182
=================================================================================

Behavior Changes
----------------
  *  The wraptext behavior has been reverted back to it's previous implementation. 
     '\n' or 'vbCrLf' now render regardless of the setting of the Style.WrapText property. 

Corrections
-----------
  * Background color of DateTimePicker's Calendar changes to "Blue" when MarqueStyle 
  is set to HighlightedRow or HighlightedCell. (8431)

  * Misc issues with the RowColChange event. (8787, 9023, 9934, 10790)

  * Resetting Frozen property cannot reset its cascade columns after close Designer. (10715)

=================================================================================
C1TrueDBGrid Build Number 2.0.20102.61180
=================================================================================

Enhacements:
- The grid now supports Multiselection in the Filter dropdown list. (8977)
   New public properties of C1DataColumn:
     bool FilterMultiSelect {get; set; }
     char FilterSeparator {get; set; }
     string FilterApplyText {get; set; }
     string FilterClearText {get; set; }
     string FilterCancelText {get; set; }
- Changed the sorting behavior of a numeric and date column displayed 
    in Filter Dropdown list (9490)
- Border of the in-build or C1TrueDBDropdown is canged from single to shadowed.
Note: if FilterMultiSelect is changed then FilterChanged event occurs.

Corrections
-----------
  * Scroll wheel does not work on columns bound to C1TDBDropdown when C1TDBGrid 
  RowHeight is set to 14 or less. (9425)
  * In ‘GroupBy’ DataView, when applying ‘BottomOfText’ for ‘ForegroundPicturePosition’, 
  foreground image overlap on grid column headers. (9668)
  * ‘NullReferenceException’ is thrown in a certain scenario with 'DataView' setting. (9807)
  
=================================================================================
C1TrueDBGrid Build Number 2.0.20101.61179
=================================================================================

Enhancements
------------
  * C1TDBGrid Designer remembers location and size (8978)

Corrections
-----------
  * Added localized event descriptions (JPN).


=================================================================================
C1TrueDBGrid Build Number 2.0.20101.61178
=================================================================================

Corrections
-----------

  * BeforeUpdate event calls inconsistently. (2992)
  * RowColChange event is not fired when data is refreshed from data source. (4592)
  * No visual difference observed between Checkbox type Columns for 
    Locked =True and Locked=False properties in Windows Vista theme. (6977)
  * BorderStyle property and most of public events don't have descriptions in 
    Properties Window (3282). 
  * RowColChange event fires twice on changing a row or both row/column when grid 
    is in 'GroupBy/Heirarchical' DataLayout mode. (9023)
  * Opening calculator of a cell of a column bound with C1NumericEdit control and 
    clicking on some other cell of the grid selects all the cells till that newly 
    clicked cell. (9123)
  * Milliseconds in a DateTime column are displayed as zero when using "o" format specifier. (9883)
  
=================================================================================
C1TrueDBGrid Build Number 2.0.20101.61175
=================================================================================

Corrections
-----------

 * Setting SpringMode to true at runtime was not working correctly.  (9050, 9096)
 * Setting the Col property in the BeforeUpdate() event and then canceling the event
   was not setting focus to the correct column. (8795)
 * Cancelling the Addnew operation on an empty grid that was bound to a master table
   was removing the addnew row.  (9009)
 * Fixed Exception when using the FilterDropdown on an empty grid.  (9012)
 * FontChanged() event was not being raised when the font was changed.  (9343)
 * Fixed exception when entering text into a cell that was not currently visible. (8072)
 
=================================================================================
C1TrueDBGrid Build Number 2.0.20101.61172
=================================================================================

Corrections
-----------

 * System.NullReferenceException thrown when C1TDBGrid is placed on Component class.  (8405)

=================================================================================
C1TrueDBGrid Build Number 2.0.20093.61171
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------

 * Added Editor property.
   This property returns the control that is used to edit the cell data.  This property
   is valid while the EditActive property is true.
   
Corrections
-----------

 * The ColEdit event was being raised before the editor was initialized (EditActive=false).


=================================================================================
C1TrueDBGrid Build Number 2.0.20093.61169
=================================================================================

Corrections
-----------

 * Adjust column sizing computation when using the SpringMode property.  [5563]
 
 * Incorrect value was being selected when selecting a value from C1TrueDBDropdown
   and the selected value was a substring of another value in the dropdown.  [5715]
   
 * The ValueItems validation was failing when the display value contained "_". [5903]
 
 * Entering edit mode was causing the LostFocus event to be raised.  [5908]
 
 * The ComboBox no longer opens when the style.Locked property is true or e.Cancel is
   set in the BeforeColEdit() event.  [6631]
   
 * No visual difference observed between Checkbox type Columns for Locked =True and Locked=False 
   properties in Windows Vista/Win7 theme.  [6977]
 
 * ArgumentOutOfRangeException thrown on collapsing a node when cell is in edit mode in
   a Hierarchical grid.  [7390]
   
 * CheckBoxes with a Horizontal alignment set to General now render centered. [6991]
 
 * Setting Style.WrapText to false now renders the cell text properly even if the 
   text contains hard returns.  [7098]
   
 * The ValueItems ComboBox was not sizing row heights based on Font size.  [7531]
 
 * After editing a column whose ImeMode was set to ImeMode.Disabled all further IME editing 
   was disabled.  [7546]
   
=================================================================================
C1TrueDBGrid Build Number 2.0.20092.61168
=================================================================================

Corrections
-----------

 * Footer text was not being refreshed for columns added at runtime.  [5666]

 * Turning off cell tips in the FetchCellTips event was not removing the cell tip. [2739]
 
 * Fixed "Object not set to an instance of an object" error when the grid was
   used in a base form and an inherited form was modified and compiled.  [3903]
 
=================================================================================
C1TrueDBGrid Build Number 2.0.20092.61167
=================================================================================

Corrections
-----------

 * Fixed exception when the AllowUpdate property was set to false and the
   MarqueeStyle was set to FloatingEditor.  [5519]
   
 * Fixed exception when switching DataViews and the last column was invisible.  [5522]
 
=================================================================================
C1TrueDBGrid Build Number 2.0.20092.61166
=================================================================================

Corrections
-----------

 * Unable to select rows by clicking on RecordsSelector, if MarqueeStyle is set to
   FloatingEditor.  [5397]

=================================================================================
C1TrueDBGrid Build Number 2.0.20092.61165
=================================================================================

Corrections
-----------

 * RowColChanged was not being raised when row currency was changed using
   C1DBNavigator.  [4718]
   
 * Changes to cells were not persisting when the grid was bound to C1DataObjects.  [4790]
 
=================================================================================
C1TrueDBGrid Build Number 2.0.20092.61164
=================================================================================

Corrections
-----------

 * Fixed sizing issue when the font of the parent Form was changed.  [3655]
 
 * RowColChange event was not being raised when moving to or from the FilterBar. [4592]
 
=================================================================================
C1TrueDBGrid Build Number 2.0.20092.61163
=================================================================================

Corrections
-----------

 * Better diagnostics in exceptions thrown on errors when using custom print options
 form type (specified via PrintInfo.PrintOptionsFormClassName). [4301]
 
 * Using the mouse wheel when actively editing now scrolls the grid.  [4362]
 
 * RowColChange event was being raised for each split.  It now only fires once.  [4312]

=================================================================================
C1TrueDBGrid Build Number 2.0.20091.61162
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------

 * Added AllowInactiveStyle property.
   This property controls whether the InactiveStyle is rendered for the grids caption
   when it loses focus.

Corrections
-----------
 
 * Fixed: when printing a grid in grouped view, aggregates in the column immediately
   following the grouped cell were not printed. [3273]
 
 * Pasting an invalid date into the DateTimePicker was throwing an unhandled exception. [3656]
 
 * Selecing a row in the C1TrueDBDropdown when the MultiSelect property was set to
   MultiSelectEnum.Extended was also selecting a range of cells in the grid. (4110)
 
 * When entering "today's date" in the date-type cell, the entered data was not
   persisting.  [3624]
   
 * In the built-in combo box, the entered value does not correspond with the selected 
   list item. [3626]
   
 * EditMask column was not honoring the Paste command. [3627]
 
 * Switch tabs when the grid was placed in a TabControl was not preserving the updated
   cell contents. [3628]
   
 * FloatingEditor marquee was not displayed when navigating to another split using the
   keyboard.  [3629]
   
 * Cell contents do not highlight when using FloatingEditor marquee on a cell with an
   EditMask.  [3633]
   
 * Corrected a number of Focus issues with the FloatingEditor marquee.  [3634, 3635, 3638, 3639]]
 
 * Value from ‘Splits.Rows.Count’ is incorrect after adding new row(s) in bound grid
   using code.  [3636]
   
 * BeforeUpdate event was being raised when the BeforeColUpdate event was cancelled
   on the last column in a split.  [3637]
   
 * ButtonClick event was not being raised in a multi-line grid if the button column was
   next to a hidden column.  [3640]
   
 * Corrected issue when using the mouse wheel in a grid with multiple splits and the splits
   had different heights.  [17545]


=================================================================================
C1TrueDBGrid Build Number 2.0.20091.61156
=================================================================================

Corrections
-----------

* In grid print/export, some foreground and background images in column
  captions were not shown. Fixed (3482).

* In grid print/export, if grid cells contained radiobuttons, those were always
  rendered unchecked even if checked in the grid. Fixed (3383).

* In grid print/export, grouped cells' content could be truncated.
  Fixed (3378).

* In grid print/export, in hierarchical grid the "collapse" button was shown
  on some rows that were neither expanded nor collapsed. Fixed (3341).

=================================================================================
C1TrueDBGrid Build Number 2.0.20091.61155
=================================================================================

Corrections
-----------

* Printing: In "TrueDBGrid Print/Export Options" dialog and in
  "save file as" export dialog, the order of export formats is now
  the same as in C1Preview.

* When exporting the grid to HTML using the "preserve pagination" export
  option, bottoms of pages could sometimes be clipped. Fixed (3262)
  (Note that this also may require build 52010 or later of C1Report to
  work properly.)

* When printing the grid, if PrintInfo.UseGridColors were set to true,
  and a page header or footer consisted of 3 "\t"-delimited parts,
  only one part was visible in the printout. Fixed (3275).

Enhancements/Documentation/Behavior Changes
-------------------------------------------

* Two new public methods added to PrintInfo (note that they do NOT
  require or load C1Report assemblies, unlike other print/export
  methods):

    public bool SaveAsC1d(string outputFileName)
      Saves the current grid as a C1D file, which can later be loaded
      into a C1PrintDocument (provided by C1Report product).
      Note that unlike most other print/export methods, this method
      does not require C1Report assemblies.
    Parameters:
      outputFileName: The name of the output file.
    Returns:
      true if the file was successfully saved, false otherwise.

    public bool SaveAsC1d(System.IO.Stream stream)
      Saves the current grid to a stream in C1D (native C1PrintDocument)
      format.
      Note that unlike most other print/export methods, this method
      does not require C1Report assemblies.
    Parameters:
      stream: The output stream.
    Returns:
      true if the stream was successfully written, false otherwise.
    Remarks:
      Unlike the Print(System.IO.Stream) method, this method does not
      reset the stream's position after saving.

=================================================================================
C1TrueDBGrid Build Number 2.0.20091.61154
=================================================================================

 Corrections
 -----------
 
 * Execption was being thrown when trying to print/preview a grid in grouped
   view.  (3273)

=================================================================================
C1TrueDBGrid Build Number 2.0.20091.61153
=================================================================================

 Corrections
 -----------
 
 * Execption was being thrown when the visible property for all the rows were
   set to false.  (3129)

=================================================================================
C1TrueDBGrid Build Number 2.0.20091.61152
=================================================================================

 Corrections
 -----------
 
 * Pressing a key in a cell that had an C1TrueDBDropdown attached was losing the first
   key if the font for the editor was larger than the default font size.  (18182)

=================================================================================
C1TrueDBGrid Build Number 2.0.20083.61151
=================================================================================

 Corrections
 -----------
 
 * Export methods fail with "could not create export provider" when 
   using C1Report dlls.  (18618)

=================================================================================
C1TrueDBGrid Build Number 2.0.20083.61150
=================================================================================

 Corrections
 -----------

 * Exception occurred when calling PrintInfo.PrintPreview method.  (18516)
 * Exception occurred when printing the grid with doPDF printer set as default.
   (18530)

=================================================================================
C1TrueDBGrid Build Number 2.0.20083.61148
=================================================================================

 Corrections
 -----------

 * The Filterbar dropdown did not have the same font as the cell in the
   filterbar.  (18479)

=================================================================================
C1TrueDBGrid Build Number 2.0.20083.61147
=================================================================================

 Corrections
 -----------

 * Calling the AutoSize() method in the Form_Load() event was not correctly
   autosizing columns when the cell value was being translated using
   C1TrueDBDropdown.

=================================================================================
C1TrueDBGrid Build Number 2.0.20083.61146
=================================================================================

 Corrections
 -----------

 * Using the mouse wheel on a split in the same VerticalScrollGroup was not
   scrolling the last row into view when the client area of the split was less than
   the split containing the vertical scrollbar.  (17545)

=================================================================================
C1TrueDBGrid Build Number 2.0.20083.61145
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------

 * SelectedStyle is now honored when rendering using Office VisualStyles.
   Note:  When using this version for the first time you should reset the
          VisualStyle property (i.e., change to Custom and then select your
          preferred VisualStyle).


=================================================================================
C1TrueDBGrid Build Number 2.0.20083.61144
=================================================================================

 Corrections
 -----------

 * FloatingEditor marquee was not being displayed when setting the Col property.  (17696)


=================================================================================
C1TrueDBGrid Build Number 2.0.20082.61142
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------

 * NOTE:  Due to a change in serialization, applications using this build *will not* be able to replace
          the grid with a previous version.

 * The FetchGroupCellStyle event will now be raised if the column that is being grouped has
   the FetchCellStyle property set to true.

 * The EventArgs passed into the FetchGroupCellStyle event has been changed from FetchCellStyleEventArgs
   to FetchGroupCellStyleEventArgs.  This class derives from FetchCellStyleEventArgs so existing
   event handlers will need no changes.

 * Setting the BackColor or BackgroundImage property with a cell using the ButtonText
   property will now render the BackColor/BackgroundImage.

 * Added FilterWatermark property.

   This property is used to render text in an empty Filterbar cell.

 * Added FilterWatermarkStyle property.

   This property is used to style the FilterWatermark text.

 * Added ability to insert a column in the designer.  Previous version always appended.

 * Enhanced unbound grid.

   Two new properties were added to allow more flexibility when using an unbound grid.

   - Added NewRow() method.  This method returns a DataRow that is compatible with
     the grids unbound schema.

   - Added Rows collection.

 * Added ImeMode property to the C1DataColumn object.

 * Grouped grid enhancements.

   - Added new override:

     ExpandGroupRow(int index, bool expand)

     This allows one to control the expansion of grouped subrows.  Passing in
     -1 for the index will expand all the rows (optionally subrows).

     CollapsedGroupRow(int index) method was updated to take a -1 as the index.
     Passing in -1 will collapse all the rows.

 * New method SetActiveCell(int row, int col)

   This method sets the row and column in one atomic unit.

 * MultipleLinesFixed DataView enhancements

   This DataView has been refactored to allow a more flexable layout for a multi-line
   grid.

   The row widths in this DataView is no longer constrained by the width of the grid.
   If the sub of the column width are greater than the client width of the grid you
   will now get a horizontal scrollbar.

   Setting the C1DisplayColumn.Merge property will now allow the column to span
   the height of the row.  Note:  The merge property is only applicable for the
   left most columns in the grid.

   Added MultiLineExtendColumns() method.  This method will adjust the width of
   the last column on a subrow to align it with the widest subrow.

 * Merged cells are now supported for Inverted DataView.

 * The RowColChange event is now raised when the grid is rebound using the Rebind() method.  (16086)

 Corrections
 -----------

 * GridLines were not properly rendered under the following conditions:
   - EmptyRows = true
   - AllowSizing = IndividualRows
   - The row height of the last row was adjusted.


=================================================================================
C1TrueDBGrid Build Number 2.0.20082.61135
=================================================================================

 Corrections
 -----------

 * FormatText event is raised with a wrong e.Row (RowIndex) when in
   Hierarchical DataView.  (VNTDG001125)

 * C1TDBGrid not able to access data/value in lower levels of hierarchical
   data source. (VNTDG001117, VNTDG001133)


=================================================================================
C1TrueDBGrid Build Number 2.0.20082.61134
=================================================================================

 Corrections
 -----------

 * PageBreak was not working for Columns/Headers/Footers when the grid was exported
   to DOCX.  (VNTDG001101)

 * "[]" text string was not being properly previewed or exported.  (VNTDG001092)

 * CellTips were being displayed when the grid didn't have focus.  (VNTDG001123)

 * Using the mouse wheel was not raising the Scroll Event.  (VNTDG001112)

 * Column footers were incorrectly rendered in a Grouped grid.  (VNTDG001124)

 * Corrected exception when a grouped row was collapsed.  (VNTDG001113)

 * Cell alignment was incorrect when exporting or previewing the grid.  (VNTDG001128)

 * Image alignment was incorrect when previwing the grid.  (VNTDG001109)

 * Fixed Tab Order in the print/export options dialog.  (VNTDG001103)

=================================================================================
C1TrueDBGrid Build Number 2.0.20081.61133
=================================================================================

  Licensing adjustments.

=================================================================================
C1TrueDBGrid Build Number 2.0.20081.61132
=================================================================================

  Localization update for JPN locale.

=================================================================================
C1TrueDBGrid Build Number 2.0.20081.61131
=================================================================================

 Corrections
 -----------

 *  Scroll event was being raised multiple times.  (VNTDG001093)

 *  Clicking the next button of C1DBNavigator was not changing row currency of the
    grid after the grid was given focus.  (VNTDG001086)

 *  Calling the MoveLast() method of the grid in the Form Load event wasn't
    displaying the last record of an Inverted or Form view grid.  (VNTDG001080)

 *  Clicking the scrolldown button in a grid that has the first row invisible
    was not scrolling the grid.  (VNTDG001079)

 *  Expanding/Collapsing rows in a grouped grid was not being reflected in
    other splits in the same scrollgroup.  (VNTDG001067)

 *  Opening a form with the grid on it was dirtying the form.  (VNTDG001057)

 *  Setting the AllowRowSizing property to IndividualRows and setting the
    MarqueeStyle property to a value other than the default value was throwing
    an exception when the form was opened.  (VNTDG001104)

 *  Fixed exception when the grid received focus in MultiLine DataView and the
    the last column was invisible.  (VNTDG001107)

=================================================================================
C1TrueDBGrid Build Number 2.0.20073.61130
=================================================================================

 Corrections
 -----------

 *  Stack Overflow Exception and data inconsistency observed when the C1TDBGrid
    has hierarchical dataview, splits and Filter applied to it. (VNTDG001059)

 *  Argument Exception error when inputing value that is not exist in the column
    into filter bar in hierarchical view (VNTDG001062)

 * ArgumentOutofRangeException observed on selecting the cell in C1TrueDBGrid
    having Hierarchical Dataview. (VNTDG001063)


=================================================================================
C1TrueDBGrid Build Number 2.0.20073.61129
=================================================================================

 Corrections
 -----------

 *  Fixed Exception that occurred when data source providers returned null
    IDataErrorInfo objects.

 *  Column picker wasn't being updated in the designer when the column information
    was changed.



=================================================================================
C1TrueDBGrid Build Number 2.0.20073.61128
=================================================================================

 Corrections
 -----------

 *  Stack Overflow Exception and data inconsistency observed when the C1TDBGrid
    has hierarchical dataview, splits and Filter applied to it. (VNTDG001059)

 *  Row Selection is not highlighted correctly when C1TrueDBGrid is bound with
    MasterDetail dataset and ¡°Hierarchical¡± dataview (VNTDG001058)

 *  Values in 'Date' column display current date on entering edit mode in Hierarchical
    DataView. (VNTDG001048)

  *  Sorting does not maintain the data consistency for hierarchical database. (VNTDG001044)


=================================================================================
C1TrueDBGrid Build Number 2.0.20073.61127
=================================================================================

 Corrections
 -----------

 *  Corrected Column caption rendering problem under Windows Vista Basic display
    settings.  (VNTDG001018)

 *  The first typed character was not displayed when the MarqueeStyle was set
    to FloatingEditor and the grid had multiple splits.  (VNTDG000980)

 *  Adding a new row in a sorted grid and then pressing KeyUp was causing the
    grid to scroll.  (VNTDG001003)

 *  Fixed Tab Key navigation on the AddNew row when moving between splits.  (VNTDG001020)

 *  In GroupBy Dataview, clicking the column header was sorting the underlying
    DataSource even though the AllowSort property was set to false.  (VNTDG001031)

 *  Modifying sorted order of a grid when using FetchRowStyle was not correctly
    applying the styles to the new sorted order.  (VNTDG001041)



=================================================================================
C1TrueDBGrid Build Number 2.0.20073.61125
=================================================================================

 Corrections
 -----------

 *  The TrueDBDropdown control attached to a column in the Filterbar with ValueTranslate
    set to True was not fully populating.  (VNTDG001049)

=================================================================================
C1TrueDBGrid Build Number 2.0.20072.61122
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------

 * Added VisualStyle property.

  This property takes a value from the VisualStyle enumeration and customizes the
  overall appearance of the grid to match commonly used visual styles.

  This is a fast and easy way to obtain high quality layouts without having to customize
  several individual properties and styles.

  Setting the VisualStyle on a C1TrueDBGrid will control the gradients and borders used
  to paint and highlight row and column headers, and the selection area. The
  VisualStyle property does not affect fonts, foreground colors, or any other
  properties that are not related to appearance.

  Most ComponentOne controls support the VisualStyle property, so this is an easy way
  to configure all controls in an application to achieve a consistent, professional
  look.

  Available settings for the VisualStyle property are:

  Custom        No visual style (use styles and appearance properties as usual)
  System        Style matches the current system settings
  Office2007Blue    Style matches Office2007 Blue color scheme
  Office2007Silver  Style matches Office2007 Silver color scheme
  Office2007Black   Style matches Office2007 Black color scheme

  The VisualStyle property is an ambient property (like Font, BackColor, ForeColor).
  If it is not set explicitly, then it inherits its value from parent controls that
  have explicit values set.


 Corrections
 -----------

 * Deleting the value from a cell that was bound to C1TDBDropdown using value translate
   was not perserving the contents of the cell.  (VNTDG1017)

 * Rowdivders were not correctly position under Vista. (VNTDG001019)

 * Setting any of the Style.Border properties was modifying the parent Style's border. (VNTDG1005)

 * Right aligned cells edited with the MaskedEditor was incorrectly accepting input
   when the mask was full.  (VNTDG000902)

 * DateTime columns were not saving current date on the AddNewRow.  (VNTDG001001, VNTDG001004)

 * Using an external editor for a date column that had an associated FormatTextEvent for that column
   was populating the editor with incorrect data.  (VNTDG001012)

 * Using aggregates in a grouped grid in which the aggregated column had formatting applied was
   not correctly computing the aggregate value.  (VNTDG001014)

 * The cell modification buffer was not being cleared for columns that contained translated values.  (VNTDG001017)

 * Setting e.Cancel = true in the BeforeUpdate event with a grid that contained multiple splits
   was causing the event to fire multiple times.  (VNTDG001021)

 * Vertical scrollbar width was not being serialized.  (VNTDG001028)

 * Having a grouped grid with FilterDropdown was not displaying the dropdown buttons.  (VNTDG001033)


=================================================================================
C1TrueDBGrid Build Number 2.0.20071.61117
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------

 *  Editing an empty DateTime cell when using the DateTime picker will now dirty
    the cell with the current DateTime.  (VNTDG001001)

 Corrections
 -----------


=================================================================================
C1TrueDBGrid Build Number 2.0.20071.61117
=================================================================================

 Corrections
 -----------

 * Exception was thrown when inputting in the filterbar when the FilterDropdown
   property was true and AutoDropdown was false.  (VNTDG000964)

 * Editing a date cell in a grouped grid was incorrectly populating the
   DateTimePicker with an incorrect date.  (VNTDG000993)

 * Corrected issue with FilterDropdown and the cell presentation was set to
   display a checkbox.  (VNTDG000994)

 * Corrected performance problem when selecting "(All)" in the filter dropdown
   on non-text fields.  (VNTDG000995)

 *

=================================================================================
C1TrueDBGrid Build Number 2.0.20071.61102
=================================================================================

 Corrections
 -----------

 * Fixed rendering issue when the grid was hosted inside the C1Sizer control.  (VNTDG000985)

 * Unhandled exception was thrown when setting the Style.Alpha property to a
   value < 0 or > 255.  (VNTDG000989)

 * First character typed was being ignored when the keypress initiated AddNew and
   the FloatingEditor marquee was set in a scrollable grid. (VNTDG000980)

 * Using the scrollbar up button in Hierarchical DataView when the parent row was
   expanded was not scrolling the grid.  (VNTDG000992)

=================================================================================
C1TrueDBGrid Build Number 2.0.20071.61026
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------

 *  New property C1DataColumn.FilterDropdownText

    public string FilterDropdownText { get; set; }

    Gets or sets the value indicating All when the FilterDropdown property is true.
    DefaultValue = "(All)"


=================================================================================
C1TrueDBGrid Build Number 2.0.20062.61023
=================================================================================

 Corrections
 -----------

 *  Unable to select master records in Hierarchical Dataview.  (VNTDG000966)

 *  Corrected exception at runtime when switching from Windows Classic to Windows XP.
    (VNTDG000952)

 *  The first input key was being ignored with a cell containing a dropdown and
    autocomplete = true. (VNTDG000956)

 *  Setting the Frozen property in an unbound grid prior to calling the SetDataBinding()
    method was not freezing the column.  (VNTDG000962)

 *  Selecting the current date on the addnew row when addnew was initiated by the
    BindingNavigator was not saving the selected date. (VNTDG000967)

 *  'System.NullReferenceException' was thrown on clicking column header to sort
    after changing the DataView of grid. (VNTDG000883)

 *  'System.NullReferenceException' was thrown on clicking record selector after
    changing the DataView of grid." (VNTDG000882)

 *  The grids design time UI was active when it the control wasn't the primary
    selected control on the design surface.  (VNTDG000968)

 *  C1TrueDBGrid Designer closed without any notification When the
    horizontal/vertical splits were dragged to the extreme ends to make them
    invisible, and then the Delete horizontal/vertical splits button was clicked.
    (VNTDG000881)

 *  C1TrueDBGrid Designer closed without any notification When the last column
    was removed from a split while there were columns in the grouping area.
    (a follow up to VNTDG000897)

 *  Setting the Alpha property of a Style to a value greater than 255 caused the
    Style Editor to close unexpectedly and the C1TrueDBGrid control to become
    unusable (VNTDG000955).  Now the user cannot set the Alpha property to an
    invalid value.

 *  The Italics & Underline buttons in Column Designer once clicked could not be
    toggled back to undo the settings. (VNTDG000926)

=================================================================================
C1TrueDBGrid Build Number 2.0.20063.60825
=================================================================================

 Corrections
 -----------

 *  Setting the RowHeight to a negative value was not being handled correctly.  (VNTDG000945)

 *  Incorrect icon 'Normal DataView' (the default value) was always selected in
    the Designer.  (VNTDG000928)

 *  Removing a grouped column in the designer was causing the designer to close. (VNTDG000897)
    The bug was fixed by adding a 'removeCol' method override in class GroupByView.

 *  The Column header divider & the Column footer divider were not shown
    for frozen columns. (VNTDG000856)

 *  The GroupAggregate() event was not being raised correctly when the grid
    was grouped on more than one column.  (VNTDG000944)

 *  Using the DateTimePicker on the new row and selecting today's date was not
    dirtying the grid.

 *  Added support for C1DataExtender column style width property.  (VNTDG000948)

 *  Cancelling the ProgressWindow while using the PrintPreview() method was
    throwing an exception.  (VNTDG000950)

 *  The grid scrolls to the first row when DataSet.AcceptChanges() is called.  (VNTDG000924)


=================================================================================
C1TrueDBGrid Build Number 2.0.20062.60720
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------

 *  New property PrintInfos.GridLines

    public GridLinesEnum GridLines

    Specifies how Grid lines are rendered when the grid is previewed or printed.

Corrections
-----------

 ** Using the grid's indexer to access data on the first parent in a hierarchcial
    datasource was not returning the correct value once the node was expanded.  (VNTDG000936)

 ** MouseWheel event wasn't being raised in the C1TrueDBDropdown control.  (VNTDG000938)

 ** Navigating columns in the Filterbar of a GroupBy grid using the keyboard was
    not correctly rendering the Marquee.  (VNTDG000925)

 ** Corrected issue that allowed expansion of a node in a hierarchical grid when
    the parent node was collapsed.  (VNTDG000937)

 ** Setting the EditMaskUpdate property was not saving the literals to the datasource.  (VNTDG000942)

 ** Setting the AutoComplete property without having the dropdown opening automatically
    was not updating the datasource with values selected with the keyboard.  (VNTDG000939)

 ** Having an editmask on a DateTime column (##/##/####) when the number of days
    or months was less than the mask lenght was not correctly populating the mask
    when going edit active. (VNTDG000934)

=================================================================================
C1TrueDBGrid Build Number 2.0.20062.60608
=================================================================================

Corrections
-----------

 ** Fixed Hierarchical DataView problem with filtered datasources.


=================================================================================
C1TrueDBGrid Build Number 2.0.20062.60531
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------

 *  New property PrintInfos.OneFormPerPage

    public bool OnFormPerPage

    Gets or sets a value indicating whether a grid in Form DataView prints each record on
    a page.  DefaultValue = true.

Corrections
-----------

 ** The FontDialog in the Style Editor wasn't being initialized to the font of the style.  (VNTDG000858)

 ** Using keyboard navigation keys (arrows, pgup, pgdn, etc.) in an opened DateTimePicker
    was locking the grid.  (VNTDG000895)

 ** Editing a cell with AnnotatePicture = true was not correctly editing the
    cell text. (VNTDG000880)

 ** Grouped rows that contained an aggregate cell was display the dropdown
    button if the cell contained a dropdown. (VNTDG000870)

 ** Error message was being displayed when deleting values from the ValueItem UITypeEditor.  (VNTDG000875)

=================================================================================
C1TrueDBGrid Build Number 2.0.20062.60510
=================================================================================


Corrections
-----------

 ** Exception is fixed when SuspendBinding() is used and mouse is over the grid.

 ** Setting the EmptyRow property of C1TrueDBGrid to true displays a dead area at
    the bottom of C1TrueDBGrid object. (VNTDG000842)

 ** Changes made for FilterBarStyle's Font size doesn't refresh once it's changed.
    (VNTDG000584)

 ** ExpandColor and CollapseColor properties not working. (VNTDG000841)

 ** Fixed obnormal verb menu appearance in design-time for the indications:
    - multi-instance in composite controls (dock,tab)
    - while typed dataset is saved

 ** Error message displayed on clicking Add absent fields if there are two unbound
    columns. (VNTDG000596)

 ** Calling the SetDataBinding() method on the C1TrueDBDropdown control when more
    than one dropdown was used in the grid was not rebinding the datasource correctly.  (VNTDG000831)

 ** Argument Exception is thrown when unbound column having null value is moved to
    the group area. (VNTDG000865)

 ** The operations with [Ctrl + X] or [Ctrl + V] key cause an exception when MarqueeStyle
    != FloatingEditor and BeforeColEdit e.Cancel = True (VNTDG000833)

 ** System.Argument exception was raised after applying filter criteria in the filterdropdown
    and choosing a value from ValueItem combobox." (VNTDG000682)

 ** Application was crashing when presentation property was set to ComboBox/SortedComboBox,
    AutoDropDown = True and MarqueeStyle = FloatingEditor.
    (VNTDG000852)

 ** The Styles collection editor was closing when you deselected a style and then
    pressed the AddCustomStyle button.  (VNTDG000848)

 ** Translated value was not being displayed for the first cell when the MarqueeStyle
    property was set to FloatingEditor and the Dropdown was used to provide
    translation.  (VNTDG000840)

 ** A cell with an edit mask that contain the '9' mask was allowing spaces as input.  (VNTDG000839)

=================================================================================
C1TrueDBGrid Build Number 2.0.20062.60407
=================================================================================


Corrections
-----------

 ** Fixed wrong position of anchored celltip for the column footers (VNTDG000351)

 ** Fixed an accessibility of filter bar being overlapped by footer (VNTDG000337)

=================================================================================
C1TrueDBGrid Build Number 2.0.20062.60324
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------

 * Optimized style operations when removing a large number of styles.  (VNTDG000825)

Corrections
-----------

 ** Editing a column with an Editmask was ignoring the mask the first time the
    cell was edited.  (VNTDG000826)

 ** Fixed disappearance of Caption when RepeatGridCaption is set. (VNTDG000621)

 ** Fixed Unhandled Exception when using the string for Editmask property (VNTDG000824)

 ** Fixed "Invalid string format" exception shown when TDBDropDown used with a specific
    combination of keys (VNTDG000818)

 ** Fixed incorrect focus-frame during scrolling when MarqueeStyle= DottedRowBorder
    (VNTDG000830)

 ** Fixed incomplete refreshing while focus is leaving & MarqueeStyle = DottedRowBorder
    (VNTDG000829)

 ** Fixed issue - When MarqueeStyle = DataRowBorder and DataView = Normal/Inverted/Form,
    then if you select cell[0, 0] to select the entire 1st row, only cell[0,0] get selected
    for the very first time, irrespective of the selected RowDividerStyle. This happens for
    the very first time. Further selection of any cell results in entire row selection.
    (VNTDG000828)

 ** Fixed ArgumentOutOfRangeException while clicking on the grid When grid's AllowRowSizing
    property is set to IndividualRows, and DataView property is set to Inverted (VNTDG000827)

 ** Fixed NullReferenceException on changing the DataView from 'Hierarchial' to any other
    value (VNTDG000820)

 ** Fixed Unhandled Exception when using the string for Editmask property (VNTDG000824)


=================================================================================
C1TrueDBGrid Build Number 2.0.20061.60224
=================================================================================

Corrections
-----------

 ** Fixed formatting when editing columns of DateTime.  The editor now tries to match the
    format of the column when editing.

 ** The behavior when pressing the enter key when using the DateTimePicker is now consistent
    with the other internal cell editors.

 ** Fixed exception when data is quickly typed under any active column Editmask (VNTDG000824)

 ** Fixed incorrect rendering after column reorder when columns are merged in the Normal
    DataView (VNTDG000802)

 ** Exception fixed when DataView is set to Inverted or Form but has no columns specified


 ** Fixed an overlapping of header area by anchored cell tips in the 'Form' dataview.(VNTDG000800)

 ** Fixed incorrect behavior with selection and vertical resizing in the InvertedView mode
    (VNTDG000787)

 ** Fixed incorrect selection frame for Inverted DataView and Marquee style = DottedRowBorder
    (VNTDG000811 & VNTDG000812)

 ** Fixed grid header with RepeatGridHeader=TRUE for Form DataView (VNTDG000621)

=================================================================================
C1TrueDBGrid Build Number 2.0.20061.60116
=================================================================================

Corrections
-----------

 ** MaintainRowCurrency property was not working.

 ** Optimized loading of a saved layout.

 ** Fixed auto scrolling of the grid when selecting a range of cells.

 ** Fixed column layout when changing dataviews between Hierarchical and MultipleLines.  (VNTDG000803)

 ** Fixed DottedRowBorder marquee for Form dataview.  (VNTDG000798)

 ** Fixed exception when a context menu was displayed and you clicked the grid.  (VNTDG000785)

 ** Fixed ArgumentOutOfRange exception in a Grouped grid when a selecting a row and then
    grouping the grid.  (VNTDG000793)

 ** Using a C1DateEdit as an external editor was not allowing input via the keyboard.  (VNTDG000794) 

 ** Opening a dropdown when the font height was greater than the rowheight was truncating
    the cell text.  (VNTDG000795)

 ** ButtonClick() event was being raised for a column when that columns AllowFocus property
    was set to false.  (VNTDG000796)

 ** Fixed serialization of the SplitDividerSize property (VNTDG000807)

 ** Fixed data disappearance when in double split mode is used SplitSizeMode=Scalable 
    after Exact one (VNTDG000628)

 ** Fixed issue of the dropdown not being closed when the dropdown was opened on an MDIChild form and
    Alt-Tab key was pressed.

 ** Applying of Locked property wasn't refreshing a grid (VNTDG000521)

====================================================================
C1TrueDBGrid Build Number 2.0.20061.51219
====================================================================

Corrections
-----------

 ** Setting PrintInfo.PageSettings.Landscape property was not being honored when printing/previewing. (VNTDG000791)

 ** Fixed "Ambigous Mismatch" exception when using the Print() method.  (VNTDG000788)

 ** Modifying the text in the filterbar with an empty grid was causing an
    extra row to be added to the grid when used with the FloatinEditor marquee.  (VNTDG000790)
 
 ** Fixed exception when binding to a hierarchical DataSource in Normal DataView.

 ** Childgrid was displaying in the wrong position when the ExpandChild() method was
    called and the current column was not the leftmost column.  (VNTDG000678)

 ** Fixed rendering of a grouped row when using aggregates. (VNTDG000666)

 ** Fixed DottedRowBorder MarqueeStyle for Inverted DataView.  (VNTDG000545)

 ** Fixed rendering of merged columns when the row other than the first row of the merged
    area was dirtied.  (VNTDG000765)

 ** AfterInsert() event wasn't firing when focus was moved from the addnew row to the filterbar.  (VNTDG000704)

 ** RowResize() event wasn't firing in Form DataView. (VNTDG764)

 ** Using the C1DateEdit as an external editor was displaying incorrect data when
    the cell was being edited.  (VNTDG000778)

====================================================================
C1TrueDBGrid Build Number 2.0.20053.51105      Build Date: 05 Nov 05
====================================================================

Retail release for VS2005 RTM.

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Style editor control is added and assigned to every style available 
  in the design-time
