# Domain Model

`I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.`

| **Classes** | **Members** | **Methods** | **Scenario** | **Outputs** |
|:--:|:--:|:--:|:--:|:--:|
| `ToDoList` | `List<Job>` | `AddToList(Job job)` | Add task to ToDoList | `true` |
| `ToDoList` | `List<Job>` | `PrintJobs(List<Job> jobs)` | View all tasks in ToDoList | `true` |
| `Job` | `Complete` | `ChangeStatus(bool status)` | Changing status of task to complete | `true` |
| `Job` | `Complete` | `ChangeStatus(bool status)` | Changing status of task to incomplete | `true` |
| `ToDoList` | `List<Job>` | `GetJobs(bool status)` | Get tasks that is complete | `List<Job>` |
| `ToDoList` | `List<Job>` | `GetJobs(bool status)` | Get tasks that is incomplete | `List<Job>` |
| `ToDoList` | `List<Job>` | `GetJob(string name)` | Get existing task specified by name | `Job` |
| `ToDoList` | `List<Job>` | `RemoveJob(string name)` | Remove existing task from ToDoList | `true` |
| `ToDoList` | `List<Job>` | `RemoveJob(string name)` | Remove non existing task from ToDoList | `false` |
| `ToDoList` | `List<Job>` | `GetJobsOrdered(bool ascending)` | Get tasks in ascending order | `List<Job>` |
| `ToDoList` | `List<Job>` | `GetJobsOrdered(bool ascending)` | Get tasks in descending order | `List<Job>` |
