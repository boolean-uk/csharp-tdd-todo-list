# Class Task
	- string taskName
	- bool isComplete


# Class TodoList
	PROPERTIES	
	- public List <Task> tasks;

	METHODS	
	- addTask(string taskName, bool isComplete) add task to List<string> _todos
	- getAllTasks() returns a Dictionary of all taks of TodoList
	- changeStatus() returns true when status is changed, return true with message of changed status.
	- getCompletedTasks returns a list of tasks that are completed
	- getIncompletedTasks returns a list of tasks that ar'nt completed
	- searchTask(string taskName) returns true if taks is found, return fals if taks does not exist. 
	- removeTask(string taskName) returns message when task is not found
	- orderListAsc(string taskName) returns list of tasks in Asc order.
	- orderListDesc(string taskName) returns list of tasks in Desc order.
