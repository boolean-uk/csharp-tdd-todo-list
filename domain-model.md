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
|ToDoList.cs    |Add(Task t), and Add(string taskName)                                   |adding a task to dictionary                | 
|ToDoList.cs    |Property for storing all tasks                           |
|ToDoList.cs    |retrieving tasks getTasks with criteria, all tasks default
|ToDoList.cs    |searchTask(uid id)                 |search for task  | exeption if not found
|ToDoList.cs    |removeTask(uid id)                    |if you want to remove task  |exception if not remove success
|ToDoList.cs    |changeTaskStatus(uid id)                    |if you want to change task status |
|ToDoList.cs    |override ToString()                 |functionality for viewing tasks in any form, can also see date| 
|ToDoList.cs    | changeNameById(uid id)                |can change name of task given id| 

## Notes
I did not get time to implement a ui, but the functionality should be solid for implementing one where you can actually see the tasks and errormessages. You would have to catch the exceptions thrown and display.	