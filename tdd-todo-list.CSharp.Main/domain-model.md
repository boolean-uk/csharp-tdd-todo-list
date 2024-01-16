
Core model

Class: Task			Method: IsComplete()			return: bool			case: 
Class: Task			Method: ChangeCompleteStatus()	void: bool = !bool		case: I want to change the status of a task between incomplete and complete.
Class: TodoList		Method: AddTask(<Task>)			void: add task			case: I want to add tasks to my todo list.
Class: TodoList		Method: RemoveTask(<Task>)		void: remove task		case: I want to remove tasks from my list.
Class: TodoList		Method: GetAllTasks()			return: List<Task>		case: I want to see all the tasks in my todo list.
Class: TodoList		Method: GetAllTasksDecending()	return: List<Task>		case: I want to see all the tasks in my list ordered alphabetically in descending order.
Class: TodoList		Method: GetAllTasksAcending()	return: List<Task>		case: I want to see all the tasks in my list ordered alphabetically in ascending order.
Class: TodoList		Method: GetCompletedTasks()		return: List<Task>		case: I want to be able to get only the complete tasks.
Class: TodoList		Method: GetIncompletedTasks()	return: List<Task>		case: I want to be able to get only the incomplete tasks.
Class: TodoList		Method: FindTask("task name")	return: <Task> or warn.	case: I want to search for a task and receive a message that says it wasn't found if it doesn't exist.

Extended model

Class: TodoList		Method:	FindTaskByID()			return: Task			case: I want to be able to get a task by a unique ID.
Class: TodoList		Method: UpdateNameByID()		void					case: I want to update the name of a task by providing its ID and a new name.
Class: TodoList		Method: UpdateCompletedByID()	void					case: I want to be able to change the status of a task by providing its ID.
Class: TodoTask		Method: GetCreationTime()		return: creation time	case: I want to be able to see the date and time that I created each task.

