//////////////////////////////////////////////////////////////////////
//
// Readme file for ComponentOne C1Excel
//
// C1.C1Excel.dll
//
// Version number format:
// first  part: Version of the .NET framework used to build the assembly (e.g. 2 = .NET 2.x)
// second part: Internal use only
// third  part: Year/version (e.g. 20101 = V1/2010)
// fourth part: Sequential number
//
/////////////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////////////////////////
//
// This assembly is available in two versions: .NET 2.x and .NET 4.0
// (for every 2.x.x.x build there is a corresponding 4.x.x.x build)
//
/////////////////////////////////////////////////////////////////////////////////////////

========================================================================================
C1.C1Excel.dll Build Number 2.1.20142.325	Build Date: Aug 29, 2014
========================================================================================

Corrections
-----------
 * Partly [Forum][Phone Excel] ArgumentException is thrown on loading an Excel file
   created through OfficeApp.
   Reason in test total strings.

       Places: OpenXmlReader.cs

   (TFS:82564)

 * Fixed 'Excel found unreadable content in xlsx file' error is thrown when an excel
   file is loaded and saved using C1Excel.
   Reason in Open XML pane inforation.

       Places: OpenXmlWriter.cs

   (TFS:84061)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20142.323	Build Date: Jul 24, 2014
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Added Clone column method (XLColumn class) with new output parameter (array of the
   column cells).
 * Added Insert column method (XLColumnCollection class) with new input parameter
   (array of the cells).

   Use (clone column with all column cells) [C#]:

            var sheet = c1XLBook1.Sheets[0];
			XLCell[] cells;
            var col = sheet1.Columns[5].Clone(out cells);
            sheet.Columns.Insert(5, col, cells);

Corrections
-----------
 * Partly fixed [Enhancement] Request to provide support for inserting cells and
   shifting of cell.
   Added Clone and Insert methods for fix. Possible clone all column as clone all row.

       Places: RowCol.cs

   (TFS:48023)

 * Fixed "ArgumentException" is raised on loading an Excel file in C1FlexGrid using
   LoadGrid method.
   Reason incorrect read columns property in Open XML format.

       Places: OpenXmlReader.cs

   (TFS:75957)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20142.322	Build Date: Jul 17, 2014
========================================================================================

Corrections
-----------
 * Fixed [C1Excel] NullReferenceException Thrown When Loading XLSX Via C1Excel.
   Reason incorrect condition at added condition formatting.

       Places: OpenXmlReader.cs

   (TFS:73333)

 * Fixed [C1Excel][44477] Formulas doesn't work correctly on exporting to .xls format.
   Reason incorrect states for AND, OR and ISNUMBER functions.

       Places: Function.cs

   (TFS:71970)

  * Fixed [WinRT XAML] C1Excel does not work to create Excel file with images.
    Support images for WinRT version.

       Places: Book.cs, Sheet.cs, OpenXmlReader.cs, OpenXmlWriter.cs

   (TFS:70533)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20142.321	Build Date: Jun 27, 2014
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
* V2/2014 build

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.319	Build Date: Jun 19, 2014
========================================================================================

Corrections
-----------
 * Fixed numeric value item is replaced by character "GyyyyNyyyyRAL" in saved CSV file.
   Reason in changed "GENERAL" format in Japanese version.

       Places: Sheet.cs

   (TFS:68073 part 2 JPN)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.318	Build Date: Jun 10, 2014
========================================================================================

Corrections
-----------
 * Fixed numeric value item is replaced by character "GyyyyNyyyyRAL" in saved CSV file.
   Reason in "GENERAL" format as text format.

       Places: Sheet.cs

   (TFS:68073)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.317	Build Date: May 13, 2014
========================================================================================

Corrections
-----------
 * Fixed [SL4][SL5][WPF][C1Excel]Unlike previous build, excel file cannot be loaded.
   BIFF8 condition formating fix.

       Places: Book.cs, Sheet.cs, Formatting.cs, Style.cs, Operand.cs

   (TFS:63446)
   
 * Fixed [SL Excel] Exception observed on loading Excel file.
   Added support read of extended Open XML format.

       Places: Book.cs, Sheet.cs, OpenXmlReader.cs

   (TFS:64796)

 * Fixed NullReference Exception is thrown when setting the cell value in an Excel file.
   Added condition at remove shared formula.

       Places: Cell.cs

   (TFS:65636)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.316	Build Date: Apr 18, 2014
========================================================================================

Corrections
-----------
 * Fixed [C1XLS] Changes cannot be saved in the output Excel file with image in the
   sheets.

       Places: OpaqueParser.cs, OpaqueCreator.cs 

   (TFS:14346)

 * Fixed [WPF][C1Excel]Unlike previous build, excel file cannot be loaded.

       Places: Book.cs, OpenXmlWriter.cs 

   (TFS:63446)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.315	Build Date: Apr 15, 2014
========================================================================================

Corrections
-----------
 * Fixed [C1Excel]Unlike previous build, texts in comments are become large font size
   and do not fix current Viewport in saved OpenXml format.

       Places: RichText.cs

   (TFS:56751)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.314	Build Date: Apr 10, 2014
========================================================================================

Corrections
-----------
 * Fixed [C1Excel] Unlike previous build, Merge cell from code does not work in excel
   file which was already merged cells across.
   Reason in ignore intersected merged ranges.

       Places: CellRange.cs

   (TFS:56810)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.313	Build Date: Mar 28, 2014
========================================================================================

Corrections
-----------
 * Fixed [WPF C1Excel] DateFormat is lost on loading & saving an Excel file.
   Reason in US format supported only.

       Places: Style.cs, BuiltInFormats.cs

   (TFS:56182)

 * Fixed [Regression] ForeColor of GroupCounter Fields are not exported to .xlsx file.
   Reason in incorrect calculate theme and tint colors.

       Places: Book.cs

   (TFS:61666)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.312	Build Date: Mar 28, 2014
========================================================================================

Corrections
-----------
 * Fixed [Silverlight] Extra space appears in the beginning of the string if exported
   string ends with a new line character.
   Reason in incorrect added space at "preserve" attribute.

       Places: OpenXmlReader.cs

   (TFS:54686)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.311	Build Date: Mar 14, 2014
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
* Added "Studio Desktop" license key ("SD" key).

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.310	Build Date: Mar 13, 2014
========================================================================================

Corrections
-----------
 * Fixed unlike build [308], cell border 'Black' color is changed 'White' color when
   saving (OpenXml) format.
   Reason in fix of 308 build.

       Places: Style.cs

   (TFS:56984)

 * Fixed unlike build [260], ArgumentException occurs when loading and saving .xls format
   excel file at printing setting.
   Reason in added support shape.LineWidth.

       Places: OpaqueCreator.cs

   (TFS:57124)

 * Fixed unlike build [301], Cell's height setting get lost and text & images are clipped
   in excel file in which containing picture 's border, alignment and properties.
   Reason in support new property for custom row height.

       Places: RowCol.cs

   (TFS:56855)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.309	Build Date: Mar 12, 2014
========================================================================================

Corrections
-----------
 * Fixed unlike build [306], cell background is shown as black in saved file if the
   background is not applied color in original excel file.
   Reason in not set auto color (255, 255, 255, 255) for BackColor.

       Places: Style.cs

   (TFS:51637)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.308	Build Date: Mar 11, 2014
========================================================================================

Corrections
-----------
 * Fixed unlike build [287], some font color is changed on gray color back ground of
   cell after exporting the C1Excel.
   Reason in incorrect theme order at writing.

       Places: Book.cs, OpenXmlWriter.cs

   (TFS:56693)

 * Fixed unlike build [301], 'Merge cells' and 'Hyperlink Texts' are not displayed
   correctly after loading and saving OpenXml format.
   Reason in incorrect 'continue' at new hyperlinks.

       Places: OpenXmlWriter.cs

   (TFS:56735)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.307	Build Date: Mar 10, 2014
========================================================================================

Corrections
-----------
 * Fixed [WPF][C1Excel] font color is lost on loading and re-saving the Excel file.
   Reason in not supported font color and font subscript & superscript for
   WPF/SL/Phone/WinRT.

       Places: Font.cs, Style.cs

   (TFS:55829)

 * Fixed [WPF C1Excel] DateFormat is lost on loading & saving an Excel file.
   Reason in incorrect condition for CurrentUICulture with "en-us" culture name.

       Places: Style.cs

   (TFS:56182)

 * Fixed [WPF][C1Excel]Shrink To Fit' formatting is lost on loading & saving an Excel
   file.
   Reason in not supported Shrink To Fit and Reading Direction for all versions of
   C1Excel.

       Places: Style.cs, OpenXmlWriter.cs, OpenXmlReader.cs

   (TFS:56185)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.306	Build Date: Mar 07, 2014
========================================================================================

Corrections
-----------
 * Fixed unlike build 287, "Gray" and "Black" with different opacity are exported as
   White.
   Big changes for themes with tints support.

       Places: Book.cs, Style.cs, OpenXmlWriter.cs, OpenXmlReader.cs

   (TFS:56034)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.305	Build Date: Mar 04, 2014
========================================================================================

Corrections
-----------
 * Partly fixed [Forum] opening xlsx file including more than 65530 rows containing
   hyperlinks throws 'Excel Found Unreadable Content...' error.
   Fixed exception at opening, but 65530 hyperlinks is limitation Open XML format.

       Places: OpenXmlWriter.cs

   (TFS:49577)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.304	Build Date: Mar 03, 2014
========================================================================================

Corrections
-----------
 * Fixed next part of unhandled exception occured, cell's height setting gets lost when
   loading and saving ExcelFlexGrid.
   Added row property: IsCustomHeight.

       Places: RowCol.cs, OpenXmlReader.cs, OpenXmlWriter.cs

   (TFS:50757)

 * Fixed next part of unhandled exception occured, backcolor is lost when excel file
   in which containing 'Range Names' & 'Formula' loaded as .xls format and saved as
   .xlsx format.

       Places: Style.cs

   (TFS:52120)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.303	Build Date: Feb 28, 2014
========================================================================================

Corrections
-----------
 * Fixed unhandled exception occured when certain xlsx file with comments is loaded with
   C1Excel.
   Reason in incorrect read xml comments from Open XML file.

       Places:  OpenXmlReader.cs

   (TFS:35878)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.302	Build Date: Feb 26, 2014
========================================================================================

Corrections
-----------
 * Fixed unlike previous build, after loading and saving excel file, backcolor is
   changed 'Black'.
   Reason in ignore clear theme colors.

       Places:  OpenXmlReader.cs

   (TFS:52196)

   C1Excel takes long time to save an excel file containing hyperlinks

 * Fixed C1Excel takes long time to save an excel file containing hyperlinks.
   Reason in using list for search of hyperlinks.

       Places:  OpenXmlWriter.cs

   (TFS:49581)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.301	Build Date: Feb 25, 2014
========================================================================================

Corrections
-----------
 * Fixed error occurs when opening of output files (.xls/.xlsx) which contains "A Date
   Occurring" ConditionlFormatting.
   Small correct for conditional formatting background.

       Places:  OpenXmlReader.cs, OpenXmlWriter.cs

   (TFS:50150)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.300	Build Date: Feb 24, 2014
========================================================================================

Corrections
-----------
 * Fixed unlike previous build, backcolor is lost when excel file in which containing
   'Range Names' & 'Formula' loaded as .xls format and saved as .xlsx format.

       Places:  Sheet.cs

   (TFS:52120)

 * Fixed unlike previous build, backcolor of style cell is changed when loading and
   saving format is reversed.
   Reason in 50757 fix.

       Places:  OpenXmlReader.cs, OpenXmlWriter.cs

   (TFS:52111)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.299	Build Date: Feb 20, 2014
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
* Applied the localized strings (CompatibilityMode, KeepFormulas, OpaqueCopy) for
  Chinese localization.

Corrections
-----------
 * Fixed exception is observed on loading excel file which contains filters.
   Reason in empty tag at rich text.

       Places:  RichText.cs

   (TFS:50841)

 * Fixed unlike previous build, cell's height setting gets lost when loading and
   saving ExcelFlexGrid.
   Reason in incorrect exchange foreground and background colors.

       Places:  Style.cs

   (TFS:50757)

 * Fixed [C1FlexGrid]Unlike build [4.6.20113.656], A tab character is not shown
   correctly in C1FlexGrid by loading excel file.
   Reason in incorrect read hex format of the symbol.

       Places:  OpenXmlReader.cs

   (TFS:51927)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.298	Build Date: Feb 17, 2014
========================================================================================

Corrections
-----------
 * Fixed cell background is shown as black in saved file if the background is not
   applied color in original excel file.
   Reason in use indexed for foreground colors.

       Places:  OpenXmlWriter.cs

   (TFS:51637,TFS:51593)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.297	Build Date: Feb 14, 2014
========================================================================================

Corrections
-----------
 * Fixed unlike previous build, 'Table Header' row is filled with 'Black' color when
   loading and saving excel file .xltx [OpenXmlTemplate] format in which using MS-Word
   Table.
   Reason in "fill" background not theme color.

       Places:  OpenXmlWriter.cs

   (TFS:51370)

 * Fixed unlike previous build, (#REF!) 'Invalid Cell Reference Error' is shown on
   opening the XLS file which is loaded and saved by C1Excel using XLSX file.
   Reason in not copy named ranges (partly fixed in TFS:50235).

       Places:  Book.cs, Cell.cs

   (TFS:51013)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.296	Build Date: Feb 10, 2014
========================================================================================

Corrections
-----------
 * Fixed unlike previous build ,Cell borders are missing when using backcolor in .xltx
   saved format.
   Reason in 0 theme for CLR_WINDOW color index.
  
       Places:  OpenXmlWriter.cs

   (TFS:50734)

 * Fixed unlike previous build, formula is disappeared after loading and saving excel
   file.
   Reason in fix TFS:50235.

       Places:  Cell.cs

   (TFS:50792)

 * Fixed unlike previous build, dotted border lines get lost when loading .xls file and
   saving in .xlsx (OpenXml) format.
   Reason in 0 theme for CLR_WINDOW color index.

       Places:  OpenXmlWriter.cs

   (TFS:50817)

 * Fixed unlike previous build, 'Black' color is set as backcolor when loading and
   saving  excel file [.xlsx] format in which containing 'Invalid Cell Reference
   Error(=#REF)'.
   Reason in "fill" background not rgb color.

       Places:  OpenXmlWriter.cs

   (TFS:50889)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.295	Build Date: Feb 06, 2014
========================================================================================

Corrections
-----------
 * Fixed unlike previous build, Invalid Excel OpenXml file (*.xlsx) exception is occur
   when loading xlsx excel file.
   Reason in unexpected empty element: font.
  
       Places:  OpenXmlReader.cs

   (TFS:50082)
 
 * Partly fixed unlike previous build, SubTotal Value is lost when opening xlsx file.
   Added save value at errors in formulas.

       Places:  Cell.cs

   (TFS:50235)

 * Fixed unlike previous build , NotSupportedException occurs when saving excel file in
   which data is getting from table at print setting.
   Added condition for control HasTokens.
  
       Places:  Book.cs

   (TFS:50503)

 * Fixed unlike previous build, 'ForeColor' is changed when excel file is loading with
   FlexGrid.
   Reason in set font color at automatic.
  
       Places:  OpenXmlReader.cs

   (TFS:50633)

 * Fixed unlike previous build, Error message is shown and background color is changed
   when loading excel file in which data getting import template.
  
       Places:  Style.cs

   (TFS:50637)

 * Fixed loading of .XLSX file containting RangeName and SUM Fomula in C1Excel, throws
   System.FormatException.
  
       Places:  OpenXmlReader.cs

   (TFS:50128)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.294	Build Date: Feb 05, 2014
========================================================================================

Corrections
-----------
 * Partly fixed 2 of size of the image is modified in the Cloned Sheet.
  
       Places:  Book.cs, Style.cs

   (TFS:49961)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.293	Build Date: Feb 03, 2014
========================================================================================

Corrections
-----------
 * Partly fixed error occurs when opening of .XLS files which has Conditional
   Formattings and saved by C1Excel.

       Places:  OpenXmlWriter.cs, OpenXmlReader.cs, Style.cs

   (TFS:50036)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.292	Build Date: Jan 23, 2014
========================================================================================

Corrections
-----------
 * Fixed unlike previous build,'A message box 'Excel found unreadable content in ...'
   is displayed on loading the excel file.

       Places: OpenXmlReader.cs

   (TFS:50040)

* Fixed part 4 ("'" symbol) of error occurs on loading excel created using C1Excel and
  containing double byte bracket " (" character in the sheet name.

       Places: CellRange.cs

   (TFS:47872)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20141.290	Build Date: Jan 22, 2014
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
* V1/2014 build
* Support conditional formatting.

Corrections
-----------
* Fixed calculation twips per character value for default font of C1Excel
  (TwipsToPixel issue part 2).

       Places: Book.cs

   (forum: http://our.componentone.com/groups/topic/width-property-problems/page/2/)

* Fixed part 3 of error occurs on loading excel created using C1Excel and containing
  double byte bracket " (" character in the sheet name.

       Places: CellRange.cs

   (TFS:47872)

 * Fixed (as conditional formatting) Conditional Formattings are not retained
   after load and save with C1Excel.

       Places: Formating.cs, Sheet.cs, OpenXmlReader.cs, OpenXmlWriter.cs

   (TFS:36825)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20133.289	Build Date: Jan 15, 2014
========================================================================================

Corrections
-----------
* Fixed part 2 of error occurs on loading excel created using C1Excel and containing
  double byte bracket " (" character in the sheet name.

       Places: CellRange.cs

   (TFS:47872)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20133.288	Build Date: Jan 15, 2014
========================================================================================

Corrections
-----------
* Fixed error occurs on loading excel created using C1Excel and containing double byte
  bracket " (" character in the sheet name.

       Places: CellRange.cs

   (TFS:47872)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20133.287	Build Date: Dec 17, 2013
========================================================================================

Corrections
-----------
* Correct calculation twips per character value for default font.
  C1Excel (TwipsToPixel issue).

       Places: Book.cs

   (forum: http://our.componentone.com/groups/topic/width-property-problems/page/2/)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20133.286	Build Date: Dec 16, 2013
========================================================================================

Corrections
-----------
* Fixed formulas are lost when multiple rows containing formulas are cloned using
  C1Excel.

       Places: OpenXmlReader.cs, Control.cs, BiffFormula.cs

   (TFS:47449)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20133.285	Build Date: Dec 05, 2013
========================================================================================

Corrections
-----------
 * Correct for issue: unlike previous build, C1Excel hang when loading .xlsx file
   contained macros and 15 sheets.

       Places: Operand.cs

   (TFS:47293)

 * Fixed Word2013 part of issue:'Invalid Excel OpenXml file' is occurred on loading an
   excel file after saving as another one.

       Places: OpenXmlReader.cs, OpenXmlWriter.cs

   (TFS:23710)

 * Fixed cell data becomes distorted and formula named 'INDIRECT' is lost when new rows
   are inserted in an Excel file using C1Excel.

       Places: BiffFormula.cs

   (TFS:47320)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20133.284	Build Date: Dec 03, 2013
========================================================================================

Corrections
-----------
 * Fixed 'ArgumentOutOfRangeException' exception is observed on loading an Excel file
   created using third party software.

       Places: OpenXmlReader.cs

   (TFS:47107)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20133.283	Build Date: Dec 02, 2013
========================================================================================

Corrections
-----------
 * Fixed unlike release build 280, certain files cannot be loaded by C1Excel.
   Regression from TFS:46324.

       Places: BiffRecord.cs

   (TFS:47113)

 * Fixed unlike release build 280, exception occurred when loading certain file.
   Regression from TFS:46324.

       Places: BiffRecord.cs

   (TFS:47114)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20133.282	Build Date: Nov 28, 2013
========================================================================================

Corrections
-----------
 * Fixed unlike previous build, XLCellRange added to "NamedRanges" collection doesn't
   save to excel file.

   But, more correctly, instead code: 
            XLCellRange CellRange1 = new XLCellRange(0, 9, 0, 0);	// for all sheets
            c1XLBook1.NamedRanges.Add("CellRange1", CellRange1);

   use code:
            XLCellRange CellRange1 = new XLCellRange(sheet, 0, 9, 0, 0);
            c1XLBook1.NamedRanges.Add("CellRange1", CellRange1);

       Places: CellRange.cs

   (TFS:46949)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20133.281	Build Date: Nov 27, 2013
========================================================================================

Corrections
-----------
 * Fixed Appearance of merged cells is distorted on Inserting/Removing rows above a row
   with merged cells.

       Places: CellRange.cs, RowCol.cs

   (TFS:46088)

 * Fixed 'ArgumentOutOfRange' exception is observed on loading Excel file saved from
   C1Excel, that sets cell value to an empty string.

       Places: BiffRecord.cs

   (TFS:46324)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20133.280	Build Date: Oct 24, 2013
========================================================================================

Corrections
-----------
 * Fixed ArgumentException is thrown when trying to save certain Excel file using Save
   method.

       Places: BiffFormula.cs

   (TFS:44298)

 * Last changes of 'Excel found unreadable content...' error message is thrown for excel
   file which contains freeze row/col (new sample).

       Places: OpenXmlWriter.cs

   (TFS:41487)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20133.279	Build Date: Oct 17, 2013
========================================================================================

Corrections
-----------
 * Fixed of 'Excel found unreadable content...' error message is thrown for excel file
   which contains freeze row/col (new sample).

       Places: OpenXmlWriter.cs

   (TFS:41487)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20133.278	Build Date: Oct 14, 2013
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
* V3/2013 build

Corrections
-----------
 * Fixed background color is not retained after excel file is loaded and saved by
   C1Excel.

       Places: OpenXmlReader.cs

   (TFS:43381)

 * Fixed invisible sheet’s data is shown when selecting the data of next sheet.

       Places: Book.cs

   (TFS:41047)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20132.277	Build Date: Oct 10, 2013
========================================================================================

Corrections
-----------
 * Fixed regression of 'Excel found unreadable content...' error message is thrown for
   excel file which contains freeze row/col.

       Places: OpenXmlWriter.cs

   (TFS:41487)

 * Fixed regression (when) row or column is freezed and selection cell range is inside
   freeze pane, only the first cell (A1) is selected excel file which contains freeze
   row/col.

       Places: OpenXmlWriter.cs

   (TFS:41537)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20132.276	Build Date: Oct 09, 2013
========================================================================================

Corrections
 -----------
 * Fixed 'Show a zero in cells' option turns ON automatically from OFF when loading &
   saving Excel file.
 
       Places: Sheet.cs, OpenXmlWriter.cs, OpenXmlReader.cs

   (TFS:43057)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20132.275	Build Date: Sep 30, 2013
========================================================================================

Corrections
 -----------
 * Fixed next part of 'Excel found unreadable content...' error message is thrown for
   excel file which contains freeze row/col.

       Places: OpenXmlWriter.cs

   (TFS:41487)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20132.274	Build Date: Sep 13, 2013
========================================================================================

Corrections
 -----------
 * Fixed part three of 'Excel found unreadable content...' error message is thrown for
   excel file which contains freeze row/col.

       Places: OpenXmlWriter.cs

   (TFS:41487)

 * Fixed cell data get not shown if indent value is greater than 31 when load as OpenXml
   and save as Biff8 filetype.

       Places: Book.cs

   (TFS:41814)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20132.273	Build Date: Sep 10, 2013
========================================================================================

Corrections
 -----------
 * Fixed part two of 'Excel found unreadable content...' error message is thrown for
   excel file which contains freeze row/col.

       Places: OpenXmlWriter.cs

   (TFS:41487)

 * Fixed (when) row or column is freezed and selection cell range is inside freeze pane,
   only the first cell (A1) is selected excel file which contains freeze row/col.

       Places: OpenXmlWriter.cs

   (TFS:41537)

 * Fixed indent value is not worked in OpenXml file type.

       Places: OpenXmlWriter.cs, OpenXmlReader.cs

   (TFS:41586)

 * Fixed indent value get always show Zero (0) when AlignHorz value is not defined in
   XLStyle object.

       Places: Style.cs

   (TFS:41590)

 * Fixed indent property is also worked in other horizontal alignment which is not ‘Left’
   and ‘Right’.

       Places: Style.cs

   (TFS:41588)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20132.272	Build Date: Sep 02, 2013
========================================================================================

Corrections
 -----------
 * Fixed 'Excel found unreadable content...' error message is thrown for excel file
   which contains freeze row/col. Reason of regression fix for TFS:30427.

       Places: OpenXmlWriter.cs

   (TFS:41487)

 * Fixed 'Excel found unreadable content...' error message is thrown when open excel
   file when selected cell range contains part of frozen row/col.

       Places: OpenXmlWriter.cs

   (TFS:41478)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20132.271	Build Date: Aug 29, 2013
========================================================================================

Corrections
 -----------
 * Fixed although setting Rows.Collapsed=true, row is not collapsed.

       Places: Book.cs, RowCol.cs, OpenXmlWriter.cs, OpenXmlReader.cs

   (TFS:28288)

 * Fixed cell range is NOT selected when cell range with Frozen row/col is selected in
   C1Excel book.

       Places: OpenXmlWriter.cs

   (TFS:30427)

=======================================================================================
C1.C1Excel.dll Build Number 2.1.20132.270	Build Date: Aug 22, 2013
========================================================================================

Corrections
 -----------
 * Fixed English Strings observed in Japan version of C1Excel.

       Places: a.C1.C1Excel.Strings.resx

   (TFS:34230)

 * Fixed 'Author' property cannot be set.

       Places: OpenXmlWriter.cs

   (TFS:41161)

=======================================================================================
C1.C1Excel.dll Build Number 2.1.20132.269	Build Date: Aug 22, 2013
========================================================================================

Corrections
 -----------
 * Fixed space characters in formula as truncated

       Places: BiffFormula.cs

   (TFS:41107)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20132.268	Build Date: Aug 21, 2013
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 - Changed strings, translated to Chinese and Korean languages.

========================================================================================
C1.C1Excel.dll Build Number 2.1.20132.267	Build Date: Aug 16, 2013
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 - Change work with collection of the formulas for performance.
   Tested "Alex Ivanenko" <alex.ivanenko@componentone.com>

========================================================================================
C1.C1Excel.dll Build Number 2.1.20132.266	Build Date: Aug 15, 2013
========================================================================================

Corrections
 -----------
 * Fixed description of Diagonal line is drawn in reverse direction in a cell.

       Places: Style.cs

   (TFS:40721)

 * Partly fixed formula value is not shown and file is opened as ‘Protected view’ in
   Biff8 file if ‘IsShow’ property of the comment is set to True.

       Places: Comment.cs, Canvas\TextBoxShape.cs

   (TFS:38340)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20132.265	Build Date: Aug 13, 2013
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 - Added Indent parameter for XLStyle class.

Corrections
 -----------
 * Fixed PatternColor is worked as Background color of the cell.

       Places: Style.cs, OpenXmlWriter.cs, OpenXmlReader.cs

   (TFS:40723)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20132.264	Build Date: Aug 05, 2013
========================================================================================

Corrections
 -----------
 * Fixed unlike BIFF8 format, opening xlsx or xltx file saved by C1Excel throws 'Excel
   found unreadable content.. ' error if that file contained tables.

       Places: OpenXmlWriter.cs, OpenXmlReader.cs, BiffFormula.cs

   (TFS:36789)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20132.263	Build Date: Jul 24, 2013
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 - Added CultureInfo parameter for XLStyle.FormatDotNetToXL.
 - Merged changes from Silverlight\WPF\Phone\WinRT project.

========================================================================================
C1.C1Excel.dll Build Number 2.1.20132.262	Build Date: Jul 11, 2013
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 - Merged changes from Silverlight\WPF\Phone\WinRT project.
 - Korean localization added.

========================================================================================
C1.C1Excel.dll Build Number 2.1.20132.261	Build Date: Jun 17, 2013
========================================================================================

Corrections
 -----------
 * Fixed [WPF] SetRangeToRepat() method is not working with OpenXML format.

       Place: OpenXmlWriter.cs

   (TFS:37310)

 * Fixed 20131 build is dropped instead of 20132 build and Japanese Aboutbox is still
   displaying old URL.

       Place: AboutForm.cs

   (TFS:37818)

 * Fixed unlike previous build, 'ArgumentException' is thrown  when BIFF8 format file
   containing font size zero is loaded and saved as OpenXML format.

       Place: OpenXmlReader.cs

   (TFS:36753)

 * Fixed unlike previous build [2/4.1.20131.248], 'Excel Found Unreadable Content ...'
   error is occurred when xls file with special character comments is loaded and saved.

       Place: OpaqueParser.cs

   (TFS:36750)

 * Fixed unlike previous builds, 'Excel found unreadable content...' error message is
   thrown and comments are lost on loading & saving 'xls' file that contains more than
   60 commented cells.
   Reason: straneg behaviour of MS Excel,

       Place: Sheet.cs

   (TFS:36642)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20132.260	Build Date: Jun 13, 2013
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
* V2/2013 build

Corrections
 -----------
 * Fixed loading of .xlsx contains  "Number sorted as text" data in C1FlexGrid throws
   System.Argument Exception.

       Place: OpenXmlReader.cs

   (TFS:37790)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20131.259	Build Date: May 28, 2013
========================================================================================

Corrections
 -----------
  * Fixed if format settings are performed in a cell, the curly brackets in the text
    ({,}) disappear. Part 2 for ';' and '\' symbols.

       Place: RichText.cs

   (TFS:36123)

  * Fixed if format settings are performed in a cell, the word following "\" will be
    deleted simultaneously.

       Place: RichText.cs

   (TFS:36383)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20131.257	Build Date: May 02, 2013
========================================================================================

Corrections
 -----------
  * Fixed although setting Rows.Collapsed=true, row is not collapsed.

       Place: RowCol.cs

   (TFS:28288)

  * Fixed  If format settings are performed in a cell, the curly brackets in the text
    ({,}) disappear.

       Place: RichText.cs

   (TFS:36123)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20131.256	Build Date: Apr 11, 2013
========================================================================================

Corrections
 -----------
 * Fixed text property of XLComment.TextBox return empty string after loading data from
   existing excel file.

       Place: OpenXmlReader.cs

   (TFS:35284)

  * Fixed black & white colors are applied on cell if color paletter is set.

       Place: Book.cs

   (TFS:34492)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20131.255	Build Date: Apr 8, 2013
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
- Updated About Box image 

========================================================================================
C1.C1Excel.dll Build Number 2.1.20131.253	Build Date: Mar 29, 2013
========================================================================================

Corrections
 -----------
 * Fixed Excel file cannot be created when save as OpaqueBiff8 fileformat.

       Place: Book.cs

   (TFS:35390)

 * Fixed for request to modify the filedescription of Design dll.

       Place: AssemblyInfo.cs

   (TFS:32311)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20131.252	Build Date: Mar 26, 2013
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 - Changes for WinRT support (without shapes).

Corrections
 -----------
 * Fixed incorrect row count is returned when few rows are deleted in MS Excel & loaded
   in C1Excel in Biff8 (.xls) format

       Place: Sheet.cs (Init method)

   (TFS:34738)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20131.251	Build Date: Mar 08, 2013
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
- Corrected remark of Height property (XLRow class).

Corrections
 -----------
 * Refixed (incorrect fixed previous once) if XLS file is loaded and saved by C1Excel,
   setting font size over 24 causes text inside cell to be disappeared format.

       Place: RowCol.cs, OpenXmlWriter.cs

   (TFS:22992)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20131.250	Build Date: Feb 27, 2013
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
- Optimization saving in Open XML format (*.xlsx files).

========================================================================================
C1.C1Excel.dll Build Number 2.1.20131.249	Build Date: Feb 21, 2013
========================================================================================

 Corrections
 -----------
 * Fixed count of comments is not maintained if file is saved and loaded using Biff8
   format.

       Place: OpaqueParser.cs, Book.cs

   (TFS:33472)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20131.248	Build Date: Feb 06, 2013
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
- Added support of color with 'auto' name for xlsx (Open XML) format.

========================================================================================
C1.C1Excel.dll Build Number 2.1.20131.247	Build Date: Feb 05, 2013
========================================================================================

* V1/2013 build

========================================================================================
C1.C1Excel.dll Build Number 2.1.20123.245	Build Date: Dec 06, 2012
========================================================================================

 Corrections
 -----------
 * Fixed ‘#Value!’ text is shown when ISBLANK formula is used with IF expression in
   Biff8 format.

       Place: BiffFormula.cs, Function.cs

   (TFS:29883)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20123.244	Build Date: Nov 17, 2012
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
- Added OpaqueCopy property for copy BIFF record (only for BIFF/xls/2003 mode).

 Corrections
 -----------
 * Fixed (partly) unlike preivous build, TextBox is missing when XLS file is loaded and
   saved by C1Excel

       Place: Book.cs, Sheet.cs:

   (TFS:29831)

 * Fixed unlike previous build, "Excel found unreadable content ..." message is shown
   when Excel file generated by C1Excel is opened.

       Place: BiffFormula.cs, Cell.cs:

   (TFS:27614)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20123.243	Build Date: Nov 07, 2012
========================================================================================

 Corrections
 -----------
 * Fixed (partly) unlike previous build, “EndOfStreamException” is occurred after loading
   and saving if more than 53 cells are commented in xls file.  (Regression Bug)

       Place: OpaqueCreator.cs:

   (TFS:24674)

 * Fixed unlike previous build, the color of the background of the comment box is not
   retained after loading and saving in xlsx file.

       Place: Style.cs:

   (TFS:24707)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20123.242	Build Date: Nov 01, 2012
========================================================================================

 Corrections
 -----------
 * Fixed (partly) it takes time in the output process of data for large number of rows
   and columns in OpenXML format (.xlsx)

       Place: comment line in OpenXmlWriter.cs:
	   zipFile.CompressionLevel = CompressionLevelEnum.BestCompression;

   (TFS:29550)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20123.241	Build Date: Oct 15, 2012
========================================================================================

 Corrections
 -----------
 * Fixed unable to set the column width correctly when font size is set to 11pt.
   Used (first set widths, second set dafault font), for example:

       sheet.DefaultColumnWidth = C1XLBook.PixelsToTwips(72);
       sheet.Columns[1].Width = C1XLBook.PixelsToTwips(72);
       book.DefaultFont = new System.Drawing.Font("Arial", 11);

   (TFS:28999)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20122.240	Build Date: Sep 11, 2012
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
- Added Metro-style icons to .NET 2.x assembly.

========================================================================================
C1.C1Excel.dll Build Number 2.1.20122.239	Build Date: Sep 01, 2012
========================================================================================

 Corrections
 -----------
 * Fixed error occurs if a file is loaded and saved in which cell of different sheet
   is mentioned as absolute reference in SUMPRODUCT function. (TFS:27562)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20122.238	Build Date: Aug 31, 2012
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
- Added Metro-style icons.

 Corrections
 -----------
 * Fixed formulas are stripped when new excel file is created using clone function.
   (TFS:24069)

 * Fixed exception 'Index was out of range...' is thrown on creating an excel file with
   large number of rows/columns  with styles applied. (TFS:26528)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20122.237	Build Date: Aug 28, 2012
========================================================================================

 Corrections
 -----------
 * Fixed error message is displayed in English when the .xls file set with password is
   loaded. (TFS:27346)

 * Fixed error 'Invalid Excel OpenXml file' is occurred on loading an excel file after
   saving as another one. (TFS:23710)

 * Fixed Excel found unreadable content is shown when load and save the excel which
   contain ‘ROUNDUP’ formula. (TFS:21319)

 * Fixed IndexOutOfRangeException is thrown on loading XLS file with Chart. (TFS:24018)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20122.236	Build Date: Aug 02, 2012
========================================================================================

 Corrections
 -----------
 * Fixed if textboxes and comments exist in a sheet, the Excel file cannot be saved
   correctly. (TFS:23093)

 * XLSX parly fixed if XLS file is loaded and saved by C1Excel, setting font size over
   24 causes text inside cell to be disappeared. (TFS:22992)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20122.235	Build Date: Jul 18, 2012
========================================================================================

 Corrections
 -----------
 * Fixed if XLS file is loaded and saved by C1Excel, setting font size over 24 causes
   text inside cell to be disappeared. (TFS:22992)

 * Partly fixed unlike previous build, TextBox is lost after loading and saving by
   C1Excel. (TFS:23563)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20122.234	Build Date: Jul 09, 2012
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Licensing code changes. (V2/2012).
 
 Corrections
 -----------
  * Fixed request to change Url and Copyright Statement in AboutBox. (TFS:23833)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20122.233	Build Date: Jun 14, 2012
========================================================================================

 * V2/2012 build

 Corrections
 -----------
  * Fixed an error occurs when an Excel 2003 file containing a protected sheet is loaded
    using the Load method. (TFS:23232)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20121.232	Build Date: May 28, 2012
========================================================================================

 Corrections
 -----------
 * Fixed regression ArgumentException raised on loading excel file containing references
   to another sheet. (TFS:16940)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20121.231	Build Date: May 25, 2012
========================================================================================

 Corrections
 -----------
 * Fixed OpenXml file with strikeout text can’t be loaded into FlexGrid. (TFS:21831)

 * Fixed when an excel file set with formula using named array constant is saved, the
   formula does not get saved. (TFS:22875)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20121.230	Build Date: Apr 25, 2012
========================================================================================

 Corrections
 -----------
 * Fixed exported excel file are corrupted if cell value is "NaN" or "Infinity". Only
   for xlsx version. (TFS:21356)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20121.229	Build Date: Apr 11, 2012
========================================================================================

 Enhancements/Documentation/Behavior Changes
 ------------------------------------------- 
 * Changed BiffFormula class, now parse text formula only it is necessary.

 Corrections
 -----------
 * Fixed when loading of .xlsx file contained macros and 15 sheets took too long to
   load. (TFS:21148)

 * Partly fixed Performance problem occurred on saving the excel file contains 10,000
   rows and 265 columns. (TFS:19638)
 
=======================================================================================
C1.C1Excel.dll Build Number 2.1.20121.228	Build Date: Mar 19, 2012
========================================================================================

 Enhancements/Documentation/Behavior Changes
 ------------------------------------------- 
 * Changed XLSheet.CopyFormula method (support others worksheet (not only current) of
   the workbook.

 * Changed support custom palette of workbook.
   For example:

            book.Palette = GetPalette();
            var sheet = book.Sheets[0];

            // style with palette colors
            var style = new C1.C1Excel.XLStyle(book);
            style.BackColor = Color.FromArgb(0xFF, 0x6C, 0xCB, 0xED); // color from custom palette
            style.ForeColor = Color.FromArgb(0xff, 0x00, 0x35, 0x60); // color from custom palette too

            // set style and text value
            sheet[12, 1].Style = style;
            sheet[12, 1].Value = "color";

 Corrections
 -----------
 * Fixed when the file contains 'Black' back color and save the file as Biff format,
  'White' back color is displayed in saved Biff file[NOT observed with 224]. (TFS:20610)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20121.227	Build Date: Mar 14, 2012
========================================================================================

 Enhancements/Documentation/Behavior Changes
 ------------------------------------------- 
 * Small changes in asserts and BIFF formula.

 * Added XLSheet.CopyFormula method. This method copies the formula from a source cell
   to a destination cell, adjusting relative references.

  For example:
        sheet[0, 6].Formula = "$E1+F1";
        sheet.CopyFormula(0, 6, 29, 7);
        Debug.Assert(sheet[29, 7].Formula == "$E30+G30");
 
========================================================================================
C1.C1Excel.dll Build Number 2.1.20121.226	Build Date: Mar 13, 2012
========================================================================================

 Corrections
 -----------
 * Fixed incorrect using named ranges in cell ranges. (TFS:20516)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20121.225	Build Date: Mar 09, 2012
========================================================================================

 Enhancements/Documentation/Behavior Changes
 ------------------------------------------- 
 * Added support custom palette of workbook.
   For example:  
      book.Palette = palette;		// where palette array of Color

 Corrections
 -----------
 * Fixed error 'The codec cannot use the type...' is occurred when loading an excel file
   which contains macro with .xls file format (WPF). (TFS:18441)

 * Fixed the excel file generated by C1Excel cann't be opened if the cell background is
   black (WPF). (TFS:19911)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20121.224	Build Date: Feb 28, 2012
========================================================================================

 Enhancements/Documentation/Behavior Changes
 ------------------------------------------- 
 * Added support named ranges for XLCellRange constructor. Using:

             // add named ranges
            _book.NamedRanges.Add("FTest", sheet, 12, 2);
            _book.NamedRanges.Add("STest", sheet, 14, 2, 2, 3);

            // cell range test
            var cr1 = new XLCellRange(_book, "FTest:STest");
            cr1.Value = 10;
            var cr2 = new XLCellRange(_book, "STest");
            cr2.Value = 20;

Result in C13:E16

    10	10	10
    10	10	10
    20	20	20
    20	20	20

 Corrections
-------------
* Fixed the problem with "Sum(Value.First:Value.Last)" formula in C1Excel (Desktop/WPF
  /SL/Phone). (TFS:20186)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20121.223	Build Date: Feb 17, 2012
========================================================================================

 Enhancements/Documentation/Behavior Changes
 ------------------------------------------- 
 * Added GetFormattedText method for XLSheet class. In result of the method -- formatted
   text. For it method is using style format value of the cell.

========================================================================================
C1.C1Excel.dll Build Number 2.1.20121.222	Build Date: Feb 16, 2012
========================================================================================

 Corrections
-------------
* Fixed when load and save the csv file which contains double quotation mark in cell,
  the quotation mark is shown as semicolon (;) in saved csv file. (TFS:19695)

* Fixed when load the file and save as CSV file which contain Date formula (Now()),
  wrong date data is shown. (TFS:19720)

* Fixed when load and save the csv file which contains a comma in cell, the contents
  in cell are shown as separate column in saved csv file. (TFS:19694)

* Clarify for request the behavior/functioning of CSV file in C1Excel. (TFS:19967)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20121.221	Build Date: Feb 03, 2012
========================================================================================

 Enhancements/Documentation/Behavior Changes
 ------------------------------------------- 
* Small changed in description of public classes, enumerations, properties and methods.

 Corrections
-------------
* Fixed a message box 'Excel found unreadable content in ...' is displayed on loading
  the excel file. (TFS:19557)

* Fixed when load the file and save as CSV file which contain Date formula (Now()),
  wrong date data is shown. (TFS:19720)

* Fixed when load and save the csv file which contains double quotation mark in
  cell, the quotation mark is shown as semicolon (;) in saved csv file. (TFS:19695)

* Fixed different values observed in XLSheet.GridColor property. (TFS:19659)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20121.220	Build Date: Jan 27, 2012
========================================================================================
 
 Corrections
-------------
* Fixed 'Unicode prefix' text is shown in the first cell on creating an empty .csv file
  with C1Excel. (TFS:19568)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20121.219	Build Date: Jan 24, 2012
========================================================================================
 
 Corrections
-------------
* Fixed Save() method of c1XLBook1.Sheet class is not found in C1Excel. Exist SaveCsv
  and LoadCsv methods. (TFS:19513)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20121.218	Build Date: Jan 19, 2012
========================================================================================

 Enhancements/Documentation/Behavior Changes
 ------------------------------------------- 
 * Added support csv formats. You can load and save of first sheet in csv format.
    For example:
         c1XLBook1.Load("Formats.csv");
         c1XLBook1.Save("Test.csv");
	or
         c1XLBook1.Sheets[2].LoadCsv("Formats.csv");
         c1XLBook1.Sheets[2].SaveCsv("Test.csv");

 * V1/2012 build

 Corrections
-------------
 * Fixed styles are not applied on the XlCellRange. (TFS:18382)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20113.217	Build Date: Dec 07, 2011
========================================================================================

 Corrections
-------------
 * Fixed ZStreamException is observe after loading “XLSX”(OpenXML) and
   “XLTX”(OpenXMLTemplate) format in C1Excel. (TFS:18668)

 * Fixed invalid character exception occurred during an saving Excel file with “escape”
   characters. (TFS:18600)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20113.216	Build Date: Nov 30, 2011
========================================================================================
    
 Enhancements/Documentation/Behavior Changes
 ------------------------------------------- 
 * Updated licensing with fixes to conform with Federal Information Processing Standards
   requirements.

 * Merge from Silverlight\WPF\Phone version.

 * Merge from C1Zip.

========================================================================================
C1.C1Excel.dll Build Number 2.1.20113.215	Build Date: Nov 23, 2011
========================================================================================
    
 Enhancements/Documentation/Behavior Changes
 ------------------------------------------- 
 * Updated licensing to conform with Federal Information Processing Standards
   requirements.

========================================================================================
C1.C1Excel.dll Build Number 2.1.20113.214	Build Date: Nov 08, 2011
========================================================================================

 Corrections
-------------
 * Fixed 'Rows to repeat at top' values are not displayed in the 'Page Setup' window
   with .xlsx format. (TFS:18216)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20113.213	Build Date: Nov 04, 2011
========================================================================================

 Corrections
-------------
 * Fixed BIFF (xls format) part of the formula is lost when the sheet is saved and
   re-loaded. (TFS:18164)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20113.212	Build Date: Nov 03, 2011
========================================================================================

 Corrections
-------------
 * Fixed the formula is lost when the sheet is saved and re-loaded. (TFS:18164)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20113.211	Build Date: Oct 27, 2011
========================================================================================

 Corrections
-------------
 * Fixed setting the border styles of a cell results in Excel warning. (TFS:18026)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20113.210	Build Date: Oct 14, 2011
========================================================================================

 Corrections
-------------
 * Partly fixed newly supported .XLST format for C1Excel can not loaded. (TFS:17654)

 * Fixed unlike previous build, "Excel found unreadable content ..." message is shown on
   opening the excel file which is generated using C1Excel and contains Offset()
   function [Broken since 204 build]. (TFS:17693)

 * Fixed when loading .xls file containing a chart sheet, the Chart Sheet is not getting
   deleted and shown as plain sheet. [Not Observed with 196 build]. (TFS:17652)

 * Fixed when loading .xlsx file and saving as .xlsx file, the formula which has no
   value in cells is not retained in the output .xlsx file. (TFS:17226)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20113.209	Build Date: Oct 07, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Merge changes with Silverlight and WPF (XAML define instead WPF define, added
   WINDOWS_PHONE define).

 Corrections
-------------
 * [WPF] Incorrect calculate width of the char (_twipsPerChar) using font metrics get
   from WIN32 functions for compatible Excel behavior.
   Reason: for WIN32 functions it was used in WPF version System.Windows.Media.Size, but
   for font metrics WIN32 functions it is necessary using System.Drawing.Size.
   (TFS:17670)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20113.208	Build Date: October 4, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Enhanced licensing in environments with some security policy restrictions

========================================================================================
C1.C1Excel.dll Build Number 2.1.20113.207	Build Date: Sep 30, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Added support XLST format (Excel templates).

 Corrections
-------------
 * Fixed request to provide support for XLST format. (TFS:17482)

 * Fixed when Loading of .xls file which contains Chart in C1Excel, VisualStudio is not
   Responding. (TFS:17359)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20113.206	Build Date: Sep 13, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * V3/2011 build

========================================================================================
C1.C1Excel.dll Build Number 2.1.20112.205	Build Date: Aug 29, 2011
========================================================================================

 Corrections
-------------
 * Fixed ArgumentException raised on loading excel file containing references to another
   sheets. (TFS:16940)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20112.204	Build Date: Aug 16, 2011
========================================================================================

 Corrections
-------------
 * Fixed 'NullReferenceException' occurs when sheet name contains invalid characters
   when acquiring "NamedRanges[index].Comment". (TFS:16601)

 * Fixed part of formula appears in the cell when load '.xlsx' format and save as '.xls'
   format. (TFS:16626)

 * Fixed ArgumentNullException occurs when load '.xls' file that contain Offset()
   function for BIFF8 version. (TFS:16687)
 
========================================================================================
C1.C1Excel.dll Build Number 2.1.20112.203	Build Date: Aug 11, 2011
========================================================================================

 Corrections
-------------
 * Fixed sheet name contains invalid characters when acquiring named range comment.
   (TFS:14521)

 * Fixed ‘EndOfStreamException’ is raised on loading the Excel file. (TFS:16287)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20112.202	Build Date: Jul 11, 2011
========================================================================================

 Corrections
-------------
 * Fixed "Error in value" error is observed and "#VALUE!" is seen in cell with text
   formula in XLS file format. (TFS:16210)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20112.201	Build Date: Jul 07, 2011
========================================================================================

 Corrections
-------------
 * Fixed at times, position of a string is changed to BottomAligned in the output.
   (TFS:16051)

 * Fixed part two of 15764 issue (Comments are shown in incorrect position). (TFS:15764)

 * Fixed after loading and saving an excel file which has '=SUM((B1,B2))' formula with
   C1Excel, the formula does not correctly worked in the new excel file. (TFS:15461)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20112.200	Build Date: Jul 01, 2011
========================================================================================

 Corrections
-------------
 * Fixed ‘The given key was not present in the dictionary’ exception is occurred when
   loading the excel file. (TFS:15764)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20112.199	Build Date: Jun 17, 2011
========================================================================================

 Corrections
-------------
 * Fixed group and expand/collapse button is not shown for column outline level when
   excel workbook is created and set outline. (TFS:15757)

 * Fixed when OutlineLevel property of columns are set and exported to excel OpenXml
   format file, the data are exported without group/outlinelevel information.(TFS:15751)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20112.198	Build Date: Jun 07, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Added print settings properties for outline buttons place:
   OutlinesBelow property of XLSheet class (true is default)
     false = Outline buttons above outline group
     true  = Outline buttons below outline group
   OutlinesRight property of XLSheet class (true is default)
     false = Outline buttons left of outline group
     true  = Outline buttons right of outline group

  The property TotalsBelowData of XLSheet class is deprecated, added MaxOutlineLevel
  property for indicate subtotals outlines in Excel worksheets.

 Corrections
-------------
 * Probably fixed one of the columns in the second sheet becomes invisible after saving
   in the different path and opening it. (TFS:15297)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20112.197	Build Date: May 30, 2011
========================================================================================

 Corrections
-------------
 * Small change to accommodate the attached spreadsheet by John Juback. In
 OpenXmlReader.cs, LoadStyles, line 824:
    XlsxAssert(key >= 0 && format != null && format.Length > 0);
	(key >= 0 instead of key > 0).

 * Fixed "File error: data may have been lost." error is shown when 'xlsx' file that
   contain 'SUM' formula reference cells is read and saved as 'xls' file. (TFS:15506)

 * Fixed null reference exception was unhandled error is thrown
   on loading .xlsx excel file which has data and charts. (TFS:15432)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20112.196	Build Date: May 24, 2011
========================================================================================

 Corrections
-------------
 * Fixed calculation result is not reflected in the Excel file (*.xls) after output even
 though value is set in the reference cells of the formula.  (TFS: 15446)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20112.195	Build Date: May 17, 2011
========================================================================================

 Corrections
-------------
 * Partly fixed Sheet name contains invalid characters when acquiring named range
   comment.  (TFS: 14521)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20112.194	Build Date: May 10, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Added methods for support rows to repeat at top and columns to repeat at left at
 sheet print. For example:

	// gets repeat range
    int rowFrom, rowTo, colFrom, colTo;
    if (c1XLBook1.Sheets[0].GetRangeToRepeat(out rowFrom, out rowTo, out colFrom, out colTo))
    {
		// exist range
    }


	// sets repeat range
	c1XLBook1.Sheets[0].SetRangeToRepeat(0, 1, -1, -1);

 Corrections
-------------
 * Fixed no image is found in exported excel file if ContrastInPercents is set as 100.
  (TFS: 15192)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.193	Build Date: May 03, 2011
========================================================================================

 Corrections
-------------
 * Fixed BrightnessInPercents and ContrastInPercents properties of XLPictureShape is not
   set correctly in OpenXml format. (TFS: 15132)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.192	Build Date: Apr 27, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
  Added new properties for XLPictureShape: BrightnessInPercents and ContrastInPercents.

  // Gets or sets the brightness in percents of this "XLPictureShape" (between -100 and 100).
  public float BrightnessInPercents

  // Gets or sets the contrast in percents of this "XLPictureShape" (between -100 and 100).
  public float ContrastInPercents

 Corrections
-------------
 * Fixed part of comments in consecutive cells are shown blank or missing after load and
   save xls file. (TFS: 14949)

 * Fixed cannot apply Author of comment set by C1Excel using Comments.Add() Method.
   (TFS: 14965)

 * Fixed image does not appears in the sheet in Biff8 format when setting
   'XLPictureShape.Contrast' value is greater than '0.74f'. (TFS: 14951)

 * Fixed when IFERROR() method is used , the concatenated value is not displayed
   correctly. (TFS: 14926)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.191	Build Date: Apr 15, 2011
========================================================================================

 Corrections
-------------
 * Fixed Exception 'NullReferenceException' was occurred on loading an excel file
   which has freeze panes. (TFS: 14923)

 * Fixed “Excel found Unreadable Content” error occurs when load and save xlsx file
   with SheetName up to maximum length of integers. (TFS: 14957)

 * Fixed Tab color set in code cannot be applied in saved excel file. (TFS: 14959)

 * Fixed after loaded and saved by C1Excel, pattern in merged cells is not retained
   at OpenXML format and is distorted at BIFF8 format. (TFS: 14969)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.190	Build Date: Apr 14, 2011
========================================================================================

 Corrections
-------------
 * Fixed 'BackColor' does not appear when load xls (Biff8)  and save to xls (Biff8) with
   Biff8 format. (TFS: 14947)

 * Fixed (xlsx to xls save part) for the background color 'black' is shown in the cell
   while editing. (TFS: 14925)

 * Fixed regression issue: Incorrect Value  is displayed in saved xls file when Formula
   includes SUMPRODUCT function. (TFS: 9764)

 * Fixed comments in consecutive cells are shown blank or missing after load and save
   xls file. (TFS: 14949)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.189	Build Date: Apr 07, 2011
========================================================================================

 Corrections
-------------
 * Fixed BackColor does not appear when C1Excel is saved as .xls (BIFF8) format.
   (TFS: 14810)

 * Fixed the background color 'black' is shown in the cell while editing. (TFS: 14925)

 * Fixed pictures are not retained in xlsx file (OpenXML Format) after loaded and saved.
   (TFS: 14843)

 * Fixed sheet name contains invalid characters when acquiring named range comment.
   (TFS: 14521)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.188	Build Date: Apr 06, 2011
========================================================================================

 Corrections
-------------
 * Fixed error value is shown in the cell which has SUMIF Formula with a single cell
   range and sum range. (TFS: 14591)

 * Fixed #VALUE! is seen on Saved xls file when C1Excel contains a certain formula.
   (TFS: 14677)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.187	Build Date: Mar 25, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Changed support Desktop, WPF and Silverlight versions in common code.

 Corrections
-------------
 * Fixed exception at using Medium Trust for Website (part two) at save. (TFS: 14589)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.186	Build Date: Mar 07, 2011
========================================================================================

 Corrections
-------------
 * Fixed XLComment , XLCommentCollection class is not present in build 185 but was seen
   in build 176 [Forums]. (TFS: 14639)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.185	Build Date: Mar 07, 2011
========================================================================================

 Corrections
-------------
 * Fixed exception at using Medium Trust for Website. (TFS: 14589)

 * Fixed part 'CalculationMode' - 'Auto' is not working in .xlsx C1Excel file of the 
   operators at the right are doing first in .xls file. (TFS: 14293)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.184	Build Date: Mar 03, 2011
========================================================================================

 Corrections
-------------
 * Fixed regression issue: Request to provide property to set "Row to repeat at top",
   "Column to Repeat at left"  in page setup  through C1Excel. (TFS: 13748)

 * Fixed unlike other C1 win controls Deactivate Dialog shows different license key
   rather than SU license key. (TFS: 14452)

 * Fixed request to change the background color to white on loading .xls file to
   C1FlexGrid in FlexGridExcel2010 product sample. (TFS: 14252)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.183	Build Date: Feb 28, 2011
========================================================================================

 Corrections
-------------
 * Fixed performance problem in creating new excel file with 50000 rows and 10 columns.
  (TFS:14506)

 * Fixed xlsx part of value is not reflected when an Excel sheet is set with a formula
   where the calculation result is “” (empty string) on output. (TFS:14093)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.182	Build Date: Feb 20, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Added support Desktop, WPF and Silverlight versions in common code.

 Corrections
-------------
 * Fixed the left most cells are converted to text from number in .xls file, error is
   thrown on loading that file. (TFS:14383)

 ========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.181	Build Date: Feb 10, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Added support of inline strings as one more value format of the Excel cell.

 Corrections
-------------
 * Fixed value is not reflected when an Excel sheet is set with a formula where the
   calculation result is “” (empty string) on output. (TFS:14093)

 * Fixed operators at the right are doing first in .xls file. (TFS:14293)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.180	Build Date: Feb 08, 2011
========================================================================================

 Corrections
-------------
 * Fixed request to provide property to set "Row to repeat at top","Column to Repeat at
   left" in page setup  through C1Excel (part 2). (TFS: 13748)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.179	Build Date: Jan 26, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------

 * Added CalculationMode workbook property of all formulas.

      C1XLBook book = new C1XLBook();
      XLSheet sheet = book.Sheets[0];

      // simple formula
      sheet[7, 0].Value = "Formula: 5!";
      sheet[7, 1].Value = 122;
      sheet[7, 1].Formula = "1*2*3*4*5";

      book.CalculationMode = CalculationMode.Manual;
      book.Save("Save.xlsx");

	 If CalculationMode is Manual that value = 122 at open in Excel, if CalculationMode is is Auto that 120.

 * Fixed bug in support rows and columns page breaks for Open XML format.

Now works code:
            C1XLBook book = new C1XLBook();
            book.Sheets[0][2, 3].Value = "pageRow1";
			book.Sheets[0].Rows[2].PageBreak = true;
            book.Sheets[0][3, 3].Value = "pageRow2";
            book.Sheets[0][0, 1].Value = "pageColumn1";
            book.Sheets[0].Columns[1].PageBreak = true;
            book.Sheets[0][0, 2].Value = "pageColumn2";
			book.Save("Save.xlsx");

 Corrections
-------------
 * Fixed request to provide property to set "Row to repeat at top","Column to Repeat at
   left" in page setup  through C1Excel. (TFS: 13748)

 * Fixed hanging on loading .xls file which contains Drop Down control. (TFS: 10822)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.178	Build Date: Jan 21, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------

 * Added support rows and columns page breaks for Open XML format.

Code example:
            C1XLBook book = new C1XLBook();
            book.Sheets[0][2, 3].Value = "page1";
			book.Sheets[0].Rows[2].PageBreak = true;
            book.Sheets[0][3, 3].Value = "page2";
            book.Save("Save.xlsx");

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.177	Build Date: Jan 12, 2011
========================================================================================

 Corrections
-------------
  * Fixed error message 'Unable to read file.' seen on opening saved xls file.
    Regression, crash in release build. (TFS: 12846)

  * Fixed when OutlineLevel property of rows are set and exported to excel file, the
    data are exported without group/outlinelevel information. (TFS: 14136)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.176	Build Date: Jan 06, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------

 * Added support Excel comments (notes).

Code example:
            C1XLBook book = new C1XLBook();
            book.Sheets[0][2, 3].Value = "test";
            book.Sheets[0].Comments.Add(2, 3, "Oleg", "Test comment");
            book.Sheets[0].Comments[0].TextBox.Rectangle = new Rectangle(220, 210, 1900, 1200);
            book.Save("Save.xls");   // or "Save.xlsx"

 Corrections
-------------
  * Fixed error message 'Unable to read file.' seen on opening saved xls file.
    (TFS: 12846)

  * Fixed after setting cell formula through format, formula is not retained  in the
    xlsx output ( but correct in xls output). (TFS: 13335)

  * Partly fixed (images are not saved) Cell Formatting when BIFF8 file is loaded and
    saved using C1Excel. (TFS: 13002)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20111.175	Build Date: Dec 20, 2010
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * V1/2011 build

========================================================================================
C1.C1Excel.dll Build Number 2.1.20103.174	Build Date: Oct 19, 2010
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Added support Excel subtotals for rows and columns. Below a subtotals sample:
 
            C1XLBook book = new C1XLBook();
            XLSheet sheet = book.Sheets[0];
            XLStyle totalStyle = new XLStyle(book);
            totalStyle.Font = new Font(book.DefaultFont, FontStyle.Bold);
            sheet[2, 1].Value = "Number";
            sheet[2, 2].Value = "ID";
            sheet[3, 1].Value = 12;
            sheet[3, 2].Value = 17;
            sheet.Rows[3].OutlineLevel = 2;
            sheet.Rows[3].Visible = false;
            sheet[4, 1].Value = 12;
            sheet[4, 2].Value = 14;
            sheet.Rows[4].OutlineLevel = 2;
            sheet.Rows[4].Visible = false;
            sheet[5, 1].Value = "12 Total";
            sheet[5, 1].Style = totalStyle;
            sheet[5, 2].Value = 31;
            sheet[5, 2].Formula = "SUBTOTAL(9,C4:C5)";
            sheet.Rows[5].OutlineLevel = 1;
            sheet[6, 1].Value = 34;
            sheet[6, 2].Value = 109;
            sheet.Rows[6].OutlineLevel = 2;
            sheet[7, 1].Value = "34 Total";
            sheet[7, 1].Style = totalStyle;
            sheet[7, 2].Value = 109;
            sheet[7, 2].Formula = "SUBTOTAL(9,C7:C7)";
            sheet.Rows[7].OutlineLevel = 1;
            sheet[8, 1].Value = "Grand Total";
            sheet[8, 1].Style = totalStyle;
            sheet[8, 2].Value = 140;
            sheet[8, 2].Formula = "SUBTOTAL(9,C4:C7)";
            sheet.Rows[8].OutlineLevel = 0;
            book.Save("Save.xls");   // or "Save.xlsx"

 Corrections
-------------
 * Partly fixed incorrect cell Formatting when BIFF8 file is loaded and saved using
   C1Excel. (TFS: 13002)

 * Fixed "PatternColor" do not get set in BIFF8 files. (TFS: 13087)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20103.173	Build Date: Sep 25, 2010
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Small changes in readme.txt and comments (correct mistakes).
 * V3/2010 build
 
========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.172	Build Date: Sep 18, 2010
========================================================================================

 Corrections
-------------
 * Fixed exception is observed on loading excel file containing IF() function
   referencing SheetNames. (TFS: 12648)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.171	Build Date: Aug 25, 2010
========================================================================================

 Corrections
-------------
 * Fixed multiple issues are observed on formula with sheet names when saving in Biff8
   (.xls) format. (TFS: 11719)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.170	Build Date: Jul 28, 2010
========================================================================================

 Corrections
-------------
 * Fixed when create copy by calling XLSheet.Clone() method, row's height and column's
   width are not retained. (TFS: 11437)

 * Fixed problem seen when FitPagesAcross is set and FitPagesDown is not set and vice
   versa. (TFS: 11203)

 * Fixed ‘Excel found unreadable content in……’ error is thrown for Load & Save xls file
   and calendar control cannot be retained by C1Excel. (TFS: 10824)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.169	Build Date: Jul 20, 2010
========================================================================================

 Corrections
-------------
 * Fixed "#VALUE!" error is shown on saving formula with sheet names from Open XML to
   BIFF8 format. (TFS: 11721)

 * Fixed regression issue: Incorrect Value ( '#VALUE!) is displayed in saved xls file
   when loading xlsx file  containing Named Range. (TFS: 9535)

 * Fixed regression issue: Errors are seen when load & Save MS excel file including
   SUM() formula. (TFS: 9792)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.168	Build Date: Jul 12, 2010
========================================================================================

 Corrections
-------------
 * Fixed Row height is increased on saving an Biff8 file containing textbox in BIFF8
   format. (TFS: 11429)

 * Fixed regression issue: Multiple problems seen when loading an excel file containing
   nested function and named ranges. (TFS: 9503)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.167	Build Date: Jul 08, 2010
========================================================================================

 Corrections
-------------
 * Fixed error is observed & MS Excel crashes on opening Saved Biff8 (xls) file when
   OpenXml(xlsx) file containing Table() function is saved in Biff8 (xls) format.
   (TFS: 11427)

 * Fixed regression issue: Incorrect Value ( '#VALUE!) is displayed in saved xls file
   when loading xlsx file  containing Named Range. (TFS: 9535)

 * Fixed regression issue: Incorrect Value  is displayed in saved xls file when Formula
   includes SUMPRODUCT function. (TFS: 9764)

 * Fixed regression issue: Errors are seen when load & Save MS excel file including
   SUM() formula. (TFS: 9792)

 * Fixed regression issue: Formula & Value is not retained in save excel file when
   function contains decimal value. (TFS: 9852)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.166	Build Date: Jul 05, 2010
========================================================================================

 Corrections
-------------
 * Fixed regression issue: [OpenXML] Errors are seen when save & load MS excel in which
   data are getting from text file. (TFS: 9627)

 * Fixed XmlException is thrown when loading MS Excel file containing Drop Down control
   for OpenXML (xlsx) format (drop down in Open XML format is limitation now).
   (TFS: 10822)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.165	Build Date: Jun 29, 2010
========================================================================================

 Corrections
-------------
 * Fixed regression issue: Incorrect Value ( '#VALUE!) is displayed in saved xls file
   when loading xlsx file  containing Named Range. (TFS: 9535)

 * Fixed regression issue: Errors are seen when load & Save MS excel file including
   SUM() formula. (TFS: 9792)

 * Fixed regression issue: Error message ‘File Error : Data may have been lost’ is seen
   on opening the saved Biff8 (xls) file where load format is OpenXML (xlsx) in which
   Address() function is added. (TFS: 10801)

 * Fixed unlike previous build, [File error : data may have been lost.] message is shown
   on opening the XLS file which is loaded and saved by C1Excel using XLSX file imported
   from text file. (TFS: 10931)

 * Fixed formula is not calculated & "#VALUE!" is displayed in saved BIFF8 excel file
   when Formula contains SUMIF Function. (TFS: 11434)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.164	Build Date: Jun 24, 2010
========================================================================================

 Corrections
-------------
 * Fixed unexpected behavior is observed when load & save excel file including Japanese
   text and Japanese Font by C1Excel. (TFS: 10122)

 * Partly fixed grouped rows are hidden when empty excel with grouped rows is loaded &
   saved using C1Excel. (TFS: 10805)

 * Fixed when read / write Excel file that has never set explicitly Page SetUp options,
   incorrect values of Page SetUp options and Print options are read or saved.
   (TFS: 11254)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.163	Build Date: Jun 21, 2010
========================================================================================

 Corrections
-------------
 * Fixed C1Excel does not get licensed with Reports for .NET Designer Edition keys.
  (TFS: 10763)

 * Fixed 'IndexOutOfRangeException' is observed on saving excel file containing Array
   function when both load and save formats are OpenXML. (TFS: 10811)

 * Fixed unlike release build, logical formula IF() function cannot be retained by
   C1Excel on Load & Save scenario in Open XML format. (TFS: 10995)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.162	Build Date: Jun 08, 2010
========================================================================================

 Corrections
-------------
 * Fixed Exception is thrown for OpenXML and error is seen for Biff8 on Load & Save
   scenario of MS Excel containing DropDown control with added data. (TFS: 10829)

 * Fixed unlike previous build, [File error : data may have been lost.] message is shown
   on opening the XLS file which is loaded and saved by C1Excel using XLSX file imported
   from text file. (TFS: 10931)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.161	Build Date: Jun 02, 2010
========================================================================================

 Corrections
-------------
 * Fixed Japanese localized evaluation dialog box is not shown if unlicensed C1Excel DLL
   is used. (TFS: 10748)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.160	Build Date: Jun 01, 2010
========================================================================================

 Corrections
-------------
 * Problems when loading and saving MS Excel containing WORKDAY() function.
   (TFS: 10888)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.159	Build Date: May 28, 2010
========================================================================================

 Corrections
-------------
 * Fixed "EndOfStreamException" is observed when excel file containing "Table()"
   function is loaded. (TFS: 10745)

 * Fixed exception is observed on loading Biff8 format excel file containing Array
   Formula. (TFS: 10806)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.158	Build Date: May 21, 2010
========================================================================================

 Enhancements/Documentation/Behavior Changes 
---------------------------------------------
 * Remove children of shared formula at setting cell value.

 Corrections
-------------
 * Fixed errors are seen when copying cell values from one sheet to another of excel
   file in which SUM() formula is added. (TFS: 10769)

 * Fixed LoadExcel method of C1Excel take about 40 seconds to load MS Excel file in
   which OFFSET() function and ranged name are added at Open XML format. (TFS: 10795)
 
 * Fixed error message ‘File Error : Data may have been lost’ is seen on opening the
   saved Biff8 (xls) file where load format is OpenXML (xlsx) in which Address()
   function is added. (TFS: 10801)

 * Fixed Incorrect Value ('#VALUE!') is displayed in saved xls file when loading xlsx
   file  containing IF() and SUM() formula. (TFS: 10810)

 * Fixed "ArgumentException" was observed on saving an excel file containing textbox in
   BIFF8 format. (TFS: 10812)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.157	Build Date: May 08, 2010
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Grouping behavior changed. If select a range and select "Group Rows" or "Group
   Columns". With the original code, the grouping symbols would appear above (rows) and
   to the left (cols) of the data. With the new code, the grouping symbols appear below
   (rows) and to the right (cols) of the data. This is the Excel default behavior.

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.156	Build Date: May 07, 2010
========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Licensing code changes. (V2/2010).
 
 Corrections
-------------
 * Fixed unexpected behavior is observed when load & save excel file including Japanese
   text and Japanese Font by C1Excel. (TFS: 10122)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.155	Build Date: May 05, 2010
=========================================================================================

 Corrections
-------------
 * Fixed unlike previous build, spaces have been removed in excel files generated by
   C1Excel in which RTF text are added. (TFS: 10698)

========================================================================================
C1.C1Excel.dll Build Number 2.1.20102.154	Build Date: May 04, 2010
=========================================================================================

 Corrections
-------------
 * Fixed multiple issues are observed on adding RTF text in Excel sheet cell (image and
   colored text issues). (TFS: 10615)
   
 * Fixed exception is observed when RTF text with paragraph spacing and Font size more
   than 10pt is saved in XLSX file. (TFS: 10632)
   
 * Fixed "CultureNotFoundException" is observed when ASCII coding is used for copying RTF
   File text in C1Excel sheet. (TFS: 10633)

 * Fixed ArgumentException["Culture ID 1024 (0x0400) is not a supported culture.Parameter
   name: culture"] is thrown on saving C1XLBook after loading the Rich Text string from
   RTF file. (TFS: 10305)
   
 * Fixed unhandled exception seen when loading xls file created using AS400. (TFS: 10306)
   
=========================================================================================
C1.C1Excel.dll Build Number 2.1.20101.152	Build Date: Apr 20, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Changed support RTF value of the cells. Added support paragraph styles of RTF code.
 * Changed to string method for range token of C1Excel formulas.
 * Added .NET 4.0 version (with separate designer to support for Client profile)

/////////////////////////////////////////////////////////////////////////////////////////
//
// Below this point all builds are for .NET 2.x only
//
/////////////////////////////////////////////////////////////////////////////////////////

=========================================================================================
C1.C1Excel.dll Build Number 2.1.20101.151	Build Date: Apr 09, 2010
=========================================================================================

 Corrections
-------------
 * Fixed multiple problems seen when loading an excel file containing nested function and
   named ranges (incorrect value '#VALUE!' at xlsx result). (TFS: 9503)
   
 * Fixed unexpected behavior is observed when load & save excel file including Japanese
   text and Japanese Font by C1Excel. (TFS: 10122)

=========================================================================================
C1.C1Excel.dll Build Number 2.1.20101.150	Build Date: Apr 07, 2010
=========================================================================================

 Corrections
-------------
 * Fixed incorrect value ('#VALUE!') is displayed in saved xls file when loading xlsx
   file containing Named Range. (TFS: 9535)
   
 * Fixed inconsistent behavior is observed when setting Name Range before setting cell
   value from code in xls/xlsx format. (TFS: 9665)
   
 * Fixed removing a sheet and then saving in xls format causes error message to be seen
   when saved xls file is opened. (TFS: 9843)
   
 * Fixed when loading .xlsx file including "chart sheet", C1Excel delete the chart sheet
   itself but doesn't delete it's sheet name properly. (TFS: 10002)

=========================================================================================
C1.C1Excel.dll Build Number 2.1.20101.149	Build Date: Mar 30, 2010
=========================================================================================

 Corrections
-------------
 * Fixed text are clipped when setting cell style from code in Open XML format.
   (TFS: 9484)
   
 * Partly fixed unexpected behavior is observed when load & save MS excel containing
   named range in xls format by C1Excel. (TFS: 9611)
   
 * Fixed Formula & Value is not retained in save excel file when function contains
   decimal value. (TFS: 9852)
   
 * Fixed Incorrect formula is displayed in saved xls file when Formula contains SUMIF
   function. (TFS: 9853)
   
 * Fixed InvalidOperationException['Stack empty'] is thrown when saving the C1XLBook
   containing the text from RTF file. (TFS: 9964)

=========================================================================================
C1.C1Excel.dll Build Number 2.1.20101.148	Build Date: Mar 26, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Changed support RTF value of the cells. Added support RTF code from Microsoft Word.

   For example:
   
            sheet = c1XLBook1.Sheets.Add();
            sheet[6, 1].Value = Encoding.ASCII.GetString(File.ReadAllBytes("Word.rtf"));
            sheet.MergedCells.Add(6, 1, 2, 6);

   Where file "Word.rtf" contain paragraph context saved in Microsoft Word.

 Corrections
-------------
 * Fixed incorrect cells size are applied when setting DefaultRowHeight and
   DefaultColunmWidth from code in xlsx (Open XML) format. (TFS: 9828)
   
 * Fixed reference parameter class for a name token if name has same rows.
   (TFS: 9503, 9792)
   
 * Fixed incorrect value is displayed in saved xls file when Formula includes SUMPRODUCT
   function [Fp Id 3220]. (TFS: 9764)
   
=========================================================================================
C1.C1Excel.dll Build Number 2.1.20101.147	Build Date: Mar 18, 2010
=========================================================================================

 Corrections
-------------
 * Fixed error is seen when merging cells from code in excel file which was already
   merged cells across. Removing internal merged cells. (TFS: 9691)
   
 * Fixed lot of memory and time is consumed while loading a certain xlsx file.
   (TFS: 9769)
   
 * Fixed errors are seen when load & Save MS excel file including SUM() formula.
   (TFS: 9792)

=========================================================================================
C1.C1Excel.dll Build Number 2.1.20101.146	Build Date: Mar 17, 2010
=========================================================================================

 Corrections
-------------
 * Fixed error is thrown when saving MS Excel in which SUM formula is added as default
   number in xlsx to xls format. (TFS: 9473)
   
 * Fixed text are clipped when setting cell style from code in Open XML format.
   (TFS: 9484)
   
 * Fixed Unlike MS Excel, ‘Value was either too large or too small for an Int32.’
   exception is thrown when adding too large value to the formula in Biff8 format.
   (TFS: 9570)
   
 * Fixed incorrect value is retained in Name manager after saving MS excel containing
   named range for date in xls format. (TFS: 9603)
   
 * Fixed unexpected behavior is observed when load & save MS excel containing named range
   in xls format by C1Excel. (TFS: 9611)
   
 * Fixed errors are seen when save & load MS excel in which data are getting from text
   file in Open XML format (xlsx). (TFS: 9627)
   
 * Fixed Missing Formula is shown when adding YEAR() formula from code in xls format.
   (TFS: 9641)
   
 * Fixed Black color filled cells are appeared when load and save xlsx file which is
   exported from MS Access in Open XML format (xlsx). (TFS: 9688)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20101.145	Build Date: Mar 04, 2010
========================================================================================= 

 Corrections
-------------
 * Fixed [FP ID 3184]Formula gets Truncated when saving in BIFF8(xls) format. (TFS: 9286)
 
 * Partly fixed row color is not applied to entire row when loading xls file and then
   saving in xls or xlsx format. (TFS: 4664)
   
 * Partly fixed if excel file is loaded and saved by C1Excel, setting font size over 24
   causes text inside cell to be disappeared. (TFS: 7248)
   
 * Partly sheets without rows and columns are shown after saving xls file  to xls/xlsx
   format when loaded with specific sheet. (TFS: 9363)
   
 * Fixed unhandled exception seen when loading OpenXml (xlsx) file containing RANK
   function. (TFS: 9405)
   
 * Fixed [OpenXML] Hyperlink in merged cells are also shown in neighbor cells when loaded
   by C1Excel. (TFS: 9423)
 
 * Fixed incorrect values are displayed in saved xls file when loaded xlsx file has
   function that uses Named Range. (TFS: 9424)
   
 * Fixed Formula and Value are not retained on saving  when loaded xlsx file contains IF
   function. (TFS: 9428)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20101.144	Build Date: Feb 26, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------

 * Licensing code updated (only affects GC builds). (V1/2010).
 * Added support RTF value of the cells.

   For example:

            XLSheet sheet = c1XLBook1.Sheets.Add();
            StringBuilder sb = new StringBuilder();
            sb.Append(@"{\rtf1{\fonttbl{\f0\fnil Arial;}}");
            sb.Append(@"{\colortbl \red0\green0\blue0;}");
            sb.Append(@"\pard\cf0\f0\fs20\i this\i0  text is \b bold");
            sb.Append(@"\b0  and this isn't\par}");
            sheet[6, 1].Value = sb.ToString();
            sheet.MergedCells.Add(6, 1, 2, 4);
  

 Corrections
-------------
 * Fixed error 'Excel found unreadable content' seen on opening saved xlsx(OpenXml) file
   when Formula contains both  Division and Sum operation. (TFS: 9007)
 
 * Fixed Formula gets changed in saved excel file when loading in xlsx (OpenXml) format
   and then saving xls (BIFF8) format. (TFS: 9002)
   
 * Fixed different FirstIndex values are set in saved xls and xlsx files when loading
   single sheet only. (TFS: 9000)
   
 * Fixed Unhandled Exception seen when loading only a single sheet for OpenXml(xlsx)
   files. (TFS: 8994)
  
 * Fixed [VS 2010][ASP][C1Excel control does not work under Framework 4.0 (Licensing
   problem). (TFS: 8985)
   
 * Fixed two part of Sheet Name in Formula gets changed in saved excel file when Loading
   in xls(BIFF8)format and then saving xls(BIFF8) format. (TFS: 8693)
   
 * Fixed two part of column width is not retained  when loading OpenXML(xlsx) format and
   then saving BIFF8(xls) format. (TFS: 8692)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20101.143	Build Date: Jan 27, 2010
========================================================================================= 

 Corrections
-------------
 * Fixed exception is thrown when saving excel file which is imported from Text file in
   a certain scenario at xlsx to xls conversion. (TFS: 8570)
   
 * Fixed multiple problems seen when loading / saving a file that contains range name
   having value as  '#REF'. (TFS: 6574)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20101.142	Build Date: Jan 26, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Changed comments and descriptions of external classes (small changes).
 * Added FirstIndex property for XLSheetCollection.

 Corrections
-------------
 * Fixed C1Excel can’t retain Excel’s Table Format when loading data from AccessDatatBase
   as copy BIFF data. (TFS: 7432)
   
 * Fixed if excel file is loaded and saved by C1Excel, setting font size over 24 causes
   text inside cell to be disappeared. (TFS: 7248)
   
 * Fixed tab for opened sheet is not in visible area when loading excel using C1Excel.
   (TFS: 7455)
 
=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20101.141	Build Date: Jan 22, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added support loading workbook is partly (each worksheet can be loaded separately from
   others worksheets).
   
  New object model:
  property:
			bool C1XLBook.IsLoading { get; }
  methods:		
			void XLSheet.Load(string path, bool next)
			void XLSheet.Load(Stream stream, bool next)
   
  For example:
  
			// path of file for loading (xls or xlsx)
            string path = @"..\..\excel.xls";
            
            // load workbook without worksheet data
            c1XLBook1.Load(path, false);
            
            // continue loading workbook
            Debug.Assert(c1XLBook1.IsLoading);
            
            // load worksheet with index 2, allow next loading
            c1XLBook1.Sheets[2].Load(path, false);
            
            // load worksheet with index 3, finish loading
            c1XLBook1.Sheets[3].Load(path, true);

            // finished loading workbook
            Debug.Assert(!c1XLBook1.IsLoading);

 Corrections
-------------
 * Fixed request to provide a Load function that loads only a particular sheet and not
   the entire excel file. (TFS: 6592)

 * Fixed unlike MS Excel, pictures created by ClipArt can’t be retained by C1Excel when
   saving OpenXML to BIFF8 format. (TFS: 7907)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20101.140	Build Date: Jan 19, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Changed comments and descriptions of external classes (small changes).

 Corrections
-------------
 * Fixed unhandled exception seen when user tries to get or set XLCellRange.Value
   property. (TFS: 8713)
   
 * Fixed FitPagesAcross and FitPagesDown  do not get applied when saving in OpenXML
   (.xlsx) format. (TFS: 8706)
   
 * Fixed row contents are not saved in new XLRow Object, when Clone method is called for
   the first time. (TFS: 8708)
   
 * Fixed error seen on opening saved xlsx file, when loading xls(BIFF8)format and then
   saving in OpenXML(xlsx) format. (TFS: 8694)
   
=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20101.139	Build Date: Jan 15, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Changed comments and descriptions of external classes.

 Corrections
------------- 
 * Fixed unhandled exception seen when loading certain xls/xlsx file (fixed bugs of
   formula's support). (TFS: 7510)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20101.138	Build Date: Jan 11, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Changed comments of the XLNamedRange class.
 * Licensing code changed (V1/2010).

 Corrections
------------- 
 * Fixed exception is thrown when saving excel file which is imported from Text file in
   a certain scenario. (TFS: 8570)
   
 * Fixed space cannot be added before text when adding text to cell from code in OpenXML
   format. (TFS: 7831)
   
 * Fixed incorrect hyperlink in merged cell are not working when loaded by C1Excel in
   OpenXML format. (TFS: 7831)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20101.137	Build Date: Jan 05, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2010 build

 Corrections
------------- 
 * Fixed [Excel found unreadable content ...] message is shown after opening the XLSX
   file (loaded & saved by C1Excel) with FreezePane. (TFS: 8561)

 * Partly fixed (shared part of the formula) error message is seen when loads xlsx excel
   file containing SUM() formula and saves it in xls format. (TFS: 8017)
   
 * Fixed problems are observed when adding a Range Name  from code in OpenXML and BIFF8
   format. (TFS: 8561)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20093.136	Build Date: Dec 30, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Licensing code changed (V1/2010).

 Corrections
------------- 
 * Fixed Column Freeze is not retained in C1Excel loaded file if other column is hidden.
   (TFS: 7736)
   
 * Fixed inconsistent behavior is observed when loading xlsx file in which cells are
   filled with White color (OpenXML format). (TFS: 7428)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20093.135	Build Date: Dec 23, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed error message is seen when loads xlsx excel file containing SUM() formula and
   saves it in xls format. (TFS: 8017)
  
 * Fixed Incorrect value for Long Date format is shown when getting cell value by using
   C1Excel. (TFS: 7541)
   
 * Fixed error message is thrown when merging cells from code in excel file which was
   already merged cells in OpenXML format. (TFS: 7552)
   
 * Fixed exception is thrown when loading shared OpenXML file using C1Excel. (TFS: 7708)
 
 * Fixed exception is thrown when copying data from one sheet to another empty sheet
   from code. (TFS: 7828)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20093.134	Build Date: Dec 21, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Licensing code updated (V1/2010).

 Corrections
------------- 
 * Fixed Saved File Gets Corrupt on saving a file in OpenXml (xlsx) containing IF
   Condition. (TFS: 6041)
   
 * Partly fixed problems related to deleting sheet and ‘KeepsFormula’ property.
   (TFS: 4785)
   
=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20093.133	Build Date: Nov 25, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * For property KeepFormulas changed Japanese description.

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20093.132	Build Date: Nov 23, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Support ICloneable interface (Clone() method) for all public objects.
 * Licensing code updated.

 Corrections
------------- 
 * Fixed problems related to deleting sheet and ‘KeepsFormula’ property. (TFS: 4785)
 
 * Fixed text inside excel sheet cannot be seen when setting different font size, font
   type and font color at OpenXML format. (TFS: 7386)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20093.131	Build Date: Nov 06, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Support selection cells for Excel sheets with active sheet.

 Corrections
------------- 
 * Fixed unhandled exception seen when loading certain xls/xlsx file. (TFS: 7510)
 
 * Fixed error message is shown when opening xlsx [OpenXMl] file in which table and count
   row formula is added and load & save by C1Excel. (TFS: 7500)
   
 * Fixed error message is shown when opening C1Excel file in which formula was added by
   code (BIFF format). (TFS: 7479)

 * Fixed Multiple Problems are seen when a particular xls/xlsx file is Loaded/Saved.
   (TFS: 7363)
   
 * Fixed error is seen open opening xls file when Formula property contains Address()
   function. (TFS: 7346)
   
 * Fixed Unhandled Exception seen when Loading a certain xls/xlsx file. (TFS: 6621)

 * Partly fixed multiple problems seen when Range Name contains OFFSET function.
   (TFS: 6591)
   
 * Partly fixed unhandled exception seen when loading certain xlsx/xls files containing
   Range Names. (TFS: 6144)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20093.130	Build Date: Oct 18, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Support vertical orientation for CJK fonts for Open XML format.

 Corrections
------------- 

 * Fixed Tab Color for sheets is not retained when loading xlsx (OpenXML) file and then
   saving in xls/xlsx format. (TFS: 6614)
   
 * Fixed Sheet Name used in Formula gets changed in Saved excel file
   when Loading a certain xls(BIFF8) file containing Formulas.
   (TFS: 6619)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20093.129	Build Date: Oct 08, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Licensing code updated.

 Corrections
------------- 
 * Fixed unhandled exception seen when loading certain xlsx/xls file. TFS (6555, 6557).

 * Fixed password used to Protect an Excel sheet is not retained after loading & saving
   Excel sheet using C1Excel. (TFS 6070)

 * Fixed multiple problems seen when loading / saving a file that contains range name
   having value as '#REF'. (TFS 6574)

 * Fixed images in Saved excel file are not transparent when loading in xls format and
   then saving in xlsx format or vice versa. (TFS 6633)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20093.128	Build Date: Sep 04, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
* Add transparent picture support.

 Corrections
------------- 
* Fixed unhandled exception seen when loading Open Xml(xlsx) file containing Range Names
  and formulas. (TFS: 6058)
  
* Fixed exception seen when Loading Open Xml file(xlsx) contains Invalid Cell Reference
  Error(=#REF). (TFS: 6053)
  
* Fixed Saved File Gets Corrupt on saving a file in OpenXml (xlsx) containing IF
  Condition. (TFS: 6041)

* Fixed unhandled exception seen when loading xls file containing Range Names. (TFS: 5900)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20093.127	Build Date: Sep 01, 2009
========================================================================================= 

 Corrections
------------- 
* Fixed exception at saving formulas with nested functions in formulas.

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20093.126	Build Date: Aug 28, 2009
========================================================================================= 

 Corrections
------------- 
* Fixed loading exception at using Filter Database range name.

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20093.125	Build Date: Aug 21, 2009
========================================================================================= 

 Corrections
------------- 
* Fixed incorrect export to BIFF format (xls files) of IF formula with expressions in
  TRUE and FALSE blocks. (TFS: 5989) 

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20093.124	Build Date: Aug 20, 2009
========================================================================================= 

 Corrections
------------- 
* Added skip white and tabulations in C1Excel formulas (BIFF formula in xls
  files). (TFS: 5966) 

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20093.123	Build Date: Aug 20, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed not supported Excel IF() condition in C1Excel formulas (BIFF formula in xls
   files). (TFS: 5966)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20093.122	Build Date: Aug 17, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2009 build
 
=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20092.121	Build Date: Jul 31, 2009
========================================================================================= 

 Corrections
------------- 
* Changed of "FORMULAS" define and spell checking.

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20092.120	Build Date: Jul 01, 2009
========================================================================================= 

 Corrections
------------- 
* Changed internal to public for Insert() method of named ranges.

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20092.119	Build Date: Jul 01, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed Range Name used in formula gets changed when removing a range name and then saving
   in xls/xlsx format (a problem with BIFF formula cached in Release version). (TFS: 5031)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20092.118	Build Date: Jun 30, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed removing all the named ranges and then Saving the file, causes the error message
   and saved file gets corrupt (comment exception correct). (TFS: 4898)

 * Fixed problem seen when adding a Range Name that is already present in loaded xls/xlsx
   file. (TFS: 5021)
   
 * Fixed Range Name used in formula gets changed when removing a range name and then saving
   in xls/xlsx format. (TFS: 5031)
   
 * Correction for is there any provision to create an object of XLNamedRange class. Creating
   named range use NamedRangeCollection.Add() -- by design. Insert method now as internal.
   (TFS: 5038)
   
 * Fixed exception 'OutOfMemoryException' seen when Loading an xls file containing comments
   in RangeName. (TFS: 5041)
   
 * Fixed request to change the description of Comment and 'IsBuiltInName' property.
   (TFS: 5042)
   
=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20092.117	Build Date: Jun 29, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed removing all the named ranges and then Saving the file, causes the error message
   and saved file gets corrupt. (TFS: 4898)
   
 * Fixed Range scope and Range Comments are not preserved when saving xls/xlsx file.
   (TFS: 4894)

 * Fixed request to change the summary and remarks in KeepFormulas property since it now
   also supports xlsx files. (TFS: 4661)

 * Fixed request to change the remarks in keepformulas property as the user can now create
   or edit formula using C1Excel. (TFS: 4588)

 * Fixed word 'Percents' is misspelled as 'persents' in the summary of 'Scale' property.
   (TFS: 4588)

 * Fixed ‘Index was outside the bounds of the array.’ (OpenXML) is thrown on loading xlsx
   file with formula. (TFS: 4649)

 * Fixed request to please clarity usage of some properties of XLNamedRange Class.
   (TFS: 4900)

 * Fixed request to clarity weather creation of namedRanges at runtime is supported for
   OpenXml(xlsx) files?. (TFS: 4903)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20092.116	Build Date: Jun 22, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed problems related to deleting sheet and ‘KeepsFormula’ property. (TFS: 4785)
 
=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20092.115	Build Date: Jun 19, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
* Partial trust ASP.NET support

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20092.114	Build Date: Jun 18, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Licensing code updated.
 * Added support named ranges in formulas.
 
 Corrections
------------- 
 * Fixed incorrect support of shared formulas. (TFS: 4649)

 * Fixed problems when Loading/Saving sheet having Range names in the formulas. (TFS: 4651)

 * Fixed shared formula that not preserved correctly when saving in xlsx (Open Xml)
   format. (TFS: 4658)

 * Fixed incorrect definition of COUNTA function. (TFS: 4662)

 * Fixed row color that not applied to entire row when loading xls file. (TFS: 4664)

 * Fixed local file hyperlinks then saving in xls format. (TFS: 4665)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20092.113	Build Date: May 28, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Licensing code updated.
 
 Corrections
------------- 
 * Fixed formula support is added for xlsx, then request to also add support for keepformula
   property for xlsx files. (TFS: 4599)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20092.112	Build Date: May 19, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Changed obfuscation for FuncItemType type.

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20092.111	Build Date: May 18, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added support formulas. Full support with binary parsing and creating.
   Using: 
            sheet[4, 1].Value = "apples and oranges";
            sheet[5, 1].Value = "apples an";       // <-- result of the formula
            sheet[5, 1].Formula = "LEFT(B5,9)";   

Corrections
-----------
* Fixed author is not retrieved on using c1XLBook1.Author for xlsx files. Added support
  author for xlsx format (TFS:4313).
  
* Fixed no effect is seen when applying Scale property for .xlsx files. Added support
  scale in percents for xlsx format (TFS:4382).  

* Fixed rotation can be set and text gets rotated when horizontal value is set to
  Fill/Selection. Added condition for Fill and Selection horizontal alignment
  (TFS:4385).

* Fixed on saving xls or xlsx files, Should Default font be applied if cell contains
  an invalid font (font not present in the system). For set method of DefaultFont
  property added block for setting new font for all XL objects (TFS:4340)
 
=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20092.110	Build Date: May 8, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2009 build

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20091.108	Build Date: April 28, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Improved encoding of RK numbers (can reduce XLS file size considerably in some cases)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20091.107	Build Date: April 21, 2009
========================================================================================= 

Corrections
-----------
- Fixed crash at reading Open XML format (customFormat == 1 but style of row is not
  setting).

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20091.106	Build Date: March 06, 2009
========================================================================================= 

Corrections
-----------
- Columns Hidden in MSExcel cannot be unhidden by code in C1Excel (19402)
  It is feature that width of column and height of row in sample has zero value,
  now setting default value for visible rows and columns if value -- zero.
- ForeColor is also set when only BackColor of a column/row is set in XLSX (19402)
  Default fore color from Transparent to Empty.

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20091.105	Build Date: February 26, 2009
========================================================================================= 

Corrections 
-----------
- ForeColor is changed when Flexgrid is exported to Excel\OpenXlS (19352)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20091.104	Build Date: February 23, 2009
========================================================================================= 

Corrections 
-----------
- Columns.Visible property does not work for XLSX File format (19050).
- Invisible column becomes visible in the excel sheet when the grid is saved
  in OpenXML format (17540)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20091.103	Build Date: January 29, 2009
========================================================================================= 

Corrections 
-----------
- Styles lost on rows hidden and then shown via the XLSSheet.Visible property (19017)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20091.102	Build Date: January 07, 2009
========================================================================================= 

Corrections 
-----------
- Fixed 16377 (exception thrown when showing a hidden sheet)
- Fixed 16389 (pattern color was not specified)
- Fixed 16396 (could not generate a sheet with more than 1024 images)
- Fixed 18723 (individual cells in a locked sheet could not be unlocked)
- Fixed many issues for Open XML read/write.
- Fixed output of numeric formats.

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20083.98	Build Date: October 8, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Improved color palette mapping algorithm
  (uses RGB instead of HSB space, reverted change made in build 84)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20083.97	Build Date: September 22, 2008
========================================================================================= 

Corrections 
-----------
- Fixed crash at opening files with groups of shapes.

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20083.96	Build Date: September 2, 2008
========================================================================================= 

Corrections 
-----------
- Fixed next issues for write and read Open XML format 17607, 17985, 18004, 18007, 18008,
  18027, 18031.
  
  
=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20083.95	Build Date: August 13, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2008 build

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20082.95	Build Date: September 2, 2008
========================================================================================= 

Corrections 
-----------
- Fixed next issues for write and read Open XML format 17607, 17985, 18004, 18007, 18008,
  18027, 18031.

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20082.94	Build Date: July 25, 2008
========================================================================================= 

Corrections 
-----------
- Fixed issues 16375, 16409, 16479.

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20082.93	Build Date: July 18, 2008
========================================================================================= 

Corrections 
-----------
- Added support sheet tab colors and fixed bug for hyperlinks (issues 16238/16285)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20082.92	Build Date: July 8, 2008
========================================================================================= 

Corrections 
-----------
- Failed to open XLSX file when file was already open in Excel (issues 16496/16458)

========================================================================================= 
C1.C1Excel.dll Build Number 2.1.20082.91	Build Date: Jun 4, 2008
========================================================================================= 

Corrections 
-----------
- Incorrect color is displayed in the exported Excel sheet upon setting Cell BackColor
  property (issue 16497).
- (OpenXML) Formula and data is not retained in saved excel or ArgumentException
  is thrown on loading xlsx file with formulaClipArt size reduced when saving (issue 17424).

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20082.90	Build Date: May 30, 2008
========================================================================================= 

Corrections 
-----------
- ClipArt size reduced when saving book (issue 16447).
- Fixed column count limits in Open XML (issue 17282).
- Added support pictures coordinates more 255 columns and 65536 rows for CompatibilityMode.Excel2007.

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20082.89	Build Date: May 15, 2008
========================================================================================= 

Corrections 
----------- 
- Added Japanese localized strings for top level descriptions
  (KeepFormulas and CompatibilityMode).
- Fixed issues 17136 (PrintSettings), 17096 (OpenXmlReader) issues.

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20082.87	Build Date: April 22, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2008 build

Corrections 
----------- 
- Fixed VNXLS000361, VNXLS000363, VNXLS000364, VNXLS000365 issues.

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20081.86	Build Date: April 15, 2008
========================================================================================= 

Corrections 
----------- 
- ForeColor was not always retained when saving in OpenXML (VNXLS000366)

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20081.85	Build Date: April 3, 2008
========================================================================================= 

Corrections 
----------- 
- Previous versions refused to read any book with a password assigned to it. This version
  will read books with passwords assigned to them as long as they are not encrypted at the
  file level (FILEPASS record).

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20081.84	Build Date: January 30, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Improved color palette mapping algorithm (now uses HSB instead of RGB space)

- Added CompatibilityMode property to improve Excel2007 support.
	Valid settings are:
	CompatibilityMode.Excel2003: 
		Up to 256 columns, 65,536 rows, and 4,050 cell styles.
	CompatibilityMode.Excel2007: 
		Up to 18,278 columns, 1,048,576 rows, and 65,536 cell styles.
		Workbooks that exceed the Excel2003 limits must be saved in OpenXml format instead of XLS.
	CompatibilityMode.NoLimits:
		No fixed limits (you may not be able to read these files with Microsoft Excel).

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20081.81	Build Date: January 19, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2008 build

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20073.77	Build Date: November 27, 2007
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added support extended (header and footer) pictures. This is implemented with the 
  following new properties:
	public object sheet.PrintSettings.HeaderPictureLeft,
	public object sheet.PrintSettings.HeaderPictureCenter,
	public object sheet.PrintSettings.HeaderPictureRight,
	public object sheet.PrintSettings.FooterPictureLeft,
	public object sheet.PrintSettings.FooterPictureCenter, and
	public object sheet.PrintSettings.FooterPictureRight.
	
	These properties accept objects of type XLPictureShape or Image.
	They always return objects of type XLPictureShape.

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20073.75	Build Date: October 26, 2007
========================================================================================= 

Corrections 
----------- 
 * Added support for loading books using base date 1904

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20073.74	Build Date: September 26, 2007
========================================================================================= 

Corrections 
----------- 
 * Improved row/column sizing.

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20073.73	Build Date: September 17, 2007
========================================================================================= 

Corrections 
----------- 
 * Fixed incorrect picture positioning (VNRPT000413).
 * Fixed internal hyperlinks in OpenXml files (VNXLS000356).

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20073.72	Build Date: September 12, 2007
========================================================================================= 

Corrections 
----------- 
 * Fixed loading stored (uncompressed) images stored in OpenXml files (VNXLS000358).

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20073.71	Build Date: August 6, 2007
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2007 build

=========================================================================================
C1.C1Excel.dll Build Number 2.1.20072.71	Build Date: June 13, 2007
=========================================================================================

Corrections 
----------- 
 * Added Japanese localization to OpenXml error messages
 - VNXLS000318  Unhandled exception occurs when .xlsx file containing various elements 
				like WordArt is saved using C1Excel.
				Fixed (WordArt objects are now ignored).
 - VNXLS000322  (Open XML format) Unhandled exception "An entry with same key already exists" 
				is shown in various situations.
 - VNXLS000323  (Open XML format)Hyperlinks are not retained (neither style nor link) once the 
				file is saved using C1Excel.
				Fixed (set fontColor for XLFont from 64-color Excel palette).
 - VNXLS000327  (Open XML format) Unhandled Argument Exception is shown while trying to load 
				C1Excel that contains imported data from text file (*.txt).
 - VNXLS000348  C1Excel saved file recognize 'Custom Currency Format' with localization 
				support as 'Accounting' in Office2003 and 'no format' in Office2007.
- VNXLS000352	Unhandled exception 'The form of the Excel OpenXml file is not correct'
				is observed on loading an excel file that contains text box.
 
=========================================================================================
C1.C1Excel.dll Build Number 2.1.20072.68	Build Date: June 6, 2007
=========================================================================================

Corrections 
----------- 
 * Delta fixes:
 - VNXLS000245	DefaultRowHeight' for sheet is not applied when saving excel.
				Fixed, DefaultRowHeight work only set DefaultRowHeightFlags.
 - VNXLS000259	Hyperlink path is changed after loading and saving excel file using C1Excel.
				Fixed, changed incorrect double set "..\" in hyperlinks.
 - VNXLS000281	Cannot set 'copies', 'orientation', 'paperKind', 'ScalingFactor' of
                XLPrintSetting if loaded sheet 'PaperKind' is 'Custom'.
				Fixed (without 'copies'), as in VNXLS000346 bug. 
 - VNXLS000289	Image gets enlarged when the displacement(horizontal and vertical) specified
                in the XLPicture shape constructor is large.
 - VNXLS000323	(Open XML format)Hyperlinks are not retained(neither style nor link) once
                the file is saved using C1Excel.
				Fixed, changed hyperlink detect.
 - VNXLS000324  Unhandled Exception is shown while using XLPICTURESHAPE object to add .ico
                image in C1Excel.
				Fixed, convert icon to png format.
 - VNXLS000325	Image on multiple sheets get mixed and blurred in saved 'xlsx' file.
 - VNXLS000326	(OpenXML format) Freeze pane is not retained when loading and saving C1Excel.
				Fixed, added write and read Frozen pane for Open XML.
 - VNXLS000328	(OpenXML format) Hidden sheet is visible in C1Excel Saved File.
				Fixed, added write and read sheet visible for Open XML.
 - VNXLS000333	(Open XML Format) Sheet protection is not retained when load and save by C1Excel.
				Fixed, added write and read sheet protection (Locked property) for Open XML.
 - VNXLS000336	(Open XMLformat) Image cannot be edited when added using XLPicture shape
                constructor and saved in xlsx format.
 - VNXLS000339	(OpenXML format) Sheet.Gridcolor property is not working in .xlsx format.
				Fixed, added write and read GridColor for Open XML.
 - VNXLS000340	(OpenXML format) Load and Save does not retain GridLine View and Heading View setting.
 - VNXLS000343	(Open XML Format) Most of predefined print settings are not retained in saved file.
				Fixed (partly), added write and read PrintSettings for Open XML without copies.
 - VNXLS000345	(Open XML Format) Default font family and font size of MS excel is not retained in saved file.
 - VNXLS000346	(OpenXML format) Hidden row is visible in C1Excel saved file and cannot set row visibility programmatically.


=========================================================================================
C1.C1Excel.dll Build Number 2.1.20072.67	Build Date: May 11, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added support for Office 2007 format (OpenXml)
 
  The OpenXml format is the new format used by Office 2007 applications. 

  Open Xml files are easier to manipulate by applications because it is based on Xml 
  and publicly documented (as opposed to proprietary binary formats such as Biff8).
  OpenXml files are usually smaller than equivalent xls files because they are 
  compressed. Open Xml files consist of a set of xml files compressed into a single 
  zip file with an extension that identifies the file creator.
    
  C1Excel can load and save data and formatting information in OpenXml files. 
  Formulas are not loaded or saved however. If you load files that contain 
  formulas and then save them back, the formulas will be removed. This is in contrast
  to the traditional xls (Biff8) format, which does preserve the formulas.

  To support the OpenXml format, the grid's Load and Save methods received new 
  overloads that take a FileFormat parameter that is used to specify the file format
  to use when loading or saving files.
    
  If the file name is not specified, then C1Excel infers the file format from the 
  file name extension: files with "xlsx" and "zip" extensions are loaded and saved
  as OpenXml by default. Other files are loaded and saved as Biff8 ("xls") format.
    
  For example:
    
    // load and save relying on file extension
    c1Excel1.Load("somefile.xls");	// load biff 8 file
    c1Excel1.Save("somefile.xlsx");	// save file as OpenXml
    c1Excel1.Save("somefile.zip");	// save file as OpenXml
    
    // load and save specifying the FileFormat
    c1Excel1.Load("somefile.xls", FileFormat.Biff8);
    c1Excel1.Save("somefile.xlsx", FileFormat.OpenXml);

  You can also specify the format when loading or saving files to and from streams.
  If the FileFormat is not specified, then C1Excel uses the Biff8 format as a default.

  Note: There is a small behavior change implied here. Consider the statement below:

    C1Excel1.Save("somefile.xlsx");

  In previous versions, this would save a Biff8 file (with the wrong extension). In
  the new version, this will save an OpenXml file (with the correct extension). 
  If you have code like this in your applications, when upgrading you should change
  it to

    // deliberately save file with wrong extension
    C1Excel1.Save("somefile.xlsx", FileFormat.Biff8);

Corrections 
----------- 
 * Delta fixes:
   VNXLS000317: Added support of foreground, fill color and fill opacity properties for XLShape.
   VNXLS000314: Corrected clone of shapes at sheet clone.
   VNXLS000312: Added BiffCode.UNK_4 (x805) opaque record with filename reference to external text.


=========================================================================================
C1.C1Excel.dll Build Number 2.1.20072.66	Build Date: April 11, 2007
=========================================================================================

Corrections 
----------- 
 * Delta fixes:
	- Excel file gets corrupted when the saved file contains chart (VNXLS000254)
	- Exception thrown when saving clone sheet that contains XLPictureShape image (VNXLS000276, VNXLS000277, VNXLS000251, VNXLS000266)
	- Lost some image and comments copied to multiple cells when loading and saving excel (VNXLS000280)
	- Excel file is corrupted on adding XLPictureShape image and saving file more than two times (VNXLS000278)
	- Files with default row visibility set to false loaded OK but did not save correctly (VNXLS000279)
	- Excel file containing comments becomes invalid if loaded and saved multiple times with C1Excel (VNXLS000253)


=========================================================================================
C1.C1Excel.dll Build Number 2.1.20072.64	Build Date: March 19, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2007 build

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20071.63	Build Date: February 26, 2007
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Improved image parser handling of large objects

=========================================================================================       
C1.C1Excel.dll Build Number 2.1.20071.61	Build Date: January 18, 2007
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added overloads to Load(Stream) and Save(Stream) methods that allow reading and writing 
  workbooks directly to streams.
  This allows applications to save workbooks directly into streams without using temporary 
  files (for example, ASP.NET applications can write directly into an HttpResponse.OutputStream).
  NOTE: This new feature is available only in the .NET 2.0 version of C1Excel.
  
* New properties:
	XLRow.PageBreak, XLColumn.PageBreak
	These new properties specify whether there are hard page breaks after any given row
	or column.

Corrections 
----------- 
* Fixed problem reading large shared-string tables (larger than 65k strings)

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20071.59	Build Date: January 2, 2007
========================================================================================= 

Corrections 
----------- 
* Improved opaque record parsing.

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20071.58	Build Date: December 26, 2006
========================================================================================= 

Corrections 
----------- 
* Delta fixes:
  - Clicking an Image does not open the associated hyperlink. VNXLS000236
  
=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20071.57	Build Date: December 9, 2006
========================================================================================= 

Corrections 
----------- 
* Delta fixes:
  - Exception when loading excel files with embedded images. VNXLS000230
  - Default column width was incorrect (different from Excel) VNXLS000239
  
=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20071.56	Build Date: November 23, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added new XLPictureShape constructor to facilitate image creation/positioning.

  The new constructor takes a cell size, alignment, and layout parameters.
  
  For example, the code below adds an image to a cell. The image is centered within 
  the cell and scaled to fill the cell while preserving its aspect ratio:
  
	// get sheet and cell
	XLSheet sheet = c1ExcelBook1.Sheets[0];
	XLCell  cell  = sheet[row, col];

	// calculate cell size to align picture
	Size cellSize = new Size(sheet.Columns[col].Width, sheet.Rows[row].Height);

	// build XLPictureShape
	XLPictureShape pic = new XLPictureShape(
		image, 
		cellSize,
		ContentAlignment.MiddleCenter,
		ImageScaling.Scale);

	// assign XLPictureShape to cell
	cell.Value = pic;

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20071.55	Build Date: October 25, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Performance improvement: use Marshal.ReleaseComObject instead of GC.Collect when closing storages.

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20071.54	Build Date: October 23, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* T1/2007 build

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20063.54	Build Date: August 18, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added support for images in cells.
  You can add images to cells using one of these methods:
  
  1) Assign an image directly to a cell's Value property:
  
	Image img = Image.FromFile(imageFileName);
	sheet[row, col].Value = img;
	
	The image will be added to the sheet in its original size. The upper left corner
	of the image will coincide with the upper left corner of the specified cell.
	
  2) Create an XLPictureShape object, set its properties, and assign it to a cell's Value property:
  
	Image img = Image.FromFile(imageFileName);
	XLPictureShape pic = new XLPictureShape(img, 1000, 1000);
    pic.Rotation = 30.0f;
    pic.LineColor = Color.Aqua;
    pic.LineWidth = 100;
    sheet[row, col].Value = pic;
    
    This second method allows you to customize the image by specifying its size, rotation 
    angle, brightness, contrast, border, etc.
    
  3) Create an XLPictureShape object, set its properties, and add it to a sheet's Shapes collection:
  
	Image img = Image.FromFile(imageFileName);
	XLPictureShape pic = new XLPictureShape(img, 2000, 2000, 1000, 1000);
    pic.Rotation = 30.0f;
    pic.LineColor = Color.Aqua;
    pic.LineWidth = 100;
    sheet.Shapes.Add(pic);
    
    This method uses the XLPictureShape constructor to specify the image bounds in sheet coordinates. 
    The shape is added directly to the sheet's Shapes collections (instead of assigning it to a 
    specific cell).


=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20063.53	Build Date: July 12, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* none

Corrections 
----------- 
* hyperlinks were not being saved correctly for consecutive integer cells (MULRK) (VNXLS000204)
* added extra check to handle files that contain fonts with zero size.


=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20063.51	Build Date: June 12, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* V3/2006 build
* added support for preserving external data links across load/save
* added XLCell.SetValue method (sets value and style in a single call)

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20062.50	Build Date: May 25, 2006
========================================================================================= 

Corrections 
----------- 
* Fixed export problem: didn't save margins set to zero.

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20062.49	Build Date: April 21, 2006
========================================================================================= 

Corrections 
----------- 
* Fixed import problem: didn't recognize all-uppercase date formats like M-DDD.

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20062.48	Build Date: February 8, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * added support for images embedded in page headers/footers
   (like formulas, images are read and saved but cannot be added)
   
Corrections 
----------- 
 * improved localization support for currency format conversion (Delta issue ANRPT000101)

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20062.47	Build Date: January 20, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2006 build
 - Added new property: XLSheet.GridColor: allows getting/setting the color of the grid lines within the sheet
 
Corrections 
----------- 
 * Delta fixes:
   VNXLS000175: couldn't scroll sheets with fixed rows > 0 and fixed cols == 0.
   VNXLS000176: improved reading Xl files created with JavaExcelApi 2.5.3.
   VNXLS000188, VNXLS000177: improve column width calculations to get closer to Excel.
 * handle incomplete COLINFO records written by Crystal Reports Xl export.
 * fixed problem saving large negative integers (in the range [-2^29-1 to -2^31]).


=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20061.45	Build Date: January 10, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * improved licensing support under ASP.NET 2.0

Corrections 
----------- 
 * handle incomplete BOF records written by Microsoft Access


=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20061.44	Build Date: October 19, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2006 drop

Corrections 
----------- 
 * fixed a problem reading some shared string tables with continue records

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20053.43	Build Date: October 7, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Improved precision in export of float values (VNFLX000463)


=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20053.42	Build Date: September 22, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Allow cloning sheets from one book and pasting them into another (VNXLS000180)

Corrections 
----------- 
 * PageSettings.StartPage printing option was not saved properly (VNXLS000181)
 * MULRK cell styles did not inherit row styles properly (VNXLS000182)

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20053.41	Build Date: July 26, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added two new properties: Rows.Frozen and Column.Frozen.
   These new properties allow the creation of non-scrollable rows and columns.
   
 * Added new method: XLSheet.Clone()
   This can be used to create copies of 'template' sheets.
   
 * Added support for external references, images, page breaks, filters, and conditional formatting.
   Like formulas, these are read and saved, but not exposed through the object model.
   This support allows C1Excel to load 'template' books, make changes, then save them back.

Corrections 
----------- 
 * Improved style comparison (to avoid saving equivalent styles)


=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20053.38	Build Date: June 27, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added extra check to WRITEACCESS reader to allow reading poorly written files created
   with Java Excel API v2.5.3.

Corrections 
----------- 
 * none


=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20053.37	Build Date: June 17, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2005 drop.
 * Save smaller files (by writing MULRK records)
 
Corrections 
----------- 
 * throw error when trying to remove non-existent row/column
 * throw error when trying to save book without any visible sheets (Excel doesn't like that)


=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20052.34	Build Date: May 16, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added new PrintSettings.AutoScale Boolean property.
 
	PrintSettings.AutoScale = false
		when the sheet is printed, it is scaled according to the value specified by the
		PrintSettings.ScaleValue property.
		
	PrintSettings.AutoScale = true
		when the sheet is printed, it is automatically scaled according to the values 
		specified by the PrintSettings.FitPagesAcross and PrintSettings.FitPagesDown.
   
 
Corrections 
----------- 
 * none

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20052.33	Build Date: May 4, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none
 
Corrections 
----------- 
 * fixed persistence of PrintSettings.Copies setting

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20052.32	Build Date: March 3, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added support for formulas and named ranges
   
   This version will read and write Excel formulas and named ranges, which allows you to 
   load existing Xl files, modify some cells, and save the file back to disk preserving 
   the formulas and named ranges.
   
   There is still no support for creating or adding formulas or named ranges.
   
   The new property C1XLBook.KeepFormulas controls this new behavior. Setting this 
   property to true (the default setting) causes the component to keep the formulas.
   Setting it to false reverts to the original behavior, which removes formulas and
   named ranges from the book.
 
Corrections 
----------- 
 * improved handling of borders in styles (could lock style in some cases)

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20052.30	Build Date: January 18, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Q2/2005 drop.
 * Added support for GDI vertical fonts (e.g. @MS Gothic)
 
Corrections 
----------- 
 * Sheet.PrintSettings.Landscape property didn't work correctly
 * Hiding the selected sheet caused problems for Excel

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20051.29   Build Date: January 18, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Save smaller files by encoding integers as RK values
 
=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20051.28   Build Date: January 17, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added two new properties to Sheet class:
	public bool Sheet.Visible
	public bool Sheet.ShowGridLines
	
Corrections 
----------- 
 ** fixed saving styles
	- some background colors in styles could prevent Excel from showing style edit dialog
	- unlocked styles were not always saved correctly
	

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20051.27   Build Date: December 7, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Q1/2005 build
 * new properties:
	
	XLSheet.Locked
	- Works with XLStyle.Locked. If both are set to true, the cell can't
	  be edited in Excel.
	  
	XLSheet.PrintSettings
	- Provides control over print settings (header, footer, margins, 
	  paper size and orientation, whether to print header cells and
	  gridlines, etc)

	Style.XLPatternEnum, Style.BackPattern, Style.PatternColor
	- Provides control over the pattern used to paint the cell background.

 * optimized Shared String Table implementation. This dramatically speeds up 
   saving sheets that contain a lot of strings. A 10,000x20 table that used
   to take 650 seconds now saves in 16.   
   
 * Updated AssemblyInfo, requires rebuilding existing apps. 
	To use this new build in existing applications, you should open the
	project, select the "References" node in the Project Explorer and replace
	the reference to the older version of the control with this new one.

Corrections 
----------- 
 ** fixed saving sheets with lots of MergedCells (more than 1024 caused problems)
 

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20044.25   Build Date: November 9, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * save non-standard data types as strings
 
Corrections 
----------- 
 ** failed to load books with single-character sheet names (e.g. "A")


=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20044.23   Build Date: October 19, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * optimized row/col additions, orders of magnitude faster for bulk operations
 
Corrections 
----------- 
 ** fixed XLStyle.Clone() method, threw when called on new books.


=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20044.21   Build Date: October 14, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * allow loading books even while they are open in Excel
 
Corrections 
----------- 
 ** added small correction to dates before March 1, 1900
    (Excel behaves as if there was a February 29, 1900, but there wasn't)


=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20044.20   Build Date: September 16, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * added support for cell background patterns (can load and save, not change)
 * improved handling of error cells (translated into Exception objects)
 * added support for more Japanese date/time formats
 * added Xml documentation for use with D2H Documenter
 
Corrections 
----------- 
 ** prevent adding multiple copies of the same row/col into a sheet
 ** DefaultRowHeight was not applied correctly to all rows
 ** fixed IsEmpty, Intersects methods in XLCellRange object
 ** handle saving styles with ForeColor and no Font
 ** custom column widths were not preserved when opening and re-saving the file in Excel
 ** improved handling of local and UNC hyperlinks
 ** Row.Style wasn't being saved correctly (didn't apply to empty cells)
 
 
=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20044.18   Build Date: August 9, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Q4/2004 build
 * updated licensing to include ASP.NET studio
 
Corrections 
----------- 
 ** none
 
 
=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20043.17   Build Date: June 29, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none
 
Corrections 
----------- 
 ** improved checks when reading SST (OpenOffice saves duplicate entries)
 
 
=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20043.16   Build Date: June 24, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * improved .NET to Excel format translation
 
Corrections 
----------- 
 ** none
 
 
=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20043.15   Build Date: June 1, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * added Japanese resources
 
Corrections 
----------- 
 ** fixed problem reading some types of hyperlinks
 
 
=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20043.14   Build Date: May 24, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Q3/2004 build
 
Corrections 
----------- 
 ** none
 
=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20042.14   Build Date: May 10, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none
 
Corrections 
----------- 
 ** use Default encoding instead of ASCII (to handle international characters)
 
=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20042.13   Build Date: April 14, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none
 
Corrections 
----------- 
 ** fixed setting of invisible row/col flags when saving sheet
 
=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20042.13   Build Date: April 14, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none
 
Corrections 
----------- 
 ** Account for empty strings in SST
 ** Improved precision of row height/column width conversion
 ** Automatically validate Sheets.SelectedIndex based on the number of sheets
 ** Automatically expand sheet to accommodate merged ranges/hyperlinks
 ** Added XLCell.Hyperlink property (replaces Sheet.Hyperlinks collection)


=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20042.8   Build Date: March 30, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none
 
Corrections 
----------- 
 ** Account for far-east information in CONTINUE records when reading strings
 ** Clear method adds a single blank sheet (as described in the documentation)
 ** Fixed null-reference problem when loading then saving a file
 ** Improved error messages when referencing sheets by name
 ** Fixed problems when reassigning style border colors and line styles
 ** Style.Locked property could not be set
 ** Added limit check for maximum number of rows (limited by Excel)
 ** Fixed problem loading books with merged cells
 ** Fixed problem loading default font and column widths
 ** Improved style ctor to prevent using null book as a ctor parameter
 ** Enforce sheet name uniqueness
 ** Improved style handling for rows/columns 
 

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20042.6   Build Date: March 8, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Q2/2004 drop
 
Corrections 
----------- 
 ** none
 

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20041.6   Build Date: February 19, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added support for merged cells:
	XLCellRangeCollection MergedCells (applies to XLSheet class)
	The collection allows you to inspect, add, or clear merged ranges in a sheet.
	The collection contains XLCellRange objects
	
 * Added support for borders: (applies to XLStyle class)

	public void SetBorderStyle(XLLineStyleEnum style)
	public void SetBorderColor(Color color)
		These methods set the borders all around the cell to a given style and color.
 
	public XLLineStyleEnum BorderLeft
	public XLLineStyleEnum BorderRight
	public XLLineStyleEnum BorderTop
	public XLLineStyleEnum BorderBottom
		These properties get or set individual border styles.

	public Color BorderColorLeft
	public Color BorderColorRight
	public Color BorderColorTop
	public Color BorderColorBottom
		These properties get or set individual border colors.

	public XLDiagonalFlags Diagonal
	public XLLineStyleEnum DiagonalStyle
	public Color DiagonalColor
		These properties get or set the direction, style, color of diagonal lines
		drawn across the cell.

Corrections 
----------- 
 ** Improved handling of international DateTime formats


=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20041.5   Build Date: February 12, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added new Sheet property XLRow and XLColumn objects
 * Added new Add(sheetName) overload to Sheets collection
 * Added new Load(string fileName, bool fillSheets) overload to C1XLBook
   (allows loading sheets without data, useful to retrieve book information)
 * Improved handling of invalid numbers (double.Nan/Infinity) when saving sheets

Corrections 
----------- 
 ** Several minor fixes

=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20041.4   Build Date: February 3, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added new property MergedCells to XLSheet
	and exposed new classes XLCellRange and XLCellRangeCollection. 
	
	The property syntax is:
		public XLCellRangeCollection MergedCells
		
	The property gets a collection of XLCellRange objects that define 
	merged ranges within the sheet.

Corrections 
----------- 
 ** none


=========================================================================================       
C1.C1Excel.dll Build Number 1.1.20041.3   Build Date: January 9, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Use Commit when closing storage for extra safety (not strictly needed in direct mode)
 * Added methods for converting twips to and from pixels:
        public static int PixelsToTwips(double pix)
        public static int TwipsToPixels(double twip)

Corrections 
----------- 
 ** none

