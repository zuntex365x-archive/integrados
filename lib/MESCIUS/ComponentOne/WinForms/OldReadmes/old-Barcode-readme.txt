/////////////////////////////////////////////////////////////////////////////////////////
//
// Readme file for ComponentOne C1BarCode control
//
// C1.Win.C1BarCode.dll
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
C1.Win.C1BarCode.dll Build Number 4.0.20142.71   Build Date: June 26, 2014
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2014 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 4.0.20141.69   Build Date: February 22, 2014
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2014 build
 - Added "Studio for Desktop" product information

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 4.0.20133.67   Build Date: September 16, 2013
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2013 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 4.0.20132.66   Build Date: July 11, 2013
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Korean localization added

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 4.0.20132.65   Build Date: May 30, 2013
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2013 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 4.0.20131.62   Build Date: April 4, 2013
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Adjusted licensing for Japanese builds

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 4.0.20131.61   Build Date: January 23, 2013
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2013 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 4.0.20123.60   Build Date: October 23, 2012
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2012 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 4.0.20122.56   Build Date: August 13, 2012
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added Metro-style toolbox icons

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 4.0.20122.55   Build Date: July 9, 2012
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2012 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 4.0.20121.53   Build Date: February 16, 2012
========================================================================================= 

Corrections 
----------- 
- Modified GetImage(ImageFormat format, int width, int height) method to avoid 
  round-off errors (even if the resulting image becomes a little blurry)

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 4.0.20121.52   Build Date: January 11, 2012
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2012 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 4.0.20113.51   Build Date: November 24, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Updated licensing to conform with Federal Information Processing Standards requirements (TFS 18562)

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 4.0.20113.48   Build Date: September 9, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2011 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 4.0.20112.47   Build Date: June 8, 2011
========================================================================================= 

Corrections 
----------- 
- Automatic encoding failed for strings with lower-case characters (TFS 15642)
- Fixed bad assembly reference on one of the VB samples (TFS 4300)
- Fixed error message shown when assigning bad values to Encoding property (TFS 15681)
- Added missing descriptions for a few properties (TFS 15679)
- Encoding failed with Japanese/Chinese characters (TFS 15644)

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 4.0.20112.45   Build Date: May 8, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added a new control to the assembly: C1QRCode

	The new C1QRCode allows you to create one of the most popular 2D barcodes
	today, the QR (Quick Response) code.

    To use the C1QRCode control, simply set the Text property to the value 
	you want to encode.
    
	The control will show the QR image. If you want to include the QR image 
	in a document, use the Image property to retrieve an image of the barcode.
    
	The QR (Quick Response) format is one of the most popular 2D barcode 
	formats today, with free readers available for virtually all smart 
	phones.
    
	The main reasons for the popularity of the QR format are its 
    efficiency (it is very compact), flexibility (you don't need special 
    scanners to read it), and the fact that the original developer of 
    the format (the DENSO-WAVE company) made it an open and freely 
    available standard (ISO/IEC18004 and others).

	ENCODING LIMITS:
	Although the QR specification includes 40 'levels', the C1QRCode control 
	only implements levels 1 through 10. The table below summarizes the image
	sizes and content length supported by each level:

	Correction Level: L (higher correction levels reduce encoding capacity)
	
		Level(*) Size(**)	Numeric	  Alpha(***)	Bin
		1		 21x21		41		  25			17
		2		 25x25		77		  47			32
		3		 29x29		127		  77			53
		4		 33x33		187		  114			78
		5		 37x37		255		  154			78
		6		 41x41		322		  195			134
		7		 45x45		370		  224			154
		8		 49x49		461		  279			192
		9		 53x53		552		  335			230
		10		 57x57		652		  395			271	

	(*) Level (AKA "Encoding") can be set to "Automatic"
	(**) Image size in pixels
	(***) Alphanumeric characters supported are ([0-9][A-Z][$%*+-./:])

    For details on the QR format, please see:
		http://www.denso-wave.com/qrcode/qrstandard-e.html 
	and
		http://en.wikipedia.org/wiki/QR_code.

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 4.0.20112.44   Build Date: May 5, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2011 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 2.0.20111.43   Build Date: Dec 20, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2011 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 2.0.20103.42   Build Date: Sep 8, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2010 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 2.0.20102.41   Build Date: May 11, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2010 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 2.0.20101.40   Build Date: April 28, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 - Added .NET 4.0 version (with separate designer to support for Client profile)

/////////////////////////////////////////////////////////////////////////////////////////
//
// Below this point all builds are for .NET 2.x only
//
/////////////////////////////////////////////////////////////////////////////////////////

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 2.0.20101.38   Build Date: December 1, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2010 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 2.0.20093.36   Build Date: August 11, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2009 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 2.0.20092.34   Build Date: May 8, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2009 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 2.0.20091.27   Build Date: April 27, 2009
========================================================================================= 

Corrections 
----------- 
 * Code128 failed on strings that started with non-printable characters (e.g tabs)

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 2.0.20091.26   Build Date: January 5, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2009 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 2.0.20083.26   Build Date: August 13, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2008 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20082.25   Build Date: April 22, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2008 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20081.24   Build Date: February 19, 2008
========================================================================================= 

Corrections 
----------- 
 * Fixed check-digit calculation in EAN8 encoding (APRDS000317)

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20081.23   Build Date: January 19, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2008 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20073.20   Build Date: October 24, 2007
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added EncodingException property to provide a description of the encoding error, if any.
 * Improved encoding error messages for clarity.

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20073.18   Build Date: October 10, 2007
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added Upc-E encoding (about half the size of UPC-A).

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20073.17   Build Date: August 6, 2007
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2007 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20072.17   Build Date: March 19, 2007
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2007 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20071.16   Build Date: October 6, 2006
========================================================================================= 

Corrections 
----------- 
 * Improved rendering of code values code within CODE_C spans (VNBAR000036)

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20071.15   Build Date: October 2, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2007 build

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20063.14   Build Date: June 20, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2006 build
 * Added a GetImage method that allows you to obtain bitmaps with the barcode image.
   This method was added because the Image property always returns enhanced metafiles
   with a transparent background, and those cannot be easily converted into bitmaps.
 * Added a new encoding: UPC-A (it is similar to EAN-13, with one less digit).
 * Improved rendering of text in EAN and UPC barcodes.

Corrections 
----------- 
 * Improved rendering of code 128 FNC* values within CODE_C spans (VNBAR000033)

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20062.12   Build Date: February 20, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2006 build

Corrections 
----------- 
 * Fixed check-digit calculation in PostNet encoding (VNBAR000016)
 * Fixed 128 encoder to recognize explicit <Start-C code> ((char)0205) (VNBAR000029)

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20061.11   Build Date: November 10, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 * changed 128 encoder to allow encoding short codes (< 5 characters)

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20061.10   Build Date: October 19, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2006 build
 
 
=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20053.10   Build Date: September 23, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * improved error-checking on BarHeight, BarWide, BarNarrow properties (must be > 0, VNBAR000017)
 * implemented Zoom sizing mode (Whidbey only, VNBAR000020)
 
Corrections 
----------- 
 * fixed 128 encoder to allow starting with FNC codes
 * prevent rendering text when font size < 1 (VNBAR000019)
 

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20053.8   Build Date: May 30, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2005 build
 * Added new property:
   public BarDirectionEnum BarDirection
   Determines whether the barcode will be rendered horizontally or vertically.
 
Corrections 
----------- 
 ** fixed PostNet encoder (broken in build 2)
 ** fixed CodeI2of5 validator (this is a digit-only encoder)
 

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20052.6   Build Date: Feb 23, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added 'About C1BarCode' context menu
 * Added two new encodings: Ean8 and Ean13

Corrections 
----------- 
 ** fixed licensing message (mentioned wrong studio)
 ** fixed text rendering (could show blank for some fonts)


=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20044.3   Build Date: January 18, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Improved code 128 generation to use code C (more compact) when possible

Corrections 
----------- 
 ** none

=========================================================================================       
C1.Win.C1BarCode.dll Build Number 1.0.20044.2   Build Date: August 19, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 ** Added frame/control digit to PostNet bar code




/////////////////////////////////////////////////////////////////////////////////////////
//
// Readme file for ComponentOne C1BarCode control
//
/////////////////////////////////////////////////////////////////////////////////////////

** Background information:

The C1BarCode code was originally developed for use in the C1Report component, and has 
been a part of C1Report since build 151, released in May 2004.

We decided to package it as a stand-alone component because it can be useful in 
many applications besides reports. For example, you can use C1BarCode to add
barcode images to grid cells, to web pages, or to regular .NET PrintDocument
objects.

There are numerous commercial controls that create barcodes. We feel that C1BarCode
is a valuable addition to our Component Studios.

** What the control does:

The C1BarCode control creates barcode representations of alphanumeric values.

The main advantages of using the C1BarCode control instead of barcode fonts are:

	1) C1BarCode will automatically add any necessary control symbols and check 
	   sums to the value being encoded, depending on the encoding being used.
	   
	2) C1BarCode is a royalty-free dll, and can be deployed with your application 
	   like any regular assembly. Bar code fonts, on the other hand, must be 
	   installed into the client's Font directory (and you have to check that the
	   bar code fonts you are using are royalty-free).
	   
To use the C1BarCode control, set the CodeType property to the type of encoding you 
want to use, then set the Text property to the value you want to encode.

The control will show the barcode image. If you want to include the barcode in
a document, use the Image property to retrieve a resolution-independent image of 
the barcode.

For example:

	c1barcode1.CodeType = CodeTypeEnum.Code39;
        c1barcode1.Text = "123456";
        pictureBox1.Image = c1barcode1.Image;


** Supported encodings:

The C1BarCode control supports the following encodings:

 - Code39
	Code 39 is an alpha-numeric encoding also known as 3 of 9 and LOGMARS.
	This was the first alphanumeric symbology developed, and is one of the
	most widely used encodings.

- Code93
	Code 93 is an alpha-numeric encoding that is slightly denser than code 39.

- Code128
	Code 128 is a very high density alpha-numeric bar code. It can be used
	to encode values with 6 characters of more and will use the least amount 
	of space of any 1-D symbology. 

- CodeI2of5
	Code I2of5 is a numeric encoding. The symbol can be as long as necessary 
	to store the encoded data.

- Codabar
	Codabar may encode 16 different characters (0 through 9 plus -$:/.+), 
	plus an additional 4 start/stop characters (A through D). Codabar
	is used by some US blood banks, photo labs, and on FedEx air bills. 

- PostNet
	PostNet is a numeric encoding used by the US postal service. It differs 
	from most others in that it is based on the height of the bars rather than
	on their width.

// Create barcodes:
// http://www.idautomation.com/servercontrols/LinearServerControl.aspx
