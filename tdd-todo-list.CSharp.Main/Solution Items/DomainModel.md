# Domain Model 
I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.
I want to be able to get a task by a unique ID.
I want to update the name of a task by providing its ID and a new name.
I want to be able to change the status of a task by providing its ID.
I want to be able to see the date and time that I created each task.

Task = job

| Classes       | Methods                                            | Scenario                                                               | Output          |
|---------------|----------------------------------------------------|------------------------------------------------------------------------|-----------------|
| `Todo`        | AddJob(Job job)                                    | User adds a task object to its todo-list                               | bool            |
|               |                                                    | Task allready exists                                                   | bool			|
|               |                                                    |                                                                        |                 |
|               | SeeJob()                                           | User wants to see all tasks                                            | List            |
|               |                                                    |                                                                        |                 |
|               | ChangeStatus(int id)                               | User wants to change the status of a task                              | Bool            |
|               |                                                    | The task doesnt exist                                                  | Bool            |
|               |                                                    |                                                                        |                 |
|               | GetSpecifiedHobing status)                         | User wants to see incomplete/complete tasks                            | List            |
|               |                                                    |                                                                        |                 |
|               | FindJob(string name)                               | User uses name to find task                                            | string          |
|               |                                                    | Task doesnt exist                                                      | string          |
|               |                                                    |                                                                        |                 |
|               | RemoveJob(int id)                                  | User wants to remove a specified task                                  | string          |
|               |                                                    | Task doesnt exist                                                      | string          |
|               |                                                    |                                                                        |                 |
|               | SortJob(string order)                              | User wants to view all tasks sorted alphabetically ascending/decending | List            |
|               |                                                    |                                                                        |                 |
|               | GetJob(int id)                                     | User wants to get a task specified by its id                           | Job             |
|               |                                                    | Task doesnt exist                                                      |                 |
|               |                                                    |                                                                        |                 |
|               | UpdateName(int id, string newName)                 | User uses id to find and rename existing task                          |                 |
|---------------|----------------------------------------------------|------------------------------------------------------------------------|-----------------|
| `Job`         | Job(string name, int id, Status status, Date date) |                                                                        |                 |
|               |                                                    |                                                                        |                 |
|               | Status                                             | Enum for Job to INCOMPLETE or COMPLETE                                 |                 |
|               |                                                    |                                                                        |                 |
|               |                                                    |                                                                        |                 |
|               |                                                    |                                                                        |                 |
|               |                                                    |                                                                        |                 |
