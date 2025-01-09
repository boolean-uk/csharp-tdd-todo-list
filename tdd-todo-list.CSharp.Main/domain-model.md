| Class        | Method                                        | Scenario                              | Output                                                                       |
|--------------|-----------------------------------------------|---------------------------------------|------------------------------------------------------------------------------|
| ToDoList.cs  | CreateList(string Title, string Description)  | A user wants to create a new list     | "TodoList created: " + UUID                                                  |
| ToDoList.cs  | AddTask(string Title, string Description)     | A user wants to add a task to a list  | "Task added: " + UUID                                                        |
| ToDoList.cs  | ReadList()                                    | A user wants to view their list       | List info and all tasks and info                                             |
| ToDoList.cs  | UpdateTaskStatus(string UUID, bool Completed) | Mark a task as complete/incomplete    | Changes the status to the given bool of the task with the given UUID         |
| ToDoList.cs  | GetTasksWithStatus(bool Completed)            | Get all completed tasks               | Returns all TodoTasks with Completed set to true                             |
| ToDoList.cs  | GetTasksWithStatus(bool Completed)            | Get all incomplete tasks              | Returns all TodoTasks with Completed set to false                            |
| ToDoList.cs  | GetTask(string UUID)                          | Find a specific task by UUID          | Gets the task with the given UUID. Prints out "Task not found!" if not found |
| ToDoList.cs  | DeleteTask(string UUID)                       | A user wants to delete a task         | Deletes the task with the given UUID                                         |
| ToDoList.cs  | GetSortedTasks(string sort = "alfasc")        | Get tasks sorted alphabetically ASC   | Returns tasks sorted in (alf)abetical (asc)ending order                      |
| ToDoList.cs  | GetSortedTasks(string sort = "alfdec")        | Get tasks sorted alphabetically DESC  | Returns tasks sorted in (alf)abetical (dec)ending order                      |
| Extension.cs | UpdateTaskTitle(string UUID, string newTitle) | A user wants to rename a task         | Changes the title of the task with given UUID to the given newTitle          |
