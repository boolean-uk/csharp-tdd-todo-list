* I want to add tasks to my todo list.
* I want to see all the tasks in my todo list.
* I want to change the status of a task between incomplete and complete.
* I want to be able to get only the complete tasks.
* I want to be able to get only the incomplete tasks.
* I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
* I want to remove tasks from my list.
* I want to see all the tasks in my list ordered alphabetically in ascending order.
* I want to see all the tasks in my list ordered alphabetically in descending order.

| Class | properties |
|---|---|
| TodoList | `Dictionary<string, bool> Task` |


| Class | Method | Scenario | Output |
|---|---|---|---|
| TodoList | `Add(string)` | | `void` |
| TodoList | `Display()` | | `void` |
| TodoList | `Display(bool)`  | | `void` |
| TodoList | `DisplayAcending()`  | | `void` |
| TodoList | `DisplayAcending(bool)`  | | `void` |
| TodoList | `DisplayDecending()`  | | `void` |
| TodoList | `DisplayDecending(bool)`  | | `void` |
| TodoList | `Complete(string)` | | `void` |
| TodoList | `Search(string)` | String matches a item | `void` |
| TodoList | `Search(string)` | String does not match a item | `void` |
| TodoList | `Remove(string)` | String matches a item | `void` |
| TodoList | `Remove(string)` | String does not match a item | `void` |

