## 
# Core
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
| | `FindTask(string text)` | Find task by text | true | 
| | | Find task that does not exist | false |
| | `RemoveTask(string text)` | Remove a task based on text | true |
| |  | Can't find the provided text | false |
| `TodoSorter` | `static SortAscending(Dictionary<string, bool> items)` | Sort list in ascending order | Dictionary<string, bool> |
| | `static SortDescending(Dictionary<string, bool> items)` | Sort list in descending order | Dictionary<string, bool>| 

## Extension

| Classes | Fields |
|-|-|
|`Extension` | `Dictionary<string, ToDoItem> _items` |
|`ToDoItem` | `string name` `DateTime _creationDate` `string _creationTime` `bool status`|

| Classes | Methods | Scenario | Outputs |
|-|-|-|-|
| Extension | `Add(string task)` | Added todotask to list | true |
| | | Failed to add todotask to list | false|
| | `RetrieveTask(string ID)` | Get task by unique ID | ToDoItem |
| | `UpdateTaskName(string ID, string newName)` | Update the ToDoItem name associated with the provided ID | true |
| | | Could not update ToDoItem due to invalid ID | false |
| | `ChangeTaskStatus(string ID)` | Change the status of the task associated with provided ID | bool |
| | | Could not change ToDoItem status due to invalid ID | false |
| | `RetrieveTaskDate()` | Retrieve date and time for each task created | out / console | 
| `ToDoItem` | `RetrieveDateTime()` | Retrieve creation date and time for the task | string |