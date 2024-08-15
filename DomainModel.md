#Domain Models




| Classes              | Methods                                                  | Scenario                                  | Outputs |
|----------------------|----------------------------------------------------------|-------------------------------------------|---------|
| `Core`			   | `AddTaskToList(string text)`                             | add new tasks to my todo list.            | adds object to list   |
|                      | ` getIndividualTasks(string search)`				      | Enter string matching strig in object     | returns object    |
|                      | ` ChangeObjStatus(TodoTaskObj obj)`                      | call func on an object where status = false  | changes status to true  |
|                      | `public void ChangeObjStatus(TodoTaskObj obj, bool b)`   | set object status to true                 | tests status to true, even if previously true    |
|                      | ` public List<TodoTaskObj> getSomeTasks(bool b)`         | send True as imput                        | returns tasks where status is true    |

|                      | `public List<TodoTaskObj> getOrderedTasks()`         | set new size to 10                        | void    |
|                      | `removeTask()`                       | set new size to 10                        | void    |