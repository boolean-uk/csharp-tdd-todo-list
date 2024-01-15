# Core
I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.

| Classes         | Methods                                     | Scenario                  | Outputs                               |
|-----------------|---------------------------------------------|---------------------------|---------------------------------------|
| `Todo`          | `getTasks()`                                | If tasks not empty	      | List<Task> tasks                      |
|                 |                                             | If tasks empty            | []                                    |
| `Todo`	        | `addTask(Task task)`                        | any			                  | void			                            |
| `Todo`	        | `setTaskStatus(Task task)`                  | If task exists            | bool true			                        |
|                 |                                             | If task doesn't exist     | bool false                            |
| `Todo`	        | `getCompleteTasks(Task task)`               | If complete tasks         | List\<Task\> completeTasks       	      |
|                 |                                             | If complete tasks empty   | []                                    |
| `Todo`	        | `getInCompleteTasks(Task task)`             | If complete tasks         | List\<Task\> incompleteTasks            |
|                 |                                             | If incomplete tasks empty | []       	                            |
| `Todo`	        | `searchForTask(Task task)`                  | If found			            | bool true 			                        |
|                 |                                             | If not found			        | bool false, prints "Task not found" |
| `Todo`	        | `getTasksAscending()`                       | If tasks                  | List\<Task\> ascendingTasks             |
|                 |                                             | If no tasks               | []                                    |
| `Todo`	        | `clearTodo()`                               | any                       | void, prints "Tasks cleared"            |
| `Todo`	        | `getTasksDescending()`                      | If tasks                  | List\<Task\> descendingTasks            |
|                 |                                             | If no tasks               | []                                    |


# Extension
I want to be able to get a task by a unique ID.
I want to update the name of a task by providing its ID and a new name.
I want to be able to change the status of a task by providing its ID.
I want to be able to see the date and time that I created each task.
| Classes         | Methods                                     | Scenario                  | Outputs                       |
|-----------------|---------------------------------------------|---------------------------|-------------------------------|
| `Todo`          | `getTaskById(string Id)`                    | If task exists	        | Task task                     |
|                 |                                             | If task doesn not exist   | null                            |
| `Todo`          | `updateTaskName(string Id)`                 | If task exists	        | bool true                     |
|                 |                                             | If task doesn't exist     | bool false                    |
| `Todo`          | `changeTaskStatus(string Id)`               | If task exists	        | bool true                     |
|                 |                                             | If task doesn't exist     | bool false                    |
| `Todo`          | `getCreationTime(string Id)`                | If task exists	        | Date/Time createdAt           |
|                 |                                             | If task doesn't exist     | null                          |
