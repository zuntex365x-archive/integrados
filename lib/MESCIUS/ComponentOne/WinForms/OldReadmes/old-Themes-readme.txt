<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

Readme file for the ComponentOne C1ThemeController component

- C1.Win.C1Themes.2.dll
- C1.Win.C1Themes.4.dll

Version number format:
- first  part: Version of the .NET framework used to build the assembly (e.g. 2 = .NET 2.x);
- second part: Internal use only;
- third  part: Year/version (e.g. 20133 = V3/2013);
- fourth part: Sequential number.

This assembly is available in two versions: .NET 2.x and .NET 4.0
(for every 2.x.x.x build there is a corresponding 4.x.x.x build)

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
C1.Win.C1Themes maintenance log
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20142.56, Sep 18, 2014
==========================================================================================

Bug fixes
---------
- Font property of standard controls reset to Control.DefaultFont if a font was not
  specified in theme. [69922]

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20142.55, Aug 01, 2014
==========================================================================================

Other changes
-------------
- Removed default theme font specification from ShinyBlue, VisualStyleOffice2010Blue and
  VisualStyleOffice2010Silver themes. [77341]

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20142.54, Jul 31, 2014
==========================================================================================

Other changes
-------------
- Updated themes.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20142.53, Jul 28, 2014
==========================================================================================

Bug fixes
---------
- "Office2012Barbie" had issues with some controls (invisible text etc). [73893]

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20142.52, Jun 28, 2014
==========================================================================================

* 2014v2 build.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20141.51, May 08, 2014
==========================================================================================

* Synchronized with C1ThemeDesigner application.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20141.50, May 05, 2014
==========================================================================================

Other changes
-------------
- Added 14 new themes (Mac*, Office2010, Office2013*, Windows8*).

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20141.46, Apr 29, 2014
==========================================================================================

* Synchronized with C1ThemeDesigner application.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20141.45, Apr 28, 2014
==========================================================================================

Other changes
-------------
- Fixed Japanese localization issues.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20141.38, Mar 18, 2014
==========================================================================================

* Synchronized with C1ThemeDesigner application.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20141.37, Mar 17, 2014
==========================================================================================

* Synchronized with C1ThemeDesigner application.

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
- Added C1Themes support to C1Chart, C1InputPanel, C1TileControl.
- Several new themes added, existing themes improved.
- Background theme items can now reference solid colors, and vice versa.
- New public class C1.Win.C1Themes.C1ThemeLocator: encapsulates a theme location
  (built-in or a disk file), can be saved to/loaded from a single string. This
  class can be used to persist the location/name of a theme used to theme an
  application, in the app's settings file.

Bug fixes
---------
- Miscellaneous bug fixes.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20133.20, Jan 27, 2014
==========================================================================================

New features
------------
- Several new themes added (VS2013_Blue, VS2013_Light, VS2013_Dark, BeigeOne, Violette).

Bug fixes
---------
- Several minor bug fixes.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20133.18, December 20, 2013
==========================================================================================

New features
------------
- Added C1Themes support to C1ReportDesigner (C1Report build 2/4.0.20133.54660 or newer).

Bug fixes
---------
- Misc bug fixes. [47057, 45982]

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20133.16, November 26, 2013
==========================================================================================

New features
------------
- Added C1Themes support to C1SplitContainer (build 2/4.0.20133.49 or newer).
- Added a "Reload themes" design-time action to C1ThemeController.

Other changes
-------------
- Added design-time descriptions to C1ThemeController events.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20133.14, November 13, 2013
==========================================================================================

Bug fixes
---------
- Minor bug fixes.

==========================================================================================
C1.Win.C1Themes -- Build 2/4.0.20133.12, November 11, 2013
==========================================================================================

- Initial public release.

  In this (2013v3) release, the following ComponentOne WinForms products support C1Themes:

  - C1Command
  - C1FlexGrid
  - C1GanttView
  - C1Input
  - C1Report (WinForms preview controls)
  - C1Ribbon
  - C1Schedule
  - C1SuperTooltip
  - C1TrueDBGrid

  In future releases and hotfixes, more products will include C1Themes support.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
Release notes, November 2013
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>

==========================================================================================
OVERVIEW
==========================================================================================

C1Themes is a ComponentOne product that allows to easily provide a consistent
customized look to WinForms applications which use other ComponentOne WinForms
products such as C1Ribbon, C1Scheduler, C1FlexGrid and others.

The C1Themes product physically consists of two separate parts:

- The C1.Win.C1Themes.2/C1.Win.C1Themes.4 assembly. The 2 or 4 number in the
  assembly's name indicates the target .NET version of your project.
  Functionally, both versions are identical and consume the same themes. This
  assembly provides the C1ThemeController component, which is used to load and
  apply themes to controls at design and runtime. Besides, the assembly contains
  (as embedded resources) a set of predefined themes which can be used as is, or
  customized to better serve your purposes.

- The C1ThemeDesigner application (C1ThemeDesigner.4.exe is installed by
  default; you may request to install the .NET 2.0 version C1ThemeDesigner.2.exe
  during installation but there is usually no need to do so as both versions of
  the theme designer work with the same theme files). This application can be
  used to create new, or customize existing themes (including those embedded
  into the C1.Win.C1Themes.2/4 assembly as mentioned above).

A theme is an XML document (with the .c1theme extension when saved in a file)
that contains a consistent set of values for properties determining the look and
feel of supporting controls. When applied to a form in an application (at
runtime and/or design time, using the C1ThemeController component), the theme
changes the look of controls on that form so that they all comply with the
theme.

Internally, a theme is divided into sections corresponding to different
ComponentOne products, so that each product only uses its own section when the
theme is applied. This allows to provide a customized "themed" look for even the
smallest and most specialized details of a control. Consistency within a theme
is achieved via a mechanism of references, which enables properties such as
colors and fonts in individual controls to reference a common repository
accessible to all other sections of the theme, which is called the "Base Theme
Properties". Properties in that repository are not directly applied to controls'
properties - rather, they can be referenced by the theme author when specifying
the actual properties used by the controls. Additionally, a theme includes a
section that is used by C1ThemeController to apply the theme to standard
WinForms forms and controls such as buttons and labels.

In an application, themes can come from the following sources:

- standard C1 themes embedded as resources into the C1.Win.C1Themes.2/4
  assembly;

- themes which you create using the C1ThemeDesigner application, and add
  as embedded resources into your own assemblies;

- themes which are loaded at runtime from .c1theme file(s).

The first two theme sources are available at design time via the
C1ThemeController properties and designer actions. At runtime, you can also load
themes in code from .c1theme files on disk using methods available on the
C1ThemeController component (please see the C1ThemeController docs for details).

==========================================================================================
C1ThemeController: Main Concepts and Properties
==========================================================================================

* Main concepts:

- Theme names: In C1Themes, themes are identified by their names. Names are
  case-sensitive, and must be unique within an application.

- Special theme names: There are two names that have special meaning and cannot
  be used as regular theme names:
  - "(default)": specifies the default theme in the current context;
  - "(none)": specifies that no theme should be applied.

- Application theme: on each form in an application, themes are applied by an
  instance of C1ThemeController living on that form. Hence different forms may
  use different themes (and individual controls may use themes different from
  their form's theme). Yet there is a simple way of specifying a single default
  theme for all theme controllers in an application, by setting the
  ApplicationTheme. This is a static (global) property available in the Visual
  Studio forms designer as a property on a C1ThemeController, and saved in the
  App.config file.

- Applying a theme to a control: it should be noted that when a
  C1ThemeController applies a theme to a control, it simply sets the visual
  properties of a control to the values specified in the theme. So applying a
  theme may overwrite any properties related to the visual appearance of a
  control (the actual set of properties overwritten by a theme is control-
  specific).

* Main C1ThemeController properties:

  - ApplicationTheme: specifies the application-wide (default) theme. As noted
    above, the name of this theme is stored in the App.config file.

  - Theme: specifies the default theme for the current C1ThemeController. The
    value "(default)" indicates that the application-wide theme specified by
    ApplicationTheme will be used.

  - A 'Theme on c1ThemeController1' extender property is added to all supporting
    controls on the form. This property supports two special values described
    above:

    - "(default)" means that the default theme specified for the
      C1ThemeController on the current form will be used for this control;

    - "(none)" means that no theme will be applied to this control.

    When set to a specific theme name, this property will apply that theme to
    the current control regardless of the theme controller's default theme. This
    allows to apply different themes to different controls on the same form if
    needed.

==========================================================================================
C1Themes and the VisualStyle Property
==========================================================================================

Many ComponentOne WinForms controls include a property called VisualStyle, of an
enum type defined in the control assembly, but following a common naming pattern
for the type and possible values. Typically, the enum type is called
VisualStyle, with values such as Office2010Blue, Office2010Black, etc. C1Themes
are designed to provide a more powerful and flexible mechanism for adjusting the
look of controls. Still there is obvious overlap between the two mechanisms,
with the possibility of conflicts. The rules for dealing with this overlap are
as follows:

- Theme sections for all C1 controls include a VisualStyle property that can be
  specified by the theme;

- By default and in all supplied themes, those properties are set 'Custom' so
  that VisualStyle does not interfere with applying other properties;

- Setting VisualStyle in a theme to anything other than custom sets the
  corresponding property on the target control and disables applying all other
  theme properties. (In the C1ThemeDesigner, this actually disables the rest of
  the theme tree for the control.)

While we recognize that backward compatibility or other considerations may
require the use of VisualStyle rather than themes to customize the look of your
application, we recommend that if possible you use C1Themes as they provide a
more powerful and flexible mechanism for that. Support for visual styles in
new controls will be phased out as themes will replace it.

==========================================================================================
C1ThemeController Quick Start
==========================================================================================

The steps below describe a simple way to start using C1Themes (for more details
please see the online docs).

1. Open a form belonging to your application in the Visual Studio's forms
  designer.

2. From the designer's toolbox, drag a C1ThemeController and drop it on your
  form. (The C1ThemeController is provided by the C1.Win.C1Themes.2/4 assembly;
  if you don't see it in your toolbox you can add it manually.)

3. When dropped on a form, the C1ThemeController pops up a dialog that allows
  you to select the application-wide default theme, the current controller's
  default theme, and themes for all supporting controls already on the form.
  (The same dialog is available via the "Set themes..." action on the
  C1ThemeController.)

  NOTE: initially in the dialog that pops up, the theme is specified as "(none)"
  for all supporting controls already on the form. This is done to prevent
  unintentional loss of property settings on those controls. Unless you have
  deliberately customized some of the controls already, you will want to click
  the "All to (default)" button in the dialog so that the default theme is set
  on all controls. (When new controls are dropped on the form already containing
  a C1ThemeController component, theme is set to "(default)" on them
  automatically.)

4. Select the default application theme from the list of available prebuilt
  themes. This theme name will be automatically stored in the App.config file.

5. Leave the theme on the current theme controller ('c1ThemeController1 theme')
  at its default "(default)" value (which means that the application theme will
  be used).

6. Click the "All to (default)" button as mentioned above, to set the default
  theme on all supporting controls on the form.

7. Finally, click the OK button to close the dialog and apply the specified
  theme to the controls on the form.

8. If your application contains multiple forms, repeat the steps above (with the
  exception of specifying the default ApplicationTheme as it will already be
  pre-selected for you) for all forms in your application.

When you are done, the selected application theme will be applied to controls on
your forms both at design and runtime.

==========================================================================================
Adding a Custom Theme to your Project
==========================================================================================

The steps above described how you can use one of the predefined themes shipped
with the C1Themes product and embedded into the C1.Win.C1Themes.2/4 assembly.
But you can also use themes either created from scratch by you, or themes based
on the standard ComponentOne themes and modified to suit your needs. To do so:

1. Create a new or modify an existing theme using the C1ThemeDesigner
  application (see the designer's documentation for details), and save it in a
  .c1theme file.

2. Open a form in your project in the Visual Studio forms designer. If that form
  does not yet contain a C1ThemeController component, add one as described above.

3. Click on the C1ThemeController component's "Add theme..." action item. This
  will show a file open dialog. Select the theme file (see p.1 above) and click
  OK.

4. The selected theme will be added to your C# or VB project as an embedded
resource in a 'Themes' folder, and will be available for selection from the
themes list provided by the C1ThemeController.

<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
The End.
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
