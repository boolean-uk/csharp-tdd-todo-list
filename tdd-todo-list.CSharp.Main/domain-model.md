## 

| Classes | Fields |
|-|-|
|`TodoList`| `List<string, bool> _items`|
|`TodoSorter` | |


| Classes | Methods | Scenario | Outputs |
|-|-|-|-|
| `TodoList` | `Add(string task)` | Add task to the list | bool |
| | `ListTasks()` | See all tasks in list | List<int, string, int> |
| | `SetTaskStatus(int index, bool completeStatus)` | Change task status based on task index | true |
| | | Provided index was not valid, no task status changed | false |
| | `GetCompleteTasks()` | Retrieve all tasks with complete status | List<int, string, int> | 
| | `GetImcompleteTasks()` | Retrieve all task with incomplete status | List<int, string, int> | 
| | `FindTask(string text)` | Find task by text | string | 
| | | Find task that does not exist | string |
| | `FindTask(int index)` | Find task by index | string | 
| | | Find task that does not exist | string |
| | `RemoveTask(int index)` | Remove a task based on index | true |
| |  | Can't remove task due to invalid index | false |
| `TodoSorter` | `SortAscending(List<int, string, int> items)` | Sort list in ascending order | List<int, string, int> |
| | `SortDescending(List<int, string, int> items)` | Sort list in descending order | List<int, string, int>| 