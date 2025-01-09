| Classes      | Methods/Properties              | Scenario                                               | Outputs                                  |
|--------------|---------------------------------|--------------------------------------------------------|------------------------------------------|
| ToDoList.cs  | Add(string task)                | Adds task to list                                      | --                                       |
| ToDoList.cs  | GetTasks()                      | Finds tasks                                            | List of tasks                            |
| ToDoList.cs  | ChangeStatus()                  | Updates status of task between complete and incomplete | --                                       |
| ToDoList.cs  | CompletedTasks()                | Finds all the completed tasks in todo-list             | List of completed tasks                  |
| ToDoList.cs  | IncompleteTasks()               | Finds all the incomplete tasks in todo-list            | List of incomplete tasks                 |
| ToDoList.cs  | SearchTask(string task)         | Looks through the todo-list for the given task         | Message if the task does not exist       |
| ToDoList.cs  | RemoveTask(string task)         | Removes the specified task from todo-list              | --                                       |
| ToDoList.cs  | SortAsc()                       | Sorts list in ascending order                          | Sorted list of tasks in ascending order  |
| ToDoList.cs  | SortDesc()                      | Sorts list in descending order                         | Sorted list of tasks in descending order |
| Extension.cs | AddEx(string task, int id)      | Adds task with a unique id to the list                 | --                                       |
| Extension.cs | UpdateTask(int id, string task) | Updates the task of the given id                       | --                                       |
| Extension.cs | ChangeStatusEx(int id)          | Changes status of task with the given id               | --                                       |
| Extension.cs | TimeOfTask(int id)              | Returns the time and day of the task with the given id | time and day of task                     |