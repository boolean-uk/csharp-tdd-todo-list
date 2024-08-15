# Domain Model

#### User stories

> I want to add tasks to my todo list.

> I want to see all the tasks in my todo list.

> I want to change the status of a task between incomplete and complete.

> I want to be able to get only the complete tasks.

> I want to be able to get only the incomplete tasks.

> I want to search for a task and receive a message that says it wasn't found if it doesn't exist.

> I want to remove tasks from my list.

> I want to see all the tasks in my list ordered alphabetically in ascending order.

> I want to see all the tasks in my list ordered alphabetically in descending order.

| **Classes** |  **Methods** | **Scenario** | **Outputs** |
|:---:|:---:|:---:|:---:|
| `ToDoList` | AddTasks(string task) | The task is added to the list   | true |
| | | The task is not added to the List | false |
|| ShowList() | Prints out the list| Dictionary<string, Status> |
|| ChangeStatus(string task) | If the list contains the given task, it will change it status| Status |
|| GetCompleteTask() | Gets the completed tasks from the list | Dictionary<string, Status>|
|| GetIncompleteTask() | Get the incompleted tasks from the list | Dictionary<string, Status>|
|| SearchForTask(string task) | Searching for a task in the to do list, and returns a message if it doesnt exists | string|
|| RemoveTask(string task)| Removes a task from the list, if the task exist | true |
||||false|
|| OrderAscending(Dictionary<string, Status> toDoList) | takes the toDolist and order it alphabetically in ascending order | |
|| OrderDescending(Dictionary<string, Status> toDoList) | takes the toDolist and order it alphabetically in descending order | |
| enum  `Status` | INCOMPLETE, COMPLETE | Shows the status of the task |

