
# User Stories

- I want to add tasks to my todo list.
- I want to see all the tasks in my todo list.
- I want to change the status of a task between incomplete and complete.
- I want to be able to get only the complete tasks.
- I want to be able to get only the incomplete tasks.
- I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
- I want to remove tasks from my list.
- I want to see all the tasks in my list ordered alphabetically in ascending order.
- I want to see all the tasks in my list ordered alphabetically in descending order.




# Domain Model


| Classes     | Methods/Properties          | Scenario                                         | Outputs                                                           |
|-------------|-----------------------------|--------------------------------------------------|-------------------------------------------------------------------|
| ToDoList.cs | AddTask(string task)        | Add tasks to list                                |                                                                   |
| ToDoList.cs | GetTasks()                  | Viewing all tasks in to do list                  | List of all tasks                                                 |
| ToDoList.cs | CompleteTask(string task)   | Marking a task as complete                       |                                                                   |
| ToDoList.cs | IncompleteTask(string task) | Marking a task as incomplete                     |                                                                   |
| ToDoList.cs | GetCompletedTasks()         | Retrieve complete tasks                          | List of complete tasks                                            |
| ToDoList.cs | GetInCompletedTasks()       | Retrieve incomplete tasks                        | List of incomplete tasks                                          |
| ToDoList.cs | SearchTask()                | Search method for task                           | String name of task if it exists, string "it wasn't found" if not.|
| ToDoList.cs | RemoveTask()                | Remove tasks from list                           |                                                                   |
| ToDoList.cs | GetAllTasksAscending()      | Show tasks ordered alphabetically and ascending  | List of tasks in alphabetically and ascending order               |
| ToDoList.cs | GetAllTasksDescending()     | Show tasks ordered alphabetically and descending | List of tasks in alphabetically and descending order              |

