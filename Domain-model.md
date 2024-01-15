#Domain Model In Here


class             |         property       |       method                           | scenario                                                      | output  
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Task              | Task Id, String Task   |                                        |                                                               |
ToDoList          | List Task              | AddATask, GetTask, ChangeTask          |Add a task, get all task, change a task status                 |                      
                  |                        | GetCompleteTask, GetIncompleteTask     |Get the completed tasks, get the incomplete tasks              | A list with tasks
                  |                        | FindATask, RemoveATask                 |Search for a task by its name, remove a task                   | The task or nothing if task doesnt exist
                  |                        | TaskAscendingOrder, TaskDescendingOrder|Order task in ascending order, order tasks in descending order | The list of tasks in orderning
==========================================================================================================================================================================
TodoListExtension | TodoList               | GetTaskById                            | Get task by its Id                                            | The task itself or null if Id doesnt exist
                  |                        | UpdateTaskname                         | Update name of task with Id and new name                      | Update of the task name
                  |                        | ChangeTaskState                        | Change to status with Id                                      | Update of the task status
                  |                        | GetCreationTime                        | Get the creation time of a task with its Id                   | Date time of task wehn created