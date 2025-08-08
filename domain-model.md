# Core Requirements

| Classes     | Methods/Properties                                     | Scenario                                | Outputs                           
| ----------- | ------------------------------------------------------ | --------------------------------------- | --------------------------------- 
| Task.cs     | string Name                                            | Name the task                           | Task name                         
| Task.cs     | Guid Id                                                | Unique identifier for the task          | Task ID							 
| Task.cs     | bool IsComplete                                        | Track completion status                 | True or false                      				 
| Task.cs     | enum Priority                                          | Task priority Low, Medium, High         | Priority status of 3 possible levels                    
| Task.cs     | enum Category                                          | Task categories for differation		 | Category name                     
| TodoList.cs | AddTask(string name, enum priority, enum category)	   | Add task to the list                    | Task added to list                
| TodoList.cs | GetAllTasks()                                          | View all tasks                          | List of tasks                     
| TodoList.cs | GetCompletedTasks()                                    | View only completed tasks               | Filtered list of tasks            
| TodoList.cs | GetIncompleteTasks()                                   | View only incomplete tasks              | Filtered list of tasks            
| TodoList.cs | ChangeTaskStatus(Guid id, bool isComplete)             | Mark task complete/incomplete by ID     | Updated task status                      
| TodoList.cs | SearchTask(string name)                                | Search task by name                     | Task found or "Not Found" message 
| TodoList.cs | RemoveTask(Guid id)                                    | Remove task from list                   | Task removed by id                     
| TodoList.cs | GetTasksAscendingAZ()                                  | Get tasks sorted A-Z                    | Alphabetically sorted list        
| TodoList.cs | GetTasksDescendingAZ()                                 | Get tasks sorted Z-A                    | Alphabetically sorted list        
| TodoList.cs | GetTasksByPriority(string priority)                    | List tasks by selected priority         | List of tasks by priority                   

# Extension Requirements

| Classes     | Methods/Properties                         | Scenario                                 | Outputs       
| ----------- | ------------------------------------------ | ---------------------------------------- | ------------- 
| Task.cs	  | GetTaskById(int id)                        | Retrieve task by ID                      | Task with matching id  
| Task.cs     | UpdateTaskName(int id, string newName)	   | Update task name                         | Updated task name  
| Task.cs     | ChangeStatusById(int id, bool isComplete)  | Change task status using ID              | Updated task  
| Task.cs     | CreatedAt(DateTime )                       | Show creation time                       | DateTime of creation     
| Task.cs     | CompletedAt (DateTime)					   | Show completed time                      | DateTime of completion     
| ToDoList.cs | GetLongestCompletionTime()                 | Find task that took longest to complete  | Task with biggest difference in CreatedAt & CompletedAt         
| ToDoList.cs | GetShortestCompletionTime()                | Find task that took shortest to complete | Task with shortest difference in CreatedAt & CompletedAt          
| ToDoList.cs | GetTasksLongerThanDays(int days)           | List tasks completed after x days        | List of tasks where the time it took is longer than x days 
| ToDoList.cs | GetTasksByCategory(enum category)          | List all tasks by category               | List of tasks displayed by category
