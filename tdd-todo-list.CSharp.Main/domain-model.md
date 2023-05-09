#Domain Models In Here
```
I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
```
| Classes         | Methods                                             | Scenario                            | Outputs             |
|-----------------|-----------------------------------------------------|-------------------------------------|---------------------|
| `AddToDo`	      | `add(Dictionary<string, boolean> todo, status`      | If todo is in list, give feedback   | todolist + error    |
|                 |                                                     | If todo is not in list, add to list | todolist + new todo |

```
I want to change the status of a task between incomplete and complete.
```
| Classes           | Methods                                           | Scenario               | Outputs                   |
|-------------------|---------------------------------------------------|------------------------|---------------------------|
| `ChangeStatus`    | `status(Dictionary<string, boolean> todo, status` | Onclick invert status  | todo item is finished     |
|                   |                                                                            | todo item is unfinished   |

```
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
```
| Classes           | Methods                                           | Scenario               | Outputs                            |
|-------------------|---------------------------------------------------|------------------------|------------------------------------|
| `SortStatus`      | `sorted(Dictionary<string, boolean> todo, status` | Sort true into list    | return todolist with true items    |
|                   |                                                                            | return todolist with false items   |

```
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
```
| Classes           | Methods                                           | Scenario                      | Outputs                |
|-------------------|---------------------------------------------------|-------------------------------|------------------------|
| `SearchToDo`      | `search(Dictionary<string, boolean> todo`         | Check if todo is in todolist  | 'Todo was found'       |
|                   |                                                                                   | 'Todo was not found'   |

```
I want to remove tasks from my list.
```
| Classes           | Methods                                           | Scenario                              | Outputs                 |
|-------------------|---------------------------------------------------|---------------------------------------|-------------------------|
| `RemoveToDo`      | `remove(Dictionary<string, boolean> todo`         | If todo is in list, remove todo       | todolist + without todo |
|                   |                                                   | If todo is not in list, give feedback | todolist + error        |

```
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.
```
| Classes             | Methods                                              | Scenario                                     | Outputs             |
|---------------------|------------------------------------------------------|----------------------------------------------|---------------------|
| `SortByAscending`   | `ascending(Dictionary<string, boolean> todo, status` | Sort list alphabetically in ascending order  | ascending todolist  |
|                     |                                                      | Sort list alphabetically in descending order | descending todolist |