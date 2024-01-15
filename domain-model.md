
     
    I want to see all the tasks in my todo list.
    I want to change the status of a task between incomplete and complete.
    I want to be able to get only the complete tasks.
    I want to be able to get only the incomplete tasks.
    I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
    I want to remove tasks from my list.
    I want to see all the tasks in my list ordered alphabetically in ascending order.
    I want to see all the tasks in my list ordered alphabetically in descending order.


    I want to add tasks to my todo list.
| Classes    | Members                               | Methods                          | Scenario              | Outputs |
|------------|---------------------------------------|----------------------------------|-----------------------|---------|
| `ToDoList` | 'Dictionaly<string, bool> ToDo'       | `Add(string task, bool status`   |  Is not already added | true    |
|            |                                       |                                  |  Is already added     | false   |
|            |                                       |                                  |                       |         |

     
    I want to see all the tasks in my todo list.
| Classes    | Members                               | Methods                          | Scenario         | Outputs |
|------------|---------------------------------------|----------------------------------|------------------|---------|
| `ToDoList` | 'Dictionaly<string, bool> ToDo'       | `PrintAll()`                     |                  | bool    |
|            |                                       |                                  |                  |         |
|            |                                       |                                  |                  |         |

    I want to change the status of a task between incomplete and complete.
| Classes    | Members                               | Methods                                          | Scenario                                   | Outputs |
|------------|---------------------------------------|--------------------------------------------------|--------------------------------------------|---------|
| `ToDoList` | 'Dictionaly<string, bool> ToDo'       | `ChangeStatus(int index, bool newStatus)`        | Change the status of the given task        |         |
|            |                                       |                                                  |                                            |         |
|            |                                       |                                                  |                                                            |         |

    I want to be able to get only the complete tasks.
    I want to be able to get only the incomplete tasks.
| Classes    | Members                               | Methods                          | Scenario                                   | Outputs |
|------------|---------------------------------------|----------------------------------|--------------------------------------------|---------|
| `ToDoList` | 'Dictionaly<string, bool> ToDo'       | `PrintCompleteTasks()`           | Prints all completed tasks                 |   int   |
|            |                                       | `PrintIncompleteTasks()`         | Prints all incompleted tasks               |   int   |
|            |                                       |                                  |                                            |         |

    I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
| Classes    | Members                               | Methods                          | Scenario                                   | Outputs        |
|------------|---------------------------------------|----------------------------------|--------------------------------------------|----------------|
| `ToDoList` | 'Dictionaly<string, bool> ToDo'       | Search(string task)              | Searches the todo list for a given task    |  bool          |
|            |                                       |                                  |                                            |                |
|            |                                       |                                  |                                            |                |

    I want to remove tasks from my list.
| Classes    | Members                               | Methods                          | Scenario                                            | Outputs        |
|------------|---------------------------------------|----------------------------------|-----------------------------------------------------|----------------|
| `ToDoList` | 'Dictionaly<string, bool> ToDo'       | RemoveTask(int index)            | Removes a task from the list with the given index   |  bool          |
|            |                                       |                                  |                                                     |                |
|            |                                       |                                  |                                                     |                |

    I want to see all the tasks in my list ordered alphabetically in ascending order.
    I want to see all the tasks in my list ordered alphabetically in descending order.
| Classes    | Members                               | Methods                          | Scenario         | Outputs        |
|------------|---------------------------------------|----------------------------------|------------------|----------------|
| `ToDoList` | 'Dictionaly<string, bool> ToDo'       | PrintAllAlphabeticAsc()          |                  |  int           |
|            |                                       | PrintAllAlphabeticDesc()         |                  |                |
|            |                                       |                                  |                  |                |



    I want to be able to get a task by a unique ID.
    I want to update the name of a task by providing its ID and a new name.
    I want to be able to change the status of a task by providing its ID.
    I want to be able to see the date and time that I created each task.

| Classes             | Members                               | Methods                                 | Scenario         | Outputs        |
|---------------------|---------------------------------------|-----------------------------------------|------------------|----------------|
| `ToDoListExtension` | List<Task> ToDo                       | GetTaskById(int id)                     |                  |  Task          |
|                     |                                       | UpdateNameById(int id,string newName)   |                  |                |
|                     |                                       | UpdateStatusById(int id, bool status)   |                  |                |
|                     |                                       | PrintDateCreated()                      |                  |  Console       |

 
