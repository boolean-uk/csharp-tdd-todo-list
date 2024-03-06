# Class Task
	- string taskName
	- bool isComplete


# Class TodoList
	PROPERTIES	
	- public List <Task> tasks;

	METHODS	
	- addTask(Task task) add task to List<Task> tasks
	- getAllTasks() returns a list of all taks of TodoList
	- changeStatus() returns true when status is changed, return fals when task does not exist. 
	- getCompletedTasks returns a list of tasks that are completed
	- getIncompletedTasks returns a list of tasks that ar'nt completed
	- searchTask(Task tasks) returns true if taks is found, return fals if taks does not exist. 
	- removeTask(Task tasks) returns message when task is not found
	- orderListAsc(Task tasks) returns list of tasks in Asc order.
	- orderListDesc(Task tasks) returns list of tasks in Desc order.
