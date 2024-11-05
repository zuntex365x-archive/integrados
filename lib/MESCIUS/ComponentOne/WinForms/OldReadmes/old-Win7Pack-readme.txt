==================================================================
C1Win7Pack                ComponentOne, LLC - www.componentone.com
==================================================================

Welcome to ComponentOne Windows 7 Control Pack for WinForms.

ComponentOne Windows Control Pack is an integral part of Studio
Enterprise, the largest and most complete toolset for developing
Win, Web, Mobile and ASP.NET AJAX enabled applications.

Please direct feedback for C1Win7Pack to the following forum:

http://our.componentone.com/groups/winforms/win7-pack-for-winforms/forum/

- Support and Feedback Options

ComponentOne is dedicated to providing reliable best-of-breed
components. If you have any issues using our products, we want
to know about it. Please use the following pages for information
to get support:

http://www.componentone.com/SuperProducts/SupportServices/

To submit a support request, report a bug, or request a feature,
please use our online Incident Submission Form. Note that we ask
you to be logged into your ComponentOne Account to submit an incident.

Login or Create an Account: http://www.componentone.com/Members/

- Installed Files

ComponentOne Windows 7 Control Pack for WinForms installs the
following files and components.

Files: C1.Win.C1Win7Pack.2/4.dll, C1.Win.C1Win7Pack.2/4.XML,
       C1.Win.C1Win7Pack.4.Design.dll

Components: C1TaskbarButton, C1TaskDialog
------------------------------------------------------------------

History of Changes
==================================================================
C1Win7Pack Build  2/4.0.20142.39            Build Date: 06/26/2014
==================================================================

- 2014/v2 drop.

==================================================================
C1Win7Pack Build  2/4.0.20141.38            Build Date: 02/20/2014
==================================================================

- C1Win7Pack is now licensed as a part of Studio for Desktop.

==================================================================
C1Win7Pack Build  2/4.0.20141.37            Build Date: 01/20/2014
==================================================================

- Fixed an issue: Unlike other C1 controls, SmartTags for a
  C1TaskDialog and C1TaskbarButton are not closed automatically
  when the modal dialog editors are opened (TFS 49369).

==================================================================
C1Win7Pack Build  2/4.0.20141.36            Build Date: 01/10/2014
==================================================================

- Fixed an issue: While adding new RadioButtons/CustomButtons to
  C1TaskDialog through the Collection Editors, button Name in the
  square brackets is not displayed starting from index 14 and
  onwards (TFS 49231).

==================================================================
C1Win7Pack Build  2/4.0.20133.34            Build Date: 10/14/2013
==================================================================

- 2013/v3 build

==================================================================
C1Win7Pack Build  2/4.0.20132.33            Build Date: 09/09/2013
==================================================================

- Internal localization code is updated.

==================================================================
C1Win7Pack Build  2/4.0.20132.32            Build Date: 06/04/2013
==================================================================

- URL changes for GrapeCity JPN AboutBox.

==================================================================
C1Win7Pack Build  2/4.0.20131.30            Build Date: 04/03/2013
==================================================================

- Moved to the subscription licensing model in Japanese build.

==================================================================
C1Win7Pack Build  2/4.0.20123.27            Build Date: 10/25/2012
==================================================================

- The interface language depends now on CurrentUICulture setting
  instead of the CurrentCulture property of CultureInfo.

==================================================================
C1Win7Pack Build  2/4.0.20123.26            Build Date: 10/13/2012
==================================================================

- Minor internal changes for better compatibility with VS2012.

==================================================================
C1Win7Pack Build  2/4.0.20123.25            Build Date: 10/12/2012
==================================================================

- Fixed an issue: an error occurs when user adds a CustomButton
  or RadioButton using the Collection Editor while the current
  locale is set to Chinese or Korean (TFS 28987).

==================================================================
C1Win7Pack Build  2/4.0.20123.24            Build Date: 10/10/2012
==================================================================

- Added the Chinese and Korean localization strings.

==================================================================
C1Win7Pack Build  2/4.0.20122.23            Build Date: 09/04/2012
==================================================================

- Updated VS2012 toolbox icons.

==================================================================
C1Win7Pack Build  2/4.0.20113.15            Build Date: 11/30/2011
==================================================================

- Updated licensing to conform with Federal Information Processing
  Standards requirements (TFS 18562).

==================================================================
C1Win7Pack Build  2/4.0.20113.13            Build Date: 10/05/2011
==================================================================

- V3/2011 build.

==================================================================
C1Win7Pack Build  2/4.0.20112.11            Build Date: 06/24/2011
==================================================================

- Updated toolbox icons for the C1TaskbarButton and C1TaskDialog
  components.

==================================================================
C1Win7Pack Build  2/4.0.20112.10            Build Date: 05/27/2011
==================================================================

- Fixed an issue: C1Win7Pack has to be deactivated twice with
  Report Designer License Key (TFS 15499).

==================================================================
C1Win7Pack Build  2/4.0.20112.9             Build Date: 05/26/2011
==================================================================

- Fixed a few problems in the XML documentation file.

==================================================================
C1Win7Pack Build  2/4.0.20112.8             Build Date: 05/24/2011
==================================================================

- Added the MaxSlots property to C1JumpList. It returns the
  maximum number of items in the C1JumpList.Items collection
  that will be shown in the Jump List. The value depends on the
  "Number of recent items to display in Jump Lists" option in
  the "Taskbar and Start Menu Properties" - "Customize Start
  Menu" window.

- Warning message box appears now when a user changes the Name
  of a C1CustomButton, C1RadioButton, or C1ThumbButton so that
  the new name coincides with the Name of another button in
  the same collection (TFS 15451).

- The default value of the C1JumpList.RefreshOnStartup property
  changed from 'true' to 'false'.

- Fixed a bug: if both C1JumpList.Items and C1JumpList.Tasks
  collections are empty and the RefreshOnStartup property is set
  to 'true' the previous items and tasks still appear in the
  application Jump List at runtime (TFS 15448).

- Fixed an issue: extra letter 'l' is added to the description
  of C1ThumbButton.ImageIndex property (TFS 15450).

==================================================================
C1Win7Pack Build  2/4.0.20112.7             Build Date: 05/17/2011
==================================================================

- Updated the internal product info (used by the C1Live utility).

==================================================================
C1Win7Pack Build  2/4.0.20112.6             Build Date: 05/11/2011
==================================================================

- Added the 'About...' link for Win7Pack controls to the Commands
  area below the property grid (TFS 15305).

==================================================================
C1Win7Pack Build  2/4.0.20112.5             Build Date: 05/10/2011
==================================================================

- Fixed a bug: C1TaskDialog.DefaultButton property has no effect
  when the task dialog shows CommonButtons only (TFS 15259).

==================================================================
C1Win7Pack Build  2/4.0.20112.4             Build Date: 04/14/2011
==================================================================

- The C1TaskbarManager component renamed to C1TaskbarButton.

- Added the FlashIfNotActive() method to C1TaskbarButton. It
  flashes the window caption and taskbar button until the window
  comes to the foreground.

- Fixed a few small issues in C1TaskbarButton.

==================================================================
C1Win7Pack Build  2/4.0.20112.3             Build Date: 04/13/2011
==================================================================

- Fixed a problem with updating custom buttons and radio buttons
  in a visible task dialog.

- Fixed a bug: calling to any of the C1TaskDialog.Show() methods
  while the task dialog is visible showed another instance of the
  same task dialog. Now it brings the first instance of the
  dialog on top of other windows.

==================================================================
C1Win7Pack Build  2/4.0.20112.1             Build Date: 04/08/2011
==================================================================

- The first drop.

==================================================================
