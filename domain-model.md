# Domain Model


| Classes         | Methods/Properties                                 | Scenario                                                                     | Outputs                          |
|-----------------|----------------------------------------------------|------------------------------------------------------------------------------|-----------------------------------
|ToDoList.cs      |AddTask(string id, Task task)                       |add a new task to the todo list                                               |the added task                    |
|ToDoList.cs      |RemoveTask(string id)                               |remove task from todo list                                                    |the removed task                  |
|ToDoList.cs      |ChangeTaskStatus(string id, bool complete)          |change task status between complete/incomplete                                |the task                          |
|ToDoList.cs      |GetTasksByStatus(bool complete)                     |list all complete or incomplete tasks                                         |List<Task>                        |
|ToDoList.cs      |SearchTask(string id)                               |search for a task to see if it exists or not                                  |bool                              |
|ToDoList.cs      |ListTasksAlphabeticalOrder(string order)            |see all tasks ordered alphabetically in either acending or descending order   |List<Task>                        |
|ToDoList.cs      |ListTasksByPriority()                               |list all tasks by priority                                                    |List<Task>                        |
|ToDoList.cs      |RenameTaskById(string id)                           |change the name/description of a task with its id                             |task                       |
|ToDoList.cs      |GetTaskCompletionTime(string id)                    |get timestamp a task was completed                                            |DateTime                        |