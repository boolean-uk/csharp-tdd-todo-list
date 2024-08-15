1. I want to add tasks to my todo list.


2. I want to see all the tasks in my todo list.


3. I want to change the status of a task between incomplete and complete.


4. I want to be able to get only the complete tasks.


5. I want to be able to get only the incomplete tasks.


6. I want to search for a task and receive a message that says it wasn't found if it doesn't exist.


7. I want to remove tasks from my list.


8. I want to see all the tasks in my list ordered alphabetically in ascending order.


9. I want to see all the tasks in my list ordered alphabetically in descending order.

| Classes     | Methods                                   | Scenario                                                        | Outputs|
|-------------|-------------------------------------------|-----------------------------------------------------------------|--------|
| `ToDoList`  | `Add(string name)`                        | Adds a task with the given name if it doesn't already exist     | true   |
|             |                                           | Don't add the task if a task with the same name already exists  | false  |
|             | `List()`                                  | List out all the tasks in the ToDo list with their status       | string |
|             | `ChangeStatus(string name, bool status)`  | Change the status of the selected task to the new status        | true   |
|             |                                           | Cannot find a task with the given name                          | false  |
|             | `ListCompleteTasks()`                     | List out all the complete tasks                                 | string |
|             | `ListIncompleteTasks()`                   | List out all the incomplete tasks                               | string |
|             | `Search(string name)`                     | Found the task user searched for                                | string |
|             |                                           | Task user seeks does not exist                                  | string |
|             | `Remove(string name)`                     | Remove selected task if it exists                               | true   |
|             |                                           | Selected task does not exist                                    | false  |
|             | `ListAscending()`                         | List out all the tasks in an alphabetically ascending order     | string |
|             | `ListDescending()`                        | List out all the tasks in an alphabetically descending order    | string |


-- Extension Tests --

1. I want to be able to get a task by a unique ID.


2. I want to update the name of a task by providing its ID and a new name.


3. I want to be able to change the status of a task by providing its ID.


4. I want to be able to see the date and time that I created each task.

| Classes              | Methods                                   | Scenario                                                                                                                  | Outputs|
|----------------------|-------------------------------------------|---------------------------------------------------------------------------------------------------------------------------|--------|
| `ToDoListExtension`  | `Add(string name)`                        | Adds a task with the given name if it doesn't already exist, but also generate a unique ID and note the time it was added | true   |
|                      |                                           | Don't add the task if a task with the same name already exists                                                            | false  |
|                      | `List()`                                  | List out all the tasks in the ToDo list with their status                                                                 | string |
|                      | `Get(int ID)`                             | Get the full task with the given ID                                                                                       | Tuple  |
|                      |                                           | If the ID does not exist, throw an error                                                                                  | error  |
|                      | `ChangeName(int ID, string newName)`      | Changes the name of a task with the given ID to the newName                                                               | true   |
|                      |                                           | If ID does not exist, it cannot change the name                                                                           | false  |
|                      | `ChangeStatus(int ID, bool status)`       | Change the status of the selected task to the new status                                                                  | true   |
|                      |                                           | Cannot find a task with the given ID                                                                                      | false  |
|                      | `ListFull()`                              | List out all tasks with their full information                                                                            | string |
|                      | `ListIncompleteTasks()`                   | List out all the incomplete tasks                                                                                         | string |
|                      | `Search(string name)`                     | Found the task user searched for                                                                                          | string |
|                      |                                           | Task user seeks does not exist                                                                                            | string |
|                      | `Remove(string name)`                     | Remove selected task if it exists                                                                                         | true   |
|                      |                                           | Selected task does not exist                                                                                              | false  |
|                      | `ListAscending()`                         | List out all the tasks in an alphabetically ascending order                                                               | string |
|                      | `ListDescending()`                        | List out all the tasks in an alphabetically descending order                                                              | string |
