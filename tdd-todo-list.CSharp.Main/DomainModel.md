I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.




| Classes         | Methods                                     | Scenario										| Outputs			|
|-----------------|---------------------------------------------|-----------------------------------------------|-------------------|
| `ToDoList`	  | `add(String task, bool complete)`		    | task added to the todo list					| true				|
|				  |											    |												|					|
|                 | `changeStatus(String task)`					| status of task changed						| true				|
|				  |											    |												|					|
|				  | `getAllTasks()`							    | shows all tasks in the todo list				| List<string>		|
|				  |											    |												|					|
|				  | `getCompletedTasks()`						| shows all completed tasks in the todo list	| List<string>		|
|				  |											    |												|					|
|				  | `getIncompletedTasks()`						| shows all completed tasks in the todo list	| List<string>		|
|				  |											    |												|					|
|				  | `search(string task)`						| finds task in the todo list					| true				|
|				  |												| task does not exist in the todo list			| false 			|
|				  |											    |												|					|
|				  | `remove(string task)`						| removes task from list						| true				|
|				  |											    |												|					|
|				  | `sortAscending()`							| shows all tasks in ascending alphabetic order	| List<string>		|
|				  |											    |												|					|
|				  | `sortDecending()`							| shows all tasks in decending alphabetic order	| List<string>		|

