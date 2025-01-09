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


## Extension Requirements



- I want to be able to get a task by a unique ID.
- I want to update the name of a task by providing its ID and a new name.
- I want to be able to change the status of a task by providing its ID.
- I want to be able to see the date and time that I created each task.

## Extension Domain model

| Classes     | Methods/Properties                  | Senario                                      | Outputs                                               |
|-------------|-------------------------------------|----------------------------------------------|-------------------------------------------------------|
| ToDoList.cs | AddTask(int id, string task, bool status) | Adds a task to the list of tasks             |    True if added, False if not                                                   |
| ToDoList.cs | GetTask(int id)                       | Get the task with the unique ID           | Task                                             |
| ToDoList.cs | ChangeName(int id, string name)           | Changes the name of a task with a unique id               | The new name                                     |
| ToDoList.cs | ChangeStatus(int id)              | Changes the statis of the task with a unique id         |The updated status                  |
| ToDoList.cs | SeeTimeCreated(int id)            | Output the time a task was created | Time created |
