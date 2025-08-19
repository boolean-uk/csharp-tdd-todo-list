
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

