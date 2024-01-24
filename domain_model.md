```
I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.
```

#Domain Models In Here

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `Todo-list`	  | `add(Task task)`							|					     | null    |
|                 | `showTasks()`                               |					     |List<Task>|
|                 | `retrieveCompleted()`                       |					     |List<Task>|
|                 | `retrieveUncompleted()`                     |					     |List<Task>|
|                 | `search(Task task)`							|Task exists		     |string	|
|                 | `search(Task task)`							|Task doesn't exists	 |string	|
|                 | `remove(Task task)`							|						 |string	|
|                 | `listInOrder()`								|						 |List<Task>|
|                 | `listDescending()`							|						 |List<Task>|

`I want to change the status of a task between incomplete and complete.`

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `Task`		  | `toggleStatus()`							|					     |null     |
|                 |                                             |						 |		   |

```
I want to be able to get a task by a unique ID.
I want to update the name of a task by providing its ID and a new name.
I want to be able to change the status of a task by providing its ID.
I want to be able to see the date and time that I created each task.
```
| Classes         | Methods                                     | Scenario               | Outputs	|
|-----------------|---------------------------------------------|------------------------|----------|
| `Todo-list-ext` | `getTaskByID(Guid id)`						|					     |		    |
|                 | `changeNameById(Guid id, string name)`      |					     |null		|
|                 | `changeStatusByID(Guid id)`                 |					     |null		|
