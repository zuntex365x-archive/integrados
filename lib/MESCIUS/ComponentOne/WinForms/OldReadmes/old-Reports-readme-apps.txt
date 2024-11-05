<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
Readme file for C1Reports for .NET applications (Designer, Scheduler etc.)
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

Thank you for your interest in the ComponentOne Reports offering.

This readme file covers the ComponentOne C1Reports applications:

- report designer (C1ReportDesigner.exe);
- reports scheduler (C1ReportsScheduler.exe, C1ReportsSchedulerService.exe);
- reports viewer (C1dView.exe, C1dView32.exe) (.NET 4.0 only).

For the non-visual C1Reports components please see the readme.txt file also
included in this release.

For the visual WinForms C1Reports controls (C1PrintPreviewControl etc.) please
see the readme-preview.txt file also included in this release.

Please visit our support web site:
  http://our.componentone.com/Support/

Also check out the product forum:
  http://our.componentone.com/groups/winforms/reports-for-winforms/forum/

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
C1Reports Apps maintenance log:
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

================================================================================
Build 2/4.6.20142.54736, 06-Oct-2014
================================================================================

Bug fixes
---------
- C1ReportDesigner: when C1ReportDesigner.UseCreationGraphicsToRenderFields was true,
  fields dispaying vertical or horizontal lines were invisible at design-time. [29905]
- C1ReportsScheduler: fixed service setup dialog Japanese localization issues. [89515]

================================================================================
Build 2/4.6.20142.54735, 17-Sep-2014
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20142.54734, 05-Sep-2014
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20142.54733, 24-Jul-2014
================================================================================

Bug fixes
---------
- C1ReportDesigner: increased max number of chars that can be pasted into SQL textbox. [72890]
- C1ReportDesigner: localization issues fixed. [61692]

================================================================================
Build 2/4.6.20142.54732, 09-Jul-2014
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20142.54731, 03-Jul-2014
================================================================================

Bug fixes
---------
- C1ReportDesigner: subreport dawn incorrectly when ShowSubreportContent is true
  and UseCreationGraphicsToRenderFields is true. [18448]
- C1ReportDesigner: added missing Korean and Chinese strings. [61692]
- C1ReportDesigner: nag screen shown when starting the .NET 2.0 version. [35609]
- C1dView: fixed application icon and version numbers. [72665]

Behavior changes
----------------
* Updated C1 assemblies used by C1ReportDesigner.

================================================================================
Build 2/4.6.20142.54730, 26-Jun-2014
================================================================================

* 2014v2 build.

Bug fixes
---------

- C1ReportDesigner: fixed Korean and Chinese localization issues. [69328]

================================================================================
Build 2/4.6.20141.54725, 13-Jun-2014
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20141.54724, 30-May-2014
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20141.54722, 12-May-2014
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20141.54721, 24-Apr-2014
================================================================================

Bug fixes
---------
- Added new/missing Japanese translations.

================================================================================
Build 2/4.6.20141.54719, 12-Apr-2014
================================================================================

Bug fixes
---------
- C1ReportDesigner: fixed help URL (Japanese version only). [62941]
- Wrong rendering if transparent color is specified for some elements. [49261]

================================================================================
Build 2/4.6.20141.54718, 29-Mar-2014
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20141.54717, 12-Mar-2014
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20141.54716, 11-Mar-2014
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20141.54715, 06-Mar-2014
================================================================================

Behavior changes
----------------

* Updated C1 assemblies used by the designer, including latest themes.

================================================================================
Build 2/4.6.20141.54714, 04-Mar-2014
================================================================================

Bug fixes
---------

- C1ReportDesigner: zoom icon looks bad when a dark theme is used. [50738]
- C1ReportDesigner: context menu was not themed. [52208]

New features
------------

- C1ReportDesigner: added ability to lock selected fields on the designer surface
  (accessible via the context menu).

================================================================================
Build 2/4.6.20141.54713, 20-Feb-2014
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20141.54712, 19-Feb-2014
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20141.54711, 04-Feb-2014
================================================================================

* 2014v1 build.

New features
------------

- C1ReportDesigner app: added C1Themes support. Now the designer app can be
  themed using either a pre-built themes from C1Themes, or any custom-made
  theme loaded from a file with .c1theme extension.

  To change the theme used by the report designer app:
  - start the C1ReportDesigner.exe;
  - open the "Options" dialog (from the application menu);
  - on the first tab ("General"), select a theme from one of the comboboxes
    in the "Themes" groupbox;
  - click "OK" to close the dialog and save the selected theme.

  You may also click the "Apply" button in the theme groupbox to see how the
  selected theme looks without closing the options dialog, but note that you
  cannot cancel that action - you can only select another theme.

  The name of the theme used by the designer is saved in the
  C1ReportDesigner.EXE.settings file as the "Theme" node, prefixed with
  "builtin:" for built-in themes, or "custom:" for custom themes. The built-in
  themes are loaded from the C1.Win.C1Themes.2/4.dll shipped with the designer.
  The custom themes are loaded from the "Themes" sub-folder of the folder
  containing the report designer executable. So to add your own custom themes to
  the list of themes available to the deisgner:
  - if it does not already exist, create a sub-folder named "Themes" in the
    folder containing the C1ReportDesigner.exe;
  - copy your custom theme files (with extension .c1theme) into that folder;
  - run the report designer and select a theme from the "Custom" theme combo as
    described above.

  To run the reprot designer without applying any theme if one was selected,
  exit the designer, locate the C1ReportDesigner.EXE.settings file and open it
  in a text editor such as Notepad. Locate the <Theme ... /> element and
  delete it. Save the .settings file (it is highly recommended to save a backup
  copy prior to that). Run the report designer again - no theme will be used.

================================================================================
Build 2/4.6.20133.54703, 02-Feb-2014
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20133.54702, 20-Jan-2014
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20133.54701, 31-Dec-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20133.54660, 19-Dec-2013
================================================================================

Bug fixes
---------

- C1ReportDesigner app: now Ctrl+Click deselects a previously selected object.

================================================================================
Build 2/4.6.20133.54659, 11-Dec-2013
================================================================================

Bug fixes
---------

- C1ReportDesigner did not generate field list if a stored procedure with parameters
  declared as either VARCHAR(MAX) or XML was set as the report's datasource. [46255]

================================================================================
Build 2/4.6.20133.54656, 25-Nov-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20133.54655, 07-Nov-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20133.54654, 03-Nov-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20133.54653, 25-Oct-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20133.54651, 17-Oct-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20133.54650, 12-Oct-2013
================================================================================

* 2013v3 build.

================================================================================
Build 2/4.6.20132.54642, 19-Sep-2013
================================================================================

Bug fixes
---------

- Designer app: removed 'check for updates' feature in Japanese version. [41821]

================================================================================
Build 2/4.6.20132.54641, 17-Sep-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20132.54640, 22-Aug-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20132.54639, 17-Aug-2013
================================================================================

Bug fixes
---------

- Designer app: disabled 'export' menu in main application menu at design time
  (export only works in preview mode). [40454]
- Designer app: fixed inconsistencies between rendering certain fiels in
  designer vs run time. [39430]

================================================================================
Build 2/4.6.20132.54638, 25-Jun-2013
================================================================================

Bug fixes
---------

- Designer app: enabled export to XPS in Japanese build (.NET 4.0 only). [38014]

================================================================================
Build 2/4.6.20132.54637, 24-Jun-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20132.54636, 15-Jun-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20132.54635, 01-Jun-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20131.54634, 29-May-2013
================================================================================

Bug fixes:
----------

- SuperLabel custom field printed with different size depend on
  screen resolution (large/medium/small fonts).

================================================================================
Build 2/4.6.20131.54633, 08-May-2013
================================================================================

Bug fixes
---------

- Exception (index out of range) could occur in the report designer app when
  correcting an invalid connection string. [35907]

================================================================================
Build 2/4.6.20131.54632, 24-Apr-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20131.54631, 22-Apr-2013
================================================================================

Bug fixes
---------

- Report designer: when changing just one dimension of a field with the mouse,
  the other dimension also changed (e.g. resising the height also changed the
  width). [35748]

================================================================================
Build 2/4.6.20131.54629, 11-Apr-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20131.54628, 09-Apr-2013
================================================================================

Behavior changes
----------------

* New licensing (Japanese version only).

Bug fixes (Report Designer app)
-------------------------------

- Report wizard produced invalid field names when data source contained names in
  square brackets. [35352]
- Fixed online help link.

================================================================================
Build 2/4.6.20131.54624, 26-Feb-2013
================================================================================

* This file renamed to readme-apps.txt (was readme-designer.txt). In addition to
  the report designer app, it now covers reports scheduler and (new for 2013v1)
  C1dView.

================================================================================
Build 2/4.6.20131.54622, 07-Feb-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20131.54620, 21-Jan-2013
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20123.54608, 12-Dec-2012
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20123.54607, 10-Dec-2012
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20123.54605, 06-Dec-2012
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20123.54604, 27-Nov-2012
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20123.54603, 21-Nov-2012
================================================================================

Bug fixes
---------

- Fixed: nag screen showed when importing a Crystal report. [30061]

================================================================================
Build 2/4.6.20123.54602, 13-Nov-2012
================================================================================

Bug fixes
---------

- Fixed error when rendering some Japanese strings in Windows 8 environment. [28099]
- Fields displaying vertical or horizontal lines were not visible in the designer. [29905]
- Updated C1 components used by the designer.

Behavior changes
----------------

- Changed the options window to a tabbed interface. [29025]

================================================================================
Build 2/4.6.20123.54601, 26-Oct-2012
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

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

- Usability: for custom fields, type is shown in parentheses after the field's name.

================================================================================
Build 2/4.6.20122.54517, 28-Sep-2012
================================================================================

* Internal localization-related changes.

================================================================================
Build 2/4.6.20122.54516, 04-Sep-2012
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20122.54515, 13-Aug-2012
================================================================================

Bug fixes
---------

- exception could occur in SqlBuilder dialog if the selected database contained
  objects (tables, fields, views) with spaces in names.

================================================================================
Build 2/4.6.20122.54514, 26-Jul-2012
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20122.54513, 13-Jul-2012
================================================================================

New features
------------

* Added support for the new data source types (ODBC and SQL Server Compact Edition).

================================================================================
Build 2/4.6.20122.54512, 22-Jun-2012
================================================================================

Bug fixes
---------

* Fixed: Pressing 'Esc' button do not stop rendering in C1ReportDesigner,
  in 2/4.6.20122.54511 build this bug was fixed incorrectly.

================================================================================
Build 2/4.6.20122.54511, 21-Jun-2012
================================================================================

Bug fixes
---------

* Fixed: Pressing 'Esc' button do not stop rendering in C1ReportDesigner.

================================================================================
Build 2/4.6.20122.54510, 07-Jun-2012
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20121.54506, 26-May-2012
================================================================================

Bug fixes
---------

* Fixed: the .NET 2.0 build of the designer app for failed to run on a system
  that did not have .NET 4.0 installed.

================================================================================
Build 2/4.6.20121.54505, 12-May-2012
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20121.54504, 05-Apr-2012
================================================================================

Bug fixes
---------

* Fixed: in some cases after 2012v1 upgrade the designer app started without any
  of the side panels (reports/fields/properties in design mode,
  thumbnails/outline in preview mode), and clicking fields or properties ribbon
  buttons threw an error "Invisible or disabled control cannot be activated."
  [21025]

* Fixed: when opening new report or switching between reports, depending on
  database connection the designer app's UI would freeze while waiting to
  retrieve the database field list, especially if a connection could not be
  established. Now fields are retrieved asynchronously in the background without
  freezing the UI.

================================================================================
Build 2/4.6.20121.54503, 16-Mar-2012
================================================================================

Bug fixes
---------

* Improved import of Crystal reports (added support for multi-table data
  sources).

================================================================================
Build 2/4.6.20121.54502, 07-Mar-2012
================================================================================

New features
------------

* Designer app: added export to XPS and C1DX.

* CustomFields: added support for CanGrow/CanShrink to SuperLabel. [18920]

================================================================================
Build 2/4.6.20121.54501, 13-Feb-2012
================================================================================

Bug fixes
---------

* FIPS compliance: fixed unhandled exception when starting the report designer
  app in a FIPS compliant environment. [18676]

* Fixed: when using a table or view containing a dash (-) in its name, no fields
  were retreived in the C1ReportWizard of the report designer. [17067]

* Fixed: thick border drawn incorrectly at design time. [18723]

New features
------------

* Report designer app's visual style changed to Office 2010 Blue.

* .NET 4.0 version only: added new Map custom field (uses C1.WPF.Maps.C1Maps
  control, requires C1.WPF.4 and C1.WPF.Maps.4 assemblies. See separate
  readme-maps.txt for details.

* Added a number of new properties to the chart custom field [14952]:
  - LabelCompass: location of labels relative to data points
    (breaking change: previously it was radial for pie charts, now none is the common default);
  - LabelOffset: distance between a label and its associated data point;
  - LabelConnected: whether a connecting line is drawn from a label to its data point
    (breaking change: previously it was true for pie charts, now false is the common default);
  - LabelAutoArrangeMethod: method used to auto arrange labels;
  - LabelAutoArrangeOptions: options used when auto arranging labels;
  - SeriesOffset: data series offset for appropriate charts;
  - ShowOutline: whether chart figures are outlined;
  - OutlineColor: outline stroke color;
  - PieStartAngle: starting angle of the first slice (pie charts only);
  - PieClockwise: pie slices' direction (pie charts only);
  - PieInnerRadius: pie inner radius (allows to turn a pie chart into a doughnut);
  - View3dDepth: apparent chart depth as a percentage of chart width
    (breaking change: previously it was 20 for pie charts, 5 for others, now 10 is the common default);
  - View3dElevation: apparent degree of inclination of the eye-point above the X-axis;
  - View3dRotation: apparent degree of rotation of the eye-point to the right of the Y-axis;
  - View3dShading: type of shading applied to 3D areas of the chart.

* Added the ability to check for updates at startup or via a menu (Help | Check for updates).
  Automatic check at startup may be turned off in the "check for updates" dialog.

* Added availability of table-based HTML export from the designer app's preview.

================================================================================
Build 2/4.6.20113.54463, 20-Jan-2012
================================================================================

Bug fixes
---------

* Fixed: in rare cases when the designer was launched from Visual Studio, and
  the report was changed in the designer, the changes were lost when the
  designer was closed. [18644]

================================================================================
Build 2/4.6.20113.54462, 09-Dec-2011
================================================================================

Bug fixes
---------

* Fixed regression bug: deleting all reports in the report list of the designer
  causes a null reference exception. [18722]

* Fixed regression bug: selecting a report definition file from the list of
  recent files only works if the file is selected twice in a row. [18727]

================================================================================
Build 2/4.6.20113.54461, 30-Nov-2011
================================================================================

Bug fixes
---------

* Updated licensing to conform with Federal Information Processing Standards
  requirements. [18460, 18562]

* Fixed a problem in the new report wizard: when the wizard connects to a SQL
  Server 2008 R2 database, the table/view/stored procedure dropdown get
  displayed, but the field list does not show. [18275]

Enhancements
------------

* Show report designer wizard in Windows task bar. This allows to alt-tab back
  to the wizard.

* Turned showing of help on in the report designer property grid.

* Improved report designer script editor's functions popup menu.

================================================================================
Build 2/4.6.20113.54459, 04-Nov-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20113.54458, 27-Oct-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20113.54457, 19-Oct-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

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

================================================================================
Build 2/4.6.20113.54454, 05-Oct-2011
================================================================================

* Enhanced licensing in environments with some security policy restrictions.

================================================================================
Build 2/4.6.20113.54453, 30-Sep-2011
================================================================================

New features
------------

* Report designer app: now the last selected report is re-selected automatically
  when the designer is started.

================================================================================
Build 2/4.6.20113.54452, 25-Sep-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20113.54451, 12-Sep-2011
================================================================================

* 2011 v3 release.

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20112.54409, 16-Aug-2011
================================================================================

Bug fixes
---------

* Fixed: if the designer app was run on a system without installed printers, the
  splash screen never went away. [16663]

================================================================================
Build 2/4.6.20112.54408, 12-Jul-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20112.54407, 11-Jul-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20112.54406, 24-Jun-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20112.54405, 17-Jun-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20112.54404, 15-Jun-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20112.54403, 14-Jun-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20112.54401, 01-Jun-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20112.54400, 26-May-2011
================================================================================

* 2011 v2 release.

Bug fixes
---------

* Fixed: garbled display of the report list if the report list panel is in
  sliding mode. [15134]

================================================================================
Build 2/4.6.20111.54317, 25-May-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20111.54316, 13-May-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20111.54315, 07-May-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20111.54314, 02-May-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20111.54313, 19-Apr-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20111.54312, 13-Apr-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20111.54311, 30-Mar-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20111.54310, 28-Mar-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20111.54309, 21-Mar-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20111.54308, 07-Mar-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20111.54307, 11-Feb-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20111.54306, 01-Feb-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20111.54305, 26-Jan-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20111.54304, 25-Jan-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20111.54303, 24-Jan-2011
================================================================================

Bug fixes
---------

* Fixed an issue (wrong image size in some scenarios) with the Gradient custom field. [12897]

================================================================================
Build 2/4.6.20111.54302, 18-Jan-2011
================================================================================

* Synchronized with other ComponentOne Reports assemblies.

================================================================================
Build 2/4.6.20111.54301, 17-Jan-2011
================================================================================

* .NET 4.0 version only: New custom field - SuperLabel - added to the prebuilt
  C1.C1Report.CustomFields.4 assembly. SuperLabel allows to render HTML text using the C1SuperLabel
  control included in the C1.Win.C1SuperTooltip.4 assembly (part of ComponentOne Studio for
  WinForms). See the CustomFields sample for details. If you do NOT need the new functionality,
  remove the corresponding line from the C1ReportDesigner.exe.settings file.

================================================================================
Build 2/4.6.20103.54206, 16-Dec-2010
================================================================================

Bug fixes
---------

* Fixed: when a field's size is set in the property page and then that field is moved, the size
  would sometimes change. [13322]

================================================================================
Build 2/4.6.20103.54205, 10-Dec-2010
================================================================================

Bug fixes
---------

* When fields were moved or resized in the designer at certain zoom levels, the resulting
  coordinates (in twips) became fractional. [13322]

* When a table or view of a MSSQL server was selected as data source in the report wizard, the field
  list was not built.

* Error message ("Unspecified error") popped up in the report wizard when an Azure SQL data source
  was selected.

* Report designer crashed if a font used by a predefined style was not installed on the system.

========================================================================
Build 2/4.6.20103.54202, 21-Oct-2010
========================================================================

* Synchronized with other ComponentOne Reports assemblies.

========================================================================
Build 2/4.6.20103.54201, 14-Oct-2010
========================================================================

* Synchronized with other C1Report assemblies.
  See readme-reports.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20103.54200, 04-Oct-2010
========================================================================

* 2010 v3 build. Synchronized with other C1Report assemblies.

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20102.54122, 17-Sep-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20102.54121, 15-Sep-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20102.54120, 31-Aug-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20102.54119, 16-Jul-2010
========================================================================

* Fixed: about box did not show at design time (.NET 4.0 version only).
  [11788]

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20102.54118, 15-Jul-2010
========================================================================

* Fixed design assembly version number (.NET 4.0 version only).

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20102.54117, 09-Jul-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20102.54116, 07-Jul-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20102.54115, 02-Jul-2010
========================================================================

Bug fixes
---------

* Fixed flashing of link options dialog when it cannot proceed. [11451]

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20102.54114, 29-Jun-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20102.54113, 25-Jun-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20102.54112, 15-Jun-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20102.54111, 14-Jun-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20101.54110, 25-May-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20101.54109, 20-May-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20101.54108, 15-May-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20101.54107, 13-May-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20101.54104, 10-May-2010
========================================================================

* Fixed: in design time, action list commands did not work. [10695]

* Fixed: wrong graphics in designer app's splash screen. [10693]

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20101.54103, 02-May-2010
========================================================================

* Fixed: pressing Esc did not stop report generation in preview mode.
  [9391]

========================================================================
C1ReportDesigner for .Net Build 2/4.6.20101.54102, 25-Apr-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20101.54008, 15-Apr-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20101.54007, 09-Apr-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20101.54006, 06-Apr-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20101.54005, 08-Mar-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20101.54004, 04-Mar-2010
========================================================================

* Fixed: Incorrect Copyright information in the C1ReportDesigner About
  box. [9172]

========================================================================
C1ReportDesigner for .Net Build 2.6.20101.54002, 23-Feb-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20101.54001, 02-Feb-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53218, 05-Jan-2010
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53217, 30-Dec-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53216, 18-Dec-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53215, 16-Dec-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53214, 10-Dec-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53213, 09-Dec-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53212, 08-Dec-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53211, 04-Dec-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53210, 01-Dec-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53209, 29-Nov-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53208, 25-Nov-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53207, 11-Nov-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53206, 06-Nov-2009
========================================================================

* Licensing issue fixed.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53205, 04-Nov-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53204, 29-Oct-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53203, 16-Oct-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53202, 06-Oct-2009
========================================================================

Bug fixes
---------

* Fixed: When chart was used in a report, in the designer's preview the
  data value of data X coordinate did not show clearly. [6504]

* Fixed: borders around fields were not drawn correctly (only two sides
  of the border were drawn). [6020]

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53201, 21-Sep-2009
========================================================================

* Fixed: after importing a report, the status label at the bottom keeps
  saying "Importing XXXX report".

* Fixed: in some reports imported from .mdb files some of the fields
  overlap.

* Fixed: after importing several reports from an .mdb file, the order of
  the imported reports in the reports list was the opposite of the one
  shown in Access.

========================================================================
C1ReportDesigner for .Net Build 2.6.20093.53200, 19-Sep-2009
========================================================================

* "Lock Fields" toggle button added to the designer application UI.

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20092.52110, 17-Sep-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20092.52109, 14-Sep-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20092.52108, 21-Aug-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20092.52107, 13-Aug-2009
========================================================================

* Synchronized with C1Report, see readme.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20092.52106, 07-Jul-2009
========================================================================

* Licensing code updated.

========================================================================
C1ReportDesigner for .Net Build 2.6.20092.52105, 25-Jun-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20092.52104, 17-Jun-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 3.6.20092.52102, 04-Jun-2009
========================================================================

Bug fixes (C1ReportDesignerApp)
---------------------------

* An unhandled exception occurs in C1ReportDesignerApp sometimes
  when application minimized
* Ctrl+G does not work in C1ReportDesignerApp

========================================================================
C1ReportDesigner for .Net Build 2.6.20092.52101, 22-May-2009
========================================================================

New features
------------

* New public property added to C1ReportDesigner:

  public float ZoomFactor {get;set;}
    Gets or sets the zoom factor (1 is actual size).

  Related additions on C1ReportDesigner object model:

  public float MinZoomFactor {get;}
    Gets the minimum allowed zoom factor (0.1).

  public float MaxZoomFactor {get;}
    Gets the maximum allowed zoom factor (10).

  public event EventHandler ZoomFactorChanged;
    Fired when the designer's ZoomFactor property has changed.

  public int ToZoomedPixelsX(double twip);
    Converts twips to pixels, taking ZoomFactor into account.

  public int ToZoomedPixelsY(double twip);
    Converts twips to pixels, taking ZoomFactor into account.

  public double ToUnZoomedTwipsX(int pixels);
    Converts pixels to twips, taking ZoomFactor into account.

  public double ToUnZoomedTwipsY(int pixels);
    Converts pixels to twips, taking ZoomFactor into account.

  Note that old public methods used to convert coordinates:
  - ToPixelsX
  - ToPixelsY
  - ToTwipsX
  - ToTwipsY
  do NOT take ZoomFactor into account.

========================================================================
C1ReportDesigner for .Net Build 2.6.20091.52016, 22-May-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20091.52015, 18-May-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20091.52014, 08-May-2009
========================================================================

* Manifest is now generated for the report designer application. This
  fixes a crash when running report designer app on Vista with UAC.

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20091.52012, 23-Apr-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20091.52011, 03-Apr-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20091.52010, 10-Mar-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20091.52009, 09-Mar-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20091.52008, 03-Mar-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20091.52007, 13-Feb-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20091.52006, 09-Feb-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20091.52005, 04-Feb-2009
========================================================================

* Synchronized with C1Preview, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20083.51015, 09-Jan-2009
========================================================================

* Bug fixes in C1Report and C1PrintDocument.

========================================================================
C1ReportDesigner for .Net Build 2.6.20083.51012, 11-Nov-2008
========================================================================

* Bug fixes in C1Report and C1PrintDocument.

========================================================================
C1ReportDesigner for .Net Build 2.6.20083.51011, 31-Oct-2008
========================================================================

* The "About" button is now a "Help" button with a dropdown allowing to
  call help contents, index or about box. When the "Help" button itself
  is clicked, help contents is displayed.

========================================================================
C1ReportDesigner for .Net Build 2.6.20083.51010, 27-Oct-2008
========================================================================

* Fixed: RTF text was not rendered correctly in Label field in
  DesignView.

* Bug fixes in C1Report and C1PrintDocument.

========================================================================
C1ReportDesigner for .Net Build 2.6.20083.51009, 16-Oct-2008
========================================================================

* Bug fixes in C1Report and C1PrintDocument, see readme-c1report.txt and
  readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20083.51008, 15-Oct-2008
========================================================================

* Bug fixes in C1Report and C1PrintDocument.

========================================================================
C1ReportDesigner for .Net Build 2.6.20083.51006, 09-Oct-2008
========================================================================

* Bug fixes in C1PrintDocument, see readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.6.20083.51005, 08-Oct-2008
========================================================================

* Bug fixes and new features in C1Report and C1PrintDocument.

========================================================================
C1ReportDesigner for .Net Build 2.6.20083.51003, 26-Sep-2008
========================================================================

* Bug fixes in C1Report and C1PrintDocument.

========================================================================
C1ReportDesigner for .Net Build 2.6.20083.51002, 25-Sep-2008
========================================================================

* Bug fixes in C1Report and C1PrintDocument.

========================================================================
C1ReportDesigner for .Net Build 2.0.20083.51001, 23-Sep-2008
========================================================================

* 2008 v3 release.

* Bug fixes and new features in C1PrintDocument, see
  readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.0.20082.50035, 07-Aug-2008
========================================================================

* Bug fixes and new features in C1PrintDocument, see
  readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.0.20082.50034, 03-Jul-2008
========================================================================

* Bug fixes and new features in C1PrintDocument, see
  readme-c1preview.txt for details.

========================================================================
C1ReportDesigner for .Net Build 2.0.20082.50025, 19-May-2008
========================================================================

Bug fixes
---------

* Minor bugs where  fixed that were added in the 2.0.20082.50023 build.

========================================================================
C1ReportDesigner for .Net Build 2.0.20082.50024, 15-May-2008
========================================================================

Bug fixes
---------

* Minor bugs where  fixed that were added in the 2.0.20082.50023 build.

========================================================================
C1ReportDesigner for .Net Build 2.0.20082.50023, 14-May-2008
========================================================================

Bug fixes
---------

* Minor bugs where  fixed that were added in the 2.0.20082.50022 build.

========================================================================
C1ReportDesigner for .Net Build 2.0.20082.50022, 01-May-2008
========================================================================

* 2008 V2 release.

========================================================================
C1ReportDesigner for .Net Build 2.0.20082.50018 (BETA), 04-Apr-2008
========================================================================

* The first public release.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
The End.
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
