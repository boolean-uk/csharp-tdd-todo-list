#Domain Models In Here

I want to add tasks to my todo list.
	```As a user I want to add tasks to my TODO list so I can create a TODO list```
	-Verb and functionality: add task

I want to see all the tasks in my todo list.
	```As a user I want an overview of all the task in the TODO list so I can easier track what I need to do```
	-Verb and functionality: view all

I want to change the status of a task between incomplete and complete.
	```As a user I want to change the status of the task between incomplete and complete so I can manage the list```
	-Verb and functionality: set status

I want to be able to get only the complete tasks.
	```As a user I want to see a list of the complete tasks I've done so I can get a sense of accomplishment```
	-Verb and functionality: view complete tasks

I want to be able to get only the incomplete tasks.
	```As a user I want to see a list of the incomplete tasks so I can easier see what I need to do```
	-Verb and functionality: view incomplete tasks

I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
	```As a user I want to search for a task and receive a message if it is found or not so I can easier navigate my TODO list```
	-Verb and functionality: search

I want to remove tasks from my list.
	```As a user I want to remove tasks from the list in case the task is not needed to be done```
	-Verb and functionality: remove task

I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.
	```As a user I want to see the tasks in my lists ordered alphabetically and have the option of both ways because I am a humourless German and "Ordnung muss sein".```
	-Verb and functionality: view alphabetically

Extension

I want to be able to get a task by a unique ID.
	-Verb and functionality: get task

I want to update the name of a task by providing its ID and a new name.
	-Verb and functionality: update name

I want to be able to change the status of a task by providing its ID.
	-Verb and functionality: change status

I want to be able to see the date and time that I created each task.
	-Verb and functionality: view creationTime



| Classes         | Methods                                        | Scenario                          | Outputs |
|-----------------|------------------------------------------------|-----------------------------------|--------------|
| `ToDoList`	  | `addTask(string task)`	    				   | If task was added	               | true         |
|                 |                                                | If task was not added	           | false        |
| 				  | `viewAll()`	    							   | Number of tasks are returned      | Dictionary   |
| 				  | `setStatus(string task)`	    			   | If task status was changed        | true         |
|                 |                                                | If task status wasn't changed	   | false        |
| 				  | `viewCompletedTasks()`	    				   | Number of comp-tasks are returned | Dictionary   |
| 				  | `viewRemainingTasks()`	    				   | Number of rema-tasks are returned | Dictionary   |
| 				  | `searchTask(string task)`	    			   | task is found          	       | true         |
|                 |                                                | task isn't found       	       | false        |
| 				  | `removeTask(string task)`	    			   | If task status was removed        | true         |
|                 |                                                | If task status wasn't removed	   | false        |
| 				  | `viewAlphabetically()`	    			       | Starting letters must match       | Dictionary   |
| 				  | `viewAlphabeticallyDescending()`	    	   | Starting letters must match       | Dictionary   |
|-----------------|------------------------------------------------|-----------------------------------|--------------|
|     EXTENSION  EXTENSION  EXTENSION  EXTENSION  EXTENSION  EXTENSION  EXTENSION  EXTENSION  EXTENSION  EXTENSION    |
|-----------------|------------------------------------------------|-----------------------------------|--------------|
| Classes         | Methods                                        | Scenario                          | Outputs	  |
|-----------------|------------------------------------------------|-----------------------------------|--------------|
| `ToDoList`	  | `getTaskByID(int id)`	    				   | If task exists					   | Class        |
| 				  |                                                | If task doesn't exist             | Class(empty?)|
| 				  | `updateName(int id, string newName)`           |                                   | string       |
| 				  | `setStatusByID(int id)`	    				   | If task status was changed        | true         |
|                 |                                                | If task status wasn't changed	   | false        |
| 				  | `getCreationTime(int id)`	    			   |						           | DateTime     |