## Domain Model

## Core Requirements
1: I want to add tasks to my todo list.
2: I want to see all the tasks in my todo list.
3: I want to change the status of a task between incomplete and complete.
4: I want to be able to get only the complete tasks.
5: I want to be able to get only the incomplete tasks.
6: I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
7: I want to remove tasks from my list.
8: I want to see all the tasks in my list ordered alphabetically in ascending order.
9: I want to see all the tasks in my list ordered alphabetically in descending order.


Req.  | Classes		   | Methods / Properties				 | Scenario									| Outputs	      |
------|----------------|-------------------------------------|------------------------------------------|-----------------|
1     |ToDoList.cs	   |List<Items> ToDoList				 |hold the todo items + status				| List			  |
1     |ToDoList.cs	   |`AddTask(string task)`				 |add task to todo list (default incomplete)| 				  |
2     |ToDoList.cs	   |`ViewList()`						 |see all items on todo list				| String		  |
3     |ToDoList.cs	   |`SetStatus(task, new status)`		 |update task status						|				  |
4     |ToDoList.cs	   |`GetCompletedTasks()`				 |get only completed tasks					| String		  |
5     |ToDoList.cs	   |`GetIncompleteTasks()`				 |get only incomplete tasks					| String          |
6     |ToDoList.cs	   |`SearchTask(task)`					 |return task + status OR "not found"		| String		  |
7     |ToDoList.cs	   |`RemoveTask(task)`					 |remove task								|				  |
8     |ToDoList.cs	   |`ListAscending()`					 |see tasks alphabetically ascending		| String		  |
9     |ToDoList.cs	   |`ListDescending()`					 |see tasks alphabetically descending		| String		  |


## Extension
10: I want to be able to get a task by a unique ID.
11: I want to update the name of a task by providing its ID and a new name.
12: I want to be able to change the status of a task by providing its ID.
13: I want to be able to see the date and time that I created each task.

Req.  | Classes		   | Methods / Properties				 | Scenario									| Outputs	      | Edit:						|
------|----------------|-------------------------------------|------------------------------------------|-----------------|-----------------------------|
1     |Extension.cs	   |List<Items> ToDoList				 |hold the todo items + status				| List			  | Add ID + Creation date/time |
1     |Extension.cs	   |`AddTask(string task)`				 |add task to todo list (default incomplete)| 				  | Generate + Add ID, creation	|
2     |ToDoList.cs	   |`ViewList()`						 |see all items on todo list				| String		  |								|
3     |ToDoList.cs	   |`SetStatus(task, new status)`		 |update task status						|				  |								|
4     |ToDoList.cs	   |`GetCompletedTasks()`				 |get only completed tasks					| String		  |								|
5     |ToDoList.cs	   |`GetIncompleteTasks()`				 |get only incomplete tasks					| String          |								|
6     |ToDoList.cs	   |`SearchTask(task)`					 |return task + status OR "not found"		| String		  |								|
7     |ToDoList.cs	   |`RemoveTask(task)`					 |remove task								|				  |								|
8     |ToDoList.cs	   |`ListAscending()`					 |see tasks alphabetically ascending		| String		  |								|
9     |ToDoList.cs	   |`ListDescending()`					 |see tasks alphabetically descending		| String		  |								|
Ext:--|----------------|-------------------------------------|------------------------------------------|-----------------|------------------------------
10    |Extension.cs    |`SearchbyID(string ID)`				 |get a task by its unique ID			    | String		  |New							|
11    |Extension.cs	   |`UpdateName(ID, new name)`           |update name by providing ID & new name    |				  |New							|
12    |Extension.cs	   |`IDSetStatus(ID, new status)`        |update status by providing ID & new status|				  |New							|
13    |Extension.cs    |`CreationDate(string task)`			 |get creation date/time for single task	| String		  |New							|
					   | or `CreationDate()` for all tasks   |get list of all tasks with creation info  | String		  |New							|