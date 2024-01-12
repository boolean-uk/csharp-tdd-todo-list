## 

| Classes | Fields |
|-|-|
|`TodoList`| `Dictionary<string, bool> _items`|
|`TodoSorter` | |


| Classes | Methods | Scenario | Outputs |
|-|-|-|-|
| `TodoList` | `Add(string task)` | Add task to the list | bool |
| | `ListTasks()` | See all tasks in list | Dictionary<string, bool> |
| | `SetTaskStatus(int index, bool completeStatus)` | Change task status based on task index | true |
| | | Provided index was not valid, no task status changed | false |
| | `GetCompleteTasks()` | Retrieve all tasks with complete status | Dictionary<string, bool> | 
| | `GetImcompleteTasks()` | Retrieve all task with incomplete status | Dictionary<string, bool> | 
| | `FindTask(string text)` | Find task by text | string | 
| | | Find task that does not exist | string |
| | `RemoveTask(string text)` | Remove a task based on text | true |
| |  | Can't find the provided text | false |
| `TodoSorter` | `SortAscending(Dictionary<string, bool> items)` | Sort list in ascending order | Dictionary<string, bool> |
| | `SortDescending(Dictionary<string, bool> items)` | Sort list in descending order | Dictionary<string, bool>| 