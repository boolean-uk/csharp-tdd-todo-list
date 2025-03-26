#Domain Models In Here

```
As a user,
I want to add tasks to my todo list.
```

```
As a user,
I want to see all the tasks in my todo list.
```

```
As a user,
I want to change the status of a task between incomplete and complete.
```

```
As a user,
I want to be able to get only the complete tasks.
```

```
As a user,
I want to be able to get only the incomplete tasks.
```

```
As a user,
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
```

```
As a user,
I want to remove tasks from my list.
```

```
As a user,
I want to see all the tasks in my list ordered alphabetically in ascending order.
```

```
As a user,
I want to see all the tasks in my list ordered alphabetically in descending order.
```

| Classes    | Members                                                                        | Methods                               | Scenario                                                 | Outputs |
|------------|--------------------------------------------------------------------------------|---------------------------------------|----------------------------------------------------------|---------|
| `TodoList` | `Dictionary<string, bool> todo` (key is task name, value is completion status) | `add(String task)`                    | Task with the provided name *is not* already in the list | true    |
|            |                                                                                |                                       | Task with the provided name *is* already in the lsit     | false   |
|            |                                                                                | `print()`                             |                                                          |         |
|            | `Dictionary<string, bool> todo` (key is task name, value is completion status) | `setStatus(string task, bool status)` | Task with the provided name is in the list               | true    |
|            |                                                                                |                                       | Task with the provided name is not in the list           | false   |
|            | `bool showCompleted`                                                           | `toggleShowCompleted()`               | showCompleted is changed to true                         | true    |
|            |                                                                                |                                       | showCompleted is changed to false                        | false   |
|            | `bool showIncomplete`                                                          | `toggleShowIncomplete()`              | showIncompleted is changed to true                       | true    |
|            |                                                                                |                                       | showIncompleted is changed to false                      | false   |
|            |                                                                                | `find(string task)`                   | Task was found                                           | true    |
|            |                                                                                |                                       | Task was not found                                       | fasle   |
|            | `Dictionary<string, bool> todo` (key is task name, value is completion status) | `remove(string task)`                 | Task with the provided name was in the list              | true    |
|            |                                                                                |                                       | Task with the provided name was not the list             | false   |
|            |                                                                                | `printAscending()`                    |                                                          |         |
|            |                                                                                | `printDescending()`                   |                                                          |         |
