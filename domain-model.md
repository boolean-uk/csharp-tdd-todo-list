## Calculator Project

# User Stories



-I want to add tasks to my todo list.

-I want to see all the tasks in my todo list.

-I want to change the status of a task between incomplete and complete.

-I want to be able to get only the complete tasks.

-I want to be able to get only the incomplete tasks.

-I want to search for a task and receive a message that says it wasn't found if it doesn't exist.

-I want to remove tasks from my list.

-I want to see all the tasks in my list ordered alphabetically in ascending order.

-I want to see all the tasks in my list ordered alphabetically in descending order.



| Classes         | Methods/Properties                                 | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------
|ToDoList.cs	  |AddTasks(string task)                               |add task to task list            |an extra task in the task list
|ToDoList.cs	  |ShowALLTasks()                                      |shows all tasks in list          |presentation of all the tasks in the list
|ToDoList.cs	  |changeStatus(string task)                           |change to(complete/incomplete)   |
|ToDoList.cs	  |findComplete()									   |finds complete tasks              complete tasks 
|ToDoList.cs	  |findIncomplete()									   |finds incomplete tasks           |incomplete tasks 
|ToDoList.cs	  |findIncomplete()									   |finds incomplete tasks           |incomplete tasks 
|ToDoList.cs	  |searchTask(string task)			       			   |checks if task exists            |message if it does not exist
|ToDoList.cs	  |removetask(string task)							   |removes a given task             |
|ToDoList.cs	  |ascendingOrder()									   |orders alphabetically(ascending) |tasks in ascending alphabetical order
|ToDoList.cs	  |descendingOrder()								   |orders alphabetically(descending)|tasks in descending alphabetical order
