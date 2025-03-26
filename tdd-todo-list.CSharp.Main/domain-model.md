# Domain Model

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


| `Classes`  | `Methods`                  | `Scenario`                 | `Outputs`                                             |
|------------|----------------------------|----------------------------|-------------------------------------------------------|
| `Todolist` | `Add()`                    | `Task is added`            | `True`                                                |
|            | `Tasks()`                  |                            | `Returns all tasks in list`                           |
|            | `Change status(Task task)` | `The task exists`          | `Changes status of task`                              |
|            |                            | `The task is incomplete`   | `Changes task to complete`                            |
|            |                            | `The task is complete`     | `Changes task to incomplete`                          |
|            | `GetTasks(bool status)`    | `The status is complete`   | `Returns all complete tasks`                          |
|            |                            | `The status is incomplete` | `Returns all incomplete tasks`                        |
|            | `Search(Task task)`        | `Task exists`              | `Returns task`                                        |
|            |                            | `Task does not exist`      | `Returns a message that task does not exist`          |
|            | `Remove(Task task)`        | `Task exists`              | `Removes a task from the list`                        |
|            |                            | `Task does not exist`      | `Returns a message that task does not exist`          |
|            | `OrderAscending()`         |                            | `Orders the tasks alphabetically in ascending order`  |
|            | `OrderDescending()`        |                            | `Orders the tasks alphabetically in descending order` |

## Extension Requirements

- I want to be able to get a task by a unique ID.
- I want to update the name of a task by providing its ID and a new name.
- I want to be able to change the status of a task by providing its ID.
- I want to be able to see the date and time that I created each task.

| `Classes`  | `Methods`           | `Scenario`                    | `Outputs`                                        |
|------------|---------------------|-------------------------------|--------------------------------------------------|
| `Todolist` | `GetTask(id)`       | `Task with ID exists`         | `Returns the task`                               |
|            |                     | `Task with ID does not exist` | `Returns a message that the task does not exist` |
|            | `Update(ID, name)`  | `Task with ID exists`         | `Name of the task is changed`                    |
|            |                     | `Task with ID does not exist` | `Returns a message that the task does not exist` |
|            | `Change status(ID)` | `Task with ID exists`         | `Status of the task is updated`                  |
|            |                     | `Task with ID does not exist` | `Returns a message that the task does not exist` |