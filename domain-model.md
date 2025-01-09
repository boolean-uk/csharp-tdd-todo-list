# Todo 


## Domain Model

### Core

| Classes         | Methods/Properties                                 | Scenario                                 | Outputs          |
|-----------------|----------------------------------------------------|------------------------------------------|------------------
|ToDoList.cs      |AddTask(string task)                                |add tasks to todo list                    |
|ToDoList.cs      |ToDoList as a dictionary of Tasks, ViewTodoList()   |store and view all tasks in todo list     |Prints out the task names in console
|ToDoList.cs      |UpdateTaskStatus(int taskId, bool status), status property of a Task  |update the status of a task |
|ToDoList.cs      |RemoveTask(int taskId)							   |remove task                               |
|ToDoList.cs      |GetCompletedTasks()                                 |get complete tasks                        |a new TodoList with only completed Tasks
|ToDoList.cs      |GetIncompletedTasks()                               |get incomplete tasks                      |a new TodoList with only incomplete Tasks
|ToDoList.cs      |SearchTaskById(int taskId)                          |search task, receive message if not found |the searched task or "Task not found" message	
|ToDoList.cs	  |OrderByAscending()								   |order alphabetically in ascending order	  |a new TodoList in alphabetical ASC order
|ToDoList.cs	  |OrderByDescending()                                 |order alphabetically in descending order  |a new TodoList in alphabetical DESC order



### Extension

| Classes         | Methods/Properties                                 | Scenario                                 | Outputs          |
|-----------------|----------------------------------------------------|------------------------------------------|------------------
|Extension.cs	  |GetTaskById(int id)                              |get task by id							      |the searched task or "Task not found" message	 
|Extension.cs	  |UpdateTask(int id, string name)                     |update a task name
|Extension.cs     |UpdateStatus(int id, bool status)                   |update the status of a task by id
|Extension.cs	  |created Property to view created date time          |view date time a task was created