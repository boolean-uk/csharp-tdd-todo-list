# Domain Modelling

## User Stories

### Core Tasks

- I want to add tasks to my todo list  
- I want to see all the tasks in my todo list  
- I want to change the status of a task between incomplete and complete  
- I want to be able to get only the complete tasks  
- I want to be able to get only the incomplete tasks  
- I want to search for a task and receive a message that says it wasn't found if it doesn't exist  
- I want to remove tasks from my list  
- I want to see all the tasks in my list ordered alphabetically in ascending order  
- I want to see all the tasks in my list ordered alphabetically in descending order  
- I want to prioritise tasks e.g. low, medium, high  
- I want to list all tasks by priority  

| Classes       | Methods/Properties                   | Scenario                                         | Outputs                  |
|---------------|--------------------------------------|--------------------------------------------------|---------------------------|
| TodoList.cs   | AddTask(string, int)                 | Add task with optional priority (1–3)            | Task added to list        |
| TodoList.cs   | Tasks (List<TaskItem>)               | View all tasks                                   | List of tasks             |
| TodoList.cs   | ChangeStatus(string, bool)           | Change task status (true = Complete, false = Incomplete)    | Updated task              |
| TodoList.cs   | GetOnlyCompletedTasks()              | Get tasks where IsDone = true                    | List of done tasks        |
| TodoList.cs   | GetOnlyIncompleteTasks()             | Get tasks where IsDone = false                   | List of not done tasks    |
| TodoList.cs   | SearchForTask(string)                | Search by task description                       | Task or "Task not found"  |
| TodoList.cs   | RemoveTask(string)                   | Remove a task                                    | Task removed              |
| TodoList.cs   | GetTasksSortedAscending()            | View tasks A–Z                                   | Sorted task list          |
| TodoList.cs   | GetTasksSortedDescending()           | View tasks Z–A                                   | Sorted task list          |
| TodoList.cs   | GetTasksByPriority(int)              | View tasks with given priority                   | Filtered list             |
| TaskItem.cs   | Description (string)                 | The task text                                    | e.g. "Buy groceries"      |
| TaskItem.cs   | IsDone (bool)                        | Task completion state                            | true / false              |
| TaskItem.cs   | Priority (int)                       | Task priority (1 = High, 2 = Medium, 3 = Low)     | 1–3                       |

### Extension Tasks

- I want to be able to get a task by a unique ID.
- I want to update the name of a task by providing its ID and a new name.
- I want to be able to change the status of a task by providing its ID.
- I want to be able to see the date and time that I created each task.
- I want to be able to see the date and time that I completed a task.
- I want to know which task took the longest amount of time to complete.
- I want to know which task took the shortest amount of time to complete.
- I want to know which tasks took longer than 5 days to complete.
- I want to categorise tasks e.g. study, work, admin etc
- I want to list all tasks by category