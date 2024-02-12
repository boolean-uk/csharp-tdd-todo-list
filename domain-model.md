I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.
| Classes  | Methods                                      | Scenario                        | Outputs          |
|----------|----------------------------------------------|---------------------------------|------------------|
|`ToDoList`| `Add(string task, string completed)`         | add task to todo list           | Dictionary myList |
|`ToDoList`| `AllTasks()`                                 | list all tasks in todo list     | Dictionary myList |
|`ToDoList`| `changeStatus(string task, string completed)`| toggle task complete status     | bool             |
|`ToDoList`| `GetComplete()`                              | list completed tasks            | List<string>     |
|`ToDoList`| `GetIncomplete()`                            | list incomplete tasks           | List<string>     |
|`ToDoList`| `Find(string task)`                          | search if task exists with message | bool          |
|`ToDoList`| `Remove(string task)`                        | remove task from todo list      | bool             |
|`ToDoList`| `AllTasksAsc(Dictionary myList)`             | list all tasks in todo list ascending | Dictionary listAsc |
|`ToDoList`| `AllTasksDsc(Dictionary myList)`             | list all tasks in todo list descending | Dictionary listDsc |

Extension
| Classes           | Methods                               | Scenario                                    | Outputs          |
|-------------------|---------------------------------------|---------------------------------------------|------------------|
|`ToDoList` `Task`  | `FindById(int id)`                    | find a task by it's unique Id               | bool             |
|`ToDoList` `Task`  | `updateTaskName(int id, string name)` | update name of task by id and provided name | Task             |
|`ToDoList` `Task`  | `changeStatus(int id)`                | toggle task completion by Id                | bool             |
|`ToDoList` `Task`  | `Created(Task task)`                  | find DateTime of when Task was created      | DateTime         |