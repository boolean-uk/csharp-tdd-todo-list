## 

| Classes | Fields |
|-|-|
|`TodoList`| `Dictionary<string, bool> _items`|
|`TodoSorter` | |


| Classes | Methods | Scenario | Outputs |
|-|-|-|-|
| `TodoList` | `Add(string task)` | Add task to the list | bool |
| | `ListTasks()` | See all tasks in list | Dictionary<string, bool> |
| | `SetTaskStatus(string task, bool completeStatus)` | Change task status based on task text | true |
| | | Provided task was not valid, no task status changed | false |
| | `GetCompleteTasks()` | Retrieve all tasks with complete status | Dictionary<string, bool> | 
| | `GetIncompleteTasks()` | Retrieve all task with incomplete status | Dictionary<string, bool> | 
| | `FindTask(string text)` | Find task by text | string | 
| | | Find task that does not exist | string |
| | `RemoveTask(string text)` | Remove a task based on text | true |
| |  | Can't find the provided text | false |
| `TodoSorter` | `static SortAscending(Dictionary<string, bool> items)` | Sort list in ascending order | Dictionary<string, bool> |
| | `static SortDescending(Dictionary<string, bool> items)` | Sort list in descending order | Dictionary<string, bool>| 