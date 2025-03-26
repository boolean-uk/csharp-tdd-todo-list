Domain model - ToDo List

User stories:
I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.

|class		 |	Method						|	Scenario						 | output
----------------------------------------------------------
|Todo		 | addTaskToToDo(string task)	 |  adds string to list				 | 
			 | changeTaskStatus(string, bool)|find string - change bool			 | bool 
			 | getListToDo()				 |									 | return list of tasks	
			 | getIncomplete()				 |	extract from list by status false| List of incomplete tasks
			 | getCompleted()				 |  extract from list by status true | List of completed tasks
			 | findTask()					 | if exists						 | bool true, string "You have the task in your list"
			 |								 | if (does not exist)				 | bool false , string "The requested task wasn't found in your list"
			 | removeTask(string)			 | if exist - remove from list		 | New List
			 | getListAscending()			 | Get total list - sort Ascending	 | list 
			 | getListDescending()			 | Get total list - sort Descending	 | list 

			
Extensions:

I want to be able to get a task by a unique ID.
I want to update the name of a task by providing its ID and a new name.
I want to be able to change the status of a task by providing its ID.
I want to be able to see the date and time that I created each task.

|class		 |	Method						|	Scenario										| output
----------------------------------------------------------
|Todo		 |AddTaskExtended(string)		| Tuple<int,string, bool, string>(id,name,status,date&Time) | bool false , string "The requested task wasn't found in your list"
			 |getTaskById(int id)			| look in list for ID								| string[] (id, name, timestamp, compeletionstatus)
			 | changeTaskName(int id, string name)|find id, change task name to name			| return Tuple 
			 | changeTaskStatus(int id)		|	find task in list, change bool					| return tuple
			 | getTimeAndDate(int id)		|	find task, get Date and Time					| string Date and time
			