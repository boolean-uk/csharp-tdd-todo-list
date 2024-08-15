|Classes | Methods/Properties                               | Scenario                        | Output                                                  |
|--------|--------------------------------------------------|---------------------------------|---------------------------------------------------------|
|ToDoList| addTask(string task)                             |                                 |                                                         |
|        | changeStatus(string task, bool completed)        |                                 |                                                         |
|        | getList(char completed = 'a', char sorted = 'n') | no specification from user      | string list (full)                                      |
|        |                                                  | completed parameter set by user | string list (only completed tasks, or only incompleted) |
|        |                                                  | sorted parameter set by user    | string list (sorted in descending or ascending order)   |
|        | findTask(string task)                            | task is in toDoList             | string task                                             |
|        |                                                  | task is not in toDolist         | string message                                          |
|        | removeTask(string task)                          |                                 |                                                         |

