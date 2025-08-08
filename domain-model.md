| Classes         | Methods/Properties                                 | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------|
|ToDoList.cs		|Add(string task)									| add task						| bool	|
|ToDoList.cs		|SeeAllTasks()										| tasks to show					|List<Task>|
|Task.cs			|ChangeStatus(string task)										| change status					|bool	|
|ToDoList.cs		|CompleteTasks()									| See completed tasks			|List<Task>|
|ToDoList.cs		|IncompleteTasks()									| See incompleted tasks			|List<Task>|
|ToDoList.cs		|Search(string task)								| Searching for a task			|bool|
|ToDoList.cs		|Remove(string task)								| remove task					| bool	|
|ToDoList.cs		|OrderAlhabetA()									| order alphabetically in ascending order		| List<Task>	|
|ToDoList.cs		|OrderAlhabetD()									| order alphabetically in descending order		| List<Task>	|
|Task.cs			|Prioritise()										| Prioritise tasks								| List<Task>	|
|ToDoList.cs		|SeePriority()										| See all tasks by priority						| List<Task>	|






## Core Requirements

- I want to add tasks to my todo list.
- I want to see all the tasks in my todo list.
- I want to change the status of a task between incomplete and complete.
- I want to be able to get only the complete tasks.
- I want to be able to get only the incomplete tasks.
- I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
- I want to remove tasks from my list.
- I want to see all the tasks in my list ordered alphabetically in ascending order.
- I want to see all the tasks in my list ordered alphabetically in descending order.
- I want to prioritise tasks e.g. low, medium, high
- I want to list all tasks by priority

| Classes         | Methods/Properties                                 | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------|
|Task.cs			|Get(string id)										| find a task by ID							| Task	|
|Task.cs			|UpdateName(string id, string newName) 				| change name by ID 						|bool|
|Task.cs			|ChangeStatus(string id)							| change status	by ID						|bool	|
|Task.cs			|Created()											| See when task is created 					|Date and time|
|Task.cs			|Completed()										| See when task is completed				|Date and time|
|ToDoList.cs		|Longest()											| See which task who took the longest time	|Task|
|ToDoList.cs		|Shortest()											| See which task who took the shortest time	| Task	|
|ToDoList.cs		|LongerThanFive()									| See which task took longer than 5 days	| List<Task>	|
|Task.cs			|Categorise()										| Categorise tasks							| List<Task>	|
|Task.cs			|Category()											| See all tasks by category					| List<Task>	|






- ## Extension Requirements

- I want to be able to get a task by a unique ID.
- I want to update the name of a task by providing its ID and a new name.
- I want to be able to change the status of a task by providing its ID.
- I want to be able to see the date and time that I created each task.
- I want to be able to see the date and time that I completed a task.
- I want to know which task took the longest amount of time to complete.
- I want to know which task took the shortest amount of time to complete.
- I want to know which tasks took longer than 5 days to complete.
- I want to categorise tasks e.g. study, work, admin etc
- I want to list all tasks by category

