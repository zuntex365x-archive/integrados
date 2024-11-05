===========================================================================
C1Schedule                         ComponentOne, LLC - www.componentone.com
===========================================================================

- Welcome to ComponentOne C1Schedule.  

ComponentOne C1Schedule is an integral part of Studio Enterprise, the largest 
and most complete toolset for developing Win, Web, Mobile and ASP.NET AJAX 
enabled applications. 

Please direct feedback for C1Schedule to the following forum:
	http://helpcentral.componentone.com/cs/forums/60/ShowForum.aspx
or newsgroup: 
	news://newsforums.componentone.com/net.scheduler_for_.net


- Support and Feedback Options

ComponentOne is dedicated to providing reliable best-of-breed components.  
If you have any issues using our products, we want to know about it.  
Please use the following pages for information to get support.
  
Online Support: http://helpcentral.componentone.com
Support Center: http://www.componentone.com/Support 

To submit a support request, report a bug, or request a feature, please use our 
online Incident Submission Form.  Note that we ask you to be logged into your 
ComponentOne Account to submit an incident.

Login or Create an Account: 
	http://www.componentone.com/c1account/pages/MyAccountMain.aspx


- Installed Files

ComponentOne C1Schedule installs the following files and components.
 Files: C1.Win.C1Schedule.2.dll
 Components: C1Schedule, C1Calendar

=================================================================================
C1Schedule Build Number 2.0.20142.297, 4.0.20142.297  Build Date: 09/04/2014
=================================================================================
Corrections
-------------------------------------------
* internal changes.

=================================================================================
C1Schedule Build Number 2.0.20142.296, 4.0.20142.296  Build Date: 08/29/2014
=================================================================================
Corrections
-------------------------------------------
* FirstVisibleTime & AutoScrollToFirstAppointment property does not work for timespan 23:31 to 23:59 (Tfs 83744).

=================================================================================
C1Schedule Build Number 2.0.20142.295, 4.0.20142.295  Build Date: 07/26/2014
=================================================================================
Corrections
-------------------------------------------
* fixed current time representation when C1Schedule.ShowWorkTimeOnly is true (Tfs 77186).

=================================================================================
C1Schedule Build Number 2.0.20142.294, 4.0.20142.294  Build Date: 07/24/2014
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added RightToleft layout support in the C1Scheduler control (Tfs 68336).

=================================================================================
C1Schedule Build Number 2.0.20142.293, 4.0.20142.293  Build Date: 06/20/2014
=================================================================================
* 2014 V2 build

Corrections
-------------------------------------------
- fixed text direction in the C1Schedule navigation panes for Korean culture (Tfs 65581).

=================================================================================
C1Schedule Build Number 2.0.20141.292, 4.0.20141.292  Build Date: 06/09/2014
=================================================================================
Corrections
-------------------------------------------
- [43916] 'BeforeAppointmentResize' event is fired twice when appointment is resized. (Tfs 69316).

=================================================================================
C1Schedule Build Number 2.0.20141.291, 4.0.20141.291  Build Date: 06/04/2014
=================================================================================
Corrections
-------------------------------------------
- fixed text direction in the C1Schedule navigation panes for Chinese culture (Tfs 65581).

=================================================================================
C1Schedule Build Number 2.0.20141.289, 4.0.20141.289  Build Date: 04/07/2014
=================================================================================
Corrections
-------------------------------------------
- the C1Schedule control fires DragOver event (Tfs 61556). The sample of using:
        private void c1Schedule2_DragOver(object sender, DragEventArgs e)
        {
            Appointment app = c1Schedule2.GetAppointmentAtPoint(new System.Drawing.Point(e.X, e.Y));
            if (app != null)
            {
			    // prevent drop if there is conflicting appointment
                e.Effect = DragDropEffects.None;
            }
        }
   Note, it only works for dragging external objects to the C1Schedule control. 
   The only event for drag&drop operations inside the C1Schedule control is BeforeAppointmentDrop event.

=================================================================================
C1Schedule Build Number 2.0.20141.288, 4.0.20141.288  Build Date: 03/27/2014
=================================================================================
Corrections
-------------------------------------------
- fixed NullReferenceException at dropping appointment from FlexGrid to C1Calendar (see the sample attached to tfs issue 61556).

=================================================================================
C1Schedule Build Number 2.0.20141.287, 4.0.20141.287  Build Date: 03/10/2014
=================================================================================
Corrections
-------------------------------------------
- fixed incorrect layout of overlapping appointments
  (http://our.componentone.com/groups/topic/appointment-rendering-issue/).

=================================================================================
C1Schedule Build Number 2.0.20141.286, 4.0.20141.286  Build Date: 03/03/2014
=================================================================================
Corrections
-------------------------------------------
- fixed issue with not showing minutes in the time ruler when ShowWorkTimeOnly is true and time format doesn't use AP/PM designators
  (http://our.componentone.com/groups/topic/showworktimeonly-bug/#post-609260).

=================================================================================
C1Schedule Build Number 2.0.20141.285, 4.0.20141.285  Build Date: 02/20/2014
=================================================================================
Corrections
-------------------------------------------
- Appointment is created by pressing the Enter key in the Export dialog (Tfs 51679).

=================================================================================
C1Schedule Build Number 2.0.20141.283, 4.0.20141.283  Build Date: 02/17/2014
=================================================================================
Corrections
-------------------------------------------
- End time is shown as twice in appointment at MonthView when Form is Maximized (Tfs 51587).

=================================================================================
C1Schedule Build Number 2.0.20141.282, 4.0.20141.282  Build Date: 02/14/2014
=================================================================================
Corrections
-------------------------------------------
- updated Korean and Chinese error message (Tfs 48158).
- Start time(hour) and End time(hour) of Appointment is not shown immediately in all day area (Tfs 51554).

=================================================================================
C1Schedule Build Number 2.0.20141.281, 4.0.20141.281  Build Date: 02/10/2014
=================================================================================
* 2014 V1 build

Corrections
-------------------------------------------
- [C1Schedule]Unlike MS-Outlook, ‘Subject’ of Appointment is not shown on next day in Week View and Work Week View (Tfs 49902).
- internal changes related to the theme support.

=================================================================================
C1Schedule Build Number 2.0.20133.280, 4.0.20133.280  Build Date: 01/31/2014
=================================================================================
Corrections
-------------------------------------------
- fixed issue with custom date fomrst in the C1Schedule's title (http://our.componentone.com/groups/topic/wrong-date-displayed-in-date-navigation-bar).

=================================================================================
C1Schedule Build Number 2.0.20133.279, 4.0.20133.279  Build Date: 01/23/2014
=================================================================================
Corrections
-------------------------------------------
- fixed issue with closing opened appointment dialogs when removing appointment (Tfs issue 49903).

=================================================================================
C1Schedule Build Number 2.0.20133.278, 4.0.20133.278  Build Date: 01/20/2014
=================================================================================
Corrections
-------------------------------------------
- fixed issue with NullReference exception at importing data with changed reminder value from the same source (Tfs issue 49663).
- show correct AM/PM designators when ShowWorkTimeOnly is true and the default time for the designator is invisible (Tfs issue 49673).

=================================================================================
C1Schedule Build Number 2.0.20133.276, 4.0.20133.276  Build Date: 01/09/2014
=================================================================================
Corrections
-------------------------------------------
- [C1Theme] Unhandled exception has occurred if "Symbol Next" is set over range of utf32 in c1ThemesDesinger (Tfs 48344).

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added support for cases when working time should last from one day to another.
  If CalendarInfo.EndDayTime property value less than CalendarInfo.StartDayTime property value, 
  working time will be represented as 2 time intervals - from day start to CalendarInfo.EndDayTime 
  and from CalendarInfo.StartDayTime to day end.
  The C1Schedule control honors this setting when ShowWorkTimeOnly property is true.
  Note, when ShowWorkTimeOnly is true, the C1Schedule always shows the full hour.
  So some free time might be included into the view.

=================================================================================
C1Schedule Build Number 2.0.20133.275, 4.0.20133.275  Build Date: 12/24/2013
=================================================================================
Corrections
-------------------------------------------
- [C1Schedule] '11:30 PM to 12:00' time slot is not fully showed when ShowAllDayArea is false (Tfs 48230).
- fixed validation of GroupBy property (Tfs 48258).
- [C1Schedule] 'BeforeAppointmentDrop' event is fired although appointment is not moved using arrow key (Tfs 48272).

=================================================================================
C1Schedule Build Number 2.0.20133.274, 4.0.20133.274  Build Date: 12/23/2013
=================================================================================
Corrections
-------------------------------------------
- 'New appointment' button is not updated instantly after new appointment is created (Tfs 48086).
- C1Schedule.BeforeAppointmentDrop event is fired for cases when end-user moves appointment with keyboard arrow keys
  (http://our.componentone.com/groups/topic/beforeappointmentxxx-event-for-key-movement/).

=================================================================================
C1Schedule Build Number 2.0.20133.273, 4.0.20133.273  Build Date: 12/20/2013
=================================================================================
Corrections
-------------------------------------------
- fixed issue with BeforeAppointmentSave event (Tfs 47962).
- fixed C1Calendar navigation to the last month (Tfs 48015).

=================================================================================
C1Schedule Build Number 2.0.20133.272, 4.0.20133.272  Build Date: 12/19/2013
=================================================================================
Corrections
-------------------------------------------
- fixed issue with adding extra recurrence appointments if recurrence pattern 
  is added to existing appointment in TimeLineView (Tfs issue 47918).

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- the next C1Schedule samples have been updated with the new BeforeAppointmentCreate functionality:
  * MultiUserCustomForms (VB, CS)
  * CustomForms (VB)
  * CustomData (CS)

=================================================================================
C1Schedule Build Number 2.0.20133.271, 4.0.20133.271  Build Date: 12/19/2013
=================================================================================
Corrections
-------------------------------------------
- don't fire BeforeAppointmentShow event for already opened form (Tfs issue 47862).

=================================================================================
C1Schedule Build Number 2.0.20133.270, 4.0.20133.270  Build Date: 12/17/2013
=================================================================================
Corrections
-------------------------------------------
- fixed Shift key behavior in TimeLine view (Tfs issue 47788).

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- CancelAppointmentEventArgs class inherited from the System.ComponentModel.CancelEventArgs instead of EventArgs.
- C1Schedule.BeforeAppointmentCreate event type changed from CancelEventArgs to the CancelAppointmentEventArgs.
  When this event is fired, the new Appointment object is already initialized according to the current C1Schedule selection and settings.
  That includes appointment times, AllDay property, reminder settings and appointment group (Category, Resource, Contact or Owner depending on the current GroupBy setting).
  All appointment properties are accessible in the BeforeAppointmentCreate event handler and can be changed from custom code.
  For example:
        void c1Schedule1_BeforeAppointmentCreate(object sender, CancelAppointmentEventArgs e)
        {
            e.Appointment.Subject = "test appointment";
            e.Appointment.Location = "test location";
		}
- C1Schedule.BeforeAppointmentShow event is fired for the newly created appointments as well.   

Breaking Changes
-------------------------------------------
- C1Schedule.BeforeAppointmentCreate event type changed from CancelEventArgs to the CancelAppointmentEventArgs.
  It would require updating existing code, which uses this event (replace CancelEventArgs to CancelAppointmentEventArgs).

=================================================================================
C1Schedule Build Number 2.0.20133.269, 4.0.20133.269  Build Date: 12/13/2013
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- improved mouse right-click behavior in the C1Schedule control. 
  If end-user performs right-click over already selected time interval, selection is not altered. 
  So, "New appointment" and "New recurring appointment" context menu actions work with the selected interval. 

=================================================================================
C1Schedule Build Number 2.0.20133.268, 4.0.20133.268  Build Date: 12/12/2013
=================================================================================
Corrections
-------------------------------------------
- added CLSCompliant attribute.

=================================================================================
C1Schedule Build Number 2.0.20133.267, 4.0.20133.267  Build Date: 11/14/2013
=================================================================================
Corrections
-------------------------------------------
- removed Theme.XmlDefinition design-time serialization when C1Schedule and C1Calendar 
  controls are used with C1ThemeController (Tfs issue 46142).

=================================================================================
C1Schedule Build Number 2.0.20133.266, 4.0.20133.266  Build Date: 11/06/2013
=================================================================================
Corrections
-------------------------------------------
- fixed issue with ColorBlend serialization (45522).

=================================================================================
C1Schedule Build Number 2.0.20133.265, 4.0.20133.265  Build Date: 11/06/2013
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added special handling for selecting contrast text color if default one is close to background. 
  Depending on the default text color and background colors, text color might be changed to more dark or light 
  or converted from light to dark and vice versa.
  This works in all areas of the C1Schedule UI which are colored with palette colors:
    - group header tabs;
	- day headers;
	- month grid header;
	- navigation panels;
	- week tabs in the Month view.

=================================================================================
C1Schedule Build Number 2.0.20133.264, 4.0.20133.264  Build Date: 10/31/2013
=================================================================================
Corrections
-------------------------------------------
- honor VisualStyle property when it is set by the C1Theme.

=================================================================================
C1Schedule Build Number 2.0.20133.263, 4.0.20133.263  Build Date: 10/31/2013
=================================================================================
Corrections
-------------------------------------------
- added support for different ForeColor in the navigation panels hot style (Tfs issue 44962);
- reset format to default value when clearing it in C1ThemeDesigner (Tfs issue 44798).

=================================================================================
C1Schedule Build Number 2.0.20133.262, 4.0.20133.262  Build Date: 10/26/2013
=================================================================================
Corrections
-------------------------------------------
- fixed undesired scrolling at changing appearance settings in the C1ThemeDesigner or navigating scheduler 
  to other groups in the Month and Office 2003 Week views (Tfs issues 44439, 44514)

=================================================================================
C1Schedule Build Number 2.0.20133.261, 4.0.20133.261  Build Date: 10/25/2013
=================================================================================
Corrections
-------------------------------------------
- fixed unhandled exception when clearing or removing Base Font in the C1ThemeDesigner (Tfs issues 44384, 43400).

=================================================================================
C1Schedule Build Number 2.0.20133.260, 4.0.20133.260  Build Date: 10/23/2013
=================================================================================
Corrections
-------------------------------------------
- fixed issues with C1Themes support:
  - applying background gradient when style background is set via reference to the other style (see day headers in the Month View of the C1 Office 2007);
  - added support for reading Utf32 symbols for Next and Previous navigation buttons (for example, it's possible to set symbol number to 61663 and use Wingdings font).
  - added ScheduleTheme.PaletteType property. It is supported by the C1ThemeDesigner and allows to switch between Office2007 and Office2010 palettes.

=================================================================================
C1Schedule Build Number 2.0.20133.259, 4.0.20133.259  Build Date: 10/21/2013
=================================================================================
Corrections
-------------------------------------------
- fixed issue with broken appearance options after changing themes in the C1ThemeDesigner app. (Tfs issue 44075).

=================================================================================
C1Schedule Build Number 2.0.20133.258, 4.0.20133.258  Build Date: 10/16/2013
=================================================================================
Corrections
-------------------------------------------
- Fixed issue with not showing last time slot in Day/Work Week/Week views when 
  ShowWorkTimeOnly is true and CalendarInfo.EndDayTime is 24:00.

=================================================================================
C1Schedule Build Number 2.0.20133.257, 4.0.20133.257  Build Date: 10/02/2013
=================================================================================
* 2013 V3 build

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added C1Theme support. Both C1Schedule and C1Calendar controls are supported in the C1ThemeDesigner application. 
  That allows to use default C1 themes or custom ones and to apply them on application level.
- added support for background gradients with interpolation colors. 
  Design-time support for editing visual appearance with these gradients is implemented in the C1ThemeDesigner application.
- added new ScheduleTheme.RoundBrowseButtons property. This property determines whether 
  browse buttons in the C1Schedule title should be round or square ones. 
  The default value of this property for Office 2007 visual styles is true, for Office 2010 visual styles - false.

=================================================================================
C1Schedule Build Number 2.0.20132.255, 4.0.20132.255  Build Date: 09/20/2013
=================================================================================
Corrections
-------------------------------------------
 42150 - Appointments with intervals within few minutes of each other appear adjacent to each other instead of in the next time slot.

=================================================================================
C1Schedule Build Number 2.0.20132.252, 4.0.20132.252  Build Date: 09/17/2013
=================================================================================
Corrections
-------------------------------------------
 42060 - Flickering is observed and appointment date change to adjacent timeline when drag the appointment in single timeline.

=================================================================================
C1Schedule Build Number 2.0.20132.251, 4.0.20132.251  Build Date: 09/16/2013
=================================================================================
Corrections
-------------------------------------------
- adjusted C1Schedule.BeforeAppointmentFormat event behavior:
  - event is fired for every UI element when corresponding Appointment object is changed;
  - for drag&drop operations event is only fired when operation is finished. 

=================================================================================
C1Schedule Build Number 2.0.20132.249, 4.0.20132.249  Build Date: 09/14/2013
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- improved layout of multi day appointments in all-day area of 
  the Day/Work Week/Office 2007 Week views, in the Office 2003 Week view and in the Month view. 
  For example, for the month view, every week contains single UI element for single appointment 
  and appointment subject is spanned to all days.
  Note: it should not be a breaking change, in most cases there is no need in any code changes.
  But if you use C1Schedule.BeforeAppointmentFormat event, test how it works with new layout before publishing new version.
- improved dragging behavior. The C1Schedule control keeps relative position of the drag start point.
  For example, if you drag multi-day appointment by some middle point, appointment.Start will be changed so that 
  to move drag start point to the drop location.  

=================================================================================
C1Schedule Build Number 2.0.20132.246, 4.0.20132.246  Build Date: 08/29/2013
=================================================================================
Corrections
-------------------------------------------
- added missing localized property descriptions.

=================================================================================
C1Schedule Build Number 2.0.20132.245, 4.0.20132.245  Build Date: 08/20/2013
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
 * added new property to the C1Schedule control:
    public bool ShowWeekends { get; set;}
        This property indicates whether the control shows weekends in a Month View.
        The default value is True.

=================================================================================
C1Schedule Build Number 2.0.20132.244, 4.0.20132.244  Build Date: 08/02/2013
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added new BeforeAppointmentSave event to the C1Schedule control. 
  It is fired before end-user saves appointment by pressing 'Save' button in the AppointmentForm.
  Use this event to validate information and prompt end-user if there is something wrong or can't be saved:
     void c1Schedule1_BeforeAppointmentSave(object sender, CancelAppointmentEventArgs e)
     {
         if (string.IsNullOrEmpty(e.Appointment.Subject))
         {
             MessageBox.Show("Please fill appointment subjects");
             e.Cancel = true; // cancel event, so that AppointmentForm is not closed and end-user can fix errors.
         }
     }

=================================================================================
C1Schedule Build Number 2.0.20132.243, 4.0.20132.243  Build Date: 06/18/2013
=================================================================================
Corrections
-------------------------------------------
 37867 - Unlike previous build, 'SerializationException' is occur when recurrence appointment is export to binary file.

=================================================================================
C1Schedule Build Number 2.0.20132.242, 4.0.20132.242  Build Date: 06/03/2013
=================================================================================
Corrections
-------------------------------------------
 37343 - After dragging the appointment (has more than one categories), application hangs when setting GroupBy to “Category”.

=================================================================================
C1Schedule Build Number 2.0.20132.241, 4.0.20132.241  Build Date: 05/29/2013
=================================================================================
Corrections
-------------------------------------------
 37194 - Regression issue - recurring appointments cannot be fetched  through Appointment.Conflicts property.

=================================================================================
C1Schedule Build Number 2.0.20132.240, 4.0.20132.240  Build Date: 05/29/2013
=================================================================================
* 2013 V2 build

=================================================================================
C1Schedule Build Number 2.0.20131.239, 4.0.20131.239  Build Date: 05/26/2013
=================================================================================
Corrections
-------------------------------------------
- improved performance when working with recurring events (Tfs issue 37069).

=================================================================================
C1Schedule Build Number 2.0.20131.238, 4.0.20131.238  Build Date: 05/15/2013
=================================================================================
Corrections
-------------------------------------------
- added missing localized property descriptions.

=================================================================================
C1Schedule Build Number 2.0.20131.237, 4.0.20131.237  Build Date: 05/02/2013
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added new method to the C1Schedule control:
    public Appointment GetAppointmentAtPoint(Point location);
      Returns the Appointment object which is located in the Schedule at the given screen point.
	  The sample of using:
        c1Schedule1.MouseMove += c1Schedule1_MouseMove;
        void c1Schedule1_MouseMove(object sender, MouseEventArgs e)
        {
            Appointment app = c1Schedule1.GetAppointmentAtPoint(c1Schedule1.PointToScreen(e.Location));
            if (app != null)
            {
                Trace.WriteLine(app.Subject);
            }
            else
            {
                Trace.WriteLine("there is no appointment under mouse");
            }
        }

=================================================================================
C1Schedule Build Number 2.0.20131.236, 4.0.20131.236  Build Date: 05/02/2013
=================================================================================
Corrections
-------------------------------------------
- fixed C1Calendar layout at changing ShowWeekNumbers property.
 
=================================================================================
C1Schedule Build Number 2.0.20131.234, 4.0.20131.234  Build Date: 04/15/2013
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added new cancellable event to the C1Schedule control:
    public event EventHandler<ExchangeEventArgs> BeforeExport;
	  This event occures before the export operation performed by the C1Schedule.Export method.
      Note, this event is not fired if you export data from your code using Appointment.SaveAs or C1ScheduleStorage.Export methods.
      Use this event if you need additional handling before export.
      
=================================================================================
C1Schedule Build Number 2.0.20131.231, 4.0.20131.231  Build Date: 04/02/2013
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- updated default printing styles - PrintedDateTime tag in the page footer has been replaced by the GeneratedDateTime tag. 
- updated licensing in Japanese version.

Corrections
-------------------------------------------
- fixed C1Calendar navigation issue: 
  C1Calendar doesn't honor CalendarInfo.LastDate when navigating 
  via mouse wheel or drop-down month/year selectors (Tfs issue 35451).
- “ArgumentOutOfRangeException” is occurred after clicking navigate button of work week view when all week days are Holidays (Tfs issue 35456)

=================================================================================
C1Schedule Build Number 2.0.20131.230, 4.0.20131.230  Build Date: 03/08/2013
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added new overload for Appointment.CopyFrom method:
    public void CopyFrom(Appointment app, bool includeKeys, bool includeRecurrenceInformation);
        Copies properties from the specified Appointment object to this one. 
		Parameters: 
         - app - the Appointment instance to copy,
         - includeKeys - specifies whether to copy internal keys,
         - includeRecurrenceInformation - Specifies whether to copy recurrence information if any.
        Set includeKeys to true if you want to receive exact copy of the specified Appointment object.
        Set includeKeys to false in order to copy only descriptive Appointment properties to other Appointment object 
		(for example, if you want to duplicate appointment from one day to another)
        Set includeRecurrenceInformation to false to exclude RecurrenceState, ParentRecurrence and RecurrencePattern information.

=================================================================================
C1Schedule Build Number 2.0.20131.229, 4.0.20131.229  Build Date: 03/05/2013
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added new property to the C1ScheduleSettings class:
    public FileFormatEnum DefaultFileFormat { get; set; }
        Gets or sets the FileFormatEnum value, specifying the default file format for import and export operations.
		It is honored in the "Import Data" and "Export Data" dialogs.
        The default value is FileFormatEnum.XML.

=================================================================================
C1Schedule Build Number 2.0.20131.228, 4.0.20131.228  Build Date: 02/26/2013
=================================================================================
Corrections
-------------------------------------------
- added missing localized property descriptions.
- adjusted behavior when C1Scheduler.ContextMenuStrip property is set to custom ContextMenuStrip.

=================================================================================
C1Schedule Build Number 2.0.20131.226, 4.0.20131.226  Build Date: 02/12/2013
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added new cancellable event to the C1Schedule control:
		public event CancelAppointmentEventHandler BeforeAppointmentEdit;
			Occurs before the end-user edits Appointment object in-place.
			This allows to prevent editing individual appointments depending on your business logic. 

=================================================================================
C1Schedule Build Number 2.0.20131.225, 4.0.20131.225  Build Date: 02/05/2013
=================================================================================
Corrections
-------------------------------------------
* added Japanese translations for the new strings added in build 222.

=================================================================================
C1Schedule Build Number 2.0.20131.224, 4.0.20131.224  Build Date: 02/01/2013
=================================================================================
Corrections
-------------------------------------------
* fixed Tfs issue 33677 - regression issue with Office 2003 week view style.
* added Korean and Chinese translations for the new strings added in build 222.

=================================================================================
C1Schedule Build Number 2.0.20131.223, 4.0.20131.223  Build Date: 01/28/2013
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* added new method to the C1Schedule control: 
    public void ShowDates(DateTime[] dates, ScheduleViewEnum? view)
        Shows specified dates in the scheduler with the specified view type.
        If parameter view has no value, the C1Schedule control 
        will select the most appropriate view depending on specified dates.

=================================================================================
C1Schedule Build Number 2.0.20131.222, 4.0.20131.222  Build Date: 01/21/2013
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* adjusted C1Calendar control behavior. 
  The C1Calendar control doesn't fire SelectionChanged event while end-user keeps mouse left button pressed. 
  C1Calendar.SelectionChanged event is only fired when mouse left button is not pressed. 
  This allows to avoid any actions until the selection is not completed.

* added new item to the default C1Schedule context menu: 'Next 7 Days'. 
  It forces C1Schedule to show 7 days starting from the current date. 
  If currently shown view is not TimeLine, the 7 days will be shown in the DayView mode.
  Note: if you use localized resources, make sure that you added translation for this item.

* added 2 hour time scale interval in the Day/Week/Work Week/Time Line views. This includes: 
    - new TimeScaleEnum.TwoHours enumeration member,
	- new "2 hours" item in the time ruler context menu.

* added support for daily scale in the Time Line view. This includes:
	- new TimeLineStyleEnum enumeration,
    - new property of the C1Schedule control:
        public TimeLineStyleEnum TimeLineStyle { get; set; }
			Gets or sets the Time Line style. 
    - "1 day" item in the Time Line time ruler context menu.

Corrections
-------------------------------------------
* fixed Tfs issue 33279 - NullReferenceException is raised on adding appointment when e.Cancel of BeforeViewChange event is True.

=================================================================================
C1Schedule Build Number 2.0.20123.220, 4.0.20123.220  Build Date: 10/30/2012
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* design-time localization honors CultureInfo.CurrentUICulture. 
  Note, runtime localization hasn't been changed and depends on the C1Schedule.CalendarInfo.CultureInfo property value.
* added missing Korean and Chinese strings.

=================================================================================
C1Schedule Build Number 2.0.20123.219, 4.0.20123.219  Build Date: 10/23/2012
=================================================================================
Corrections
-------------------------------------------
* fixed Tfs issue 29218 - IDE closed when user clicks "Localize.." from Smart Designer.

=================================================================================
C1Schedule Build Number 2.0.20123.218, 4.0.20123.218  Build Date: 10/18/2012
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* to avoid font issues on international systems changed some fonts in default visual styles:
  - Arial is replaced by Tahoma;
  - Calibri is replaced by the smaller size Segoe UI.

=================================================================================
C1Schedule Build Number 2.0.20123.217, 4.0.20123.217  Build Date: 10/15/2012
=================================================================================
* 2012 V3 build

Enhancements/Documentation/Behavior Changes
-------------------------------------------
* added Chinese and Korean resources.

=================================================================================
C1Schedule Build Number 2.0.20122.214, 4.0.20122.214  Build Date: 09/29/2012
=================================================================================
Corrections
-------------------------------------------
* fixed issue with saving Reminder.NextReminderDate property in xml format.

=================================================================================
C1Schedule Build Number 2.0.20122.213, 4.0.20122.213  Build Date: 09/15/2012
=================================================================================
Corrections
-------------------------------------------
* fixed issue with duplicated recurrence exceptions after updating the data source (Tfs 27851)

=================================================================================
C1Schedule Build Number 2.0.20122.211, 4.0.20122.211  Build Date: 08/22/2012
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* added VS2012 toolbox icons.

=================================================================================
C1Schedule Build Number 2.0.20122.210, 4.0.20122.210  Build Date: 07/03/2012
=================================================================================
Corrections
-------------------------------------------
* updated AssemblyCompany and AssemblyCopyright attributes and about box.

=================================================================================
C1Schedule Build Number 2.0.20122.208, 4.0.20122.208  Build Date: 06/14/2012
=================================================================================
Corrections
-------------------------------------------
* [13453-139][Regression] After data binding, no option is showed in 'DataMember' dropdown in Appointment Storage Properties dialog.

=================================================================================
C1Schedule Build Number 2.0.20122.207, 4.0.20122.207  Build Date: 06/13/2012
=================================================================================
Corrections
-------------------------------------------
* The C1Schedule doesn't fire AppointmentCustomAction event for recurring appointments (Tfs 23345).
 
=================================================================================
C1Schedule Build Number 2.0.20122.206, 4.0.20122.206  Build Date: 06/08/2012
=================================================================================
Corrections
-------------------------------------------
* Improved TimeLine view navigation when C1Schedule.ShowWorkTimeOnly is true.

=================================================================================
C1Schedule Build Number 2.0.20122.205, 4.0.20122.205  Build Date: 06/07/2012
=================================================================================
Corrections
-------------------------------------------
*  The C1Schedule.EditReccurence method has been renamed to EditRecurrence (corrected misspelling).

=================================================================================
C1Schedule Build Number 2.0.20122.204, 4.0.20122.204  Build Date: 06/05/2012
=================================================================================
Corrections
-------------------------------------------
*  Tfs issue 23110 - The appointment, which is navigated by ‘Tab’ key, cannot be opened by pressing ‘Enter’ key although it is displayed as selected.

=================================================================================
C1Schedule Build Number 2.0.20122.203, 4.0.20122.203  Build Date: 06/01/2012
=================================================================================
Corrections
-------------------------------------------
*  Tfs issue 23077 - [C1Scheduler][C1Calendar] Only 3 Weeks are displayed as Selected after selecting a month (range of dates) 
					 in C1Calendar if the start selected date is not week start date.

=================================================================================
C1Schedule Build Number 2.0.20122.202, 4.0.20122.202  Build Date: 05/24/2012
=================================================================================
Corrections
-------------------------------------------
*  Tfs issue 22642 - [C1Scheduler] Recurring appointments cannot be fetched through Appointment.Conflicts property.

=================================================================================
C1Schedule Build Number 2.0.20122.200, 4.0.20122.200  Build Date: 05/11/2012
=================================================================================
* 2012 V2 build

=================================================================================
C1Schedule Build Number 2.0.20121.199, 4.0.20121.199  Build Date: 05/08/2012
=================================================================================
Corrections
-------------------------------------------
* When 'ShowNavigationButtons' property is set to True, navigation button are not showed at month header (Tfs 21899).

=================================================================================
C1Schedule Build Number 2.0.20121.198, 4.0.20121.198  Build Date: 05/02/2012
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added new property to the C1Calendar control:
	public bool ShowNavigationButtons { get; set; }
	  Determines whether control displays navigation buttons in the month header. The default value is true.

Corrections
-------------------------------------------
* C1Calendar.MouseWheel event is fired before scrolling the control. 
  This allows to prevent scrolling by setting HandledMouseEventArgs.Handled to true.	  

=================================================================================
C1Schedule Build Number 2.0.20121.197, 4.0.20121.197  Build Date: 04/24/2012
=================================================================================
Corrections
-------------------------------------------
* [12027-139]When using BeginUpdate() and EndUpdate() around the ShowDates() method, incorrect dates are shown in the C1Schedule.

=================================================================================
C1Schedule Build Number 2.0.20121.196, 4.0.20121.196  Build Date: 03/30/2012
=================================================================================
Corrections
-------------------------------------------
* Improved vertical scrolling behavior during appointments tab navigation in the DayView all-day area and in the TimeLine view (Tfs 20932).

=================================================================================
C1Schedule Build Number 2.0.20121.195, 4.0.20121.195  Build Date: 03/28/2012
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Implemented appointments tab navigation. When user presses the Tab key, the C1Schedule control selects the next appointment object in the current view.
  When end-user presses Shift-Tab combination, the C1Schedule control selects the previous appointment object in the current view.
  Note, the C1Schedule control doesn't navigate current view to other date range during tab navigation.
* Added new property to C1Schedule control:
    public WeekTabFormat WeekTabFormat { get; set; }
      Determines the content of week tabs in the month view mode. The default value is WeekTabFormat.Floating. 
	  Available WeekTabFormat values:
	    - Floating - use long or short date pattern depending on the available space.
        - Short - always show date range using short date pattern.
        - WeekNumber - display the week of the year number.

=================================================================================
C1Schedule Build Number 2.0.20121.193, 4.0.20121.193  Build Date: 03/14/2012
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added new method to C1Schedule control:
    public void EditReccurence(Appointment appointment);
       Opens RecurrenceForm dialog for editing existent or newly created RecurrencePattern object for the specified Appointment.
* Added new constructor to the AppointmentForm form:
    public AppointmentForm(C1Schedule schedule, Appointment appointment, bool editRecurrence);
       Initializes a new instance of the AppointmentForm form for editing of the specified Appointment object.
	   If editRecurrence parameter is true, opens RecurrenceForm dialog immediately after the opening AppointmentForm dialog.

=================================================================================
C1Schedule Build Number 2.0.20121.192, 4.0.20121.192  Build Date: 03/10/2012
=================================================================================
Corrections
-------------------------------------------
* fixed design-time issue with setting Data member in the C1Schedule's 'Data Source settings' smart designer 
  when using C1.Win.Data.Entities.C1DataSource as data source.

=================================================================================
C1Schedule Build Number 2.0.20121.191, 4.0.20121.191  Build Date: 02/22/2012
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added RightToleft layout support in the C1Calendar control.
  Added new property to the C1Calendar control:
     public virtual bool RightToLeftLayout { get; set; }
        Gets or sets a value indicating whether the control can be laid out from right to left.
        When the RightToLeft and RightToLeftLayout properties are both true, control is displayed with the right to left layout.

=================================================================================
C1Schedule Build Number 2.0.20121.190, 4.0.20121.190  Build Date: 02/22/2012
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added new property to the C1Calendar control:
     public int CurrentMonthDisplayOffset { get; set; }
         Gets or sets the current month display offset.
         This example shows current month at the center of the multi-dimensional calendar:
           c1Calendar1.CalendarDimensions = 3;
           c1Calendar1.CurrentMonthDisplayOffset = 1;

=================================================================================
C1Schedule Build Number 2.0.20121.189, 4.0.20121.189  Build Date: 02/20/2012
=================================================================================
Corrections
-------------------------------------------
* Implemented word wrapping rules for Asian languages (Chinese/Japanese/Korean) (TFS 19995, 18543).    

=================================================================================
C1Schedule Build Number 2.0.20121.187, 4.0.20121.187  Build Date: 12/30/2011
=================================================================================
* 2012 V1 build

=================================================================================
C1Schedule Build Number 2.0.20113.186, 4.0.20113.186  Build Date: 11/30/2011
=================================================================================
Corrections
-------------------------------------------
* Updated licensing to conform with Federal Information Processing Standards requirements (TFS 18562).    

=================================================================================
C1Schedule Build Number 2.0.20113.184, 4.0.20113.184  Build Date: 11/12/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added new property to the C1Schedule control:
		public List<string> Locations { get; }
		  Gets the List<String> list containing string descriptions of available locations.
		  The C1Schedule control uses this list to populate Locations ComboBox in the
		  C1.Win.C1Schedule.Forms.AppointmentForm form. 
		  You can pre-populate this list at application start.
		  The C1Schedule control extends this list automatically every time when the new
		  location value is used in one of the Appointment objects.
		  You can use this list to fill Locations comboBox in the custom appointment dialog.
* Improved the RecurrencePattern class behavior:
    - the DayOfWeekMask property is initialized according to the parent Appointment.Start.DayOfWeek value;
    - the PatternEndDate returns valid value for patterns with finite Occurrences number. 
      You can use this property	to keep pattern end date in database, so that you can either
      load or don't load recurrent appointment row at runtime depending on the current range of displayed dates.
      Note, this value doesn't make sense if RecurrencePattern.NoEndDate property is true.
      The RecurrenceForm dialog reflects this change as well. I.e., if occurrences number is set,
      any change to other pattern settings is reflected in the PatternEndDate control.
      
Corrections
-------------------------------------------
* fixed Tfs issue 15710 - Update individual properties of the recurrence pattern exception 
						  on changes to the Master appointment.      

=================================================================================
C1Schedule Build Number 2.0.20113.183, 4.0.20113.183  Build Date: 10/27/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added new property to the BeforeTimeFormatEventArgs class:
	public ScheduleGroupItem Group { get; }
	  Gets the ScheduleGroupItem object which is currently formatted.
	  This property allows setting different coloring for DateTime intervals for different 
	  calendar owners. For example:
        private void c1Schedule1_BeforeTimeFormat(object sender, BeforeTimeFormatEventArgs e)
        {
			// default settings
			DayOfWeek weekendDay = DayOfWeek.Sunday;
			TimeSpan lunchTime = TimeSpan.FromHours(11);
			// determine specific settings depending on the owning ScheduleGroupItem or ScheduleGroupItem.Owner
			if (e.Group == c1Schedule1.GroupItems[2]) 
			{
				weekendDay = DayOfWeek.Saturday;
				lunchTime = TimeSpan.FromHours(12);
			}
			// format time interval
			DateTime end = e.Start.Add(e.Duration);
			if (e.Start.TimeOfDay >= lunchTime
				&& end.Date == e.Start.Date && end.TimeOfDay <= lunchTime.Add(TimeSpan.FromHours(1)))
			{
				// lunch time
				e.Background = Color.Yellow;
			}
			if (e.Start.DayOfWeek == weekendDay)
			{
				// weekend
				e.Background = Color.Red;
			}
		}
	  

=================================================================================
C1Schedule Build Number 2.0.20113.182, 4.0.20113.182  Build Date: 10/14/2011
=================================================================================
Corrections
-------------------------------------------
* fixed Tfs issue 17683 - 'Category' items are lost in the appointment after dragging 
                          the appointment from the ungrouped C1Schedule and dropping into 
                          the grouped C1Schedule
* fixed issue with running C1Schedule from the VB6 application
  (http://our.componentone.com/groups/winforms/scheduler-for-winforms/forum/topic/opening-vb-net-form-containing-c1schedule-from-vb6-project-causes-automation-error/)                          

=================================================================================
C1Schedule Build Number 2.0.20113.180, 4.0.20113.180  Build Date: 10/12/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Updated Japanese resources.

=================================================================================
C1Schedule Build Number 2.0.20113.179, 4.0.20113.179  Build Date: 10/12/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Extended Time Line View settings in the Visual Style Smart Designer.

=================================================================================
C1Schedule Build Number 2.0.20113.178, 4.0.20113.178  Build Date: 10/08/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added Time Line View settings to the Visual Style Smart Designer.

=================================================================================
C1Schedule Build Number 2.0.20113.177, 4.0.20113.177  Build Date: 10/05/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Licensing update for FIPS compliance.

=================================================================================
C1Schedule Build Number 2.0.20113.176, 4.0.20113.176  Build Date: 10/01/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added new Time Line View. 
  It can be set from code by setting C1Schedule.ViewType property to the ScheduleViewEnum.TimeLineView value. 
  At design-time it can be set from the property grid, from the C1Schedule's Smart Designer or
  from the C1Schedule's smart tags.
  The most of the Time Line View appearance options are the same as for the Day View.
  For the sample of using see C1ScheduleDemo or MultiUser samples.

=================================================================================
C1Schedule Build Number 2.0.20112.175, 4.0.20112.175  Build Date: 9/22/2011
=================================================================================
Corrections
-------------------------------------------
* Fixed ScheduleGroupItem selection behavior during drag&drop operations:
  - Appointment owner object is set before C1Schedule.BeforeAppointmentDrop event is fired.
    So, in the event handler for BeforeAppointmentDrop event you can determine whether
	appointment owner has been changed:
	    void c1Schedule1_BeforeAppointmentDrop(object sender, CancelAppointmentEventArgs e)
        {
            // to determine whether appointment owner has been changed, compare appointment properties
            // with the c1Schedule1.SelectedGroupItem.Owner object
            if (!e.Appointment.IsGroupMember(c1Schedule1.SelectedGroupItem.Owner, c1Schedule1.GroupBy))
            {
                // appointment owner has been changed. To cancel operation, uncomment the next line
                // e.Cancel = true;
            }
            else
            {
                // appointment owner has not been changed
            }
        }
   - If drop operation hasn't been cancelled, c1Schedule1.SelectedGroupItem property is changed automatically
     to the newly selected item.

=================================================================================
C1Schedule Build Number 2.0.20112.174, 4.0.20112.174  Build Date: 9/20/2011
=================================================================================
Corrections
-------------------------------------------
* Fixed regression issue introduced in build 173 
  (17327 - Edited Label is not applied to appointment occurrences from recurrence series) 
* Fixed iCal import from msevents.microsoft.com issue.

=================================================================================
C1Schedule Build Number 2.0.20112.173, 4.0.20112.173  Build Date: 8/03/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Improved group header layout at resizing the C1Schedule control.
* Information about reminder snoozing is saved along with appointment properties.
  That includes data-bound scenarios and import/export in xml and binary formats. 

=================================================================================
C1Schedule Build Number 2.0.20112.172, 4.0.20112.172  Build Date: 7/25/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Improved TimeRuler behavior. 
	- the top most time slot always shows time, so that for the small time scale current time 
	  is always visible to the end-user regardless of the scroll position;
	- added ScheduleTheme.TimeRulerFormat2 property. 
	  This property gets or sets the string value which determines time format string used 
	  in the time ruler for displaying times other then the beginning of the hour.
	  The default value is empty string. If this format is not empty, time values will be shown for 
	  very time slot. You can change this property from the TimeRuler tab of the VisualStyle Smart Designer. 
	  
* Changed Day/Working Week/Office 2007 Week View layout (Tfs issue 4461).
    Added the separate scroll bar for the all-day area. All-day area can't occupy more than
	a third part of the available height. 

=================================================================================
C1Schedule Build Number 2.0.20112.170, 4.0.20112.170  Build Date: 7/21/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added sorting appointments by the Subject in the default printing styles.

=================================================================================
C1Schedule Build Number 2.0.20112.169, 4.0.20112.169  Build Date: 7/09/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added new property to the BeforeContextMenuShowEventArgs class:
	public SelectionType SelectionType {get;}
		Gets the SelectionType value determining the UI element type for which context menu is about to show.
		Use this property to customize context menu behavior or content depending on the current context.
	
	The new SelectionType enum contains the next members:
        - Appointment - Appointment element,
        - TimeInterval - either day element or time slot element,
		- DayTitle - day title,
        - TimeRuler - time ruler element,
        - GroupHeader - the group header,
        - None - the selection area belongs to the C1Schedule control, 
			but doesn't belong to any active area described by the other SelectionType members.
    }

=================================================================================
C1Schedule Build Number 2.0.20112.168, 4.0.20112.168  Build Date: 7/06/2011
=================================================================================
Corrections
-------------------------------------------
* fixed issue with not loading images from internet links (16078)

=================================================================================
C1Schedule Build Number 2.0.20112.167, 4.0.20112.167  Build Date: 7/01/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added ColorMapping for the CategoryStorage. Note, default Categories have no color set and C1Schedule doesn't use
  Category.Color in the default UI. 
* The CategoryMappingCollection class has been removed, use BaseObjectMappingCollection<Category> instead.
* Changed UI layout - group navigation buttons have been moved to the C1Schedule's title area.
* Added C1Schedule.BeforeGroupHeaderFormat event. 
	This event occurs before the group header is formatted. Use it to alter default group header appearance. 
	You can change group header style, tab shape or displayed content.
	The next sample shows how to alter group header appearance depending on BeforeGroupHeaderFormatEventArgs properties:
		private void c1Schedule1_BeforeGroupHeaderFormat(object sender, BeforeGroupHeaderFormatEventArgs e)
		{
		    Contact owner = e.Group.Owner as Contact;
		    if (owner != null)
		    {
		        TestSchedule.NwindDataSet.EmployeesRow row = this.nwindDataSet.Employees.FindByEmployeeID((int)owner.Key[0]);
		        if (row != null)
		        {
		            string imageName = "photo" + row.EmployeeID + ".bmp";
		            if (File.Exists(imageName))
		            {
							// use image from file
							// note, C1Schedule only accepts images from internet (http://..), 
							// application resources (res://..) and local file system (file:///...).
							e.Html = row.FirstName + " " + row.LastName + "<br><img src=file:///" + imageName + "/>";
		            }
		        }
		    }
		    if (e.Style.Hot != null)
		    {
		        // Hot style is applied to the group header when ScheduleGroupItem is selected.
		        e.Style.Hot.BackColor2 = e.Style.Hot.BorderColor = Color.DarkSlateGray;
		        e.Style.Hot.ForeColor = Color.WhiteSmoke;
		    }
		    // use rectangular tab
		    e.TriangleTab = false;
		}

=================================================================================
C1Schedule Build Number 2.0.20112.166, 4.0.20112.166  Build Date: 6/14/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added new data storage to keep calendar owners.
	Added new property to the C1ScheduleStorage class:
		public ContactStorage OwnerStorage { get; }
			Gets the ContactStorage object used to keep contacts which might be used as appointment owners.
			Appointment.Owner property only accepts Contact objects which are present in this storage.
    Both ContactStorage and OwnerStorage can be used in unbound mode or can be bound to the same or different data.
	Note that Contact objects from the ContactStorage will appear in the AppointmentForms and Appointment context menu, 
	so that end-user will be able to edit them.
	Contact objects from the OwnerStorage won't appear in the AppointmentForms or Appointment context menu. They are only
	used as a group headers when C1Schedule.GroupBy = "Owner".
    
	Updated MultiUser sample shows how to use different data for ContactStorage and OwnerStorage.

Breaking Changes
-------------------------------------------
* If you use Appointment.Owner property (or set C1Schedule.GroupBy to "Owner"), either set OwnerStorage 
  data bindings to the same data as ContactStorage, or use different data sources for OwnerStorage and ContactStorage.

=================================================================================
C1Schedule Build Number 2.0.20112.164, 4.0.20112.164  Build Date: 6/08/2011
=================================================================================
Corrections
-------------------------------------------
- fixed 15346 [4905-139] Request to display the last week in view at Schedule MonthView
- fixed 15617 - MouseClick and MouseDoubleClick events do not get fired in C1Schedule

=================================================================================
C1Schedule Build Number 2.0.20112.163, 4.0.20112.163  Build Date: 5/30/2011
=================================================================================
Corrections
-------------------------------------------
- fixed issue 15433 - [C1Calendar] The LastDate cannot be selected at C1Calendar

=================================================================================
C1Schedule Build Number 2.0.20112.162, 4.0.20112.162  Build Date: 5/19/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- Improved performance at working with recurring events.
- Changed behavior of the C1Schedule.BeforeViewChange event, it is fired before any change to the C1Schedule.ViewType property.

=================================================================================
C1Schedule Build Number 2.0.20112.160, 4.0.20112.160  Build Date: 5/08/2011
=================================================================================
* 2011 V2 build

=================================================================================
C1Schedule Build Number 2.0.20111.159, 4.0.20111.159  Build Date: 4/27/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Improved printing styles layout for better space distribution.
* Added overflow arrow to the month and week printing styles. It is shown when not all appointments can be printed.
* Updated PrintDocTemplates sample.
* Added new constructors to the Appointment class:
    public Appointment(int key);
    public Appointment(Guid key);
		Both constructors initialize a new instance of the Appointment class with the specified key.
        Use one of them if your business logic requires setting custom key value.
        Make sure that you use the correct constructor overload (with integer or Guid key value) and that key value is unique.
* Added new constructors to the BaseObject-derived classes:
    public Status.Status(int key);
    public Status.Status(Guid key);
    public Label.Label(int key);
    public Label.Label(Guid key);
    public Resource.Resource(int key);
    public Resource.Resource(Guid key);
    public Category.Category(int key);
    public Category.Category(Guid key);
    public Contact.Contact(int key);
    public Contact.Contact(Guid key);
		All constructors initialize a new instance of the object with the specified key.
        Use one of them if your business logic requires setting custom key value.
        Make sure that you use the correct constructor overload (with integer or Guid key value) and that key value is unique.

* Added new methods to the Appointment class:
	public string GetAppointmentProperties();
	    Returns XML encoding of appointment properties.
        Use this property to get the same string as serialized value of appointment properties, which you get
        when set mapping for AppointmentProperties.
    public bool SetAppointmentProperties(string source);
        Reconstructs appointment properties from the specified string.
        The String value containing XML encoding of appointment properties.
        Returns True if appointment has been changed.

=================================================================================
C1Schedule Build Number 2.0.20111.158, 4.0.20111.158  Build Date: 4/05/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* added Memo printing style localization:
  - added new PrintStyleTagStrings strings, make sure that you localized them from design-time localization dialog;
  - updated Memo printing style (added localizable document tags);
  - updated PrintDocTemplates sample application.

Corrections
-------------------------------------------
* Fixed issue 14856 - On repeating the preview of 1 appointment, preview of all the appointments get displayed.

=================================================================================
C1Schedule Build Number 2.0.20111.156, 4.0.20111.156  Build Date: 3/08/2011
=================================================================================
Corrections
-------------------------------------------
* Fixed backward compatibility issue with C1Calendar's custom themes 
  which had been created with build 138 or earlier builds:
  http://helpcentral.componentone.com/CS/winforms_31/f/60/p/88289/245821.aspx#245821

=================================================================================
C1Schedule Build Number 2.0.20111.155, 4.0.20111.155  Build Date: 3/04/2011
=================================================================================
Corrections
-------------------------------------------
* Fixed issue 14559 - [C1Schedule] The cursor is displayed as 'SizeWE' on editing appointment.

=================================================================================
C1Schedule Build Number 2.0.20111.154, 4.0.20111.154  Build Date: 2/22/2011
=================================================================================
Corrections
-------------------------------------------
* Fixed mouse selection issue: http://helpcentral.componentone.com/CS/winforms_31/f/60/p/87574/245133.aspx#245133

=================================================================================
C1Schedule Build Number 2.0.20111.151, 4.0.20111.151  Build Date: 2/15/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added new property to the Appointment class:
		public Contact Owner {get; set; }
			Gets or sets the Contact object which owns current Appointment object.
			The default value is null.
	  The AppointmentStorage object supports new optional mappings which allow to set either OwnerIndexMapping or OwnerIdMapping.
	  For the sample of using look at the updated MultiUser sample.

* Added grouping support. The C1Schedule control supports grouping by resources, contacts, categories and by 
  the Appointment.Owner property value. All C1Schedule vies and visual styles support grouping and contain 
  UI for navigation between groups. The new Grouping sample demonstrates C1Schedule grouping functionality.
  Default printing styles and PrintDocTemplates sample have been updated to honor new grouping feature.
  MultiUser sample have been updated as well.

	  New classes:

		public class ScheduleGroupItem
			Holds all the data required for displaying individual UI part for the single resource, 
			category or contact when the C1Schedule.GroupBy property is set, or default UI otherwise.

		public class ScheduleGroupItemCollection : C1ObservableCollection<ScheduleGroupItem>
			Represents a collection of the ScheduleGroupItem objects.
	  
	  New properties of the C1Schedule control:
		
		public string GroupBy { get; set; }
			Gets or sets the string value determining the type of grouping.
			This property can be equal to one for the next supported keywords:
				* An empty string - no grouping.
				* "Owner" - grouping by Appointment.Owner property value.
				* "Category" - grouping by Appointment.Categories property value.
				* "Contact" - grouping by Appointment.Links property value.
				* "Resource" - grouping by Appointment.Resources property value.
			The default value is an empty string.
			
		public bool ShowGroupNavigation { get; set; }
			Gets or sets the Boolean value determining whether the C1Schedule control
			should display group navigation buttons.
			The default value is true.
			This property only makes sense when the GroupBy property is set.

		public bool ShowEmptyGroupItem { get; set; }
			Gets or sets the Boolean value determining whether the C1Schedule control
			should display an empty group item.
			This property only makes sense when the GroupBy property is set.
			If this property is set to True, the C1Schedule control will display a group item 
			without assigned owner (resource, contact or category). This group item will contain all appointments, 
			which don't fall into other group items. 
			The default value is false.

		public string EmptyGroupName { get; set; }
			Gets or sets a String value used as default value for the ScheduleGroupItem.Name property.
			The default value is "Calendar"

		public ScheduleGroupItemCollection GroupItems { get; }
		    Gets a collection of all available GroupItem objects for the currently set type of grouping.

		public ScheduleGroupItemCollection VisibleGroupItems { get; }
			Gets a collection of currently visible GroupItem objects.

		public bool IsGrouped { get; }
			Gets a Boolean value determining whether grouping has been set for the C1Schedule control.

		public ScheduleGroupItem SelectedGroupItem { get; }
			Gets the selected ScheduleGroupItem object or returns null if the selection is empty. 

		public int GroupPageSize { get; set; }
			Gets or sets the Integer value determining the maximum number of the ScheduleGroupItem objects
			displayed in UI at the same time. Increasing this value might affect performance.
			The default value is 2.

	  New C1Schedule method:
	    
		public void NavigateToScheduleGroup(int increment);
			Navigates the C1Schedule control back or forth to another ScheduleGroupItem object by the specified increment.

* Added new check box in the PrintOptionsForm. It allows to select whether to print all appointments or appointment from the
  currently selected group item only. If you use localized version of the C1Schedule control, make sure that you added new string there. 

=================================================================================
C1Schedule Build Number 2.0.20111.149, 4.0.20111.149  Build Date: 1/15/2011
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Updated Japanese resources

=================================================================================
C1Schedule Build Number 2.0.20111.148, 4.0.20111.148  Build Date: 1/5/2011
=================================================================================
Corrections
-------------------------------------------
* fixed issue 14000 - [C1Schedule] Appointment does not get selection by the right click.
* fixed issue with unwanted appointment dragging if focus is in some other control
  (http://helpcentral.componentone.com/CS/winforms_31/f/60/t/87524.aspx).

=================================================================================
C1Schedule Build Number 2.0.20111.147, 4.0.20111.147  Build Date: 12/29/2010
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added new property to the C1Schedule control: 
	public Comparison<Appointment> AppointmentComparison { get; set; }
		Gets or sets the Comparison<Appointment> delegate which is used by 
		the C1Schedule control to sort appointments in the Month and Office 2003 Week views.
  By default C1Schedule performs comparison with the new C1Schedule.Compare(Appointment x, Appointment y) method.
  This method compares appointments by the Appointment.Start property and then (if start time is the same)
  by the Appointment.Subject property. You can alter this behavior by supplying custom comparison:
  		
  		c1Schedule1.AppointmentComparison = this.Compare;
		...
		public int Compare(Appointment x, Appointment y)
		{
			// sort appointments by location
			return String.Compare(x.Location, y.Location, true);
		}

* Added C1Calendar.BeforeDayFormat event. Use this event to alter default day appearance. For example:
		private void c1Calendar1_BeforeDayFormat(object sender, BeforeDayFormatEventArgs e)
		{
			e.Style.Corners = new C1.Framework.Corners(3);
			if (e.Date.DayOfWeek == DayOfWeek.Sunday)
			{
				e.Style.ForeColor = Color.Red;
			}
			else if (e.Date.DayOfWeek == DayOfWeek.Saturday)
			{
				e.Style.ForeColor = Color.Blue;
			}
			if (e.Date == DateTime.Today.AddDays(1))
			{
				e.Style.BackColor = Color.YellowGreen;
				e.Style.BorderColor = Color.Tomato;
				e.Style.Border = new C1.Framework.Thickness(1);
			}
		}

* Added Office 2010 Visual Styles for the C1Calendar and C1Schedule controls:
  - Office 2010 Blue,
  - Office 2010 Black,
  - Office 2010 Silver.
  
* Added possibility to change C1Schedule navigation panels and week tabs appearance from the C1Schedule
  Visual Style Smart Designer.  

* Added new property to the C1Schedule class:
  C1ScheduleSettings Settings { get; }
  The C1ScheduleSettings class determines auxiliary properties providing different C1Schedule object settings:
  			AllowContactsEditing
			AllowContactsMultiSelection
			AllowResourcesEditing
			AllowResourcesMultiSelection
			AllowCategoriesEditing
			AllowCategoriesMultiSelection
			FirstVisibleTime
			AutoScrollToFirstAppointment 
			SetReminder
			ReminderTimeBeforeStart
		Default value for all AllowXXX properties is True.
		AppointmentForm and list editing forms honor above settings of the C1Schedule control.
			Examples:
			- if AllowXXXEditing property is false and corresponding data storage (for example, ResourceStorage)
			  is empty, AppointmentForm won't show controls for editing resources;
			- if AllowXXXEditing and AllowXXXMultiSelection properties are false, AppointmentForm
			  will show ComboBox for the single selection;
			- if AllowXXXEditing is false and AllowXXXMultiSelection is true, 
			  corresponding list editing form won't allow showing master list editing form.    
	    If you use localized version of the AppointmentForm, add localization for the new AppointmentForm resources.

* Improved appointment layout in the Day/Working Week/Week views. 

Breaking Changes
-------------------------------------------
* C1Schedule.FirstVisibleTime property has been marked as obsolete. 
  Use C1ScheduleSettings.FirstVisibleTime property instead.

* Removed old obsolete properties ScheduleTheme.BackGround and ScheduleTheme.BackGround2. 
  Use ScheduleTheme.CurrentPalette property instead.

=================================================================================
C1Schedule Build Number 2.0.20103.145, 4.0.20103.145  Build Date: 12/20/2010
=================================================================================
Corrections
-------------------------------------------
* fixed issue 13750 - [C1Schedule] If an appointment is shifted by moving the mouse very fast, 
					  there are cases that the BeforeAppointmentDrop event is not fired.

=================================================================================
C1Schedule Build Number 2.0.20103.144, 4.0.20103.144  Build Date: 12/5/2010
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* corrected Appointment element keyboard and mouse behavior:
	- single click on the Appointment element selects appointment;
	- mouse left button click or pressing 'F2' button on the selected Appointment element 
	  switches appointment into inline edit mode;
	- mouse left button double click on the Appointment element opens Appointment dialog;
	- pressing 'Enter' button in inline edit mode finishes editing;
	- pressing 'Escape' button in inline edit mode cancels all changes.

* corrected AppointmentForm behavior, so that it allows showing newly created appointments from the 
  C1Schedule.BeforeAppointmentCreate event handler. For example:
        void c1Schedule1_BeforeAppointmentCreate(object sender, CancelEventArgs e)
        {
            // cancel default handling
            e.Cancel = true;
            // create new appointment
            Appointment app = new Appointment();
            // change appointment properties here
            app.Subject = "test appointment";
            app.Location = "test location";
            if (c1Schedule1.SelectedInterval != null)
            {
                // set appointment properties according to the current C1Schedule selection
                app.Start = c1Schedule1.SelectedInterval.Start;
                app.End = c1Schedule1.SelectedInterval.End;
                if (app.Duration.TotalDays >= 1)
                {
                    app.AllDayEvent = true;
                }
            }
            // create and show AppointmentForm
            AppointmentForm form = new AppointmentForm(c1Schedule1, app);
			// set appointment Resources, Categories, Links and Label property here
			app.Resources.Add(c1Schedule1.DataStorage.ResourceStorage.Resources[0]);
            form.Show();
        }

=================================================================================
C1Schedule Build Number 2.0.20103.142, 4.0.20103.142  Build Date: 10/14/2010
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* added new property to the C1Calendar control: 
	public int DropDownMonthCount { get; set; }
		 Gets or sets the number of items in dropdown month/year selectors in the month header.
		 The default value is 9.

=================================================================================
C1Schedule Build Number 2.0.20103.140, 4.0.20103.140  Build Date: 9/27/2010
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* added Japanese translations for the new strings.
* improved formatting of the week tab text in the Office 2007 month view mode. 
  Actual format depends on the available screen space and C1Schedule.CalendarInfo.CultureInfo.DateTimeFormat settings.

=================================================================================
C1Schedule Build Number 2.0.20103.139, 4.0.20103.139  Build Date: 9/22/2010
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* added possibility to customize appointment corner radius for bubble look appointments.
  It can be changed at design time from the C1Schedule Visual Style Smart Designer
  (see 'Appointment' tab).
  
* improved behavior of the overflow button in the month view mode:
	- added tooltip. Tooltip text can be customized in design time 
	  (in the localization smart designer look for 'MiscStrings/MoreAppointments" item);
	- changed button appearance.

* improved C1Calendar behavior:
	- added ISupportInitialize interface implementation;
	
	- improved minimum size determination according to the current appearance settings.
	
	- C1Calendar.BorderStyle property has been disabled. It is hidden in design-time and 
	  C1Calendar always uses BorderStyle.None regardless of custom settings. 
	  Added customizable border settings in the C1Calendar Visual Style Smart Designer (see 'Common' tab).
	  Note: if you need BorderStyle.FixedSingle or BorderStyle.Fixed3D, 
	  place C1Calendar on the Panel and set Panel.BorderStyle property to the desired value.
	  
	- added new method:
		public SelectionRange GetDisplayRange(bool visible);
		Returns date information that represents the low and high limits of 
		the displayed dates of the control.
		
	- added new settings page in the C1Calendar Visual Style SmartDesigner for customizing
	  not working days ('Weekend' page). Default settings for weekends are the same as 
	  for the ordinary day.
	  Note: Bolded and Selected day settings have higher priority than Weekend settings. 
	  So, if weekend day is bolded or selected, Weekend settings will be ignored for this day. 

=================================================================================
C1Schedule Build Number 2.0.20102.138, 4.0.20102.138  Build Date: 7/28/2010
=================================================================================
Corrections
-------------------------------------------
* fixed issue with not showing multi-day events in a DayView when added from code 
(http://helpcentral.componentone.com/CS/winforms_31/f/60/t/84663.aspx).

=================================================================================
C1Schedule Build Number 2.0.20102.137, 4.0.20102.137  Build Date: 7/14/2010
=================================================================================
Corrections
-------------------------------------------
* Tfs issue 11732 - Exception is observed on setting Reminder time to 100000000 hours.
* Tfs issue 11735 - All Day appointments start shuffling on dragging any one of the 
					Appointments & Keeping mouse key pressed in Month View
* Tfs issue 11740 - 'Open' Option does not work when opened in the MonthView Grid header.
					

=================================================================================
C1Schedule Build Number 2.0.20102.136, 4.0.20102.136  Build Date: 7/8/2010
=================================================================================
Corrections
-------------------------------------------
Fixed issue with NullReferenceException if adding reminder to the hidden C1Schedule control:
http://helpcentral.componentone.com/CS/winforms_31/f/60/t/84442.aspx

=================================================================================
C1Schedule Build Number 2.0.20102.135, 4.0.20102.135  Build Date: 6/26/2010
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* removed bolding weekend days in C1Calendar. It is done to avoid end-user confusion when C1Calendar
  is bound to C1Schedule control and bolded days represent days with appointments.

=================================================================================
C1Schedule Build Number 2.0.20102.134, 4.0.20102.134  Build Date: 5/27/2010
=================================================================================
Corrections
-------------------------------------------
Update C1PrintDocument templates in order to reflect latest C1Report changes.

=================================================================================
C1Schedule Build Number 2.0.20102.133, 4.0.20102.133  Build Date: 5/25/2010
=================================================================================
Corrections
-------------------------------------------
Internal changes

=================================================================================
C1Schedule Build Number 2.0.20102.131, 4.0.20102.131  Build Date: 5/19/2010
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* implemented saving Appointment.Label information in iCal format. 
  Note, this information doesn't fit into iCal specification, so it can be read only by ComponentOne
  Scheduler controls.
 
=================================================================================
C1Schedule Build Number 2.0.20102.130, 4.0.20102.130  Build Date: 5/06/2010
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* added new property to the C1Schedule control:
    public bool ShowAllDayArea { get; set;}
        This property indicates whether the control should show All-Day area in a Day (Week) View.
        Default value is True.

=================================================================================
C1Schedule Build Number 2.0.20101.129, 4.0.20101.129  Build Date: 4/28/2010
=================================================================================
Corrections
-------------------------------------------
* Tfs issue 10599 - ArgumentException [An item with the same key has already been added.] 
					is thrown if Image is set to ImagePrevious / ImageNext of C1Calendar's Theme

=================================================================================
C1Schedule Build Number 2.0.20101.127, 4.0.20101.127  Build Date: 4/24/2010
=================================================================================
Corrections
-------------------------------------------
Internal changes

=================================================================================
C1Schedule Build Number 2.0.20101.126, 4.0.20101.126  Build Date: 4/24/2010
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
* Added support for importing binary data from different versions, including
  versions for other platforms (ASP.Net and WPF schedulers).

=================================================================================
C1Schedule Build Number 2.0.20101.125, 4.0.20101.125  Build Date: 4/23/2010
=================================================================================
Corrections
-------------------------------------------
* fixed Tfs issue 10347 - Appointment is not rendered in desired time slot 
						  if Appointment has different StartDate and EndDate

=================================================================================
C1Schedule Build Number 2.0.20101.124, 4.0.20101.124  Build Date: 4/19/2010
=================================================================================
Corrections
-------------------------------------------
Internal changes

=================================================================================
C1Schedule Build Number 2.0.20101.122, 4.0.20101.122  Build Date: 4/08/2010
=================================================================================
Corrections
-------------------------------------------
Internal changes

=================================================================================
C1Schedule Build Number 2.0.20101.121, 4.0.20101.121  Build Date: 4/07/2010
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added new event to the C1Schedule control:
        public event EventHandler<BeforeTimeFormatEventArgs> BeforeTimeFormat;
			Occurs before the time interval is formatted. 
			Use this event to alter default time interval appearance. 
			For example, to display different working hours for different days:

        private void c1Schedule1_BeforeTimeFormat(object sender, BeforeTimeFormatEventArgs e)
        {
            if (e.Start.TimeOfDay == TimeSpan.FromMinutes(120))
            {
                e.WorkTime = true;
                if (e.Start.DayOfWeek == DayOfWeek.Sunday)
                {
                    e.Background = Color.Red;
                }
            }
            else if (e.Start.TimeOfDay == TimeSpan.FromMinutes(240) && e.Start.DayOfWeek != DayOfWeek.Sunday)
            {
                e.Background = c1Schedule1.Theme.Palette.FreeHourBorder;
           }
            else
            {
                if (e.Start.DayOfWeek == DayOfWeek.Sunday && e.Duration.TotalDays == 1)
                {
                    e.Background = Color.Navy;
                }
            }
        }   
             
=================================================================================
C1Schedule Build Number 2.0.20101.120, 4.0.20101.120  Build Date: 4/07/2010
=================================================================================
Corrections
-------------------------------------------
Fixed Tfs issue:
  * 10067 - Some invalid behaviors of scroll bar with very old FirstDate

=================================================================================
C1Schedule Build Number 2.0.20101.118   Build Date: 3/26/2010
=================================================================================
Corrections
-------------------------------------------
Internal changes

=================================================================================
C1Schedule Build Number 2.0.20101.115   Build Date: 2/18/2010
=================================================================================
Corrections
-------------------------------------------
Removed dependency from System.Web.dll.

=================================================================================
C1Schedule Build Number 2.0.20101.114   Build Date: 2/10/2010
=================================================================================
Corrections
-------------------------------------------
Fixed Tfs issues:
  * 8966 - [3128] Appointment's HTML formatting do not work in Appointment 
		   tooltip in few scenarios
  * 8967 - [3128] Day header size is increased on resizing the form
 
=================================================================================
C1Schedule Build Number 2.0.20101.113   Build Date: 2/9/2010
=================================================================================
Corrections
-------------------------------------------
- internal changes.

=================================================================================
C1Schedule Build Number 2.0.20101.112   Build Date: 1/27/2010
=================================================================================
Fixed issue with not preserving autoincrement key values if one of C1Scheduler storages is bound
to the data source with primary key which is an autoincrement integer value.
 
=================================================================================
C1Schedule Build Number 2.0.20101.111   Build Date: 1/6/2010
=================================================================================
* 2010 V1 build
 
=================================================================================
C1Schedule Build Number 2.0.20093.108   Build Date: 11/20/2009
=================================================================================
Corrections
-------------------------------------------
- C1Calendar updates itself if CalendarInfo.FirstDate and CalendarInfo.LastDate properties
  have been changed.
- fixed regression issue "appointment text with html layout displayed out of appointment borders".

=================================================================================
C1Schedule Build Number 2.0.20093.106   Build Date: 10/30/2009
=================================================================================
Corrections
-------------------------------------------
Fixed Tfs issue 7556 - Some four byte characters are not displayed in subject, 
					   location, contacts, description, resources and categories.
 
=================================================================================
C1Schedule Build Number 2.0.20093.105   Build Date: 10/01/2009
=================================================================================
Corrections
-------------------------------------------
- internal changes.

=================================================================================
C1Schedule Build Number 2.0.20093.103   Build Date: 9/15/2009
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added new property to BeforeAppointmentFormatEventArgs:
	public DateTime UIElementDate { get; }
        Gets the date of the current UI element representing appointment.
        Multi day appointments are represented by several UI elements. 
        Use this property to distinguish the first UI element, the second one, etc...

Corrections
-------------------------------------------
- added displaying of appointment subject in a first visible day if the start day of 
  multi day appointment is invisible.

=================================================================================
C1Schedule Build Number 2.0.20093.102   Build Date: 8/30/2009
=================================================================================
* 2009 V3 build

=================================================================================
C1Schedule Build Number 2.0.20092.101   Build Date: 8/1/2009
=================================================================================
Added new property to Appointment class:

    - public string CustomData { get; set; }
        Gets or sets custom text associated with this object. 
        This property is serialized with other appointment properties.
        It isn't used by the scheduler, use it to keep your data associated with appointment.
        This property is serialized into xml and binary formats and it is saved into underlying 
        data source if mapping for Appointment Properties is set. It isn't retained at export/import to iCal format.

=================================================================================
C1Schedule Build Number 2.0.20092.100   Build Date: 6/17/2009
=================================================================================
Corrections
-------------------------------------------
- internal changes.

=================================================================================
C1Schedule Build Number 2.0.20092.99   Build Date: 5/25/2009
=================================================================================
Corrections
-------------------------------------------
   * C1Schedule printing doesn't use C1.C1Preview.2.dll and C1.Win.C1Preview.2.dll.
     These assemblies are not shipped anymore, use C1.C1Report.2.dll and C1.Win.C1Report.2.dll instead.

=================================================================================
C1Schedule Build Number 2.0.20092.98   Build Date: 5/18/2009
=================================================================================
Corrections
-------------------------------------------
   * Tfs issue 4468 - Color of tentative status changes to Blue on importing schedule(xml file)

=================================================================================
C1Schedule Build Number 2.0.20092.97   Build Date: 5/12/2009
=================================================================================
* 2009 V2 build

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- improved xml serialization/deserialization:

	- removed serialization of default values;
	
	- deserialization implemented with XmlReader;
		Added new overloads for FromXml methods:
			Appointment.FromXml(XmlReader reader)
			BasePersistableObject.FromXml(XmlReader reader)
			BaseObject.FromXml(XmlReader reader)
		
		FromXml(XmlNode node) methods changed to use new overloads internally.	
   
Upgrade considerations:
-------------------------------------------
1. Xml data saved with this version won't be read with previous versions of C1Schedule.

2. If you use large permanent sets of xml data (for example, the list of your regional holidays),
	consider saving this data with new version. This would reduce the size of xml, 
	improve performance and	reduce memory usage at reading data. 

=================================================================================
C1Schedule Build Number 2.0.20091.95   Build Date: 3/15/2009
=================================================================================
Corrections
-------------------------------------------
- fixed issue with overlapping appointments in a DayView mode.

=================================================================================
C1Schedule Build Number 2.0.20091.93   Build Date: 1/29/2009
=================================================================================
Corrections
-------------------------------------------
 - fixed bug with NullReferenceException at switching to the MonthView mode.

=================================================================================
C1Schedule Build Number 2.0.20091.92   Build Date: 1/17/2009
=================================================================================
Corrections
-------------------------------------------
 - fixed issue with updating all-day area height at dragging appointment to/from all-day area.

=================================================================================
C1Schedule Build Number 2.0.20091.91   Build Date: 1/10/2008
=================================================================================
* 2009 V1 build

Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added support for showing day tooltips in C1Calendar control:
	
	* added new event to C1CalendarControl:

		public event EventHandler<BeforeDayTooltipShowEventArgs> BeforeDayTooltipShow;
			Occurs before the day tooltip is shown.
		
		Sample of using:
	
			private void c1Calendar1_BeforeDayTooltipShow(object sender, BeforeDayTooltipShowEventArgs e)
			{
				if (e.Day.DayOfWeek == DayOfWeek.Sunday)
				{
					e.Text = "<div style=\"color:red\"><b>Sunday</b></div>";
				}
				else
				{
					e.Cancel = true;
				}
			}
	
	* added new class BeforeDayTooltipShowEventArgs. It provides data for the 
	  C1Calendar.BeforeDayTooltipShow event of the C1Calendar control. 

	* ToolTipRoundedCorners property moved from the C1.Win.C1Schedule.UI.ScheduleTheme class to it's base class 
	  C1.Win.C1Schedule.UI.BaseTheme. So, this property is common for all inherited classes.
	
	* if day tooltip hasn't been set from event handler for above event, day tooltip won't be shown.
	
	* tooltip appearance can be changed at design-time from the C1Calendar Visual Style smart designer.

=================================================================================
C1Schedule Build Number 2.0.20083.90   Build Date: 12/25/2008
=================================================================================
Corrections
-------------------------------------------
	* internal changes
	
=================================================================================
C1Schedule Build Number 2.0.20083.88   Build Date: 12/18/2008
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added drop-down Month/Year selectors in month headers of the C1Calendar control.

- C1Calendar and C1Schedule controls honor ambient values of VisualStyle property.

- changed serialization behavior of CalendarInfo.FirstDate and CalendarInfo.LastDate properties.
  The default values for these properties are Today.AddYears(-1) and Today.AddYears(1).
  If these values haven't been changed at design-time, they won't be serialized.
  In this case property values will be updated automatically at every application start.
  To use default values in existing applications, clear CalendarInfo.FirstDate 
  and CalendarInfo.LastDate values at design-time.
  
- added new cancellable events to the C1Schedule control:
		public event CancelAppointmentEventHandler BeforeAppointmentDrop;
			Occurs before an Appointment object is dropped by end-user.
		public event CancelAppointmentEventHandler BeforeAppointmentResize;
			Occurs before an Appointment object is resized by end-user.
			
    The sample of using:
    
    private void c1Schedule1_BeforeAppointmentDrop(object sender, C1.C1Schedule.CancelAppointmentEventArgs e)
	{
	    // cancel dragging if it causes conflicts with existing appointments
		AppointmentList list = c1Schedule1.DataStorage.AppointmentStorage.Appointments.GetConflicts(e.Appointment);
		foreach (Appointment app in list)
		{
			if (app.BusyStatus.StatusType == StatusTypeEnum.Busy)
			{
				e.Cancel = true;
			}
		}
	}
		
- added new property to the C1.C1Schedule.Printing.PrintInfo class:
		public bool ShowProgressForm { get; set; }
			Determines whether the Print progress form is displayed.
			The default value is true.
			
- added new class C1.Win.C1Schedule.Printing.PrintProgressForm.			

=================================================================================
C1Schedule Build Number 2.0.20083.86   Build Date: 12/13/2008
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- extended C1Calendar navigation:
    
    PgUp/PgDown/MouseWheel			- navigates 1 month back/forward
    Ctrl + PgUp/PgDown/MouseWheel	- navigates 1 year back/forward
    Home							- navigates to current date

=================================================================================
C1Schedule Build Number 2.0.20083.85   Build Date: 11/25/2008
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added new property to C1Calendar control:
	
	public int MaxSelectionCount { get; set; }
		Gets or sets the maximum number of days that can be selected in the C1Calendar control.
		The default value is 42.
		Exceptions:
		  -	ArgumentException - The value is less than 1.
		
	Note: this property is ignored if C1Calendar control is attached to C1Schedule control and
		  property value is greater than it is allowable for C1Schedule navigation 
		  (up to 6 full weeks or up to 14 arbitrary days). 
 
=================================================================================
C1Schedule Build Number 2.0.20083.83   Build Date: 10/31/2008
=================================================================================
Corrections
-------------------------------------------
  - corrected English spelling of RecurrencePattern.Description.

=================================================================================
C1Schedule Build Number 2.0.20083.81   Build Date: 10/23/2008
=================================================================================
Corrections
-------------------------------------------
 - fixed issue with saving/loading some types of recurring events (Yearly : The ‘second’ ‘Monday’ of ‘March’)
   to/from iCal format (Issue 18405). 
   At some conditions such events saved with previous versions might be loaded incorrectly.

=================================================================================
C1Schedule Build Number 2.0.20083.79   Build Date: 10/19/2008
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added new methods to C1Schedule class:

	public void Export(object parameter, string dialogTitle)
		Shows the SaveFileDialog and exports specified data to the selected file.
		Parameters:
		* parameter - an object to export. This parameter can be one of the next:
			null for export all C1Schedule data;
			Appointment object;
			IList<Appointment>.
		* dialogTitle - the string value used as a SaveFileDialog title.
		
	public void Import(string dialogTitle)
		Shows the OpenFileDialog and tries to export data from the selected file.
		Parameter:
		* dialogTitle - the string value used as an OpenFileDialog title.

Corrections
-------------------------------------------
- fixed issue with appointment duration at drag&drop between 2 C1Schedule controls
  (http://helpcentral.componentone.com/cs/forums/p/76772/209617.aspx#209617).

=================================================================================
C1Schedule Build Number 2.0.20083.77   Build Date: 10/01/2008
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added new public class C1.Win.C1Schedule.Localization.String, containing 
  static properties used for localization. 
  
  If you need to add localized resources to the custom control assembly, 
  change Strings.ResourceManager property so that specified ResourceManager object is able
  to find resources from your assembly. 
  It can be done from the custom control static constructor.
  
- added new property to the ScheduleTheme class: 
		public bool ShowTimeMonthView { get; set; }
	
	Setting this property to false hides all appointment times in a Month View mode.
	You can change this setting from the Visual Style smart designer.	

=================================================================================
C1Schedule Build Number 2.0.20082.74   Build Date: 08/23/2008
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added new property to the PrintStyle class:
		public string DisplayName { get; set;}
			Determines style display name. For default styles this value is initialized with 
			the value of the Description property localized according to the C1Schedule control's 
			culture. If Description property of the default style has been changed by user,
			it won't be localized.

- implemented IDisposable interface in PreviewWrapper and PrintDocumentWrapper classes.			

=================================================================================
C1Schedule Build Number 2.0.20082.72   Build Date: 08/07/2008
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added new property 
		public int AppointmentHeight { get; set; }
			Gets or sets the integer value determining the height of appointment elements
			in a Month View mode, Office 2003 Week View mode  and in AllDay area of a Day View mode.
			Default value is -1. If this property is set to default value, appointment height will be
			determined automatically according to the current view font size.
		
- added printing support. C1Schedule printing is based on using C1.C1Preview.C1PrintDocument component and 
  C1.Win.C1Preview.C1PrintPreviewDialog form via reflection. C1Schedule uses new C1PrintDocument features 
  which have been added in build 2.0.20082.50035 of C1PrintDocument component. It won't work with earlier 
  versions of C1PrintDocument component. 
  
  By default C1Schedule printing is enabled from context menus and from AppointmentFrom with no coding.
  The only requirement is a presence of C1Preview assemblies either in GAC or in the application working folder.
  
  By default, when user click "Print Preview" or "Print" item from the context menu, he gets Print Options form, 
  where he can select the style for printing. Furthermore, he can edit the selected style from the
  Page Setup dialog. From the print Preview dialog user can print the document or save it in a number of
  formats supported by the C1PrintDocument component: .c1dx, .c1d, .pdf, .xlsx, .xls, .rtf, .docx, .htm, .emf,
  .tiff, .png, .jpg, .gif, .bmp. 
  
  C1PrintDocument component is shipped in C1.C1Report.2.dll assembly.
  C1PrintPreviewDialog form is shipped in C1.Win.C1Report.2 assembly.
  
  At run-time C1Schedule looks for available C1Preview assemblies. If there is no available assemblies,
  C1Schedule control shows notification message to end-user and hides print and print preview items in
  context menus and in the Appointment form toolbar. If C1Preview assemblies have been found,
  C1Schedule loads them and uses via reflection.
  
  ------
  Component upgrade considerations:
  
  - if your application doesn't need printing, set PrintInfo.IsPrintingEnabled property to false. 
	In such case C1Schedule won't try to find and load C1Preview assemblies and won't show Print and Print Preview
    items in context menus and in the AppointmentForm toolbar.
    
  - if your application needs printing, consider the next steps for better perfomance and maintainability:
       
       1. add references to C1Preview assemblies to your application;
       2. add C1PrintDocument component to your form and assign it to the
		  PrintInfo.PrintDocumentHelper.C1PrintDocument property;
       3. add C1PrintPreviewDialog instance to your form and assign it to the
		  PrintInfo.PreviewHelper.C1PrintPreviewDialog property. 

  ------
  New properties and events in C1Schedule control (you can find them at design time under "Printing" category
  of the property grid):
	  
  	public PrintInfo PrintInfo { get; }
		Gets the PrintInfo object responsible for printing support.
  
  	public event EventHandler<CancelEventArgs> BeforeOptionsFormShow; 
  		Occurs before showing print options form.
	
	public event EventHandler<CancelEventArgs> BeforePrint;
		Occurs before printing.

	public event EventHandler<CancelEventArgs> BeforePrintPreview; 
		Occurs before print preview.
	
	public event EventHandler PrintDocumentStarting; 
		Occurs when the print document building is started.

  All printing options, the set of printing styles and printing styles properties are defined as a part of
  the C1.C1Schedule.Printing.PrintInfo class.
  
  ------
  Namespaces and classes:
  
	------
	C1.C1Schedule.Printing namespace:
		
		public class DateAppointments 
			represents the single calendar day with the List<Appointment> list of appointments.
			It is an auxiliary class for using in C1PrintDocument scripts.
  
		public class DateAppointmentsCollection : KeyedCollection<DateTime, DateAppointments>
			represents the KeyedCollection<DateTime, DateAppointments> collection 
			which can be used as data source in C1PrintDocument documents.  	
	
		public enum PrintContextType
			defines the printing context for the PrintStyle object.
		
		public class PreviewWrapper 
			wraps the print preview dialog functionality. It allows showing C1.C1Preview.C1PrintDocument 
			content in a C1.Win.C1Preview.C1PrintPreviewDialog, loaded via reflection from 
			the C1.Win.C1Report.2 assembly.	
	
		public class PrintDocumentWrapper 
			wraps the C1.C1Preview.C1PrintDocument functionality. It loads C1.C1Preview.C1PrintDocument 
			component via reflection from the C1.C1Report.2 assembly.	
		
		public class PrintInfo  
		    the object used to manage schedule printing.	

		public class PrintStyle 
			represents the single printing style for a schedule control.

		public class PrintStyleCollection : KeyedCollection<string, PrintStyle> 
			represents the keyed collection of scheduler printing styles. The PrintStyle.StyleName property 
			is used as a collection key.

		public class TagInfo 
			represents the facade for the C1.C1Preview.Tag class. Use this class for getting information 
			about document tags and for setting tag values before rendering the document.
	
		public abstract class TagInputParams and derived classes 
			represent tag customization parameters for input from print style options from.
	
	------
	C1.Win.C1Schedule.Printing namespace:
		
		public partial class PrintOptionsForm : Form  
			allows selecting printing style from the list of available styles and setting other printing options.	
	
		public partial class PrintStyleOptionsForm : Form
			allows setting properties of the specified printing style.
	

Corrections 
-------------------------------------------
- improved layout of multi-day appointments in a Month View mode
		(http://helpcentral.componentone.com/cs/forums/p/76026/207515.aspx#207515).

- improved performance for long date ranges
		(http://home.componentone.com/cs/forums/197188/ShowPost.aspx).
	Note: make sure that you call C1Schedule.BeginUpdate() before loading data or updating 
	      data adapters and C1Schedule.EndUpdate() after such operations.
	      
- changed layout of AllDay events in a Day, Work Week and Office 2007 Week View modes. 
  From this version AllDay area layout is the same as layout of a single day in a Month View mode.	      

=================================================================================
C1Schedule Build Number 2.0.20082.71   Build Date: 07/24/2008
=================================================================================
Enhancements/Documentation/Behavior Changes
-------------------------------------------
- added new property to the CalendarInfo class:
		public DateTimeKind DateTimeKind { get; set; }
			Gets or sets a DateTimeKind value specifying DateTime kind
		    used for saving DateTime values.
			This property only have an influence on the process of saving data to
			the AppointmentStorage.DataSource object and on export operations.
			All properties of the Appointment and RecurrencePattern objects 
			represent current system local time values. 
			The default value is DateTimeKind.Unspecified.
		User can set this property to DateTimeLind.Utc if he needs to save
		data with universal time. In such case the data will be converted to the local time 
		and back at every read/write operation.

=================================================================================
C1Schedule Build Number 2.0.20082.68   Build Date: 06/05/2008
=================================================================================
Corrections 
-------------------------------------------
  Fixed issue:
	- Weekly recurrence pattern is displayed as Saturday and Sunday instead of Friday and Saturday.

=================================================================================
C1Schedule Build Number 2.0.20082.67   Build Date: 05/09/2008
=================================================================================
Corrections 
------------------------------------------- 
	* Issue 17134 - If LabelStorage or StatusStorage are mapped to data using IndexMapping, 
					labels are not displayed correctly.

=================================================================================
C1Schedule Build Number 2.0.20082.66   Build Date: 05/03/2008
=================================================================================
Corrections 
------------------------------------------- 
	* fixed some drag&drop issues;
	* internal changes.

=================================================================================
C1Schedule Build Number 2.0.20082.62   Build Date: 03/23/2008
=================================================================================
Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
	* V2/2008 build
	
	* added support for drag&drop appointments from one C1Schedule control to another.
	
	* added support	for drag&drop appointments onto C1Calendar control. 
	  User can drop appointments on C1Calendar control if C1Calendar.AllowDrop is true and 
	  C1Calendar.Schedule property is not null.
	  Appointment.Start property will be changed according to the date, selected in the C1Calendar
	  control and C1Schedule control will be navigated to that date. 
	  Note: if there are several C1Schedule controls in application, appointment will be moved 
	  to the C1Schedule control specified in C1Calendar.Schedule property.
	  
	* added support for drag&drop .ics, .dat and .xml files with saved schedule data onto 
	  C1Schedule control.

=================================================================================
C1Schedule Build Number 2.0.20081.60   Build Date: 03/08/2008
=================================================================================
Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
	* implemented support of appointment actions. 
	  Appointment.Action property determines an action to take when the current system time reaches 
	  the start of the owning Appointment object. 
	  By default, control tries to start the system process executing an action.
	  To change this behavior you can set CancelAppointmentEventArgs.Cancel property to true
	  in event handler for C1Schedule.AppointmentCustomAction event.
	  
	  Here is a sample of setting appointment action:
		private void c1Schedule1_AppointmentAdded(object sender, AppointmentEventArgs e)
		{
			Action action = new Action();
			action.Command = "http://www.componentone.com";
			e.Appointment.Action = action;
		}
	
	* added implementation of ISerializable interface to the RecurrencePattern class.
	  IMPORTANT UPGRADE NOTE: if you use binary serialization to save your data, before upgrading
	  to this version, save all data to xml format with an old version and then restore from xml with 
	  this or newer version.
	  Don't forget to mention that in documentation if you distribute your application.	
	
	* implemented creation of a new appointment on pressing 'Enter' key in the selected
	  time slot or day.
	  
	* changed C1Schedule events (AppointmentAdded, AppointmentRemoved, AppointmentChanged) behavior.
	  When one of these events is fired you can be sure that all changes have already been populated to the
	  underlying data source.  
	  
Corrections 
------------------------------------------- 
	* fixed bug:
	  - at moving occurrences of a recurrence pattern to other dates, the number of occurrences and their
	    dates not always saved and restored correctly at restarting an application. This issue
	    is related to recurrence patterns with limited number of occurrences.
	    
	* changed xml serialization behavior: if Appointment property has it's default value, this value
	  is not saved to xml. 

=================================================================================
C1Schedule Build Number 2.0.20081.59   Build Date: 02/08/2008
=================================================================================
Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
	* V1/2008 build
	
	* Added new property to CalendarInfo class:
		
		public CultureInfo CultureInfo { get; set; }
	  
	  Gets or sets the CultureInfo object which holds culture-specific information used by C1Schedule components.

=================================================================================
C1Schedule Build Number 2.0.20073.58   Build Date: 01/18/2008
=================================================================================
Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
	* Hot-fix build
	
	- added new method to RecurrencePattern class:
		
		public string GetDescription(CalendarInfo calendarInfo);
	  
	  This method returns the human-readable description of the RecurrencePattern object
	  according to the specified CalendarInfo object.
	  Use this method instead of Description property if the RecurrencePattern 
	  object does not belong to the C1Schedule control.
	  Note: If the RecurrencePattern object does not belong to the C1Schedule control,
	  its Description property will return the default description using current 
	  user culture and calendar settings.
	
=================================================================================
C1Schedule Build Number 2.0.20073.57   Build Date: 11/02/2007
=================================================================================
Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
	* T3/2007 build

=================================================================================
C1Schedule Build Number 2.0.20072.48   Build Date: 08/03/2007
=================================================================================
Corrections 
------------------------------------------- 
	- fixed bug:
	  when restoring appointment from xml with Appointment.FromXml method, an 
	  extra appointment gets shown for Today date.

=================================================================================
C1Schedule Build Number 2.0.20072.47   Build Date: 07/20/2007
=================================================================================
Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
	- added new properties to BeforeAppointmentFormatEventArgs class:
		public System.Drawing.Color BackColor {get; set; }
		public System.Drawing.Color BackColor2 {get; set; }
		These properties allow to set custom background color and custom 
		background gradient color for the appointment element. 
		Leave the property value System.Drawing.Color.Empty to use default color value 
		determined by the Appointment.Label property. For example:
			private void c1Schedule1_BeforeAppointmentFormat(object sender, BeforeAppointmentFormatEventArgs e)
			{
				if (e.Appointment.Resources.Contains(myResource))
				{
					// Leave e.BackColor empty to show default back color corresponding to Appointment.Label.
					// Set gradient color to Navy to highlight appointments with myResource.
					e.BackColor2 = Color.Navy;
				}
			}
	
	- added new public property to the C1Calendar control:	/// <summary>
		public CalendarInfo CalendarInfo { get; }
		This property gets the CalendarInfo object for the C1Calendar control.
		If C1Calendar control is attached to the C1Schedule control, this property returns 
		the same object as C1Schedule.CalendarInfo property.
	
	- added new public method to C1Schedule:
		public void EnsureVisibleTime(TimeSpan time);
		This method ensures that the specified time is visible within the control, 
		scrolling the contents if necessary. It doesn't make sense 
		for MonthView and Office 2003 WeekView modes.
	
Corrections 
------------------------------------------- 
	- fixed issue with Appointment.Conflicts.Count = 1 if there is no conflicts.

=================================================================================
C1Schedule Build Number 2.0.20072.46   Build Date: 06/26/2007
=================================================================================
Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
    - implemented selection of multiple appointments. End-user can open, export or
	  remove selected appointments. Drag&drop operations for multiple appointments
	  are not supported.
    
	- added new members to C1Schedule:
		public TimeInterval SelectedInterval { get;}
			Gets the currently selected time interval.
		public event EventHandler<SelectedIntervalChangedEventArgs> SelectedIntervalChanged;
			Occurs when selected time interval is changed.
			
		public AppointmentList SelectedAppointments { get;}
			Gets the list of appointments which are selected in the user interface.
		public event EventHandler<SelectedAppointmentsChangedEventArgs> SelectedAppointmentsChanged;
			Occurs when the list of selected appointments is changed.
		public void SelectAppointment(Appointment appointment, bool extendSelection)
			This method selects specified Appointment in the user interface.
			It doesn't change or scroll current view. Use C1Schedule.GoToDate 
			method to bring desired appointment into view:
				GoToDate(appointment.Start);
			If extendSelection is true, specified appointment will be added to 
			the current selection; in other case, current selection will be changed 
			by the specified appointment.

    - added new enum determining the set of default icons shown in appointment element:	
		[Flags]
		public enum AppointmentIcons
		{
			None = 0,
			Occurrence = 1,
			Exception = 2,
			Locked = 4,
			Reminder = 8,
			Continued = 16
		}
		
	- added new formatting capabilities to C1Schedule. 
	  Appointment text and tooltip contain html text. 
	  New events:
	  
	  *	public event EventHandler<BeforeAppointmentTooltipShowEventArgs> BeforeAppointmentTooltipShow;
		  occurs before the appointment tooltip is shown.
	  *	public event EventHandler<BeforeAppointmentFormatEventArgs> BeforeAppointmentFormat;
		  occurs before the appointment content is formatted.
	  *	public event EventHandler<AppointmentLinkClickedEventArgs> AppointmentLinkClicked;
		  fires when the user clicks a hyperlink within the appointment element.
		  You should handle this event if you insert hyperlinks into appointment element.
		
      Samples of using:
      		
		// Change tooltip text or cancel the tooltip: 	
		private void c1Schedule1_BeforeAppointmentTooltipShow(object sender, BeforeAppointmentTooltipShowEventArgs e)
		{
			if (e.Appointment.Importance == ImportanceEnum.High)
			{
				// show bold red text for important appointments.
				if (!String.IsNullOrEmpty(e.Text))
				{
					e.Text = "<div style=\"color:red\"><b>" + e.Text + "</b></div>";
				}
				else
				{
					// if tooltip text is empty (all text is fit into Appointment element),
					// show 'Important' label.
					e.Text = "<div style=\"color:red\"><b>Important</b></div>";
				}
			}
		}
		
		// Change appointment text and icons:
		private void c1Schedule1_BeforeAppointmentFormat(object sender, BeforeAppointmentFormatEventArgs e)
		{
			if (e.Appointment.ReminderSet)
			{
				e.Icons |= AppointmentIcons.Reminder;
			}
			if (!String.IsNullOrEmpty(e.Text) && e.Appointment.Importance == ImportanceEnum.High)
			{
				e.Text = "<div style=\"color:red\"><b>" + e.Text + "</b></div>";
			}
			if (String.IsNullOrEmpty(e.Text) && !String.IsNullOrEmpty(e.Appointment.Body))
			{
				e.Text = "<a href=more>More info...</a>";
			}
		}
		
		// Do the needed actions when user clicks hyperlink:
		private void c1Schedule1_AppointmentLinkClicked(object sender, AppointmentLinkClickedEventArgs e)
		{
			if (e.HRef == "more")
			{
			    MessageBox.Show(e.Appointment.Body);
			}
		}

    - changed codebase for localization.
      Added end-user localization for run-time string resources.
      Localization form available from Smart Tags and from the Smart Designer.
      
      All end user visible strings can be localized (translated) by the developer. 
      C1Schedule localization is based on the same approach as the standard 
      localization of .NET Windows forms employs via the Localizable property. 
      As with Windows forms, a set of resource files (with the extension resx) 
      can be created (a separate file for each required culture) for C1Schedule assembly. 
      When the app runs you can switch between those resources (i.e. between languages). 
      All parts of your app using components from a C1Schedule dll must use 
      the same localization resource.
	  It is recommended that the following conventions are followed when resx files 
		are created:
		• All resx files should live in the subfolder C1LocalizedResources of your project
		• Files should be named as follows:
			XXX.YYY.resx, where:
				– XXX is the name of Component one assembly;
				– YYY is the culture code of the resource.
			For example:
				– C1.Win.C1Schedule.2.de.resx – German (de) resource for C1.Win.C1Schedule.2 
					assembly;
				– C1.Win.C1Schedule.2.resx – Invariant culture resource for C1.Win.C1Schedule.2 assembly.
	  Creating the resource files is easy using the new design time editor accessible 
	  via the “Localize” context menu/action item available on the C1Schedule and C1Calendar
	  controls.
	  To switch the current culture at runtime, the following code can be used:
		Thread.CurrentThread.CurrentUICulture = new CultureInfo("de")
	  This will switch to German locale.

=================================================================================
C1Schedule Build Number 2.0.20072.45   Build Date: 05/30/2007
=================================================================================
Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
	- added new event to C1Schedule component:
		public event EventHandler<BeforeContextMenuShowEventArgs> BeforeContextMenuShow;
	  It occurs before the context menu is shown.
	  Note: this event gets fired even if ShowContextMenu property is false.
	  Here is a sample of removing appointments from the custom menu:
		
    public class Form1 : Form
    {
		private void c1Schedule1_BeforeContextMenuShow(object sender, C1.Win.C1Schedule.BeforeContextMenuShowEventArgs e)
		{
			if (e.Appointment != null)
				this.remove_.Tag = e.Appointment;
			else
				this.remove_.Tag = null;
		}
		private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if (e.ClickedItem == this.remove_ && this.remove_.Tag is Appointment)
				((Appointment)e.ClickedItem.Tag).Delete();
		}
		private void c1Schedule1_Click(object sender, EventArgs e)
		{
			if (((MouseEventArgs)e).Button == MouseButtons.Right && this.remove_.Tag != null)
				this.contextMenuStrip1.Show(PointToScreen(((MouseEventArgs)e).Location));
		}
		...
        private void InitializeComponent()
        {
        ...
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.remove_ = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
		...
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remove_});
 			this.remove_.Name = "remove_";
			this.remove_.Size = new System.Drawing.Size(217, 22);
			this.remove_.Text = "Remove Appointment";
		...
       }
        private C1.Win.C1Schedule.C1Schedule c1Schedule1;
        // MS Context Menu
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem remove_;
	}

=================================================================================
C1Schedule Build Number 2.0.20072.33   Build Date: 05/02/2007
=================================================================================
Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
	- added new public method to CategoryCollection class:
		public List<Category> GetDefaults();
	  It returns the list of predefined categories.

=================================================================================
C1Schedule Build Number 2.0.20072.29   Build Date: 04/23/2007
=================================================================================
Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
	- added export and import of recurring appointments to(from) iCal format.
	  Note that some items from iCal specification are not supported (such as
      Secondly, Minutely patterns, etc.). It is possible that sophisticated recurrent
      event will be imported as the set of events (to fit into C1.C1Schedule's object model).
	- improved iCal export and import. At importing iCal files, component tries
	  to skip errors and import as much information as possible.
	- added processing of patterns such as "last(first, second, etc..)
	  day of month", "last weekday of month", "last weekend of month". 
	- added new property to BasePersistableObject class:
		public object[] Key	{ get; }
		It gets an array of objects represented the key of the BasePersistableObject
		(and all derived objects such as Appointment, Contact, etc.).
		In the current version array always contains single object.
		It can be either Int32 or Guid value depending on which one is actually 
		used for binding this data.
		For example, if you bind AppointmentStorage to the database and set
		IndexMapping, this property will return an Int32 value.
		If you set IdMapping, this property will return a Guid value.
		Note: in future versions working with compound keys might be implemented.
		In such case this property will return array of objects composing the key.


Corrections 
----------- 
	- corrected processing of changing start dates for individual occurrences
	  of the recurrence pattern.

=================================================================================
C1Schedule Build Number 2.0.20072.27   Build Date: 04/11/2007
=================================================================================
Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
	- added new class 
	  public class C1.C1Schedule.TimeZoneInfo
	  It determines time zone properties.
	  This class can be used to receive the list of all available time zones in the 
	  local system and for conversion to/from utc times and local times.

Corrections 
----------- 
	- fixed obfuscation issue at importing/exporting data in binary format.
	  Note, that due to this issue, data saved with previous versions might not be 
	  imported back correctly.

=================================================================================
C1Schedule Build Number 2.0.20071.26   Build Date: 04/06/2007
=================================================================================
Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
    - added horizontal resizing of appointments.
    - changed icons and layout of bubble-look appointments.
	- added new properties to C1ScheduleTheme class (and corresponding controls
	  to smart designers):
		public bool ShowEndTimeMonthView { get; set; }
		public bool ShowEndTimeWeekView { get; set; }
	  these properties determine if appointment end time will be shown in corresponding
	  view.
	- added days and time slots coloring according to the availability status 
	  of appointments. You can turn on or turn of this feature by changing
	  ScheduleTheme.HighlightDayStatus property.
	  By default this feature is enabled for Office 2007 visual styles and disabled
	  for Office 2003 ones.
	- added support for dragging external objects onto C1Schedule. If AllowDrop 
	  property is set to true, end-user will be able to drag any textual information 
	  from other controls onto schedule. That will create a new Appointment object 
	  populated with the dragged data on the given time point. 
	  To customize or get reference to the newly created appointment use C1Schedule's
	  DragDrop event:
		private void c1Schedule1_DragDrop(object sender, DragEventArgs e)
		{
			// check if data contain appointment
			if (e.Data.GetDataPresent(typeof(Appointment)))
			{
				// get appointment object from data
				Appointment app = (Appointment)e.Data.GetData(typeof(Appointment));
				// change appointment subject
				app.Subject = "my test dragged appointment";
			}
		}
	  
	- added new method to C1Schedule class:   
				public DateTime GetDateTimeAtPoint(Point location);
	  It returns the DateTime value which is located in the Schedule at the given screen point.		 
	- added new property to C1Schedule class:
		public TimeSpan FirstVisibleTime { get; set; }
	  It gets or sets the first visible time slot in a DayView. 
	  Note: it affects only initial scroll position of the DayView. 

=================================================================================
C1Schedule Build Number 2.0.20071.25   Build Date: 03/18/2007
=================================================================================
Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
	- class C1.C1Schedule.DateList is no longer inherited from Collection<DateTime>.
	  It's Items property returns reference to the wrapped List<DateTime> instance.
	  
	- added new navigation panels as in MS Outlook 2007. 
	  If there is no appointments in the visible range of dates, 
	  two navigation panels occur on the left and right sides of the schedule. 
	  Clicking on one of them switches current view to the previous or next date 
	  with Appointments. If there is no previous or next appointment, 
	  corresponding panel gets disabled. 
	  These panes are enabled by default in Office 2007 Visual Styles 
	  and disabled in other ones. To show or hide them use 
	  ScheduleTheme.ShowNavigationPanels property.
	  
	- added Browse buttons to the title as in MS Outlook 2007. 
	  Clicking of them switches current view to the next or previous
	  range of dates.
	  These buttons are enabled by default in Office 2007 Visual Styles 
	  and disabled in other ones. To show or hide them use 
	  ScheduleTheme.ShowBrowseButtons property.

=================================================================================
C1Schedule Build Number 2.0.20071.24   Build Date: 03/13/2007
=================================================================================
Enhancements/Documentation/Behavior Changes 
------------------------------------------- 
    - Implemented week tabs in the month view. 
	  By default week tabs are shown in Office 2007 Visual Styles and hidden in other ones. 
	  You can enable or disable them by changing ScheduleTheme.ShowWeekTabs property. 
	  At run-time clicking on the week tab switches C1Schedule to the selected week view.

    - Changed day headers behavior: in all views clicking on the day header switches
      C1Schedule to the selected day view.  

    - Made some changes to the C1Schedule's layout. If you use custom visual styles,
      it might be necessary to adjust borders and border colors.

    - Added Office 2007 embedded palettes and adjusted Office 2003 palettes.
    
		1) Added new enum: 
		   public enum C1.Win.C1Schedule.UI.PaletteType.
			 members:
				* Office2007 - Office 2007 palette includes back and border colors 
								of free and working hours and days, day headers, 
								grid borders and calendar tabs. 
				* Office2003 - Office 2003 palette only includes back and border 
								colors of free and working hours and days. 
								Day headers, grid borders are not changed by such palettes.
				* Custom - Use this type to define your own palettes. For example:
					// Clear default palettes.
					c1Schedule.Theme.Palettes.Clear();
					// Create new palette.
					Palette pal = new Palette(PaletteType.Custom);
					// Set work hour color.
					pal.WorkHour = Color.Red;
					// You might set some other colors of palette as well or leave them empty.
					// Add palette to the theme palettes.
					c1Schedule.Theme.Palettes.Add(pal);
					// add two more palettes
					pal = new Palette(PaletteType.Custom);
					pal.WorkHour = Color.Yellow;
					c1Schedule.Theme.Palettes.Add(pal);
					pal = new Palette(PaletteType.Custom);
					pal.WorkHour = Color.Green;
					c1Schedule.Theme.Palettes.Add(pal);
					// Select palette in control.
					c1Schedule.Theme.CurrentPalette = Color.Yellow;

		2) added new class
		   public class C1.Win.C1Schedule.UI.Palette 
			it represents a set of Color values which are used for displaying C1Schedule control.
			The default value for each field is Color.Empty. 
			For Office 2003 and custom palettes Palette.WorkHour field should
			always contain unique Color value before adding the Palette object to 
			the Palettes collection.
			For Office 2007 palettes Palette.AlternateMonth field should always contain 
			unique Color value before adding the Palette object to the Palettes collection.
			For other fields Color.Empty is allowed. In such case control uses 
			the corresponding color from the theme definition.
		
		3) added new class
		   public class C1.Win.C1Schedule.UI.Palettes : KeyedCollection<Color, Palette>
			it represents a collection of available color palettes for the C1Schedule 
			Visual Style. C1Schedule component uses this collection to switch currently 
			used palettes.
			The key of collection is a Color value which is shown in the 
			C1.Win.C1Schedule.Forms.PaletteForm form.
			For Office 2003 palettes key is a color of the working hours and alternate 
			month days.
			For Office 2007 palettes key is a color of alternate month days, all-day area 
			and dark horizontal borders in the day view.
			
		4) added new properties to the ScheduleTheme class:
			public bool UseOffice2007Pallettes { get; set; } determines if control 
				uses Office 2003 or Office 2007 palettes should be used. 
			public bool ShowTodayBorder { get; set; } determines if control should 
				show orange border around today date (as in Office 2007). 
			public bool ShowWeekTabs { get; set; } determines if control should show 
				week tabs in the MonthView 
			public Color CurrentPalette	{ get; set; } Gets or sets Color value 
				determining the currently used palette. At setting this property C1Schedule
				control tries to find corresponding palette in Palettes collection 
				and attaches it to the views.
			public Palette Palette { get; } Gets the currently used Palette object.
			public Palettes Palettes { get; } Gets the Palettes collection available 
				for the current theme.
    
		5) ScheduleTheme.BackGround and ScheduleTheme.BackGround2 properties marked 
		   as obsolete. Use ScheduleTheme.CurrentPalette property instead.
		   
    - Changed layout of Visual Style smart designer's windows. Added new controls for
      editing gradients.
    

===========================================================================
C1Schedule  Build Number 2.0.20071.23   Initial Release: February 16, 2007
===========================================================================
