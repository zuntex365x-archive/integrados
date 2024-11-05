==================================================================
C1GanttView               ComponentOne, LLC - www.componentone.com
==================================================================

Welcome to ComponentOne GanttView for WinForms.

The C1GanttView control is designed for project management.
Projects can be managed effectively by adding several project
related details, such as start time, finish time, resources,
deadlines, constraints and dependencies, to each task.

C1GanttView delivers a Microsoft Project-like user experience
with more than one way to manage tasks. Users can edit task
information through a tabular data grid, input dialog, or by
clicking and dragging bars within the timeline.

------------------------------------------------------------------
ComponentOne GanttView is an integral part of Studio Enterprise,
the largest and most complete toolset for developing Win, Web,
Mobile and ASP.NET AJAX enabled applications.

Please direct feedback for GanttView to the following forum:

http://our.componentone.com/groups/winforms/ganttview-for-winforms/forum/

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

ComponentOne GanttView for WinForms installs the following
files and controls.

Files: C1.Win.C1GanttView.2/4.dll, C1.Win.C1GanttView.2/4.XML,
       C1.Win.C1GanttView.4.Design.dll

Controls: C1GanttView
------------------------------------------------------------------

History of Changes
==================================================================
C1GanttView 2/4.0.20142.221                 Build Date: 08/26/2014
==================================================================

- Fixed an issue: Application hangs when setting PercentComplete
  property after loading XML in C1GanttView (TFS 83143).

==================================================================
C1GanttView 2/4.0.20142.220                 Build Date: 08/07/2014
==================================================================

- Fix an issue: [Localization] Context of Dialogs, Menu dropdows 
  and ToolTips are not fully localized to Korean Localization
  (TFS 76489).

- Fix an issue: [Localization] Context of Dialogs, Menu dropdows 
  are not fully localized to Chinese Localization (TFS 76505).

- Fix an issue: Undo button is active a while, on adding/removing 
  of "ProjectSummaryTask" in ReadOnly GanttView (TFS 78904).

- Fix an issue: Ctrl+Z/Ctrl+Y shortcuts are working in ReadOnly 
  C1GanttView (TFS 78971).

- Fix an issue: Digit incremental of FilterName is inconsistent 
  in "More Filters" Dialog (TFS 78997).

- Fix an issue: StartDate of Successor Task is not reset to it's 
  original value after 'Undo' action has been performed (TFS 79035).

- Fix an issue: Duplicate Name entries are added in Resources/
  WorkWeek/Exceptions collection after deleting one entry (TFS 79138).

==================================================================
C1GanttView 2/4.0.20142.219                 Build Date: 08/06/2014
==================================================================

- Fixed an issue: Matched Tasks are not shown in C1GanttView
  while applying of Advanced Filter with Empty Values (TFS 79265).

- Fixed an issue: After applying a filter, the vertical scroll
  thumb is not retained at top (TFS 79272).

==================================================================
C1GanttView 2/4.0.20142.217                 Build Date: 08/01/2014
==================================================================

- Fix an issue: Undo/Redo menu buttons are active in ReadOnly 
  C1GanttView (TFS 78526).

==================================================================
C1GanttView 2/4.0.20142.216                 Build Date: 07/31/2014
==================================================================

- Fix an issue: [Localization] Context of Dialogs, Menu dropdows 
  and ToolTips are not fully localized to Korean Localization
  (TFS 76489).

- Fix an issue: [Localization] Context of Dialogs, Menu dropdows 
  are not fully localized to Chinese Localization (TFS 76505).

=================================================================
C1GanttView 2/4.0.20142.215                 Build Date: 07/28/2014
==================================================================

- Fix an issue: StackOverflowException Exception occurs in 
  C1.Win.C1GanttView dll, while adding of OutlineParentID to 
  dynamically created tasks (TFS 76306).

- Fix an issue: Text in StyleSettings Dialog and More Filter Dialog 
  are not fully Localized in Japanese String (TFS 76458).

- Fix an issue: GridView of C1GanttView is crash when RemoveChild() 
  method is called to remove the child task (TFS 76608).

- Fix an issue: System.NullReferenceException occurs pressing Undo 
  menu button after deleting the row (TFS 76926).

- Fix an issue: Multiple performance issues are observed in 
  C1GanttView (TFS 74002).

- Add partial missed Chinese, Korean strings from TFS 76505, 76489.

==================================================================
C1GanttView 2/4.0.20142.214                 Build Date: 07/21/2014
==================================================================

- Fix an issue: [Enhancement] Request to provide support to access 
  C1GanttView object in PrintInfo class (TFS 69265):
  + Add C1GanttView.PrintInfo.Scale property: Set double value from
  0.1 to 5.0 to scale gantt view when printing.
  + To change PrintInfo.Scale by GUI, see View tab in Style 
  Settings dialog.

- Fix an issue: [Enhancement] Request to provide support to export
  /import Calendar information only in C1GanttView (TFS 75292):
  + Add LoadXml/SaveXml method to C1GanttView.CustomCalendars.

- Fix an issue: Edit and Delete button of MoreFilters are not 
  getting active at once, when 1st filter is created (TFS 76207).

- Fix an issue: Deleted Filter is shown in AdvancedFilter Dialog, 
  while editing of 2nd AdvancedFilter after deleting 1st 
  AdvancedFilter (TFS 76215).

==================================================================
C1GanttView 2/4.0.20142.213                 Build Date: 07/18/2014
==================================================================

- Fix an issue: Multiple performance issues are observed in 
  C1GanttView (TFS 74002).

==================================================================
C1GanttView 2/4.0.20142.212                 Build Date: 07/16/2014
==================================================================

- Fix an issue: Filtering does not work with Enum type Custom 
  Column (TFS 74841).

- Fix an issue: Child tasks are not sorted when parent tasks are 
  sorted based on OutlineParentID property (TFS 74018).

- Fix an issue: [Enhancement] Request to provide support to sort 
  tasks based on Custom Column (TFS 74020).

- Fix an issue: [Query] Request to please clarify how to remove 
  Outlines from tasks in C1GanttView (TFS 74838).

==================================================================
C1GanttView 2/4.0.20142.211                 Build Date: 07/04/2014
==================================================================

- Localze to Japanese/Chinese for some parts of Sort, Filter...

==================================================================
C1GanttView 2/4.0.20142.210                 Build Date: 06/30/2014
==================================================================

- Add undo/redo support for changing task's field styles.

- Fix an issue: CheckBoxes of Boolean CustomColumn are shown Left 
  Alignment in GridView (TFS 70746).

- Fix an issue: [C1Ganttview] ‘Duration’ is still remained although 
  'Undo' button is clicked (TFS 72423).
 
- Fix an issue: [C1Granttview]"SelectedTaskIndex" is shown as two 
  values after clicking ‘MoveTaskUp’ button (TFS 72274).

==================================================================
C1GanttView 2/4.0.20142.209                 Build Date: 06/27/2014
==================================================================

- Support issue: [Enhancement] Request to provide support for 
  changing the Fontcolor of a specific cell in C1GanttView 
  (TFS 68329):
  We could change the Font/Background Color/Foreground color for
  a specific cell or row on grid view. The both design-time and runtime are 
  supported.

  - GUI: select 'Field Styles...' item by right click to grid view;
    or select a task then click to the 'Field Styles...' button on
	toolstrip.

  - Programmatically:
    
	Use the following code snippet to configure style for cell that
	represents 'Name' property of Task:
	//-------------------------------------------------------------
	FieldStyle  fs = new FieldStyle(StyleField.Name, null);
	task.FieldStyles.Add(fs);
	//-------------------------------------------------------------

	Use the following code snippet to configure style for row that
	represents Task on grid view:
	//-------------------------------------------------------------
	FieldStyle  fs = new FieldStyle(StyleField.All, null);
	task.FieldStyles.Add(fs);
	//-------------------------------------------------------------

	Use the following code snippet to configure style for cell that
	represents the custom field of Task:
	//-------------------------------------------------------------
	FieldStyle  fs = new FieldStyle(StyleField.Custom, "WBS_ID");
	task.FieldStyles.Add(fs);
	//-------------------------------------------------------------

	Note: The changing of Group task or summary task field styles 
	in group view are not allowed.

==================================================================
C1GanttView 2/4.0.20142.208                 Build Date: 06/19/2014
==================================================================

- Add Undo/Redo feature: All the following actions are supported,
  they have to invoke in non-programmatically ways such as clicking
  to toolstrip items or interact with grid/chart by mouse/keyboard:
	+ Change grid columns
	+ Move task up
	+ Move task down
	+ Change Task Info
	+ Add new task
	+ Add new summary task
	+ Add blank row
	+ Delete task
	+ Outdent task
	+ Indent task
	+ Show project summary
	+ Group by predefined/custom group
	+ Clear group
	+ Maintain Hierarchy changing
	+ Filter by predefined filters/custom filter
	+ Show related summary rows changing
	+ Change AdvancedFilter collection by More Filters dialog
	+ Sort by predefined/custom sorting
	+ Remove sort
	+ Change Project settings
	+ Change Working Time settings
	+ Change Progress Line settings
	+ Change Resources
	+ Change Timescale settings
	+ Change BarStyles
	+ All zoom actions
	+ Link task by mouse dragging
	+ Move task by mouse dragging
	+ Change task start/finish by mouse dragging
	+ Change task's deadline by mouse dragging
	+ Change task's percent complete by mouse dragging
	+ Create initialized task by mouse dragging
	+ Change task's properties in grid view cell
  To support undo/redo for custom actions are created by user,
  please implement the BaseCommand class. Overrides Execute() and
  Unexecute() methods that will be called when perform undo/redo.

  Use the below code snippet to add custom command to GanttView:

  //-------------------------------------------------------------

  public class CustomCommand : BaseCommand{}

  CustomCommand cmd = new CustomCommand(c1GanttView);
  cmd.Execute();

  //-------------------------------------------------------------

==================================================================
C1GanttView 2/4.0.20142.207                 Build Date: 06/19/2014
==================================================================

- Fix an issue: Dropdowns of "Sort" Dialog are not AutoCompleted 
  while entering the Text (TFS 70919).

- Fix an issue: Previewing Empty GanttView with 'Legend Every 
  Pages' PrintStyle , Legend are shown in PrintPreview (TFS 70993).

- Change JPN strings for PrintInfo.PrintAllGridColumns and 
  PrintInfo.NumberOfFirstColumns property descriptions.

==================================================================
C1GanttView 2/4.0.20141.206                 Build Date: 06/17/2014
==================================================================

- Fix an issue: ChartView does not show Start Point of 
  ProjectSummaryTask when adding ProjectSummaryTask after calling 
  Clear() method (TFS 70310).

- Fix an issue: [Win8.1]In Advanced Filter Dialog, Selected 
  TestOperator is lost while opening of Value(s) dropdown or 
  clicking 'Save' button (TFS 70608).

- Fix an issue: [C1GanttView] Unlike previous build, 
  ArgumentException is occurred when sorting task (TFS 70610).

- Fix an issue: Unlike other columns, Predecessor are lost in 
  GridView while grouping is applied to Task (70680).

- Fix an issue: Current ViewState is not retained while adding 
  of SummaryTask after calling ScrollToTask() (TFS 70729).

==================================================================
C1GanttView 2/4.0.20141.205                 Build Date: 06/16/2014
==================================================================

- Fix an issue: ArgumentOutOfRangeException occurs  while sorting 
  after calling Tasks.Clear() methods in Tasks existing GanttView
  (TFS 70173).

- Fix an issue: [C1GanttView] Unlike previous build, Task 
  Information and Delete Task toolbar button is disabled after 
  grouping task (TFS 70280).

- Fix an issue: [Regression]Changing of Default BarStyle also 
  affected to the currently selected Task which has different 
  BarStyle (TFS 70466).

- Fix an issue: [Win8.1] NullReferenceException occurs in 
  C1.Win.C1GanttView dll when selecting 'Is Within'/
  'Is Not Within' TestOpearator in Advanced Filter Dialog
  (TFS 70532).

==================================================================
C1GanttView 2/4.0.20141.204                 Build Date: 06/13/2014
==================================================================

- Fix an issue: PrintPreview dialog title text does not change to 
  Japanese on using JPN Builds (TFS 69462).

- Fix an issue: [Enhancement] Request to provide support to access 
  StyleSettings dialog in code (TFS 69456): 
  Just add comments to PrintInfo.PrintAllGridColumns and 
  PrintInfo.NumberOfFirstColumns properties to clarify the usage.

- Fix an issue: System.ArgumentException occurs while opening of 
  "Advanced Filter" Dialog (TFS 69876).

- Fix an issue: Current ViewState is lost while sorting the 
  grouped Tasks in C1GanttView (TFS 69927).

==================================================================
C1GanttView 2/4.0.20141.203                 Build Date: 06/06/2014
==================================================================

- Fix an issue: [41514] Request to provide method to filter tasks 
  based on Custom Columns(TFS 63881):

  To filter for custom fields, please use AdvanceFilter. You could
  select the custom fields in AdvanceFilter dialog or by following 
  code snippet:

	  ConditionTaskFilter condition = new ConditionTaskFilter();
	  condition.FilterField = FilterField.Custom;
	  condition.FilterFieldName = "CustomFieldName";
	  condition.TestOperator = TestOperators.Equal;
	  condition.FilterValue = 1;

==================================================================
C1GanttView 2/4.0.20141.202                 Build Date: 06/05/2014
==================================================================

- Fix an issue: [43390] Tasks added in 'BeginUpdate'& 'EndUpdate' 
  Methods are not shown in the C1GanttView (TFS 68025).

- Fix an issue: NullReferenceException occurs in C1.Win.C1GanttView 
  dll, while C1GanttView is sorted by SortTask() with the instance 
  of TaskComparer (TFS 68505).

==================================================================
C1GanttView 2/4.0.20141.201                 Build Date: 05/30/2014
==================================================================

- Fix an issue: [Query] Request to provide method to scroll to 
  Task Time interval in the scheduler (TFS 64592).
  Add an overload method to scroll to the begining of task:
  ScrollToTask(Task task, bool scrollToBegining);

- Fix an issue: Checked mark does not show on currently select 
  Sorting Type in Sort Menu Dropdown (TFS 67083).

==================================================================
C1GanttView 2/4.0.20141.200                 Build Date: 05/21/2014
==================================================================

- Fix an issue: Unlike previous build, 'Zoom Selected Task' toolbar 
  button is enabled although no task is selected (TFS 67440).

==================================================================
C1GanttView 2/4.0.20141.199                 Build Date: 05/20/2014
==================================================================

- Fix an issue: Value can not be added to Object DataType Columns 
  through C1GanttView.Tasks Collection Editor (TFS 67284).

- Fix an issue: System.Reflection.AmbiguousMatchException thrown 
  on previewing of CustomFieldColumn contained GanttView 
  (TFS 67314).

- Fix an issue: System.NullReferenceException occurs while opening 
  of child dialog customized TaskInfomation Dialog (TFS 67365).

==================================================================
C1GanttView 2/4.0.20141.198                 Build Date: 05/20/2014
==================================================================

- Fix an issue: Return CurrentComparer value is always constant 
  for sorting type by using 'PropertyDescriptor' (TFS 66990).

- Fix an issue: Checked mark does not show on currently select 
  Sorting Type in Sort Menu Dropdown (TFS 67083).

- Fix an issue: Some TaskProperties are not listed in 
  SortBy/ThenBy dropdowns of Sort Dialog (TFS 67097).

- Fix an issue: Filtered Tasks are added blank rows between 
  them while changing in C1GanttView.Tasks Collection Editor
  (TFS 67202).

- Fix an issue: [Regression] SummaryTask is not added to the 
  1st index Task after applying the sorting (TFS 67243).

- Fix an issue: ArgumentOutOfRange exception occurs while 
  grouped Tasks are added Task/SummaryTask/BlankRow (TFS 67251).

==================================================================
C1GanttView 2/4.0.20141.197                 Build Date: 05/19/2014
==================================================================

- Fix an issue: Exceptions occur in C1.Win.C1GanttView dll while 
  some action are performed on Empty GanttView (TFS 65152).

- Fix an issue: Object Reference Exception occurs while loading of 
  Empty "usingResourcePredefined" Filter containing xml (TFS 65981).

- Fix an issue: [C1GanttView] Selected 'ListSortDirection' are 
  lost on 2nd time opening of 'Sort' Dialog (TFS 66805).

- Fix an issue: [Regression]BarStyle is inconsistent for DesignTime 
  loading and RunTime Loading in Themes Applied C1GanttView
  (TFS 66144).

- Fix an issue: 'ScrollToTask' method does not works at Form Load
  (TFS 66275).

- Fix an issue: [Enhancement] Request to provide public dialog 
  form classes from which custom dialogs can be generated
  (TFS 66297).

- Fix an issue: Removing of applied grouping in ReadOnly 
  C1GanttView, some menu items are active and allow to perform 
  UserInteraction (TFS 66886).

==================================================================
C1GanttView 2/4.0.20141.196                 Build Date: 05/13/2014
==================================================================

- Fix an issue: Exceptions occur in C1.Win.C1GanttView dll while 
  some action are performed on Empty GanttView (TFS 65152).

- Fix an issue: Object Reference Exception occurs while loading of 
  Empty "usingResourcePredefined" Filter containing xml (TFS 65981).

- Fix an issue: Default Selection is lost in TasksCollectionEditor 
  after deleting of SummaryTask (TFS 66087).

==================================================================
C1GanttView 2/4.0.20141.194                 Build Date: 05/08/2014
==================================================================

- Merge fixes from JPN v1.1.

- Fix an issue: [Enhancement] Request to synchronize Newly added 
  Custom Columns in "Tasks Collection Editor" in Design Time
  (TFS 40669).

- Fix an issue: [Forum][Enhancement[ Request to provide support 
  for ReadOnly mode (TFS 43091):
  + The C1GanttView.ReadOnly is added to enable/disable readonly
	mode.

- Fix an issue: Deleting Behavior of Summary Task is inconsistent 
  for run time deleting and design time deleting process (TFS 49067).

- Fix an issue: [Enhancement]Request to provide a method or property 
  to get current sorting state of C1GanttView (TFS 50500):
  + The C1GanttView.CurrentComparer is added to get current state 
	sorting of C1GanttView.

- Fix an issue: [Enhancement]Request to provide Build-In Sorting 
  features for all TaskProperties at C1GanttView ToolBar (TFS 50549):
  + The new sort menu is added to tool bar.

- Fix an issue: Line feeds contained 'Notes' are cut off in 
  PrintPreview (TFS 56519).

- Fix an issue: Task BarStyles of a GanttView is honored to another 
  ThemeApplied GanttView in project (TFS 57235).

- Fix an issue: Applied AdvancedFilters is not shown in 
  AdvancedFilter Dialog while using ApplyFilters() method 
  (TFS 60634):
  + Remove C1GanttView.ApplyFilters() method.
  + There's only one filter is applied at the same time. The current
    filter is referenced at FilterDefinition.CurrentFilter.
  + FilterDefinition.Items stores the exist advanced filters.
  + Select More Filters item in Filter menu to edit exist advanced
    filters.

- Fix an issue: [41576] Incorrect value is returned on getting 
  Tasks.Count property when no tasks are added in the control 
  (TFS 63923):
  + The new property: TaskCollection.NonEmptyTaskCount is added to 
    get the initialized task count.

==================================================================
C1GanttView 2/4.0.20141.193                 Build Date: 05/01/2014
==================================================================

- Fix an issue: [Regression]AdvancedFilter items in 
  AdvancedFilterDialog becomes twice while "Show Related Summary 
  Row" is checked (TFS 65031).

- Fix an issue: [Regression] C1GanttView is distorted while 
  loading of XML and Undo action at DesignTime (TFS 65044).

==================================================================
C1GanttView 2/4.0.20141.192                 Build Date: 04/30/2014
==================================================================

- Fix an issue: [JP Environment]InvalidOperationException occurs 
  while second time opening of AdvancedFilter Dialog (TFS 64984).

==================================================================
C1GanttView 2/4.0.20141.191                 Build Date: 04/29/2014
==================================================================

- Fix an issue: [Regression]NullReferenceException occurs while 
  Empty Resource Tasks are sorted by SortTasks() method (TFS 64735).

- Fix an issue: [Sample]Warning MessageBox shown on loading of 
  CustomTaskInfoDialog C# Sample (TFS 64961).

==================================================================
C1GanttView 2/4.0.20141.190                 Build Date: 04/26/2014
==================================================================

- Fix an issue: Contents of the BarStyle Dialog is not fully 
  supported for Japanese localization (TFS 63239): Add Japanese
  strings for predefined text header/footer in printing.

- Fix an issue: [Enhancement] Request to provide a method to notify 
  changes in C1GanttView.SelectedTask (TFS 64496).

==================================================================
C1GanttView 2/4.0.20141.189                 Build Date: 04/25/2014
==================================================================

- Fix an issue: Contents of the BarStyle Dialog is not fully 
  supported for Japanese localization (TFS 63239).

==================================================================
C1GanttView 2/4.0.20141.188                 Build Date: 04/15/2014
==================================================================

- Fix an issue: [41513] Request to provide method to customize 
  'Task Information' dialog (TFS 63492): Add C1GanttView.ShowDialog 
  event, user can replace their own dialog at this event handler.

- Add CustomTaskInfoDialog sample.

==================================================================
C1GanttView 2/4.0.20141.187                 Build Date: 04/11/2014
==================================================================

- Fix an issue: When Summary Task is deleting through 
  C1GanttView.Task Collection Editor, Object reference exception 
  is thrown (TFS 49017).

- Fix an issue: InvalidOpearationException occurs while 'None' 
  PropertyDescriptor is sorted by GanttView.Tasks.Sort() method
  (TFS 63144).

- Fix an issue: Sorting Results are different when using 
  Tasks.Sort() and SortTasks()  methods (TFS 63183).

- Fix an issue: Blank rows are sorted first while sorting of 
  'Name'/'ResourceName' by using Tasks.Sort() (TFS 63205).

- Fix an issue: RemoveSort() method does not remove the sorting of 
  Tasks.Sort() (TFS 63206).

- Fix an issue: Contents of the BarStyle Dialog is not fully 
  supported for Japanese localization (TFS 63239).

- Fix an issue:[Regression] Sorting of Late Task does not retained 
  the current ViewState (TFS 63477).

- Fix an issue: [Regression]"Resources" Dialog Name is shown as 
  'Recurrence Pattern' (TFS 63676).

- Fix an issue: [Regression]IndexOutOfRange Exception occurs in 
  C1GanttView.Columns Collection Editor while changing of 'Visible' 
  property of a column (TFS 63677).

==================================================================
C1GanttView 2/4.0.20141.186                 Build Date: 04/08/2014
==================================================================

- Fix an issue: [Regression]Vertical ViewState are not retained on 
  changing of Task's properties (TFS 60636).

- Fix an issue: [Regression]ChartView state is not retained whiel 
  adding ProjectSummaryTask to C1GanttView dynamically (TFS 63335).

- Fix an issue: Task Bars are hidden while hiding of 'ProjectSummary 
  Task' on its collapsed state (TFS 63370).

- Fix an issue: Selected Task is not affected while 'Default' BarS-
  tyle is changed at RunTime (TFS 63406).

==================================================================
C1GanttView 2/4.0.20141.185                 Build Date: 04/07/2014
==================================================================

- Fix an issue: [Regression]Columns are not shown in GridView while 
  adding them at RunTime (TFS 63325).

==================================================================
C1GanttView 2/4.0.20141.184                 Build Date: 04/04/2014
==================================================================

- Fix an issue: Chart DateFormat does not honor to the System 
  DateFormat (TFS 59189).

- Fix an issue: [Regression]Vertical ViewState are not retained on 
  changing of Task's properties (TFS 60636).

- Fix an issue: [Regression]Current ViewState is not retained 
  while debugging the project (TFS 63302).

==================================================================
C1GanttView 2/4.0.20141.183                 Build Date: 04/02/2014
==================================================================

- Add Japanese localization to :
  + Field Name combo box items in Advanced Filter dialog.
  + BeforePrint/BeforePrintPreview event description.

==================================================================
C1GanttView 2/4.0.20141.182                 Build Date: 03/31/2014
==================================================================

- Fix an issue: [Query]Request to provide solution to sort Tasks 
  in GanttView (TFS 49216):
  + Add TaskCollection.Sort(PropertyDescriptor prop, 
    ListSortDirection direction) method to sort Tasks.

==================================================================
C1GanttView 2/4.0.20141.181                 Build Date: 03/25/2014
==================================================================

- Fix an issue: Chart DateFormat does not honor to the System 
  DateFormat (TFS 59189).

- Fix an issue: [Regression]Vertical ViewState are not retained on 
  changing of Task's properties (TFS 60636).

==================================================================
C1GanttView 2/4.0.20141.180                 Build Date: 03/18/2014
==================================================================

- Fix an issue: Line feeds contained 'Notes' are cut off in 
  PrintPreview (TFS 56519).

- Fix an issue: [Regression]TodayLine is outside the visible screen
  (TFS 59892).

- Fix an issue: [Regression]Last column is not printed in 
  PrintPreview (TFS 60182).

==================================================================
C1GanttView 2/4.0.20141.179                 Build Date: 03/17/2014
==================================================================

- Fix an issue: ChartView rendering is uneven while loading of 
  .xml in tasks existing C1GanttView (TFS 57221).

- Fix an issue: Changing of some properties to Tasks at run time 
  after calling ScrollToTask , C1GattView does not maintain current 
  view state (TFS 57266).

- Fix an issue: ChartView area is crashed in vertical scrolling 
  and swithching of ZoomFactor (TFS 57331).

- Fix an issue:  End Shpae of SummaryTaskBar is cut off on Vertical 
  Scrolling (TFS 57923).

- Fix an issue: Summary Task is disappered when adding new 
  Predecessors/ResourceRefs at design time through C1GanttView.Task 
  Collection Editor (TFS 58209).

- Fix an issue: [Regression]Row Height of C1GanttView is increased 
  on changing of Column Width (TFS 58447).

- Fix an issue: [Regression]Text in Last Column are shift to next 
  line and cut off in PrintPreview (TFS 59201).

==================================================================
C1GanttView 2/4.0.20141.178                 Build Date: 03/14/2014
==================================================================

- Fix an issue: [Enhancement]C1GanttView is not get licensed with 
  Studio For Desktop Key (TFS 57209).

- Fix an issue: Changing of some properties to Tasks at run time 
  after calling ScrollToTask , C1GattView does not maintain 
  current view state (TFS 57266).

- Fix an issue: [Query] How to test "Add grid view fonts to 
  printing" in ReadMe (TFS 57342).

- Fix an issue: Newly added Filter Sample is not found in Site1 
  (TFS 56055).

==================================================================
C1GanttView 2/4.0.20141.177                 Build Date: 03/13/2014
==================================================================

- Fix an issue: [Query] SelectedIndexChanged event fired twice on 
  grouping of Tasks (TFS 56113).

- Fix an issue: Changing of BarStyle after 'Scroll To Task', 
  C1GanttView does not maintain current view state (TFS 56559).

- Fix an issue: GroupTasks are lost in C1GanttView on clicking 
  Expand/Collapse while 'IsWithin'/'IsNotWithin' TestOperator is 
  used to Filter (TFS 56657).

- Fix an issue: [Regression]FilterValues are shown as C1.Win.C1G-
  anttView.j in Advanced Filter Dialog, when 'IsWithin'/
  'IsNotWithin' TestOperator is used (TFS 57042).

- Fix an issue: Unlike other Predifined FilterType, "Completed 
  Tasks" filter is not retained on loading of .xml (TFS 57188).

- Fix an issue: NullReference Exception is occurs in C1.Win.
  C1GanttView dll on saving of .xml while FilterValue is null
  (TFS 57199).

- Add grid view fonts to printing.

==================================================================
C1GanttView 2/4.0.20141.176                 Build Date: 03/12/2014
==================================================================

- Fix an issue: Event firing Times of SelectedIndexChanged 
  increases large counts starting from 2nd time sorting (TFS 56108).

- Fix an issue: Tasks are lost while grouping and setting of 
  'Maintain Hierarchy'  to OultlineLevel filter applied GanttView
  (TFS 56592).

- Fix an issue: GroupTasks are lost in C1GanttView on clicking 
  Expand/Collapse while 'IsWithin'/'IsNotWithin' TestOperator is 
  used to Filter (TFS 56657).

- Fix an issue: System.FormatException occurs in AdvancedFilter 
  Dialog while Invalid FilterValue is set through code snipped
  (TFS 56668).

- Fix an issue: [Regression]Moving Times of ScrollBars is 
  significantly increased while sorting (TFS 56725).

- Fix an issue: [Regression]Expand/Collapse state of SummaryTasks 
  button does not reflect at once in filtered GanttView (TFS 56759).

- Fix an issue: Unlike other group types, "Task Completes Vs Task 
  Incomplete" grouping is not retained while loading of .xml at 
  DesignTime (TFS 56807).

- Fix an issue: NullReference Exception occurs in C1.Win.C1GanttView 
  dll when saving of .xml while ResourceFilter is applied (TFS 56815).

- Fix an issue: [C1Theme]Unhandled exception is occurred if 
  “Transparent“ is set to SplitterColor of  c1GanttView (TFS 47059).

==================================================================
C1GanttView 2/4.0.20141.175                 Build Date: 03/10/2014
==================================================================

- Fix an issue: Expand/Collapse button of GroupTask remains the 
  old place instead of moving belong with GroupTaskName while Task
  Name column is moved (TFS 56455).

- Fix an issue: Copying of Text in Value(s) TextBox of Advanced 
  Filter dialog, it get copied the whole row (TFS 56490).

- Fix an issue: FileFormat Exception occurs while loading of .xml 
  file which contains 'Is Within'/'Is Not Within' Filter for 
  Start/Finish Column (TFS 56492).

- Fix an issue: Line feeds contained 'Notes' are cut off in Print-
  Preview (TFS 56519).

- Fix an issue: Error occurs in loading of .xml which contains 
  OutlineLevel filter with 'IsWithin'/'IsNotWithin' TestOperator
  (TFS 56595).

==================================================================
C1GanttView 2/4.0.20141.174                 Build Date: 03/07/2014
==================================================================

- Fix an issue: Creating a new task in Filtered GanttView, the ne-
  wly created task move upward even it does not match the applied 
  filter (TFS 56193).

- Fix an issue: [Regression] GroupText are not displayed in Chart-
  View (TFS 56207).

- Fix an issue: 'TaskMode' are summrized in Maintain Hierarchy Su-
  mmaryTasks (TFS 56237).

- Fix an issue: [Regression]Error occurs in Task.SetFieldValue() 
  method while initialization the control (TFS 56291).

==================================================================
C1GanttView 2/4.0.20141.173                 Build Date: 03/05/2014
==================================================================

- Fix an issue: [Enhancement]Request to provide 'is within' and 
  'is not within' TestOperators in C1GanttView (TFS 54580).

- Fix an issue: [Regression]Previously applied filter is re-affec-
  ted even though the filter is removed in gouped tasks (TFS 55901).

- Add partial Korean, Chinese, Japanese localization for Filter
  (TFS 55600).

- Fix an issue: Tasks with duplicated TaskName are sorted as reve-
  rted order in 'Task: Dropdown' of  BarStyles Dialog (TFS 56033).

- Fix an issue: BeforeFilter and AfterFilter events fired twice 
  while loading of .xml which contained <filterDefinition> tag
  (TFS 56030).

- Fix an issue: Check mark does not show on currently select Grou-
  p Type in GroupBy Menu Dropdown (TFS 55676).

==================================================================
C1GanttView 2/4.0.20141.172                 Build Date: 03/03/2014
==================================================================

- Fix an issue: ConnectorLine between Milestone and Tasks are cut 
  off when applying 'Late Tasks' filter (TFS 52529).

- Fix an issue: [Enhancement]Request to provide ResourceIndex pas-
  sing to UsingResourceFilter constructor instead of ResourceID
  (TFS 54554).

- Fix an issue: [Regression]CustomFiedd is not listed in GroupType 
  Dropdown of Group Dialog (TFS 55576).

==================================================================
C1GanttView 2/4.0.20141.171                 Build Date: 02/28/2014
==================================================================

- Add Filter Sample.

- Fix an issue: BeforeFilter and AfterFilter event fired on some 
  user interactions of C1GanttView (TFS 54417).

- Fix an issue: [Regression]System.NullReferenceException is thro-
  wn while setting of new Group to Tasks (TFS 55571).

- Fix an issue: [Regression]Clicking anywhare of Group Dialog, 1st 
  index of GroupType dropdown item is lost (TFS 55598).

==================================================================
C1GanttView 2/4.0.20141.170                 Build Date: 02/26/2014
==================================================================

- Add filter support for SoftwareDevelopmentPlan sample.

- Add filter support for Notes, OutlineLevel properties.

- Fix an issue: [Localization] Tooltip, Description and menu relat-
  ed to new feature "Group" and "Project Summary" are not localiz-
  ed into Korea, Chinese and Japanese (TFS 48515).

- Fix an issue: [Regression]ChartView is totally blank when loadi-
  ng of .xml which contain MaintainHierarchy (TFS 52748).

==================================================================
C1GanttView 2/4.0.20141.169                 Build Date: 02/24/2014
==================================================================

- Add Group/Summary localization strings for Chinese and Korean
  (TFS 47248).

- Add BeforeFilter and AfterFilter event (TFS 51721).

==================================================================
C1GanttView 2/4.0.20141.168                 Build Date: 02/19/2014
==================================================================

- Fix an issue: [Localization] Tooltip, Description and menu relat-
  ed to new feature "Group" and "Project Summary" are not localiz-
  ed into Korea, Chinese and Japanese (TFS 48515).

- Fix an issue: 'PreviewKeyDown' event is not fired in C1GanttView
  (TFS 51756).

- Update latest changes for theming.

==================================================================
C1GanttView 2/4.0.20141.167                 Build Date: 02/18/2014
==================================================================

- Fix an issue: Unlike TestOperator Dropdown,  Value(s) Dropdown 
  elects 1st index of dropdown items automatically on Tab Action
  (TFS 51599).

- Fix an issue: [Regression]Unlike previous build, NullReference 
  Exception is thrown when applying of BarStyle to Tasks without 
  'TaskName' (TFS 51635).

- Fix an issue: [Regression]System.StackOverflowException was un-
  handled when creating tasks dynamically (TFS 51672).

- Update selected task after filtering.

==================================================================
C1GanttView 2/4.0.20141.166                 Build Date: 02/17/2014
==================================================================

- Fix an issue: <unnamed> tasks are shown in GridView when applyi-
  ng the filters to C1GanttView (TFS 51527).

- Fix an issue: [Regression]Unlike previous build, Loading of .xml 
  to C1GanttView shows TaskMode/DurationUnits values for all <unn-
  amed> tasks (TFS 51555).

- Fix an issue:[C1GanttView] Unlike previous build, hierarchy str-
  ucture doesn't display (TFS 51622).

- Fix an issue: ArgumentOutOfRange Exception is thworn while swit-
  ching of Sorting by using IComparer (TFS 51628).

==================================================================
C1GanttView 2/4.0.20141.165                 Build Date: 02/14/2014
==================================================================

- Fix an issue: If Task ID is set '0' and export to .xml then the 
  TaskID is not saved in .xml (TFS 50557).

- Fix an issue: Duration Only Tasks are sorted first when sorting 
  of C1GanttView with 'Start' and 'Finish' properties (TFS 50564).

- Fix an issue: 'Tasks.Start' becomes null when the respective 
  'Resources' of a Task are modified (TFS 50663).

- Fix an issue: Unlike previous build, Start Date for Calendar 
  Exception is not retained when saving as xml  and  loading it 
  again (TFS 51209).

- Fix an issue: Sub Task disappear and “ArgumentOutOfRangeException” 
  is observe after sorting the summary task in certain scenarios
  (TFS 51211).

- Fix an issue: NullReference Exception is thrown, when clicking 'OK' 
  button without adding any value in 'Using Resource' Dialog
  (TFS 51461).

- Fix an issue: NullReference Exception is thrown, when Combinatio-
  nOperator is set without any value in AdvanceFilter (TFS 51462).

- Fix an issue: Sub Task disappear and “ArgumentOutOfRangeException” 
  is observe after sorting the summary task in certain scenarios
  (TFS 51470).

- Fix an issue: Predefined LateTasksFilter is not working in C1Ga-
  nttVew (TFS 51524).

- Remove IConditionTaskFilter interface. Set internal modifier for 
  some Filter related classes/methods/properties.

==================================================================
C1GanttView 2/4.0.20141.164                 Build Date: 02/12/2014
==================================================================

- Add Filter support.

- Update theme backgrounds.

==================================================================
C1GanttView 2/4.0.20133.163                 Build Date: 01/22/2014
==================================================================

- Fix an issue: Warning Message for FinishDate input shows wrong 
  parameter name (TFS 49697).

- Fix an issue: If incorrect property value is sorted by using 
  c1GanttView.SortTasks(), NullReferenceException is thrown in 
  C1.Win.C1GanttView dll (TFS 49781).

- Fix an issue: If BarText is set large font size, row height of 
  C1GanttView are not uniformed (TFS 49803).

- Fix an issue: C1GanttView does not render correct duration when 
  "Print specific dates" opition is used (TFS 49819).

- Fix an issue: In PrintPreview, ChartView rendered 3 days consta-
  ntly whatever the Duration is 1/2/3 or 4 days while "Print spec-
  ific dates" opition is used (TFS 49832).

- Fix an issue: If TaskProperty.None is passed to sort C1GanttView 
  Task, Null Reference exception is thrown in C1.Win.C1GanttView 
  dll (TFS 49841).

- Fix an issue: Not all enums of TaskProperty can be used to sort 
  C1GanttView (TFS 49846).

- Fix an issue: C1GanttView shows incorrect sorting with ListSortD-
  irection when 'Mode' is used to sort (TFS 49848).

==================================================================
C1GanttView 2/4.0.20133.162                 Build Date: 01/16/2014
==================================================================

- Correct XML comments.

- Add sorting supports:
	C1GanttView.SortTasks(PropertyDescriptor prop, ListSortDirec-
	tion direction)
	C1GanttView.SortTasks(IComparer<Task> comparer)
	C1GanttView.RemoveSort()

==================================================================
C1GanttView 2/4.0.20133.161                 Build Date: 01/14/2014
==================================================================

- Fix an issue: Chart View is not rendered  when print preview the 
  C1GanttView with "Print specific dates" option and  'Start:' and 
  'End:' is given the same Date (TFS 49042).

- Fix an issue: NonworkingTimeColor is overlapped the Bar Text st-
  arting from font size 26 (TFS 49051).

- Fix an issue: Unhandled exception occurs when deleting default 
  StartDate value of C1GanttView in property grid (TFS 49058).

- Fix an issue: External Exception is thrown in System.Drawing, 
  when large ZoomFactor value is set at DesignTime and print prev-
  iew at RunTime (TFS 49110).

- Fix an issue: Loading grouped Tasks by CustomFieldColumn from 
  XML file, does not retain grouping and CustomField Column Values 
  when rebuilding the project (TFS 49138).

- Fix an issue: [Regression]Previewing of C1GanttView with 'Print 
  specific dates' by setting 1 year grater dates to  'Start:' and 
  'End:' throws ExternalException (TFS 49276).

- Fix an issue: [Regression]If Zoom Factor '0' is set to C1Gantt-
  View and print previewed at run time, extra gray area is rende-
  red in ChartView (TFS 49283).

==================================================================
C1GanttView 2/4.0.20133.160                 Build Date: 01/09/2014
==================================================================

- Fix an issue: Chart View is not rendered  when print preview the 
  C1GanttView with "Print specific dates" option and  'Start:' and 
  'End:' is given the same Date (TFS 49042).

- Fix an issue: If Task Bar with small zoom factor is print previ-
  ewed, right side of Task Bars are cut off (TFS 49107).

- Fix an issue: NullReferenceException is thrown in C1.Win.C1Gant-
  tView dll when grouping according to the Customfield column wit-
  hout any data values (TFS 49123).

==================================================================
C1GanttView 2/4.0.20133.159                 Build Date: 01/08/2014
==================================================================

- Fix an issue: Correct xml comments.

- Fix an issue: Unlike MS Project, ‘Alert Indicator’ is not display 
  although ‘Auto’ task is over the deadline when this task become 
  summary task (TFS 48609).

- Fix an issue: Bar text from right most area is cut off in print 
  preview when ZoomFactor change from small value to 'Zoom Entire 
  project' (TFS 48722).

- Fix an issue: [Regression]Summary Task is disappered when adding 
  new Task at design time through C1GanttView.Task Collection Edi-
  tor (TFS 49087).

==================================================================
C1GanttView 2/4.0.20133.158                 Build Date: 01/07/2014
==================================================================

- Fix an issue: Unlike MS Project, child task is able to link its 
  parent summary task as predecessor in C1GanttView (TFS 48580).
  
- Fix an issue: Difference behavior is observed between C1GanttVi-
  ew and MS Project when clicking on ‘Indent’ toolbar button or 
  Outdent’ toolbar button (TFS 48583).

- Fix an issue: Unlike MS Project,  Deadline for parent summary 
  task is movable in chart view of C1GanttView control (TFS 48584).

- Fix an issue: ‘Scroll To Task’ vertically is not working correc-
  tly when tasks are in grouped by  mode (TFS 48610).

- Fix an issue: If "23" is set to EndShape property of the Task, 
  the EndShape of this task is not rendered in print preview
  (TFS 48856).

- Fix an issue: Dropdown list area of the "Order" dropdown is exc-
  eeding the boundry of the Group Dialog (TFS 48859).

- Fix an issue: LeftText are cut off and RightText are not rendered 
  in print preview while BarType = "Progress" (TFS 48890).

- Fix an issue: The task is unable to link to ‘Summary’ task as its 
  predecessor in chart view although this task is not its child 
  task (TFS 48927).

- Fix an issue: Unlike MS Project, the second summary task become 
  the child of first summary task although its child task is not 
  related to first summary task after  adding second summary task 
  (TFS 48932).

- Fix an issue: When Summary Task is deleting through C1GanttView.-
  Task Collection Editor, Object reference exception is thrown
  (TFS 49017).

- Fix an issue: If tasks are grouped without 'Maintain Hierarchy' 
  option, Notes of these tasks are not displayed in Grid View alt-
  hough Notes are existing in Task Information Dialog (TFS 49021).

==================================================================
C1GanttView 2/4.0.20133.157                 Build Date: 01/03/2014
==================================================================

- Fix an issue: Request to hide "Error" and "OutlineLevel" proper-
  ties from C1GanttView's Properties Grid (TFS 48523).

- Fix an issue: Some bar styles are not listed in Legend and Grou-
  pBy header text are cutoff in Print Preivew (TFS 48539).

- Fix an issue: Unlike MS Project, ‘Indent’ is not working when t-
  here is blank row exist between the task row and ‘summary’ task
  header row (TFS 48579).

- Fix an issue: Unlike MS Project, child task is able to link its 
  parent summary task as predecessor in C1GanttView (TFS 48580).

- Fix an issue: Unlike MS Project,  the predecessor links is also 
  display for sub task group header when another task is link to 
  its child task (TFD 48581).

- Fix an issue: Difference behavior is observe between task bar 
  style ‘Bar Style’ collection editor  and ‘Project Summary coll-
  ection editor when clicking on ‘Cancel’ button (TFS 48582).

==================================================================
C1GanttView 2/4.0.20133.156                 Build Date: 12/27/2013
==================================================================

- Fix an issue: Unlike MS Project, ‘PercentComplete’ is not retain 
  and updated on the task if it is added in ‘Summary Tasks’
  (TFS 47688).

- Fix an issue: ‘Maintain Hierarchy’ option  with sub task header 
  is not retain when it is loaded as xml file from design time
  (TFS 48050).

==================================================================
C1GanttView 2/4.0.20133.155                 Build Date: 12/26/2013
==================================================================

- Fix an issue: The sub task header is deleted instead of the 
  specific tasks  after deleting the specific task in grouped modes 
  with ‘Maintain Hierarchy’ option set to true (TFS 48046).

- Fix an issue: ‘ArgumentException’ is observed after clicking on 
  ‘collapse/expand’ button when task view are loaded from xml file 
  for second time (TFS 48047).

- Fix an issue: Unlike MS Project , Milestone which has no 
  ‘StartDate’ and ‘EndDate’ is not calculated as ‘Milestone:Yes’ 
  when the tasks are grouped by ‘Milestone’ (TFS 48048).

- Fix an issue: Unlike MS Project , deadline is also display in sub 
  task header when tasks are grouped with ‘Maintain Hierarchy’ 
  option on (TFS 48049).

- Fix an issue: Unlike MS Project, duration column is still able to 
  edit in Grouped header when all its child tasks are deleted
  (TFS 48051).

==================================================================
C1GanttView 2/4.0.20133.154                 Build Date: 12/24/2013
==================================================================

- Fix an issue: [WinForms][C1GanttView] The representation of 
  legend at the time of print is not in Japanese language 
  (TFS 48054).

- Fix an issue: Unlike previous build , alert indicator is not 
  printed in print preview  or in printer if the task bar has 
  passed the deadline (TFS 48100).

==================================================================
C1GanttView 2/4.0.20133.153                 Build Date: 12/18/2013
==================================================================

- Fix an issue: Unlike MS Project, the grouped header is not move 
  at run time according to its child tasks although these child 
  tasks are moved (TFS 47679).

- Fix an issue: “NullReferenceException” is observed after linking 
  a new task with task grouped header and clicking on collapse/
  expand button (TFS 47685).

- Fix an issue: Unlike MS Project, the grouped header task name is 
  also deleted when deleting the last child task in C1GanttView
  (TFS 47689).

- Fix an issue: Unlike MS Project, Grouped Task bar header is not 
  shown for ‘Duration Only’ task when it is grouped by ‘Task Mode’
  (TFS 47690).

- Fix an issue: Incorrect description is mention in code view of 
  ‘OutlineLevel’ property of ProjectSummary in C1GanttView
  (TFS 47692).

- Fix an issue: Unlike MS Project, ‘Scroll To Task’ is not working 
  when the tasks are grouped (TFS 47693).

- Fix an issue: Unlike MS Project, ‘Maintain Hierarchy’ option is 
  not working properly in C1GanttView when it is grouped 
  (TFS 47773).

- Add more Command Buttons.

==================================================================
C1GanttView 2/4.0.20133.152                 Build Date: 12/12/2013
==================================================================

- Fix issue: The sort order when apply single group model from
  group menu is descending.

- ‘ArgumentOutOfRangeException’ is observed after collapsing the 
  group when all three tires in the timescales are invisible
  (TFS 47567).

- ‘NullReferenceException’ is observed after deleting the last 
  manual task which is  Grouped (TFS 47568).

- ‘ArgumentOutOfRangeException’ is observed after  clicking on 
  ‘Add Task’ menu in the context menu of collapsed group header
  (TFS 47578).

==================================================================
C1GanttView 2/4.0.20133.151                 Build Date: 12/10/2013
==================================================================

- Add Summary/Group task feature.

==================================================================
C1GanttView 2/4.0.20133.150                 Build Date: 11/28/2013
==================================================================

- Add Japanese localization strings for Printing (TFS 44136).

==================================================================
C1GanttView 2/4.0.20133.149                 Build Date: 11/28/2013
==================================================================

- Add Japanese localization strings for Printing (TFS 44136).

- Fixed an issue: Unlike C1Schedule and C1TrueDBGrid, "System.Dll-
  NotFoundException" occured if C1Report dll is not added in 
  Reference (TFS 46540).

- Fixed an issue: If predecessor task is below successor task then 
  the relation line is distorted in Preview (TFS 46546).

- Fixed an issue: "Zoom Selected Task" button is not disabled as 
  soon as last task is deleted (TFS 46550).

- Fixed an issue: Japanese text for 'Settings...' button is clipped 
  in localized version 'Print' dialog (TFS 46768).

==================================================================
C1GanttView 2/4.0.20133.148                 Build Date: 11/13/2013
==================================================================

- Fixed an issue with reading Fonts from a theme (TFS 44478).

==================================================================
C1GanttView 2/4.0.20133.146                 Build Date: 11/05/2013
==================================================================

- Fix an issue: Printing feature is disabled when no printers are
  installed.

==================================================================
C1GanttView 2/4.0.20133.145                 Build Date: 11/04/2013
==================================================================

- Fix an issue: Exception raises when no printers are installed.

- Fix an issue: Row height of column header  get larger in print 
  preview when all tiers are invisible (TFS 43964).

- Fix an issue: Extra slash '/' is contained in descirption of 
  'FixedFont' property (TFS 43965)

==================================================================
C1GanttView 2/4.0.20133.144                 Build Date: 10/31/2013
==================================================================

- Updated theme support (added the VisualStyle property).

==================================================================
C1GanttView 2/4.0.20133.142                 Build Date: 10/18/2013
==================================================================

- Re-fix an issue: Bar text and chart view is clipped in print 
  preview if bar text is long (TFS 43578).

- Fix an issue: Start and End shape of task bar are not shown in 
  print preview when zoom factor is set to small value (TFS 43851).

==================================================================
C1GanttView 2/4.0.20133.141                 Build Date: 10/15/2013
==================================================================

- Fix an issue: Tooltips is not shown for some text of  
  'GridColumn' to display full text (TFS 42825).

- Fix an issue: Bar text and chart view is clipped in print 
  preview if bar text is long (TFS 43578).

==================================================================
C1GanttView 2/4.0.20133.140                 Build Date: 10/14/2013
==================================================================

- Fix a re-open issue: Members are created with duplicate name 
  when add new member after deleting members in Calendar or 
  Resources Collection Editor (TFS 42877).

- Fix a re-open issue: Bar text  selected from right side drop 
  down is not displayed if text selected from left side drop down 
  is not defined (TFS 42939).

- Fix an issue: Bar text is not fixed with row height and 
  overlapped with text of other Task bar (TFS 43285).

- Fix an issue: Bottom text of Task bar  is distorted if text is 
  overlapped with 'NonworkingTime' position (TFS 43288).

- Fix an issue: FixedFont is not effect to chart view for larger 
  unit from ThirdsOfMonths (TFS 43297).

- Fix an issue: Bar Text selected by using arrow key or pressing 
  beginning word  is not effected in chart view (TFS 43508).

==================================================================
C1GanttView 2/4.0.20133.139                 Build Date: 10/10/2013
==================================================================

- Fix an issue: Members are created with duplicate name when add 
  new member after deleting members in Calendar or Resources  
  Collection Editor (TFS 42877).

- Fix an issue: Bar text  selected from right side drop down is 
  not displayed if text selected from left side drop down is not 
  defined (TFS 42939).

- Fix an issue: Text of 'Middle Tier' is distorted in printed 
  output when 'Min Width' property of bottom tier is set to 5
  (TFS 42952).

==================================================================
C1GanttView 2/4.0.20133.138                 Build Date: 10/10/2013
==================================================================

- Updated theme support.

- Added new theming properties to C1GanttView control:

  public Color GridForeColor { get; set; }
  Specifies the foreground color of the grid view.

  public Color BarTextForeColor { get; set; }
  Specifies the foreground color of bar text on the chart view.

  public Font FixedFont { get; set; }
  Specifies the font used in row/column headers.

  public Font BarTextFont { get; set; }
  Specifies the font used for bar text on the chart view.

==================================================================
C1GanttView 2/4.0.20132.137                 Build Date: 10/09/2013
==================================================================

- Add theme support.

- Fix an issue: Different behavior is found for "%Complete" value 
  of progress bar when change the duration of task (TFS 42482).

- Fix an issue: Some column is not printed if Task bar is not 
  drawn in chart view (TFS 42869).

==================================================================
C1GanttView 2/4.0.20132.136                 Build Date: 09/30/2013
==================================================================

- Fix a re-open issue: In Fresh Enviornment, ArgumentOutOfRange 
  Exception occurred at runtime due to 'ZoomFactor' default value  
  '-1'; also not able to change that value in property grid 
  (TFS 42047).

==================================================================
C1GanttView 2/4.0.20132.135                 Build Date: 09/24/2013
==================================================================

- Fix a re-open issue: In Fresh Enviornment, ArgumentOutOfRange 
  Exception occurred at runtime due to 'ZoomFactor' default value  
  '-1'; also not able to change that value in property grid 
  (TFS 42047).

==================================================================
C1GanttView 2/4.0.20132.134                 Build Date: 09/23/2013
==================================================================

- Fix an issue: In Fresh Enviornment, ArgumentOutOfRange Exception 
  occurred at runtime due to 'ZoomFactor' default value  '-1'; 
  also not able to change that value in property grid (TFS 42047).

- Fix an issue: “Alert” indicator is not printed in print preview 
  if the task bar has passed the deadline (TFS 42065).

- Fix an issue: ChartView display in print preview are clipped 
  and does not show properly when there are several columns in the 
  gridview (TFS 42120).

- Fix an issue: “TargetInvocationException” is observe when loading 
  some ‘.c1dx’ file or ‘.c1d’ file is loaded for custom styles in 
  ‘Print’ dialog (TFS 42123).

- Fix an issue: The ‘Print first’ checkbox is unable to uncheck 
  once it is checked at run time in ‘View’ tab of ‘Style Setting’ 
  dialog (TFS 42306).

- Fix an issue: ‘Chart View’ is not display in ‘Print Preview’ 
  dialog or  when printed after unselecting ‘Print all columns’ 
  option (TFS 42308).

==================================================================
C1GanttView 2/4.0.20132.133                 Build Date: 09/19/2013
==================================================================

- Fix an issue: “Runtime.InteropServices.ExternalException” is 
  observed when there no bar display for chart view or setting 
  visible property of three tiers to false (TFS 42061).

- Fix an issue: “TargetInvocationException” is observed after 
  setting a value in ‘NumberOfRepeatColumns’ property which is 
  greater than value in ‘NumberOfFirstColumns’ property (TFS 42062).

- Fix an issue: Text area of Legend or ‘Header/Footer’ style is 
  not affected in the printing preview if ‘Style’ is edited for 
  second time in ‘Style Setting’ dialog at run time (TFS 42063).

- Fix an issue: “ArgumentOutOfRangeException” is observed after 
  click on ‘Print’ toolbar button if  ‘PrintEntireProject’ \
  property is set to false and there is no ‘StartDate’ and 
  ‘EndDate’ added (TFS 42066).

- Fix an issue: “Runtime.InteropServices” exception is observed 
  after clicking on ‘Preview’ button if setting ‘EndDate’ which 
  is less than ‘StartDate’ in Print range (TFS 42067).

==================================================================
C1GanttView 2/4.0.20132.132                 Build Date: 09/17/2013
==================================================================

- Add printing feature.

==================================================================
C1GanttView 2/4.0.20132.131                 Build Date: 08/27/2013
==================================================================

- Added the ability to localize all text strings on C1GanttView
  and its dialogs (added the 'Localize...' smart tag).

- Synchronized changes with C1FlexGrid 2/4.6.20132.783.

==================================================================
C1GanttView 2/4.0.20132.130                 Build Date: 08/20/2013
==================================================================

- Fixed an issue: ‘NullReferenceException’ is observed after 
  clicking on ‘Zoom…’ toolbar button when three tiers are 
  invisible (TFS 41051).

==================================================================
C1GanttView 2/4.0.20132.129                 Build Date: 08/20/2013
==================================================================

- Fixed an issue: In Zoom Form, Korean text for "Custom" is cutoff
  (TFS 39768).

==================================================================
C1GanttView 2/4.0.20132.128                 Build Date: 08/19/2013
==================================================================

- Fixed an issue: Localize string for Zoom feature in Korea, 
  Chinese and Japanese (TFS 39768).

==================================================================
C1GanttView 2/4.0.20132.127                 Build Date: 08/15/2013
==================================================================

- Fixed an issue: Japanese string for "Quarter" is incorrect in 
  "Zoom" dialog (TFS 40951).

- Fixed an issue: Decimal value set to ZoomFactor at Design Time
  slightly change at Run Time and value of ZoomFactor is "-1" when
  new C1GanttView add to a form (TFS 40811).

==================================================================
C1GanttView 2/4.0.20132.126                 Build Date: 08/12/2013
==================================================================

- Fixed an issue: localize string for Zoom feature in Japanese
  (TFS 39768).

==================================================================
C1GanttView 2/4.0.20132.125                 Build Date: 08/12/2013
==================================================================

- Fixed an issue: Saved values of CusttomFieldColumns are not
  loaded to C1GranttView when saved .xml is loaded (TFS 40670).

==================================================================
C1GanttView 2/4.0.20132.124                 Build Date: 08/09/2013
==================================================================

- Fixed an issue: If many task contained C1GanttView and clicking 
  of  'ZoomEntireProject'/'ZoomSelectedTask' menu item 2nd 
  and more, Horizontal and Vertical ScrollThumbs of Chart View 
  are moving (TFS 40405).

- Fixed an issue: Deleting of last row in C1GanttView,
  SelectedIndexChanged event fired 3 times for the same value -1
  (TFS 40643).

- Fixed an issue: Japanese string for "Cancel" button is incorrect
 in "Zoom" dialog (TFS 40724).

==================================================================
C1GanttView 2/4.0.20132.123                 Build Date: 08/05/2013
==================================================================

- Fixed an issue: Adding of blank rows in GridVeiw fired
  SelectedIndexChanged event for the same selected index value
  (TFS 40428).

==================================================================
C1GanttView 2/4.0.20132.122                 Build Date: 07/29/2013
==================================================================

- Fixed an issue: SelectedIndexChange Event fired on setting
  'Visible' to Tiers at run time (TFS 40223).

==================================================================
C1GanttView 2/4.0.20132.121                 Build Date: 07/24/2013
==================================================================

- Fixed an issue: ChartView is flicking while clicking 2nd and
  onward times of 'ZoomEntireProject' menu item (TFS 40169).

- Fixed an issue: If all three Tiers are set 'Invisible' at 
  DesignTime then C1GanttView throws Argument Exception at run 
  time (TFS 40150).

==================================================================
C1GanttView 2/4.0.20132.120                 Build Date: 07/24/2013
==================================================================

- Fixed an issue: 'System.StackOverflowException' is occurred
  while ZoomFactor value of C1GanttView is output in
  BeforeZoomFactorChange event (TFS 40112).

- Fixed an issue: BeforeZoomFactorChange event fired for first
  time of calling get{} method for ZoomFactor at run time
  (TFS 40117).

==================================================================
C1GanttView 2/4.0.20132.119                 Build Date: 07/19/2013
==================================================================

- Change valid range of ZoomFactor to from 0 to 11 and ZoomIn(),
  ZoomOut() only work in the range from 1 to 10 (like MSProject).

- Add event BeforeZoomFactorChange to C1GanttView (TFS 39978).

- Expose ZoomFactor in property grid of C1GranttView (TFS 39959).

- Fixed an issue: If Top Tier is set visible with the suitable
  unit ( >the unit of Middle Tier) at run time, ZoomFactorChanged
  event is fired even though the ZoomFactor value is the same for
   before and after making Top Tier visible (TFS 39967).

- Fixed an issue: ZoomFactorChanged event fired on resetting of
  Zoom before any changes applied to Zoom Value (TFS 39976).

==================================================================
C1GanttView 2/4.0.20132.118                 Build Date: 07/17/2013
==================================================================

- Fixed a regression bug: After cancelling any child collection
  editor of the "Tasks Collection Editor" and moving to another
  task, property grid of all tasks becomes blank (TFS 39900).

==================================================================
C1GanttView 2/4.0.20132.117                 Build Date: 07/16/2013
==================================================================

- Fixed an issue: ZoomFactorChanged event fired twice for 
  'ZoomIn'/'ZoomOut' actions clicking via on 'ZoomIn'/'ZoomOut'
  menu items (TFS 39875).

==================================================================
C1GanttView 2/4.0.20132.116                 Build Date: 07/16/2013
==================================================================

- Fixed an issue: When a task and a deadline is created in 
  C1GanttView, and this deadline exist after the task bar , after 
  clicking on the ‘Zoom In’  toolbar button and dragging the 
  existing deadline and drop it before the start of task bar, 
  “System.NullReferenceException” is observe (TFS 39839).

==================================================================
C1GanttView 2/4.0.20132.115                 Build Date: 07/15/2013
==================================================================

- Fixed an issue: grid and chart view areas become blank when
  a user opens the Tasks Collection Editor, then opens BarStyles
  Collection Editor, and clicks the drop-down button for the
  BarColor property (TFS 39845).

==================================================================
C1GanttView 2/4.0.20132.114                 Build Date: 07/15/2013
==================================================================
- Fixed an issue: Zoom "1 month" has some issues.Let say today is 
  "July 11" which will be project start date and if user zooms 
  "1 month" then the start date is "June 16" and end date is 
  "Aug 4" which is 7 weeks(49 days). When user has choose 
  "Custom:" option  and enter "1" and "Month(s)" values in textbox
  and dropdown. Zoom dialog is closed by clicking "OK" button to
  apply the changes. When user reopen the Zoom dialog, it is 
  observed that "3" and "Thirds of Month(s)" is selected for 
  "Custom:" options instead of selecting "1 month" in Zoom dialog
  (TFS 39744).

- Fixed an issue: All the tasks are not shown in one view if 
  "Zoom Entire Project" after "Zoom Selected Task" or Zoom In/Out 
  or reset value in custom text box to initial value (TFS 39764).

- Fixed an issue: If user set "1 Half Year(s)" for "Custom:"
  option then it is shown as "2 Quarter(s)" when Zoom dialog is
  reopened (TFS 39765).

- Fixed an issue: When a task with ‘Task Mode’ and ‘Task Name’ is
  created, but without adding duration or start date and end date
  (i.e without creating task bar in chart view), after clicking on
  ‘Zoom Selected Task’ toolbar button on this task, the ‘Unit’ for
  middle tier should selected as ‘Hours’ and the ‘Zoom Out’ button
  in “Zoom” drop down should zoom more in C1GanttView (TFS 39821).

- Fixed an issue: When user have set ‘Zoom Entire Project’ 
  (Since in Zoom Entire Project : Middle Tier = Days, Bottom 
  Tier = Hours )for C1GanttView.Clicking  “Zoom In” toolbar button,
  it didn’t zoom in (because Middle Tier become ‘Week’ unit and 
  Bottom Tier become ‘Day’ and it rather works like zoom out .
  Clicking “Zoom Out” toolbar button, it did zoom out but display
  as incorrect timescale. The timescale should be 
  (Middle Tier = Weeks,Bottom = Days) but actual result which
  C1GanttView display was (Middle Tier = Month, Bottom Tier = Days)
  (TFS 39834).

- Fixed an issue: When ‘Middle Tier’ is set to ‘Months’, 
 ‘Bottom Tier’ is set to ‘Weeks’ and changing ‘Minimal Cell Width’
  to 50, after clicking on “Zoom In” or “Zoom Out”,
  “System.ArgumentOutOfRangeException” is observed (TFS 39838).

- Fixed an issue: Cannot zoom to specific time range with 
  ZoomToRange() if zoom to range out of project's time (TFS 39763).

==================================================================
C1GanttView 2/4.0.20132.113                 Build Date: 07/13/2013
==================================================================

- Fixed an issue: After opening "C1GanttView.BarStyles Collection
  Editor" and adding a new bar style, any changes to bar colors
  in the collection editor are immediately shown in the designer
  view. Then, after closing this collection editor and opening it
  once again, changes to bar colors don't affect the designer
  view (TFS 38516).

==================================================================
C1GanttView 2/4.0.20132.112                 Build Date: 07/12/2013
==================================================================

- Fixed an issue: When selecting ‘Zoom Out’ and then selecting
  ‘Zoom In’ option in ‘Zoom’ drop down and then, changing the 
  displayed ‘Timescale’ of  C1GanttView (eg . Selecting ‘Month’ in
  ‘Units’ drop down in ‘Middle Tire’ and selecting ‘Weeks’ in 
  ‘Units’ drop down of ‘Bottom Tier’) , and then selecting 
  ‘ZoomOut’ option again in ‘Zoom’ drop down.
  "ArgumentOutOfRangeException ” is observed(TFS 39733).

- Fixed an issue:DropDown from Zoom dialog should not be editable
  (TFS 39766).

- Fixed an issue:While all visible property of all tiers are set to
  false , after setting ‘Zoom Entire Project’ and setting to true 
  again for all the visible property of two tiers (i.e Middle and
  Bottom tiers), ‘GridView’ and ‘ChartView’ are not display
  anymore and shown as white blank in its area (TFS 39772).

- Fixed an issue:‘ZoomSelectedTask’ toolbar is still disable when
  new task is created and selected(TFS 39773).

- Fixed an issue: When ‘Duration Only’ manual task or  ‘0’
  duration manual task is created, after selecting any of this
  task and click ‘ZoomSelectedTask’ toolbar button, 
  “System.InvalidOperationException”  is observed (TFS 39774).

==================================================================
C1GanttView 2/4.0.20132.111                 Build Date: 07/11/2013
==================================================================

- Add Zoom In - Zoom Out feature.

==================================================================
C1GanttView 2/4.0.20132.110                 Build Date: 06/20/2013
==================================================================

- Fixed an issue: Description is not localized for new event 
  "SelectedIndexChanged" (TFS 37904)

==================================================================
C1GanttView 2/4.0.20132.109                 Build Date: 06/20/2013
==================================================================

- Synchronized changes with C1FlexGrid 2/4.6.20132.778.

==================================================================
C1GanttView 2/4.0.20132.108                 Build Date: 06/20/2013
==================================================================

- Fixed an issue: NullReferenceException is observed in
  C1GanttView when using MEF in the application (TFS 37999).

==================================================================
C1GanttView 2/4.0.20132.107                 Build Date: 06/17/2013
==================================================================

- Add event SelectedIndexChanged in C1GanttView.

==================================================================
C1GanttView 2/4.0.20132.106                 Build Date: 06/04/2013
==================================================================

- URL changes for GrapeCity JPN AboutBox.

==================================================================
C1GanttView 2/4.0.20131.104                 Build Date: 04/03/2013
==================================================================

- Moved to the subscription licensing model in Japanese build.

==================================================================
C1GanttView 2/4.0.20131.102                 Build Date: 03/04/2013
==================================================================

- Fixed a couple of localization issues (TFS 34568).

==================================================================
C1GanttView 2/4.0.20131.101                 Build Date: 03/01/2013
==================================================================

- Added a missed localization string (TFS 34502).

- Fixed an issue: When the user clicks the timescale with the
  left mouse button the chart view is scrolled to the left.

==================================================================
C1GanttView 2/4.0.20131.100                 Build Date: 02/28/2013
==================================================================

- Fixed an issue in "Task Information" dialog: the 'Predecessor
  Type' combobox is getting enabled after creating an 'Undefined
  predecessor' item for the second time (TFS 34481).

==================================================================
C1GanttView 2/4.0.20131.99                  Build Date: 02/27/2013
==================================================================

- Fixed an issue in "Change Working Time" dialog: If the user
selected a week day on the "Work Weeks" tab, such as Friday, then
switched to another tab, and then returned back to "Work Weeks",
both Sunday and Friday are selected (TFS 34422).

==================================================================
C1GanttView 2/4.0.20131.98                  Build Date: 02/26/2013
==================================================================

- Added a few Japanese, Chinese, and Korean localization strings
  (TFS 34361).

- Synchronized changes with C1FlexGrid 2/4.6.20131.762.

==================================================================
C1GanttView 2/4.0.20131.97                  Build Date: 02/19/2013
==================================================================

- Fixed an issue: The deadline is not dragged with the mouse if
  the timescale for bottom tier is set to Hours (TFS 34181).

- Fixed an issue: The default deadline shape is always used
  while dragging the deadline, although the custom shape is set
  for deadlines (TFS 34182).

- Fixed an issue: 'Deadline' bar type is not selected
  automatically in the Bar Styles dialog at run time when a user
  right clicks a deadline on the chart view and selects "Bar
  Styles" from the context menu (TFS 34185).

- Fixed an issue: Finish date of a WorkWeek or CalendarException
  can be set to a value less than the Start date in WorkWeeks
  and Exceptions Collection Editors at design time (TFS 26156).

- Fixed an issue: An attempt to assign a value to the Task.Start
  or Task.Finish property does NOT ignore for auto-scheduled
  tasks at design time in some scenarios (TFS 28415).

==================================================================
C1GanttView 2/4.0.20131.95                  Build Date: 02/18/2013
==================================================================

- It is now possible to drag and drop the task deadline in the
  chart view. Also, the deadline mark has a tooltip (TFS 27966).

- Added a few tooltips to the drop-down of the color selector.
  
- Fixed an issue: Progress line is not displayed if the status
  date is scrolled a little far from the the visible area
  (TFS 34169).

- Fixed an one-pixel inaccuracy when drawing spikes to the left
  and right on the progress line. The line was cut at the task
  cell bottom.

==================================================================
C1GanttView 2/4.0.20131.94                  Build Date: 02/15/2013
==================================================================

- Fixed an issue: Rows are not scrolled in sync in the grid and
  chart views after setting top/bottom bar text Bar styles and
  changing the Start/Finish date for the last task (TFS 34097).

- Added a new style for manual task milestones whose Duration is
  set to 0 without setting Start and Finish dates (TFS 28610).

==================================================================
C1GanttView 2/4.0.20131.93                  Build Date: 02/14/2013
==================================================================

- Fixed an issue (it was introduced in build 87): Milestone is
  not displayed after setting task Duration to 0 (TFS 34012).

- Fixed an issue: Quarters, Half-Years and Years in Units for
  timescale are not started according to Fiscal Year when "Use
  Fiscal Year" checkbox is checked in the timescale options
  (TFS 34017).

==================================================================
C1GanttView 2/4.0.20131.91                  Build Date: 02/13/2013
==================================================================

- Added the UseAntialiasing property to the ProgressLine class.
  It enables antialiasing when drawing the progress line.

==================================================================
C1GanttView 2/4.0.20131.89                  Build Date: 02/12/2013
==================================================================

- Added the ProgressLine class and a property of the same name
  to C1GanttView. Also, added the "Progress Line" dialog and the
  corresponding button on the toolbar. Progress line can be
  displayed on the timescale and used for drawing attention to
  tasks that are ahead or behind the schedule.

==================================================================
C1GanttView 2/4.0.20131.87                  Build Date: 02/11/2013
==================================================================

- Task.PercentComplete value is now visualized as the percent
  of working time, not just the whole length of the task bar.
  When a user changes task duration that affects the "% Complete"
  value so that duration of the finished work remains unchanged,
  if possible.

==================================================================
C1GanttView 2/4.0.20131.86                  Build Date: 02/03/2013
==================================================================

- Added the UseFiscalYear boolean property to ScaleTier. It
  indicates whether the fiscal year should be used instead of
  the calendar year for a level of timescale.

- Added the FirstMonthOfFY and UseStartingYearForFY properties
  to C1GanttView and the Schedule objects. They specify the
  the first month of the fiscal year and indicate if the fiscal
  year should start in the same calendar year.

- Added the 'Calendar Options' tab to the Project Information
  dialog with a few elements for editing the fiscal year start
  month, the date formats, the first day of the week and so on.

==================================================================
C1GanttView 2/4.0.20131.85                  Build Date: 01/29/2013
==================================================================

- Fixed an issue: Setting a value to the GridDateFormat property
  of a C1GanttView may cause an exception at runtime.

==================================================================
C1GanttView 2/4.0.20131.84                  Build Date: 01/23/2013
==================================================================

- Fixed a few localization issues: 33393, 33401, 33403, 33405.

==================================================================
C1GanttView 2/4.0.20123.83                  Build Date: 12/27/2012
==================================================================

- Fixed an issue: Changing Duration Units for a Manual Task at
  run time and opening the Task Information dialog causes an
  ArgumentOutOfRange exception sometimes (TFS 32295).

- Fixed an issue: the Notes field in the Task Information dialog
  and in the Project Resources dialog doesn't select all the text
  when the user presses Ctrl+A (TFS 32290).

==================================================================
C1GanttView 2/4.0.20123.82                  Build Date: 12/26/2012
==================================================================

- Fixed an issue: Pressing Ctrl+Z (Undo) after deleting a
  C1GanttView control throws an ArgumentOutOfRange exception
  in the designer (TFS 32273).

- Fixed an issue: While task duration is more than 1300 days,
  clicking its task bar shows a marquee which length exceeds
  the task bar area (TFS 32271).

- Synchronized changes with C1FlexGrid 2/4.6.20123.741.

==================================================================
C1GanttView 2/4.0.20123.81                  Build Date: 11/09/2012
==================================================================

- Fixed a regression issue: If user sets Duration, then sets the
  Finish date, then sets the Start date the task Duration is not
  updated and the Finish date is moved (TFS 28293).

==================================================================
C1GanttView 2/4.0.20123.80                  Build Date: 11/08/2012
==================================================================

- Fixed an issue: AutoTask is changed to milestone after dragging
  the task bar to the date which exceeds the ConstraintDate when
  ConstraintType is set to 'FinishNoEarlierThan' (TFS 29841).

- Fixed an issue: AutoTask doesn't to move on chart view although
  the ConstraintDate is changed after dragging the AutoTask which
  has the ConstraintType set to 'StartNoLaterThan' (TFS 29844).

- Fixed a small localization issue.

==================================================================
C1GanttView 2/4.0.20123.78                  Build Date: 11/07/2012
==================================================================

- Fixed an issue: an ArgumentOutOfRange exception is throw after
  setting Task.Mode to 'Automatic' for existing GanttView in code
  behind before the control becomes visible (TFS 29776).

==================================================================
C1GanttView 2/4.0.20123.77                  Build Date: 11/05/2012
==================================================================

- Fixed an issue: Bar Text still appears for the progress bar's
  bar style although there is no progress bar (0%) in the task
  bar (TFS 29689).

==================================================================
C1GanttView 2/4.0.20123.76                  Build Date: 11/02/2012
==================================================================

- Fixed an issue: Text doesn't appear for the Bar Style when the
  BarType property is set to 'Progress Bar' (TFS 29652).

==================================================================
C1GanttView 2/4.0.20123.75                  Build Date: 11/01/2012
==================================================================

- Fixed an issue: When ConstraintType property of an AutoTask is
  set to 'MustFinishOn', dragging the task bar on the chart view
  doesn't work as expected (TFS 29602).

==================================================================
C1GanttView 2/4.0.20123.74                  Build Date: 10/29/2012
==================================================================

- Fixed an issue: ArgumentOutOfRangeException is observed after
  adding a new BarStyle, then canceling 'BarStyle Collection
  Editor', and canceling 'Task Collection Editor' dialogs at
  design-time (TFS 29462).

- Fixed an issue: Bottom border of Calendars is always cut off at
  design-time and runtime for the Chinese locale (TFS 29468).
  
- Fixed a minor issue with localization for Chinese (TFS 29467).

==================================================================
C1GanttView 2/4.0.20123.73                  Build Date: 10/27/2012
==================================================================

- Added a few missed localization strings.

==================================================================
C1GanttView 2/4.0.20123.72                  Build Date: 10/25/2012
==================================================================

- The interface language depends now on CurrentUICulture setting
  instead of the CurrentCulture property of CultureInfo.

- Fixed a small localization issue (TFS 29347).

==================================================================
C1GanttView 2/4.0.20123.70                  Build Date: 10/24/2012
==================================================================

- C1GanttView is now localized for the Japanese culture.

==================================================================
C1GanttView 2/4.0.20123.69                  Build Date: 10/21/2012
==================================================================

- Small internal optimization.

==================================================================
C1GanttView 2/4.0.20123.68                  Build Date: 10/15/2012
==================================================================

- Fixed an issue: Task is always created after clicking on the
  chart view, dragging the mouse pointer out of chart view and
  releasing the mouse button (TFS 27623).

- Fixed an issue: Both the Start and Finish position are changed
  while the ProgressBar is dragged across the Task (TFS 27647).

- Fixed an issue: Text editor appears in the chart view at run
  time after double clicking on any row in chart view and double
  clicking second time again on the same row (TFS 27964).

==================================================================
C1GanttView 2/4.0.20123.67                  Build Date: 10/13/2012
==================================================================

- Minor internal changes for better compatibility with VS2012.
- Added the Chinese and Korean localization strings.

==================================================================
C1GanttView 2/4.0.20122.65                  Build Date: 10/01/2012
==================================================================

- Fixed an issue: Duration is not updated for an auto-scheduled
  task when its Start or Finish column values are set using the
  grid view at runtime (TFS 28293).

==================================================================
C1GanttView 2/4.0.20122.64                  Build Date: 09/29/2012
==================================================================

- Fixed an issue: Duration only manual task bar doesn't move to
  the project finish date after setting the ScheduleFrom property
  to "ProjectFinishDate" when there is a deadline (TFS 27965).

==================================================================
C1GanttView 2/4.0.20122.63                  Build Date: 09/28/2012
==================================================================

- An attempt to assign a value to the Task.Start or Task.Finish
  property is now ignored for auto-scheduled tasks. The only
  exception is the grid view at runtime where the user can change
  values in the Start and Finish columns even for auto-scheduled
  tasks (see TFS 27669, 27700).

- Fixed a bug: Current Selection is jumped when a new task is
  inserted from code-behind in C1GanttView (TFS 27795).

- Fixed a bug: After changing C1GanttView.Cursor property, the
  cursor is not affected on the chart view (TFS 27868).

- Fixed a bug: Predecessor links aren't displayed correctly if
  TopText is specified for the task bar and the corresponding
  task is moved up (TFS 27993).

==================================================================
C1GanttView 2/4.0.20122.61                  Build Date: 09/27/2012
==================================================================

- Fixed a bug: Changing the Font Name at design-time doesn't
  affect the TimeScale on the Chart View (TFS 27807).
  
- Fixed a bug: No enough space at the left side of chart view
  to display long LeftText1 and LeftText2 for the earliest tasks
  (TFS 27706).

- Added the ScrollToTask() method to C1GanttView. The method
  scrolls the grid and chart views so that the specified task
  becomes visible.

==================================================================
C1GanttView 2/4.0.20122.59                  Build Date: 09/24/2012
==================================================================

- Fixed a bug: Deadline disappears and doesn't display properly
  when moving the vertical scroll bar (TFS 27633).

- Fixed an issue: the "Red Alert Indicator" is not displayed
  although the predecessor task link is conflicted with the
  constraint for Auto Task (TFS 27862).

==================================================================
C1GanttView 2/4.0.20122.58                  Build Date: 09/11/2012
==================================================================

- Removed internal reference to the C1FlexGrid assembly.

- Updated GrapeCity product information.

==================================================================
C1GanttView 2/4.0.20122.57                  Build Date: 09/03/2012

*** This build depends on C1FlexGrid 2/4.6.20122.716 ***
==================================================================

- Fixed an issue: an ArgumentOutOfRangeException is observed
  after deleting the last existing Exception in the "Change
  Working Time" dialog at run time (TFS 27582).

- Fixed an issue: the Predecessor links becomes hidden when the
  predecessor task's start date, finish date and duration are
  cleared (TFS 27588).

- Fixed an issue: changing the Font property of C1GanttView or
  its parent form did not affect the font used on grid/chart
  views at run-time.

==================================================================
C1GanttView 2/4.0.20122.55                  Build Date: 08/30/2012

*** This build depends on C1FlexGrid 2/4.6.20122.715 ***
==================================================================

- Fixed an issue: the chart view does not scroll automatically
  to the new start/finish date of the project if there are only
  Duration-only task bars or no task bars at all (TFS 27338).

- Fixed an issue: the user is unable to drag, resize, and link
  a manual task with the Duration-only bar style (TFS 27341).

==================================================================
C1GanttView 2/4.0.20122.53                  Build Date: 08/27/2012

*** This build depends on C1FlexGrid 2/4.6.20122.713 ***
==================================================================

- Fixed an issue (introduced in build 51): Start date of the
  Exception or Work Week is automatically changed to the 1st day
  of the month after browsing the calendar of the End/Finish
  date editor to the next month, then selecting the End date in
  the same month with the Start date (TFS 27342).

==================================================================
C1GanttView 2/4.0.20122.52                  Build Date: 08/23/2012

*** This build depends on C1FlexGrid 2/4.6.20122.712 ***
==================================================================

- Fixed an issue: the "Scroll To Task" command doesn't work for
  a Manual Task which has Duration only task bar (TFS 27264).

==================================================================
C1GanttView 2/4.0.20122.51                  Build Date: 08/20/2012

*** This build depends on C1FlexGrid 2/4.6.20122.710 ***
==================================================================

- Fixed an issue: Auto Task bar disappears at run time when
  a circular reference is set between tasks (TFS 26121).

- Fixed a problem in the 'Change Working Time' dialog: it was
  possible to set the finish date of a Work Week or Exception
  less than the start date (TFS 26156).

==================================================================
C1GanttView 2/4.0.20122.49                  Build Date: 08/16/2012

*** This build depends on C1FlexGrid 2/4.6.20122.707 ***
==================================================================

- Fixed an issue: manual task bar is not displayed on the chart
  view if only Duration is set without setting the Start and
  Finish dates (TFS 24801).

- Fixed an issue: the auto-scheduled task bar moves over its
  deadline when the project is scheduled from the end date
  (TFS 24804).

- Fixed an issue: value typed in the Duration column disappears
  when the Finish date is set before the Start date and the
  project is scheduled from the start date (TFS 25853).

- Added VS2012 toolbox icon.

==================================================================
C1GanttView 2/4.0.20122.45                  Build Date: 08/13/2012

*** This build depends on C1FlexGrid 2/4.6.20122.704 ***
==================================================================

- Fixed an issue: When a C1GanttView is placed in an MDI child
  form, after closing this form the MDI parent form becomes
  deactivated and has to be clicked twice in order to set focus
  in the parent form (TFS 24802).

- Fixed an issue: BarStyle text disappears every time the
  corresponding task bar is scrolled horizontally outside the
  visible area (24803).

==================================================================
C1GanttView 2/4.0.20122.44                  Build Date: 08/04/2012

*** This build depends on C1FlexGrid 2/4.6.20122.704 ***
==================================================================

- No changes except referencing a new build of C1FlexGrid.

==================================================================
C1GanttView 2/4.0.20122.43                  Build Date: 08/01/2012

*** This build depends on C1FlexGrid 2/4.6.20122.703 ***
==================================================================

- Fixed an issue: In certain cases the auto-scheduled task can
  be displayed at the wrong position that doesn't correspond to
  the task's constraint condition (TFS 24576).

==================================================================
C1GanttView 2/4.0.20122.42                  Build Date: 07/31/2012

*** This build depends on C1FlexGrid 2/4.6.20122.703 ***
==================================================================

- Fixed an issue: The predecessor task's bar does not move to
  the expected position when a predecessor is added to some task
  while the ScheduleFrom property is set to "ProjectFinishDate"
  for the owner project (TFS 24513).

==================================================================
C1GanttView 2/4.0.20122.41                  Build Date: 07/29/2012

*** This build depends on C1FlexGrid 2/4.6.20122.703 ***
==================================================================

- Fixed an issue: Vertical scrollbar of the form is scrolled
  along with the grid view’s scrollbar when using the mouse
  wheel (TFS 24492).

==================================================================
C1GanttView 2/4.0.20122.40                  Build Date: 07/20/2012

*** This build depends on C1FlexGrid 2/4.6.20122.703 ***
==================================================================

- Irrelevant events became hidden in the C1GanttView control
  (see TFS 23996).

- Small improvement to the "Change Working Time" editor: time
  intervals are validated before closing the dialog window.

==================================================================
C1GanttView 2/4.0.20122.36                  Build Date: 07/16/2012

*** This build depends on C1FlexGrid 2/4.6.20122.701 ***
==================================================================

- Cosmetic changes: reordered buttons on the toolbar. Also,
  reordered items in the Smart Tag menu (Action List).

==================================================================
C1GanttView 2/4.0.20122.34                  Build Date: 07/06/2012

*** This build depends on C1FlexGrid 2/4.6.20122.699 ***
==================================================================

- Fixed an issue: Grid vertical scroll bar doesn't appear after
  hiding all three tiers of Timescales (TFS 23926).

- A few toolbar icons were updated and reordered.

==================================================================
C1GanttView 2/4.0.20122.33                  Build Date: 07/05/2012

*** This build depends on C1FlexGrid 2/4.6.20122.699 ***
==================================================================

- C1GanttView shows a message box at run-time when upper tiers
  units have less time per tick than the tiers below (TFS 23726).

- Fixed an issue: When the GridDateFormat property is set at run
  time, the date display format in the grid view is not updated
  (TFS 23776).

- Fixed an issue: Inconsistence observed between hiding all
  timescale tiers at design time and at run time (TFS 23777).

- Updated the assembly copyright information.

==================================================================
C1GanttView 2/4.0.20122.32                  Build Date: 06/26/2012

*** This build depends on C1FlexGrid 2/4.6.20122.698 ***
==================================================================

- Added the VisualStyle property to C1GanttView. It gets or sets
  the visual style for the Gantt View control.

- Fixed an issue: an ArgumentOutOfRangeException observed after
  setting the MiddleTier timescale unit to "Years" and BottomTier
  to "HalfYears" or "Quarters" at run time (TFS 23626).
  
- Fixed a problem: text entered in a grid cell is lost while the
  cell is in edit mode after clicking on the "Grid Columns"
  toolbar button and checking some visible columns (TFS 23631).

==================================================================
C1GanttView 2/4.0.20122.31                  Build Date: 06/23/2012

*** This build depends on C1FlexGrid 2/4.6.20122.698 ***
==================================================================

- Removed a few properties from an output XML file. The following
  C1GanttView's properties are not persisted in XML because the
  user can't edit their values at runtime:
  
  ShowToolbar, SplitterColor, BackColor, ForeColor,
  CellBorderColor, ToolbarBackColor, FixedBackColor,
  FixedForeColor, FixedCellBorderColor, HighlightBackColor,
  HighlightForeColor, EmptyAreaBackColor.

==================================================================
C1GanttView 2/4.0.20122.30                  Build Date: 06/22/2012

*** This build depends on C1FlexGrid 2/4.6.20122.698 ***
==================================================================

- Added the SelectedTask and SelectedTaskIndex properties to
  C1GanttView (see TFS 23460). Both properties are runtime-only.
  They allow to get or set the currently selected task or its
  row index.

- Added the GetPredefinedBarStyle() method to C1GanttView. It
  returns a copy the built-in BarStyle that corresponds to the
  specified bar type.

- Added a few Search() and IndexOf() methods overloads to the
  following collections: TaskCollection, CustomCalendarCollection,
  CalendarExceptionCollection, ColumnCollection, ResourceCollection,
  PredecessorCollection, ResourceRefCollection, WorkWeekCollection.

- Added the Initialized property to the Task class. It indicates
  whether the task contains any non-empty fields.
  
- Added the GetDurationInDays() method to the Task class. It
  returns the duration of the task, in days.  

- Added the Cost label and value to the Resources tab of the Task
  Information dialog.

- Fixed an issue: the HighlightBackColor and HighlightForeColor
  properties had no effect in C1GanttView which is placed in
  a C1RibbonForm (TFS 23461).

==================================================================
C1GanttView 2/4.0.20122.28                  Build Date: 06/19/2012

*** This build depends on C1FlexGrid 2/4.6.20122.698 ***
==================================================================

- Fixed an issue in the Timescale dialog: inappropriate formats
  were available in the Format and Example comboboxes.

==================================================================
C1GanttView 2/4.0.20122.26                  Build Date: 06/15/2012

*** This build depends on C1FlexGrid 2/4.6.20122.697 ***
==================================================================

- Fixed issues: 22900 (at design-time), 23391, 23392, 23420.

==================================================================
C1GanttView 2/4.0.20122.24                  Build Date: 06/14/2012

*** This build depends on C1FlexGrid 2/4.6.20122.697 ***
==================================================================

- Extended scrolling limits on the chart view. Added more space
  before the project start and after the project end.

- Fixed an issue: task predecessor lines did not appear correctly
  at design-time after inserting/removing tasks using the Task
  Collection Editor.

==================================================================
C1GanttView 2/4.0.20122.22                  Build Date: 06/13/2012

*** This build depends on C1FlexGrid 2/4.6.20122.694 ***
==================================================================

- Fixed TFS issues: 23299, 23300, 23301.

==================================================================
C1GanttView 2/4.0.20122.21                  Build Date: 06/12/2012

*** This build depends on C1FlexGrid 2/4.6.20122.693 ***
==================================================================

- Fixed TFS issues: 23260, 23261, 23262, 23265.

==================================================================
C1GanttView 2/4.0.20122.20                  Build Date: 06/11/2012

*** This build depends on C1FlexGrid 2/4.6.20121.690 ***
==================================================================

- Added the StartFinishLineColor property to C1GanttView:

  public Color StartFinishLineColor { get; set; }
  
  The property specifies the color of the project start/finish
  date lines on the chart view.

- Added a few other Color properties to C1GanttView that help to
  adjust various aspects of the grid and chart view appearance:

  public Color ToolbarBackColor { get; set; }
  public Color CellBorderColor { get; set; }
  public Color FixedBackColor { get; set; }
  public Color FixedForeColor { get; set; }
  public Color FixedCellBorderColor { get; set; }
  public Color HighlightBackColor { get; set; }
  public Color HighlightForeColor { get; set; }
  public Color EmptyAreaBackColor { get; set; }

- Fixed an issue: the IndexOutOfRangeException occured in
  C1GanttView when a user adds a blank row while the last task
  row is currently selected.

- Fixed an issue: when the user creates a new automatic task by
  dragging the mouse pointer over the chart view the newly
  created task always started at the project start, not at the
  specified time position.

- Fixed an issue with loading task data from an XML file.

- Fixed an issue: the predecessor task's working hours did not
  take into account when scheduling a task with non-zero value
  in the Predecessor.Lag property.

- Improved keyboard interaction in the grid view.

- Fixed a problem with incorrect position of the notification
  window while the user drags a task bar on the chart view if
  that view is scrolled down.

- Fixed a layout problem at design time: when the C1GanttView
  control is added to a form from the toolbar the splitter
  between the grid and chart views doesn't appear.

==================================================================
C1GanttView 2/4.0.20122.13                  Build Date: 06/05/2012

*** This build depends on C1FlexGrid 2/4.6.20121.690 ***
==================================================================

- Fixed TFS issues: 22895, 22900, 22901, 22902, 22924, 22925,
  22926, 22927, 22946.

- Removed the MinDateTime and MaxDateTime properties from the
  Timescale object. These properties seem to be unnecessary.

- The Format property has been moved from the BaseColumn class
  to CustomFieldColumn.

- The DefaultDateTimeFormat property has been removed from the
  C1GanttView control and the Schedule class.
  
- DefaultDateFormat property has been replaced with two new
  properties: GridDateFormat and ChartDateFormat. It is now
  possible to specify different date formats for the grid view
  and the chart view.

- Added the ShowToolbar boolean property to C1GanttView. The
  property specifies whether the toolbar with the command buttons
  is visible.
  
- Added the ClickButton() method to C1GanttView:

  public void ClickButton(CommandButton button);
  
  The method simulates a click on the toolbar button specified
  by the 'button' parameter.

==================================================================
C1GanttView 2/4.0.20122.12                  Build Date: 05/25/2012

*** This build depends on C1FlexGrid 2/4.6.20121.686 ***
==================================================================

- The first official drop.

==================================================================
