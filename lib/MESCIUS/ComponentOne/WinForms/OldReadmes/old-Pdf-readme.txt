/////////////////////////////////////////////////////////////////////////////////////////
//
// Readme file for ComponentOne C1Pdf
//
// C1.C1Pdf.dll
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

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20143.3			Build Date: Oct 02, 2014
========================================================================================= 

Corrections
------------
 * Fixed in other place [Pdf][Regression] Font size is larger and text are cut off when
   html file is exported to C1Pdf.
   (TFS 89418)
   reason place: HtmlRenderer.cs, GetImage method
   correction place: PdfDocument.cs, DrawStringHtml method

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20142.278			Build Date: Sep 19, 2014
========================================================================================= 

Corrections
------------
 * Fixed [41027] issues on exporting Arabic text to pdf (Case 1 is known limitation, but
   partly fixed. Case 2 is fixed.)
   (TFS 62893)
   place: PdfFont.cs, PdfDocumentBase.cs, FontSubSetArabic.cs, FontSubSet.cs 

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20142.277			Build Date: Aug 14, 2014
========================================================================================= 

Corrections
------------
 * Fixed part 2 (Greek locale problem) [45781-139] Emf images do not render correctly in
   pdf file created using C1Pdf.
   (TFS 77181)
   place: MetafileConverterBase.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20142.276			Build Date: Aug 07, 2014
========================================================================================= 

Corrections
------------
 * Fixed [Forum] Bookmark in a Pdf file generated using C1Pdf does not appear expanded
   in specific scenerios.
   Reason in incorrect calculation child count for last outline.
   (TFS 51468)
   place: PdfBookmark.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20142.273			Build Date: Aug 06, 2014
========================================================================================= 

Corrections
------------
 * Fixed [C1Report][Regression] Text extends outside the field when exported to Pdf with
   system fonts.
   Not regression. Reason in wariour width for fixed width fonts.
   (TFS 78659)
   place: PdfFont.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20142.272			Build Date: Aug 01, 2014
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Added new property (for text output as v1) for performance issue (TFS:69683):

        /// <summary>
        /// Gets or sets whether use fast or slow text output, by default using slow text output, but more exactly.
        /// </summary>
        /// <remarks>At fast text output not using slow (but more exact) Windows API MeasureText method.</remarks>
        public bool UseFastTextOut

Corrections
------------
 * Fixed [45781-139] Emf images do not render correctly in pdf file created using C1Pdf.
   Reason in not supported EmfSmallTextOut.
   (TFS 77181)
   place: MetafileConverterBase.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20142.271			Build Date: Jul 29, 2014
========================================================================================= 

Corrections
------------
 * Fixed subscript characters become overlapped in pdf export when render together with EUDC
   characters.
   Reason in calculation kern values.
   (TFS 39593)
   place: PdfDocument.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20142.270			Build Date: Jul 22, 2014
========================================================================================= 

Corrections
------------
 * Text are printed by exceeding the margin while long string contained rectangles are
   exported to pdf.
   Reason in text clipping.
   (TFS 62913)
   place: MetafileConverterBase.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20142.269			Build Date: Jun 27, 2014
========================================================================================= 

Corrections
------------
 * C1Report [Regression] Hebrew Text are overlapped and cut off while exporting to .pdf.
   Reason in fix 62913.
   (TFS 71313)
   place: MetafileConverterBase.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20142.268			Build Date: Jun 23, 2014
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * V2/2014 build

Corrections
------------
 * C1Report][41193] Everytime PDF file generated from C1Report, it reproduces a different
   technical PDF description file.
   (TFS 69950)
   place: PdfImage.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20141.267			Build Date: Jun 06, 2014
========================================================================================= 

Corrections
------------
 * [Regression] Button image is extremely small if FieldBorderWidth is Thick/Medium.
   Reason in fixes TFS:28420 and TFS:35436 (calculate image scale).
   (TFS 67949)
   place: PdfAcroform.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20141.266			Build Date: Jun 06, 2014
========================================================================================= 

Corrections
------------
 * Partly fixed text are printed by exceeding the margin while long string contained
   rectangles are exported to pdf.
   Only EMF-ONLY issue.
   (TFS 62913)
   place: MetafileConverterBase.cs

 * Partly fixed image generated from PrintDocument with ScaleTransformation is rendered
   incorrectly.
   Only EMF-PLUS: reset clipping at drawing string at using position.
   (TFS 65120)
   place: MetafileConverterBase.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20141.265			Build Date: May 22, 2014
========================================================================================= 

Corrections
------------
 * Fixed unlike previous build, sentences are overlap each other when setting
   'ParseEmfPlus' is set True and 'DrawImage' method is usedreport.
   Reason in incorrect convert coordinates to pixel from page unit.
   (TFS 67637)
   place: MetafileConverterBase.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20141.264			Build Date: May 20, 2014
========================================================================================= 

Corrections
------------
 * Small changes of EMF+ export from metafiles.
   place: MetafileConverterBase.cs, PdfMetafileConverter.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20141.263			Build Date: May 19, 2014
========================================================================================= 

Corrections
------------
 * Partly fixed [C1PDF] Image generated from PrintDocument with ScaleTransformation is
   rendered incorrectly.
   Reason in EMF(ONLY) mode not found as to support such transformation, but in EMF+ mode
   added support of such transformation.
   (TFS 65120)
   place: MetafileConverterBase.cs, PdfMetafileConverter.cs, PdfDocumentBase.cs,
          PdfDocument.cs 

 * Fixed [40766][C1ReportDesigner] Overlapping text in the exported PDF from a report
   with subReports.
   Reason in very small width or height of the text bounds.
   (TFS 61462)
   place: MetafileConverterBase.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20141.262			Build Date: Apr 09, 2014
========================================================================================= 

Corrections
------------
 * [Regression]Different behaviors observed for ButtonLayout.ImageOnly enum value of
   PdfPushButton in build 240.
   Reason in fix TFS:28420 (remove 'borderWidth' from calculate image scale).
   (TFS 35436)
   place: PdfAcroform.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20141.261			Build Date: Apr 08, 2014
========================================================================================= 

Corrections
------------
 * [Win8.1] OutOfMemoryException raised on creating PDF file although
   UseFileCaching = True.
   Added 'using' for bitmap objects. Not shown at me, but perhaps fixed.
   (TFS 63448)
   place: PdfDocument.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20141.260			Build Date: Mar 31, 2014
========================================================================================= 

Corrections
------------
 * [C1PrintDocument] All images are replaced with first image when
   C1PrintDocument containing multiple RenderIamge objects is exported
   Reason in incorrect image compare.
   (TFS 57247)
   place: PdfImageDIB.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20141.259			Build Date: Mar 24, 2014
========================================================================================= 

Corrections
------------
 * [Jpn] English text render outside the rectangle box when meta file is exported on
   Japanese environment.
   Reason in changes of TFS:52196 issue.
   (TFS 61357)
   place: PdfFont.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20141.258			Build Date: Mar 14, 2014
========================================================================================= 

Corrections
------------
 * Japanese text is garbled when viewing the pdf file genereated using C1Pdf on a
   different machine.
   Reason in changes of TFS:34255 issue.
   (TFS 52196)
   place: PdfFont.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20141.257			Build Date: Feb 22, 2014
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
- Added "Studio for Desktop" and "Studio for Web" product information

Corrections
------------
 * Small changes for cannot find/create ëAharonií message box is shown when creating
   fonts pdf file.
   (TFS 50511)
   place: PdfFont.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20141.255			Build Date: Jan 30, 2014
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * V1/2014 build

Corrections
------------
 * Fixed if 'CanGrow/CanShrink'=True fileds containing report is exporting to
   .xls/.xlsx, it throws ObjectReference exception.
   (TFS 50322)
   place: FontSubSetArabic.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20133.254			Build Date: Nov 06, 2013
========================================================================================= 

Corrections
------------
 * Fixed Explicit Directional Embedding characters incorporated in a Field's 'Text'
   property are not exported to Pdf correctly.
   (TFS 43395 part 2)
   place: PdfFont.cs, FontSubSetArabic.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20133.253			Build Date: Oct 25, 2013
========================================================================================= 

Corrections
------------
 * Fixed 'DrawImage()' method takes lot of time to render an image to a PDF file.
   Reason in call Win32.GetCharWidth32 method for many symbols (more 255).
   (TFS 42031)
   place: PdfFont.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20133.252			Build Date: Oct 15, 2013
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
* V3/2013 build

Corrections
------------
 * Fixed regression (unlike previous build) issue: 'Parameter is not valid.' exception is
   occur when generate pdf.
   (TFS 43304)
   place: PdfDocument.cs, MetafileConverterBase.cs

 * Fixed incorrect Line break is observed with Japanese Text on using DrawString method
   (part of break asian symbols).
   (TFS 42975)
   place: PdfDocument.cs

 * Fixed Explicit Directional Embedding characters incorporated in a Field's 'Text'
   property are not exported to Pdf correctly.
   (TFS 43395)
   place: PdfFont.cs

  * Fixed vertical alignment becomes misaligned on exporting the report to PDF.
   (TFS 43394)
   place: PdfDocument.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20132.251			Build Date: Oct 09, 2013
========================================================================================= 

Corrections
------------
 * Fixed double byte characters get clipped from the right & calling Dispose() method
   does not release memory.
   (TFS 42925)
   place: PdfDocument.cs, MetafileConverterBase.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20132.250			Build Date: Oct 08, 2013
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Support transformation of coordinates and sises at EMF Plus metafile export.

Corrections
------------
 * Fixed incorrect Line break is observed with Japanese Text on using DrawString method.
   (TFS 42975)
   place: PdfDocument.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20132.249			Build Date: Aug 20, 2013
========================================================================================= 

Corrections
------------
 * Fixed index out of bounds of Array exception occurs while exporting Report to PDF file
   (TFS 36976)
   place: PdfBookmark.cs

 * Fixed single-byte spaces after external characters (EUDC) get displayed as "." in
   the output PDF.  (TFS 39657)
   place: PdfFont.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20132.248			Build Date: Aug 19, 2013
========================================================================================= 

Corrections
------------
 * Fixed clipped text from emf image is rendered as full text in created pdf file
   (TFS 40935)
   place: MetafileConverterBase.cs

 * Fixed hidden text is appeared in drawing MetaFile image which EmfType is ëEmfPlusDualí
   or ëEmfPlusOnlyí (TFS 10808)
   place: PdfDocumentBase.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20132.247			Build Date: Aug 11, 2013
========================================================================================= 

Corrections
------------
 * Fixed text gets overlapped with Border when 'UseGdiPlusTextRendering' is set to True.
   (TFS 40253)
   place: MetafileConverterBase.cs

 * Fixed clipping problem of text at use sample:
   $/C1GanttView.Net/Research/OverlayingRenderObjects. (TFS 40584)
   place: PdfDocumentBase.cs

 * Height of GroupFooter section changes to its default value on exporting to Pdf.
   (TFS 40628)
   place: PdfDocument.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20132.246			Build Date: Jul 11, 2013
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Korean localization added.

Corrections
------------
 * Fixed some of the graphics are not included in exported pdf file. (TFS 38178)
   place: PdfMetafileConverter.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20132.245			Build Date: Jun 14, 2013
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
* About information for GrapeCity (Japan) version.

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20132.244			Build Date: Jun 14, 2013
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
* V2/2013 build

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.243			Build Date: Jun 14, 2013
========================================================================================= 

Corrections
------------
 * Fixed clipping of text does not work. (TFS 34659)
   place: PdfMetafileConverter.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.242			Build Date: May 28, 2013
========================================================================================= 

Corrections
------------
 * Fixed images are missing when user previewed specific c1dx file and exported to PDF
   File.  (TFS 36083)
   place: MetafileConverterBase.cs and PdfMetafileConverter.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.241			Build Date: March 28, 2013
========================================================================================= 

Corrections
------------
 * Fixed partly of ëNullReferenceExceptioní is occured for  certain EMF file when
   'DrawImage' method is used and ëParseEmfPlusí property is set to 'True'. (TFS 33425)
   place: MetafileConverterBase.cs/EmfPlusDrawDriverString

 * Fixed part 7 (regression) of unlike MS control and previous build, the string drawn
   using 'DrawString' method does not get wrapped. (TFS 34518)
   place: PdfDocument.cs/BreakLines


=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.240			Build Date: March 28, 2013
========================================================================================= 

Corrections
------------
 * Fixed part 2 of unlike previous build, System.ArgumentOutOfRangeException occured when
   DrawString method is called. (TFS 34892)
   place: PdfDocument.cs/BreakLines

 * Fixed part 6 of unlike MS control and previous build, the string drawn using
   'DrawString' method does not get wrapped. (TFS 34518)
   place: PdfDocument.cs/BreakLines

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.239			Build Date: March 25, 2013
========================================================================================= 

Corrections
------------
 * Fixed unlike previous build, System.ArgumentOutOfRangeException occured when
   DrawString method is called. (TFS 34892)
   place: PdfDocument.cs/BreakLines

 * Fixed part 5 of unlike MS control and previous build, the string drawn using
   'DrawString' method does not get wrapped. (TFS 34518)
   place: PdfDocument.cs/BreakLines

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.238			Build Date: March 13, 2013
========================================================================================= 

Corrections
------------
 * Fixed part 4 of unlike MS control and previous build, the string drawn using
   'DrawString' method does not get wrapped. (TFS 34518)
   place: PdfDocument.cs/BreakLines


=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.237			Build Date: March 11, 2013
========================================================================================= 

Corrections
------------
 * Fixed part 3 of unlike MS control and previous build, the string drawn using
   'DrawString' method does not get wrapped. (TFS 34518)
   place: PdfDocument.cs/BreakLines

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.236			Build Date: March 07, 2013
========================================================================================= 

Corrections
------------
 * Fixed part 2 of unlike MS control and previous build, the string drawn using
   'DrawString' method does not get wrapped. (TFS 34518)
   place: PdfDocument.cs/BreakLines

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.235			Build Date: March 01, 2013
========================================================================================= 

Corrections
------------
 * Fixed unlike MS control and previous build, the string drawn using 'DrawString' method
   does not get wrapped. (TFS 34518)
   place: PdfDocument.cs/BreakLines

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.234			Build Date: February 26, 2013
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
  * Small changes in PDF boomarks for support Multidocument outlines of C1Reporter.

Corrections
------------
 * Fixed Japanese string gets wrapped after some characters in created pdf file.
   (TFS 34354)
   place: PdfDocument.cs/IsBreakPoint

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.233			Build Date: February 25, 2013
========================================================================================= 

Corrections
------------
 * Fixed par two of the string drawn using DrawString method gets wrapped at null or
   punctuation while being displayed. (TFS 34170)
   place: PdfDocument.cs/IsBreakPoint

 * Fixed space added after "(" and ")" overlapped with text when C1PDF draw meta image.
   (TFS 34255)
   place: PdfFont.cs (some places)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.232			Build Date: February 20, 2013
========================================================================================= 

Corrections
------------
 * Fixed the string drawn using DrawString method gets wrapped at null or punctuation
   while being displayed. (TFS 34170)
   place: PdfDocument.cs/IsBreakPoint

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.231			Build Date: February 18, 2013
========================================================================================= 

Corrections
------------
 * Fixed part two of issue: unlike previous build, some Hebrew fonts are not correctly
   shown in pdf. (TFS 33105)
   place: PdfDocumentBase.cs/TextToBytes

 * Fixed upper part of the number from emf file are clipped in created pdf file when
   using DrawImage method. (TFS 34057)
   place: MetafileConverterBase.cs/EmfExtTextOut

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.230			Build Date: February 11, 2013
========================================================================================= 

Corrections
------------
 * Fixed unlike previous build, Extra bullet is added in created pdf file when using
  'PageAsMetafile' and 'DrawImage' to draw Meta File in PDF. (TFS 33421)
   place: PdfFont.cs/SplitByMetrics

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.229			Build Date: February 11, 2013
========================================================================================= 

Corrections
------------
 * Fixed string color is spreaded all over the japanese characters and become unreadable
   if ëDrawStringí method is used with Font ëArialí , ëPointFí and ëStringAlignmentí
   parameters. (TFS 33911)
   place: PdfDocumentBase.cs/TextOut

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.228			Build Date: February 07, 2013
========================================================================================= 

Corrections
------------
 * Fixed when setting the rendering limit by DrawString method, there is a difference in
   wrapping position of the single byte and double byte character. (TFS 33835)
   place: PdfDocument.cs/CheckNeedBreak

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.227			Build Date: February 07, 2013
========================================================================================= 

Corrections
------------
 * Fixed of regression issue: 'ArgumentOutOfRangeException' is occurred on using
   ëDrawStringí  and ëDrawStringHtmlí method. (TFS 30856)
   place: PdfFont.cs and FontSubSet.cs

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.226			Build Date: February 06, 2013
========================================================================================= 

Corrections
------------
 * Fixed unlike previous build, 'ArgumentOutOfRangeException' is occurred on using
   ëDrawStringí  and ëDrawStringHtmlí method with certain font. (TFS 30856)
   place: PdfDocumentBase.cs/SetAlternativeFont

 * Fixed part 2 of regression issue: text are not correctly shown. (TFS 33659)
   place: PdfFont.cs/SplitByMetrics

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.225			Build Date: February 05, 2013
========================================================================================= 

Corrections
------------
 * Fixed regression issue: text are not correctly shown. (TFS 33659)
   place: PdfDocumentBase.cs/SetFont

 * Fixed pdf part of unlike previous build, some text of the column are not shown in PDF
   export if printer is not installed. (TFS 33530)
   place: MetafileConverterBase.cs/EmfExtTextOut

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.224			Build Date: January 30, 2013
========================================================================================= 

Corrections
------------
 * Fixed regression issue: When ëDrawStringHtmlí method is combined with 'DrawStringRtf'
   method, special characters are displayed as garbled character.  (TFS 33484)
   place: PdfDocumentBase.cs/SetFont

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20131.223			Build Date: January 29, 2013
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
* V1/2013 build

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20123.222			Build Date: January 23, 2013
========================================================================================= 

Corrections
------------
 * Probably fixed three part of regression issue: 'ArgumentOutOfRangeException' is
   occurred on using ëDrawStringí  and ëDrawStringHtmlí method. (TFS 30856)
   place: PdfFont.cs

 * Fixed regression issue: sentence cut off if FormatFlags is set as DirectionVertical.
   (TFS 33173)
   place: PdfDocument.cs/DrawString

 * Fixed ìNull Reference exceptionî is occurred if the C1PdfDocument use ëPDFTextNoteí
   and set ëFontTypeEnum.Standardí. (TFS 33200)
   place: PdfAnnotations.cs/DrawText

 * Fixed (partly) Hebrew and Arabic text are incorrectly displayed when using
   DrawStringRtf method. (TFS 33225)
   place: PdfAnnotations.cs/DrawText

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20123.221			Build Date: January 19, 2013
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Optimization (fixing bugs) work with pie/arc and pens.
 * Added property ParseEmfPlus as flag to convert EMF PLUS metafiles to EMF ONLY
   metafiles or no.

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20123.220			Build Date: January 14, 2013
========================================================================================= 

Corrections
------------
 * Fixed the characters in second field are moved downwards by a few pixels in pdf export
   if one of the fields contain low characters. (TFS 33129)
   place: PdfMetafileConverter.cs/EmfExtTextOut

 * Fixed three part of regression issue: 'ArgumentOutOfRangeException' is occurred on
   using ëDrawStringí and ëDrawStringHtmlí method (only for Japan). (TFS 30856)
   place: PdfFont.cs/CreateFontHandle
 
=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20123.219			Build Date: January 07, 2013
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Full optimization of memory at using embedded fonts (many changes).

Corrections
------------
 * Fixed regression Japanese characters (Katagana, Kanji) are overlapped in PdfTextNote
   if the line break or tab contains at the end or start of text. (TFS 10839)
   place: FontSubSet.cs/IsCharSupported

 * Fixed two part of regression issue: 'ArgumentOutOfRangeException' is occurred on using
   ëDrawStringí  and ëDrawStringHtmlí method. (TFS 30856)
 
=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20123.218			Build Date: December 20, 2012
========================================================================================= 

Corrections
------------
 * Fixed regression Japanese text are not displayed in PdfTextNote. (TFS 9606)
   place: PdfDocumentBase.cs/Save

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20123.216			Build Date: December 7, 2012
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Optimization of memory at using embedded fonts.
 * Add Japanese comment for RotateAngle method for Japanese drop.

Corrections
------------
 * Fixed if Japanese text is rendered using 'DrawString' method in which 'MeasureString'
   method specifies the string size, the last character of string gets truncated. (TFS 30646)
   place: PdfDocument.cs/MeasureString

 * Fixed text in EMF image is overlapped in exported Pdf file. (TFS 30280)
   place: PdfDocument.cs/TextOut

 * Fixed InvalidOperationException is thrown when export to pdf using RenderToFile method
   in multithread appllication. (TFS 29892)
   place: PdfDocumentBase.cs/_gs

 * Fixed unlike previous build and C1PrintPreviewControl, Japanese text present in
   RenderVerticalText are not fully displayed when export to PDF. (TFS 30218)
   place: PdfMetafileConvertor.cs/EmfExtTextOut

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20123.214			Build Date: October 26, 2012
========================================================================================= 

Corrections
------------
 * Fixed Japanese character displayed as unknown if ëDrawStringí Method is used with
   ëPointFí. (TFS 28092)
   place: FontSubSetBase.cs/ReadDirectory

 * Fixed exception if Japanese string is added in TextField of C1ReportDesigner, Error
   occurs when preview the report. (TFS 28099)
   place: FontSubSetBase.cs/ReadDirectory

 * Fixed PDF file gets garbled in the Windows8 environment. (TFS 28866)
   place: FontSubSetBase.cs/ReadDirectory

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20123.213			Build Date: October 18, 2012
========================================================================================= 

Corrections
------------
 * Fixed once Security.Encryption property is set to 'NotPermit', can't change to another
   property value. (TFS 28270)
   place: PdfSecurity.cs/Encryption

 * Fixed image of ëPdfPushButtoní class is reversed if its ëBorderWidthí property is set
   to ëThickí or ëMediumí. (TFS 28128)
   place: PdfAcroform.cs/GetTextData

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20123.212			Build Date: October 16, 2012
========================================================================================= 

Corrections
------------
 * Fixed the number in the Arabic text is not correctly displayed in exported pdf file.
   (TFS 28715)
   place: FontSubSetArabic.cs/Shaping

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20122.211			Build Date: September 27, 2012
========================================================================================= 

Corrections
------------
 * Fixed regression issue: text got clipped if DrawString method with RectangleF is used
   together with RotateAngle. (TFS 15838)
   place: PdfDocument.cs/DrawString

 * Fixed regression issue: vertical text in a metafile image is not displayed correctly.
   (TFS 14216)
   place: PdfMetafileConverter.cs/EmfExtTextOut

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20122.210			Build Date: August 27, 2012
========================================================================================= 

Corrections
------------
 * Fixed some of the text is revered in exported pdf file if Hebrew letters and digits
   are mixed together. (TFS 27339)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20122.209			Build Date: August 20, 2012
========================================================================================= 

Corrections
------------
 * Fixed PdfRadioButtons are editable when setting ëCheckMarkTypeí except Default and
   Circle although 'AllowEditContent' property set to 'false'. (TFS 10738)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20122.208			Build Date: August 14, 2012
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
- Added Metro-style icons.

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20122.206			Build Date: August 4, 2012
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
- Added support for bi-directional text (right-to-left) in the DrawStringHtml method.

	Right-to-left text is commonly used to render Arabic and Hebrew text.

	To enable right-to-left, add a "direction:rtl" attribute to the css styles
	(or add a "dir=rtl" attribute to the html tags).

	To support Arabic and Hebrew text, set the FontType property to Embedded:

		pdf.FontType = C1.C1Pdf.FontTypeEnum.Embedded;

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20122.205			Build Date: Jul 09, 2012
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Licensing code changes. (V2/2012).

Corrections
------------
 * Fixed third party font used to render Report is incorrectly exported to PDF file.
   (TFS 22742)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20122.204			Build Date: Jun 14, 2012
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
* V2/2012 build

Corrections
-------------
 * Small fixed part 2 Hebrew text are not rendering properly in exported PDF file.
   (TFS 22742)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20121.203			Build Date: Jun 08, 2012
========================================================================================= 

Corrections
-------------
 * Fixed vertical strings are displayed as horizontal text on exporting to PDF
   (Japanesse) part 2 (for Japanese version). (TFS 20985)

 * Fixed part 2 Hebrew text are not rendering properly in exported PDF file. (TFS 22742)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20121.202			Build Date: May 25, 2012
========================================================================================= 

Corrections
-------------
 * Partly fixed on rendering and exporting an EMF image containing images applied with
   180∞rotation, the image is not displayed correctly. (TFS 21437)

 * Fixed Hebrew text are not rendering properly in exported PDF file. (TFS 22742)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20121.201			Build Date: May 11, 2012
========================================================================================= 

Corrections
-------------
 * Fixed bugs of previous version (200). Please to use of 201 build for test.

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20121.200			Build Date: May 10, 2012
========================================================================================= 

Corrections
-------------
 * Probably fixed right side of the characters in metafile image gets clipped ("System.
   Collections.Generic.KeyNotFoundException" occurs with message "The given key was not
   present in the dictionary." This does not happen with build 198.). (TFS 14852)

 * Fixed incorrect rendering of background rectangle and the text is clipped at the top
   with special fonts. (TFS 21615)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20121.199			Build Date: May 07, 2012
========================================================================================= 

Corrections
-------------
 * Fixed vertical strings are displayed as horizontal text on exporting to PDF
   (Japanesse). (TFS 20985)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20121.198			Build Date: Mar 13, 2012
========================================================================================= 

Corrections
-------------
 * Partly fixed InvalidOperationException occurred on exporting metafile chart using
   DrawImage method. (TFS 20425)

 * Partly fixed blank images are shown on drawing 3DChart of metafile type using
   DrawImage method. (TFS 20428)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20121.197			Build Date: Mar 08, 2012
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added support EMF+ files and DrawPath/FillPath methods for Pdf document.

Corrections
-------------
 * Fixed when exporting of .xml to pdf in C1ReportDesigner, some subscripted letters are
   shift upward. (TFS 19366)

 * Fixed Emf images are not rendered correctly in pdf files when used in DrawImage()
   method. (TFS 18003)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20121.196			Build Date: Jan 25, 2012
========================================================================================= 

Corrections
-------------
 * Fixed rendering of broken local HTML links (TFS 18716)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20121.195			Build Date: Jan 11, 2012
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2012 build

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20113.194			Build Date: Dec 29, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes
------------------------------------------- 
* Added support for page breaks in DrawStringHtml method ()
  Page breaks are specified in HTML using the 'page-break-before' and 'page-break-after' 
  css attributes.

  For example:

	var html =  "<p>Here is some text on page 1.</p>" +
				"<p style='page-break-after: always' >Still on page 1.</p>" +
				"<p>After page break, this is the top of page 2.</p>";

	var pdf = new C1PdfDocument();
	var rcPage = pdf.PageRectangle;		// get page rectangle
	rcPage.Inflate(-72, -72);			// add one-inch margins
	for (int offset = 0; offset < int.MaxValue; )
	{
		if (offset > 0) pdf.NewPage();
		offset = pdf.DrawStringHtml(html, Font, Brushes.Black, rcPage, offset);
	}
	pdf.Save(fileName);



Corrections
-------------
 * Fixed nothing rendered in Pdf file if FillPie/DrawArc method is used  and error
   message is raised on printing. (TFS: 19083)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20113.193			Build Date: Dec 25, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes
------------------------------------------- 
 * Changed of PieArc method. In previous version incorrect arc/pie angles.
 * Changed RGN_AND clipping. In previous version new region AND empty equal empty, now
   equal new region.

Corrections
-------------
 * Fixed not shown text in pdf result from metafile (C1Report with a superlabel contains
   some HTML code). (TFS: 19009)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20113.192			Build Date: Dec 17, 2011
========================================================================================= 

Corrections
-------------
 * Fixed problem exporting links to empty anchors (<a href='#'>). For some strange 
   reason, this prevented the Acrobat Reader from printing the document. (TFS 18716)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20113.191			Build Date: Dec 07, 2011
========================================================================================= 

Corrections
-------------
 * Fixed ArgumentException thrown when Images are exported to pdf in 'CreatePdf' sample 
   (image compression). (TFS: 18671)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20113.190			Build Date: Nov 30, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes
 ------------------------------------------- 
 * Updated licensing with fixes to conform with Federal Information Processing Standards
   requirements.
 * Merge from C1Zip.

Corrections
-------------
 * Fixed InvalidOperationException is observed on building C1Pdf project in an FIPS
   compliant environment. (TFS: 18474)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20113.189			Build Date: Nov 23, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes
 ------------------------------------------- 
 * Updated licensing to conform with Federal Information Processing Standards
   requirements.

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20113.188			Build Date: Oct 25, 2011
========================================================================================= 

Corrections
-------------
  * Fixed Barcode cannot be rendered in exported PDF file when Password security is set
    in ëAES 128 bitÅEEncryption level. (TFS: 17984)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20113.187			Build Date: Oct 21, 2011
========================================================================================= 

Corrections
-------------
 * Fixed the numbers in the Arabic text gets reversed and a little square are added when
   the report is exported to PDF. (TFS: 17563)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20113.186			Build Date: Oct 10, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 

 * Changed embedded font structure, added 'cmap' block for support embedded fonts in
   C1PDFViewer (Silverlight and WPF versions).

Corrections
-------------
 * Fixed TypeInitializationException is thrown on creating PdfDocument in MediumTrust
   website. (TFS: 17684)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20113.185			Build Date: October 4, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Enhanced licensing in environments with some security policy restrictions

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20113.184			Build Date: Sep 27, 2011
========================================================================================= 

Corrections
-------------
 * Fixed error while viewing PDF file (at set AES128 encoding without passwords).
   Reason in new security code at condition when set AES128 encoding but not set
   user and/or owner passwords.

 * Fixed Href links are not clickable in pdf document when created using DrawStringHtml()
   method. (TFS: 17285)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20113.183	Build Date: Sep 27, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added support for exporting hyperlinks in DrawHtmlString.

   For example, the code below generates a PDF file with a hyperlink to the 
   ComponentOne home page:

		// HTML with a hyperlink
		var text = "<a href='www.componentone.com'>Visit ComponentOne!</a>";

		// render it into a PDF file
		var pdf = new C1.C1Pdf.C1PdfDocument();
		var rc = pdf.PageRectangle;
		rc.Inflate(-72, -72);
		pdf.DrawStringHtml(text, this.Font, Brushes.Black, rc);
		var fn = @"c:\temp\out.pdf";
		pdf.Save(fn);
		System.Diagnostics.Process.Start(fn);

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20113.182	Build Date: Sep 08, 2011
========================================================================================= 

Corrections
-------------
 * Fixed secured pdf file cannot be opened by Owner password. (TFS 17100)

 * Fixed vertical text appears outside the defined area when using DrawString method with
   RectangleF parameter. (TFS 16682)

 * Fixed unhandled exception seen when clicking on Fonts ,fonts button in CreatePdf
   Sample. (TFS 10708)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20113.181	Build Date: Sep 05, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added support for 128-bit encryption. Added pdf.Security.Encryption property for setting 
   the encryption type (PdfEncryptionType enum).

   Usage:
            C1.C1Pdf.PdfEncryptionType encryption = C1.C1Pdf.PdfEncryptionType.Standard40;
            if (_radioStandart128.Checked)
			{
                encryption = C1.C1Pdf.PdfEncryptionType.Standard128;
			}
            else if (_radioAes128.Checked)
			{
                encryption = C1.C1Pdf.PdfEncryptionType.Aes128;
			}
            pdf.Security.Encryption = encryption;

  By default the component uses standard 40-bit encryption as previous builds.

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20112.180	Build Date: Aug 18, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Changed optimization of C1Pdf performance code in graphics and bitmap storage.

Corrections
-------------
 * Text gets truncated when the width is less than 100%. (TFS 16789)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20112.179	Build Date: Aug 14, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added deleting temp files for Dispose object of C1PdfDocument (UseFileCaching
   property). UseFileCaching property is necessary using at many pages (500 or above)
   So, it appears that using temp files:
   1) increases generation time by about 10-20%
   2) decreases memory usage by about 50%

 * Changed optimization of C1Pdf performance code in MeasureText method of
   C1PdfDocumentBase.

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20112.178	Build Date: Aug 14, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Changed file caching for support multi threading.

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20112.177	Build Date: Aug 12, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added UseFileCaching property of C1PdfDocument. If UseFileCaching is true (false by
   default) then for pages will use disk space (temp files). It is necessary use at many
   pages in PDF result.

 * Optimization of C1Pdf performance using static graphics and bitmap objects.
   Performance gain is 32-40% at metafile exports.

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20112.176	Build Date: Aug 03, 2011
========================================================================================= 

Corrections
-------------
 * Unlock images rendered with DrawStringHtml (used to lock local files) (TFS 16294)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20112.175	Build Date: Jul 08, 2011
========================================================================================= 

Corrections
-------------
 * Fixed "General error in GDI+" exception in multithreaded application.

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20112.174	Build Date: Jun 27, 2011
========================================================================================= 

Corrections
-------------
 * Fixed rRegression bug: rendered text vanished when ëStringFormatÅEset as
   ëDirectionVerticalÅE (TFS: 15842)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20112.173	Build Date: Jun 22, 2011
========================================================================================= 

 Corrections
-------------
 * Fixed rendered sentence disappeared if RoateAngle is greater than 55. (TFS: 15842)

 * Fixed text got clipped if DrawString method with RectangleF is used together with
   RotateAngle. (TFS: 15838)

 * Fixed RotateAngle is different between strings are drawn using DrawString method with
   PointF and RectangleF parameter although same value is set to ëRotateAngleÅEproperty.
   (TFS: 15686)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20112.172	Build Date: Jun 15, 2011
========================================================================================= 

 Corrections
-------------
 * Fixed entire string not drawn when rotate the text if DrawString method with
   PointF parameter is used. (TFS: 15687)

 * Fixed RotateAngle is different between strings are drawn using DrawString method with
   PointF and RectangleF parameter although same value is set to ëRotateAngleÅEproperty.
   (TFS: 15686)

 * Fixed MS Visual Studio shown warning message on opening the solution file for
   ëPdfTablesÅEsample. (TFS: 14195)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20112.171	Build Date: Jun 07, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added new RotateAngle property of C1PdfDocument. If RotateAngle not equal zero, that
   PDF objects drawing with rotation. Except DrawStringRtf and DrawStringHtml.
   For example:
			    RectangleF rcPage = _c1pdf.PageRectangle;
			    rcPage.Inflate(-72, -72);
			    RectangleF rc = rcPage;
                _c1pdf.RotateAngle = -30;
				Font font = new Font("Tahoma", 14, FontStyle.Bold);
    			_c1pdf.DrawString("Sample text", font, Brushes.Black, rc);
                _c1pdf.RotateAngle = 0;

 Corrections
-------------
 * Fixed request to provide support to rotate text at an angle. (TFS: 15392)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20112.170	Build Date: May 12, 2011
========================================================================================= 

 Corrections
-------------
 * Fixed multiple issues occur when report containing field with ëTextDirection=Up/DownÅE
   is exported (PDF export part). (TFS: 15188)

 * Fixed when EMF file is exported to pdf file, Japanese text is not shown correctly.
  (TFS: 15184)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20111.169	Build Date: April 21, 2011
========================================================================================= 

 Corrections
-------------
 * Fixed vertical text in a metafile image is not displayed correctly. (TFS: 14216)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20111.168	Build Date: April 19, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Changed load font data: now blocking loading instead all loading. For fix of Windows
   XP load font bug.

 Corrections
-------------
 * Fixed new line position changes on setting RectangleF in argument of DrawString
   method. (TFS: 14847)

 * Fixed right side of the characters in metafile image gets clipped. (TFS: 14852)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20111.167	Build Date: March 28, 2011
========================================================================================= 

 Corrections
-------------
 * Fixed exception at using Medium Trust for Website. (TFS: 14589)
   Warning! For support Medium Trust inside common PDF fonts using standard PDF fonts.

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20111.166	Build Date: March 24, 2011
========================================================================================= 

Corrections
-------------
- Improved rendering HTML in over remote connections (TFS 2127)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20111.165	Build Date: March 02, 2011
========================================================================================= 

Corrections
-------------
 * Fixed incorrect direct and kerns problems for some Hebrew text. (TFS: 14524)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20111.164	Build Date: February 25, 2011
========================================================================================= 

Corrections
-------------
 * Fixed Pdf result crash and direct problem for some Hebrew fonts. (TFS: 14524)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20111.163	Build Date: January 28, 2011
========================================================================================= 

Corrections
-------------
 * Fixed pie is not rendered when Gradient Brush is specified to fill Pie. (TFS: 13632)

 * Partly fixed vertical text in a metafile image is not displayed correctly (correct
   position). (TFS: 14216)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20111.161	Build Date: January 10, 2011
========================================================================================= 

Corrections
-------------
 * Fixed overlapping of Japanese text is observed on exporting the report definition file
   having Japanese characters to pdf file format. (TFS: 13045)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20111.160	Build Date: December 27, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added support draw string with various width of the characters:

        public int DrawString(string text, Font font, Brush brush, RectangleF rc, int firstChar, StringFormat sf, float widthCoeff)
        public int DrawString(string text, Font font, Brush brush, PointF pt, StringFormat sf, float widthCoeff)
        public int DrawString(string text, Font font, Brush brush, PointF pt, float widthCoeff)

For example:

_c1pdf1.DrawString("double text", SystemFonts.CaptionFont, SystemBrushes.ControlDark, new PointF(10, 10), 2.0f);

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20111.159	Build Date: December 20, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2011 build

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20103.158	Build Date: December 14, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 

- Improved HTML rendering:
	- better clipping at page breaks.
	- added support for CSS 'line-height' attribute (ignored in previous builds)
	- added support for loading images into <img> tags

- Added support for stream-based attachments
  This build adds two new AddAttachment overloads:

	public void AddAttachment(string attachmentName, byte[] attachmentData, RectangleF rc, int page, AttachmentIconEnum icon, Color iconColor);
	public void AddAttachment(string attachmentName, byte[] attachmentData, RectangleF rc, AttachmentIconEnum icon, Color iconColor);

  These overloads are similar to previous existing ones, except for the 'attachmentData'
  parameter which allows the caller to provide data that is not stored in files (for
  example, the data could be dynamically generated or stored in databases, or streams).


=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20103.155	Build Date: Nov 22, 2010
========================================================================================= 

 * Fixed last characters of Japanese string are getting truncated when using 'DrawString'
   method. (TFS: 13026)

 * Fixed when using 'PageAsMetafile' and 'DrawImage' to draw Meta File in PDF, it appears
   painted in Black color. (TFS: 13025)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20103.154	Build Date: Oct 29, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added support images with gradient and transparent pixels (png and gif formats).

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20103.153	Build Date: Oct 06, 2010
========================================================================================= 

Corrections
-------------
 * Fixed not show line background at metafile export. Not shown white lines instead light
   blue lines. Reason in not support PATINVERT at export emf file to PDF (TFS: 12996).

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20103.152	Build Date: Sep 25, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Small changes in readme.txt and comments (correct mistakes).
 * Q3/2010 build

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20102.151	Build Date: Sep 22, 2010
========================================================================================= 

Corrections
-------------
 * Fixed unhandled exception seen when clicking on "Fonts, fonts" button in CreatePdf
   sample. (TFS: 10708)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20102.150	Build Date: Aug 20, 2010
========================================================================================= 

Corrections
------------- 
 * Fixed the background color of Chart area is shown with ìgrayÅEcolor in generated pdf
   file if the border of Chart area is ëroundedÅEand gets image with  ëMeta file typeÅE
   (TFS: 12233)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20102.149	Build Date: Aug 02, 2010
========================================================================================= 

Corrections
------------- 
 * Fixed inconsistent behaviors occur after ëLockedÅEcheckbox is checked-on and 'cancel'
   button is clicked in 'File Attachment Property' dialog. (TFS: 10820)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20102.148	Build Date: Jul 16, 2010
========================================================================================= 

 Enhancements/Documentation/Behavior Changes 
---------------------------------------------
 * Licensing code changes. (V2/2010).

 Corrections
------------- 
 * Fixed DrawString and DrawStringRTF method with RectangleF parameter return incorrect
   value if string is empty. (TFS: 10750)

 * Fixed hidden text is appeared in drawing MetaFile image which EmfType is ëEmfPlusDualÅE
   or ëEmfPlusOnlyÅE (TFS: 10808)

 * Fixed text set in ëTextÅEproperty is not displayed without focus when
   'TextBox.IsPassword' is set true and FontType is ëEmbeddedÅE (TFS: 10819)

 * Fixed DrawString method with pointF parameter cannot draw entire Japanese string and
   cut off at end. (TFS: 10838)

 * Fixed case 1 from issue: Multiple issues seen when creating a pdf from EMF files.
   (TFS: 11174)

=========================================================================================
C1.C1Pdf.dll Build Number 2.1.20102.147	Build Date: Jun 21, 2010
========================================================================================= 

 Corrections
------------- 
 * Fixed C1Pdf does not get licensed with Reports for .NET Designer Edition keys. 
  (TFS: 10709)

* Fixed if FontType is ëStandardÅE ìNullReferenceExceptionÅEis thrown after adding some
  field controls with text. (TFS: 10775)

========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20102.146	Build Date: May 19, 2010
========================================================================================= 

 Enhancements/Documentation/Behavior Changes 
---------------------------------------------
 * Licensing code changes. (V2/2010).

 Corrections
------------- 
 * Fixed Japanese characters (Katagana, Kanji) are overlapped in PdfTextNote if the line
   break or tab contains at the end or start of text. (TFS: 10839)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20102.145	Build Date: May 07, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
---------------------------------------------
 * Licensing code changes. (V2/2010).

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20102.144	Build Date: May 03, 2010
========================================================================================= 

 Corrections
------------- 
 * Fixed incorrect text position in metafile image. (TFS: 10585)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.143	Build Date: Apr 16, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Added .NET 4.0 version (with separate designer to support for Client profile)

/////////////////////////////////////////////////////////////////////////////////////////
//
// Below this point all builds are for .NET 2.x only
//
/////////////////////////////////////////////////////////////////////////////////////////

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.142	Build Date: Apr 13, 2010
========================================================================================= 

 Corrections
------------- 
 * Fixed extra spaces are inserted between EUDC text and other text when Italic font
   style is used in PDF document. (TFS: 8313)
   
 * Partly fixed Japanese text are displayed overlapped in PdfTextNote. (TFS: 9862)
 
=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.141	Build Date: Mar 22, 2010
========================================================================================= 

 Corrections
------------- 
 * Fixed ìNullReferenceExceptionÅEoccurs when DrawStringhtml is used in rendering import
   html file with specified style. (TFS: 9671)
   
 * Fixed DrawStringhtml method renders Comments from import htm file if comment text
   contains ÅE(apostrophe/single quote) or ÅE(double quote). (TFS: 9685)
   
=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.140	Build Date: Mar 16, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Changed PDF file version (in PDF header) from 1.4 to 1.3.

 Corrections
------------- 
 * Fixed Japanese text are not displayed in PdfTextNote. (TFS: 9606)
 
 * Fixed DrawString method return incorrect value if the last line of import text file
   has text. (TFS: 9642)
   
 * Fixed DrawStringRTF method does not render Japanese DateTime format properly.
   (TFS: 9661)
   
 * Partly fixed vertical Japanese text is displayed improperly by using 'DrawString'
   method (fixed only for DrawString method with using begin coordinate). (TFS: 9692)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.139	Build Date: Mar 05, 2010
========================================================================================= 

 Corrections
------------- 
 * Fixed request to replace '0. 90' with '0 , 90' in exception message of rotation
   property. (TFS: 9421)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.138	Build Date: Feb 16, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------- 
- Removed dependency on System.Web.dll (not included in VS2010 "Client Profile")

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.137	Build Date: Feb 05, 2010
========================================================================================= 

 Corrections
------------- 
 * Licensing code updated (only affects GC builds). (V1/2010).
 * Fixed [VS 2010][ASP][C1PDF Control does not work under Framework 4 (Licensing
   problem). (TFS: 8943)
 
=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.136	Build Date: Feb 01, 2010
========================================================================================= 

 Corrections
------------- 
 * Fixed same border width is seen for C1PDFRadio button when border width is set as
   Medium, Thick or Thin. (TFS: 6705)
   
 * Fixed Japanese string is displayed outside of Rectangle when exported to pdf using
   specific font & font size. [TTP ID : 12614] (TFS: 6939)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.135	Build Date: Jan 21, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Changed PDF file version (in PDF header) from 1.3 to 1.4.
 * Licensing code updated (About form) (V1/2010).

 Corrections
------------- 
 * Clicking on signature field created by C1PDF throws ìSignature unrecognized or
   corruptedÅEerror. (TFS: 8793)
   
 * Fixed No Effect is seen when setting Opacity for PDFLineNote. (TFS: 7522)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.134	Build Date: Dec 23, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed some text are overlapped using DrawStringHtml method. (TFS: 8356)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.133	Build Date: Dec 22, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
 * Licensing code updated (V1/2010).
 
 Corrections
------------- 
 * Fixed invalid characters are rendered for English characters when using EUDC
   characters more than one line. (TFS: 8463)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.132	Build Date: Dec 18, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Changes bitmap images support.

 Corrections
------------- 
 * Fixed space is ignored in RenderParagraph document title when RenderToc is inserted to
   C1PrintDocument and exported to pdf file format. (TFS: 8391)
   
 * Fixed throw bounds-checking exception when deflating streams under very rare
   conditions. (C1Zip part)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.131	Build Date: Dec 16, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Changes support right of left texts (Hebrew and Arabic). Fixed character widths if
   incorrect metrics of the font data (shows for Thai text).

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.130	Build Date: Dec 15, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Changed filter of character width at text metafile export.

 Corrections
------------- 
 * Fixed next part for extra spaces are inserted between EUDC text and other text when
   Italic font style is used in PDF document. (TFS: 8313)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.129	Build Date: Dec 14, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Support kerning (inter-symbols spaces) for vertical output.

 Corrections
------------- 
 * Fixed extra spaces are appended to the end of string if Font styles are used in
   C1PdfDocument.DrawString method. (TFS: 8311)
   
 * Fixed extra spaces are inserted between EUDC text and other text when Italic font
   style is used in PDF document. (TFS: 8313)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.128	Build Date: Dec 11, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed Line break is skipped in rendering text within C1PDF. (TFS: 8253)
 
 * Fixed C1PdfDocument.MeasureString() method does not return the correct value.
   (TFS: 8255)
   
 * Fixed C1PDF does not render VerticalText at specified location. (TFS: 8266)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.127	Build Date: Dec 10, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed in edit mode, Japanese text are not correctly shown inside of PdfTextBox.
   (TFS: 8248)
 
=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.126	Build Date: Dec 09, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed English characters are appeared a little bit lower than Japanese characters when
   C1PrintDocumnet with WaterMark which containing both English and Japanese is export to
   pdf file. (TFS: 8093)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.125	Build Date: Dec 08, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed pdf field controls do not work properly when setting security password to pdf
   document. (TFS: 7112)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20101.124	Build Date: Dec 07, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Changed XML comments for fields of the acroform and for annotations.
 * V1/2010 build

 Corrections
------------- 
 * Fixed italic font style takes no effect on both Japanese and English characters when
   C1PrintDocument is exported to pdf file format. (TFS: 8106)
    
 * Fixed English characters are appeared a little bit lower than Japanese characters when
   C1PrintDocumnet with WaterMark which containing both English and Japanese is export to
   pdf file. (TFS: 8093)
   
 * Fixed PdfTextBox does not appear in pdf document when using certain Japanese text.
   (TFS: 8083)
   
 * Partly fixed cannot write rich text data from RichTextBox into pdf document when
   using ëFontTypeEnum.StandardÅE (TFS: 6726)
  
 * Fixed DrawString() method does not render texts in right to left format although
   StringFormatFlags is set to ëDirectionRightToLeftÅE (TFS: 6779)
   
 * Fixed text inside PdfTextNote does not render properly in pdf document. (TFS: 6999)
 
 * Fixed ExternalException [A generic error occurred in GDI+.] is thrown on exporting
   C1Report to PDF if it contains specific characters. (TFS: 9193, 8229)
   
 * Fixed C1Pdf control (Japan version) does not get licensed by using 2009T2 license tool
   under certain scenario. (TFS: 8071)
   
=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20093.123	Build Date: Nov 27, 2009
========================================================================================= 

 Corrections
------------- 
  * Fixed inconsistent behavior is observed between PreviewPane and ëpdfÅEfile format
    when C1PrintDocument with watermark is export to ëpdfÅEfile format. (TFS: 8009)
  
  * Fixed PdfRadioButton does not render properly when setting ëCheckMarkTypeÅEexcept
    Default and Circle (TFS: 7190)
    
  * Fixed PdfComboBox does not appear in pdf document when using certain Japanese text.
    (TFS: 8014)
    
  * Fixed Japanese text is not shown clearly when exporting into PDF format. (TFS: 8042)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20093.122	Build Date: Nov 25, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed items of ëPdfListBoxÅEare not able to select when its ëFontÅEproperty is set to
   some specific font type. (TFS: 6726)
   
 * Partly fixed some Japanese characters are disappeared when C1PrintDocument with
   RenderVerticalParagraph is render to pdf file format. (TFS: 7783)
   
=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20093.121	Build Date: Nov 12, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed some Japanese characters are disappeared when C1PrintDocument with
   RenderVerticalParagraph is render to pdf file format. (TFS: 7783)
   
 * Fixed cannot write rich text data from RichTextBox into pdf document when using
   ëFontTypeEnum.StandardÅE (TFS: 6726)
   
 * Fixed Japanese Text exceeds the border of cell when C1PrintDocument with RenderTable
   is render to pdf file format. (TFS: 7870)
   
 * Fixed image used in PdfSignature is stretched out of the boundary. (TFS: 6919)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20093.120	Build Date: Nov 07, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed only drawing the top half of an emf image. (TFS: 7770)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20093.119	Build Date: Nov 06, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed inconsistent behavior is observed in RenderVerticalText Japanese characters
   between preview control and pdf file format. (TFS: 7518)
   
 * Fixed selected color is applied only to the item selected by default in list box.
   (TFS: 4936)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20093.118	Build Date: Oct 27, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed Japanese text is not displayed in ëPDFTextBoxÅE (TFS: 6876)
 
 * Fixed Japanese text is not displayed in ëPDFPushButtonÅE (TFS: 6917)
   
 * Fixed Japanese characters are not able to shown in 'ToolTip' text for all
   'PdfFeildBase' classes which are newly added in build 85 (TFS: 6960 or TTP: 19020)
   
 * Fixed Japanese characters are not able to show in all PdfNotes. (TFS: 7041)
 
 * Fixed bitmap image with borders in metafile cannot be exported. (TFS: 7094)
   
 * Fixed default opacity PdfLineNote is set as 100.0, but PdfLineNote is not visible in
   exported pdf file. (TFS: 7246)
   
 * Fixed inconsistent border line is occurred when RenderRectangle is exported to pdf
   file. (TFS: 7288)
   
 * Fixed first item of RenderInputComboBox is selected in pdf file although none item is
   selected in PreviewPane. (TFS: 7353)
   
 * Fixed C1Pdf does not render properly for 'borders.htm' in 'FlowHtml' sample.
   (TFS: 8186)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20093.117	Build Date: Oct 14, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed bad show Croatian characters at PDF export. (TFS: 6903)
 
 * Fixed incorrect wrapped of Polish characters. (TFS: 7136)
 
 * Fixed 'Null Reference' Exception seen on printing Value property when default item is
   selected in list box (TFS: 4933)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20093.116	Build Date: Oct 05, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed Export to pdf of RenderInputComboBox is not proper on un checking the option -
   'Allow Content Editing'. (TFS: 4296)
   
 * Fixed Few Problems seen with Style, FillColor Property and NoteStyle Enum. (TFS: 6741)

 * Fixed default Thickness Value is set as 0 but object browser mentions that Thickness
   can be between 1-12. (TFS: 6720)
   
 * Fixed default Opacity Value for PDFLineNote is set as 100.5 but object browser mentions
   that default opacity should be 100. (TFS: 6719)
   
 * Fixed same border width is seen for C1PDFRadio button when border width is set as Medium,
   Thick or Thin. (TFS: 6705)
   
 * Fixed image present in Signature.Image property is not displayed in PDF file when PDF is
   generated for the second time. (TFS: 6845)
   
 * Fixed description is not displayed in intellisense for 'SignatureHandler' enum.
   (TFS: 6843)
   
Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Licensing code updated.

 * Changes in support annotations (AddNote method of the PdfDocument):

     AddNote(PdfNoteBase note, RectangleF rc)
	
   The 'note' parameter should be an instance of a class that derives
   from the abstract PdfNoteBase for all annotations. Available note
   classes are:
	
	 PdfTextNote, PdfSquareNote, PdfCircleNote (derives from PdfRectNote)
	 and PdfLineNote
	
   All note classes contain the following properties:
   
     Contents, ForeColor, Thickness, Opacity, PopupOpen
   
   and (except PdfLineNote)
   
     FillColor (for PdfRectNote child's)
   
   For an example, please see the "PdfAnnotations" sample.

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20093.115	Build Date: Sep 28, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * DetachedMode property of PdfSignature field changed on Handler property. Handler has
   type SignatureHandler (PPKMS by default and PPKLite).
   PPKMS   - authenticates using hash code instead of the actual file data (faster).
   PPKLite - authenticates using the actual file data (slower but more secure).

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20093.114	Build Date: Sep 12, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Some changes for PdfSignature fields of the PdfArcoform object.

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20093.113	Build Date: Sep 11, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added support PdfSignature fields of the PdfArcoform object.

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20093.112	Build Date: Aug 05, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Set miter limit (1.414 M) for join style in SetPen method (PdfDocumentBase.cs).

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20093.110	Build Date: Jul 30, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Changed Thickness property and "PdfAnnotations" sample.
 
=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20093.109	Build Date: Jul 29, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2009 build

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20092.108	Build Date: Jul 28, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added support for Pdf annotations.
   Forms are supported with a new AddNote method, and several new
   note classes:

	AddNote(PdfNoteBase note, RectangleF rc)
	
   The 'note' parameter should be an instance of a class that derives
   from the abstract PdfNoteBase. Available note classes are:
	
	PdfTextNote, PdfLineNote, PdfSquareNote, PdfCircleNote
	
   All note classes contain the following properties:
   
   Contents, FillColor, ForeColor, Style, Thickness, Opacity, PopupOpen
	
   For an example, please see the "PdfAnnotations" sample.

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20092.107	Build Date: Jul 11, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed Border Color is not applied on PDFRadioButton. (TFS: 5229)
 
 * Fixed border is displayed when Border width is set to 'C1.C1Pdf.FieldBorderWidth.None'.
   Now if BorderWidth is None that BorderColor is BackColor. (TFS: 5232)

 * Partly fixed no effect is seen when setting alignment property for PDFComboBox,
   PDFButton. Now property Alignment only for PdfTextBox fileds. (TFS: 5234)

 * Partly fixed alignment is not retained and Items gets Left alignment when focus is set
   on List box. Now property Alignment only for PdfTextBox fileds. (TFS: 5236)

 * Fixed forecolor in listbox is not applied when pdf opens, but gets applied when user
   clicks inside listbox. (TFS: 5244)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20092.106	Build Date: Jul 08, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Support all properties for acrofields.
 
 Corrections
------------- 
 * Fixed incorrect work of Rotation property. (TFS: 4684)
 
 * Fixed no effect is seen in pdf file when setting 'Visibility'
   property. (TFS: 4696)
 
=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20092.105	Build Date: Jul 02, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed incorrect position of texts with colored background at PDF export
   from metafilee. (TFS: 5073)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20092.104	Build Date: Jun 23, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Licensing code updated.
 
 Corrections
------------- 
 * Fixed evaluation message can be hidden in pdf file generated by C1PDF. (TFS: 4595)
 
 * Fixed no effect is seen when some value is assigned to DefaultText property in
   PdfFieldBase. (TFS: 4702)
   
 * Fixed text set in 'Text' property is displayed in pdf file when Textbox.IsPassword
   is set to true. (TFS: 4697)
   
 * Fixed items in List box are not displayed in pdf file when value property is not
   set. (TFS: 4698)
   
=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20092.103	Build Date: May 26, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Licensing code updated.
 
 Corrections
------------- 
 * Fixed issue with Export of large RenderVerticalParagraph (C1Report/C1Preview) which
   splits across the pages. Not clipping text at page break. (TFS: 4577)

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20092.102	Build Date: May 22, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Licensing code updated.

 Corrections
------------- 
 * Fixed Characters get too large and become unreadable in PDF export if CharWidth is set
   to greater than 100. Shown for font with font substitution. Next reason in not copy
   font width coefficient to substitute fonts. (TTP: 19559).

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20092.101	Build Date: May 21, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed Characters get too large and become unreadable in PDF export if CharWidth is set
   to greater than 100. Shown for fonts with GdiCharSet < 128. (TTP: 19559).

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20092.100	Build Date: May 15, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed Japanese characters not shown in PDF export. (TTP: 19560 and TFS:4427).

 * Added to (TFS: 4296) export to pdf with option 'Allow Content Editing' for radio buttons
   (C1Report/C1Preview) (TFS: 4296).

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20092.99	Build Date: May 13, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Licensing code updated.
 
=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20092.97	Build Date: May 12, 2009
========================================================================================= 

 Corrections
------------- 
 * Fixed SecurityException occurs on C1PDF in default and custom medium trust level for
   Web applications (TFS:4381).

 * Fixed export to pdf of RenderInputComboBox is not proper on unchecking the option -
   'Allow Content Editing' (C1Report/C1Preview) (TFS: 4296).
   
 * Fixed characters overlapped in exporting 'WideTable' sample to PDF (C1Report/C1Preview)
   (TTP: 19553).

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20092.95	Build Date: May 8, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2009 build

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20091.94	Build Date: March 25, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Changes to GrapeCity build for custom-width text.

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20091.93	Build Date: March 25, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Changes to GrapeCity build only.

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20091.92	Build Date: March 23, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Corrected saving images, double-mask save fixed.
 
 Corrections
----------- 
 * Fixed not transparent picture exporting from metafile (TTP: 19495).
   
=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20091.91	Build Date: March 19, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added support for custom-width text.
 
 Corrections
----------- 
 * Fixed incorrect vertical visual alignment in RenderTable cells at PDF export (TTP: 19486).

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20091.90	Build Date: March 09, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Changed clipping path support.
 
 Corrections
----------- 
 * Fixed duplicate book marks are created on exporting Report to PDF file format (TTP: 19390).

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20091.89	Build Date: January 27, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added support of clipping text for not rectangular areas.

Corrections
----------- 
 * Fixed a issue with bad font (show little dots instead of actual content) for
   AcroForm fields. 
 * Fixed a issue for actions of PdfPushButton without images. 
 * Added Japanese localization for new properties.

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20091.87	Build Date: January 07, 2009
========================================================================================= 

Corrections
-----------
 * Fixed several Japanese language related bugs:
   - 18757 Japanese text is garbled when setting passwords
   - 18754 Invalid font size of EUDC characters when exporting to PDF
   - 18753 A Space is inserted between EUDC characters when exporting to PDF

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20091.85	Build Date: December 22, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added support for Pdf AcroForms.
   Forms are supported with a new AddField method, and several new
   field classes:

	AddField(PdfFieldBase field, RectangleF rc)
	
   The 'field' parameter should be an instance of a class that derives
   from the abstract PdfFieldBase. Available field classes are:
	
	PdfPushButton, PdfCheckBox, PdfRadioButton, PdfTextBox
	PdfListBox, PdfComboBox
	
   All field classes contain the following properties:
   
	Name, Value, DefaultValue, IsReadOnly, IsRequired, 
	Font, BackColor, ForeColor, BorderWidth, BorderColor, BorderStyle,
	Rotation, Visibility, Text, DefaultText
	
   For an example, please see the "PdfAcroform" sample.
   
 * Added support for rendering HTML.
   HTML rendering is supported with two new methods:
	MeasureStringHtml
	DrawStringHtml
	
   The semantics for these new methods are the sames as those used
   for rendering RTF text (MeasureStringRtf and DrawStringRtf).
   
   The control supports rendering HTML into arbitrary rectangles on one
   page or flowing HTML onto multiple pages.
   
   The HTML rendering engine supports CSS, tables, and images. It does not 
   support interactive HTML features such as forms, editing, or hyperlinks.
   
   For an example, please see the "HtmlFlow" sample.
   
Corrections
----------- 
 * Fixed small text clipping issue at creating PDF from metafiles. 

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20083.80	Build Date: August 13, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added SaveAllImagesAsJpeg property. 
	Setting this property to true causes the component to save ALL images using the 
	Jpeg format, which is usually faster and more compact more than alternate formats. 
	Note however that the Jpeg format does not support an alpha channel and thus has 
	no transparency.

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20083.79	Build Date: August 13, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2008 build

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20082.78	Build Date: June 30, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Improved documentation for the DrawString method.

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20082.77	Build Date: June 7, 2008
========================================================================================= 

Corrections
----------- 
 * Added support for custom width characters in metafile export.
 * Fixed bug: 17376 invalid baseline height.

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20082.76	Build Date: April 22, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2008 build

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20081.75	Build Date: March 23, 2008
========================================================================================= 

Corrections 
----------- 
 * Improved handling of Custom paper sizes and orientation (VNPDF000077)
 * Fixed bug: VNPDF000135, reason in first save DC (it is necessary ignore).
 * Fixed metafiles bugs: VNPDF000085, VSPDF000102, VSPDF000117. And
   fixed CJK symbols bug (VNRPT000353).
 * Fixed clipping at SelectClipPath (sample Pie.emf), added clip parameter 
   for FillStroke method and override EmfPlusSaveRestoreDC method for pdf.

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20081.72	Build Date: January 19, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2008 build

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20073.69	Build Date: January 6, 2008
========================================================================================= 

Corrections 
----------- 
 * Changed embed allowed for FontSubSet and PdfFont classes, added CanEmbed and
   CanSubset properties instead _allowed field.
 * Fixed set of cmap table names (incorrect symbols and bold fonts).
 * Improved thread-safety

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20073.68	Build Date: October 20, 2007
========================================================================================= 

Corrections 
----------- 
 * Added support for mirrored and rotated fields in PdfImafeDIB class.
 * Fixed round-off issue that could cause inaccurate clipping of small images
   

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20073.67	Build Date: August 28, 2007
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2007 build
 - Improved rendering of Japanese characters

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20072.65	Build Date: July 24, 2007
========================================================================================= 

Corrections 
----------- 
 * Fixed problem rendering some Rtf tables at the end of documents
   (nextChar could get stuck and return the same value over and over again)
   
=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20072.64	Build Date: June 21, 2007
========================================================================================= 

Corrections 
----------- 
 * Fixed problem with text flow and trimmed strings that contained hard line breaks (VNPDF000104).
 
Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Encode hyperlink targets as resources rather than as page numbers.
   This causes links to be preserved when the document is opened and saved in Acrobat Pro.
 
=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20072.62	Build Date: May 22, 2007
========================================================================================= 

Corrections 
----------- 
 * Encoding of monochrome images was broken in build 50.
 
=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20072.61	Build Date: March 25, 2007
========================================================================================= 

Corrections 
----------- 
 * Fixed regression bug VNPRV000579, caused generation of invalid pdf when emulating bold
   in some international systems.

=========================================================================================       
C1.C1Pdf.dll Build Number 2.1.20072.60	Build Date: March 19, 2007
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2007 build

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20071.59	Build Date: November 23, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Improved text clipping when rendering metafiles
 
=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20071.58	Build Date: November 7, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Improved text measurement logic (more precise right-alignment in DrawString).
 
 * Added method for measuring the width of Rtf strings
   For example:
		public SizeF MeasureStringRtf(string text, Font font)
	
 * Added support for StringFormat.StringTrimming in DrawString method (with or without wrapping).
   For example:
		StringFormat sf = new StringFormat();
		sf.Trimming = StringTrimming.EllipsisWord;
		_pdf1.DrawString(text, font, Brushes.Black, rc, sf);

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20071.57	Build Date: October 13, 2006
========================================================================================= 

Corrections 
----------- 
 * Using 'Marlett' font in the DrawString() caused error in Acrobat Reader (font contains bad widths). (VNPDF000092)
   This bug was introduced in build 48, with adding improved support for Japanese characters.

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20071.56	Build Date: October 12, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Improved rendering of wmf images (render as metafiles)
 * Optimized rendering of 32 bpp images

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20071.55	Build Date: October 2, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2007 build.

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20063.55	Build Date: September 20, 2006
========================================================================================= 

Corrections 
----------- 
 * Fixed GDI leak rendering some types of image. (Bug was introduced in build 50).

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20063.54	Build Date: July 21, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Improved performance in rendering multi-page Rtf strings.

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20063.53	Build Date: July 5, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2006 build.
 * Added new property: ViewerPreferences
 
   The ViewerPreferences property determines how the document is initially displayed in the Viewer.
   It contains the following sub-properties:
      
        public PageModeEnum PageMode		// Gets or sets how the document should be displayed when opened.
        public PageLayoutEnum PageLayout	// Gets or sets the page layout to be used when the document is opened.
        public bool HideToolBar				// Gets or sets whether to hide the viewer tool bars when the document is active.
        public bool HideMenuBar				// Gets or sets whether to hide the viewer menu bar when the document is active.
        public bool FitWindow				// Gets or sets whether to resize the document's window to fit the size of the first displayed page.
        public bool CenterWindow			// Gets or sets whether to position the document's window in the center of the screen.
   
 * Added return value to DrawStringRtf method and an overload that takes the initial character to render.
   These additions make it possible to flow Rtf text into multi-page documents. For example:
   
        // calculate page rectangle
        RectangleF rcPage = _c1pdf.PageRectangle;
        rcPage.Inflate(-72, -72);
        
        // get Rtf to render
        string text = richTextBox1.Rtf;

        // print the Rtf string spanning multiple pages
        _c1pdf.Clear();
        for (int start = 0; start < int.MaxValue; )
        {
            if (start > 0) _c1pdf.NewPage();
            start = _c1pdf.DrawStringRtf(text, Font, Brushes.Black, rcPage, start);
        }

        // show the result
        string fn = @"c:\temp\test\rtf.pdf";
        _c1pdf.Save(fn);
        System.Diagnostics.Process.Start(fn);
        
 * Added overloads to DrawString with a parameter that specifies the position within
   the string where printing will start. 
   This makes the DrawString and DrawStringRtf methods more consistent.
 * Optimized DrawString, rendering long strings is now much faster than in previous 
   versions.
 
=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20062.51	Build Date: May 25, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added new property: PdfDocumentInfo.CreationDate.
   By default, this property is set to DateTime.MinValue, which causes the component
   to use the date/time when the document is written to disk.

Corrections 
----------- 
 * Added time zone offset to document creation date.
  
=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20062.50	Build Date: May 3, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Improved performance and compression of images contained in metafiles. The difference
   is especially noticeable in large jpg images, which didn't compress well in earlier versions.

Corrections 
----------- 
 * Fixed rendering of some Rtf text with Unicode characters 
   (including Hebrew text encoded in Rtf with the ETO_GLYPH_INDEX flag)

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20062.49	Build Date: February 28, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 * Improved text clipping (Delta issue VNPRV000485)
 * Fixed rendering of symbol and Unicode fonts when fonts are not embedded (Delta issue 
   VNRPT000337)

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20062.48	Build Date: February 22, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Improved rendering of Japanese characters

Corrections 
----------- 
 * none
 
=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20062.46	Build Date: January 22, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2006 build

Corrections 
----------- 
 * Delta fixes:
   VNPDF000054: could throw when measuring strings with small 'width' parameter
   VNPDF000037: some methods in PdfPageCollection did not show in C# IntelliSense


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20061.46	Build Date: December 1, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 * Updated Japanese localization strings


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20061.45	Build Date: November 8, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 * Improved color precision when saving bitmaps


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20061.44	Build Date: October 19, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2006


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20053.44	Build Date: July 12, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 * Improved speed/compression when saving monochrome bitmaps


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20053.43	Build Date: July 12, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 * Improved rendering of EMR_PIE metafile records (when using the same point, should draw full ellipse) 
 * Improved metafile path clipping operations


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20053.42	Build Date: May 25, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2005 build.
 * Added two new DrawString overloads to improve compatibility with Graphics object model:
	public int DrawString(string text, Font font, Brush brush, PointF pt, StringFormat sf)
	public int DrawString(string text, Font font, Brush brush, PointF pt)

Corrections 
----------- 
 * Improve measuring/alignment for fonts with units other than Points (i.e. Pixel, Inch) (VNPDF000047)
 * Improved duplicate image detection to reduce Pdf file size (VNPDF000050)  
 

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20052.40	Build Date: February 17, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2005 build.
 * Improved FillRectangle method to support non-solid brushes (gradients, textures, etc)

Corrections 
----------- 
 * Improved line-breaking logic to deal with lines that are wider than the page
   (previous change in build 35 was not correct)
 * Improved page-size selection logic to handle paperKinds that have the same size (VNPDF000026)
 * Improved evaluation check on ASP.NET apps.


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20051.35	Build Date: November 1, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Q1/2005 drop
 * Improved line-breaking logic to deal with lines that are wider than the page

Corrections 
----------- 
 ** improved rendering of non-standard RTF bullets
 ** removed references to printer hdcs (uses screen hdc now, except for Rtf text)
 ** improved rendering of paths in metafiles

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20044.35	Build Date: October 9, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * more thread-safety for use in ASP.NET applications
   (drawing Rtf strings could fail under some multi-threaded scenarios)
 * added support for Arabic text

Corrections 
----------- 
 ** none

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20044.34	Build Date: September 9, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * added thread-safety for use in ASP.NET applications
   (could fail to embed fonts properly under some multi-threaded scenarios)

Corrections 
----------- 
 ** none

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20044.33	Build Date: August 31, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * added Xml documentation for use with D2H Documenter

Corrections 
----------- 
 ** none

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20044.32	Build Date: August 9, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Q4/2004 build
 * updated licensing to include ASP.NET studio

Corrections 
----------- 
 ** none

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20043.31	Build Date: June 24, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 ** improved support for plus/dual metafiles in low-resolution printer-less systems

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20043.30	Build Date: June 8, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * added support for inter-character spacing in metafiles (supports justified text)

Corrections 
----------- 
 ** improved support for clipping operations in metafiles
 ** improved scaling of display-based metafiles

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20043.28   Build Date: May 6, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 ** improved handling of clipping commands in metafiles

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20043.27   Build Date: May 3, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Q3/2004

Corrections 
----------- 
 ** none

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20042.27   Build Date: April 26, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 ** Improved Japanese line breaking rules

=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20042.26   Build Date: April 22, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 ** Handle GDI charset in metafiles and rtf
 ** Improved handling of MS UI-type Japanese fonts (was saving multiple font subsets)
 ** Fixed PageCollection.Insert/InsertRange methods in documents with varying page sizes
 ** Handle fonts created in units other than points
 ** Added range checking for page sizes (can't be negative)
 ** Improved saving outline after removing pages
 ** Improved rtf character encoding (required any chars > 126)
 ** Fixed font embedding in encrypted documents (wasn't working on multiple saves)
 ** Added extra checks to font creation in Rtf renderer (failed with non-TrueType fonts)


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20042.20   Build Date: April 2, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 ** Handle vertical gdi fonts (by converting them to horizontal fonts, for now)
 ** Fixed image alignment within rectangles with negative dimensions (width/height)
 ** Added extra checks to PdfPageCollection to prevent mixing pages from different documents
 ** Improve rendering of RTF strings that contains invalid RTF commands and Unicode strings
 ** Improved handling of Pages.InsertRange/RemoveRange
 ** Improved handling of PaperKind property when setting CurrentPage property


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20042.19   Build Date: March 18, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added support for metafile clipping operations (EmfIntersectClipRect/EmfSelectClipPath)
 * Added Japanese resources
 * Added line break logic for Japanese strings

Corrections 
----------- 
 ** Improved support for Unicode attachments and links
 ** Allow to save the same document multiple times


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20042.16   Build Date: March 11, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * improved precision of metafile scaling (size and position)

Corrections 
----------- 
 ** handle images that don't specify resolution (e.g. TIFFs) 
 ** improved image clipping
 ** improved rendering of masked monochrome images in metafiles
 ** fixed problem with file attachments (colors, encryption)
 ** improved rendering of embedded non-ASCII chars
 ** improved argument type-checking in PageCollection methods


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20042.11   Build Date: February 26, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 ** setting FontType property to Standard threw exception 
 ** rendering right-aligned strings made up of spaces created invalid pdf files
 ** support Unicode characters in DrawStringRtf method
 ** improved font handling in mixed unicode/ASCII documents


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20042.10   Build Date: February 19, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Q2/2004 build

Corrections 
----------- 
 ** none


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20041.10   Build Date: February 16, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 ** Improved management of reference graphics used to render RTF 


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20041.9   Build Date: February 9, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 ** Fixed string clipping in Win98 metafiles


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20041.8   Build Date: February 5, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 ** Fixed embedded metafile scaling in Win98
	(to test: render a C1FlexGrid into a C1PrintDocument under Win98, then export to pdf)


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20041.7   Build Date: December 30, 2003 
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Improved precision of string clipping when rendering metafiles

Corrections 
----------- 
 ** none


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20041.6   Build Date: December 9, 2003 
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Improved appearance of non-solid lines (dash, dot, etc)

Corrections 
----------- 
 ** Handle hyperlinks in scaled metafiles (rare but possible)


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20034.4   Build Date: December 3, 2003 
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 ** Fixed character spacing problem in Win9x (doesn't have GetCharWidth32)
 ** Fixed problem with localized decimal points in metafiles
 ** Fixed problem with hyperlink coordinates (rectangle wasn't being honored)
 ** Fixed problem with security permissions (AllowEditContent and AllowCopyContent were switched)


=========================================================================================       
C1.C1Pdf.dll Build Number 1.1.20034.3   Build Date: November 10, 2003 
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added support for Embedded fonts (set FontType = FontTypeEnum.Embedded)

Corrections 
----------- 
 ** Fixed GDI leak related to font objects and GetReferenceGraphics()


1.1.20034.2 - October 17
	Fixed problem with bullets in RTF text
1.1.20034.1 - October 9
	First release

----------------------------------------------------------------------
Introduction
----------------------------------------------------------------------

C1Pdf supports most of the advanced features included in the PDF 
specification, including security, compression, outlining, hyper-linking, 
and file attachments.

But the main feature in C1Pdf is ease of use. The commands provided for 
adding content to documents are similar to the ones available in the 
.NET Graphics class. If you know how to display text and graphics in 
.NET, you already know how to use C1Pdf.

To create PDF documents using C1Pdf, three steps are required:
1) Create a C1PdfDocument object. 
2) Add content to the document. This usually involves calling the DrawString method.
3) Save the document to a file or to a stream using the Save method.

Here's how to create a "hello world" document using C1Pdf:

	// step 1: create the C1PdfDocument object
	C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument();

	// step 2: add content to the page
	RectangleF rc = pdf.PageRectangle;
	rc.Inflate(-72, -72);
	Font font = new Font("Arial", 12);
	pdf.DrawString("Hello World!", font, Brushes.Black, rc);

	// step 3: save the document to a file
	pdf.Save(@"c:\temp\hello world.pdf");
	
One important thing to remember is that C1Pdf uses a point-based coordinate 
system with the origin at the top-left corner of the page. This is similar 
to the default coordinate system used by .NET, but is different from the 
default PDF coordinate system (where the origin is on the bottom-left 
corner of the page).


