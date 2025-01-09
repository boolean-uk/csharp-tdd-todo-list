# Domain model

## User stories

- [x] I want to add tasks to my todo list.
- [x] I want to see all the tasks in my todo list.
- [x] I want to change the status of a task between incomplete and complete.
- [x] I want to be able to get only the complete tasks.
- [x] I want to be able to get only the incomplete tasks.
- [x] I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
- [x] I want to remove tasks from my list.
- [x] I want to see all the tasks in my list ordered alphabetically in ascending order.
- [x] I want to see all the tasks in my list ordered alphabetically in descending order.
- [x] I want to be able to get a task by a unique ID. (Extension)
- [x] I want to update the name of a task by providing its ID and a new name. (Extension)
- [x] I want to be able to change the status of a task by providing its ID. (Extension)
- [x] I want to be able to see the date and time that I created each task. (Extension)

## Methods

*D<> = Dictionary<>*

| Function Name               | Parameters                 | Behavior                                           | Returns      |
|-----------------------------|----------------------------|----------------------------------------------------|--------------|
| AddTask                     | string name                | Add Task object to Dictionary                      | int          |
| RemoveTask                  | int id                     | Remove Task object from Dictionary                 | void         |
| GetTask                     | string taskName            | Get Task object                                    | Task         |
| GetTask (Extended)          | int id                     | Get Task object                                    | Task         |
| GetTasks                    |                            | Get Dictionary containing all tasks                | D<int, Task> |   
| GetName (Task)              |                            | Get name of Task                                   | string       |
| SetName (Task)              | string newName             | Update name of Task                                | void         |
| SetName (Extended)          | int id, string newName     | Update name of Task using unique ID                | void         |
| GetStatus (Task)            |                            | Get status of a Task                               | bool         |   
| SetStatus (Task)            | bool complete              | Set status of a Task                               | void         |   
| SetStatus                   | string name, bool complete | Set status of a Task                               | void         |   
| GetDateTimeStamp (Extended) |                            | Returns the DateTime value for when task was added | DateTime     |
| GetCompletedTasks           |                            | Get all complete Tasks                             | D<int, Task> |
| GetIncompleteTasks          |                            | Get all incomplete Tasks                           | D<int, Task> |   
| ToString `@override`        |                            | Makes a string message for found Task              | string       |
| GetOrdered                  | bool Ascending             | Get ordered Dictionary of Tasks                    | D<int, Task> |

