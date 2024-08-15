# Domain Model 

> I want to be able to get a task by a unique ID.

> I want to update the name of a task by providing its ID and a new name.

> I want to be able to change the status of a task by providing its ID.

> I want to be able to see the date and time that I created each task. 


| **Classes** |  **Methods** | **Scenario** | **Outputs** |
|:---:|:---:|:---:|:---:|
| `Extension` | getTask(int id) | receive a task by typing its id | string | 
|| updateName(int id, string name) | updates the name of a task, by providing its id and new name| List<TaskItem,> |
|| changeStatus(int id) | changes the tasks status by providing the tasks id | Status
|| seeDateAndTime(int id) | prints the date and time that the task was created | string
| `TaskItem`|
| enum  `Status` | INCOMPLETE, COMPLETE | Shows the status of the task |
