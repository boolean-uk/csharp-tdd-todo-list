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

-I want to be able to get a task by a unique ID.

-I want to update the name of a task by providing its ID and a new name.

-I want to be able to change the status of a task by providing its ID.

-I want to be able to see the date and time that I created each task.



| Classes         | Methods/Properties                                 | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------
|ToDoList.cs	  |AddTask(string task)                               |add task to task list            |an extra task in the task list
|ToDoList.cs	  |ShowList()                                      |shows all tasks in list          |presentation of all the tasks in the list
|ToDoList.cs	  |changeStatus(string task)                           |change to(complete/incomplete)   |
|ToDoList.cs	  |GetCompletedTasks()									   |finds complete tasks              complete tasks 
|ToDoList.cs	  |GetIncompletedTasks()									   |finds incomplete tasks           |incomplete tasks 
|ToDoList.cs	  |SearchTask(string task)			       			   |checks if task exists            |message if it does not exist
|ToDoList.cs	  |RemoveTask(string task)							   |removes a given task             |
|ToDoList.cs	  |SortAlphabeticalAscendingO()									   |orders alphabetically(ascending) |tasks in ascending alphabetical order
|ToDoList.cs	  |SortAlphabeticalDescendingO()								   |orders alphabetically(descending)|tasks in descending alphabetical order
|ToDoListExtension.cs	  |GetTaskById(int id)							   |returns a task by giving an id           |
|ToDoListExtension.cs	  |UpdateName(int id, string name)									   |changes name of the task with the given id |
|ToDoListExtension.cs	  |UpdateStatusById(int id)								   |updates status on the task with the given id|
