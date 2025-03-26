EXTENSION
Class TodoTask
properties:
    private int id
    string name
    bool isCompleted
Methods:
    void SetName(string name)

    void ToggleStatus()

Class TodoList
properties:
    List <TodoTask> tasks

methods:
TodoTask AddTask(string name)
    add name to new Task and set isCompleted to false, return true if task doesnt already exist, false if if it already exists. Add to tasks
TodoTask GetTask(int id)
    returns TodoTask if id exists
TodoTask UpdateTaskName(int id, string name)
    return updated task
TodoTask ToggleTaskStatus(int id)
    return updated task
CORE
I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.

Class TodoTask
    private int id
    string name
    bool isCompleted

Class TodoList
PROPETIES:
    List<TodoTask> tasks

Methods:
    TodoTask AddTask(string name)
        add name to new Task and set isCompleted to false, return TodoTask if task doesnt already exist, null if if it already exists
    bool RemoveTask(string name)
        check if task exists, remove from tasks, return new List<TodoTask>
    bool ToggleComplete(string name)
        get task by name, modify complete status by switching from true to false or reversed. return true if successful return false if task name is not in tasks
    string TaskExists(string name)
        get task by name, return "Task found in todo list" if found return "Task not found in list" if task name is not in tasks
    List<TodoTask> ShowAllTasks()
        return List<TodoTask> tasks
    List <TodoTask> ShowCompletedTasks()
        iterate through tasks and return a new List<TodoTask> with completed tasks
    List <TodoTask> ShowIncompletedTasks()
        iterate through tasks and return a new List<TodoTask> with incompleted tasks
    List <TodoTask> SortedTasksAsc()
        iterate through tasks and return a new List<TodoTask> sorted by name ascending
    List <TodoTask> SortedTasksDesc()
        iterate through tasks and return a new List<TodoTask> sorted by name descending

    I want to be able to get a task by a unique ID.
    I want to update the name of a task by providing its ID and a new name.
    I want to be able to change the status of a task by providing its ID.
    I want to be able to see the date and time that I created each task.