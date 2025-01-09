## Todo List

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



| Classes     | Methods/Properties                                                  | Scenario                                                         | Outputs                                                          |   |
|-------------|---------------------------------------------------------------------|------------------------------------------------------------------|------------------------------------------------------------------|---|
| ToDoList.cs | AddTask(string task)                                                | Add task to list                                                 |                                                                  |   |
| ToDoList.cs | GetList()															| Get all elements in list                                         | All elements in list                                             |   |
| ToDoList.cs | ToggleTask(string task)												| Set task to completed or incomplete                              |                                                                  |   |
| ToDoList.cs | GetFilteredTasks(bool completed)                                    | Get a list of all completed tasks                                | All completed tasks                                              |   |
| ToDoList.cs | GetFilteredTasks(bool completed)                                    | Get a list of all incomplete tasks                               | All incompleted tasks                                            |   |
| ToDoList.cs | GetTask(string task)                                                | Get task from list or "not found" message                        | Matching task/"Not found"                                        |   |
| ToDoList.cs | DeleteTask(string task)                                             | Removes task from list                                           |                                                                  |   |
| ToDoList.cs | GetOrderedList(bool ascending)										| All elements in list, ordered alphabetically in ascending order  | All elements in list, ordered alphabetically in ascending order  |   |
| ToDoList.cs | GetOrderedList(bool ascending)										| All elements in list, ordered alphabetically in descending order | All elements in list, ordered alphabetically in descending order |   |