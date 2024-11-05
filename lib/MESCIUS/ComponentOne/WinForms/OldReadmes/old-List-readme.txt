C1List Product Version 2/4.1.20142.305    August 06, 2014
============================================================
[79142] Cell tip behavior is now consistent with other
controls for RTL situations and extends left from the mouse
point.
[79209] Vertical scrollbar ScrollTips have been adjusted such
that they appear to the left of the scrollbar for RTL situations..

C1List Product Version 2/4.1.20142.304    August 04, 2014
============================================================
[78858] An uninitialized variable in the previous version has
is no correctly initialized.  This corrects a design time
exception.

C1List Product Version 2/4.1.20142.303    August 01, 2014
============================================================
[56434] Completed implementation of RightToLeft behavior.

C1List Product Version 2/4.1.20142.302    July 28, 2014
============================================================
[71793] First character in C1Combo is deleted when the 
data source is cleared at runtime.
[70544] RowChange event does not fire for every combo box change
[73236] "Violette" theme is still affected in C1List although 
change to another theme

C1List Product Version 2/4.1.20142.301    June 28, 2014
============================================================
[61696] Theme is not applied to C1Combo's TextArea.

C1List Product Version 2/4.1.20142.300    June 27, 2014
============================================================
* 2014 v2 drop

C1List Product Version 2/4.1.20141.251    April 4, 2014
============================================================
[61364] [Regression]EditorBackColor is not affected while VisualStyle is set to C1Combo.

C1List Product Version 2/4.1.20141.250    March 21, 2014
============================================================
Updated theming style and color resets when setting VisualStyles.

C1List Product Version 2/4.1.20141.249    March 20, 2014
============================================================
Updated theming to be consistent with TrueDBGrid. 
Studio Ultimate licensing is now explicitly handled by List/Combo.

C1List Product Version 2/4.1.20141.248    March 4, 2014
============================================================
[17587] Error is observed on resize inherited form when base form contains private C1List/C1Combo object 

C1List Product Version 2/4.1.20141.247    Feb 27, 2014
============================================================
[51418] [C1Combo] DropDownlists now honor leading blanks during
   incremental searches.

C1List Product Version 2/4.1.20141.246    Feb 21, 2014
============================================================
Added ControlThemeVersion class.
Added more fully qualified design assembly name (PublicKeyToken)
   for the 4x DesignerAttribute. (Tfs-50367).

C1List Product Version 2/4.1.20141.245    Feb 21, 2014
============================================================
Localized to korean and chinese description of "DrawItem" event.


C1List Product Version 2/4.1.20141.244    Feb 7, 2014
============================================================
[50665] [C1Combo] Description of ‘DrawItem’ event in property grid  is incorrect.

C1List Product Version 2/4.1.20141.243    Feb 4, 2014
============================================================
* 2014 v1 drop

C1List Product Version 2/4.1.20133.242    Jan 30, 2014
============================================================
[49765] The C1Combo behaviors related to BackColor, ReadOnly
    and Enabled have been improved. (Tfs-49765 and Tfs-36777)

C1List Product Version 2/4.1.20133.241    Jan 27, 2014
============================================================
[48384] Blinking cursor now correctly appear in C1Combo if the
    language settings are set to Arabic. (Tfs-48384)

C1List Product Version 2/4.1.20133.240    Oct 29, 2013
============================================================
[41748] A Design Time Exception is no longer raised when
    adding controls on an Inherited Form containing C1Combo.

C1List Product Version 2/4.1.20133.239    Oct 15, 2013
============================================================
Added support for C1ThemeControl for .NET 4x.

C1List Product Version 2/4.1.20133.238    Oct 14, 2013
============================================================
Added support for C1ThemeControl for .NET 2x.

C1List Product Version 2/4.1.20132.237    Aug 08, 2013
============================================================
[40531] Bound data translated by Radiobuttons at design time
now translate correctly.


C1List Product Version 2/4.1.20132.236    Aug 01, 2013
============================================================
[40410] Check boxes are now included in printing and exports.


C1List Product Version 2/4.1.20132.235    July 31, 2013
============================================================
[40406] Row headers are now automatically sized with the data
rows when printing and exporting.


C1List Product Version 2/4.1.20132.234    July 30, 2013
============================================================
[22294] All records are now exported to excel file if
'OnePerPageSheet' property is set to True during print/export
operations.


C1List Product Version 2/4.1.20132.233    July 26, 2013
============================================================
[36574] C1Combo controls with ComboStyle as DropDownlist
now fire the DrawItem event for the combo value as well as
the list values when DrawMode indicates OwnerDraw.


C1List Product Version 2/4.1.20132.232    July 23, 2013
============================================================
[38512] DataBinding with Enums as Keys are now properly
handled by List and Combo.


C1List Product Version 2/4.1.20132.231    June 04, 2013
============================================================
URL changes for GrapeCity JPN AboutBox.


C1List Product Version 2/4.1.20131.230    June 04, 2013
============================================================
[37420] The behavior of the Combo styles with respect to
the Enter keypress is now consistent with the standard combo.


C1List Product Version 2/4.1.20131.229    June 03, 2013
============================================================
[35380] The behavior of the Combo styles is with respect to
the Escape keypress is now consistent with the standard combo.
[36777] When a combo is ReadOnly, the appearance also reflects the
ReadOnly state, regardless of mouse movement.


C1List Product Version 2/4.1.20131.228    April 04, 2013
============================================================
Additional changes for new GrapeCity licensing model.


C1List Product Version 2/4.1.20131.227    March 28, 2013
============================================================
Changed to new GrapeCity licensing model.


C1List Product Version 2/4.1.20131.226    February 28, 2013
============================================================
[33117] Revisited.  Scrolling in C1Combo by using mouse wheel
        no longer results in an overflow exception on 64bit
        machines.


C1List Product Version 2/4.1.20131.225    February 20, 2013
============================================================
[33863] The ShowHeaderCheckBox property has been localized
        for Japanese, Chinese and Korean. 


C1List Product Version 2/4.1.20131.224    February 08, 2013
============================================================
[33117] Scrolling in C1Combo by using mouse wheel no longer
        results in an overflow exception on 64bit machines.


C1List Product Version 2/4.1.20131.223    February 07, 2013
============================================================
[33863] The missing property description for the ‘ShowHeaderCheckBox’
        property has been added in English.  Localizations for
        Japanese, Chinese and Korean are pending.


C1List Product Version 2/4.1.20131.222    January 18, 2013
============================================================
Internal changes only.


C1List Product Version 2/4.1.20123.221    December 14, 2012
============================================================
[30641] [24764-139][Regression]If the MaxDropDownItems is set
        to 8 C1Combo is not rendered correctly

  MaxDropDownItems is now honored through a Rebind() operation.
        
[30810] While AutoSelect='True' and calling ClearItems() method,
        the text of previously selected item remains visible in
        TextArea of C1Combo

  AutoSelect now behaves correctly when ClearItems() is called
  in nnbound mode.

C1List Product Version 2/4.1.20123.220    November 09, 2012
============================================================
[29277] [17748-139]Request to support the DataField property of
        C1List/C1Combo to be case-insensitive (revised).

C1List Product Version 2/4.1.20123.219    November 08, 2012
============================================================
[29863] Exception occurs when user scroll to selectedindex using
        ScrollCtl method in BeforeOpen or Open event

C1List Product Version 2/4.1.20123.218    November 02, 2012
============================================================
[29625] [25045-139] Removing of Last item of a BindingList<>
   bound to C1List with RemoveAt() no longer generates an
   exception.

C1List Product Version 2/4.1.20123.217    October 29, 2012
=========================================================
Internal changes of some combo descriptions.

        
C1List Product Version 2/4.1.20123.216    October 29, 2012
=========================================================
[28960] Descriptions for some properties and events are
        now localized in Korean and Chinese

        
C1List Product Version 2/4.1.20123.215    October 26, 2012
=========================================================
Internal changes related to designer/editor specifications.
[29373] Adding a new column in the Designer no longer generates
        an exception.  (Introduces in build 214).
[28123] The DrawItem event of C1Combo now provides a non-null
        e.Column value.

        
C1List Product Version 2/4.1.20123.214    October 25, 2012
=========================================================
[28072] Multi-threading initialization of C1List and C1Combo
        causes exceptions.
[28956] DisplayMember and ValueMember properties of C1Combo
        do not work and Control's name gets shown in TextBox
[28123] Copy of the effective CellStyle is passed to C1Combo
        DrawItem event via the event args.
[27648] Column selection in Designer now operative again.
[29277] The DataField property of C1List/C1Combo is now case-insensitive

The Localization basis is now CurrentUICulture instead of
CurrentCulture.


C1List Product Version 2/4.1.20123.213		October 10, 2012
=========================================================
Internal changes for 2012v3 release.


C1List Product Version 2/4.1.20122.212		October 10, 2012
=========================================================
Chinese and Korean localizations have been adjusted.


C1List Product Version 2/4.1.20122.211		October 10, 2012
=========================================================
[28905] Added IC1EmbeddedEditor implementation to C1Combo.
        This improves the behavior of the C1Combo control when used as an editor 
		for the C1FlexGrid and C1TrueDBGrid grids.

C1List Product Version 2/4.1.20122.210		October 9, 2012
=========================================================
Chinese and Korean localizations have been added.


C1List Product Version 2/4.1.20122.209		August 30, 2012
=========================================================
[19772] PageUp/PageDown key are not working for row navigation when
        SelectionMode is set to 'CheckBox'.  This has been corrected.

C1List Product Version 2/4.1.20122.208		August 16, 2012
=========================================================
[25095] Selected Tab is change in C1Ribbon instead of items in drop down
        portion is scroll after using mouse wheel when C1ComboBox is used
        as ControlHost.

The mouse wheel behavior for both C1List and C1Combo have been improved
and standardized, including the DropDownList.


C1List Product Version 2/4.1.20122.207		August 15, 2012
=========================================================
[25095] Selected Tab is change in C1Ribbon instead of items in drop down
        portion is scroll after using mouse wheel when C1ComboBox is used
        as ControlHost.

The mouse wheel behavior for both C1List and C1Combo have been improved
and standardized.


C1List Product Version 2/4.1.20122.206		August 10, 2012
=========================================================
[24796] Correct Style does not apply in C1Combo control when Office2010 Visual Style is applied
[21434] C1Combo broken when autoscale in high DPI - adjusted Defaults.
Added Visual Studio 2012 style toolbox bitmaps and logic.

C1List Product Version 2/4.1.20122.205		August 2, 2012
========================================================
[21434] C1Combo broken when autoscale in high DPI
[22872] Request to provide more VisualStyle - The VisualStyles in C1List now
        match those available in TDBGrid.

C1List Product Version 2/4.1.20122.204		July 6, 2012
========================================================
[23533] ArgumentOutOfRangeException 'Index was out of range.Must be non-negative...'  
is thrown if StudioEF control is binding with C1List

C1List Product Version 2/4.1.20122.202		July 03, 2012
========================================================
Company and Copyright changes to GrapeCity, Inc.


C1List Product Version 2/4.1.20122.201		May 21, 2012
========================================================
2012 T2 Builds


C1List Product Version 2/4.1.20121.199		May 2, 2012
========================================================
[21434] [12542-139] C1Combo broken when autoscale in high DPI


C1List Product Version 2/4.1.20121.198		April 9, 2012
========================================================
[20616] [10934-139]C1Combo does not work with respect to bindingNavigator contorl
[14334] [2569-139][Enhancement]Request to provide the feature to export the C1List content to the Excel file


C1List Product Version 2/4.1.20121.197		Feb 21, 2012
========================================================
Fixed an issue that SelectionChangeCommitted is fired before selected index changed.


C1List Product Version 2/4.1.20121.196		Feb 3, 2012
========================================================
SelectionChangeCommitted should not be fired when the drop down is opened.


C1List Product Version 2/4.1.20121.195		Feb 2, 2012
========================================================
[12904] Cannot set 'AllowColSelect' property to True for C1List from its Designer dialog box
[12898] When navigating rows by arrow key ,rows are moved though scroll bar is left at the top
[19541] [10501-139] Unlike MS ComboBox control , SelectionChangeCommitted() event of C1Combo is fired on changing the value through code


C1List Product Version 2/4.1.20113.194		Jan 20, 2012
========================================================
[18624] [9433-139]When SeclectionMode is set to CheckBox, then the scrollbar does not move according to keyboard navigation


C1List Product Version 2/4.1.20113.193		Nov 30, 2011
========================================================
Enhancements/Documentation/Behavior Changes
------------------------------------------- 
- Updated licensing to conform with Federal Information Processing Standards requirements. [TFS-18562]


C1List Product Version 2/4.1.20113.190		Nov 21, 2011
========================================================
** Added a new property "ShowHeaderCheckBox".
[18253] [8871-139][Enhancement]Request to provide Up and Down keys to be getting affected,when 'c1List.SelectionMode= CheckBox'
[18255] [8871-139]'HighlightedRowStyle' property of c1List does not work
[18296] [8680-139][Enhancement]Request to make C1Combo support IC1EmbeddedEditor interface (Case 2)


C1List Product Version 2/4.1.20113.189		Nov 7, 2011
========================================================
** [18212] C1List does not property work with hierarchical data from C1DataSource.

C1List Product Version 2/4.1.20113.188		Oct 10, 2011
========================================================
** [17587] [Forum] Error is observed on adding any control on inherited form when base form contains private C1List/C1Combo object


C1List Product Version 2/4.1.20113.187		Oct 04, 2011
========================================================
** New license code for FIPS Compliance situations.


C1List Product Version 2/4.1.20113.186		Sep 22, 2011
========================================================
** When column has ValueItems, and the Translate is turned on, the displayed value is not the translated string.


C1List Product Version 2/4.1.20113.185		Sep 10, 2011
========================================================
2011 T3 Builds


C1List Product Version 2/4.1.20112.184		July 15, 2011
========================================================
** Allow user to specify the width of column in ColMov event.
** Allow user to drag columns to new line in multiple-lines view.


C1List Product Version 2/4.1.20112.183		July 6, 2011
========================================================
** Visual Studio crashes when setting C1DataSource to C1List for entity framework data


C1List Product Version 2/4.1.20112.182		June 30, 2011
========================================================
** [15720] [5541-139]In MultipleLines DataView List, detection of the cell always indicate the first row layout columns


C1List Product Version 2/4.1.20112.181		June 7, 2011
========================================================
** Added ToolTip property to ComboBox


C1List Product Version 2/4.1.20112.180		June 3, 2011
========================================================
** In Office2007xxx visual style, if user changed the EditorBackColor property to non-default value, hover effect is disabled


C1List Product Version 2/4.1.20112.179		May 8, 2011
========================================================
** [Forum][C1Combo][Enhancement] Request for "SelectionChangeCommitted" event


C1List Product Version 2/4.1.20111.178		April 6, 2011
========================================================
** Dropdown button was changed to no border style when FlatStyle is flat.
** [14641] [3532-139]When maximizing the form,containing C1List which is binded more data row than can be visible in the List, previously hidden rows are not visible
** [14325] [2398-139]When C1List is placed inside nested container, the vertical scrollbar of C1List is starting in the wrong position and showing partially the first row


C1List Product Version 2/4.1.20111.177		Feb 15, 2011
========================================================
** Licensing code was updated.


C1List Product Version 2/4.1.20111.176		Jan 31, 2011
========================================================
** [2335 - 139]NullReference Exception thrown on called ClearItems() method where "C1.Win.C1List.C1Combo" is subclassed


C1List Product Version 2/4.1.20111.175		Dec 26, 2010
========================================================
2011 T1 builds


C1List Product Version 2/4.1.20103.174		Sep 10, 2010
========================================================
** [11175] [3391] NullReference Exception thrown on selecting value second time from a combobox, when adding items to another combo box based on AddItemCols property.
** [12568] [3560] "ColumnDivider.Style" cannot be set to None using C1List Designer


C1List Product Version 2/4.1.20102.173		June 4, 2010
========================================================
2010 T2 builds.


========================================================
C1List Product Version 2/4.1.20101.172		May 20, 2010
========================================================
Corrections
------------------
** [10787] [C1List] Vertically scrolling the list to last row when Dock is set to 'Fill' and resizing the form covers the bottom rows by dead area.
** [10846] C1List and C1Combo are found vertically scrolled till end when horizontal splits are added to the controls.
** [10854] DisplayValue, of an item of ValueItem Collection, set at runtime, does not reflect on the column immediately.
** [10869] C1Combo item gets selected on the right click of the mouse unlike the MS Combo.
** [10877] C1List and C1Combo are seen one row vertically scrolled down at runtime.


========================================================
C1List Product Version 2/4.1.20101.171		May 16, 2010
========================================================
Enhancements/Documentation/Behavior Changes 
-------------------------------------------
** [10650] DisplayColumn.AllowFocus property is hidden to end user.

Corrections
------------------
** [10789] [C1List2.0][C1Combo2.0] "Error invoking 'Designer'" observed on opening Designer of C1List and C1Combo.
** [10786] Split.Name property does not update correctly on adding splits.


========================================================
C1List Product Version 2/4.1.20101.170		May 12, 2010
========================================================
Corrections
------------------
** [10789] [C1List2.0][C1Combo2.0] "Error invoking 'Designer'" observed on opening Designer of C1List and C1Combo.
** [10787] [C1List] Vertically scrolling the list to last row when Dock is set to 'Fill' and resizing the form covers the bottom rows by dead area.
** [10786] Split.Name property does not update correctly on adding splits.
** [10718] [C1List] Multiple issues with SpringMode property.
** [10707] [C1Combo] Opening C1Combo, scrolling it and choosing a row does not close the combo.


========================================================
C1List Product Version 2/4.1.20101.169		May 6, 2010
========================================================
Corrections
------------------
** [10665] [4.0 ClientProfile][C1List][C1Combo] Ellipsis next to all Style Properties are missing in the PropertyGrid.
** [10718] [C1List] Multiple issues with SpringMode property.
** [10703] Style set to a DisplayColumn at runtime does not reflect immediately.
** [10692] [3327] Designer closes if a column added after another column in C1List Designer is chosen from dropdown list of columns in Columns ToolBar.
** [10719] [4.0 ClientProfile] Split Name in SplitCollectionEditor for a single split is shown as "ListBox View".


========================================================
C1List Product Version 2/4.1.20101.168		Apr. 13, 2010
========================================================
.NET Framework 4.0 is added.


========================================================
C1List Product Version 2.1.20101.165		Jan. 10, 2010
========================================================
Corrections
------------------
** Tab key does not move focus when ComboStyle is DropdownList.


========================================================
C1List Product Version 2.1.20101.164		Dec. 28, 2009
========================================================
Corrections
------------------
** PartialColumns property in samples were removed.
** [7941] SelectedValue property of C1Combo doesn't seem to be working when C1Combo is bound with list of objects
** [8533] [C1Combo] Scrolling the combobox using scroll button of mouse does not work when ComboStyle is set to "SimpleCombo" .
** [8576] [C1Combo] Text is right aligned after selection when the combo box width is less.


========================================================
C1List Product Version 2.1.20101.163		Dec. 28, 2009
========================================================
Corrections
------------------
** Button control is clickable when setting the e.Cancel=true in the validating event.


========================================================
C1List Product Version 2.1.20101.162		Dec. 10, 2009
========================================================
** 2009 T1 Builds


========================================================
C1List Product Version 2.1.20093.160		Oct. 28, 2009
========================================================
Corrections
------------------
** CheckBox is not displayed when the SelectionMode=CheckBox and RightToLeft is enabled.


========================================================
C1List Product Version 2.1.20093.159		Oct. 20, 2009
========================================================
Corrections
------------------
** [4532] Tab Key not getting detected under KeyDown Event
** [5239] Focus is not set on to the Combo control when the select/focus method is called from Form's Load Event
** [6230] [Samples][VB] 'Tutorial5' and 'Tutorial18' samples give an error message on rebuilding


========================================================
C1List Product Version 2.1.20093.158		Oct. 10, 2009
========================================================
** License code updated.


========================================================
C1List Product Version 2.1.20093.157		Aug. 17, 2009
========================================================
** 2009 T3 Builds.


========================================================
C1List Product Version 2.1.20092.156		June 28, 2009
========================================================
Corrections
------------------
** Control can't be licensed.


========================================================
C1List Product Version 2.1.20092.155		June 22, 2009
========================================================
Corrections
------------------
** [19369] An exception is generated when the dispose method is called for C1Combo in debug mode. 


========================================================
C1List Product Version 2.1.20092.154		June 19, 2009
========================================================
Corrections
------------------
** [4844] Error message seen when dropping C1List/C1Combo on the form



========================================================
C1List Product Version 2.1.20092.153		June 10, 2009
========================================================
** 20092 T2 build.



========================================================
C1List Product Version 2.1.20091.151		April 2, 2009
========================================================

Corrections
------------------
** [19369] An exception is generated when the dispose method is called for C1Combo in debug mode. 


========================================================
C1List Product Version 2.1.20091.150		Jan. 8, 2009
========================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
** [18472] C1Combo.Caption property does not have Localizable attributes set

Corrections
------------------
** [18762] Request to change summary of hbar.visible and vbar.visible, as visible property is read only but summary mentions that value c¡­
** [18722] Description of 'Renderer' property and 'Split Change' ,'Split Removed' , 'Visual style changed' events is missing in Propertie¡­



========================================================
C1List Product Version 2.1.20083.149		Jan. 6, 2008
========================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
None

Corrections
------------------
** [#17188] RemoveItem() method does not work properly after Sorting



========================================================
C1List Product Version 2.1.20083.148		Dec. 18, 2008
========================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
** [18720] Problem in Scrollbar Appearance and Positioning when setting Visible property at runtime


========================================================
C1List Product Version 2.1.20083.147		Nov. 30, 2008
========================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
** [17957] Request to provide HScrollBar.Visible and VScrollBar.Visible property in C1List.


========================================================
C1List Product Version 2.1.20083.146		Nov. 25, 2008
========================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
** [18437] Checkbox added in a row by setting SelectionModeEnum to Checkbox cannot be checked in C1List.
** [18390] RowDivider.Style property set to 'Single' does not show on C1Combo and C1List.


========================================================
C1List Product Version 2.1.20083.145		Nov. 14, 2008
========================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
* Automatically set the DataField property of Column for AddItem mode.



========================================================
C1List Product Version 2.1.20083.144		Nov. 6, 2008
========================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------
None

Corrections
------------------
** VS hangs when binding the list control to a data source with recursive data fields.


========================================================
C1List Product Version 2.1.20083.143
========================================================

Enhancements/Documentation/Behavior Changes 
-------------------------------------------

 * SelectedStyle is now honored when rendering using Office VisualStyles.
   Note:  When using this version for the first time you should reset the 
          VisualStyle property (i.e., change to Custom and then select your
          preferred VisualStyle). 



========================================================
C1List Product Version 2.1.20083.142		September 22, 2008
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None

Corrections
------------------
** After calling the Sort(0, C1.Win.C1List.SortDirEnum.None) method in AddItem mode, previous sorted order is not removed.
** [#12449] 'LineStyleEnum' error observed on changing the language and coming back to default again when placing c1combo after c1truedbgrid on the form.
** [#12444] SelChange event gets fired in dead area.
** [#18226] LoadLayout does not load images set on C1List and C1Combo.



========================================================
C1List Product Version 2.1.20083.141		September 11, 2008
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None

Corrections
------------------
** [#12450] Text does not get highlighted in C1Combo on pressing 'Tab' key after canceling the Validating event.



========================================================
C1List Product Version 2.1.20082.140		June 20, 2008
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None

Corrections
------------------
** C1Combo item selection causes form to flicker (#17473)



========================================================
C1List Product Version 2.1.20082.139		April 3, 2008
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None

Corrections
------------------
** Click event is fired after the DoubleClick event when clicking the list area.
** C1Combo's Office2007Blue VisualStyle shows a grey inactive background (VNLST000647)



========================================================
C1List Product Version 2.1.20081.138		March 18, 2008
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None

Corrections
------------------
** 'Parameter not valid' error messages get pops up when c1sizer with c1list placed gets deleted and also when the application is saved after deletion. (VNLST000665) 
** Double Click event does not fire on the List area of the C1Combo when ComboStyle = SimpleCombo (VNLST000664) 



========================================================
C1List Product Version 2.1.20081.137		Jan. 29, 2008
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None

Corrections
------------------
** Clicking the list portion of C1Combo does not fire the click event.
** ArgumentOutOfRangeException¡¯ is raised and control is crashed when placing C1List control to the form (VNLST000652) 
** ¡®InvalidCastException¡¯ is raised when ¡®DataView¡¯ is set to ¡®MultipleLines¡¯ from property window (VNLST000653) 




========================================================
C1List Product Version 2.1.20081.136		Jan. 17, 2008
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
** Licensing logic updated.



========================================================
C1List Product Version 2.1.20081.134		Jan. 15, 2008
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None

Corrections
------------------
** [C1Combo] Unable to inherit C1Combo through 'Component Class': Designer throws Error (VNLST000650) 
** [C1Combo] White space appears below combo items when MaxDropDownItems and SelectedValue are set (VNLST000649) 



========================================================
C1List Product Version 2.1.20081.133		Jan. 1, 2008
========================================================

** 2008 T1 build.




========================================================
C1List Product Version 2.1.20073.132		October, 18, 2007
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None

Corrections
------------------
** C1Combo - GotFocus event not getting raised consistently (VNLST000644) 



========================================================
C1List Product Version 2.1.20073.131		September, 20, 2007
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None


Corrections
------------------
** If a C1Combo compiled on 96 DPI is viewed on 120 DPI, the display is bit corrupt in the first run. (VNLST000623) 



========================================================
C1List Product Version 2.1.20073.130		September, 12, 2007
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None


Corrections
------------------
** C1combo doesnot refresh to display correct data values with "DataTable.DefaultView.RowFilter" is changed for the DataTable. (VNLST000631) 
** VisualStyle property is localized.



========================================================
C1List Product Version 2.1.20073.129		August, 28, 2007
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None


Corrections
------------------
** Every time the form is reopened it comes up flagged ¡°*¡± on the tab for modification. (VNTDG001057)



========================================================
C1List Product Version 2.1.20073.128		August, 16, 2007
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None


Corrections
------------------
** ObjectDisposedException observed when a C1List object is used on a 'modeless' form to pass results to the parent form or closing the modeless form (VNLST000624) 
** HeaderDivider, ButtonHeader and ButtonFooter properties are not working (VNLST000622) 
** [Vista] Vertical scrollbar does not appear in the Drop Down for "Font Size" and "Column Name" in C1List Designer (VNLST000615) 
** C1Combo with its 'ReadOnly' property set to 'True' appears as if in Edit Mode when the mouse is hovered. (VNLST000629) 
** Complete cell content is not visible after autosizing columns containing foreground image and 'HorizontalAlignment' is 'Far' (VNLST000628) 
** Alpha Channnel value is not applied to the selected column (VNLST000619) 
** In C1List and C1Combo, celltips size exceed the cell size if length of cell content is larger than celltips width (VNLST000625) 




========================================================
C1List Product Version 2.1.20072.126		July, 19, 2007
========================================================

Enhancements/Documentation/Behavior Changes 
----------------------------------
None


Corrections
------------------
** AutoSize property is invisible in property grid.



========================================================
C1List Product Version 2.1.20072.125		July, 15, 2007
========================================================

Enhancements/Documentation/Behavior Changes 
----------------------------------
None


Corrections
------------------
** Clicking on a hilighed entry would not select the item.




========================================================
C1List Product Version 2.1.20072.124
========================================================

Enhancements/Documentation/Behavior Changes 
----------------------------------
None


Corrections
------------------
** Tuned the VisualStyle to have it work properly inside C1Ribbon.



========================================================
C1List Product Version 2.1.20072.123
========================================================

Enhancements/Documentation/Behavior Changes 
----------------------------------
None


Corrections
------------------
** Different problems observed related to the Color for Column Captions on setting Visual Style property to Office2007 styles (VNLST000621) 
** Checkboxes are not visible when the Selection mode property is set to "CheckBox" (VNLST000620) 
** Alpha Channnel value is not applied to the selected column (VNLST000619)
** "Index was out of range" error pops up on loading the Saved xml file that contain BackGround/ForeGround Images set for different Styles (VNLST000612) 
** [2.0]Unexpected behavior of "FontSize" combo box in C1List Designer on entering the values from the keyboard. (VNLST000608) 
** [1.x/2.0]Setting the ¡°ComboStyle¡± to ¡°DropDownList¡±, changing the alignment of the editor via the "TextAlign" property,has no effect, in C1combo. (VNLST000603) 
** [1.x/2.0]In certain scenarios of C1List,Vertical scroll bar appears over the data and in others data in some splits disappears. (VNLST000602) 
** Unlike at Design time, VisualStyles do not get apply at Run time. (VNLST000618) 
** [1.x]HelpRequested event is fired two times for c1combo. (VNLST000599) 
** [1.x/2.0]Grey area is displayed at the bottom of the control when SelectionMode is changed from Checkbox to MultiSimple. (VNLST000584) 
** [1.x/2.0]Program inactive for few seconds when adding 5000 records by AddItem method (VNLST000551) 



========================================================
C1List Product Version 2.1.20072.122
========================================================

Enhancements/Documentation/Behavior Changes 
----------------------------------
None


Corrections
------------------
** Unable to set the C1List.VisualStyle property to 'Custom' (VNLST000617) 
** Unable to re-select the last row of previously selected rows after calling ClearSelected() method (VNLST000616) 
** Unable to set the 'SelectedValue' property (returns Nothing) when the 'ValueMember' field's datatype is Decimal (VNLST000609) 



========================================================
C1List Product Version 2.1.20072.121
========================================================

Enhancements/Documentation/Behavior Changes 
----------------------------------
** Added VisualStyle property.


Corrections
------------------
None




========================================================
C1List Product Version 2.1.20072.119
========================================================

Enhancements/Documentation/Behavior Changes 
----------------------------------
** 2007 T2 build.

Corrections
------------------
None



========================================================
C1List Product Version 2.1.20071.118
========================================================

Enhancements/Documentation/Behavior Changes 
----------------------------------

** The ButtonWidth property was readonly, in this build user can set value to it.
** Style objects were not persisted in designer.

Corrections
------------------
** Smart Tab is popped up while changing the DataSource property.




========================================================
C1List Product Version 2.1.20071.117
========================================================

Enhancements/Documentation/Behavior Changes 
----------------------------------

None.

Corrections
------------------

** VisibleRows property was returning one less than the number of visible rows.  (VNLST000598)

** Anchored CellTips was incorrectly positioned when RightToLeft was true.  (VNLST000595)



========================================================
C1List Product Version 2.1.20071.116       Tuesday Oct 31, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.

Corrections
------------------
** The ¡°AfterSort¡± event is getting fired before the event ¡°ColHeadClick¡± for the c1List as compared to c1combo. (VNLST000589)
** Negative values are accepted for ColumnFooterHeight and VScrollBar and Split Caption Height of C1List and C1Combo. (VNLST000590) 




========================================================
C1List Product Version 2.1.20071.115       Monday Oct 16, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.

Corrections
------------------
** Grey area is displayed at the bottom of the control when SelectionMode is changed from Checkbox to MultiSimple. (VNLST000584) 
** Cell tips do not show all the text when foreground image is set. (VNLST000576) 
** Unexpected result occurs when Presentation is 'checkBox'and NumberFormat is 'Yes/No' or 'On/Off' for a particular column. (VNLST000575) 
** BackColor2 is not effected in the column which Presentation value is ¡®CheckBox¡¯ (VNLST000574) 
** Desire row is not selected when C1List has 2 splits and one split has caption but the other doesn¡¯t. (VNLST000570) 
** If ¡®DataMember¡¯ property changes frequently then unexpected behavior occurs. (VNLST000571)




========================================================
C1List Product Version 2.1.20063.114       Saturday Oct 1, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.

Corrections
------------------
** C1List Designer closes when 'Make all columns same width'/ 'Increase column width'/ 'Decrease column width' buttons are clicked. (VNLST000581)
** C1List control crashes when DataView is set to MultipleLines and EmptyRows to True. (VNLST000583) 



========================================================
C1List Product Version 2.1.20063.113       Friday September 29, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.

Corrections
------------------
** C1List Designer closed without notification when DataView of C1List Contorl is ¡®MultipleLines¡¯ (VNLST000568)
** Can't select a row twice when SelectionMode is ¡®CheckBox¡¯ and ¡®MultiSimple¡¯ selection. (VNLST000569) 
** Some localization issues.


========================================================
C1List Product Version 2.1.20063.112       Monday September 25, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.

Corrections
------------------
** VS 2005 IDE closed when C1List control is resized. (VNLST000566) 




========================================================
C1List Product Version 2.1.20063.111       Friday September 15, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.

Corrections
------------------
** Inconsistent behavior of row height shown at design time. (VNLST000560) 
** Hand cursor appears without placing on the column at design time. (VNLST000564) 
** Marked the obselete attribute for the RowResize event of C1Combo.
** At run time, inserting and removing horizontal split by user behaves unexpectedly (VNLST000522) 



========================================================
C1List Product Version 2.1.20063.110       Tuesday September 13, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.

Corrections
------------------
** Dropdown window of the C1Combo is being displayed on the Primary monitor when the 
application using the C1Combo is on the seconday monitor (VNLST000518) 



========================================================
C1List Product Version 2.1.20063.109       Monday September 11, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.

Corrections
------------------
** Some localization issues.



========================================================
C1List Product Version 2.1.20063.108       Tuesday September 4, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.

Corrections
------------------
** Control crashes on setting Alpha to 256 in C1List (VNLST000519) 
** To select data column in C1List Designer, need to set ¡®AllowColSelect¡¯ to True (VNLST000547) 
** RemoveHorizontalSplit/RemoveVerticalSplit option doesn¡¯t disable in the designer on removing all the splits. (VNLST000548) 
** Application hangs when EmptyRows = true and ItemHeight = -1 (VNLST000537) 
** Application closes when DataView property of C1List is set to ¡®MultipleLine¡¯ view. (VNLST000531) 
** Designer does not refreshes properly in a certain scenario. (VNLST000545) 
** An unbound C1List control does not refresh itself on adding the splits at design time. (VNLST000544) 
** Application Crashes when a c1list or c1combo control is placed on the form and windows theme is swithched from 'Windows classic' to 'Windows XP'. (VNLST000543) 
** Information sorted on the behavior of RowChange event of c1List when a column of c1combo control is sorted. (VNLST000542) 
** Unhandled ¡®ArugumentOutOfRange¡¯ exception occurs in ClearField method for C1Combo and C1List (VNLST000541) 
** 'ColumnHeader' property can not be set through designer. (VNLST000539) 
** Error Message occurs at DesignTime on setting Selection Mode property to 'None' after 'Checkbox' (VNLST000533) 
** "System.Reflection.TargetInvocationException" occurs on calling the SaveLayout method when the data is displayed using the value items. (VNLST000530) 
** An unhandled 'system.OverflowException' occurs on resizing the form when Anchor property is set to 'All' and 'SpringMode' is set to true. (VNLST000526) 
** C1Combo trims the blank spaces from the string added to the list using the 'AddItem' method (VNLST000517) 
** Unable to close the winform using Alt+F4 keys when the focus is on C1Combo (VNLST000516)
** Inconsistent behavior observed on Setting the "Presentation" property of the "ValueItems" object of a particular column to "Radio Button" . (VNLST000512) 
** Clicking the ellipsis besides the "Background Image " property in the C1List Designer gives an error message. (VNLST000511) 
** Sort icon not appearing on Fixed Columns (VNLST000508) 
** Foreground picture of CaptionStyle is displayed outside the Caption area on setting position to 'BottomOfText' (VNLST000540) 



========================================================
C1List Product Version 2.1.20063.107       Thursday August 17, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
Localization enhancement.

Corrections
------------------
None.


========================================================
C1List Product Version 2.1.20062.106       Friday June 23, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.

Corrections
------------------
** With DropDownPosition property of C1combo set to DefaultPosition, the drop down's horizontal position does not change with the position of the combo. 



========================================================
C1List Product Version 2.1.20062.105       Monday May 29, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.

Corrections
------------------
** ValueItem(string value, object displayValue) constructor does not work.


========================================================
C1List Product Version 2.1.20062.104       Friday May 12, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.

Corrections
------------------
** Splits once inserted can not be deleted. (VNLST000506) 




========================================================
C1List Product Version 2.1.20062.103       Tuesday May 09, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.

Corrections
------------------
** Some of the columns of List becomes invisible when some of the columns are fixed and Horizontal scroll Bar is Scrolled. (VNLST000505) 
** C1List designer closes without any notification in a certain senario. (VNLST000504) 



========================================================
C1List Product Version 2.1.20062.102       Monday May 08, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.

Corrections
------------------
** Fixing a column also freezes the resizing of the column. (VNLST000501) 
** Column divider not aligned poperly when RightToLeft is set to True. (VNLST000500) 
** Application crashes when C1Combo is bound to an array (VNLST000495) 




========================================================
C1List Product Version 2.1.20062.101       Monday May 08, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
** Setting AutoSelect property at runtime will auto-select the combo.

Corrections
------------------
** When AutoSelect is false, the SelectedIndex should be -1 after the Combo is firstly initialized.



========================================================
C1List Product Version 2.1.20062.100       Friday May 05, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
** PartialRightColumn property is obseleted.
** FixedColumn only affect the scrolling, does not affect resizing. (Changed the document to clarify this point).  To disable resizing, please change the C1DisplayColumn.AllowSizing to false.


Corrections
------------------
** Height of the lower vertical split keeps on decreasing every time the C1List designer is opened. (VNLST000497) 
** AutoCompletion property of C1Combo not working. (VNLST000496) 
** Application crashes when C1Combo is bound to an array (VNLST000495) 
** FindString() & FindStringExact() methods of C1List return -1 when used in the AddItem Mode. (VNLST000494) 
** 'SelChange' event does not get fired when first row is selected even after selecting other rows in the column. (VNLST000493) 
** Few Columns disappear when FixColumn property of other columns is set to True. (VNLST000488) 




========================================================
C1List Product Version 2.1.20062.99       Monday April 10, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
** Added ClearRegexCellStyle method to C1List and C1Combo class.

Corrections
------------------
** Remove button for the default Styles in the Styles Collection Editor gets enabled in a certain scenario (VNLST000485) 
** Unable to select the row after clicking on the column header. (VNLST000475) 
** DataField property effects the caption of the datacolumn. (VNLST000472) 
** Mouse gets trapped in Row selection region while resizing the row. (VNLST000471) 
** Fixed Columns can be resized once we autosize their width. Also, any column divider lies inside initial width of fix column cannot be resized. (VNLST000470) 
** Unable to delete more than one split from column designer at a time. (VNLST000469) 
** The view of C1List gets distorted when some of column made fix and width of other columns is resized to zero. (VNLST000467) 
** The view of C1List gets distorted when some of column are fixed and Horizontal scroll Bar is Scrolled. (VNLST000466) 
** ColumnDivider displayed at the right edge of the column even when the RightToLeft property for C1List is set to 'Yes'. (VNLST000465) 


========================================================
C1List Product Version 2.1.20061.98       Tuesday March. 28, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
** Added Accessibility support

Corrections
------------------
** The BackGround & the ForeGround images once set through the Editors accessed from the SmartTag cannot be then removed. (VNLST000479)
** The values once set in the FontDialogBox gets reset to the Default values when the DialogBox is opened again. (VNLST000478) 
** The Project closes when the DataSource property is first set to the Dataset & then set to the Table through the Smart Tag. (VNLST000477)
** Some Columns not displayed in the visible area of the C1List when the form is maximized. (VNLST000459) 
** Refreshing problem observed in C1List when the FooterDivider property for any Column is set to False. (VNLST000455) 
** Misalignment of data in Vertical Splits observed when the Verical Split is added & ColumnHeader property is set to Fale. (VNLST000456) 



========================================================
C1List Product Version 2.1.20061.97       Monday March 8, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
** None

Corrections
------------------
** When TaskBar is on top of the screen, the dropdown list position is not correct.


========================================================
C1List Product Version 2.1.20061.96       Monday March. 6, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
** Allow changing the background color and foreground color for columns in designer.
** Allow applying styles to column headers in designer.

Corrections
------------------
** Obfuscate Issue.
** Resolved some issues in designer.


========================================================
C1List Product Version 2.1.20061.95       Tuesday Feb. 28, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
** Added some new style elements: Padding, BackColor2, GammaCorrection, GradientMode, Alpha
** Added SplitChange event
** Added SaveLayout and LoadLayout methods
** New Column Designer
** New Style Editor
** Enhance the design time abiities: Glyphs, Behaviors and ActionList
** Unexpected behavior observed for SelectedRowStyle property in C1Combo (VNLST000452)

Corrections
------------------
None.



========================================================
C1List Product Version 2.1.20061.94       Tuesday Feb. 21, 2006
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------

Corrections
------------------
** The Visible property of C1DisplayColumn does not persist in code-behind. (VNLST000457) 
** Column can not be select in columns designer if the AllowColSel property is false.
** ContextMenuStrip was not associated with the editor control of the combo box.


========================================================
C1List Product Version 2.1.20061.93       Thursday Feb. 2, 2005
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None

Corrections
------------------
** Setting the FlatStyle to System does not change the Visual Style to XP theme.



========================================================
C1List Product Version 2.1.20061.92       Friday Dec. 9, 2005
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None

Corrections
------------------
** Row selection disappears after the row has been deleted in the C1LIst using RemoveItem() method (VNLST000450) 
** Horizontal Scrollbars not working correctly when datasource contains only single column and Column width is increased. (VNLST000449) 
** Horizontal scrollbar is distorted when multiple splits are created and SplitSize is set (VNLST000448) 



========================================================
C1List Product Version 2.1.20061.91       Wednesday Nov. 23, 2005
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
** When mouse move over the drop down list of C1Combo, hot track item will be highlighted, 
selected row will not be painted with selectedstyle.
** Array could be bound to C1Combo. 


Corrections
------------------
** The newly inserted record does not get deleted using RemoveItem method (VNLST000444) 
** DeadArea is visible when SelectionMode property is changed from "CheckBox" to "None" and Horizontal scroll bar is at extreme right corner (VNLST000443) 
** The Fixed Column is getting resized when SelectionMode is set to "CheckBox". (VNLST000442) 
** Pressing Escape Key closes the standard combo box but not C1Combo control. (VNLST000434) 
** The ClearSelected() method in conjuction with SelectionModeEnum is not working properly (VNLST000432) 
** Dead area is displayed on left when ExtendRightColumn is used with RightToLeft and SelectionMode property (VNLST000429) 


========================================================
C1List Product Version 2.1.20061.90       Wednesday Oct. 26, 2005
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.


Corrections
------------------
** Dropdown list can not dropped. (Hotfix)
** When C1Combo.AutoCompletion=true, after user types string that exists in the list, the whole text will be selected.



========================================================
C1List Product Version 2.1.20061.89       Wednesday Oct. 12, 2005
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.


Corrections
------------------
** Dead area is visible even when ExtendRightColumn does is true and SelectionMode is checkbox. (VNLST000395) 
** View distorted when [ComboStyle] = [SimpleCombo] and the [RightToLeft] property = True (VNLST000387) 
** Checkboxes are displayed on the left(SelectionMode =Checkbox) when RightToLeft is set to Yes. (VNLST000378) 
** C1Combo in a UserControl goes into a loop when validation fails (VNLST000426) 
** The last column can not be resized when the list has scrollbars enabled.(VNLST000398)



========================================================
C1List Product Version 2.1.20053.90       Wednesday Oct. 26, 2005
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
None.


Corrections
------------------
** When C1Combo.AutoCompletion=true, after user types string that exists in the list, the whole text will be selected.
** Dead area is visible even when ExtendRightColumn does is true and SelectionMode is checkbox. (VNLST000395) 
** View distorted when [ComboStyle] = [SimpleCombo] and the [RightToLeft] property = True (VNLST000387) 
** Checkboxes are displayed on the left(SelectionMode =Checkbox) when RightToLeft is set to Yes. (VNLST000378) 
** C1Combo in a UserControl goes into a loop when validation fails (VNLST000426) 
** The last column can not be resized when the list has scrollbars enabled.(VNLST000398)



========================================================
C1List Product Version 2.1.20053.88       Friday Oct. 7, 2005
========================================================
Enhancements/Documentation/Behavior Changes 
----------------------------------
** AllowSort = false, user can not sort the column by mouse. But calling the Sort() method can sort the column.


Corrections
------------------
** Add/Remove buttons are not disabled in the SplitCollection Editor. (VNLST000423)
** Unable to move columns even when AllowColMove=True in C1Combo.(VNLST000418)
** Columns can be selected even when AllowColSelect=False in C1Combo. (VNLST000417) 
** Unable to open the Styles Collection Editor in C1Combo. (VNLST000416) 
** CellTips not shown properly when the right edge of the C1List is not in the Screen's visible area. (VNLST000408) 
** Unable to scroll the C1List using the ScrollButton when a row >= the C1List's visible area. (VNLST000406) 
** The Columns in the C1List appear at the run-time even after deleting them from the Column Collection Editor. (VNLST000403) 
** Dead area is visible even when ExtendRightColumn does is true and SelectionMode is checkbox. (VNLST000395) 
** View distorted when [ComboStyle] = [SimpleCombo] and the [RightToLeft] property = True (VNLST000387) 
** Checkboxes are displayed on the left(SelectionMode =Checkbox) when RightToLeft is set to Yes. (VNLST000378) 
** C1Combo in a UserControl goes into a loop when validation fails (VNLST000426) 




========================================================
C1List Product Version 2.1.20053.87       Tuesday Sept 20, 2005
========================================================
Build for VS.NET 2005 Beta2 (50215)
