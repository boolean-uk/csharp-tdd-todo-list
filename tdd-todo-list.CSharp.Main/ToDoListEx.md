|Classes | Methods/Properties                               | Scenario                        | Output                                                  |
|--------|--------------------------------------------------|---------------------------------|---------------------------------------------------------|
|ToDoList| addTask(string task)                             |                                 | int id                                                  |
|        | changeStatus(int id)                             |                                 |                                                         |
|        | getList(char completed = 'a', char sorted = 'n') | no specification from user      | string list (full)                                      |
|        |                                                  | completed parameter set by user | string list (only completed tasks, or only incompleted) |
|        |                                                  | sorted parameter set by user    | string list (sorted in descending or ascending order)   |
|        | findTask(int id)				                    | task is in toDoList             | string task                                             |
|        |                                                  | task is not in toDolist         | string message                                          |
|        | removeTask(string task)                          |                                 |                                                         |
|        | updateTask(int id, string description)           |                                 |                                                |
|        | getTimeAndDate(int id)                           |                                 | string                                                  |
|Task    | bool Completed									|                                 |                                                         |
|        | string Description                               |                                 |                                                         |
|		 | string TimeAndDateCreated						|                                 |                                                         |
