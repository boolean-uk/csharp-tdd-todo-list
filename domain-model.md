# Domain Model

## Entities:

### Task
| Field       | Type   | Description                                    |
|-------------|--------|------------------------------------------------|
| Description | string | The description of the task.                   |
| IsCompleted | bool   | Indicates whether this task is completed or not.|

#### Methods
| Method            | Return Type | Description                                 |
|-------------------|-------------|---------------------------------------------|
| Complete          | void        | Marks this task as complete.                |
| Incomplete        | void        | Marks this task as incomplete.              |

### TodoList
| Field      | Type          | Description                                     |
|------------|---------------|-------------------------------------------------|
| Tasks      | List<Task>    | List of all tasks in the todo list.             |
| SortOrder  | enum          | Used to decide the sort order in returned task lists.|

#### Methods
| Method                  | Return Type    | Description                                                 |
|-------------------------|----------------|-------------------------------------------------------------|
| AddTask                 | void           | Adds a new task based on input string to the todo list.     |
| RemoveTask              | void           | Removes the task at the specified index (last task if not specified).|
| CompleteTask            | void           | Marks the task at the specified index as complete (first task if not specified).|
| IncompleteTask          | void           | Marks the task at the specified index as incomplete (first task if not specified).|
| GetAllTasks             | List<Task>     | Returns all tasks.                                          |
| GetCompletedTasks       | List<Task>     | Returns all completed tasks.                                |
| GetIncompleteTasks      | List<Task>     | Returns all incomplete tasks.                               |
| GetTasksWithSubstring   | List<Task>     | Returns all tasks that contain the specified substring.   |
| SearchTasks            | string         | String representation of tasks obtained from GetTasksWithSubstring.|
