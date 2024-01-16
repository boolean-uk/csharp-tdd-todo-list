| Classes         | Methods                                     | Scenario               | Outputs					   |
|-----------------|---------------------------------------------|------------------------|-----------------------------|
| `TodoList`  | `Add(String name)`				| task is added			 | Task  |
| `TodoList`  | `PrintAll()`		  | there are tasks			| string containing all Tasks   |
|		  |						  | there are no tasks      | string containing all Tasks   |
| `TodoList`  | `Complete(Task task)` | task exists and is uncompleted      | completed Task  |
|		  |						  | task exists and is completed        | uncompleted Task  |
| `TodoList`  | `GetComplete()`		  | there are completed tasks			| List of all completed Tasks   |
|		  |						  | there are no completed tasks		| empty list of Tasks    |
| `TodoList`  | `GetIncomplete()`	  | there are incomplete tasks			| List of all incomplete Tasks   |
|		  |						  | there are no incomplete tasks		| empty list of Tasks    |
| `TodoList`  | `Search(string name)`	  | task exists				| Task		 |
|		  |						  | task doesn't exist		| Empty Task |
| `TodoList`  | `Remove(Task task)`	  | task exists			    | True   |
|		  |						  | task doesn't exist		| False  |
| `TodoList`  | `PrintOrderASC()`	  | there are tasks			| string containing all Tasks   |
|		  |						  | there are no tasks      | string containing all Tasks   |
| `TodoList`  | `PrintOrderDESC()`	  | there are tasks			| string containing all Tasks   |
|		  |						  | there are no tasks      | string containing all Tasks   |