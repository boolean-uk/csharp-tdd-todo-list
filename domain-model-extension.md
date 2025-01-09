# Domain model


| Classes     | Methods/Properties | Scenarios                    | Outputs |
|-------------|--------------------|------------------------------|---------|
| TodoTask.cs | int id | The unique identifier of this task |       |
| TodoTask.cs | string Name | Returns the name of the task |    |
| TodoTask.cs | DateTime Created | Stores the creation time of the task |         |
| TodoTask.cs | bool Completed | The completion status of the task |   |
| TodoListExtension.cs | Add() | Creates a new TodoTask object and adds it to the list | The id of the task |
| TodoListExtension.cs | Get(int id) | Gets the task tied to the id. If the id does not exist, throws an ArgumentException | int id or ArgumentException |
| TodoListExtension.cs | Remove(int id)   | Removes the task tied to the id. If the id does not exist, throws an ArgumentException | |
| TodoListExtension.cs | TaskList   | Gets the list of tasks. | List\<TodoTask>, the task list        |
| TodoListExtension.cs | GetSortedTaskList(bool asc)   | Gets the task list sorted alphabetically, ascending or descending based on arg. | List\<TodoTask>, the sorted task list |
| TodoListExtension.cs | GetTaskCreatedDate(int id)   | Gets the creation date of the task tied to the id. If the id does not exist, throws an ArgumentException | DateTime or ArgumentException |
| TodoListExtension.cs | UpdateName(int id, string name)   | Updates the name of the task tied to the provided Id. If the id does not exist, throws an ArgumentException |  |
| TodoListExtension.cs | ContainsId(int id)   | Checks if the id exists in the task list. | true / false |
| TodoListExtension.cs | ContainsName(string name)   | Checks if the name exists in the task list | true / false |
| TodoListExtension.cs | ToggleStatus(int id)   | Toggles the completion of the given task. Raises ArgumentException if invalid Id | bool, the new status |

