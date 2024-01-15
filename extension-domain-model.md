
| Classes             | Members                                          | Methods                         | Scenario                                       | Outputs     |
|---------------------|--------------------------------------------------|---------------------------------|------------------------------------------------|-------------|
| `TodoListExtension` | `List<Tasks> _toDoList` (Tasks is its own class) | `idTask(int)`                   | Task with the provided ID *is not* on the list | false       |
|                     |                                                  |                                 | Task with the provided ID *is* on the list     | true        |
|                     |                                                  | `updateNameByID(int, string)`   | Task with the provided ID *is not* on the list | false       |                       
|                     |                                                  |                                 | Task with the provided ID *is* on the list     | true        |                       
|                     |                                                  | `updateStatusByID(int)`         | Task with the provided ID *is not* on the list | false       |                       
|                     |                                                  |                                 | Task with the provided ID *is* on the list     | true        |                       
|                     |                                                  | `dates()`                       |                                                |             |                       
|                     |                                                  |                                 |                                                |             |