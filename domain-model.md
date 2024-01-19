I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.

```
public struct Todo
	int id
	string name
	bool done
	

public class TodoList
PROPERTIES:
	private _lastId = 0;
	List<Todo> todoList 

Methods:
public void Add(string textDesc)
public List<Todo> Tasks()
public void changeStatus(int id) // change status of specified task
public List<Todo> CompletedTasks() //return all tasks with done == true
public List<Todo> InompleteTasks() //return all tasks with done == false
public string searchTask(int id) // return message if task was not found
public void Remove(int id) // remove specified id
public List<Todo> TasksAscending() // return list of tasks that is in acending order based on the description
public List<Todo> TasksDecending() // return list of tasks that is in decending order based on the description

```


I want to be able to get a task by a unique ID.
I want to update the name of a task by providing its ID and a new name.
I want to be able to change the status of a task by providing its ID. (same as cores changeStatus method????)
I want to be able to see the date and time that I created each task.


```
public struct Todo
	int id
	string name
	bool done

	//Extension
	Date dateCreated
	Time timeCreated
	

public class TodoList
PROPERTIES:
	private _lastId = 0;
	List<Todo> todoList 

Methods:
public void Add(string textDesc)
public List<Todo> Tasks()
public void changeStatus(int id) // change status of specified task
public List<Todo> CompletedTasks() //return all tasks with done == true
public List<Todo> InompleteTasks() //return all tasks with done == false
public string searchTask(int id) // return message if task was not found
public void Remove(int id) // remove specified id
public List<Todo> TasksAscending() // return list of tasks that is in acending order based on the description
public List<Todo> TasksDecending() // return list of tasks that is in decending order based on the description

//Extension
public Todo getTaskByID(int id)
public void updateName(int id, string newDesc)
public List<string> getDateTime() // return list of strings with $"Task {id} was created date:{date} and time:{time}"

```