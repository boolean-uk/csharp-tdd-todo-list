| Classes    | Members                                                               | Methods                                     | Scenario                                                 | Outputs             |
|------------|-----------------------------------------------------------------------|---------------------------------------------|----------------------------------------------------------|---------------------|
| `ToDoList` | `HashMap<String, bool> tasks` (key is task name, value is completion) | `addTask(String task)`                      | Task with the provided name *is not* already in the list | true                |
|            |                                                                       |                                             | Task with the provided name *is* already in the list     | false               |
|            |                                                                       |                                             |                                                          |                     |
|		     |                                                                       | `showTasks()`						       | All task are shown                      				  | HashMap<String,bool> | 
|            |                                                                       | `changeStatus()`                            | Task with the provided name *is not* completed           | true                |
|            |                                                                       |                                             | Task with the provided name *is* completed               | false               |
|            |                                                                       | `showCompletedTasks()`                      | Task with the provided name is completed                 | true                |
|            |                                                                       |                                             |                                                          |                     |
|            |                                                                       | `showInCompletedTasks()`                    | Task with the provided name *is not* completed           | true                |
|            |                                                                       |                                             | Task with the provided name *is* completed               | false               |
|            |                                                                       | `searchTasks()`                             | Task with the provided name *is not* in the list         | string              |
|            |                                                                       |                                             | Task with the provided name *is* in the list             | string              |
|            |                                                                       | `removeTasks()`                             | Task with the provided name *is not* in the list         | true                |
|            |                                                                       |                                             | Task with the provided name *is* in the list             | false               |
|            |                                                                       | `sortAlphabeticalAsc()`                     | Tasks are not sorted alphabetical ascending              | true                |
|            |                                                                       |                                             | Task are sorted alphabetical descending			      | false               |
|            |                                                                       | `sortAlphabeticalDesc()`                    | Tasks are not sorted alphabetical descending             | true                |
|            |                                                                       |                                             | Task are sorted alphabetical descending				  | false               |

EXTENSION class

| Classes    | Members                                                                                   | Methods                                     | Scenario                                                 | Outputs             |
|------------|-------------------------------------------------------------------------------------------|---------------------------------------------|----------------------------------------------------------|---------------------|
| `ToDoList` | `HashMap<int, String, bool> tasks` (int is the ID, key is task name, value is completion) | `getTask(int Id)`                           | Task with the provided id *is not* already in the list   | true                |
|            |                                                                                           |                                             | Task with the provided id *is* already in the list       | false               |
|            |                                                                                           |                                             |                                                          |                     |
|            |                                                                                           |                                             |                                                          |                     |



