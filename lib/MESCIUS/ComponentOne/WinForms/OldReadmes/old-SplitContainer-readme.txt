==================================================================
C1SplitContainer          ComponentOne, LLC - www.componentone.com
==================================================================

Welcome to ComponentOne SplitContainer for WinForms.

C1SplitContainer works similar to the standard SplitContainer
control. It represents a container for resizable docked panels
(C1SplitterPanel). Unlike the standard control, there may be more
than two panels in a C1SplitContainer. These panels can be docked
to either side of the container control.

The panels are either resizable or fixed. Dimension of resizable
panels can be changed with the special splitter element. The
actual size of a corresponding panel can be updated when the user
releases the mouse button after dragging the splitter or while
the user is dragging the splitter (on-the-fly). The minimum height
and width of each panel is maintained (if possible) when moving
splitters or resizing the container control.

Panels can display a collapsing handle. If the user clicks such
a handler at runtime, the corresponding panel disappears from
the screen, except a narrow band with an expanding handle. There
are two predefined scales of the collapsing/expanding handles
(compact and enlarged).

The size of a panel can be either absolute or relative. Panels
with relative size try to keep their size ratio when the owner
container control is resized. The Visible property of a
C1SplitterPanel control affects the collapsing state of the
panel (if the Collapsible property is set to true).

Panels can display headers with caption text. You can adjust
appearance of headers and other visual elements using a few handy
properties of a C1SplitContainer, such as HeaderHeight,
SplitterColor, and so on. The special drawing events are also
provided in C1SplitterPanel to support owner-drawn splitters and
panel headers. At design-time, the user can click a panel header
to select the corresponding panel control. If she clicks the
panel header for the second time the whole C1SplitContainer
will be selected.

C1SplitContainer control has the VisualStyle property. It allows
to adjust visual appearance of the split container to make it
consistent with other ComponentOne controls for WinForms, such
as C1RibbonForm, C1InputPanel, and so on.

It is also possible to add nested C1SplitContainer controls to
the panel controls. This allows to create more complex layouts.
When the user updates style properties of the most parent split
container these changes affect all nested containers as well
(if the UpdateNestedContainers property is set to true).

------------------------------------------------------------------
ComponentOne SplitContainer is an integral part of Studio Enterprise,
the largest and most complete toolset for developing Win, Web,
Mobile and ASP.NET AJAX enabled applications.

Please direct feedback for SplitContainer to the following forum:

http://our.componentone.com/groups/winforms/general-winforms-discussion-12971/forum/

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

ComponentOne SplitContainer for WinForms installs the following
files and controls.

Files: C1.Win.C1SplitContainer.2/4.dll, C1.Win.C1SplitContainer.2/4.XML,
       C1.Win.C1SplitContainer.4.Design.dll

Controls: C1SplitContainer
------------------------------------------------------------------

History of Changes
==================================================================
C1SplitContainer 2/4.0.20142.56             Build Date: 06/23/2014
==================================================================

- 2014/v2 drop.

==================================================================
C1SplitContainer 2/4.0.20141.55             Build Date: 04/14/2014
==================================================================

- Fixed an issue: previous value of the Height property is
  returned in C1SplitterPanel.Resize event when the splitter is
  moved at runtime (TFS 63930).

==================================================================
C1SplitContainer 2/4.0.20141.54             Build Date: 03/05/2014
==================================================================

- Fixed an issue: When a C1SplitterPanel is in disabled state
  the HeaderClick and HeaderDoubleClick events are still fired
  (TFS 49918).

==================================================================
C1SplitContainer 2/4.0.20141.53             Build Date: 02/20/2014
==================================================================

- C1SplitContainer is now licensed as part of Studio for Desktop.

==================================================================
C1SplitContainer 2/4.0.20141.52             Build Date: 02/10/2014
==================================================================

- Updated theming code for the latest version of C1ThemeDesigner.

==================================================================
C1SplitContainer 2/4.0.20133.50             Build Date: 12/09/2013
==================================================================

- Fixed an issue: In C1SplitContainer, whenever the user changes
  the value of "Theme on c1ThemeController1" property, the
  UpdateNestedContaners property is reset to False (TFS 46981).

- Fixed an issue: Tooltips become distorted when
  C1SplitContainer\Tooltip\Background\BackColor property is set
  to Color.Transparent in C1ThemeDesigner (TFS 46977).

==================================================================
C1SplitContainer 2/4.0.20133.49             Build Date: 11/22/2013
==================================================================

- Added theming support.

==================================================================
C1SplitContainer 2/4.0.20132.46             Build Date: 09/08/2013
==================================================================

- Internal changes in the localization code.

==================================================================
C1SplitContainer 2/4.0.20132.45             Build Date: 06/04/2013
==================================================================

- URL changes for GrapeCity JPN AboutBox.

==================================================================
C1SplitContainer 2/4.0.20131.43             Build Date: 04/03/2013
==================================================================

- Moved to the subscription licensing model in Japanese build.

==================================================================
C1SplitContainer 2/4.0.20123.40             Build Date: 12/26/2012
==================================================================

- Fixed an issue: C1SplitterPanel is not repainted correctly
  (build 39 reintroduced TFS issue 32220).

==================================================================
C1SplitContainer 2/4.0.20123.39             Build Date: 12/24/2012
==================================================================

- Optimized repainting when the ResizeWhileDragging property of
  a C1SplitterPanel is set to true (TFS 32246, 32249).

==================================================================
C1SplitContainer 2/4.0.20123.38             Build Date: 12/22/2012
==================================================================

- Fixed an issue: C1SplitterPanel is not repainted correctly if
  its size exceeds the MaximumSize specified for a Control which
  is docked (Dock = Fill) within the splitter panel (TFS 32220).

==================================================================
C1SplitContainer 2/4.0.20123.37             Build Date: 10/25/2012
==================================================================

- The interface language depends now on CurrentUICulture setting
  instead of the CurrentCulture property of CultureInfo.

==================================================================
C1SplitContainer 2/4.0.20123.36             Build Date: 10/21/2012
==================================================================

- Small internal optimization.

==================================================================
C1SplitContainer 2/4.0.20123.35             Build Date: 10/13/2012
==================================================================

- Minor internal changes for better compatibility with VS2012.

==================================================================
C1SplitContainer 2/4.0.20123.34             Build Date: 10/10/2012
==================================================================

- Added the Chinese and Korean localization strings.

==================================================================
C1SplitContainer 2/4.0.20122.33             Build Date: 09/21/2012
==================================================================

- Fixed a few issues in panel's collapsing/collapsed tooltips
  when the right-to-left mode is active.

- Fixed a few potential issues that might occur when the control
  is used from multiple threads.

==================================================================
C1SplitContainer 2/4.0.20122.31             Build Date: 09/12/2012
==================================================================

- Fixed an issue: changes to the parent SplitContainer's style
  properties, such as VisualStyle, may unexpectedly affect the
  nested SplitContainers even if the UpdateNestedContainer
  property is set to False (TFS 27843).

==================================================================
C1SplitContainer 2/4.0.20122.27             Build Date: 09/04/2012
==================================================================

- Updated VS2012 toolbox icon.

==================================================================
C1SplitContainer 2/4.0.20122.24             Build Date: 08/27/2012
==================================================================

- Fixed an issue: the panel caption text was not correctly
  aligned when the RightToLeft property is set to 'Yes' in the
  C1SplitContainer. Also, RTL text displayed incorrectly in
  the tooltip for the truncated panel caption.

- The RightToLeft property is now hidden in the property grid
  for a C1SplitterPanel. It's still available at run-time as
  a read-only property (setting it has no effect).

==================================================================
C1SplitContainer 2/4.0.20122.23             Build Date: 08/24/2012
==================================================================

- C1SplitContainer is now localized for the Japanese culture.

- Added VS2012 toolbox icon.

==================================================================
C1SplitContainer 2/4.0.20122.19             Build Date: 06/27/2012
==================================================================

- Fixed an issue: a NullReferenceException is observed sometimes
  after resizing a splitter panel (TFS 23660).

==================================================================
C1SplitContainer 2/4.0.20121.16             Build Date: 05/02/2012
==================================================================

- Fixed an issue: the TabControl's header is not redrawn correctly
  when resizing a C1SplitterPanel with the TabControl having the
  Dock property set to Fill (TFS 21491).

==================================================================
C1SplitContainer 2/4.0.20121.15             Build Date: 04/13/2012
==================================================================

- Fixed an issue: the Validating and Validated events were
  not fired on controls inside a C1SplitContainer after calling
  the ValidateChildren() method of the owner Form.

==================================================================
C1SplitContainer 2/4.0.20113.13             Build Date: 11/30/2011
==================================================================

- Updated licensing to conform with Federal Information Processing
  Standards requirements (TFS 18562).

==================================================================
C1SplitContainer 2/4.0.20113.12             Build Date: 11/23/2011
==================================================================

- Added the HeaderLineWidth property to C1SplitContainer. The
  property specifies the width of a horizontal line that appears
  below panel headers. If it's equal to 0 the header line width
  depends on the FixedLineWidth property.

- Added the HeaderLineColor property to C1SplitterPanel. The
  property sets the color of a horizontal line that appears below
  the panel header.

==================================================================
C1SplitContainer 2/4.0.20113.11             Build Date: 11/04/2011
==================================================================

- Default value for the C1SplitContainer.BorderWidth property
  changed from 1 to 0 (BREAKING CHANGE).

- Hidden a few protected properties in C1SplitContainer and
  C1SplitterPanel from the Object Browser (TFS 18190).

- Added the "Dock in Parent Container" SmartTag Link to the
  C1SplitContainer's tasks (TFS 18193).

==================================================================
C1SplitContainer 2/4.0.20113.10             Build Date: 11/03/2011
==================================================================

- Added the BorderColor and BorderWidth properties to the
  C1SplitterPanel control:

  public Color BorderColor { get; set; }
  public int BorderWidth { get; set; }

  Individual panels can now display a border that surrounds both
  the panel contents and its header. The default value for the
  BorderWidth property is set to 0 (border is hidden by default).
  
- Removed the BorderStyle property from the C1SplitterPanel class
  (it's still available at runtime for backward compatibility).

==================================================================
C1SplitContainer 2/4.0.20113.9              Build Date: 10/05/2011
==================================================================

- Licensing update for FIPS compliance.

==================================================================
C1SplitContainer 2/4.0.20113.8              Build Date: 09/12/2011
==================================================================

- Updated a toolbox icon for the C1SplitContainer control.

- Fixed a few problems in the XML documentation file.

- The following methods become public (they were declared as
  protected in the previous builds):
  
  C1SplitContainer.ResetBorderColor()
  C1SplitContainer.ResetFixedLineColor()
  C1SplitContainer.ResetCollapsingAreaColor()
  C1SplitContainer.ResetCollapsingCueColor()
  C1SplitContainer.ResetCollapsedToolTip()
  C1SplitContainer.ResetCollapsingToolTip()
  C1SplitContainer.ResetHeaderBackColor()
  C1SplitContainer.ResetHeaderForeColor()
  C1SplitContainer.ResetSplitterColor()
  C1SplitContainer.ResetSplitterMovingColor()

  C1SplitterPanel.ResetPadding()
  C1SplitterPanel.ResetSizeRatio()
  C1SplitterPanel.ResetHeight()
  C1SplitterPanel.ResetWidth()
  C1SplitterPanel.ResetHeaderBackColor()
  C1SplitterPanel.ResetHeaderForeColor()
  
  Each of these methods resets the value of the corresponding
  property to its default state.

==================================================================
C1SplitContainer 2/4.0.20113.7              Build Date: 09/09/2011
==================================================================

- Fixed an issue: the splitter panel's background is redrawn
  even if the whole panel is covered by opaque child controls
  (see TFS 17106). The issue was partly fixed in build 5 (for
  single child control). Now it is fixed for multiple opaque
  child controls as well.

==================================================================
C1SplitContainer 2/4.0.20113.6              Build Date: 09/07/2011
==================================================================

- Fixed an issue: the result of setting the BackColor property
  of a C1SplitContainer or C1SplitterPanel to a transparent or
  semi-transparent color was incorrect.

==================================================================
C1SplitContainer 2/4.0.20113.4              Build Date: 09/05/2011
==================================================================

- Fixed an issue: Panel headers are not refreshed after adding
  BackgroundImage to the panels, setting BackgroundImageLayout
  to Tile, and resizing the panel (TFS 17061).

- Fixed an issue: Panel headers are still visible in the split
  container although all the panels Visible property is set to
  false (TFS 17062).

==================================================================
C1SplitContainer 2/4.0.20113.3              Build Date: 09/03/2011
==================================================================

- Fixed an issue: the BackColor, ForeColor and Font properties
  of a nested C1SplitContainer were not updated if they are set
  to not default values although the parent split container's
  UpdateNestedContainers property is set to true (TFS 17026).

- Fixed an issue with the DrawHeader and DrawSplitter events that
  fired twice when repainting a C1SplitContainer (TFS 17045).

- Fixed a bug: when C1SplitterPanel.ResizeWhileDragging is set
  to True, there were problems while resizing this panel if there
  are more than one panel after this one in the collection.

==================================================================
C1SplitContainer 2/4.0.20113.2              Build Date: 08/31/2011
==================================================================

- Fixed an issue in case if the RightToLeft property is set to
  'Yes' for a C1SplitContainer. This should affect the panel's
  Dock property behavior (every left-docked panel must appear
  as right-docked and vice versa).

==================================================================
C1SplitContainer 2/4.0.20113.1              Build Date: 08/30/2011
==================================================================

- The first drop.

==================================================================
