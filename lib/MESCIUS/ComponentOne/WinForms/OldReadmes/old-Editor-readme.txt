/////////////////////////////////////////////////////////////////////////////////////////
//
// Readme file for ComponentOne C1Editor library
//
// C1.Win.C1Editor.2.dll
//
/////////////////////////////////////////////////////////////////////////////////////////


=========================================================================================
C1Editor is an editor that allows users to load/save/edit XHTML documents. 

The C1Editor control provides a Document property that you can assign an existing document
to, which will be displayed in the control. The document is an XMLDocument object, and the
user can change the document after it is loaded into C1Editor.
C1Editor has 3 view modes: Design (WYSIWYG), Source and Preview. 

The control and the document are bound in Design mode. If the document is edited within
the control, the underlying XmlDocument changes to match. If the XmlDocument changes (in code),
then the changes appear in the editor.

Use the LoadXml method to load the document from a file, stream, or XML string.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
Editor for WinForms maintenance log:
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20141.214,
C1.Win.C1Editor.4.dll Build Number 4.0.20141.214,    Build Date: July, 24, 2014
=========================================================================================
Fixes:
  Saving C1Editor into XML changes <DIV> tags to <P> tags. (70638)
  Argument exception is observed when apply increase indent to image in editor. (72875)
  C1Editor shows flickering when its BackColor is set to Transparent. (74482)
  Can't display customized resouce string after set the "Localize... " menu. (61486)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20142.213,
C1.Win.C1Editor.4.dll Build Number 4.0.20142.213,    Build Date: June, 24, 2014
=========================================================================================
Internal changes.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20141.212,
C1.Win.C1Editor.4.dll Build Number 4.0.20141.212,    Build Date: May, 15, 2014
=========================================================================================
Fixes:
  Cursor is not shown correctly in hyperlink text after performing Undo action from redo action. (65389)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20141.211,
C1.Win.C1Editor.4.dll Build Number 4.0.20141.211,    Build Date: May, 05, 2014
=========================================================================================
Fixes:
  52264, 55828 (related with UNDO engine replacement).
  Image SRC attributes were not changed when saving new file, this was caused for images to be unresolved.
  Closing of 'Style Formatting' Dialog after applying format to text, hide the current form behind the other application". (38556)
Enhancements:
  Implemented custom Undo/Redo engine, replaced standard IE undo/redo functionality. 
Localization:
  Translated several chinese and korean strings.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20141.210,
C1.Win.C1Editor.4.dll Build Number 4.0.20141.210,    Build Date: March, 06, 2014
=========================================================================================
Fixes:
  [Regression]Focus cusor in C1Editor is shift one line below". This is regression since changeset 101238. (55800)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20141.209,
C1.Win.C1Editor.4.dll Build Number 4.0.20141.209,    Build Date: February, 28, 2014
=========================================================================================
Fixes:
  4 byte character get not shown in build-in editor and output targets. (49693)
  A break in loading of .rtf files to C1Editor. (52249)
  ObjectReference Exception occurs when clicking 'Undo' button of c1EditorToolStripMain after drag/drop .htm file to C1Editor. (52264)
Enhancements:
  Changes for licensing.  

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20141.208,
C1.Win.C1Editor.4.dll Build Number 4.0.20141.208,    Build Date: February, 21, 2014
=========================================================================================
Fixes:
  'Text' property of C1Editor returns an extra space character at the beginning of the text, when the text in the C1Editor is placed inside a table. (46893)
  Two spaces cannot be found in the document.
Localization:
  Synchronized with the latest shared code.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20133.207,
C1.Win.C1Editor.4.dll Build Number 4.0.20133.207,    Build Date: December, 16, 2013
=========================================================================================
Fixes:
  Fixed memory leaks.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20133.206,
C1.Win.C1Editor.4.dll Build Number 4.0.20133.206,    Build Date: October, 14, 2013
=========================================================================================
Fixes:
  Unhandled exception is occurred when merge two table cells that contain bullets. (41009, 40949)
  Text copied from MS word are not shown when paste in comment box. (41204)

=================================================================================7========
C1.Win.C1Editor.2.dll Build Number 2.0.20132.205,
C1.Win.C1Editor.4.dll Build Number 4.0.20132.205,    Build Date: October, 06, 2013
=========================================================================================
Fixes:
  ‘Object reference not set’ error is shown when open HTML5 document which is coverted from HTML Help". (39992)
  Apply Style sometimes does not apply the selected style, applies "normal" instead.
  Pasting as unformatted text inserts BR tags instead of P tags. It seem to be MSHTML feature (bug?).
  Link underline from hyperlink texts contained comment is shown partially in html5 editor after viewing the project. (41186)
  Unhandled exception is thrown when user try to edit bookmark properties via tagbar for "a" tag. (DocToHelp only)
  Google doc spreadsheet content cannot be pasted into C1Editor.
  Add missed toolbar icon to resources. (35569)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20132.204,
C1.Win.C1Editor.4.dll Build Number 4.0.20132.204,    Build Date: August, 11, 2013
=========================================================================================

Fixes:
  'Object reference not set' error is shown when open HTML5 document which is coverted from HTML Help. (39992)
  After setting Localized texts [eg.” Dutch”] to some labels in dialogs, Label’s text are not fixed positioned. (35370)
  Image size is changed to original size when press 'Enter' key at the end of image. (40737)
  Two comments are overlapped in c1editor when Html file is getting saved into editor using ‘Save’ Toolbar button. (39649)
  C1EditorToolStripReview(FW 2.0) shows different Toolbox icon from C1EditorToolStripReview(FW 4.0). (35569)

Enhancements:
  Changes for licensing.   

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20132.203,
C1.Win.C1Editor.4.dll Build Number 4.0.20132.203,    Build Date: July, 14, 2013
=========================================================================================
Table copied from MS Word 2010 doesn't paste in C1Editor on a machine with IE10 installed. (39625)
 
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20132.202,
C1.Win.C1Editor.4.dll Build Number 4.0.20132.202,    Build Date: July, 06, 2013
=========================================================================================
Multiple issues in merged and pasted tables. (38756, 35823, 38232, 38488)
Adding a Table Select All and applying of 'Increase Indent' , the table is disappeared in C1Editor. (38517)
'NullReferenceException' occurs when setting and removing bullets to two selected cells of a table. (37973)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20132.201,
C1.Win.C1Editor.4.dll Build Number 4.0.20132.201,    Build Date: June, 24, 2013
=========================================================================================
Fix:
  By EMail Brad Keller <brad.keller@componentone.com> 04/10/2013 "Unhandled Exception - XHTML Editor - Build 755".
  Three or more time Merging/Splitting in a table throws System.ArgumentOutOfRangeException. (35823)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20131.200,
C1.Win.C1Editor.4.dll Build Number 4.0.20131.200,    Build Date: April, 04, 2013
=========================================================================================
Enhancements:
  Changes for licensing.   

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20131.199,
C1.Win.C1Editor.4.dll Build Number 4.0.20131.199,    Build Date: March, 18, 2013
=========================================================================================
Enhancements:
  New icons for comments.
Fix:
  Changeset 101510-sergeyb-2-19-2013 is rolled back because of multiple issues with IE8/IE9 rendering mode.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20131.198,
C1.Win.C1Editor.4.dll Build Number 4.0.20131.198,    Build Date: February, 27, 2013
=========================================================================================
Enhancements:
  Decreased indent between paragraphs in comment.

Fixes:
  Unhandled Exception in Built-in Editor when pasting text from MS Word.
  "InvalidComObjectException was unhandled when user try to add new comment in certain scenario. (34414)
  "class="c1-comment-reply" is removed from comment-reply DIV tag when user clear formatting. (34400, 34407)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20131.97,
C1.Win.C1Editor.4.dll Build Number 4.0.20131.97,    Build Date: February, 25, 2013
=========================================================================================
Enhancements:
  Restricted adding image and flash movie in Comment. It seem to be not useful feature and also gives some bugs with focus.
  Comment element structure fixup is made similar to table fixup. It allows to keep comment structure (container, comments, markers) always valid.
  Minor enhancement of comment reply margins.

Fixes:
  Finalized bugfix 33858.
  List indents in Preview are not equal to list indents in IE browser. To use IE8/IE9 rendering mode, application should be registered with proper IE emulation type in HKLM (or HKCU) in Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION registry node. 
  Unlike previous build, Table cannot be edited as toolbar buttons are disabled. (34076)
  “ArgumentOutOfRangeException” exception was thrown after clicking button (eg.picture, Hyperlink, Bookmark and Flashmovie) of c1EditorToolStripObjects. (34180)
  Comment’s text is shown in rtf file saved by c1Editor with comment. (34207)
  Comment is not highlighted when scrollbar position is changed.
  Comment become overlap if line break is inserted in comment box. (34165, found in DocToHelp).

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20131.96,
C1.Win.C1Editor.4.dll Build Number 4.0.20131.96,    Build Date: February, 14, 2013
=========================================================================================
Enhancements:
  Comment is highlighted if mouse cursor is placed between markers (with delay 1 sec).
  Text of new created comment is fully selected.
  Reply button has tooltip now.

Fixes:
  Style applied to "c1-comment-container" div tag if user selected entire paragraph in comment. (33737)
  Comments are overlapped in certain scenarios. (33741)
  "Previous Comment" navigates to (previous+1)th comment" (33742)
  XML Document goes to non stable state when removing single comment on single paragraph. (related with 33827)
  Hotspots are created with incorrect html if they are created by copy-paste from D2H panels to our editor. (DocToHelp only)
  When pressing Enter key to go new line after inserting a comment, comment box also point to the new line. (33827)
  Apply style in XHTML editor window using Style Formatting dialogbox cause position misalignment to the comment box. (33858, partial fix, will be finalized in DocToHelp)
  Clear formatting command removes formatting from whole paragraph, regardeless of real selection. (DocToHelp only)
  Next and Previous menu items are in enabled state although there are only one comments. (33879)
  Opening of some .rtf file, throws System.StackOverflowException. (33829)
  Highlighted text is not always marked as pink. (found in DocToHelp only)
  Hidden comments are excluded from the search.
  Incorrect tab is selected when Find/Replace button from C1EditorToolStripMain is clicked if user rearranged tabs in ‘Find and Replace’ Dialog. (34024)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20131.95,
C1.Win.C1Editor.4.dll Build Number 4.0.20131.95,    Build Date: February, 01, 2013
=========================================================================================
Enhancements:
  Added "Comments" feature: comments can be added to text similar with MS Word comments.

Fixes:
  Image tag is removed on pressing enter when culture is set to "tr-TR". (33605)
  Clicking "Go to previous page" shows Application folder path in Preview permanently. (30270, partially)
  "NOSCRIPT" tag was removed. (involved by 30295)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20123.94,
C1.Win.C1Editor.4.dll Build Number 4.0.20123.94,    Build Date: November, 21, 2012
=========================================================================================
Localization:  
  Added string translations for Chinese/Korean languages. (29459)

Fixes:
  KeyDown/KeyUp/KeyPress events weren't raised when table removing. (29728)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20123.93,
C1.Win.C1Editor.4.dll Build Number 4.0.20123.93,    Build Date: November, 08, 2012
=========================================================================================
Localization:  
  Added string translations for Chinese/Korean languages.

Fixes:
  Copy/Paste does not work for image between two editors. (27599)
  Unncessary break line is inserted when rtf file is loaded. (29496)
  With 'rtf' format, saved Bullet and Numbering are not loaded correctly. (29510)
  Resizing the button object in the Design View does not change style attribute in Source View. (29273)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20123.92,
C1.Win.C1Editor.4.dll Build Number 4.0.20123.92,    Build Date: October, 26, 2012
=========================================================================================
Localization:  
  C1Editor is localized to Chinese and Korean languages.

Tasks:
  Load/Save RTF files.

Fixes:
  Only the top two paragraphs were working when increase/decrease indent are applied (27594)
  Forms's OnActivated event is fired before Load Load when C1Editor is placed on a form and XML text is empty. (23944, finalized)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20122.91,
C1.Win.C1Editor.4.dll Build Number 4.0.20122.91,    Build Date: September, 10, 2012
=========================================================================================
Fixes:
  Metro toolbox icon of C1Editor is different from other C1 Controls metro icon. (27613)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20122.90,
C1.Win.C1Editor.4.dll Build Number 4.0.20122.90,    Build Date: August, 31, 2012
=========================================================================================
Enhancements:
  Supported Metro icons.
  All kinds of Uri (including web adresses) are supported in LoadXml methods now. (24279)

Fixes:
  Forms's OnActivated event is fired before Load Load when C1Editor is placed on a form. (23944)
  DropDown of Toolbar items are render off screen. (24425)
  Setting of the same value of Xml property didn't change value if it was changed in Editor. (24199, partially)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20122.89,
C1.Win.C1Editor.4.dll Build Number 4.0.20122.89,    Build Date: July, 11, 2012
=========================================================================================
Internal changes.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20122.88,
C1.Win.C1Editor.4.dll Build Number 4.0.20122.88,    Build Date: June, 18, 2012
=========================================================================================
Fixes:
  NullReferenceException is thrown when rapidly change view from Source to Proview and then to Design, (only if iframe tag was inserted in Source mode). (20454)
  Unhandled exception has occured when C1Editor form is opened in modal state and Formatting context menu item was clicked. (22910)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20121.87,
C1.Win.C1Editor.4.dll Build Number 4.0.20121.87,    Build Date: May, 21, 2012
=========================================================================================
Fixes:
  Errors are displayed when import the document selecting 'Convert to XHTML' option. This is regression since 80812 changeset. (22002, DocToHelp only)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20121.86,
C1.Win.C1Editor.4.dll Build Number 4.0.20121.86,    Build Date: April, 11, 2012
=========================================================================================
Fixes:
  Fixed various bugs after C1Editor.RollbackTransaction using, only if selection was not changed.
  Added internal property SaveWithoutBOM (just for using within DocToHelp): if true (false by default), document is saved without BOM mark.
  Pressing F5 during preview mode opens the explorer(the path selector). (21154)
  COMException thrown when the html file that contains scripts is opened while Editor Mode is 'Preview'. (21159)
  Editor.History not reinitialized upon LoadXml. (21169)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20121.85,
C1.Win.C1Editor.4.dll Build Number 4.0.20121.85,    Build Date: March, 9, 2012
=========================================================================================
Fixes:
 IFRAME tag was incorrectly handled.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20121.84,
C1.Win.C1Editor.4.dll Build Number 4.0.20121.84,    Build Date: February, 14, 2012
=========================================================================================
Enhancements:
  Added FontSize and FontFamily toolbar comboboxes. (19533)

Fixes:
  Validation fails & formatting is allowed in C1Editor placed in Panel in usercontrol. (19531)
  Inconsistent behavior is observed when Ordered List <ol> and Unordered List <ul> are used in C1Editor. (19229)
  C1Editor made incorrect color changes to selected text inside <span> and <font> tags. (17724)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20113.83,
C1.Win.C1Editor.4.dll Build Number 4.0.20113.83,    Build Date: January, 13, 2012
=========================================================================================
Behavior Changes (Only for DocToHelp):
  Target attribute is added for Strict mode, for the same elements as in transitional mode.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20113.82,
C1.Win.C1Editor.4.dll Build Number 4.0.20113.82,    Build Date: January, 4, 2012
=========================================================================================
Enhancements/Documentation/Behavior Changes:
  Updated licensing to conform with Federal Information Processing Standards requirements.

Fixes:
  Context Menu was enabled when ReadOnly property is set to True in C1Editor. (18806)
  DIV tags (even with 'id' attribute) disappear when switching mode from source to design. (18361)
  Issues observed when C1Editor and other controls present on form are bound to a dataset. (18637)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20113.81,
C1.Win.C1Editor.4.dll Build Number 4.0.20113.81,    Build Date: November 11, 2011
=========================================================================================
Fixes:
  Image map regions are damaged when pressing Enter immediately after picture. (found in DocToHelp)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20113.80,
C1.Win.C1Editor.4.dll Build Number 4.0.20113.80,    Build Date: October 27, 2011
=========================================================================================
Fixes:
  Line of text are sperated into each paragraph after removing the bullet items. (17966)
  C1Editor made incorrect color changes to selected text inside <span> and <font> tags" (17724, finalized)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20113.79,
C1.Win.C1Editor.4.dll Build Number 4.0.20113.79,    Build Date: October 20, 2011
=========================================================================================
Fixes:
  Exception is observed on running C1WordsX sample (15819, 16302)
  'Exception from HRESULT' error is shown when pressing  Ctrl+S two times while opening source view of xml editor. (17374, found in DocToHelp)
  " (quote) character is not converted to entity in Source mode. (found in DocToHelp)
  C1Editor can be editable in Design mode when readonly property is set to true and 'Text' property or 'LoadXML'l property is set. (17287)
  "src" attribute is removed in "script", "iframe" and "input" elements.
  Cannot remove C1Editor's ContextMenu items using 'RemovByKey' method. (17567)
  Cannot remove C1Editor's Toolstrip items using 'RemovByKey' method.
  C1Editor made incorrect color changes to selected text inside <span> and <font> tags". (17724)
  Changes in licensing code.

Localization:  
  Localized Style dropdown list items and Color names for toolstrips and dialogs. (17513)
  
Samples:
 [C1WordX-VB]Error message seen when load the document to the C1Editor". (17627)  

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20113.78,
C1.Win.C1Editor.4.dll Build Number 4.0.20113.78,    Build Date: September 13, 2011
=========================================================================================
Enhancements:
 Enhanced object model to allow access to HTML event handlers. Added event HtmlEvent. (17047)
 "Font", "ForeColor" and BackColor" properties are made visible to set the browser appearance. (6327)
 
Fixes:
  Nothing is dropped when drag&drop of .htm file to the Editor. (16744)
  Values of input controls are missing when drag&drop from one Editor instance to another. (16756)

Samples:
 Added sample HtmlEvents to demonstrate abilities of new event HtmlEvent.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20112.77,
C1.Win.C1Editor.4.dll Build Number 4.0.20112.77,    Build Date: August 8, 2011
=========================================================================================
Fixes:
 Exception is raised when pasting text from LibreOffice.
 Unhandled exception when inserting Flash. (16347)
 WordWrap property value was ignored after saving file, text in source mode was always wrapped. (15767)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20112.76,
C1.Win.C1Editor.4.dll Build Number 4.0.20112.76,    Build Date: June 8, 2011
=========================================================================================

Fixes:
 Incorrect selection of source tags when HTML controls are selected in design view. (15526)
 Underline toolstrip button is deactive when overline style is applied using Formatting dialog. (15599)
 Double quotes are removed in html tag & xml:Lang attribute is not retained when saving & loading the xml file. (15388, Part 2)
 [VB -ContentEditable]Source and Design button is not working. (15598)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20112.75,
C1.Win.C1Editor.4.dll Build Number 4.0.20112.75,    Build Date: May 31, 2011
=========================================================================================
Fixes:
  Performance is slow when pasting Japanese text into "Source" tab. (12527, found in DocToHelp)
  ".Net Framework license compiler has stopped working" error is shown when build the project in VS2008 and VS 2010SP1. (15405)
  Double quotes are removed in html tag & xml:Lang attribute is not retained when saving & loading the xml file. (15388)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20112.74,
C1.Win.C1Editor.4.dll Build Number 4.0.20112.74,    Build Date: May 16, 2011
=========================================================================================
Enhancements:
  Style Formatting dialog is replaced with new dialog with rich formatting abilities.
  Added "Style" property with builin editor to all dialogs for table, hyperlink, bookmark e t.c. (12709)
  Added new split button "Border" to C1EditorToolStripStyle toolbar.
Fixes:
  Specified font size does not effect to all selected text. (14723)
  Cusor delay to go to the next line when cursor is at the first line of C1Editor". (15322)
  Duplicate Bookmarks are added to bookmarks list when pressing ENTER key after bookmarked text. (14725)
  Applying changes to XmlDocument (f.e. applying of STRONG tag) caused executing delay on big documents.
  Enhanced code executing speed in C1TextRange methods IsStyleApplied, IsClassApplied, IsTagApplied.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20111.73,
C1.Win.C1Editor.4.dll Build Number 4.0.20111.73,    Build Date: May 05, 2011
=========================================================================================

Fixed:
  Unhandled Exception observed on adding  Image/Flash file on a network location. (14214, DocToHelp)
  Bug in Image/Flash dialog: if source file was on the same disk, it was not copied to Project/Media folder.  

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20111.72,
C1.Win.C1Editor.4.dll Build Number 4.0.20111.72,    Build Date: April 18, 2011
=========================================================================================
Fixed:
  Cannot set hyperlink "target" attribute, "rel" attribute is set instead.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20111.71,
C1.Win.C1Editor.4.dll Build Number 4.0.20111.71,    Build Date: April 11, 2011
=========================================================================================
Fixed:
  'Delete' menu link is not showed at table context menu. (14719)
  
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20111.70,
C1.Win.C1Editor.4.dll Build Number 4.0.20111.70,    Build Date: April 07, 2011
=========================================================================================
Fixed: 
  (DocToHelp)Unhandled Exception seen when creating a new tag. Also, this bug causes repeating raise of DocumentChanged event on mouse moving. (14827). 
  Cursor is moved to lower place when press "Backspace" or "Delete" in list with table inside.
  Removed default .NET icon from "Localize" dialog.
  
Enhancements:
  Added public property C1Editor.WebBrowser, that returns a reference to the IWebBrowser2 interface for current Editor mode. This will make available advanced programming opportunities for Editor. (14685)
  Disabled “Ctrl + l” WebBrowser builtin shortcut. (14869)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20111.69,
C1.Win.C1Editor.4.dll Build Number 4.0.20111.69,    Build Date: March 10, 2011
=========================================================================================

Fixed:
  Multiple issue are observed when two Editor are on one single form. (14604)
  Applying upper case tags throws error when switching to source view. (14588)

Enhancements: 
  AcceptsTab property is made "true" by default. (14594)
  
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20111.68,
C1.Win.C1Editor.4.dll Build Number 4.0.20111.68,    Build Date: March 07, 2011
=========================================================================================
Fixed:
  "StackOverflowException was enhandled." message seen when load the HTML file include Meta tag at the first line. (14556)
  
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20111.67,
C1.Win.C1Editor.4.dll Build Number 4.0.20111.67,    Build Date: March 05, 2011
=========================================================================================
Fixed:
  Changed initial values of Text and XmlExtensions properties to avoid their unwanted serialization in designer.cs file.
  Multiple issues occurs while formatting the text outside of the <Fieldset> tag. (12957)
  'Text' and 'Xml' properties are not added in Properties grid of C1Editor. (14287)
  
Enhancements: 
  Increase/decrease indent on TAB/Shift-TAB pressing. (13077)
  Request to please provide resizing the image with keep aspect ratio in C1Editor's design mode. (14318)
  Add ability to save pictures/video from Web to local folder. (9658)
  
Localization:
  Added feature that can be used to localize strings at design time. (14259)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20103.66,
C1.Win.C1Editor.4.dll Build Number 4.0.20103.66,    Build Date: February 03, 2011
=========================================================================================
Fixed:
  Unhandled exception was raised when open specific document.
  'ArgumentException was unhandled' exception occurs when save file using 'SaveXml' method. (14295)
  In C1Editor, the maximum number of characters cannot be typed after 'MaxLength' property is set. (14286) 

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20103.65,
C1.Win.C1Editor.4.dll Build Number 4.0.20103.65,    Build Date: January 30, 2011
=========================================================================================
Fixed:
  Cosmetic changes in English strings.
  
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20103.64,
C1.Win.C1Editor.4.dll Build Number 4.0.20103.64,    Build Date: January 27, 2011
=========================================================================================
Fixed:
  Content of the Source mode browser in some cases isn't refreshed after saving a document with automatic fix of the validation errors.
  Image path in img tag changes from absolute to relative path when editing text in Design view. (13449)
  Extra '<p>&nbsp;</p>' gets created after each paragraph in C1Editor when texts are copy and paste from Word document. (13481)  

Enhancements:
  Added ReadOnly property (9953)
  Added MaxLength property (9953)
  Enhanced databinding support: Properties 'Text' and 'Xml' are marked as Bindable, editor is able to notify changes in binded 'Text' and 'Xml' properties. (9953)
  Added property Editor.CustomDialogs.MessageBox to support message box customizing. (11248)
  Added support for resizing C1Editor's font using C1Sizer/C1SizerLight control. (9951)
  
Samples:
  Added code to C1EditorQuickStart sample to support Ctrl+P, Ctrl+N, and Ctrl+O shortcuts custom handling. (13518)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20103.63,
C1.Win.C1Editor.4.dll Build Number 4.0.20103.63,    Build Date: January 07, 2011
=========================================================================================
Fixed:
  Files are not converted to XHTML when converting from RoboHelp for HTML because of exception. (DocToHelp only)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20103.62,
C1.Win.C1Editor.4.dll Build Number 4.0.20103.62,    Build Date: December 30, 2010
=========================================================================================
Fixed:
  Incorrect selection is seen after merging row/Columns when row is selected using Select Row option in Select Dropdown. (13334)
  Error Error 'Object Reference not set..' seen when converting Word document to XHTML. (12693)
  Converting Manual output document to xml and then opening xml file causes "validation errors" message to be seen. (13907)
Localization:
  Localized names of the predefined values of the hyperlink target.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20103.61,
C1.Win.C1Editor.4.dll Build Number 4.0.20103.61,    Build Date: December 24, 2010
=========================================================================================

Enhancements:
  Improved diagnostics for C1Editor.XmlExtensions setting: if one of custom tags in incorrect, repeating or is a duplicate of standard XHTML tag, 
    ArgumentException with corresponding message is thrown.
  Changes in license info.
  
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20103.60,
C1.Win.C1Editor.4.dll Build Number 4.0.20103.60,    Build Date: December 10, 2010
=========================================================================================

Localization:
  Translated japanese strings for messages.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20103.59,
C1.Win.C1Editor.4.dll Build Number 4.0.20103.59,    Build Date: December 01, 2010
=========================================================================================

Fixed:
  Closing Find Dialog using Close button and then opening it again does not set focus 'find what' textbox. (13165)
  ['Find what' & Find Next'], ['Search all documents..' &'Replace All'] have same shortcut keys in Find and Replace dialog. (13178)
  
Enhancements:
  Strings (used in DocToHelp only) are prepared to japanese localization.
  Japanese strings are always used for japanese locale, even in English release. 
  Changes for licensing.    
    
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20103.58,
C1.Win.C1Editor.4.dll Build Number 4.0.20103.58,    Build Date: October 22, 2010
=========================================================================================

Fixed:
  Underline style does not remove when clear formatting using "Ctrl + Space" keys. (13140)
  Incorrect description of the DefaultTitle property. (13046)
  Flash movie (OBJECT tag) begins to play its sound after his paragraph style is changed. (49209)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20103.57,
C1.Win.C1Editor.4.dll Build Number 4.0.20103.57,    Build Date: October 18, 2010
=========================================================================================

Fixes:
  Buttons in C1EditorToolStripStyle are not higlighted when HTML contains <b>, <u>, <i> & <strike> tags. (12418)
  Multiple issues are observed when setting the 'DefaultTitle' property at run time. (13046)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20103.56,
C1.Win.C1Editor.4.dll Build Number 4.0.20103.56,    Build Date: October 8, 2010
=========================================================================================

Improvements:
  Added public property XHTMLItemBase.Node to give direct access to XmlNode in edit dialogs (Table/Bookmark/Hyperlink e t.c.). (12712)
  Added public property C1Editor.DefaultTitle to set initial value of the new document. (5056)
 
Fixes:
  Buttons in C1EditorToolStripStyle are not higlighted when HTML contains <b>, <u>, <i> & <strike> tags. (12418)
  GDI leak observed in an application on using C1Editor". (12955)
  Cursor gets placed at end of internal hyperlink on pressing enter after the paragraph above it. (12468)
  Multiple issues occur when Flash file is dragged and dropped on C1Editor in Design mode. (12464)
  
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20103.55,
C1.Win.C1Editor.4.dll Build Number 4.0.20103.55,    Build Date: September 25, 2010
=========================================================================================
Fixes: 
  Editor.Selection points to wrong place in DragDrop event handler.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20102.54,
C1.Win.C1Editor.4.dll Build Number 4.0.20102.54,    Build Date: September 22, 2010
=========================================================================================
Improvements:
  Borders are visible in borderless table in design mode. (12711)
  Toggling between Find/Replace dialog on pressing shortcut keys. (11587)
  
Fixes:
  Cross sign is displayed instead of the image when the image is inserted into source document that has a Japanese path. (12415)
  'LoadDesignCSS()' and 'LoadPreviewCss()' methods do not work when C1Editor is created at run time. (12466)
  Hyperlink set to an internal link in the same page does not work. (12467)
  'Find what' textbox becomes empty in Find/Replace dialog when Ctrl+H/Ctrl+f is clicked. (11586)
  Formatting is not removed in few cases when XML is saved & reloaded. (12190)
  Exception occurs on copy pasting Japanese characters into the XHTML document in design view. (12485)
  Wrong behavior when inserting &nbsp; entity when set C1TextRange.XmlText.
  C1TextRange bounds don't change after set Text and XmlText.  
  Improved validation of a bookmark name: only letters, digits, ’.’, ’-’, ’_’ and ’:’ characters are allowed.
  2 comments on the different lines in the original document are joined to the single line after loading.
  
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20102.53,
C1.Win.C1Editor.4.dll Build Number 4.0.20102.53,    Build Date: July 30, 2010
=========================================================================================
Fixes:
  Some minor issues in runtime cases with XmlEditorToolStrip.
  [3503] Formatting is removed from text on which cursor is placed when C1EditorToolStripStyle.Editor is set on TabControl's "SelectedIndexChanged". (12029)
  Bookmark button is enabled but bookmark cannot be created when Horizontal line is selected. (11688)
  FindReplace Feature throws "HRESULT: 0x80070005 (E_ACCESSDENIED)" error after loading another XHTML document.
  
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20102.52,
C1.Win.C1Editor.4.dll Build Number 4.0.20102.52,    Build Date: July 24, 2010
=========================================================================================
Fixes:
  Bookmark button is enabled but bookmark cannot be created when Horizontal line is selected. (11688, DocToHelp only)
  Regression since "Added correction of bookmarks with non-unique name in the document": NBSP tags was unexpectedly created. Now nonunique bookmark names are corrected silently, without validation errors.
  
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20102.51,
C1.Win.C1Editor.4.dll Build Number 4.0.20102.51,    Build Date: July 20, 2010
=========================================================================================
Fixes:
  Added correction of bookmarks with non-unique name in the document.
  Added validation of bookmarks for the unique name in the document.
  Fixes for supporting of the glyph for the bookmarks. (DocToHelp only)
  
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20102.50,
C1.Win.C1Editor.4.dll Build Number 4.0.20102.50,    Build Date: July 09, 2010
=========================================================================================
Fixes:
  Exception is observed when bookmark is created for empty paragraph, user types some text and then clicks on the Bookmark button. (11584)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20102.49,
C1.Win.C1Editor.4.dll Build Number 4.0.20102.49,    Build Date: July 07, 2010
=========================================================================================
Fixes:
  New Bullet list created when the user selected the inner items of a list and clicks twice on the Bulleted/Numbered List  button (11140)
  All options of context menu are shown for incorrect word (6283)
  'Few Events' of C1XMLEditor not getting fired (6980)
  Fixed bug with glyphs on empty bookmarks.
  
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20102.48,
C1.Win.C1Editor.4.dll Build Number 4.0.20102.48,    Build Date: June 19, 2010
=========================================================================================
Fixes:
  'Restart Numering' and 'Continue Numbering' options remain enabled for incorrect text. (6283)
  Selected Color is not applied when the color is reselected from Color dropdown. (11155, partially)
  Multiple issues are observed when BackColor is applied to an Image or Flash file object. (11152)
  Shading color is not applied to the Table caption text (11148)
  New Bullet list created when the user selected the inner items of a list and clicks twice on the Bulleted/Numbered List  button (11140)
  Exception is observed when DragDrop operation is implemented in C1Editor. (11135)
  StreamObject gets corrupted after using  SaveXML(stream) method. (9949)
  'Few Events' of C1XMLEditor not getting fired. (6980)
  Exception is observed on switching view from Source to Design to Source when commented text is written between <p> tags. (11142)
  Title bar of all error message alerts shows 'ComponentOne XML Editor'. (11151)
  Text Selection styles get applied on the table instead of Cell selection when the content of table cells is deleted. (11153)
  Selected Color is not applied when the color is reselected from Color dropdown. (11155)
  Transparent Color is set as Default color for FontColor/ParagraphColor/BackColor buttons in C1EditorToolStripStyle. (11136)
  Subscript, Superscript, Big, Small, Bold, Underline, Italic gets applied at once on text when cursor is placed at the end of the word. (11157)
  C1Editor does not appear on WPF Window when WindowsHost is added to StackPanel. (11138)
  'C1WordX' sample uses old reference of C1Ribbon.2.Design.dll. (11139)
  
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20102.47,
C1.Win.C1Editor.4.dll Build Number 4.0.20102.47,    Build Date: June 03, 2010
=========================================================================================

Fixes:
  Autosize setting doesn't raise exception, this code just ignored. This change is made for compability with WPF.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20102.46,
C1.Win.C1Editor.4.dll Build Number 4.0.20102.46,    Build Date: May 24, 2010
=========================================================================================

Improvements:
  The following style/formatting buttons are added to C1EditorToolStripStyle control (8404):
    - Numbered list;
    - Bulleted list;
    - Increase indent;
    - Decrease indent;
    - Text color;
    - Background color;
    - Paragraph background color.

  * New values in the CommandButton enum:
        NumberedList,
        BulletedList,
        IncreaseIndent,
        DecreaseIndent.
  * New enum CommandColorPicker
    {
        None,
        ForeColor,
        BackColor,
        ParagraphBackColor
    }
  * New class C1EditorToolStripColorPicker.

  Mouse events of the C1Editor (Click, DoubleClick, MouseClick, MouseDoubleClick, MouseDown, MouseUp, MouseMove, MouseEnter and MouseLeave) are implemented. (6980)
  Drag events of the C1Editor (DragEnter, DragOver, DragLeave and DragDrop) are implemented. (6980)
  
Changes in object model:
  Class C1.Win.C1Editor.List:
            public void Execute(Action action);
            public bool CanExecute(Action action);
            public ListType Type;

  Enum C1.Win.C1Editor.List.Action:
            IncreaseLevel,
            DecreaseLevel,
            ContinueNumbering,
            RestartNumbering
            
  Enum C1.Win.C1Editor.List.ListType
            None,
            Numbered,
            Bulleted
  
  Class C1.Win.C1Editor.History:
            public void Undo(int count);
            public void Redo(int count);
            public string[] UndoList;
            public string[] RedoList;

  
  Property SelectionWorks.List, to support work with lists.
  Property C1Editor.History to support work with undo/redo stacks.
  Method C1TextRange.GetTags(C1StyleType type, bool includePartialNodes), that returns list of nodes in range.

Changes in samples:
  Added sample ContentEditable.
  Changes in the C1WordsX: IncreaseIndent and DecreaseIndent are implemented through the C1TextRange.GetTags.
  
Fixes:
  In some cases selecting of the element with 'contenteditable' attribute may be a cause of the recursive calling of the SelectCurrentSimpleSelection.  
  
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20101.45,
C1.Win.C1Editor.4.dll Build Number 4.0.20101.45,    Build Date: Apr 28, 2010
=========================================================================================

Improvements:
  Support glyph of the bookmarks in the C1Editor is implemented. See also D2H task #10324: Display bookmarks in editor. (for DocToHelp only)
  Made C1Editor accept Reports for .NET Designer Edition product keys
  Used Dotfuscator 4.0 for obfuscation.
  
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20101.44,
C1.Win.C1Editor.4.dll Build Number 4.0.20101.44,    Build Date: Apr 20, 2010
=========================================================================================
Fixes:
  Unnecessary empty paragraphs are created in the XmlDocument after creating new paragraph in the HTML-document (Regression since 2.0.20101.43).
  Print Dialog opens twice if the user opens it (9481).
  Exception is observed when C1Editor is set as Editor of C1FlexGrid or its column (10245).
  "IsDirty" flag is not reset when any HTML file is loaded using LoadXml method or from the Open dialog of MainToolStrip (10244).
  StreamObject gets corrupted after using  SaveXML(stream) method (9949).
  
Improvements:
  Added samples for VS2010.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20101.43,
C1.Win.C1Editor.4.dll Build Number 4.0.20101.43,    Build Date: Apr 9, 2010
=========================================================================================
* C1Editor control designer has been moved to a separate dll in the version for .NET 4.0. 
  Target framework of C1.Win.C1Editor.4.dll is Framework 4.0 Client Profile.

Fixes:  
  Issue in collaboration with FlexGrid. Calling of ApplyStyle is ignored.

Changes in object model:
  Added public property: 
      public string Xml {get;set;} 
      Gets or sets the current XML content of the editor.
  Added public method:
      public string SaveXml().
      Returns the XML content of the document as a string.

 Inprovements:
   Improved Xml content fixup when source XML is incomplete (HTML or BODY element is missed).      
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20101.42    Build Date: Mar 16, 2010
=========================================================================================
Fixes:
 IsDirty flag was not reset when calling UIEditor.LoadXml.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20101.41    Build Date: Mar 10, 2010
=========================================================================================
Fixes:
 Picture/Flash URL was missed when editing in dialog.
 
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20101.40    Build Date: Mar 09, 2010
=========================================================================================
Fixes:
 Proper icons for C1EditorToolstrips are not observed. (9431)
 Whole of the selected multiline text is displayed in 'Find What:' of 'Find and Replace' dialog box". (9455)
 Few issues observed with 'PrintTemplate2008' sample". (9481)
 Selection.ApplyStyle attaches extra 'font-face' to the text" and 9478 "BackgroundColor applied gets removed on placing cursor at its extreme right. (9456)
 Tab button does not work in the table inserted in C1Editor. (9454)
 Disabled toolbar buttons in C1EditorQuickStart sample which do not work in Source/Preview mode. (9500)
 
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20101.39    Build Date: Feb 26, 2010
=========================================================================================
Fixes:
In the builtin toolbar, when the html doc is loaded. If you click any of the  paragraphs that appear on the numbered list at the start of the document, 
you will notice that the item clicked is 'detached' from the list, and  numbering restarts.
Method C1TextRange.Move works incorrectly with picture/object/br, it passed this element.
Editor dialog icons (FindReplace, Hyperlink, Bookmark e t.c.) are incorrect.
If document contains comments, editor worked incorrectly with them.
Changes in licensing.
Incorrect work with PRE tag.
Incorrect work with content pasted from MS Word. (8540)
Issue with loading of HTML files having table with a <col/> tag, table becomes empty. (8779)
Paragraph styles aren't applied to the single text (without parent paragraph tag) in the tag with Flow-content. (8630)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20101.38    Build Date: Jan 08, 2010
=========================================================================================
Fixes:
 In some cases Selection.IsAnchorEnabled return incorrect result. (8471)
 Partial rollback of change "Heading styles are not applied to bulleted text in XML editor.". (8304)
 
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20101.37    Build Date: Dec 31, 2009
=========================================================================================
Fixes:
 Few button are disabled for text with collapsible sections with 'C1SectionCollapsed'/'c1sectionexpanded' styles (DocToHelp only). (8471)
 Add to the schema and validator methods for getting elements list by element type (inline, paragraph, table etc) (DocToHelp only).
 Heading styles are not applied to bulleted text in XML editor. (8304)
 Fixed self-detected bug for the 31779-Vyacheslavv-12-24-2009 
 Cell alignment set by Alignment group is not applied on newly added row/column. (7191)
 Heading styles formatting gets removed when user selects Horizontal line & clicks on clear formatting. (6970)
 HR tag in the selection is removed after executing ClearFormatting or ApplyStyle with paragraph-style arguments.
 
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20101.36    Build Date: Dec 18, 2009
=========================================================================================
Renamed C1XmlEditor to C1Editor.
Changes for licensing.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20101.35    Build Date: Dec 13, 2009
=========================================================================================
Fixes:
 On inserting a new table, cursor is shown outside the table. (8212)
 Cursor is incorrectly restored by the XmlSelectionKeeper, if the selection is inside empty tag. (8232, 8233)
 An unhandled exception is observed on adding commented </head> inside the <Head> tag of XHtml Document. (8264)
 No license entry is created when XmlToolstrip is added on the form. (8195)
 
Enhancements:
 Document in the Design and Preview modes is saved in the same way as in the Source mode, in the "formatted" form. Also document header and document type are saved in the Source mode. (2623)
 'xmlns' attribute for the 'html' tag is always shown in the Source mode, even if it isn't specified.
 
=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20093.34    Build Date: Nov 25, 2009
=========================================================================================
Fixes:
 Bug when using static method C1Editor.CheckAndFixXmlDocument: exception is raised if "customization" argument is null or empty. (for DocToHelp only)

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20093.33    Build Date: Nov 16, 2009
=========================================================================================
Changes in GUI strings.
Edited XML doc comments.
Toolbar icons updated in C1EditorToolStripMain and C1EditorToolStripObjects.

=========================================================================================
C1.Win.C1Editor.2.dll Build Number 2.0.20093.32    Build Date: Nov 9, 2009
=========================================================================================
Initial release version.
