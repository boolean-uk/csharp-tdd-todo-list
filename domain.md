# Domain model

| Classes     | Methods/Properties | Scenario | Output |
|-------------|--------------------|----------|--------|
| TodoList    | Add(Task)          | Add a task to the list, doesn't allow duplicate titles, returns true if added, oterwise false | bool | 
| TodoList    | Remove(string)          | Remove a task with the given title returns true if deleted, false otherwise | bool | 
| TodoList    | GetTasks()          | Get all tasks in the list | List<TodoTask> | 
| TodoList    | ToggleComplete(string)          | Toggle completed state of the given task | | 
| TodoList    | Search(string)          | Return a task with the given title, or null if not found | TodoTask? |
| TodoList    | GetCompleted()          | Gets all completed tasks | List<TodoTask> |
| TodoList    | GetIncomplete()          | Gets all incompleted tasks | List<TodoTask> |
| TodoList    | GetOrderedTasks(ascending: bool)          | Gets all tasks ordered either ascending or descending | List<TodoTask> |
| TodoTask    | Title: string | Title of the task| |
| TodoTask    | Completed: bool | bool describing if the task is completed | |
| TodoTask    | ToggleComplete() | Toggles the complete state of the task| |


# Extension domain model

| Classes     | Methods/Properties | Scenario | Output |
|-------------|--------------------|----------|--------|
| ETodoList   | Get(string taskId) | returns a task from taskId, null if it doesn't exist | ETodoTask? |
| ETodoList   | ChangeName(string taskId, string newName) | Changes the name of a task with the given id if it exists |  |
| ETodoList   | ToggleComplete(string taskId) | Toggles if the task with the given id is completed |  |
| ETodoList   | GetDate(string taskId) | Returns the date the task was created| DateTime? |
| ETask    | Title: string | Title of the task| |
| ETask    | Completed: bool | bool describing if the task is completed | |
| ETask    | createdDate: DateTime | A datetime of when the task was created | |
