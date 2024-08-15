| Classes  | Methods                              | Scenario                                       | Output                     |
|----------|--------------------------------------|------------------------------------------------|----------------------------|
| TodoList | List\<TaskItem> Tasks {get; set;}         | Store and get tasks                           | List\<TaskItem> tasks           |
|          | AddTask(String, taskName)            | Add a new task to Task List                    | bool                       |
|          | GetCompleteTasks(List\<TaskItem> Tasks)  | Filter the tasks to show only complete        | List\<TaskItem> completeTasks   |
|          | GetIncompleteTasks(List\<TaskItem> Tasks)| Filter tasks to find only incomplete          | List\<TaskItem> incompleteTasks |
|          | SearchTask(String name)              | Search for a specific task                     | bool                       |
|          | RemoveTask(String name)              | Remove task if exists                          | bool                       |
|          | OrderTasks(bool ascending)           | Order alphabetically true = asc / false = desc | List\<TaskItem> Tasks          |
| TaskItem | String Name {get; set;}              | store and get name of task                     | String name                |
|          | bool Complete {get; set;} = false;   | check completion status                        | bool                       |