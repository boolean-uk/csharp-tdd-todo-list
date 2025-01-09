1. I want to add tasks to my todo list.
2. I want to see all the tasks in my todo list.
3. I want to change the status of a task between incomplete and complete.
4. I want to be able to get only the complete tasks.
5. I want to be able to get only the incomplete tasks.
6. I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
7. I want to remove tasks from my list.
8. I want to see all the tasks in my list ordered alphabetically in ascending order.
9. I want to see all the tasks in my list ordered alphabetically in descending order.

| Class		| Members											| Methods											| Scenario						    | Output
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
| ToDoList  | Dictionary<string, string> ToDoList				| AddTask(string task)								| if task is not already in list    | True
| ToDoList  |													|													| if task is already in list	    | False
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
| ToDoList	|													| SearchList(string task)							| if task is not in list		    | string SearchMessage
| ToDoList	|													|													| if task is in list			    | string SearchMessage
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
| ToDoList	| 													| RemoveTask(string task)							| if task exist						| True
| ToDoList	| 													|													| if task does not exist		    | False
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
| ToDoList	|													| ChangeTaskStatus(string task, string taskStatus)	| if task is not in list 			| string
| ToDoList	|													|													| if if task is in list				| set taskStatus
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
| ToDoList  | Dictionary ViewToDoList { get; set; }			    |													| property to view ToDoList			| Dictionary ToDoList
| ToDoList  | Dictionary ViewCompleteTasksList { get; set	}	|													| property to view complete tasks   | Dictionary 
| ToDoList  | Dictionary ViewIncompleteTasksList { get; set; }	|													| property to view incomplete tasks | Dictionary
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
| ToDoList	| Dictionary AscendingList { get; set; }		    | 													| property to view ascending list   | Dictionary
| ToDoList	| Dictionary DescendingList { get; set; }			|													| property to view descending list  | Dictionary
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------