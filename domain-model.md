| Methods                            | Scenario                           | Output                  |
|------------------------------------|------------------------------------|-------------------------|
| AddTask(string task)               | provided task                      | TRUE                    |
|                                    | empty string                       | FALSE                   |
| getList()                    | Dictionary isnt empty              | List<Task> |
|                                    | Dictionary is empty                | null                    |
| EditTask(string task, bool status) | task exists                        | TRUE                    |
|                                    | task doesnt exist                  | FALSE                   |
| GetCompleteTasks()               | tasks with bool = true exist       | List<Task> |
|                                    | tasks with bool = true dont exist  | null                    |
| GetIncompleteTasks()             | tasks with bool = false exist      | List<Task> |
|                                    | tasks with bool = false dont exist | null                    |
| Search(string task)                | task exists                        | TRUE                    |
|                                    | task doesnt exist                  | FALSE                   |
| Remove(string task)                | task exists                        | TRUE                    |
|                                    | task doesnt exist                  | FALSE                   |
| SortAlphIncrement()                | Dictionary isnt empty              | List<Task> |
|                                    | Dictionary is empty                | null                    |
| SortAlphUnincrement()                | Dictionary isnt empty              | List<Task> |
|                                    | Dictionary is empty                | null                    |
