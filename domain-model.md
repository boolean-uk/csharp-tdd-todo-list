# Domain Model

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


| Classes			| Methods/Properties			| Scenario		| Outputs	|
|-------------------|-------------------------------|---------------|-----------|
|ToDoList.cs		|AddTask(Task t)				|adds task t to the todolist	|void |
|ToDoList.cs		|GetAllTasks()					|fetches out all tasks			|List<TaskItem> |
|TaskItem.cs		|ChangeStatus()					|flips boolean value of StatusComplete	|void |
|ToDoList.cs		|GetAllCompleteTasks()			|fetches all tasks where statusComplete == true|List<TaskItem> |
|ToDoList.cs		|GetAllIncompleteTasks()		|fetches all tasks where statusComplete == false|List<TaskItem> |
|ToDoList.cs		|DoesTaskExist(Task t)			|Checks if a given task exists in toDoList|bool |
|ToDoList.cs		|RemoveTask(Task t)				|Removes a given TaskItem from todoList.|void |
|ToDoList.cs		|GetAllTasksInOrder()			|fetches all tasks in alphabetical order |List<TaskItem> |
|ToDoList.cs		|GetAllTasksInReverseOrder()			|fetches all tasks in reverse alphabetical order |List<TaskItem> |
|ToDoList.cs		|GetTasksSortedByPriority()			|fetches all tasks in order by priority |List<TaskItem> |



## Extension tests

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