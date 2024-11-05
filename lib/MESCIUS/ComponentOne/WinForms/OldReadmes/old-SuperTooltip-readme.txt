/////////////////////////////////////////////////////////////////////////////////////////
//
// Readme file for ComponentOne C1SuperTooltip library
//
// C1.Win.C1SuperTooltip.dll
//
/////////////////////////////////////////////////////////////////////////////////////////

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20142.143    Build Date: July 29, 2014
=========================================================================================

Corrections
------------------------------------------- 
- C1SuperErrorProvider could appear behind other controls. [70543]
- Fixed issue with paragraph spacing in HTML renderer [77892]

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20142.141    Build Date: July 18, 2014
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Chinese localization added. [67802]

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20142.140    Build Date: June 26, 2014
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V2/2014 build

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20141.139    Build Date: June 20, 2014
=========================================================================================

Corrections
------------------------------------------- 
- Improved handling of margins in div elements (TFS 60637)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20141.137    Build Date: February 24, 2014
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Internal C1Themes-related changes
- Added "Studio for Desktop" product information
- Honor style.cursor in tooltips when HitTestVisible is set to true
	http://our.componentone.com/groups/topic/supertooltip-mouse-hover-cursor/
	http://our.componentone.com/groups/topic/two-questions-add-event-link-support-c1supertooltip-use-c1supertooltip-and-c1topicbar/

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20141.134    Build Date: February 07, 2014
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V1/2014 build

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20133.133    Build Date: November 25, 2013
=========================================================================================

Corrections
------------------------------------------- 
- Setting BackgroundGradient to None at runtime did not reset the current gradient. [45423#1]
- Changing IsBalloon at runtime could result in incorrect rendering of text. [45423#2]

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20133.132    Build Date: November 07, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Internal C1Themes-related changes

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20133.131    Build Date: November 03, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Internal C1Themes-related changes

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20133.130    Build Date: October 23, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Internal C1Themes-related changes

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20133.129    Build Date: October 09, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- C1Themes support added

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20133.128    Build Date: October 4, 2013
=========================================================================================

Corrections
------------------------------------------- 
- Adjusted StripAmpersands to recognize "&#38;" in addition to "&amp;" (TFS 42676)
- Improved css parsing to support strike-through and underline (TFS 42927)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20133.126    Build Date: September 16, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V3/2013 build

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20132.125    Build Date: July 11, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Korean localization added

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20132.124    Build Date: May 30, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V2/2013 build

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20131.121    Build Date: April 4, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Adjusted licensing for Japanese builds

Corrections
------------------------------------------- 
- DrawToGraphics method rendered the image slightly smaller than it should.

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20131.118    Build Date: January 23, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V1/2013 build

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20123.117    Build Date: November 21, 2012
=========================================================================================

Corrections
------------------------------------------- 
- DrawToGraphics(Graphics, Rectangle) method didn't work reliably (TFS 27855)
- Do not hide Tooltips on mouse move if they are HitTestVisible (TFS 27835)
- Tooltip editor did not open if the C1SuperTooltip's name started or ended with underscore (TFS 30205)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20123.115    Build Date: November 8, 2012
=========================================================================================

Corrections
------------------------------------------- 
- Added a couple of missing Japanese localization strings

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20123.114    Build Date: October 23, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V3/2012 build

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20122.113    Build Date: August 13, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added Metro-style toolbox items.

Corrections
------------------------------------------- 
- Fixed C1SuperLabel design-time editor to support the RightToLeft property (TFS 25937)
- Improved handling of span tags not enclosed in div tags (TFS 25936)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20122.109    Build Date: August 10, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added support for bi-directional text (right-to-left, TFS 17139).

	Right-to-left text is commonly used to render Arabic and Hebrew text.

	To enable right-to-left, add a "direction:rtl" attribute to the css styles
	(or add a "dir=rtl" attribute to the html tags).

	For example:

	<html>
		<body dir='ltr'>
			<p><b>Arabic:</b></p>
				<p style='direction:rtl'>سلام دوست من حال شما چطوره شما</p>
				<p dir='rtl'>سلام دوست من حال شما چطوره شما</p>
			<p><b>Hebrew:</b></p>
				<p style='direction:rtl'>לאיראן היא מציאתה של דרך</p>
				<p dir='rtl'>לאיראן היא מציאתה של דרך</p>
		</body>
	</html>


=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20122.107    Build Date: July 9, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V2/2012 build

Corrections
------------------------------------------- 
- Fixed design-time issue with tooltips in ToolStripTextBox objects (TFS 23304)
- Fixed an issue in error provider: blinking does not resume after hovering the mouse
  pointer over the error icon if the BlinkStyle is set to 'AlwaysBlink' (TFS 23291)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20121.103    Build Date: February 18, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added Eastern language word-wrapping support (Japanese, Chinese, Korean)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20121.99    Build Date: January 19, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added support for Padding property to C1SuperLabel control (TFS 18479)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20121.98    Build Date: January 11, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V1/2012 build

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20113.97    Build Date: November 24, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Updated licensing to conform with Federal Information Processing Standards requirements (TFS 18562)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20113.95    Build Date: October 14, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Enhanced licensing in environments with some security policy restrictions

Corrections
------------------------------------------- 
- Improved handling of tab characters in pre-formatted spans (TFS 17194)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20113.93    Build Date: September 9, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V3/2011 build

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20111.92    Build Date: September 6, 2011
=========================================================================================

Corrections
------------------------------------------- 
- Fixed issue with overlapping span styles (TFS 17072)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20111.91    Build Date: August 31, 2011
=========================================================================================

Corrections
------------------------------------------- 
- Handle tab characters in pre-formatted spans (TFS 17000)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20111.90    Build Date: May 5, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V2/2011 build

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20111.89    Build Date: Mar 23, 2011
=========================================================================================

Corrections
------------------------------------------- 
- Fixed a potential design-time issue that may occur on a machine with multiple installed
  versions of C1SuperTooltip for .NET 4.x.

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20111.88    Build Date: Feb 2, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V1/2011 build
- Adding a C1SuperErrorProvider from the toolbox also creates a C1SuperTooltip and
  automatically connects it to the error provider.

Corrections
------------------------------------------- 
- The ToolTip property editor did not appear in VS2010 with German locale (13248)
- Improved behavior of HTML editor for C1SuperTooltip and C1SuperLabel (13976)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20103.86    Build Date: Dec 7, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added a toolbar to the Office tab in the SuperTooltip designer

- Added new C1SuperErrorProvider component

  The C1SuperErrorProvider is similar to the standard ErrorProvider component, except
  it allows you do display rich error information using HTML (instead of plain text).

  You can, for example, use icons and bold red titles for the error indicators, and
  include bold and italic text in the error description, making the error messages
  clearer to the user.

  Here is an example:

    // instead of
    //errorProvider.SetError(_txtCountry, "The 'Country' field is required.");

    // you can use this
    c1superErrorProvider.SetError(_txtCountry,
        "<img src='res://errorIcon.png/> <b>Invalid Country</b><br/>" +
        "<p>The <b>Country</b> field is required. We need it in order to ship the product.</p>");

  You can take a look at the SuperErrorProvider sample for more advanced examples.

  With the new component you can use a simple image (instead of icon) to indicate
  an error. Also, it extends functionality beyond the standard ErrorProvider component
  by adding the IconClick/IconDoubleClick events and the ImageHot property which allows
  to get feedback when the mouse pointer hovers over the error icon.

Corrections
------------------------------------------- 
- SuperTooltip designer remembers its layout settings until the user closes VS IDE

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20103.85    Build Date: Sep 17, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V3/2010 build

- Added HitTestVisible property and LinkClicked event to the C1SuperTooltip component.

  By default, the C1SuperTooltip is invisible to the mouse (all mouse events are passed
  directly to the control under the tooltip). Setting the HitTestVisible property to true
  makes the tooltip visible to the mouse, so you can add hyperlinks and other clickable
  elements to the tooltip.

  For example, the code below creates a tooltip that contains a clickable hyperlink and
  handles clicks on the tooltip hyperlink:

    _c1ttHitTestable.HitTestVisible = true;
    _c1ttHitTestable.SetToolTip(
        button1, 
        "<a href='destination'>This is a hyperlink in a tooltip.</a>");
    _c1ttHitTestable.LinkClicked += _c1ttHitTestable_LinkClicked;

    void _c1ttHitTestable_LinkClicked(object sender, C1SuperLabelLinkClickedEventArgs e)
    {
        MessageBox.Show("You clicked the hyperlink in the tooltip!");
    }

  More details about this feature can be found here:
	http://helpcentral.componentone.com/CS/winforms_31/f/55/t/85144.aspx


=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20102.83    Build Date: June 1, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V2/2010 build

Corrections
------------------------------------------- 
- Designer closed when user typed comments (<!-- comment -->) [10730]
- SuperTooltip designer did not work at design time on Japanese systems

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20101.78    Build Date: May 10, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Improved designer (added toolstrip with common formatting options)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20101.77    Build Date: April 11, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added .NET 4.0 version

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20101.76    Build Date: March 25, 2010
=========================================================================================

Corrections
------------------------------------------- 
- Tooltips were not always positioned correctly on multi-monitor setups (8878)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20101.75    Build Date: March 17, 2010
=========================================================================================

Corrections
------------------------------------------- 
- Html css parser could throw null reference exception when handling border attributes (9671)
- Html rendering rendered comments that contained quotes (9685)
- Html renderer did not break lines on hyphens
- Table autosizing did not account for border width correctly

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20101.74    Build Date: February 17, 2010
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Removed dependency on System.Web.dll (not included in VS2010 Client Profile)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20101.72    Build Date: December 17, 2009
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V1/2010 build
- Added Opacity property to C1SuperTooltip so it is possible to allow users to see 
  the content under the tooltip.
  
=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20093.70    Build Date: October 28, 2009
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Support adding tooltips to WinForms controls hosted in MFC applications.

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20093.69    Build Date: August 11, 2009
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V3/2009 build

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20092.67    Build Date: May 8, 2009
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V2/2009 build
- Added overload to C1SuperLabel.DrawToGraphics method:

	public int DrawToGraphics(Graphics g, RectangleF bounds, int offset)
	
	This allows rendering Html content onto multiple pages. The "offset" parameter 
	represents a vertical offset into the document. It should start as zero. Each call
	to this method returns the offset to be used in the nex call (on a different page).
	
	For example, the code below renders a long HTML document into a .NET PrintDocument
	object:

    public class HtmlPrintDocument : PrintDocument
    {
        string _html;
        int _offset;
        C1SuperLabel _label;

        public XhtmlPrintDocument(string html)
        {
            _html = html;
        }
        protected override void OnBeginPrint(PrintEventArgs e)
        {
            _offset = 0;
            _label = new C1SuperLabel();
            _label.Text = _html;
        }
        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            // calculate bounds
            var rc = e.MarginBounds;
            float scale = 96f / 100f;
            var bounds = new RectangleF(
                rc.Left * scale, rc.Top * scale,
                rc.Width * scale, rc.Height * scale);

            // render from current offset
            var newOffset = _label.DrawToGraphics(e.Graphics, bounds, _offset);

            // update offset
            e.HasMorePages = newOffset != _offset && newOffset < int.MaxValue;
            _offset = newOffset;
        }
    }
	


Corrections
------------------------------------------- 
- Fixed problem that caused the HTML parser to fail under certain circumstances (4656)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20091.57    Build Date: January 5, 2009
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V1/2009 build

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20083.56    Build Date: September 24, 2008
=========================================================================================

Corrections
------------------------------------------- 
- RemoveAll method did not hide the current tooltip (18075)
- Improved licensing to handle embedding in user controls (17904)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20083.54    Build Date: August 13, 2008
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V3/2008 build

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20082.52    Build Date: August 10, 2008
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added support for animated images (e.g. GIF files)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20082.53    Build Date: August 5, 2008
=========================================================================================

Corrections
------------------------------------------- 
- Setting tooltip on ContextMenuStrip could cause crash at design time (17657)
- Trying to show the tip for a context menu that was just closed could throw exception (11380)
- Balloon tip got clipped when shown too close to the edges of the screen (11393)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20082.52    Build Date: July 14, 2008
=========================================================================================

Corrections
------------------------------------------- 
- Could throw exception when disposing of tips in MDI child forms (Issue ID 11381)

=========================================================================================
>>>>>>> 1.48
C1.Win.C1SuperTooltip.dll Build Number 2.0.20082.51    Build Date: April 24, 2008
=========================================================================================

Corrections
------------------------------------------- 
- Tooltip didn't work for ContextMenuStrip controls (VNHTM000103)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20082.50    Build Date: April 22, 2008
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V2/2008 build

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20081.49    Build Date: March 9, 2008
=========================================================================================

Corrections
-----------
- Tooltip didn't work for menustrip sub items (VNHTM000100, VNHTM000103, VNHTM000097)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20081.48    Build Date: January 19, 2008
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V1/2008 build

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20073.44    Build Date: September 14, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Simplified syntax for referring to images in the "Images" collection (made 'res://' optional).

Corrections
-----------
- Popup event of C1SuperTooltip control fired continuously when setting e.Cancel = True (VNHTM000099) 

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20073.43    Build Date: August 22, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added Text property to PopupEventArgs class.

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20073.42    Build Date: August 6, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V3/2007 build
- Added UseMnemonic property to C1SuperLabel to enhance compatibility with standard Label control.

Corrections
-----------
- Exception occurred sometimes when disposing parent MDI forms

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20072.41    Build Date: July 30, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added Japanese localization for all new properties/events.

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20072.40    Build Date: May 25, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added Popup event that can be used to adjust the position of the tooltip or to prevent
  the tooltip from being displayed.
  A typical use for this event is when the tooltip is used with a ribbon control. The 
  ribbon adjusts the tooltip position so it always appears immediately below the ribbon
  itself, rather than below the control that is providing the tooltip text.
  
=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20072.39    Build Date: April 25, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added MaximumWidth property to C1SuperTooltip. This is an easy way to wrap the Html
  content in the tooltip without adding <br> tags to the tooltip text.

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20072.38    Build Date: April 17, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- V2/2007 build

Corrections
-----------
- Tooltips appear behind form when the form is Topmost and UseFading is set as False. (VNHTM000092, VNHTM000093)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.36	Build Date: March 15, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added support for subscripts/superscripts (<sub>, <sup> tags)


=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.35	Build Date: February 21, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added three new methods to C1SuperLabel control:

    public Size Measure()
    - Measures the width and height of the control content.
			
    public Size Measure(int width)
    - Measures the height of the control content when rendered with a given width.
			
    public void DrawToGraphics(Graphics g, Rectangle bounds)
    - Draws the control content into a given Graphics object.
    
  These new methods make it easy to render Html content into arbitrary Graphics objects
  such as those in OwnerDraw controls and in PrintDocument objects.
  
- Added new methods and an event to the ImageCollection class:

	public void Add(ImageList)
	
	Allows you to add the images in an ImageList component to the Images collection
	of a C1SuperLabel or C1SuperTooltip. For example:
	
		// make images in imageList1 available to the label and the tooltip
		this.c1SuperLabel1.Images.Add(this.imageList1);
		this.c1SuperTooltip1.Images.Add(this.imageList1);

		// build html string to show all images in an image list
		StringBuilder sb = new StringBuilder();
		sb.Append("These are all the images in <b>imageList1:</b><br><table>");
		foreach (string key in imageList1.Images.Keys)
			sb.AppendFormat("<tr><td>{0}<td><img src='res://{0}'>", key);
		sb.Append("</table>");

		// assign string to SuperLabel and tooltip
		this.c1SuperLabel1.Text = sb.ToString();
		this.c1SuperTooltip1.SetToolTip(this.c1SuperLabel1, this.c1SuperLabel1.Text);
  

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.33	Build Date: February 19, 2007
=========================================================================================

Corrections
-----------
- Ensure tip window is topmost even when owner form is topmost as well.

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.32	Build Date: February 8, 2007
=========================================================================================

Corrections
-----------
- On Japanese systems, font in the C1SuperTooltip Editor Window changes while typing (VNHTM000080, again)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.31	Build Date: January 23, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Allow adding tooltips to composite controls (e.g. controls that inherit from UserControl, VNSCH000145)

Corrections
-----------
- On Japanese systems, font in the C1SuperTooltip Editor Window changes while typing (VNHTM000080)
- Shadow property did not work under Vista

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.28	Build Date: January 17, 2007
=========================================================================================

Corrections
-----------
* Delta fixes:
  - Added support for RGB color notation in html (VNHTM000059)
  - Hide tip when mouse is clicked even if ShowAlways = true (VNHTM000068) 
  - Improved tooltip placement when width is larger than screen (VNHTM000069)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.25	Build Date: January 9, 2007
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added new property: RoundedCorners
  Setting this property to true makes the tooltip window display rounded corners.
  This property has no effect when IsBalloon is set to true (in that case, the corners are always rounded).
* Improved design-time support under Japanese systems.
* Setting BackGroundGradient to none caused bad tooltip background (VNHTM000077, VNHTM000078) 

Corrections
-----------
* Delta fixes:
  - An empty tooltip appears when the IsBalloon property is changed and the tooltip is visible (VNHTM000085) 
  - Tooltip not displayed consistently on the ToolStrip items (VNHTM000084) 

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.22	Build Date: December 26, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* New properties (for more compatibility with standard ToolTip component):
	public bool StripAmpersands 
	public bool UseFading

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.21	Build Date: December 19, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Do not show tip while context menus are visible (VNHTM000063)
* Fixed ShowAlways property so tips appear on forms that are not active (VNHTM000065) 

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.20	Build Date: December 15, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Improved designer localization.
* Changed ImageEntry persistence mechanism to make it version-neutral (and allow easier project upgrades).

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.16	Build Date: December 8, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added Show/Hide overloads for ToolStripItems (in addition to controls).

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.14	Build Date: December 6, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added scrollbars to designer preview.

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.14	Build Date: December 5, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Enabled GrapeCity licensing.

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.13	Build Date: November 30, 2006
=========================================================================================

Corrections
-----------
* Delta fixes:
  - SnapLines bug caused design-time crash for some complex layouts. (VNHTM000057)
  - BackgroundImageLayout.Zoom did not center zoomed image in C1SuperLabel (but did in C1SuperTooltip).  (VNHTM000047)

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.12	Build Date: November 27, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added new LinkClicked event.

  If the Html string contained in the Text property contains hyperlinks ("A" tags), then
  the control will monitor the mouse for clicks on the hyperlinks. If the user clicks 
  a hyperlink, the control fires the new LinkClicked event. The event handler may check
  the value of the event parameters (HRef and Target) and take appropriate action.
  
  For example:
  
	// configure c1superLabel
	c1superLabel.AutoSize = true;
	c1superLabel.Text =
		"click <a href='about'><b>HERE</b></a> to see an about box.<br>" +
		"or click <a href='time'><b>HERE</b></a> to see the current time.";

	// attach event handler
	c1superLabel.LinkClicked += new C1SuperLabelLinkClickedEventHandler(c1superLabel_LinkClicked);
	// ...

	void c1superLabel_LinkClicked(object sender, C1SuperLabelLinkClickedEventArgs e)
	{
	  if (e.HRef == "about")
	  {
		MessageBox.Show("About C1SuperLabel!");
	  }
	  else if (e.HRef == "time")
	  {
		MessageBox.Show("The time is " + DateTime.Now.ToShortTimeString());
	  }
	}


=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.11	Build Date: October 30, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* none

Corrections
-----------
* Delta fixes:
	- ToolStripButton lost hot state when C1SuperToolTip is displayed for the button with 'IsBalloon' set as FALSE  (VNHTM000040) 
	- Adjusted Tooltip position to show at the bottom of the cursor  (VNHTM000041) 
	- 'ControlAdded'/'ControlRemoved' events fire when cursor moves in/out of ToolStripButton configured with C1SuperToolTip  (VNHTM000042) 
	- Top/Bottom separators of 'Office' style tooltip are right aligned  (VNHTM000043) 
	- Balloon tip looks strange when text is too narrow (e.g. one character)  (VNHTM000044) 


=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.10	Build Date: October 26, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* none

Corrections
-----------
* Delta fixes:
	- Tooltip does not appear on first mouse move.  (VNHTM000018) 
	- Improved tooltip wizard template to close all HTML tags (VNHTM000027)
	- Added smart tag to C1SuperLabel for editing the label text (VNHTM000029) 
	- Value of 'AutoPopDelay' property is set to 5 times of value of 'AutomaticDelay' (instead of 10) (VNHTM000031)
	- Scrollbars in Title/Subtitle text boxes in C1SuperTooltip Editor makes the text not readable  (VNHTM000032) 
	- When an string with spaces is set as tooltip text causes a small rectangle to displayed as tooltip  (VNHTM000033)
	- Large images are cropped C1SuperTooltip wizard  (VNHTM000034) 
	- Tooltip is not displayed at the coordinates as specified in the Show() method  (VNHTM000037) 
	- Problems setting BackGroundImage property in Tooltip wizard property page  (VNHTM000020) 
	- ToolTip not functional for ToolStipItems when the form containing the strip is a MDIchild  (VNHTM000028) 
	- Glyph overhangs being clipped in bold italic text.  (VNHTM000021) 


=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20071.9	Build Date: October 19, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added Show() and Hide() methods to improve compatibility with standard tooltip component

Corrections
-----------
* ensure tooltip is repainted immediately when tip text changes

=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20063.8	Build Date: September 29, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Improved designer: made office template create tips more similar to Office2007.


=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20063.7	Build Date: September 18, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added BackgroundGradient property.
* Improved designer: added Images property to support adding images to labels/tips at design time.

Corrections
-----------
* Designer did not always persist new images correctly.


=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20063.6	Build Date: September 4, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added editor to SuperLabel Text property.

Corrections
-----------
* 'BackgroundImageLayoutChanged' in C1SuperLabel did not fire (VNHTM000013).
* Incompatibility between C1Superlabel 'Dock' and 'AutoSize' properties (VNHTM000015).
* Wizard could cause SuperTooltip to disappear from the design surface (VNHTM000011).
* ClientSizeChanged fired too many times (VNHTM000014).
* SuperTooltip re-showing without mouse movement (VNHTM000012).


=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20063.5	Build Date: August 31, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added editor for SupertTooltip.


=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20063.3	Build Date: August 24, 2006
=========================================================================================

Corrections
-----------
* Improved rendering of underlined text to make underline continuous (VNHTM000001).
* IsBalloon was not honored until a different control was selected (VNHTM000002).
* Showing several tooltips on the same form could cause form deactivation (VNHTM000003).
* Background image didn't render correctly when BackColor = Transparent (VNHTM000005).
* SuperTooltip BorderColor ignored in some scenarios (VNHTM000010).
* SuperTooltip flickers in some scenarios (VNHTM000012).


=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20063.2	Build Date: July 16, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added IsBalloon property to allow showing tooltip in a balloon instead of rectangle


=========================================================================================
C1.Win.C1SuperTooltip.dll Build Number 2.0.20063.1	Build Date: June 12, 2006
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* V3/2006 build


=========================================================================================

C1SuperTooltip is a library that contains two components:

C1SuperTooltip is similar to the standard ToolTip component, except it displays HTML 
content instead of plain text.

C1SuperLabel is similar to the standard Label control, except is displays HTML content
instead of plain text.

C1SuperTooltip does not use or rely on IE. It has its own light-weight HTML parser and renderer,
completely written in C#. The C1SuperTooltip renderer supports most HTML features including
cascading style sheets, tables, and images.

Because C1SuperTooltip doesn't use IE, HTML content may sometimes look slightly different in 
C1SuperTooltip than it does in IE. Because C1SuperTooltip doesn't use IE, it will load and display
much faster, and will not be subject the security concerns usually associated with
the Browser control.
