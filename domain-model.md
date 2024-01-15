| Classes         | Methods                                     | Scenario               | Outputs					   |
|-----------------|---------------------------------------------|------------------------|-----------------------------|
| `Task`  | `add(String name, Bool isCompleted)`				| task is added			 | string containing confirmation of added Task  |
| `Task`  | `printAll()`		  | there are tasks			| string containing all Tasks   |
|		  |						  | there are no tasks      | string containing all Tasks   |
| `Task`  | `complete(Task task)` | task exists and is uncompleted      | completed Task  |
|		  |						  | task exists and is completed        | uncompleted Task  |
| `Task`  | `getComplete()`		  | there are completed tasks			| List of all completed Tasks   |
|		  |						  | there are no completed tasks		| empty list of Tasks    |
| `Task`  | `getIncomplete()`	  | there are incomplete tasks			| List of all incomplete Tasks   |
|		  |						  | there are no incomplete tasks		| empty list of Tasks    |
| `Task`  | `search(Task task)`	  | task exists				| Task		 |
|		  |						  | task doesn't exist		| Empty Task |
| `Task`  | `remove(Task task)`	  | task exists			    | True   |
|		  |						  | task doesn't exist		| False  |
| `Task`  | `printOrderASC()`	  | there are tasks			| string containing all Tasks   |
|		  |						  | there are no tasks      | string containing all Tasks   |
| `Task`  | `printOrderDESC()`	  | there are tasks			| string containing all Tasks   |
|		  |						  | there are no tasks      | string containing all Tasks   |