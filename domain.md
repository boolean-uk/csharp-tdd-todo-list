I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.

I want to be able to get a task by a unique ID.
I want to update the name of a task by providing its ID and a new name.
I want to be able to change the status of a task by providing its ID.
I want to be able to see the date and time that I created each task.

Class				Method												Scenario									Return value
TodoList			AddTask(Task task)									Add a task to the ToDoList					true if successful
																													false if not succesful
TodoList			AllTasks()											Fetch all the tasks							list of all tasks
TodoList			FetchTask(string taskName)							Fetch a task								the task if found
																													null if not found
TodoList			ChangeStatus(string taskName, Status.newStatus)		Change the status of a task					true if succesful
																													false if task does not exist
TodoList			FetchTasksWithStatus(Status.status)					Fetch all the tasks with a specific status	list of tasks
TodoList			DoesExist(string taskName)							Check if a task with a specific name exists	string with status message
TodoList			RemoveTask(string taskName)							Remove a task								true if found and removed
																													false if not found
TodoList			AllTasksSorted(string asc/desc)						Fetch tasks in order						list of tasks
TodoList			PrintTaskList(List<Task> list)						Print the list of tasks						void

TodoListExtended	FetchTaskByID(int id)								Fetch a task by id							int id of the task
																													-1 if not found
TodoListExtended	UpdateTaskNameByID(int id, string newName)			Update task name by id						true if successful
																													false if no task with id
TodoListExtended	UpdateTaskStatusByID(int id, status newStatus)		Update task status by id					true if successful
																													false if no task with id