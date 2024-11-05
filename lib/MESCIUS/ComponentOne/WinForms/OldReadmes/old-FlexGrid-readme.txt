/////////////////////////////////////////////////////////////////////////////////////////
//
// Readme file for ComponentOne C1FlexGrid control
//
// C1.Win.C1FlexGrid.dll
//
// Version number format:
// first  part: Version of the .NET framework used to build the assembly (e.g. 2 = .NET 2.x)
// second part: Internal use only
// third  part: Year/version (e.g. 20101 = V1/2010)
// fourth part: Sequential number
//
/////////////////////////////////////////////////////////////////////////////////////////
//
// This assembly is available in two versions: .NET 2.x and .NET 4.0
// (for every 2.x.x.x build there is a corresponding 4.x.x.x build)
//
/////////////////////////////////////////////////////////////////////////////////////////

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20142.844	Build Date: October 20, 2014
=========================================================================================

Corrections
-----------
- Fix positioning of FlexGrid's CellLabel in the MDI child Form (TFS 89579)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20142.843	Build Date: October 2, 2014
=========================================================================================

Corrections
-----------
- Improve XLS loading to handle rich text (TFS 84223)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20142.842	Build Date: August 5, 2014
=========================================================================================

Corrections
-----------
- Hide CellLabel when showing ContextMenu (TFS 72567)
- Handle focus issue when changing ShowCellLabels in Windows 8 (TFS 71208)
- Fix positioning of ScrollTip when RightToLeft is true (TFS 79202)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20142.840	Build Date: July 25, 2014
=========================================================================================

Corrections
-----------
- Improved handling of edit starts with space in Hiragana mode (TFS 70048)
- Improved editing with ComboList in Hiragana mode (TFS 76102)
- Do not export collapsed rows to CVS when VisibleOnly flag is set (TFS 77135)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20142.835	Build Date: June 26, 2014
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V2/2014 build

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20141.833	Build Date: June 16, 2014
=========================================================================================

Corrections
-----------
- Fixed issue with auto-alignment of negative currency values in some locales (TFS 69964).

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20141.832	Build Date: June 3, 2014
=========================================================================================

Corrections
-----------
- Fixed issue related to selection being canceled (broken in build 818, TFS 52653, 64215, 67636, 67953, and 68508).
- Fixed issue related to null/DBNull/empty values in string columns (TFS 35379)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20141.831	Build Date: May 28, 2014
=========================================================================================

Corrections
-----------
- Fixed issue with CellLabels in Windows 8 modal dialogs (TFS 48235)
- Fixed issue with CellLabels in Windows 8 (TFS 36190)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20141.828	Build Date: April 29, 2014
=========================================================================================

Corrections
-----------
- Changed Greek translation of '(null)' to '(χωρίς τιμή)' (no value).
- Fixed Hebrew translation of 'less than or equals'.
- Prevent grid from entering edit mode on single click/numeric columns (TFS 64389)
- Improved printing of grids with row headers wider than the page (TFS 64420)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20141.824	Build Date: March 28, 2014
=========================================================================================

Corrections
-----------
- RightToLeft property not working after applying a theme. (TFS 47700)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20141.822	Build Date: February 27, 2014
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added ShowThemedHeadersEnum.SelectedOnly setting to allow highligting only
  selected ranges when SelectionMode is set to ListBox, Row, RowRange, etc.
  For details, see http://our.componentone.com/groups/topic/misbehaviour-with-fixed-row/

Corrections
-----------
- Improved localization issue with custom decimal/thousand separators (original change in 800, TFS 43573)
  For details, see http://our.componentone.com/groups/topic/setting-values-using-strings-that-contain-dollar-sign-character/
- Removed support for leading zeros in numeric editor (change in 818 had nasty side-effects, TFS 56448)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20141.818	Build Date: February 27, 2014
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Internal C1Themes-related changes
- Added "Studio for Desktop" product information

Corrections
-----------
- Improved alignment of checkboxes when importing from Excel (TFS 50980)
- Improved handling of null values in filter (TFS 50728)
- Improved numeric editor to support leading zeros (i.e. fmt="0.00" in addition to "#.00") (TFS 51490)
- Handle invalid characters in Excel output (TFS 51927)
- Honor e.Cancel while dragging the mouse in ListBox selection mode (TFS 52653)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20141.809	Build Date: February 07, 2014
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V1/2014 build
- Improved value filter editor to show only values that are not filtered out by other columns (like Excel, TFS 40629/50901)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20133.807	Build Date: January 12, 2014
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Improved value filter editor to show only values that are not filtered out by other columns (like Excel, TFS 40629)

Corrections
-----------
- ComboBox did not always commit edits made with keyboard (TFS 49326)
- Clear filter indicators when setting dataSource to null (TFS 49544)
- Improved rendering of custom borders with VisualStyles (TFS 39445)
- Improved null handling in cell merging logic (TFS 50566)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20133.800	Build Date: December 12, 2013
=========================================================================================

Corrections
-----------
- Improved auto-resize handling in Row/ListBox selection modes. (TFS 43545, 43977, 23278)
- Fixed issue with setting TopRow to invalid values while Redraw == false (TFS 46867)
- Fixed localization issue with custom decimal/thousand separators (TFS 43573)
- Added localization strings for "(null)"

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20133.793  Build Date: October 31, 2013
=========================================================================================

Corrections
-----------
- Fixed issue that could result in accessing disposed objects (TFS 45172)
- Special handling of VisualStyle in C1Themes

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20133.792  Build Date: October 23, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Internal C1Themes-related changes

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20133.791  Build Date: October 10, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added support for C1Themes

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20133.789  Build Date: October 2, 2013
=========================================================================================

Corrections
-----------
- Improved string comparison in the Filter to honor the current culture (TFS 42801)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20133.788  Build Date: September 16, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V3/2013 build

Corrections
-----------
- Improved behavior of data-mapped cells when closing the combo editor (TFS 42217)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20132.786  Build Date: September 6, 2013
=========================================================================================

Corrections
-----------
- Renamed recently added Strings type to RuntimeStrings to avoid ambiguity issues in VB projects (TFS 41628)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20132.785  Build Date: August 9, 2013
=========================================================================================

Corrections
-----------
- Fixed issue when dragging scroll thumb with ScrollFlags.ScrollByRowColumn set to true (TFS 41232)
- Measure trailing spaces with both settings of UseCompatibleTextRendering (TFS 41191)
- Improved AutoSizeCols when rendering cells with vertical text (TFS 41231)
- Fixed issue with rows being removed from the data source with AllowAddNew set to true (TFS 41177)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20132.783  Build Date: July 23, 2013
=========================================================================================

Improvements
------------
- Added workaround for GDI+ bug/limitation: GDI+ does not support certain complex script
  characters (u200D specifically), so fall back on TextRenderer automatically.

  To see the issue in GDI, try:

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new Form1());
        }
        public Form1()
        {
            InitializeComponent();
            Font = new Font("Arial Unicode MS", 11.0F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Text = "\u0924\u094D\u200D\u0928";
    }

  For details, see:
  http://connect.microsoft.com/VisualStudio/feedback/details/95565/external-exception-thrown-from-measurestring-method-of-system-drawing-graphics

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20132.782  Build Date: July 16, 2013
=========================================================================================

Corrections
-----------
- Improved clipboard handling when pasting into columns with IC1MultiColumnDictionary data maps (TFS 37991)
- Improved handling of RemoveItem notifications (TFS 38418)
- Improved mouse handling on empty grids (TFS 39905)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20132.778  Build Date: June 10, 2013
=========================================================================================

Corrections
-----------
- Fixed issue with designer font serialization (TFS 37445)
- Improved performance when exporting large XLSX files (TFS 27897)
- Fixed issue with XLSX import (TFS 37790)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20132.774  Build Date: May 31, 2013
=========================================================================================

Improvements
------------
- Improved thread safety in scenarios where grids are created simultaneously on multiple threads (TFS 36611)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20132.772  Build Date: May 30, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V2/2013 build

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20131.771  Build Date: May 29, 2013
=========================================================================================

Corrections
-----------
- Improved auto-sizing to account for edit buttons in cells (TFS 37087)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20131.770  Build Date: April 8, 2013
=========================================================================================

Corrections
-----------
- Improved style handling with VisualStyles (TFS 35409)
- Improved rendering of Japanese text in the vertical direction

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20131.767  Build Date: March 20, 2013
=========================================================================================

Corrections
-----------
- Improved column editor (TFS 34467, 34386)
- Improved highlighting of merged row/column headers (TFS 34618)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20131.765  Build Date: March 8, 2013
=========================================================================================

Corrections
-----------
- Show sort glyph on first column header when SubtotalPosition == BelowData (TFS 34655)
- Improved Excel export with OwnerDraw cells (TFS 34497)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20131.763  Build Date: February 27, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Improved numeric/DateTime/boolean editors to honor DataColumn.AllowDBNull in data source
  (http://our.componentone.com/groups/winforms/flexgrid-for-winforms/forum/topic/35695/#post-184864)

Corrections
-----------
- Saving non-primitive values to XLSX created blank cells (now they are converted to strings TFS 33506)
- Inconsistent behavior when editing merged cells on sorted columns (TFS 33738)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20131.751  Build Date: January 22, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V1/2013 build

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20123.749  Build Date: January 22, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Auto-size all selected rows/columns with double click on row/column headers (like Excel, TFS 23278)

Corrections
-----------
- Bottom subtotals were not being inserted at the right position when AllowAddNew == true (TFS 27980)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20123.745  Build Date: January 9, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added DraggingRow and DraggingColumn events.

  These events may be useful when providing feedback to users while they drag rows
  and columns to new positions. For example, the code below paints a red rectangle
  at the column drag target position. The code assumes there's a Panel control
  positioned above the grid:

    int target = -1;
    this.c1FlexGrid1.DraggingColumn += (s, e) =>
        {
            target = e.Position;
            panel1.Invalidate();
        };
    this.c1FlexGrid1.AfterDragColumn += (s, e) =>
        {
            target = -1;
        };
    panel1.Paint += (s,e) =>
        {
            if (target > -1)
            {
                var rc = this.c1FlexGrid1.GetCellRect(0, target);
                rc.Width = 10;
                e.Graphics.FillRectangle(Brushes.Red, rc);
            }
        };


Corrections
-----------
- Improved mouse handling of outline tree with merged nodes (TFS 20538)
- Fixed issue with CVS import/export and IncludeFixedCells (TFS 32209)
- Fixed issue with deleting content from cells with check boxes (TFS 30122)
- Fixed issue with VisualStyle property in C1RibbonForm (TFS 15726)
- Improved ShowCell to keep cell top and left within view (TFS 32763)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20123.740  Build Date: December 17, 2012
=========================================================================================

Corrections
-----------
- Improved serialization of filter definitions to handle empty strings, null values, and DBNull.Value (TFS 32090)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20123.738  Build Date: December 5, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added localization for Hungarian.

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20123.737  Build Date: November 20, 2012
=========================================================================================

Corrections
-----------
- Improved sorting consistency in Filter list for columns of type 'object' (TFS 29982)
- Prevented formatting aggregates as DateTime values (TFS 30273)
- Added extra sanity checks to ListChanged notification handler (TFS 30378)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20123.734  Build Date: November 12, 2012
=========================================================================================

Corrections
-----------
- Improved behavior of ComboList when adding new rows, ListBox selection mode, always edit mode (TFS 29152)
- Improved performance when loading XLSX files (TFS 29224)
- Improved handling of Shift-key when editing cells with custom editors (TFS 29683)
- Improved handling of decimal point character in numeric editor (TFS 29782)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20123.730  Build Date: October 23, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V3/2012 build

Corrections
-----------
- Fixed auto-size issue in C1FlexGridClassic control (TFS 29233)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20122.726  Build Date: October 15, 2012
=========================================================================================

Corrections
-----------
- Improved selection after pasting over new row template (TFS 29018)
- Improved hit test to avoid returning invisible items (fringe case) (TFS 28423)
- Honor setting TopRow, LeftCol properties while Redraw == false (TFS 28746)
- Improved positioning of cell labels when parent form's RightToLeft is set to true (TFS 13893)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20122.723  Build Date: October 2, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Improved keyboard handling with custom cell editors (TFS 15083)
- Added localization for traditional Chinese. The grid now supports two Chinese cultures:
  - Traditional (Taiwan, Hong Kong, Macao).
    Used if the CurrentUICulture name starts with "zh-TW", "zh-HK", or "zh-MO".
  - Simplified (PRC, Singapore)
    Used if the CurrentUICulture name is anything else, starting with "zh".

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20122.722  Build Date: September 24, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Improved memory management to deal with sparse unbound arrays (TFS 15872)
- Made column filter editor honor column sort setting (TFS 24715)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20122.721  Build Date: September 10, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Changed NumericEditor to keep original value if text doesn't change (TFS 27956)

Corrections
-----------
- Outline bar buttons were broken (TFS 27738)
- Improved mouse handling of merged ranges (TFS 27729)
- Fixed localization of column filter in Norwegian/.NET 4.0 (TFS 27805)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20122.716  Build Date: August 27, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added Metro-style toolbox icon

Corrections
-----------
- Improved CSV parsing to handle multi-line cells (TFS 25072)
- Added extra checks to formatting in filter editor (TFS 24715)
- Honor outline buttons in merged header cells (TFS 26046)
- Improved handling of re-binding while adding new rows (TFS 11189)
- Hide outline tree when Tree.Column.Width == 0 (TFS 26317)
- Improved handling of AllowAddNew in MDI child forms (TFS 26360)
- Improved display of sort icon on merged column headers (TFS 23551)
- Fixed issue importing Excel files with charts (TFS 24018)
- Fixed issue with filter/mouse wheel under Win XP (TFS 27422)
- Improved font conversion in project upgrades (TFS 17270)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20122.704  Build Date: August 3, 2012
=========================================================================================

Corrections
-----------
- Cancel parameter property in ShowScrollTip event was not honored (TFS 24480)
- First fixed column did not honor uniform resizing (TFS 24491)
- Set designer's ShowInTaskbar property to false (for consistency with other grid dialogs) (TFS 24486)
- Designer column combo got out of sync after dragging columns (TFS 24395)
- Designer 'toggle column visibility' button did not work correctly (TFS 24444)
- Improved handling of Escape key when editing bound grids (TFS 23313)
- DataTree sample: deleting expanded rows did not remove the child grid (TFS 24135)
- Fixed rendering of Japanese text in the vertical direction (TFS 24499)
- Improved listbox selection with sorting (TFS 24371)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20122.703  Build Date: July 16, 2012
=========================================================================================

Corrections
-----------
- Fixed rendering of Japanese text in the vertical direction (TFS 23763)
- Improved keyboard handling with traditional Chinese keyboard (TFS 21042)
- Updated assembly information for C1FlexGridClassic (TFS 24068)
- Honor Get/SetCellChecked value when exporting and filtering
  http://our.componentone.com/groups/winforms/flexgrid-for-winforms/forum/topic/checkbox-col-with-some-cells-in-style-nocheckbox/#post-177706

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20122.698  Build Date: June 19, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V2/2012 build

Corrections
-----------
- Improved designer behavior when showing invisible columns (TFS 23326)
- Improved handling of Escape key when adding new rows (TFS 23313, 23377)
- UseCompatibleTextRendering was being reset when setting StyleInfo property (23269)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20121.692  Build Date: June 6, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Optimized CellStyle constructor to avoid unnecessary calls to Graphics.FromHwnd.

Corrections
-----------
- Moving selected nodes did not move the selection along with the node (TFS 14975)
- Improved display of error cells when importing from Excel (TFS 21408)
- Changed shortcut key for "And" button in column filter (to avoid conflict with "Apply" button) (TFS 23089)
- Fixed Norwegian filter localization (TFS 14713)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20121.685  Build Date: May 16, 2012
=========================================================================================

Corrections
-----------
- Adding new rows in sorted bound grids could cause an item to be deleted (TFS 22303, regression on TFS 20916)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20121.684  Build Date: May 10, 2012
=========================================================================================

Corrections
-----------
- Clip string did not always separate column headers correctly (TFS 19996)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20121.683  Build Date: May 5, 2012
=========================================================================================

Corrections
-----------
- Adding new rows in sorted bound grids could cause an item to be deleted (TFS 20916)
- Tooltip text for ‘SortFlag.Descending’ option was incorrect (TFS 16011)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20121.682  Build Date: April 25, 2012
=========================================================================================

Corrections
-----------
- Updated Excel filter to handle double.NaN correctly (TFS 21356)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20121.681  Build Date: April 6, 2012
=========================================================================================

Corrections
-----------
- Changed automation support to count row headers as regular cells
  (so the coded UI infrastructure returns the correct column index) TFS 19730
- Fixed issue with numeric editor and +/- Infinity values (TFS 19502)
- Made Styles editor resizable (TFS 20267)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20121.679  Build Date: March 31, 2012
=========================================================================================

Corrections
-----------
- Could throw when modifying the rows collection while adding a new row in unbound mode (TFS 20926)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20121.678  Build Date: March 7, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V1/2012 build

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20113.677  Build Date: March 5, 2012
=========================================================================================

Corrections
-----------
- Improved behavior of auto-clip with empty strings (TFS 19829)
- Improved behavior of updates when setting data that does not match filter requirements (TFS 20273)

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added Korean localization

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20113.673  Build Date: February 16, 2012
=========================================================================================

Corrections
-----------
- Improved behavior of auto-clip with empty strings (TFS 19829, 19996)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20113.668  Build Date: February 7, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added support for data annotation attributes (see System.ComponentModel.DataAnnotations
  namespace)

  When auto-generating data bound columns, the C1FlexGrid now honors the following data
  annotation attributes:

  - System.ComponentModel.DisplayNameAttribute
    "DisplayName" attribute property sets column "Caption" property
  - System.ComponentModel.DataAnnotations.DisplayAttribute
    "Name" attribute property sets column "Caption" property
        "AutoGenerateField" attribute property sets column "Visible" property
  - System.ComponentModel.DataAnnotations.DisplayFormatAttribute
    "DataFormatString" attribute property sets column "Format" property
  - System.ComponentModel.DataAnnotations.EditableAttribute
    "AllowEdit" attribute property sets column "AllowEditing" property

  For example:

  public class MyDataItem
  {
  // auto-generated CustomerName column header will show "Customer".
    [System.ComponentModel.DataAnnotations.Display(Name = "Customer")]
  public string CustomerName { get; set; }

  // auto-generated CustomerID column will be invisible.
    [System.ComponentModel.DataAnnotations.Display(AutoGenerateField = false)]
  public int CustomerID{ get; set; }

  // auto-generated "Frequency" column will show values formatted as percentages
  // and will not allow editing.
  [System.ComponentModel.DataAnnotations.DisplayFormat(DataFormatString = "0%")]
    [System.ComponentModel.DataAnnotations.Editable(false)]
  public double Frequency { get; set; }
  }

  Using standard attributes to annotate data members allows you to write data models
  that can be re-used in different applications and platforms.

  NOTE: The C1FlexGrid uses reflection to apply these attributes, so it does not
  require a reference to the System.ComponentModel.DataAnnotations assembly.
  However, data models that use these attributes will require this reference.

Corrections
-----------
- Fixed issue related to coded UI tests (TFS 19730)
- Fixed issue with numeric editor and +/- Infinity values (TFS 19502)
- Improved behavior of selection when removing items in ListBox mode (TFS 14975)
- Use cr/lf as line separator when copying to the clipboard (TFS 19514)
- Reverted change made to CellChanged event. It is not supposed to fire when data is changed directly in the datasource (TFS 19668, 14475)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20113.663  Build Date: January 16, 2012
=========================================================================================

Corrections
-----------
- Fixed issue with Excel filter (some cells were being assigned a black background) (TFS 18896)
- Control did not allow pasting into the new row template (TFS 19598)
- CellChanged event did not fire when data was changed directly in the datasource (TFS 19668)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20113.662  Build Date: January 16, 2012
=========================================================================================

Corrections
-----------
- Numeric editor did not handle percentages correctly when starting edits (TFS 18490)
- Suppress selection change events while changing the SelectionMode (TFS 17142)
- Improved OwnerDraw logic for painting OutlineBar (TFS 18162)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20113.660  Build Date: January 9, 2012
=========================================================================================

Corrections
-----------
- Prevent right-aligned cells from spill-merging (TFS 14739)
- Preserve line breaks in cells when saving/loading text files (TFS 18652)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20113.659  Build Date: December 26, 2011
=========================================================================================

Corrections
-----------
- Fixed issue related to Condition filter XML persistence (TFS 19062)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20113.658  Build Date: December 20, 2011
=========================================================================================

Corrections
-----------
- Fixed issue with column designer with grids with more than 100 columns (TFS 18894)
- VisualStyle Office2010Black caused problems visible with DataTree sample (TFS 18793)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20113.656  Build Date: November 22, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Updated licensing to conform with Federal Information Processing Standards requirements (TFS 18562)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20113.650  Build Date: November 17, 2011
=========================================================================================

Corrections
-----------
- Allow saving more than 65k rows to xlsx files (TFS 15294)
- The Highlight property in custom renderers was overridden by custom cell backgrounds;
  this behavior was inconsistent with the regular highlight behavior (TFS 10169)
- Toggle CheckBoxes with space bar when auto-search is on (TFS 18282)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20113.647  Build Date: November 10, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Save outline indentation when exporting to XLSX and CSV (already did for XLS)
- Save gridline visibility and color when exporting to XLSX and XLS

Corrections
-----------
- Updated Excel filter (TFS 18225)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20113.646  Build Date: November 1, 2011
=========================================================================================

Corrections
-----------
- When AllowAddNew is true, pressing ESC twice can delete row (TFS 18097)
- Flickering on choosing item from combos on the new row template (TFS 18104, 17949)
- OwnerDraw logic was inconsistent for the cell containing the OutlineBar (TFS 18162)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20113.643  Build Date: October 24, 2011
=========================================================================================

Corrections
-----------
- CellChecked event did not fire SelectionMode property was set to ListBox (TFS 17945)
- Added extra checks to Filter type coercion (TFS 17680)
- Disable editing if the cell is not visible (TFS 17259)
- Improved type coercion in flex filter (TFS 17680)
- Value filter now shows only mapped values that are present on the grid (TFS 17484)
- Improved positioning of filter editor popup (TFS 17570)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20113.641  Build Date: October 4, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Enhanced licensing in environments with some security policy restrictions

Corrections
-----------
- Improved editor positioning with non-flat cell borders (TFS 17414)
- Improved editor error-checking when filtering on boolean/checkbox values (TFS 17553)
- Improved type conversions in Aggregate calculations (TFS 17755)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20113.636  Build Date: September 21, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added a new GetLocalizedString event for customizing the column filter UI:

  The C1FlexGrid automatically localizes the column filter based on the
  system's current culture and in the setting of the Language property.

    The GetLocalizedString event allows callers to customize the filter strings
  or to implement localization to languages that are not supported by the grid's
    built-in localization mechanism.

  To modify the content of any of the filter's UI elements, the event handler
  must set the "e.Value" parameter to the text to be displayed in the filter.

  The example below shows how you can change the strings in the filter
    UI based on the string value and on the name of the controls being localized:

  void Initialize()
    {
        // enable filtering
        _flex.AllowFiltering = true;

        // set GetLocalizedString handler
        _flex.GetLocalizedString += _flex_GetLocalizedString;
    }

    void _flex_GetLocalizedString(object sender, C1.Win.C1FlexGrid.GetLocalizedStringEventArgs e)
    {
        // customize item based on text value
        if (e.Value == "(Select All)")
        {
        e.Value = "(Select Everything)";
        }

        // customize item based on component name
        switch (e.ComponentName)
        {
        case "_btnApplyFilter":
            e.Value = "OK";
            break;
        case "_btnClearFilter":
            e.Value = "Reset";
            break;
        case "_btnCancel":
            e.Value = "Close";
            break;
        }
    }

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20113.635  Build Date: September 9, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V3/2011 build

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20112.634  Build Date: August 18, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added Persian (Farsi) localization

Corrections
-----------
- Fixed issue with tri-state CheckBoxes and nullable Boolean columns. For details, see:
  http://our.componentone.com/groups/winforms/flexgrid-for-winforms/forum/topic/55516/#post-164412
  (and TFS 16625)
- Subtotals were not being calculated for hidden columns (TFS 17027)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20112.630  Build Date: August 11, 2011
=========================================================================================

Corrections
-----------
- Collapsed rows were exported to Excel as visible (TFS 16607, broken in 2010 V1)
- Canceling new row on edit start left old content on the cell (TFS 16608)
- BottomRow property could be off by one (TFS 16528)
- Reset AutoSearch buffer when changing the value of the AutoSearch property (TFS 16567)
- Start AutoSearch when user presses non-whitespace key (TFS 16567)
- ComboBox dropdown could be incorrectly positioned near screen edges (TFS 16621)
- Null values in bool columns showing as grey CheckBoxes (TFS 16625)
- Deleting columns with filtering on and with mouse over column headers could cause exceptions (TFS 16670)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20112.626  Build Date: July 29, 2011
=========================================================================================

Corrections
-----------
- Combos with wide content positioned near the bottom of the screen did not
  always position the dropdown above the control to keep content visible (TFS 13496)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20112.625  Build Date: July 13, 2011
=========================================================================================

Corrections
-----------
- Setting SelectionMode == ListBox did not always update the visual selection correctly (TFS 16213)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20112.624  Build Date: July 9, 2011
=========================================================================================

Corrections
-----------
- Fixed painting issue in outline button bar (TFS 14232, 15606)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20112.623  Build Date: June 24, 2011
=========================================================================================

Corrections
-----------
- Fixed issue with designer (http://our.componentone.com/groups/winforms/flexgrid-for-winforms/forum/topic/54197/)
- Improved logic for ShowCellLabels with WordWrap (TFS 15853)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20112.621  Build Date: June 13, 2011
=========================================================================================

Corrections
-----------
- Exception when clicking separator in filter menu (TFS 8361)
- CellChecked event did not fire for all settings of EditOptions (TFS 8335)
- SaveExcel did not honor column width == 0 (TFS 14533)
- CellChanged event did not fire when the new value caused the data to be sorted (TFS 14475)
- Improved precision of aggregate calculations (use decimal internally instead of double (TFS 13024)
- Numeric editor did not handle typing over extended selections correctly (TFS 12492)
- Canceling edits on a single new row did not remove the row (TFS 11189)
- Exception when opening a combo in the new row template, moving focus to a different control,
  then trying to re-open the combo on the new row template (TFS 12490)
- Improved handling of new row edit/cancel action (TFS 11189)
- Fixed Japanese date formatting in filter editor (TFS 12494)
- Clear could throw if invoked after binding to a filtered DataView (TFS 15601)
- AccessibleObject was not returning the last column of the grid

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20112.614  Build Date: May 8, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V2/2011 build
- Improved editing formatted nullable values (see http://helpcentral.componentone.com/CS/winforms_31/f/8/t/88537.aspx)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20111.611  Build Date: April 5, 2011
=========================================================================================

Corrections
-----------
- Improved speed of ReadXml method (TFS 14904)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20111.610  Build Date: March 26, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added Turkish localization
- Improved support for editing nullable values (numbers, dates, booleans)

Corrections
-----------
- Fixed issue with column filter persistence

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20111.606  Build Date: March 24, 2011
=========================================================================================

Corrections
-----------
- Localized new properties to Japanese
- Column.Editor property got lost when editing with the designer (TFS 14718)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20111.605  Build Date: March 8, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Improved performance of paste operations on numeric cells (TFS 14584)

Corrections
-----------
- Grid did not honor RTL when printing merged cells
- Filter editor did not honor RTL
- Grid could throw when holding down the Enter key while editing DateTime values (TFS 12944)
- Adding columns to data source caused grid to create a new column even when AutoGenerateColumns == False (TFS 14501)
- Editor allowed entering decimal characters even when that exceeded the MaxLength property (TFS 14444)
- Improved extended row/column selection (TFS 14278)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20111.602  Build Date: Feb 21, 2011
=========================================================================================

Corrections
-----------
- Fixed issue with Filter localization

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20111.601  Build Date: Feb 10, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Improved RightToLeft implementation.
  It now renders text using the RightToLeft style (flipping punctuation, etc),
  with one exception:
  When displaying or editing negative numeric values, the minus sign is always shown
  before the digits (e.g. -123), while standard RightToLeft controls show the minus
  sign (incorrectly) after the number (e.g. 123-).

Corrections
-----------
- Fixed issue with PrintDialog layout measurements (TFS 14294, introduced in version 589)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20111.599  Build Date: Feb 7, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added Rows.GlyphRow property.

  When grids have multiple fixed rows, the sorting and filter glyphs are shown on
  the last fixed column by default. The reason for this is that the last fixed row
  is usually not merged, and the glyphs should be column-specific.

  In some cases, however, the application may require showing the sort and filter
  glyphs on the first fixed row (or on any other fixed row). This property allows
  you to select the row that will contain the sort and filter glyphs.

  By default, this property is set to -1, which causes the glyphs to be displayed
  on the last fixed row (the original default behavior).

  For example:

    // show glyphs on the first fixed row
    this.c1FlexGrid1.Rows.GlyphRow = 0;
    this.c1FlexGrid1.Rows.Fixed = 3;
    this.c1FlexGrid1.AllowFiltering = true;
    this.c1FlexGrid1.DataSource = myDataTable;

    // show glyphs on the default position (last fixed row)
    this.c1FlexGrid2.Rows.Fixed = 3;
    this.c1FlexGrid2.AllowFiltering = true;
    this.c1FlexGrid2.DataSource = myDataTable;


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20111.598  Build Date: Jan 31, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added EditFilter(col) and ClearFilter(col) methods to allow easy control over the
  filters from UI elements such as menus and toolstrips (see FilterMenu sample).
- Added Chinese localization.

Corrections
-----------
- Fixed issue with RightToLeft rendering (TFS 13408)
  When RightToLeft is set to true, .NET moves the minus sign to the right of the number
  (e.g. -123 renders as 123-). This behavior is incorrect, the negative sign should
  always precede the number.
- Disable automatic ole drag state before showing context menus.

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20111.591  Build Date: Jan 5, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added Language property to allow control over the localization

  By default, the FlexGrid localizes the column filter editor to use the language
  specified by the CurrentUICulture setting. This property allows you to override that
  default and specify the language that should be used when the grid displays the
  column filter editor.

  The default setting for this property is "Default", which corresponds to the original
  behavior.

Corrections
-----------
- Fixed issue with designer persistence
  (was not working correctly for controls embedded in user controls).
- Improved AddNew behavior (allow cancelling by pressing escape even after edits).

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20111.589  Build Date: Dec 20, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V1/2011
- Show accurate page count in PrintDialog

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20103.587  Build Date: Dec 13, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added localization for Polish culture (pl)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20103.586  Build Date: Nov 30, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added Clipboard support methods: Cut(), Copy(), and Paste()

Corrections
-----------
- Improved Rtl support (TFS 13408)
- Improved handling of nullable types (TFS 13491)
- Clipboard support did not handle some SelectionMode settings correctly (Row/Rows/Column/Columns)
  (http://helpcentral.componentone.com/CS/winforms_31/f/8/t/87133.aspx)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20103.583  Build Date: Nov 22, 2010
=========================================================================================

Corrections
-----------
- Handle GDI exception when auto-sizing rows with empty cells (broken in build 405, TFS 4131).
- SelChanged event fired more often than needed with SelectionMode == ListBox and shift pressed.

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20103.581  Build Date: Nov 20, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added Microsoft Office 2010 visual styles.
  The VisualStyle property has three new settings that match the look of Excel 2010:
    Office2010Blue, Office2010Silver, and Office2010Black.


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20103.577  Build Date: Nov 8, 2010
=========================================================================================

Corrections
-----------
- Setting Redraw false/true did not always update scrollbars correctly (TFS 13328)
- Fixed issues with Node.FirstSibling Node.LastSibling properties (TFS 13325)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20103.576  Build Date: Nov 4, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Improved localization strings for the Column filters, added six new cultures:
  Danish, Finnish, Norwegian, Swedish, Arabic, Hebrew

  We also switched from user-provided localization to a professional translation
  service: Lionbridge (www.lionbridge.com).

Corrections
-----------
- Fixed issues with Node.NextVisibleNode Node.PrevVisibleNode properties (TFS 13218, 13219)
- Fixed issue with ScrollableRectangle while updating filter (TFS 13253)
- Fixed issue with Column.Editor in designer (TFS 9171)
- Clear method did not clear MergedRanges

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20103.570  Build Date: Oct 25, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added FilterDefinition property

  public string FilterDefinition { get; set; }

  This property gets or sets the current filter definitions as an XML string that can
  be used for persisting the grid state.

  NOTE: The FilterDefinition property only serializes the built-in filters. If your
  application uses custom filters, then you have to provide the custom serialization
  mechanism yourself.

- Added ShowSortPosition property

  public ShowSortPositionEnum ShowSortPosition { get; set; }

  This property specifies the position of the sort glyphs displayed in the header cells
  of sorted columns. Valid settings for this property are:

    None: Do not show the sort glyphs.
        This setting has the same effect as setting the ShowSort property
        to false. The ShowSort property is no longer necessary and has
        been deprecated.

    Right:  Show the sort glyphs on the right of the header cells.
        This setting restores the appearance the FlexGrid had before column
        filtering was added (in build 515).

    Top:  Show the sort glyphs on the top of the header cells.
        This setting became the default in build 515, when the right portion
        of the header cells was reserved to display the filter icons.

    Auto: Show the sort glyphs on the top of the header cells if the
        AllowFiltering property is set to true, and on the right
        otherwise.
        This is the default setting.

Corrections
-----------
- Fixed issues with new Node.NextVisibleNode Node.PrevVisibleNode properties (TFS 13149, 13150)
- Fixed selection behavior with SelectionMode = ListBox (issue introduced in build 568, TFS 13157)
- Before/AfterAddNew events did not fire after call to ReadXml (TFS 13078)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20103.569  Build Date: Oct 7, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added new settings for the NodeTypeEnum enumeration:
        FirstVisibleSibling, LastVisibleSibling, NextVisibleSibling,
    PreviousVisibleSibling, FirstVisibleChild
- Added new properties to Node class to reflect the new NodeTypeEnum settings:
  Node.FirstVisibleChild
  Node.NextVisibleNode
  Node.PrevVisibleNode

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20103.568  Build Date: Oct 5, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Made filter drop-down wider to better accommodate localization in certain cultures

Corrections
-----------
- More consistent selection behavior with SelectionMode = ListBox (TFS 3931)
- Cell content longer than 32k could cause GDI to throw (in Win XP only)
- BeginUpdate/EndUpdate did not always update scrollbars correctly


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20103.565  Build Date: Sep 17, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V3/2010

- Added IgnoreDiacritics property.
    This property determines whether the grid should ignore diacritics (accents)
  when filtering data. It is especially important in cultures that use accents
  extensively, such as French, Spanish, and Portuguese.

- Added support for Greek culture.
    The built-in filter now supports the following cultures:
  English, German, Dutch, Spanish, Portuguese, Italian, French, Russian, Japanese,
  Czech, Slovak, and Greek.

Corrections
-----------
- NewRowWatermark property was not working properly
- Filter glyphs did not paint correctly on merged column headers

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20102.558  Build Date: Sep 15, 2010
=========================================================================================

Corrections
-----------
- Setting IsNode to true when the parent node was collapsed left the new node
  permanently collapsed (http://helpcentral.componentone.com/CS/winforms_31/f/8/t/85172.aspx).

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20102.557  Build Date: August 16, 2010
=========================================================================================

Corrections
-----------
- Changing data source in BeginUpdate/EndUpdate block allowed some flicker
- Double-clicking the grid while resizing columns threw exception (11120)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20102.556  Build Date: July 19, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added support for Czech and Slovak cultures.
    The built-in filter now supports the following cultures:
  English, German, Dutch, Spanish, Portuguese, Italian, French, Russian, Japanese, Czech, and Slovak.

Corrections
-----------
- Show sort glyphs on last fixed row

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20102.554  Build Date: June 29, 2010
=========================================================================================

Corrections
-----------
- Fixed keyboard handling in RTL grids (reversed left/right arrow key behavior)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20102.553  Build Date: June 22, 2010
=========================================================================================

Corrections
-----------
- When scrolling large cells into view, the grid used the right/bottom of the cell instead
  of the top/left coordinates.
- Added new AggregateFlags.ExcludeCollapsedCells setting to exclude collapsed cells
  from aggregates.
- Added support for cell merging to Excel export.
- Added support for tree column indent to Excel export.
- Honor Rows.MaxSize/MinSize, Cols.MaxSize/MinSize when exporting to Excel.
- Fixed RTL printing support
- Improved painting outline tree when SubtotalPosition == BelowData

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20102.547  Build Date: June 4, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V1/2010 release

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20101.546  Build Date: May 24, 2010
=========================================================================================

Corrections
-----------
- Left/Right keys didn't cause the text editor to close correctly in RTL grids.
- SaveExcel VisibleOnly flag still exported collapsed rows.
- HasMorePages parameter in the PrintPage event was always set to false [10908]
- Cell merging was not honored in Excel export when using the VisibleOnly flag [10916]

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20101.543  Build Date: May 8, 2010
=========================================================================================

Corrections
-----------
- Position of aggregate symbols in Excel export was not the Excel default (below and to the right of the data) [4953]
- PrintParameters.PageNumber was off by one [9911]
- ReadXML method did not work correctly for subtotal rows (broken in build 535) [10101]
- Updated some strings in German localization files
- Grid was not showing cell contents if the associated DataMap did not contain the key [9927/9928]
- Adding rows (or nodes) as children of collapsed nodes did not hide the new row correctly [10577]


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20101.541  Build Date: May 5, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Enable filter localization: The filter will be localized automatically to these
  languages: English, German, Dutch, Spanish, Portuguese, Italian, French, Russian, Japanese

  Filter localization is based on the current thread's CultureInfo setting.
  To test localization for a specific culture, add the following to the application's
  startup code:

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
      // TO TEST LOCALIZATION
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20101.540  Build Date: May 1, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added .NET 4.0 version (with separate designer to support for Client profile)
- Added new properties to Node object:
  FirstChild, LastChild, FirstSibling, LastSibling, Index
- Added new FlexGrid.Nodes property:
  returns an array with all level zero nodes on the grid.
- Improved masked editor to allow mixed forced case
  (e.g. ">LL<LL<>LL": 2 uppercase, 2 lowercase, 2 any case)

Corrections
-----------
- ValidateEdit sometimes passed wrong value in CheckBox parameter when checking multiple cells at once
- Optimized SetCellImage not to invalidate if setting the same image
- Numeric editor did not handle formats that start with multiple zeros (e.g. "000.000") [10332]
- Adding rows to collapsed nodes created invisible (instead of collapsed) rows [10577]
- SaveExcel could throw with OwnerDraw (broken in 533) [10559]
- Use themes for painting outline ButtonBar

/////////////////////////////////////////////////////////////////////////////////////////
//
// Below this point all builds are for .NET 2.x only
//
/////////////////////////////////////////////////////////////////////////////////////////

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20101.535  Build Date: April 6, 2010
=========================================================================================

Corrections
-----------
- ReadXml did not always honor international locales correctly

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20101.533  Build Date: March 25, 2010
=========================================================================================

Corrections
-----------
- Honor OwnerDraw when exporting the grid to Excel
- Fixed rare issue with row invalidation
- Improved performance of grids with merged cells (TFS 9556)
- Fixed issue with numeric editor (TFS 9180, broken in 525)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20101.532  Build Date: March 17, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added FindRowRegex method to simplify looking for rows using regular expressions.

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20101.531  Build Date: March 12, 2010
=========================================================================================

Corrections
-----------
- Fixed default alignment when editing empty numeric cells with numeric editor
  (should align to the right)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20101.530  Build Date: March 04, 2010
=========================================================================================

Corrections
-----------
- Improved performance when adding/removing unbound columns (9049)
- BeforeFilter and AfterFilter were firing too often in some cases (8979)
- Fixed design time drag-drop logic (7899)
- Fixed painting of selected column header when Cols.Fixed == 0 (7007)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20101.527  Build Date: February 10, 2010
=========================================================================================

Corrections
-----------
- "General" Excel format was not handled correctly by the Excel filter (8927)
- BeforeFilter and AfterFilter were firing too often in some cases (8979)
- Setting AllowFiltering = false did not cause all rows to become visible (8986)
- Outline buttons did not work correctly in some merge scenarios

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20101.525  Build Date: February 1, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added RightToLeft support (important for Hebrew and Arabic systems)

Corrections
-----------
- Numeric editor did not handle single zeros for "n*" formats
- Mouse wheel did not work properly for Delta < 120
- CellLabel showed mnemonics
- Setting e.Order == SortFlags.None in BeforeSort did not remove the sort

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20101.515  Build Date: January 2, 2010
=========================================================================================

- V1/2010

- Added built-in column filtering:
  new properties
    bool grid.AllowFiltering
    AllowFiltering column.AllowFiltering
    IC1ColumnFilter column.Filter
  new method
    grid.ApplyFilter()
  new events
    grid.BeforeFilter/AfterFilter
  new classes/interfaces
    IC1ColumnFilter
    IC1ColumnFilterEditor
    ValueFilter
    ConditionFilter
    ColumnFilter
- column filtering supports automatic localization for the following languages:
  English, Spanish, French, Italian, Portuguese, German, Dutch, Russian, and Japanese.
- icons used in column sorting may be customized using the Glyphs property:
   Glyphs[FilterEditor], Glyphs[FilteredColumn]

- New Node object properties: Parent, PrevNode, NextNode, Nodes, Checked
- New BeginUpdate/EndUpdate methods (Redraw property is still available)
- New data binding events: DataMemberChanged, DataSourceChanged, DataBindingComplete
- New editing event: CellChecked
- General improvements
  Improved painting with system themes
  Improved drag/scroll behavior
  Narrower default width for first fixed column
  Changed default value of AutoResize property to false (better performance by default)
  Made GridRendererOffice2007 non-abstract so it can be used without inheritance

- See samples that demonstrate the new features:
  * Column filtering: ColumnFilters, CustomFilters
  * Node object: TreeCheck
  * Renderers and Visual Styles: GridRenderer

- Potentially breaking changes:

  1) Narrower default width for first fixed column
    By default, the first fixed column is 1/3 the width of the regular columns.
    To restore the old behavior, use this code:

    // initialize width of the first fixed column to match
    // all other columns
    _flex.Cols[0].Width = _flex.Cols.DefaultSize * 3;

  2) Changed default value of AutoResize property to false (better performance by default)
    To restore the old behavior, use this code:

    // autosize all columns when the grid is bound to a new DataSource
    // (time-consuming for large data sources)
    _flex.AutoResize = true;

  3) Changed Row.Visible property to work independently of Node.Collapsed.
    In previous versions, rows in collapsed nodes returned Visible = false
    In this version, the Visible property is used by the filtering feature
    and operates independently of the outlining feature.
    This change was made to support the new filtering feature in grids with
    outlines.
    It may break existing applications that use outlining features and rely
    on the Row.Visible property returning false for collapsed rows.
    To minimize the impact of this change on existing apps, we added a new
    IsVisible property (read-only) that returns true if the row is not
    collapsed and its Visible property is set to true.

Corrections
-----------
- Fixed TFS issues
  8262, 8226, 8222, 8386, 8330, 8262, 8267


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20093.429  Build Date: Nov 21, 2009
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added editing support for nullable types
  for example, if you set col.DataType = typeof(Nullable<int>) or col.DataType = typeof(int?),
  then users can set the cell to null by clearing the content of the editor.
- Added support for decimal measurements in PageSetupDialog.
- Added Highlight property to the GridRendererOffice2007 class to ease customization

Corrections
-----------
- BeforePageBreak event was not firing (7782, broken in build 422)
- PrintGridFlags not honored in PrintGrid (7311, broken in build 422)
- Improved validation in numeric editor (7424)
- WriteXml failed if invoked while column resize cursor visible (5504)
- Improved scrolling logic to handle focus/capture loss while scrolling (5526)
- FormatString dialog showed a "Null Value" field that was not used (5140)
- ValidateEdit fired three times on DateTimePicker when user pressed enter and the validation failed

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20093.424  Build Date: Sept 9, 2009
=========================================================================================

Corrections
-----------
- Updated Excel filter.
- Improved clipboard handling for cells containing tab or line break characters.
- Fixed invalidation problem that affected merged cells (broken in build 417).

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20093.422  Build Date: August 8, 2009
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V3/2009

** New properties and methods in the CellStyle class:

  CellStyle.StringFormat
  Gets the StringFormat object used to format the text content of cells.

  CellStyle.GetTextRectangle
  Gets the portion of the cell where text is displayed (bounds minus margins and borders).

  CellStyle.GetImageRectangle
  Gets the portion of the cell where images are displayed (bounds minus margins, borders, and text).

  These additions enables caller to draw adornments on the cell contents, including for example
  wavy underlines under misspelled text (the Graphics.MeasureCharacterRanges method requires a
  StringFormat object and a rectangle).

** New PrintDocumentGridRenderer class:

  This class is used to render grids into PrintDocument objects. The FlexGrid always
  provided a PrintGrid method which is still available. That is the easiest way to
  print and preview a grid. For example:

  void button1_Click(object sender, EventArgs e)
    {
    c1FlexGrid1.PrintGrid("Traditional",
      PrintGridFlags.FitToPageWidth |
            PrintGridFlags.ExtendLastCol |
            PrintGridFlags.ShowPreviewDialog);
  }

  This method automatically creates and prepares a PrintDocument object that contains
  a single FlexGrid. But it does not allow you to combine the grid with other content
  elements on the document, including other grids. That is the purpose of the
  PrintDocumentGridRenderer class. For example, the code below renders two grids into
  a single existing PrintDocument:

  // event handlers for the "PrintDocument" object on the form
    PrintDocumentGridRenderer _g1, _g2;
    void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
    // create and configure grid renderer for the first grid
        _g1 = new PrintDocumentGridRenderer(c1FlexGrid1);
        _g1.Options = PrintGridFlags.FitToPageWidth | PrintGridFlags.ExtendLastCol;

        // create and configure grid renderer for the second grid
        _g2 = new PrintDocumentGridRenderer(c1FlexGrid2);
        _g2.Options = PrintGridFlags.FitToPageWidth | PrintGridFlags.ExtendLastCol;
  }
    void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
    // render first grid
        if (_g1.CurrentPage < _g1.PageCount)
        {
      _g1.PrintPage(e);
            e.HasMorePages = true;
    }

        // render second grid
        else if (_g2.CurrentPage < _g2.PageCount)
        {
      _g2.PrintPage(e);
            e.HasMorePages = _g2.CurrentPage < _g2.PageCount;
    }
  }

** New Renderer property:

  The Renderer property is similar to the one available in the ToolStrip control.

  It allows you to create classes that take over rendering the grid and replace the
  need to set up individual cell styles. You can define renderers and share them easily
  across the enterprise, ensuring a consistent and professional look for your grids.

  The Renderer property leverages the rendering engine used to implement the VisualStyle
  property. The Renderer property is a C1FlexGridRenderer object, the base abstract type
  from which all grid renderers inherit. The C1FlexGrid also provides an easy-to-use
  GridRendererOffice2007 type which inherits from C1FlexGridRenderer and uses a set
  of 25 colors to create all the gradients and images used to implement the MS Office 2007
  visual styles (blue, silver, and black).

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20092.418  Build Date: July 31, 2009
=========================================================================================

Corrections
-----------
- Cell invalidation could fail when using the new AllowMergingFixed property.

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20092.417  Build Date: July 16, 2009
=========================================================================================

Corrections
-----------
- Cell invalidation could fail when using the new AllowMergingFixed property.

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20092.415  Build Date: June 19, 2009
=========================================================================================

Corrections
-----------
- Selecting fixed cells in code when EditFlags.EditOnRequest set to false caused the
  fixed cell to enter edit mode.

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20092.414  Build Date: May 13, 2009
=========================================================================================

Corrections
-----------
- Improved autosizing compatibility with and without merging
- Fixed some issues that affected the Japanese build only
- Improved rendering of header cells when VisualStyle = Office*

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20092.407  Build Date: May 8, 2009
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V2/2009

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20091.405  Build Date: May 6, 2009
=========================================================================================

Corrections
-----------
- Honor Row.AllowEditing and Col.AllowEditing in multi-check actions.
- Handle GDI exception when auto-sizing columns that contain extremely long strings (TFS 4131).

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20091.403  Build Date: March 23, 2009
=========================================================================================

Corrections
-----------
- Some clipboard keys were not working in the numeric editor (TTP 18976).
- Loading Excel sheets could occasionally load extra empty rows/columns (TTP 18536).

Documentation/Behavior Changes
-------------------------------------------
- Changes in the Japanese version only

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20091.401  Build Date: March 7, 2009
=========================================================================================

Corrections
-----------
- Fixed column visibility issue in Excel output filter (XLSX)
- Improved rendering with Office VisualStyles:
  - honor FocusRect = None
  - highlight row headers when SelectionMode = ListBox

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20091.399  Build Date: February 26, 2009
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added a new overload to the SaveExcel method:

  public void SaveExcel(string fileName, string sheetName, FileFlags flags, PrinterSettings ps)

  The new PrinterSettings parameter allows the caller to specify page settings to be
  used as defaults for the Excel sheet. The caller may specify paper size, orientation,
  margins, etc.

  For example:

        var ps = new System.Drawing.Printing.PrinterSettings();
        ps.DefaultPageSettings.Landscape = true;
        ps.DefaultPageSettings.PaperSize = ps.PaperSizes[2];

        _flex.SaveExcel("MyBook.xls", "Sheet1", C1.Win.C1FlexGrid.FileFlags.None, ps);

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20091.395  Build Date: January 7, 2009
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V1/2009

- Added NewRowWatermark property
  This new property allows you to specify a string that is displayed in the new
  row template that appears when the AllowAddNew property is set to true.

- Added ClipboardCopyMode property
  This new property allows you to configure the grid so the column and/or row
  headers are included in the data provided by the Clip property and also in the
  content copied to the clipboard when the AutoClipboard property is set to true.

- Added RowValidating and RowValidated events
  These events fire when the grid loses focus or when a different row is selected.
  They allow you to perform row-level validation and optionally prevent the user
  from leaving a row if it fails validation.

- Added BeforeSubtotal and AfterSubtotal events
  These events fire before and after each subtotal row is created after a cell to
  the Subtotal method.
  They allow you to customize the subtotal rows and modify their style, content,
  or suspend the creation of some subtotal rows altogether.

- Added AllowMergingFixed property
  This property allows you to specify different merging modes for fixed and
  scrollable cells. It is especially useful in situations where you want to
  merge column headers using one merge mode and data using a different mode.

- Added more options to EditOptions property
  The EditFlags enumeration has two new settings:

  ** EditFlags.ExitOnLeftRightKeys:
  When this flag is set to true (the default  setting), the built-in text and
  numeric editors exit edit mode if the user presses the left arrow key when
  the caret is at the first position or when the user presses the right key
  and the caret is at the last position (TextLength).
  When this flag is set to false, the built-in text and numeric editors do not
  exit edit mode until the user presses enter or clicks a different cell.

  ** EditFlags.EditOnRequest:
  When this flag is set to true (the default  setting), the grid does not enter
  edit mode until the user starts typing or double-clicks a cell (Excel behavior).
  When this flag is set to false, the grid enters edit mode automatically
  whenever it gets the focus or the selection changes (Access behavior).


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20083.392  Build Date: October 30, 2008
=========================================================================================

Corrections
-----------
- Fixed issue with format exporting in Excel output filter

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20083.391  Build Date: October 20, 2008
=========================================================================================

Corrections
-----------
- Fixed issue with scrollbars and ScrollByRowColumn (ttp id 18072)
- Removed Console.WriteLine debug statements from numeric editor (ttp id 18324)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20083.390  Build Date: October 8, 2008
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Enable horizontal scrolling at design time (to facilitate setting column properties)
- Improved color palette mapping algorithm in Excel export


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20083.389  Build Date: September 15, 2008
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Improved Accessibility notifications (test with Windows Narrator)

Corrections
-----------
- Fixed issue with drop down list
  (on some multi-monitor systems, the drop down appeared in the wrong location)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20083.387  Build Date: September 2, 2008
=========================================================================================

Corrections
-----------
- Improved Excel OpenXml filter
- Allow empty nodes to spill (fixes problem with FlexGroup appearance when entries are empty)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20083.386  Build Date: August 13, 2008
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V3/2008 build

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20082.385    Build Date: August 5, 2008
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Enabled saving xlsx files with more than 256 columns/65k rows.

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20082.380    Build Date: April 22, 2008
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V2/2008 build

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20081.379    Build Date: March 23, 2008
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Updated GC licensing information

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20081.378    Build Date: February 27, 2008
=========================================================================================

Corrections
-----------
- SaveExcel() and SaveGrid() methods with FileFlags.AsDisplayed could throw internal
  exceptions which degraded performance (VNFLX000883)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20081.377    Build Date: February 6, 2008
=========================================================================================

Corrections
-----------
- MouseWheel event did not fire (broken on 241, issue VNFLX000753)
- Tab character sometimes had inconsistent behavior while editing cells (VNFLX000785)
- Fixed inconsistent behavior when last row was filtered out of view by editing and AllowAddNew == true (VNFLX000818)
- Could not use line buttons to scroll to first row/column when ScrollByRowAndColumn == true (VNFLX000828)
- Improved color mapping into Excel palette when saving to Excel (VNFLX000849)
- Numeric editor did not handle the minus sign correctly for some formats

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Improved built-in combo to avoid clipping the drop-down list at the edges of the screen

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20081.370    Build Date: January 19, 2008
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V1/2008 build

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20073.368    Build Date: January 3, 2007
=========================================================================================

Corrections
-----------
- Improved consistency in handling Enter/Escape keys in edit mode (VNFLX000860)
- Improved handling of custom type descriptors assigned to bound columns (VNFLX000867)
- Improved complex format handling in the numeric editor
- Improved efficiency when setting cell styles in merged grids
- Additional Japanese localization

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20073.361    Build Date: December 7, 2007
=========================================================================================

Corrections
-----------
- Numeric editor did not discard literals from format while initializing Text property

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20073.358    Build Date: November 15, 2007
=========================================================================================

Corrections
-----------
- Text was not always clipped correctly when UseCompatibleTextRendering = false (VNFLX000840)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20073.357    Build Date: October 10, 2007
=========================================================================================

Corrections
-----------
- ParseString method fails to set the DataType of a Style when the DataType is ENUM or custom class
  (VNFLX000837)
- Cursor gets placed on the left side of ZERO when an empty NUMERIC cell with format (#)
  is edited with double click (VNFLX000838)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20073.356    Build Date: October 4, 2007
=========================================================================================

Corrections
-----------
- AutoSizeRows did not work correctly with Boolean cells and ImageAlign = CenterTop (VNFLX000831)
- CellLabels did not account for word-wrapping correctly in some scenarios (VNFLX000826)
- Excel filter did not honor the 'use 1904' date option when loading sheets created with Excel.


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20073.353    Build Date: September 25, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Improved built-in numeric editor to handle percentage formats

  In previous versions, the percentage format was removed when entering edit mode,
  and restored upon closing the editor. So if a cell showed "10%", the editor would
  show "0.1".

  Now the editor preserves the percentage while editing and shows "10%" while the
  value is being edited (like Excel does).

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20073.352    Build Date: August 1, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- V3/2007 build

- Added OpenXml support for loading and saving Excel Office 2007 files.

  Files with extensions "xlsx" or "zip" as recognized as OpenXml files by default.
  To save or load OpenXML files with other extensions, specify the new FileFlags.OpenXml
  flag in the SaveExcel or LoadExcel commands.

  OpenXml files are more compact than regular Excel files (xls) because they are
  compressed using the standard zip format. They are also easier to manipulate
  programmatically since the actual content is stored in Xml.

Corrections
-----------
- Added missing Japanese localization to color-picker in column designer.
- Prevent grid from invalidating when setting CellButtonImage in StartEdit

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20072.348    Build Date: July 31, 2007
=========================================================================================

Corrections
-----------
- Improved behavior of GetCellRect with merged cells (didn't always clip correctly)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20072.347    Build Date: July 3, 2007
=========================================================================================

Corrections
-----------
- Improved VisualStyle property integration with C1RibbonForm.
- Optimized handling of style changes in non-merging grids.
- Improved measuring items in multi-column drop-downs

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20072.345    Build Date: June 22, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Added Row.Grid and Column.Grid properties to allow retrieving a reference to the owner
  grid control from row and column objects.
- Added Japanese localization for new properties and events
- Improved VisualStyle notification mechanism

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20072.340    Build Date: May 29, 2007
=========================================================================================

Corrections
-----------
- Improved design-time behavior (prevent changes while app is running) (VNFLX000803).
- Decimal values with more than 15 digits got rounded off by grid editor (VNFLX000796).

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20072.338    Build Date: May 5, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Improved VisualStyle property (closer to Excel 2007 look, see VNFLX000798).
- Added VisualStyle property to smart tag designer (see VNFLX000807).
- Added fix for MouseWheel operation under 64-bit systems.
- Expanded Xml documentation.

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20072.336 Build Date: April 27, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * V2/2007 build.

 * Added VisualStyle property.

  This property takes a value from the VisualStyle enumeration and customizes the
  overall appearance of the grid to match commonly used visual styles.

  This is a fast and easy way to obtain high quality layouts without having to customize
  several individual properties and styles.

  Setting the VisualStyle on a C1FlexGrid will control the gradients and borders used
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

 * Added Rows.Add(count) and Cols.Add(count) methods.
   These methods are similar to InsertRange, but always append elements to the end of the
   collections instead of adding them at a specific position.

 * Added MouseEnterCell and MouseLeaveCell events.
   These events replace MouseHoverCell, which has been deprecated. It passes a
   RowColEventArgs which contains the row and column indices of the cell being entered/left.

Corrections
-----------
 * Improved performance when loading text files (VNFLX000794)
 * Improved drawing of sort glyph on merged column headers (VNFLX000788)
 * Improved error-checking in Node.Move method
 * Added extra sanity checks to FinishEditing method

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20071.329 Build Date: February 19, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Added extra check to printing code; if the user changes the page size halfway
   through the document, grid images will be reduced to fit the new page size as
   needed.

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20071.328 Build Date: February 19, 2007
=========================================================================================

Corrections
-----------
 * Improved handling of data exceptions when adding new rows
 * XP-style border did not always paint correctly while resizing the control.

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20071.326 Build Date: February 9, 2007
=========================================================================================

Corrections
-----------
 * Added extra sanity checks to OnBindingContextChanged

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20071.325 Build Date: January 31, 2007
=========================================================================================

Corrections
-----------
 * Added missing Japanese localization
 * Removed 'Update With Literals' checkbox from Styles dialog (VNFLX000780)
 * Resize cursor sometimes did not appear in multi-threaded .NET 1.0 apps (VNFLX000493)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20071.323 Build Date: January 15, 2007
=========================================================================================

Corrections
-----------
 * Ampersands rendered as shortcuts when UseCompatibleTextRendering = false
 * ScrollOptions.AlwaysVisible sometimes caused scrollbars to render without Visual Styles
 * SaveExcel skipped cells with no value and style != null (VNFLX000773/VNFLX000734)
 * Merging sometimes did not refresh correctly after edits (VNFLX000776)
 * In Japanese systems, Format designer font should be MS UI Gothic instead of Tahoma (VNFLX000778)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20071.319 Build Date: January 5, 2007
=========================================================================================

Corrections
-----------
 * SaveExcel slow when saving empty grid (VNFLX000645)
 * Input Mask dialog box showed inactive 'Update with literals' check box (VNFLX000701)
 * Some column properties (Name, DataType) not reset after setting DataSource = null (VNFLX000717)
 * Cannot delete numeric data by setting editor text to empty string (VNFLX000712)
 * FormatString dialog resetting format type when Custom format selected (VNFLX000770)
 * Extra columns added to grid when changing DataSource and preserving column layout (VNFLX000762)
 * Values formatted with scientific notation did not get saved to Excel correctly (VNFLX000715)
 * Excel files with Boolean values in the first columns don't get imported correctly (VNFLX000740)
 * Scrollbars property not always honored when ScrollbarOptions includes AlwaysVisible flag (VNFLX000732)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20071.318 Build Date: December 19, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added overload to _flex.Tree.Sort method:

  _flex.Tree.Sort(int level, IComparer comparer);

  This new overload takes a custom comparer as a parameter, much like the
  _flex.Sort(IComparer comparer) method.

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20071.317 Build Date: December 13, 2006
=========================================================================================

Corrections
-----------
* Improved thread-safety (Issue ID: 4766-36)
* Empty merged ranges were not being saved correctly to Excel (VNFLX000734)
* Improved designers (VNFLX000709, VNFLX000701)
* Fixed checkbox hit-testing in merged ranges (VNFLX000729)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20071.316 Build Date: December 5, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Updated GrapeCity licensing information

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20071.315 Build Date: November 7, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added some optimization to SaveGrid/Excel format (VNFLX000645)
* Removed 'Update with literals' check box from Input Mask dialog (not supported) (VNFLX000701)
* Improved behavior of font size control in grid designer (VNFLX000703)
* Improved SaveExcel behavior to honor NoFreezing flag in appearance as well as behavior (VNFLX000706)

Corrections
-----------
* Improved built-in numeric editor handling of formats that suppress zero display (#, #.##, etc)
* Mark bound row as modified before sorting with the mouse
* Improved handling of CellStyle.BackGroundImageLayout property (VNFLX000707)
* Value of the 'Cursor' property not retained (VNFLX000626)
* Xml serialization was not supported by the FlexGrid.Classic (VNFLX000631)
* Ensure reset mouse cursor after dragging partially visible columns (VNFLX000643)
* Error message when setting C1FlexGridClassic.GridLineWidth to a negative value was unclear (VNFLX000700)
* ScrollTips with tabs did not render correctly (VNFLX000705)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20071.313 Build Date: October 31, 2006
=========================================================================================

Corrections
-----------
* ComboBox did not paint image-map images correctly for columns with enum data types (VNFLX000696)
* Changing grid size did not update scroll position in some cases (bug introduced in build 310)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20071.312 Build Date: October 23, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* T1/2007 build
* Added new value to AggregateFlags enumeration:
  AggregateFlags.ExcludeHiddenCells

Corrections
-----------
* Sort glyph was not always displayed correctly in merged cells.


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20063.311 Build Date: October 19, 2006
=========================================================================================

Corrections
-----------
* Bound grid didn't invalidate CheckBoxes immediately after editing (broken in build 301)
* Obsolete property ScrollTips was still being persisted


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20063.310 Build Date: October 5, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Some optimization in control creation/loading time.

Corrections
-----------
* Ensure custom merge ranges are normalized to prevent endless loop when drawing the grid.
* Always finish editing when items are picked from ComboBox.


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20063.308 Build Date: September 29, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Improved value type coercion performance (especially noticeable when loading formatted strings, VNFLX000628)
* Improved automatic paste logic to honor data mapped cells.

Corrections
-----------
* Fixed xml serialization problem introduced in build 300.


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20063.305 Build Date: September 13, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Improved ComboBox performance when using large DataMaps (500+ items)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20063.304 Build Date: September 8, 2006
=========================================================================================

Corrections
-----------
* User controls didn't always behave correctly when scrolling the grid.


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20063.303 Build Date: August 31, 2006
=========================================================================================

Corrections
-----------
* Not able to edit CheckBoxes with the mouse if cell is clipped (VNFLX000339).
* Invalid chars in Excel 2000 export when cells contain '\r' character (VNFLX000557)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20063.302 Build Date: August 15, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Improved CellChanged event to pass the actual column that was changed in the e.Col parameter
  when the grid is bound to DataTable objects. (VNFLX000600)

  note: This improvement is available in the .NET 2.0 version only (it relies on the enhanced
  data binding notification mechanism added in .NET version 2.0).

* Improved AutoSizeCols() method to account for the space taken up by the sort glyph in the
  header cells (VNFLX000537).

Corrections
-----------
* Keep cell button visible while editing cells with PopupEdit style (ComboList = "|..."; broken in build 233, VNFLX000511)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20063.300 Build Date: July 31, 2006
=========================================================================================

* New Properties:

  --------------------------------------------------------------------------------
  - MergedRanges

  public CellRangeCollection MergedRanges { get; }

  Gets a reference to a collection of CellRange objects that determine which cells
  are merged when the AllowMerging property is set to AllowMergingEnum.Custom.

  This property enables custom merging without subclassing. In previous versions,
  custom merging required subclassing the grid and overriding the GetMergedRange
  method. This property allows you to provide a list of ranges that should be
  merged.

  Custom merged ranges are supported when saving and loading the grid to Excel
  (SaveExcel/LoadExcel) and Xml files (WriteXml/ReadXml).

  --------------------------------------------------------------------------------
  - ScrollOptions

    public ScrollFlags ScrollOptions { get; set; }

    Gets or sets flags that customize the grid's scrolling behavior. The ScrollFlags
    enumeration contains the following flags:

    AlwaysVisible = 1,    // keeps scrollbars visible even when they are not needed
    ScrollByRowColumn = 2,  // scrolls by row/column instead of by pixel
    DelayedScroll = 4,    // do not scroll while dragging the scrollbar thumb
    ShowScrollTips = 8,   // show a tooltip next to the vertical scrollbar

  This property provides options that were not available in previous versions,
  and also specifies options that had their own properties. The properties below
  are now obsolete:

    ScrollTrack       // ** obsolete: provided by ScrollFlags.DelayedScroll
    ScrollTips        // ** obsolete: provided by ScrollFlags.ShowScrollTips
    ScrollTipText     // ** obsolete: provided by the new ShowScrollTip event

  The BeforeScrollTip event was also replaced with the new ShowScrollTip event.
  The old event had two problems: (1) it used an external property (ToolTipText) to
  provide the event argument, and (2) it was a Before event with no matching After.

  The new ShowScrollTip event allows you to provide the tooltip text using an event
  parameter, which is much easier to understand and use. For example:

  // old code, obsolete
  void _flex_BeforeScrollTip(object sender, RowColEventArgs e)
  {
    _flex.ToolTipText = string.Format("row {0}", e.Row);
  }

  // new code
  void _flex_ShowScrollTip(object sender, ToolTipEventArgs e)
  {
    e.ToolTipText = string.Format("row {0}", e.Row);
  }

  --------------------------------------------------------------------------------
  - ScrollBarsVisible

    public ScrollBars ScrollBarsVisible { get; }

    Gets a ScrollBars value that indicates which scrollbars are currently visible.

    In previous versions, the caller had to compare the size of the control and its
    client area to find out which bars were being displayed. This property makes that
    unnecessary.

  --------------------------------------------------------------------------------
  - ComboBoxEditor

    public ComboBoxEditor ComboBoxEditor

    This new property provides easy access to the main properties of the active
    ComboBox editor control. It contains the following sub-properties:

    public int SelectedIndex
        public object SelectedItem
        public object SelectedKey
        public IList Items

  These properties get or set properties on the currently active ComboBox editor.
  They all cast the current editor to a ComboBox and then get or set the appropriate
  properties on the ComboBox object.
  If no editor is active, or if the editor is not a ComboBox, these properties return
  null or -1, and cannot be set.

    For example:

    // with the ComboBoxEditor property:
    Console.WriteLine("The current combo index is {0}",
    _flex.ComboBoxEditor.SelectedIndex);

    // without the ComboBoxEditor property:
    ComboBox cb = _flex.Editor as ComboBox;
    int index = (cb != null) ? cb.SelectedIndex : -1;
    Console.WriteLine("The current combo index is {0}",
    index);

  Note: This property is especially useful in VB, which doesn't currently have a
  conditional cast operator like 'as' in C#.

* New Settings:

  - AllowMergingEnum.Custom

    New setting for the AllowMerging property, allows specifying custom cell ranges for
    merging. This used to require subclassing the control and overriding the GetMergedRange
    method. The custom ranges are specified with the MergedRanges property.

  - FileFlags.LoadMergedRanges

    New setting for the LoadExcel flags parameter, allows loading merged cells from Excel
    sheets. If the Excel sheet being loaded contains merged cells, this flag sets the
    AllowMerging property to AllowMergingEnum.Custom and loads the merged cells into the
    MergedRanges collection.

  - FileFlags.IncludeMergedRanges

    New setting that combines SaveMergedRanges and LoadMergedRanges and can be used
    when saving and loading Excel files with merged ranges.

  - FileFlags.NoFreezing

    New setting that prevents the grid from freezing rows and columns when saving and
    loading Excel files. By default, fixed and frozen rows and columns are frozen when
    exported to Excel, and frozen rows and columns in Excel are frozen when imported
    into the grid.

  - EditFlags.DelayedCommit

    This setting is used with the EditOptions property to determine when changes are
    applied to the underlying data source.

    If the EditOptions value includes the DelayedCommit flag (the default setting does),
    then the grid uses the standard WinForms behavior and commits the changes only when
    the cursor moves to a new row or when the grid loses focus.

    If the EditOptions value does not include the DelayedCommit flag, changes are
    committed to the data source immediately after each edit.

 * New Classes:

  - CellRangeCollection
    Collection of CellRange objects, type of the new MergedCells property.

  - ComboBoxEditor
    Class used with the ComboBoxEditor property described above.

 * New methods:

  - Added three overloads to the Subtotal method that take column names instead of indices.
  - Added an overload to the ColumnCollection.IndexOf method that allows the caller to
    specify whether an exception should be thrown if the column cannot be found.
  - Added overloads to the LoadExcel and SaveExcel methods that allow the caller to specify
    flags and no sheet name.
  - Added an overload to the CellStyle.BuildString method that allows specifying which
    element flags should be represented in the string.

 * New Behaviors:

  - Honor DataColumn.Caption property when data binding.
    This is something that should happen automatically, but the PropertyDescriptor objects
    created by the DataTable do not set their DisplayName property correctly. So we added
    code to handle this specific case.

  - Freeze fixed and frozen rows and columns when exporting to and importing from Excel.
    This behavior can be changed using the new FileFlags.NoFreeze property.

  - Make sure strings with embedded line breaks are saved to Excel with WordWrap = true.
    C1FlexGrid always honors hard breaks, even if WordWrap = false. With this change, the
    Excel output is closer to the grid content.

  - Improved Subtotals to work with TimeSpan values.


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20062.263 Build Date: July 19, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* none

Corrections
-----------
* fixed design-time column style parser to handle multi-part formats
  (e.g. "0;(0);Zero", broken in build 250)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20062.261 Build Date: June 30, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* none

Corrections
-----------
* fixed CellLabel sizing on trees (with and without word-wrapping)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20062.260 Build Date: June 12, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* none

Corrections
-----------
* improved precision of built-in preview (fixes issue with DBCS and some font sizes / VNFLX000551)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20062.259 Build Date: May 31, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* none

Corrections
-----------
* 'Italics'/'Underline' buttons in Designer can't be toggled back (VNFLX000593)
* Localization code adjustment.


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20062.257 Build Date: May 24, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* none

Corrections
-----------
* Allow setting Editor property in derived classes, from OnStartEdit overrides
* Call OnBeforeEdit even if there's no registered handler (for consistency)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20062.256 Build Date: May 16, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* none

Corrections
-----------
* Some values do not display correctly using numeric keypad when currency format and EditOptions.UseNumericEditor is set. (VNFLX000585)
* The behavior of adding new rows from the other form is invalid. (VNFLX000573)
* Unnecessary columns are added when save the grid to.csv file with SaveGrid method. (VNFLX000554)
* Hidden Columns become visible at RunTime if made visible with 'Show Hidden Columns' option in the smart tag. (VNFLX000570)
* Hidden Columns can't be made visible by checking 'Display Hidden Columns' from smart tag of the C1FlexGrid if Column Designer is open. (VNFLX000567)
* Error message is displayed when clicking BackgroundImage ellipse in the Styles editor for every Style (VNFLX000566)
* Selection of control can't be done if the control's columns are not in the visible area. (VNFLX000565)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20062.255 Build Date: May 1, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* none

Corrections
-----------
* fixed problem with designer and Style.BackgroundImage (VNFLX000580)
* fixed problem with designer and 'unhide all columns' command (VSFLX000576)
* improved key handling for composite editors (see CompositeEditor sample)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20062.254 Build Date: April 17, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* none

Corrections
-----------
* AllowAddNew didn't always work when initializing with data source set at design time.
* Fixed problem in Excel import filter (didn't recognize all-uppercase date formats like M-DDD)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20062.253 Build Date: April 3, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* V2/2006 build


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20061.253 Build Date: March 30, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Improved Accessibility (for consistency with TDBGrid and MS DataGridView)

Corrections
-----------
* Improved numeric editor:
  - position cursor correctly when starting edits with '.' and value < 1 (Delta issue VNFLX000560)
  - honor KeyActionTab


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20061.252 Build Date: February 17, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added property: bool UseCompatibleTextRendering

  This new property determines whether the control should render text using the Graphics
  class (GDI+, compatible with previous versions, true by default), or the new
  TextRenderer class (GDI, available in .NET 2.0 and later).

  The TextRenderer class uses GDI, which supports complex scripts and the Uniscribe APIs,
  making it better for some international applications. GDI also supports hardware
  acceleration, but in my tests the new GDI rendering is about 25% slower than the
  compatible (GDI+) mode.

  This property was added so you can select the mode that matches other controls and
  dialogs in your application.

* improved licensing requires fewer permissions in partial-trust scenarios.


Corrections
-----------
* Ensure CellLabels appear on top of parent forms that have TopMost = true


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20061.251 Build Date: January 28, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* none

Corrections
-----------
* improved keyboard handling with drop-down editors
  (use alt-down instead of f4 to drop-down, in order to avoid possible conflicts with
  alt-f4, which is the form-close shortcut).


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.6.20061.250 Build Date: January 21, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* New properties:

   - ShowThemedHeaders:
     Allows you to control themed headers independently for rows and columns, and also
     independently of the BorderStyle property.

   - SortColumn:
     Gets a reference to the column that defines the current sort applied to the grid.
     This works regardless of the method used for sorting the grid (Sort method, clicks
     on header columns, or sorting the data source object).
     The user can determine the sort order by checking the value of the Column.Sort
     property.

   - Style.BackgroundImage, Style.BackgroundImageLayout:
     Specify images to be used as cell backgrounds. This can be used to provide advanced
     themes with custom borders, gradients, transparency, etc. There is also a new
     setting ImageAlignEnum.TileStretch that was added specifically to support cell
     backgrounds. This setting stretches the central portion of the image while keeping
     the original size of the edges.

   - Styles.SelectedRowHeader, Styles.SelectedColumnHeader
     Styles used to paint row and column headers that correspond to the selected cells,
     Excel-style.

* Built-in numeric editor:
    When editing numeric values, the grid will by default use its built-in numeric editor.
    The numeric editor honors the Format property assigned to the cell style (or column) and
    provides key checking, as-you-type formatting, and range checking (based on the cell type).

    You can disable the built-in numeric editor by setting the EditOptions.NumericEditor flag
    to false.

* Better Excel export:
  The new FileFlags.SaveMergedRanges flag allows saving merged ranges into XLS files.
  For example:

    _flex.SaveExcel(fileName, FileFlags.IncludeFixedCells | FileFlags.SaveMergedRanges);

* Better handling of Data-Mapped columns:
  Setting the DataType property of a column automatically sets it's Alignment property based
  on the data type. Now, setting the DataMap property has the same effect.

  This makes the control easier to use because in typical scenarios, DataMaps are used to
  translate numeric values (IDs, which are right-aligned by default) into strings (which
  are left aligned by default).

  For example, if a grid is bound to a 'products' table, the numeric 'CategoryID' column will
  be right-aligned By default. Assigning a DataMap containing strings to that column will
  automatically make the column left-aligned.

* Do not fire StartEdit and AfterEdit when the user clicks on button cells:
    In this case, only the CellButtonClick event is fired.

* Do fire StartEdit and AfterEdit when cutting/pasting with AutoClipboard or dragging/dropping

* .NET 2.0 version only ========================================================================

- Improved design-time support:
    1) Allow column resizing/dragging at design time
    2) Click the first scrollable cell in a row to show column ActionLists
    3) Improved column designer with ToolStrips,
       including ability to see invisible columns at design time

- Exposed the IC1EmbeddedEditor interface (public C1.Win.C1FlexGrid.IC1EmbeddedEditor):
    In .NET 1.0 builds, this interface was exposed by the C1Common assembly. The 2.0
    version of the grid no longer uses that assembly, and therefore exposes the interface
    definition to make implementation easier.

    Note that the methods in IC1EmbeddedEditor are called using reflection. Controls do
    not need to implement the entire interface. Any public methods with matching names,
    parameters, and return values will be recognized and invoked by the grid.

Corrections
-----------
* improved handling of BindingContext changes
  (important when adding grids dynamically to tab controls)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20061.236 Build Date: January 17, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Avoid marking rows as changed when user enters edit mode and then exits without
   actually changing the cell value (only happened with non-string/non-boolean values)

Corrections
-----------
 * Delta fixes:
   VNFLX000493: Resize cursor does not appear when the grid is running on a different thread
   VNFLX000503: Painting problems when scrolling grid with transparent fixed/frozen cells
   VNFLX000264: Multi-row cells are not saved/loaded correctly from CSV format
   VNFLX000265: same issue as VNFLX000264

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20061.235 Build Date: January 10, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Improved rendering of Xp-style borders:
  When XP styles are enabled and the BorderStyle property is set to XpThemes or
  FixedSingle, the theme color is used instead of SystemColors.WindowFrame.

Corrections
-----------
* Improved behavior when CellLabels is set to true:
  The labels are now hidden when the mouse leaves the control, preventing them from
  showing above popup dialogs and other controls contained in the grid)
  Also, avoid showing labels in some cases where the cell height is a couple of pixels
  too small (VNFLX000531)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20061.233 Build Date: December 15, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* V1/2006 build

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20053.233 Build Date: December 14, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Optimized Styles.ClearUnused method by an order of magnitude.
  This noticeably improves binding speed when there are many styles defined.
  (Sample available at site1/Test/BindWithStyles).

Corrections
-----------
* Improved behavior of mouse wheel handing in nested scrollable controls (test case MouseWheel)
* Delta issues:
  VNFLX000511 When editor is activated, the editing cell is blank.
  VNFLX000508 Drag-drop behavior with SelectionMode = Row/RowRange restored to v229 and earlier (cell-based).
  VNFLX000509 Designer unable to set Column.Editor property

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20053.232 Build Date: November 7, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* none

Corrections
-----------
* LoadGrid method was hidden from IntelliSense (because of an obsolete overload)
* Drag Drop displayed incorrect behavior when Selection mode is Rows (VNFLX000504)
* Link for About box was not displayed in Smart Tags (VNFLX000501)
* Some clipboard actions could delete the content of non-editable cells (VNFLX000396)
* Undesired behavior with invalid DisplayColumn parameter in MultiColumnDictionary ctor (VNFLX000486)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20053.231 Build Date: November 7, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* none

Corrections
-----------
* Show sort direction when clicking column headers even if there are no scrollable rows
  (same in unbound mode as with empty DataTable)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20053.230 Build Date: October 29, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Improved Japanese localization

Corrections
-----------
* Improved error-checking when setting bound cells to null (VNFLX000497)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20053.229 Build Date: October 19, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Improved CellLabel avoid interference with regular mouse operations
* Improved ComboBox editor to honor drop-down width on first use

Corrections
-----------
* AutoClipboard: cut/delete text only, not images (VNFLX000473)
* ReadXml: restore property defaults before loading data (VNFLX000476)
* CellLabels: sometimes showed when not needed (VNFLX000470)
* Fixed columns: honor DataType = typeof(bool) and show CheckBoxes (VNFLX000467)
* Row/Col.GetStyleDisplay: without custom style, return fixed/frozen/alternate as well as normal (VNFLX000464)
* Invalidate grid when setting AllowEditing (to refresh buttons) (VNFLX000479)
* ListBox selection: BeforeSelChange event did not fire under some circumstances (VNFLX000441)
* ListBox selection: improved drag-drop behavior when dragging/dropping within the same grid (VNFLX000445)
* Added extra checks for mouse/keyboard handlers while disposing of the control

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20053.227 Build Date: October 7, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Improved precision in Excel filter output of float values (VNFLX000463)

Corrections
-----------
* Hitting Escape key could move cursor up (bug introduced in build 224)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20053.226 Build Date: September 12, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * none

Corrections
-----------
 * improved exception handling in data binding code
 * added workaround for DataTable bug (returns ints for enum-type columns)
 * fixed problem with merge = spill/nodes and frozen columns

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20053.225 Build Date: August 24, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * none

Corrections
-----------
 * improved embedded editor handling to support compound controls (e.g. based on UserControl)
   now sends initial character to editor even if it is not a simple control
 * fixed problem with loading some Xml files created with WriteXml (VNFLX000418)
 * improved behavior of cancelling the addition of new rows when AllowAddNew is true (VNFLX000420)
 * added extra safety to ensure scrollbar's SmallChange is set to non-zero value
 * fixed problems with new ScrollTips (didn't support multi-line tips, VNFLX000427/VNFLX000428)
 * improved scrollbar update when binding to data sources that don't have IBindingList

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20053.221 Build Date: July 19, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * reset CharacterCasing and MaxLength in built-in editor before firing StartEdit

Corrections
-----------
 * fixed Styles.Clear to restore default font

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20053.220 Build Date: June 6, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * V3/2005 build

 * Added support for multi-column combos
  Multi-column combos are implemented with DataMaps that implement the new
  IC1MultiColumnDictionary interface.

  The MultiColumnDictionary class implements IC1MultiColumnDictionary and
  can be used as a multi-column data map based on string data or on data sources
  (any object that implements ITypedList).

  The MultiColumnDictionary class has two constructors.

  One constructor takes a string that contains a pipe-delimited list of items.
  Each item contains a tab-delimited list of columns. For example:

  // create string-based MultiColumnDictionary and assign it to column
  // note: this will automatically generate keys of type int for each item,
  // the key values will be stored in the grid.
  string text = "Row1, Col1\tRow1, Col2|Row2, Col1\tRow2, Col2";
  MultiColumnDictionary map = new MultiColumnDictionary(text, 0, true);
  _flex.Cols[1].DataMap = map;

  The other constructor takes four parameters: a data source, the name of the
  column that contains the data stored in the grid, a list of fields to display
  in the dropdown list, and the index of the column that should be shown in
  the grid when the list is closed. For example:

  // create data-based MultiColumnDictionary and assign it to column
  // note: the list will automatically be updated is the data source changes.
  DataTable dt = GetDataTable("employees");
  string[] columnNames = new string[] { "FirstName", "LastName", "Country" };
  MultiColumnDictionary map = new MultiColumnDictionary(dt, "EmployeeID", columnNames, 1);
  _flex.Cols[2].DataMap = map;

 * improved ScrollTips to work more reliably under Whidbey
 * improved CellLabels to avoid interference with column resizing
 * improved style persistence mechanism (mainly to support Whidbey, but also more compact and robust)
 * improved the way Excel export filter handles localized currencies (VNFLX000371)
 * improved AddNew behavior for more consistency with other grids (TDBG, MS DataGrid, MSAccess)
     before: a new row was added when the cursor moved into the new row template
     now: the new row is added when the user starts editing the new row template

 * exposed some useful methods that used to be protected or internal:
  bool    IsCellFixed(int row, int col)
  bool    IsCellCursor(int row, int col)
  bool    IsCellHighlighted(int row, int col)
  bool    IsCellValid(int row, int col)
  HitTestInfo HitTest() // no parameters, use current mouse position
  void    SetCellStyle(int row, int col, string styleName) // set style by name
  CellStyle Styles.Add(string name, string basedOn) // create style by name

Corrections
-----------
 * Do not show CellLabels in cells with CheckBoxes.
 * SetUserData(int row, string colName, object data) caused stack overflow.
 * Added clearer error message when setting Node.Data and Tree.Column is set to invalid column.
 * Improved consistency of selection/scrolling with merged cells (VNFLX000356)
 * Improved consistency of Restricted merging in fixed cells (VNFLX000341)
 * Fixed Read/WriteXml to include CellButtonPicture property (VNFLX000362)
 * Fixed Read/WriteXml to handle AllowAddNew grids better (was adding extra row) (VNFLX000383)
 * Fixed Read/WriteXml to handle empty styles (VNFLX000374)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20052.217 Build Date: June 2, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * None

Corrections
-----------
 * Fixed problem with loading quoted values from CSV files
 * Refresh row ErrorInfo when cells on the row change value

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20052.216 Build Date: May 9, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * none

Corrections
-----------
 * Improved error-checking for editors in case their row/column is deleted while editing
 * Allow CheckBoxes on fixed rows/columns

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20052.215 Build Date: May 9, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Improved security handling to allow running inside IE

Corrections
-----------
 * Fixed problem with images displayed in ComboBox items (VNFLX000347)
 * Improved Excel "SaveAsDisplayed" with data-mapped values


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20052.214 Build Date: April 25, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * none

Corrections
-----------
 * Allow Clip property to change non-editable grid content (like in builds before 200)
 * Improved parameter validation in Sort method
 * Improved handling of ShowCellLabels with cells that have hard line breaks


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20052.213 Build Date: April 15, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Added new ExtendLastCol setting to PrintGridFlags enumeration.
   This new setting causes the grid to extend the last column on each printed page.
   It can be used with the PrintGrid method and also with C1PrintDocument. For example:

    // print grid using PrintGrid method
    _flex.PrinGrid("mygrid",
      PrintGridFlags.ShowPreviewDialog | PrintGridFlags.ExtendLastCol);

    // print grid using C1PrintDocument
    _flex.PrintParameters.PrintGridFlags = PrintGridFlags.ExtendLastCol;
    C1PrintDocument c1pd = new C1PrintDocument();
    c1pd.StartDoc();
    c1pd.RenderBlockText("This is a C1PrintDocument.");
    c1pd.RenderBlockText(" ");
    c1pd.RenderBlockC1Printable(_flex, c1pd.BodyAreaSize.Width);
    c1pd.EndDoc();

   Note that this is completely independent of the ExtendLastCol grid property, which
   has no effect on printing.

Corrections
-----------
 * ComboCloseUp event didn't always fire when it should (VNFLX000291)
 * Pressing ctrl+tab could cause crash (VNFLX000290)
 * Scrolling with the editor active could mess up the display (VNFLX000285)
 * Moving selection with tab and activating editor on SelChange sent Tab to editor (VNFLX000284)
 * MouseLeave event didn't fire (VNFLX000317, broken in build 200)
 * WriteXml and ReadXml methods could create invalid Xml files (VNFLX000330, obfuscation issue)
 * Retain column selection when dragging to first position (VNFLX000299)
 * Tree.Clear method didn't refresh the display


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20052.211 Build Date: Mar 25, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * none

Corrections
-----------
 * AfterSelChange event sometimes didn't fire in ListBox selection mode (VNFLX000263)
   (happened when re-selecting a single row that had been de-selected with ctrl+click)
 * Allow merged node rows to scroll horizontally (VNFLX000247)
 * Account for trailing spaces when right-aligning (good for numbers, e.g. "#.## ;(#.##)")


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20052.210 Build Date: Feb 20, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * V2/2005

 * New Methods

  - ReadXml, WriteXml
    Serialize grids into Xml documents.
    The grid serializes all its contents (control properties, grid layout, styles, and data).

  - GetUserData/SetUserData
    These new methods make all cell information accessible directly through the grid's
    object model.
    In previous versions, the cell's UserData value was accessible only through CellRange
    objects. With this addition, all cell information can be read or set directly
    (Get/SetData, Get/SetCellImage, Get/GetCellCheck, Get/GetCellStyle, and
    Get/SetUserData).

  - Tree.Clear
    New method for resetting the Tree object.


Corrections
-----------
 * handle Combos with transparent background
 * handle TextAlign in built-in editor


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20051.207 Build Date: Feb 2, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Allow combos in fixed cells (for use with StartEditing)
 * Modified licensing to enable automated testing scenarios (NUnit, C1Test)

Corrections
-----------
 * improved column persistence to work better with WinRes (again)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20051.205 Build Date: January 9, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Enhanced Accessibility compliance. The grid now has a custom AccessibleObject that
   exposes the grid contents (rows, columns, and cells) as a collection of AccessibleObjects.

Corrections
-----------
 * fixed design-time handling of BindingContextChanged notification
   (design-time column layout could be lost on grids within tab pages)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20051.203 Build Date: January 7, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * improved CellLabels to account for work-wrapping, outlines, prevent flicker
 * improved button-bar rendering when BorderStyle = XpThemes.

Corrections
-----------
 * fixed row add optimization introduced in build 200, caused problems when clearing and
   re-populating data tables while the grid was bound to the tables.
 * border style = XpThemes now uses a solid single border (previously used a non-xp light 3d style)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20051.200 Build Date: January 4, 2005
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------

 * New settings:

 - BorderStyle.XpThemes
   Causes the control to use Xp themes to display fixed cells, including hot-tracking

 * New properties:

 - ShowCellLabels
   Displays a tooltip-style label when the mouse is over cells that are too small to
   display their contents.

 - AutoGenerateColumns
   Determines whether the grid should update its column collection when it is
   assigned a new DataSource.

 * New events:

 - MouseHoverCell
   Fires when the mouse hovers over a cell.

 - OnGetCellErrorInfo(GetErrorInfoEventArgs e), OnGetRowErrorInfo(GetErrorInfoEventArgs e)
   Fires when ShowErrors is true and the control needs error information for a cell or a row.
   The grid always supported the IDataErrorInfo interface, which allows the grid to show
   error glyphs in cells and row headers, and to show a tooltip with error information when
   the mouse hovers over the error glyph. However, not all data sources support IDataErrorInfo
   (DataTable is the only common class that does).
   These events allow you to add custom error information to any data source and to unbound
   grids.

 * improved column localization to work with WinRes (VNFLX000249)
   (control must be in the GAC, edit columns using "Edit Columns" verb)
 * optimized populating hierarchical grids (VNFLX000257)

Corrections
-----------
 * improved behavior of SelectedRowsOnly in ListBox mode when saving to Excel.
 * fixed Rows.Add() and Sort() methods when AllowAddNew = true
 * prevent pasting into cells that are not editable (done with the Clip property)
 * improved serialization of Column.Editor property set at design time


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20044.197   Build Date: December 12, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * none

Corrections
-----------
 * improved translation of custom time formats into DateTimePicker editor
 * improved handling of OnBindingContextChanged notification (broken in 195)
 * fixed printing when Cols.Fixed == 0 and columns on the last page are invisible


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20044.194   Build Date: November 13, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * improved behavior of Esc key when editing dates on dropped down calendar
 * improved handling of Tab key in apps that have their own message loop
 * faster scrolling with merged ranges
 * prevent style/column editor from displaying while the control is running (can't be edited)
 * interpret time format and use it to show up/down buttons in DateTimePicker

Corrections
-----------
 * honor calls to FinishEditing from StartEdit event handler
 * drop down combos when starting to edit with Enter key
 * When an item value of ComboBox was chosen with Arrow keys ValidateEdit event could fire twice. (VNFLX000068)
 * Could move to invisible rows using PageUp and PageDown keys.  (VNFLX000071)
 * Pressing "PageUp" could throw exception when there are no scrollable rows.  (VNFLX000075)
 * Tab key modifiers not passed correctly in KeyDownEdit with ComboBox editor.  (VNFLX000077)
 * ScrollTips didn't always show unless the tip text was changed.  (VNFLX000079)
 * Setting rows.Count = rows.Fixed = n could leave the focus in a fixed row.  (VNFLX000080)
 * Use only solid colors to match WinForms appearance.  (VNFLX000083)
 * Setting DataType = boolean at design time disabled ImageAlign settings.  (VNFLX000084)
 * ComboBox did not retain typed values if closed by clicking another cell.  (VNFLX000086)
 * Merged column headers didn't always show sort glyph.  (VNFLX000085)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20044.192   Build Date: October 13, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * improved date formatting in Japanese locales
 * allow loading Excel books even while they are open in Excel

Corrections
-----------
 * adding child nodes to collapsed parent nodes didn't hide the new nodes as it should


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20044.190   Build Date: October 7, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * improved behavior of list box editor when closing without making a selection

Corrections
-----------
 * fixed problem with new merging code in grids with no rows (problem introduced in build 189)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20044.189   Build Date: September 21, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Optimized Tree.Sort method (by an order of magnitude).
 * Optimized merged scrolling (a fair amount).
 * Allow user to select page range when printing the grid
   The page range option was disabled in the dialog, and not honored when set
   in the PrintSettings object. It is now supported.
 * Added a new flag to PrintGrid method: PrintGridFlags.ShowHighlight
   By default, the grid will no longer show the selection when printing.
   To show the selection, set the new PrintGridFlags.ShowHighlight flag in the
   call to PrintGrid.
 * Added style preview to design-time Style Editor.
 * Fire GridError event on printer errors, allow user to handle

Corrections
-----------
 * cancel auto-search on mouse clicks
 * improved painting of OutlineTree (no DBCursor, clip wide trees)
 * improved painting of rows that are invisible but merged
 * improved hit-testing on intersection of fixed rows/columns (could not resize all fixed rows)
 * fixed Rows.CopyTo method
 * fixed initial display of ButtonBar when adding deep nodes
 * fixed style persistence in Classic
 * fixed index-checking on setting Row.Caption property
 * fixed index-checking on Rows.RemoveRange method
 * fixed RemoveNode method when SubtotalPosition == BelowData
 * fixed automatic drag/drop with ClipSeparators set to custom value
 * handle latest .NET 1.0 revision (1.0.3705.6018) which fixes the ComboBox control


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20044.187   Build Date: July 25, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Update AssemblyVersion on every drop (stop using File/Assembly versions)
 * Added PicturesOver property to C1FlexGrid classic (uses CellStyle.Display property)

Corrections
-----------
 ** Improved editing with Hiragana characters
 ** Adding nodes with collapsed siblings sometimes made the new node invisible
 ** Editing merged/frozen cells sometimes showed editor in wrong position (broken in 153)
 ** Improved handling of current row when bound to filtered DataViews
 ** StartEdit fired twice when toggling CheckBoxes
 ** Fixed Style designer (didn't reset TextDirection)
 ** Fixed Column designer (didn't reset column captions)
 ** Setting ScrollBars property didn't update control immediately
 ** Column.Clear(ClearAll) method didn't clear column Name property
 ** Fixed painting problems when Normal.BackColor = Fixed.BackColor
 ** Setting the Column.DataType property didn't update TextAlign for all numeric types
 ** Glyphs (cursor, sort) didn't always display correctly on merged grids
 ** Removed Row/Column objects didn't reset the Index property to -1
 ** Setting style colors could fail if the style inherited the same color from parent style
 ** Fixed memory leak caused by setting DropMode property != None
    (workaround was to set DropMode = None at Form_Closing event)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20044.185   Build Date: July 25, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Q4/2004 build

Corrections
-----------
 ** none


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20043.185   Build Date: July 24, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * none

Corrections
-----------
 ** improved .NET to Excel style translation (previous version didn't properly account for style hierarchy)
 ** improved fix made to ShowCell method in build 181


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20043.183   Build Date: July 19, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * none

Corrections
-----------
 ** improved .NET to Excel format translation (for formats such as f2 and no DataType specified)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20043.182   Build Date: July 16, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * none

Corrections
-----------
 ** fixed AutoSizeRows/Cols on owner-drawn merged grids.
 ** cancel AddNew when the control loses focus and the new row is empty
  (this is the MS DataGrid behavior)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20043.181   Build Date: July 13, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * improved column editor dialog:
  the property grid now shows nested as well as root-level controls for the Editor property
 * spill merges now take images into account

Corrections
-----------
 ** fixed painting of editor drop-down buttons when ShowButtons == Always and using ComboList property
 ** honor calls to ShowCell even when the grid is invisible


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20043.178   Build Date: June 24, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * improved .NET to Excel format translation
 * honor property window Reset on Back/ForeColor properties

Corrections
-----------
 ** some fixes to column editor:
  - handle remove all columns/then add
  - handle enter key while editing column headers
  - restore frozen columns on Cancel


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20043.176   Build Date: June 1, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Q3/2334 drop
 * added support for calculating aggregates on custom types that implement IConvertible

Corrections
-----------
 ** fixed AutoSize method in C1FlexGrid.Classic (autosize rows didn't work correctly)
 ** handle error that occurred when setting Styles.EmptyArea.Border = None and frozen rows/cols
 ** fixed painting problem with partial cells when Styles.Normal.BackColor == Styles.Fixed.BackColor
 ** fixed editing problem with some international characters (e.g. most Russian chars)
 ** fixed problem dropping down empty lists (showed a big empty drop down area)
 ** fixed problem with popup buttons in narrow columns (could fail to fire the CellButtonClick event)
 ** small improvement to handling of page up/page down keys


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20042.175   Build Date: June 1, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * none

Corrections
-----------
 ** improved reading Excel links (written out with Excel)
 ** improved behavior of StartEdit event with ComboList property
 ** column editor cleared the data source


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20042.173   Build Date: May 31, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * none

Corrections
-----------
 ** starting custom editors on off-view cells threw exception
 ** improved handling of default keys used with validation


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20042.172   Build Date: May 15, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * honor SelectedRowsOnly flag in Excel export

Corrections
-----------
 ** keep caret visible while editing masked content
 ** added extra check when disposing of XP theme handles


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20042.171   Build Date: May 5, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * none

Corrections
-----------
 ** editing failed when first character was '('
 ** improved handling of KeyAction.MoveAcrossOut with custom editors
 ** improved excel export with AsDisplayed and OwnerDraw styles
 ** fixed dimension check on Excel export (broken in 170)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20042.169   Build Date: April 25, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * SaveExcel now honors VisibleOnly flag
 * Added new value to the AggregateFlags enumeration:
  AggregateBooleans causes the control to include boolean cells in aggregates:
    true values count as 1, false as 0. For example, you can get the number of
    checked cells in a range using:

    // sum values in the range, count true values as 1
    double sum = _flex.Aggregate(AggregateEnum.Sum, 1, 1, 49, 1,
              AggregateFlags.AggregateBooleans);

Corrections
-----------
 ** Improved handling of tab key while editing (back-tab didn't work reliably)
 ** Improved painting of merged fixed cells
 ** Allow data-mapping on fixed cells
 ** CellChanged fired even when assigning the original value to a cell
 ** Invalidate rows/cols after changing their style


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20042.167   Build Date: April 13, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Added new element to FileFlags enumeration:
  FileFlags.AsDisplayed causes the grid to save the cell's display contents to Excel
  files rather than the internal values.
  For example, columns with DataMaps will save the dictionary keys by default,
  but if the AsDisplayed is set it will save the dictionary value instead.
  The AsDisplayed flags also honors cell contents and styles set in the OwnerDrawCell
  event handler.
 * Added new event: LeaveEdit(object sender, RowColEventArgs e)
  This is similar to AfterEdit, except it also fires when the editing is canceled
  (AfterEdit doesn't).

Corrections
-----------
 ** fixed error-handling for some data-bound scenarios
    (wasn't catching and firing GridError, broken in 153)
 ** allow adding unbound columns at design time using column designer
 ** checkbox hit-testing was off with outline trees
 ** added extra checks to IDataErrorInfo handlers


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20042.166   Build Date: April 13, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * none

Corrections
-----------
 ** fixed vertical scrollbar ComboBox editor (didn't show even with many items)
 ** honor generic number ("n") in excel export filter
 ** improved handling of Tab keys with 3rd party editors

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20042.164   Build Date: April 3, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Exposed BeforeDoubleClick event
  (allows user to cancel double-clicks before auto-sizing or entering edit mode)

Corrections
-----------
 ** Excel filter failed with empty strings
 ** improved clipping of merged cells
 ** fixed behavior of KeyActionTab when the first column is invisible and user tries to back tab out of the grid.

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20042.163   Build Date: March 28, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * none

Corrections
-----------
 ** selection events fired too often when adding rows
 ** SaveGrid with SelectedOnly flag always saved first scrollable row (even when not selected)
 ** fixed obfuscation problem that affected ComboBox editor behavior


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.5.20042.161   Build Date: March 9, 2004
=========================================================================================

 ** 2.5: Updated AssemblyInfo, requires rebuilding existing apps.

    This new version has an expanded object model, with new methods to support
    saving and loading Excel files, custom editors, and other new features
    described below.

  To use this new build in existing applications, you should open the
  project, select the "References" node in the Project Explorer and replace
  the reference to the older version of the grid.

Enhancements/Documentation/Behavior Changes
-------------------------------------------

  ** New Methods

    ** FlexGrid class:

    - public void SaveGrid(string fileName, FileFormatEnum format, [FileFlags flags, Encoding encoding])
    Replaced the 'fixedCells' parameter with a more general 'flags'.

    - public void LoadGrid(string fileName, FileFormatEnum format, [FileFlags flags, Encoding encoding])
    Replaced the 'fixedCells' parameter with a more general 'flags'.

    - public void LoadExcel(string fileName, [string sheetName, FileFlags flags])
    Load the grid from an Excel file, optionally specifying a sheet in the Excel book.
    (If the sheet is not specified, loads the first sheet).

    - public void SaveExcel(string fileName, [string sheetName, FileFlags flags])
    Save the grid contents into an Excel file, optionally specifying a sheet in the Excel book.
    (If the sheet is not specified, creates a new file with a single sheet).

    - public string[] LoadExcelSheetNames(string fileName)
    Gets a string array containing the names of all sheets in the Excel book.
    (Useful to inspect existing Excel files and load specific sheets).

  ** New Properties

      ** FlexGrid class:

      - public bool AutoClipboard
        Gets or sets whether the grid should automatically handle clipboard shortcut keys
        to cut, copy, paste, and delete grid contents (supported keys are ctrl-C, ctrl-X,
        ctrl-V, shift-Ins, shift-Del, and Del).

        - public IComparer CustomComparer
          Gets or sets a custom comparer object used for comparing cell values while merging,
          inserting subtotals, and finding rows. Useful if you want to change the default
          behavior and make the comparisons ignore case, trailing blanks, etc. Set to null
          to restore the default behavior.

    ** Row/Column classes:

    - public object DataSource {get;} (Row only)
      Gets the underlying data object providing data for the row. The type of object
      returned depends on the type of DataSource being used (e.g. if the DataSource
      is a DataView, the Row.DataObject will be of type DataRowView).
      Returns null if the grid is unbound.

    - public Control Editor {get;set;}
      Gets or sets a custom editor control for editing cells in a given row or column.

      You can set custom column editors at design time, using the Column Editor.

    - public ImageAlign ImageAlignFixed {get;set;}
      Gets or sets the alignment for images in fixed cells for a given row or column.

    ** CellStyle class:

    - public Control Editor {get;set;}
      Gets or sets a custom editor control for editing cells with a style.

    - public object UserData {get;set;}
      Gets or sets arbitrary user data associated with a style.

    - public void Render(Graphics g, Rectangle rc, Image img, DrawCellFlags flags);
      Render strings and images using the given style.
      Allows you to render multiple elements in a cell using OwnerDraw and also to
      use the CellStyle objects to render other UI elements outside the grid.

    ** CellStyleCollection class:

    - public CellStyle Editor:
      Gets a built-in style used to define the appearance of cell editors.
      You can edit this style at design time, using the "Edit Styles" verb, or
      at run time using the _flex.Styles.Editor property.
      For example, this code applies a bold font to cells being edited:
      _flex.Styles.Editor.Font = new Font(_flex.Font, FontStyle.Bold);

  ** New Events

        - BeforeAddRow(object sender, RowColEventArgs e)
          Fired before a new row is added by the user (allows cancel).
          Only happens when AllowAddNew property is set to true.
          This event fires when the cursor moves into the new row holder (marked with an asterisk).
          If you cancel the event, the cursor is not allowed into the new row holder.
          If you don't cancel the event, a new blank row is added to the grid and the cursor moves
          into it.

        - AfterAddRow(object sender, RowColEventArgs e)
          Fired after a new row is added by the user.
          This event always fires immediately after BeforeAddRow, unless the BeforeAddRow event
          handler cancels the action or an error occurs while adding the new row.

        - CancelAddRow(object sender, RowColEventArgs e)
          Fired when the cursor leaves the new row before any changes are made,
          automatically removing the new empty row.

        - BeforeDeleteRow(object sender, RowColEventArgs e)
          Fired before a row is deleted by the user with the Delete key (allows cancel).
          Only happens when the AllowDelete property is set to true.

        - AfterDeleteRow(object sender, RowColEventArgs e)
          Fired after one or more rows are deleted by the user.

    - GetUnboundValue(object sender, UnboundValueEventArgs e)
          Fired when the grid needs to retrieve data for an unbound cell.
      Event parameters are:
          e.Row, e.Col: coordinates of the cell
      e.Value: value of the cell (should be set by the event handler)

    - SetUnboundValue(object sender, UnboundValueEventArgs e)
          Fired when the grid needs to store data in an unbound cell.
          Event parameters are:
      e.Row, e.Col: coordinates of the cell
      e.Value: value of the cell (should be saved by the event handler)

  ** New Enums/Settings

    - FileFormatEnum has a new setting (Excel) used to save and load Excel files
      public enum FileFormatEnum
      {
        TextComma,
        TextTab,
        TextCustom,
        Excel
      }

    - FileFlags contains options used when saving and loading files
      [Flags]
      public enum FileFlags
      {
        None        = 0, // default behavior
        IncludeFixedCells = 1, // read/write fixed cells when loading/saving
        VisibleOnly     = 2, // skip invisible rows/columns when saving
      }

    - StyleElementFlags has a new setting (Editor) to support the new
      CellStyle.Editor property.

  ** New Behaviors

    - Styles.Add(null) is now allowed.
      It creates an 'anonymous' style that can be assigned directly to grid elements,
      but is not exposed in the collection. This type of style is the same that is
      created by the Row/Col.StyleNew methods. Anonymous styles not in use are cleared
      by the Styles.ClearUnused() and by the grid's Clear() methods.

     -  OwnerDrawn cells now support AutoSizing
        The OwnerDraw event now fires also when cells are being measured while auto-sizing.
        This ensures that auto sizing works even in cases where you change the cell contents
        (e.Text, e.Image) while handling the OwnerDrawCell event.
        You can determine whether the event is actually drawing or only measuring by
        checking the value of a new event parameter called Measuring.

  ** Notes on Custom Editors

    You can use any object based on the Control class as a grid editor. The grid will
    handle the usual events and properties exposed by the base class to manage the
    editor.

    If you want to improve the level of integration between custom editors and the
    grid, you should ensure that your editor implements one or more methods in the
    IC1EmbeddedEditor interface.

    The grid uses this interface through late-binding, so you don't have to implement
    all of its methods. The grid will use whatever methods are available, and will
    provide a default implementation for any methods that are missing.

    The IC1EmbeddedEditor interface is exposed by the C1Common dll. It contains the
    following members:

    interface IC1EmbeddedEditor
    {
      - void C1EditorInitialize(object value, IDictionary editorAttributes);

      Called to initialize the editor content and styles.

      The parameter 'value' contains the grid data that should be
      displayed in the editor. The parameter 'editorAttributes' contains
      a HashTable with keys that correspond to style element names and
      the values for the cell being edited. Apply these styles to the
      editor control to make it look like the cell being edited.
      The 'editorAttributes' table contains the following elements:

      - BackColor     cell  background color
      - ForeColor     cell foreground color
      - Font        cell font
      - EditMask      cell editing mask (e.g. "(999) 999-9999")
      - Format      cell format string (e.g. "#,##0.##")
      - ContentAlignment  cell text alignment
      - Margins     extra margins around the cell content (pixels)
      - Wrap        whether word wrapping is enabled

      The default handler sets the editor's Text property and ignores all styles.

      - object C1EditorGetValue();

      Returns the current value of the editor. This can be of any data type.
      The default handler returns the editor's Text property.

      - bool C1EditorValueIsValid();

      Returns true if the editor currently has valid content (e.g it contains
      an EditMask and all required positions have been filled).
      The default handler always returns true.

      - UITypeEditorEditStyle C1EditorGetStyle()

      Returns the editor style, which determines the type of button that is
      displayed in the cell before and during editing (DropDown, Modal, None).
      The default handler returns DropDown for ComboBoxes, DateTimePickers, and
      UpDown controls. It returns None for other control types.

      NOTE:
      The UITypeEditorEditStyle enumeration is defined in the System.Drawing.Design
      namespace. The available settings are DropDown, Modal, and None.

      - void C1EditorUpdateBounds(Rectangle rc);

      Moves the editor to the given rectangle so it stays over the cell upon
      initialization and whenever the grid scrolls.
      The default handler sets the control's Bounds property.

      - bool C1EditorKeyDownFinishEdit(KeyEventArgs e);

      Returns true if the given key should finalize editing and be handled
      by the grid.
      The default handler returns true for the Tab, Enter, and Escape keys. It
      also handles the arrow keys for editors based on TextBox, ComboBox, and
      DateTimePicker controls.

      - string C1EditorFormat(object value, string mask)

      Formats a given value using a specified mask.
      The default handler returns a string representation of the value
      (value.ToString()).

  ** Other changes

    Added several optimizations in drawing the code. The new grid repaints 10% faster in
    typical cases, much faster in special cases (e.g. with merged and frozen cells).

    The line between frozen and scrollable cells used to be painted using a dark gray brush,
    and there was no way to change that. The new version uses the same color used to paint the
    sheet edges, defined by the EmptyArea.Border.Color property.

Corrections
-----------
 ** none


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.1.20041.156   Build Date: February 2, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Honor ExtendLastCol in AutoSizeRows method
 * Keep selection when changing Frozen rows/columns
 * Improved AutoSearch to improve compatibility with Windows Explorer
   (now, hitting the 'a' key repeatedly will cycle through items a1, a2, a3, ..., )
 * Added optimization to merging logic
 * Allow unfreezing rows/cols even when they cover the entire client area

Corrections
-----------
 ** Clear method clears unused styles when ClearFlags.Style is set


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.1.20041.155   Build Date: January 26, 2004
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Honor AutoSearchDelay property in ComboEditors search as well as grid search

Corrections
-----------
 ** Don't fire SelChange when bound to a filtered data table and elements are filtered
    in and out of view.
 ** Fixed AutoSearch with merged cells (wasn't always scrolling to the new selection)
 ** Fixed problem disposing of AutoSearch timer (could cause null object reference)
 ** Improved handling of mouse/focus interaction (to honor validation on other controls)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.1.20041.153   Build Date: December 20, 2003
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Optimized merging logic, new version is about 15% faster in typical cases,
  but orders of magnitude faster in some cases (> 1000 rows, restricted merges)
 * Optimized subtotal logic, new version is dramatically faster than old one
  (about 30 times faster in a test case with 10,000 rows and 2 levels of totals)
 * Improved theme support, now use themes for CheckBoxes and collapse/expand buttons

Corrections
-----------
 ** Improved EditOptions design-time editor (clicking on All selects/deselects other options)
 ** Improved behavior of multi-check editing when bound (didn't always mark non-current rows as edited)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.1.20041.152   Build Date: November 20, 2003
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Set default tab stops to 50 pixels (about 5 spaces using the default font, used to be 150)

Corrections
-----------
 ** Honor Style.ImageMap in fixed cells
 ** Improved AutoSearch in drop-down lists (was looking for 1st character only)


=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.1.20041.151   Build Date: November 20, 2003
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Honor CheckBox in built-in DateTimePicker (if checkbox is visible and unchecked, date is set to null)
 * Optimized Tree.Show method (order of magnitude faster, very noticeable on large grids)

Corrections
-----------
 ** Preserve row selection when adding items with a filter applied (improvement to currency fix in 147)
 ** Improved rendering into C1PrintDocument (was resolution-dependent, failed with empty grids)
 ** Fixed rendering of merged columns adjacent to frozen columns
 ** SheetBorder property in Classic didn't work
 ** Couldn't clear Classic Wallpaper property from property grid
 ** Improved Node.Sort to handle subtotals below data (could make the grid hang)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.1.20041.149   Build Date: November 10, 2003
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * none

Corrections
-----------
 ** Using Rows.InsertRange or Cols.InsertRange raised GridChanged with incomplete parameters
  (only a single row/column was reported, not the actual range)

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.1.20041.148   Build Date: November 10, 2003
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Q1/2004 drop
 * Show DBNull values as gray CheckBoxes in bound Boolean columns

Corrections
-----------
 ** none

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.1.20034.147   Build Date: November 10, 2003
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * AddItem method used to be void, now returns a reference to the new Row <<DOC>>

Corrections
-----------
 ** Improved mouse handling when last frozen row/col is invisible
 ** When bound and with frozen rows, the grid sometimes moved the currency position on data refresh
 ** AfterEdit, ValidateEdit events passed wrong e.Col when processing CheckBoxes on multiple columns

=========================================================================================
C1.Win.C1FlexGrid.dll Build Number 2.1.20034.146   Build Date: September 19, 2003
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * Added repainting optimization with merged cells
 * Optimized row adding while Redraw = false
 * Show CheckBoxes when the cell's DataType is Boolean even with inherited numeric format strings
 * Added new property: EditFlags EditOptions <<DOC>>
    This property contains flags that allow customization of the built-in
    editing behavior. The options available are:
      EditFlags.AutoSearch
        Gets or sets whether the built-in ComboBox should search for items as the user types.
      EditFlags.CycleOnDoubleClick
        Gets or sets whether the built-in ComboBox should cycle items when the user double-clicks a cell.
      EditFlags.MultiCheck
        Gets or sets whether the grid should toggle all CheckBoxes in a selection.
 * Added new property: TextDirectionEnum Style.TextDirection <<DOC>>
    This property allows text to be displayed in the vertical direction (up or down along the cell).
    Cells containing vertical text can wrap and be auto-sized as usual.

Corrections
-----------
 ** Fixed problem with outline tree indentation when Tree.Style = None
 ** Improved timer fix to work with Application.EnableVisualStyles()
 ** Keep selection when adding rows in bound mode
 ** Fire BeforePageBreak event when rendering into a C1PrintPreview (as when printing directly)

2.1.20034.145 - September 12
  Added extra safety when setting multi-cell checks (in case the field is part of a filter)

2.1.20034.144 - September 6
  q4 drop

  Added two new properties to the GridPrinter class: Header and Footer <<DOC>>
    these properties allow you to customize the header and footer
    of the grid's PrintDocument in case you want to display the grid
    preview in your own dialog. For example:

    GridPrinter gp = _flex.PrintParameters;
    gp.Header = "Hello\tWorld\tHeader";
    gp.Footer = "Hello\tWorld\tFooter";
    gp.PrintGridFlags = C1.Win.C1FlexGrid.PrintGridFlags.FitToPageWidth;
    PrintPreviewDialog dlg = new PrintPreviewDialog();
    dlg.Document = gp.PrintDocument;
    dlg.ShowDialog();

2.1.20033.143 - August 20
    Fixed focus handling in MDI forms
  Fixed notification in Rows/Cols.Move methods
    Fixed painting of merged ranges with invisible cells
    Before/AfterResize fired even if the new size was the same as the old
    Improved consistency in CellRange.Style/StyleNew properties
        before, Style/StyleNew would return the style for the first cell in the range
        now, they will also assign the style to the whole range
2.1.20033.142 - July 25
  Added Chinese localization info
  Typing Alt/Shift-Enter inserts line breaks into cell (like Excel and Word)
2.1.20033.141 - July 7
    Optimized Clear method (much faster now)
  Added extra safety to cell merging logic
  Added extra safety to mouse timer
  Exposed PrintGridFlags property in PrintParameters class

2.1.20033.139 - June 16
  Improved logic for adding nodes (that are children of collapsed nodes)
  Fixed problem with casing and style names (they are case-insensitive)
  Fixed KeyPressEdit problem (couldn't cancel, probably due changes in .NET base class)

  Added DoubleBuffer property <<DOC>>
    ** DoubleBuffer Property
      If this property is set to true, drawing is performed in a buffer,
      and after it completes, the result is output to the screen.
      This prevents flicker caused by the redrawing of the control.

    public bool DoubleBuffer

      Do not set DoubleBuffer to false if the grid has:
      - Merged cells, or
      - Transparent areas, or
      - A Background image.

      You may want to set DoubleBuffer to false to increase
      performance when deploying applications that run on terminal
      servers.

2.1.20033.138 - June 12
  Improved handling of auto-sizing on double-click
  Improved dispose logic (caused problem with data-binding at design time)
  Setting DataSource == null now resets DataMember to "" (for compatibility with MS, TDBGrid)
  Improved behavior of error ToolTips
  Improved performance of Redraw property while re-binding

2.1.20033.137 - June 2
  Exposed constructors for event arguments (so derived classes can create and fire events)

2.1.20033.136 - May 25
    Q3/2003 build

2.1.20032.136 - May 25
    Fixed bug in Clear method (didn't honor ranges when clearing content)
    Improved handling of XP themes initialization (slightly faster now, no try/catch)
    Fixed problem in column editor (allowed user to add rows at design time)
    Fixed problem with some ImageMaps based on SortedLists (can't look up null/DBNull.Value keys)
    Paint event fires _after_ the control has painted itself

2.1.20032.135 - May 2
    Added indexers to Row/Column objects (e.g. you can do Row[2] to get the data in the second cell of the row) <<DOC>>
    Added Move method to Row/Column objects (Row.Move(newIndex), more concise than Rows.Move(oldIndex, newIndex)) <<DOC>>
    Added new setting to AllowResizing enumeration: ColumnsUniform <<DOC>>
    Improved keyboard handling in ComboBoxes
    Cleaned up overridables (virtual On... methods)
  Fixed problem with persistence of alpha-blended border colors
  Fixed problem with ComboBox editor in .NET 1.1 (base control is incompatible with .NET 1.0 ComboBox!!!)
    Improved FxCop compliance

2.1.20032.134 - May 2
  Short initial delay for Error tooltips (see ShowErrors property)
  Slight improvement in clipping merged cells (screen and printer)
  Fixed problem in AllowAddNew with hierarchical C1Data data sources
  Improved display of ComboEditor on merged cells

2.1.20032.133 - April 28
  Fixed problem with CheckBoxes on fixed cells
  Fixed problem with Dispose method in MDI forms (previous fix was bad)

2.1.20032.132 - April 24 ** bad build **
  Fixed problem with Dispose method in MDI forms
  Optimized row/col invalidation
  Improved clipping when drawing outline tree
  Improved logic for AfterSelChange event with ListBox selection
  Added workaround for GDI+ right-alignment bug

2.1.20032.131 - April 17
  Fixed problem with tree lines not being drawn correctly (broken in 129)
  Fixed problem with KeyActionTab (broken in 126)

2.1.20032.130 - April 15 ** bad build **
  Fixed problem with page-up/down when rows are taller than the grid's client area
  Fixed problem with design-time column editor (was clearing DataSource property)

2.1.20032.129 - April 7 ** bad build **
  Added Chinese localization tables
  Honor system setting for mouse wheel scrolling
  Fixed Aggregate overloads
  Fixed Node.EnsureVisible method
  Fixed problem with ValidateEdit and DateTimePicker control
  Optimized StyleNew logic (much faster with lots of styles)
  Added Styles.ClearUnused() method
    This deletes styles that are unnamed and unused (created with StyleNew
    and no longer assigned to any rows, columns, or cell ranges).

2.1.20032.126
  Reduced flicker when re-setting DataSource
  Improved column editor (move/select columns with a single row)
  Added new KeyActionEnum for KeyActionTab:
    MoveAcrossOut cycles to the last cell, then on to the next control

2.1.20032.125 - March 27
  Fixed problem introduced in 122 (non-editable last row would show 'add row' glyph)
  Fixed problem with Subtotal(Percent), didn't work at all

2.1.20032.123 - March 24
  Fixed problem created by FxCop compliance changes (build 118, disabled RowCollection persistence)
  Added overload to column collection: Contains(string name) in addition to Contains(Column col)
  Improved behavior of AllowAddNew when adding the first row to an empty table

2.1.20032.122 - March 18
  Improved support for IME editor
  Improved performance of Redraw property
    Check for valid currency manager Position before calling EndCurrentEdit
  Fixed problem with AllowDelete and ListBox selection mode

2.1.20032.121 - March 12
  Fixed minor refresh problem with outline button bar
  Reset grid model when setting DataSource = null

2.1.20032.120 - March 5
  Fixed semantics of Margins attribute in Styles.Add method
    Before, Margins was the only attribute that was copied as a reference
    Now, new styles clone the margin of the parent style. For example:
      CellStyle s1 = _flex.Styles.Add("s1");
      s1.Margins.Left = 20;
      CellStyle s2 = _flex.Styles.Add("s2", s1);
      s2.Margins.Left = 10;
    Before, s1.Margins.Left would be set to 10 (via s2). Now, each
    style has its own Margins object.
  Fixed problem setting LeftCol property (2.1 issue)
  Added support for Windows XP themes
    The support is automatic. If the grid is used in an application
    that has the appropriate manifest, and is running under Windows XP,
    then the Combo and Edit buttons and editors will automatically
    be displayed using the current theme.

2.1.20032.118 - Feb 25
  Q2/2003 drop
  FxCop compliance changes
  Disabled spill merge on right-aligned cells
  Optimized Invalidate method (dramatic speed increase in some common scenarios)
  Fixed problem when binding to source with no columns
  Fixed column editor (couldn't move columns)
  Fixed problem removing the last row when AllowDelete is true
  Fixed initialization for drop down lists (was selecting second item, not first)
  Fixed problem with KeyPress event and IME editor
  Fixed problem with PrintGrid and page breaks
  Row/Col.Clear method did not invalidate correctly

2.1.20031.117 - Feb 19
  Fixed persisting margins in Style Editor
  Fixed flex.ComboList/flex.EditMask properties (2.1 issue)
  Allow TopRow/LeftCol/ShowCell even with Redraw = false
  Allow tabbing within and then out of the control

2.1.20031.114 - Feb 13
  Improved setting ClientSize
  Calling Clear with no cells caused crash
  Added FrozenRows, FrozenCols to Classic grid

2.1.20031.113 - Feb 6
    OnSizeChanged was firing too often
    Fixed problem with ScrollBars (could reset scroll position with hidden bar)

2.1.20031.112 - January 30
  ScrollTip wasn't being disposed correctly (previous fix was incomplete)
    Fixed AllowDelete property
    Exposed IPrintable interface in Flex.Classic
    Use new version of c1common.dll (1.0.20031.116) for compatibility with other products

2.1.20031.111 - January 25 (** bad build **)
  ScrollTip was firing for horizontal scrollbar as well as vertical (2.1 issue)
  Improved scrollbar setup logic (2.1 issue)
  Fixed invalidation problem with merged cells (2.1 issue)
  Fixed AllowDelete when SelectionMode = Row or RowRange (2.1 issue)
  Added slight optimization to Paint routine
  ScrollTip wasn't being disposed correctly (caused memory leak)

2.1.20031.110 - January 16
    Improved multi-column mouse sort (AllowSortingEnum.MultiColumn)
  Show Boolean values as checks on Boolean columns/node rows
  Improve repaint to avoid occasional 'black screen' when Redraw = false
  Improve invalidation issue when data bound
  Fixed incompatibility in MouseDown event ordering (2.1 issue)

2.1.20031.108 - January 14
  Fixed problem setting row count with AllowAddNew
  Fixed problem adding rows to empty data-bound grids

2.1.20031.106 - January 10
  Fixed painting problem (calling Update() while Redraw = false)
  Apply Format to fixed cells as well as scrollable cells

2.1.20031.105 - January 9
  Fixed problem with optimization in CellStyle
  Fixed problem with ScrollBars property
  Fixed problem with losing focus on MouseDown
  Added MergeWith method to CellStyle object (docs below)

2.1.20031.102 - January 2 ** New Release

 ** 2.1: Updated AssemblyInfo, requires rebuilding existing apps.

    This new version has an expanded object model, and a new dependency on
  the C1Common.dll, the assembly that defines all common C1 interfaces.

  To use this new build in existing applications, you need to open the
  project, select the "References" node in the Project Explorer, replace
  the reference to the older version of the grid, then add a reference
  to the new version of the grid and to C1.C1Common.dll.

  ** Compatibility Note:
  ----------------------
  In this new version, several properties that used to belong to the Row
  and Column objects were moved to the CellStyle object. These properties
  are: Format, EditMask, ComboList, ImageMap, and DataMap.

  This was done to increase the power and flexibility of these properties,
  which now can be applied to individual cells or cell ranges (through the
  CellStyle).

  The original syntax for setting these properties is still supported, so
  you can write:

  _flex.Cols[1].Format = "d"; // assign Format to column
  _flex.Cols[1].StyleNew.Format = "d"; // assign Format to column's style

  In fact, the statements above are 100% equivalent. When you assign a value
  to the Format property of the Column object, the Column simply passes it
  on to its style.

  ** IMPORTANT
  This represents a change in behavior that may affect some applications
  written using version 1.1 of the grid. Consider the following code:

  >>>>>>>
  CellStyle s = _flex.Styles.Add("DateStyle");
  s.TextAlign = TextAlignEnum.CenterCenter;
  s.Font = New Font(s.Font, FontStyle.Bold);
  _flex.Rows[0].Style = s;
  _flex.Rows[1].Style = s;
  _flex.Rows[2].Style = s;

  _flex.Rows[0].DataType = typeof(DateTime);
  _flex.Rows[0].Format = "MMMM yyyy";
  <<<<<<

  In version 1.1, this would cause rows 0, 1, and 2 to share the same style,
  and row 0 would also have a custom Format on top of that.

  In version 2.1, this won't work the same way. Assigning the Format to row 0
  will change the CellStyle which is also used by rows 1 and 2. To obtain the
  same effect as before, the code would have to be rewritten as:

  >>>>>>>
  CellStyle s = _flex.Styles.Add("FixedStyle");
  s.TextAlign = TextAlignEnum.CenterCenter;
  s.Font = New Font(s.Font, FontStyle.Bold);
  _flex.Rows[1].Style = s;
  _flex.Rows[2].Style = s;

  s = _flex.Styles.Add("DateStyle", s);
  _flex.Rows[0].Style = s;
  _flex.Rows[0].DataType = typeof(DateTime);
  _flex.Rows[0].Format = "MMMM yyyy";
  <<<<<<

  This version creates a new style for row 0, and sets the Format property on
  the new style only.


  ** New Properties:
  ------------------

 ** public bool AllowAddNew (applies to C1FlexGrid)
  Gets or sets whether the grid should display a new row template after the
  last data row. If the user enters data into the new row template, a new
  row is automatically added to the grid.

  This property works in bound mode (if the data source supports adding new
  rows) and in unbound mode.

  Note that if this property is set to true, the Rows.Count property will
  return a value that includes the new row template. If you set the Rows.Count
  property, the grid will set the number of data rows and will automatically
  add the new row template. For example:

  _flex.AllowAddNew = true;
  _flex.Rows.Count = 10;
  Console.WriteLine(_flex.Rows.Count);

  This will print out "11" (10 data rows plus the new row template).


 ** public bool AllowDelete (applies to C1FlexGrid)
  Gets or sets whether the grid should monitor the keyboard and handle the
  Delete key. If this property is set to true, the user can delete rows
  by selecting them and then pressing the Delete key.

  This property works in bound mode (if the data source supports deleting
  rows) and in unbound mode.


 ** public CellStyle Styles.NewRow (applies to CellStyleCollection)
  Built-in style used to display the new row template (only used when
  AllowAddNew is set to true).

  For example, the code below will display the new row template with a
  Yellow background:

  _flex.Styles.NewRow.BackColor = Color.Yellow;


 ** public bool ShowErrors (applies to C1FlexGrid)
  Gets or sets whether the grid should monitor and display errors in the
  data source. The errors are provided by the data source object using the
  IDataErrorInfo interface (ADO.NET and C1Data support this).

  If this property is enabled, cells with errors will display an error icon
  (customizable via the SetGlyph method). When the user moves the mouse over
  the error icon, the control will display a tooltip containing the error
  description. For example:

  this._flex.ShowErrors = true;
  _dt.Rows[3].SetColumnError(_dt.Columns[0], "row 3, col 0 is bad");
  _dt.Rows[4].SetColumnError(_dt.Columns[1], "this cell is bad too");
  _dt.Rows[5].RowError = "This whole row is bad";


 ** public GridGlyphs Glyphs (applies to C1FlexGrid)
  Allows you to customize all built-in images displayed by the grid. This
  property has an indexer of type GlyphEnum that gets or sets the images
  used to indicate column sorting, collapsed and expanded outline groups,
  CheckBoxes, cursors, error information, etc.

  For example, the code below causes the grid to use custom images to
  display the column sorting order (instead of the built-in hollow
  triangles):

  _flex.Glyphs[GlyphEnum.Ascending]  = imgAscending;
  _flex.Glyphs[GlyphEnum.Descending] = imgDescending;

  Note: Setting a glyph to null restores the default (built-in) image. If
  you want to make a glyph invisible, set it to a small blank image instead.


 ** public PrintPreviewDialog PrintPreviewDialog (applies to GridPrinter)
  Allows you to specify properties for the built-in PrintPreview dialog. For
  example, the code below sets the caption and size of the built-in
  PrintPreview dialog:

  PrintPreviewDialog dlg = _flex.PrintParameters.PrintPreviewDialog;
  dlg.Text = "Custom Caption in Preview Dialog";
  dlg.ClientSize = new Size(500,500);


 ** New CellStyle properties
  The CellStyle object has the following new properties:

  - public DisplayEnum Display (applies to CellStyle)
  Gets or sets whether the grid should show text, images, or both
  in a cell, and also whether text should be placed next to the images
  (Stack, the default setting) or below the text (Overlay).

  - public string Format (applies to CellStyle)
  Gets or sets the format for individual cells and ranges
  (as opposed to by row or column only, which are still available).
  For example:

  CellStyle s = _flex.Styles.Add("BigNumber");
  s.Format = "#,##0.##";
  CellRange r = _flex.GetCellRange(10,10);
  rg.Style = s;

  - public string EditMask (applies to CellStyle)
  Gets or sets the edit mask for individual cells and ranges
  (as opposed to by row or column only, which are still available).
  For example:

  CellStyle s = _flex.Styles.Add("TheMask");
  s.EditMask = "##-##-####";
  CellRange r = _flex.GetCellRange(10,10);
  rg.Style = s;

  - public string ComboList (applies to CellStyle)
  Gets or sets the ComboList for individual cells and ranges
  (as opposed to by row or column only, which are still available).
  For example:

    CellStyle s = _flex.Styles.Add("TheList");
  s.ComboList = "Fiat|Mercedes|Porsche|Pontiac";
  CellRange r = _flex.GetCellRange(10,10);
  rg.Style = s;

  - public IDictionary ImageMap (applies to CellStyle)
  Gets or sets the ImageMap for individual cells and ranges
  (as opposed to the whole grid, or by row/column, which are still
  available).

  For details and examples, see the Column.ImageMap property.

  - public IDictionary DataMap (applies to CellStyle)
  Gets or sets the DataMap for individual cells and ranges
  (as opposed to the whole grid, or by row/column, which are still
  available).

  For details and examples, see the Column.DataMap property.

 ** New CellStyle method
  - public void MergeWith(CellStyle sourceStyle)
    Copies all elements defined in sourceStyle into the current style,
    leaving existing elements unchanged.

    This new method allows you to apply visual styles to rows and columns
    without disturbing existing style attributes such as ComboList and Format.
    For example:

  ' add a combo box to a column (saved with the column style)
    _flex.Cols[2].ComboList = "A|B|C|D|E|F";

    ' apply a new style to the column without disturbing the combo
    _flex.Cols[2].Style.MergeWith(flex.Styles.Frozen);

    ' ** this wouldn't work, it would remove the ComboList saved with the column style
    '_flex.Cols[2].Style = flex.Styles.Frozen;


 ** Other improvements

  - support for IC1ControlPrintable
    The control now supports the IC1ControlPrintable interface, which allows
    you to render it into C1PrintDocument objects. For example:

  C1PrintDocument doc = new C1PrintDocument();
  doc.StartDoc();
  doc.RenderBlockText("Here is a C1FlexGrid:");
  doc.RenderBlockText(" ");
  doc.RenderBlockC1Printable(_grid, doc.BodyAreaSize.Width);
  doc.RenderBlockText(" ");
  doc.EndDoc();

  Note: the control has a new dependency on the C1Common.dll, the assembly
  that defines all common C1 interfaces (including IC1ControlPrintable).

  - Resize last row/col:
    The control now allows you to drag the mouse outside the control area
    to resize the last row or column more easily.

  - Faster/smoother scrolling
    The control uses a new base class that provides much faster and smoother
    scrolling.

  - Before/AfterCollapse now fire with Row = -1 to indicate many rows are being
    expanded or collapsed.

    When the user clicks an outline button, several nodes may be expanded or
    collapsed to show the target outline level. In these cases, the grid will
    fire the BeforeCollapse event with the Row parameter set to -1 to indicate
    it's starting a collapse/expand batch of operations, and it will fire the
    AfterCollapse event with the Row parameter set to -1 to indicate it's done
    with the batch. For example, when the user expands the outline tree to a
    given level, the control will fire the following event sequence:

    BeforeCollapse (e.Row = -1) // ** batch started
    BeforeCollapse (e.Row = 1)  // individual rows being collapsed/expanded
    AfterCollapse  (e.Row = 1)
    BeforeCollapse (e.Row = 5)
    AfterCollapse  (e.Row = 5)
    BeforeCollapse (e.Row = 15)
    AfterCollapse  (e.Row = 15)
    AfterCollapse  (e.Row = -1) // ** batch ended



// 2002 //////////////////////////////////////////////////////////////
1.1.20031.101 - December 19
  Fixed problem with merged filtered views
  Fixed problem with AutoSize and center-aligned images
  Fixed refresh problem with ListChangedType.Reset and subtotals
1.1.20031.102 - January 12
  Fixed selection problem in ListBox mode with custom check boxes
1.1.20031.97 - December 8
  Added support for vertical alignment in TextBox editor
1.1.20031.96 - December 5
  Fixed problem with licensing subclassed controls (since IE-aware 90 build)
  Improved multi-column subtotals fix (from 85)
1.1.20031.93 - November 26
  Fixed exception when printing grids with no scrollable rows
  Auto-adjust dimensions when changing font property (_flex.Font = ...)
  Improved freezing behavior with merged column headers
1.1.20031.92 - November 25
  Improved style notification mechanism slightly
  (avoids subtle problems when changing styles in response to BeforeEdit event)
1.1.20031.91 - November 25
  Updated about box links, Enterprise studio licensing
1.1.20024.90 - November 9
  Added IE-aware licensing/attributes
  Didn't always call cm.EndCurrentEdit() when losing focus
  Didn't always fire GridError after ConstraintExceptions
1.1.20024.87 - November 4
  ClientSize didn't account for scrollbars
1.1.20024.86 - November 4
  Control didn't fire the Paint event
1.1.20024.85 - October 30
  Fixed problem with merging logic when merging both rows and columns
  Fixed problem with multi-column subtotals below data
1.1.20024.84 - October 24
  Deleting rows/cols while editing left editor in limbo
1.1.20024.83 - October 22
  Account for Outline button bar when auto-sizing
  Fixed speed optimization bug (introduced in 81)
  Improved list editor behavior when initializing with bad key (not on list)
  Classic: Allow setting flexcpData in put_Cell method
1.1.20024.81 - September 24
  Removed check boxes from boolean columns on subtotal rows
  Added some minor speed optimizations
1.1.20024.78 - September 12
  Improved error-checking in calls to Sort, Node.Move
1.1.20024.77 - September 10
  Made columns localizable
  Fixed visibility problem when moving nodes into collapsed/hidden nodes
  Fixed crash: click on left-top fixed cell with SelectionMode == CellRange
1.1.20024.75 - September 6
  Improved handling of empty cells in Clip property
  Fixed problem with selection update after removing columns
1.1.20024.74 - August 30
  Setting Row.Selected = true was not firing SelChange event
  Fixed problem with scaling of frozen rows/cols in PrintGrid
1.1.20024.73 - August 29
  Optimized setting Row.IsNode property
  Improved handling of style changes in OwnerDrawCell event
  Fixed problem with ListBox selection (ctrl-click, then click a row was not re-selecting it)
  Fixed problem with Cols.RemoveRange
1.1.20024.70 - August 22
  Fixed problem sorting bound fields with names that contain spaces
  Fixed problem with sort indicator on first column (didn't always show)
  Optimized Clip property (getting the data is order of magnitudes faster now)
1.1.20024.69 - August 21
  Fixed problem with DataMaps in combo drop-downs
1.1.20024.68 - August 13
  Included frozen rows/cols in PrintGrid (they're like fixed rows/cols)
  Optimized data-binding (design vs run time)
  Fixed problem with SpillMerge and invisible columns
1.1.20024.66 - August 9
  Fixed problem with combo editor (didn't always commit when losing focus)
  Wasn't firing SelChange events when ctrl-clicking on the current row in listbox mode
  Allow changes to Style parameter in OwnerDrawCell event
1.1.20024.64 - August 2
  Fixed small problem with column editor (caused fonts to shift a little bit)
  Fixed problem with Validating event
    When validation of an edit control fails, the grid now sets the
    Cancel parameter to true before firing the standard Validating event.
1.1.20024.62 - July 29
  Fixed problem with AutoSizeRows (didn't account for outline tree)
  Fire ValidateEdit/AfterEdit on multiple checkbox editing
  Fixed more problems with drop-down combos (Text didn't always return correct value in ValidateEdit event)
1.1.20023.56 - July 17
  Fixed problem with drop-down combos (sometimes cancelled edit when losing focus)
1.1.20023.54 - July 16
  Improved error-checking on coerced assigns (didn't always fire GridError when it should)
  Fixed problem with Tree.Sort method
  Optimized printing (faster and more memory-efficient)
1.1.20023.53 - July 12
  Fixed problem with scroll ranges when setting Visible = true (ugly and old bug)
  Fixed problem with KeyActionEnter (was ignored in forms with the AcceptButton property set)
  Improved image generation performance (and fixed a clipping problem with outlines)
  Added a few extra safety checks while handling the AfterEdit event
1.1.20023.50 - July 5
  Added GrapeCity configuration (Japanese build)
1.1.20023.49 - July 3
  Improved handling of null values in sorting
1.1.20023.48 - July 1
  Fixed repainting problem with fixed columns (wasn't invalidating correctly)
  Fixed repainting problem when setting col.Selected (wasn't invalidating correctly)
1.1.20023.46 - June 27
  Fixed serious problem introduced in build 43 (Rows.Add could throw exception)
  Fixed problem with SortFlags.AsDisplayed (didn't honor DataMaps)
  Fixed Validation problem with drop lists (empty selections wouldn't go away)
  Fixed problem with Focus style
  (was being used to paint the cursor cell even when the control didn't have the focus)
  Optimized merged cell painting

1.1.20022.43-45 - June 14-25 ***** BAD BUILDS *****
  Fixed problems with sorting (two rows, bound totals) << buggy fix!!!

1.1.20022.42 - June 5
  Fixed problem with style editor (couldn't remove last custom style)
  Fixed problem with merging frozen rows
1.1.20022.40 - June 5
  Fixed problem with IME editor
  Fixed problem with ScrollTip event (Row parameter wasn't always right)
  Fixed problem with image scaling in PrintPreview
  ComboCloseUp was not firing reliably
1.1.20022.39 - June 1
    Improved case-insensitive sorting, masked editing
  Fixed problem with StringFormat (caused interaction with Crystal Reports)
  Added ShowSortAt method
1.1.20022.38 - May 16
  Fixed problems with Node sort/move
  Removed auto-formatting for 'decimal' columns (not always currency)
1.1.20022.37 - May 10
  Fixed problem with setting LeftCol, TopRow when Frozen > 0
  Fixed StyleEditor (clear was not removing all custom styles)
  Fixed CellStyle.WordWrap persistence
  Fixed Boolean format strings (e.g. "Yes;No")
  Extended several Column properties to Row objects as well:
    If a property is specified for both row and column, the
    column takes precedence. The new Row properties are:
      Format, EditMask, ComboList, DataMap, ImageMap, StyleFixed,
      DataType, ImageAlign, and TextAlign.
1.1.20022.36 - May 9
  Improved ColumnEditor to allow editing inherited collections
  Fixed mouse handling problems with single, fixed row grid
  Finished Japanese localization
1.1.20022.35 - Apr 30
  Improved localization scheme (shrank control by about 300k)
  Fixed tree painting problem (first node, subtotals below data)
  Fixed hit-testing bug introduced in build 33
  Added SetDataBinding method (set DataSource and DataMember at once)
  Better handling of Image columns
  Better handling of layout changes while loading control
  ValidateEdit was firing twice when failing on combos
  Added HitTest method and HitTestInfo struct for testing the mouse
  Added GridChanged event with notifications for pretty much everything
1.1.20022.31 - Apr 18
  Improved vertical alignment (centering doesn't crop top)
  Fixed mouse clipping in multi-monitor setup
1.1.20022.30 - Apr 15
  Drop down editor on F4
  Improved type coercion when data-bound (to handle DBNull correctly)
  Fixed data-binding initialization problem (broken in build 22)
1.1.20022.28 - Apr 8
  Improved performance of row.Index
  Improved adding rows (when parent node is hidden, new row is too)
  Added option to specify the placeholder character in EditMasks
    (same syntax as VSFlexGrid, e.g. "999-9999;*" to use an asterisk as a placeholder)
1.1.20022.27 - Apr 5
  Fixed clicks on CheckBoxes displayed on tree nodes
1.1.20022.26 - Apr 3
  Fixed Leave event (was firing when leaving cell editor)
  Improved performance on ListBox selection
1.1.20022.25 - Mar 29
  Improved combo box logic to allow item removal in SetupEditor event
  Improved licensing (now supports embedding licx in dlls)
1.1.20022.24 - Mar 26
  Improved style merging (cell/col/row/built-ins)
1.1.20022.23 - Mar 25
  Added support for virtual data (through C1Data/C1DataExpress)
  Added support for control localization
  Fixed problem with using the control in localized forms
  Fixed problem with accelerator keys and editing
1.1.20022.22 - Mar 18
  Q2 RC
  Fixed mouse handling problem introduced in 1.1.20021.21
  Fixed DB updating problem (not updating after edit on current row)
  Added Row/Column freezing (like VSFlexGrid). Frozen rows/columns
  are displayed using the Styles.Frozen style.
  + New properties:
    - Rows.Frozen, Cols.Frozen: number of non-scrollable but editable rows/cols
    - AllowFreezing: whether the user can freeze rows/cols with the mouse
    - BeforeFreezeRow, BeforeFreezeColumn, AfterFreezeRow, AfterFreezeColumn events
1.1.20021.20 - Mar 11
  Added AutoFormat button to Style Editor
  Added ShowButtons property to control when combo buttons are displayed: always, focus, editing
  Added ShowCursor property to display DataGrid-style cursor on fixed column
  Added Rows.InsertNode(index, level) method to insert node rows to bound grids
  Added SubtotalPosition property to determine whether Subtotal adds nodes above or below the data (like VSFlexGrid)
1.1.20021.17 - Mar 5
    6551 - Column designer didn't save column captions in Classic version
    6552 - Selection events firing during initialization
    6553 - Dragging columns caused spurious scrolling with no fixed cols
    6554 - Improved Tab key handling with drop-lists/date pickers
       (note: you still can't tab out of real combos, there's a bug in the .NET base control that makes it beep when it gets the tab key)
1.1.20021.16 - Feb 28
    Setting Cancel to true in BeforeMouseDown didn't cancel double-click processing
    Scroll events were fired on row/col changes only, not on a pixel basis
1.1.20021.15 - Feb 18
    Fixed problem with styles persisted in international locales (must use invariant locale for persistence)
    Fixed problem with Sort method when bound (error in notification handler)
1.1.20021.14 - Feb 17
    Fixed problem with Sort method when bound
1.1.20021.13 - Feb 12
  Improved Sort (added Handled member to SortColEventArgs to allow custom mouse sorting) (DOC)
  StartEdit event was firing too often on CheckBoxes
  Fixed painting problem when using list mode and ExtendLastCol
1.1.20021.12 - Feb 12
  Improved style handling when editing cells with custom styles
1.1.20021.11 - Feb 11
  Fixed beep when user presses tab in cell editor
1.1.20021.10 - Feb 4
  Improved hierarchical data-binding
  Added BeforeAutosizeRow/Col events
  Added overloads for GetData/GetDataDisplay to use col names
  Fixed problem with Sort(IComparer) method
1.1.20021.9 - Jan 29
  Improved ComboList editor (item height, selected style)
  Tabbing (MoveAcross) during edit mode required 2 keystrokes
1.1.20021.8 - Jan 26
  Improved Mask editor (starting position when second mask char is literal)
1.1.20021.7 - Jan 25
  Fixed problem when setting Clip property to values with cr/lf
1.1.20021.6 - Jan 19
  Improved precision in Row/Col AutoSizing
1.1.20021.5 - Jan 17
  Improved Rows.Add/Insert/Remove/Fixed behavior when data-bound
1.1.20021.4 - Jan 10
  Fixed small problem with BeforeEdit/StartEdit event firing
1.1.20021.3 - Jan 9
  Fixed format used in DateTimePicker
1.1.20021.2 - Jan 7
  Fixed problem displaying captions when bound and no fixed cols
1.1.20021.1 - Jan 1
  First drop Q1/2002
  Fixed mouse-handling bug with no rows and ExtendLastCol = true

** beta builds

1.1.20014.34456 - Jan 1
  Fixed bug in StartEditing method
  Fixed bugs in big mouse selection
  Fixed bug in keyboard extended selection
  Fixed bug in Cols.Remove()
  Fixed bug in licensing
  Fixed editing when AllowMerging = Nodes
  Implemented column editor
1.1.20014.34455 - Dec 26
  Keep editor text when validation fails
  Move selection to check boxes on click
  Fixed data refresh/threading issue (newsgroup)
  Fixed ExtendLastCol (last _visible_ col)
  Fixed Cursor property (grid was overriding it)
  Removed calls to SendMessage (replaced with WndProc)
  Added AutoSearch/Complete feature to edit lists
  Added DatePicker editor (Col.DataType == typeof(DateTime), no combo, no mask)
  Added new ButtonBar setting to TreeStyleFlags
1.1.20014.34454 - Dec 21
  Fixed handling of new items in IBindingList
  Fixed bug when clicking fixed cell and no scrollable cells
  Fixed clipping in ControlPaint.DrawBorder3D
  Fixed bugs in GetNode routine (Node.Add)
  Fixed painting of empty nodes (no collapse/expand button)
  Fixed auto resizing with outline trees
  Fixed Node.EnsureVisible (was expanding the node)
  Improved keyboard handling with outline trees (left/right keys expand/collapse)
  Improved mouse handling with outline trees (shift/ctrl click to show level)
  Improved painting dotted lines (use hatch brush instead of dotted pen)
1.1.20014.27503 - Dec 17
  Changed ImageMap and DataMap from HashTables into IDictionary (more general)
  Changed data-bound Sort to use IBindingList (more general)
  Couldn't collapse/expand outlines when AllowDragging was set to rows



Release notes, December 2001
----------------------------------------------------------------------

* Differences between .NET and ActiveX versions


- C1FlexGrid and C1FlexGridClassic

In the ActiveX product, we supplied several versions of the FlexGrid
control (ADO, DAO, unbound, Unicode, etc). In the .NET product, there
are two versions: C1FlexGrid and C1FlexGridClassic.

C1FlexGrid is not a simple port of the ActiveX control. It is a brand
new grid control, written from the ground up in C#, with the same
design principles but with a new object model that is more modern,
clean, and powerful that the one in the ActiveX control. The
C1FlexGrid control can be bound to ADO.NET data sources, or used in
unbound mode.

To keep the highest level of source-code compatibility with existing
applications, and to make the learning curve as smooth as possible for
VSFlexGrid users, we also offer the C1FlexGridClassic control.

C1FlexGridClassic is a control uses C1FlexGrid as a base class and
exposes an object model that is virtually identical to the one in
VSFlexGrid. We supply the source code to C1FlexGridClassic, so you can
see exactly how to use the new object model. Or you can use it as an
example and create your own grid using the C1FlexGrid as a base class.

If you are writing new applications, you should use the C1FlexGrid.

If you are porting existing applications that use the VSFlexGrid
ActiveX, and want to change as little code as possible, then use the
C1FlexGridClassic.


- Rows, Cols collections

The ActiveX control has Rows and Cols properties that are used to
get or set the number of rows and columns on the grid. In the
C1FlexGrid control, these properties return row and column collections.
The collections have read/write properties that return the number of
elements and fixed elements in each collection.

This is probably the most visible change between the controls. Using
the ActiveX control, you would write:

    Dim r%, c%
    c = 1
    For r = fg.FixedRows To fg.Rows - 1
        Debug.Print fg.TextMatrix(r,c)
    Next

Using the C1FlexGrid control, this becomes:

    Dim r%, c%
    c = 1
    For r = fg.Rows.Fixed To fg.Rows.Count - 1
        Debug.Print fg(r,c)
    Next

Note also that the TextMatrix property was replaced with indexers.


- Styles

In the ActiveX control, you can customize the appearance of individual
cells or cell ranges using the Cell property. For example, to give the
second row a red background, you would write:

    fg.Cell(flexcpBackColor, 2, 0, 2, fg.Cols-1) = vbRed

The C1FlexGrid control uses a CellStyle object to customize cell
appearance. To make the second row red, you would write:

    Dim redStyle As CellStyle = fg.Styles.Add("Red")
    redStyle.BackColor = vbRed
    fg.Rows(2).Style = redStyle

But this requires three lines of code instead of one! What's the advantage?

The main advantage of the new approach is that the new style is an object
that can be changed or assigned to new ranges. For example, if you decide
to give the red cells a white ForeColor and a bold font, you can write

    fg.Styles("Red").ForeColor = vbWhite
    fg.Styles("Red").Font = new Font("Arial", 9, FontStyle.Bold)

This will change the appearance of all cells that use the "Red" style.
The previous approach would require either (1) clearing all styles and
setting everything up again from scratch or (2) scanning all cells in the
grid to detect which cells are red, then changing those.

CellStyle objects are used consistently throughout the control, so instead
of BackColorFixed and ForeColorSel you can now write Styles.Fixed.BackColor
and Styles.Highlight.ForeColor.


- CellRange

The Cell property is one of the most powerful elements of the VSFlexGrid
object model. It allows you to set get or set any property of any cell or
cell range with a single command. However, handling colors, text, values,
etc using a single properties means using Variants, and this prevents the
compiler from catching many subtle problems in case you make mistakes.

The C1FlexGrid replaces the Cell property with a CellRange object that
exposes type-safe properties and methods used to access the properties of
a cell range. For example, instead of writing

    fg.Cell(flexcpPicture, 5, 5, 10, 10) = theImage

You would write

    Dim rg As CellRange
    rg = fg.GetCellRange(5,5,10,10)
    rg.Image = theImage

The new approach has two significant advantages: (1) it is type-safe,
so if the variable theImage contained a string instead of an image
you would get a compiler error instead of a runtime error; and (2)
because the types for each property are known, you get command-completion
when writing the code.


- Typed columns

In the ActiveX version, the ColDataType allowed you to se the type
of data that each column contained. This information was used mainly
for sorting columns that contained dates or numbers.

The .NET version has a Cols[i].DataType property that determines the
type of data the column holds. By default, the DataType for all columns
is "object", which means you can store anything in any column. You can
set the data type to specific types, however, and the grid will try to
coerce any data stored in the grid to the proper type. For example:

    fg.Cols[2].DataType = typeof(int);
    fg[1,2] = "12";     // ok, value will be set to 12
    fg[2,2] = "hello";  // bad value, fire GridError event and ignore

This code would assign the integer 12 to cell (1,2). Cell (2,2) would
retain its original value, because the string "hello" can't be
converted to an integer.

If you want to store values of mixed types in a column, you have two
options: (1) set the column's DataType property to "object", or (2)
use the SetData method with the "coerce" parameter set to false to
store a value or object without checking the data type.


* Limitations

The initial release of the C1FlexGrid control does not support the
following features present in the ActiveX version:

- CellBorders (you can draw custom borders using OwnerDraw cells).
- FloodPercent (you can draw flooded cells using OwnerDraw cells).
- Frozen rows/cols.
- Saving/loading grids from disk (text-only formats are supported, e.g. CSV).
- Multi-column combo boxes

Most of these features will be added to the control shortly, and should
be available with the next Studio maintenance release.


* Details

Component name: C1FlexGrid
Namespace:      C1.Win.C1FlexGrid
DLL:            C1.Win.C1FlexGrid.dll
Dependencies:   .NET Framework

Component name: C1FlexGridClassic
Namespace:      C1.Win.C1FlexGrid.Classic
DLL:            C1.Win.C1FlexGrid.Classic.dll
Dependencies:   .NET Framework, C1.Win.C1FlexGrid.dll
