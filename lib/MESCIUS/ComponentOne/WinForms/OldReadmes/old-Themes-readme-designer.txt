<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

Readme file for the ComponentOne C1ThemeDesigner application

- C1ThemesDesigner.2.exe
- C1ThemesDesigner.4.exe

Version number format:
- first  part: Version of the .NET framework used to build the assembly (e.g. 2 = .NET 2.x);
- second part: Internal use only;
- third  part: Year/version (e.g. 20133 = V3/2013);
- fourth part: Sequential number.

While this application is available in two versions (for .NET 2.x and .NET 4.0),
both versions are functionally the same and consume and produce the same file
format (.c1theme) which does not depend on the .NET version. Themes created by
either version of the application are fully compatible, so even if your
projects target .NET 2.0 and you are using the .NET 2.0 version of
C1ThemeController, you may use the .NET 4.0 version of the theme designer.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
C1ThemeDesigner maintenance log
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20142.56, Sep 18, 2014
==========================================================================================

* Synchronized with C1Themes assembly.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20142.55, Aug 01, 2014
==========================================================================================

* Synchronized with C1Themes assembly.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20142.54, Jul 31, 2014
==========================================================================================

Other changes
-------------
- Updated C1Input assemblies used by the theme designer app.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20142.53, Jul 28, 2014
==========================================================================================

Bug fixes
---------
- Text under "Disable" column was overlapped and garbled in C1Input theme preview. [72948]
- Some tooltips were not localized correctly. [73443]

Other changes
-------------
- Updated C1 assemblies used by the theme designer app.
- In the new theme dialog, the default theme name was localized;
  now "NewTheme" is used regardless of the current locale. [73442]

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20142.52, Jun 28, 2014
==========================================================================================

* 2014v2 build.

Bug fixes
---------
- Ctrl+S shortcut was working incorrectly. [67644]

Other changes
-------------
- Updated C1 assemblies used by the theme designer app.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20141.51, May 08, 2014
==========================================================================================

Bug fixes
---------
- Shortcut keys (e.g. Ctrl+N, Ctrl+O, Ctrl+S) were not working (regression). [65444]

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20141.50, May 05, 2014
==========================================================================================

Other changes
-------------
- Updated C1 assemblies used by the theme designer app.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20141.46, Apr 29, 2014
==========================================================================================

Bug fixes
---------
- In background properties dialog, sometimes part of the dialog was cut off. [64904]

Other changes
-------------
- Updated C1 assemblies used by the theme designer app.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20141.45, Apr 28, 2014
==========================================================================================

Other changes
-------------
- Updated C1 assemblies used by the theme designer app.
- Fixed Japanese localization issues.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20141.38, Mar 18, 2014
==========================================================================================

Other changes
-------------
- Updated C1.Win.C1GanttView assembly.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20141.37, Mar 17, 2014
==========================================================================================

Bug fixes
---------
- Minor bug fixes.

Other changes
-------------
- Updated C1 assemblies used by the theme designer app.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20141.36, Mar 13, 2014
==========================================================================================

Bug fixes
---------
- Miscellaneous bug fixes.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20141.35, Mar 06, 2014
==========================================================================================

* 2014v1 build.

New features
------------
- The theme designer can now itself be themed via the File | Options dialog.
  Available themes include all built-in themes, plus any themes (in .c1theme
  files) located in the "Themes" subdirectory of the directory where the theme
  designer app is installed,
- Handling of the Background theme items has been significantly improved.
- Multiple other improvements and enhancements.

Bug fixes
---------
- Miscellaneous bug fixes.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20133.20, Jan 27, 2014
==========================================================================================

Bug fixes
---------
- Multiple minor bug fixes and enhancements.

Other changes
-------------
- Updated C1 assemblies used by the theme designer app.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20133.18, December 20, 2013
==========================================================================================

New features
------------

- New Active Preview feature: when turned on (the rightmost button on the app's ribbon),
  the control or part of it under the mouse is highlighted; Ctrl+Click jumps to that control
  in the theme tree.
- Added C1ReportDesigner theme preview.
- Added command line arguments (running 'C1ThemeDesigner.4.exe mytheme.c1theme' opens the
  specified theme file).
- Limit recent file history to 10 entries.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20133.16, November 26, 2013
==========================================================================================

New features
------------
- Added C1SplitContainer theme preview.
- Added new theme: ShinyBlue.c1theme.

Bug fixes
---------
- Fixed: two items were added to the undo stack when an item was deleted from the theme tree. [46056]
- Disabled "Remove reference" context menu item if the current theme tree item has no reference. [44385]
- Limited recent files list to 15 items. [44358]
- In theme tree context menu, disabled actions that cannot be performed. [44422]

Other changes
-------------
- Updated C1 assemblies used by the theme designer app.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20133.14, November 13, 2013
==========================================================================================

Bug fixes
---------
- Fixed help URL.
- Minor bug fixes.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20133.12, November 11, 2013
==========================================================================================

- Initial public release.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
Release notes, November 2013
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

For an overview of the ComponentOne C1Themes for WinForms product (of which the
C1ThemeDesigner is a part), please see the readme.txt also included in this
release.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
The End.
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
