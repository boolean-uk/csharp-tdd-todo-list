# Core
1. I want to add tasks to my todo list.
2. I want to see all the tasks in my todo list.
3. I want to change the status of a task between incomplete and complete.
4. I want to be able to get only the complete tasks.
5. I want to be able to get only the incomplete tasks.
6. I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
7. I want to remove tasks from my list.
8. I want to see all the tasks in my list ordered alphabetically in ascending order.
9. I want to see all the tasks in my list ordered alphabetically in descending order.

| Class | properties |
|---|---|
| TodoList | `Dictionary<string description, bool isComplete> Tasks` |


| User story | Method | Scenario | Output |
|---|---|---|---|
| 1 | `Add(string description)` | | Adds `KeyValuePair<description, false>`|
| 2 | `Display()` | | Displays all entries |
| 4, 5 | `Display(bool isComplete)`  | | Displays all entries that has `value` equal to `isComplete` |
| 8 | `DisplayAscending()`  | | Displays all entries in ascending alphabetical order |
| 8, 5 | `DisplayAscending(ool isComplete)`  | | Displays all entries in ascending alphabetical order, that have `value` equal to parameter |
| 9 | `DisplayDescending()`  | | Displays all entries in descending alphabetical order |
| 9, 5 | `DisplayDescending(bool isComplete)`  | | Displays all entries in descending alphabetical order, that have `value` equal to parameter |
| 3 | `Complete(string description)` | String matches a entry | Sets the `value` the entry `TodoList` to `true` |
|   |                    | String does not match a entry | Displays `"Not found"`|
| 6 | `Search(string description)`   | String matches a entry | Displays matching entry |
|   |                    | String does not match a entry | Displays `"Not found"` |
| 7 | `Remove(string description)`   | String matches a entry | Removes entry with `key` equal to parameter|
|   |                    | String does not match a entry | Displays `"Not found"`|

# Extension
1. I want to be able to get a task by a unique ID.
2. I want to update the name of a task by providing its ID and a new name.
3. I want to be able to change the status of a task by providing its ID.
4. I want to be able to see the date and time that I created each task.

| Class | properties |
|---|---|
| TodoList | `Dictionary<int id, Task task> Tasks` |
| Task | `string Description`, `bool IsComplete`, `DateTime Time` |


| User story | Method | Scenario | Output |
|---|---|---|---|
| 1 | `Search(int id)` | ID String matches a entry | Displays matching entry |
|   |              | ID does not match a entry | Displays `"Not found"` |
| 2 | `Rename(int id, string Description)` | String matches a entry | Change name of entry with key coresponding to   |
|   |                           | String does not match a entry | Displays `"Not found"` |
| 3 | `Complete(int id)` | ID matches a entry | Change entrys `IsComplete` to `true`  |
|   |                           | ID does not match a entry | Displays `"Not found"` |
| 4 | `Display()` | | Displays all entries with time of creation |