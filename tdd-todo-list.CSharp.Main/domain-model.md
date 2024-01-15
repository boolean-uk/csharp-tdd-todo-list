DOMAIN MODEL FOR TODOLIST:

Core Requirements
I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order

Class

	-ToDoList()

Properties

	-Public Dict<String(nameTask), Int(isFinnish)>

Methods

	add(task);
		-adds new task, default value: incomplete(0)

	ShowTasks();
		-shows all keys (nameTask) in the dict

	ChangeStatus(string(taskName), Status(int));
		-changes value in specific keyvaluepair 0 = incomplete, 1 = complete
	
	SearchForTask(string(taskName);
		-Returns true if it exists, or a false if it does'nt 

	RemoveTask(string(taskName);
		-removes the task with that specific name

	ShowIncompleteTasks();
		-shows all incomplete tasks (0)

	ShowCompleteTasks
		-shows all complete tasks(1)

	ShowTaskAlphabeticAsc();
		-shows all tasks in ascending order

	ShowTaskAlphabeticDesc();
		-shows all tasks in descending order


DOMAIN MODEL FOR TODOLIST, Extension:

I want to be able to get a task by a unique ID.
I want to update the name of a task by providing its ID and a new name.
I want to be able to change the status of a task by providing its ID.
I want to be able to see the date and time that I created each task.

Class

	-ToDoListExtension()

Properties

	-Private List<String[]> ("NameTask, "ID", "Timestamp", "Status")

Methods
	
	getID(taskName);
		-returns the ID of task with taskName if it exists

	getTaskID(ID);
		-returns the task if task with that ID exists

	UpdateTaskNameID(ID, newName);
		-update the name of the task by providing ID

	UpdateTaskStatusID(ID, newStatus);
		-changes the status of a task if the task with that ID exists
	
	getTaskTimeStamp;
		-Returns a list with arrays that contains name and timestamp for all tasks