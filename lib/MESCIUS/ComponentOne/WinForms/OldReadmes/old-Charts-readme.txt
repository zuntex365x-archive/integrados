Thank you for your interest in the ComponentOne Chart offering.
ComponentOne Chart for .Net (C1Chart and C1Chart3D), is an integral
part of ComponentOne Studio for .Net.

Please note, the version numbers given in the Maintenance log below
refer to the AssemblyVersion.


C1Chart components are contained in the following dlls:

 .NET 2.x
   C1.Win.C1Chart.2.dll, C1.Win.C1Chart3D.2.dll,

 .NET 4.x
   C1.Win.C1Chart.4.dll, C1.Win.C1Chart3D.4.dll,
   C1.Win.C1Chart.4.Design.dll, C1.Win.C1Chart3D.4.Design.dll,


Version numbers for .NET 2.x builds have major.minor version number values of 2.x.
Version numbers for .NET 4.x builds have major.minor version number values of 4.x.


<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
C1Chart.Net is the 2D Componentone Chart for .Net
C1Chart.Net Maintenance log:


======================================================================================
C1Chart.Net Build Number 4.0.20142.24286   Build Date: Tuesday, October 14, 2014
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


====================================================================================
C1Chart.Net Build Number 4.0.20142.24247   Build Date: Friday, September 5, 2014
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added Japanese, Korean and Chinese localizations for the ContourMethod
  propery description and Save Chart Template and Load Chart Template verbs.
* Added 14 significant digit rounding to axis min/max calculations due to
  .NET handling of doubles.  This provideds improved axis limit annotations.


Corrections
-----------
none



==================================================================================
C1Chart.Net Build Number 4.0.20142.24182   Build Date: Wednesday, July 2, 2014
==================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



===============================================================================
C1Chart.Net Build Number 4.0.20142.24177   Build Date: Friday, Jun 27, 2014
===============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added ChartGroups.ReverseDraw property.
  Documentation should include the new property.

    Gets or sets whether the order in which the ChartGroups are normally
    drawn is reversed.

    ChartGroups are normally drawn in descending order in which they
    appear in the ChartGroupsCollection. If ReversedDraw is true, then
    the ChartGroups are drawn in ascending order in which they appear in the
    ChartGroupsCollection.

* Added of saving and loading chart templates.  Chart templates are similar
  to chart descriptions, but do not store or reset data upon loading.  The
  new method prototypes include:

      void SaveChartTemplateToFile(string Filename);
      string templateString = SaveChartTemplateToString();
      string templateString = SaveChartTemplateToString(bool formatting);

      void LoadChartTemplateFromFile(string Filename);
      void LoadChartTemplateFromString(string templateString);

   Documentation should include the new methods.

Corrections
-----------
none



==============================================================================
C1Chart.Net Build Number 4.0.20141.24156   Build Date: Friday, Jun 6, 2014
==============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Zooming interactions how handle very small values more appropriately.


Corrections
-----------
none



===============================================================================
C1Chart.Net Build Number 4.0.20141.24135   Build Date: Friday, May 16, 2014
===============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Modified an axis sizing loop that was causing design time hang when
  loading old persisted data.


Corrections
-----------
none



==================================================================================
C1Chart.Net Build Number 4.0.20141.24092   Build Date: Thursday, April 3, 2014
==================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* The chart now always translates it coordinate system to use internal
  coordinates when invoking the chart Draw method.  This is necessary
  to correctly draw chart elements with specific values.


Corrections
-----------
none



=================================================================================
C1Chart.Net Build Number 4.0.20141.24071   Build Date: Thursday, March 13, 2014
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



====================================================================================
C1Chart.Net Build Number 4.0.20141.24070   Build Date: Wednesday, March 12, 2014
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=================================================================================
C1Chart.Net Build Number 4.0.20141.24062   Build Date: Tuesday, March 4, 2014
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=======================================================================================
C1Chart.Net Build Number 4.0.20141.24056   Build Date: Wednesday, February 26, 2014
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Empty BackColor2 no longer throws an internal exception in the
  ChartProperties and ChartWizard dialogs for FillStyles.



====================================================================================
C1Chart.Net Build Number 4.0.20141.24051   Build Date: Friday, February 21, 2014
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added fully qualified design assembly name for 4x DesignerAttribute.
* Added themed axis support.


Corrections
-----------
none



======================================================================================
C1Chart.Net Build Number 4.0.20141.24050   Build Date: Thursday, February 20, 2014
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added license support for Studio for Desktop



Corrections
-----------
none



=======================================================================================
C1Chart.Net Build Number 4.0.20141.24049   Build Date: Wednesday, February 19, 2014
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Adjustments for C1ThemeController.


Corrections
-----------
none



=====================================================================================
C1Chart.Net Build Number 4.0.20141.24048   Build Date: Tuesday, February 18, 2014
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added support for C1ThemeController.



Corrections
-----------
none



====================================================================================
C1Chart.Net Build Number 4.0.20141.24047   Build Date: Monday, February 17, 2014
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added some Chinese and Korean localizations.


Corrections
-----------
none



======================================================================================
C1Chart.Net Build Number 4.0.20141.24035   Build Date: Wednesday, February 5, 2014
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



======================================================================================
C1Chart.Net Build Number 4.0.20133.24035   Build Date: Wednesday, February 5, 2014
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



====================================================================================
C1Chart.Net Build Number 4.0.20141.24034   Build Date: Tuesday, February 4, 2014
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



===================================================================================
C1Chart.Net Build Number 4.0.20133.24030   Build Date: Friday, January 31, 2014
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* The rounding parameters in the border style dialogs (previous) can now
  be set above a value of 20.



Corrections
-----------
none



======================================================================================
C1Chart.Net Build Number 4.0.20133.24028   Build Date: Wednesday, January 29, 2014
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* The PlotArea and Axes are now rendered correctly when AutoOrigin is false.



Corrections
-----------
none



====================================================================================
C1Chart.Net Build Number 4.0.20133.24027   Build Date: Tuesday, January 28, 2014
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Corrected an internal data type conversion error that resulted in a
  failure to locate a PlotFilter'd index.



Corrections
-----------
none



===================================================================================
C1Chart.Net Build Number 4.0.20133.24019   Build Date: Monday, January 20, 2014
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* The rounding parameters in the border style dialog of the Chart Wizard
  and Property dialogs now correctly permit values greater than 20.

Corrections
-----------
none



===================================================================================
C1Chart.Net Build Number 4.0.20133.24012   Build Date: Monday, January 13, 2014
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



===================================================================================
C1Chart.Net Build Number 4.0.20133.24009   Build Date: Friday, January 10, 2014
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.



Corrections
-----------
* Restored proper designer behavior for XYPlots with logarithmic axes that
  was broken beginning with build 24007.



====================================================================================
C1Chart.Net Build Number 4.0.20133.24008   Build Date: Thursday, January 9, 2014
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Charts using line styles now correctly display legends with or without
  vertical fonts and any rotation.
* The chart property and wizard dialogs now limit line editing button
  displays so LineStyle samples are painted within the confines of the
  button borders.


=====================================================================================
C1Chart.Net Build Number 4.0.20133.24007   Build Date: Wednesday, January 8, 2014
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Dialog resizing behavior of the chart Wizards and Properties dialogs has been
  improved.



Corrections
-----------
* Restored minimized XYPlots with logarithmic scaling now correctly repaint in
  all circumstances.


==================================================================================
C1Chart.Net Build Number 4.0.20133.24002   Build Date: Friday, January 3, 2014
==================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Grid lines lost due to changes in build 24001 have been recovered.



====================================================================================
C1Chart.Net Build Number 4.0.20133.24001   Build Date: Thursday, January 2, 2014
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Charts using line styles now correctly display vertical legends with vertical
  fonts.
* Zooming charts no longer results in extraneous grid lines drawn in the
  opposing axes.



=====================================================================================
C1Chart.Net Build Number 4.0.20133.23350   Build Date: Tuesday, December 17, 2013
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Adjusted tesselation depending upon z-values and additional conditions.


Corrections
-----------
none



====================================================================================
C1Chart.Net Build Number 4.0.20133.23345   Build Date: Friday, December 12, 2013
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Pruned code path to minimize effort of drawing zero sized symbols for
  XYPlots to improve performance.
* Improved minor tick assignment and distribution for zoomed and scrolled charts.


Corrections
-----------
none



===================================================================================
C1Chart.Net Build Number 4.0.20133.23339   Build Date: Friday, December 6, 2013
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=======================================================================================
C1Chart.Net Build Number 4.0.20133.23332   Build Date: Friday, November 29, 2013
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added Japanese localization for the new MixStacking property.


Corrections
-----------
none



=======================================================================================
C1Chart.Net Build Number 4.0.20133.23330   Build Date: Wednesday, November 27, 2013
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Stacked, 100 percent, bar charts now render all series points as
  absolute values rather than signed values.  This change was made
  because no other behavior with negative values makes any sense.


Corrections
-----------
none



=====================================================================================
C1Chart.Net Build Number 4.0.20133.23329   Build Date: Tuesday, November 26, 2013
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added MixedStacking option for bar charts (ChartGroup.Bar.MixedStacking)
  MixedStacking is a boolean which if true, positive values are stacked
  above the origin and negative values are stacked below the origin.  Bar
  charts with 3D effects always assume MixedStacking is true.

Corrections
-----------
none



=======================================================================================
C1Chart.Net Build Number 4.0.20133.23316   Build Date: Wednesday, November 13, 2013
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Remove incomplete support for C1ThemeController.


Corrections
-----------
none



===================================================================================
C1Chart.Net Build Number 4.0.20133.23290   Build Date: Friday, October 18, 2013
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart.Net Build Number 4.0.20133.23289   Build Date: Thursday, October 17, 2013
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added basic support for C1ThemeController.


Corrections
-----------
none



====================================================================================
C1Chart.Net Build Number 4.0.20133.23287   Build Date: Tuesday, October 15, 2013
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart.Net Build Number 4.0.20132.23282   Build Date: Thursday, October 10, 2013
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart.Net Build Number 4.0.20132.23225   Build Date: Wednesday, August 14, 2013
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



================================================================================
C1Chart.Net Build Number 4.0.20132.23192   Build Date: Friday, July 12, 2013
================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Japanese characters are no longer clipped by the Fill color rectangle.
* The ChartData Fill color button of the Wizard and Properties dialogs
  is now correctly positioned after resizing the form.


===============================================================================
C1Chart.Net Build Number 4.0.20132.23171   Build Date: Friday, Jun 21, 2013
===============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Line charts and area charts are now treated equally wrt zoom operations.


Corrections
-----------
none



===============================================================================
C1Chart.Net Build Number 4.0.20132.23164   Build Date: Friday, Jun 14, 2013
===============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
* Radar charts with clipped data now display all points correctly.



===============================================================================
C1Chart.Net Build Number 4.0.20132.23154   Build Date: Tuesday, Jun 4, 2013
===============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Updated GrapeCity JPN AboutBox URLs.


Corrections
-----------
none



================================================================================
C1Chart.Net Build Number 4.0.20131.23121   Build Date: Thursday, May 2, 2013
================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Minor internal double buffering changes.

Corrections
-----------
none



=================================================================================
C1Chart.Net Build Number 4.0.20131.23091   Build Date: Tuesday, April 2, 2013
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Implemented additional GrapeCity licensing model changes for JPN builds.


Corrections
-----------
none



================================================================================
C1Chart.Net Build Number 4.0.20131.23090   Build Date: Monday, April 1, 2013
================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
* The AboutBox evaluation notice has been corrected.



=================================================================================
C1Chart.Net Build Number 4.0.20131.23087   Build Date: Friday, March 29, 2013
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Implemented new GrapeCity licensing model for JPN builds.



Corrections
-----------
none



=================================================================================
C1Chart.Net Build Number 4.0.20131.23069   Build Date: Monday, March 11, 2013
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.



Corrections
-----------
none



==================================================================================
C1Chart.Net Build Number 4.0.20131.23065   Build Date: Thursday, March 7, 2013
==================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



===================================================================================
C1Chart.Net Build Number 4.0.20131.23064   Build Date: Wednesday, March 6, 2013
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added Japanese localization for description of the Axis.Scrollbar.Anchored property.
* Added new localizations for Japanese, Chinese and Korean.

Corrections
-----------
none



====================================================================================
C1Chart.Net Build Number 4.0.20131.23041   Build Date: Monday, February 11, 2013
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart.Net Build Number 4.0.20131.23037   Build Date: Thursday, February 7, 2013
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Internal legend data is now cleared when all series are removed.



======================================================================================
C1Chart.Net Build Number 4.0.20131.23036   Build Date: Wednesday, February 6, 2013
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.



Corrections
-----------
* Interactive zoom operations with FilledSelectionArea no longer leaks
  memory.



=====================================================================================
C1Chart.Net Build Number 4.0.20131.23030   Build Date: Thursday, January 31, 2013
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Enabled Tooltips now work correctly after LoadChartFromString() and
  LoadChartFromFile() calls.
* Histogram sorting for interval boundary values is improved (again).
* Double buffering at design time no longer causes excessive flicker.


===================================================================================
C1Chart.Net Build Number 4.0.20131.23027   Build Date: Monday, January 28, 2013
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Histogram sorting for interval boundary values is improved.



===================================================================================
C1Chart.Net Build Number 4.0.20131.23017   Build Date: Friday, January 18, 2013
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



===================================================================================
C1Chart.Net Build Number 4.0.20123.23010   Build Date: Friday, January 11, 2013
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Designer "About" verbs have removed ComponentOne from the display text.


Corrections
-----------
none



=====================================================================================
C1Chart.Net Build Number 4.0.20123.22305   Build Date: Thursday, November 1, 2012
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Improved axis limit calculation for series with one data point and
  extreme values.


Corrections
-----------
none



======================================================================================
C1Chart.Net Build Number 4.0.20123.22304   Build Date: Wednesday, October 31, 2012
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Improved printer scaling logic.



===================================================================================
C1Chart.Net Build Number 4.0.20123.22303   Build Date: Monday, October 30, 2012
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



===================================================================================
C1Chart.Net Build Number 4.0.20123.22299   Build Date: Friday, October 26, 2012
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart.Net Build Number 4.0.20123.22298   Build Date: Thursday, October 25, 2012
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* The Localization basis is now CurrentUICulture instead of CurrentCulture.


Corrections
-----------
none



======================================================================================
C1Chart.Net Build Number 4.0.20123.22283   Build Date: Wednesday, October 10, 2012
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


======================================================================================
C1Chart.Net Build Number 4.0.20122.22283   Build Date: Wednesday, October 10, 2012
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Corrected language codes for Chinese (zh) and Korean (ko).


===================================================================================
C1Chart.Net Build Number 4.0.20122.22282   Build Date: Tuesday, October 9, 2012
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added localizations for Chinese and Korean.


Corrections
-----------
none



===================================================================================
C1Chart.Net Build Number 4.0.20122.22227   Build Date: Tuesday, August 14, 2012
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Adjustment to VS2012 toolbox bitmap logic.


Corrections
-----------
none



===================================================================================
C1Chart.Net Build Number 4.0.20122.22226   Build Date: Tuesday, August 14, 2012
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Adjustment to VS2012 toolbox bitmap logic.



Corrections
-----------
none



===================================================================================
C1Chart.Net Build Number 4.0.20122.22221   Build Date: Thursday, August 9, 2012
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Updated VS2012 toolbox bitmap.
* Added internal documentation for ColorGenerationEnum, FillTypeEnum,
  PlotElementEnum and ScrollBarAppearanceEnum.

Corrections
-----------
none



===================================================================================
C1Chart.Net Build Number 4.0.20122.22206   Build Date: Wednesday, July 25, 2012
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Logic has been added for VS2012 toolbox bitmaps.


Corrections
-----------
* Use a fixed random generator starting point for automatic DataLabel
  arranging.  This avoids label changes when the chart is redrawn without
  changes.



===============================================================================
C1Chart.Net Build Number 4.0.20122.22187   Build Date: Friday, July 6, 2012
===============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Gantt charts now correctly track points with very small differences in
  start and end times during both run time and design time.

Corrections
-----------
none



=================================================================================
C1Chart.Net Build Number 4.0.20122.22186   Build Date: Thursday, July 5, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Gantt charts now correctly track points with very small differences in
  start and end times.


Corrections
-----------
none



================================================================================
C1Chart.Net Build Number 4.0.20122.22184   Build Date: Tuesday, July 3, 2012
================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Updated copyright messages.


Corrections
-----------
none



===============================================================================
C1Chart.Net Build Number 4.0.20122.22162   Build Date: Monday, Jun 11, 2012
===============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Radar charts with unusual min/max values now limit grid lines within
  the max boundaries.



=================================================================================
C1Chart.Net Build Number 4.0.20122.22157   Build Date: Wednesday, Jun 6, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* "NaN" is now accepted in the chart Properties/Wizard dialog data table
  for a (hole) value in JPN Chart builds.


Corrections
-----------
none



===============================================================================
C1Chart.Net Build Number 4.0.20122.22156   Build Date: Tuesday, Jun 5, 2012
===============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* The chart StyleChanged event now fires when the Style for the control
  changes.  This event does not fire when other chart element styles are
  changed.  Use the ChartChanged event for other styles.
* The default chart now has an AxisY2 forecolor that matches the AxisX and
  AxisY forecolors.


Corrections
-----------
none



==============================================================================
C1Chart.Net Build Number 4.0.20122.22155   Build Date: Monday, Jun 4, 2012
==============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* The chart no longer takes an exception when the LineStyle pattern is set to
  None and the legend is visible.  This exception was introduced in build 22121.
* The Smart Designer plot area toolbar is now usable for Polar and Radar charts.



===============================================================================
C1Chart.Net Build Number 4.0.20122.22145   Build Date: Friday, May 25, 2012
===============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



==================================================================================
C1Chart.Net Build Number 4.0.20122.22143   Build Date: Wednesday, May 23, 2012
==================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* BorderStyleEnum.Opaque no longer reduces the chart area size when
  Rounding is non-zero.



================================================================================
C1Chart.Net Build Number 4.0.20122.22142   Build Date: Tuesday, May 22, 2012
================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  Same as previous build, except for version number.



Corrections
-----------
none



================================================================================
C1Chart.Net Build Number 4.0.20121.22142   Build Date: Tuesday, May 22, 2012
================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* A new border style (BorderStyleEnum.Opaque) has been added.  The new
  border style ensures that anti-aliasing is turned off when drawing the
  border.  Opaque borders ignore Rounding settings.  This border style can
  be useful for generating chart images to be use with transparent
  backgrounds.


Corrections
-----------
none



==================================================================================
C1Chart.Net Build Number 4.0.20121.22136   Build Date: Wednesday, May 16, 2012
==================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Pie charts with VisualEffects now correctly display the highcolor color
  in both the data and legend regions.
* Axis ValueLabel grid lines in 3D plots are now correctly placed
  for certain axis Compass values and rotations/elevations.
* Chart Labels with AttachMethod of Coordinate and Radial, RadialText and
  Orthogonal Compass values are now handled as Auto Compass values.


=================================================================================
C1Chart.Net Build Number 4.0.20121.22129   Build Date: Wednesday, May 9, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Restored the GotFocus event.  Please note that the GotFocus and
  LostFocus events are no longer recommended for usage by Microsoft - use
  the Enter and Leave events instead.
  



===============================================================================
C1Chart.Net Build Number 4.0.20121.22121   Build Date: Tuesday, May 1, 2012
===============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
* Series lines are now clipped to the plot area when VisualEffects are used.
* Data series lines' are now rendered in the Legend with a maximum
  thickness of slightly less than the line height.
* Data series lines' are now rendered in the Chart Properties dialog data
  editor with a maximum thickness of slightly less than the header height.


====================================================================================
C1Chart.Net Build Number 4.0.20121.22115   Build Date: Wednesday, April 25, 2012
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Function lines are now correctly limited to the plot area when visual
  effects and scrollbars are used.
* Highlight color is now correctly applied to Area, Histogram and
  3D XYPlots (ribbon chart).
* Conical and Pyramid bar charts are now properly clipped in all
  circumstances with VisualEffects.


=================================================================================
C1Chart.Net Build Number 4.0.20121.22110   Build Date: Friday, April 20, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* ChartLineStyle.Thickness is now limited to values 0 to 1000 inclusive.

Corrections
-----------
* Bar charts now correctly interpret X values containing NaN as data holes.
* The ChartDataSeriesCollection.AddNewSeries() method now always generates
  a unique series label.
* Chart Labels added through the design time UI designer now correctly use
  the DefaultStyle BackColor.


==================================================================================
C1Chart.Net Build Number 4.0.20121.22100   Build Date: Tuesday, April 10, 2012
==================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added a DescriptionAttribute for the C1Chart control class.

Corrections
-----------
* MetaFile images can now be saved to the clipboard in all scenarios.



===================================================================================
C1Chart.Net Build Number 2.0.20121.22036   Build Date: Monday, February 6, 2012
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Chart axis non-anchored scrollbars are now properly placed for 2D charts
  in all scenarios.
* Axes are now correctly placed for non-default Origin values when the
  opposing axis is logarithmic.



===================================================================================
C1Chart.Net Build Number 2.0.20121.22035   Build Date: Sunday, February 5, 2012
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added RotationOverride property to chart Label objects.  This property
  allows the specification of the clockwise rotation angle around the
  connection point of the label.  The property overrides the RotationEnum
  of the label Style object, and does NOT apply to Radial or RadialText
  compass values.  This property is demonstrated in a new sample,
  RotatedLabels.   Documentation changes required.


Corrections
-----------
none



====================================================================================
C1Chart.Net Build Number 2.0.20121.22030   Build Date: Tuesday, January 31, 2012
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



====================================================================================
C1Chart.Net Build Number 2.0.20113.22030   Build Date: Tuesday, January 31, 2012
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* A new AxisScrollbar.Anchored property indicates whether or not axis
  scrollbars should be fixed to the PlotArea boundary or move with the
  axis origin.  Documentation changes.
* Axis scrollbars are now supported for logarithmic axes.

Corrections
-----------
none



====================================================================================
C1Chart.Net Build Number 2.0.20113.21345   Build Date: Monday, December 12, 2011
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Pie charts with ValueLabels no longer throw an exception (design time
  and runtime) when the number of ValueLabels is less than the number of
  points.  Since the exception previously occured during the chart
  rendering, it was possible that only parts of the chart were not
  correctly rendered and affected series selection.
* Stack XYPlot charts no longer fail to render series data in certain
  circumstances.
* X axis ValueLabel grid lines in 3D plots are now correctly placed
  for certain axis Compass values.



=====================================================================================
C1Chart.Net Build Number 2.0.20113.21334   Build Date: Thursday, December 1, 2011
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* The Axis Thickness property can now have a zero value.  Axes with a
  Thickness value are fully drawn except for the axis line itself.
  (Documentation changes)
* Radar charts now display tickmarks in the radial direction along X axis
  major gridlines.  The tickmarks are controlled by the Y axis tickmark
  properties.  (Documentation changes).
* Non-stacked Pie charts can now display labels for each pie/point, by
  using the X axis ValueLabels.
  (Documentation changes)
  ValueLabels are applied to pies or points in the order they appear in
  the ValueLabels collection.  The labels are only displayed if the X axis
  AnnotationMethod property is set to ValueLabels.  The display of the
  labels is also controlled by the X axis properties, including Alignment,
  AnnotationMethod, Compass, Font, ForeColor, Rotation, ValueLabels,
  VerticalText and Visible properties.  No other X axis properties affect
  the labels.  The ChartArea Inverted property also affects the label
  display, in that it determines whether the X axis Compass property
  values will be North, South or East, West.
* Updated licensing to conform with Federal Information Processing
  Standards requirements. (Tfs-18562)


Corrections
-----------
- The Design time Smart Designer now correctly shows the subtype in all
  scenarios.



======================================================================================
C1Chart.Net Build Number 2.0.20113.21313   Build Date: Thursday, November 10, 2011
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Design time pie charts now correctly show the selected series if zero or
  hole values are present.
* 3D XYPlot and 3D Step chart legend entries now correctly reflect the
  LineStyle instead of the FillStyle.


===================================================================================
C1Chart.Net Build Number 2.0.20113.21296   Build Date: Monday, October 24, 2011
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Click once applications granted FullTrust can now execute built in chart
  functions.


===================================================================================
C1Chart.Net Build Number 2.0.20113.21286   Build Date: Friday, October 14, 2011
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Absolute Location and Size of chart elements are now adjusted along with
  chart size during printing operations.



===================================================================================
C1Chart.Net Build Number 2.0.20113.21276   Build Date: Tuesday, October 4, 2011
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Licensing update for FIPS compliance   (TFS-17615,TFS-18460,TFS-18562)

Corrections
-----------
none



========================================================================================
C1Chart.Net Build Number 2.0.20113.21263   Build Date: Wednesday, September 21, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Gantt and Histogram charts have improved designer behavior.
* Improved resizing behavior of the designer DataTable.
* Axes Origin properties now honored if Group.Use3D properties are set
  to false, even if the View3D.Depth property is non-zero.
* Improved behavior of highlighted style mouse actions.


Corrections
-----------
* Corrected a caching error when using log plots.  The error occurred when
  the only Axis property to change during an event was IsLogarithmic.



=====================================================================================
C1Chart.Net Build Number 2.0.20113.21253   Build Date: Sunday, September 11, 2011
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


======================================================================================
C1Chart.Net Build Number 2.0.20112.21250   Build Date: Thursday, September 8, 2011
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=======================================================================================
C1Chart.Net Build Number 2.0.20112.21249   Build Date: Wednesday, September 7, 2011
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* The joint use PlotFilters and custom PointStyles behavior has been improved.


Corrections
-----------
none



======================================================================================
C1Chart.Net Build Number 2.0.20112.21243   Build Date: Thursday, September 1, 2011
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Radar charts with flat grid lines now display normal AlarmZones with
  flat edges.

Corrections
-----------
* Adjustment made to designer datasource and datafield handling for the
  benefit of WebChart.


==================================================================================
C1Chart.Net Build Number 2.0.20112.21240   Build Date: Monday, August 29, 2011
==================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
* Adjustment made to designer datafield handing for the benefit of WebChart.


====================================================================================
C1Chart.Net Build Number 2.0.20112.21236   Build Date: Thursday, August 25, 2011
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Y Axes are now forced to zero bounds only if a bar chart is associated
  with the axis, rather than if either Y axis is associated with a bar
  chart, and only if the Y axis is not logarithmic.



=====================================================================================
C1Chart.Net Build Number 2.0.20112.21228   Build Date: Wednesday, August 17, 2011
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Lasso zooming no longer generates an exception when over zooming
  generates extreme scaling due to unshown series.


=====================================================================================
C1Chart.Net Build Number 2.0.20112.21221   Build Date: Wednesday, August 10, 2011
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
* Chart Draw now correctly handles offsets during printing.
* Lasso zooming no longer generates an exception when over zooming
  produces a floating point underflow.


====================================================================================
C1Chart.Net Build Number 2.0.20112.21214   Build Date: Wednesday, August 3, 2011
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* ChartChanged now fires once when BackgroundImageLayout changes.
* ChartChanged now fires when the BackgroundImage changes.

Corrections
-----------
* VisualEffects now properly handle rounding and shadow effects for highly
  scaled objects.
* Serialization of the ValueLabelsCollection no longer duplicates the
  labels in the collection in some circumstances.


===============================================================================
C1Chart.Net Build Number 2.0.20112.21181   Build Date: Friday, July 1, 2011
===============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Time axis major ticks values are now rounded more appropriately.


Corrections
-----------
none



=================================================================================
C1Chart.Net Build Number 2.0.20112.21173   Build Date: Thursday, Jun 23, 2011
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Improved time y axis annotations for Gantt charts.


Corrections
-----------
* Corrected problem with XYPlot series detection based on chart coordinates.
  This problem affects Tooltips with PlotElement set to Series, HighLight with
  PlotElement set to Series.
* Corrected problem where HighLight would activate during design time.


===============================================================================
C1Chart.Net Build Number 2.0.20112.21170   Build Date: Monday, Jun 20, 2011
===============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* The chart.PrintChart() overloads now print items drawn in the Paint event.



===============================================================================
C1Chart.Net Build Number 2.0.20112.21167   Build Date: Friday, Jun 17, 2011
===============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* The TrendLine.GetY() method has been extended to include Maximum,
  Minimum, Average and MovingAverage trendlines.
* Time axis major ticks values are now rounded more appropriately.


Corrections
-----------
none



=================================================================================
C1Chart.Net Build Number 2.0.20112.21131   Build Date: Thursday, May 12, 2011
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Corrected problem with drawing of certain Candle charts.
* Charts element sizing is now more consistent with axis compass changes.


================================================================================
C1Chart.Net Build Number 2.0.20112.21129   Build Date: Tuesday, May 10, 2011
================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added Japanese localization for ChartData.SeriesWidth.


Corrections
-----------
none



===================================================================================
C1Chart.Net Build Number 2.0.20111.21119   Build Date: Saturday, April 30, 2011
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* A new property, ChartData.SeriesWidth has been added. This property
  specifies the percentage of 3D series widths (Area and Ribbon charts).
  The default value is 100 percent.  Values less than 100 percent provide
  gaps between adjacent series.

Corrections
-----------
none



====================================================================================
C1Chart.Net Build Number 2.0.20111.21116   Build Date: Wednesday, April 27, 2011
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* PlotFilter methods now apply to log plots.



Corrections
-----------
* Improved tooltip behavior for Ribbon charts.



==================================================================================
C1Chart.Net Build Number 2.0.20111.21108   Build Date: Tuesday, April 19, 2011
==================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Removed icons from headers in designer forms.


Corrections
-----------
none



===================================================================================
C1Chart.Net Build Number 2.0.20111.21089   Build Date: Thursday, March 31, 2011
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Some Japanese localizations related to the PlotArea
  (LocationDefault and SizeDefault) now read correctly.
* Time formatted axes are no longer incorrectly adjusted to a multiple of
  UnitMajor.  This action was not intended for time formatted axes.
* Radar charts can no longer have negative radii.


===================================================================================
C1Chart.Net Build Number 2.0.20111.21084   Build Date: Saturday, March 26, 2011
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Japanese localizations have been added.



Corrections
-----------
* When requesting the design time dialogs with Japanese Visual Studio, a
  null exception message no longer occurs.


=================================================================================
C1Chart.Net Build Number 2.0.20111.21083   Build Date: Friday, March 25, 2011
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added explicit reference to 4x designer.  This improves behavior when multiple
  versions of the Chart are installed on the same machine.

Corrections
-----------
none



===============================================================================
C1Chart.Net Build Number 2.0.20111.21027   Build Date: Friday, January 28, 2011
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Corrected Xml documentation file for SaveLocalizations(byte[] byteArray)
  and LoadLocalizations(byte[] byteArray).
* Corrected behavior of Chart Properties and Chart Wizard Dialogs when
  changing the size by Maximizing and Restoring dialog.


=================================================================================
C1Chart.Net Build Number 2.0.20111.21012   Build Date: Thursday, January 13, 2011
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* LoadLocalization() overloads can now reset the localization to its default
  state by passing a null argument.


Corrections
-----------
none


==============================================================================
C1Chart.Net Build Number 2.0.20111.21006   Build Date: Friday, January 7, 2011
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Chart dialogs can now be maximized.


Corrections
-----------
none


================================================================================
C1Chart.Net Build Number 2.0.20111.21005   Build Date: Thursday, January 6, 2011
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=================================================================================
C1Chart.Net Build Number 2.0.20111.21004   Build Date: Wednesday, January 5, 2011
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added runtime user localizations by introducing SaveLocalizations() and
  LoadLocalizations() methods.  This overloaded methods save and load XML
  translation tables, respectively, that translate internal strings at
  runtime.
* The radar chart now supports AlarmZones.  The AlarmZones specify
  NearExtents and FarExtents in angles measured from the first item in the
  radar chart.  The angle is specified in degrees or radians depending
  upon the ChartGroup.Radar object settings.  Requires documentation
  changes to indicate angle specification.
* The chart property and chart wizard dialogs can now be resized.


Corrections
-----------
none


==================================================================================
C1Chart.Net Build Number 2.0.20103.20356   Build Date: Thursday, December 23, 2010
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


================================================================================
C1Chart.Net Build Number 2.0.20103.20346   Build Date: Monday, December 13, 2010
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==================================================================================
C1Chart.Net Build Number 2.0.20103.20251   Build Date: Thursday, September 9, 2010
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* ShowVisualEffectsEditor has been added to the C1Chart object.


Corrections
-----------
* When the Group0 and Group1 entries are used to override the Default
  VisualEffects style, the legend entries are now correctly rendered.


===================================================================================
C1Chart.Net Build Number 2.0.20103.20250   Build Date: Wednesday, September 8, 2010
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* The VisualEffectsStylesCollection now has Group0 and Group1 entries
  which can be used to selectively override the data (Default) settings
  for the respective ChartGroup data.


Corrections
-----------
none


================================================================================
C1Chart.Net Build Number 2.0.20103.20245   Build Date: Friday, September 3, 2010
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==================================================================================
C1Chart.Net Build Number 2.0.20102.20244   Build Date: Thursday, September 2, 2010
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Adjusted Axis calculations to match format even for ValueLabel
  annotations.


Corrections
-----------
* The DrawDataSeries event now honors the setting of e.Pen when drawing
  the data lines in the legend.


==============================================================================
C1Chart.Net Build Number 2.0.20102.20187   Build Date: Wednesday, July 7, 2010
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==============================================================================
C1Chart.Net Build Number 2.0.20102.20166   Build Date: Wednesday, Jun 16, 2010
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=============================================================================
C1Chart.Net Build Number 2.0.20101.20159   Build Date: Wednesday, Jun 9, 2010
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==========================================================================
C1Chart.Net Build Number 2.0.20101.20157   Build Date: Monday, Jun 7, 2010
==========================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==============================================================================
C1Chart.Net Build Number 2.0.20101.20145   Build Date: Wednesday, May 26, 2010
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* The ChartGroup.CoordToDataIndex() method now returns correct distance
  data for pie charts for all settings.


===========================================================================
C1Chart.Net Build Number 2.0.20101.20143   Build Date: Monday, May 24, 2010
===========================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===========================================================================
C1Chart.Net Build Number 2.0.20101.20136   Build Date: Monday, May 17, 2010
===========================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=============================================================================
C1Chart.Net Build Number 2.0.20101.20132   Build Date: Thursday, May 13, 2010
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==============================================================================
C1Chart.Net Build Number 2.0.20101.20131   Build Date: Wednesday, May 12, 2010
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Finalizing 4.0 version port.


Corrections
-----------
none


=============================================================================
C1Chart.Net Build Number 2.0.20101.20119   Build Date: Friday, April 30, 2010
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* 4.0 version has designer split into separate assembly for 4.0 Client Mode.

Corrections
-----------
none


===============================================================================
C1Chart.Net Build Number 2.0.20101.20096   Build Date: Wednesday, April 7, 2010
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


================================================================================
C1Chart.Net Build Number 2.0.20101.20089   Build Date: Wednesday, March 31, 2010
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==============================================================================
C1Chart.Net Build Number 2.0.20101.20062   Build Date: Thursday, March 4, 2010
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Histogram charts with VisualEffects now scroll and paint correctly with
  axis scrollbars.


=============================================================================
C1Chart.Net Build Number 2.0.20101.20060   Build Date: Tuesday, March 2, 2010
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.



Corrections
-----------
* A minor change was made to mouse processing that elimates a rare exception.


=================================================================================
C1Chart.Net Build Number 2.0.20101.20053   Build Date: Tuesday, February 23, 2010
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Area chart data series can now be selected in the smart designer.
* Chart Properties dialog now enables the Stacked checkbox for Pie types.
* Chart Properties dialog now enables the 3D checkbox for Step types.
* PlotArea.LocationDefault and PlotArea.SizeDefault are now properly
  persisted during serialization.


==================================================================================
C1Chart.Net Build Number 2.0.20101.20048   Build Date: Thursday, February 18, 2010
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Stacked pie charts are now properly persisted when changing views in the
  designer and wizard.



===============================================================================
C1Chart.Net Build Number 2.0.20101.20037   Build Date: Sunday, February 7, 2010
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==================================================================================
C1Chart.Net Build Number 2.0.20101.20033   Build Date: Wednesday, February 3, 2010
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added stacked Pie charts to the Pie and Doughnut galleries.
* Added new sample, PieGrouping to C# and VB sample directories.

Corrections
-----------
none


===============================================================================
C1Chart.Net Build Number 2.0.20101.20021   Build Date: Friday, January 22, 2010
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Added a new Pie and Bar chart DataLabel and Tooltip text place holder,
  {%YVAL} in addition to the existing place holders.  The new place holder
  is replaced with the percentage that the series Y value represents of
  the sum of all series values at a given point.
* Added LabelCompassEnum.RadialText to the enumeration.  This value
  requests that the label text is oriented in the same direction as the
  offset.  The value has been added for Pie chart data labels.


Corrections
-----------
none


===============================================================================
C1Chart.Net Build Number 2.0.20101.20014   Build Date: Friday, January 15, 2010
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* The PlotArea now exposes LocationDefault and SizeDefault properties that
  together allow placement of the PlotArea within the chart.  If the
  PlotArea is placed, the axes are forced to align at the PlotArea
  boundaries regardless of whether they can be fully displayed.
* Modified licensing requirements for Visual Studio 2010.

Corrections
-----------
none


==================================================================================
C1Chart.Net Build Number 2.0.20093.19364   Build Date: Thursday, December 31, 2009
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Modified style persistence such that the attribute order is consistent.


Corrections
-----------
none


=================================================================================
C1Chart.Net Build Number 2.0.20093.19362   Build Date: Tuesday, December 29, 2009
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* ChartDataSeries.SymbolStyle objects are now visible from property grids
  for HiLoOpenClose charts.  SymbolStyle.Size is used to specify the
  length of the Open and Close lines for this chart type.
* AboutBox truncations in GrapeCity builds have been eliminated.


===================================================================================
C1Chart.Net Build Number 2.0.20093.19356   Build Date: Wednesday, December 23, 2009
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes

Corrections
-----------
* Resizing the chart to zero width or height during a repaint operation no longer
  causes an exception.
* Attempting to add a new ChartDataSeries to an empty ChartDataSeriesCollection
  through the PropertyGrid editor no longer causes an exception.


==================================================================================
C1Chart.Net Build Number 2.0.20093.19342   Build Date: Wednesday, December 9, 2009
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* DataLabel styles are now preserved when modified in the
  ChartDataSeriesCollectionEditor.
* Legend forecolor is now correctly inherits chart forecolor in all
  circumstances.


===============================================================================
C1Chart.Net Build Number 2.0.20093.19337   Build Date: Friday, December 4, 2009
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* ShowTooltip event does not fire for the chart elements when the element's
  tooltip is not set.
* BackgroundImageLayoutChanged event now fires properly.


=================================================================================
C1Chart.Net Build Number 2.0.20093.19336   Build Date: Thursday, December 3, 2009
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Improved axis limits calcualtion.
* Restored MiterLimit and LineJoin properties to line styles for
  PointStyle.LineStyle and HighLight.LineStyle.


Corrections
-----------
* Fixed the problem with axis value label marker when dragging with two mouse
  buttons.


==================================================================================
C1Chart.Net Build Number 2.0.20093.19335   Build Date: Wednesday, December 2, 2009
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added Japanese localizations.


Corrections
-----------
none


================================================================================
C1Chart.Net Build Number 2.0.20093.19334   Build Date: Tuesday, December 1, 2009
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added Japanese localizations.
* MiterLimit and LineJoin properties are now displayed in property grids
  only for the ChartDataSeries LineStyles.



Corrections
-----------
* Header and footer images now are displayed correctly when using
  visual effects.


================================================================================
C1Chart.Net Build Number 2.0.20093.19333   Build Date: Monday, November 30, 2009
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Add Sample Data verbs now post a confirmation request before changing data.
* Added Japanese localization adjustments.


Corrections
-----------
* Fixed the problem with Doughnut charts and text visual effects in the
  chart designer previews.


================================================================================
C1Chart.Net Build Number 2.0.20093.19332   Build Date: Sunday, November 29, 2009
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Area charts with Visual Effects now display correctly when scrolled.


==================================================================================
C1Chart.Net Build Number 2.0.20093.19329   Build Date: Thursday, November 26, 2009
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* GrapeCity licensing now correct.
* Bubble charts with Visual Effects now display correctly.


===================================================================================
C1Chart.Net Build Number 2.0.20093.19328   Build Date: Wednesday, November 25, 2009
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* Area chart tooltips now function correctly.



=================================================================================
C1Chart.Net Build Number 2.0.20093.19310   Build Date: Saturday, November 7, 2009
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Internal licensing changes.



Corrections
-----------
none


=================================================================================
C1Chart.Net Build Number 2.0.20093.19301   Build Date: Thursday, October 29, 2009
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Added new GrapeCity license codes for JPN version.
  


Corrections
-----------
none


===============================================================================
C1Chart.Net Build Number 2.0.20093.19298   Build Date: Monday, October 26, 2009
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Added default data setups based on the chart type.
* Added verbs and designer operations to allow update of chart data after
  changing chart type.


Corrections
-----------
* Pie charts (3D) with VisualEffects now draw correctly when one or more
  series have pattern or gradient fill.
* Chart.Print now properly displays the PrintDialog during 64 bit
  execution.


===============================================================================
C1Chart.Net Build Number 2.0.20093.19284   Build Date: Monday, October 12, 2009
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes



Corrections
-----------
* Adjusted internal documentation.


====================================================================================
C1Chart.Net Build Number 2.0.20093.19272   Build Date: Wednesday, September 30, 2009
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


=================================================================================
C1Chart.Net Build Number 2.0.20093.19267   Build Date: Friday, September 25, 2009
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* Corrected pen behavior when a thin line and legend are used in the same
  line chart.  The error was introduced in build 2.0.20093.19256.


====================================================================================
C1Chart.Net Build Number 2.0.20093.19265   Build Date: Wednesday, September 23, 2009
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


====================================================================================
C1Chart.Net Build Number 2.0.20093.19258   Build Date: Wednesday, September 16, 2009
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* LineStyle Color and Symbol generation is now reset when all series are
  removed from both ChartGroups.


Corrections
-----------
none


=================================================================================
C1Chart.Net Build Number 2.0.20093.19256   Build Date: Monday, September 14, 2009
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Added LineJoin and MiterLimit properties to the LineStyle of the
  ChartDataSeries.  The LineJoin and MiterLimit properties, definitions
  and defaults are the same as the those of Pen.LineJoin and
  Pen.MiterLimit.
* Series lines drawn in the legend are now set to a minimum thickness of 3
  pixels if all series lines in the group are the same thickness.
* Added Axis.TickFactorMajor and Axis.TickFactorMinor properties.  These
  properties apply a multiplication factor to the respective tick lengths
  for the axis.
* Added gauge marks and Axis.TickGauge property.  Gauge marks are
  periodically enhanced minor tick marks that allow easier reading of
  minor tick marks. See TickGauge property for more details.
* Added Axis.NoAnnoOverlap property.  Setting this value to true
  suppresses drawing of axis annotations that have been previously drawn.
* Improved automatic histogram interval calculation for skewed data.
* Honors C1Olap licensing.

Corrections
-----------
none


=============================================================================
C1Chart.Net Build Number 2.0.20092.19168   Build Date: Thursday, Jun 18, 2009
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* Logarithmic trendline behavior has been improved.


=============================================================================
C1Chart.Net Build Number 2.0.20092.19161   Build Date: Thursday, Jun 11, 2009
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* Adjusted obfuscation for licensing.


==============================================================================
C1Chart.Net Build Number 2.0.20092.19160   Build Date: Wednesday, Jun 10, 2009
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Chart 2D ChartGroup and FillStyle outline colors are now reflected in
  the legend.


Corrections
-----------
* Adjusted obfuscation for licensing.


===========================================================================
C1Chart.Net Build Number 2.0.20092.19152   Build Date: Tuesday, Jun 2, 2009
===========================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* New Licensing and AboutBox code.


Corrections
-----------
none


================================================================================
C1Chart.Net Build Number 2.0.20091.19053   Build Date: Monday, February 23, 2009
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* ChartGroup.ResetOutlineColor() now automatically refreshes the image and
  correctly fires the ChartChanged event.


================================================================================
C1Chart.Net Build Number 2.0.20091.19043   Build Date: Friday, February 13, 2009
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Added Japanese localizations for property descriptions new to build
  2.0.20091.19030


Corrections
-----------
none


===============================================================================
C1Chart.Net Build Number 2.0.20091.19032   Build Date: Monday, February 2, 2009
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* Corrects persistence problem for Axis.VerticalText in build 19030.
  Do not use build 19030


=================================================================================
C1Chart.Net Build Number 2.0.20091.19030   Build Date: Saturday, January 31, 2009
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Bad build, do not use
* Internal changes
* Added the new property, OutlineColor to the Group class.  By default,
  the property value is Color.Empty which indicates continued use of the
  PlotArea.ForeColor for outlining figures.  Setting this property to a
  non-empty value overrides the PlotArea.ForeColor use for outlining.
* Added the new method, ResetOutlineColor() to the Group class.  This method
  sets the OutlineColor to Color.Empty.
* Added the new properties, OutlineColor and OutlineThickness to the FillStyle
  class.  For data that applies FillStyles, the outline color and thickness
  can be overriden by the FillStyle property values.
* Added the new method, ResetOutlineColor() to the FillStyle class.  This method
  sets the OutlineColor to Color.Empty.
* Added the new property VerticalText to the Style class.  This allows
  some double byte characters to be rendered from top to bottom instead
  of left to right. For single byte characters VerticalText appears as
  rotated text, 90 degrees in the clockwise direction.
* Added the new property VerticalText and AnnoVerticalText to the Axis
  class.  This allows some double byte character to be rendered from top
  to bottom instead of left to right.  For single byte characters
  VerticalText and AnnotVerticalText appears as rotated text, 90 degrees
  in the clockwise direction.


Corrections
-----------
none


================================================================================
C1Chart.Net Build Number 2.0.20091.19026   Build Date: Tuesday, January 27, 2009
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Added Japanese localizations for property descriptions new to build
  2.0.20091.19015


Corrections
-----------
none


===============================================================================
C1Chart.Net Build Number 2.0.20091.19015   Build Date: Friday, January 16, 2009
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Added new properties to the Group.Bar class.  The new properties affect
  lines are rendered between series rectangles from point to point in
  stacked 2D bar and column charts.  The properties include BarLines,
  BarLineColor and BarLineThickness.
* Added the new property, FlatGridLines to the Group.Radar class.  The
  new property specifies whether to use flat Y coordinate gridlines for
  for radar charts.
* Added the new property, Clockwise to the Group.Pie class.  The new
  property specifies whether the series slices are rendered in a clockwise
  or counter-clockwise direction (default).
* Completed the implementation of the TickLabels property of the Axis class,
  which now includes implementation of TickLabelsEnum.High and
  TickLabelsEnum.Low.


Corrections
-----------
none


================================================================================
C1Chart.Net Build Number 2.0.20083.19012   Build Date: Tuesday, January 13, 2009
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Design time environment chart designer Visual Effects operations are now
  suppressed when running in the IDE.  Previously some attempts at
  changing the chart properties could result in an unhandled exception.


Corrections
-----------
none


===============================================================================
C1Chart.Net Build Number 2.0.20083.19011   Build Date: Monday, January 12, 2009
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Design time environment chart designer operations are now suppressed
  when running in the IDE.  Previously some attempts at changing the chart
  properties could result in an unhandled exception.

Corrections
-----------
none


=================================================================================
C1Chart.Net Build Number 2.0.20083.19006   Build Date: Wednesday, January 7, 2009
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


===============================================================================
C1Chart.Net Build Number 2.0.20083.19005   Build Date: Tuesday, January 6, 2009
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* HiLow / HiLowOpenClose charts now correctly show tooltips when either
  axes are scaled logarithmically.



================================================================================
C1Chart.Net Build Number 2.0.20083.18353   Build Date: Friday, December 19, 2008
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* 3D Pie Charts now use the correct FillStyle with DrawDataSeries events
  are used but do not set brushes.


===============================================================================
C1Chart.Net Build Number 2.0.20083.18335   Build Date: Monday, December 1, 2008
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Adjustments for MediumTrust situations.


Corrections
-----------
none


================================================================================
C1Chart.Net Build Number 2.0.20083.18325   Build Date: Friday, November 21, 2008
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Adjustments for MediumTrust situations.



Corrections
-----------
none


===================================================================================
C1Chart.Net Build Number 2.0.20083.18323   Build Date: Wednesday, November 19, 2008
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Adjustments for MediumTrust situations.


Corrections
-----------
none


===============================================================================
C1Chart.Net Build Number 2.0.20083.18297   Build Date: Friday, October 24, 2008
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* Axis precision now matches that of UnitMajor or UnitMinor in all cases.
  (revised)


=================================================================================
C1Chart.Net Build Number 2.0.20083.18296   Build Date: Thursday, October 23, 2008
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* Inverted HiLo and related charts now propertly scroll within the
  PlotArea.
* Axis precision now matches that of UnitMajor or UnitMinor in all cases.


================================================================================
C1Chart.Net Build Number 2.0.20083.18294   Build Date: Tuesday, October 21, 2008
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Added new C1Chart methods.  The new methods are similar to the
  previously existing methods but also save the chart element style
  images:
    SaveChartAndImagesToFile(),    SaveChartAndImagesToString()
    LoadChartAndImagesFromFile(),  LoadChartAndImagesFromString()
* Adjusted behavior of Smart Designer labels editor.


Corrections
-----------
* The LabelCollection editor dialogs now correctly handle and persist
  property assignments for collection elements.  This was a error
  resulting from changes in build 2.0.20083.18265.
* The SmartDesigner for ChartLabels now correctly handles Cancel
  operations with respect to chart element images.


=================================================================================
C1Chart.Net Build Number 2.0.20083.18265   Build Date: Monday, September 22, 2008
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* Memory leaks associated with LabelsCollection.Clear() have been corrected.


================================================================================
C1Chart.Net Build Number 2.0.20083.18248   Build Date: Friday, September 5, 2008
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes

Corrections
-----------
* A workaround for a C++ compiler naming issue was added by adjusting
  obfuscation.


===============================================================================
C1Chart.Net Build Number 2.0.20083.18238   Build Date: Tuesday, August 26, 2008
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Added/modified internal documentation changes for YFunction and
  ParametricFunction constructors and value retrieval functions.


Corrections
-----------
none


==============================================================================
C1Chart.Net Build Number 2.0.20083.18237   Build Date: Monday, August 25, 2008
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


==============================================================================
C1Chart.Net Build Number 2.0.20082.18237   Build Date: Monday, August 25, 2008
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* AlarmZone polygons with 3 or more visible unclipped points are now
  correctly drawn.
* Plotted YFunctions and ParametricFunctions using CodedText and
  CodedLines now correctly release memory associated with each coded
  change.


============================================================================
C1Chart.Net Build Number 2.0.20082.18192   Build Date: Friday, July 11, 2008
============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* All series are now correctly drawn when one or more series are hidden
  with the PlotFilterMethod.


============================================================================
C1Chart.Net Build Number 2.0.20082.18140   Build Date: Tuesday, May 20, 2008
============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes

Corrections
-----------
* Headers, Footers, Legend and Labels (chart) are now correctly placed
  when making external calls to the Chart Draw method and any or all of
  these objects are not automatically placed.


================================================================================
C1Chart.Net Build Number 2.0.20082.18134   Build Date: Wednesday, May 14, 2008
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* The ChartProperties and ChartWizard designers now correctly gray the
  chart in the preview panel when gradient backgrounds are used.
* The ChartProperties and ChartWizard designer have improved behavior
  on the Axis tabs.


================================================================================
C1Chart.Net Build Number 2.0.20082.18078   Build Date: Wednesday, March 19, 2008
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
none


Corrections
-----------
none


==============================================================================
C1Chart.Net Build Number 2.0.20081.18077   Build Date: Tuesday, March 18, 2008
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* Antialiasing in the plot now draws correctly for large numbers of plot
  points.  The problem was created as a result of the workaround of the
  GDI+ issue implemented in build 18041.


================================================================================
C1Chart.Net Build Number 2.0.20081.18045   Build Date: Friday, February 15, 2008
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* Labels placed by DataCoordinate are correctly positioned for logarithmic axes.


================================================================================
C1Chart.Net Build Number 2.0.20081.18041   Build Date: Monday, February 11, 2008
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* XYPlots with plot lines of near zero slope now render correctly in all
  cases.  This is a workaround to a GDI+ issue.


Corrections
-----------
none


=================================================================================
C1Chart.Net Build Number 2.0.20081.18039   Build Date: Saturday, February 9, 2008
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Bar charts will now adjust the Y axis minimum zero for cases near zero
  when the AutoMin is true.


Corrections
-----------
none


===============================================================================
C1Chart.Net Build Number 2.0.20081.18038   Build Date: Friday, February 8, 2008
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Moveable axis markers can now be dragged by grabbing any part of the
  marker's circumscribing rectangle.


Corrections
-----------
* Bar charts now correctly stack for single data point series.
* Labels placed by DataCoordinate are correctly positioned for logarithmic
  axes.
* Pie slices now have correct edge shading when hatching or gradient fills
  are used.


================================================================================
C1Chart.Net Build Number 2.0.20081.18021   Build Date: Tuesday, January 22, 2008
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


===============================================================================
C1Chart.Net Build Number 2.0.20081.18020   Build Date: Monday, January 21, 2008
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


=================================================================================
C1Chart.Net Build Number 2.0.20081.18016   Build Date: Thursday, January 17, 2008
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes

Corrections
-----------
* Conic, Pyramidal and Cylindrical bar charts now correctly display
  all gradient styles.


===============================================================================
C1Chart.Net Build Number 2.0.20081.18013   Build Date: Monday, January 14, 2008
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Interaction behavior improved.
* ToolTip behavior has been improved.


Corrections
-----------
* Edit Data Series correctly handles series edit requests, even when all
  series labels have been cleared.
* Conic, Pyramidal and Cylindrical bar charts now correctly display all
  gradient styles.


================================================================================
C1Chart.Net Build Number 2.0.20073.17333   Build Date: Friday, November 30, 2007
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==================================================================================
C1Chart.Net Build Number 2.0.20073.17282   Build Date: Wednesday, October 10, 2007
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* SmartDesigner behavior improvements.


===============================================================================
C1Chart.Net Build Number 2.0.20073.17281   Build Date: Tuesday, October 9, 2007
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Japanese localization improvements.
* SmartDesigner behavior improvements.



Corrections
-----------
none


==============================================================================
C1Chart.Net Build Number 2.0.20073.17277   Build Date: Friday, October 5, 2007
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


================================================================================
C1Chart.Net Build Number 2.0.20073.17276   Build Date: Thursday, October 4, 2007
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* AlarmZone polygon coordinate data now persists correctly in all cases.


===============================================================================
C1Chart.Net Build Number 2.0.20073.17274   Build Date: Tuesday, October 2, 2007
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* SmartDesigner behavior improvements.


Corrections
-----------
none


==============================================================================
C1Chart.Net Build Number 2.0.20073.17273   Build Date: Monday, October 1, 2007
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* ChartWizard and ChartProperty dialog behavior improvements.


Corrections
-----------
* The design time verbs, "Reset" and "Reset to default chart" now reset
  UseGrayScale, Enabled and Visible properties.  The Chart.Reset() method
  now resets UseGrayScale at runtime.


=================================================================================
C1Chart.Net Build Number 2.0.20073.17270   Build Date: Friday, September 28, 2007
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal Changes.


Corrections
-----------
* The Chart BackgroundImageLayout property is now correctly linked to the
  Chart.Style.ImageAlignment property.  ImageAlignments that cannot be
  mapped values for the BackgroundImageLayout are reflected as
  ImageAlignment.None for the BackgroundImageLayout value.


===================================================================================
C1Chart.Net Build Number 2.0.20073.17269   Build Date: Thursday, September 27, 2007
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal Changes.
* Added a new PrintChart() overload which allows printing as a bitmap
  instead of a metafile.  This overload may be useful for printer drivers
  that do not support GDI+.


noneCorrections
-----------
none


=================================================================================
C1Chart.Net Build Number 2.0.20073.17266   Build Date: Monday, September 24, 2007
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* SmartDesigner behavior improvements.
* Cylinders, Cones and Pyramid bar charts now support HatchBrush
  fillstyles.



Corrections
-----------
* The Bar.MultiRow property now persists correctly when it is the only
  non-default property.


===================================================================================
C1Chart.Net Build Number 2.0.20073.17262   Build Date: Thursday, September 20, 2007
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added new Japanese localizations.
* SmartDesigner behavior improvements.


Corrections
-----------
none


====================================================================================
C1Chart.Net Build Number 2.0.20073.17261   Build Date: Wednesday, September 19, 2007
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Charts now use SystemColors.Window for the default BackColor of the
  ChartArea instead of White.
* SmartDesigner tooltip sizing has been improved.
* Improved axis number formatting.
* Improved behavior of Data Binding Editor


Corrections
-----------
* Integral holes are now properly handled in bar charts


================================================================================
C1Chart.Net Build Number 2.0.20073.17249   Build Date: Friday, September 7, 2007
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* SmartDesigner now operates correctly when UseGrayScale is true.


==================================================================================
C1Chart.Net Build Number 2.0.20073.17248   Build Date: Thursday, September 6, 2007
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Design time series data is no longer removed when a datasource is cleared.
* Saved images of specified sizes now render consistently regardless of
  the size of the hosting chart.
* Chart image is now updated when the BackgroundImage property is set when
  either UseDoubleBuffer or UseGrayScale properties are true.

===================================================================================
C1Chart.Net Build Number 2.0.20073.17247   Build Date: Wednesday, September 5, 2007
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Bound string fields now handle DBNull values as data holes.
* Bar chart ClusterOverlap properties now accept negative values.
  Negative values separate bars within the cluster.


Corrections
-----------
* Adjustments required for C1WebChart corrections.
* SmartTag now updates its properties when changed using the Properties
  or Wizard dialogs


==============================================================================
C1Chart.Net Build Number 2.0.20073.17231   Build Date: Monday, August 20, 2007
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  
* Added new Japanese localizations.

Corrections
-----------
none


=============================================================================
C1Chart.Net Build Number 2.0.20072.17187   Build Date: Saturday, July 7, 2007
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
none


=============================================================================
C1Chart.Net Build Number 2.0.20072.17156   Build Date: Wednesday, Jun 6, 2007
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
none


==============================================================================
C1Chart.Net Build Number 2.0.20072.17142   Build Date: Wednesday, May 23, 2007
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
* Fixed an intermittent problem with Axis scrollbars serialization that
  would sometimes result in an exception.


===========================================================================
C1Chart.Net Build Number 2.0.20072.17140   Build Date: Monday, May 21, 2007
===========================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added ColorGeneration operations to the ChartProperties and ChartWizard
  dialogs on the Data page.


Corrections
-----------
* Fixed the problem with moveable ValueLabels, which can now be dragged using
  the label part which is outside the axis limits.


============================================================================
C1Chart.Net Build Number 2.0.20072.17134   Build Date: Tuesday, May 15, 2007
============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  
* Added UseGrayscale property to the chart object.  This boolean property
  allows rendering of the charts in grayscale as a preview for non-color
  printers.
* Added ColorGeneration property to the 2D chart object.  This enumeration
  allows selection of color schemes for data series.


Corrections
-----------
* Fixed failing tooltip display for bar charts when input x values are
  float (Single) values.  Double values are okay.
* Fixed minor problem with rendering XYChart when PlotFilterMethod=Default.
* DataLabels now are visible when the data value is equal to the axis
  minimum for bar charts.


==============================================================================
C1Chart.Net Build Number 2.0.20071.17096   Build Date: Saturday, April 7, 2007
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Fixed a problem with C1Chart.Draw() method when coordinates of
  rectangle parameter are negative.
* Fixed a problem with automatic calcualtion of min/max for
  logarithmic axes.


===============================================================================
C1Chart.Net Build Number 1.0.20071.17032   Build Date: Friday, February 2, 2007
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==================================================================================
C1Chart.Net Build Number 1.0.20071.17030   Build Date: Wednesday, January 31, 2007
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==================================================================================
C1Chart.Net Build Number 1.0.20071.17023   Build Date: Wednesday, January 24, 2007
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=================================================================================
C1Chart.Net Build Number 1.0.20071.17002   Build Date: Wednesday, January 3, 2007
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===============================================================================
C1Chart.Net Build Number 1.0.20071.17001   Build Date: Tuesday, January 2, 2007
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Fixed memory leak after clearing ChartDataSeriesCollection with
  RemoveAll()/Clear() methods.


==================================================================================
C1Chart.Net Build Number 1.0.20071.16354   Build Date: Thursday, December 21, 2006
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===================================================================================
C1Chart.Net Build Number 1.0.20071.16346   Build Date: Wednesday, December 13, 2006
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
none


===================================================================================
C1Chart.Net Build Number 1.0.20071.16332   Build Date: Wednesday, November 29, 2006
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


================================================================================
C1Chart.Net Build Number 1.0.20071.16289   Build Date: Tuesday, October 17, 2006
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added an option to Interaction properties that allows to fill selected
  area when zooming. The color for the selected area is PlotArea.BackColor2,
  if this color is empty the semi-transparent color is used.
* Added couple of methods(BeginUpdate()/EndUpdate()) which allows multiple
  (batched) chart updates to be performed without excessive repainting.


Corrections
-----------
none


==============================================================================
C1Chart.Net Build Number 1.0.20063.16281   Build Date: Monday, October 9, 2006
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  
* Cosmetic changes were made in VisualEffects dialog.


Corrections
-----------
* Adjusted position of rotated axis labels(Axis.AnnoRotation != 0).
  Previously the axis labels may have been overlapped by the axis title.
  with certain DateManual specifications.   
* Automatic axis limits are now calculate more correctly when formatting

==============================================================================
C1Chart.Net Build Number 1.0.20063.16228   Build Date: Thursday, August 17, 2006
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
* Fixed the problem with bar chart and logarithmic x-axis.


==============================================================================
C1Chart.Net Build Number 1.0.20063.16219   Build Date: Tuesday, August 8, 2006
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  
* Added variations of 3D bar charts: cylinder, cone and pyramid
  (Bar.Appearance property).
* Added an option to show 3D bar chart as multiple rows
  (ChartGroup.MultiRow property).


Corrections
-----------
* AxisScrollbar.Scroll() now behaves correctly for for reversed vertical axes.


==============================================================================
C1Chart.Net Build Number 1.0.20062.16205   Build Date: Tuesday, July 25, 2006
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
* 100% stacked bar charts now behave correctly when y-values have zero values.


===========================================================================
C1Chart.Net Build Number 1.0.20062.16183   Build Date: Monday, July 3, 2006
===========================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
none


===========================================================================
C1Chart.Net Build Number 1.0.20062.16182   Build Date: Sunday, July 2, 2006
===========================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
none


==============================================================================
C1Chart.Net Build Number 1.0.20062.16143   Build Date: Wednesday, May 24, 2006
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
* Fixed a localization issue so that text is no longer truncated in the
  border editor.


===========================================================================
C1Chart.Net Build Number 1.0.20062.16128   Build Date: Tuesday, May 9, 2006
===========================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
* Fixed the problems with Histogram chart which may lead to exception
  under several conditions.
* Fixed incorrect behavour of 'Cancel' button in TrendLinesCollection
  editor.



==========================================================================
C1Chart.Net Build Number 1.0.20062.16127   Build Date: Monday, May 8, 2006
==========================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Fixed the problem where BindingSource creation using DataSource Designer
  through Property Grid is empty.
* Fixed the problem Clicking the 'Cancel' button in the
  'PointStylesCollection' editor removes the applied styles.
* Fixed the problem with stacked chart which may cause exception
  under several conditions with logarithmic axes.


============================================================================
C1Chart.Net Build Number 1.0.20062.16123   Build Date: Thursday, May 4, 2006
============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Fixed stacked chart PointStyle issue that incorrectly resulted in
  multiple PointStyle changes.


=============================================================================
C1Chart.Net Build Number 1.0.20062.16122   Build Date: Wednesday, May 3, 2006
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Fixed a problem with border color. It was sometimes cleared after changing
  border style.
* Fixed several minor designtime issues.


==========================================================================
C1Chart.Net Build Number 1.0.20062.16120   Build Date: Monday, May 1, 2006
==========================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added localizations for Japanese builds.


Corrections
-----------
* Fixed several designtime issues related with VisualEffects.


=============================================================================
C1Chart.Net Build Number 1.0.20062.16110   Build Date: Friday, April 21, 2006
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Data series with 3 points now are rendered as a spline curve
  when FitType=FitTypeEnum.Spline, previously there were connected
  with straight lines.

Corrections
-----------
* Fixed problems with VisualEffectsStyle collection editor.


=============================================================================
C1Chart.Net Build Number 1.0.20062.16106   Build Date: Monday, April 17, 2006
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* AboutBox adjustments.

Corrections
-----------
none


================================================================================
C1Chart.Net Build Number 1.0.20062.16103   Build Date: Friday, April 14, 2006
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------

* Basic chart elements now are exposed through accessibility interfaces.
* Added localized Japanese descriptions for UseAntiAliasGraphics,
  UseAntiAliasText, VisualEffects properies and all VisualEffectsStyle
  properties. Added localized Japanese translation for VisualEffects verb.

Corrections
-----------
* VisualEffects dialog is no longer shown in the taskbar.

=============================================================================
C1Chart.Net Build Number 1.0.20062.16099   Build Date: Monday, April 10, 2006
=============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
none

============================================================================
C1Chart.Net Build Number 1.0.20062.16098   Build Date: Sunday, April 9, 2006
============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Due to changes to the C1Chart 2.x DataSource property, the IDE PropertyGrid
  now provides better editing support, allowing the selection of an existing
  data source, or the creation of a new data source as necessary.
* Added public interface to VisualEffects through Styles collection
  of VisualEffectsStyle objects.


Corrections
-----------
* Fixed the problem with 3D doughnut chart appearance under certain conditions.
* Fixed several designtime issues.


================================================================================
C1Chart.Net Build Number 1.0.20062.16087   Build Date: Wednesday, March 29, 2006
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Several minor design time behaviors have been improved.
* Added UseAntiAliasGraphics, UseAntiAliasText for the chart object,
  and UseAntiAlias to the PlotArea object.
* Added SmartPainter support.
* Added ChartSampleCenter.exe, a chart function sampler with code
  display in C Sharp and Visual Basic.Net.


Corrections
-----------
* "Antialising" checkbox now worka properly in chart property dialog.
* Fixed the problem with axis date/time formatting, under several
  conditions the labels could be rendered with incorrect overlap.
* Fixed several localization issues specific for .Net 2.0.
* Fixed incorrect rendering of moving-average trendline in financial
  (hilo/hi-lo-open-close/candle) charts. Under certain conditions
  trendline could go beyond the plot area.  


=================================================================================
C1Chart.Net Build Number 1.0.20061.16018   Build Date: Thursday, January 19, 2006
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Several minor design time behaviors have been improved.


================================================================================
C1Chart.Net Build Number 1.0.20061.16009   Build Date: Tuesday, January 10, 2006
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Fixed several localization issues.
* Label images now are not removed after properties dialog.


==============================================================================
C1Chart.Net Build Number 1.0.20061.16007   Build Date: Sunday, January 8, 2006
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Add additional localizations, translations and adjustments for Japanese
  builds.


Corrections
-----------
* Fixed problems with logarithmic stacked chart.
* Fixed several minor issues with properties dialog.
* Improved axis label display in some cases when the UnitMajor values are
  explicitly set.


===============================================================================
C1Chart.Net Build Number 1.0.20061.16002   Build Date: Tuesday, January 3, 2006
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Highlighting data series with holes now works correctly.
* Fixed minor problems in Edit Data Binding dialog.
* Fixed several VS2005-specific collection editor problems.


================================================================================
C1Chart.Net Build Number 1.0.20061.15363   Build Date: Friday, December 30, 2005
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Fixed additional problems with unsupported data types.


==================================================================================
C1Chart.Net Build Number 1.0.20061.15362   Build Date: Thursday, December 29, 2005
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Fixed several problems associated with data binding in designer dialogs.
* Fields with unsupported data types now are not visible in design dialogs.


===================================================================================
C1Chart.Net Build Number 1.0.20061.15354   Build Date: Wednesday, December 21, 2005
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Improved performance when creating large number of data series.


Corrections
-----------
* Fixed the problems with logarithmic area chart rendering under
  several conditions.


=================================================================================
C1Chart.Net Build Number 1.0.20061.15353   Build Date: Tuesday, December 20, 2005
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added localization and translations of the DataBindingEditor for Japanese
  builds.


Corrections
-----------
none


===============================================================================
C1Chart.Net Build Number 1.0.20061.15342   Build Date: Friday, December 9, 2005
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Japanese and English localization for all builds.
* PointStyleSelect event has been modified to handle LineStyle changes
  for XYPlots, as well as SymbolStyle changes.

Corrections
-----------
none


================================================================================
C1Chart.Net Build Number 1.0.20061.15339   Build Date: Tuesday, December 6, 2005
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


================================================================================
C1Chart.Net Build Number 1.0.20053.15339   Build Date: Tuesday, December 6, 2005
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
* Various bug fixes.


================================================================================
C1Chart.Net Build Number 1.0.20053.15321   Build Date: Friday, November 18, 2005
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Aboutbox email handler changes.

Corrections
-----------
* Axis scrollbar can now have a minimal scroll thumb size.  Previously, the thumb
  did not scale with the axis scaling.

==================================================================================
C1Chart.Net Build Number 1.0.20053.15320   Build Date: Thursday, November 17, 2005
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=================================================================================
C1Chart.Net Build Number 1.0.20053.15308   Build Date: Saturday, November 5, 2005
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===============================================================================
C1Chart.Net Build Number 1.0.20053.15307   Build Date: Friday, November 4, 2005
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
* Various bug fixes.


=================================================================================
C1Chart.Net Build Number 1.0.20053.15306   Build Date: Thursday, November 3, 2005
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
* Various bug fixes.


=================================================================================
C1Chart.Net Build Number 1.0.20053.15299   Build Date: Thursday, October 27, 2005
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Designer enhancements, including a new Data Binding Editor.

Corrections
-----------
* Various bug fixes.


===============================================================================
C1Chart.Net Build Number 1.0.20053.15288   Build Date: Sunday, October 16, 2005
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
* Various bug fixes.


================================================================================
C1Chart.Net Build Number 1.0.20053.15236   Build Date: Thursday, August 25, 2005
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
* Various bug fixes.


=================================================================================
C1Chart.Net Build Number 1.0.20053.15235   Build Date: Wednesday, August 24, 2005
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
* Various bug fixes.


===============================================================================
C1Chart.Net Build Number 1.0.20053.15234   Build Date: Tuesday, August 23, 2005
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Various bug fixes.

Corrections
-----------
none


==============================================================================
C1Chart.Net Build Number 1.0.20053.15233   Build Date: Monday, August 22, 2005
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Various bug fixes.

Corrections
-----------
none


==============================================================================
C1Chart.Net Build Number 1.0.20053.15225   Build Date: Sunday, August 14, 2005
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added new Japanese translations.
* Added DrawDataSeriesEventArgs.DisposePen property.

Corrections
-----------
none


==============================================================================
C1Chart.Net Build Number 1.0.20053.15213   Build Date: Tuesday, August 2, 2005
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added DrawDataSeriesEventArgs.Pen property which allows using custom
  pens for rendering lines.
* Added GetMetafile() method.
* Added PrintChart() method with PageSettings parameter.


Corrections
-----------
* Various bug fixes.


=================================================================================
C1Chart.Net History
=================================================================================

2.0.20142.24286    14-Oct-2014
4.0.20142.24286    14-Oct-2014
  - Internal changes.

2.0.20142.24247    05-Sep-2014
4.0.20142.24247    05-Sep-2014
  - Internal changes.
  - Added Japanese, Korean and Chinese localizations for the ReverseDraw
    propery description and Save Chart Template and Load Chart Template verbs.
  - Added 14 significant digit rounding to axis min/max calculations due to
    .NET handling of doubles.  This provideds improved axis limit annotations.

2.0.20142.24182    02-Jul-2014
4.0.20142.24182    02-Jul-2014
  - Internal changes.

2.0.20142.24177    27-Jun-2014
4.0.20142.24177    27-Jun-2014
  - Internal changes.
  - Added ChartGroups.ReverseDraw property.
    Documentation should include the new property.

      Gets or sets whether the order in which the ChartGroups are normally
      drawn is reversed.

      ChartGroups are normally drawn in descending order in which they
      appear in the ChartGroupsCollection. If ReversedDraw is true, then
      the ChartGroups are drawn in ascending order in which they appear in the
      ChartGroupsCollection.

  - Added of saving and loading chart templates.  Chart templates are similar
    to chart descriptions, but do not store or reset data upon loading.  The
    new method prototypes include:

        void SaveChartTemplateToFile(string Filename);
        string templateString = SaveChartTemplateToString();
        string templateString = SaveChartTemplateToString(bool formatting);

        void LoadChartTemplateFromFile(string Filename);
        void LoadChartTemplateFromString(string templateString);

   Documentation should include the new methods.

2.0.20141.24156    06-Jun-2014
4.0.20141.24156    06-Jun-2014
  - Internal changes.
  - Zooming interactions how handle very small values more appropriately.

2.0.20141.24135    16-May-2014
4.0.20141.24135    16-May-2014
  - Internal changes.
  - Modified an axis sizing loop that was causing design time hang when
    loading old persisted data.

2.0.20141.24092    03-Apr-2014
4.0.20141.24092    03-Apr-2014
  - Internal changes.
  - The chart now always translates it coordinate system to use internal
    coordinates when invoking the chart Draw method.  This is necessary
    to correctly draw chart elements with specific values.

2.0.20141.24071    13-Mar-2014
4.0.20141.24071    13-Mar-2014
  - Internal changes.
  - Logarithmic transforms are now correctly applied in all cases.

2.0.20141.24070    12-Mar-2014
4.0.20141.24070    12-Mar-2014
  - Internal changes.

2.0.20141.24062    04-Mar-2014
4.0.20141.24062    04-Mar-2014
  - Internal changes.

2.0.20141.24056    26-Feb-2014
4.0.20141.24056    26-Feb-2014
  - Internal changes.
  - Empty BackColor2 no longer throws an internal exception in the
    ChartProperties and ChartWizard dialogs for FillStyles. (Tfs-52608)

2.0.20141.24051    21-Feb-2014
4.0.20141.24051    21-Feb-2014
  - Internal changes.
  - Added fully qualified design assembly name for 4x DesignerAttribute.
  - Added themed axis support.

2.0.20141.24050    20-Feb-2014
4.0.20141.24050    20-Feb-2014
  - Internal changes.
  - Added license support for Studio for Desktop

2.0.20141.24049    19-Feb-2014
4.0.20141.24049    19-Feb-2014
  - Internal changes.
  - Adjustments for C1ThemeController.

2.0.20141.24048    18-Feb-2014
4.0.20141.24048    18-Feb-2014
  - Internal changes.
  - Added support for C1ThemeController.

2.0.20141.24047    17-Feb-2014
4.0.20141.24047    17-Feb-2014
  - Internal changes.
  - Added some Chinese and Korean localizations.

2.0.20141.24035    05-Feb-2014
4.0.20141.24035    05-Feb-2014
  - Internal changes.

2.0.20133.24035    05-Feb-2014
4.0.20133.24035    05-Feb-2014
  - Internal changes.

2.0.20141.24034    04-Feb-2014
4.0.20141.24034    04-Feb-2014
  - Internal changes.

2.0.20133.24030    31-Jan-2014
4.0.20133.24030    31-Jan-2014
  - Internal changes.
  - The rounding parameters in the border style dialogs (previous) can now
    be set above a value of 20.  (Tfs-50461).

2.0.20133.24028    29-Jan-2014
4.0.20133.24028    29-Jan-2014
  - Internal changes.
  - The PlotArea and Axes are now rendered correctly when AutoOrigin is false.

2.0.20133.24027    28-Jan-2014
4.0.20133.24027    28-Jan-2014
  - Internal changes.
  - Corrected an internal data type conversion error that resulted in a
    failure to locate a PlotFilter'd index.

2.0.20133.24019    20-Jan-2014
4.0.20133.24019    20-Jan-2014
  - Internal changes.
  - The rounding parameters in the border style dialog of the Chart Wizard
    and Property dialogs now correctly permit values greater than 20.

2.0.20133.24012    13-Jan-2014
4.0.20133.24012    13-Jan-2014
  - Internal changes.

2.0.20133.24009    10-Jan-2014
4.0.20133.24009    10-Jan-2014
  - Internal changes.
  - Restored proper designer behavior for XYPlots with logarithmic axes that
    was broken beginning with build 24007.

2.0.20133.24008    09-Jan-2014
4.0.20133.24008    09-Jan-2014
  - Internal changes.
  - Charts using line styles now correctly display legends with or without
    vertical fonts and any rotation.
  - The chart property and wizard dialogs now limit line editing button
    displays so LineStyle samples are painted within the confines of the
    button borders.
    
2.0.20133.24007    08-Jan-2014
4.0.20133.24007    08-Jan-2014
  - Internal changes.
  - Restored minimized XYPlots with logarithmic scaling now correctly
    repaint in all circumstances.
  - Dialog resizing behavior of the chart Wizards and Properties dialogs
    has been improved.

2.0.20133.24002    03-Jan-2014
4.0.20133.24002    03-Jan-2014
  - Internal changes.
  - Grid lines lost due to changes in build 24001 have been recovered.

2.0.20133.24001    02-Jan-2014
4.0.20133.24001    02-Jan-2014
  - Internal changes.
  - Charts using line styles now correctly display vertical legends with vertical
    fonts.
  - Zooming charts no longer results in extraneous grid lines drawn in the
    opposing axes.

2.0.20133.23350    17-Dec-2013
4.0.20133.23350    17-Dec-2013
  - Internal changes.

2.0.20133.23345    12-Dec-2013
4.0.20133.23345    12-Dec-2013
  - Internal changes.
  - Pruned code path to minimize effort of drawing zero sized symbols for
    XYPlots to improve performance.
  - Improved minor tick assignment and distribution for zoomed and scrolled
    charts.

2.0.20133.23339    06-Dec-2013
4.0.20133.23339    06-Dec-2013
  - Internal changes.

2.0.20133.23332    29-Nov-2013
4.0.20133.23332    29-Nov-2013
  - Internal changes.
  - Added Japanese localization for the new MixStacking property.

2.0.20133.23330    27-Nov-2013
4.0.20133.23330    27-Nov-2013
  - Internal changes.
  - Stacked, 100 percent, bar charts now render all series points as
    absolute values rather than signed values.

2.0.20133.23329    26-Nov-2013
4.0.20133.23329    26-Nov-2013
  - Internal changes.
  - Added MixedStacking option for bar charts (ChartGroup.Bar.MixedStacking)
    MixedStacking is a boolean which if true, positive values are stacked
    above the origin and negative values are stacked below the origin.  Bar
    charts with 3D effects always assume MixedStacking is true.

2.0.20133.23316    13-Nov-2013
4.0.20133.23316    13-Nov-2013
  - Internal changes.
  - Remove incomplete support for C1ThemeController.

2.0.20133.23290    18-Oct-2013
4.0.20133.23290    18-Oct-2013
  - Internal changes.

2.0.20133.23289    17-Oct-2013
4.0.20133.23289    17-Oct-2013
  - Internal changes.
  - Added basic support for C1ThemeController.
  
2.0.20133.23287    15-Oct-2013
4.0.20133.23287    15-Oct-2013
  - Internal changes.

2.0.20132.23282    10-Oct-2013
4.0.20132.23282    10-Oct-2013
  - Internal changes.

2.0.20132.23225    14-Aug-2013
4.0.20132.23225    14-Aug-2013
  - Internal changes.

2.0.20132.23192    12-Jul-2013
4.0.20132.23192    12-Jul-2013
  - Internal changes.
  - Japanese characters are no longer clipped by the Fill color rectangle.
  - The ChartData Fill color button of the Wizard and Properties dialogs
    is now correctly positioned after resizing the form.

2.0.20132.23171    21-Jun-2013
4.0.20132.23171    21-Jun-2013
  - Internal changes.
  - Line charts and area charts are now treated equally wrt zoom operations.
    
2.0.20132.23164    14-Jun-2013
4.0.20132.23164    14-Jun-2013
  - Internal changes.
  - Radar charts with clipped data now display all points correctly.

2.0.20132.23154    04-Jun-2013
4.0.20132.23154    04-Jun-2013
  - Internal changes.
  - Updated GrapeCity JPN AboutBox URLs.

2.0.20131.23121    02-May-2013
4.0.20131.23121    02-May-2013
  - Internal changes.
  - Minor internal double buffering changes.

2.0.20131.23091    02-Apr-2013
4.0.20131.23091    02-Apr-2013
  - Internal changes.
  - Implemented additional GrapeCity licensing model changes for JPN builds.

2.0.20131.23090    01-Apr-2013
4.0.20131.23090    01-Apr-2013
  - Internal changes.
  - The AboutBox evaluation notice has been corrected.

2.0.20131.23087    29-Mar-2013
4.0.20131.23087    29-Mar-2013
  - Internal changes.
  - Implemented new GrapeCity licensing model for JPN builds.

2.0.20131.23069    11-Mar-2013
4.0.20131.23069    11-Mar-2013
  - Internal changes.

2.0.20131.23065    07-Mar-2013
4.0.20131.23065    07-Mar-2013
  - Internal changes.

2.0.20131.23064    06-Mar-2013
4.0.20131.23064    06-Mar-2013
  - Internal changes.
  - Added Japanese localization for description of the
    Axis.Scrollbar.Anchored property.  (Tfs-34204).
  - Added new localizations for Japanese, Chinese and Korean. (Tfs-34204).

2.0.20131.23041    11-Feb-2013
4.0.20131.23041    11-Feb-2013
  - Internal changes.

2.0.20131.23037    07-Feb-2013
4.0.20131.23037    07-Feb-2013
  - Internal changes.
  - Internal legend data is now cleared when all series are removed.

2.0.20131.23036    06-Feb-2013
4.0.20131.23036    06-Feb-2013
  - Internal changes.
  - Interactive zoom operations with FilledSelectionArea no longer leaks
    memory.

2.0.20131.23030    31-Jan-2013
4.0.20131.23030    31-Jan-2013
  - Internal changes.
  - Enabled Tooltips now work correctly after LoadChartFromString() and
    LoadChartFromFile() calls.
  - Histogram sorting for interval boundary values is improved (again).
  - Double buffering at design time no longer causes excessive flicker.

2.0.20131.23027    28-Jan-2013
4.0.20131.23027    28-Jan-2013
  - Internal changes.
  - Histogram sorting for interval boundary values is improved.

2.0.20131.23017    18-Jan-2013
4.0.20131.23017    18-Jan-2013
  - Internal changes.

2.0.20123.23010    11-Jan-2013
4.0.20123.23010    11-Jan-2013
  - Internal changes.
  - Designer "About" verbs have removed ComponentOne from the display text.

2.0.20123.22305    01-Nov-2012
4.0.20123.22305    01-Nov-2012
  - Internal changes.
  - Improved axis limit calculation for series with one data point and
    extreme values.

2.0.20123.22304    31-Oct-2012
4.0.20123.22304    31-Oct-2012
  - Internal changes.
  - Improved printer scaling logic.

2.0.20123.22303    30-Oct-2012
4.0.20123.22303    30-Oct-2012
  - Internal changes.

2.0.20123.22299    26-Oct-2012
4.0.20123.22299    26-Oct-2012
  - Internal changes.

2.0.20123.22298    25-Oct-2012
4.0.20123.22298    25-Oct-2012
  - Internal changes.
  - The Localization basis is now CurrentUICulture instead of CurrentCulture.

2.0.20123.22283    10-Oct-2012
4.0.20123.22283    10-Oct-2012
  - Internal changes.

2.0.20122.22283    10-Oct-2012
4.0.20122.22283    10-Oct-2012
  - Internal changes.
  - Corrected language codes for Chinese (zh) and Korean (ko). (Tfs-28888)

2.0.20122.22282    09-Oct-2012
4.0.20122.22282    09-Oct-2012
  - Internal changes.
  - Added localizations for Chinese and Korean.

2.0.20122.22227    14-Aug-2012
4.0.20122.22227    14-Aug-2012
  - Internal changes.
  - Adjustment to VS2012 toolbox bitmap logic.

2.0.20122.22226    14-Aug-2012
4.0.20122.22226    14-Aug-2012
  - Internal changes.
  - Adjustment to VS2012 toolbox bitmap logic.

2.0.20122.22221    09-Aug-2012
4.0.20122.22221    09-Aug-2012
  - Internal changes.
  - Updated VS2012 toolbox bitmap.
  - Added internal documentation for ColorGenerationEnum, FillTypeEnum,
    PlotElementEnum and ScrollBarAppearanceEnum.

2.0.20122.22206    25-Jul-2012
4.0.20122.22206    25-Jul-2012
  - Internal changes.
  - Logic has been added for VS2012 toolbox bitmaps.
  - Use a fixed random generator starting point for automatic DataLabel
    arranging.  This avoids label changes when the chart is redrawn without
    changes.

2.0.20122.22187    06-Jul-2012
4.0.20122.22187    06-Jul-2012
  - Internal changes.
  - Gantt charts now correctly track points with very small differences in
    start and end times during both run time and design time.

2.0.20122.22186    05-Jul-2012
4.0.20122.22186    05-Jul-2012
  - Internal changes.
  - Gantt charts now correctly track points with very small differences in
    start and end times.

2.0.20122.22184    03-Jul-2012
4.0.20122.22184    03-Jul-2012
  - Internal changes.
  - Updated copyright messages.

2.0.20122.22162    11-Jun-2012
4.0.20122.22162    11-Jun-2012
  - Internal changes.
  - Radar charts with unusual min/max values now limit grid lines within
    the max boundaries.

2.0.20122.22157    06-Jun-2012
4.0.20122.22157    06-Jun-2012
  - Internal changes.
  - "NaN" is now accepted in the chart Properties/Wizard dialog data table
    for a (hole) value in JPN Chart builds.

2.0.20122.22156    05-Jun-2012
4.0.20122.22156    05-Jun-2012
  - Internal changes.
  - The chart StyleChanged event now fires when the Style for the control
    changes.  This event does not fire when other chart element styles are
    changed.  Use the ChartChanged event for other styles.
  - The default chart now has an AxisY2 forecolor that matches the AxisX and
    AxisY forecolors.

2.0.20122.22155    04-Jun-2012
4.0.20122.22155    04-Jun-2012
  - Internal changes.
  - The chart no longer takes an exception when the LineStyle pattern is set
    to None and the legend is visible.  This exception was introduced in
    build 22121.
  - The Smart Designer plot area toolbar is now usable for Polar and Radar
    charts.
    
2.0.20122.22145    25-May-2012
4.0.20122.22145    25-May-2012
  - Internal changes.

2.0.20122.22143    23-May-2012
4.0.20122.22143    23-May-2012
  - Internal changes.
  - BorderStyleEnum.Opaque no longer reduces the chart area size when
    Rounding is non-zero.

2.0.20122.22142    22-May-2012
4.0.20122.22142    22-May-2012
  - Internal changes.  Same as previous build, except for version number.

2.0.20121.22142    22-May-2012
4.0.20121.22142    22-May-2012
  - Internal changes.
  - A new border style (BorderStyleEnum.Opaque) has been added.  The new
    border style ensures that anti-aliasing is turned off when drawing the
    border.  Opaque borders ignore Rounding settings.  This border style can
    be useful for generating chart images to be use with transparent
    backgrounds.

2.0.20121.22136    16-May-2012
4.0.20121.22136    16-May-2012
  - Internal changes.
  - Pie charts with VisualEffects now correctly display the highcolor color
    in both the data and legend regions.
  - Axis ValueLabel grid lines in 3D plots are now correctly placed
    for certain axis Compass values and rotations/elevations.
  - Chart Labels with AttachMethod of Coordinate and Radial, RadialText and
    Orthogonal Compass values are now handled as Auto Compass values.

2.0.20121.22129    09-May-2012
4.0.20121.22129    09-May-2012
  - Internal changes.
  - Restored the GotFocus event.  Please note that the GotFocus and
    LostFocus events are no longer recommended for usage by Microsoft - use
    the Enter and Leave events instead.
  
2.0.20121.22121    01-May-2012
4.0.20121.22121    01-May-2012
  - Internal changes.
  - Series lines are now clipped to the plot area when VisualEffects are
    used.
  - Data series lines' are now rendered in the Legend with a maximum
    thickness of slightly less than the line height.
  - Data series lines' are now rendered in the Chart Properties dialog
    data editor with a maximum thickness of slightly less than the header
    height.

2.0.20121.22115    25-Apr-2012
4.0.20121.22115    25-Apr-2012
  - Internal changes.
  - Function lines are now correctly limited to the plot area when visual
    effects and scrollbars are used.
  - Highlight color is now correctly applied to Area, Histogram and
    3D XYPlots (ribbon chart).
  - Conical and Pyramid bar charts are now properly clipped in all
    circumstances with VisualEffects.

2.0.20121.22110    20-Apr-2012
4.0.20121.22110    20-Apr-2012
  - Internal changes.
  - Bar charts now correctly interpret X values containing NaN as data holes.
  - The ChartDataSeriesCollection.AddNewSeries() method now always generates
    a unique series label.
  - ChartLineStyle.Thickness is now limited to values 0 to 1000 inclusive.
  - Chart Labels added through the design time UI designer now correctly use
    the DefaultStyle BackColor.

2.0.20121.22100    10-Apr-2012
4.0.20121.22100    10-Apr-2012
  - Internal changes.
  - MetaFile images can now be saved to the clipboard in all scenarios.
  - Added a DescriptionAttribute for the C1Chart control class.

2.0.20121.22036    06-Feb-2012
4.0.20121.22036    06-Feb-2012
  - Internal changes.
  - Chart axis non-anchored scrollbars are now properly placed for 2D charts
    in all scenarios.
  - Axes are now correctly placed for non-default Origin values when the
    opposing axis is logarithmic.

2.0.20121.22035    05-Feb-2012
4.0.20121.22035    05-Feb-2012
  - Internal changes.
  - Added RotationOverride property to chart Label objects.  This property
    allows the specification of the clockwise rotation angle around the
    connection point of the label.  The property overrides the RotationEnum
    of the label Style object, and does NOT apply to Radial or RadialText
    compass values.  This property is demonstrated in a new sample,
    RotatedLabels.   Documentation changes required.

2.0.20121.22030    31-Jan-2012
4.0.20121.22030    31-Jan-2012
  - Internal changes.

2.0.20113.22030    31-Jan-2012
4.0.20113.22030    31-Jan-2012
  - Internal changes.
  - A new AxisScrollbar.Anchored property indicates whether or not axis
    scrollbars should be fixed to the PlotArea boundary or move with the
    axis origin.  Documentation changes.

    Documentation:  When an axis origin is set, the axis can be placed
    inside the plot area if the origin point on the crossing axis lies
    inside the plot area rectangle.  By default, an axis scrollbar will be
    placed with the axis.  Setting the new AxisScrollbar.Anchored property
    to True results in placement of the scrollbar on the appropriate edge of
    the plot area when the axis is placed inside the plot area rectangle.

  - Axis scrollbars are now supported for logarithmic axes.
    Documentation:  Current documentation may indicate that scrollbars are
    not supported for logarithmic axes.  If so, the documentation should be
    changed.

2.0.20113.21345    12-Dec-2011
4.0.20113.21345    12-Dec-2011
  - Internal changes.
  - Pie charts with ValueLabels no longer throw an exception (design time
    and runtime) when the number of ValueLabels is less than the number of
    points.  Since the exception previously occured during the chart
    rendering, it was possible that only parts of the chart were not
    correctly rendered and affected series selection.
  - Stack XYPlot charts no longer fail to render series data in certain
    circumstances.
  - X axis ValueLabel grid lines in 3D plots are now correctly placed
    for certain axis Compass values.

2.0.20113.21334    01-Dec-2011
4.0.20113.21334    01-Dec-2011
  - Internal changes.
  - The Design time Smart Designer now correctly shows the subtype in all
    scenarios.
  - The Axis Thickness property can now have a zero value.  Axes with a
    Thickness value are fully drawn except for the axis line itself.
    (Documentation changes)
  - Radar charts now display tickmarks in the radial direction along X axis
    major gridlines.  The tickmarks are controlled by the Y axis tickmark
    properties.  (Documentation changes).
  - Non-stacked Pie charts can now display labels for each pie/point, by
    using the X axis ValueLabels.
    (Documentation changes)
    ValueLabels are applied to pies or points in the order they appear in
    the ValueLabels collection.  The labels are only displayed if the X axis
    AnnotationMethod property is set to ValueLabels.  The display of the
    labels is also controlled by the X axis properties, including Alignment,
    AnnotationMethod, Compass, Font, ForeColor, Rotation, ValueLabels,
    VerticalText and Visible properties.  No other X axis properties affect
    the labels.  The ChartArea Inverted property also affects the label
    display, in that it determines whether the X axis Compass property
    values will be North, South or East, West.
  - Updated licensing to conform with Federal Information Processing
    Standards requirements. (Tfs-18562)

2.0.20113.21313    10-Nov-2011
4.0.20113.21313    10-Nov-2011
  - Internal changes.
  - Design time pie charts now correctly show the selected series if zero or
    hole values are present.
  - 3D XYPlot and 3D Step chart legend entries now correctly reflect the
    LineStyle instead of the FillStyle.

2.0.20113.21296    24-Oct-2011
4.0.20113.21296    24-Oct-2011
  - Internal changes.
  - Click once applications granted FullTrust can now execute built in chart
    functions.

2.0.20113.21286    14-Oct-2011
4.0.20113.21286    14-Oct-2011
  - Internal changes.
  - Absolute Location and Size of chart elements are now adjusted along with
    chart size during printing operations.

2.0.20113.21276    04-Oct-2011
4.0.20113.21276    04-Oct-2011
  - Internal changes.
  - Licensing update for FIPS compliance.    (TFS-17615,TFS-18460,TFS-18562)

2.0.20113.21263    21-Sep-2011
4.0.20113.21263    21-Sep-2011
  - Internal changes.
  - Gantt and Histogram charts have improved designer behavior.
  - Corrected a caching error when using log plots.  The error occurred when
    the only Axis property to change during an event was IsLogarithmic.
  - Improved resizing behavior of the designer DataTable.
  - Axes Origin properties now honored if Group.Use3D properties are set
    to false, even if the View3D.Depth property is non-zero.
  - Improved behavior of highlighted style mouse actions.

2.0.20113.21253    11-Sep-2011
4.0.20113.21253    11-Sep-2011
  - Internal changes.

2.0.20112.21250    08-Sep-2011
4.0.20112.21250    08-Sep-2011
  - Internal changes.

2.0.20112.21249    07-Sep-2011
4.0.20112.21249    07-Sep-2011
  - Internal changes.
  - The joint use PlotFilters and custom PointStyles behavior has been
    improved.

2.0.20112.21243    01-Sep-2011
4.0.20112.21243    01-Sep-2011
  - Internal changes.
  - Radar charts with flat grid lines now display normal AlarmZones with
    flat edges.
  - Adjustment made to designer datasource and datafield handling for the
    benefit of WebChart.

2.0.20112.21240    29-Aug-2011
4.0.20112.21240    29-Aug-2011
  - Internal changes.
  - Adjustment made to designer datafield handing for the benefit of WebChart.

2.0.20112.21236    25-Aug-2011
4.0.20112.21236    25-Aug-2011
  - Internal changes.
  - Y Axes are now forced to zero bounds only if a bar chart is associated
    with the axis, rather than if either Y axis is associated with a bar
    chart, and only if the Y axis is not logarithmic.

2.0.20112.21228    17-Aug-2011
4.0.20112.21228    17-Aug-2011
  - Internal changes.
  - Lasso zooming no longer generates an exception when over zooming
    generates extreme scaling due to unshown series.

2.0.20112.21221    10-Aug-2011
4.0.20112.21221    10-Aug-2011
  - Internal changes.
  - Chart Draw now correctly handles offsets during printing.
  - Lasso zooming no longer generates an exception when over zooming
    produces a floating point underflow.

2.0.20112.21214    03-Aug-2011
4.0.20112.21214    03-Aug-2011
  - Internal changes.
  - ChartChanged now fires once when BackgroundImageLayout changes.
  - ChartChanged now fires when the BackgroundImage changes.
  - VisualEffects now properly handle rounding and shadow effects for highly
    scaled objects.
  - Serialization of the ValueLabelsCollection no longer duplicates the
    labels in the collection in some circumstances.

2.0.20112.21181    01-Jul-2011
4.0.20112.21181    01-Jul-2011
  - Internal changes.
  - Time axis major ticks values are now rounded more appropriately.
    
2.0.20112.21173    23-Jun-2011
4.0.20112.21173    23-Jun-2011
  - Internal changes.
  - Improved time y axis annotations for Gantt charts.
  - Corrected problem with XYPlot series detection based on chart
    coordinates.  This problem affects Tooltips with PlotElement set to
    Series, HighLight with PlotElement set to Series.
  - Corrected problem where HighLight would activate during design time.

2.0.20112.21170    20-Jun-2011
4.0.20112.21170    20-Jun-2011
  - Internal changes.
  - The chart.PrintChart() overloads now print items drawn in the Paint
    event.

2.0.20112.21167    17-Jun-2011
4.0.20112.21167    17-Jun-2011
  - Internal changes.
  - The TrendLine.GetY() method has been extended to include Maximum,
    Minimum, Average and MovingAverage trendlines.
  - Time axis major ticks values are now rounded more appropriately.

2.0.20112.21131    12-May-2011
4.0.20112.21131    12-May-2011
  - Internal changes.
  - Corrected problem with drawing of certain Candle charts.
  - Charts element sizing is now more consistent with axis compass changes.

2.0.20112.21129    10-May-2011
4.0.20112.21129    10-May-2011
  - Internal changes.
  - Added Japanese localization for ChartData.SeriesWidth.

2.0.20111.21119    30-Apr-2011
4.0.20111.21119    30-Apr-2011
  - Internal changes.
  - A new property, ChartData.SeriesWidth has been added. This property
    specifies the percentage of 3D series widths (Area and Ribbon charts).
    The default value is 100 percent.  Values less than 100 percent provide
    gaps between adjacent series.
    
2.0.20111.21116    27-Apr-2011
4.0.20111.21116    27-Apr-2011
  - Internal changes.
  - Improved tooltip behavior for Ribbon charts.
  - PlotFilter methods now apply to log plots.

2.0.20111.21108    19-Apr-2011
4.0.20111.21108    19-Apr-2011
  - Internal changes.
  - Removed icons from headers in designer forms.

2.0.20111.21089    31-Mar-2011
4.0.20111.21089    31-Mar-2011
  - Internal changes.
  - Some Japanese localizations related to the PlotArea
    (LocationDefault and SizeDefault) now read correctly.
  - Time formatted axes are no longer incorrectly adjusted to a multiple of
    UnitMajor.  This action was not intended for time formatted axes.
  - Radar charts can no longer have negative radii.

2.0.20111.21084    26-Mar-2011
4.0.20111.21084    26-Mar-2011
  - Internal changes.
  - When requesting the design time dialogs with Japanese Visual Studio, a
    null exception message no longer occurs.
  - Japanese localizations have been added.

2.0.20111.21083    25-Mar-2011
4.0.20111.21083    25-Mar-2011
  - Internal changes.
  - Added explicit reference to 4x designer.  This improves behavior when multiple
    versions of the Chart are installed on the same machine.


2.0.20111.21027    28-Jan-2011
4.0.20111.21027    28-Jan-2011
  - Internal changes.
  - Corrected Xml documentation file for SaveLocalizations(byte[] byteArray)
    and LoadLocalizations(byte[] byteArray).
  - Corrected behavior of Chart Properties and Chart Wizard Dialogs when
    changing the size by Maximizing and Restoring dialog.
    
2.0.20111.21012    13-Jan-2011
4.0.20111.21012    13-Jan-2011
  - Internal changes.
  - LoadLocalization() overloads can now reset the localization to its default
    state by passing a null argument.

2.0.20111.21006     07-Jan-2011
4.0.20111.21006     07-Jan-2011
  - Internal changes.
  - Chart dialogs can now be maximized.
  
2.0.20111.21005     06-Jan-2011
4.0.20111.21005     06-Jan-2011
  - Internal changes.
  - The V1 chart properties dialog and wizard now reflect the property
    settings of the hosting chart at startup.

2.0.20111.21004     05-Jan-2011
4.0.20111.21004     05-Jan-2011
  - Internal changes.
  - Added runtime user localizations by introducing SaveLocalizations() and
    LoadLocalizations() methods.  This overloaded methods save and load XML
    translation tables, respectively, that translate internal strings at
    runtime.
  - The radar chart now supports AlarmZones.  The AlarmZones specify
    NearExtents and FarExtents in angles measured from the first item in the
    radar chart.  The angle is specified in degrees or radians depending
    upon the ChartGroup.Radar object settings.  Requires documentation
    changes to indicate angle specification.
  - The chart property and chart wizard dialogs can now be resized.

2.0.20103.20356     23-Dec-2010
4.0.20103.20356     23-Dec-2010
  - Internal changes.

2.0.20103.20346     13-Dec-2010
4.0.20103.20346     13-Dec-2010
  - Internal changes.

2.0.20103.20251     09-Sep-2010
4.0.20103.20251     09-Sep-2010
  - Internal changes.
  - When the Group0 and Group1 entries are used to override the Default
    VisualEffects style, the legend entries are now correctly rendered.
  - ShowVisualEffectsEditor has been added to the C1Chart object.

2.0.20103.20250     08-Sep-2010
4.0.20103.20250     08-Sep-2010
  - Internal changes.
  - The SmartPainter now has Group0 and Group1 entries which can be used to
    selectively override the data (Default) settings for the respective
    ChartGroup data.

2.0.20103.20245     03-Sep-2010
4.0.20103.20245     03-Sep-2010
  - Internal changes.

2.0.20102.20244     02-Sep-2010
4.0.20102.20244     02-Sep-2010
  - Internal changes.
  - Adjusted Axis calculations to match format even for ValueLabel
    annotations.
  - The DrawDataSeries event now honors the setting of e.Pen when drawing
    the data lines in the legend.

2.0.20102.20187     07-Jul-2010
4.0.20102.20187     07-Jul-2010
  - Internal changes.

2.0.20102.20166     16-Jun-2010
4.0.20102.20166     16-Jun-2010
  - Internal changes.

2.0.20101.20159     09-Jun-2010
4.0.20101.20159     09-Jun-2010
  - Internal changes.

2.0.20101.20157     07-Jun-2010
4.0.20101.20157     07-Jun-2010
  - Internal changes.

2.0.20101.20145     26-May-2010
4.0.20101.20145     26-May-2010
  - Internal changes.
  - The ChartGroup.CoordToDataIndex() method now returns correct distance
    data for pie charts for all settings.

2.0.20101.20143     24-May-2010
4.0.20101.20143     24-May-2010
  - Internal changes.

2.0.20101.20136     17-May-2010
4.0.20101.20136     17-May-2010
  - Internal changes.

4.0.20101.20132     13-May-2010
2.0.20101.20132     13-May-2010
  - Internal changes.

4.0.20101.20131     12-May-2010
2.0.20101.20131     12-May-2010
  - Internal changes.
  - Finalizing 4.0 version port.

4.0.20101.20119     30-Apr-2010
2.0.20101.20119     30-Apr-2010
  - Internal changes.
  - 4.0 version has designer split into separate assembly for 4.0 Client Mode.

2.0.20101.20096     07-Apr-2010
  - Internal changes.

2.0.20101.20089     31-Mar-2010
  - Internal changes.

2.0.20101.20062     04-Mar-2010
  - Internal changes.
  - Histogram charts with VisualEffects now scroll and paint correctly with
    axis scrollbars.

2.0.20101.20060     02-Mar-2010
  - Internal changes.
  - A minor change was made to mouse processing that elimates a rare exception.

2.0.20101.20053     23-Feb-2010
  - Internal changes.
  - Area chart data series can now be selected in the smart designer.
  - Chart Properties dialog now enables the Stacked checkbox for Pie types.
  - Chart Properties dialog now enables the 3D checkbox for Step types.
  - PlotArea.LocationDefault and PlotArea.SizeDefault are now properly
    persisted during serialization.

2.0.20101.20048     18-Feb-2010
  - Internal changes.
  - Stacked pie charts are now properly persisted when changing views in the
    designer and wizard.

2.0.20101.20037     07-Feb-2010
  - Internal changes.
  - Added stacked Pie charts to the Pie and Doughnut galleries.
  - Added new sample, PieGrouping to C# and VB sample directories.

2.0.20101.20033     03-Feb-2010
  - Internal changes.
  - Added stacked Pie charts.  Stacking Pie charts produces a concentric pie
    charts, with point zero at the outermost edge with subsequent pie chart
    points added to the center.  Please note that for stacked pie charts,
    pie slices can longer be offset, and 3D stacked pie charts do not honor
    the inner radius setting (i.e. - no 3D stacked donut charts).
    
2.0.20101.20021     22-Jan-2010
  - Internal changes
  - Added a new Pie and Bar chart DataLabel and Tooltip text place holder,
    {%YVAL} in addition to the existing place holders.  The new place holder
    is replaced with the percentage that the series Y value represents of
    the sum of all series values at a given point.
  - Added LabelCompassEnum.RadialText to the enumeration.  This value
    requests that the label text is oriented in the same direction as the
    offset.  The value has been added for Pie chart data labels.

2.0.20101.20014     15-Jan-2010
  - Internal changes
  - The PlotArea now exposes LocationDefault and SizeDefault properties that
    together allow placement of the PlotArea within the chart.  If the
    PlotArea is placed, the axes are forced to align at the PlotArea
    boundaries regardless of whether they can be fully displayed.
  - Modified licensing requirements for Visual Studio 2010.

2.0.20093.19364     31-Dec-2009
  - Internal changes
  - Modified style persistence such that the attribute order is consistent.

2.0.20093.19362     29-Dec-2009
  - Internal changes
  - ChartDataSeries.SymbolStyle objects are now visible from property grids
    for HiLoOpenClose charts.  SymbolStyle.Size is used to specify the
    length of the Open and Close lines for this chart type.
  - AboutBox truncations in GrapeCity builds have been eliminated.


2.0.20093.19356     23-Dec-2009
  - Internal changes
  - Resizing the chart to zero width or height during a repaint
    operation no longer causes an exception.
  - Attempting to add a new ChartDataSeries to an empty
    ChartDataSeriesCollection through the PropertyGrid editor no longer causes
    an exception.

2.0.20093.19342     09-Dec-2009
  - Internal changes
  - DataLabel styles are now preserved when modified in the
    ChartDataSeriesCollectionEditor.
  - Legend forecolor is now correctly inherits chart forecolor in all
    circumstances.

2.0.20093.19337     04-Dec-2009
  - Internal changes.
  - ShowTooltip event does not fire for the chart elements when the element's
    tooltip is not set.
  - BackgroundImageLayoutChanged event now fires properly.

2.0.20093.19336     03-Dec-2009
  - Internal changes.
  - Fixed the problem with axis value label marker when dragging with two mouse
    buttons.
  - Improved axis limits calcualtion.
  - Restored MiterLimit and LineJoin properties to line styles for
    PointStyle.LineStyle and HighLight.LineStyle.

2.0.20093.19335     02-Dec-2009
  - Internal changes.
  - Added Japanese localizations.

2.0.20093.19334     01-Dec-2009
  - Internal changes.
  - Header and footer images now are displayed correctly when using
    visual effects.
  - Added Japanese localizations.
  - MiterLimit and LineJoin properties are now displayed in property grids
    only for the ChartDataSeries LineStyles.

2.0.20093.19333     30-Nov-2009
  - Internal changes.
  - Fixed the problem with Doughnut charts and text visual effects in the
    chart designer previews.
  - Add Sample Data verbs now post a confirmation request before changing
    data.
  - Added Japanese localization adjustments.

2.0.20093.19332     29-Nov-2009
  - Internal changes.
  - Area charts with Visual Effects now display correctly when scrolled.

2.0.20093.19329     26-Nov-2009
  - Internal changes
  - GrapeCity licensing now correct.
  - Bubble charts with Visual Effects now display correctly.

2.0.20093.19328     25-Nov-2009
  - Internal changes
  - Area chart tooltips now function correctly.

2.0.20093.19310     07-Nov-2009
  - Internal changes
  - Internal licensing changes.

2.0.20093.19301     29-Oct-2009
  - Internal changes
  - Added new GrapeCity license codes for JPN version.
  
2.0.20093.19298     26-Oct-2009
  - Internal changes
  - Pie charts (3D) with VisualEffects now draw correctly when one or more
    series have pattern or gradient fill.
  - Added default data setups based on the chart type.
  - Added verbs and designer operations to allow update of chart data after
    changing chart type.
  - Chart.Print now properly displays the PrintDialog during 64 bit
    execution.

2.0.20093.19284     12-Oct-2009
  - Internal changes
  - Adjusted internal documentation.

2.0.20093.19272     30-Sep-2009
  - Internal changes

2.0.20093.19267     25-Sep-2009
  - Internal changes
  - Corrected pen behavior when a thin line and legend are used in the same
    line chart.  The error was introduced in build 2.0.20093.19256.

2.0.20093.19265     23-Sep-2009
  - Internal changes

2.0.20093.19258     16-Sep-2009
  - Internal changes
  - LineStyle Color and Symbol generation is now reset when all series are
    removed from both ChartGroups.

2.0.20093.19256     14-Sep-2009
  - Internal changes
  - Added LineJoin and MiterLimit properties to the LineStyle of the
    ChartDataSeries.  The LineJoin and MiterLimit properties, definitions
    and defaults are the same as the those of Pen.LineJoin and
    Pen.MiterLimit.
  - Series lines drawn in the legend are now set to a minimum thickness of 3
    pixels if all series lines in the group are the same thickness.
  - Added Axis.TickFactorMajor and Axis.TickFactorMinor properties.  These
    properties apply a multiplication factor to the respective tick lengths
    for the axis.
  - Added gauge marks and Axis.TickGauge property.  Gauge marks are
    periodically enhanced minor tick marks that allow easier reading of
    minor tick marks. See TickGauge property for more details.
  - Added Axis.NoAnnoOverlap property.  Setting this value to true
    suppresses drawing of axis annotations that have been previously drawn.
  - Improved automatic histogram interval calculation for skewed data.
  - Honors C1Olap licensing.

2.0.20092.19168     18-Jun-2009
  - Internal changes

2.0.20092.19161     11-Jun-2009
  - Internal changes
  - Adjusted obfuscation for licensing.

2.0.20092.19160     10-Jun-2009
  - Internal changes
  - Adjusted obfuscation for licensing.
  - Chart 2D ChartGroup and FillStyle outline colors are now reflected in
    the legend.

2.0.20092.19152     02-Jun-2009
  - Internal changes
  - New Licensing and AboutBox code.

2.0.20091.19053     23-Feb-2009
  - Internal changes
  - ChartGroup.ResetOutlineColor() now automatically refreshes the image and
    correctly fires the ChartChanged event.
    
2.0.20091.19043     13-Feb-2009
  - Internal changes
  - Added Japanese localizations for property descriptions new to build
    2.0.20091.19030

2.0.20091.19032     02-Feb-2009
  - Internal changes
  - Corrects persistence problem for Axis.VerticalText in build 19030.
    Do not use build 19030

2.0.20091.19030     31-Jan-2009
  - Bad build, do not use
  - Internal changes
  - Added the new property, OutlineColor to the Group class.  By default,
    the property value is Color.Empty which indicates continued use of the
    PlotArea.ForeColor for outlining figures.  Setting this property to a
    non-empty value overrides the PlotArea.ForeColor use for outlining.
  - Added the new method, ResetOutlineColor() to the Group class.  This method
    sets the OutlineColor to Color.Empty.
  - Added the new properties, OutlineColor and OutlineThickness to the FillStyle
    class.  For data that applies FillStyles, the outline color and thickness
    can be overriden by the FillStyle property values.
  - Added the new method, ResetOutlineColor() to the FillStyle class.  This method
    sets the OutlineColor to Color.Empty.
  - Added the new property VerticalText to the Style class.  This allows
    some double byte characters to be rendered from top to bottom instead
    of left to right. For single byte characters VerticalText appears as
    rotated text, 90 degrees in the clockwise direction.
  - Added the new property VerticalText and AnnoVerticalText to the Axis
    class.  This allows some double byte character to be rendered from top
    to bottom instead of left to right.  For single byte characters
    VerticalText and AnnotVerticalText appears as rotated text, 90 degrees
    in the clockwise direction.

2.0.20091.19026     27-Jan-2009
  - Internal changes
  - Added Japanese localizations for property descriptions new to build
    2.0.20091.19015

2.0.20091.19015     16-Jan-2009
  - Internal changes
  - Added new properties to the Group.Bar class.  The new properties affect
    lines are rendered between series rectangles from point to point in
    stacked 2D bar and column charts.  The properties include BarLines,
    BarLineColor and BarLineThickness.
  - Added the new property, FlatGridLines to the Group.Radar class.  The
    new property specifies whether to use flat Y coordinate gridlines for
    for radar charts.
  - Added the new property, Clockwise to the Group.Pie class.  The new
    property specifies whether the series slices are rendered in a clockwise
    or counter-clockwise direction (default).
  - Completed the implementation of the TickLabels property of the Axis class,
    which now includes implementation of TickLabelsEnum.High and
    TickLabelsEnum.Low.

2.0.20083.19012     13-Jan-2009
  - Internal changes
  - Design time environment chart designer Visual Effects operations are now
    suppressed when running in the IDE.  Previously some attempts at
    changing the chart properties could result in an unhandled exception.

2.0.20083.19011     12-Jan-2009
  - Internal changes
  - Design time environment chart designer operations are now suppressed
    when running in the IDE.  Previously some attempts at changing the chart
    properties could result in an unhandled exception.

2.0.20083.19006     07-Jan-2009
  - Internal changes

2.0.20083.19005     06-Jan-2009
  - Internal changes
  - HiLow / HiLowOpenClose charts now correctly show tooltips when either
    axes are scaled logarithmically. (TTP-18789)

2.0.20083.18353     19-Dec-2008
  - Internal changes
  - 3D Pie Charts now use the correct FillStyle with DrawDataSeries events
    are used but do not set brushes.

2.0.20083.18335     01-Dec-2008
  - Internal changes
  - Adjustments for MediumTrust situations.

2.0.20083.18325     21-Nov-2008
  - Internal changes
  - Adjustments for MediumTrust situations.

2.0.20083.18323     19-Nov-2008
  - Internal changes

2.0.20083.18297     24-Oct-2008
  - Internal changes
  - Axis precision now matches that of UnitMajor or UnitMinor in all cases.
    (revised)

2.0.20083.18296     23-Oct-2008
  - Internal changes
  - Inverted HiLo and related charts now propertly scroll within the
    PlotArea.
  - Axis precision now matches that of UnitMajor or UnitMinor in all cases.

2.0.20083.18294     21-Oct-2008
  - Internal changes
  - The LabelCollection editor dialogs now correctly handle and persist
    property assignments for collection elements.  This was a error
    resulting from changes in build 2.0.20083.18265.
  - The SmartDesigner for ChartLabels now correctly handles Cancel
    operations with respect to chart element images.
  - Added new C1Chart methods.  The new methods are similar to the
    previously existing methods but also save the chart element style
    images:
      SaveChartAndImagesToFile(),    SaveChartAndImagesToString()
      LoadChartAndImagesFromFile(),  LoadChartAndImagesFromString()
  - Adjusted behavior of Smart Designer labels editor.

2.0.20083.18265     22-Sep-2008
  - Internal changes
  - Memory leaks associated with LabelsCollection.Clear() have been
    corrected.

2.0.20083.18248     05-Sep-2008
  - Internal changes
  - A workaround for a C++ compiler naming issue was added by adjusting
    obfuscation.

2.0.20083.18238     26-Aug-2008
  - Internal changes
  - Added/modified innternal documentation changes for YFunction and
    ParametricFunction constructors and value retrieval functions.

2.0.20083.18237     25-Aug-2008
  - Internal changes

2.0.20082.18237     25-Aug-2008
  - Internal changes
  - AlarmZone polygons with 3 or more visible unclipped points are now
    correctly drawn.
  - Plotted YFunctions and ParametricFunctions using CodedText and
    CodedLines now correctly release memory associated with each coded
    change.

2.0.20082.18192     11-Jul-2008
  - Internal changes
  - All series are now correctly drawn when one or more series are hidden
    with the PlotFilterMethod.

2.0.20082.18140     20-May-2008
  - Internal changes
  - Headers, Footers, Legend and Labels (chart) are now correctly placed
    when making external calls to the Chart Draw method and any or all of
    these objects are not automatically placed.

2.0.20082.18134     14-May-2008
  - Internal changes
  - The ChartProperties and ChartWizard designers now correctly gray the
    chart in the preview panel when gradient backgrounds are used.
  - The ChartProperties and ChartWizard designer have improved behavior
    on the Axis tabs.

2.0.20082.18078     19-Mar-2008
  - Internal changes
  - Added AxisScroll events to both C1Chart and AxisScrollBar.  One or both
    events fire whenever the value of the AxisScrollBar changes.

2.0.20081.18077     18-Mar-2008
  - Internal changes
  - Antialiasing in the plot now draws correctly for large numbers of plot
    points.  The problem was created as a result of the workaround of the
    GDI+ issue implemented in build 18041.

2.0.20081.18045     15-Feb-2008
  - Internal changes
  - Labels placed by DataCoordinate are correctly positioned for logarithmic
    axes.

2.0.20081.18041     11-Feb-2008
  - Internal changes
  - XYPlots with plot lines of near zero slope now render correctly in all
    cases.  This is a workaround to a GDI+ issue.

2.0.20081.18039     09-Feb-2008
  - Internal changes
  - Bar charts will now adjust the Y axis minimum zero for cases near zero
    when the AutoMin is true.

2.0.20081.18038     08-Feb-2008
  - Internal changes
  - Bar charts now correctly stack for single data point series.
  - Moveable axis markers can now be dragged by grabbing any part of the
    marker's circumscribing rectangle.
  - Labels placed by DataCoordinate are correctly positioned for logarithmic
    axes.
  - Pie slices now have correct edge shading when hatching or gradient fills
    are used.

2.0.20081.18021     22-Jan-2008
  - Internal changes

2.0.20081.18020     21-Jan-2008
  - Internal changes

2.0.20081.18016     17-Jan-2008
  - Internal changes
  - Conic, Pyramidal and Cylindrical bar charts now correctly display
    all gradient styles.

2.0.20081.18013     14-Jan-2008
  - Internal changes
  - Edit Data Series correctly handles series edit requests, even when all
    series labels have been cleared.
  - Conic, Pyramidal and Cylindrical bar charts now correctly display
    all gradient styles.
  - Interaction behavior improved.
  - ToolTip behavior has been improved.

2.0.20073.17333     30-Nov-2007
  - Internal changes.

2.0.20073.17282     10-Oct-2007
  - Internal changes.
  - SmartDesigner behavior improvements.

2.0.20073.17281     09-Oct-2007
  - Internal changes.
  - Japanese localization improvements.
  - SmartDesigner behavior improvements.

2.0.20073.17277     05-Oct-2007
  - Internal changes.

2.0.20073.17276     04-Oct-2007
  - Internal changes.
  - AlarmZone polygon coordinate data now persists correctly in all cases.

2.0.20073.17274     02-Oct-2007
  - Internal changes.
  - SmartDesigner behavior improvements.

2.0.20073.17273     01-Oct-2007
  - Internal changes.
  - The design time verbs, "Reset" and "Reset to default chart" now reset
    UseGrayScale, Enabled and Visible properties.  The Chart.Reset() method
    now resets UseGrayScale at runtime.
  - ChartWizard and ChartProperty dialog behavior improvements.

2.0.20073.17270     28-Sep-2007
  - Internal changes.
  - The Chart BackgroundImageLayout property is now correctly linked to the
    Chart.Style.ImageAlignment property.  ImageAlignments that cannot be
    mapped values for the BackgroundImageLayout are reflected as
    ImageAlignment.None for the BackgroundImageLayout value.

2.0.20073.17269     27-Sep-2007
  - Internal changes.
  - Added a new PrintChart() overload which allows printing as a bitmap
    instead of a metafile.  This overload may be useful for printer drivers
    that do not support GDI+.

2.0.20073.17266     24-Sep-2007
  - Internal changes.
  - SmartDesigner behavior improvements.
  - The Bar.MultiRow property now persists correctly when it is the only
    non-default property.
  - Cylinders, Cones and Pyramid bar charts now support HatchBrush
    fillstyles.

2.0.20073.17262     20-Sep-2007
  - Internal changes.
  - Added new Japanese localizations.
  - SmartDesigner behavior improvements.

2.0.20073.17261     19-Sep-2007
  - Internal changes.
  - Charts now use SystemColors.Window for the default BackColor of the
    ChartArea instead of White.
  - SmartDesigner tooltip sizing has been improved.
  - Improved axis number formatting.
  - Improved behavior of Data Binding Editor
  - Integral holes are now properly handled in bar charts

2.0.20073.17249     07-Sep-2007
  - Internal changes.
  - SmartDesigner now operates correctly when UseGrayScale is true.

2.0.20073.17248     06-Sep-2007
  - Internal changes.
  - Design time series data is no longer removed when a datasource is cleared.
  - Saved images of specified sizes now render consistently regardless of
    the size of the hosting chart.
  - Chart image is now updated when the BackgroundImage property is set when
    either UseDoubleBuffer or UseGrayScale properties are true.
 
2.0.20073.17247     05-Sep-2007
  - Internal changes.
  - Adjustments required for C1WebChart corrections.
  - SmartTag now updates its properties when changed using the Properties
    or Wizard dialogs
  - Bound string fields now handle DBNull values as data holes.
  - Bar chart ClusterOverlap properties now accept negative values.
    Negative values separate bars within the cluster.

2.0.20073.17231     20-Aug-2007
  - Internal changes.  
  - Added new Japanese localizations.

2.0.20072.17187     07-Jul-2007
  - Internal changes.  

2.0.20072.17156     06-Jun-2007
  - Internal changes.  

2.0.20072.17142     23-May-2007
  - Internal changes.  
  - Fixed an intermittent problem with Axis scrollbars serialization that
    would sometimes result in an exception.

2.0.20072.17140     21-May-2007
  - Internal changes.  
  - Fixed the problem with moveable ValueLabels which can now be dragged using
    the label part which is outside the axis limits.
  - Added ColorGeneration operations to the ChartProperties and ChartWizard
    dialogs on the Data page.

2.0.20072.17134     15-May-2007
  - Internal changes.  
  - Fixed failing tooltip display for bar charts when input x values are
    float (Single) values.  Double values are okay.
  - Fixed minor problem with rendering XYChart when PlotFilterMethod=Default.
  - Added UseGrayscale property to the chart object.  This boolean property
    allows rendering of the charts in grayscale as a preview for non-color
    printers.
  - DataLabels now are visible when the data value is equal to the axis
    minimum for bar charts.
  - Added ColorGeneration property to the 2D chart object.  This enumeration
    allows selection of color schemes for data series.

2.0.20071.17096     07-Apr-2007
  - Internal changes.  
  - Fixed a problem with C1Chart.Draw() method when coordinates of
    rectangle parameter are negative(VNCHT000525).
  - Fixed a problem with automatic calcualtion of min/max for
    logarithmic axes.

1.0.20071.17032     02-Feb-2007
  - Internal changes.

1.0.20071.17030     31-Jan-2007
  - Internal changes.

1.0.20071.17023     24-Jan-2007
  - Internal changes.

1.0.20071.17002     03-Jan-2007
  - Internal changes.

1.0.20071.17001     02-Jan-2007
  - Internal changes.
  - Fixed memory leak after clearing ChartDataSeriesCollection with
    RemoveAll()/Clear() methods.

1.0.20071.16354     21-Dec-2006
  - Internal changes.

1.0.20071.16346     13-Dec-2006
  - Internal changes.

1.0.20071.16332     29-Nov-2006
  - Internal changes.

1.0.20071.16289     17-Oct-2006
  - Internal changes.
  - Added an option to Interaction properties that allows to fill selected
    area when zooming. The color for the selected area is PlotArea.BackColor2,
    if this color is empty the semi-transparent color is used.
  - Added couple of methods(BeginUpdate()/EndUpdate()) which allows
    multiple(batched) chart updates to be performed without excessive repainting.
   
1.0.20063.16281     09-Oct-2006
  - Internal changes.
  - Adjusted position of rotated axis labels(Axis.AnnoRotation != 0).
    Previously the axis labels may have been overlapped by the axis title.
  - Automatic axis limits are now calculate more correctly when formatting
    with certain DateManual specifications.   
  - Cosmetic changes were made in VisualEffects dialog.

1.0.20063.16228     17-Aug-2006
  - Internal changes.
  - Fixed the problem with bar chart and logarithmic x-axis.

1.0.20063.16219     08-Aug-2006
  - Internal changes.
  - Added variations of 3D bar charts: cylinder, cone and pyramid
    (Bar.Appearance property).
  - Added an option to show 3D bar chart as multiple rows
    (ChartGroup.MultiRow property).
  - AxisScrollbar.Scroll() now behaves correctly for for reversed vertical
    axes.

1.0.20062.16205     25-Jul-2006
  - Internal changes.
  - 100% stacked bar charts now behave correctly when y-values have zero values.

1.0.20062.16183     03-Jul-2006
  - Internal changes.

1.0.20062.16182     02-Jul-2006
  - Internal changes.

1.0.20062.16143     24-May-2006
  - Internal changes.  
  - Fixed a localization issue so that text is no longer truncated in the
    border editor.
 
1.0.20062.16128     09-May-2006
  - Internal changes.  
  - Fixed the problems with Histogram chart which may lead to exception
    under several conditions.
  - Fixed incorrect behavour of 'Cancel' button in TrendLinesCollection
    editor.

1.0.20062.16127     08-May-2006
  - Internal changes.
  - Fixed the problem where BindingSource creation using DataSource Designer
    through Property Grid is empty.
  - Fixed the problem Clicking the 'Cancel' button in the
    'PointStylesCollection' editor removes the applied styles.
  - Fixed the problem with stacked chart which may cause exception
    under several conditions with logarithmic axes.

1.0.20062.16123     04-May-2006
  - Internal changes.
  - Fixed stacked chart PointStyle issue that incorrectly resulted in
    multiple PointStyle changes.

1.0.20062.16122     03-May-2006
  - Internal changes.
  - Fixed a problem with border color. It was sometimes cleared after changing
    border style.
  - Fixed several minor designtime issues.

1.0.20062.16120     01-May-2006
  - Internal changes.
  - Fixed several designtime issues related with VisualEffects.
  - Added localizations for Japanese builds.

1.0.20062.16110     21-Apr-2006
  - Internal changes.
  - Fixed problems with VisualEffectsStyle collection editor.
  - Data series with 3 points now are rendered as a spline curve
    when FitType=FitTypeEnum.Spline, previously there were connected
    with straight lines.

1.0.20062.16106     17-Apr-2006
  - Internal changes.
  - AboutBox adjustments.

1.0.20062.16103     14-Apr-2006
  - Basic chart elements now are exposed through accessibility interfaces.
  - VisualEffects dialog is no longer shown in the taskbar.
  - Added localized Japanese descriptions for UseAntiAliasGraphics,
    UseAntiAliasText, VisualEffects properies and all VisualEffectsStyle
    properties. Added localized Japanese translation for VisualEffects verb.
  - Fixed several designtime issues.

1.0.20062.16099     10-Apr-2006
  - Internal changes.

1.0.20062.16098     09-Apr-2006
  - Fixed the problem with 3D doughnut chart appearance under certain conditions.
  - Due to changes to the C1Chart 2.x DataSource property, the IDE PropertyGrid
    now provides better editing support, allowing the selection of an existing
    data source, or the creation of a new data source as necessary.
  - Added public interface to VisualEffects through Styles collection
    of VisualEffectsStyle objects.

1.0.20062.16087     29-Mar-2006
  - Internal changes.
  - Several minor design time behaviors have been improved.
  - Added UseAntiAliasGraphics, UseAntiAliasText for the chart object,
    and UseAntiAlias to the PlotArea object.
  - Added VisualEffects support.
  - "Antialising" checkbox now works properly in chart property dialog.
  - Fixed the problem with axis date/time formatting, under several
    conditions the labels could be rendered with incorrect overlap.
  - Fixed several localization issues specific for .Net 2.0.
  - Fixed incorrect rendering of moving-average trendline in financial
    (hilo/hi-lo-open-close/candle) charts. Under certain conditions
    trendline could go beyond the plot area.  
  - Added ChartSampleCenter.exe, a chart function sampler with code
    display in C Sharp and Visual Basic.Net.

1.0.20061.16018     19-Jan-2006
  - Internal changes.
  - Several minor design time behaviors have been improved.

1.0.20061.16009     10-Jan-2006
  - Internal changes.
  - Fixed several localization issues.
  - Label images now are not removed after properties dialog.

1.0.20061.16007     08-Jan-2006
  - Internal changes.
  - Fixed problems with logarithmic stacked chart.
  - Fixed several minor issues with properties dialog.
  - Improved axis label display in some cases when the UnitMajor values are
    explicitly set.
  - Add additional localizations, translations and adjustments for Japanese
    builds.

1.0.20061.16002     03-Jan-2006
  - Internal changes.
  - Highlighting data series with holes now works correctly.
  - Fixed minor problems in Edit Data Binding dialog.
  - Fixed several VS2005-specific collection editor problems.

1.0.20061.15363     30-Dec-2005
  - Internal changes.
  - Fixed additional problems with unsupported data types.

1.0.20061.15362     29-Dec-2005
  - Internal changes.
  - Fixed several problems associated with data binding in designer dialogs.
  - Fields with unsupported data types now are not visible in design dialogs.

1.0.20061.15354     21-Dec-2005
  - Internal changes.
  - Fixed the problems with logarithmic area chart rendering under
    several conditions.
  - Improved performance when creating large number of data series.

1.0.20061.15353     20-Dec-2005
  - Internal changes.
  - Added localization and translations of the DataBindingEditor for
    Japanese builds.

1.0.20061.15342     09-Dec-2005
  - Internal changes.
  - Japanese and English localization for all builds.
  - PointStyleSelect event has been modified to handle LineStyle changes
    for XYPlots, as well as SymbolStyle changes.

1.0.20061.15339     06-Dec-2005
  - Internal changes.

1.0.20053.15339     06-Dec-2005
  - Internal changes.

1.0.20053.15321     18-Nov-2005
  - Internal changes.
  - Aboutbox email handler changes.
  - Axis scrollbar can now have a minimal scroll thumb size.  Previously, the thumb
    did not scale with the axis scaling.

1.0.20053.15320     17-Nov-2005
  - Internal changes.

1.0.20053.15308     05-Nov-2005
  - Internal changes.

1.0.20053.15307     04-Nov-2005
  - Internal changes.
  - Various bug fixes.

1.0.20053.15306     03-Nov-2005
  - Internal changes.
  - Various bug fixes.

1.0.20053.15299     27-Oct-2005
  - Internal changes.
  - Various bug fixes.

1.0.20053.15288     16-Oct-2005
  - Internal changes.
  - Various bug fixes.

1.0.20053.15236     25-Aug-2005
  - Internal changes.
  - Various bug fixes.

1.0.20053.15235     24-Aug-2005
  - Internal changes.
  - Various bug fixes.

1.0.20053.15234     23-Aug-2005
  - Internal changes.
  - Various bug fixes.

1.0.20053.15233     22-Aug-2005
  - Internal changes.
  - Various bug fixes.

1.0.20053.15225     14-Aug-2005
  - Added new Japanese translations.
  - Added DrawDataSeriesEventArgs.DisposePen property.

1.0.20053.15213     02-Aug-2005
  - Added DrawDataSeriesEventArgs.Pen property which allows using custom
    pens for rendering lines.
  - Added GetMetafile() method.
  - Added PrintChart() method with PageSettings parameter.
  - Various bug fixes.

1.0.20052.15205     25-Jul-2005
  - Various bug fixes.
  - Additional Japanese translations.

1.0.20052.15197     17-Jul-2005
  - Various bug fixes.
  - Added doughnut charts to Chart Properties/Wizard.

1.0.20052.15181     01-Jul-2005
  - Japanese and English localization for all builds

1.0.20052.15171     21-Jun-2005
  - Additional translations made/corrected for Japanese version.

1.0.20052.15163     13-Jun-2005
  - Added Step chart
  - Added Doughnut chart capability to pie charts.
  - Added Histogram chart.
  - Added DataLabels which automatically generate labels for data points.
  - Added enhanced and automatic label placement logic that provides label
    placement to minimize label overlap.
  - Added automatic data Highlighting
  - Added enhanced AlarmZones.
  - Added logic allowing ValueLabels to be dragged and show markers and
    gridlines.
  - Added StatisticsData object to ChartDataArray objects.
  - Added new axis annotation mode Mixed allowing used of Value and
    ValueLabels together on the same axis.
  - Added new samples, AlarmZoneShapes, AutoArrangement, Donut, StepChart,
    and Histogram.
  - Added drawing cache improvements and optimizations
  - Added plot filtering for further optimized high speed rendering.
  - PointStyles LineStyle can now change the line style for all subsequent
    points or until the next PointStyle changes them again.
  - Fixed the problems with axis scrollbar printing.

1.0.20052.15115     26-Apr-2005
  - Various bug fixes.

1.0.20052.15111     22-Apr-2005
  - More reasonable MinorTick spacing is now automatically calculated when
    large values of LogarithmicBase are used.

1.0.20052.15109     20-Apr-2005
  - Fixed a problem with autscaling when the axis limits are very close.

1.0.20052.15108     19-Apr-2005
  - Additional Japanese translations.

1.0.20052.15103     14-Apr-2005
  - Additional Japanese translations.

1.0.20052.15102     13-Apr-2005
  - Various bug fixes.

1.0.20052.15097     08-Apr-2005
  - Borders with rounded corners are drawn using anti-aliasing.
  - Added FillStyles, Tooltips, Header/Footer images, Header/Footer RTF.

1.0.20051.15083     25-Mar-2005
  - Additional translations made/corrected for Japanese version.

1.0.20051.15082     24-Mar-2005
  - Additional translations made/corrected for Japanese version.
  - Various bug fixes.
  - Chart designer now limits rounded corners radius.
  - Axis scrollbars no longer paint without chart data available.
  - Added property descriptions for YFunction and ParametricFunction objects.

1.0.20051.15080     22-Mar-2005
  - Additional translations made for Japanese version.
  - Improved plotting of some discontinous functions.
  - Radar charts no longer have an extra line between the first and
    last data values when spline fits are used.

1.0.20051.15075     17-Mar-2005
  - Various bug fixes.

1.0.20051.15072     14-Mar-2005
  - Automatic Min/Max calculations for bar charts with a logarithmic X axis
    has been modified to accommodate data near the axis extremes.
  - Fixed various minor bugs and anomolies.

1.0.20051.15063     05-Mar-2005
  - Axis.ScrollBar.ScaleMenu now can be set at design time.
  - Various bug fixes.

1.0.20051.15059     01-Mar-2005
  - Fixed problems with inheriting properties(ForeColor, BackColor, Font)
    from the parent form.
  - Fixed various problems with collection editors.
  - Fixed the problem with XP-theme appearance of axis scroll bar.
  - Fixed the problem with value label color where text color was incorrect
    under several conditions.
  - Fixed a problem setting the Axis.Max when axis scrollbar is active.
  - Fixed minor issues with Axes collection editor and the ChartGroups
    collection editor.
  - Fixed several minor problems with wizard/properties dialog.
  - Fixed a problem updating axis Min/Max when changing LogarithmicBase property.
  - Data binding now can work with fields which have dot symbol in name.
  - Fixed the problem with axis auto limits calculation that could
    cause overflow exception when working with huge data values.
  - Fixed the problem with updating Label.Location property in property grid.
  - Fixed the problem with label names in collection edtior.
  - Miscellaneous bug fixes.

1.0.20051.15016     17-Jan-2005
  - 100% bar charts no long take exceptions when using logarithmic y-axis under
    certain conditions.
  - The range restriction during built-in interaction has been weakened
    for XYPlot charts.
  - Unattached ChartDataSeries objects (i.e. not associated with a chart or
    ChartData object) no longer throw exceptions with data related operations.
  - Fixed additional problems with PropertyGrid behaviors involving Location,
    LocationDefault, Size and SizeDefault when other object properties are
    changed.

1.0.20051.14362     28-Dec-2004
  - Fixed a problem with the collection editor whereby a background image could
    be lost after using the editor.
  - Fixed some problems with PropertyGrid behaviors involving Location,
    LocationDefault, Size and SizeDefault when other object properties are
    modified.

1.0.20051.14349     15-Dec-2004
  - The DataCoordToCoord() method of a ChartGroup now returns false when the data
    coordinate is nonpositive and the corresponding axis is logarithmic.
  - A problem with editing the ChartDataArray.DataField property has been fixed, and
    no longer results in clearing the data array.
  - A problem that caused an exception when using logarithmic axis with Gantt charts
    has been fixed.
  - Alarmzones auto-numbering algorithm has been improved.
  - A problem with incorrect ChartGroupsCollection editor behavior after editing
    the ChartData collections (FunctionsList, PointStylesList, SeriesList, TrendsList
    has been fixed.

1.0.20051.14343     09-Dec-2004
  - Internal changes
  - Charts with polar coordinate axes in one ChartGroup can no longer be
    mixed with cartesian axis charts.
  - Fixed various minor problems with properties dialog
  - Added XML help file.

1.0.20051.14326     22-Nov-2004
  - Internal changes.
  - Support of xp themes for axis scroll bars.
  - Customizable property dialog, new overloaded C1Chart.ShowProperties() method
    and corresponding flag enum PropertyPageFlags.
  - DrawLegendEntry event, color labels in legend.
  - Added Gantt chart type. 
  - Added 100% Area and Bar charts, ChartGroup.Is100Percent property.
  - Added PaintPlotArea event to allow draw on plotarea before data is plotted.

1.0.20044.14284     11-Oct-2004
  - Internal changes.
  - Corrects a problem with with XYPlots with large numbers of points (> 7500)
    using line and spline draws.

1.0.20044.14265     22-Sep-2004
  - Internal changes.

1.0.20044.14260     17-Sep-2004
  - Internal changes.
  - Internal changes made associated with possible GDI memory leaks.
  - Newly chart labels are now always created with unique names.

1.0.20044.14252     09-Sep-2004
  - Internal changes.
  - Fixed a problem with trendline when x-data and y-data have different lengths.
  - Fixed a problem with chart repainting after series deletion.
  - Fixed minor problems with wizard/property dialog

1.0.20044.14231     19-Aug-2004
  - Internal changes.
  - Added new C1Chart property, UseDoubleBuffer.
  - C1Chart now correctly responds to runtime help requests.
  - Added new members to LegendOrientationEnum including
    HorizontalVariableItemWidth and VerticalVariableItemHeight.
  - Added the new C1Chart property, UseDoubleBuffer.
  - Added the new ValueLabel property, Color.
  - Added axis scroll bars through the addition of a new class called AxisScrollBar
    and a new Axis class property called ScrollBar

1.0.20043.14175     24-Jun-2004
  - Internal changes.
  - Data values obtained through databinding now automatically take on the
    datatype of the bound column.  Previous versions did not change the
    datatype.
  - Fixed the problem with updating code error list for parametric functions.

1.0.20043.14162     11-Jun-2004
  - Internal changes.
  - Fixed problems with function engine at design time.
  - Fixed problems with updating Location and Size properties of chart elements.

1.0.20043.14144     24-May-2004
  - Internal changes
  - Added function plotting engine, FunctionList property of ChartData
    object, new classes YFunction and ParametricFunction.
  - Added point styles, PointStylesList property of ChartData object,
    new class PointStyle.
  - Added trend lines, TrendLinesList property of ChartData object,
    new class TrendLine.
  - new C1Chart event LayoutLabels which allows to reposition labels
    depending on location of other chart elements or data points.
  - Added 4 new samples that demonstrate new features: FExplorer,
    PointStyles, TrendAndError, TrendLines.
  - Adjusted positioning of axes, now more long axis annotations can be
    shown without clipping.
  - Fixed the problem with exception when Axis.Text is null(Nothing).

1.0.20042.14090     31-Mar-2004
  - Internal changes.  
  - Reset() methods now clear BackgroundImage property.
  - Fixed the problems with resource-based localization.

1.0.20042.14077     18-Mar-2004
  - Internal changes.  
  - Fixed problem with ChartDataArray objects which always returned -1 for
    IndexOf() and false for Contains() methods.
  - Fixed the problem with BackColor and ForeColor properties after Reset()
    method.
  - Internal changes to allow use of charts in IE as a rich client.
  - Fixed problem when changing from charts with OnTop true to OnTop false
    and different axis types.  Most pronounced when changing from
    Polar/Radar to Area charts.
  - Fixed problem that caused incorrect AutoMajor calculations with various
    annotation rotations.
  - Improved behavior of the data editor grid using .Net Framework 1.1.

1.0.20042.14063     04-Mar-2004
  - Internal changes.

1.0.20042.14060     01-Mar-2004
  - Adjusted some behaviors in the 2D chart properties and wizard dialogs.
  - Fixed the problem with automatic calculation of x-axis limits
    for bar chart when there is only one x-value in data.
    The bars were too thin when UnitMinor is large enough.
  - Added LogBase to axes, allowing logarithmic scales other than 10.
  - Added new samples, DataBoundChart and DataChart.
  - CopyDataIn() now accepts string arrays.  The array is used for
    ValueLabels for the appropriate axis, and simple counting values are
    used beginning with zero.
  - Added AutoEnumerate property to ChartDataSeries.  If true, the
    ChartDataSeries will automatically create enumerated data, beginning
    with zero, for the X values, if no X values have been supplied.
  - Added new 2D chart designer property and wizard dialogs.
    By default new dialogs are shown at designtime and at runtime
    when calling ShowProperties() and ShowWizard() methods without parameters.
    To show old dialogs :
    - at designtime add following key to the registry
      [HKEY_CURRENT_USER\SOFTWARE\ComponentOne\C1Chart]
      "DesignerDialogVersion"=dword:00000001
    - at runtime use new overloaded ShowProperties() and ShowWizard()
      methods with parameter DesignerDialogEnum.V1
      e.g:
        c1Chart1.ShowProperties( C1.Win.C1Chart.DesignerDialogEnum.V1)
  - Added overloaded chart methods ShowProperties(DesignerDialogEnum version)
    and ShowWizard(DesignerDialogEnum version) and corresponding
    enum DesignerDialogEnum. These methods allows to call specific version of
    designer dialogs.
  - Added LabelsCollection RemoveAll() method. This method empties the
    collection and forces a repaint.
  - Adding, removing and inserting labels into or from the LabelsCollection
    now automatically results in a repaint.
  - New 2D Chart Axes methods for manipulating the axis Min and Max values.  The
    new methods include SetMinMax(), GetMin() and GetMax().
  - 2D Chart behavior has changed when setting the Axis.Min value greater than
    Axis.Max property, or Axis.Max property less than Axis.Min property.  The
    new behavior now sets both properties, maintaining the original difference
    between the Max and Min values.
  - Bound 2D charts now load data immediately when bound to already filled
    Datasets.

1.0.20041.13346     13-Dec-2003
  - Corrected minor problems in samples.
  - Fixed the problem with general alignment of chart titles( header, footer
    and legend). There was delay in initial chart rendering when running
    under VS2003 in debug mode.
  - Added "Reset Chart" and "Reset To Default Chart" verbs to the designer.
    These verbs reset the chart to its default state.  The second verb
    restores the initial default numeric data as well.

1.0.20041.13328     25-Nov-2003
  - Internal changes.
  - Fixed the problem with 3D pie chart: the chart is not visible
    when one value corresponds full 100% chart and start angle is
    not zero.

1.0.20041.13317     14-Nov-2003
  - Internal changes.

1.0.20041.13316     13-Nov-2003
  - Internal changes.
  - Added OutlineColor and OutlineWidth properties to the ChartSymbolStyle
    object that control drawing of symbol outline.

1.0.20034.13295     23-Oct-2003
  - Internal changes.
  - Behavior of logarithmic axes has been improved.
  - Legend.ResetSizeDefault() method corrected.
  - Chart now throws an error when SaveImage requests unavailable image
    formats.
  - PrintChart method with ScaleNone now correctly prints a chart the
    same measured size as the chart on the screen.  Previously, it was
    printing according to the ScaleToFit definition.
  - Axes placement logic has been corrected so both Y axes may be placed
    with the same compass value.
  - Axes labeling has been corrected for long labels.  Wrapping is now
    handled properly in all cases.
  - Designtime handling of collection some properties and their elements
    could result in thrown errors.  These errors have been fixed.
  - Polar chart alarm zones now behave correctly when radians and pi
    fractions are used.
  - Property changed events now fire correctly.
  - Reset methods now fully reset their objects.
  - Round border behavior has been corrected.

1.0.20034.13279     7-Oct-2003
  - Internal changes.
  - A problem with loading C1Chart properties at design time when CopyLocal
    for the C1Chart dll is true, and C1Chart is also in the GAC has been
    corrected.

1.0.20034.13244     2-Sep-2003
  - Internal changes.
  - Chart and chart elements(Header, Footer, ChartArea, Legend) now can
    have border with rounded corners, added new Rounding property of
    Border object and Rounding class to control this feature.
  - C1Chart now supports data binding, see new DataSource property of C1Chart
    and DataField property of ChartDataSeries.

1.0.20033.13219     8-Aug-2003
  - Fixed problems with DrawDataSeries event when drawing legend.
  - Added Clone() method to the ChartDataSeries object that 
    creates a copy of the series without data.
  - Added SetMargins() method to the Margin object.
  - Added LegendReversed property to the ChartGroup object that
    allows to change order of series in the legend.
  - Added Reversed property to the Legend object that changes
    order of chart groups in the legend.
  - Added Tag property to ChartDataSeries object that allows to
    associate user data with the series.
  - Chart data now uses round-trip formatting during serialization.
  - Corrected data holes handling for stacked xy-charts.
  - ChartDataArray now implements IList interface.
  - ChartDataArray now supports Int16 data type.
  - Internal changes.

1.0.20033.13147     28-May-2003
  - Added C1Chart event DrawDataSeries that allows custom brushes
    for drawing data, also added demo application CustomBrushes that
    demonstrates using of this event.
  - Added runtime mouse interaction managed by new C1Chart Interaction
    object. Supported actions include rotation(only for charts with
    3D-effects), scaling, translation, zooming. Note that by default
    chart interaction is disabled(property Interaction.Enabled).
    Default action mappings:
      drag with left mouse button - rotation,
      shift + drag with left mouse button - translation,
      control + drag with left mouse button - scale,
      alt + drag with left mouse button mouse - zoom.
    Added C1Chart event Transform that fires when interactive action
    occurs. This event allows user to control action behaviour.
  - Added new demos CandyBox, CpuUsage, DiskSapce, Interview, StockChart.
  - Fixed a bug in ChartGroup.DataIndexToRect() method that returns
    empty rectangle when part of bar is beyond plotarea.
  - Added AutoOrigin and Origin properties to the Axis object, 
    axes now can be placed inside the plotarea.
  - Fixed a bug that caused exception when logarithmic axis has time
    annotation formatting.
  - Fixed a bug that caused exception under several conditions
    when chart label has Orthogonal/Radial compassing.
  - Fixed a bug with axis positioning when there are no labels on axis
    (axis property TickLabels = TickLabelsEnum.None).
  - Added Visible property to the ChartGroup object.
  - Corrected bug causing exceptions when constructing series prior to
    adding to the series collection.
  - Corrected behavior for charts with 3D-effects when data is clipping
    by axis limits.
  - Fixed a bug with axes positioning when switching from polar or radar
    chart to the chart with cartesian axes.

1.0.20032.13071     13-Mar-2003
  - Corrected a bug which could lead to an exception when setting an
    axis maximum value under certain conditions.
  - Internal changes.

1.0.20032.13070     12-Mar-2003
  - Added a boolean LegendEntry property to the ChartDataSeries object,
    which is true by default.  If the LegendEntry is false, then the
    series is not listed in the Legend.
  - Duplicate series names now appear correctly in the legend.
  - Series Display properties now persist correctly.
  - Data lines and gridlines are now appearing properly at the extremities
    of the plot area.  Previously, some were occasionally clipped.
  - Internal changes.

1.0.20032.13063     5-Mar-2003
  - Added ChartGroup Use3D property to control 3D effects applying
    to the group.
  - Added 3D effects to the XYPlot("ribbon chart") and Area chart.
  - Added logarithmic scale, axis property IsLogarithmic.
  - Added text wrapping for headers, footers, axes.  Legend header and
    labels will also wrap, but require manual sizing, as default sizing
    assumes a single line.  A new style property named Autowrap (default
    is true) controls the automatic wrapping.
  - Added horizontal legend orientation, legend property Orientation and
    corresponding enum LegendOrientationEnum.
  - Modified Axis behavior so it manages time annotations better based
    upon the chosen Axis AnnoFormat property.  Also, choosing DateManual
    format, and setting AnnoFormatString to an empty string now provides
    appropriate annotation formatting for the timespan of the axis.
  - The PlotArea and Axes are no longer extended to accommodate large
    annotations.  Instead, the PlotArea is reduced and the large annotations
    extend into a ChartArea without changing the axes limits.  Note that
    this may require changes to code that adjust the ChartArea and PlotArea
    locations and size.
  - Internal changes.

1.0.20031.23161     16-Jan-2003
  - Added readonly properties AssemblyFileVersionString and
    AssemblyVersionString to chart.  These properties return strings
    indicating version information of the chart.
  - Modified internal serialization to speed up serialization of large
    datasets.
  - Internal changes.

1.0.20031.23081     8-Jan-2003
  - Corrected problem with automatic line and symbol colors that could
    result in an infinite loop (internal) when a data series is added
    to the data series collection.
  - Corrected problem with improper positioning of Axis annotations when
    printing.
  - Automatic Line and Symbol colors are now generated so they do not
    match the PlotArea background.
  - Internal changes.

1.0.20031.22041     4-Jan-2003
  - Added 3D affects for Bar and Pie charts through the use
    of the new View3D property/object of the 2D chart PlotArea.
  - Changed internal data storage from float (Single) to double (Double) to
    allow processing of a wide range of numbers and proper scaling for
    dates.  Also, a large number of exposed data related properties have also
    changed from float (Single) to double (Double), including data holes,
    Axis min and max values, etc.
  - Internal changes.

1.0.20024.22161     16-Dec-2002
  - Corrected problem with zero width or zero height image
    generation that caused an exception.

1.0.20024.22031     3-Dec-2002
  - Fixed bug with Charts licensing associated user controls
    inheritting directly from the chart controls.
  - Fixed bug with Charts licensing associated with running
    the chart wizard/properties dialogs from a user control.
  - Internal changes.

1.0.20024.21181     18-Nov-2002
  - Fixed bug with Charts licensing associated with VB usercontrols.
  - Fixed bug with 2D chart which sometimes resulted in a collapsed or
    "squished" plot area.
  - Fixed bug with 2D chart hi-low-open-close and candle charts that
    resulted in no symbol at all when all Y point values are the same.
  - Fixed bug with 2D chart problem associated with a single data point
  - Fixed bug with 2D chart Bar charts where under certain conditions the
    bar cluster at the axis extremes are clipped.
  - Chart2D autoscaling now forces max and min axes values to be a multiple
    of UnitMajor.
  - Internal changes.

1.0.20024.20151     15-Oct-2002
  - Added background hatching and color gradients.
  - Internal changes.

1.0.20024.19041     4-Sep-2002
  - Adjusted clipping region of XYPlot and Area charts to include
    extreme points (min or max of the axis).
  - Internal changes.

1.0.20024.18281     28-Aug-2002
  - Added boolean Repaint property.  When set to false, most automatic repaints
    of the chart during property changes are inhibited.  When set to true,
    forces an immediate repaint of the chart and allows automatic repaints
    with property changes.
  - Internal changes.

1.0.20023.17191 - 19-Jul-02
  - Internal changes.
  - Fixed bug causing exception when axis width/length approproached zero.
  - Fixed bug that plotted lines and symbols outside the plot area.
  - Fixed bug that reported data indicies outside of the plot area.

1.0.20023.16051 - 05-June-02 
  - Added support of C1.C1PrintDocument.ControlPrinters.IC1ControlPrintable
    interface for using with C1PrintDocument.


<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>
C1Chart3D.Net is the 3D Componentone Chart for .Net
C1Chart3D.Net Maintenance log:

======================================================================================
C1Chart3D.Net Build Number 4.0.20142.24286   Build Date: Tuesday, October 14, 2014
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
* Applied modified contour calculations to ContourData as well as Elevation data when
    calculating contours. (TFS-90816)


======================================================================================
C1Chart3D.Net Build Number 4.0.20142.24247   Build Date: Friday, September 5, 2014
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added Japanese, Korean and Chinese localizations for the ContourMethod
  propery description and Save Chart Template and Load Chart Template verbs.
* Added 14 significant digit rounding to axis min/max calculations due to
  .NET handling of doubles.  This provideds improved axis limit annotations.

Corrections
-----------
none



====================================================================================
C1Chart3D.Net Build Number 4.0.20142.24182   Build Date: Wednesday, July 2, 2014
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added new contouring method (Marching Squares) to release version for
  testing.  To enable the marching squares contouring method, change the
  new property, C1.Win.C1Chart3D.Chart3DContour.ContourMethod property
  from Default to MarchingSquares.

  Documentation changes include the addition of the ContourMethodEnum enum
  and the addition of the property:

  public enum C1.Win.C1Chart3D.ContourMethodEnum
  {
      /// <summary>
      /// Default method of contour calculation.
      /// </summary>
      Default,

      /// <summary>
      /// Method of marching squares that provides an alternate contour calculation.
      /// This method requires an increased number of calculations, but tends to
      /// improve contour symmetry. 
      /// </summary>
      MarchingSquares
  }

  New property for class C1.Win.C1Chart3D.Chart3DContour:

  public ContourMethodEnum ContourMethod

     Gets or sets the contour calculation method.
     DefaultValue = ContourMethodEnum.Default


Corrections
-----------
none



=================================================================================
C1Chart3D.Net Build Number 4.0.20142.24177   Build Date: Friday, Jun 27, 2014
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Modified Legend.FormatString behavior such that a leading minus sign
  left justifies the numberic strings.  Otherwise the behavior is to left
  pad with blanks necessary to align decimal points.

* Added of saving and loading chart templates.  Chart templates are similar
  to chart descriptions, but do not store or reset data upon loading.  The
  new method prototypes include:

      void SaveChartTemplateToFile(string Filename);
      string templateString = SaveChartTemplateToString();
      string templateString = SaveChartTemplateToString(bool formatting);

      void LoadChartTemplateFromFile(string Filename);
      void LoadChartTemplateFromString(string templateString);

  Documentation should include the new methods.


Corrections
-----------
none



================================================================================
C1Chart3D.Net Build Number 4.0.20141.24156   Build Date: Friday, Jun 6, 2014
================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
none


Corrections
-----------
none



=================================================================================
C1Chart3D.Net Build Number 4.0.20141.24135   Build Date: Friday, May 16, 2014
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



====================================================================================
C1Chart3D.Net Build Number 4.0.20141.24092   Build Date: Thursday, April 3, 2014
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* The chart now always translates it coordinate system to use internal
  coordinates when invoking the chart Draw method.  This is necessary
  to correctly draw chart elements with specific values.



Corrections
-----------
none



===================================================================================
C1Chart3D.Net Build Number 4.0.20141.24071   Build Date: Thursday, March 13, 2014
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
none



======================================================================================
C1Chart3D.Net Build Number 4.0.20141.24070   Build Date: Wednesday, March 12, 2014
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added Chinese and Korean localizations for FormatString and Separator properties.



Corrections
-----------
none



===================================================================================
C1Chart3D.Net Build Number 4.0.20141.24062   Build Date: Tuesday, March 4, 2014
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added FormatString and Separator properties to the Legend object.



Corrections
-----------
* Chart data is now shown in chart area of C1Chart3D when a new instance
  is added to an existing Themed form.



=========================================================================================
C1Chart3D.Net Build Number 4.0.20141.24056   Build Date: Wednesday, February 26, 2014
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



======================================================================================
C1Chart3D.Net Build Number 4.0.20141.24051   Build Date: Friday, February 21, 2014
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added fully qualified design assembly name for 4x DesignerAttribute.


Corrections
-----------
none



========================================================================================
C1Chart3D.Net Build Number 4.0.20141.24050   Build Date: Thursday, February 20, 2014
========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added license support for Studio for Desktop


Corrections
-----------
none



=========================================================================================
C1Chart3D.Net Build Number 4.0.20141.24049   Build Date: Wednesday, February 19, 2014
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Adjustments for C1ThemeController.


Corrections
-----------
none



=======================================================================================
C1Chart3D.Net Build Number 4.0.20141.24048   Build Date: Tuesday, February 18, 2014
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added support for C1ThemeController.


Corrections
-----------
none



======================================================================================
C1Chart3D.Net Build Number 4.0.20141.24047   Build Date: Monday, February 17, 2014
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



========================================================================================
C1Chart3D.Net Build Number 4.0.20141.24035   Build Date: Wednesday, February 5, 2014
========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



========================================================================================
C1Chart3D.Net Build Number 4.0.20133.24035   Build Date: Wednesday, February 5, 2014
========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Removed Marching Squares contouring method, enum and associated
  properties.


Corrections
-----------
none



======================================================================================
C1Chart3D.Net Build Number 4.0.20141.24034   Build Date: Tuesday, February 4, 2014
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 4.0.20133.24030   Build Date: Friday, January 31, 2014
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* The rounding parameters in the border style dialogs (previous) can now
  be set above a value of 20.

Corrections
-----------
none



========================================================================================
C1Chart3D.Net Build Number 4.0.20133.24028   Build Date: Wednesday, January 29, 2014
========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Additional adjustments to the new contouring method (Marching Squares).


Corrections
-----------
none



======================================================================================
C1Chart3D.Net Build Number 4.0.20133.24027   Build Date: Tuesday, January 28, 2014
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added new contouring method (Marching Squares).


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 4.0.20133.24019   Build Date: Monday, January 20, 2014
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 4.0.20133.24012   Build Date: Monday, January 13, 2014
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Further adjusted tesselation conditions to improve contouring in symmetrictal and
  negative valued elevations.



=====================================================================================
C1Chart3D.Net Build Number 4.0.20133.24009   Build Date: Friday, January 10, 2014
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



======================================================================================
C1Chart3D.Net Build Number 4.0.20133.24008   Build Date: Thursday, January 9, 2014
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=======================================================================================
C1Chart3D.Net Build Number 4.0.20133.24007   Build Date: Wednesday, January 8, 2014
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



====================================================================================
C1Chart3D.Net Build Number 4.0.20133.24002   Build Date: Friday, January 3, 2014
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



======================================================================================
C1Chart3D.Net Build Number 4.0.20133.24001   Build Date: Thursday, January 2, 2014
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=======================================================================================
C1Chart3D.Net Build Number 4.0.20133.23350   Build Date: Tuesday, December 17, 2013
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



======================================================================================
C1Chart3D.Net Build Number 4.0.20133.23345   Build Date: Friday, December 12, 2013
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 4.0.20133.23339   Build Date: Friday, December 6, 2013
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Changed order of tesselation depending upon z-values (TFS 41341, 42523), while
  maintaining proper drawing of column and row mesh lines (TFS 43899).


Corrections
-----------
none



=======================================================================================
C1Chart.Net Build Number 4.0.20133.23332   Build Date: Friday, November 29, 2013
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=========================================================================================
C1Chart3D.Net Build Number 4.0.20133.23330   Build Date: Wednesday, November 27, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=======================================================================================
C1Chart3D.Net Build Number 4.0.20133.23329   Build Date: Tuesday, November 26, 2013
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=========================================================================================
C1Chart3D.Net Build Number 4.0.20133.23316   Build Date: Wednesday, November 13, 2013
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Remove incomplete support for C1ThemeController.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 4.0.20133.23290   Build Date: Friday, October 18, 2013
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Removed changed order of tesselation depending upon z-values. (TFS 41341).


Corrections
-----------
none



=======================================================================================
C1Chart3D.Net Build Number 4.0.20133.23289   Build Date: Thursday, October 17, 2013
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added basic support for C1ThemeController.


Corrections
-----------
none



======================================================================================
C1Chart3D.Net Build Number 4.0.20133.23287   Build Date: Tuesday, October 15, 2013
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=======================================================================================
C1Chart3D.Net Build Number 4.0.20132.23282   Build Date: Thursday, October 10, 2013
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Changed order of tesselation depending upon z-values. (TFS 41341).


Corrections
-----------
none



=======================================================================================
C1Chart3D.Net Build Number 4.0.20132.23225   Build Date: Wednesday, August 14, 2013
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Obfuscation adjusted to compensate for bug in VC++ compiler.


Corrections
-----------
none



==================================================================================
C1Chart3D.Net Build Number 4.0.20132.23192   Build Date: Friday, July 12, 2013
==================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Handling of extreme data involving near zero values in legend
  calculations has been improved.


=================================================================================
C1Chart3D.Net Build Number 4.0.20132.23171   Build Date: Friday, Jun 21, 2013
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=================================================================================
C1Chart3D.Net Build Number 4.0.20132.23164   Build Date: Friday, Jun 14, 2013
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=================================================================================
C1Chart3D.Net Build Number 4.0.20132.23154   Build Date: Tuesday, Jun 4, 2013
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Updated GrapeCity JPN AboutBox URLs.


Corrections
-----------
none



==================================================================================
C1Chart3D.Net Build Number 4.0.20131.23121   Build Date: Thursday, May 2, 2013
==================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Minor internal double buffering changes.

Corrections
-----------
* Changing chart types while double buffered now correctly repaints the
  chart display in all cases.


===================================================================================
C1Chart3D.Net Build Number 4.0.20131.23091   Build Date: Tuesday, April 2, 2013
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Implemented additional GrapeCity licensing model changes for JPN builds.


Corrections
-----------
none



==================================================================================
C1Chart3D.Net Build Number 4.0.20131.23090   Build Date: Monday, April 1, 2013
==================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
* The AboutBox evaluation notice has been corrected.



===================================================================================
C1Chart3D.Net Build Number 4.0.20131.23087   Build Date: Friday, March 29, 2013
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Implemented new GrapeCity licensing model for JPN builds.


Corrections
-----------
none



===================================================================================
C1Chart3D.Net Build Number 4.0.20131.23069   Build Date: Monday, March 11, 2013
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



====================================================================================
C1Chart3D.Net Build Number 4.0.20131.23065   Build Date: Thursday, March 7, 2013
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 4.0.20131.23064   Build Date: Wednesday, March 6, 2013
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



======================================================================================
C1Chart3D.Net Build Number 4.0.20131.23041   Build Date: Monday, February 11, 2013
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Internal legend data is now cleared when all series are removed.


Corrections
-----------
none



=======================================================================================
C1Chart3D.Net Build Number 4.0.20131.23037   Build Date: Thursday, February 7, 2013
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



========================================================================================
C1Chart3D.Net Build Number 4.0.20131.23036   Build Date: Wednesday, February 6, 2013
========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=======================================================================================
C1Chart3D.Net Build Number 4.0.20131.23030   Build Date: Thursday, January 31, 2013
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Double buffering at design time no longer causes excessive flicker.



=====================================================================================
C1Chart3D.Net Build Number 4.0.20131.23027   Build Date: Monday, January 28, 2013
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 4.0.20131.23017   Build Date: Friday, January 18, 2013
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 4.0.20123.23010   Build Date: Friday, January 11, 2013
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Axis tick marks are now only drawn for axes specified by the Axis.AnnoPosition property.
* Designer "About" verbs have removed ComponentOne from the display text.


Corrections
-----------
none



=======================================================================================
C1Chart3D.Net Build Number 4.0.20123.22305   Build Date: Thursday, November 1, 2012
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



========================================================================================
C1Chart3D.Net Build Number 4.0.20123.22304   Build Date: Wednesday, October 31, 2012
========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Improved printer scaling logic.



=====================================================================================
C1Chart3D.Net Build Number 4.0.20123.22303   Build Date: Monday, October 30, 2012
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 4.0.20123.22299   Build Date: Friday, October 26, 2012
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=======================================================================================
C1Chart3D.Net Build Number 4.0.20123.22298   Build Date: Thursday, October 25, 2012
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* The Localization basis is now CurrentUICulture instead of CurrentCulture.


Corrections
-----------
* Contour level properties are now correctly persisted.  This was a
  problem due to changes beginning with build version 22221.



========================================================================================
C1Chart3D.Net Build Number 4.0.20123.22283   Build Date: Wednesday, October 10, 2012
========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



========================================================================================
C1Chart3D.Net Build Number 4.0.20122.22283   Build Date: Wednesday, October 10, 2012
========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Corrected language codes for Chinese (zh) and Korean (ko).



=====================================================================================
C1Chart3D.Net Build Number 4.0.20122.22282   Build Date: Tuesday, October 9, 2012
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added localizations for Chinese and Korean.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 4.0.20122.22227   Build Date: Tuesday, August 14, 2012
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Adjustment to VS2012 toolbox bitmap logic.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 4.0.20122.22226   Build Date: Tuesday, August 14, 2012
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Adjustment to VS2012 toolbox bitmap logic.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 4.0.20122.22221   Build Date: Thursday, August 9, 2012
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* ContourStyle colors now interpolate color alpha characteristics as well
  as color.
* Updated VS2012 toolbox bitmap.
* Excluded ActionEnum from the documentation as this enum is for internal
  use only.

Corrections
-----------
* ContourStyle colors are now updated when colors are added to or removed
  from the ContourStyle.Colors collection.


=====================================================================================
C1Chart3D.Net Build Number 4.0.20122.22206   Build Date: Wednesday, July 25, 2012
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Logic has been added for VS2012 toolbox bitmaps.


Corrections
-----------
* Scatter charts now correctly omit points with hole values.



=================================================================================
C1Chart3D.Net Build Number 4.0.20122.22187   Build Date: Friday, July 6, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



===================================================================================
C1Chart3D.Net Build Number 4.0.20122.22186   Build Date: Thursday, July 5, 2012
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



==================================================================================
C1Chart3D.Net Build Number 4.0.20122.22184   Build Date: Tuesday, July 3, 2012
==================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Updated copyright messages.


Corrections
-----------
none



=================================================================================
C1Chart3D.Net Build Number 4.0.20122.22162   Build Date: Monday, Jun 11, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



===================================================================================
C1Chart3D.Net Build Number 4.0.20122.22157   Build Date: Wednesday, Jun 6, 2012
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* The chart designer form font has been changed for JPN WebChart builds.
  The new font allows designer controls to properly display their text.
* "NaN" is now accepted in the chart Properties/Wizard dialog data table
  for a (hole) value in JPN Chart builds.


Corrections
-----------
none



=================================================================================
C1Chart3D.Net Build Number 4.0.20122.22156   Build Date: Tuesday, Jun 5, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* The chart StyleChanged event now fires when the Style for the control
  changes.  This event does not fire when other chart element styles are
  changed.  Use the ChartChanged event for other styles.


Corrections
-----------
none



================================================================================
C1Chart3D.Net Build Number 4.0.20122.22155   Build Date: Monday, Jun 4, 2012
================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=================================================================================
C1Chart3D.Net Build Number 4.0.20122.22145   Build Date: Friday, May 25, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



====================================================================================
C1Chart3D.Net Build Number 4.0.20122.22143   Build Date: Wednesday, May 23, 2012
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* BorderStyleEnum.Opaque no longer reduces the chart area size when
  Rounding is non-zero.



==================================================================================
C1Chart3D.Net Build Number 4.0.20122.22142   Build Date: Tuesday, May 22, 2012
==================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  Same as previous build, except for version number.


Corrections
-----------
none



==================================================================================
C1Chart3D.Net Build Number 4.0.20121.22142   Build Date: Tuesday, May 22, 2012
==================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* A new border style (BorderStyleEnum.Opaque) has been added.  The new
  border style ensures that anti-aliasing is turned off when drawing the
  border.  Opaque borders ignore Rounding settings.  This border style can
  be useful for generating chart images to be use with transparent
  backgrounds.


Corrections
-----------
none



====================================================================================
C1Chart3D.Net Build Number 4.0.20121.22136   Build Date: Wednesday, May 16, 2012
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



===================================================================================
C1Chart3D.Net Build Number 4.0.20121.22129   Build Date: Wednesday, May 9, 2012
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Restored the GotFocus event.  Please note that the GotFocus and
  LostFocus events are no longer recommended for usage by Microsoft - use
  the Enter and Leave events instead.


=================================================================================
C1Chart3D.Net Build Number 4.0.20121.22121   Build Date: Tuesday, May 1, 2012
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



======================================================================================
C1Chart3D.Net Build Number 4.0.20121.22115   Build Date: Wednesday, April 25, 2012
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



===================================================================================
C1Chart3D.Net Build Number 4.0.20121.22110   Build Date: Friday, April 20, 2012
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
none



====================================================================================
C1Chart3D.Net Build Number 4.0.20121.22100   Build Date: Tuesday, April 10, 2012
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added a DescriptionAttribute for the C1Chart3D control class.


Corrections
-----------
* Axis Min and Max values are automatically adjusted if both are zero.
* MetaFile images can now be saved to the clipboard in all scenarios.



=====================================================================================
C1Chart3D.Net Build Number 2.0.20121.22036   Build Date: Monday, February 6, 2012
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 2.0.20121.22035   Build Date: Sunday, February 5, 2012
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



======================================================================================
C1Chart3D.Net Build Number 2.0.20121.22030   Build Date: Tuesday, January 31, 2012
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



======================================================================================
C1Chart3D.Net Build Number 2.0.20113.22030   Build Date: Tuesday, January 31, 2012
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Adjusted axis automatic Min/Max calculations to eliminate exceptions in some cases.


======================================================================================
C1Chart3D.Net Build Number 2.0.20113.21345   Build Date: Monday, December 12, 2011
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=======================================================================================
C1Chart3D.Net Build Number 2.0.20113.21334   Build Date: Thursday, December 1, 2011
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Updated licensing to conform with Federal Information Processing
  Standards requirements. (Tfs-18562)


Corrections
-----------
none



========================================================================================
C1Chart3D.Net Build Number 2.0.20113.21313   Build Date: Thursday, November 10, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 2.0.20113.21296   Build Date: Monday, October 24, 2011
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 2.0.20113.21286   Build Date: Friday, October 14, 2011
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Absolute Location and Size of chart elements are now adjusted along with
  chart size during printing operations.



=====================================================================================
C1Chart3D.Net Build Number 2.0.20113.21276   Build Date: Tuesday, October 4, 2011
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Licensing update for FIPS compliance.    (TFS-17615,TFS-18460,TFS-18562)

Corrections
-----------
none



==========================================================================================
C1Chart3D.Net Build Number 2.0.20113.21263   Build Date: Wednesday, September 21, 2011
==========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=======================================================================================
C1Chart3D.Net Build Number 2.0.20113.21253   Build Date: Sunday, September 11, 2011
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


========================================================================================
C1Chart3D.Net Build Number 2.0.20112.21250   Build Date: Thursday, September 8, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=========================================================================================
C1Chart3D.Net Build Number 2.0.20112.21249   Build Date: Wednesday, September 7, 2011
=========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Automatic axis min and max values calculations have been improved when
  handling extreme values.

Corrections
-----------
none



========================================================================================
C1Chart3D.Net Build Number 2.0.20112.21243   Build Date: Thursday, September 1, 2011
========================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



====================================================================================
C1Chart3D.Net Build Number 2.0.20112.21240   Build Date: Monday, August 29, 2011
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



======================================================================================
C1Chart3D.Net Build Number 2.0.20112.21236   Build Date: Thursday, August 25, 2011
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=======================================================================================
C1Chart3D.Net Build Number 2.0.20112.21228   Build Date: Wednesday, August 17, 2011
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=======================================================================================
C1Chart3D.Net Build Number 2.0.20112.21221   Build Date: Wednesday, August 10, 2011
=======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Chart3D has improved handling of extreme floating point numbers.


Corrections
-----------
none



======================================================================================
C1Chart3D.Net Build Number 2.0.20112.21214   Build Date: Wednesday, August 3, 2011
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=================================================================================
C1Chart3D.Net Build Number 2.0.20112.21181   Build Date: Friday, July 1, 2011
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



===================================================================================
C1Chart3D.Net Build Number 2.0.20112.21173   Build Date: Thursday, Jun 23, 2011
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=================================================================================
C1Chart3D.Net Build Number 2.0.20112.21170   Build Date: Monday, Jun 20, 2011
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* The chart.PrintChart() overloads now print items drawn in the Paint event.



=================================================================================
C1Chart3D.Net Build Number 2.0.20112.21167   Build Date: Friday, Jun 17, 2011
=================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



===================================================================================
C1Chart3D.Net Build Number 2.0.20112.21131   Build Date: Thursday, May 12, 2011
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



==================================================================================
C1Chart3D.Net Build Number 2.0.20112.21129   Build Date: Tuesday, May 10, 2011
==================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 2.0.20111.21119   Build Date: Saturday, April 30, 2011
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



======================================================================================
C1Chart3D.Net Build Number 2.0.20111.21116   Build Date: Wednesday, April 27, 2011
======================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



====================================================================================
C1Chart3D.Net Build Number 2.0.20111.21108   Build Date: Tuesday, April 19, 2011
====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Removed icons from headers in designer forms.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 2.0.20111.21089   Build Date: Thursday, March 31, 2011
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



=====================================================================================
C1Chart3D.Net Build Number 2.0.20111.21084   Build Date: Saturday, March 26, 2011
=====================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none



===================================================================================
C1Chart3D.Net Build Number 2.0.20111.21083   Build Date: Friday, March 25, 2011
===================================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added explicit reference to 4x designer.  This improves behavior when multiple
  versions of the Chart are installed on the same machine.


Corrections
-----------
none



=================================================================================
C1Chart3D.Net Build Number 2.0.20111.21027   Build Date: Friday, January 28, 2011
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
   

Corrections
-----------
* Corrected Xml documentation file for SaveLocalizations(byte[] byteArray)
  and LoadLocalizations(byte[] byteArray).


===================================================================================
C1Chart3D.Net Build Number 2.0.20111.21012   Build Date: Thursday, January 13, 2011
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* LoadLocalization() overloads can now reset the localization to its default
  state by passing a null argument.


Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 2.0.20111.21006   Build Date: Friday, January 7, 2011
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Chart dialogs can now be maximized.


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 2.0.20111.21005   Build Date: Thursday, January 6, 2011
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 2.0.20111.21004   Build Date: Wednesday, January 5, 2011
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added runtime user localizations by introducing SaveLocalizations() and
  LoadLocalizations() methods.  This overloaded methods save and load XML
  translation tables, respectively, that translate internal strings at
  runtime.
* The chart property and chart wizard dialogs can now be resized.


Corrections
-----------
none


====================================================================================
C1Chart3D.Net Build Number 2.0.20103.20356   Build Date: Thursday, December 23, 2010
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Surface chart legend drawing no longer incorrectly honors the LineStyle.Thickness
  property.


==================================================================================
C1Chart3D.Net Build Number 2.0.20103.20346   Build Date: Monday, December 13, 2010
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


====================================================================================
C1Chart3D.Net Build Number 2.0.20103.20251   Build Date: Thursday, September 9, 2010
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=====================================================================================
C1Chart3D.Net Build Number 2.0.20103.20250   Build Date: Wednesday, September 8, 2010
=====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 2.0.20103.20245   Build Date: Friday, September 3, 2010
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


====================================================================================
C1Chart3D.Net Build Number 2.0.20102.20244   Build Date: Thursday, September 2, 2010
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 2.0.20102.20187   Build Date: Wednesday, July 7, 2010
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Changing to PointData at runtime no longer results in an exception in
  some circumstances.


================================================================================
C1Chart3D.Net Build Number 2.0.20102.20166   Build Date: Wednesday, Jun 16, 2010
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===============================================================================
C1Chart3D.Net Build Number 2.0.20101.20159   Build Date: Wednesday, Jun 9, 2010
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


============================================================================
C1Chart3D.Net Build Number 2.0.20101.20157   Build Date: Monday, Jun 7, 2010
============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* The Chart3D now rotates on its axes in a consistent manner at design
  time and runtime.


================================================================================
C1Chart3D.Net Build Number 2.0.20101.20145   Build Date: Wednesday, May 26, 2010
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=============================================================================
C1Chart3D.Net Build Number 2.0.20101.20143   Build Date: Monday, May 24, 2010
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=============================================================================
C1Chart3D.Net Build Number 2.0.20101.20136   Build Date: Monday, May 17, 2010
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===============================================================================
C1Chart3D.Net Build Number 2.0.20101.20132   Build Date: Thursday, May 13, 2010
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 2.0.20101.20131   Build Date: Wednesday, May 12, 2010
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Finalizing 4.0 version port.


Corrections
-----------
none


===============================================================================
C1Chart3D.Net Build Number 2.0.20101.20119   Build Date: Friday, April 30, 2010
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* 4.0 version has designer split into separate assembly for 4.0 Client Mode.



Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20101.20096   Build Date: Wednesday, April 7, 2010
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 2.0.20101.20089   Build Date: Wednesday, March 31, 2010
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 2.0.20101.20062   Build Date: Thursday, March 4, 2010
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===============================================================================
C1Chart3D.Net Build Number 2.0.20101.20060   Build Date: Tuesday, March 2, 2010
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 2.0.20101.20053   Build Date: Tuesday, February 23, 2010
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


====================================================================================
C1Chart3D.Net Build Number 2.0.20101.20048   Build Date: Thursday, February 18, 2010
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20101.20037   Build Date: Sunday, February 7, 2010
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


====================================================================================
C1Chart3D.Net Build Number 2.0.20101.20033   Build Date: Wednesday, February 3, 2010
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20101.20021   Build Date: Friday, January 22, 2010
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20101.20014   Build Date: Friday, January 15, 2010
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Modified licensing requirements for Visual Studio 2010.


Corrections
-----------
none


====================================================================================
C1Chart3D.Net Build Number 2.0.20093.19364   Build Date: Thursday, December 31, 2009
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Modified style persistence such that the attribute order is consistent.


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 2.0.20093.19362   Build Date: Tuesday, December 29, 2009
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* AboutBox truncations in GrapeCity builds have been eliminated.


=====================================================================================
C1Chart3D.Net Build Number 2.0.20093.19356   Build Date: Wednesday, December 23, 2009
=====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* Attempting to open and write to a data file that was previously loaded
  in Chart7 format no longer results in a file in use error.


====================================================================================
C1Chart3D.Net Build Number 2.0.20093.19342   Build Date: Wednesday, December 9, 2009
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20093.19337   Build Date: Friday, December 4, 2009
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 2.0.20093.19336   Build Date: Thursday, December 3, 2009
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
* Chart3DData.SaveDataToFile() method now saves data correctly in old
  data format(Chart7).
* Text in wizard dialog now is not cut when windows fonts are large.




====================================================================================
C1Chart3D.Net Build Number 2.0.20093.19335   Build Date: Wednesday, December 2, 2009
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
none


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 2.0.20093.19334   Build Date: Tuesday, December 1, 2009
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 2.0.20093.19333   Build Date: Monday, November 30, 2009
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added Japanese localization adjustments.


Corrections
-----------
* Fixed the problem with setting Chart3DView.View3D(introduced in 19332).


==================================================================================
C1Chart3D.Net Build Number 2.0.20093.19332   Build Date: Sunday, November 29, 2009
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Fixed the problem with applying rotation properties(Chart3DView.RotationX/Y/Z)
  to the 3D chart.
* Fixed the problem with 3D chart appearance with small values of 
  Chart3DView.XScale/YScale.


====================================================================================
C1Chart3D.Net Build Number 2.0.20093.19329   Build Date: Thursday, November 26, 2009
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* GrapeCity licensing now correct.


=====================================================================================
C1Chart3D.Net Build Number 2.0.20093.19328   Build Date: Wednesday, November 25, 2009
=====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
none


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 2.0.20093.19310   Build Date: Saturday, November 7, 2009
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Internal licensing changes.


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 2.0.20093.19301   Build Date: Thursday, October 29, 2009
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Added new GrapeCity license codes for JPN version.


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20093.19298   Build Date: Monday, October 26, 2009
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* Chart.Print now properly displays the PrintDialog during 64 bit
  execution.


=================================================================================
C1Chart3D.Net Build Number 2.0.20093.19284   Build Date: Monday, October 12, 2009
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


======================================================================================
C1Chart3D.Net Build Number 2.0.20093.19272   Build Date: Wednesday, September 30, 2009
======================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 2.0.20093.19267   Build Date: Friday, September 25, 2009
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


======================================================================================
C1Chart3D.Net Build Number 2.0.20093.19265   Build Date: Wednesday, September 23, 2009
======================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


======================================================================================
C1Chart3D.Net Build Number 2.0.20093.19258   Build Date: Wednesday, September 16, 2009
======================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 2.0.20093.19256   Build Date: Monday, September 14, 2009
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Honors C1Olap licensing.
* Improved loading capability of chart3dxml files.


Corrections
-----------
none


===============================================================================
C1Chart3D.Net Build Number 2.0.20092.19168   Build Date: Thursday, Jun 18, 2009
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


===============================================================================
C1Chart3D.Net Build Number 2.0.20092.19161   Build Date: Thursday, Jun 11, 2009
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* Adjusted obfuscation for licensing.


================================================================================
C1Chart3D.Net Build Number 2.0.20092.19160   Build Date: Wednesday, Jun 10, 2009
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* Adjusted obfuscation for licensing.


=============================================================================
C1Chart3D.Net Build Number 2.0.20092.19152   Build Date: Tuesday, Jun 2, 2009
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* New Licensing and AboutBox code.


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 2.0.20091.19053   Build Date: Monday, February 23, 2009
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Added VerticalText to Styled Chart3d elements.


Corrections
-----------
none

==================================================================================
C1Chart3D.Net Build Number 2.0.20091.19043   Build Date: Friday, February 13, 2009
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20091.19032   Build Date: Monday, February 2, 2009
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 2.0.20091.19030   Build Date: Saturday, January 31, 2009
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* Bad build, do not use



==================================================================================
C1Chart3D.Net Build Number 2.0.20091.19026   Build Date: Tuesday, January 27, 2009
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20091.19015   Build Date: Friday, January 16, 2009
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 2.0.20083.19012   Build Date: Tuesday, January 13, 2009
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20083.19011   Build Date: Monday, January 12, 2009
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Design time environment chart designer operations are now suppressed
  when running in the IDE.  Previously some attempts at changing the chart
  properties could result in an unhandled exception.

Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20083.19011   Build Date: Monday, January 12, 2009
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 2.0.20091.19006   Build Date: Wednesday, January 7, 2009
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20083.19005   Build Date: Tuesday, January 6, 2009
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 2.0.20083.18353   Build Date: Friday, December 19, 2008
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20083.18335   Build Date: Monday, December 1, 2008
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Adjustments for MediumTrust situations.


Corrections
-----------
* Chart3D data files (*.dat) from ActiveX charts now read correctly for
  irregular grids.


==================================================================================
C1Chart3D.Net Build Number 2.0.20083.18325   Build Date: Friday, November 21, 2008
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Adjustments for MediumTrust situations.


Corrections
-----------
none


=====================================================================================
C1Chart3D.Net Build Number 2.0.20083.18323   Build Date: Wednesday, November 19, 2008
=====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes
* Adjustments for MediumTrust situations.


Corrections
-----------
none


=====================================================================================
C1Chart3D.Net Build Number 2.0.20083.18323   Build Date: Wednesday, November 19, 2008
=====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
none


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20083.18297   Build Date: Friday, October 24, 2008
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
none


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 2.0.20083.18296   Build Date: Thursday, October 23, 2008
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
none


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 2.0.20083.18294   Build Date: Tuesday, October 21, 2008
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* The LabelCollection editor dialogs now correctly handle and persist
  property assignments for collection elements.  This was a error
  resulting from changes in build 2.0.20083.18265.

===================================================================================
C1Chart3D.Net Build Number 2.0.20083.18265   Build Date: Monday, September 22, 2008
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
* Memory leaks associated with LabelsCollection.Clear() have been corrected.


==================================================================================
C1Chart3D.Net Build Number 2.0.20083.18248   Build Date: Friday, September 5, 2008
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20083.18238   Build Date: Tuesday, August 26, 2008
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 2.0.20083.18237   Build Date: Monday, August 25, 2008
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 2.0.20082.18237   Build Date: Monday, August 25, 2008
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
none


Corrections
-----------
* Internal changes


==============================================================================
C1Chart3D.Net Build Number 2.0.20082.18192   Build Date: Friday, July 11, 2008
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


==============================================================================
C1Chart3D.Net Build Number 2.0.20082.18140   Build Date: Tuesday, May 20, 2008
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes

Corrections
-----------
* Headers, Footers, Legend and Labels (chart) are now correctly placed
  when making external calls to the Chart Draw method and any or all of
  these objects are not automatically placed.


==================================================================================
C1Chart3D.Net Build Number 2.0.20082.18134   Build Date: Wednesday, May 14, 2008
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 2.0.20082.18078   Build Date: Wednesday, March 19, 2008
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 2.0.20081.18077   Build Date: Tuesday, March 18, 2008
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 2.0.20081.18045   Build Date: Friday, February 15, 2008
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 2.0.20081.18041   Build Date: Monday, February 11, 2008
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 2.0.20081.18039   Build Date: Saturday, February 9, 2008
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20081.18038   Build Date: Friday, February 8, 2008
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 2.0.20081.18021   Build Date: Tuesday, January 22, 2008
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes



Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20081.18020   Build Date: Monday, January 21, 2008
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 2.0.20081.18016   Build Date: Thursday, January 17, 2008
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20081.18013   Build Date: Monday, January 14, 2008
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 2.0.20073.17333   Build Date: Friday, November 30, 2007
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


====================================================================================
C1Chart3D.Net Build Number 2.0.20073.17282   Build Date: Wednesday, October 10, 2007
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20073.17281   Build Date: Tuesday, October 9, 2007
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* SmartDesigner behavior improvements.


Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 2.0.20073.17277   Build Date: Friday, October 5, 2007
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Setting the Contour.NumLevels property now automatically calculates the
  the levels based upon the new value of the property.


==================================================================================
C1Chart3D.Net Build Number 2.0.20073.17276   Build Date: Thursday, October 4, 2007
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 2.0.20073.17274   Build Date: Tuesday, October 2, 2007
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* ChartWizard and ChartProperty dialog behavior improvements.


Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 2.0.20073.17273   Build Date: Monday, October 1, 2007
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* ChartWizard and ChartProperty dialog behavior improvements.


Corrections
-----------
* The design time verbs, "Reset" and "Reset to default chart" now reset
  UseGrayScale, Enabled and Visible properties.  The Chart.Reset() method
  now resets UseGrayScale at runtime.


===================================================================================
C1Chart3D.Net Build Number 2.0.20073.17270   Build Date: Friday, September 28, 2007
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal Changes.


Corrections
-----------
* The Chart BackgroundImageLayout property is now correctly linked to the
  Chart.Style.ImageAlignment property.  ImageAlignments that cannot be
  mapped values for the BackgroundImageLayout are reflected as
  ImageAlignment.None for the BackgroundImageLayout value.


=====================================================================================
C1Chart3D.Net Build Number 2.0.20073.17269   Build Date: Thursday, September 27, 2007
=====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal Changes.
* Added a new PrintChart() overload which allows printing as a bitmap
  instead of a metafile.  This overload may be useful for printer drivers
  that do not support GDI+.


Corrections
-----------
* Interaction operations now work correctly for all combinations of
  buttons and modifiers.  Interaction operations also load correctly from
  code behind.
* Interaction operates now correctly after a designtime reset.


===================================================================================
C1Chart3D.Net Build Number 2.0.20073.17266   Build Date: Monday, September 24, 2007
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Design time charts no longer inappropriately responds to mouse drag
  movements when Interaction is enabled.


=====================================================================================
C1Chart3D.Net Build Number 2.0.20073.17262   Build Date: Thursday, September 20, 2007
=====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added new Japanese localizations.


Corrections
-----------
none


======================================================================================
C1Chart3D.Net Build Number 2.0.20073.17261   Build Date: Wednesday, September 19, 2007
======================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Charts now use SystemColors.Window for the default BackColor of the
  ChartArea instead of White.
* SmartDesigner tooltip sizing has been improved.


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 2.0.20073.17249   Build Date: Friday, September 7, 2007
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* SmartDesigner now operates correctly when UseGrayScale is true.
* SmartDesigner now reflects ChartType changes in the gallery when the
  chart type is changed without using the SmartDesigner.


====================================================================================
C1Chart3D.Net Build Number 2.0.20073.17248   Build Date: Thursday, September 6, 2007
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Saved images of specified sizes now render consistently regardless of
  the size of the hosting chart.
* Chart image is now updated when the BackgroundImage property is set when
  either UseDoubleBuffer or UseGrayScale properties are true.


=====================================================================================
C1Chart3D.Net Build Number 2.0.20073.17247   Build Date: Wednesday, September 5, 2007
=====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
* Adjustments required for C1WebChart corrections.
* SmartTag now updates its properties when changed using the Properties
  or Wizard dialogs


================================================================================
C1Chart3D.Net Build Number 2.0.20073.17231   Build Date: Monday, August 20, 2007
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  
* Added new Japanese localizations.


Corrections
-----------
none


===============================================================================
C1Chart3D.Net Build Number 2.0.20072.17187   Build Date: Saturday, July 7, 2007
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
none


===============================================================================
C1Chart3D.Net Build Number 2.0.20072.17156   Build Date: Wednesday, Jun 6, 2007
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 2.0.20072.17142   Build Date: Wednesday, May 23, 2007
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
none


=============================================================================
C1Chart3D.Net Build Number 2.0.20072.17140   Build Date: Monday, May 21, 2007
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
none


==============================================================================
C1Chart3D.Net Build Number 2.0.20072.17134   Build Date: Tuesday, May 15, 2007
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  
* Added UseGrayscale property to the chart object.  This boolean property
  allows rendering of the charts in grayscale as a preview for non-color
  printers.


Corrections
-----------
* Improved style handling for Chart3DPointSeries.


================================================================================
C1Chart3D.Net Build Number 2.0.20071.17096   Build Date: Saturday, April 7, 2007
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Fixed a compilation errors when both chart controls are in the same C++
  WinForms project.
* Fixed a problem with Chart3DPointSeriesCollection.AddRange() - the series
  styles were lost after adding them to the collection. 
* Fixed a cosmetic problem with with 3D Chart Properties/Wizard designer
  gallery.

=================================================================================
C1Chart3D.Net Build Number 1.0.20071.17032   Build Date: Friday, February 2, 2007
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Zoned surface charts now correctly display with all combinations of contours
  and shading.



====================================================================================
C1Chart3D.Net Build Number 1.0.20071.17030   Build Date: Wednesday, January 31, 2007
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


====================================================================================
C1Chart3D.Net Build Number 1.0.20071.17023   Build Date: Wednesday, January 24, 2007
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 1.0.20071.17002   Build Date: Wednesday, January 3, 2007
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 1.0.20071.17001   Build Date: Tuesday, January 2, 2007
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


====================================================================================
C1Chart3D.Net Build Number 1.0.20071.16354   Build Date: Thursday, December 21, 2006
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=====================================================================================
C1Chart3D.Net Build Number 1.0.20071.16346   Build Date: Wednesday, December 13, 2006
=====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Fixed a problem with incorrect appearance of zoned chart with custom levels.


=====================================================================================
C1Chart3D.Net Build Number 1.0.20071.16332   Build Date: Wednesday, November 29, 2006
=====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added Interaction property that allows to control settings of built-in
  interactive features(rotate, zoom, scale, translate).


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 1.0.20071.16289   Build Date: Tuesday, October 17, 2006
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added couple of methods(BeginUpdate()/EndUpdate()) which allows multiple
  (batched) chart updates to be performed without excessive repainting.


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 1.0.20061.16289   Build Date: Tuesday, October 17, 2006
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
none


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 1.0.20063.16289   Build Date: Tuesday, October 17, 2006
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
none


Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 1.0.20063.16281   Build Date: Monday, October 9, 2006
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  
* Transparency for Chart3DSymbolStyle now can be set individually,
  when A component of Color/Outline color is less than 255 this value
  is used when plotting, if A=255 the common Elevation.Transparency is
  applied. Previously it was fully controlled by Elevation.Transparency.
* Added Chart3DPointSeriesCollection.AddRange()/RemoveRange methods which
  provides fast way for adding/removing large number of data series.

Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 1.0.20063.16228   Build Date: Thursday, August 17, 2006
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 1.0.20063.16219   Build Date: Tuesday, August 8, 2006
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
none


===============================================================================
C1Chart3D.Net Build Number 1.0.20062.16205   Build Date: Tuesday, July 25, 2006
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=============================================================================
C1Chart3D.Net Build Number 1.0.20062.16183   Build Date: Monday, July 3, 2006
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
none


=============================================================================
C1Chart3D.Net Build Number 1.0.20062.16182   Build Date: Sunday, July 2, 2006
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 1.0.20062.16143   Build Date: Wednesday, May 24, 2006
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
none


=============================================================================
C1Chart3D.Net Build Number 1.0.20062.16128   Build Date: Tuesday, May 9, 2006
=============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.  


Corrections
-----------
none


============================================================================
C1Chart3D.Net Build Number 1.0.20062.16127   Build Date: Monday, May 8, 2006
============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==============================================================================
C1Chart3D.Net Build Number 1.0.20062.16123   Build Date: Thursday, May 4, 2006
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===============================================================================
C1Chart3D.Net Build Number 1.0.20062.16122   Build Date: Wednesday, May 3, 2006
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Fixed a problem with border color. It was sometimes cleared after changing
  border style.


============================================================================
C1Chart3D.Net Build Number 1.0.20062.16120   Build Date: Monday, May 1, 2006
============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===============================================================================
C1Chart3D.Net Build Number 1.0.20062.16110   Build Date: Friday, April 21, 2006
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===============================================================================
C1Chart3D.Net Build Number 1.0.20062.16106   Build Date: Monday, April 17, 2006
===============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* AboutBox adjustments.


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 1.0.20062.16103   Build Date: Friday, April 14, 2006
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Basic chart elements now are exposed through accessibility interfaces.
* Added localized Japanese descriptions for UseAntiAliasGraphics and
  UseAntiAliasText.

Corrections
-----------
* Fixed performance issue when working with properties of Chart3DContour
  object.
* Wizard and Properties dialogs are no longer shown in the taskbar.


===============================================================================
C1Chart3D.Net Build Number 1.0.20062.16099   Build Date: Monday, April 10, 2006
===============================================================================

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
none

==============================================================================
C1Chart3D.Net Build Number 1.0.20062.16098   Build Date: Sunday, April 9, 2006
==============================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Added UseAntiAliasedText and UseAntiAliasedGraphics properties.


Corrections
-----------
* Chart3DLabel.Size property now is saved correctly at designtime.


==================================================================================
C1Chart3D.Net Build Number 1.0.20062.16087   Build Date: Wednesday, March 29, 2006
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Several minor design time behaviors have been improved.


Corrections
-----------
* Fixed several localization issues specific for .Net 2.0.


===================================================================================
C1Chart3D.Net Build Number 1.0.20061.16018   Build Date: Thursday, January 19, 2006
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Several minor design time behaviors have been improved.


==================================================================================
C1Chart3D.Net Build Number 1.0.20061.16009   Build Date: Tuesday, January 10, 2006
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Fixed several localization issues.


================================================================================
C1Chart3D.Net Build Number 1.0.20061.16007   Build Date: Sunday, January 8, 2006
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
* Both the BarColorCollection and the LevelCollection editors now properly
  restore the previous chart state when the Cancel button is pressed.


=================================================================================
C1Chart3D.Net Build Number 1.0.20061.16002   Build Date: Tuesday, January 3, 2006
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 1.0.20061.15363   Build Date: Friday, December 30, 2005
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


====================================================================================
C1Chart3D.Net Build Number 1.0.20061.15362   Build Date: Thursday, December 29, 2005
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=====================================================================================
C1Chart3D.Net Build Number 1.0.20061.15354   Build Date: Wednesday, December 21, 2005
=====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 1.0.20061.15353   Build Date: Tuesday, December 20, 2005
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 1.0.20061.15342   Build Date: Friday, December 9, 2005
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 1.0.20061.15339   Build Date: Tuesday, December 6, 2005
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 1.0.20053.15339   Build Date: Tuesday, December 6, 2005
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 1.0.20053.15321   Build Date: Friday, November 18, 2005
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.
* Aboutbox email handler changes.

Corrections
-----------
none


====================================================================================
C1Chart3D.Net Build Number 1.0.20053.15320   Build Date: Thursday, November 17, 2005
====================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 1.0.20053.15308   Build Date: Saturday, November 5, 2005
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 1.0.20053.15307   Build Date: Friday, November 4, 2005
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 1.0.20053.15306   Build Date: Thursday, November 3, 2005
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 1.0.20053.15299   Build Date: Thursday, October 27, 2005
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
* Various bug fixes.


=================================================================================
C1Chart3D.Net Build Number 1.0.20053.15288   Build Date: Sunday, October 16, 2005
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
none


==================================================================================
C1Chart3D.Net Build Number 1.0.20053.15236   Build Date: Thursday, August 25, 2005
==================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.


Corrections
-----------
none


===================================================================================
C1Chart3D.Net Build Number 1.0.20053.15235   Build Date: Wednesday, August 24, 2005
===================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
none


=================================================================================
C1Chart3D.Net Build Number 1.0.20053.15234   Build Date: Tuesday, August 23, 2005
=================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 1.0.20053.15233   Build Date: Monday, August 22, 2005
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Internal changes.

Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 1.0.20053.15225   Build Date: Sunday, August 14, 2005
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added new Japanese translations.


Corrections
-----------
none


================================================================================
C1Chart3D.Net Build Number 1.0.20053.15213   Build Date: Tuesday, August 2, 2005
================================================================================


Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added GetMetafile() method.
* Added AutoFit property of Chart3DView object which controls x/y ratio for
  2D projection chart.
* Added PrintChart() method with PageSettings parameter.
* Improved performance of contour chart plotting.


Corrections
-----------
* Various bug fixes.

=================================================================================
C1Chart3D.Net History
=================================================================================

2.0.20142.24286    14-Oct-2014
4.0.20142.24286    14-Oct-2014
  - Internal changes.
  - Applied modified contour calculations to ContourData as well as Elevation data when
    calculating contours. (TFS-90816)

2.0.20142.24247    05-Sep-2014
4.0.20142.24247    05-Sep-2014
  - Internal changes.
  - Added Japanese, Korean and Chinese localizations for the ContourMethod
    propery description and Save Chart Template and Load Chart Template verbs.
  - Added 14 significant digit rounding to axis min/max calculations due to
    .NET handling of doubles.  This provideds improved axis limit annotations.

2.0.20142.24182    02-Jul-2014
4.0.20142.24182    02-Jul-2014
  - Internal changes.
  - Added new contouring method (Marching Squares) to release version for
    testing.  To enable the marching squares contouring method, change the
    new property, C1.Win.C1Chart3D.Chart3DContour.ContourMethod property
    from Default to MarchingSquares.

    Documentation changes include the addition of the ContourMethodEnum enum
    and the addition of the property:

    public enum C1.Win.C1Chart3D.ContourMethodEnum
    {
        /// <summary>
        /// Default method of contour calculation.
        /// </summary>
        Default,

        /// <summary>
        /// Method of marching squares that provides an alternate contour calculation.
        /// This method requires an increased number of calculations, but tends to
        /// improve contour symmetry. 
        /// </summary>
        MarchingSquares
    }

    New property for class C1.Win.C1Chart3D.Chart3DContour:

    public ContourMethodEnum ContourMethod

       Gets or sets the contour calculation method.
       DefaultValue = ContourMethodEnum.Default

    Related to Tfs-41341 and Tfs-42523, changeset 133818.


2.0.20142.24177    27-Jun-2014
4.0.20142.24177    27-Jun-2014
  - Internal changes.
  - Modified Legend.FormatString behavior such that a leading minus sign
    left justifies the numberic strings.  Otherwise the behavior is to left
    pad with blanks necessary to align decimal points.

  - Added of saving and loading chart templates.  Chart templates are similar
    to chart descriptions, but do not store or reset data upon loading.  The
    new method prototypes include:

        void SaveChartTemplateToFile(string Filename);
        string templateString = SaveChartTemplateToString();
        string templateString = SaveChartTemplateToString(bool formatting);

        void LoadChartTemplateFromFile(string Filename);
        void LoadChartTemplateFromString(string templateString);

   Documentation should include the new methods.

2.0.20141.24156    06-Jun-2014
4.0.20141.24156    06-Jun-2014
  - Internal changes.

2.0.20141.24135    16-May-2014
4.0.20141.24135    16-May-2014
  - Internal changes.

2.0.20141.24092    03-Apr-2014
4.0.20141.24092    03-Apr-2014
  - Internal changes.
  - The chart now always translates it coordinate system to use internal
    coordinates when invoking the chart Draw method.  This is necessary
    to correctly draw chart elements with specific values.

2.0.20141.24071    13-Mar-2014
4.0.20141.24071    13-Mar-2014
  - Internal changes.

2.0.20141.24070    12-Mar-2014
4.0.20141.24070    12-Mar-2014
  - Internal changes.
  - Added Chinese and Korean localizations for FormatString and Separator
    properties.

2.0.20141.24062    04-Mar-2014
4.0.20141.24062    04-Mar-2014
  - Internal changes.
  - Chart data is now shown in chart area of C1Chart3D when a new instance
    is added to an existing Themed form.
  - Added FormatString and Separator properties to the Legend object.

2.0.20141.24056    26-Feb-2014
4.0.20141.24056    26-Feb-2014
  - Internal changes.

2.0.20141.24051    21-Feb-2014
4.0.20141.24051    21-Feb-2014
  - Internal changes.
  - Added fully qualified design assembly name for 4x DesignerAttribute.

2.0.20141.24050    20-Feb-2014
4.0.20141.24050    20-Feb-2014
  - Internal changes.
  - Added license support for Studio for Desktop

2.0.20141.24049    19-Feb-2014
4.0.20141.24049    19-Feb-2014
  - Internal changes.
  - Adjustments for C1ThemeController.

2.0.20141.24048    18-Feb-2014
4.0.20141.24048    18-Feb-2014
  - Internal changes.
  - Added support for C1ThemeController.

2.0.20141.24047    17-Feb-2014
4.0.20141.24047    17-Feb-2014
  - Internal changes.

2.0.20141.24035    05-Feb-2014
4.0.20141.24035    05-Feb-2014
  - Internal changes.

2.0.20133.24035    05-Feb-2014
4.0.20133.24035    05-Feb-2014
  - Internal changes.
  - Removed Marching Squares contouring method, enum and associated
    properties.

2.0.20141.24034    04-Feb-2014
4.0.20141.24034    04-Feb-2014
  - Internal changes.

2.0.20133.24030    31-Jan-2014
4.0.20133.24030    31-Jan-2014
  - Internal changes.
  - The rounding parameters in the border style dialogs (previous) can now
    be set above a value of 20.

2.0.20133.24028    29-Jan-2014
4.0.20133.24028    29-Jan-2014
  - Internal changes.
  - Additional adjustments to the new contouring method (Marching Squares).

2.0.20133.24027    28-Jan-2014
4.0.20133.24027    28-Jan-2014
  - Internal changes.
  - Added new contouring method (Marching Squares).

2.0.20133.24019    20-Jan-2014
4.0.20133.24019    20-Jan-2014
  - Internal changes.

2.0.20133.24012    13-Jan-2014
4.0.20133.24012    13-Jan-2014
  - Internal changes.
  - Further adjusted tesselation conditions to improve contouring in
    symmetrictal and negative valued elevations.

2.0.20133.24009    10-Jan-2014
4.0.20133.24009    10-Jan-2014
  - Internal changes.

2.0.20133.24008    09-Jan-2014
4.0.20133.24008    09-Jan-2014
  - Internal changes.
    
2.0.20133.24007    08-Jan-2014
4.0.20133.24007    08-Jan-2014
  - Internal changes.

2.0.20133.24002    03-Jan-2014
4.0.20133.24002    03-Jan-2014
  - Internal changes.

2.0.20133.24001    02-Jan-2014
4.0.20133.24001    02-Jan-2014
  - Internal changes.

2.0.20133.23350    17-Dec-2013
4.0.20133.23350    17-Dec-2013
  - Internal changes.
  - Adjusted tesselation depending upon z-values and additional conditions.

2.0.20133.23345    12-Dec-2013
4.0.20133.23345    12-Dec-2013
  - Internal changes.

2.0.20133.23339    06-Dec-2013
4.0.20133.23339    06-Dec-2013
  - Internal changes.
  - Changed order of tesselation depending upon z-values, while
    maintaining proper drawing of column and row mesh lines.

2.0.20133.23332    29-Nov-2013
4.0.20133.23332    29-Nov-2013
  - Internal changes.

2.0.20133.23330    27-Nov-2013
4.0.20133.23330    27-Nov-2013
  - Internal changes.

2.0.20133.23329    26-Nov-2013
4.0.20133.23329    26-Nov-2013
  - Internal changes.

2.0.20133.23316    13-Nov-2013
4.0.20133.23316    13-Nov-2013
  - Internal changes.
  - Remove incomplete support for C1ThemeController.

2.0.20133.23290    18-Oct-2013
4.0.20133.23290    18-Oct-2013
  - Internal changes.
  - Removed changed order of tesselation depending upon z-values. (TFS 41341).

2.0.20133.23289    17-Oct-2013
4.0.20133.23289    17-Oct-2013
  - Internal changes.
  - Added basic support for C1ThemeController.
  
2.0.20133.23287    15-Oct-2013
4.0.20133.23287    15-Oct-2013
  - Internal changes.

2.0.20132.23282    10-Oct-2013
4.0.20132.23282    10-Oct-2013
  - Internal changes.
  - Changed order of tesselation depending upon z-values. (TFS 41341).

2.0.20132.23225    14-Aug-2013
4.0.20132.23225    14-Aug-2013
  - Internal changes.
  - Obfuscation adjusted to compensate for bug in VC++ compiler.
  
2.0.20132.23192    12-Jul-2013
4.0.20132.23192    12-Jul-2013
  - Internal changes.
  - Handling of extreme data involving near zero values in legend
    calculations has been improved.

2.0.20132.23171    21-Jun-2013
4.0.20132.23171    21-Jun-2013
  - Internal changes.

2.0.20132.23164    14-Jun-2013
4.0.20132.23164    14-Jun-2013
  - Internal changes.

2.0.20132.23154    04-Jun-2013
4.0.20132.23154    04-Jun-2013
  - Internal changes.
  - Updated GrapeCity JPN AboutBox URLs.

2.0.20131.23121    02-May-2013
4.0.20131.23121    02-May-2013
  - Internal changes.
  - Minor internal double buffering changes.
  - Changing chart types while double buffered now correctly repaints the
    chart display in all cases.

2.0.20131.23091    02-Apr-2013
4.0.20131.23091    02-Apr-2013
  - Internal changes.
  - Implemented additional GrapeCity licensing model changes for JPN builds.

2.0.20131.23090    01-Apr-2013
4.0.20131.23090    01-Apr-2013
  - Internal changes.
  - The AboutBox evaluation notice has been corrected.

2.0.20131.23087    29-Mar-2013
4.0.20131.23087    29-Mar-2013
  - Internal changes.
  - Implemented new GrapeCity licensing model for JPN builds.

2.0.20131.23069    11-Mar-2013
4.0.20131.23069    11-Mar-2013
  - Internal changes.

2.0.20131.23065    07-Mar-2013
4.0.20131.23065    07-Mar-2013
  - Internal changes.

2.0.20131.23064    06-Mar-2013
4.0.20131.23064    06-Mar-2013
  - Internal changes.

2.0.20131.23041    11-Feb-2013
4.0.20131.23041    11-Feb-2013
  - Internal changes.
  - Internal legend data is now cleared when all series are removed.

2.0.20131.23037    07-Feb-2013
4.0.20131.23037    07-Feb-2013
  - Internal changes.

2.0.20131.23036    06-Feb-2013
4.0.20131.23036    06-Feb-2013
  - Internal changes.

2.0.20131.23030    31-Jan-2013
4.0.20131.23030    31-Jan-2013
  - Internal changes.
  - Double buffering at design time no longer causes excessive flicker.

2.0.20131.23027    28-Jan-2013
4.0.20131.23027    28-Jan-2013
  - Internal changes.

2.0.20131.23017    18-Jan-2013
4.0.20131.23017    18-Jan-2013
  - Internal changes.

2.0.20123.23010    11-Jan-2013
4.0.20123.23010    11-Jan-2013
  - Internal changes.
  - Axis tick marks are now only drawn for axes specified by the
    Axis.AnnoPosition property. (Tfs-30817)
  - Designer "About" verbs have removed ComponentOne from the display text.

2.0.20123.22305    01-Nov-2012
4.0.20123.22305    01-Nov-2012
  - Internal changes.

2.0.20123.22304    31-Oct-2012
4.0.20123.22304    31-Oct-2012
  - Internal changes.
  - Improved printer scaling logic.

2.0.20123.22303    30-Oct-2012
4.0.20123.22303    30-Oct-2012
  - Internal changes.

2.0.20123.22299    26-Oct-2012
4.0.20123.22299    26-Oct-2012
  - Internal changes.

2.0.20123.22298    25-Oct-2012
4.0.20123.22298    25-Oct-2012
  - Internal changes.
  - Contour level properties are now correctly persisted.  This was a
    problem due to changes beginning with build version 22221.
  - The Localization basis is now CurrentUICulture instead of CurrentCulture.

2.0.20123.22283    10-Oct-2012
4.0.20123.22283    10-Oct-2012
  - Internal changes.

2.0.20122.22283    10-Oct-2012
4.0.20122.22283    10-Oct-2012
  - Internal changes.
  - Corrected language codes for Chinese (zh) and Korean (ko). (Tfs-28888)

2.0.20122.22282    09-Oct-2012
4.0.20122.22282    09-Oct-2012
  - Internal changes.
  - Added localizations for Chinese and Korean.

2.0.20122.22227    14-Aug-2012
4.0.20122.22227    14-Aug-2012
  - Internal changes.
  - Adjustment to VS2012 toolbox bitmap logic.

2.0.20122.22226    14-Aug-2012
4.0.20122.22226    14-Aug-2012
  - Internal changes.
  - Adjustment to VS2012 toolbox bitmap logic.

2.0.20122.22221    09-Aug-2012
4.0.20122.22221    09-Aug-2012
  - Internal changes.
  - ContourStyle colors are now updated when colors are added to or removed
    from the ContourStyle.Colors collection.
  - ContourStyle colors now interpolate color alpha characteristics as well
    as color.
  - Updated VS2012 toolbox bitmap.
  - Excluded ActionEnum from the documentation as this enum is for internal
    use only.

2.0.20122.22206    25-Jul-2012
4.0.20122.22206    25-Jul-2012
  - Internal changes.
  - Logic has been added for VS2012 toolbox bitmaps.
  - Scatter charts now correctly omit points with hole values.

2.0.20122.22187    06-Jul-2012
4.0.20122.22187    06-Jul-2012
  - Internal changes.

2.0.20122.22186    05-Jul-2012
4.0.20122.22186    05-Jul-2012
  - Internal changes.

2.0.20122.22184    03-Jul-2012
4.0.20122.22184    03-Jul-2012
  - Internal changes.
  - Updated copyright messages.

2.0.20122.22162    11-Jun-2012
4.0.20122.22162    11-Jun-2012
  - Internal changes.

2.0.20122.22157    06-Jun-2012
4.0.20122.22157    06-Jun-2012
  - Internal changes.
  - The chart designer form font has been changed for JPN WebChart builds.
    The new font allows designer controls to properly display their text.
  - "NaN" is now accepted in the chart Properties/Wizard dialog data table
    for a (hole) value in JPN Chart builds.

2.0.20122.22156    05-Jun-2012
4.0.20122.22156    05-Jun-2012
  - Internal changes.
  - The chart StyleChanged event now fires when the Style for the control
    changes.  This event does not fire when other chart element styles are
    changed.  Use the ChartChanged event for other styles.

2.0.20122.22155    04-Jun-2012
4.0.20122.22155    04-Jun-2012
  - Internal changes.

2.0.20122.22145    25-May-2012
4.0.20122.22145    25-May-2012
  - Internal changes.

2.0.20122.22143    23-May-2012
4.0.20122.22143    23-May-2012
  - Internal changes.
  - BorderStyleEnum.Opaque no longer reduces the chart area size when
    Rounding is non-zero.

2.0.20122.22142    22-May-2012
4.0.20122.22142    22-May-2012
  - Internal changes.  Same as previous build, except for version number.

2.0.20121.22142    22-May-2012
4.0.20121.22142    22-May-2012
  - Internal changes.
  - A new border style (BorderStyleEnum.Opaque) has been added.  The new
    border style ensures that anti-aliasing is turned off when drawing the
    border.  Opaque borders ignore Rounding settings.  This border style can
    be useful for generating chart images to be use with transparent
    backgrounds.

2.0.20121.22136    16-May-2012
4.0.20121.22136    16-May-2012
  - Internal changes.

2.0.20121.22129    09-May-2012
4.0.20121.22129    09-May-2012
  - Internal changes.
  - Restored the GotFocus event.  Please note that the GotFocus and
    LostFocus events are no longer recommended for usage by Microsoft - use
    the Enter and Leave events instead.
  
2.0.20121.22121    01-May-2012
4.0.20121.22121    01-May-2012
  - Internal changes.

2.0.20121.22115    25-Apr-2012
4.0.20121.22115    25-Apr-2012
  - Internal changes.

2.0.20121.22110    20-Apr-2012
4.0.20121.22110    20-Apr-2012
  - Internal changes.

2.0.20121.22100    10-Apr-2012
4.0.20121.22100    10-Apr-2012
  - Internal changes.
  - Axis Min and Max values are automatically adjusted if both are zero.
  - MetaFile images can now be saved to the clipboard in all scenarios.
  - Added a DescriptionAttribute for the C1Chart3D control class.

2.0.20121.22036    06-Feb-2012
4.0.20121.22036    06-Feb-2012
  - Internal changes.

2.0.20121.22035    05-Feb-2012
4.0.20121.22035    05-Feb-2012
  - Internal changes.

2.0.20121.22030    31-Jan-2012
4.0.20121.22030    31-Jan-2012
  - Internal changes.

2.0.20113.22030    31-Jan-2012
4.0.20113.22030    31-Jan-2012
  - Internal changes.
  - Adjusted axis automatic Min/Max calculations to eliminate exceptions in
    some cases.

2.0.20113.21345    12-Dec-2011
4.0.20113.21345    12-Dec-2011
  - Internal changes.

2.0.20113.21334    01-Dec-2011
4.0.20113.21334    01-Dec-2011
  - Internal changes.
  - Updated licensing to conform with Federal Information Processing
    Standards requirements. (Tfs-18562)

2.0.20113.21313    10-Nov-2011
4.0.20113.21313    10-Nov-2011
  - Internal changes.

2.0.20113.21296    24-Oct-2011
4.0.20113.21296    24-Oct-2011
  - Internal changes.

2.0.20113.21286    14-Oct-2011
4.0.20113.21286    14-Oct-2011
  - Internal changes.
  - Absolute Location and Size of chart elements are now adjusted along with
    chart size during printing operations.

2.0.20113.21276    04-Oct-2011
4.0.20113.21276    04-Oct-2011
  - Internal changes.
  - Licensing update for FIPS compliance.  (TFS-17615,TFS-18460,TFS-18562)

2.0.20113.21263    21-Sep-2011
4.0.20113.21263    21-Sep-2011
  - Internal changes.

2.0.20113.21253    11-Sep-2011
4.0.20113.21253    11-Sep-2011
  - Internal changes.

2.0.20112.21250    08-Sep-2011
4.0.20112.21250    08-Sep-2011
  - Internal changes.

2.0.20112.21249    07-Sep-2011
4.0.20112.21249    07-Sep-2011
  - Internal changes.
  - Automatic axis min and max values calculations have been improved when
    handling extreme values.

2.0.20112.21243    01-Sep-2011
4.0.20112.21243    01-Sep-2011
  - Internal changes.

2.0.20112.21240    29-Aug-2011
4.0.20112.21240    29-Aug-2011
  - Internal changes.

2.0.20112.21236    25-Aug-2011
4.0.20112.21236    25-Aug-2011
  - Internal changes.

2.0.20112.21228    17-Aug-2011
4.0.20112.21228    17-Aug-2011
  - Internal changes.

2.0.20112.21221    10-Aug-2011
4.0.20112.21221    10-Aug-2011
  - Internal changes.
  - Chart3D has improved handling of extreme floating point numbers.

2.0.20112.21214    03-Aug-2011
4.0.20112.21214    03-Aug-2011
  - Internal changes.

2.0.20112.21181    01-Jul-2011
4.0.20112.21181    01-Jul-2011
  - Internal changes.
    
2.0.20112.21173    23-Jun-2011
4.0.20112.21173    23-Jun-2011
  - Internal changes.

2.0.20112.21170    20-Jun-2011
4.0.20112.21170    20-Jun-2011
  - Internal changes.
  - The chart.PrintChart() overloads now print items drawn in the Paint
    event.

2.0.20112.21167    17-Jun-2011
4.0.20112.21167    17-Jun-2011
  - Internal changes.

2.0.20112.21131    12-May-2011
4.0.20112.21131    12-May-2011
  - Internal changes.

2.0.20112.21129    10-May-2011
4.0.20112.21129    10-May-2011
  - Internal changes.

2.0.20111.21119    30-Apr-2011
4.0.20111.21119    30-Apr-2011
  - Internal changes.

2.0.20111.21116    27-Apr-2011
4.0.20111.21116    27-Apr-2011
  - Internal changes.

2.0.20111.21108    19-Apr-2011
4.0.20111.21108    19-Apr-2011
  - Internal changes.
  - Removed icons from headers in designer forms.

2.0.20111.21089    31-Mar-2011
4.0.20111.21089    31-Mar-2011
  - Internal changes.

2.0.20111.21084    26-Mar-2011
4.0.20111.21084    26-Mar-2011
  - Internal changes.

2.0.20111.21083    25-Mar-2011
4.0.20111.21083    25-Mar-2011
  - Internal changes.
  - Added explicit reference to 4x designer.  This improves behavior when multiple
    versions of the Chart are installed on the same machine.

2.0.20111.21027    28-Jan-2011
4.0.20111.21027    28-Jan-2011
  - Internal changes.
  - Corrected Xml documentation file for SaveLocalizations(byte[] byteArray)
    and LoadLocalizations(byte[] byteArray).
    
2.0.20111.21012    13-Jan-2011
4.0.20111.21012    13-Jan-2011
  - Internal changes.
  - LoadLocalization() overloads can now reset the localization to its default
    state by passing a null argument.

2.0.20111.21006     07-Jan-2011
4.0.20111.21006     07-Jan-2011
  - Internal changes.
  - Chart dialogs can now be maximized.
  
2.0.20111.21005     06-Jan-2011
4.0.20111.21005     06-Jan-2011
  - Internal changes.

2.0.20111.21004     05-Jan-2011
4.0.20111.21004     05-Jan-2011
  - Internal changes.
  - Added runtime user localizations by introducing SaveLocalizations() and
    LoadLocalizations() methods.  This overloaded methods save and load XML
    translation tables, respectively, that translate internal strings at
    runtime.
  - The chart property and chart wizard dialogs can now be resized.

2.0.20103.20356     23-Dec-2010
4.0.20103.20356     23-Dec-2010
  - Internal changes.
  - Surface chart legend drawing no longer incorrectly honors the
    LineStyle.Thickness property.

2.0.20103.20346     13-Dec-2010
4.0.20103.20346     13-Dec-2010
  - Internal changes.

2.0.20103.20251     09-Sep-2010
4.0.20103.20251     09-Sep-2010
  - Internal changes.

2.0.20103.20250     08-Sep-2010
4.0.20103.20250     08-Sep-2010
  - Internal changes.

2.0.20103.20245     03-Sep-2010
4.0.20103.20245     03-Sep-2010
  - Internal changes.

2.0.20102.20244     02-Sep-2010
4.0.20102.20244     02-Sep-2010
  - Internal changes.

2.0.20102.20187     07-Jul-2010
4.0.20102.20187     07-Jul-2010
  - Internal changes.
  - Changing to PointData at runtime no longer results in an exception in
    some circumstances.

2.0.20102.20166     16-Jun-2010
4.0.20102.20166     16-Jun-2010
  - Internal changes.

2.0.20101.20159     09-Jun-2010
4.0.20101.20159     09-Jun-2010
  - Internal changes.

2.0.20101.20157     07-Jun-2010
4.0.20101.20157     07-Jun-2010
  - Internal changes.
  - The Chart3D now rotates on its axes in a consistent manner at design
    time and runtime.

2.0.20101.20145     26-May-2010
4.0.20101.20145     26-May-2010
  - Internal changes.

2.0.20101.20143     24-May-2010
4.0.20101.20143     24-May-2010
  - Internal changes.

2.0.20101.20136     17-May-2010
4.0.20101.20136     17-May-2010
  - Internal changes.

4.0.20101.20132     13-May-2010
2.0.20101.20132     13-May-2010
  - Internal changes.

4.0.20101.20131     12-May-2010
2.0.20101.20131     12-May-2010
  - Internal changes.
  - Finalizing 4.0 version port.

4.0.20101.20119     30-Apr-2010
2.0.20101.20119     30-Apr-2010
  - Internal changes.
  - 4.0 version has designer split into separate assembly for 4.0 Client Mode.

2.0.20101.20096     07-Apr-2010
  - Internal changes.

2.0.20101.20089     31-Mar-2010
  - Internal changes.

2.0.20101.20062     04-Mar-2010
  - Internal changes.

2.0.20101.20060     02-Mar-2010
  - Internal changes.

2.0.20101.20053     23-Feb-2010
  - Internal changes.

2.0.20101.20048     18-Feb-2010
  - Internal changes.

2.0.20101.20037     07-Feb-2010
  - Internal changes.

2.0.20101.20033     03-Feb-2010
  - Internal changes.
    
2.0.20101.20021     22-Jan-2010
  - Internal changes

2.0.20101.20014     15-Jan-2010
  - Internal changes
  - Modified licensing requirements for Visual Studio 2010.

2.0.20093.19364     31-Dec-2009
  - Internal changes
  - Modified style persistence such that the attribute order is consistent.

2.0.20093.19362     29-Dec-2009
  - Internal changes
  - AboutBox truncations in GrapeCity builds have been eliminated.

2.0.20093.19356     23-Dec-2009
  - Internal changes
  - Attempting to open and write to a data file that was previously loaded
    in Chart7 format no longer results in a file in use error.

2.0.20093.19342     09-Dec-2009
  - Internal changes.

2.0.20093.19337     04-Dec-2009
  - Internal changes.

2.0.20093.19336     03-Dec-2009
  - Internal changes.
  - Chart3DData.SaveDataToFile() method now saves data correctly in old
    data format(Chart7).
  - Text in wizard dialog now is not cut when windows fonts are large.

2.0.20093.19335     02-Dec-2009
  - Internal changes.

2.0.20093.19334     01-Dec-2009
  - Internal changes.

2.0.20093.19333     30-Nov-2009
  - Internal changes.
  - Fixed the problem with setting Chart3DView.View3D(introduced in 19332).
  - Added Japanese localization adjustments.

2.0.20093.19332     29-Nov-2009
  - Internal changes.
  - Fixed the problem with applying rotation properties(Chart3DView.RotationX/Y/Z)
    to the 3D chart.
  - Fixed the problem with 3D chart appearance with small values of 
    Chart3DView.XScale/YScale.

2.0.20093.19329     26-Nov-2009
  - Internal changes
  - GrapeCity licensing now correct.

2.0.20093.19328     25-Nov-2009
  - Internal changes

2.0.20093.19310     07-Nov-2009
  - Internal changes
  - Internal licensing changes.

2.0.20093.19301     29-Oct-2009
  - Internal changes
  - Added new GrapeCity license codes for JPN version.
  
2.0.20093.19298     26-Oct-2009
  - Internal changes
  - Chart.Print now properly displays the PrintDialog during 64 bit
    execution.

2.0.20093.19284     12-Oct-2009
  - Internal changes

2.0.20093.19272     30-Sep-2009
  - Internal changes

2.0.20093.19267     25-Sep-2009
  - Internal changes

2.0.20093.19265     23-Sep-2009
  - Internal changes

2.0.20093.19258     16-Sep-2009
  - Internal changes

2.0.20093.19256     14-Sep-2009
  - Internal changes
  - Honors C1Olap licensing.
  - Improved loading capability of chart3dxml files.

2.0.20092.19168     18-Jun-2009
  - Internal changes

2.0.20092.19161     11-Jun-2009
  - Internal changes
  - Adjusted obfuscation for licensing.

2.0.20092.19160     10-Jun-2009
  - Internal changes
  - Adjusted obfuscation for licensing.

2.0.20092.19152     02-Jun-2009
  - Internal changes
  - New Licensing and AboutBox code.

2.0.20091.19053     23-Feb-2009
  - Internal changes
  - Added VerticalText to Styled chart3d elements.

2.0.20091.19043     13-Feb-2009
  - Internal changes

2.0.20091.19032     02-Feb-2009
  - Internal changes
    Do not use build 19030

2.0.20091.19030     31-Jan-2009
  - Bad build, do not use

2.0.20091.19026     27-Jan-2009
  - Internal changes

2.0.20091.19015     16-Jan-2009
  - Internal changes

2.0.20083.19012     13-Jan-2009
  - Internal changes

2.0.20083.19011     12-Jan-2009
  - Internal changes
  - Design time environment chart designer operations are now suppressed
    when running in the IDE.  Previously some attempts at changing the chart
    properties could result in an unhandled exception.

2.0.20083.19006     07-Jan-2009
  - Internal changes

2.0.20083.19005     06-Jan-2009
  - Internal changes

2.0.20083.18353     19-Dec-2008
  - Internal changes

2.0.20083.18335     01-Dec-2008
  - Internal changes
  - Adjustments for MediumTrust situations.
  - Chart3D data files (*.dat) from ActiveX charts now read correctly for
    irregular grids.

2.0.20083.18325     21-Nov-2008
  - Internal changes
  - Adjustments for MediumTrust situations.

2.0.20083.18323     19-Nov-2008
  - Internal changes

2.0.20083.18297     24-Oct-2008
  - Internal changes

2.0.20083.18296     23-Oct-2008
  - Internal changes

2.0.20083.18294     21-Oct-2008
  - Internal changes
  - The LabelCollection editor dialogs now correctly handle and persist
    property assignments for collection elements.  This was a error
    resulting from changes in build 2.0.20083.18265.

2.0.20083.18265     22-Sep-2008
  - Internal changes
  - Memory leaks associated with LabelsCollection.Clear() have been
    corrected.

2.0.20083.18248     05-Sep-2008
  - Internal changes

2.0.20083.18238     26-Aug-2008
  - Internal changes

2.0.20083.18237     25-Aug-2008
  - Internal changes

2.0.20082.18237     25-Aug-2008
  - Internal changes

2.0.20082.18192     11-Jul-2008
  - Internal changes

2.0.20082.18140     20-May-2008
  - Internal changes
  - Headers, Footers, Legend and Labels (chart) are now correctly placed
    when making external calls to the Chart Draw method and any or all of
    these objects are not automatically placed.

2.0.20082.18134     14-May-2008
  - Internal changes

2.0.20082.18078     19-Mar-2008
  - Internal changes

2.0.20081.18077     18-Mar-2008
  - Internal changes

2.0.20081.18045     15-Feb-2008
  - Internal changes

2.0.20081.18041     11-Feb-2008
  - Internal changes

2.0.20081.18039     09-Feb-2008
  - Internal changes

2.0.20081.18038     08-Feb-2008
  - Internal changes

2.0.20081.18021     22-Jan-2008
  - Internal changes

2.0.20081.18020     21-Jan-2008
  - Internal changes

2.0.20081.18016     17-Jan-2008
  - Internal changes

2.0.20081.18013     14-Jan-2008
  - Internal changes.

2.0.20073.17333     30-Nov-2007
  - Internal changes.

2.0.20073.17282     10-Oct-2007
  - Internal changes.

2.0.20073.17281     09-Oct-2007
  - Internal changes.
  - SmartDesigner behavior improvements.

2.0.20073.17277     05-Oct-2007
  - Internal changes.
  - Setting the Contour.NumLevels property now automatically calculates the
    the levels based upon the new value of the property.

2.0.20073.17276     04-Oct-2007
  - Internal changes.

2.0.20073.17274     02-Oct-2007
  - Internal changes.
  - SmartDesigner behavior improvements.
  - ChartProperties and ChartWizard dialog behavior improvements.

2.0.20073.17273     01-Oct-2007
  - Internal changes.
  - ChartWizard and ChartProperty dialog behavior improvements.
  - The Chart BackgroundImageLayout property is now correctly linked to the
    Chart.Style.ImageAlignment property.  ImageAlignments that cannot be
    mapped values for the BackgroundImageLayout are reflected as
    ImageAlignment.None for the BackgroundImageLayout value.
  - The design time verbs, "Reset" and "Reset to default chart" now reset
    UseGrayScale, Enabled and Visible properties.  The Chart.Reset() method
    now resets UseGrayScale at runtime.

2.0.20073.17270     28-Sep-2007
  - Internal changes.
  - The Chart BackgroundImageLayout property is now correctly linked to the
    Chart.Style.ImageAlignment property.  ImageAlignments that cannot be
    mapped values for the BackgroundImageLayout are reflected as
    ImageAlignment.None for the BackgroundImageLayout value.
  - The design time verbs, "Reset" and "Reset to default chart" now reset
    UseGrayScale, Enabled and Visible properties.  The Chart.Reset() method
    now resets UseGrayScale at runtime.
  - ChartWizard and ChartProperty dialog behavior improvements.

2.0.20073.17270     28-Sep-2007
  - Internal changes.
  - The Chart BackgroundImageLayout property is now correctly linked to the
    Chart.Style.ImageAlignment property.  ImageAlignments that cannot be
    mapped values for the BackgroundImageLayout are reflected as
    ImageAlignment.None for the BackgroundImageLayout value.

2.0.20073.17269     27-Sep-2007
  - Internal changes.
  - Interaction operations now work correctly for all combinations of
    buttons and modifiers.  Interaction operations also load correctly from
    code behind.
  - Interaction operates now correctly after a designtime reset.
  - Added a new PrintChart() overload which allows printing as a bitmap
    instead of a metafile.  This overload may be useful for printer drivers
    that do not support GDI+.

2.0.20073.17266     24-Sep-2007
  - Internal changes.
  - Design time charts no longer inappropriately responds to mouse drag
    movements when Interaction is enabled.

2.0.20073.17262     20-Sep-2007
  - Internal changes.
  - Added new Japanese localizations.

2.0.20073.17261     19-Sep-2007
  - Internal changes.
  - Charts now use SystemColors.Window for the default BackColor of the
    ChartArea instead of White.
  - SmartDesigner tooltip sizing has been improved.

2.0.20073.17249     07-Sep-2007
  - Internal changes.
  - SmartDesigner now operates correctly when UseGrayScale is true.
  - SmartDesigner now reflects ChartType changes in the gallery when the
    chart type is changed without using the SmartDesigner.

2.0.20073.17248     06-Sep-2007
  - Internal changes.
  - Saved images of specified sizes now render consistently regardless of
    the size of the hosting chart.
  - Chart image is now updated when the BackgroundImage property is set when
    either UseDoubleBuffer or UseGrayScale properties are true.

2.0.20073.17247     05-Sep-2007
  - Internal changes.  
  - Adjustments required for C1WebChart corrections.
  - SmartTag now updates its properties when changed using the Properties
    or Wizard dialogs

2.0.20073.17231     20-Aug-2007
  - Internal changes.  
  - Added new Japanese localizations.

2.0.20072.17187     07-Jul-2007
  - Internal changes.  

2.0.20072.17156     06-Jun-2007
  - Internal changes.  

2.0.20072.17142     23-May-2007
  - Internal changes.  

2.0.20072.17140     21-May-2007
  - Internal changes.  

2.0.20072.17134     15-May-2007
  - Internal changes.
  - Improved style handling for Chart3DPointSeries.
  - Added UseGrayscale property to the chart object.  This boolean property
    allows rendering of the charts in grayscale as a preview for non-color
    printers.

2.0.20071.17096     07-Apr-2007
  - Internal changes.
  - Fixed a compilation errors when both chart controls are in the same C++
    WinForms project.
  - Fixed a problem with Chart3DPointSeriesCollection.AddRange() - the series
    styles were lost after adding them to the collection. 
  - Fixed a cosmetic problem with with 3D Chart Properties/Wizard designer
    gallery.

1.0.20071.17032     02-Feb-2007
  - Internal changes.
  - Zoned surface charts now correctly display with all combinations of contours
    and shading.

1.0.20071.17030     31-Jan-2007
  - Internal changes.

1.0.20071.17023     24-Jan-2007
  - Internal changes.

1.0.20071.17002     03-Jan-2007
  - Internal changes.

1.0.20071.17001     02-Jan-2007
  - Internal changes.

1.0.20071.16354     21-Dec-2006
  - Internal changes.

1.0.20071.16346     13-Dec-2006
  - Internal changes.
  - Fixed a problem with incorrect appearance of zoned chart with custom levels.

1.0.20071.16332     29-Nov-2006
  - Internal changes.
  - Added Interaction property that allows to control settings of built-in
    interactive features(rotate, zoom, scale, translate).

1.0.20071.16289     17-Oct-2006
  - Internal changes.
  - Added couple of methods(BeginUpdate()/EndUpdate()) which allows
    multiple(batched) chart updates to be performed without excessive repainting.
   
1.0.20063.16281     09-Oct-2006
  - Internal changes.
  - Transparency for Chart3DSymbolStyle now can be set individually,
    when A component of Color/Outline color is less than 255 this value
    is used when plotting, if A=255 the common Elevation.Transparency is
    applied. Previously it was fully controlled by Elevation.Transparency.
  - Added Chart3DPointSeriesCollection.AddRange()/RemoveRange methods which
    provides fast way for adding/removing large number of data series.

1.0.20063.16228     17-Aug-2006
  - Internal changes.

1.0.20063.16219     08-Aug-2006
  - Internal changes.

1.0.20062.16205     25-Jul-2006
  - Internal changes.

1.0.20062.16183     03-Jul-2006
  - Internal changes.

1.0.20062.16182     02-Jul-2006
  - Internal changes.

1.0.20062.16143     24-May-2006
  - Internal changes.  
 
1.0.20062.16128     09-May-2006
  - Internal changes.  

1.0.20062.16127     08-May-2006
  - Internal changes.

1.0.20062.16123     04-May-2006
  - Internal changes.

1.0.20062.16122     03-May-2006
  - Internal changes.
  - Fixed a problem with border color. It was sometimes cleared after changing
    border style.

1.0.20062.16120     01-May-2006
  - Internal changes.

1.0.20062.16110     21-Apr-2006
  - Internal changes.

1.0.20062.16106     17-Apr-2006
  - Internal changes.
  - AboutBox adjustments.

1.0.20062.16103     14-Apr-2006
  - Basic chart elements now are exposed through accessibility interfaces.
  - Fixed performance issue when working with properties of Chart3DContour
    object.
  - Added localized Japanese descriptions for UseAntiAliasGraphics and
    UseAntiAliasText.
  - Wizard and Properties dialogs are no longer shown in the taskbar.

1.0.20062.16099     10-Apr-2006
  - Internal changes.

1.0.20062.16098     09-Apr-2006
  - Internal changes.
  - Chart3DLabel.Size property now is saved correctly at designtime.
  - Added UseAntiAliasedText and UseAntiAliasedGraphics properties.

1.0.20062.16087     29-Mar-2006
  - Internal changes.
  - Fixed several localization issues specific for .Net 2.0.
  - Several minor design time behaviors have been improved.

1.0.20061.16018     19-Jan-2006
  - Internal changes.
  - Several minor design time behaviors have been improved.

1.0.20061.16009     10-Jan-2006
  - Internal changes.
  - Fixed several localization issues.

1.0.20061.16007     08-Jan-2006
  - Internal changes.
  - Both the BarColorCollection and the LevelCollection editors now properly
    restore the previous chart state when the Cancel button is pressed.

1.0.20061.16002     03-Jan-2006
  - Internal changes.

1.0.20061.15363     30-Dec-2005
  - Internal changes.

1.0.20061.15362     29-Dec-2005
  - Internal changes.

1.0.20061.15354     21-Dec-2005
  - Internal changes.

1.0.20061.15353     20-Dec-2005
  - Internal changes.

1.0.20061.15342     09-Dec-2005
  - Internal changes.

1.0.20053.15339     06-Dec-2005
  - Internal changes.

1.0.20053.15321     18-Nov-2005
  - Internal changes.
  - Aboutbox email handler changes.

1.0.20053.15320     17-Nov-2005
  - Internal changes.

1.0.20053.15308     05-Nov-2005
  - Internal changes.

1.0.20053.15307     04-Nov-2005
  - Internal changes.

1.0.20053.15306     03-Nov-2005
  - Internal changes.

1.0.20053.15299     27-Oct-2005
  - Internal changes.

1.0.20053.15288     16-Oct-2005
  - Internal changes.

1.0.20053.15236     25-Aug-2005
 - Internal changes.

1.0.20053.15235     24-Aug-2005
 - Internal changes.

1.0.20053.15234     23-Aug-2005
 - Internal changes.

1.0.20053.15233     22-Aug-2005
 - Internal changes.

1.0.20053.15225     14-Aug-2005
 - Added new Japanese translations.

1.0.20053.15213     02-Aug-2005
 - Added GetMetafile() method.
 - Added AutoFit property of Chart3DView object which controls x/y ratio for
   2D projection chart.
 - Added PrintChart() method with PageSettings parameter.
 - Improved performance of contour chart plotting.
 - Various bug fixes.

1.0.20052.15205     25-Jul-2005
 - Internal changes.

1.0.20052.15197     17-Jul-2005
 - Internal changes.

1.0.20052.15181     01-Jul-2005
  - Japanese and English localization for all builds

1.0.20052.15171     21-Jun-2005
  - Additional translations made/corrected for Japanese version.

1.0.20052.15163     13-Jun-2005
 - Internal changes.

1.0.20052.15115     26-Apr-2005
 - Internal changes.

1.0.20052.15111     22-Apr-2005
  - Internal changes.

1.0.20052.15109     20-Apr-2005
  - Internal changes.

1.0.20052.15108     19-Apr-2005
  - Internal changes.

1.0.20052.15103     14-Apr-2005
  - Additional Japanese translations.

1.0.20052.15102     13-Apr-2005
  - Various bug fixes.

1.0.20052.15097     08-Apr-2005
  - Borders with rounded corners are drawn using anti-aliasing.

1.0.20051.15083     25-Mar-2005
  - Additional translations made/corrected for Japanese version.
  - Chart designer now limits Perspective, XScale, YScale to appropriate ranges.

1.0.20051.15082     24-Mar-2005
  - Additional translations made/corrected for Japanese version.
  - Various bug fixes.

1.0.20051.15080     22-Mar-2005
  - Additional translations made for Japanese version.

1.0.20051.15075     17-Mar-2005
  - Various bug fixes.

1.0.20051.15072     14-Mar-2005
  - Various bug fixes.

1.0.20051.15063     05-Mar-2005
  - Various bug fixes.

1.0.20051.15059     01-Mar-2005
  - Corrected behavior of property dialog, under several conditions the
    changes were not applied after closing dialog.
  - Fixed the problem with label names in collection editor.
  - Miscellaneous bug fixes.

1.0.20051.15016     17-Jan-2005
  - Internal changes.
  - Fixed additional problems with PropertyGrid behaviors involving Location,
    LocationDefault, Size and SizeDefault when other object properties are
    changed.

1.0.20051.14362     28-Dec-2004
  - Fixed a problem with the collection editor whereby a background image could
    be lost after using the editor.
  - Fixed some problems with PropertyGrid behaviors involving Location,
    LocationDefault, Size and SizeDefault when other object properties are
    modified.

1.0.20051.14349     15-Dec-2004
  - Some problems in the properties dialogs have been corrected.
  - Cancel from the properties dialog now undoes only the changes made since the
    properties were last applied.  Previously, the chart reverted to its default state.
  - Behavior of the data grid editor using Visual Studio.Net 2003 has been corrected.

1.0.20051.14343     09-Dec-2004
  - Internal changes
  - Added XML help file.

1.0.20051.14326     22-Nov-2004
  - Internal changes.

1.0.20044.14284     11-Oct-2004
  - Internal changes.

1.0.20044.14265     22-Sep-2004
  - Internal changes.

1.0.20044.14260     17-Sep-2004
  - Internal changes.

1.0.20044.14252     09-Sep-2004
  - Internal changes.

1.0.20044.14231     19-Aug-2004
  - Internal changes.
  - Added new C1Chart3D property, UseDoubleBuffer.
  - C1Chart3D now correctly responds to runtime help requests.

1.0.20043.14175     24-Jun-2004
  - Internal changes.

1.0.20043.14162     11-Jun-2004
  - Internal changes.

1.0.20043.14144     24-May-2004
  - Internal changes
  - new C1Chart3D event LayoutLabels which allows to reposition labels
    depending on location of other chart elements or data points.

1.0.20042.14090     31-Mar-2004
  - Internal changes.  
  - Fixed the problem with legend visibilty under several conditions.
  - Reset() methods now clear BackgroundImage property.
  - Fixed the problems with resource-based localization.

1.0.20042.14077     18-Mar-2004
  - Internal changes.  
  - Fixed the problem with Chart3DView.Save()/Restore(), under several
    conditions the scaling was not correct after Restore() method.
  - Fixed the problem with BackColor and ForeColor properties after Reset()
    method.
  - Internal changes to allow use of charts in IE as a rich client.

1.0.20042.14063     04-Mar-2004
  - Internal changes.
  - Added new constructors and methods to accommodate the use of jagged arrays
    for the construction of data sets and contour arrays.  The new constructors
    and methods include:
  
      Chart3DDataSetGrid(double, double, double, double, object z);
      Chart3DDataSetIrGrid(double, double, double, double, object z);
  
      object GetJaggedGridData();
      void SetJaggedGridData(object z);
  
      object GetJaggedContourData();
      void SetJaggedContourData(object z);
  
    These methods are useful for both sparse grids and programming languages
    which work primarily with jagged arrays.

1.0.20042.14060     01-Mar-2004
  - Fixed the problem with Chart3DPointDataSet that caused exception
    when changing style properties of Chart3DPointSeries if data set is
    not attached to the chart.

1.0.20041.13346     13-Dec-2003
  - Fixed the problem with general alignment of chart titles( header, footer
    and legend). There was delay in initial chart rendering when running
    under VS2003 in debug mode.
  - Added Reset() method.
  - Added "Reset Chart" and "Reset To Default Chart" verbs to the designer.
    These verbs reset the chart to its default state.  The second verb
    restores the initial default numeric data as well.

1.0.20041.13328     25-Nov-2003
  - Internal changes.

1.0.20041.13317     14-Nov-2003
  - Internal changes.
  - Added OutlineColor and OutlineWidth properties to the ChartSymbolStyle
    object that control drawing of symbol outline.

1.0.20041.13316     13-Nov-2003
  - Internal changes.

1.0.20034.13295     23-Oct-2003
  - Internal changes.
  - Added OutlineColor and OutlineWidth properties to the ChartSymbolStyle
    object that control drawing of symbol outlines.
  - Chart now throws an error when SaveImage requests unavailable image
    formats.
  - PrintChart method with ScaleNone now correctly prints a chart the
    same measured size as the chart on the screen.  Previously, it was
    printing according to the ScaleToFit definition.
  - Data hole behavior has been corrected.
  - Designtime handling of collection some properties and their elements
    could result in thrown errors.  These errors have been fixed.
  - Property changed events now fire correctly.
  - Save/Load Data to/from file now works correctly for Points layouts.
  - Label placement problems have been corrected.
  - Legend behaviors have been corrected.
  - Reset methods now fully reset their objects.
  - Round border behavior has been corrected.

1.0.20034.13279     7-Oct-2003
  - Internal changes.
  - A problem with loading C1Chart3D properties at design time when CopyLocal
    for the C1Chart3D dll is true, and C1Chart3D is also in the GAC has been
    corrected.

1.0.20034.13244     2-Sep-2003
  - Internal changes.
  - Chart and chart elements(Header, Footer, ChartArea, Legend) now can
    have border with rounded corners, added new Rounding property of
    Border object and Rounding class to control this feature.

1.0.20033.13238     27-Aug-2003
  - Methods CoordToDataCoord() and DataCoordToCoord() of Chart3DData object
    now supports double data coordinates as parameters.
  - Fixed a problems with CoordToDataIndex() method of Chart3DData when
    row number is not equal to column number.
  - Internal changes.

1.0.20033.13147     28-May-2003
  - Added boolean property Connected to the Chart3DPointSeries object 
    that defines whether the series points are connected with lines.
  - Added boolean property Boxed to the Chart3DView object that controls
    visibility of plotting cube edges.
  - Fixed bug with importing point data set from ActiveX ComponentOne format.
  - Internal changes.

1.0.20032.13084     26-Mar-2003
  - Legend orientation values persisted at design time can now be loaded
    correctly.
  - Internal changes.

1.0.20032.13063     5-Mar-2003
  - Internal changes.
  - Fixed bug that legend display is not correct for zoned chart.
  - Fixed bug with custom contour levels and styles.
  - Fixed bug with bar contour chart when using custom contour data.
  - Added text wrapping for headers, footers, axes.  Legend header and
    labels will also wrap, but require manual sizing, as default sizing
    assumes a single line.  A new style property named Autowrap (default
    is true) controls the automatic wrapping.

1.0.20031.23161     16-Feb-2003
  - Added readonly properties AssemblyFileVersionString and
    AssemblyVersionString to chart.  These properties return strings
    indicating version information of the chart.
  - Modified internal serialization to speed up serialization of large
    datasets.
  - Modified Layout property to eliminate message box confirmation when
    changing the property with code.
  - Fixed bug that did not allow input of PointSeries values.
  - Internal changes.

1.0.20031.22041     4-Jan-2003
  - Changed internal data storage from float (Single) to double (Double) to
    allow processing of a wide range of numbers and proper scaling for
    dates.  Also, a large number of exposed data related properties have also
    changed from float (Single) to double (Double), including data holes,
    Axis min and max values, etc.
  - Internal changes.

1.0.20024.22161     16-Dec-2002
  - Corrected problem with zero width or zero height image
    generation that caused an exception.

1.0.20024.22031     3-Dec-2002
  - Fixed bug with Charts licensing associated user controls
    inheritting directly from the chart controls.
  - Fixed bug with Charts licensing associated with running
    the chart wizard/properties dialogs from a user control.
  - Internal changes.

1.0.20024.21181     18-Nov-2002
  - Fixed bug with Charts licensing associated with VB usercontrols.
  - Internal changes.

1.0.20024.20151     15-Oct-2002
  - Added AnnoPosition property to the Chart3DAxis and corresponding enum AnnoPositionEnum.
    It allows to choose position of axis annotation and title.
  - Added background hatching and color gradients.
  - Internal changes.

1.0.20024.18281     28-Aug-2002
  - Added boolean Repaint property.  When set to false, most automatic repaints
    of the chart during property changes are inhibited.  When set to true,
    forces an immediate repaint of the chart and allows automatic repaints
    with property changes.
  - Internal changes.

1.0.20023.16051 - 05-June-02 
  - Added support of C1.C1PrintDocument.ControlPrinters.IC1ControlPrintable
    interface for using with C1PrintDocument.





----------------------------------------------------------------------------
Saved Chart Files
----------------------------------------------------------------------------
Examples of saved charts are now included in the Samples\ChartFiles folder.
Charts can be load from the demos or at design time using the context menu.

2D Chart files
   CpuUsagePies.chart2dxml . . . . . . . . . pie chart
   EngineTestBar.chart2dxml. . . . . . . . . bar chart
   EyeResponse_xyplot.chart2dxml . . . . . . multiple series XY plot
   HiLoOpenCloseVolume.chart2dxml. . . . . . stock type chart
   TraceElementAnalysis.chart2dxml . . . . . area chart

3D Chart files
   4dbars.chart3dxml . . . . . . . . . . . . 4d bar chart
   4dsurface.chart3dxml. . . . . . . . . . . 4d surface chart with floor projection
   elevate.chart3dxml. . . . . . . . . . . . elevation contours
   kimberlite.chart3dxml . . . . . . . . . . complex surface chart with projection
   population.chart3dxml . . . . . . . . . . 3d bar chart
   scatter.chart3dxml. . . . . . . . . . . . scattered 3d point data with droplines
   shock.chart3dxml. . . . . . . . . . . . . contour projection



Chart Sample Applications
----------------------------------------------------------------------------
Examples of chart applications included in the Samples folder.  The
applications can be run and executed by loading the appropriate project
files.  All sample applications are available in both C# and VB.


2D Chart sample programs
------------------------

Alarmz
  - creates a 2d scatter chart for student grades
  - AlarmZones flag each of the letter grade zones
  - legend indicates plotted grade statics
  - xy coordinate labels are used to supplement the
    legend information

AlarmZoneShapes
  - creates a default XY chart
  - demonstrates various types of AlarmZones including rectangles,
    ellipses and polygons.
  - demonstrates the use of moveable ValueLabels in Mixed mode, with marker
    characteristics.

AutoArrangement
  - creates an XY plot
  - demonstrates automatic placement of chart labels that avoid
    label overlap.

Box
  - creates a Box-and-Whisker-Chart using randomly generated data.
  - two ChartGroups are used to superimpose horizontal candle
    chart data with XYPlot data and line symbols to produce the
    Box-and-Whisker effect.

Bubbles
  - creates a bubble chart
  - tracks the mouse movement and provides information
    about selected data points as selected by the mouse
  - axis value labels are demonstrated

CandyBox
  - creates an area chart
  - shows various symbols
  - label attachments are shown
  - plays an animated game

ChartLoader
  - loads 2D and 3D charts from saved XML
  - allows the loaded charts to be edited through various means,
    including the Chart Properties Dialog, the Chart Wizard Dialog,
    and a basic Property Grid.
  - allows loaded and edited charts to be save as XML, or as
    chart images.
  - useful as a utility for manipulating chart XML files at runtime
    and storing the chart state

Chlabels
  - creates a horizontal bar chart
  - labels are dynamically generated base upon
    mouse position describing various chart elements
    and data points.
  - bar values can be changed interactively using the
    mouse position and buttons.

CpuUsage
  - creates multiple charts
  - XY plot with alarm zones show current cpu usage
  - XY plot tracks cpu usage history
  - timer used for data sampling

CustomBrushes
  - creates charts of multiple types
  - demonstrates the use of available brushes
    and textures in each chart type

CustomDraw
  - creates a 2D XYPlot with a single series in the form of a spiral.
  - using the ChartDataSeries Draw event, the spiral is drawn using
    multiple colors.

DataBoundChart
  - creates a 2D horizontal bar chart from a database
  - X-Axis ValueLabels are created and used by specifying
    a text/string Datafield for the X vectors of each series.
  - demostrates databinding.

DataChart
  - creates a 2D horizontal bar chart from a database using code
  - X-Axis ValueLabels are created and added to the axis in code.
  - DOES not demostrate databinding, as all data operations are
    performed in code and the results copied into the chart.

DataStyl
  - creates various 2d charts by radion button selection.
  - demonstrates mouse tracking for each type of chart,
    for both the data points and the legend.
  - types of charts include XYPlot, Bar, Pie, Area,
    High-Low-Open-Close, Candle, Polar, Radar, and Bubble.
  - stacking is demonstrated for appropriate chart types.

DiskSpace
  - creates pie charts
  - pie charts display current disk usage
  - shows 3D pie chart effects
  - shows labels and legends

Donut
  - creates a doughnut chart
  - demonstrates the use of tooltips and series highlighting.
  - demonstrates variance of a 3D doughnut chart elevation and rotation.
  - demonstrates variance of the doughtnut chart inner radius.

ErrorBar
  - creates an XY Plot, and uses a second ChartGroup
    to plot High-Low-Open-Close data providing Error
    bars around the original XY data points. 

FloatBar
  - creates a stacked bar chart.
  - shows the effect of hiding and excluding
    series from the stack bars

Function2D
  - creates an XYPlot or Polar chart based
    upon specified functions.
  - demostrates series data editting through
    a runtime property grid.

Gantt
  - shows a basic Gantt style chart.
  - creates a Gantt chart showing starting and ending dates of
    numbered tasks.  Chart labels are added to indicate the exact
    starting and ending times of each data point.

Histogram
  - creates a 2D scatter chart with random data
  - develops a histogram in a second ChartGroup based on the distances
    of each of the scatter points from a set of crosshairs.
  - crosshairs are generated using moveable ValueLabels with markers
    (arrows) and gridlines.
  - demostrates the three types of distribution charts are available using
    histogram charts, including Histogram, Frequency graph and a Stepped
    Frequency graph.
  - demostrates the superposition of a Normal (Gaussian) distribution
    fit to the chart plot area, that can be shown for comparison purposes.
  - demonstrates statistics calculations about the distributions
  - demonstrates the use of DataLabels to automatically label each data
    point with label collision avoidance.
  - demonstrates the use of Rtf formatting in the chart footer.

HistTemp
  - creates a 2D XY plot of seasonal average mean temperatures
    in Kansas City, Mo., USA.
  - in a second chart, a bar chart containing histogram data is generated
    using one of the C1Chart.GenerateHistogramData method overloads showing
    the distribution of the difference from average mean temperatures
    through the years.
  - statistics are calculated by the chart for each data series and presented
    in an accompanying text box.

HLCandle
  - creates various types of price charts, including
    High-Low, High-Low-Open-Close, Candle and Complex
    Candle charts.
  - demonstrates various options associated with each
    kind of chart.

Interview
  - creates radar chart
  - demonstrates legend orientation
  - shows alpha blending with filled radar
  - demonstrates the effects of antialiasing

Multi
  - creates multiple charts on the same form
  - animates the charts with a timer
  - allows printing and print preview of a page
    with all three charts.
  - demostrates the use of the chart Draw function
    which renders the chart to a Graphics object.

PieStuff
  - creates a pie chart with labels.
  - demonstrates pie functions including offsets, starting
    angle and series hiding.
  - mouse tracking of the slices and legend are demonstrated.

PointStyles
  - shows the use of PointStyles.
  - creates PointStyles with different options and applies them to
    bar and scatter chart data points
  - custom PointStyles are used to color data points depending
    upon their absolute y-values

PrintIt2D
  - reads in 2d or 3d persisted charts from the Samples\ChartFiles
    folder, or persisted charts generated from other demos.
  - prints, previews, and saves images to files and clipboard.
  - demostrates various scaling methods.

PropGrid (Demo2D)
  - explores C1Chart control in runtime using property grid
  - most features of the 2d chart, including mouse tracking
    are demonstrated by this one demo.

Radar
  - creates a radar chart
  - demonstrates the use of value labels
  - demonstrates filled and stacked radar options

RtfTitle
  - creates a simple 2D XYPlot
  - adds headers and footers with RFT formatting.
  - a simple RTF editor using a RichTextBox control is part of the
    sample to allow modifications of the header and footer.

Scatter
  - creates a scatter chart with random data
  - tracks the mouse movement indicating data
    point selection.
  - plays a game of connect the dots, moving
    data points from one series to another.
  - labels (optionally shown) are attached to
    the moved data points, indicating their
    order of use.

SelectSeries
  - creates an inverted XYPlot with multiple series
  - demonstrates an axis scrollbar with and strip chart like
    appearance and function.
  - demonstrates series selection with a mouse click and the
    series highlighting.

StepChart
  - creates a step chart
  - demonstrates the use of tooltips
  - demonstrates the effects of change 3D elevations and rotations
    for step charts with 3D effects.
  - demonstrates mouse tracking capability for a step chart.

StockChart
  - creates a typical stock chart display
  - combines two chart types, candle and bar
  - uses multiple Y axes

Tooltip
  - creates a 2D XYPlot
  - demonstrates the use of the chart tooltip functions, properties
    and events.

TrendAndError
  - shows different types of trend line.
  - creates two charts
  - one chart (top) represents random data with a polynomial trend line,
    the order of polynomial can be changed using menu.  Data points on
    this chart can be moved using mouse
  - second chart (bottom) shows regression errors for each point on the
    first chart and two trend lines show the maximum positive and negative
    errors

TrendLines
  - creates pseudo-random data using various models
  - plots the generated data along with different
    types of trend lines.
  - for regression trend lines the additional statistics
    information is calculated.



3D Chart sample programs
------------------------

Chart4D
  - creating 4-d bar and surface chart
  - create 2 different regular grid data sets and switch between them in runtime
  - switch between different contour data arrays
  - mofiying zone colors set in runtime on the property grid

CoordMapping3D
  - using coordinate mapping functions
  - drawing over chart using OnPaint event
  - using value and value labels annotation methods
  - using chart label attached by data index
  - changing grid data Z-value
  - using hole value
  - setting color for indidvidual bar

Function3D
  - creating different regular grid datasets in runtime
  - using meshed and shaded charts
  - using contour and shaded charts
  - rotation of the chart
  - using different 3d and 2d views of the chart
  - changing color appearance 

PropGrid3D (Demo3D)
  - exploring C1Chart3D control in runtime using property grid
  - detailed description of this sample program is in the documentation

Scatter3D
  - creating point data set with many data series
  - dynamically changing data values in point dataset
  - setting visibilty of individual data series
  - using scatter drop lines
  - setting chart styles
  - using chart labels attached by data index
