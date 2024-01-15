```
I want to add tasks to my todo list.
```

| Classes    | Methods            | Scenario                                                 | Outputs |
|------------|--------------------|----------------------------------------------------------|---------|
| `ToDoList` | `add(string task)` | Task with the provided name *is not* already in the list | true    |
|            |                    | Task with the provided name *is* already in the list     | false   |

```
I want to see all tasks in my todo list.
```
| Classes      | Methods  | Function                    | Outputs   |
|--------------|----------|-----------------------------|-----------|
|  `ToDoList`  | `show()` | Shows all tasks in the list |listString |

```
I want to change the status of a task between incomplete and complete.
```

| Classes    | Methods                     | Function               | Scenario                                                 | Outputs |
|------------|-----------------------------|------------------------|----------------------------------------------------------|---------|
| `ToDoList` | `changeStatus(string task)` | Changes status on task | Task with the provided name *is not* already in the list | true    |
|            |                             |                        | Task with the provided name *is* already in the list     | false   |

```
I want to get only the complete or incomplete tasks.
```

| Classes    | Methods            | Function                 | Outputs               |
|------------|--------------------|--------------------------|-----------------------|
| `ToDoList` | `showComplete()`   | Shows completed tasks    | completeListString    |
|            | `showIncomplete()` | Shows incompleted tasks  | incompleteListString  |

```
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
```
| Classes    | Methods               | Function          | Scenario                                                 | Outputs |
|------------|-----------------------|-------------------|----------------------------------------------------------|---------|
| `ToDoList` | `search(string task)` | Searches for task | Task with the provided name *is* already in the list     | true    |
|            |                       |                   | Task with the provided name *is not* already in the list | false   |

```
I want to remove tasks from my list.
```
| Classes    | Methods               | Function          | Scenario                                                 | Outputs |
|------------|-----------------------|-------------------|----------------------------------------------------------|---------|
| `ToDoList` | `remove(string task)` | Removes task      | Task with the provided name *is* already in the list     | true    |
|            |                       |                   | Task with the provided name *is not* already in the list | false   |

```
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.
```

| Classes    | Methods                | Function                             | Outputs               |
|------------|------------------------|--------------------------------------|-----------------------|
| `ToDoList` | `showAllAscending()`   | Shows all tasks in ascending order   | ascendingListString   |
|            | `showAllDescending()`  | Shows all tasks in descending order  | descendingListString  |

```
I want to search for a task by its unique ID
```
| Classes     | Methods               | Function                | Scenario                                                 | Outputs |
|-------------|-----------------------|-------------------------|----------------------------------------------------------|---------|
| `Extension` | `searchID(int ID)`    | Searches for task by ID | Task with the provided name *is* already in the list     | true    |
|             |                       |                         | Task with the provided name *is not* already in the list | false   |

```
I want to update the name of a task by providing its ID and a new name.
I want to be able to change the status of a task by providing its ID.
```
| Classes     | Methods                            | Function             | Scenario                                                 | Outputs                 |
|-------------|------------------------------------|----------------------|----------------------------------------------------------|-------------------------|
| `Extension` | `updateTask(int id, string task)`  | Updates task by id   | Task with the provided name *is* already in the list     | true, updates task      |
|             | `updateStatus(int id)`             | Updates status by id | Task with the provided name *is* already in the list     | true, updates status    |

```
I want to be able to see the date and time that I created each task.
```
| Classes     | Methods               | Function                | Scenario                                                 | Outputs               |
|-------------|-----------------------|-------------------------|----------------------------------------------------------|-----------------------|
| `Extension` | `searchID(int ID)`    | Searches for task by ID | Task with the provided name *is* already in the list     | true, timeVar updated |
|             |                       |                         | Task with the provided name *is not* already in the list | false                 |