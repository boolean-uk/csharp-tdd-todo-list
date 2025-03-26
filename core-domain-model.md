# Domain Models

| Classes    | Methods                     | Scenario               | Outputs                    |
|------------|-----------------------------|------------------------|----------------------------|
| `TodoList` | `add(string task)`          | if task in not in list | `true`                     |
|            |                             | if task is in list     | `false`                    |
| `TodoList` | `tasks()`                   |                        | `Dictionary<string, bool>` |
| `TodoList` | `changeStatus(string task)` | if task in not in list | `true`                     |
|            |                             | if task is in list     | `false`                    |
| `TodoList` | `completeTasks()`           |                        | `Dictionary<string, bool>` |
| `TodoList` | `incompleteTasks()`         |                        | `Dictionary<string, bool>` |
| `TodoList` | `search(string task)`       | if task is in list     | task                 |
|            |                             | if task in not in list | `"task not found"`         |
| `TodoList` | `remove(string task)`       | if task in not in list | `false`                    |
|            |                             | if task is in list     | `true`                     |
| `TodoList` | `tasksInAscOrder()`         |                        | `List<KeyValuePair<string, bool>>` |
| `TodoList` | `tasksInDescOrder()`        |                        | `List<KeyValuePair<string, bool>>` |

