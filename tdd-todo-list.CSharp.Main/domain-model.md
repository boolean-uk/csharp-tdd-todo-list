
### Requirements: 
1. I want to add tasks to my todo list.
2. I want to see all the tasks in my todo list.
3. I want to change the status of a task between incomplete and complete.
4. I want to be able to get only the complete tasks.
5. I want to be able to get only the incomplete tasks.
6. I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
7. I want to remove tasks from my list.
8. I want to see all the tasks in my list ordered alphabetically in ascending order.
9. I want to see all the tasks in my list ordered alphabetically in descending order.

### Extended Reqirements:
10. I want to be able to get a task by a unique ID.
11. I want to update the name of a task by providing its ID and a new name.
12. I want to be able to change the status of a task by providing its ID.
13. I want to be able to see the date and time that I created each task.


### Domain Table

| **User Story ID** | **Classes** | **Method/Property**     | **Scenario**                                                                   | **Outputs**                                                                                | **Is Extension? (empty=False)** |
|-------------------|-------------|-------------------------|--------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------|---------------------------------|
| 1                 | TodoList    | AddTask                 | Add task with a string description/value                                       | String stored in list                                                                      |                                 |
| 10                | TodoList    | GetTask                 | Retrieve added task from list given ID                                         | returns requested Task instance                                                            | True                            |
| 2                 | TodoList    | GetTaskList_all         | Want all the tasks in a list                                                   | returns List of TaskEntry objects                                                          |                                 |
| 4                 | TodoList    | GetTaskList_completed   | Want all the completed tasks in a list                                         | returns List of all completed TaskEntry objects                                            |                                 |
| 5                 | TodoList    | GetTaskList_incompleted | Want all the incompleted tasks in a list                                       | returns List of all incompleted TaskEntry objects                                          |                                 |
| 3                 | TodoList    | ToggleTaskStatus        | Given task ID, Toggle status between incomplete/complete                       | if incomplete, call result in toggled to complete. if Complete, call results in incomplete | True                            |
| 6--               | TodoList    | SearchTask              | Want to be able to search for a task without knowing the Task ID               | returns list of Tasks that matches the search criteria, or if no matching enrties exist    |                                 |
| 7                 | TodoList    | RemoveTask              | Remove a task from the list based on task id                                   | List is changed with requested task removed                                                |                                 |
| 8                 | TodoList    | SetTaskOrder_Ascending  | Change order of tasks. Ascends in alphabetically order                         | List order is changed to ascending alphabetically                                          |                                 |
| 9                 | TodoList    | SetTaskOrder_Descending | Change order of tasks. Descends in alphabetically order                        | List order is changed to descending alphabetically                                         |                                 |
| extra             | TodoList    | SetTaskOrder_asAdded    | Change order of tasks to the order for when they where added                   | List order is changed to the order they where added                                        |                                 |
| 11                | TodoList    | EditTaskName            | Provide ID and new name to the task which we want to change                    | Task Entry is changed with the name                                                        | True                            |
|                   |             |                         |                                                                                |                                                                                            |                                 |
| 1                 | TaskEntry   | Constructor             | Create a Task Object, provide name and description                             | Task with name and description created                                                     |                                 |
| 13                | TaskEntry   | --                      | Upon creation, time and date should be stored, and a ID managed by owner.      | Task will have a creation date/time                                                        | True                            |
| 11                | TaskEntry   | SetName (Name prop)     | Change name of Task                                                            | Task name will be changed to provided name                                                 |                                 |
| 6                 | TaskEntry   | GetName (Name prop)     | Retrieve the name                                                              | returns Task name as string                                                                |                                 |
| 3,12              | TaskEntry   | Completed  (prop)       | Set Completion status to True/False                                            | Completion Status will be changed                                                          |                                 |
| 4,5               | TaskEntry   | Completed  (prop)       | Retrieve the task completion status                                            | Completion status will be returned as boolean value                                        |                                 |
|                   |             |                         |                                                                                |                                                                                            |                                 |