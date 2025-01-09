```I want to add tasks to my todo list.```

TodoList

| method               | object variable         | context                                                         | output/return      |
|----------------------|-------------------------|-----------------------------------------------------------------|--------------------|
| addTask(string name) | List\<Task\> tasks		 | Method creates a new Task, and adds it to the List\<Task\>	   | (Task) createdTask |

___
```I want to see all the tasks in my todo list.```

TodoList

| method                                    | object variable         | context                                                                                                   | output/return                     |
|-------------------------------------------|-------------------------|-----------------------------------------------------------------------------------------------------------|-----------------------------------|
| showTasks()								| List\<Task\> tasks	  | Print all tasks in terminal. Includes name and status of task. Order is chronological of time of creation | (string) allTasksFormattedToPrint |

___

```I want to be able to get only the complete tasks.```

TodoList

| method              | object variable         | context                                                                                           | output/return                              |
|---------------------|-------------------------|---------------------------------------------------------------------------------------------------|--------------------------------------------|
| showCompleteTasks() | List\<Task\> tasks		| creates new List, adds all tasks with complete status and calls showTasks with new List			| (string) allCompletedTasksFormattedToPrint |
|                     |                         |                                                                                                   |                                            |
___
```I want to be able to get only the incomplete tasks.```

TodoList

| method                | object variable         | context                                                                                             | output/return                               |
|-----------------------|-------------------------|-----------------------------------------------------------------------------------------------------|---------------------------------------------|
| showIncompleteTasks() | List\<Task\> tasks	  | creates new List, adds all tasks with incomplete status and calls showTasks with new List			| (string) allIncompleteTasksFormattedToPrint |

___
```I want to search for a task and receive a message that says it wasn't found if it doesn't exist.```

TodoList

| method              | object variable         | context                                                                                                       | output/return            |
|---------------------|-------------------------|---------------------------------------------------------------------------------------------------------------|--------------------------|
| search(string name) | List\<Task\> tasks		| iterates over elements in List and checks if any element matches name. If found, return positive message		| (string) foundMessage    |
|                     |                         | If not found, return negative message                                                                         | (string) notFoundMessage |
___
```I want to remove tasks from my list.```

TodoList

| method              | object variable         | context                                                                                                      | output/return      |
|---------------------|-------------------------|--------------------------------------------------------------------------------------------------------------|--------------------|
| delete(string name) | List\<Task\> tasks	    | iterates over elements in List and remove the first element that matches name. If deleted, return true.	   | (bool) found		|
|                     |                         | If not deleted (not found), return false                                                                     | (bool) notFound	|
___
```I want to see all the tasks in my list ordered alphabetically in ascending order.```

TodoList

| method          | object variable        | context                                                                           | output/return                      |
|-----------------|------------------------|-----------------------------------------------------------------------------------|------------------------------------|
| orderTasksAsc() | List\<Task\> list	   | If there are elements in List, use sort-method to sort it in ascending order	   | (List\<Task\>) tasksSortedAsc		|

___
```I want to see all the tasks in my list ordered alphabetically in descending order.```

TodoList

| method           | object variable        | context                                                                                                           | output/return                       |
|------------------|------------------------|-------------------------------------------------------------------------------------------------------------------|-------------------------------------|
| orderTasksDesc() | List\<Task\> list		| If there are elements in List, use sort-method and Collections.reverseOrder() to sort it in descending order		| (List\<Task\>) tasksSortedDesc |

___
```I want to be able to get a task by a unique ID.```

TodoList

| method             | object variable         | context                                                                                                      | output/return             |
|--------------------|-------------------------|--------------------------------------------------------------------------------------------------------------|---------------------------|
| searchById(int id) | List\<Task\> tasks	   | iterates over elements in List and checks if any element's id matches id. If found, return the element.	  | (Task) taskWithMatchingId |
|                    |                         | if not found, return null                                                                                    | (Task) null               |

___
```I want to update the name of a task by providing its ID and a new name.```

TodoList

| method                              | object variable         | context                                                                                                                        | output/return            |
|-------------------------------------|-------------------------|--------------------------------------------------------------------------------------------------------------------------------|--------------------------|
| setNameById(int id, string newName) | List\<Task\> tasks		| iterates over elements in List and checks if any element's id matches id. If found, set the name to new name, return true		 | (bool) changedName		|
|                                     |                         | if not found, return false                                                                                                     | (bool) notChangedName	|

___
```I want to be able to change the status of a task by providing its ID.```

TodoList

| method                                   | object variable         | context                                                                                                                            | output/return              |
|------------------------------------------|-------------------------|------------------------------------------------------------------------------------------------------------------------------------|----------------------------|
| setStatusById(int id, bool newStatus)	   | List\<Task\> tasks		 | iterates over elements in List and checks if any element's id matches id. If found, set the status to new status, return true	  | (bool) changedStatus		|
|                                          |                         | if not found, return false                                                                                                         | (bool) notChangedStatus		|

___
```I want to be able to see the date and time that I created each task.```

Task

| method | object variable     | context                                                                                                   | output/return |
|--------|---------------------|-----------------------------------------------------------------------------------------------------------|---------------|
| Task   | string name         | add a new object variable "createdAt" of type TimeStamp. Upon creation of object, set createdAt to 'now'  |               |
|        | bool status		   |                                                                                                          |               |
|        | TimeStamp createdAt |                                                                                                           |               |
