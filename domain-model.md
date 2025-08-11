# Domain models

## Core requirements

1. I want to add tasks to my todo list.

| Classes     | Methods/Properties | Scenario                          | Outputs |
|-------------|--------------------|-----------------------------------|---------|
| ToDoList.cs | Add(TaskItem task) | Add task to List<TaskItem> MyList | bool    |


2. I want to see all the tasks in my todo list.

| Classes     | Methods/Properties                         | Scenario                                  | Outputs        |
|-------------|--------------------------------------------|-------------------------------------------|----------------|
| ToDoList.cs | public List<TaskItem> MyList { get; set; } | Return all tasks in List<TaskItem> MyList | List<TaskItem> |


3. I want to change the status of a task between incomplete and complete.

| Classes     | Methods/Properties                    | Scenario                          | Outputs |
|-------------|---------------------------------------|-----------------------------------|---------|
| TaskItem.cs | public bool IsCompleted { get; set; } | Changes IsCompleted to true/false | bool    |


4. I want to be able to get only the complete tasks.

| Classes     | Methods/Properties                                 | Scenario                       | Outputs        |
|-------------|----------------------------------------------------|--------------------------------|----------------|
| ToDoList.cs | public List<TaskItem> CompletedTasks { get; set; } | Return all the completed tasks | List<TaskItem> |


5. I want to be able to get only the incomplete tasks.

| Classes     | Methods/Properties                                   | Scenario                         | Outputs        |
|-------------|------------------------------------------------------|----------------------------------|----------------|
| ToDoList.cs | public List<TaskItem> IncompletedTasks { get; set; } | Return all the incompleted tasks | List<TaskItem> |


6. I want to search for a task and receive a message that says it wasn't found if it doesn't exist.

| Classes     | Methods/Properties                     | Scenario                              | Outputs |
|-------------|----------------------------------------|---------------------------------------|---------|
| ToDoList.cs | Search(TodoList todolist, string name) | Returns task name or "Task not found" | string  |
 

7. I want to remove tasks from my list. 

| Classes     | Methods/Properties    | Scenario                               | Outputs |
|-------------|-----------------------|----------------------------------------|---------|
| ToDoList.cs | Remove(TaskItem task) | Remove task from List<TaskItem> MyList | bool    |


8. I want to see all the tasks in my list ordered alphabetically in ascending order.

| Classes     | Methods/Properties                                       | Scenario                                          | Outputs        |
|-------------|----------------------------------------------------------|---------------------------------------------------|----------------|
| ToDoList.cs | public List<TaskItem> TasksSortedAscending { get; set; } | Return the list in alphabetically ascending order | List<TaskItem> |


9. I want to see all the tasks in my list ordered alphabetically in descending order.

| Classes     | Methods/Properties                                        | Scenario                                           | Outputs        |
|-------------|-----------------------------------------------------------|----------------------------------------------------|----------------|
| ToDoList.cs | public List<TaskItem> TasksSortedDescending { get; set; } | Return the list in alphabetically descending order | List<TaskItem> |


10. I want to prioritise tasks e.g. low, medium, high

| Classes     | Methods/Properties                     | Scenario                                         | Outputs |
|-------------|----------------------------------------|--------------------------------------------------|---------|
| TaskItem.cs | public Priority priority { get; set; } | Possible to set task to low/medium/high priority | bool    |


11. I want to list all tasks by priority

| Classes     | Methods/Properties                                        | Scenario                          | Outputs        |
|-------------|-----------------------------------------------------------|-----------------------------------|----------------|
| ToDoList.cs | public List<TaskItem> TasksSortedByPriority { get; set; } | Return the list in priority order | List<TaskItem> |
