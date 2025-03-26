| Classes  | Methods               | Scenario                                          | Outputs      |
|----------|-----------------------|---------------------------------------------------|--------------|
| ToDoList | `Add(string task)`            | Adds a task to do the lodo-list                   | void         |
|          | `Tasks()`                     | Returns all tasks                                 | List<string> |
|          | `Toggle(string task)`         | Toggles the task between finished and incomplete  | void         |
|          | `GetCompleted()`              | Returns the completed tasks                       | List<string> |
|          | `GetUncompleted()`            | Returns the uncompleted tasks                     | List<string> |
|          | `Search(string task)`         | Returns whether the tasks exists or not           | Boolean      |
|          | `Remove(string task)`         | Removes a string from the todo-list               | void         |
|          | `AscendingList()`             | Returns the list in alphabetical ascending order  | List<string> |
|          | `DescendingList()`            | Returns the list in alphabetical descending order | List<string> |
|          | `Get(int id)`                 | Returns task given an ID                          | string       |
|          | `Update(int id, string task)` | Updates the task name of a task		           | void         |
|          | `Toggle(int id)`              | Toggles the task of given ID                      | void         |
|          | `Origins()`                   | Returns date and time of when tasks were created  | List<string> |