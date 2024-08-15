I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.



| Classes       | Methods			     					 |  Scenario								 | Outputs			|
| ------------- | -------------	     						 |  ------------							 | -----------		|
| `TodoList`    | AddTask(Task t)							 |  Adds task to todo list					 | true				|
|				| 											 |  Task could not be added					 | false			|
|				|										     |											 |      			|
| `TodoList`    | GetAllTasks()	     					     |  Finds all tasks from todo list			 | List<Task>		|
|               |				    						 |											 |					|
| `TodoList`    | ChangeTaskStatus(Task t, Status new)	     |  Changes status of task					 | Status		    |
|               |				    						 |											 |					|
| `TodoList`    | GetCompleteTasks()						 |  Get all complete tasks					 | List<Task>		|
| `TodoList`    | GetIncompleteTasks()						 |  Get all incomplete tasks				 | List<Task>		|
|               |				    						 |											 |					|
| `TodoList`    | FindTask(string task)						 |  Get all incomplete tasks				 | Task				|
|               |				    						 |											 |					|
| `TodoList`    | DeleteTask(string task)					 |  Delete task from todo list				 | true				|
|               |				    						 |	 Task does not exist in todo list		 | false			|
|               |				    						 |											 |					|
| `TodoList`    | GetSortedTasksAsc()						 |  Get all tasks sorted ascending			 | List<Task>		|
| `TodoList`    | GetSortedTasksDesc()						 |  Get all tasks sorted descending			 | List<Task>		|