/////////////////////////////////////////////////////////////////////////////////////////
//
// Readme file for ComponentOne C1Zip
//
// C1.C1Zip.dll
//
/////////////////////////////////////////////////////////////////////////////////////////

=========================================================================================
C1.C1Zip.dll Build Number 2.1.20142.108		Build Date: Jun 26, 2014
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2014 build

=========================================================================================
C1.C1Zip.dll Build Number 2.1.20141.107		Build Date: Apr 22, 2014
=========================================================================================

Corrections 
-----------
* Fixed error when processing large files (>4GB). [63091]

=========================================================================================
C1.C1Zip.dll Build Number 2.1.20141.106		Build Date: Feb 08, 2014
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2014 build

=========================================================================================
C1.C1Zip.dll Build Number 2.1.20133.105		Build Date: Dec 26, 2013
=========================================================================================

Corrections 
-----------
 * Fixed Length parameter in Progress event (TFS 48361, broken in build 94, partial fix in 103)

=========================================================================================
C1.C1Zip.dll Build Number 2.1.20133.104		Build Date: Sep 16, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2013 build

=========================================================================================
C1.C1Zip.dll Build Number 2.1.20132.103		Build Date: Sep 9, 2013
=========================================================================================

Corrections 
-----------
 * Length parameter in Progress event was always set to int.MaxValue (TFS 41637, broken in build 94)

=========================================================================================
C1.C1Zip.dll Build Number 2.1.20132.102		Build Date: May 30, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2013 build

=========================================================================================
C1.C1Zip.dll Build Number 2.1.20131.101		Build Date: January 23, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2013 build

=========================================================================================
C1.C1Zip.dll Build Number 2.1.20123.100		Build Date: December 12, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Use CurrentUICulture encoding to interpret file names (TFS 30097)
  Although the zip format does not specify a culture for this, Windows and other
  zip utilities do use the CurrentUICulture.

=========================================================================================
C1.C1Zip.dll Build Number 2.1.20123.98		Build Date: November 6, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 - Added a UseUtf8Encoding property to allow storing file names and comments as UTF8 strings. (TFS 29748)

	The Zip specification does not specify what character encoding to be used for the 
    embedded file names and comments. The original IBM PC character encoding set, 
    commonly referred to as IBM Code Page 437, is supposed to be the only encoding supported.
    
	Because of this, some zip utilities will not allow storing file names or comments with 
    Unicode characters. Others do allow it, but those file names and comments may not be
    read correctly by other utilities.
    
	Setting the <b>UseUtf8Encoding</b> to true causes C1Zip to store and retrieve
    file names and comments using the Utf8 encoding, which allows Unicode characters. The
    caveat is that Unicode file names may not be read correctly by other zip utilities.

=========================================================================================
C1.C1Zip.dll Build Number 2.1.20123.97		Build Date: October 23, 2012
=========================================================================================

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2012 build

=========================================================================================
C1.C1Zip.dll Build Number 2.1.20122.96		Build Date: August 7, 2012
=========================================================================================

* Improvements:
-----------
- Optimized decompression speed (under some scenarios, decompression is now up to 5x faster)
	
Corrections 
-----------
- Honor date parameter in Add method also for files (used to be only for streams; TFS 10242)

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20122.94		Build Date: June 28, 2012
========================================================================================= 

Corrections 
-----------
- Method C1ZipEntryCollection.Add(sourceStream, entryName) did not work correctly 
  for compressed source streams (TFS 23671)

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20122.93		Build Date: June 11, 2012
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2012 build

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20121.92		Build Date: January 20, 2012
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2012 build

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20113.90		Build Date: December 18, 2011
========================================================================================= 

Corrections 
-----------
- Fixed zip64 extensions to work with WinZip, WinRAR, 7-Zip, and Windows OS (TFS 17922, 17569)

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20113.79		Build Date: September 9, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2011 build

=========================================================================================       
C1.C1Zip.dll Build Number 4.1.20112.78		Build Date: August 22, 2011
========================================================================================= 

Corrections 
-----------
- Fixed modifications made in 77 (bad build!)
- Empty folders were zipped and unzipped as zero-length files (TFS 4121)

=========================================================================================       
C1.C1Zip.dll Build Number 4.1.20112.77		Build Date: June 1, 2011
========================================================================================= 

Corrections 
-----------
- Exception could occur when compressing large (> 1 meg) blocks with BestCompression (TFS 15568)

=========================================================================================       
C1.C1Zip.dll Build Number 4.1.20112.76		Build Date: May 5, 2011
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2011 build

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20111.75		Build Date: April 30, 2011
========================================================================================= 

Corrections 
-----------
- Fixed IsZipFile method to return false when the stream doesn't support Seek
	(Seek is required for all zip streams)

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20111.74		Build Date: December 20, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2011 build

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20103.73		Build Date: December 2, 2010
========================================================================================= 

Corrections 
-----------
- Fixed Zip64 issue.
  Headers were not written correctly for entries larger then 4 gigabytes.

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20103.71		Build Date: Sep 17, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2010 build

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20102.69		Build Date: August 5, 2010
========================================================================================= 

Corrections 
-----------
- IsZipFile method did not always close the file being tested properly.

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20102.68		Build Date: June 11, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added support for Zip64 files.
  This allows for entries longer than the usual 4gig limit and also more entries
  per Zip file.
  
  The old and new limits are as follows:
	- Maximum number of entries per ZIP file:
		before: 65,535			(ushort.MaxValue)
		after:	2,147,483,647	(int.MaxValue)
	- Maximum uncompressed entry size:	
		before: 4,294,967,295	(uint.MaxValue)
		after:	9,223,372,036,854,775,807	(long.MaxValue)
  
  To keep compatibility with previous versions, we kept all properties related to
  file size and position as type Int32 (int). However, because of the new limits, 
  these properties may not be able to represent all file sizes and offsets. To 
  accommodate this, we added corresponding properties of type Int64 (long). These
  new properties have the same name as the old ones with a "Long" suffix added.

  These are the new properties:
  
	C1ZipEntry, C1ZStreamReader, C1ZStreamWriter:
		public long SizeCompressedLong
		public long SizeUncompressedLong
		
	ZipProgressEventArgs:
		public long FileLengthLong
		public long PositionLong
		
	

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20102.65		Build Date: June 7, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2010 build

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20101.64		Build Date: April 16, 2010
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
- Added overloads to allow specifying an entry's last modified date.
	ZipEntryCollection.Add(string fileName, string entryName, DateTime dateTime);
	ZipEntryCollection.Add(Stream stream, string entryName, DateTime dateTime);
	ZipEntryCollection.OpenWriter(string entryName, DateTime dateTime, bool useMemory)
- Added .NET 4.0 version
	
=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20101.62		Build Date: December 17, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2010 build

Corrections 
-----------
 * Could throw bounds-checking exception when deflating streams under very rare conditions.

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20093.61		Build Date: August 11, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2009 build

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20092.58		Build Date: May 8, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2009 build

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20091.57 Build Date: January 5, 2009
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2009 build

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20083.56 Build Date: November 27, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Added Extract and Remove methods to the C1ZipEntry class
 * Improved bounds-checking for maximum file sizes and number of entries in zip files.

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20083.55 Build Date: August 13, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2008 build

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20082.54 Build Date: July 8, 2008
========================================================================================= 

Corrections 
----------- 
 * Improved handling of file permissions 
   (mainly to allow reading XLSX files that are already open in Excel)

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20082.53 Build Date: May 20, 2008
========================================================================================= 

Corrections 
----------- 
 * Could throw when compressing very long streams without intermediate flushes (VNZIP000051)

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20082.52 Build Date: April 24, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2008 build

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20081.51 Build Date: January 19, 2008
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2008 build
 * improved licensing code to accept new keys

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20073.48 Build Date: November 26, 2007
========================================================================================= 

Corrections 
----------- 
* Fixed loading stored (uncompressed) streams with non-zero offset (VNXLS000358).

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20073.47 Build Date: November 16, 2007
========================================================================================= 

Corrections 
----------- 
* Support up to 65,535 entries per zip file (previous version only allowed up to 32,767).

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20073.46 Build Date: October 30, 2007
========================================================================================= 

Corrections 
----------- 
* Handle zip entries with invalid date/time values.


=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20073.44 Build Date: September 12, 2007
========================================================================================= 

Corrections 
----------- 
* Fixed loading stored (uncompressed) streams with non-zero offset (VNXLS000358).


=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20073.43 Build Date: August 6, 2007
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* V3/2007 build


=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20072.43 Build Date: June 19, 2007
========================================================================================= 

Corrections 
----------- 
* Improved stream-end test while reading compressed streams (VNXLS000329).


=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20072.41 Build Date: March 19, 2007
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* V2/2007 build


=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20071.40 Build Date: February 26, 2007
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added the ability to read and write to zip files stored in streams in addition 
  to actual files.
	
	C1ZipFile.Open(Stream)
	
	This allows reading zip files embedded in application resources or stored in database
	fields instead of in actual files.
	
	For example:
	
        // get Stream from application resources
        System.Reflection.Assembly a = this.GetType().Assembly;
        using (Stream stream = a.GetManifestResourceStream("MyApp.test.zip"))
        {
          // open C1ZipFile on the stream
          zip.Open(stream);
        
          // enumerate the entries in the zip file,
          foreach (C1ZipEntry ze in zip.Entries)
          {
            // show entries that have a 'txt' extension.
            if (ze.FileName.ToLower().EndsWith(".txt"))
            {
              using (StreamReader sr = new StreamReader(ze.OpenReader()))
              {
                MessageBox.Show(sr.ReadToEnd(), ze.FileName);
              }
            }
          }
        }
	

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20071.39  Build Date: November 3, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
* Added a new method to C1ZipEntry:

	public bool CheckPassword()
	
	This method checks whether the entry can be opened using the current password.
	This is more efficient than using a try/catch block and trying to open the entry
	to determine whether the current password is valid for the entry.


=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20071.38  Build Date: October 2, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2007 drop

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20063.38  Build Date: July 18, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none

Corrections 
----------- 
 * AddFolder method did not add empty sub-folders to zip file (VNZIP000042)

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20063.37  Build Date: June 12, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2006 drop

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20062.37  Build Date: January 26, 2006
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V2/2006 drop

 - added new constructor to create and automatically open/create zip file:
	public C1ZipFile(string fileName, bool create)
        
 - added methods to compress and expand folders preserving folder structure:
   C1ZipFile.Entries.AddFolder(string path [, string searchPattern][, bool includeSubFolders]);
   C1ZipFile.Entries.ExtractFolder(string path);
 
 - added methods to inspect the entry collection: 
   C1ZipFile.Entries.Contains(string entryName)
   C1ZipFile.Entries.IndexOf(string entryName)

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20061.36  Build Date: October 2, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V1/2006 drop

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20053.36  Build Date: July 6, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2005 drop
 * improved international support (better than what was added in build 32)
 
=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20052.35  Build Date: February 28, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * add finally clause to ensure temp file is deleted even when there are errors (VNZIP000035)
 	
Corrections 
----------- 
 * Extracting entries in OpenBatch mode closed the batch (VNZIP000036, VNZIP000037) 

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20052.34  Build Date: January 28, 2005
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * V3/2005 build
 * added Japanese localization (error messages only)
 	
Corrections 
----------- 
 * improved thread-safety

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20051.33  Build Date: November 15, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * improved exception messages (more consistent and detailed).
 	
Corrections 
----------- 
 * Honor OverwriteHidden property under Compact Framework.

=========================================================================================       
C1.C1Zip.dll Build Number 2.1.20051.32  Build Date: October 15, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Q1/2005 build
 * New Methods: 
    - OpenBatch/CloseBatch
      By default, C1ZipFile opens and closes the zip file automatically whenever entries 
      are added or removed.
	  This can cause delays in systems that have certain types of anti-virus software 
	  installed, or in situations where you want to add a large number of relatively 
	  small entries. In these cases, use the OpenBatch and CloseBatch methods to keep 
	  the zip file open until the entire operation is concluded.
 * New Properties: 
	- MemoryThreshold
	  Gets or sets the size of the largest stream to be compressed in memory. Files larger
	  than this are compressed into a temporary file.
	- TempFileName
	  Gets or sets the name of the temporary file to use when compressing into files 
	  (see MemoryThreshold property above). If set to an empty string, C1Zip creates the 
	  file name automatically using Path.GetTempFileName.
  * support extra international characters in file names (use codepage 850, OEM multi-lingual Latin I)	  
	
Corrections 
----------- 
 * none


=========================================================================================       
C1.C1Zip.dll Build Number 1.1.20044.31  Build Date: September 29, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none
	
Corrections 
----------- 
 * fixed problem extracting encrypted and uncompressed (stored) entries from zip archives


=========================================================================================       
C1.C1Zip.dll Build Number 1.1.20044.30  Build Date: July 19, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Q4/2004 drop
 * added Xml documentation for use with D2H Documenter
	
Corrections 
----------- 
 * none


=========================================================================================       
C1.C1Zip.dll Build Number 1.1.20043.30  Build Date: April 19, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Q3/2004 drop
	
Corrections 
----------- 
 * none


=========================================================================================       
C1.C1Zip.dll Build Number 1.1.20042.30  Build Date: April 5, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Improved international support
	C1Zip now encodes entry names and comments using the current code page
	This allows it to handle Japanese file names and comments.
	
Corrections 
----------- 
 * fire Progress event even when adding entries with zero length
 * watch out for repeated indices when removing entries by index list


=========================================================================================       
C1.C1Zip.dll Build Number 1.1.20042.27   Build Date: March 1, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * new properties: 
	public bool OverwriteHidden {get;set;}
	public bool OverwriteSystem {get;set;}
	Get or set whether the component should write over existing hidden and system files 
	when extracting zip entries. (Previous versions already had OverwriteReadOnly property).
	
Corrections 
----------- 
 * Extract empty files (zero length)
 * Don't extract entries over zip file itself (now throws an Exception)
 * Better error handling/messages for unsupported compression methods in Zip files (e.g. Shrink)
 

=========================================================================================       
C1.C1Zip.dll Build Number 1.1.20042.26   Build Date: February 9, 2004
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Q2/2004 build
	
Corrections 
----------- 
 * none
 

=========================================================================================       
C1.C1Zip.dll Build Number 1.1.20041.26   Build Date: November 10, 2003 
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none
	
Corrections 
----------- 
 * C1ZipFile didn't honor CompressionLevel property
 * When expanding, set date before attributes (in case the file is read-only)
 

=========================================================================================       
C1.C1Zip.dll Build Number 1.1.20041.25   Build Date: November 10, 2003 
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * none
	
Corrections 
----------- 
 * Preserve file attributes when unzipping
 
=========================================================================================       
C1.C1Zip.dll Build Number 1.1.20041.24   Build Date: November 10, 2003 
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * OpenReader now opens in read-only mode (allow several simultaneous readers on the same entry)
	
Corrections 
----------- 
 * None

=========================================================================================       
C1.C1Zip.dll Build Number 1.1.20041.23   Build Date: October 22, 2003 
========================================================================================= 

Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
 * Q1/2004 drop
	
Corrections 
----------- 
 * None
 
1.1.20034.23 - October 21
	Allow adding files that are open for reading (use FileShare.ReadWrite instead of FileShare.Read)
1.1.20034.22 - Aug 13
    Could not read zip entries with DataDescriptors (rare, usually created in Unix)
1.1.20034.21 - Aug 7
	Q3/2003 drop
1.1.20033.21 - May 20
    Folder attributes were not being set correctly
1.1.20033.20 - May 6
	Q3/2003 drop
1.1.20032.20 - April 9
	Added OverwriteReadOnly property to overwrite read-only files when extracting (default is false)
1.1.20032.19 - April 7
	Allow save/open extra-large zip files (up to about 4.2 gig)
1.1.20032.18 - March 23
    Changed behavior of Open() with non-exiting files (used to throw, now creates a new empty zip file).
    Fixed date parameter in zip entries (minutes were slightly off)
1.1.20032.17 - March 13 <DOC>
    Added new method to C1ZipEntryCollection
    
        Add(string fileName, string entryName)
    
    This new method makes it easy to add files to a zip archive and
    specify the path to be stored in the archive. For example, the
    code below stores all files in the "c:\" directory into a zip
    file as "mydir\myfiles\*.*".
    
    foreach (string fileName in Directory.GetFiles(@"c:\"))
    {
        try
        {
            string fileTitle = Path.GetFileName(fileName);
            _zipFile.Entries.Add(fname, @"mydir\myfiles\" + fileTitle);
        }
        catch {}
    }

    Note that the Add(string fileName) method stores the specified 
    file into the zip archive, but trims the path name. The new method
    Add(string fileName, string entryName) allows you to store the full
    path name. For example:
    
    string fileName = @"c:\myfiles\myletters\joe.txt";
    _zip.Entries.Add(fileName); // << stores entry as 'joe.txt'
    _zip.Entries.Add(fileName, fileName); // << stores entry as 'c:\myfiles\myletters\joe.txt'
        
1.1.20032.16 - Feb 20
	Q2/2003 drop
1.1.20031.16 - Jan 25
	Fixed problem with Peek support (previous fix was still bad)
1.1.20031.15 - Dec 26
	Allow opening read-only zip files
1.1.20031.14 - Dec 11
	Fixed problem with Peek support (previous fix was bad)
1.1.20031.13 - Dec 2
	Fixed problem with Peek support (could return false EOF in rare cases)
	Allow foreach on Entries collection while extracting files
1.1.20031.11 - Nov 25
	Fixed About box links, added Enterprise licensing
	Fixed entry dates when adding/extracting (use original file date, not current)
1.1.20031.9 - Nov 7
	2003/Q1 build
1.1.20024.9 - October 22
	Fixed problem reading (bad) files with inconsistent central/local info
1.1.20024.8 - September 23
	Fixed problem with encrypted zip files
1.1.20024.7 - August 21
	Fixed problem reading certain zip files created with additional custom fields
1.1.20024.6 - June 23
	Q4 drop
1.1.20023.5 - June 18
	Q3 drop
1.1.20022.4 - May 30
    Added Progress event: Fires while adding/extracting files into/from zip file, allows cancel. <DOC>
    For example:
        _zipFile.Progress += new C1.C1Zip.ZipProgressEventHandler(this.zip_Progress);
        private void zip_Progress(object sender, C1.C1Zip.ZipProgressEventArgs e)
        {
            int pct = (100 * e.Position) /e.FileLength;
            Console.WriteLine("{0}: {1}%", e.FileName, pct);
            if (_cancel) e.Cancel = true; // cancels adding/extracting files
        }
1.1.20022.3 - Apr 25
	Added support for reading 'stored' (uncompressed) entries in zip files
1.1.20022.2 - Mar 18
	Q2 RC
1.1.20021.1 - Jan 7
	First drop


C1.C1Zip.ZLib
-------------
This is a C# implementation of Adler and Gailly's ZLIB code. ZLIB handles 
the actual data compression and decompression.

ZLIB is designed to be a free, general-purpose, legally unencumbered --
that is, not covered by any patents -- lossless data-compression library
for use on virtually any computer hardware and operating system. The ZLIB
data format is itself portable across platforms. Unlike the LZW compression 
method used in Unix compress(1) and in the GIF image format, the compression 
method currently used in ZLIB essentially never expands the data. (LZW can 
double or triple the file size in extreme cases.) ZLIB's memory footprint 
is also independent of the input data. 

ZLIB was written by Jean-loup Gailly and Mark Adler. It is an open-source
library. For more information on ZLIB, check www.info-zip.org or www.gzip.org.

C1Zip.ZLib contains a main class ZStream that handles stream-based compression
and decompression.



C1.C1Zip
--------
C1Zip contains three main classes:

1) C1ZStreamWriter is a stream object that takes regular data on input, 
compresses it, and writes it out to an underlying stream. You can compress
data to files, memory, or any other type of stream. You can attach a 
BinaryWriter object to C1ZStreamWriter to write objects directly, without
dealing with byte arrays.

2) C1ZStreamReader is a stream object that takes a compressed stream as input
and decompresses it as it reads data from the underlying compressed stream.
You can attach a BinaryReader object to C1ZStreamReader to read objects 
directly, without dealing with byte arrays.

3) C1ZipFile is a class that deals with zip files. It allows you to create,
open, and modify zip files. C1ZipFile has an Entries property that represents
a collection of entries in a zip file.



Why use C1Zip?
--------------
 
* Save time by transferring compressed files and data
* Deploy and update applications more easily by storing all data in a single file
* Fast, low memory usage compression engine 
* 100% managed C# code
* Simple, intuitive object model



Major operations
----------------

- Zip files or memory buffers into new or existing zip files 
- Unzip files to disk or directly to memory 
- Compress and decompress strings or buffers completely in memory 
- Stream-based compression and decompression for maximum flexibility

- Obtain global information on a zip file 
- Obtain a detailed list of a zip file's contents via a collection object.
- Delete files from within a zip file 
- Test the integrity of a zip file and its contents 
- Add and retrieve comments for individual files in the zip file 
- Get and set the global zip file comment 
- Control what path information is stored in the zip file for each file 
- Zip system and hidden files
- Control the amount of compression applied to files being zipped 
- Specify the path where files will be uncompressed to 
- Work on temporary copies of zip files, for maximum safety 
