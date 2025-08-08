# Core requirements

1. I want to add tasks to my todo list.
2. I want to see all the tasks in my todo list.
3. I want to change the status of a task between incomplete and complete.
4. I want to be able to get only the complete tasks.
5. I want to be able to get only the incomplete tasks.
6. I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
7. I want to remove tasks from my list.
8. I want to see all the tasks in my list ordered alphabetically in ascending order.
9. I want to see all the tasks in my list ordered alphabetically in descending order.
10. I want to prioritise tasks e.g. low, medium, high
11. I want to list all tasks by priority

# Domain Model

## 1. Add tasks to my todo list
| Classes      | Methods/Properties        | Scenario                        | Outputs         |
|--------------|---------------------------|---------------------------------|-----------------|
| ToDoList     | Add(TodoTask task)        | Adds a new task to the list     | bool            |

## 2. See all the tasks in my todo list
| Classes      | Methods/Properties        | Scenario                        | Outputs         |
|--------------|---------------------------|---------------------------------|-----------------|
| ToDoList     | Tasks (property)          | Returns all tasks               | List<TodoTask>  |

## 3. Change the status of a task
| Classes      | Methods/Properties             | Scenario                        | Outputs         |
|--------------|--------------------------------|---------------------------------|-----------------|
| ToDoList     | IsComplete (property)          | Set to true/false for status    | bool            |

## 4. Get only the complete tasks
| Classes      | Methods/Properties         | Scenario                        | Outputs         |
|--------------|----------------------------|---------------------------------|-----------------|
| TodoList     | CompletedTasks (property)  | Returns only completed tasks    | List<TodoTask>  |

## 5. I want to be able to get only the incomplete tasks.
| Classes      | Methods/Properties         | Scenario                        | Outputs         |
|--------------|----------------------------|---------------------------------|-----------------|
| TodoList     | InCompletedTasks (property)| Returns only incompleted tasks  | List<TodoTask>  |

## 6. I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
| Classes      | Methods/Properties         | Scenario                        | Outputs                                    |
|--------------|----------------------------|---------------------------------|--------------------------------------------|
| ToDoList     | FindTaskByName(string name)| Detects name in Tasks or not	  | string with Task name or "Task not found"  |

## 7. I want to remove tasks from my list.
| Classes      | Methods/Properties         | Scenario                        | Outputs  |
|--------------|----------------------------|---------------------------------|----------|
| ToDoList     | Remove(TodoTask task)      | Removes a task from the list	  |bool      |

## 8. I want to see all the tasks in my list ordered alphabetically in ascending order.
| Classes      | Methods/Properties         | Scenario                        | Outputs       |
|--------------|----------------------------|---------------------------------|---------------|
| ToDoList     | OrderBy(TodoTask Name)     | Orders list of task by name	  |List<TodoTask> |

## 9. I want to see all the tasks in my list ordered alphabetically in descending order.
| Classes      | Methods/Properties               | Scenario                          | Outputs         |
|--------------|----------------------------------|-----------------------------------|-----------------|
| ToDoList     | OrderByDescending(TodoTask Name) | Orders list of task by name desc  |  List<TodoTask> |

## 10. I want to prioritise tasks e.g. low, medium, high
| Classes                  | Methods/Properties               | Scenario                                     | Outputs         |
|--------------------------|----------------------------------|----------------------------------------------|-----------------|
| TodoTask                 | Priority (property of type enum) | Each task has a priority: low/medium/high    |  Priority       |

## 11. I want to list all tasks by priority
| Classes                  | Methods/Properties               | Scenario                          | Outputs         |
|--------------------------|----------------------------------|-----------------------------------|-----------------|
| ToDoList                 | TasksByPriority (property)       | Assign priority to a task         | List<TodoTask>  |