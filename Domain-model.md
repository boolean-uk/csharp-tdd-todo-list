#Domain Model In Here

class      |         property       |       method                           | scenario                                                      | output  
------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Task       | Task Id, String Task   |                                        |                                                               |
ToDoList   | List Task              | AddATask, GetTask, ChangeTask          |Add a task, get all task, change a task status                 |                      
           |                        | GetCompleteTask, GetIncompleteTask     |Get the completed tasks, get the incomplete tasks              | A list with tasks
           |                        | FindATask, RemoveATask                 |Search for a task by its name, remove a task                   | The task or nothing if task doesnt exist
           |                        | TaskAscendingOrder, TaskDescendingOrder|Order task in ascending order, order tasks in descending order | The list of tasks in orderning 