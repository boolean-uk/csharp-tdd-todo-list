
```
- I want to add tasks to my todo list.
- I want to see all the tasks in my todo list.
- I want to change the status of a task between incomplete and complete.
- I want to be able to get only the complete tasks.
- I want to be able to get only the incomplete tasks.
- I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
- I want to remove tasks from my list.
- I want to see all the tasks in my list ordered alphabetically in ascending order.
- I want to see all the tasks in my list ordered alphabetically in descending order.
```

| Class    | Member Variables                    | Method           | Scenario                   | Result                |
|----------|-------------------------------------|------------------|----------------------------|-----------------------|
| TodoList | Dictionary<string, string> taskList | add(string task) | If string not in hashmap   | add to hashmap        |
|          |                                     |                  | If string exists in hashmap | don't add (key exist) |

| Class    | Member Variables                    | Method     | Scenario                   | Result          |
|----------|-------------------------------------|------------|----------------------------|-----------------|
| TodoList | Dictionary<string, string> taskList | viewTask() | If taskList exists          | return taskList |
|          |                                     |            | If taskList doesn't exist  | return taskList |

| Class    | Member Variables                    | Method                  | Scenario                     | Result        |
|----------|-------------------------------------|-------------------------|------------------------------|---------------|
| TodoList | Dictionary<string, string> taskList | updateTask(string task) | If string value is different | Set new value |
|          |                                     |                         | If string value is the same  | Set new value |

| Class    | Member Variables                    | Method              | Scenario                 | Result          |
|----------|-------------------------------------|---------------------|--------------------------|-----------------|
| TodoList | Dictionary<string, string> taskList | viewCompletedTask() | Loop to see value of key | return taskList |
|          |                                     |                     | is Complete              |                 |

| Class    | Member Variables                    | Method                | Scenario                 | Result          |
|----------|-------------------------------------|-----------------------|--------------------------|-----------------|
| TodoList | Dictionary<string, string> taskList | viewIncompletedTask() | Loop to see value of key | return taskList |
|          |                                     |                       | is Incomplete            |                 |

| Class    | Member Variables                    | Method                | Scenario                   | Result                 |
|----------|-------------------------------------|-----------------------|----------------------------|------------------------|
| TodoList | Dictionary<string, string> taskList | findTask(string task) | If value exists in taskList | return taskList<key>   |
|          |                                     |                       | If value not in taskList   | return "doesn't exist" |

| Class    | Member Variables                    | Method                  | Scenario                | Result                 |
|----------|-------------------------------------|-------------------------|-------------------------|------------------------|
| TodoList | Dictionary<string, string> taskList | removeTask(string task) | If task exists in taskList  | return true            |
|          |                                     |                         | If task not in taskList | return "doesn't exist" |

| Class    | Member Variables                    | Method                   | Scenario | Result        |
|----------|-------------------------------------|--------------------------|----------|---------------|
| TodoList | Dictionary<string, string> taskList | sortAscTask()            |          | return string |
|          |                                     |                          |          |               |

| Class    | Member Variables                    | Method         | Scenario | Result        |
|----------|-------------------------------------|----------------|----------|---------------|
| TodoList | Dictionary<string, string> taskList | sortDescTask() |          | return string |
|          |                                     |                |          |               |
