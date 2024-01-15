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
|`ToDoList`| `Add(string task)`                           | add task to todo list           | bool             |
|`ToDoList`| `AllTasks()`                                 | list all tasks in todo list     | bool             |
|`ToDoList`| `changeStatus(string task, string completed)`| toggle task complete status     | bool             |
|`ToDoList`| `GetComplete()`                              | list completed tasks            | bool             |
|`ToDoList`| `GetIncomplete()`                            | list incomplete tasks           | bool             |
|`ToDoList`| `Find(string task)`                          | search if task exists with message | string           |
|`ToDoList`| `Remove(string task)`                        | remove task from todo list      | bool             |
|`ToDoList`| `AllTasksAsc()`                              | list all tasks in todo list ascending | bool             |
|`ToDoList`| `AllTasksDsc()`                              | list all tasks in todo list descending | bool             |