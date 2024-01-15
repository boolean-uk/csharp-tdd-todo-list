

I want to add tasks to my todo list.

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `ToDoList`	  | `Add(string task)`							|  N/A					 | void    |
|                 |                                             |						 |		   |

I want to see all the tasks in my todo list.

| Classes         | Methods                                     | Scenario               | Outputs		   |
|-----------------|---------------------------------------------|------------------------|-----------------|
| `ToDoList`	  | `ShowList()`								|  List is not empty	 | print		   |
|                 |                                             |  List is empty		 | "list is empty" |

I want to change the status of a task between incomplete and complete.

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `ToDoList`	  | `SetStatus(string task)`					|  bool is false		 | true    |
|                 |                                             |  bool is true			 | true	   |
|				  |											    |  object does not exist | false   |

I want to be able to get only the complete tasks.

| Classes         | Methods                                     | Scenario						| Outputs			  |
|-----------------|---------------------------------------------|-------------------------------|---------------------|
| `ToDoList`	  | `ShowComplete()`							|  list has completed tasks	    | string			  |
|                 |                                             |  list has no completed tasks	| "no completed tasks |

I want to be able to get only the incomplete tasks.

| Classes         | Methods                                     | Scenario                         | Outputs    |
|-----------------|---------------------------------------------|----------------------------------|------------|
| `ToDoList`	  | `ShowIncomplete()`							| list has uncompleted tasks	   | list       |
|                 |                                             | list has no uncompleted tasks	   | empty list |

I want to search for a task and receive a message that says it wasn't found if it doesn't exist.

| Classes         | Methods                                     | Scenario                         | Outputs             |
|-----------------|---------------------------------------------|----------------------------------|---------------------|
| `ToDoList`	  | `Search(string task)`						| list has Task	                   | string task name    |
|                 |                                             | list does not have task	       | "Task wasn't found" |

I want to remove tasks from my list.

| Classes         | Methods                                     | Scenario                         | Outputs		|
|-----------------|---------------------------------------------|----------------------------------|----------------|
| `ToDoList`	  | `Remove(string task)`						| Task is in list				   | rmoved item	|
|                 |                                             | Task is not in list			   | "error message"|

I want to see all the tasks in my list ordered alphabetically in ascending order.

| Classes         | Methods                                     | Scenario                         | Outputs    |
|-----------------|---------------------------------------------|----------------------------------|------------|
| `ToDoList`	  | `ShowAlphabeticalList()`					| list is not empty				   | list       |
|                 |                                             | list is empty					   | empty list |

I want to see all the tasks in my list ordered alphabetically in descending order.

| Classes         | Methods                                     | Scenario                         | Outputs    |
|-----------------|---------------------------------------------|----------------------------------|------------|
| `ToDoList`	  | `ShowAlphabeticalDecendingList()`			| list is not empty				   | list       |
|                 |                                             | list is empty					   | empty list |







### EXTENSIONS

I want to be able to get a task by a unique ID.
| Classes         | Methods                                     | Scenario                         | Outputs    |
|-----------------|---------------------------------------------|----------------------------------|------------|
| `ToDoList`	  | `FindTaskByID(int id)`						| 			   | list       |
|                 |                                             | list is empty					   | empty list |

I want to update the name of a task by providing its ID and a new name.
I want to be able to change the status of a task by providing its ID.
I want to be able to see the date and time that I created each task.