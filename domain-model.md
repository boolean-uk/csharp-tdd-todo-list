# Domain model

## User stories

- [ ] I want to add tasks to my todo list.
- [ ] I want to see all the tasks in my todo list.
- [ ] I want to change the status of a task between incomplete and complete.
- [ ] I want to be able to get only the complete tasks.
- [ ] I want to be able to get only the incomplete tasks.
- [ ] I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
- [ ] I want to remove tasks from my list.
- [ ] I want to see all the tasks in my list ordered alphabetically in ascending order.
- [ ] I want to see all the tasks in my list ordered alphabetically in descending order.
- [ ] I want to be able to get a task by a unique ID.
- [ ] I want to update the name of a task by providing its ID and a new name.
- [ ] I want to be able to change the status of a task by providing its ID.
- [ ] I want to be able to see the date and time that I created each task.

## Methods

| Function Name      | Parameters      | Behavior                                                         | Returns  |
|--------------------|-----------------|------------------------------------------------------------------|----------|
| AddTask            | Task task       | Add Task object to Dictionary                                    | int      |
| RemoveTask         | int id          | Remove Task object from Dictionary                               | bool     |
| GetTask            | string taskName | Get Task object                                                  | Task     |
| GetTaskById        | int id          | Get Task object by id                                            | Task     |
| GetTasks           |                 | Get Dictionary containing all tasks                              | []Task   |   
| SetName (Task)     | string newName  | Update name of task                                              | void     |
| SetStatus (Task)   | bool complete   | Set status of a task                                             | void     |   
| GetDateTimeStamp   |                 | Returns the DateTime value for when task was added               | DateTime |
| GetCompleteTasks   |                 | Get all complete tasks                                           | []Task   |
| GetIncompleteTasks |                 | Get all incomplete tasks                                         | []Task   |   
| FindTask           | string taskName | Searches for a task and returns a message if it was found or not | Task     |
| GetOrdered         | bool Ascending  | Get Dictionary ordered                                           | []Task   |
| UpdateTaskStatusById| int id, string status		   | Update status of a task by id                    | void     |
| UpdateTaskNameById | int id, string newName		   | Update name of a task by id                      | void     |
