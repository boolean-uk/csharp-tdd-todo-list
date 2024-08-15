1. I want to add tasks to my todo list.
2. I want to see all the tasks in my todo list.
3. I want to change the status of a task between incomplete and complete.
4. I want to be able to get only the complete tasks.
5. I want to be able to get only the incomplete tasks.
6. I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
7. I want to remove tasks from my list.
8. I want to see all the tasks in my list ordered alphabetically in ascending order.
9. I want to see all the tasks in my list ordered alphabetically in descending order.

| Class		| Members							       | Methods														 | Scenario						    | Output
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
| ToDoList  | Dictionary<string, string> ToDoList      | AddTask(string task)											 | if task is not already in list   | True
| ToDoList  |									       |																 | if task is already in list	    | False
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
| ToDoList  |									       | ViewToDoList(Dictionary<string, string> ToDoList)				 | if viewing all tasks in list	    | Dictionary ToDoList
| ToDoList  |									       |		modified ViewToDoList()									 | if filtering incomplete tasks    | List
| ToDoList  |									       |		modified ViewToDoList()									 | if filtering complete tasks	    | List
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
| ToDoList	|									       | SearchList(Dictionary<string, string> ToDoList, string task)	 | if task is not in list		    | string SearchMessage
| ToDoList	|									       |																 | if task is in list			    | string SearchMessage
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
| ToDoList	| 									       | RemoveTask(string task)										 | if task exist				    | True
| ToDoList	| 									       |																 | if task does not exist		    | False
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
| ToDoList	| string TaskStatus { get; set; }	       |																 | property to set task status 	    | string
| ToDoList	|									       |																 | if task new or is not completed  | string "incomplete"
| ToDoList	|									       |																 | if task is completed			    | string "complete"
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
| ToDoList	| bool CheckStatus { get; set; }	       |																 | property to check task status    | bool
| ToDoList	|									       |																 | if TaskStatus is incomplete	    | False
| ToDoList	| 									       |																 | if TaskStatus is complete	    | True
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
| ToDoList	| List AscendingOrder { get; set; }		   | 																 | property to view ascending list  | List
| ToDoList	| List DescendingOrder { get; set; }	   |																 | property to view descending list | List
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------