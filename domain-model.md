# Domain model

## User Stories

### Core

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

|Classes|Methods/Properties|Scenario|Output|
|-------|------------------|--------|------|
| ToDoList.cs | Add(ToDoTask task) | Add task to todo list |  | 
| ToDoList.cs | GetTasks() | Get all tasks from todo list | List of all todo tasks |
| ToDoList.cs | PrintTasks() | Print all tasks from todo list | Print of all todo tasks |
| ToDoList.cs | GetCompleteTasks() | Get all complete todo tasks | List of all complete tasks | 
| ToDoList.cs | GetIncompleteTasks() | Get all incomplete todo tasks | List of all incomplete tasks | 
| ToDoList.cs | SearchForTask(ToDoTask? ) | Search for task | Returns null if it doesn't exist, returns the tasks otherwise | 
| ToDoList.cs | RemoveTask(ToDoTask task) | Remove task from todo list |  | 
| ToDoList.cs | OrderList(bool ascending = true) | Orders the todo list | returns the todo list ordered. (returns ascending or decending dependent on boolean value | 
| ToDoList.cs | PrioritiseTask(int taskid, string priority) | Sets what priority the task has |  | 
| ToDoList.cs | GetTasksByPriority(string priority) | Get all tasks from todo liost with given priority | returns all tasks by priorioty | 



### Extension

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

|Classes|Methods/Properties|Scenario|Output|
|-------|------------------|--------|------|
| Extension.cs | GetByID(int id)  | Get task by ID | returns task given the ID | 
| Extension.cs | UpdateName(int id, string name) | Update name given an ID and a new name |  | 
| ToDoList.cs | DateTime CreatedDate | Property for saving created date |  |
| ToDoList.cs | DateTime CompletedDate | Property for saving completed date |  |
| Extension.cs | SeeCreatedDate(int id) | Get date of task | returns the date when the task was created | 
| Extension.cs | CompleteTask(int id, DateTime date) | Completes task given an id | Returns difference of CompletedDate and CreatedDate |
| Extension.cs | SeeCompletedDate(int id) | Get completed date of task | returns the date of when the tasl was completed | 
| Extension.cs | GetCompleteLength(int id) | Get how long it took to complete task |  |
| Extension.cs | GetLongestCompletedTask() | Get task that was completed the slowest | Returns a task object |
| Extension.cs | GetShortestCompletedTask() | Get task that was completed the fastest | Returns a task object |
| Extension.cs | GetTasksOver5Days() | Get all tasks that took longer than 5 days to complete | Returns a list of task objects |
| ToDoList.cs | String Category | Property for category of task |  |
| Extension.cs | ListByCategory(string category) | Get all tasks given a category | Returns a list of task objects | 