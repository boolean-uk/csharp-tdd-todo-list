addTask(string, bool) 
listAllTasks()
changeStatus(string, bool) 
listAllCompletedTasks() 
listAllIncompletedTasks() 
searchTask(string) 
removeTask(string) 
listAllTasksAscending() 
listAllTasksDescending() 


| Classes | Members                                                                                | Methods                                   | Scenario                    | Output  | 
|---------|----------------------------------------------------------------------------------------|-------------------------------------------|-----------------------------|---------|
| `User`  | `Dictionary<String, bool> todoList` (key is task name, value is completed/incompleted) | addTask(string task, bool status)         | Task is not in the list     | true    |
|         |																						   |									       | Task is already in the list | false   |
|         |																						   | listAllTasks()						       |                             | console |
|         |																						   | changeStatus(string task, bool newStatus) | Task is in the list		 | true    |
|         |																						   |										   | Task doesn't exist			 | false   | 
|		  |																						   | listAllCompletedTasks()				   |							 | console |
|		  |																						   | listAllIncompletedTasks()				   |							 | console |
|		  |																						   | searchTask(string task)				   | Task is in the list		 | true    |
|		  |																						   |										   | Task doesn't exist			 | false   |
|		  |																						   | removeTask(string task)				   | Task is in the list		 | true    |
|		  |																						   |										   | Task doesn't exist			 | false   |
|         |																						   | listAllTasksAscending()			       |                             | console |
|         |																						   | listAllTasksDescending() 			       |                             | console |