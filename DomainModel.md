

| Classes     | Method				      | Scenario									  | Output		  |
|-------------|---------------------------|-----------------------------------------------|---------------|
| `TodoList`  | `Add(Task task)`          | Adds task to todo list succesfully			  | true		  |
|-------------|---------------------------|-----------------------------------------------|---------------|
| `TodoList`  | `GetTodoList()`		      | Returns a todolist of all the tasks			  | TodoList	  |
|-------------|---------------------------|-----------------------------------------------|---------------|
| `Task`	  | `ChangeStatus()`	      | Changes the status to whatever it isnt		  | true		  |
| `TodoList`  |`ChangeStatus(string name)`| Changes the status of given task			  | Task.ChangeStatus()|
|-------------|---------------------------|-----------------------------------------------|---------------|
| `TodoList`  | `GetCompleted()`	      | Gets the completed tasks in the TodoList	  | List_Task	  |
|-------------|---------------------------|-----------------------------------------------|---------------|
| `TodoList`  | `GetIncompleted()`	      | Gets the incompleted tasks in the TodoList	  | List_Task	  |
|-------------|---------------------------|-----------------------------------------------|---------------|
| `TodoList`  | `FindTask(string name)`   | Finds the task with a mathing name			  | String	   	  |
|			  |						      |												  | 			  |
|			  |                           | Unable to find the task name				  | String		  |
|-------------|---------------------------|-----------------------------------------------|---------------|
| `TodoList`  | `RemoveTask(String name)` | Removes the given task						  | true		  |
|			  |							  |												  |				  |
|			  |							  | Unable to remove the given task				  | false		  |
|-------------|---------------------------|-----------------------------------------------|---------------|
| `TodoList`  | `SortAscending()`		  | Sorts the tasks in ascending order			  | List_Task	  |
|-------------|---------------------------|-----------------------------------------------|---------------|
| `TodoList`  | `SortDescending()`		  | Sorts the tasks in descending order			  | List_Task	  |
|-------------|---------------------------|-----------------------------------------------|---------------|
