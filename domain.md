I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.

Class		Method												Scenario									Return value
ToDoList	AddTask(Task task)									Add a task to the ToDoList					true if successful
																											false if not succesful
ToDoList	AllTasks()											Fetch all the tasks							list of all tasks
ToDoList	FetchTask(string taskName)							Fetch a task								the task if found
																											null if not found
ToDoList	ChangeStatus(string taskName, Status.newStatus)		Change the status of a task					true if succesful
																											false if task does not exist
ToDoList	FetchTasksWithStatus(Status.status)					Fetch all the tasks with a specific status	list of tasks
ToDoList	DoesExist(string taskName)							Check if a task with a specific name exists	string with status message
ToDoList	RemoveTask(string taskName)							Remove a task								true if found and removed
																											false if not found
ToDoList	AllTasksSorted(string asc/desc)						Fetch tasks in order						list of tasks
ToDoList	PrintTaskList(List<Task> list)						Print the list of tasks						void