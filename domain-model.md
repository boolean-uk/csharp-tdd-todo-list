| Class | Task                                                   | Method/Property                       | Input                  | Output          |
|-------|--------------------------------------------------------|---------------------------------------|------------------------|-----------------|
|       | Add tasks to list                                      | Add(string task)                      | String                 | Success/fail    |
|       | See all tasks in list                                  | GetList()                             | None                   | List of tasks   |
|       | Change status between complete and incomplete          | ChangeTaskStatus(bool status)         | New status             | Success/fail    |
|       | Retrieve completed tasks                               | GetList(                              | None                   | List of tasks   |
|       | Retrieve uncomplete tasks                              | GetList()                             | None                   | List of tasks   |
|       | Search for task, get message if task is not found      | Search(task)                          | Task                   | Task or message |
|       | Remove task from list                                  | Remove(task)                          | Task to remove         | Success/fail    |
|       | See all tasks ordered alphabetically ascending order   | GetList()                             | None                   | List of tasks   |
|       | See all tasks ordered alphabetically descending order  | GetList()                             | None                   | List of tasks   |
|       | List all tasks by priority                             | GetList()                             |                        |                 |
|       |                                                        |                                       |                        |                 |
|       | Get task by unique ID                                  | Search(int id)                        | unique id              | Task            |
|       | Update name of task by providing ID and new name       | Rename(int id, string NewName)        | unique id and new name | Success/failure |
|       | See datetime of task creation                          | Add() / timestarted                   | None                   | Datetime        |
|       | See datetime of task completion                        | ChangeTaskStatus / timecompleted      | None                   | Datetime        |
|       | Get task that took longest time to complete            | GetList                               | None                   | Task            |
|       | Get task that took shortest time to complete           | GetList()                             | None                   | Task            |
|       | Get all tasks that took longer than 5 days to complete | GetList()                             | 5 days                 | List of tasks   |
|       | Categorize task by area                                | SetCategory(task id, string category) | unique id and category | Success/failure |
|       | List all tasks by category                             | GetList()                             | Category               | List of tasks   |