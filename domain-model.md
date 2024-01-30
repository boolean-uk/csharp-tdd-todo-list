// Domain model Todo List

Class Task
PROPERTIES
- string name;
- bool complete;


Class TodoList
PROPERTIES
- List<Task> tasks;


METHODS
- void AddTask(Task task); 
- GetList; returns a list of tasks with their status (complete/incomplete)
- ChangeStatus; return true if status is changed, returns false when task not found. 
- GetComplete; returns a list of completed tasks;
- GetIncomplete; returns a list of incomplete tasks;
- SearchTask(Task task); returns a string message when the task was not found in the list;
- RemoveTask(Task task); removes a task and returns a string message when the task was not found;
- SortAsc; return a list of tasks ordered alphabetically in ascending order;
- SortDesc; return a list of tasks ordered alphabetically in descending order;