#Domain Models In Here

Domain Model
| Classes         | Methods                          | Scenario                                | Outputs                                               |
|-----------------|----------------------------------|-----------------------------------------|-------------------------------------------------------|
| `TodoList`	  | `add(string name)`               | if key is not in List                   | adds object to todoList and returns true              |
|                 |                                  | if key is in dict                       | does not add object to todolist and returns false     |
|                 | `listTasks()`                    | if method is called                     | either prints or returns the todoList                 |
|                 | `taskStatus(int id)`             | if id is in object list                 | switches status from true to false or vice versa, return bool  |
|                 | `fetchTasks(bool complete)`      | if complete is true                     | returns or prints todoList with only complete tasks   |
|                 |                                  | if complete is false                    | returns or prints todoList with only incomplete tasks |
|                 | `searchTask(int id)`             | if task in todolist                     | returns task object                                   |
|                 |                                  | if task not in todolist                 | returns null                                          |
|                 | `remove(int id)`                 | if task in todolist                     | returns task object                                   |
|                 |                                  | if task not in todolist                 | returns null                                          |
|                 | `listTasksSort(bool descending)` | if bool true                            | lists todolist descending                             |
|                 |                                  | if bool false                           | list todolist ascending                               |
