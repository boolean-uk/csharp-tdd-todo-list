# Core Requirements & User stories
***
### 1. I want to add tasks to my todo list.
> As a user, <br> So I can add tasks to do, <br> I would like to add tasks to my TODO-list.

### 2. I want to see all the tasks in my todo list.
> As a user, <br> So I can see the tasks to do, <br> I would like to see all the tasks in my TODO-list.

### 3. I want to change the status of a task between incomplete and complete.
> As a user, <br> So I can know that the task is done, <br> I would like to change the status of a task in my TODO-list.

### 4. I want to be able to get only the complete tasks.
> As a user, <br> So I can see my previous tasks, <br> I would like to see tasks that are finished in my TODO-list.

### 5. I want to be able to get only the incomplete tasks.
> As a user, <br> So I can see my current tasks, <br> I would like to see tasks that are not finished in my TODO-list.

### 6. I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
> As a user, <br> So I can see a specific task, <br> I would like to search for tasks in my TODO-list.

### 7. I want to remove tasks from my list.
> As a user, <br> So I can remove a task, <br> I would like to remove tasks from my TODO-list.

### 8. I want to see all the tasks in my list ordered alphabetically in ascending order.
> As a user, <br> So I can see my tasks alphabetically, <br> I would like to order my tasks in an ascending order alphabetically in my TODO-list.

### 9. I want to see all the tasks in my list ordered alphabetically in descending order.
> As a user, <br> So I can see my tasks alphabetically, <br> I would like to order my tasks in a descending order alphabetically in my TODO-list.

***
# Domain Model

| **Classes** | **Methods** | **Scenario** | **Outputs** |
|:---:|:---:|:---:|:---:|
| `ToDoList` | Add(string task) | Add a task to a TODO-list | bool |
|  | ShowList(string task, bool isComplete) | Return tasks from the TODO-list | Dictionary<string, bool> |
|  | ChangeStatus(string task, bool isComplete) | Change the status of a task | bool |
|  | ShowCompleteTasks() | Return a list of completed tasks from the TODO-list | Dictionary<string, bool> |
|  | ShowIncompleteTasks() | Return a list of incomplete tasks from the TODO-list | Dictionary<string, bool> |
|  | SearchFor(string task) | Search for a task in the TODO-list. If the task does not exist it will display a message | Dictionary<string, bool> |
|  | Remove(string task) | Remove a task from the TODO-list | bool |
|  | ShowListAscending() | Return the TODO-list sorted alphabetically in ascending order | Dictionary<string, bool> |
|  | ShowListDescending() | Return the TODO-list sorted alphabetically in descending order | Dictionary<string, bool> |

