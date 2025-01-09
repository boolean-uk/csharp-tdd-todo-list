# User stories
- I want to add tasks to my todo list.
- I want to see all the tasks in my todo list.
- I want to change the status of a task between incomplete and complete.
- I want to be able to get only the complete tasks.
- I want to be able to get only the incomplete tasks.
- I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
- I want to remove tasks from my list.
- I want to see all the tasks in my list ordered alphabetically in ascending order.
- I want to see all the tasks in my list ordered alphabetically in descending order.

# Domain model
| Classes         | Methods/Properties                                 | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------
|Task.cs    | bool status, string task, uid id, date creationDate                                               
|ToDoList.cs    |Add(Task t)                                   |adding a task to list                | Log 'task added' or error
|ToDoList.cs    |Property for storing all tasks                           |
|ToDoList.cs    |retrieving tasks getTasks
|ToDoList.cs    |different implementations of gettask based on criteria                  | get tasks by alphabetic 
|ToDoList.cs    |searchTask(string name)                    |search for task  | get response of found or not
|ToDoList.cs    |removeTask(uid id)                    |if you want to remove task  |log if remove successful