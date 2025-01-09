# Domain model


| Classes     | Methods/Properties | Scenarios                    | Outputs |
|-------------|--------------------|------------------------------|---------|
| TodoList.cs | Add(string task)   | Adds an incompleted task to the todo list |         |
| TodoList.cs | TaskList   | Gets the entire task list | List\<string>, the tasks |
| TodoList.cs | IsComplete(string task)   | Checks if a task is complete | The completeness, bool |
| TodoList.cs | ToggleComplete(string task)   | Toggles the status of a task | The new status, bool |
| TodoList.cs | GetCompleted()   | Gets all the completed tasks | List\<string>, the completed tasks |
| TodoList.cs | GetIncomplete()   | Gets all the incompleted tasks | List\<string>, the incompleted tasks |
| TodoList.cs | Get(string task)   | Gets task if it exists, otherwise "Task not found" | string with the result |
| TodoList.cs | Remove(string task)   | Removes a task from the list | bool, if it was removed or not |
| TodoList.cs | GetSortedTaskList(bool asc)   | Gets the task list sorted alphabetically, ascending or descending based on arg. | List\<string>, the sorted task list        |
