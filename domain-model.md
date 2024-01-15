| Classes         | Methods                                     | Scenario               | Outputs					   |
|-----------------|---------------------------------------------|------------------------|-----------------------------|
| `TodoList`  | `add(String name, Bool isCompleted)`				| task is added			 | string containing confirmation of added Task  |
| `TodoList`  | `printAll()`		  | there are tasks			| string containing all Tasks   |
|		  |						  | there are no tasks      | string containing all Tasks   |
| `TodoList`  | `complete(Task task)` | task exists and is uncompleted      | completed Task  |
|		  |						  | task exists and is completed        | uncompleted Task  |
| `TodoList`  | `getComplete()`		  | there are completed tasks			| List of all completed Tasks   |
|		  |						  | there are no completed tasks		| empty list of Tasks    |
| `TodoList`  | `getIncomplete()`	  | there are incomplete tasks			| List of all incomplete Tasks   |
|		  |						  | there are no incomplete tasks		| empty list of Tasks    |
| `TodoList`  | `search(Task task)`	  | task exists				| Task		 |
|		  |						  | task doesn't exist		| Empty Task |
| `TodoList`  | `remove(Task task)`	  | task exists			    | True   |
|		  |						  | task doesn't exist		| False  |
| `TodoList`  | `printOrderASC()`	  | there are tasks			| string containing all Tasks   |
|		  |						  | there are no tasks      | string containing all Tasks   |
| `TodoList`  | `printOrderDESC()`	  | there are tasks			| string containing all Tasks   |
|		  |						  | there are no tasks      | string containing all Tasks   |