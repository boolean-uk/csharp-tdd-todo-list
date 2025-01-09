# Todo 


## Domain Model

### Core

| Classes         | Methods/Properties                                 | Scenario                                 | Outputs          |
|-----------------|----------------------------------------------------|------------------------------------------|------------------
|ToDoList.cs      |AddTask(string task)                                |add tasks to todo list                    |
|ToDoList.cs      |ToDoList as a dictionary of Tasks, ViewTasks()      |store and view all tasks in todo list      |
|ToDoList.cs      |UpdateTaskStatus(int taskId, bool status), status property of a Task  |update the status of a task
|ToDoList.cs      |RemoveTask(int taskId)							   |remove task                               |
|ToDoList.cs      |GetCompleteTasks()                                  |get complete tasks                        |
|ToDoList.cs      |GetIncompleteTasks()                                |get incomplete tasks                      |
|ToDoList.cs      |SearchById(int taskId)                                  |search task, receive message if not found |
|ToDoList.cs	  |OrderByAscending()									   |order alphabetically in ascending order	  |
|ToDoList.cs	  |OrderByDescending()                                   |order alphabetically in descending order  | 



### Extension

| Classes         | Methods/Properties                                 | Scenario                                 | Outputs          |
|-----------------|----------------------------------------------------|------------------------------------------|------------------
|Extension.cs	  |GetTaskById(int id)
|Extension.cs	  |UpdateTask(int id, string name)
|Extension.cs     |UpdateStatus(int id, bool status)
|Extension.cs	  |created Property to view created date time