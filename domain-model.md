## Core Requirements

- I want to add tasks to my todo list.
- I want to see all the tasks in my todo list.
- I want to change the status of a task between incomplete and complete.
- I want to be able to get only the complete tasks.
- I want to be able to get only the incomplete tasks.
- I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
- I want to remove tasks from my list.
- I want to see all the tasks in my list ordered alphabetically in ascending order.
- I want to see all the tasks in my list ordered alphabetically in descending order.

## Domain model

| Classes     | Methods/Properties                  | Senario                                      | Outputs                                               |
|-------------|-------------------------------------|----------------------------------------------|-------------------------------------------------------|
| ToDoList.cs | AddTask(string task, bool status) | Adds a task to the list of tasks             |                                                       |
| ToDoList.cs | GetList                         | Get the current list of tasks                | todoList                                              |
| ToDoList.cs | ChangeStatus(string task)           | Changes the status of a task                 | the new status                                        |
| ToDoList.cs | GetTasks(bool status)              | Gets the tasks of a specific status          | The tasks with a specific status                      |
| ToDoList.cs | SearchTask(string input)            | Search for the task that the user has put in | The task that was searched for or a not found message |
| ToDoList.cs | RemoveTask(string task)             | removes the task from list                   | Removed task                                          |
| ToDoList.cs | AscSortList()                       | sorts the list in asceending order           | Sorted list                                           |
| ToDoList.cs | DesSortList()                       | sorts the list in descending order           | Sorted list                                           |