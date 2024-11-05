==================================================================
C1TileControl             ComponentOne, LLC - www.componentone.com
==================================================================

Welcome to ComponentOne Tile Control for WinForms.

------------------------------------------------------------------
ComponentOne C1TileControl is an integral part of Studio Enterprise,
the largest and most complete toolset for developing Win, Web,
Mobile and ASP.NET AJAX enabled applications.

Please direct feedback for C1TileControl to the following forum:

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

ComponentOne Tile Control for WinForms install the following files
and controls.

Files: C1.Win.C1TileControl.2/4.dll, C1.Win.C1TileControl.2/4.XML,
       C1.Win.C1TileControl.4.Design.dll

Controls: C1TileControl
------------------------------------------------------------------

History of Changes
==================================================================
C1TileControl 2/4.0.20142.95                Build Date: 07/21/2014
==================================================================

- Updated one Korean localization string (see TFS 63568).

==================================================================
C1TileControl 2/4.0.20142.94                Build Date: 07/15/2014
==================================================================

- Added a missing Chinese localization string (TFS 63568).

==================================================================
C1TileControl 2/4.0.20141.91                Build Date: 04/09/2014
==================================================================

- Fixed an issue: When DirectionVertical property of TextElement
  is set to True, numbers in the newly created tiles and group
  captions use incorrect font style in Japanese environment
  (TFS 63569).

- Added a missing localization string (TFS 63568).

==================================================================
C1TileControl 2/4.0.20141.90                Build Date: 03/26/2014
==================================================================

- Fixed an issue with multithreading: InvalidOperationException
  may occur when a C1TileControl is disposed.

==================================================================
C1TileControl 2/4.0.20141.89                Build Date: 03/10/2014
==================================================================

- Fixed a regression issue introduced in build 88: An exception
  is occurred on 64 bit platform when tapping a tile at runtime
  (TFS 56493).

==================================================================
C1TileControl 2/4.0.20141.88                Build Date: 03/05/2014
==================================================================

- Added the ability to use transparent and semi-transparent
  background colors for tiles.

- Fixed an issue: The UncheckTilesOnClick property (added in
  build 85) is not persisted in XML.

- Fixed a few issues with pen input device.

==================================================================
C1TileControl 2/4.0.20141.85                Build Date: 02/27/2014
==================================================================

- Added a new boolean property to C1TileControl:

  public bool UncheckTilesOnClick { get; set; }

  The property indicates whether all tiles have to be unchecked
  after clicking a tile (see TFS 52348).

- Improved the easing function used when animating slides.

==================================================================
C1TileControl 2/4.0.20141.84                Build Date: 02/25/2014
==================================================================

- Fixed an issue: An exception occurs after setting
  C1TileControl\Common\BackColor property to Color.Transparent
  in C1Theme Designer (see TFS 51929).

==================================================================
C1TileControl 2/4.0.20141.83                Build Date: 02/20/2014
==================================================================

- C1TileControl is now licensed as a part of Studio for Desktop.

==================================================================
C1TileControl 2/4.0.20141.82                Build Date: 02/10/2014
==================================================================

- Updated theming code for the latest version of C1ThemeDesigner.

==================================================================
C1TileControl 2/4.0.20141.81                Build Date: 01/31/2014
==================================================================

- Added theming support.

==================================================================
C1TileControl 2/4.0.20141.79                Build Date: 01/10/2014
==================================================================

- Fixed an issue: Various internal errors occurred after moving
  selection between C1Gauge and C1TileControl on the designer
  surface and also after pressing the Delete key (TFS 49257).

==================================================================
C1TileControl 2/4.0.20133.77                Build Date: 10/14/2013
==================================================================

- 2013/v3 build

==================================================================
C1TileControl 2/4.0.20132.76                Build Date: 09/13/2013
==================================================================

- Fixed an issue: When C1TileControl is selected on the designer
  surface and the user added a new control from the toolbox, the
  new control is added to C1TileControl.Controls collection.
  It should be added to C1TileControl's parent container control
  instead (TFS 41828).

==================================================================
C1TileControl 2/4.0.20132.75                Build Date: 09/12/2013
==================================================================

- Fixed an issue: Font size of text elements in slides does not
  refresh after changing C1TileControl's font size (TFS 41761).

==================================================================
C1TileControl 2/4.0.20132.74                Build Date: 09/05/2013
==================================================================

- Improved compatibility with various screen DPI values.

==================================================================
C1TileControl 2/4.0.20132.73                Build Date: 09/04/2013
==================================================================

- Fixed an issue: Text elements are not displayed properly
  after changing system DPI to "Medium - 125%" (TFS 41522).

- Fixed an issue: CommonImage2 and CommonImage3 properties of
  C1TileControl are not persisted in XML when the user clicks
  'Save As XML File' designer verb (TFS 41547).

==================================================================
C1TileControl 2/4.0.20132.72                Build Date: 09/02/2013
==================================================================

- Fixed an issue: it is impossible to pan or check/rearrange
  tiles using touch input when system DPI is not default and the
  "Use Windows XP style scaling" flag is not set in the Custom
  Sizing Options dialog or you selected "Larger - 150%" size.

==================================================================
C1TileControl 2/4.0.20132.71                Build Date: 08/15/2013
==================================================================

- Fixed an issue: a NullReferenceException occurs if the user
  starts moving a tile with the touch interface, then starts
  panning with touch, then drops/releases the tile being moved
  and continue panning with other hand (TFS 40978).

- Added the "Edit Default Template Slides" item to the context
  menu and smart tag of C1TileControl at design time (TFS 40980).

- Made an attempt to fix a thread-synchronization issue that is
  hard to reproduce (see TFS 40977).

==================================================================
C1TileControl 2/4.0.20132.70                Build Date: 07/12/2013
==================================================================

- Fixed an issue: the focused tile can be pressed with the Enter
  key while moving this or other tile with the mouse.

- Fixed an issue: Form.Deactivate event is fired on a Windows 8
  machine when the user starts rearranging tiles.

==================================================================
C1TileControl 2/4.0.20132.68                Build Date: 07/11/2013
==================================================================

- Fixed an issue: focus is shown on a tile after pressing the
  Escape key while moving the tile (TFS 39757).

- Fixed an issue: the Click event is fired for a C1TileControl
  when the Escape key is pressed while moving a tile and the
  user releases the mouse button (39758).

==================================================================
C1TileControl 2/4.0.20132.67                Build Date: 07/10/2013
==================================================================

- Fixed an issue: the Click and MouseClick events were fired for
  a C1TileControl inappropriately (TFS 39680).

==================================================================
C1TileControl 2/4.0.20132.66                Build Date: 07/08/2013
==================================================================

- Fixed an issue: it was possible to move tile to a hidden group
  at runtime (TFS 39483).

==================================================================
C1TileControl 2/4.0.20132.65                Build Date: 07/05/2013
==================================================================

- Added the missed localization strings for Chinese and Korean.

- Fixed an issue: Tooltip doesn't display the full text of tile
  when DirectionVertical property is set to True (TFS 39169).

- Changed behavior: Tooltip with full text is now not displayed
  for a text element which TextTrimming is set to None or to
  PathEllipsis. Showing long paths in the tooltip seems to be
  unnecessary.

- Fixed multiple layout issues with the TextElement.TextTrimming
  options (especially with EndEllipsis and WordEllipsis).

==================================================================
C1TileControl 2/4.0.20132.63                Build Date: 07/04/2013
==================================================================

- If the Tile object has no associated ToolTipText and its Text
  is partially displayed, the full text of tile is displayed in
  tooltip when the mouse pointer hovers that tile (TFS 38319).

==================================================================
C1TileControl 2/4.0.20132.62                Build Date: 07/02/2013
==================================================================

- Added the missed localization strings for Japanese.

==================================================================
C1TileControl 2/4.0.20132.61                Build Date: 07/01/2013
==================================================================

- Fixed an issue: NullReferenceException is thrown when a user
  clicks the Cancel button in the Template.Slides Collection
  Editor (TFS 38876).

==================================================================
C1TileControl 2/4.0.20132.60                Build Date: 07/01/2013
==================================================================

- Optimized memory usage for slides.

- Added the TransitionAcceleration property to the Slide class.
  It sets the acceleration (if value > 1.0) or deceleration (if
  value < 1.0) of the transition.

==================================================================
C1TileControl 2/4.0.20132.58                Build Date: 06/30/2013
==================================================================

- Added the Slides collection property to the Template class. It
  returns the collection of slides that can replace each other
  after a given amount of time using the specified transition
  method, such as Push or Fade.

- Added the TopmostElements property to the Template class. It
  returns the collection of elements that appear above all slides.

- Added the ShowSlides boolean property to the Tile class. It
  specifies whether the tile should display slides if any exist
  in the Template.Slides collection.

- The Template.Paint event is now fired for slides as well as for
  the main template. The TemplatePaintEventArgs.Slide property
  returns the currently drawn slide or null for the main template.

- Added HotBackColor and HotForeColor properties to C1TileControl.
  They specify the colors that replace BackColor and ForeColor of
  a Tile that is hovered with the mouse.

- Added CheckBackColor and CheckForeColor properties to
  C1TileControl. They specify the colors that replace BackColor
  and ForeColor of a Tile when it is checked.

- Added HotCheckBackColor and HotCheckForeColor properties to
  C1TileControl. These are the colors that replace BackColor and
  ForeColor of a checked Tile when it is hovered with the mouse.

- Added the AccessibleDescription, AccessibleName, and
  AccessibleRole properties to the Tile class. They work as the
  corresponding properties of the standard Control class.

- Added the UncheckAllTiles() method to C1TileControl. It removes
  check marks from all tiles.

- Added the ImageOrSymbol option to the ImageSelector enumeration.
  It binds to the default image of a tile or to the Tile.Symbol
  property if the image is not specified.

- Added the Enabled and EnabledSelector properties to Template.
  They specify whether the associated tile is enabled, i.e. it can
  be pressed, checked, or moved by the end user at runtime.

- "Edit Default Template" smart tag action of a C1TileControl is
  now renamed to "Edit Default Template Elements". Also, updated
  the smart tag panel of the Tile components.

- The TileMovingOpacity property renamed to MovingTileOpacity in
  C1TileControl.

==================================================================
C1TileControl 2/4.0.20132.57                Build Date: 06/24/2013
==================================================================

- Fixed an issue: Focus can not be moved to the first/last tile
  by pressing Ctrl+Home / Ctrl+End (TFS 38223).

- Added a few missed Chinese and Korean localization strings.

==================================================================
C1TileControl 2/4.0.20132.56                Build Date: 06/21/2013
==================================================================

- Fixed an issue: although the image list is deleted, images from
  image list are still shown on tiles at design time (TFS 38043).

- Fixed an issue: an ObjectDisposedException exception is thrown
  when the Form.Close() method is executed from the Click event
  handler of C1TileControl (TFS 38062).

- Fixed an issue: under Windows 7 the focus rectangle is still
  shown on a tile after rearranging tiles (TFS 38101).

==================================================================
C1TileControl 2/4.0.20132.55                Build Date: 06/20/2013
==================================================================

- Fixed an issue: ContextMenu is shown at design-time when a user
  right clicks on C1TileControl (TFS 37987).

- Changed behavior: tiles are not unchecked automatically when
  a user starts rearranging tiles. This addresses the issue with
  throwing a NullReferenceException if the Form is closed from
  a handler of the Tile.CheckedChanged event (TFS 38031).

- Updated description of the C1TileControl.ShowToolTips property
  (TFS 37946).

==================================================================
C1TileControl 2/4.0.20132.54                Build Date: 06/17/2013
==================================================================

- Fixed an issue: When the group text is displayed with end
  ellipsis no tooltip is shown for full text (TFS 37844).

==================================================================
C1TileControl 2/4.0.20132.53                Build Date: 06/15/2013
==================================================================

- Fixed an issue: "Duplicate the selected item" button does not
  work  after opening and closing the Children Collection Edior
  of a nested panel element (TFS 37638).

- Fixed an issue: Unlike Windows 8, tiles remain checked after
  clicking a tile or starting rearranging tiles (TFS 37856).

- Fixed a problem with displaying group caption when the groups
  are arranged vertically (partially fixed TFS 37844).

==================================================================
C1TileControl 2/4.0.20132.52                Build Date: 06/13/2013
==================================================================

- Fixed an issue: NullReferenceException is observed after
  dragging a tile out of the client area of C1TileControl and
  clicking the right mouse button (TFS 37769).

- Fixed an issue: When a tile is dragged out of the control area,
  the tile groups are scrolling automatically, but after releasing
  the mouse button C1TileControl is still scrolling till the end
  although the tile has already been released (TFS 37770).

- Added a few missed Japanese localization strings (TFS 37731).

==================================================================
C1TileControl 2/4.0.20132.51                Build Date: 06/12/2013
==================================================================

- Scrolling of tile groups is now started automatically when
  a tile is moved beyond the bounds of the scrollable surface.

- Accessibility (MSAA) is now supported in C1TileControl.

==================================================================
C1TileControl 2/4.0.20132.49                Build Date: 06/11/2013
==================================================================

- Added the AllowRearranging property to C1TileControl. It
  indicates whether the user can rearrange tiles with the mouse
  or touch device at runtime.

- Added the SwipeRearrangeDistance property that specifies the
  distance for a swipe gesture to start rearranging tiles.

- Added the TileMovingOpacity property that sets the opacity
  level of a tile being moved by the user at runtime.

==================================================================
C1TileControl 2/4.0.20131.47                Build Date: 05/16/2013
==================================================================

- Added missing strings for Chinese and Korean localization.

==================================================================
C1TileControl 2/4.0.20131.46                Build Date: 05/15/2013
==================================================================

- Added a few missing strings for Japanese localization.

==================================================================
C1TileControl 2/4.0.20131.45                Build Date: 05/13/2013
==================================================================

- Fixed an issue: if the Form.Close() method is executed from
  the Tile.Click event handler the ObjectDisposedException is
  fired in C1TileControl when a user taps this tile using the
  touch device (TFS 36516).

- Added the DataSource and DataMember properties to C1TileControl.
  It is now possible to load tiles dynamically from a data source
  at runtime. When some data is changed in the associated data
  source all tiles are recreated automatically.
  
- Added the PropertyMappings collection property to C1TileControl.
  The collection consists of the PropertyMapping objects that
  establish an association between the property of an item from
  data source and the property of the corresponding Tile
  component. 

- Added the FilterItem event to C1TileControl. It occurs when
  loading an item from the data source. You can skip creating
  a Tile for the given item if you set e.Skip to True in this
  event handler.

- Added the FormatValue event to C1TileControl. It occurs when
  a data value has to be mapped to a tile property. Use this
  event to convert a value to the appropriate data type or to
  generate value for a given data item. For example, you can use
  this event to make a background color dependent on a Decimal
  value obtained from the data source.
  
- Added the CompareGroups/CompareTiles events to C1TileControl.
  These events occur when sorting groups and tiles after filling
  from a data source. They allows the user to compare two groups
  or two tiles and make a decision which of those items should
  precede the other in the corresponding collection.

==================================================================
C1TileControl 2/4.0.20131.44                Build Date: 04/29/2013
==================================================================

- Moved to the new internal localization model.

==================================================================
C1TileControl 2/4.0.20131.43                Build Date: 04/03/2013
==================================================================

- Moved to the subscription licensing model in Japanese build.

==================================================================
C1TileControl 2/4.0.20131.41                Build Date: 03/12/2013
==================================================================

- Added a few missed strings for Korean localization.

==================================================================
C1TileControl 2/4.0.20131.40                Build Date: 03/09/2013
==================================================================

- C1TileControl is now localized for Japanese (TFS 34731).

- Added a few missed strings for Chinese localization.

==================================================================
C1TileControl 2/4.0.20131.39                Build Date: 03/02/2013
==================================================================

- Added the AllowPanningFeedback property to C1TileControl. The
  property specifies whether the form shows a visual cue when
  a user reaches the end of a pannable area (true by default).

- Added the TileBorderColor property to C1TileControl. It gets
  or sets the color of a thin border that is drawn around tiles.

- Added the SBThumbBorderColor and SBThumbInnerColor properties
  to C1TileControl. The properties specify the colors of the
  border and interior of the scroll bar thumb.

==================================================================
C1TileControl 2/4.0.20131.38                Build Date: 02/26/2013
==================================================================

- Updated a few Chinese localization strings.

==================================================================
C1TileControl 2/4.0.20131.37                Build Date: 02/11/2013
==================================================================

- Added the GroupSpacing property to C1TileControl. It specifies
  the gap between groups on the scrollable surface.

==================================================================
C1TileControl 2/4.0.20131.36                Build Date: 02/08/2013
==================================================================

- Fixed a couple of localization issues (TFS 33918, 33919).

==================================================================
C1TileControl 2/4.0.20131.35                Build Date: 02/07/2013
==================================================================

- Added Chinese and Korean localization strings.

==================================================================
C1TileControl 2/4.0.20131.34                Build Date: 02/04/2013
==================================================================

- Members of the TileSymbol enumeration have descriptions now.

==================================================================
C1TileControl 2/4.0.20131.33                Build Date: 01/31/2013
==================================================================

- Fixed an issue: Focus is not set to the last tile when the user
  presses the End key (TFS 33675).

==================================================================
C1TileControl 2/4.0.20131.32                Build Date: 01/30/2013
==================================================================

- Added the RightToLeft property to the TextElement class. It
  allows to display correctly multiline English text in vertical
  direction (see TFS 33631).
  
- Added the MeasureTrailingSpaces property to the TextElement
  class (true by default). It specifies whether the text bounding
  rectangle includes the trailing space at the end of each line.
  It is only applicable if the text element has no background.

==================================================================
C1TileControl 2/4.0.20131.31                Build Date: 01/30/2013
==================================================================

- Added a small change to the SmartTag panel for groups and tiles.
  Now it shows the name of the currently selected object to avoid
  confusion because the SmartTag panel appears for groups, tiles,
  and the C1TileControl itself.

- Fixed an issue: Sometimes pressing the Home key doesn't scroll
  the surface to the beginning in case of vertical orientation.

==================================================================
C1TileControl 2/4.0.20131.29                Build Date: 01/29/2013
==================================================================

- Fixed an issue: When loading an xml file to C1TileControl and
  then undoing this operation, the previous state (before loading
  xml file) cannot be reached (TFS 33564).

==================================================================
C1TileControl 2/4.0.20131.28                Build Date: 01/28/2013
==================================================================

- Fixed an issue: 'NullReferenceException' is observed at design
  time after setting tile’s Group and changing other property
  of the same tile, then undoing all these changes (TFS 33559).

- Fixed an issue: the Name property of a Template, Group and
  Tile components is not loaded from an XML file.

==================================================================
C1TileControl 2/4.0.20131.27                Build Date: 01/27/2013
==================================================================

- Added the DirectionVertical property to TextElement. It allows
  to draw text vertically.

- Added the SurfaceContentAlignment property to C1TileControl.
  It specifies the alignment of groups on the scrollable surface
  when the surface size (either horizontal or vertical) exceeds
  the size of all the groups.

- PassThroughNavigation property renamed to PassthroughNavigation
  (the fifth letter 'T' changed to lower case 't').

- Added a couple of new items on the SmartTag panel.

- Fixed an issue: C1TileControl disappears when its Height is
  not enough for displaying the whole cell (TFS 33531).

- Fixed a few issues with z-order of tiles when the CellSpacing
  property of C1TileControl is set to 0.

==================================================================
C1TileControl 2/4.0.20131.24                Build Date: 01/25/2013
==================================================================

- Fixed an issue: If the tile template is updated on the smart
  tag panel this change is not persisted (TFS 33493).

- Added the BackColor and BackColorSelector properties to the
  Template object. It is now possible to specify the background
  color for tiles in their template.

==================================================================
C1TileControl 2/4.0.20131.22                Build Date: 01/24/2013
==================================================================

- Fixed an issue: right-click on a tile shows the context menu
  and also checks/unchecks the tile. Now the context menu is
  not shown if the AllowChecking property is True and the user
  right-clicked a tile. Also, the context menu is not displayed
  when the user right-clicks the scrollbar.

- Now the Tile.Template property shows "(default)" instead of
  "(none)" in the property grid if this property contains no
  reference to the Template object.

==================================================================
C1TileControl 2/4.0.20131.21                Build Date: 01/23/2013
==================================================================

- Added the ClearCache() method to C1TileControl. The method
  releases memory occupied by internal cached images.

- Added the SaveXml() and LoadXml() methods to C1TileControl.
  The methods save/load the layout of the tile control to/from
  the specified XML file or stream.

- Added the "Load From XML File" and "Save To XML File" actions
  to C1TileControl's smart tag panel.

==================================================================
C1TileControl 2/4.0.20131.20                Build Date: 01/18/2013
==================================================================

- Updated the toolbox icon for C1TileControl.

==================================================================
C1TileControl 2/4.0.20131.19                Build Date: 01/17/2013
==================================================================

- Fixed an issue: Pressing the End key doesn't focus sometimes
  the last visible tile when the Orientation property is set
  to 'Vertical' (TFS 33246).

- Fixed an issue: Modified properties are reverted to their
  original values after closing the Template.Elements collection
  editor if the properties were set for elements of the second
  nested panel element in the template (TFS 33258).

==================================================================
C1TileControl 2/4.0.20131.18                Build Date: 01/16/2013
==================================================================

- Fixed an issue: Pressing the Tab key doesn't focus the current
  tile in C1TileControl if there are no other focusable controls
  on the same form (TFS 33219).

- Changed behavior: If no tiles are checked pressing the Escape
  key removes selection from the focused tile.

- The maximum value of the SwipeDistance property is now limited
  to 100. An attempt to set this property to a greater value
  doesn't throw an exception though (TFS 33220).

==================================================================
C1TileControl 2/4.0.20131.17                Build Date: 01/15/2013
==================================================================

- Added the Symbol property to the Tile component. The property
  can be used by an ImageElement if its ImageSelector is set to
  'Symbol'. With the Symbol property you can choose an image for
  a tile from many predefined images (312 images). The color of
  displayed symbol depends on the ForeColor property. Also, added
  the Symbol property to ImageElement. That property is used if
  an ImageElement.ImageSelector is set to 'UnboundSymbol'.

- Added the SymbolSize property to ImageElement. The property
  allows to vary the size of the symbol that is displayed by
  the image element. There are 9 predefined symbol sizes.

- Added the ForeColor and ForeColorSelector properties to an
  ImageElement. These properties specify the foreground color
  for symbols, numbers, and stars.

==================================================================
C1TileControl 2/4.0.20131.16                Build Date: 01/10/2013
==================================================================

- Fixed an issue: Pressing the Home or End keys makes the tile
  control scrolling through to the first/last tiles but doesn't
  move to the first or last tiles directly (TFS 33102).

==================================================================
C1TileControl 2/4.0.20131.15                Build Date: 01/10/2013
==================================================================

- Added the PassThroughNavigation property to C1TileControl.
  The new property indicates whether the keyboard should navigate
  to the next row/column after focusing the last tile in the
  current row/column for vertical/horizontal layout (TFS 33080).

- Increased the speed of scrolling when the user presses the
  left/right scrollbar buttons (see discussion in TFS 32999).

==================================================================
C1TileControl 2/4.0.20131.14                Build Date: 01/08/2013
==================================================================

- Fixed an issue: An exception is thrown after setting some
  properties in the children of a PanelElement and cancelling
  the Template.Elements Collection Editor at design time
  (TFS 33035).

- Fixed an issue: C1TileControl is not redrawn correctly when it
  is docked within the owner Form and the user resizes the Form
  (TFS 32999).

==================================================================
C1TileControl 2/4.0.20131.12                Build Date: 01/06/2013
==================================================================

- Group.Index, Tile.Index, and Tile.Group properties become
  read-only in a collection editor. Setting these properties
  from a collection editor caused incorrect behavior in previous
  builds. Now an attempt to set any of these properties has no
  effect in a collection editor. Use the "up arrow" and "down
  arrow" buttons instead (TFS 32501).

- Fixed an issue: modified properties are not restored to their
  original values when the user clicks the Cancel button or
  presses the Esc key in a collection editor for PanelElement's
  Children property (TFS 32708).

- Added small optimization to the redrawing algorithm. Now the
  tile control is not redrawn too frequently.

==================================================================
C1TileControl 2/4.0.20131.10                Build Date: 01/04/2013
==================================================================

- The type of the C1TileControl.CheckedTiles read-only property
  changed from 'List<Tile>' to 'Tile[]' to prevent expectations
  that the tiles can be checked/unchecked by adding/removing
  them to/from the list. The only correct way to check/uncheck
  tiles from program code is setting the Tile.Checked property.

- Pressing the Esc key uncheckes all checked tile if any exist.

- Pressing the Enter key executes the PerformClick() method for
  a Tile which is currently focused.

==================================================================
C1TileControl 2/4.0.20131.9                 Build Date: 01/02/2013
==================================================================

- The CellMargin property of a C1TileControl has been renamed
  to CellSpacing.

- The WordBreak property has been removed from TextElement. It
  seems to be ambiguous since we have the SingleLine property
  in the same class (see TFS 32502).

==================================================================
C1TileControl 2/4.0.20131.8                 Build Date: 12/28/2012
==================================================================

- Fixed an issue: Deleting a custom template does not apply the
  default template to the tiles using that template (TFS 32319).

==================================================================
C1TileControl 2/4.0.20131.7                 Build Date: 12/26/2012
==================================================================

- Fixed an issue: if a TextElement has the BackColor property set
  to Color.Empty and its BackColorSelector is set to 'Unbound'
  the text is not displayed sometimes (that's a rounding error).

==================================================================
C1TileControl 2/4.0.20131.6                 Build Date: 12/24/2012
==================================================================

- Updated the initial layout of C1TileControl when it is added
  from the Visual Studio Toolbox.

- Minor changes in the designer behavior (smart tag appears each
  time when the user clicks a tile).

- Fixed an issue with setting position for a tile tooltip.

- Fixed an issue: The Padding property of the owner element was
  not taken into account by a PanelElement which has the Dock
  property set to anything other than 'None'.

- Added the ClipNoPadding option to the possible values for the
  ImageElement.ImageLayout property. It allows to display a
  clipped image as the background for a stacked panel.

==================================================================
C1TileControl 2/4.0.20131.3                 Build Date: 12/24/2012
==================================================================

- Added support for keyboard navigation in the tile control.
  Also, added the FocusedBorderColor property to C1TileControl.
  The property specifies the color of the tile border when the
  tile is selected using the keyboard.

- Added the "badge number" and "5-stars" value-dependent images
  that can be displayed on an ImageElement.

- Added the CommonImage1/2/3 properties to C1TileControl. These
  allow to use the same set of value-dependent images (packed
  into a compound image with several rows and/or columns) from
  multiple templates.

- The AlignmentOfContents property now works as expected for
  the PanelElement.

- Added new verbs to the Tile and Group smart tag panels.

==================================================================
C1TileControl 2/4.0.20131.1                 Build Date: 12/19/2012
==================================================================

- The first drop.

==================================================================
