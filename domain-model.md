

### Todo | Core

| Classes | Members                 | Methods                                | Returns                                                                       |   |
|---------|-------------------------|----------------------------------------|-------------------------------------------------------------------------------|---|
| ToDo    | Dictionary<string, int> | AddTask(string Task)                   | true if succesful, otherwise false                                            |   |
|         |                         | GetTasks()                             | returns the Dictionary of tasks                                               |   |
|         |                         | ChangeStatus(string Task, bool status) | returns true if changed, otherwise false                                      |   |
|         |                         | Search(string task): string            | "Not Found" if the task doesn't exist, and "Exists" otherwise                 |   |
|         |                         | RemoveTask(string task): bool          | true if the task was found and removed, and  false otherwise                  |   |
|         |                         | OrderAlphabetically(): List<string>    | A list of all tasks in the todo list, sorted alphabetically by task name      |   |
|         |                         | OrderByDescending(): List <string>     | A list of all tasks in the todo list, sorted in descending order by task name |   |


### Todo  | Extension

| Classes   | Members                         | Methods                        | Returns                                                                                   |   |
|-----------|---------------------------------|--------------------------------|-------------------------------------------------------------------------------------------|---|
| Task      | string Name                     |                                | The task name                                                                             |   |
|           | bool status                     |                                | The task status (true for completed, false for incomplete)                                |   |
|           | Date date                       |                                | The task creation date                                                                    |   |
| Extension | Dictionary<int, Task> _todoList | Add(string name): bool         |                                                                                           |   |
|           |                                 | GetTaskById(int id): Task      |                                                                                           |   |
|           |                                 | UpdateTask(int id, string name | Overloaded to support only changing name, id or status, And all. Returns true if updated. |   |
|           |                                 |                                |                                                                                           |   |
