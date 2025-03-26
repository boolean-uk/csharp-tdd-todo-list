# Extension Domain Model: Todo List

## Entities

### TodoItem
- **Fields**:
  - `int Id`: Unique identifier for the todo item.
  - `string Description`: Description of the todo item.
  - `DateTime CreationTime`: Date and time the item was created.
  - `bool IsDone`: Indicates whether the item is completed.
- **Methods**:
  - `void MarkDone()`: Marks the todo item as done.
  - `void MarkUndone()`: Marks the todo item as not done.

### TodoListManager
- **Fields**:
  - `List<TodoItem> todoItems`: List of todo items.
- **Methods**:
  - `void AddTodoItem(TodoItem)`: Adds a new todo item.
  - `void RemoveTodoItem(int)`: Removes a todo item by ID.
  - `TodoItem GetTodoItemById(int)`: Retrieves a todo item by ID.
  - `List<TodoItem> GetAllTodoItems(SortOrder)`: Gets all todo items.
  - `List<TodoItem> GetCompletedTodoItems(SortOrder)`: Gets all completed todo items.
  - `List<TodoItem> GetIncompleteTodoItems(SortOrder)`: Gets all incomplete todo items.
  - `List<TodoItem> SearchTodoItems(string, SortOrder)`: Searches todo items by description.