
## Core ##
| Methods/Properties                                  | Scenario                                              | Outputs                                                      |
|-----------------------------------------------------|-------------------------------------------------------|--------------------------------------------------------------|
| AddTask(Task task)                                  | add task to list                                      | None                                                         |
| ListTasks()                                         | see all tasks in list                                 | List of all tasks                                            |
| SetTaskStatus(string name, TaskStatus status)       | change the status of a task                           | None                                                         |
| ListCompletedTasks()                                | list complete tasks                                   | List of complete tasks                                       |
| ListIncompleteTasks()                               | list incomplete tasks                                 | List of incomplete tasks                                     |
| FindTask(string name)                               | find given task                                       | The desired task or an error message                         |
| RemoveTask(string name)                             | remove task                                           | Removes the desired task if found                            |
| ListTasksAlphabeticallyOrderedByAscending()         | list tasks ordered alphabetically in ascending order  | A list of of tasks ordered alphabetically in ascending order |
| ListTasksAlphabeticallyOrderedByDescending()        | list tasks ordered alphabetically in descending order | A list of tasks ordered alphabetically in descending order   |
| SetTaskPriority(string name, TaskPriority priority) | prioritise tasks e.g. low, medium, high               | None                                                         |
| ListTasksByPriority()                               | list all tasks by priority                            | A list of tasks ordered by priority                          |

## Extensions ##

| Methods/Properties                             | Scenario                                                     | Outputs                                                 |
|------------------------------------------------|--------------------------------------------------------------|---------------------------------------------------------|
| GetTask(Guid id)                               | get a task by unique id                                      | Task with id                                            |
| UpdateTaskName(Guid id, string name)           | update the name of a task by providing id and name           | None                                                    |
| SetTaskStatus(Guid id, TaskStatus status)      | change the status of a task with id                          | None                                                    |
| GetTaskTimeOfCreation(Guid id)                 | see date and time of task creation                           | Date and time of task creation                          |
| GetTaskTimeOfCompletion(Guid id)               | see date and time of task completion                         | Date and time of task completion                        |
| FindLongestCompletedTask()                     | know which task took the longest amount of time to complete  | Task that took the longest amount of time to complete   |
| FindShortestCompletedTask()                    | know which task took the shortest amount of time to complete | Task that took the shortest amount of time to complete  |
| FindTasksCompletedInMoreThan5Days()            | know which tasks took longer than 5 days to complete         | A list of tasks that took  more than 5 days to complete |
| CategoriseTask(Guid id, TaskCategory category) | categorise tasks e.g. study, work, admin etc                 | None                                                    |
| ListByCategory()                               | list all tasks by category                                   | A list of tasks ordered by category                     |


