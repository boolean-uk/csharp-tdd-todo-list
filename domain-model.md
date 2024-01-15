```
 User stories

 * I want to add tasks to my todo list.
 * I want to see all the tasks in my todo list.
 * I want to change the status of a task between incomplete and complete.
 * I want to be able to get only the complete tasks.
 * I want to be able to get only the incomplete tasks.
 * I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
 * I want to remove tasks from my list.
 * I want to see all the tasks in my list ordered alphabetically in ascending order.
 * I want to see all the tasks in my list ordered alphabetically in descending order.
```






| Classes           | Members                                                                 | Methods                                               | Scenario                       | Outputs |
|-------------------|-------------------------------------------------------------------------|-------------------------------------------------------|--------------------------------|---------|
| `TodoList`        | `Dictionary<string, string> Todos (key is description, value is status` | `AddTodo(string description)`                         | Todo *is not* already in todos | true    | 
|                   |                                                                         |                                                       | Todo *is* already in todos     | false   |
|                   |                                                                         | `ShowAllTodos()`                                      |                                | Todos   |
|                   |                                                                         | `ChangeTodoStatus(string description, string status)` | Todo *is not* in todos         | false   |
|                   |                                                                         |                                                       | Todo *is* in todos             | true    |
|                   |                                                                         | `ShowCompletedTasks()`                                |                                | Todos   |
|                   |                                                                         | `ShowIncompeleteTasks()`                              |                                | Todos   |
|                   |                                                                         | `SearchForTask(string description)`                   | Todo *is not* in todos         | string  |
|                   |                                                                         |                                                       | Todo *is* in todos             | string  |
|                   |                                                                         | `RemoveTodo(string description)`                      | Todo *is not* in todos         | false   |
|                   |                                                                         |                                                       | Todo *is* in todos             | true    |
|                   |                                                                         | `ShowTodosAlphabeticallyAscending()`                  |                                | Todos   |
|                   |                                                                         | `ShowTodosAlphabeticallyDescending()`                 |                                | Todos   |

```
User stories

 * I want to be able to get a task by a unique ID.
 * I want to update the name of a task by providing its ID and a new name.
 * I want to be able to change the status of a task by providing its ID.
 * I want to be able to see the date and time that I created each task.
```



| Classes           | Members                                                                 | Methods                                                 | Scenario                       | Outputs   |
|-------------------|-------------------------------------------------------------------------|---------------------------------------------------------|--------------------------------|-----------|
| `Extension`       | List<Todo> todos (Todo contains, id, description, status, dateTime)     | `GetTodoById(int id)`                                   | Todo by id *is* in todos       | Todo      |
|                   |                                                                         | `UpdateTodoDescriptionById(int id, string description)` | Todo by id *is not* in todos   | false     | 
|                   |                                                                         |                                                         | Todo by id *is* in todos       | true      |
|                   |                                                                         | `UpdateTodoStatusById(int id, string status)`           | Todo by id *is not* in todos   | false     |
|                   |                                                                         |                                                         | Todo by id *is* in todos       | true      |
|                   |                                                                         | `AllTodosDateAndTimeAdded()`                            |                                | TodosList |