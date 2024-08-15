## Domain Model Requirements
I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.

I want to be able to get a task by a unique ID.
I want to update the name of a task by providing its ID and a new name.
I want to be able to change the status of a task by providing its ID.
I want to be able to see the date and time that I created each task.

Task == Job, because of the Task.cs already existing

| Classes         | Methods                                     | Scenario											 | Outputs   |
|-----------------|---------------------------------------------|----------------------------------------------------|-----------|
| `TodoList`	  | `AddJob(Job job)`				     		| User can add job object to its todo list           | bool	     |
|                 |                                             | If job already exist					             | bool      |
|                 |                                             |                       				             |           |
|                 | `GetAllJobs()`                              | User can get all job from the todo list            | List<Job> |
|                 |                                             |                       				             |           |
|                 | `ChangeJobStatus(int jobId)`                | Update/change the status of a job based on id      | bool      |
|                 |                                             | If job does not exist           		             | bool      |
|                 |                                             |                       				             |           |
|                 | `GetJobByStatus(Status status)`             | User can get all jobs based on the job status      | List<Job> |
|                 |                                             |                       				             |           |
|                 | `SearchJobByName(string jobName)`           | User can search for a job based on the jobName     | string    |
|                 |                                             | Searched job does not exist					     | string    |
|                 |                                             |                       				             |           |
|                 | `RemoveJob(int jobId)`                      | User can remove a job object from the todo list    | void      |
|                 |                                             | based on the jobs unique id                        |           |
|                 |                                             |                       				             |           |
|                 | `AllJobSorted(string order)`                | User can get all jobs sorted alphabetically based  | List<Job> |
|                 |                                             | on the incomning string (ascending/descending)     |           |
|                 |                                             |                       				             |           |
|                 | `GetJobById(int jobId)`                     | User can get a specific job based on a unique id   | Job       |
|                 |                                             |                       				             |           |
|                 | `UpdateJobName(int jobId, string newName)`  | User can update the name of a specific job         | Job       |
|                 |                                             |                       				             |           |
|-----------------|---------------------------------------------|----------------------------------------------------|-----------|
| `Job`           | `Job(int id, string name, Status status, `  | Job object for the Todo list                       |           |
|                 | `Date date)`                                |                       				             |           |
|                 | `Status`                                    | Enum for Job to be INCOMPLETE or COMPLETE          | ENUM      |
|                 |                                             |                       				             |           |
|-----------------|---------------------------------------------|----------------------------------------------------|-----------|
