# Domain Models

| Classes             | Methods                                       | Scenario          | Outputs |
|---------------------|-----------------------------------------------|-------------------|---------|
| `TodoListExtension` | `GetTask(int taskId)`                         | id exists         | `TaskItem`  |
|                     |                                               | id does not exist | `null`  |
| `TodoListExtension` | `UpdateTaskName(int taskId, string taskName)` | id exists         | `true`  |
|                     |                                               | id does not exist | `false` |
| `TodoListExtension` | `ChangeTaskStatus(int taskId, bool status)`   | id exists         | `true`  |
|                     |                                               | id does not exist | `false` |
| `TodoListExtension` | `GetTaskDates()`                              |                   | `string`|
