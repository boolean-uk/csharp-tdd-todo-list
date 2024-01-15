classes	 | Members												| Methods																																						 |
---------|------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------|
Task	 | string title, string description, bool isComplete	| ToggleStatus(); ToString();                                                                                                                                    |
---------|------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------|
ToDoList | List <Dictionary<string, object>> tasks				| AddTask(string title); RemoveTask(string title); GetAllTasks(); GetCompletedTasks(); GetIncompleteTasks(); SearchTask(string title); OrderByTitleAscending(); OrderByTitleDescending();|
---------|------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------|


Scenarios:

GetAllTasks(): User wants to see all tasks in the ToDoList;

ChangeStatus(): User wants to change status on tasks COMPLETE|INCOMPLETE;

RemoveTask(): User wants to remove a task from the list;

AddTask(): User wants to add a task to the list;

GetCompletedTasks(): User wants to return all the completed tasks;

GetIncompleteTasks(); User wants to return all the incomplete tasks;

SearchTask(); User wants to search for a task in the ToDoList, and return a message saying it's not in the list if not there;

OrderByTitleAscending(): User wants to display tasks in alphabetical order;

OrderByTitleDescending(): User wants to display tasks in tasks in a descendiing alphabetical order;

