| Methods                               | Scenario                           | Output      |
|---------------------------------------|------------------------------------|-------------|
| AddTask(string task)                  | provided task                      | TRUE        |
|                                       | empty string                       | FALSE       |
| getList()                             | Dictionary isnt empty              | List<pTask> |
|                                       | Dictionary is empty                | empty       |
| EditTask(string task, bool status)    | task exists                        | TRUE        |
|                                       | task doesnt exist                  | FALSE       |
| getCompleteTasks()                    | tasks with bool = true exist       | List<pTask> |
|                                       | tasks with bool = true dont exist  | empty       |
| getUncompleteTasks()                  | tasks with bool = false exist      | List<pTask> |
|                                       | tasks with bool = false dont exist | empty       |
| Search(string task)                   | task exists                        | TRUE        |
|                                       | task doesnt exist                  | FALSE       |
| Remove(string task)                   | task exists                        | TRUE        |
|                                       | task doesnt exist                  | FALSE       |
| SortAlphIncrement()                   | Dictionary isnt empty              | List<pTask> |
|                                       | Dictionary is empty                | empty       |
| SortAlphIncrement()                   | Dictionary isnt empty              | List<pTask> |
|                                       | Dictionary is empty                | empty       |
| getTask(guid taskID)                  | task exists                        | pTask       |
|                                       | task doesnt exist                  | null        |
| editTask(guid taskID, string newname) | task exists                        | pTask       |
|                                       | task doesnt exist                  | null        |
|                                       | name is already taken              | null        |
| editTask(guid taskID, bool status)    | task exists                        | pTask       |
|                                       | task doesnt exist                  | null        |
| showTaskTime(string name)             | task exists                        | pTask       |
|                                       | task doesnt exist                  | null        |
