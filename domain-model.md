I want to add tasks to my todo list.

| Classes         | Methods                                     | Scenario                    | Outputs |
|-----------------|---------------------------------------------|-----------------------------|---------|
| `ToDoList`	  | `add(string task)`							| Adds task to toDoList, and sets incomplete| void    |

I want to see all the tasks in my todo list.

| Classes         | Methods                                     | Scenario                    | Outputs		|
|-----------------|---------------------------------------------|-----------------------------|-------------|
| `ToDoList`	  | `viewTasks()`								| View all tasks, ordered      | List<string>|

I want to change the status of a task between incomplete and complete.

| Classes         | Methods                                     | Scenario                    | Outputs |
|-----------------|---------------------------------------------|-----------------------------|---------|
| `ToDoList`	  | `changeStatus(string task)`					| Changes status of task, true if change was done	  | bool    |

I want to be able to get only the complete tasks.

| Classes         | Methods                                     | Scenario                    | Outputs |
|-----------------|---------------------------------------------|-----------------------------|---------|
| `ToDoList`	  | `viewCompletedTasks()`							| Views Completed tasks		  | List<string>    |

I want to be able to get only the incomplete tasks.
| Classes         | Methods                                     | Scenario                    | Outputs |
|-----------------|---------------------------------------------|-----------------------------|---------|
| `ToDoList`	  | `viewIncompleteTasks()`							| Views Incomplete tasks		  | List<string>    |

I want to search for a task and receive a message that says it wasn't found if it doesn't exist.

| Classes         | Methods                                     | Scenario                    | Outputs |
|-----------------|---------------------------------------------|-----------------------------|---------|
| `ToDoList`	  | `findTask()`							| Message that says if task was found in List  | bool   |

I want to remove tasks from my list.
| Classes         | Methods                                     | Scenario                    | Outputs |
|-----------------|---------------------------------------------|-----------------------------|---------|
| `ToDoList`	  | `removeTask(string task)`							| Removes task from toDoList		  | void    |

I want to see all the tasks in my list ordered alphabetically in ascending order.

| Classes         | Methods                                     | Scenario                    | Outputs		|
|-----------------|---------------------------------------------|-----------------------------|-------------|
| `ToDoList`	  | `viewTasks()`								| View all tasks, ordered      | List<string>|


I want to see all the tasks in my list ordered alphabetically in descending order.

| Classes         | Methods                                     | Scenario                    | Outputs		|
|-----------------|---------------------------------------------|-----------------------------|-------------|
| `ToDoList`	  | `viewTasks( string order )`								| View all tasks, ordered      | List<string>|

| Classes         | Methods                                     | Scenario                                          | Outputs		|
|-----------------|---------------------------------------------|---------------------------------------------------|--------|
| `ToDoList`	  | `add(string task)`							| Adds task to toDoList, and sets incomplete		| void    |
|				  | `viewTasks( string order, string complete )`| View all tasks, ordered							| List<string>|
|				  | `changeStatus(string task)`					| Changes status of task, true if change was done	| bool    |
|				  | `findTask()`								| Message that says if task was found in List		| bool   |
|				  | `removeTask(string task)`					| Removes task from toDoList						| void    |

Extensions:
I want to be able to get a task by a unique ID.
| Classes         | Methods                                     | Scenario                    | Outputs |
|-----------------|---------------------------------------------|-----------------------------|---------|
| `ToDoList`	  | `getId(string task)`						| Gets ID of task			  | int    |
| `ToDoList`	  | `getTaskById(int id)`						| Gets task by ID			  | string    |

I want to update the name of a task by providing its ID and a new name.
| Classes         | Methods                                     | Scenario                    | Outputs |
|-----------------|---------------------------------------------|-----------------------------|---------|
| `ToDoList`	  | `updateName(int ID)`						| updates name of task		  | void    |

I want to be able to change the status of a task by providing its ID.
| Classes         | Methods                                     | Scenario                    | Outputs |
|-----------------|---------------------------------------------|-----------------------------|---------|
| `ToDoList`	  | `changeStatus(int ID)`						| Changes status of task by ID, true if change was done| bool    |

I want to be able to see the date and time that I created each task.
| Classes         | Methods                                     | Scenario                    | Outputs |
|-----------------|---------------------------------------------|-----------------------------|---------|
| `ToDoList`	  | `whenCreated(int ID)`						| Finds when a task was created| string    |

| Classes         | Methods                                     | Scenario                    | Outputs |
|-----------------|---------------------------------------------|-----------------------------|---------|
| `ToDoList`	  | `getId(string task)`						| Gets ID of task			  | int    |
|				  | `getTaskById(int id)`						| Gets task by ID			  | string    |
|				  | `updateName(int ID)`						| updates name of task		  | void    |
|				  | `changeStatus(int ID)`						| Changes status of task by ID, true if change was done| bool    |
|				  | `whenCreated(int ID)`						| Finds when a task was created| string    |