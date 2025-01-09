
`
1 I want to add tasks to my todo list.
2 I want to see all the tasks in my todo list.
3 I want to change the status of a task between incomplete and complete.
4 I want to be able to get only the complete tasks.
5 I want to be able to get only the incomplete tasks.
6 I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
7 I want to remove tasks from my list.
8 I want to see all the tasks in my list ordered alphabetically in ascending order.
9 I want to see all the tasks in my list ordered alphabetically in descending order.
`

  | Classes       | Methods											  | Scenario (act)					            | Outputs 			    
  |---------------|---------------------------------------------------|---------------------------------------------|----------------------------------------|
  | `TodoList`    | AddTask(string task)							  | method add task to TodoList		  	        | bool true if added, else false	    
				  |
				  | RemoveTask(string task)							  | method remove task from TodoList		    | bool true if removed, else false					
				  |
				  | SeeAllTasks()									  | member to expose all tasks in TodoList		| return TodoList
				  |
				  | ChangeStatus(string task, bool isCompleted)		  | method for updating task.value		     	| bool true if changed
				  |
				  | GetCompletedTasks()								  |	member to get completed tasks				| return TodoList with completed tasks
				  |
				  | GetInCompletedTasks							      | member to get incompleted tasks				| return TodoList with incompleted tasks
				  |
				  |
				  | SearchTask()									  | method for finding task						| bool true if found
				  | 
				  | SortByAscending()								  | OrderBy, keys sorted in ascending order  	| return List of keys
				  | SortByAscending()								  | OrderBy, keys sorted in ascending order  	| return List of keys
				  |
				  | SortByDescending()								  | OrderByDescending, keys sroted in descending order 	 | return List of keys
					