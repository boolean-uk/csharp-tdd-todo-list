Core requirements.

| Classes  | Methods                        | Scenario                                                 | Output |
|----------|--------------------------------|----------------------------------------------------------|--------|
| ToDoList | Add(string task)               | Add task to list                                         | void   |
| ToDoList | GetAll                       | Print all tasks in list                                  | List   |
| Task     | ChangeStatus(int id) | Changes the status between incomplete and complete       | bool   |
| ToDoList | GetCompleted                   | Shows only the completed tasks                           | List   |
| ToDoList | GetIncomplete                  | Shows only the incomplete tasks                          | List   |
| ToDoList | SearchTask(string task)        | Searches for task and gives status on found or not found | bool   |
| ToDoList | Remove(string task)            | removes task from list                                   | void   |
| ToDoList | ShowAlpAscending               | see all in alphabetical ascending order                  | List   |
| ToDoList | ShowAlpDecending               | see all in alphabetical descending order                 | List   |
| Task     | SetPriority(int priority)      | sets the priority for the task                           | bool   |
| ToDoList | ShowByPriority                 | see all sorted by priority, highest to lowest            | List   |

Extension requirement:

| Classes  | Methods                             | Scenario                                                   | Output    |
|----------|-------------------------------------|------------------------------------------------------------|-----------|
| ToDoList | GetTaskById(int id)                 | get task by in number                                      | task      |
| Task     | SetId(int id)                       | Set id number for task                                     | bool      |
| ToDoList | UpdataName(int id, string newName)  | Update task name by id and new name                        | bool      |
| ToDoList | ChangeStatus(int id, string status) | change the status of a task by providing id and new status | bool      |
| Task     | GetTimeCreated(int id)              | get the date and time a task was created                   | Time/Date |
| Task     | GetTimeCompleted(int id)            | get the date and time a task war completed                 | Time/Date |
| ToDoList | LongestTime                         | show which task took the longest to complete               | task      |
| ToDoList | ShortestTime                        | show which task took the shortest to complete              | task      |
| ToDoList | LongerThanFiveToComplete            | show which task took linger than 5 days to complete        | task      |
| ToDoList | CategoriseTasks(string category)    | categorise tasks (study, work, admin)                      | bool      |
| ToDoList | ListByCategory                      | show all tasks sorted by category                          | List      |