
I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.




| Classes         | Methods                                     | Scenario							 |			  Outputs								|
|-----------------|---------------------------------------------|------------------------------------|--------------------------------------------------|
| `Todo			` | `AddTask(Task task)						`	| Add task to incomplete todo list	 |(bool) True if added, otherwise false				|
|                 |                                             |									 |													|
|-----------------|---------------------------------------------|------------------------------------|--------------------------------------------------|
| `Todo			` | `PrintTodo()							`	| Print todo list					 |(void) No return, prints list						|
|                 |                                             |									 |													|
|-----------------|---------------------------------------------|------------------------------------|--------------------------------------------------|
| `Todo			` | `ChangeStatus(Task task)				`	| Change status on task				 |(bool) Returns true if changed, false if not		|
|                 |                                             |									 |													|
|-----------------|---------------------------------------------|------------------------------------|--------------------------------------------------|
| `Todo			` | `PrintCompleteTodo()					`	| Prints completed TODO				 |(void) Prints list with only completed TODO		|
|                 |                                             |									 |													|
|-----------------|---------------------------------------------|------------------------------------|--------------------------------------------------|
| `Todo			` | `PrintIncompleteTodo()					`	| Prints incomplete TODO			 |(void) Prints list with only incomplete TODO		|
|                 |                                             |									 |													|
|-----------------|---------------------------------------------|------------------------------------|--------------------------------------------------|
| `Todo			` | `SearchTask(string name)				`	| Search specific task				 |(bool) Find task, return false if not found		|
|                 |                                             |									 |													|
|-----------------|---------------------------------------------|------------------------------------|--------------------------------------------------|
| `Todo			` | `RemoveTask(Task task)					`	| Remove task from list				 |(bool) return true if removed, false if not	    |
|                 |                                             |									 |													|
|-----------------|---------------------------------------------|------------------------------------|--------------------------------------------------|
| `Task			` | `CreateTask()							`	| Creates Task						 |													|
|                 |                                             |									 |													|
|-----------------|---------------------------------------------|------------------------------------|--------------------------------------------------|



I want to be able to get a task by a unique ID.
I want to update the name of a task by providing its ID and a new name.
I want to be able to change the status of a task by providing its ID.
I want to be able to see the date and time that I created each task.

| Classes         | Methods                                     | Scenario							 |			  Outputs								|
|-----------------|---------------------------------------------|------------------------------------|--------------------------------------------------|
| `Todo			` | `FindTask(int id)						`	| Find task by ID					 |(Task) Returns task if ID exists					|
|                 |                                             |									 |													|
|-----------------|---------------------------------------------|------------------------------------|--------------------------------------------------|
| `Todo			` | `ChangeName(int id, string name)		`	| Updates name of task				 |(bool) Returns true if changed, otherwise false	|
|                 |                                             |									 |													|
|-----------------|---------------------------------------------|------------------------------------|--------------------------------------------------|
| `Todo			` | `ChangeStatus(int id)					`	| Change status on task				 |(bool) Returns true if changed, false if not		|
|                 |                                             |									 |													|
|-----------------|---------------------------------------------|------------------------------------|--------------------------------------------------|
| `Todo			` | `FindDateTime(int id)					`	| Finds date and time for task creati|(DateTime) Returns datetime of task creation		|
|                 |                                             |									 |													|
|-----------------|---------------------------------------------|------------------------------------|--------------------------------------------------|