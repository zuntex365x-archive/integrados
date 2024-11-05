<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
Readme file for ComponentOne Reports for .NET
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

Thank you for your interest in the ComponentOne Reports offering.

ComponentOne Reports for .Net (C1Report) is a part of ComponentOne Studio for
.NET. This product combines the previously separate products - C1Report and
C1Preview.

This readme file covers the following non-visual components included in the
C1Reports product:
  - C1PrintDocument
  - C1Report
  - C1RdlReport

Unless specifically noted, this readme applies to all platforms (WinForms, WPF
and ASP.NET) and all framework versions.

See readme-preview.txt for info on the WinForms-specific visual preview controls
included in C1Reports for WinForms.

Maintenance log for older releases of C1PrintDocument can be found in the
old-readme-c1preview.txt file.

Maintenance log for older releases of C1Report can be found in the
old-readme-c1report.txt file.

Please visit our support web site:
  http://our.componentone.com/Support/

Also check out the product forum:
  http://our.componentone.com/groups/winforms/reports-for-winforms/forum/

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
C1Reports non-visual components maintenance log
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

================================================================================
Build 2/4.6.20142.54736, 06-Oct-2014
================================================================================

Bug fixes
---------
- C1Report: in some cases style applied to one RTF field affected other RTF fields. [83003]

================================================================================
Build 2/4.6.20142.54735, 17-Sep-2014
================================================================================

Enhancements
------------
- New property:
    CompatibilityOptions.IgnoreInvisibleFieldsInGrowShrinkSections {get;set;}
    Gets or sets a value indicating whether invisible fields should be ignored
    when calculating the heights of CanGrow/CanShrink sections.
  [71577]

================================================================================
Build 2/4.6.20142.54734, 05-Sep-2014
================================================================================

Bug fixes
---------
- Incorrect wrapping of fields with text containing double byte characters. [82322]
- When a multi-document is exported to PDF, some hyperlinks do not work. [79292]
- PDF: text with fixed width font extends past the field's bounds. [78659]

Enhancements
------------
- New property:
    PageNumberingChange C1MutliDocumentItem.PageNumberingChange {get;set;}
    Gets or sets the PageNumberingChange object which is applied to the first
    page of this C1MultiDocumentItem.
  Allows to control how pages of individual documents included in a multi-
  document are numbered. [80707]

================================================================================
Build 2/4.6.20142.54733, 24-Jul-2014
================================================================================

Bug fixes
---------
- DOCX: percent sign not shown in exported DOCX files. [72791]
- PDF: incorrect clipping of text in some cases. [62913]
- RTF: incorrect font size, overlapping text. [72799]
- HTML: some data in RenderTable not exported. [67757]

================================================================================
Build 2/4.6.20142.54732, 09-Jul-2014
================================================================================

Bug fixes
---------
- Excel: incorrect row position when exporting with DataOnly turned on. [56436]
- HTML: distorted layout when exporting some documents. [71629]

================================================================================
Build 2/4.6.20142.54731, 03-Jul-2014
================================================================================

Bug fixes
---------
- PDF (regression): Incorrect export of Hebrew text (overlapping/clipping). [71313]

================================================================================
Build 2/4.6.20142.54730, 26-Jun-2014
================================================================================

* 2014v2 build.

Bug fixes
---------
- RTF: some text was missing in the output file. [71472]
- PDF: different technical PDF description was generated on repeated exports. [69950]
- PDF: overlapping text when exporting a report with subreports. [61462]
- RTF: incorrect export of documents containing many images under Windows 8. [67255]

================================================================================
Build 2/4.6.20141.54725, 13-Jun-2014
================================================================================

Bug fixes
---------
- Added new/missing Japanese translations. [69328]
- Minor bugfixes in DOCX/Excel exports.

New
---
- Added property:
  bool RenderGraphics.GraphicsSizeEqualToObjectSize { get; set; }
  Gets or sets value indicating whether size of Graphics object
  managed by this RenderGraphics same as RenderGraphics size.
  Set this property to true if you want to create image
  with exact sizes.
  If this property is true then Width and Height
  should be specified as absolute values (10mm, 1inch for example). [67508]

================================================================================
Build 2/4.6.20141.54724, 30-May-2014
================================================================================

Bug fixes
---------
- Minor fixes in PDF support.
- C1Report: fixed exception in RenderToFile/Filter to XLSX. [63929]
- C1MultiDocument: fixed wrong handling of page numbering change. [47900]

================================================================================
Build 2/4.6.20141.54722, 12-May-2014
================================================================================

Bug fixes
---------
- HTML export: fixed "index out of range" error when exporting some documents to HTML. [41199]

Behavior changes
----------------
- C1Report's TextFilter rewritten, new/changed properties:

    bool Paged { get; set; }
      Specifies whether the filter should produce a continuous report or a
      report with page break characters and page header and footer sections.

    int MaxTextWidth { get; set; }
      Gets or sets the maximum width of text lines, in characters.
      -1 (the default) indicates that this value will be calculated automatically.

    Encoding Encoding { get; set; }
      Gets or sets the text encoding. The default is Encoding.Default.

    The old version of TextFilter has been renamed to TextFilterClassic. A
    property has been added to control which version should be used by
    RenderToStream(...) and RenderToFile(...) methods:

    bool C1Report.CompatibilityOptions.UseTextFilterClassic { get; set; }
      Gets or sets a value indicating whether to use the old version of text filter (TextFilterClassic).

    The default is false.

================================================================================
Build 2/4.6.20141.54721, 24-Apr-2014
================================================================================

Bug fixes
---------
- Added new/missing Japanese translations. [61692]

================================================================================
Build 2/4.6.20141.54719, 12-Apr-2014
================================================================================

Bug fixes
---------
- Excel (regression): wrong placement of unbound images. [37066]
- Excel (regression): ForeColor of GroupCounter fields not exported to .xlsx. [61666]
- RTF (regression): "Parameter is not valid" error occurs in some cases. [43341]

================================================================================
Build 2/4.6.20141.54718, 29-Mar-2014
================================================================================

Bug fixes
---------
- PDF export: same image showed as different RenderImage objects in the PDF. [57247]
- Excel export: fixed several issues when exporting RenderTable. [41199]
- Excel export: fixed export of fields with PageNo and PageCount tags. [50624]
- RTF export: some fonts were garbled in the resulting file. [54435]

================================================================================
Build 2/4.6.20141.54717, 12-Mar-2014
================================================================================

Bug fixes
---------
 - Minor bugfixes in C1Report RtfLabelFilter.

================================================================================
Build 2/4.6.20141.54716, 11-Mar-2014
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20141.54715, 06-Mar-2014
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20141.54714, 04-Mar-2014
================================================================================

Bug fixes
---------

- In export to RTF, header area could be cut off when using absolute positioning. [50750]
- Incorrect rendering of chart fields in some cases. [50755]
- Plain text in a field with RTF property turned on could be clipped. [51702]

================================================================================
Build 2/4.6.20141.54713, 20-Feb-2014
================================================================================

Behavior changes
----------------

- Internal licensing changes.

================================================================================
Build 2/4.6.20141.54712, 19-Feb-2014
================================================================================

Bug fixes
---------

- C1PrintDocument: in some rare cases RenderRichText would split between pages
  incorrectly. [49031]
- C1Report (regression): incorrect export of Hebrew text to HTML. [50843]
- C1Themes related changes.

================================================================================
Build 2/4.6.20141.54711, 04-Feb-2014
================================================================================

* 2014v1 build.

================================================================================
Build 2/4.6.20133.54703, 02-Feb-2014
================================================================================

Bug fixes
---------

- C1Report (regression): if a report with CanGrow/CanShrink fields was exported
  to Excel, exception could be thrown. [50322]

================================================================================
Build 2/4.6.20133.54702, 20-Jan-2014
================================================================================

Enhancements
------------

* C1PrintDocument/C1MultiDocument: faster generation of documents containing
  many hyperlinks with C1LinkTargetAnchor.

================================================================================
Build 2/4.6.20133.54701, 31-Dec-2013
================================================================================

Bug fixes
---------

- C1Report: in RTF field text got clipped if the field was split over pages. [47658]
- C1Themes related corrections.

================================================================================
Build 2/4.6.20133.54660, 19-Dec-2013
================================================================================

Bug fixes
---------

- C1ReportDesigner control: themes-related corrections.

================================================================================
Build 2/4.6.20133.54659, 11-Dec-2013
================================================================================

New features
------------

- Added themes support to C1ReportDesigner control.

Bug fixes
---------

- C1Report prompted for integer values when the data source was set to a stored
  procedure which required parameters of the DateTime type. [46042]

================================================================================
Build 2/4.6.20133.54656, 25-Nov-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20133.54655, 07-Nov-2013
================================================================================

Bug fixes
---------

- Pdf: explicit directional embedding characters were not exported correctly. [43395]
  (previous fix was incomplete).

================================================================================
Build 2/4.6.20133.54654, 03-Nov-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20133.54653, 25-Oct-2013
================================================================================

Bug fixes
---------

- Major slow down in PDF export (regression). [42031]
- Edges of a round corner gradient field were clipped at some screen resolutions. [42942]
- Export to Excel: rows appear bigger with small font sizes. [42641]

================================================================================
Build 2/4.6.20133.54651, 17-Oct-2013
================================================================================

Bug fixes
---------

- C1Report: chart field in a group header could be rendered incorrectly. [43197]
- Pdf: explicit directional embedding characters were not exported correctly. [43395]
- Pdf: misaligned vertical alignment. [43394]

================================================================================
Build 2/4.6.20133.54650, 12-Oct-2013
================================================================================

* 2013v3 build.

Bug fixes
---------

- Fixed: issue with overlapping group footers with PrintAtPageBottom true. [34823]
- Fixed (export to docx): alignment of RenderInputText lost in export. [33959]

================================================================================
Build 2/4.6.20132.54642, 19-Sep-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20132.54641, 17-Sep-2013
================================================================================

Bug fixes
---------

- Fixed: Japanese tests in some cases wrapped incorrectly. [41437]
- PDF: single-byte spaces after EUDC chars were shown as ".". [39657]

================================================================================
Build 2/4.6.20132.54640, 22-Aug-2013
================================================================================

Bug fixes
---------

- Additional fixes for issues 36976, 40628.

================================================================================
Build 2/4.6.20132.54639, 17-Aug-2013
================================================================================

Bug fixes
---------

- Export to Excel: fixed images overlapping text in some cases. [40722]
- Export to Excel: fixed maximum row/column limits.
- Export to PDF: fixed several clipping and sizing issues. [40253, 40584, 40628]
- Export to PDF: fixed export of certain graphics. [38178]
- Fixed: in some cases in a RenderTable, grid lines of a user group were rendered
  incorrectly on page breaks. [40941]
- Fixed: error when resolving some relatively positioned objects. [40854]
- Fixed: in some cases rendering of RTF could hang. [37781]
- C1ReportDesigner: added new property:
    bool C1ReportDesigner.UseCreationGraphicsToRenderFields {get;set;}
  If this property is true (default), C1Report.CreationGraphics is used as
  reference graphics when the designer renders the fields. This fixes some
  inconsistencies between rendering certain fiels in designer vs run time.
  Previously, the report designer always used the screen DC. (Set this property
  to false to revert to the old behavior). [39430]

================================================================================
Build 2/4.6.20132.54638, 25-Jun-2013
================================================================================

Bug fixes
---------

- Enabled export to XPS in Japanese build (.NET 4.0 only). [38014]

================================================================================
Build 2/4.6.20132.54637, 24-Jun-2013
================================================================================

Bug fixes
---------

- Index out of bounds exception when exporting some reports to PDF. [36976]
- Several fixes in export to Open XML Word. [37581]
- Hebrew text in page footer was not exported to RTF. [36510]

================================================================================
Build 2/4.6.20132.54636, 15-Jun-2013
================================================================================

Bug fixes
---------

- When exporting a custom paper size report with portrait orientation to
  RtfLabelFilter text alignment was incorrect. [37206]
- When exporting a report with Hebrew text to Excel, text was mangled. [36513]
- Fixed text clipping when exporting to PDF. [34659]
- Fixed link in about box.

================================================================================
Build 2/4.6.20132.54635, 01-Jun-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20131.54634, 29-May-2013
================================================================================

Bug fixes
---------

- Fixed PDF export bugs.
- Fixed exception occurs during document rendering if it contains
  some types of LinearGradientBrush.
- Fixed XLS export bugs.

================================================================================
Build 2/4.6.20131.54633, 08-May-2013
================================================================================

Bug fixes
---------

- When using C1Report.RenderToFilter to render to a stream, the resulting stream
  could contain just part of the report. [36417, 35905].
- In export to DOCX, RTF or HTML, extra rows could be inserted when exporting a
  RenderTable. [35406]
- Border was not displayed for subreport fields. [35843]

================================================================================
Build 2/4.6.20131.54632, 24-Apr-2013
================================================================================

Bug fixes
---------

- C1Report export filters: when a filter (e.g. HtmlFilter) was created on a
  stream, that stream was closed when the filter completed (regression bug
  introduced in build 54625). [35905]

================================================================================
Build 2/4.6.20131.54631, 22-Apr-2013
================================================================================

* Internal changes.

================================================================================
Build 2/4.6.20131.54629, 11-Apr-2013
================================================================================

Behavior changes
----------------

* New licensing (Japanese version only).

Bug fixes
---------

- Incorrect line wrapping of Japanese text (new line added after "ten-ten"
  symbol). [34464]
- C1Report's non-paginated RTF filter could produce invalid result if the report
  contained thin lines. [35570]
- Internal changes.

New features
------------

* Added new option to C1.C1Preview.Export.RtfExporter:

    bool ShapesWord2007Compatible {get;set;}

  This option is only relevant for Open XML (DOCX) paginated export, and
  controls which format is used when creating shapes. The default is true, which
  creates shapes in Word 2007 format. Setting this option to false produces
  shapes in Word 2010 format which supports certain new options but is not
  compatible witih Word 2007, and may yield documents that are handled very
  slowly by MS Word. So unless you specifically need the Word 2010 shape
  support, leave this option at its default false value. (The new option is
  also available in the DOCX export options dialog.) [35571]

* Added new report page rendering mode that allows to add content and generate
  the C1PrintDocument representing the report. New mode is specified by the new
  PageRenderingMode.ReflowableDocument enum element:

  The C1PrintDocument representing the generated report (accessible via the
  C1Document property) will be reflowable, so that additional elements (such as
  overlays) may be added to the document after the report has generated, and
  C1Report.C1Document.Generate() may be called to render the additional content.

  Note that this mode is slower than the default, so use only when necessary.

================================================================================
Build 2/4.6.20131.54624, 26-Feb-2013
================================================================================

Bug fixes
---------

- Export to .docx: wrong size of tiled pictures. [33693]
- Export to .docx: wrong text alignment in RenderInputText. [33959]
- Export to Excel: wrong order of fields in detail sections. [34062]
- Export to Excel: wrong position of first row on page when DataOnly is true. [28946]

New features
------------

* Added new property to C1PrintDocument:
    PrintDocument C1PrintDocument.Document {get;}
  Gets a PrintDocument object that can be used to render the current document
  into a standard print preview control. Not needed and not recommended if
  you're using ComponentOne preview controls.

* Added access to C1MultiDocument.PageCount property from C1PrintDocument scripts.
  For example, the following code forces adding an empty page if the C1MultiDocument
  containing the current C1PrintDocument has odd number of pages (i.e. the next page
  will always print on an odd page):

    RenderEmpty re = new RenderEmpty();
    re.ObjectResolvedScript =
      "if MultiDocument.PageCount mod 2 <> 0 then\r\n" +
      "Dim lc As LayoutChangeNewPage = New LayoutChangeNewPage()\r\n" +
      "lc.PageLayout = New PageLayout()\r\n" +
      "lc.PageLayout.PageFooter = New RenderEmpty()\r\n" +
      "Document.Body.Children(RenderObject.IndexInOwner + 1).LayoutChangeAfter = lc\r\n" +
      "else\r\n" +
      "Document.Body.Children(RenderObject.IndexInOwner + 1).LayoutChangeAfter = Nothing\r\n" +
      "end if";
    doc.Body.Children.Add(re);
    doc.Body.Children.Add(new RenderEmpty());

* Added C1Report.Print(...) and C1Report.PrintDialog(...) method overloads, which are
  shortcuts to the corresponding methods of the C1PrintDocument representing the current
  report (i.e. they just call C1Document.

* C1Report\Report.cs: added Print(...) and PrintDialog(...) overloads which are
  simple shortcuts calling the corresponding methods on the underlying C1Document.

================================================================================
Build 2/4.6.20131.54622, 07-Feb-2013
================================================================================

Bug fixes
---------

- Fixed: crash when exporting some reports to Excel. [27572, 33845]
- Fixed: reports containing group footers with PrintAtPageBottom set to true
  were incorrectly exported to Excel. [28710]
- Fixed: spacing between page columns was not serialized. [33814]
- Fixed: '&' in RenderInput* objects replaced with '_' when exported. [33806]
- Fixed: incorrect image clipping in PDF export. [33686]
- Fixed: incorrect layout when exporting document with maps to HTML. [33552]
- Fixed: unexpected page breaks could occur before group footer if
  C1Report.RecordsPerPage was greater than 0. [33498]

New features
------------

* Added a new mode of generating report pages that can help avoid memory issues
  for very large reports. Supporting types and properties are:

  New public enum PageRenderingMode, with two elements:
  - Default - the default mode, same as previously;
  - AsMetafiles - in this mode, as each page of a report is generated, a metafile
    for it is created and then all page related data is purged from memory.

  New public property on C1Report:
    public PageRenderingMode PageRenderingMode {get;set;}
  Specifies which page rendering mode to use when generating the report.

  Use the default unless you have a very large report that may run out of memory
  when using the default.

* Added a new application to the C1Report suite: C1dView.exe. This application
  allows to generate and view C1Report and previously saved documents. The
  application uses C1Ribbon-based UI. Full source code and a Visual Studio
  template are provided as a sample (downloadable from the C1 web site). Note
  that this app uses .NET 4.0 version of C1 controls. See readme-c1dview.txt for
  details.

================================================================================
Build 2/4.6.20131.54620, 21-Jan-2013
================================================================================

Bug fixes
---------

- PDF export: if a field contains "low" characters (such as "g" or "y"), the
  immediately following field is positioned lower than needed. [33129]
- Fixed: document/report generation could fail in a multithreaded environment.
- Fixed: Reports containing group footers with PrintAtPageBottom set to true
  were incorrectly exported to Excel. [28710]
- Fixed: when a hyperlink is created using RTF text, the hyperlink is not
  clickable. [32202]

New features
------------

* Improved export of dashed lines to PDF (smaller file sizes).

  Added properties:

    bool C1Report.CompatibilitOptions.UseGdiLinesInPdfExport {get;set;}
    bool C1PrintDocument.CompatibilitOptions.UseGdiLinesInPdfExport {get;set;}

  Set the corresponding property to true to use GDI when rendering for PDF, which
  improves speed and reduces file size if the document contains many dashed lines.

* Added new property:

    string RenderObject.ObjectResolvingScript {get;set;}

  Gets or sets the script that is executed before resolving the current object.

* Added new properties on C1PrintDocument and C1Report:

  * public MeasurementDeviceEnum C1PrintDocument.CreationDevice {get;set;}
    public MeasurementDeviceEnum C1Report.CreationDevice {get;set;}

  Gets or sets the type of device that is used to provide reference graphics
  when generating the report. If this property is MeasurementDeviceEnum.Printer
  (which is the default), CreationPrinterName specifies the printer.

  Normally all installed printers would be scanned to obtain a high-resolution
  reference Graphics object. In order to bypass this process, set this property
  to MeasurementDeviceEnum.Screen. In some cases this may increase rendering
  speed at the cost of some loss in layout accuracy.

  * public string C1PrintDocument.CreationPrinterName {get;set;}
    public string C1Report.CreationPrinterName {get;set;}

  Gets or sets the name of the printer that is used to provide reference
  graphics when generating the report. This property is only used if
  CreationDevice is set to MeasurementDeviceEnum.Printer. Set this property to
  null to select the reference printer automatically.

  Note that while the meaning of CreationDevice and CreationPrinterName
  properties are the same on a C1Report and a C1PrintDocument, the defaults on a
  C1Report are not affected by the static properties
  C1PrintDocument.MeasurementDevice and C1PrintDocument.MeasurementPrinterName.
  Instead, MeasurementDeviceEnum.Printer is used as the default, and the default
  printer name is null (which means that the printer is selected automatically).
  This is done for compatibility with previous versions.

  * public float C1PrintDocument.CreationDpi {get;set;}
    public float C1Report.CreationDpi {get;set;}

  Gets or sets the resolution (DPI) used when generating the report.

  * public Graphics C1PrintDocument.CreationGraphics {get;set;}
    public Graphics C1Report.CreationGraphics {get;set;}

  Gets or sets the System.Drawing.Graphics object to use as reference when
  generating the report. This Graphics is used to calculate text sizes, measure
  RTF text, and so on.

  * public MeasurementDeviceEnum C1PrintDocument.ActualCreationDevice {get;set;}
    public MeasurementDeviceEnum C1Report.ActualCreationDevice {get;set;}

  Gets the actual measurement device which was used to generate the report.

  * public string C1PrintDocument.ActualCreationPrinterName {get;set;}
    public string C1Report.ActualCreationPrinterName {get;set;}

  Gets the name of the actual measurement printer which was used to generate the
  report.

  NOTE: unlike previous versions, now when automatically selecting a measurement
  printer the default system printer is checked first.

* Improved handling of font embedding and substitution. Added new types:
  - C1.C1Preview.FontProcessingOptions
  - C1.C1Report.FontProcessingOptions - this class is derived from
    C1.C1Preview.FontProcessingOptions but overrides default values for compatibility
    with earlier versions. Both classes have the same properties:

  * public FontHandling FontHandling {get;set;}

  Gets or sets a value indicating how font embedding and substitution are handled
  by the current C1PrintDocument or C1Report.

  * public string SubstitutionFallbackFontName {get;set;}

  Gets or sets the name of a font used when a document or report cannot find a
  suitable font to display a text.

  * public bool UseOldSubstitutionAlgorithm {get;set;}

  Gets or sets a value indicating whether to use the old (prior to 2013v1 release)
  algorithm of font substitution.

  * public EmbeddedFontsGlyphsBuildMode EmbeddedFontsGlyphsBuildMode {get;set;}

  Gets or sets a value indicating how EmbeddedFont builds lists of glyphs.

  Added corresponding public properties to C1PrintDocument and C1Report:
  - public FontProcessingOptions C1PrintDocument.FontProcessingOptions {get;}
  - public FontProcessingOptions C1Report.FontProcessingOptions {get;}

* Added the ability to stretch barcodes. New properties:
  - public bool C1PrintDocument.CompatibilityOptions.StretchBarCodesAsImages {get;set;}
  - public bool C1Report.CompatibilityOptions.StretchBarCodesAsImages {get;set;}

  Gets or sets a value indicating whether to stretch barcodes as images.
  The default value is false, which is compatible with previous versions.

================================================================================
Build 2/4.6.20123.54608, 12-Dec-2012
================================================================================

Bug fixes
---------

- Export of certain C1MultiDocument to PDF could result in exception message. [30904]

================================================================================
Build 2/4.6.20123.54607, 10-Dec-2012
================================================================================

Bug fixes
---------

- Fixed several issues in export of text to DOCX. [30819, 30830, 30834]

================================================================================
Build 2/4.6.20123.54605, 06-Dec-2012
================================================================================

Bug fixes
---------

- Fixed HTML filter issue with exporting barcode labels. [30482]
- Fixed export of vertical text to DOCX. [30416]
- Fixed export of C1TrueDBGrid header rows to Excel. [30422]

================================================================================
Build 2/4.6.20123.54604, 27-Nov-2012
================================================================================

Bug fixes
---------

- Fixed null reference exception when rendering sub-reports with RecordsPerPage specified. [30394]
- Fixed several issues in export to Excel. [30314, 30302, 30238]
- Fixed export of rotated images to DOCX/RTF. [21437]
- Fixed export of C1Report footers to DOCX. [30246]
- Fixed export of vertical text to PDF. [30218]
- Fixed export of vertically aligned text to RTF and HTML. [30212]

================================================================================
Build 2/4.6.20123.54603, 21-Nov-2012
================================================================================

Bug fixes
---------

- Proper setting of Reflowable flag when loading document from an older C1D/X file. [28057]

================================================================================
Build 2/4.6.20123.54602, 13-Nov-2012
================================================================================

Bug fixes
---------

- Updated licensing. [28687]
- Fixed a multithreading issue when exporting to PDF. [29892]
- Invalid PDF were created when rendering some reports to PDFEmbedFonts. [29898]
- Fixed checkbox alignment when exporting to Excel. [29237]

================================================================================
Build 2/4.6.20123.54601, 26-Oct-2012
================================================================================

Behavior changes
----------------

- Use CurrentUICulture rather than CurrentCulture when selecting appropriate string resources.

Bug fixes
---------

- Errors when handling certain fonts (e.g. some Japanese fonts) in Windows 8. [28099, 28866]
- Incorrect export of numbers in Arabic text to PDF. [28715]
- Incorrect export of empty C1Report fields to RTF. [28940]

================================================================================
Build 2/4.6.20123.54600, 11-Oct-2012
================================================================================

* 2012 v3 release.

New features
------------

- Added design and run time support for Chinese and Korean languages.

================================================================================
Build 2/4.6.20122.54519, 09-Oct-2012
================================================================================

Bug fixes
---------

- Fixed regression error when exporting C1Report with chart to DOCX. [27780]
- Fixed metro toolbox icons issues. [27666]
- Fixed regression error in C1PrintDocument export to Excel. [28057]
- Fixed table column resizing error in export to RTF. [28417]
- Fixed export to HTML for reports with user scripts changing section visibility. [27914]
- Fixed CodeWall compatibility issue introduced in build 54407. [28141]

================================================================================
Build 2/4.6.20122.54517, 28-Sep-2012
================================================================================

Bug fixes
---------

- Fixed scaling of image fields when exported to RTF. [27523]
- Added error details to ReportError event for open data source errors. [27786]
- Fixed some issues with metro icons. [27666, 27670]

================================================================================
Build 2/4.6.20122.54516, 04-Sep-2012
================================================================================

Bug fixes
---------

- Added reference to WindowsBase in WPF C1PrintDocument scritps. [27508]
- Fixed export to PDF when Hebrew letters were mixed with digits. [27339]
- Fixed padding and page size issues in export to DOCX and RTF. [25952]
- Added metro toolbox icons.

================================================================================
Build 2/4.6.20122.54515, 13-Aug-2012
================================================================================

Bug fixes
---------

- Misc bug fixes in PDF export.
- Picture within C1Report's Field is visible even if PictureScale set to Hide. [23579]
- TextColor property of RenderInputText and RenderInputComboBox
  is not affected in C1Printdocument when document opened in preview,
  but it used when document printed or exported as image. [23537]
- BarCode fiels of C1Report exported to XLS, HTM, RTF with distortions. [24489]
- C1Report detail section can be rendered twice when IEnumerable specified as datasource
  and report contains nested groups. [24740]

New features
------------
* Added property:
  object C1.C1Rdl.Rdl2008.DataSource Recordset { get; set; }
  Gets or sets the data source object that provides data to this DataSource object.
  Following objects can be specified as Recordset:
    - DataTable
    - DataView
    - Object supporting IEnumerable interface
    - Object supporting IEnumerator interface
  If assigned object does not contain list of fields (like DataTable or DataView)
  then fields are built via ITypedList interface. If ITypedList
  interface is not supported then public properties of first object in the collecton
  used as fields. [17942]

================================================================================
Build 2/4.6.20122.54514, 26-Jul-2012
================================================================================

Bug fixes
---------

- Code128 barcodes could be rendered incorrectly if they contained dot-separated digits. [23709]
- Import from Crystal Reports when Crystal Reports for Visual Studio 2010 is installed. [22112]

================================================================================
Build 2/4.6.20122.54513, 13-Jul-2012
================================================================================

Bug fixes
---------

- Paged HTML export worked incorrectly when exporting multi-column reports. [23729]
- HTML filter failed if report name contained a forward slash chart '/'. [23785]
- Incorrect rendering of RTF fields with text similar to "X{\super 2}". [23986]
- Export to XLS with pagination off produced incorrect output. [18885]
- When exporting a C1MultiDocument to PDF, outlines were lost. [22070]

New features
------------

* C1Report: added support for ODBC and SQL Server Compact Edition versions 3.5 and 4.0:
  - a new enum DataProvider was added which specifies the supported types of data sources;
  - a DataProvider property was added to C1Report.DataSource object.

  Note: by default, the DataProvider is "auto" which means that when opening the
  data source, the type of the data provider is determined automatically (this
  is the same behavior as before). But it is highly recommended to set the
  DataProvider to a specific value that matches the actual type of the data
  source used, as automatic determination of the data provider is generally
  speaking not effective and may take a lot of time.

================================================================================
Build 2/4.6.20122.54512, 22-Jun-2012
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20122.54511, 21-Jun-2012
================================================================================

Bug fixes
---------

* Misc bug fixes in PDF export.

================================================================================
Build 2/4.6.20122.54510, 07-Jun-2012
================================================================================

Bug fixes
---------

* Fixed: after exporting a list of metafiles (i.e. not a C1Report or a
  C1PrintDocument), the metafiles were disposed which resulted in crashes if the
  list was accessed afterwards (e.g. in the preview). [23157]

* Fixed: some Code128 barcodes (e.g. those containing more than 4 digits in
  sequence) were rendered incorrectly. [22950]

* Fixed: some vertical Japanese strings were rendered horizontally. [20985]

================================================================================
Build 2/4.6.20121.54506, 26-May-2012
================================================================================

Bug fixes
---------

* Misc bug fixes in PDF export.

================================================================================
Build 2/4.6.20121.54505, 12-May-2012
================================================================================

Bug fixes
---------

* PDF export: fixed incorrect rendering of background and clipping issue when
  using certain fonts. [21615]

* PDF export: fixed incorrect export of vertical Japanese strings. [20985]

* Several minor localization bugs fixed.

* Fixed: the page footer in a report could not be hidden completely. Now this
  can be achieved by placing code equivalent to the following either in OnPage
  script or in StartPage event:

    C1Report1.Sections.PageFooter.CanShrink = False
    C1Report1.Sections.PageFooter.CanGrow = False
    C1Report1.Sections.PageFooter.Height = 0

  Note that the PageFooter.Visible property works as before (i.e. it hides the
  page footer but the area it occupied on page is still "taken" by it). [21512]

* XPS export (also affected preview in WPF version): some databound images were
  displayed incorrectly (wrong images were shown). [20804]

* XPS export (also affected preview in WPF version): in some cases metafiles
  rendered into a C1PrintDocument showed as "zoomed in". [21440]

* Fixed: Layout.Columns of a subreport was ignored. [21238]

* Fixed: if a field was used in an aggregate function in a report's page header
  or footer, wrong data was shown for that field in detail on the next page.
  [21220]

================================================================================
Build 2/4.6.20121.54504, 05-Apr-2012
================================================================================

Bug fixes
---------

* Behavior change: if user code calls Reflow() on a non-reflowable
  C1PrintDocument, exception is thrown. Previously, there was no exception and
  this could lead to incorrectly formatted documents.

* Fixed: exception occurred when Reflow() called on C1PrintDocument with
  embedded fonts. [20869]

* Fixed: C1PrintDocument.Reflowable flag was not serialized. [20868]

* Fixed: dashed lines are now supported in export to XPS and WPF viewer. [20644]

* Fixed: wrong image size in pdf export when ParseEmfPlus property is true. [20678]

* Fixed: when exporting a report to RTF with absolutely-positioned fields,
  picture alignment was always top/left. [20704]

================================================================================
Build 2/4.6.20121.54503, 16-Mar-2012
================================================================================

Bug fixes
---------

* Fixed (export to Excel): when exporting a document with two charts only one
  shows up. [20449]

================================================================================
Build 2/4.6.20121.54502, 07-Mar-2012
================================================================================

Bug fixes
---------

* Export to PDF: fixed positioning of subscript text. [19366]

* Fixed: if a document with embedded fonts was saved as c1d/x with font
  embedding turned off in the options dialog, fonts still were embedded in the
  c1d/x. [19811]

* C1.C1Report.CustomFields.4.dll's assembly version is now synchronized with
  C1Report's version.

* Fixed: Using an external barcode font showed text instead of the barcode. [19888]

New features
------------

* Added support for Ean128 (GS1-128) barcodes.

================================================================================
Build 2/4.6.20121.54501, 13-Feb-2012
================================================================================

Bug fixes
---------

* Fixed: FIPS compliance (exceptions when exporting to PDF). [18679, 18677]

* Fixed: WMF images not visible in C1PrintDocument. [19893]

* Fixed: paper size was not set correctly when using a C1Report in a WCF services app. [19535]

* Fixed (regression): in export to DOCX, borders were displayed around text. [18798]

* Fixed: in C1PrintDocument, render objects with sizes specified like:
    ro.Width = "max(3cm, auto)";
  were rendered incorrectly. [19239]
  NOTE: use of "auto" in expressions has the following limitations:
  - "auto" can only be used to specify width or height (i.e. not coordinates);
  - cannot be used to specify sizes of columns and rows in RenderTable;
  - expressions using "auto" (e.g. "max(auto,3cm)") should be used only on the
    most nested object, otherwise unexpected results may occur.

* Fixed: some content (e.g. from a superlabel field) was not shown in exported PDF. [19009]

New features
------------

* Added property DocumentName on C1MultiDocument and C1RdlReport:
    string DocumentName {get;set;}
  Gets or sets the name of the document (used to identify documents in print
  tasks and so on). For C1RdlReport, C1RdlReport.Description is returned by
  this property.

* Export to PDF, RTF, XLS: added parsing of EMF+ files without converting them
  first to EMF only. Enabled using the property on corresponding exporters:
    bool ParseEmfPlus {get;set;}
  Gets or sets a value indicating whether EMF+ metafiles should be parsed
  directly without converting them to EMF-only first. The default is false. Set
  to true if you have issues resulting from EMF+ to EMF conversion.
  NOTE: currently this property is in "experimental" status, should be used only
  if specific problems exist when using defaults.

* Export to XLS/XLSX: added data-only export:
    bool XlsExporter.DataOnly {get;set;}
  Gets or sets a value indicating whether only data should be exported, ignoring
  visual attributes.
  This can also be turned on by the user in XLS export options form.

* Rules of applying locale settings in C1Report script functions (CStr, CDbl and
  CDate) were changed to better work in non-US locales. Prior to this release,
  the following rules were used:
  - CStr used Application.CurrentCulture.
  - CDbl used InvariantCulture, if that failed Application.CurrentCulture was used.
  - CDate used InvariantCulture.
  Starting with this (2012 v1) release, the rules changed to:
  - CStr uses Application.CurrentCulture.
  - CDbl and CDate use Application.CurrentCulture, if that fails then InvariantCulture is used.

  To revert to old behavior, use property:
  bool C1Report.CompatibilityOptions.OldTypesConversion {get;set;}

* C1Report: added new member to public enum: FileFormatEnum.HTMLTableBased, to
  use HtmlTableFilter: creates a single HTML file that can be viewed in any web
  browser. Unlike plain HTML format, uses tables rather than absolute
  positioning to arrange objects.

* C1Report: added shape support, provided by Field.Shape and Field.ShapeType
  properties:

    ShapeType ShapeType {get;set;}
  Gets or sets the type of geometric shape drawn by the current field. The
  default is None.

    ShapeBase Shape {get;set;}
  Gets or sets an instance of the ShapeBase-derived class specifying properties
  of the geometric shape drawn by this field (if ShapeType is not None).

  The hierarchy of shape classes is as follows:
  ShapeBase
  - LineShapeBase
  -- LineShape
  - TriangleShapeBase
  -- IsoscelesTriangleShape
  -- RightTriangleShape
  - RectangleShape
  -- EllipseShape
  --- EllipsePartShape
  ---- ArcShape
  ---- PieShape

  In the report designer, select the desired ShapeType from the dropdown, then
  adjust the sub-properties of Shape as needed.

  In code, create an instance of the desired ShapeBase and assign it to the
  Field.Shape property, e.g.:
    Field.Shape = new LineShape(LineSlant.NoSlant);
  In C1Report scripts, the following method may be used to specify shapes:
    field.ShapeType = "Pie";
    field.Shape.StartAngle = 10;
    field.Shape.SweepAngle = 100;

* C1Report: added support for rotated text:
    float Field.TextAngle {get;set;}
  Gets or sets the angle of text rotation within the field (including barcodes).
  Note that some output/export formats (such as HTML, RTF and plain text) may not
  support rotated text.

* C1Report: added new property:
    double AvailableHeight {get;}
  Gets the height of the remaining area available for sections on the current page.
  This property can only be used while the report is being rendered (i.e. when IsBusy is true),
  at other times a value of -1 is returned.
  Note that if used in OnPrint/OnFormat scripts, this value does NOT yet account for the current section.

  Here is an example of code which can be used in the detail section's OnFormat
  script to determine whether the current detail section will be the last one
  printed on the page (the test checks that the current section will fit onto
  the page while the next section won't):

    h = Detail.RenderHeight
    ah = Report.AvailableHeight
    if (h &lt; ah) and (2 * h > ah) then
      Detail.BackColor = RGB(255, 0, 0) ' last on page
    else
      Detail.BackColor = RGB(255, 255, 255)
    endif

* C1Report: added the ability to specify transaction isolation level:
    IsolationLevel C1.C1Report.DataSource.IsolationLevel {get;set;}
  Gets or sets the isolation level for OleDBTransaction used to retrieve the
  report data. The default is IsolationLevel.ReadCommitted.

================================================================================
Build 2/4.6.20113.54463, 20-Jan-2012
================================================================================

Bug fixes
---------

* C1Report barcodes now stretch to the full height of the field if PictureScale
  is Stretch (except for PostNet). C1PrintDocument's RenderBarCode now stretches
  vertically if Style.ImageAlign.StretchVert is true.

* Fixed C1Report: in rare cases if Repeat was true for a group footer, it could
  cause an endless loop when the report was generated. [19125]

* Fixed CustomFields SuperLabel: it could not be bound to a data field.

================================================================================
Build 2/4.6.20113.54462, 09-Dec-2011
================================================================================

Bug fixes
---------

* Added strong name to C1.C1Report.CustomFields.4.dll (NOTE: this is for
  .NET 4.0 only!). This allows to put the custom fields assembly in the GAC if
  needed.

================================================================================
Build 2/4.6.20113.54461, 30-Nov-2011
================================================================================

Bug fixes
---------

* Updated licensing to conform with Federal Information Processing Standards
  requirements. [18460, 18562]

* C1Report: improved rendering of barcodes. [18265]

New features
------------

* C1Report VBScript enhancements:
  - support for HEX numbers, e.g. &H001122&, or without ending '&' e.g. &H00AABB.
  - new function: ARGB(...), accepts 1, 3 or 4 parameters, and produces GDI+
    colors, e.g.: Field.BackColor = ARGB(80, 255, 0, 0).

* C1Report: added support for PrintAtPageBottom property to group footer section.

================================================================================
Build 2/4.6.20113.54459, 04-Nov-2011
================================================================================

Bug fixes
---------

* Fixed (x64 systems only): in some cases a null reference exception occurred
  when generating a report or document containing RTF text. [18165]

================================================================================
Build 2/4.6.20113.54458, 27-Oct-2011
================================================================================

Bug fixes
---------

* Fixed: if a field of a C1Report split between pages, it was shifted to the
  left on the second page. (Regression bug added in build 54407.) [17795]

* Properly support LINQ objects implementing IBindingList interface as data
  sources for C1Report. [14345]

* Fixed error when exporting barcodes to PDF with AES security. [17984]

* Fixed support of dashed lines in export to Excel.

* Fixed export of numbers in Arabic text to PDF. [17563]

================================================================================
Build 2/4.6.20113.54457, 19-Oct-2011
================================================================================

Bug fixes
---------

* Fixed: certain unbound images from network locations did not render in
  C1Report at runtime. [17779]

* Fixed export of C1Report checkbox fields using Wingdings font to Excel.
  [17753]

* Fixed issues when printing to certain paper sizes (e.g. A0 or A1). (Related to
  page setup fix [17823] in preview controls.)

* Fixed: in some cases EMF+ metafiles displayed incorrectly in C1Report even if
  C1Report.EmfType was set to EmfPlusOnly.

New features
------------

* Now Linq data sources (IEnumerable) can be used in C1Report. [14345]

================================================================================
Build 2/4.6.20113.54456, 11-Oct-2011
================================================================================

* Readme files updated.

================================================================================
Build 2/4.6.20113.54455, 08-Oct-2011
================================================================================

* Starting with this build, the C1ReportDesigner control is included in the
  ComponentOne Studio for WinForms, is licensed by the same keys that are valid
  for C1Report, and the C1.Win.C1ReportDesigner assembly is now included in the
  main C1Reports distribution.

Bug fixes
---------

* Fixed an error ("Could not load document: Error during deserialization") that
  occurred when exporting a C1PrintDocument with certain images to some formats.
  [17493]

New features
------------

* C1RdlReport can now load reports created with Report Builder 3.0 (MS SQL 2008
  R2) that use the 2010 RDL spec, PROVIDED the report definition contains only
  one ReportSection. The following changes were made:

  - new member added to RdlFormatVersion enum: Rdl2010.

  - the property C1RdlReportBase.RdlVersion is now read write. After loading a
    report, it contains the actual version of the loaded RDL (Rdl2008 or
    Rdl2010). If that property is assigned a different value, the report will be
    saved in the specified format.

  Note that if the report contains more than one ReportSection, an exception
  will be thrown.

================================================================================
Build 2/4.6.20113.54454, 05-Oct-2011
================================================================================

Bug fixes
---------

* Fixed: in certain scenarios loading C1MultiDocument with disk storage could
  cause a null reference exception. [17611]

New features
------------

* Enhanced licensing in environments with some security policy restrictions.

* C1Report: added new public property on Section:

    public bool PrintAtPageBottom {get;set;}

    For master report's footer sections only, gets or sets a value indicating
    whether the current section should print at the bottom of the page
    immediately above the page footer, rather than right below the detail. The
    default is false.
    This property is ignored for non-footer sections or for footers of sub-
    reports. [13510]

* C1Report: enhanced the Section.Repeat property - it is now supported for group
  footer sections (in addition to group headers). [13689]

================================================================================
Build 2/4.6.20113.54453, 30-Sep-2011
================================================================================

Bug fixes
---------

* Fixed: default storage for C1MultiDocument was not "memory". [17516]

* Fixed: the last bullet of a C1Report field with an RTF list was not rendered
  correctly if the field was larger than page. [15653]

* PDF exprot: fixed an error when exporting a document with AES128 encryption
  but without a password. [17532]

================================================================================
Build 2/4.6.20113.54452, 25-Sep-2011
================================================================================

New features
------------

* CustomFields: new custom field QRCode that renders QR (Quick Response) 2D
  barcode added to the pre-built custom fields assembly (.NET 4.0 version only).

Bug fixes
---------

* C1PrintDocument: Fixed several issues when rendering tables. [17372]

* C1Report: Fixed incorrect page numbering in the thumbnail view when the page
  was changed in the Section.OnPrint script. [17283]

* C1MultiDocument: fixed reading of .c1mdx files created with builds prior to
  54450.

* C1Report: fixed bug when a new column was started instead of a new page when a
  subreport was rendered within a report's footer. [17251]

* C1MultiDocument: default storage type was changed from memory to disk
  (binary serialization that is used by multi-document now requires more space).

================================================================================
Build 2/4.6.20113.54451, 12-Sep-2011
================================================================================

* 2011 v3 release.

Bug fixes
---------

* Fixed: when a field of a C1Report definition containing only white space
  characters (e.g. a single TAB character) was loaded into a C1Report, the
  resulting field became emtpy. This could cause problems e.g. if that field
  was a barcode. [17134]

* Fixed: when the page column def collection of a C1PrintDocument was edited in
  the collection editor at design time (e.g. a column was added) and the
  collection editor was closed by clicking the X button in the top right of the
  window, the changes were not cancelled as they should. [15518]

New features
------------

* Added binary C1PrintDocument serialization format (default extension .C1DB).
  This is a proprietary binary format that is designed to provide better
  performance when serializing large documents in performance critical
  situations. This is the format that is now used by C1MultiDocument, and
  significantly improves multi-document's performance.

  Note: properties of user types derived from C1PrintDocument classes are NOT
  serialized by binary serializations. E.g. if you derive your own document type
  from C1PrintDocument, and add your own properties to that type - they will NOT
  be serialized by the binary format. Use C1D/X formats in such cases.

* PDF export: added support for 128 bit (RC4 and AES) encryption, see the new
  C1.C1Preview.Export.PdfExporter.Security.Encryption property.

================================================================================
Build 2/4.6.20112.54409, 16-Aug-2011
================================================================================

Bug fixes
---------

* Fixed: stack overflow occurred when generating a document with a RenderTable
  that contained stretched rows or columns with spanned cells. [16697]

New features
------------

* New public enum WordWrapMode: Specifies how to break words when lines of text wrap.

* New public property on C1.C1Preview.Style:
    WordWrapMode WordWrapMode {get;set;}
  Gets or sets a value indicating how words can be split when text lines wrap. [13690]

* C1Report's HtmlTableFilter enabled in the .NET 4.0 version.

================================================================================
Build 2/4.6.20112.54408, 12-Jul-2011
================================================================================

Bug fixes
---------

* Fixed: C1Report.RecordsPerPage property was processed incorrectly if thereport
  contained groups - page break was not inserted between the groups. (The fix
  in previous builds was incomplete.)

================================================================================
Build 2/4.6.20112.54407, 11-Jul-2011
================================================================================

Bug fixes
---------

* Fixed bug when C1Report.RecordsPerPage property processed incorrectly
  if report contans groups - page break not inserted between groups.

* Fixed bug when exception occurs during C1Report rendering if
  it contains subreport and subreport contains field with [PageNo] tag.

* Fixed bug in C1ReportDesigner when error occurs on previewing report
  when the last preview was canceled.

* Fixed bug when exception occurs during importing C1Report into C1PrintDocument via
  ImportC1Report method when report template contains paramters without value.

* Fixed unstable bugs which occurs when C1Report/C1PrintDocument used
  in multithreading enviroment.

* Fixed bug when report rendered incorrectly if it is multicolumn and pagebreak
  occurs within section.

* Fixed bug when field does not align/position correctly if report contains subreport which splits
  and Layout.MarginLeft was changed in C1Report.StartPage event.

================================================================================
Build 2/4.6.20112.54406, 24-Jun-2011
================================================================================

Bug fixes
---------

* Fixed bug when licensing window is displayed when C1MultiDocument
  used under licensed C1ReportViewer.

================================================================================
Build 2/4.6.20112.54405, 17-Jun-2011
================================================================================

Bug fixes
---------

* Fixed (regression) crash when exporting a C1Report with sub-reports to HTML,
  RTF or text. [15762]

================================================================================
Build 2/4.6.20112.54404, 15-Jun-2011
================================================================================

Bug fixes
---------

* Fixed regression bug: the C1PrintDocument.EditTags() method did not show the
  tags input dialog unless ShowTagsInputDialog property was set to true. This
  behavior was different prior to build 54403 (EditTags() always showed the
  dialog if explicitly called) and is restored again now. [15583]

================================================================================
Build 2/4.6.20112.54403, 14-Jun-2011
================================================================================

Bug fixes
---------

* In C1PrintDocument's tags input form, now an up/down spanner is used instead
  of a dropdown calendar for DateTime input if the format is time. [15583]

* When deserializing very large C1PrintDocument objects, use a temporary disk
  file instead of memory. This helps avoid out of memory exceptions in certain
  scenarios, e.g. when previewing a large C1MultiDocument.

* Suppress Windows events processing if C1MultiDocument.DoEvents is false.
  [15689]

* Fixed: invalid page numbers appeared in previvew thumbnails when a
  C1MultiDocument containing certain C1Report objects was shown in the preview.
  [15718]

New features
------------

* New public event added to C1MultiDocument: ItemLoaded. Occurs when the report
  or document represented by an item is loaded into memory (deserialized) prior
  to generation, but after processing of any parameters. This event allows to
  programmatically adjust the properties of the report or document before it is
  generated. For instance, the data source of a C1Report may be assigned here.

* New public method added to C1PrintDocumetn:
    public bool HasEditableTags();
  Checks whether the document contains any tags that can be entered or changed
  in the tags input dialog. Note that this method does NOT check the value of
  C1PrintDocument.ShowTagsInputDialog property.

================================================================================
Build 2/4.6.20112.54401, 01-Jun-2011
================================================================================

Bug fixes
---------

* Added public methods to remove items from a C1MultiDocument:
  C1MultiDocument.Items.Remove()/RemoveAt(). [15503]

* Fixed: when using certain printer/paper size combinations, preview print
  dialog showed incorrect paper kind and/or orientation. [15277]

* Fixed: in rare cases, C1Report sections would overlap when rendering reports
  with sub-reports that split between pages. [15074]

* Fixed: in export to Excel, formatting of tables that did not have visible grid
  lines could be corrupted. [15411]

* Fixed: in rare cases, the last line of an RTF text would not show. [14564]

================================================================================
Build 2/4.6.20112.54400, 26-May-2011
================================================================================

* 2011 v2 release.

New features
------------

* C1MultiDocument: in addition to C1PrintDocument, now C1Report and C1RdlReport
  objects can be added to a C1MultiDocument. If any reports within a multi-
  document require parameters, they are requested prior to generating the multi-
  document.

* C1MultiDocument: added outline support. A collection of outline nodes specific
  to the multi-document may be specified via the C1MultiDocument.Outlines
  property. The resulting outline (e.g. for the preview) is built as a
  combination of outline nodes in that collection and outline nodes in the
  contained documents. This outline can be built programmatically using the
  C1MultiDocument.MakeOutlines() method. The following rules are used when
  building the resulting outline:

  The multi-document's own Outlines collection is processed first, and nodes
  from that collection are included in the resulting outline. If a node is also
  specified as the value of the OutlineNode of a contained C1MultiDocumentItem
  (i.e. the two properties reference the same object), the whole outline of the
  document or report represented by that item is inserted into the resulting
  outline. Depending on the value of the multi-document item's
  NestedOutlinesMode property, the outline of the document or report is either
  nested within the outline node, or replaces it. Finally, outlines of documents
  and reports represented by items that are not included in the multi-document's
  Outlines collection are automatically appended to the resulting outline
  sequentially.

  Outlines support is provided by the following properties and methods:
  - C1MultiDocument.Outlines {get;}
  - C1MultiDocument.MakeOutlines();
  - C1MultiDocumentItem.Outlines {get;}
  - C1MultiDocumentItem.OutlineNode {get;set;}

* New public events added to C1MultiDocument: ItemGenerating, ItemAdding,
  ItemAdded, ItemRemoving, ItemRemoved, ItemsClearing, ItemsClear.

* New public method ClearGeneratedPages() added on C1MultiDocument,
  C1PrintDocument, C1Report, C1RdlReport. This method allows to clear generated
  pages and other data without deleting the content of a document or report, so
  that it can be regenerated.

* New public properties added on C1MultiDocument:
  - object UserData {get;set;}
  - bool IsGenerating {get;set;}

* New public property added on C1RdlReport: EmfType {get;set;}

* Improved performance when serializing styles.

Bug fixes
---------

* Fixed: certain font specifications were ignored. This affected fonts that had
  both Macintosh and Windows names specified in their 'names' table, one such
  font is "Akzidenz-Grotesk Std Light". [15031]

================================================================================
Build 2/4.6.20111.54317, 25-May-2011
================================================================================

Bug fixes
---------

* Assign a default name ("C1Document") to the print job when a document without
  a user specified name is printed. This avoids problems when printing to Adobe
  Acrobat X and some other virtual printers (output file is not created). [15363]

================================================================================
Build 2/4.6.20111.54316, 13-May-2011
================================================================================

Bug fixes
---------

* Fixed: method C1PageSettings.ToPageSettings() always returned page settings
  with "custom" paper kind (even though the size was correct). E.g. if 'doc' was
  a C1PrintDocument and these lines of code were executed:
    doc.PageLayout.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
    System.Drawing.Printing.PageSettings ps = doc.PageLayout.PageSettings.ToPageSettings();
  then ps.PaperSize.Kind would be Custom rather than A4. [15281]

================================================================================
Build 2/4.6.20111.54315, 07-May-2011
================================================================================

Bug fixes
---------

* Japanese text fixed in design time report picker form. [15178]

* Fixed object placement bug occurring with data-bound render objects. [15240]

* Fixed several issues when exporting report fields with up or down text direction
  to PDF. [15188]

================================================================================
Build 2/4.6.20111.54314, 02-May-2011
================================================================================

Bug fixes
---------

* Fixed: if a report custom field's text was changed by the custom field code,
  that change was ignored if the report was rendered to Excel. [15131]

* Fixed error when saving a report to .docx without pagination. [14950]

* Fixed export of hyperlinks with C1LinkTargetAnchor to RTF. [14953]

* Added UpcE to supported barcodes.

* Fixed: wrong positioning of strings with alignment set to "justify" and
  TextDirection "down". [15018]

* Added new Japanese translations.

================================================================================
Build 2/4.6.20111.54313, 19-Apr-2011
================================================================================

Bug fixes
---------

* Fixed a rare OS-dependent bug that could cause a "Font is not a TrueType font" exception when
  generating a report.

* Fixed: in C1PrintDocument, BreakBefore/BreakAfter settings on a render object were ignored if that
  object was within a table with grid lines. [15015]

================================================================================
Build 2/4.6.20111.54312, 13-Apr-2011
================================================================================

Bug fixes
---------

* Fixed: on some systems, the size of RenderImage changed when certain screen resolutions were
  selected. [12598]

* Fixed: padding in table cells was not exported correctly to HTML/XLS/XLSX. [14570]

* Fixed: C1Report could not handle SQL queries starting with "transform" keyword. [14905]

================================================================================
Build 2/4.6.20111.54311, 30-Mar-2011
================================================================================

Bug fixes
---------

* Fixed an issue in serialization exception log.

* Removed runtime-only C1PrintDocument.DocumentInto.UserData from design time property editor. [14822]

================================================================================
Build 2/4.6.20111.54310, 28-Mar-2011
================================================================================

Bug fixes
---------

* Fixed serialization issues with certain colors (in particular, this could affect colors in
  C1MultiDocument). [14792]

* .NET 4.0 build only: added explicit references to designer assemblies. This fixes issues when
  multiple versions of C1Report are installed on the same system.

================================================================================
Build 2/4.6.20111.54309, 21-Mar-2011
================================================================================

Behavior changes
----------------

* Properties defined in user types derived from C1PrintDocument, RenderObject or other C1 types are
  now excluded from C1D/X serialization by default. If you have your own types derived from C1
  types, and are sure that you need those properties to be serialized, mark them with either
  XmlElementAttribute or XmlAttributeAttribute. (If an exception occurs during serialization, that
  exception now contains a Log property that might help identify the problem.)

Bug fixes
---------

* Fixed: RTF export without pagination did not always preserve the correct page orientation. [14621]

================================================================================
Build 2/4.6.20111.54308, 07-Mar-2011
================================================================================

Bug fixes
---------

* Fixed: incorrect rendering of Hebrew text in C1Report. [14577]

* Fixed: several issues when exporting Hebrew text to PDF. [14524]

* Fixed: RecordsPerPage property was processed incorrectly in reports with groups. [14477]

================================================================================
Build 2/4.6.20111.54307, 11-Feb-2011
================================================================================

Bug fixes
---------

* Fixed bug introduced in build 54301: rendering a C1Report into a PDF file or stream via
  RenderToFile(<file or stream>,C1.C1Report.FileFormatEnum.PDF) failed with "report is busy"
  exception. [13896]

================================================================================
Build 2/4.6.20111.54306, 01-Feb-2011
================================================================================

Bug fixes
---------

* Added C1MultiDocument icon to .NET 2.0 build. [14289]

* Fixed wrong behavior of PageNumberingChangeModeEnum.Increment and PageNumberingChangeModeEnum.Set
  enumeration values. [14182]

* Changed representation of unresolved PageNo and HyperlinkPageNo tags during document generation
  from actual tag strings to "???".

================================================================================
Build 2/4.6.20111.54305, 26-Jan-2011
================================================================================

* Fixed: anchors in non-top level render objects could not be resolved in a C1MultiDocument. This
  resulted in broken hyperlinks to such objects. [14270]

================================================================================
Build 2/4.6.20111.54304, 25-Jan-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20111.54303, 24-Jan-2011
================================================================================

Bug fixes
---------

* Fixed: several issues with incorrect rendering of Japanese text. [14228]

================================================================================
Build 2/4.6.20111.54302, 18-Jan-2011
================================================================================

* ComponentOne OLAP licensing added.

Bug fixes
---------

* Fixed: in export to HTML, exception occurred if an auto-generated image file name
  matched the name of an existing file. [14208]

================================================================================
Build 2/4.6.20111.54301, 17-Jan-2011
================================================================================

New features
------------

* New component added: C1.C1Preview.C1MultiDocument.

  C1MultiDocument is designed to allow creating, persisting and exporting large documents that
  cannot be handled by a single C1PrintDocument object due to memory limitations.

  A C1MultiDocument provides an Items collection that can contain elements of type
  C1MultiDocumentItem. Each such element represents a single C1PrintDocument. When combined within a
  C1MultiDocument, all these documents are rendered as a whole with continuous page numbering, and
  can have common TOC, word index and inter-document hyperlinks. To reduce memory consumption,
  individual documents within a multi-document are compressed and can optionally use temporary disk
  storage. This allows to handle very large multi-documents that would cause out of memory
  exceptions if all pages belonged to a single C1PrintDocument. The following snippet of code
  illustrates how a multi-document might be created and previewed:

    C1MultiDocument mdoc = new C1MultiDocument();
    mdoc.Items.Add(C1PrintDocument.FromFile("myDoc1.c1dx"));
    mdoc.Items.Add(C1PrintDocument.FromFile("myDoc2.c1dx"));
    mdoc.Items.Add(C1PrintDocument.FromFile("myDoc3.c1dx"));
    C1PrintPreviewDialog pview = new C1PrintPreviewDialog();
    pview.Document = mdoc;
    pview.ShowDialog();

  As mentioned above, a C1MultiDocument supports links between contained documents, common TOC and
  word index, continuous page numeration and total page count.

  Note that a C1MultiDocument does NOT store references to the C1PrintDocument objects added to it -
  rather, it serializes them (as c1d/x) and stores the result (in memory or optionally on disk).
  Thus, you can create really large multi-documents without running out of memory - provided, of
  course, that your code itself does not keep references to the individual C1PrintDocument objects
  that were added to the C1MultiDocument. So when building a large multi-document please make sure
  that you do not keep reference to an individual document object once you have added it to the
  multi-document.

  C1MultiDocument can be persisted as "C1 Open XML Multi Document" with default extension .c1mdx.

  C1MultiDocument can be exported to most formats using any of the Export(...) method overloads.

  C1MultiDocument can be printed using any of the Print(...) and PrintDialog(...) methods overloads.

  IMPORTANT NOTE: our tests showed that on some systems (in our case, it was a Vista x64 system), it
  was necessary to explicitly call GC.Collect() and GC.WaitForPendingFinalizers() when a large
  C1MultiDocument was generated to avoid running out of memory. So far this looks to us like an OS-
  specific .NET bug. The following code snippet illustrates a workaround that should be safe to
  implement when working with large multi-documents on any system:

    // create a C1MultiDocument:
    C1MultiDocument mdoc = new C1MultiDocument();
    // the following event handler ensures that memory is released
    // after each document contained within the multi-document has generated:
    mdoc.ItemGenerated += (o, ee) =>
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
    };
    // fill the multi-document with some data:
    for (int i = 0; i < 100; ++i)
    {
      C1PrintDocument doc = new C1PrintDocument();
      // fill "doc" with data here...
      ...
      // and add it to multi-doc:
      mdoc.Items.Add(doc);
      // the following code ensures that memory occupied by the C1PrintDocument
      // that was just added is released:
      doc = null;
      GC.Collect();
      GC.WaitForPendingFinalizers();
    }

* .NET 4.0 version only: export to XPS (XML Paper Specification) is now supported in WinForms build
  (C1MultiDocument is not yet supported).

* The following methods were added to C1Report to improve handling of large reports:

  public IEnumerable<Metafile> GetPageImages();
    Enumerates page images (represented by metafiles) of the generated report. Using this method in
    a "foreach" loop allows to iterate over all pages of a large report without exhausting system
    resources. This approach is preferable to PageImages property that creates images for all pages
    and can consume a large amount of resources.
    returns: An IEnumerable that allows to iterate over the page images.

  public Metafile GetPageImage(int pageIndex);
    Gets a metafile representing the specified page.
    pageIndex: 0-based page index.
    returns: The metafile representing the page.

  public int GetPageCount();
    Gets the total number of pages in the generated report.
    returns: The total page count.

  The C1Report.PageImages property has been marked as obsolete as using the new methods described
  above is preferable.

* New public property added on C1PrintDocument:

  public PageNumberingChange PageNumberingChange {get;set;}
    Gets or sets the PageNumberingChange object applied to the first page of the document.

* Added support for the latest RTF implementation from Microsoft if that is available on the system:
  rtf window class: RICHEDIT60W, provided by riched20.dll shipped with MS Office 2007.

Bug fixes
---------

* Fixed: wrong page size when exporting Custom Paper Size report sample to RTF  (in part this is a
  limitation of the RTF format). [14141]

* Fixed: incorrect export to PDF if C1Report.EmfType is EmfPlusOnly. [14148]

* Fixed: export of large C1Report to PDF via RenderToFile could fail due to not enough resources.
  [13939]

* Fixed: overlapping of Japanese characters would sometimes occur when exporting a C1Report to PDF.
  [12868]

* Fixed: exception in HTML export with "preserve pagination" and "create canvases" turned off.
  [12868]

* Fixed: progress not shown when exporting a document via ProgressForm. [14053]

* Fixed: incorrect export of external links specified via LinkTarget in report fields to PDF.
  [14049]

================================================================================
Build 2/4.6.20103.54206, 16-Dec-2010
================================================================================

Bug fixes
---------

* C1Report: fixed incorrect rendering of Asian text with text direction up. [13185]

* C1PrintDocument: fixed blurred rendering of RenderBarCode.
  NOTE: C1PrintDocument.EmfType MUST BE SET to EmfOnly for pixel-perfect rendering of bar codes.
  This is a limitation that will be removed in one of future releases. [13458]

================================================================================
Build 2/4.6.20103.54205, 10-Dec-2010
================================================================================

New features
------------

* New public static property added to C1.C1Preview.C1PrintOptions class:
    C1PrintOptions.MsPrintDocumentPrintEmfType {get;set;}
      Gets or sets the type of metafiles used when printing standard .NET PrintDocument documents.
      The default is EmfType.EmfPlusDual.
      If your printer needs to scan the output for data (e.g. a fax number; a case in point is Tobit
      Faxware) and fails, try setting this to EmfType.EmfOnly.
      Note that this property ONLY affects printing of standard .NET PrintDocument documents, and
      has no bearing on other supported document types.

Bug fixes
---------

* Wrong "Source Tray" value (always "Upper") was used by default with printers that have different
  default (e.g. "Auto"). [13215]

* C1Report: in some cases report generation would froze if they contained a subreport with CanGrow
  set to false. [13440]

* C1Report: Code128 barcode was generated with a low resolution and could not be scanned. [13458]

* C1Report: when RecordsPerPage was set, a blank page was sometimes added to the end of the
  generated report. [12879]

* C1Report: Field text aligned incorrectly if TextDirection was not Normal. [13185]

* C1Report: unexpected page break could be added after a report header if it contained a subreport.
  [13183]

================================================================================
Build 2/4.6.20103.54202, 21-Oct-2010
================================================================================

Bug fixes
---------

* Internal changes to accommodate parameter input in ASP.NET report viewer.

* C1RdlReport: removed ReportParameters property from design time.

* Added public methods to add items to C1.C1Rdl.Rdl2008.Values collection.

* Fixed conversion of margins when default document units are pixels. [13071]

* Test for user interactive environment when entering RDL report parameters.

================================================================================
Build 2/4.6.20103.54201, 14-Oct-2010
================================================================================

Bug fixes
---------

* Fixed: after exporting, custom user defined strings stored in the document's
  DocumentInfo.UserData were lost. [12295]

* Fixed: exception occurred when a C1PrintDocument was exported to RTF, DOCX,
  RTF, XLSX, XLS or HTML formats with both "preserve pagination" and "create
  drawing canvases" options turned off. [12868]

* Fixed: extra line appeared when RenderText objects were exported to DOCX with
  "preserve pagination" set to true. [11556]

* Fixed: in export of C1Report to RTF, DOCX, XLS and XLSX formats, hyperlinks
  were rendered with incorrect foreground color if ColorizeHyperlinks on the
  report was true. [13031]

* Fixed: in PDF export, added support for background colors with alpha channel
  (semi-transparent colors). [12996]

New features
------------

* C1RdlReport: support for input of report parameters added (see
  C1RdlReport.ShowParametersInputDialog).

================================================================================
Build 2/4.6.20103.54200, 04-Oct-2010
================================================================================

* First 2010 v3 build.

New features
------------

* New component added: C1.C1Rdl.Rdl2008.C1RdlReport
  Represents an RDL (Report Definition Language) report defined using the 2008
  version of the RDL specification. See documentation for details.

  IMPORTANT NOTE for .NET 2.0/3.0 version users: C1.C1Report.2 assembly uses the
  following dll that is only included in .NET Framework 3.5 and later:

  - System.Windows.Forms.DataVisualization.dll

  That assembly is installed on your system with other C1Reports assemblies when
  you install C1Reports for .NET 2.0. It MUST BE INCLUDED with other C1Reports
  assemblies when you deploy your app that uses C1Reports to other systems.
  Also, if you update C1Reports dlls manually - you MUST put DataVisualization
  where those assemblies are, and make sure that your project references it.
  (This does not apply to .NET 4.0 users as DataVisualization is already
  included in the Framework.)

  Major advantages provided by C1RdlReport are:
  - Support for the current RDL 2008 specification;
  - Programmatic access to the RDL object model (which follows the 2008 RDL
    specification) - this allows to modify existing or even create new RDL
    reports completely in code;
  - Generation of RDL reports that can consume any data source (such as .mdb
    files);
  - A self-contained RDL reporting solution without external dependencies such
    as the need to access a MSRS server;
  - Seamless integration with C1PrintPreviewControl, and with other C1Reports
    reporting engines - C1Report and C1PrintDocument.

  This release of C1RdlReport has the following limitations:
  - Gauge objects are not supported.
  The following RDL properties are not supported:
  - Document.AutoRefresh
  - Document.Width
  - Document.Language
  - Document.DataTransform
  - Document.DataSchema
  - Document.DataElementName
  - Document.DataElementStyle
  - DataSet.CaseSensitivity
  - DataSet.Collation
  - DataSet.AccentSensitivity
  - DataSet.KanatypeSensitivity
  - DataSet.WidthSensitivity
  - DataSet.InterpretSubtotalsAsDetails
  - TextBox.UserSort
  - TextBox.ListStyle
  - TextBox.ListLevel
  - TextRun.ToolTip
  - TextRun.MarkupType

  RDL import in C1PrintDocument (provided by ImportRdl and FromRdl methods) is
  now obsolete. C1RdlReport should be used instead.

* For .NET 4.0 version only: a pre-built version of
  C1.C1Report.CustomFields.4.dll is now included in the release. It no longer
  directly references a specific version of the C1Chart assembly (it is used via
  reflection), so C1.Win.C1Chart.4.dll can be updated without recompiling
  CustomFields. See readme.txt in the CustomFields sample (available from
  ComponentOne web site) for details.

* Azure platform support added.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
The End.
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
