
I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.

Struct Task()
Properties
public string taskTitle;
public bool complete;


Class TodoList()

Properties
public Dictionary<int,Task>() todoList; //changed from a list to dictionary to have an Id conected to the task.


Methods

public AddTaskToList(Task task);
-Add a task to the list.

public List<String> ShowList(); return List of tasks

public bool ChangeStatus(Task taskToChange); //added a bool for if the task is not in the list
-Checks list for provided task.
-Change task if it is in the list.


----------------------------------------------------------------------------

I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.

public List<string> GetCompleatedTasks(); returns a list of compleated tasks.
-looks through todoList.
-put compleated tasks in a new list.
-return new list.

public List<srting> GetIncompleteTasks(); returns a list of incompleated tasks.
-looks through todoList.
-put incompleated tasks in a new list.
-return new list.

public string searchForTask(int taskId); looks for task with the ID.
-returns name of task and compleation status if found.
-send message if not found.



