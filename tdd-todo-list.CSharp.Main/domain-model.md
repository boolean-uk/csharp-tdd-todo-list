


I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.

| Classes  | Methods                                    | Scenario                                      | Output                              |
|----------|--------------------------------------------|-----------------------------------------------|-------------------------------------|
| ToDoList | string addTask(String taskname, bool status)| task added or task not added                  | task got, or  not got anything      |
|          | Dictionary<string,bool> ViewAllTasks()     | view all tasks or not                   |      Dictionary <string name, bool status>|
|          | changeStatus(string task, bool isComplete) | status changed between complete/incomplete    | status is changed                   |
|          | getCompleteTasks()                         | task is completed                             | show completed task nothing to show |
|          | getIncompleteTasks()                       | task not completed                            | show not completed task             |
|          | searchTaskInList(string taskname)          | task is found task not found                  | string task string message          |
|          | removeTasks(string taskname)               | task is getting removed                       | string task is removed              |
|          | viewTasksAscending()                       | viewing list ordered alphabetically ascending |                                     |
|          | viewTasksDescending()                      |                                               |                                     |
|          |                                            |                                               |                                     |

