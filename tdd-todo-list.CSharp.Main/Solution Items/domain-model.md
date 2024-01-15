# Domain model for TODO list.

1. I want to add tasks to my todo list.

2. I want to see all the tasks in my todo list.

3. I want to change the status of a task between incomplete and complete.

4. I want to be able to get only the complete tasks.

5. I want to be able to get only the incomplete tasks.

6. I want to search for a task and receive a message that says it wasn't found if it doesn't exist.

7. I want to remove tasks from my list.

8. I want to see all the tasks in my list ordered alphabetically in ascending order.

9. I want to see all the tasks in my list ordered alphabetically in descending order.

## Domain Models In here
```
1. I want to add tasks to my todo list.

```

| Classes         | Methods                                            | Scenario										| Outputs          |
|-----------------|----------------------------------------------------|------------------------------------------------|------------------|
|`TodoList`		  |	`Add(string task)`				                   | add string task to Dictionary<strig,string>	| void             |

```
2. I want to see all the tasks in my todo list.
```

| Classes         | Methods                                            | Scenario							 | Outputs          |
|-----------------|----------------------------------------------------|-------------------------------------|------------------|
|`TodoList`		  |	`displayList(string sort)`						   | Display Dictionary<strig,string>	 | List<string>     |

```
3. I want to change the status of a task between incomplete and complete.
```

| Classes         | Methods                                            | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------|
|`TodoList`		  |	`changeStatus(string task, string status)`         |Change value based on key task	 | void             |


```
4. I want to be able to get only the complete tasks.
```

| Classes         | Methods                                            | Scenario							 | Outputs          |
|-----------------|----------------------------------------------------|-------------------------------------|------------------|
|`TodoList`		  |	`displayList(string sort)`				           | Display Dictionary<strig,string>	 | List<string>     |


```
5. I want to be able to get only the incomplete tasks.
```

| Classes         | Methods                                            | Scenario							 | Outputs          |
|-----------------|----------------------------------------------------|-------------------------------------|------------------|
|`TodoList`		  |	`displayList(string sort)`				           | Display Dictionary<strig,string>	 | List<string>     |


```
6. I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
```

| Classes         | Methods                                            | Scenario								   | Outputs          |
|-----------------|----------------------------------------------------|-------------------------------------------|------------------|
|`TodoList`		  |	`searchingTask(string task)`					   | Display task i in the List, else *message*| string           |


```
7. I want to remove tasks from my list.
```

| Classes         | Methods                                            | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------|
|`TodoList`		  |	`remove(string task)`				               | remove string task from the list| void             |


```
8. I want to see all the tasks in my list ordered alphabetically in ascending order.
```

| Classes         | Methods                                            | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------|
|`TodoList`		  |	`sort(Dictionary<strig,string> list, string order)`| Sort the list ascending order	 | List<string>     |


```
9. I want to see all the tasks in my list ordered alphabetically in descending order.
```

| Classes         | Methods                                            | Scenario                        | Outputs          |
|-----------------|----------------------------------------------------|---------------------------------|------------------|
|`TodoList`		  | `sort(Dictionary<strig,string> list, string order)`| Sort the list descending order	 | List<string>     |
