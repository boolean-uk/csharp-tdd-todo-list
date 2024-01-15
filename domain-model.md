| Methods                            | Scenario                           | Output                  |
|------------------------------------|------------------------------------|-------------------------|
| AddTask(string task)               | provided task                      | TRUE                    |
|                                    | empty string                       | FALSE                   |
| PrintTodoList()                    | Dictionary isnt empty              | Dictionary<String,Bool> |
|                                    | Dictionary is empty                | null                    |
| EditTask(string task, bool status) | task exists                        | TRUE                    |
|                                    | task doesnt exist                  | FALSE                   |
| PrintCompleteTasks()               | tasks with bool = true exist       | Dictionary<String,Bool> |
|                                    | tasks with bool = true dont exist  | null                    |
| PrintUncompleteTasks()             | tasks with bool = false exist      | Dictionary<String,Bool> |
|                                    | tasks with bool = false dont exist | null                    |
| Search(string task)                | task exists                        | TRUE                    |
|                                    | task doesnt exist                  | FALSE                   |
| Remove(string task)                | task exists                        | TRUE                    |
|                                    | task doesnt exist                  | FALSE                   |
| SortAlphIncrement()                | Dictionary isnt empty              | Dictionary<String,Bool> |
|                                    | Dictionary is empty                | null                    |
| SortAlphIncrement()                | Dictionary isnt empty              | Dictionary<String,Bool> |
|                                    | Dictionary is empty                | null                    |
