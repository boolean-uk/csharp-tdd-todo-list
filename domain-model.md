| Classes       | Methods/Properties                                | Scenario							| Outputs          |
|---------------|---------------------------------------------------|-----------------------------------|------------------
|ToDoList.cs	|Add(string name)										|Add task to ToDoList				|bool
|ToDoList.cs	|GetAll(bool complete=false, bool incomplete=false)	|Get tasks from ToDoList (filtered)	|List\<Task\>
|ToDoList.cs	|ChangeStatus(int TaskId)							|Change status for a task			|bool
|ToDoList.cs	|GetTask(int taskId)								|Get task by Id						|Task
|ToDoList.cs	|GetTask(string TaskName)							|Get/Search for task by stringName	|Task
|ToDoList.cs	|GetTasksByPriority(string priority="")				|Get all tasks for a priority		|List\<Task\>
|ToDoList.cs	|Remove(int TaskId)								|Remove tasks by Id					|bool
|ToDoList.cs	|SetTaskPriority(int TaskId, int Priority)				|Sets the priority for a task		|bool
|ToDoList.cs	|GetTasksByCategory(string category)				|Get tasks by category				|List\<Task\>
|ToDoList.cs	|GetSortedTasks(bool ascending=true)				|Get tasks sorted alphabetically	|List\<Task\>
|ToDoList.cs	|GetLongerThanFive()								|Get tasks that took \> 5 days		|List\<Task\>
|ToDoList.cs	|LongestToComplete									|Get task that took longest to complete | Task
|ToDoList.cs	|ShortestToComplete									|Get task that took shortest to complete | Task
|Task.cs		|int Priority (0=None, 1=low, 2=medium 3=high)		|Property to define priority level	|int (1=low, 2=medium, 3=high)
|Task.cs		|int Id												|Give tasks an identifier			|int
|Task.cs		|Update(int taskId, string newName)					|Update name of task by Id			|bool
|Task.cs		|DateTime CreatedAt									|Get date and time for creation		|DateTime
|Task.cs		|DateTime CompletedAt								|Get date and time for completion	|DateTime 
|Task.cs		|string Category (study, work, admin, etc.)			|Categorize each task				|string