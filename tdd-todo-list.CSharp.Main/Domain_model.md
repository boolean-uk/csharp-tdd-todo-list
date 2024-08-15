X - I want to add tasks to my todo list. 
X - I want to see all the tasks in my todo list.
X - I want to change the status of a task between incomplete and complete
X - I want to be able to get only the complete tasks.
X - I want to be able to get only the incomplete tasks.
X - I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
X - I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.




| Classes        | Members                                                            | Methods                          | Scenario                                                       | Outputs       |
|----------------|--------------------------------------------------------------------|----------------------------------|----------------------------------------------------------------|---------------|
| `ToDoList`     |`Dictionary<String, int>` (string is task name, int is status (0,1))| `add(String task)`               | Task with the provided name *is not* already in the basket     | true          |
|                |                                                                    |                                  | Task with the provided name *is* already in the basket         | false         |
|                |                                                                    |                                  |                                                                |               |
|                |                                                                    | `GetAllTasks( )`                 | Returns List of all tasks. return empty if no task(?)          | List<string>  |
|                |                                                                    |                                  |                                                                |               |
|                |                                                                    | `ChangeStatus(string task)`      | If status changes (0 to 1 or 1 to 0)                           | true          |
|                |                                                                    |                                  | If status  does not change (0 to 0 or 1 to 1 or invalid)       | false         |
|                |                                                                    |                                  |                                                                |               |
|                |                                                                    |                                  |                                                                |               |
|                |                                                                    | `GetIncompleteTask()`  prop?     | Return List of incomplete tasks                                | List<string>  |
|                |                                                                    |                                  |                                                                |               |
|                |                                                                    | `Remove(string task)`            | if task exist   -> remove                                      | true          |
|                |                                                                    |                                  | else                                                           | false         |
|                |                                                                    |                                  |                                                                |               |
|                |                                                                    | `Search(string task)`            | if Task exists                                                 | true          |
|                |                                                                    |                                  |                                                                |               |
|                |                                                                    | `SortAscending()`                |                                                                | void          |
|                |                                                                    | `SortDscending()`                |                                                                | void          |
                                                                                                                                                                                                          