| Classes | Methods           | Scenario                                         | Output                          |   |
|---------|-------------------|--------------------------------------------------|---------------------------------|---|
| Task.cs | Add("string")     | Add task to todo list                            | Task                            |   |
| Todo.cs | All()             | View all tasks in todo list                      | List<Task>                      |   |
| Task.cs | ChangeStatus()    | Change completion status of task                 | "Task is {complete/incomplete}" |   |
| Todo.cs | FetchComplete()   | View completed tasks                             | List<Task>                     |   |
| Todo.cs | FetchIncomplete() | View incompleted tasks                           | List<Task>                      |   |
| Todo.cs | Search("string")  | Search and found task                            | Task                            |   |
|         |                   | Search and task not found                        | "Task not found"                |   |
| Todo.cs | Remove(Task)      | Remove task from todo list                       | "{Task} removed"                |   |
|         |                   |                                                  | "Task not found"                |   |
| Todo.cs | AlphabetOrderAsc  | Show todolist alphabetically in ascending order  | List<Task>                      |   |
| Todo.cs | AlphabetOrderDes  | Show todolist alphabetically in descending order | List<Task>                      |   |