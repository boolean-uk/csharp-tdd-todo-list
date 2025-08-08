# Domain Modelling

## ITodoTask
| Methods/Properties                            | Scenario                            | Outputs                  |
|-----------------------------------------------|-------------------------------------|--------------------------|
| Id                                            | Stores task ID                      | int                      |
| CompletionStatus                              | stores completion status            | TaskCompletionStatusEnum |
| TaskContent                                   | task description                    | string                   |
| Priority                                      | stores task priority                | TaskPriorityEnum         |
| TimeCreated                                   | stores time of task creation        | DateTime                 |
| TimeCompleted                                 | stores time of task completion      | DateTime                 |
| TimeToComplete                                | shows time it took to complete task | TimeSpan                 |
| Category                                      | stores task category                | TaskCategoryEnum         |
| CompleteTask()                                | changes task completion status      |                          |
| ChangeTaskPriority(TaskPriorityEnum priority) | changes priority of the task        |                          |
| ChangeTaskContent(string newContent)          | changes content of the task         |                          |
| ChangeTaskCategory(TaskCategoryEnum category) | changes category of the task        |                          |
|                                               |                                     |                          |
|                                               |                                     |                          |




## ToDoList
| Method                                                      | Scenario                                               | Outputs                                                    |
|-------------------------------------------------------------|--------------------------------------------------------|------------------------------------------------------------|
| AddTask(Task task)                                          | add new task to list                                   |                                                            |
| GetAllTasks()                                               | gets all tasks                                         | return all tasks in IEnumerable<ITodoTask>                 |
| GetCompletedTasks()                                         | gets all completed tasks                               | return all completed tasks in IEnumerable<ITodoTask>       |
| GetIncompleteTasks()                                        | gets all incomplete tasks                              | return all incomplete tasks in IEnumerable<ITodoTask>      |
| RemoveTaskByName(string name)                               | remove task by its content                             |                                                            |
| RemoveTaskById(int id)                                      | remove task by its id                                  |                                                            |
| GetAlphabeticallySortedTasks(bool ascending)                | Get all tasks sorted by content                        | returns sorted tasks in IEnumerable<ITodoTask>             |
| ChangeTaskPriorityByName(string name)                       | change tasks priority value by name                    |                                                            |
| ChangeTaskPriorityByid(int id)                              | change tasks priority value by id                      |                                                            |
| GetAllTasksByPriority()                                     | get all tasks sorted by priority                       | returns tasks sorted by priority in IEnumerable<ITodoTask> |
| GetTaskByName(string name)                                  | find a task by its name                                | return ITodoTask                                           |
| GetTaskById(int id)                                         | find a task by id                                      | return ITodoTask                                           |
| UpdateTaskNameById(int id, string newName)                  | update tasks description by id                         |                                                            |
| CompleteTaskById(int id)                                    | complete task by id                                    |                                                            |
| CompleteTaskByName(string name)                             | complete task by name                                  |                                                            |
| GetTaskLongestToComplete()                                  | get task which took the longest to complete            | return ITodoTask                                           |
| GetTaskShortestToComplete()                                 | get task which took the shortest to complete           | return ITodoTask                                           |
| GetTasksWhichTookLongerToCompleteThan(int seconds)          | get task which took longer to complete than given time | IEnumerable<ITodoTask>                                     |
| AssignCategoryToTaskById(int id, TaskCategoryEnum category) | assign category to task by id                          |                                                            |
| GetTasksByCategory(TaskCategoryEnum category)               | get tasks from given category                          | IEnumerable<ITodoTask>                                     |
