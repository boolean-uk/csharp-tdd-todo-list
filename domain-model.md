# User Stories

1. I want to add tasks to my todo list.
2. I want to see all the tasks in my todo list.
3. I want to change the status of a task between incomplete and complete.
4. I want to be able to get only the complete tasks.
5. I want to be able to get only the incomplete tasks.
6. I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
7. I want to remove tasks from my list.
8. I want to see all the tasks in my list ordered alphabetically in ascending order.
9. I want to see all the tasks in my list ordered alphabetically in descending order.



| Classes       | Methods/Properties                             | Scenario                                          | Outputs                                     |
|---------------|------------------------------------------------|---------------------------------------------------|---------------------------------------------|
|ToDoList.cs    |AddTasks(string task)                           |add tasks to tasklist                              |message confirming addition of task          |
|ToDoList.cs    |SeeAllTasks()                                   |retrieve all tasks                                 |returns all tasks                            |
|ToDoList.cs    |ChangeTaskStatus(string task, string newStatus) |change task status                                 |message confirming the change of task status |
|ToDoList.cs    |GetCompletedTasks()                             |return completed tasks                             |returns completed tasks                      |
|ToDoList.cs    |GetIncompleteTasks()                            |return incomplete tasks                            |returns incomplete task                      |
|ToDoList.cs    |CheckIfTaskExists(string task)                  |return message confirming task existence if exists |message confirming or denying task existence |
|ToDoList.cs    |RemoveTasks(string task)                        |remove task                                        |message confirming removal of task           |
|ToDoList.cs    |GetTasksAlphaAscending()                        |return tasks in alphabetical ascending order       |returns all tasks in alpha asc order         |
|ToDoList.cs    |GetTasksAlphaDescending()                       |return tasks in alphabetical descending order      |returns all tasks in alpha desc order        |
