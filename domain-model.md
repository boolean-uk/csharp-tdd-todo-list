Core Requirements
-  I want to add tasks to my todo list.
- I want to see all the tasks in my todo list.
- I want to change the status of a task between incomplete and complete.
- I want to be able to get only the complete tasks.
- I want to be able to get only the incomplete tasks.
- I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
- I want to remove tasks from my list.
- I want to see all the tasks in my list ordered alphabetically in ascending order.
- I want to see all the tasks in my list ordered alphabetically in descending order.

Extension requirements

- I want to be able to get a task by a unique ID.
- I want to update the name of a task by providing its ID and a new name.
- I want to be able to change the status of a task by providing its ID.
- I want to be able to see the date and time that I created each task.

| Classes  | Methods                                | Scenario                                       | Output                         |
|----------|----------------------------------------|------------------------------------------------|--------------------------------|
| TodoList | List\<TaskItem> Tasks {get; set;}       | Store and get tasks                            | List\<TaskItem> tasks           |
|          | AddTask(String taskName)               | Add a new task to Task List                    | bool                           |
|          | GetCompleteTasks()                     | Filter the tasks to show only complete         | List\<TaskItem> completeTasks   |
|          | GetIncompleteTasks()                   | Filter tasks to find only incomplete           | List\<TaskItem> incompleteTasks |
|          | SearchTask(String name)                | Search for a specific task                     | bool                           |
|          | RemoveTask(String name)                | Remove task if exists                          | bool                           |
|          | OrderTasks(bool ascending)             | Order alphabetically true = asc / false = desc | List\<TaskItem> Tasks           |
|          | GetTask(int Id)                        | Get a task by its unique id                    | TaskItem task                  |
|          | UpdateTaskName(int Id, String newName) | Update a task with a new name                  | bool                           |
|          | UpdateTaskStatus(int Id)               | Updates the isComplete property                | bool                           |
| TaskItem | String Name {get; set;}                | store and get name of task                     | String name                    |
|          | bool isComplete {get; set;} = false;   | check completion status                        | bool                           |
|          | int Id {get; set;}                     | store unique id for tasks                      | int id                         |
|          | DateTime Date {get; set;}              | store date of task creation                    | DateTime date                  |